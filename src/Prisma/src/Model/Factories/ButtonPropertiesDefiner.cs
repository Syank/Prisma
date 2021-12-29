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
            ButtonProperties properties;

            string targetName = (targetButton as Control).Name;

            if (targetName == CloseWindowButtonProperties.buttonName) {
                properties = new CloseWindowButtonProperties();

            } else if (targetName == MinimizeWindowButtonProperties.buttonName) {
                properties = new MinimizeWindowButtonProperties();

            } else if (targetName.Contains(MenuOptionButtonProperties.buttonName)) {
                properties = new MenuOptionButtonProperties();

            } else {
                throw new Exception("No button implementation found");
            }

            return properties;
        }

    }

}
