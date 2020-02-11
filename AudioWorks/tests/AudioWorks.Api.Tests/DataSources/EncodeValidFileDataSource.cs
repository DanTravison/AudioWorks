﻿/* Copyright © 2018 Jeremy Herbison

This file is part of AudioWorks.

AudioWorks is free software: you can redistribute it and/or modify it under the terms of the GNU Affero General Public
License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later
version.

AudioWorks is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied
warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more
details.

You should have received a copy of the GNU Affero General Public License along with AudioWorks. If not, see
<https://www.gnu.org/licenses/>. */

#if !LINUX
using System;
#endif
using System.Collections.Generic;
using System.Linq;
using AudioWorks.Api.Tests.DataTypes;

namespace AudioWorks.Api.Tests.DataSources
{
    public static class EncodeValidFileDataSource
    {
        static readonly List<object[]> _data = new List<object[]>
        {
            #region Wave Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "818EE6CBF16F76F923D33650E7A52708"
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "509B83828F13945E4121E4C4897A8649"
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "5D4B869CD72BE208BC7B47F35E13BE9A"
                }
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "EFBC44B9FA9C04449D67ECD16CB7F3D8"
                }
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "D55BD1987676A7D6C2A04BF09C10F64F"
                }
            },

            new object[]
            {
                "FLAC Level 5 8-bit 8000Hz Stereo.flac",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "818EE6CBF16F76F923D33650E7A52708"
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Mono.flac",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "509B83828F13945E4121E4C4897A8649"
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo.flac",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "5D4B869CD72BE208BC7B47F35E13BE9A"
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 48000Hz Stereo.flac",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "EFBC44B9FA9C04449D67ECD16CB7F3D8"
                }
            },

            new object[]
            {
                "FLAC Level 5 24-bit 96000Hz Stereo.flac",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "D55BD1987676A7D6C2A04BF09C10F64F"
                }
            },

#if !LINUX
            new object[]
            {
                "ALAC 16-bit 44100Hz Mono.m4a",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "509B83828F13945E4121E4C4897A8649"
                }
            },

            new object[]
            {
                "ALAC 16-bit 44100Hz Stereo.m4a",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "5D4B869CD72BE208BC7B47F35E13BE9A"
                }
            },

            new object[]
            {
                "ALAC 16-bit 48000Hz Stereo.m4a",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "EFBC44B9FA9C04449D67ECD16CB7F3D8"
                }
            },

            new object[]
            {
                "ALAC 24-bit 96000Hz Stereo.m4a",
                "Wave",
                new TestSettingDictionary(),
                new[]
                {
                    "D55BD1987676A7D6C2A04BF09C10F64F"
                }
            },
#endif

            #endregion

            #region FLAC Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "ADF68390D58F5312FE3B01D75FE5BE57", // FLAC 1.3.1 (Ubuntu 16.04)
                    "44AA2E52CED28503D02D51957B19DF74", // FLAC 1.3.2 (Ubuntu 18.04)
                    "42070347011D5067A9D962DA3237EF63" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "9A4394FF3EA062E68526EFBCC3851FB9", // FLAC 1.3.1 (Ubuntu 16.04)
                    "588ACB7827AF0D1A6A18751EEFEA3604", // FLAC 1.3.2 (Ubuntu 18.04)
                    "0771EF09959F087FACE194A4479F5107" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "75A88A48CC2EDE69F79E4D86F3B67B11", // FLAC 1.3.1 (Ubuntu 16.04)
                    "3983A342A074A7E8871FEF4FBE0AC73F", // FLAC 1.3.2 (Ubuntu 18.04)
                    "734954C2D360CD6D6C4F7FE23F6970AF" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "EFAA1634FCAC4C0AA6544F085DCAA315", // FLAC 1.3.1 (Ubuntu 16.04)
                    "8A532C4C9D61AF027BC6F684C59FE9A6", // FLAC 1.3.2 (Ubuntu 18.04)
                    "F0F075E05A3AFB67403CCF373932BCCA" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "20A6542862C62E47F75FA91CA3863F21", // FLAC 1.3.1 (Ubuntu 16.04)
                    "4A4DE0494E31D82F446421C876FB10EA", // FLAC 1.3.2 (Ubuntu 18.04)
                    "D3A7B834DCE97F0709AEFCA45A24F5B6" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "AE5FE89E167550019A672C46D81B765E", // FLAC 1.3.1 (Ubuntu 16.04)
                    "A6B18F2B4DDC51DC37154410E701251F", // FLAC 1.3.2 (Ubuntu 18.04)
                    "2F2F341FEECB7842F7FA9CE6CB110C67" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "4E48D943C0D10F7B59490398AA68C305", // FLAC 1.3.1 (Ubuntu 16.04)
                    "CC3E8D9A5B48AE40CB9D0EDD38D433B5", // FLAC 1.3.2 (Ubuntu 18.04)
                    "A48820F5E30B5C21A881E01209257E21" // FLAC 1.3.3
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "FLAC",
                new TestSettingDictionary(),
                new[]
                {
                    "075CCCEB8C9263F21C95CDF5C2B9D691", // FLAC 1.3.1 (Ubuntu 16.04)
                    "93016EE621E1F515BDAF0D405917DA25", // FLAC 1.3.2 (Ubuntu 18.04)
                    "D90693A520FA14AC987272ACB6CD8996" // FLAC 1.3.3
                }
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
                new[]
                {
                    "75A88A48CC2EDE69F79E4D86F3B67B11", // FLAC 1.3.1 (Ubuntu 16.04)
                    "3983A342A074A7E8871FEF4FBE0AC73F", // FLAC 1.3.2 (Ubuntu 18.04)
                    "734954C2D360CD6D6C4F7FE23F6970AF" // FLAC 1.3.3
                }
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
                new[]
                {
                    "1F6BE17A7FCDCC0D879F4A067B4CEF8B", // FLAC 1.3.1 (Ubuntu 16.04)
                    "D352B276E4712ABBA3A8F1B9CA8BAB55", // FLAC 1.3.2 (Ubuntu 18.04)
                    "A58022B124B427771041A96F65D8DF21" // FLAC 1.3.3
                }
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
                new[]
                {
                    "78D765C28F4817CB0189B8A1238F2C27", // FLAC 1.3.1 (Ubuntu 16.04)
                    "C73F21F10850A4542EEA2435226F1DEB", // FLAC 1.3.2 (Ubuntu 18.04)
                    "F341E56E68A0A168B779A4EBFD41422D" // FLAC 1.3.3
                }
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
                new[]
                {
                    "75A88A48CC2EDE69F79E4D86F3B67B11", // FLAC 1.3.1 (Ubuntu 16.04)
                    "3983A342A074A7E8871FEF4FBE0AC73F", // FLAC 1.3.2 (Ubuntu 18.04)
                    "734954C2D360CD6D6C4F7FE23F6970AF" // FLAC 1.3.3
                }
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
                new[]
                {
                    "2ED9148F4629DDBCCF43BF903E8F237E", // FLAC 1.3.1 (Ubuntu 16.04)
                    "7DBB3E3E8079E60932AA5F8B4D9CD57C", // FLAC 1.3.2 (Ubuntu 18.04)
                    "986464F3AC48E00D00B8ECF3AF3FD6BC" // FLAC 1.3.3
                }
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
                new[]
                {
                    "75A88A48CC2EDE69F79E4D86F3B67B11", // FLAC 1.3.1 (Ubuntu 16.04)
                    "3983A342A074A7E8871FEF4FBE0AC73F", // FLAC 1.3.2 (Ubuntu 18.04)
                    "734954C2D360CD6D6C4F7FE23F6970AF" // FLAC 1.3.3
                }
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
                new[]
                {
                    "75A88A48CC2EDE69F79E4D86F3B67B11", // FLAC 1.3.1 (Ubuntu 16.04)
                    "3983A342A074A7E8871FEF4FBE0AC73F", // FLAC 1.3.2 (Ubuntu 18.04)
                    "734954C2D360CD6D6C4F7FE23F6970AF" // FLAC 1.3.3
                }
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
                new[]
                {
                    "F303C709C209A5B6A986D7EBF0CCC07B", // FLAC 1.3.1 (Ubuntu 16.04)
                    "FFB7D9F0F4CDF37EDBA799FE371424A7", // FLAC 1.3.2 (Ubuntu 18.04)
                    "662592BD8B3853B6FEC4E188F7D0F246" // FLAC 1.3.3
                }
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
                new[]
                {
                    "67E4AB6AD90E9FFE867ED57E6AFCC09C", // FLAC 1.3.1 (Ubuntu 16.04)
                    "F03F417B853C560705CD424AD329EFBC", // FLAC 1.3.2 (Ubuntu 18.04)
                    "455753A51355171BF22CCC78647235B4" // FLAC 1.3.3
                }
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
                new[]
                {
                    "50F7F27DBCCE5874118C3DE9B0F0306D"
                }
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
                new[]
                {
                    "4A2E22037B18F3318920EA47BA76825C"
                }
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
                new[]
                {
                    "C299C20C8EF4ED5B6B5664E6B81C3244"
                }
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
                new[]
                {
                    "26442948986C55394D8AE960E66101C3"
                }
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
                new[]
                {
                    "C8E2DD6861F837C845A52A4C34523C85"
                }
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
                new[]
                {
                    "FAF8B7679D0B2446D83BA248CB491410"
                }
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
                new[]
                {
                    "38406F719F6EF9E5F5D4E7862AA5C351"
                }
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
                new[]
                {
                    "2F72E377036957C669D858AEA26DF62F"
                }
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
                new[]
                {
                    "F57326FFFD308ED69B83F7F451938D55"
                }
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
                new[]
                {
                    "4A2E22037B18F3318920EA47BA76825C"
                }
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
                new[]
                {
                    "03305CCE91A686386908415EF35BDE0D"
                }
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
                new[]
                {
                    "815E83D61745D4E117E12D31543C47BF"
                }
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
                new[]
                {
                    "A4A51635A3E24D6AD0C377C918FBE7B6", // MacOS
                    "09CD8B8C8E9D8BC09121D8C9F871F9B7", // 32-bit Windows on Intel
                    "CF5AD69DADDCCE22612CD6FA8FB21897", // 32-bit Windows on AMD
                    "D281CFECEEBE5A14D0D3D953D12F71DC", // 64-bit Windows on Intel
                    "F1E4C1E4386B0DD4B233284E4E2363D8" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "336CE3C01C6F9D430E6FC947B93820F7", // MacOS
                    "9A0F6E1984B428F236E1209C13AED4D1", // 32-bit Windows on Intel
                    "7FABBF9DDF1A16701E57C6DD190485E0", // 32-bit Windows on AMD
                    "47189DECF29E68A40F60645F97714BE3", // 64-bit Windows on Intel
                    "C40C18B162E7429F60C62DF6A23071D6" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "6C9073E678B05536C0B6AE3BF98691DD", // MacOS
                    "CB39DFBF414790022574435C2D30297D", // 32-bit Windows on Intel
                    "EB0DA4A098888A34C2F77A2A65D2E337", // 32-bit Windows on AMD
                    "589C93B14B5A2C8EF39239949A7729FF", // 64-bit Windows on Intel
                    "CA58A161F472C9038E29DB08BC8B41CC" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "8CA08D60F2A8FD8E9E966FB86C56246B", // MacOS
                    "E0C34EA1479C8979D3AF3A2C98D4E699", // 32-bit Windows on Intel
                    "06469BD31CF3F0B799D9E52BBEA00C72", // 32-bit Windows on AMD
                    "BA760ADA182CA749797AC1B978266CB1", // 64-bit Windows on Intel
                    "155983F671E0ACD36DC482A283A8EDBE" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "0F0823DFE0AC879E021E881F70AF5775", // MacOS
                    "7BAD797AA7C5F71C7168C24077271029", // 32-bit Windows on Intel
                    "01DF45A55B786EBDEFCFFFFFD58187DF", // 32-bit Windows on AMD
                    "A3DC2D21D29A05456284B0B8C09E1F94", // 64-bit Windows on Intel
                    "EB34F55D3D94E569E99C12BD8FCF5BBF" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "7F43E990D02B3D55798A69F675362138", // MacOS
                    "9AC3DEF9B464D0E1AB2D4F91C1A08B83", // 32-bit Windows on Intel
                    "4BB812252790CAEDE8CE8547E7BD546A", // 32-bit Windows on AMD
                    "DC77F4678649D575CE3E91DB950CDF55", // 64-bit Windows on Intel
                    "76BFBCEB5644AEA27C774D00D35A2B66" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "7F43E990D02B3D55798A69F675362138", // MacOS
                    "9AC3DEF9B464D0E1AB2D4F91C1A08B83", // 32-bit Windows on Intel
                    "4BB812252790CAEDE8CE8547E7BD546A", // 32-bit Windows on AMD
                    "DC77F4678649D575CE3E91DB950CDF55", // 64-bit Windows on Intel
                    "76BFBCEB5644AEA27C774D00D35A2B66" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "336CE3C01C6F9D430E6FC947B93820F7", // MacOS
                    "9A0F6E1984B428F236E1209C13AED4D1", // 32-bit Windows on Intel
                    "7FABBF9DDF1A16701E57C6DD190485E0", // 32-bit Windows on AMD
                    "47189DECF29E68A40F60645F97714BE3", // 64-bit Windows on Intel
                    "C40C18B162E7429F60C62DF6A23071D6" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "924AD280AF0C8E068F2CA14211631527", // MacOS
                    "78299761793D1A6EC79CBB9233156FD8", // Windows on Intel
                    "E53BA332FDCFBE927A81040DB480688B" // Windows on AMD
                }
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
                new[]
                {
                    "B26CC58D8473661388019F210607C1B7", // MacOS
                    "7EDD94F25082AEEE82B2AA87E795AB6D", // 32-bit Windows on Intel
                    "9EFB3B60246E65F1C90A0880CF8905D9", // 32-bit Windows on AMD
                    "560039278EF9183F0FB2C47E5744E475", // 64-bit Windows on Intel
                    "288B9B3FE4FCC212491B9A370757FC46" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "31E4469B7D826DF20C38EC8EC80C0D16", // MacOS
                    "0177BB1DEB19854CA8495C4CBBB25366", // 32-bit Windows on Intel
                    "4EE479F602DD0FB162B19540B683B2BF", // 32-bit Windows on AMD
                    "DB44ACD7770861D4A3C6D7EE644C5E1C", // 64-bit Windows on Intel
                    "2D6F2B1043E1276764605C70E94A9EAE" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "2321A80FDC5F36A1860523948548F8E5", // MacOS
                    "9E77C0824474E3600F1A919715609A1B", // 32-bit Windows
                    "2321A80FDC5F36A1860523948548F8E5" // 64-bit Windows
                }
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
                new[]
                {
                    "E36539ED8969070A53809CECCD0B422A", // MacOS
                    "EBD496E30A953A8D0FE11C2609EFABC3", // 32-bit Windows on Intel
                    "AFEC3388275B59A08EFD11A9B32904FD", // 32-bit Windows on AMD
                    "A67A5F8D1A55CD2A29EEFA54E583AEA1", // 64-bit Windows on Intel
                    "58E298B32860D9A30E1F31B3D164A3AC" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "9116562A92B3F1FA983A180972CE670E", // MacOS
                    "DE5F94EC1EACB75A3D049AE9960A7ACB", // 32-bit Windows on Intel
                    "C3A45A0F87C7E3A8BDAD6526CFA00ABF", // 32-bit Windows on AMD
                    "8F6858F8F86AA821789D926E0B4F63B6", // 64-bit Windows on Intel
                    "8853121A36B39C0A607B5FE219A8EFD8" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "503F9957F1FE77F23189507AFC641297", // MacOS
                    "B26C14FD53A4027C26FA3A57CB96AF4C", // 32-bit Windows
                    "EEEAF1FB2801EF0FB49B9B87350B5587", // 64-bit Windows on Intel
                    "60DEF5D19AF12B0962777B0B38CBA79A" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "503F9957F1FE77F23189507AFC641297", // MacOS
                    "B26C14FD53A4027C26FA3A57CB96AF4C", // 32-bit Windows
                    "EEEAF1FB2801EF0FB49B9B87350B5587", // 64-bit Windows on Intel
                    "60DEF5D19AF12B0962777B0B38CBA79A" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "31FCA720DAD2B27CCFD20D52F8E32B2D", // MacOS
                    "B65D496ADABF3DBCDB24136A9655C295", // 32-bit Windows
                    "6AD4BD76918C74B976FD7774163CD7ED", // 64-bit Windows on Intel
                    "2B2F9D57CFA1F3A0D63D261AD4750468" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "1D7F6BDC889271BEA523A07DD29BDD37", // MacOS
                    "365D7E965534C8690B4694B27D0CF1C9", // 32-bit Windows on Intel
                    "BCA45E90590A453EF4DBDCE3950C9CC4", // 32-bit Windows on AMD
                    "4E99289AFF43EA387442E30EAFB7305A", // 64-bit Windows on Intel
                    "85FBE50C3C18EFAB46DE754068F359BC" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "336CE3C01C6F9D430E6FC947B93820F7", // MacOS
                    "9A0F6E1984B428F236E1209C13AED4D1", // 32-bit Windows on Intel
                    "7FABBF9DDF1A16701E57C6DD190485E0", // 32-bit Windows on AMD
                    "47189DECF29E68A40F60645F97714BE3", // 64-bit Windows on Intel
                    "C40C18B162E7429F60C62DF6A23071D6" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "6F97B672D446B19B9370EE3FF4A5DCB5", // MacOS
                    "DDA8DBB070EA36F77455A41A2628B6AA", // 32-bit Windows on Intel
                    "9EBD64EEF7F1CB540012892515A3B0F5", // 32-bit Windows on AMD
                    "14145EA9D279E2FA457AD85F19DC0896", // 64-bit Windows on Intel
                    "A65D4DA9DB98F2DEF066508818C680CD" // 64-bit Windows on AMD
                }
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
                new[]
                {
                    "FD0ADBEFE09CE73D7A71768366A029A4", // MacOS
                    "5502D724D98AA24FE49FA8AFB0FC63A6", // 32-bit Windows on Intel
                    "838B5CABD1F8E0077559E4DF504842DC", // 32-bit Windows on AMD
                    "90D1426E435372B957E6558E4DC5D7FD", // 64-bit Windows on Intel
                    "8107A1714777E243320A2E72F8F1D6D7" // 64-bit Windows on AMD
                }
            },

            #endregion

#endif

            #region Lame MP3 Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "362C1DC415B6ED27B3BB0C43EEC7614A", // Lame 3.99.5 (Ubuntu 16.04)
                    "F2BD0875E273743A8908F96DCCFDFC44", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "7CB68FB7ACC70E8CD928E7DB437B16FE" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "3FBE256A1ABC2C530FAAA632929F9AC2", // Lame 3.99.5 (Ubuntu 16.04)
                    "1CB5B915B3A72CBE76087E16F96A0A3E", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "537DE5BA83AAF6542B2E29C74D405EC2" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "F2FFFC7C7001A93C0CC19466D51FC597", // Lame 3.99.5 (Ubuntu 16.04)
                    "1454732B48913F2A3898164BA366DA01", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "D6C2622620E83D442C80AADBE6B45921" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "BFF278600EB87215603D727BAA7905BD", // Lame 3.99.5 (Ubuntu 16.04)
                    "AD56C3A1ACD627DBDA4B5A28AFE0355D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "5BCC0ED414809596507ECFEDEBD4454D" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "EED1BD58A65E3CA92EEC176F156DEF24", // Lame 3.99.5 (Ubuntu 16.04)
                    "32EEC2B69A048975FB3BD034E8B392A4", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "32EA73E1A45C35F3FDDA998BC0849F2F" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "E73399A30F5497FD72E1AEE0A3E76EAF", // Lame 3.99.5 (Ubuntu 16.04)
                    "FB1B7DECB2C2A2C9CAA1FBB917A81472", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "A4306E31052226EFD081D5D5FA80F62B" // Lame 3.100 (Windows)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "LameMP3",
                new TestSettingDictionary(),
                new[]
                {
                    "E73399A30F5497FD72E1AEE0A3E76EAF", // Lame 3.99.5 (Ubuntu 16.04)
                    "FB1B7DECB2C2A2C9CAA1FBB917A81472", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "A4306E31052226EFD081D5D5FA80F62B" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "EED1BD58A65E3CA92EEC176F156DEF24", // Lame 3.99.5 (Ubuntu 16.04)
                    "32EEC2B69A048975FB3BD034E8B392A4", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "32EA73E1A45C35F3FDDA998BC0849F2F" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "8EEAF387756C09E867E45CAEF8649C53", // Lame 3.99.5 (Ubuntu 16.04)
                    "24F1B744BDA5C6A94B9FE6136DEC4614", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "A04B9E28A8E0CB84D2842627007146DD" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "EED1BD58A65E3CA92EEC176F156DEF24", // Lame 3.99.5 (Ubuntu 16.04)
                    "32EEC2B69A048975FB3BD034E8B392A4", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "32EA73E1A45C35F3FDDA998BC0849F2F" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "A7C95E4A6B3071F8C9498D4A705E2685", // Lame 3.99.5 (Ubuntu 16.04)
                    "1B5C266B6D799765BA1272BE28A7C435", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "0BBC28BA7AD11F619F18B030D47061B7" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "EED1BD58A65E3CA92EEC176F156DEF24", // Lame 3.99.5 (Ubuntu 16.04)
                    "32EEC2B69A048975FB3BD034E8B392A4", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "32EA73E1A45C35F3FDDA998BC0849F2F" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "2773A9EAC3A6E07FA1C71DD5FC730267", // Lame 3.99.5 (Ubuntu 16.04)
                    "5737ED221E55314FD5B9FA167C1C1651", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "E286B5641F602703E4A5B8EB1F872AA7" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "D05EA326944389E530612EAF314BB588", // Lame 3.99.5 (Ubuntu 16.04)
                    "D270226F14E850B208624CD2AC59512D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "E48008616899B2B56279BE94C00C8F27" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "472A428EDB8AD18369EEC4F748F80A59", // Lame 3.99.5 (Ubuntu 16.04)
                    "65D418A236D86A8CE33E07A76C98DF08", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "BB8B33BD589DA49D751C883B8A0FF653" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "E539FECE8D80128F11BA73148B92209F", // Lame 3.99.5 (Ubuntu 16.04)
                    "5DE234656056DFDAAD30E4DA9FD26366", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "3B10B6430B2A823C58F16953F5B33E9C" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "30520C93D354F17F637671B99BE75083", // Lame 3.99.5 (Ubuntu 16.04)
                    "2BBC83E74AB1A4EB150BC6E1EB9920B5", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "2ACEB0816512B4300D13E9329F76D752" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "464C9EE0662B447224805438FAC9D10E", // Lame 3.99.5 (Ubuntu 16.04)
                    "BEB5029A08011BCEDFFA99173B763E7F", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "E9525D2505684DDB3F9FDDE7B550577E" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "9CD9C9FCE1E42F79EDBAA84BA1B8D8C4", // Lame 3.99.5 (Ubuntu 16.04)
                    "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "54E8544993C1E818C72DE5AC00DEABF5" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "9CD9C9FCE1E42F79EDBAA84BA1B8D8C4", // Lame 3.99.5 (Ubuntu 16.04)
                    "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "54E8544993C1E818C72DE5AC00DEABF5" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "5BE352395ADE20729E8F68977C3043C7", // Lame 3.99.5 (Ubuntu 16.04)
                    "EACCA2FD6404ACA1AB46027FAE6A667B", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "AAE7CB7E1E4EAAF5ED19F8B986647298" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "9CD9C9FCE1E42F79EDBAA84BA1B8D8C4", // Lame 3.99.5 (Ubuntu 16.04)
                    "AD0C6C5DE14F77D2CFEE3F27EEA6B0C6", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "54E8544993C1E818C72DE5AC00DEABF5" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "B46B30D5E331FE64F24C620CFD5C717D", // Lame 3.99.5 (Ubuntu 16.04)
                    "10E44CEE38E66E9737677BE52E7A286D", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "EF2FAA877F1DE84DC87015F841103263" // Lame 3.100 (Windows)
                }
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
                new[]
                {
                    "C4BE1E9B133ECF06E397F812D5AF250E", // Lame 3.99.5 (Ubuntu 16.04)
                    "AFC1B4A4D1D02944A0902C5FA3A3E7E7", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "CFEF4A8950ACF179D92DC7930EE738EE", // Lame 3.100 (Legacy .NET on Windows)
                    "00B6F73984EF8978D057D2620D1541C9" // Lame 3.100 (.NET Core 3.0+ on Windows)
                }
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
                new[]
                {
                    "D4757E5D593DCB6C139790DFC4FE0C6D", // Lame 3.99.5 (Ubuntu 16.04)
                    "A3CEC39BF25ED93F5729BD8179853E2E", // Lame 3.100 (MacOS and Ubuntu 18.04)
                    "90E64D2E7628FC749E8194011E358854", // Lame 3.100 (Legacy .NET on Windows)
                    "17C5D78EB69791D271DC5FDC47C245BD" // Lame 3.100 (.NET Core 3.0+ on Windows)
                }
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
                new[]
                {
                    "169D4509DF879ADC61BBACA4C3CEDF49", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "C4CB008A88BB92E54CFCF5EB8CC6E6A4", // Vorbis 1.3.6 (MacOS)
                    "ED535E5C67B9EE0957D58E1EB8124158" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "2022FC0C77829D1CE73D57912FE7929E", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "CB5B49E015E1C1C8BD09459E860BBF4E", // Vorbis 1.3.6 (MacOS)
                    "D47CCFD390BB1BEBE25D10EFF729D5ED", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "CEC2E59B39269B3B2D2718D8CDB60D12", // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "62D12380155023C53AD1C679524B73EB", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "CDC01A83DE71D5A96FD39991C8C2885B", // Vorbis 1.3.6 (MacOS)
                    "168FC8CD7A8FE45927BC68E9A78A63F2" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "73C7A548A304C9A6668E9BADD05EF3D8", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "0FB3B4487F7D0A107FFF847C92520D8E", // Vorbis 1.3.6 (MacOS)
                    "C6D6F2C20EB47386FF1BD678FBBC823F" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "EC24791D57666C738DF852B537A7E93F", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "37FA56FB113CC847DD3054FD87B17D82", // Vorbis 1.3.6 (MacOS)
                    "891186CBF151E4F3BCE528CFAAB43678" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "FDAB2DD681F09A84236ECDF050B3086B", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "860F43037C8ECDC02233CDC1844601D3", // Vorbis 1.3.6 (MacOS)
                    "FB2F8F3FE4581E9854CD4A95C1CC4B33" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "AF6DC6FC3EB19867B56B0FB55C4D7410", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "8D77247996A63F24623793E9A8CD9427", // Vorbis 1.3.6 (MacOS)
                    "F13F58D39138CDBA4C42E4A7E5A56C19" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "Vorbis",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "AF6DC6FC3EB19867B56B0FB55C4D7410", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "8D77247996A63F24623793E9A8CD9427", // Vorbis 1.3.6 (MacOS)
                    "F13F58D39138CDBA4C42E4A7E5A56C19" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
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
                new[]
                {
                    "1EF6D099FFC64B6E2B54C87F0BFFE948", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "AD6CC65EA1BF0DE4A66DA6026D09C7E7", // Vorbis 1.3.6 (MacOS)
                    "3C7E2BDC5A976AC8A05EAEB43F4EFDE3" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
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
                new[]
                {
                    "50C94F4625B7E1B168212A564D3FCEE6", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "0BF600C8D2D7AF3BFA6ACD4055B2F1FB", // Vorbis 1.3.6 (MacOS)
                    "507AA2B1437339200556A6E5718346A2" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
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
                new[]
                {
                    "62D12380155023C53AD1C679524B73EB", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "CDC01A83DE71D5A96FD39991C8C2885B", // Vorbis 1.3.6 (MacOS)
                    "168FC8CD7A8FE45927BC68E9A78A63F2" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
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
                new[]
                {
                    "06BB339324CC08B4F9DB9AB549382313", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "17F6ED99258BC832478E7CAA273108BC", // Vorbis 1.3.6 (MacOS)
                    "04978FA3F4718F76C8BAA78EC1454346", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "BB5F44D6ECD09E9AED2D3DF7B23036B2" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)

                }
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
                new[]
                {
                    "FBD64FFF01984F2860E72F97841D4E45", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "5C5BF2D883D82E8673217524A66AFEF1", // Vorbis 1.3.6 (MacOS)
                    "94C6AC2DE1AF3349AD78A034B754C802", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "32220663AA048D7721C9868D45BF15FC" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "F403579CAB6AFD7FE440A96D2051BA57", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "4C98EB3D79436A6B768D1E9634088681", // Vorbis 1.3.6 (MacOS)
                    "693951E0DD85C845CCD5B818663C94C2", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "998DAD6B8CA915BD78B33A96EE043584" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "75FEA74C38068EC55547F91B7B921951", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "CB77612ABAD41C28D894B70831BA25E3", // Vorbis 1.3.6 (MacOS)
                    "09458DB1687084E904549BC99BB23918", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "70818F18E8CD266AB44DFB686FBB5334" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "EFB37C1BF555256EF774A346D8A7E726", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "582862413672D5290AC69019BEC4E576", // Vorbis 1.3.6 (MacOS)
                    "D5FB1B7D5C057107BD5C438BD48800BE", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "746E10DFB94D0749698F240D9151142B" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "EFB37C1BF555256EF774A346D8A7E726", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "582862413672D5290AC69019BEC4E576", // Vorbis 1.3.6 (MacOS)
                    "D5FB1B7D5C057107BD5C438BD48800BE", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "746E10DFB94D0749698F240D9151142B" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "76519119096606316467F962AAF6DDD8", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "B1598421FF7FCE6C8D69CB8DE68EBD1A", // Vorbis 1.3.6 (MacOS)
                    "3AA85218BD8F14462B329360E359F51D", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "96FB4F45EA0CD3EA0B4F0C30E1CE82AE" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "62D12380155023C53AD1C679524B73EB", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "CDC01A83DE71D5A96FD39991C8C2885B", // Vorbis 1.3.6 (MacOS)
                    "168FC8CD7A8FE45927BC68E9A78A63F2" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
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
                new[]
                {
                    "EFB37C1BF555256EF774A346D8A7E726", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "582862413672D5290AC69019BEC4E576", // Vorbis 1.3.6 (MacOS)
                    "D5FB1B7D5C057107BD5C438BD48800BE", // Vorbis 1.3.6 AoTuV + Lancer (Windows on Intel)
                    "746E10DFB94D0749698F240D9151142B" // Vorbis 1.3.6 AoTuV + Lancer (Windows on AMD)
                }
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
                new[]
                {
                    "62D12380155023C53AD1C679524B73EB", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "CDC01A83DE71D5A96FD39991C8C2885B", // Vorbis 1.3.6 (MacOS)
                    "168FC8CD7A8FE45927BC68E9A78A63F2" // Vorbis 1.3.6 AoTuV + Lancer (Windows)
                }
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
                new[]
                {
                    "F8D1973844C250D9960695304C5EE217", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "D21A100762D895FB5338204E81922971", // Vorbis 1.3.6 (MacOS)
                    "62D8E5794AFAC335E1D6396D5C9CD2BC", // Vorbis 1.3.6 AoTuV + Lancer (Legacy .NET on Windows / Intel)
                    "5E016C1161A7CFE96C0AADB3375BB5D6", // Vorbis 1.3.6 AoTuV + Lancer (Legacy .NET on Windows / AMD)
                    "B269083AA223F1C43699C181B6B6A987", // Vorbis 1.3.6 AoTuV + Lancer (.NET Core 3.0+ on Windows / Intel)
                    "3FB874EA12FB73A4C1D0AB1290B7C635" // Vorbis 1.3.6 AoTuV + Lancer (.NET Core 3.0+ on Windows / AMD)
                }
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
                new[]
                {
                    "1A35111ED26A079B6A972992C2E2105B", // Vorbis 1.3.5 (Ubuntu 16.04 and 18.04)
                    "DFA1457680EC838FBBB6C14CE83760B9", // Vorbis 1.3.6 (MacOS)
                    "2D26A6E733CC1788B55463088F8BACAF", // Vorbis 1.3.6 AoTuV + Lancer (Legacy .NET on Windows / Intel)
                    "5878C4C3C57547E1163039D40DD2802D", // Vorbis 1.3.6 AoTuV + Lancer (Legacy .NET on Windows / AMD)
                    "43693924C5126AC180A005E565104637", // Vorbis 1.3.6 AoTuV + Lancer (.NET Core 3.0+ on Windows / Intel)
                    "6320E9A1D0C2EBE13188DD9A1A615AAE" // Vorbis 1.3.6 AoTuV + Lancer (.NET Core 3.0+ on Windows / Intel)
                }
            },

            #endregion

            #region Opus Encoding

            new object[]
            {
                "LPCM 8-bit 8000Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "D085A7142C47B6898B3CCB6C5EDCBA55", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "2D31A0D707D3A9AB865DB00095EB08AE", // Opus 1.3.1 (MacOS)
                    "8BB7F2763D133BD534AE9C20104AFA2E", // Opus 1.3.1 (32-bit Windows on Intel)
                    "6FB30E2C70A48F63A6596FCDE747E47A", // Opus 1.3.1 (32-bit Windows on AMD)
                    "05B065E87CE35617089DC8A86ED5AD19", // Opus 1.3.1 (64-bit Windows on Intel)
                    "3E1D8B9F272D68F84209CA487120EFB1" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Mono.wav",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "46B412FA052C97474B60DDDCF2CA8052", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "C22E87F617B51970785E9A4C43C9FC48", // Opus 1.3.1 (MacOS)
                    "BE719CEBED7270CD6DC580007E20D5F2", // Opus 1.3.1 (32-bit Windows on Intel)
                    "B68DA72E32DD0B6A89138679E8716876", // Opus 1.3.1 (32-bit Windows on AMD)
                    "C8C92433A8093BB8C7AE3AE6F84653B3" // Opus 1.3.1 (64-bit Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "94AADBE44ECF34AF98982F17BCCE7C97", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "0C6BF7ECB9F757DB8F8AF485137BD2C8", // Opus 1.3.1 (MacOS)
                    "3CAB512976D0D62B45E2C9239B19735D", // Opus 1.3.1 (32-bit Windows on Intel)
                    "63CCEA9D4CF6847E5D6D29245372E93D", // Opus 1.3.1 (32-bit Windows on AMD)
                    "F82CC6FE2C86F5E7CD4A4F8F634E2DE9", // Opus 1.3.1 (64-bit Windows on Intel)
                    "A6ACF878EA0F60CF33EA9D214F814608" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 48000Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "C9024DED60E2039752C7B372DFFC7149", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "BD5F090F921BCC80F05FCBF5725D8E0E", // Opus 1.3.1 (MacOS)
                    "3C5EF551E97AEE3A916F1B39BCD5D3C2", // Opus 1.3.1 (32-bit Windows on Intel)
                    "B9B4ECB9629E3DCA58EC09AC5560A1F9", // Opus 1.3.1 (32-bit Windows on AMD)
                    "BD5F090F921BCC80F05FCBF5725D8E0E", // Opus 1.3.1 (64-bit Windows on Intel)
                    "FDE97144EB743A401CD274613B32D085" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 24-bit 96000Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "22AA639A1AA309F9C343F8D8EBDB1B6D", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "8A8FA9C452D9EBBCF8554EE3E270A538", // Opus 1.3.1 (MacOS)
                    "9E31F9F58A41EA377740E7AC43E57939", // Opus 1.3.1 (32-bit Windows on Intel)
                    "6D4CD77579FC6041A28997D9A409DCB4", // Opus 1.3.1 (32-bit Windows on AMD)
                    "D0FC8A33EE164AC29D79435A4ED779B1", // Opus 1.3.1 (64-bit Windows on Intel)
                    "EF01321114364EB70260DA0AC94553DB" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "1B7298B4EA52190612430642D2CD0694", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "5501D7D9730B0722C310D5263AFBEB77", // Opus 1.3.1 (MacOS)
                    "ED5EA746CA5182DE57E0D25695D17F4E", // Opus 1.3.1 (32-bit Windows on Intel)
                    "F6AE6DD4A2E565AD94622055C7DD2DD6", // Opus 1.3.1 (32-bit Windows on AMD)
                    "E59BFB7E77545D36723E7B8EB5AF1B48", // Opus 1.3.1 (64-bit Windows on Intel)
                    "0E862732E81AF56E0AF64B9878BEFED8" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - PNG).flac",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "476D30594189602BF6E4755E990D0615", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "0ADBC105EA51C62CB1ED53B978B33415", // Opus 1.3.1 (MacOS)
                    "17D464F4D94C17DD99AC0017BAB9228F", // Opus 1.3.1 (32-bit Windows on Intel)
                    "37FAD87A9C5A0E42FEEBE2B5CC5547DF", // Opus 1.3.1 (32-bit Windows on AMD)
                    "B52AE38B2D30A7ADE63492CCB2F000EC", // Opus 1.3.1 (64-bit Windows on Intel)
                    "285F9F24FA0B405F86C61AC20BE81333" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (PICTURE block - JPEG).flac",
                "Opus",
                new TestSettingDictionary
                {
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "476D30594189602BF6E4755E990D0615", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "0ADBC105EA51C62CB1ED53B978B33415", // Opus 1.3.1 (MacOS)
                    "17D464F4D94C17DD99AC0017BAB9228F", // Opus 1.3.1 (32-bit Windows on Intel)
                    "37FAD87A9C5A0E42FEEBE2B5CC5547DF", // Opus 1.3.1 (32-bit Windows on AMD)
                    "B52AE38B2D30A7ADE63492CCB2F000EC", // Opus 1.3.1 (64-bit Windows on Intel)
                    "285F9F24FA0B405F86C61AC20BE81333" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Minimum serial #
                    ["SerialNumber"] = int.MinValue
                },
                new[]
                {
                    "DE6D30BCAC9DA6340DA28542E75C5E01", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "CDE65307AACEA4F40F22FF925622D14E", // Opus 1.3.1 (MacOS)
                    "0E458849DBB876C84D23FA8B1AE58E7D", // Opus 1.3.1 (32-bit Windows on Intel)
                    "7BB78CF68981EC0D8A4FF3006F9D56D9", // Opus 1.3.1 (32-bit Windows on AMD)
                    "3804E9A98DDBD216A3AED6F638C5644E", // Opus 1.3.1 (64-bit Windows on Intel)
                    "211289691B8D3B688C68ADAE31CF17FA" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Maximum serial #
                    ["SerialNumber"] = int.MaxValue
                },
                new[]
                {
                    "D0DB0EE3ABC3950E3009663461F631DB", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "3AA89123958BA0DF1611539BC909DD0B", // Opus 1.3.1 (MacOS)
                    "049CE3FC2614A25BDE9E311CCEC4E995", // Opus 1.3.1 (32-bit Windows on Intel)
                    "2D4B0717D5E4BA6494A5A50131FABB2E", // Opus 1.3.1 (32-bit Windows on AMD)
                    "5480E19A91B0DC0891094B43168FA839", // Opus 1.3.1 (64-bit Windows on Intel)
                    "F07749A5027B6F7994D04ED84E75AC8E" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Minimum bit rate
                    ["BitRate"] = 5,
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "7556A3E6FF92CEF2D0ECD5654322DEAB", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "1F81AFD1976BAB56F31A4599A8AD8FF1", // Opus 1.3.1 (MacOS)
                    "FC89452B5F0EA49E3D738CE67FBF8B1C", // Opus 1.3.1 (32-bit Windows)
                    "D345EE9B84E231E3ACB17C7AC0972154" // Opus 1.3.1 (64-bit Windows)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Maximum bit rate
                    ["BitRate"] = 512,
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "C031F42E8AF2D482E302264E132502E1", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "785D39E686216F4958B8103B62E9E321", // Opus 1.3.1 (MacOS)
                    "6B422669A0FCB242E0E15204F5FDCC47", // Opus 1.3.1 (32-bit Windows on Intel)
                    "DFF654F2AF639F992FA9BC378F80FE20", // Opus 1.3.1 (32-bit Windows on AMD)
                    "4A9455EB95B3C9CBCB2538D0C888267D", // Opus 1.3.1 (64-bit Windows on Intel)
                    "0E9C8DE567A09A13D1D35A14BBB04A2D" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Variable control mode (default, explicit)
                    ["ControlMode"] = "Variable",
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "94AADBE44ECF34AF98982F17BCCE7C97", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "0C6BF7ECB9F757DB8F8AF485137BD2C8", // Opus 1.3.1 (MacOS)
                    "3CAB512976D0D62B45E2C9239B19735D", // Opus 1.3.1 (32-bit Windows on Intel)
                    "63CCEA9D4CF6847E5D6D29245372E93D", // Opus 1.3.1 (32-bit Windows on AMD)
                    "F82CC6FE2C86F5E7CD4A4F8F634E2DE9", // Opus 1.3.1 (64-bit Windows on Intel)
                    "A6ACF878EA0F60CF33EA9D214F814608" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Constrained VBR mode
                    ["ControlMode"] = "Constrained",
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "940955E239CF3D26B417F6B532EBC726", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "B98AC6052E465C5A226D8D2905B535EC", // Opus 1.3.1 (MacOS)
                    "38E90E75D928371AB9C1CFF243C731B4", // Opus 1.3.1 (32-bit Windows on Intel)
                    "7DB85D28D9AEF13C7D8BAB7578EC3019", // Opus 1.3.1 (32-bit Windows on AMD)
                    "E0219613A0740FACAAC162D7B9FD0517", // Opus 1.3.1 (64-bit Windows on Intel)
                    "2FEF54092E6C1442909D4B3A8F697632" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // CBR mode
                    ["ControlMode"] = "Constant",
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "9533FF6E154EE45B8ED522C3B5A25865", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "687B2402BF33EDB0EAD683235E309BC8", // Opus 1.3.1 (MacOS)
                    "0A4FC1F40FD76797222FC8CACCA83AD9", // Opus 1.3.1 (32-bit Windows on Intel)
                    "15F2F64E2FD60C135DE87B563DA028DF", // Opus 1.3.1 (32-bit Windows on AMD)
                    "F3CF4988FB774A297832863156B8ED8D", // Opus 1.3.1 (64-bit Windows on Intel)
                    "CD6404BF5B59DE41CE66F7D2C8838015" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Low bit rate, Music signal type (default)
                    ["BitRate"] = 32,
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "201BD7EF36658DB3DC9658C67E9AF71E", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "8FC7BCF02EDB42E9785797FD2C9A71D6", // Opus 1.3.1 (MacOS and Windows on Intel)
                    "BD1629D7E9272CAA8AEAC20FD576B7C6" // Opus 1.3.1 (Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Low bit rate, Music signal type (explicit)
                    ["SignalType"] = "Music",
                    ["BitRate"] = 32,
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "201BD7EF36658DB3DC9658C67E9AF71E", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "8FC7BCF02EDB42E9785797FD2C9A71D6", // Opus 1.3.1 (MacOS and Windows on Intel)
                    "BD1629D7E9272CAA8AEAC20FD576B7C6" // Opus 1.3.1 (Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // Low bit rate, Speech signal type
                    ["SignalType"] = "Speech",
                    ["BitRate"] = 32,
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "8AA73947B00AABCB3602F660E69263C5", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "84D72BBEF86EA7611518CF2862FC94BD", // Opus 1.3.1 (MacOS)
                    "F7583CA097F3B8D7EE50587DB0C9B883", // Opus 1.3.1 (32-bit Windows on Intel)
                    "CE832392AA59C20C39D1C246A96E31AC", // Opus 1.3.1 (32-bit Windows on AMD)
                    "0C29F2F289C7817FC177201ECCA21BC9", // Opus 1.3.1 (64-bit Windows on Intel)
                    "EE24D1F3BCA4485768E29F8F842B8009" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "LPCM 16-bit 44100Hz Stereo.wav",
                "Opus",
                new TestSettingDictionary
                {
                    // TrackGain requested but not available
                    ["ApplyGain"] = "Track",
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "94AADBE44ECF34AF98982F17BCCE7C97", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "0C6BF7ECB9F757DB8F8AF485137BD2C8", // Opus 1.3.1 (MacOS)
                    "3CAB512976D0D62B45E2C9239B19735D", // Opus 1.3.1 (32-bit Windows on Intel)
                    "63CCEA9D4CF6847E5D6D29245372E93D", // Opus 1.3.1 (32-bit Windows on AMD)
                    "F82CC6FE2C86F5E7CD4A4F8F634E2DE9", // Opus 1.3.1 (64-bit Windows on Intel)
                    "A6ACF878EA0F60CF33EA9D214F814608" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Opus",
                new TestSettingDictionary
                {
                    // Scaled to TrackGain
                    ["ApplyGain"] = "Track",
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "945B2B47707ED2C2DC2D30BD4AF75A34", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "B6029E9FC954A8722A1B10700F80EA19", // Opus 1.3.1 (MacOS)
                    "2B5AD4B688767C703DC63A83C3F96074", // Opus 1.3.1 (32-bit Windows on Intel)
                    "CE9599BAE9112521A52EC0749041D72C", // Opus 1.3.1 (32-bit Windows on AMD)
                    "AC629D5D7F3B004E75BE9F85D4B1DBD3", // Opus 1.3.1 (64-bit Windows on Intel)
                    "2844C8E28786F962FE6C611991FC3FFD" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            },

            new object[]
            {
                "FLAC Level 5 16-bit 44100Hz Stereo (Tagged using defaults).flac",
                "Opus",
                new TestSettingDictionary
                {
                    // Scaled to AlbumGain
                    ["ApplyGain"] = "Album",
                    ["SerialNumber"] = 1
                },
                new[]
                {
                    "2D5A8223552F6A731413BD1DD181040A", // Opus 1.1.2 (Ubuntu 16.04 and 18.04)
                    "EF6A93BC1F10A15E5F45255F36E90F3A", // Opus 1.3.1 (MacOS)
                    "509504BD68BD34AC79FECEA9073BAFB3", // Opus 1.3.1 (32-bit Windows on Intel)
                    "0AF4C3DCD598108BEA2671C1B784A10F", // Opus 1.3.1 (32-bit Windows on AMD)
                    "45911349F86066B37C0DBC7D6AC43890", // Opus 1.3.1 (64-bit Windows on Intel)
                    "2DA574E2734B174C0844847AAEF7643A" // Opus 1.3.1 (64-bit Windows on AMD)
                }
            }

            #endregion
        };

        public static IEnumerable<object[]> Data => _data.Select((item, index) => item.Prepend(index).ToArray());
    }
}