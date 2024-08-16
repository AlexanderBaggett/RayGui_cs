using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RayGui_cs.RayGui;

namespace RayGui_cs
{
    public static unsafe partial class RayGui
    {
        // GuiTextSplit function (custom implementation might be needed)
        public static string[] GuiTextSplit(string text, char delimiter, ref int count)
        {
            string[] result = text.Split(delimiter);
            count = result.Length;
            return result;
        }

        // ConvertHSVtoRGB function
        public static Vector3 ConvertHSVtoRGB(Vector3 hsv)
        {
            Vector3 rgb = new Vector3();
            float hh, p, q, t, ff;
            long i;

            if (hsv.Y <= 0.0f)
            {
                rgb.X = hsv.Z;
                rgb.Y = hsv.Z;
                rgb.Z = hsv.Z;
                return rgb;
            }

            hh = hsv.X;
            if (hh >= 360.0f) hh = 0.0f;
            hh /= 60.0f;
            i = (long)hh;
            ff = hh - i;
            p = hsv.Z * (1.0f - hsv.Y);
            q = hsv.Z * (1.0f - (hsv.Y * ff));
            t = hsv.Z * (1.0f - (hsv.Y * (1.0f - ff)));

            switch (i)
            {
                case 0:
                    rgb.X = hsv.Z;
                    rgb.Y = t;
                    rgb.Z = p;
                    break;
                case 1:
                    rgb.X = q;
                    rgb.Y = hsv.Z;
                    rgb.Z = p;
                    break;
                case 2:
                    rgb.X = p;
                    rgb.Y = hsv.Z;
                    rgb.Z = t;
                    break;
                case 3:
                    rgb.X = p;
                    rgb.Y = q;
                    rgb.Z = hsv.Z;
                    break;
                case 4:
                    rgb.X = t;
                    rgb.Y = p;
                    rgb.Z = hsv.Z;
                    break;
                default:
                    rgb.X = hsv.Z;
                    rgb.Y = p;
                    rgb.Z = q;
                    break;
            }

            return rgb;
        }

        // ConvertRGBtoHSV function
        public static Vector3 ConvertRGBtoHSV(Vector3 rgb)
        {
            Vector3 hsv = new Vector3();
            float min, max, delta;

            min = rgb.X < rgb.Y ? rgb.X : rgb.Y;
            min = min < rgb.Z ? min : rgb.Z;

            max = rgb.X > rgb.Y ? rgb.X : rgb.Y;
            max = max > rgb.Z ? max : rgb.Z;

            hsv.Z = max;
            delta = max - min;

            if (delta < 0.00001f)
            {
                hsv.Y = 0;
                hsv.X = 0;
                return hsv;
            }

            if (max > 0.0f)
            {
                hsv.Y = (delta / max);
            }
            else
            {
                hsv.Y = 0.0f;
                hsv.X = 0.0f;
                return hsv;
            }

            if (rgb.X >= max)
                hsv.X = (rgb.Y - rgb.Z) / delta;
            else if (rgb.Y >= max)
                hsv.X = 2.0f + (rgb.Z - rgb.X) / delta;
            else
                hsv.X = 4.0f + (rgb.X - rgb.Y) / delta;

            hsv.X *= 60.0f;

            if (hsv.X < 0.0f) hsv.X += 360.0f;

            return hsv;
        }


        public static Color GuiFade(Color color, float alpha)
        {
            if (alpha < 0.0f) alpha = 0.0f;
            else if (alpha > 1.0f) alpha = 1.0f;

            return new Color(color.R, color.G, color.B, (byte)(color.A * alpha));
        }

        //public static int GuiSliderPro(Rectangle bounds, string textLeft, string textRight, ref float value, float minValue, float maxValue, int sliderWidth)
        //{
        //    int result = 0;
        //    GuiState state = (GuiState)GuiGetState();

        //    float temp = (maxValue - minValue) / 2.0f;
        //    float* tempValue = &temp;

        //    int sliderValue = (int)(((value - minValue) / (maxValue - minValue)) * (bounds.Width - 2 * GuiGetStyle((int)GuiControl.SLIDER, (int)GuiControlProperty.BORDER_WIDTH)));

        //    Rectangle slider = new Rectangle
        //    {
        //        X = bounds.X,
        //        Y = bounds.Y + GuiGetStyle((int)GuiControl.SLIDER, (int)GuiControlProperty.BORDER_WIDTH) + GuiGetStyle((int)GuiControl.SLIDER, (int)GuiSliderProperty.SLIDER_PADDING),
        //        Width = 0,
        //        Height = bounds.Height - 2 * GuiGetStyle((int)GuiControl.SLIDER, (int)GuiControlProperty.BORDER_WIDTH) - 2 * GuiGetStyle((int)GuiControl.SLIDER, (int)GuiSliderProperty.SLIDER_PADDING)
        //    };

        //    if (sliderWidth > 0)
        //    {
        //        slider.X += (sliderValue - sliderWidth / 2);
        //        slider.Width = sliderWidth;
        //    }
        //    else if (sliderWidth == 0)
        //    {
        //        slider.X += GuiGetStyle((int)GuiControl.SLIDER, (int)GuiControlProperty.BORDER_WIDTH);
        //        slider.Width = sliderValue;
        //    }

        //    // Update control
        //    if ((state != GuiState.STATE_DISABLED) && !guiLocked)
        //    {
        //        Vector2 mousePoint = GetMousePosition();

        //        if (guiSliderDragging)
        //        {
        //            if (IsMouseButtonDown(MouseButton.Left))
        //            {
        //                if (CHECK_BOUNDS_ID(bounds, guiSliderActive))
        //                {
        //                    state = GuiState.STATE_PRESSED;

        //                    // Get equivalent value and slider position from mousePoint.X
        //                    value = ((maxValue - minValue) * (mousePoint.X - (bounds.X + sliderWidth / 2))) / (bounds.Width - sliderWidth) + minValue;
        //                }
        //            }
        //            else
        //            {
        //                guiSliderDragging = false;
        //                guiSliderActive = new Rectangle();
        //            }
        //        }
        //        else if (CheckCollisionPointRec(mousePoint, bounds))
        //        {
        //            if (IsMouseButtonDown(MouseButton.Left))
        //            {
        //                state = GuiState.STATE_PRESSED;
        //                guiSliderDragging = true;
        //                guiSliderActive = bounds;

        //                if (!CheckCollisionPointRec(mousePoint, slider))
        //                {
        //                    value = ((maxValue - minValue) * (mousePoint.X - (bounds.X + sliderWidth / 2))) / (bounds.Width - sliderWidth) + minValue;

        //                    if (sliderWidth > 0) slider.X = mousePoint.X - slider.Width / 2;
        //                    else if (sliderWidth == 0) slider.Width = sliderValue;
        //                }
        //            }
        //            else state = GuiState.STATE_FOCUSED;
        //        }

        //        if (value > maxValue) value = maxValue;
        //        else if (value < minValue) value = minValue;
        //    }

        //    // Bar limits check
        //    if (sliderWidth > 0)
        //    {
        //        if (slider.X <= (bounds.X + GuiGetStyle(GuiControl.SLIDER, GuiControlProperty.BORDER_WIDTH))) slider.X = bounds.X + GuiGetStyle(GuiControl.SLIDER, GuiControlProperty.BORDER_WIDTH);
        //        else if ((slider.X + slider.Width) >= (bounds.X + bounds.Width)) slider.X = bounds.X + bounds.Width - slider.Width - GuiGetStyle(GuiControl.SLIDER, GuiControlProperty.BORDER_WIDTH);
        //    }
        //    else if (sliderWidth == 0)
        //    {
        //        if (slider.Width > bounds.Width) slider.Width = bounds.Width - 2 * GuiGetStyle(GuiControl.SLIDER, GuiControlProperty.BORDER_WIDTH);
        //    }

        //    // Draw control
        //    GuiDrawRectangle(bounds, GuiGetStyle(GuiControl.SLIDER, GuiControlProperty.BORDER_WIDTH), GetColor(GuiGetStyle(GuiControl.SLIDER, (int)state * 3 + (int)GuiControlProperty.BORDER_COLOR_NORMAL)), GetColor(GuiGetStyle(GuiControl.SLIDER, (int)GuiControlProperty.BASE_COLOR_NORMAL)));

        //    // Draw slider internal bar
        //    if (state == GuiState.STATE_NORMAL) GuiDrawRectangle(slider, 0, Color.BLANK, GetColor(GuiGetStyle(GuiControl.SLIDER, (int)GuiControlProperty.BASE_COLOR_PRESSED)));
        //    else if (state == GuiState.STATE_FOCUSED) GuiDrawRectangle(slider, 0, Color.BLANK, GetColor(GuiGetStyle(GuiControl.SLIDER, (int)GuiControlProperty.TEXT_COLOR_FOCUSED)));
        //    else if (state == GuiState.STATE_PRESSED) GuiDrawRectangle(slider, 0, Color.BLANK, GetColor(GuiGetStyle(GuiControl.SLIDER, (int)GuiControlProperty.TEXT_COLOR_PRESSED)));

        //    // Draw left/right text if provided
        //    if (textLeft != null)
        //    {
        //        Rectangle textBounds = new Rectangle();
        //        textBounds.Width = (float)GetTextWidth(textLeft);
        //        textBounds.Height = (float)GuiGetStyle(GuiControl.DEFAULT, (int)GuiControlProperty.TEXT_SIZE);
        //        textBounds.X = bounds.X - textBounds.Width - GuiGetStyle(GuiControl.SLIDER, (int)GuiControlProperty.TEXT_PADDING);
        //        textBounds.Y = bounds.Y + bounds.Height / 2 - GuiGetStyle(GuiControl.DEFAULT, (int)GuiControlProperty.TEXT_SIZE) / 2;

        //        GuiDrawText(textLeft, textBounds, GuiTextAlignment.TEXT_ALIGN_RIGHT, GetColor(GuiGetStyle(GuiControl.SLIDER, (int)state * 3 + (int)GuiControlProperty.TEXT_COLOR_NORMAL)));
        //    }

        //    if (textRight != null)
        //    {
        //        Rectangle textBounds = new Rectangle();
        //        textBounds.Width = (float)GetTextWidth(textRight);
        //        textBounds.Height = (float)GuiGetStyle(GuiControl.DEFAULT, (int)GuiControlProperty.TEXT_SIZE);
        //        textBounds.X = bounds.X + bounds.Width + GuiGetStyle((int)GuiControl.SLIDER, (int)GuiControlProperty.TEXT_PADDING);
        //        textBounds.Y = bounds.Y + bounds.Height / 2 - GuiGetStyle(GuiControl.DEFAULT, (int)GuiControlProperty.TEXT_SIZE) / 2;

        //        GuiDrawText(textRight, textBounds, GuiTextAlignment.TEXT_ALIGN_LEFT, GetColor(GuiGetStyle(GuiControl.SLIDER, (int)state * 3 + (int)GuiControlProperty.TEXT_COLOR_NORMAL)));
        //    }

        //    return result;
        //}
    }
}
