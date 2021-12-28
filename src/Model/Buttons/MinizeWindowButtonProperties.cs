using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.src.Model.Buttons {

    internal class MinizeWindowButtonProperties: ButtonProperties {

        public static string buttonName = "MinimizeWindowButton";

        public MinizeWindowButtonProperties() {
            hoverBackgroundColor = Color.FromArgb(51, 51, 51);
            normalBackgroundColor = Color.Transparent;

        }

        public override Color getHoverBackgroundColor() {
            return hoverBackgroundColor;
        }

        public override Color getNormalBackgroundColor() {
            return normalBackgroundColor;
        }

    }

}
