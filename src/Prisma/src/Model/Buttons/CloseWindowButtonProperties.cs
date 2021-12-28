using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Prisma.src.Model.Buttons {
    internal class CloseWindowButtonProperties: ButtonProperties {

        public static string buttonName = "CloseWindowButton";

        public CloseWindowButtonProperties() {
            hoverBackgroundColor = Color.Red;
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
