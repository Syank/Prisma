using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Prisma.src.Model.ColorUtils {
    internal class GradientBuilder {

        public static LinearGradientBrush buildGradientBrush(Rectangle clientRectangle, Dictionary<Color, float> colorsGradient, int rotation) {
            LinearGradientBrush brush = new LinearGradientBrush(clientRectangle, Color.Black, Color.Black, 0, false);
            
            ColorBlend colorBlender = new ColorBlend();

            Color[] colors = colorsGradient.Keys.ToArray<Color>();
            float[] positions = colorsGradient.Values.ToArray<float>();

            colorBlender.Positions = positions;
            colorBlender.Colors = colors;

            brush.InterpolationColors = colorBlender;

            brush.RotateTransform(rotation);

            return brush;
        }

    }

}
