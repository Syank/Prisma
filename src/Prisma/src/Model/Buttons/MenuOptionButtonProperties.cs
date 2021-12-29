using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.src.Model.Buttons {
    internal class MenuOptionButtonProperties : ButtonProperties {

        public static string buttonName = "MenuOption";

        public MenuOptionButtonProperties() {
            hoverBackgroundColor = Color.AliceBlue;
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
