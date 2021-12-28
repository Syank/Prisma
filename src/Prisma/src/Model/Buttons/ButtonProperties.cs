using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.src.Model.Buttons {
    internal abstract class ButtonProperties {

        public static Color hoverBackgroundColor { get; set; }
        public static Color normalBackgroundColor { get; set; }

        public abstract Color getHoverBackgroundColor();

        public abstract Color getNormalBackgroundColor();

    }

}
