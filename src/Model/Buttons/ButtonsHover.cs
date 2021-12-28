using FontAwesome.Sharp;
using Prisma.src.Model.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.src.Model.Buttons {
    internal class ButtonsHover {

        public static void hoverEnter(object targetElement) {
            ButtonProperties properties = ButtonPropertiesDefiner.getButtonPropertiesObject(targetElement);

            IconButton button = targetElement as IconButton;

            button.BackColor = properties.getHoverBackgroundColor();

        }

        public static void hoverExit(object targetElement) {
            ButtonProperties properties = ButtonPropertiesDefiner.getButtonPropertiesObject(targetElement);

            IconButton button = targetElement as IconButton;

            button.BackColor = properties.getNormalBackgroundColor();

        }

    }

}
