using FontAwesome.Sharp;
using Prisma.src.Model.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prisma.src.Model.Factories {
    internal class ButtonPropertiesDefiner {

        public static ButtonProperties getButtonPropertiesObject(object targetButton) {
            ButtonProperties button;
            Console.WriteLine(targetButton.GetType());
            if(targetButton is IconButton || targetButton is Panel) {
                string buttonName = (targetButton as IconButton).Name;

                if (buttonName == CloseWindowButtonProperties.buttonName) {
                    button = new CloseWindowButtonProperties();

                } else if (buttonName == MinizeWindowButtonProperties.buttonName) {
                    button = new MinizeWindowButtonProperties();

                } else if (buttonName.Contains(MenuOptionButtonProperties.buttonName)){
                    button = new MenuOptionButtonProperties();

                } else {
                    throw new Exception("No button implementation found");
                }

            } else {
                throw new Exception("Not a valid button");
            }

            return button;
        }

    }

}
