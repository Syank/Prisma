using FontAwesome.Sharp;
using Prisma.src.Model.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.src.Model.Factories {
    internal class ButtonPropertiesDefiner {

        public static ButtonProperties getButtonPropertiesObject(object targetButton) {
            ButtonProperties button;

            if(targetButton is IconButton) {
                string buttonName = (targetButton as IconButton).Name;

                if (buttonName == CloseWindowButtonProperties.buttonName) {
                    button = new CloseWindowButtonProperties();

                } else if (buttonName == MinizeWindowButtonProperties.buttonName) {
                    button = new MinizeWindowButtonProperties();

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
