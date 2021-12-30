using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.src.Model.Menu {
    internal class MenuProperties {
        public static Dictionary<Color, float> colorsGradient { get; } = getColorsGradient();

        private static Dictionary<Color, float> getColorsGradient() {
            Dictionary<Color, float> colorsGradient = new Dictionary<Color, float>();

            colorsGradient.Add(Color.FromArgb(68, 2, 72), 0f);
            colorsGradient.Add(Color.FromArgb(111, 0, 0), 1f);

            return colorsGradient;
        }

    }

}
