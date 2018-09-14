﻿#if !LINUX
using System;
#endif
using System.Collections.Generic;
using System.Linq;
using AudioWorks.Api.Tests.DataTypes;
using JetBrains.Annotations;

namespace AudioWorks.Api.Tests.DataSources
{
    public static class EncodeValidFileDataSource
    {
        [NotNull, ItemNotNull] static readonly List<object[]> _data = new List<object[]>
        {
            #region Wave Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "Wave",
                null,
#if !OSX
                "818EE6CBF16F76F923D33650E7A52708",
#endif
                "818EE6CBF16F76F923D33650E7A52708"
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "Wave",
                null,
#if !OSX
                "509B83828F13945E4121E4C4897A8649",
#endif
                "509B83828F13945E4121E4C4897A8649"
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Wave",
                null,
#if !OSX
                "5D4B869CD72BE208BC7B47F35E13BE9A",
#endif
                "5D4B869CD72BE208BC7B47F35E13BE9A"
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "Wave",
                null,
#if !OSX
                "EFBC44B9FA9C04449D67ECD16CB7F3D8",
#endif
                "EFBC44B9FA9C04449D67ECD16CB7F3D8"
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "Wave",
                null,
#if !OSX
                "D55BD1987676A7D6C2A04BF09C10F64F",
#endif
                "D55BD1987676A7D6C2A04BF09C10F64F"
            },

            new object[]
            {
                "FLAC Level 5 8-bit 8000Hz Stereo.flac",
                "Wave",
                null,
#if !OSX
                "818EE6CBF16F76F923D33650E7A52708",
#endif
                "818EE6CBF16F76F923D33650E7A52708"
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Mono.flac",
                "Wave",
                null,
#if !OSX
                "509B83828F13945E4121E4C4897A8649",
#endif
                "509B83828F13945E4121E4C4897A8649"
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo.flac",
                "Wave",
                null,
#if !OSX
                "5D4B869CD72BE208BC7B47F35E13BE9A",
#endif
                "5D4B869CD72BE208BC7B47F35E13BE9A"
            },

            new object[]
            {
                "FLAC Level 5 16-bit 48000Hz Stereo.flac",
                "Wave",
                null,
#if !OSX
                "EFBC44B9FA9C04449D67ECD16CB7F3D8",
#endif
                "EFBC44B9FA9C04449D67ECD16CB7F3D8"
            },

            new object[]
            {
                "FLAC Level 5 24-bit 96000Hz Stereo.flac",
                "Wave",
                null,
#if !OSX
                "D55BD1987676A7D6C2A04BF09C10F64F",
#endif
                "D55BD1987676A7D6C2A04BF09C10F64F"
            },

#if !LINUX
            new object[]
            {
                "ALAC 16-bit 44100Hz Mono.m4a",
                "Wave",
                null,
#if !OSX
                "509B83828F13945E4121E4C4897A8649",
#endif
                "509B83828F13945E4121E4C4897A8649"
            },

            new object[]
            {
                "ALAC 16-bit 44100Hz Stereo.m4a",
                "Wave",
                null,
#if !OSX
                "5D4B869CD72BE208BC7B47F35E13BE9A",
#endif
                "5D4B869CD72BE208BC7B47F35E13BE9A"
            },

            new object[]
            {
                "ALAC 16-bit 48000Hz Stereo.m4a",
                "Wave",
                null,
#if !OSX
                "EFBC44B9FA9C04449D67ECD16CB7F3D8",
#endif
                "EFBC44B9FA9C04449D67ECD16CB7F3D8"
            },

            new object[]
            {
                "ALAC 24-bit 96000Hz Stereo.m4a",
                "Wave",
                null,
#if !OSX
                "D55BD1987676A7D6C2A04BF09C10F64F",
#endif
                "D55BD1987676A7D6C2A04BF09C10F64F"
            },
#endif

            #endregion

            #region FLAC Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "FLAC",
                null,
#if LINUX
                "ADF68390D58F5312FE3B01D75FE5BE57",
                "44AA2E52CED28503D02D51957B19DF74"
#elif OSX
                "44AA2E52CED28503D02D51957B19DF74"
#else
                "44AA2E52CED28503D02D51957B19DF74",
                "44AA2E52CED28503D02D51957B19DF74"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "FLAC",
                null,
#if LINUX
                "9A4394FF3EA062E68526EFBCC3851FB9",
                "588ACB7827AF0D1A6A18751EEFEA3604"
#elif OSX
                "588ACB7827AF0D1A6A18751EEFEA3604"
#else
                "19B38AABCF5C7B1BC6142B131111D700",
                "588ACB7827AF0D1A6A18751EEFEA3604"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                null,
#if LINUX
                "75A88A48CC2EDE69F79E4D86F3B67B11",
                "3983A342A074A7E8871FEF4FBE0AC73F"
#elif OSX
                "3983A342A074A7E8871FEF4FBE0AC73F"
#else
                "3DBDA80BB4810C91CC868478D189DDE7",
                "0137D7EA15464514D6C8445D4940654A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "FLAC",
                null,
#if LINUX
                "EFAA1634FCAC4C0AA6544F085DCAA315",
                "8A532C4C9D61AF027BC6F684C59FE9A6"
#elif OSX
                "8A532C4C9D61AF027BC6F684C59FE9A6"
#else
                "5DA29CFCDB61B4B496A892980A83444D",
                "8A532C4C9D61AF027BC6F684C59FE9A6"
#endif
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "FLAC",
                null,
#if LINUX
                "20A6542862C62E47F75FA91CA3863F21",
                "4A4DE0494E31D82F446421C876FB10EA"
#elif OSX
                "4A4DE0494E31D82F446421C876FB10EA"
#else
                "6D32DE3A9790FB007534AB9C0CF21E15",
                "4A4DE0494E31D82F446421C876FB10EA"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "FLAC",
                null,
#if LINUX
                "AE5FE89E167550019A672C46D81B765E",
                "A6B18F2B4DDC51DC37154410E701251F"
#elif OSX
                "A6B18F2B4DDC51DC37154410E701251F"
#else
                "B54A449EEC15659FD1262224913253E8",
                "CAA2E90C27940A68EFE083E439527C27"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "FLAC",
                null,
#if LINUX
                "4E48D943C0D10F7B59490398AA68C305",
                "CC3E8D9A5B48AE40CB9D0EDD38D433B5"
#elif OSX
                "CC3E8D9A5B48AE40CB9D0EDD38D433B5"
#else
                "EF128FFA32E07D10E5E6D57B860A7730",
                "76954D618CB59B4905396575F956E550"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "FLAC",
                null,
#if LINUX
                "075CCCEB8C9263F21C95CDF5C2B9D691",
                "93016EE621E1F515BDAF0D405917DA25"
#elif OSX
                "93016EE621E1F515BDAF0D405917DA25"
#else
                "EFDE9011E3A36492501F41E795EA5FC8",
                "C65FBDA188A36CBFFAC74286A66D85FA"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Default compression
                    ["CompressionLevel"] = 5
                },
#if LINUX
                "75A88A48CC2EDE69F79E4D86F3B67B11",
                "3983A342A074A7E8871FEF4FBE0AC73F"
#elif OSX
                "3983A342A074A7E8871FEF4FBE0AC73F"
#else
                "3DBDA80BB4810C91CC868478D189DDE7",
                "0137D7EA15464514D6C8445D4940654A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Minimum compression
                    ["CompressionLevel"] = 0
                },
#if LINUX
                "1F6BE17A7FCDCC0D879F4A067B4CEF8B",
                "D352B276E4712ABBA3A8F1B9CA8BAB55"
#elif OSX
                "D352B276E4712ABBA3A8F1B9CA8BAB55"
#else
                "D352B276E4712ABBA3A8F1B9CA8BAB55",
                "D352B276E4712ABBA3A8F1B9CA8BAB55"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Maximum compression
                    ["CompressionLevel"] = 8
                },
#if LINUX
                "78D765C28F4817CB0189B8A1238F2C27",
                "C73F21F10850A4542EEA2435226F1DEB"
#elif OSX
                "C73F21F10850A4542EEA2435226F1DEB"
#else
                "682A631EE08BE5075C5A1B81A6D9EDC8",
                "63CB2495C4A463A41B019F8A8D86AB3F"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Default seek point interval
                    ["SeekPointInterval"] = 10
                },
#if LINUX
                "75A88A48CC2EDE69F79E4D86F3B67B11",
                "3983A342A074A7E8871FEF4FBE0AC73F"
#elif OSX
                "3983A342A074A7E8871FEF4FBE0AC73F"
#else
                "3DBDA80BB4810C91CC868478D189DDE7",
                "0137D7EA15464514D6C8445D4940654A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Disabled seek points
                    ["SeekPointInterval"] = 0
                },
#if LINUX
                "2ED9148F4629DDBCCF43BF903E8F237E",
                "7DBB3E3E8079E60932AA5F8B4D9CD57C"
#elif OSX
                "7DBB3E3E8079E60932AA5F8B4D9CD57C"
#else
                "69CF6B3C80AC9A39F163BE8971515319",
                "260617EF462F485D9470044D8F16D05A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Maximum seek point interval
                    ["SeekPointInterval"] = 600
                },
#if LINUX
                "75A88A48CC2EDE69F79E4D86F3B67B11",
                "3983A342A074A7E8871FEF4FBE0AC73F"
#elif OSX
                "3983A342A074A7E8871FEF4FBE0AC73F"
#else
                "3DBDA80BB4810C91CC868478D189DDE7",
                "0137D7EA15464514D6C8445D4940654A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Default padding
                    ["Padding"] = 8192
                },
#if LINUX
                "75A88A48CC2EDE69F79E4D86F3B67B11",
                "3983A342A074A7E8871FEF4FBE0AC73F"
#elif OSX
                "3983A342A074A7E8871FEF4FBE0AC73F"
#else
                "3DBDA80BB4810C91CC868478D189DDE7",
                "0137D7EA15464514D6C8445D4940654A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Disabled padding
                    ["Padding"] = 0
                },
#if LINUX
                "F303C709C209A5B6A986D7EBF0CCC07B",
                "FFB7D9F0F4CDF37EDBA799FE371424A7"
#elif OSX
                "FFB7D9F0F4CDF37EDBA799FE371424A7"
#else
                "38B5F185CEAFF8F67029A01F45F230C7",
                "D0886BDBA9B11ED9644F52B6832DD066"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary
                {
                    // Maximum padding
                    ["Padding"] = 16_775_369
                },
#if LINUX
                "67E4AB6AD90E9FFE867ED57E6AFCC09C",
                "F03F417B853C560705CD424AD329EFBC"
#elif OSX
                "F03F417B853C560705CD424AD329EFBC"
#else
                "CC2803ABBA9A1FA57D715A4DF8BF9466",
                "D231A96C6D04252FE4A98C9BB9409885"
#endif
            },

            #endregion

#if !LINUX
            #region ALAC Encoding

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "50F7F27DBCCE5874118C3DE9B0F0306D"
#else
                "50F7F27DBCCE5874118C3DE9B0F0306D",
                "50F7F27DBCCE5874118C3DE9B0F0306D"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "4A2E22037B18F3318920EA47BA76825C"
#else
                "4A2E22037B18F3318920EA47BA76825C",
                "4A2E22037B18F3318920EA47BA76825C"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "C299C20C8EF4ED5B6B5664E6B81C3244"
#else
                "C299C20C8EF4ED5B6B5664E6B81C3244",
                "C299C20C8EF4ED5B6B5664E6B81C3244"
#endif
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "26442948986C55394D8AE960E66101C3"
#else
                "26442948986C55394D8AE960E66101C3",
                "26442948986C55394D8AE960E66101C3"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "C8E2DD6861F837C845A52A4C34523C85"
#else
                "C8E2DD6861F837C845A52A4C34523C85",
                "C8E2DD6861F837C845A52A4C34523C85"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "FAF8B7679D0B2446D83BA248CB491410"
#else
                "FAF8B7679D0B2446D83BA248CB491410",
                "FAF8B7679D0B2446D83BA248CB491410"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "ALAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "38406F719F6EF9E5F5D4E7862AA5C351"
#else
                "38406F719F6EF9E5F5D4E7862AA5C351",
                "38406F719F6EF9E5F5D4E7862AA5C351"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    // Different creation time
                    ["CreationTime"] = new DateTime(2016, 12, 1),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "2F72E377036957C669D858AEA26DF62F"
#else
                "2F72E377036957C669D858AEA26DF62F",
                "2F72E377036957C669D858AEA26DF62F"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    // Different modification time
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2018, 12, 1)
                },
#if OSX
                "F57326FFFD308ED69B83F7F451938D55"
#else
                "F57326FFFD308ED69B83F7F451938D55",
                "F57326FFFD308ED69B83F7F451938D55"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    // Default padding (explicit)
                    ["Padding"] = 2048,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "4A2E22037B18F3318920EA47BA76825C"
#else
                "4A2E22037B18F3318920EA47BA76825C",
                "4A2E22037B18F3318920EA47BA76825C"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    // Disabled padding
                    ["Padding"] = 0,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "03305CCE91A686386908415EF35BDE0D"
#else
                "03305CCE91A686386908415EF35BDE0D",
                "03305CCE91A686386908415EF35BDE0D"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "ALAC",
                new TestSettingDictionary
                {
                    // Maximum padding
                    ["Padding"] = 16_777_216,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "815E83D61745D4E117E12D31543C47BF"
#else
                "815E83D61745D4E117E12D31543C47BF",
                "815E83D61745D4E117E12D31543C47BF"
#endif
            },

            #endregion

            #region Apple AAC Encoding

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "C1DFE680420B4D2D46BA02F087ACB488"
#else
                "09CD8B8C8E9D8BC09121D8C9F871F9B7",
                "D281CFECEEBE5A14D0D3D953D12F71DC"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "86FEDE6D1F7EF6216FE5420A4B326F89"
#else
                "9A0F6E1984B428F236E1209C13AED4D1",
                "47189DECF29E68A40F60645F97714BE3"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "C76FDC7D9181C8A5C64B45315B9E3779"
#else
                "CB39DFBF414790022574435C2D30297D",
                "589C93B14B5A2C8EF39239949A7729FF"
#endif
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "8CA08D60F2A8FD8E9E966FB86C56246B"
#else
                "E0C34EA1479C8979D3AF3A2C98D4E699",
                "BA760ADA182CA749797AC1B978266CB1"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "047B0319C62CD977077D920DC71295AD"
#else
                "7BAD797AA7C5F71C7168C24077271029",
                "A3DC2D21D29A05456284B0B8C09E1F94"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "987CFD9DF4CBDFDB0BE674395D2165F5"
#else
                "9AC3DEF9B464D0E1AB2D4F91C1A08B83",
                "DC77F4678649D575CE3E91DB950CDF55"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "AppleAAC",
                new TestSettingDictionary
                {
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "987CFD9DF4CBDFDB0BE674395D2165F5"
#else
                "9AC3DEF9B464D0E1AB2D4F91C1A08B83",
                "DC77F4678649D575CE3E91DB950CDF55"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Default VBR quality
                    ["VBRQuality"] = 9,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "86FEDE6D1F7EF6216FE5420A4B326F89"
#else
                "9A0F6E1984B428F236E1209C13AED4D1",
                "47189DECF29E68A40F60645F97714BE3"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Minimum VBR quality
                    ["VBRQuality"] = 0,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "924AD280AF0C8E068F2CA14211631527"
#else
                "78299761793D1A6EC79CBB9233156FD8",
                "78299761793D1A6EC79CBB9233156FD8"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Maximum VBR quality
                    ["VBRQuality"] = 14,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "672E1988E013BD994E7D428528D7C235"
#else
                "7EDD94F25082AEEE82B2AA87E795AB6D",
                "560039278EF9183F0FB2C47E5744E475"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Minimum bit rate (stereo is automatically increased to 64)
                    ["BitRate"] = 32,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "31E4469B7D826DF20C38EC8EC80C0D16"
#else
                "0177BB1DEB19854CA8495C4CBBB25366",
                "DB44ACD7770861D4A3C6D7EE644C5E1C"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Minimum bit rate (mono)
                    ["BitRate"] = 32,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "2321A80FDC5F36A1860523948548F8E5"
#else
                "9E77C0824474E3600F1A919715609A1B",
                "2321A80FDC5F36A1860523948548F8E5"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Maximum bit rate (stereo)
                    ["BitRate"] = 320,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "F2E26A79A81AC009F83A90E1720926D4"
#else
                "EBD496E30A953A8D0FE11C2609EFABC3",
                "A67A5F8D1A55CD2A29EEFA54E583AEA1"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Maximum bit rate (mono is automatically reduced to 256)
                    ["BitRate"] = 320,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "E02E2162305236482A85303CE0A8BCFE"
#else
                "DE5F94EC1EACB75A3D049AE9960A7ACB",
                "8F6858F8F86AA821789D926E0B4F63B6"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Constrained bit rate mode (default)
                    ["BitRate"] = 128,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "FB28221E1847925A8E338184A4D154E6"
#else
                "B26C14FD53A4027C26FA3A57CB96AF4C",
                "EEEAF1FB2801EF0FB49B9B87350B5587"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Constrained bit rate mode (explicit)
                    ["ControlMode"] = "Constrained",
                    ["BitRate"] = 128,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "FB28221E1847925A8E338184A4D154E6"
#else
                "B26C14FD53A4027C26FA3A57CB96AF4C",
                "EEEAF1FB2801EF0FB49B9B87350B5587"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Average bit rate mode
                    ["ControlMode"] = "Average",
                    ["BitRate"] = 128,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "592C890A4624C05761ED9E7169354A73"
#else
                "B65D496ADABF3DBCDB24136A9655C295",
                "6AD4BD76918C74B976FD7774163CD7ED"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Constant bit rate mode
                    ["ControlMode"] = "Constant",
                    ["BitRate"] = 128,
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "681669911753B8226451A31ABF1A9886"
#else
                "365D7E965534C8690B4694B27D0CF1C9",
                "4E99289AFF43EA387442E30EAFB7305A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // TrackGain requested but not available
                    ["ApplyGain"] = "Track",
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "86FEDE6D1F7EF6216FE5420A4B326F89"
#else
                "9A0F6E1984B428F236E1209C13AED4D1",
                "47189DECF29E68A40F60645F97714BE3"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Scaled to TrackGain
                    ["ApplyGain"] = "Track",
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "2D94FDDB2800F73894BDDE07242C4F2A"
#else
                "DDA8DBB070EA36F77455A41A2628B6AA",
                "14145EA9D279E2FA457AD85F19DC0896"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "AppleAAC",
                new TestSettingDictionary
                {
                    // Scaled to AlbumGain
                    ["ApplyGain"] = "Album",
                    ["CreationTime"] = new DateTime(2017, 1, 31),
                    ["ModificationTime"] = new DateTime(2017, 1, 31)
                },
#if OSX
                "E1841342DFCE34B07406584F667091B5"
#else
                "5502D724D98AA24FE49FA8AFB0FC63A6",
                "90D1426E435372B957E6558E4DC5D7FD"
#endif
            },

            #endregion

#endif
            #region Lame MP3 Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "LameMP3",
                null,
#if LINUX
                "362C1DC415B6ED27B3BB0C43EEC7614A",
                "F2BD0875E273743A8908F96DCCFDFC44"
#elif OSX
                "F2BD0875E273743A8908F96DCCFDFC44"
#else
                "7CB68FB7ACC70E8CD928E7DB437B16FE",
                "7CB68FB7ACC70E8CD928E7DB437B16FE"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "LameMP3",
                null,
#if LINUX
                "3FBE256A1ABC2C530FAAA632929F9AC2",
                "1CB5B915B3A72CBE76087E16F96A0A3E"
#elif OSX
                "1CB5B915B3A72CBE76087E16F96A0A3E"
#else
                "C02CA44F3E1CCA3D8BA0DE922C49946E",
                "C02CA44F3E1CCA3D8BA0DE922C49946E"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                null,
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "LameMP3",
                null,
#if LINUX
                "F2FFFC7C7001A93C0CC19466D51FC597",
                "1454732B48913F2A3898164BA366DA01"
#elif OSX
                "1454732B48913F2A3898164BA366DA01"
#else
                "A333E74AFF4107E6C6C987AB27DF4B36",
                "A333E74AFF4107E6C6C987AB27DF4B36"
#endif
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "LameMP3",
                null,
#if LINUX
                "BFF278600EB87215603D727BAA7905BD",
                "AD56C3A1ACD627DBDA4B5A28AFE0355D"
#elif OSX
                "AD56C3A1ACD627DBDA4B5A28AFE0355D"
#else
                "C0204097396B92D06E2B1BEBA90D0BD9",
                "C0204097396B92D06E2B1BEBA90D0BD9"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                null,
#if LINUX
                "EED1BD58A65E3CA92EEC176F156DEF24",
                "32EEC2B69A048975FB3BD034E8B392A4"
#elif OSX
                "32EEC2B69A048975FB3BD034E8B392A4"
#else
                "0E420A25F4CAE013B6328E5A52E38B3D",
                "0E420A25F4CAE013B6328E5A52E38B3D"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "LameMP3",
                null,
#if LINUX
                "E73399A30F5497FD72E1AEE0A3E76EAF",
                "FB1B7DECB2C2A2C9CAA1FBB917A81472"
#elif OSX
                "FB1B7DECB2C2A2C9CAA1FBB917A81472"
#else
                "8E61943EEA4008E8921618B76FB4C870",
                "8E61943EEA4008E8921618B76FB4C870"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "LameMP3",
                null,
#if LINUX
                "E73399A30F5497FD72E1AEE0A3E76EAF",
                "FB1B7DECB2C2A2C9CAA1FBB917A81472"
#elif OSX
                "FB1B7DECB2C2A2C9CAA1FBB917A81472"
#else
                "8E61943EEA4008E8921618B76FB4C870",
                "8E61943EEA4008E8921618B76FB4C870"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Default tag version
                    ["TagVersion"] = "2.3"
                },
#if LINUX
                "EED1BD58A65E3CA92EEC176F156DEF24",
                "32EEC2B69A048975FB3BD034E8B392A4"
#elif OSX
                "32EEC2B69A048975FB3BD034E8B392A4"
#else
                "0E420A25F4CAE013B6328E5A52E38B3D",
                "0E420A25F4CAE013B6328E5A52E38B3D"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Tag version 2.4
                    ["TagVersion"] = "2.4"
                },
#if LINUX
                "8EEAF387756C09E867E45CAEF8649C53",
                "24F1B744BDA5C6A94B9FE6136DEC4614"
#elif OSX
                "24F1B744BDA5C6A94B9FE6136DEC4614"
#else
                "6D7E02945EFBFAB16E41827E4C7F9D7F",
                "6D7E02945EFBFAB16E41827E4C7F9D7F"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Default tag encoding
                    ["TagEncoding"] = "Latin1"
                },
#if LINUX
                "EED1BD58A65E3CA92EEC176F156DEF24",
                "32EEC2B69A048975FB3BD034E8B392A4"
#elif OSX
                "32EEC2B69A048975FB3BD034E8B392A4"
#else
                "0E420A25F4CAE013B6328E5A52E38B3D",
                "0E420A25F4CAE013B6328E5A52E38B3D"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // UTF-16 tag encoding
                    ["TagEncoding"] = "UTF16"
                },
#if LINUX
                "A7C95E4A6B3071F8C9498D4A705E2685",
                "1B5C266B6D799765BA1272BE28A7C435"
#elif OSX
                "1B5C266B6D799765BA1272BE28A7C435"
#else
                "92ED87DB059CA2A609E8AADF0AF84909",
                "92ED87DB059CA2A609E8AADF0AF84909"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Default tag padding (explicit)
                    ["TagPadding"] = 2048
                },
#if LINUX
                "EED1BD58A65E3CA92EEC176F156DEF24",
                "32EEC2B69A048975FB3BD034E8B392A4"
#elif OSX
                "32EEC2B69A048975FB3BD034E8B392A4"
#else
                "0E420A25F4CAE013B6328E5A52E38B3D",
                "0E420A25F4CAE013B6328E5A52E38B3D"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Tag padding disabled
                    ["TagPadding"] = 0
                },
#if LINUX
                "2773A9EAC3A6E07FA1C71DD5FC730267",
                "5737ED221E55314FD5B9FA167C1C1651"
#elif OSX
                "5737ED221E55314FD5B9FA167C1C1651"
#else
                "55F290095FDCE602C43380CC4F5D1101",
                "55F290095FDCE602C43380CC4F5D1101"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Maximum tag padding
                    ["TagPadding"] = 16_777_216
                },
#if LINUX
                "D05EA326944389E530612EAF314BB588",
                "D270226F14E850B208624CD2AC59512D"
#elif OSX
                "D270226F14E850B208624CD2AC59512D"
#else
                "2572B2613BC3B8E63048527A247A7906",
                "2572B2613BC3B8E63048527A247A7906"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Tag version does nothing without metadata
                    ["TagVersion"] = "2.4"
                },
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Tag encoding does nothing without metadata
                    ["TagEncoding"] = "UTF16"
                },
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Tag padding does nothing without metadata
                    ["TagPadding"] = 100
                },
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Default VBR quality
                    ["VBRQuality"] = 3
                },
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Minimum VBR quality
                    ["VBRQuality"] = 9
                },
#if LINUX
                "472A428EDB8AD18369EEC4F748F80A59",
                "65D418A236D86A8CE33E07A76C98DF08"
#elif OSX
                "65D418A236D86A8CE33E07A76C98DF08"
#else
                "BB8B33BD589DA49D751C883B8A0FF653",
                "BB8B33BD589DA49D751C883B8A0FF653"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Maximum VBR quality
                    ["VBRQuality"] = 0
                },
#if LINUX
                "E539FECE8D80128F11BA73148B92209F",
                "5DE234656056DFDAAD30E4DA9FD26366"
#elif OSX
                "5DE234656056DFDAAD30E4DA9FD26366"
#else
                "5DE234656056DFDAAD30E4DA9FD26366",
                "5DE234656056DFDAAD30E4DA9FD26366"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Minimum bit rate
                    ["BitRate"] = 8
                },
#if LINUX
                "30520C93D354F17F637671B99BE75083",
                "2BBC83E74AB1A4EB150BC6E1EB9920B5"
#elif OSX
                "2BBC83E74AB1A4EB150BC6E1EB9920B5"
#else
                "2BBC83E74AB1A4EB150BC6E1EB9920B5",
                "2BBC83E74AB1A4EB150BC6E1EB9920B5"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Maximum bit rate
                    ["BitRate"] = 320
                },
#if LINUX
                "464C9EE0662B447224805438FAC9D10E",
                "BEB5029A08011BCEDFFA99173B763E7F"
#elif OSX
                "BEB5029A08011BCEDFFA99173B763E7F"
#else
                "BEB5029A08011BCEDFFA99173B763E7F",
                "BEB5029A08011BCEDFFA99173B763E7F"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Forced bit rate disabled (default)
                    ["BitRate"] = 128
                },
#if LINUX
                "9CD9C9FCE1E42F79EDBAA84BA1B8D8C4",
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#elif OSX
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#else
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6",
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Forced bit rate explicitly disabled
                    ["BitRate"] = 128,
                    ["ForceCBR"] = false
                },
#if LINUX
                "9CD9C9FCE1E42F79EDBAA84BA1B8D8C4",
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#elif OSX
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#else
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6",
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Forced bit rate enabled
                    ["BitRate"] = 128,
                    ["ForceCBR"] = true
                },
#if LINUX
                "5BE352395ADE20729E8F68977C3043C7",
                "EACCA2FD6404ACA1AB46027FAE6A667B"
#elif OSX
                "EACCA2FD6404ACA1AB46027FAE6A667B"
#else
                "EACCA2FD6404ACA1AB46027FAE6A667B",
                "EACCA2FD6404ACA1AB46027FAE6A667B"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Forced bit rate ignored without bit rate
                    ["ForceCBR"] = true
                },
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // VBR quality ignored with bit rate
                    ["VBRQuality"] = 3,
                    ["BitRate"] = 128
                },
#if LINUX
                "9CD9C9FCE1E42F79EDBAA84BA1B8D8C4",
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#elif OSX
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#else
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6",
                "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary
                {
                    // TrackGain requested but not available
                    ["ApplyGain"] = "Track"
                },
#if LINUX
                "B46B30D5E331FE64F24C620CFD5C717D",
                "10E44CEE38E66E9737677BE52E7A286D"
#elif OSX
                "10E44CEE38E66E9737677BE52E7A286D"
#else
                "34C345AB6BDA4A4C172D74046EC683D7",
                "34C345AB6BDA4A4C172D74046EC683D7"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Scaled to TrackGain
                    ["ApplyGain"] = "Track"
                },
#if LINUX
                "C6F6B42CCBC2435DC612F643A76E46FC",
                "8EFA63733A5527E08092CAD86E86F76E"
#elif OSX
                "8EFA63733A5527E08092CAD86E86F76E"
#else
                "56C04FEBD02CB1127649A21E70B78C0E",
                "56C04FEBD02CB1127649A21E70B78C0E"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary
                {
                    // Scaled to AlbumGain
                    ["ApplyGain"] = "Album"
                },
#if LINUX
                "F1C20FE496BD523FFC1088A44091D84F",
                "FB96F0590FB1A603C847DEF075D8FC5F"
#elif OSX
                "FB96F0590FB1A603C847DEF075D8FC5F"
#else
                "F8A627B834782D13EBB9A9B722094F05",
                "F8A627B834782D13EBB9A9B722094F05"
#endif
            },

            #endregion

            #region Ogg Vorbis Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "F4351B0F0454B305E353318B410ECBB7",
                "F4351B0F0454B305E353318B410ECBB7"
#elif OSX
                "738178D4B462373D934D228C4A82C1E0"
#else
                "C3379168580C0B08178735BEBF80EA72",
                "C3379168580C0B08178735BEBF80EA72"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "ECC538FF2379AFB7DA3C0A40D2F9B183",
                "ECC538FF2379AFB7DA3C0A40D2F9B183"
#elif OSX
                "4E39AB0FDDEDB3EA444E9F874D627A25"
#else
                "1F962FD6341344AE7A3D01C2ACDC01F1",
                "1F962FD6341344AE7A3D01C2ACDC01F1"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B",
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B"
#elif OSX
                "733244985AA835C9C7B36FB18C6FEBD6"
#else
                "BAD08F056C5BA8308C7B9D1D2E1C2564",
                "BAD08F056C5BA8308C7B9D1D2E1C2564"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "9602838283C7BA2E83930679CFE937D3",
                "9602838283C7BA2E83930679CFE937D3"
#elif OSX
                "36A8224974E97D78AFF5C7CFA2F7AEDC"
#else
                "2D2C106A4DB35969205DCCDAF5229539",
                "2D2C106A4DB35969205DCCDAF5229539"
#endif
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "A40F3915C0CC3ED6DA131CE5EDFAD724",
                "A40F3915C0CC3ED6DA131CE5EDFAD724"
#elif OSX
                "92D75343184BCC158795A7B7E9042211"
#else
                "5F3982A0B34D80B598CBF57265804EA0",
                "5F3982A0B34D80B598CBF57265804EA0"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "D2A49419AB33AA6B299500696FF8E45D",
                "D2A49419AB33AA6B299500696FF8E45D"
#elif OSX
                "9A0F96C0DEBAB71FD1DAA96288864883"
#else
                "1ACAE5D89454C496451F897C6BD32FD0",
                "1ACAE5D89454C496451F897C6BD32FD0"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "45F1D896C34D5FF1B2A04766ABF0E0D1",
                "45F1D896C34D5FF1B2A04766ABF0E0D1"
#elif OSX
                "4E0FA8F81B728E85EEE2B347965AB42D"
#else
                "450B66579C480F81CAEA3404C3C5B08E",
                "450B66579C480F81CAEA3404C3C5B08E"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
#if LINUX
                "45F1D896C34D5FF1B2A04766ABF0E0D1",
                "45F1D896C34D5FF1B2A04766ABF0E0D1"
#elif OSX
                "4E0FA8F81B728E85EEE2B347965AB42D"
#else
                "450B66579C480F81CAEA3404C3C5B08E",
                "450B66579C480F81CAEA3404C3C5B08E"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Minimum serial #
                    ["SerialNumber"] = int.MinValue
                },
#if LINUX
                "EEE89A23404EF9D5ED0D87DB36886EE5",
                "EEE89A23404EF9D5ED0D87DB36886EE5"
#elif OSX
                "19FED7709729025B3B872DA904B2EC20"
#else
                "AACC33C1A52E37098DBBD948039ACF06",
                "AACC33C1A52E37098DBBD948039ACF06"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Maximum serial #
                    ["SerialNumber"] = int.MaxValue
                },
#if LINUX
                "B0CD6D94A249D8CCCAD8FD1BDCFF0484",
                "B0CD6D94A249D8CCCAD8FD1BDCFF0484"
#elif OSX
                "D256FD4F9FD69A42EB39B915633970B6"
#else
                "626A3AE3A7452955075D5578A7A60830",
                "626A3AE3A7452955075D5578A7A60830"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Default quality (explicit)
                    ["Quality"] = 5,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B",
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B"
#elif OSX
                "733244985AA835C9C7B36FB18C6FEBD6"
#else
                "BAD08F056C5BA8308C7B9D1D2E1C2564",
                "BAD08F056C5BA8308C7B9D1D2E1C2564"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Minimum quality
                    ["Quality"] = -1,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "5A4810D3420C0D8F5F01366ADA4ADCA5",
                "5A4810D3420C0D8F5F01366ADA4ADCA5"
#elif OSX
                "163BB28847D6D19F33BA89B9A9BE0BAA"
#else
                "7FC140C80519059284FD728CD4198515",
                "7FC140C80519059284FD728CD4198515"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Maximum quality
                    ["Quality"] = 10,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "B29E49F15FF28688977D1410F3AC549C",
                "B29E49F15FF28688977D1410F3AC549C"
#elif OSX
                "F8332CC8B5B0A63F8F1DEC3E6B10C79A"
#else
                "0B65C4E0389B976E508AEB677F686170",
                "0B65C4E0389B976E508AEB677F686170"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Minimum bit rate
                    ["BitRate"] = 45,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "CFFA4031CD86194861D2AEB3671C2980",
                "CFFA4031CD86194861D2AEB3671C2980"
#elif OSX
                "6B91A80210D065277B7D73F2EC4EFB00"
#else
                "0F9B9459E5E02BD639E086C50904ACD7",
                "0F9B9459E5E02BD639E086C50904ACD7"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Maximum bit rate
                    ["BitRate"] = 500,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "B7305400434E748A541AA40DFCE008AC",
                "B7305400434E748A541AA40DFCE008AC"
#elif OSX
                "3175BF4C12BB57181EEF01F48BD0B489"
#else
                "A5E58EDDF584651D768E809B45AF0E57",
                "A5E58EDDF584651D768E809B45AF0E57"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Forced bit rate disabled (default)
                    ["BitRate"] = 128,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "A74BCB8E6E196514559814E05FCCC71A",
                "A74BCB8E6E196514559814E05FCCC71A"
#elif OSX
                "9B357D4D2A24C48FE45FE559D2456EE2"
#else
                "6419168FF3EF995A41F17FCAF44E9C4A",
                "6419168FF3EF995A41F17FCAF44E9C4A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Forced bit rate disabled (explicit)
                    ["BitRate"] = 128,
                    ["ForceCBR"] = false,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "A74BCB8E6E196514559814E05FCCC71A",
                "A74BCB8E6E196514559814E05FCCC71A"
#elif OSX
                "9B357D4D2A24C48FE45FE559D2456EE2"
#else
                "6419168FF3EF995A41F17FCAF44E9C4A",
                "6419168FF3EF995A41F17FCAF44E9C4A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Forced bit rate enabled
                    ["BitRate"] = 128,
                    ["ForceCBR"] = true,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "8BB26B2BDDDC220D5B6908479981B8D3",
                "8BB26B2BDDDC220D5B6908479981B8D3"
#elif OSX
                "AB341C45F387E300554DC1350034E6D6"
#else
                "1DE19792FF2C7D898197AE88677BABFD",
                "1DE19792FF2C7D898197AE88677BABFD"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Forced bit rate ignored without bit rate
                    ["ForceCBR"] = true,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B",
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B"
#elif OSX
                "733244985AA835C9C7B36FB18C6FEBD6"
#else
                "BAD08F056C5BA8308C7B9D1D2E1C2564",
                "BAD08F056C5BA8308C7B9D1D2E1C2564"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Quality ignored with bit rate
                    ["Quality"] = 3,
                    ["BitRate"] = 128,
                    ["SerialNumber"] = 1
                },
#if LINUX
                "A74BCB8E6E196514559814E05FCCC71A",
                "A74BCB8E6E196514559814E05FCCC71A"
#elif OSX
                "9B357D4D2A24C48FE45FE559D2456EE2"
#else
                "6419168FF3EF995A41F17FCAF44E9C4A",
                "6419168FF3EF995A41F17FCAF44E9C4A"
#endif
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    // TrackGain requested but not available
                    ["ApplyGain"] = "Track",
                    ["SerialNumber"] = 1
                },
#if LINUX
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B",
                "4FF4ECBB0DAD17ABBB42A3A098B5B79B"
#elif OSX
                "733244985AA835C9C7B36FB18C6FEBD6"
#else
                "BAD08F056C5BA8308C7B9D1D2E1C2564",
                "BAD08F056C5BA8308C7B9D1D2E1C2564"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Scaled to TrackGain
                    ["ApplyGain"] = "Track",
                    ["SerialNumber"] = 1
                },
#if LINUX
                "3BE0C521F649D9BE8E71E44C20D1B0A4",
                "3BE0C521F649D9BE8E71E44C20D1B0A4"
#elif OSX
                "380662754A2C3A8CD837F53D8E09A5CA"
#else
                "CFCCC97C8BE4941921C95F2D501CF66C",
                "CFCCC97C8BE4941921C95F2D501CF66C"
#endif
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    // Scaled to AlbumGain
                    ["ApplyGain"] = "Album",
                    ["SerialNumber"] = 1
                },
#if LINUX
                "9376D4E99CDB475D5073D1CC545D8D0B",
                "9376D4E99CDB475D5073D1CC545D8D0B"
#elif OSX
                "33717D870DC9A3B9BCCD191BA8ADAAEE"
#else
                "E89F1CDE37BFB3E81D96B1BD044F8D07",
                "E89F1CDE37BFB3E81D96B1BD044F8D07"
#endif
            }

            #endregion
        };

        [NotNull, ItemNotNull]
        public static IEnumerable<object[]> Data
        {
            // Prepend an index to each row
            [UsedImplicitly] get => _data.Select((item, index) => item.Prepend(index).ToArray());
        }
    }
}