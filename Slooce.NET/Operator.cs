using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Slooce.NET
{
    
    [Serializable]
    public enum Operator
    {
        [XmlEnum("0")]
        Unknown = 0,
        [XmlEnum("6")]
        ACSWireless = 6,
        [XmlEnum("16")]
        Alltel = 16,
        [XmlEnum("17")]
        AllWestWireless = 17,
        [XmlEnum("22")]
        AppalachianWireless = 22,
        [XmlEnum("25")]
        ATT = 25,
        [XmlEnum("26")]
        BellMobility = 26,
        [XmlEnum("28")]
        Bandwidth = 28,
        [XmlEnum("29")]
        BluegrassCellular = 29,
        [XmlEnum("30")]
        BoostMobileCDMA = 30,
        [XmlEnum("31")]
        BoostMobileiDEN = 31,
        [XmlEnum("35")]
        CarolinaWest = 35,
        [XmlEnum("38")]
        Cellcom = 38,
        [XmlEnum("42")]
        CellularOneOfNEArizona = 42,
        [XmlEnum("46")]
        CSpire = 46,
        [XmlEnum("49")]
        USCharitonValleyCellular = 49,
        [XmlEnum("50")]
        ChatMobility = 50,
        [XmlEnum("62")]
        CopperValley = 62,
        [XmlEnum("67")]
        Cricket = 67,
        [XmlEnum("69")]
        CTCUS = 69,
        [XmlEnum("73")]
        Dobson = 73,
        [XmlEnum("76")]
        CellularOneEastCentralIllinois = 76,
        [XmlEnum("79")]
        PioneerCellular = 79,
        [XmlEnum("80")]
        EpicTouchCo = 80,
        [XmlEnum("82")]
        FarmersMutualTelephoneCo = 82,
        [XmlEnum("83")]
        FidoWireless = 83,
        [XmlEnum("87")]
        FlatWireless = 87,
        [XmlEnum("88")]
        GCIWireless = 88,
        [XmlEnum("91")]
        GoldenState = 91,
        [XmlEnum("99")]
        Helio = 99,
        [XmlEnum("103")]
        IllinoisValleyCellular = 103,
        [XmlEnum("106")]
        ImmixWireless = 106,
        [XmlEnum("107")]
        InlandCellular = 107,
        [XmlEnum("108")]
        Iwireless = 108,
        [XmlEnum("111")]
        Leaco = 111,
        [XmlEnum("131")]
        MTAWireless = 131,
        [XmlEnum("140")]
        NexTechWireless = 140,
        [XmlEnum("141")]
        Nextel = 141,
        [XmlEnum("142")]
        NNTCWireless = 142,
        [XmlEnum("146")]
        NorthwestMissouriCellular = 146,
        [XmlEnum("148")]
        nTelos = 148,
        [XmlEnum("155")]
        PanhandleWireless = 155,
        [XmlEnum("158")]
        PeoplesWireless = 158,
        [XmlEnum("160")]
        PineCellular = 160,
        [XmlEnum("164")]
        PlateauWireless = 164,
        [XmlEnum("165")]
        Pocket = 165,
        [XmlEnum("171")]
        RevolWireless = 171,
        [XmlEnum("172")]
        RogersWireless = 172,
        [XmlEnum("176")]
        RuralCellular = 176,
        [XmlEnum("180")]
        SaskTel = 180,
        [XmlEnum("187")]
        SouthernLINC = 187,
        [XmlEnum("189")]
        Sprint = 189,
        [XmlEnum("191")]
        SRTCommunications = 191,
        [XmlEnum("195")]
        SyringaWireless = 195,
        [XmlEnum("199")]
        TELUS = 199,
        [XmlEnum("201")]
        ThumbCellular = 201,
        [XmlEnum("205")]
        TMobile = 205,
        [XmlEnum("208")]
        TmpSimmetry = 208,
        [XmlEnum("209")]
        TracFone = 209,
        [XmlEnum("212")]
        UnionWireless = 212,
        [XmlEnum("213")]
        UnitedWireless = 213,
        [XmlEnum("214")]
        USCellular = 214,
        [XmlEnum("217")]
        VerizonWireless = 217,
        [XmlEnum("218")]
        Videotron = 218,
        [XmlEnum("222")]
        VirginMobileCanada = 222,
        [XmlEnum("223")]
        VirginMobileUSA = 223,
        [XmlEnum("226")]
        ClaroPuertoRico = 226,
        [XmlEnum("228")]
        WestCentralWireless = 228,
        [XmlEnum("236")]
        ViaeroWireless = 236,
        [XmlEnum("238")]
        DuetWireless = 238,
        [XmlEnum("239")]
        ElementMobile = 239,
        [XmlEnum("241")]
        MobiPCS = 241,
        [XmlEnum("242")]
        MobileNation = 242,
        [XmlEnum("243")]
        MosaicTelecom = 243,
        [XmlEnum("244")]
        CellularOneofMontana = 244,
        [XmlEnum("247")]
        DTCWireless = 247,
        [XmlEnum("248")]
        CricketGSM = 248,
        [XmlEnum("249")]
        GoogleVoice = 249,
        [XmlEnum("250")]
        BreakawayWireless = 250,
        [XmlEnum("251")]
        SnakeRiverPCS = 251,
        [XmlEnum("252")]
        SprocketWireless = 252,
        [XmlEnum("253")]
        StrataNetworks = 253,
        [XmlEnum("254")]
        OpenMobilePuertoRico = 254,
        [XmlEnum("255")]
        CellularOneofNEPA = 255,
        [XmlEnum("256")]
        Cablevision = 256,
        [XmlEnum("257")]
        CenturyTelWireless = 257,
        [XmlEnum("258")]
        EinsteinWireless = 258,
        [XmlEnum("259")]
        IceWireless = 259,
        [XmlEnum("260")]
        Kajeet = 260,
        [XmlEnum("261")]
        Mobilicity = 261,
        [XmlEnum("262")]
        MTSMobility = 262,
        [XmlEnum("263")]
        SilverStarPCS = 263,
        [XmlEnum("264")]
        Sogetel = 264,
        [XmlEnum("265")]
        Tbaytel = 265,
        [XmlEnum("266")]
        Unicel = 266,
        [XmlEnum("267")]
        WindMobile = 267,
        [XmlEnum("268")]
        LynxMobility = 268,
        [XmlEnum("269")]
        Eastlink = 269,
        [XmlEnum("270")]
        SagebrushCellular = 270,
        [XmlEnum("271")]
        PeerlessWireless = 271,
        [XmlEnum("272")]
        MastMobile = 272,
        [XmlEnum("273")]
        Truphone = 273,
        [XmlEnum("274")]
        CableandCellularCommunications = 274,
        [XmlEnum("275")]
        Enflick = 275,
        [XmlEnum("276")]
        ASTAC = 276,
        [XmlEnum("277")]
        ATTPuertoRico = 277,
        [XmlEnum("278")]
        ATTUSVirginIslands = 278,
        [XmlEnum("279")]
        BrightlinkCommunications = 279,
        [XmlEnum("280")]
        LayeredCommunications = 280,
        [XmlEnum("281")]
        SprintPuertoRico = 281,
        [XmlEnum("282")]
        SprintUSVirginIslands = 282,
        [XmlEnum("283")]
        TriangleCommunicationSystem = 283,
        [XmlEnum("284")]
        TMobilePuertoRico = 284,
        [XmlEnum("285")]
        CordovaWireless = 285,
        [XmlEnum("286")]
        Inteliquent = 286,
    }
}
