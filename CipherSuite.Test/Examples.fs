namespace CipherSuite.Test

/// Examples from the 2022 National Cipher Challenge.
[<RequireQualifiedAccess>]
module Examples =

    [<Literal>]
    let challenge1A =
        """P DHZ OVWPUN P DVBSK MPUK FVB OLYL. DPAOVBA AOL VMMPJPHS ZBWWVYA VM IVZZ, PA PZ NVPUN AV IL OHYK AV AYHJR QVKPL KVDU HUK P HT NVPUN AV ULLK FVBY OLSW.

P ZAVSL AOL HAAHJOLK UVAL (UVA ZBYL AOLYL PZ H ILAALY DHF AV WBA AOHA NPCLU AOHA AOPZ VWLYHAPVU PZ ZAYPJASF VMM AOL IVVRZ) MYVT SFUU MYHUR'Z VMMPJL, HUK P AOPUR PA PZ MYVT QVKPL. AOL DVYK ULPNOIVBYOVVK ZBNNLZAZ PA DHZ DYPAALU IF H UHAPCL LUNSPZO ZWLHRLY YHAOLY AOHU HU HTLYPJHU, HUK PA PZ ZPNULK VMM JPMYHY HNHPU. P JHSSLK AOHA HU HSPIP ILMVYL, IBA THFIL UVT KL NBLYYL PZ TVYL HWWYVWYPHAL.

P ULLK APTL AV KLJPWOLY AOL YLWSF, IBA LCLU AOL WHWLY PA PZ DYPAALU VU PZ H JSBL. PA PZ AOL ZVYA FVB MPUK PU AOL MHUJF OVALSZ, ZV P DPSS ZAHYA SVVRPUN AOLYL. AOLF HYL UVA YLHSSF QVKPL'Z ZAFSL, IBA PM ZOL PZ MYLLSHUJPUN MVY IHURZ, ZOL DPSS DHUA AV NPCL AOL YPNOA PTWYLZZPVU. DOPJO NPCLZ TL HU PKLH. P AOPUR P DPSS AHRL H TBJO JSVZLY SVVR HA AOHA SLAALY.
"""

    [<Literal>]
    let challenge1B =
        """WXTK FL YKTGD,

BM PTL ZKXTM FXXMBGZ RHN TGW B TF IEXTLXW MH TVVXIM MAX VHGMKTVM MH BGOXLMBZTMX MAX LMKTGZX VBKVNFLMTGVXL TM VNEIXIXK VHNGMR UTGD.

TL WBLVNLLXW, B PBEE GXXW YNEE TVVXLL MH MAX UTGD MKTGLTVMBHG KXVHKWL, MAX VNKKXGM TGW KXVXGM LMTYY YBEXL, TGW TGR LNKOXBEETGVX YHHMTZX MATM RHN VTG IKHOBWX, XBMAXK YKHF MAX UTGD, MAX LMKXXML HNMLBWX HK YKHF GXBZAUHNKAHHW LMHKXL.

B XQTFBGXW MAX UHQ MATM RHN YHNGW HG MAX YEHHK HY MAX OTNEM TGW GXXW MH VHKKXVM RHN HG HGX MABGZ. BM PTL GHM XFIMR. MAX BGLBWX HY MAX EBW ATW T LAXXM HY OXEENF ITIXK EBZAMER YBQXW MH BM TGW PAXG B KXFHOXW MATM B YHNGW GBGX VABGXLX VATKTVMXKL BGLVKBUXW BG T LJNTKX ITMMXKG HG MAX KXOXKLX. B MKTVXW MAXF HGMH MAX TMMTVAXW VHOXK LAXXM TGW PHNEW UX ZKTMXYNE BY RHN VHNEW TLD MAX UTGD HYYBVBTEL PAXMAXK MAXR KXVHZGBLX MAXF. BM BL IHLLBUEX MATM MAX ITIXK PTL ZENXW BG PAXG MAX UHQ PTL FTWX, BM PTL VXKMTBGER BGMXGWXW MH EHHD EBDX MATM, UNM ZBOXG MAX TULXGVX HY TGR HMAXK VENXL TM MABL IHBGM B MABGD BM BL PHKMA VAXVDBGZ BY MABL VHNEW ATOX TGR LBZGBYBVTGVX.

RHN VTG VHGMTVM FX TM MAX KV; B PBEE UX FHOBGZ MAXKX MABL TYMXKGHHG TGW MAXR TKX XQIXVMBGZ T VTEE YKHF RHN MH TKKTGZX MAX XQIXGLXL YTVBEBMR MATM RHN HYYXKXW.

B EHHD YHKPTKW MH RHNK KXIER.

CTWX VBYKTK"""

    [<Literal>]
    let challenge2A =
        "K EWJWAQL NO NDWGQ PWLQ/POLKQ NO W ISKNQ WN W FKAF-GZWII FONQZ LOCJNOCJ. NFQ IODN OV TZWGQ OJZM W BWJU GOSZL WVVODL, WJL K GOSZLJ’N INWM NFQDQ EMIQZV, QXQJ KV K CWI OJ QHTQJIQI. K NFKJU KN COSZL FWXQ BQQJ NQETNKJA VWNQ WJMCWM. KV K GWJ VKJL POLKQ, K WE ISDQ IFQ GWJ VKJL EQ. IOEQNFKJA KJ FQD ZQNNQD NQZZI EQ IFQ WZDQWLM FWI. KJ WJM GWIQ, K LQGKLQL NO UQQT W ZOJA NWKZ OJ FQD, KV OJZM NO WXOKL ITOOUKJA WJMOJQ QZIQ CFO EKAFN BQ VOZZOCKJA FQD. K WE VOGSIKJA OJ KJNQDGQTNKJA FQD GOEEI CKNF ZMJJ VDWJU. NFQM WDQ INKZZ SIKJA VWKDZM ZKAFN QJGDMTNKOJ, WJL KN KI QWIKQD NO AQN WGGQII NO EI VDWJU’I OVVKGQ NFWJ KN COSZL BQ NO KJVKZNDWNQ POLKQ’I DOOE WN NFQ FONQZ. NFOIQ TZWGQI NWUQ NFQ IQGSDKNM OV NFQKD GZKQJNI QXQJ EODQ IQDKOSIZM NFWJ NFQ BWJUI. NFQ WNNWGFQL ZQNNQD IFOCI NFWN POLKQ KI AQNNKJA EODQ GWSNKOSI, BSN KN WZIO IQQEI NO BQ WJ KJXKNWNKOJ NO AQN KJXOZXQL. K WE JON ISDQ CFQDQ NO AO VDOE FQDQ. WI POLKQ IWMI KJ NFQ ZQNNQD, NFQ JSEBQDI KJ NFQ IKAJ-KJ BOOU ISAAQIN IOEQNFKJA OLL, BSN SJZKUQ POLKQ K COJ’N FWXQ WGGQII NO NFQ XWSZN NO GFQGU KN. KI IFQ FKJNKJA NFWN CQ IFOSZL NQWE ST, OD CWDJKJA EQ NFWN IFQ UJOCI K WE FQDQ WJL IFOSZL UQQT WCWM? (KV MOS WDQ JON ISDQ CFWN K WE NWZUKJA WBOSN, NWUQ W XQDM GWDQVSZ ZOOU WN MOSD LQGDMTN OV FQD ZQNNQD. MOS IFOSZL VKJL W FKLLQJ EQIIWAQ.) BM NFQ CWM, NFQDQ KI IOEQNFKJA JWAAKJA WN EQ NFWN K GWJ’N YSKNQ TZWGQ. NFQDQ KI W JWEQ KJ NFQ IKAJ-KJ BOOU NFWN, KJ EM FQWL WN ZQWIN, KI GOJJQGNQL KJ IOEQ CWM NO NFQ JWEQ OV NFQ BWJU, WJL K GWJ’N DQEQEBQD CFWN NFWN GOJJQGNKOJ KI. EWMBQ KN KI JON KETODNWJN, BSN K COJ’N IZQQT TDOTQDZM SJNKZ K GWJ VKASDQ KN OSN. OJGQ MOS FWXQ GDWGUQL POLKQ’I ZQNNQD, FQWL OXQD NO NFQ GWIQ VKZQI WJL NWUQ W ZOOU WN NFQ IKAJWNSDQI. EWMBQ MOS GWJ VKASDQ KN OSN VOD EQ. FWDDM"

    [<Literal>]
    let challenge2B =
        """GPFC JL YCFSR,

QBKP NBD QFG F HBBG VPPRPSG. UQFSR NBD YBC UQP LFYPUN GPKBLZU OBE FXXPLL CPXBCGL NBD LPSU, UQBDHQ XFS Z LDHHPLU UQFU ZS UQP YDUDCP VP DLP F QZHQPC APMPA BY LPXDCZUN? PMPS YFZCAN ZSPEKPCZPSXPG XCZJZSFAL XFS OP YFJZAZFC VZUQ UQPLP XZKQPCL, FSG VP GBS’U RSBV VQB JZHQU OP JBSZUBCZSH NBDC XBJJDSZXFUZBS XQFSSPAL.

FL KCBJZLPG, Z PEFJZSPG UQP MFDAU CPXBCGL ZS GPUFZA, FSG UQPN GB UPAA F LUBCN, UQBDHQ Z FJ SBU LDCP VQFU ZU JPFSL. UQPCP ZL F KFUUPCS ZS UQP SDJOPCL UQFU ZL MPCN LDHHPLUZMP FSG ZY NBD XFS PEKPGZUP JN CPTDPLU UB LKPSG LBJP UZJP FABSP ZS UQP MFDAU UQPS Z QBKP UB OP FOAP UB ZSMPLUZHFUP UQFU YDCUQPC.

CP-PEFJZSZSH UQP MFDAU XFJPCF YBBUFHP UQFU NBD LPSU, Z VFL LDCKCZLPG UB LPP UQFU XDAKPKPC QFL SB FXUDFA YBBUFHP BY UQP ABOON BC MFDAU ZULPAY. NBDC LPXDCZUN UPFJ PEKAFZSPG UQFU UQZL ZL F KCZMFXN KBAZXN UB PSLDCP XAZPSU XBSYZGPSUZFAZUN. ZU FALB LPPJL UB OP UQP XFLP UQFU VQZAP XDLUBJPCL LZHS ZS FSG BDU BY UQP MFDAU, OFSR LUFYY FCP SBU CPTDZCPG UB GB LB. UQPN UBAG JP UQFU LUFYY GB SBU ZS HPSPCFA PSUPC UQP ZSSPC XQFJOPC, FSG UQFU SB-BSP LQBDAG PSUPC UQP ABOON DSFXXBJKFSZPG VQZAP UQP MFDAU ZL DSABXRPG. UQP LUFYY LFN UQFU UQZL KCBUBXBA ZL UFRPS MPCN LPCZBDLAN; ZU ZL F LFXRFOAP BYYPSLP UB PSUPC UQP ABOON FABSP. UQPCP ZL BSP PEXPKUZBS. ZS BCGPC UB PSLDCP UQP LPXDCZUN BY UQP XBJOZSFUZBS UQFU BKPSL UQP MFDAU ZULPAY, UQP XQZPY UPAAPC PSUPCL UQP ABOON FABSP ZS UQP JBCSZSH UB BKPS DK. UQP QPFG BY LPXDCZUN VFZUL BDULZGP, UQPS XBSGDXUL F LPFCXQ BY UQP UPAAPC VQPS UQPN APFMP UQP MFDAU UB PSLDCP UQFU SBUQZSH QFL OPPS CPJBMPG. UQP YBBUFHP LQBVL UQP KFU GBVS ZS KCBHCPLL UQFU GFN, LB Z UQZSR ZU ZL YFZC UB GPGDXP UQFU ZY UQP UPAAPC QFG CPJBMPG FSNUQZSH YCBJ UQP LFYP UQPS ZU VBDAG QFMP OPPS GZLXBMPCPG FU UQP UZJP. UQFU JPFSL UQFU ZY FSNUQZSH VFL UFRPS YCBJ UQP OBE, UQPS ZU QFG FACPFGN OPPS CPJBMPG VQPS UQP UPAAPC FSG UQP LPXDCZUN HDFCG FCCZMPG.

CPHFCGZSH UQP KFKPC AZSZSH ZS UQP GPKBLZU OBE AZG: Z FLRPG UQP OFSR LUFYY FOBDU ZU FSG UQP XQZPY UPAAPC, VQB ZL F JFSGFCZS LKPFRPC, CPXBHSZLPG UQP XQFCFXUPCL FL UQP GZHZUL WPCB FSG BSP. LQP LDHHPLUPG UQFU UQP UQCPP AZSPL XBDAG GPSBUP UQP SDJOPCL YZMP, YBDC, UQCPP ZS OZSFCN, UQBDHQ BUQPC CPFGZSHL FCP KBLLZOAP. ZY UQPN VPCP VCZUUPS XAFLLZXFAAN, YBC PEFJKAP UB OP CPFG MPCUZXFAAN CZHQU UB APYU, UQPS UQPN XBDAG GPSBUP LZE, BSP, YZMP. Z VBSGPCPG ZY UQZL CPYPCCPG UB UQP OBE SDJOPC, FL UQPCP FCP LPMPS QDSGCPG FSG LZEUN-UQCPP OBEPL ZS UQP MFDAU, ODU UQP OBE ZULPAY VFL FKKFCPSUAN UFRPS YCBJ XFLLPUUP UVPSUN-UQCPP, LB DSAPLL ZU QFL OPPS KDU OFXR ZS UQP VCBSH KAFXP LBJP UZJP UQPS Z GBS’U UQZSR UQFU XFS OP ZU. KPCQFKL LBJPBSP FU UQP OFSR JZHQU QFMP FS ZGPF. APU JP RSBV VQPS NBD QFMP FCCFSHPG UQP MFDAU FXXPLL YBC JP.

NBDCL LZSXPCPAN,

IFGP XZYCFC"""

    [<Literal>]
    let challenge3A =
        "RWLQM QAUIS QVOBP QADMZ GMIAG NWZUM PMZZM KMVBK IAMVW BMAEM ZMTMN BWVIV MVKZG XBMLC AJSMG IBBIK PMLBW PMZSM GKPIQ VQPIL BISMV BPMAC QBMWX XWAQB MIVLZ MDMZA MLBPM AXGPW TMQVU GLWWZ AWQKW CTLEI BKPPM ZUWDM UMVBA QBPWC OPBQP ILJMM VKIZM NCTJC BQAEM IZBPI BAPMO TIVKM LWDMZ IBUMI AAPMT WKSML BPMLW WZBWP MZZWW UBPMV APMEI TSMLI EIGLW EVBPM KWZZQ LWZTM IDQVO BPMSM GAQVB PMTWK SQEWV LMZML QNQAP WCTLK ITTWC BBWPM ZJCBX MZPIX AAPME IAKPM KSQVO BPIBQ EIAVW BBPMZ MJMNW ZMTMI DQVOB PMSMG AZIBP MZBPI VBZGQ VOBWU ISMAC ZMQEI ACVBQ TQKIV JMKMZ BIQVB PIBAP MQAZM IKPQV OWCBQ EQTTP IDMBW JMLQA KZMMB BPMMV KZGXB QWVWV BPMCA JQAMI AGBWJ ZMISC AQVOI AQUXT MSMGE WZLAC JABQB CBQWV QBKWV BIQVA RCABW VMNQT MEQBP VWBMA WVPMZ QVDMA BQOIB QWVIV LAPMP IAKPI VVMTT MLPMZ QVVMZ APMZT WKSMT QUQVI BQVOB PMQUX WAAQJ TMBWI ZZQDM IBBPM WVTGT WOQKI TKWVK TCAQW VQVAP WZBAW UMWVM PIAIA MKZMB IVLAW UMWVM MTAMB PMKPQ MNBMT TMZEI VBABW SVWEE PIBQB QABPM GBPQV SRWLQ MKIVI AAQAB IVLUI GJMRW LQMQA BZGQV OBWBM TTUMI JWCBQ BQLWV BSVWE QNBPI BQAJM KICAM APMBP QVSAA PMVMM LAUGP MTXQI UXZMB BGACZ MAPML WMAVB WZQNA PMBPQ VSAQV MMLBW SVWEI JWCBQ BJCBC VBQTE MKIVN QVLIE IGBWZ MMABI JTQAP BZCAB QBQAO WQVOB WJMLQ NNQKC TBBWN QVLWC BEPQK P"

    [<Literal>]
    let challenge3B =
        """ZBGOF BZ GQO RZIOFGRPWGRBZ
GQO TQRON GOXXOE OZGOEOS GQO IWHXG WTTBYCWZROS AL GQO QOWS BN FOTHERGL GQO ZRPQG AONBEO GQO RZTRSOZG GB TQOTV GQWG GQO SOCBFRG ABKOF JOEO FOTHEO WZS GB XBTV GQO IWHXG SBBE. WXX JWF RZ BESOE WG GQWG FGWPO.

GQO FOTHERGL NBBGWPO FQBJF GQWG ZB-BZO WZS ZBGQRZP XONG GQO IWHXG BIOEZRPQG. GQO TWYOEWF JOEO YBZRGBEOS XRIO NEBY W EOYBGO XBTWGRBZ, WZS R QWIO EOIROJOS GQO NBBGWPO YLFOXN.

WNGOE GQO GOXXOE XONG GQO IWHXG GB EWRFO GQO WXWEY, FQO WZS GQO FOTHERGL PHWES JOEO BZ TWYOEW HZGRX WSSRGRBZWX FOTHERGL WEERIOS WZS ZORGQOE BN GQOY QWS WZLGQRZP RZ GQORE CBFFOFFRBZ GQWG GQOL TBHXS ZBG WTTBHZG NBE.

GQO SOCBFRG ABKOF WEO WXX OYCGL, OKTOCG GQWG GQOL OWTQ TBZGWRZ W CWCOE XRZRZP RZ GQO XRS YWEVOS JRGQ ZRZO TQRZOFO TQWEWTGOEF EOCEOFOZGRZP GQO SRPRGF BZO WZS MOEB, FBYO JRGQ GQO PERS RZFRSO WZ BHGXRZO WZS FBYO JRGQBHG. GQO YWEVRZPF WEO HZRDHO GB OWTQ ABK.

TBZTXHFRBZ: GQO AWZV IWHXG JWF FOTHEO HZGRX BCOZOS RZ GQO YBEZRZP WZS ZBGQRZP JWF EOYBIOS RZ GQWG COERBS, FB JO TWZ EHXO BHG GQONG WF W YBGRIO NBE GQO AEOWV RZ. GQO BZXL COEFBZ JQB TBHXS QWIO SRFGHEAOS GQO IWHXG TBZGOZGF JWF GQO TQRON GOXXOE, AHG FQO ZBG BZXL NWRXOS GB TBZTOWX GQO SRFGHEAWZTO, FQO WXFB ZBGRNROS FOTHERGL WABHG RG. TXOWEXL, FQO JWZGOS WZ RZIOFGRPWGRBZ, AHG SRS ZBG JWZG GQO CBXRTO RZIBXIOS. R JWF AEBHPQG RZ WG PEOWG OKCOZFO OIOZ GQBHPQ THXCOCOE WXEOWSL OYCXBLF RGF BJZ FOTHERGL WZS RZIOFGRPWGRBZ GOWY JQRTQ QWF YWZL BN GQO FWYO FVRXXF WF R SB. GQOEO RF COEQWCF UHFG BZO GQRZP R TWZ SB AOGGOE GQWZ GQOY WZS GQWG RF GB AEOWV TBSOF WZS TRCQOEF. YWLAO GQWG RF JQL R WY QOEO. R AOXROIO GQWG GQO TQRON GOXXOE SOXRAOEWGOXL FGWPOS GQO AEOWV RZ GB QBBV YO, FB R TBHXS SRFTBIOE WZS AEOWV W TBSO QRSSOZ RZ GQO IWHXG. JQWG R SBZ’G LOG VZBJ RF, JQL?

R SBZ’G GEHFG GQO TQRON GOXXOE, GQBHPQ R SBZ’G VZBJ JQWG FQO RF HC GB, WZS R WY ZBG FHEO GQWG R TWZ GEHFG XLZZ NEWZV, AHG WFFHYRZP GQWG R WY ERPQG GQOL ZOOS YO YBEO GQWZ R ZOOS GQOY, FB R FQBHXS AO FWNO NBE ZBJ JQRXO R NBTHF BZ GQO THXCOCOE TBSO."""
