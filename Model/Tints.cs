using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT13_Masudog.model
{
    internal class Tints
    {
        // Tints (Mixed with White) RGB Values
        public Color baseNavyBlue = Color.FromArgb(28, 40, 63);        // Base (0%) - #1C283F
        public Color softSlateBlue = Color.FromArgb(50, 62, 82);       // 10% White - #323E52
        public Color duskyBlue = Color.FromArgb(73, 83, 101);          // 20% White - #495365
        public Color softDenimBlue = Color.FromArgb(96, 105, 121);     // 30% White - #606979
        public Color heatherBlueGray = Color.FromArgb(119, 126, 140);  // 40% White - #777E8C
        public Color frostedSlateGray = Color.FromArgb(142, 148, 159); // 50% White - #8E949F
        public Color silverBlueGray = Color.FromArgb(164, 169, 178);   // 60% White - #A4A9B2
        public Color softLightGrayTint = Color.FromArgb(187, 191, 197);// 70% White - #BBBFC5
        public Color iceBlueSurfaceGray = Color.FromArgb(210, 212, 217);// 80% White - #D2D4D9
        public Color offWhiteBlueTint = Color.FromArgb(232, 233, 236); // 90% White - #E8E9EC
        public Color pureWhite = Color.FromArgb(255, 255, 255);        // 100% White - #FFFFFF
    }
}
