using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace modbusLB
{
    public static class DeviceClass
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct Union16
        {
            [FieldOffset(0)]
            public Int16 Value;
            [NonSerialized]
            [FieldOffset(0)]
            public UInt16 UValue;
            [FieldOffset(0)]
            public byte Byte0;
            [FieldOffset(1)]
            public byte Byte1;
            public bool isBitSet(byte index)
            {
                if (index >= 15)
                    return false;
                return (Value & (1L << index)) != 0;
            }
            [System.Xml.Serialization.XmlIgnore]
            public byte[] ToArray => new byte[]
            {
            Byte0,
            Byte1
            };
        }

        public static string GetNameOfEnum(this Enum enumVal)
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            try
            {
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                return (attributes.Length > 0) ? ((DescriptionAttribute)attributes[0]).Description : "";
            }
            catch
            {
                return Convert.ToInt16(enumVal).ToString("X4");
            }

        }

        [Description("Тип данных - Тип подустройства")]
        public enum LBClassType
        {
            [Description("Загрузчик")]
            te6Load = 0,        // Загрузчик.
            [Description("Могилевлифтмаш (УУЛ)")]
            te6Mog = 1,     // Могилевлифтмаш (УУЛ)
            [Description("МЭЛ (СУЛ1)")]
            te6MEL = 2,     // МЭЛ (СУЛ1)
            [Description("МППЛ (НПО «Вектор»)")]
            te6MPPL = 3,        // МППЛ (НПО «Вектор»)
            [Description("ОТИС")]
            te6Otis = 4,        // ОТИС
            [Description("ШУЛК17")]
            te6S17 = 5,     // ШУЛК17
            [Description("ШУЛК32")]
            te6S32 = 6,     // ШУЛК32
            [Description("УКЛ/УЛ")]
            te6UCL = 7,     // УКЛ/УЛ
            [Description("Релейный лифт")]
            te6Rele = 8,        // Релейный лифт. 
            [Description("SODIMAS")]
            te6Sodi = 9,        // SODIMAS
            [Description("LG DI")]
            te6LGDI = 10,       // LG_DI
            [Description("LG DSS")]
            te6LGDSS = 11,      // LG_DSS
            [Description("эскалатор")]
            teEscal = 12,       // эскалатор
            [Description("AXEL")]
            te6AXEL = 13,       // AXEL
            [Description("ELEX")]
            te6ELEX = 14,       // ELEX
            [Description("СПУЛ")]
            te6SPUL = 15,       // СПУЛ
            [Description("THYSSEN")]
            te6THYSSEN = 16,        // THYSSEN
            [Description("ОЛИМП")]
            te6OLIMP = 17,      // ОЛИМП
            [Description("Doppler")]
            te6Doppler = 18,        // Doppler
            [Description("THYSSEN (LS3)")]
            te6THYSSEN3 = 19,       // THYSSEN (LS3)
            [Description("EXPRESS")]
            te6EXPRESS = 20,        // EXPRESS
            [Description("BLT")]
            te6BLT = 21,        // BLT
            [Description("THYSSEN (TAC50)")]
            te6THYS_50 = 22,        // THYSSEN (TAC50)
            [Description("LISA (KLEEMANN)")]
            te6LISA = 23,       // LISA (KLEEMANN)
            [Description("Schindler")]
            te6Schind = 24,     // Schindler
            [Description("PLK (программируемые логические контроллеры)")]
            te6PLK = 25,        // PLK (программируемые логические контроллеры)
            [Description("УЭЛР")]
            te6UELR = 26,       // УЭЛР
            [Description("THYSSEN (MCI)")]
            te6THYSMCI = 27,        // THYSSEN (MCI)
            [Description("ORONA")]
            te6ORONA = 28,      // ORONA
            [Description("ARKEL")]
            te6ARKEL = 29,      // ARKEL 
            [Description("BG15")]
            te6BG15 = 30,       // BG15
            [Description("МППЛ (НПО «Вектор») версия 2")]
            te6MPPL2 = 31,      // МППЛ (НПО «Вектор») версия 2           
            [Description("VEGA")]
            te6VEGA = 32,       // VEGA            
            [Description("Sodimas QI")]
            te6SodQI = 33,      // Sodimas QI           
            [Description("ТР")]
            te6TR = 34,     // ТР            
            [Description("DMG")]
            te6DMG = 35,        // DMG           
            [Description("MIK_EL")]
            te6MIK_EL = 36,     // MIK_EL            
            [Description("KONE")]
            te6KONE = 37,       // KONE           
            [Description("S9")]
            te6S9 = 38,     // S9           
            [Description("HYUNDAI")]
            te6HYUNDAI = 39,        // HYUNDAI            
            [Description("NICE")]
            te6NICE = 40,       // NICE            
            [Description("VASSLER")]
            te6VASSLER = 41,        // VASSLER            
            [Description("FST2")]
            te6FST2 = 42,       // FST2            
            [Description("CANNY")]
            te6CANNY = 43,      // CANNY
            [Description("SILVER")]
            te6SILVER = 44,     // SILVER            
            [Description("ИНВАЛИДНЫЙ")]
            te6Invalid = 45,        // ИНВАЛИДНЫЙ            
            [Description("BETACONTROL")]
            te6BETACTRL = 46,       // BETACONTROL            
            [Description("StaGeHELLAS")]
            te6StaGeHEL = 47,       // StaGeHELLAS
            [Description("ШК6000")]
            te6SK6000 = 48,     // ШК6000
            [Description("ТКЛ")]
            te6TKL = 49,        // ТКЛ
            [Description("СУЛ2010")]
            te6SUL2010 = 50,        // СУЛ2010
            [Description("Союз")]
            te6Union = 51,      // Союз
            [Description("ШЛ-Р")]
            te6SH_R = 52,       // ШЛ-Р
            [Description("FT9X0")]
            te6FT9X0 = 53,      // FT9X0
            [Description("LLC")]
            te6LLC = 54,        // LLC
            [Description("KOLLMORGEN")]
            te6KOLLMORGEN = 55,     // KOLLMORGEN
            [Description("SECURLIFT")]
            te6SECURLIFT = 56,      // SECURLIFT
            [Description("IMEM")]
            te6IMEM = 57,       // IMEM
            [Description("WIPO")]
            te6WIPO = 58,       // WIPO
            [Description("KLST (VESTNER)")]
            te6VESTNER = 59,        // KLST (VESTNER)
            [Description("CARLOS SILVA")]
            te6CARLOS_SILVA = 60,   // CARLOS SILVA
            [Description("KOYO")]
            te6KOYO = 61,       // KOYO
            [Description("BL6")]
            te6BL6 = 62,        // BL6
            [Description("WEBER")]
            te6WEBER = 63,      // WEBER
            [Description("iAStar")]
            te6iAStar = 64,     // iAStar
            [Description("GTE")]
            te6GTE = 65,        // GTE
            [Description("AUTINOR")]
            te6AUTINOR = 66,        // AUTINOR
            [Description("THYSCMC")]
            te6THYSCMC = 67,        // THYSCMC
            [Description("DAESUNG")]
            te6DAESUNG = 68,        // DAESUNG
            [Description("AS380")]
            te6AS380 = 69,      // AS380
            [Description("ECL1")]
            te6ECL1 = 70,       // ECL1
            [Description("ECLIPSE")]
            te6ECLIPSE = 71,        // ECLIPSE
            [Description("SKG")]
            te6SKG = 72,        // SKG
            [Description("ML65X")]
            te6ML65X = 73,      // ML65X
            [Description("ML60X")]
            te6ML60X = 74,      // ML60X
            [Description("PDAHL")]
            te6PDAHL = 75,      // PDAHL
            [Description("УЛЖМ")]
            te6ULGM = 76,       // УЛЖМ
            [Description("ISLv4")]
            te6ISLv4 = 77,      // ISLv4
            [Description("ML50")]
            te6ML50 = 78,       // ML50
            [Description("ViaSerie")]
            teViaSerie = 79,        // ViaSerie
            [Description("MASHIBA")]
            te6MASHIBA = 80,        // MASHIBA
            [Description("HYUNDAI_CAN")]
            te6HYUN_CAN = 81,       // HYUNDAI_CAN
            [Description("BST (B08 China)")]
            te6BST = 82,        // BST (B08 China)
            [Description("KST (NewLift Germany)")]
            te6KST = 83,        // KST (NewLift Germany)
            [Description("MITSUBISHI")]
            te6MITSUBI = 84,        // MITSUBISHI
            [Description("АСУД Концентратор")]
            te6ASUD = 85,       // АСУД Концентратор
            [Description("Hidral")]
            te6Hidral = 86,     // Hidral
            [Description("Smart controller")]
            te6Smart = 87,      // Smart controller
            [Description("EASY TRONIC")]
            te6EASY = 88,       // EASY TRONIC
            [Description("GILAN")]
            te6GILAN = 89,      // GILAN
            [Description("INVT")]
            te6INVT = 90,       // INVT
            [Description("SUMEL")]
            te6SUMEL = 91,      // SUMEL
            [Description("GMV")]
            te6GMV = 92,        // GMV
            [Description("МЛК")]
            te6MLK = 93,        // МЛК
            [Description("TRAVIS")]
            te6TRAVIS = 94,     // TRAVIS
            [Description("УКЛ-40Р (Распределенная станция МПУ-2)")]
            te6UKL40R = 95,     // УКЛ-40Р (Распределенная станция МПУ-2)
            [Description("DIGILIFT (Gruppomillepiani)")]
            te6DIGILIFT = 97,    // DIGILIFT (Gruppomillepiani)
            [Description("KONE_ESC(EMB - 501)")]
            teKoneEsc = 98,    // KONE_ESC(EMB - 501)
            [Description("KRONA")]
            teKrona = 99,    // KRONA
            [Description("ELMI")]
            teElmi = 100,    //ELMI
            [Description("HD ONE(Hedefsan)")]
            tehdOne = 101,    // HD ONE(Hedefsan)
            [Description("SODIMAS QI TOUCH(CAN)")]
            teSodimasQiTouch = 102,    // SODIMAS QI TOUCH(CAN)           
            [Description("MASHIBA MS68")]
            teMashibaMs68 = 103,    // MASHIBA MS68            
            [Description("BP306")]
            teBp306 = 104,    // BP306           
            [Description("NP1(HISSTEMA)")]
            te6Np1 = 105,    // NP1(HISSTEMA)            
            [Description("HIDRA CRONO(Carlos Silva)")]
            teHidraCrono = 106,    //HIDRA CRONO(Carlos Silva)            
            [Description("MC3000")]
            teMc3000 = 107,    // MC3000            
            [Description("MLC01")]
            teMlc01 = 108,    // MLC01            
            [Description("THYSSEN GEC")]
            teThyssenGec = 109,    // THYSSEN GEC           
            [Description("K-TYPE(Mitsubishi ЭСК)")]
            teKType = 110,      // K-TYPE(Mitsubishi ЭСК)    
            [Description("GPS(Mitsubishi)")]
            teGPS = 111,         
            [Description("BR100 (MOVILIFT)")]
            teBR100 = 112,           
            [Description("MODEUN")]
            teMODEUN = 113,           
            [Description("GUANGRI")]
            teGUANGRI = 114,           
            [Description("KONE KCE")]
            teKONEKCE = 115,           
            [Description("IFE")]
            teIFE = 116,           
            [Description("EAGLE (IGV)")]
            teEAGLE = 117,           
            [Description("RODOS (UKR)")]
            teRODOS = 118,           
            [Description("SISTEL")]
            teSISTEL = 119,            
            [Description("CIBES A5")]
            teCIBES = 120,          
            [Description("121")]
            te121 = 121,           
            [Description("122")]
            te122 = 122,          
            [Description("123")]
            te123 = 123,          
            [Description("124")]
            te124 = 124,           
            [Description("125")]
            te125 = 125,           
            [Description("126")]
            te126 = 126,           
            [Description("127")]
            te127 = 127,
            [Description("128")]
            te128 = 128,     
            [Description("129")]
            te129 = 129,
            [Description("130")]
            te130 = 130,
        }


    }
}
