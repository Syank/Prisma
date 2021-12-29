using Prisma.src.Model.Factories;
using System.Windows.Forms;



namespace Prisma.src.Model.Buttons {
    internal class ButtonsHover {

        public static void hoverEnter(object targetElement) {
            ButtonProperties properties = ButtonPropertiesDefiner.getButtonPropertiesObject(targetElement);

            Control button = targetElement as Control;

            button.BackColor = properties.getHoverBackgroundColor();

        }

        public static void hoverExit(object targetElement) {
            ButtonProperties properties = ButtonPropertiesDefiner.getButtonPropertiesObject(targetElement);

            Control button = targetElement as Control;

            button.BackColor = properties.getNormalBackgroundColor();

        }

    }

}
