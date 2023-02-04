namespace CipherSuite

#if DEBUG
#else
#nowarn "9"
#endif

open Microsoft.FSharp.NativeInterop

[<Struct>]
#if DEBUG
type Arr4D<'a> =
    {
        Elements : 'a array
        Width : int
        WidthTimesHeight : int
        WidthTimesHeightTimesDepth : int
    }

    member this.Depth = this.Elements.Length / this.WidthTimesHeightTimesDepth
#else
type Arr4D<'a when 'a : unmanaged> =
    {
        Elements : nativeptr<'a>
        Length : int
        Width : int
        WidthTimesHeight : int
        WidthTimesHeightTimesDepth : int
    }

    member this.Depth = this.Length / this.WidthTimesHeightTimesDepth
#endif

[<RequireQualifiedAccess>]
module Arr4D =

    /// It's faster to iterate forward over the first argument, `x`, and then the
    /// second argument, `y`, and then the third argument, `z`.
    let inline get (arr : Arr4D<'a>) (x : int) (y : int) (z : int) (i : int) : 'a =
#if DEBUG
        arr.Elements.[i * arr.WidthTimesHeightTimesDepth
                      + z * arr.WidthTimesHeight
                      + y * arr.Width
                      + x]
#else
        NativePtr.get
            arr.Elements
            (i * arr.WidthTimesHeightTimesDepth
             + z * arr.WidthTimesHeight
             + y * arr.Width
             + x)
#endif

    let inline set (arr : Arr4D<'a>) (x : int) (y : int) (z : int) (i : int) (newVal : 'a) : unit =
#if DEBUG
        arr.Elements.[i * arr.WidthTimesHeightTimesDepth
                      + z * arr.WidthTimesHeight
                      + y * arr.Width
                      + x] <- newVal
#else
        NativePtr.write
            (NativePtr.add
                arr.Elements
                (i * arr.WidthTimesHeightTimesDepth
                 + z * arr.WidthTimesHeight
                 + y * arr.Width
                 + x))
            newVal
#endif

#if DEBUG
    /// In lieu of a meaningful name for the ana-kata axis, I am just going to call it katana.
    let create (width : int) (height : int) (depth : int) (katana : int) (value : 'a) : Arr4D<'a> =
        let arr = Array.create (width * height * depth * katana) value

        {
            Width = width
            WidthTimesHeight = width * height
            WidthTimesHeightTimesDepth = width * height * depth
            Elements = arr
        }
#else
    /// In lieu of a meaningful name for the ana-kata axis, I am just going to call it katana.
    /// The input array must be at least of size width * height * depth * katana.
    let create
        (arr : nativeptr<'a>)
        (width : int)
        (height : int)
        (depth : int)
        (katana : int)
        (value : 'a)
        : Arr4D<'a>
        =
        {
            Width = width
            Elements = arr
            Length = width * height * depth * katana
            WidthTimesHeight = width * height
            WidthTimesHeightTimesDepth = width * height * depth
        }
#endif

    [<RequiresExplicitTypeArguments>]
#if DEBUG
    let zeroCreate<'a when 'a : unmanaged> (width : int) (height : int) (depth : int) (katana : int) : Arr4D<'a> =
        {
            Elements = Array.zeroCreate (width * height * depth * katana)
            Width = width
            WidthTimesHeight = width * height
            WidthTimesHeightTimesDepth = width * height * depth
        }
#else
    let zeroCreate<'a when 'a : unmanaged>
        (elts : nativeptr<'a>)
        (width : int)
        (height : int)
        (depth : int)
        (katana : int)
        : Arr4D<'a>
        =
        {
            Elements = elts
            Width = width
            WidthTimesHeight = width * height
            WidthTimesHeightTimesDepth = width * height * depth
            Length = width * height * depth * katana
        }
#endif

    let inline clear (a : Arr4D<'a>) : unit =
#if DEBUG
        System.Array.Clear a.Elements
#else
        NativePtr.initBlock a.Elements 0uy (uint32 sizeof<'a> * uint32 a.Length)
#endif
