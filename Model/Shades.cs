using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT13_Masudog.model
{
    internal class Shades
    {
        // Base & Shades (Mixed with Black) RGB Values
        public Color baseNavyBlue = Color.FromArgb(28, 40, 63);        // Base (0%) - #1C283F
        public Color darkMidnightBlue = Color.FromArgb(25, 36, 57);   // 10% Black - #192439
        public Color deepOceanNavy = Color.FromArgb(22, 32, 50);      // 20% Black - #162032
        public Color shadowBlue = Color.FromArgb(20, 28, 44);         // 30% Black - #141C2C
        public Color obsidianCharcoalBlue = Color.FromArgb(17, 24, 38);// 40% Black - #111826
        public Color nightNavyBlue = Color.FromArgb(14, 20, 32);      // 50% Black - #0E1420
        public Color abyssBlueBlack = Color.FromArgb(11, 16, 25);     // 60% Black - #0B1019
        public Color softJetBlackBlue = Color.FromArgb(8, 12, 19);    // 70% Black - #080C13
        public Color midnightBlack = Color.FromArgb(6, 8, 13);        // 80% Black - #06080D
        public Color charcoalBlack = Color.FromArgb(3, 4, 6);         // 90% Black - #030406
        public Color purePitchBlack = Color.FromArgb(0, 0, 0);        // 100% Black - #000000
    }
}
