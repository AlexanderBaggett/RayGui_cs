using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Raylib_cs;
using Font = Raylib_cs.Font;

namespace RayGui_cs
{
    [SuppressUnmanagedCodeSecurity]
    public static unsafe partial class RayGui
    {
        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiEnable();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiDisable();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiLock();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiUnlock();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern CBool GuiIsLocked();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetAlpha(float alpha);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetState(int state);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiGetState();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetFont(Font font);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Font GuiGetFont();

        /// <summary>
        /// Control and Property are both Enums
        /// In the underlying C language int and enum values are equal
        /// Just like we sometimes cast chars to ints in C#
        /// Property can be either something from : GuiControlProperty
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetStyle(int control, int property, int value);

        /// <summary>
        /// Convience method for working with Styles
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetStyle(GuiControl control, AllGuiProperties property, int value);

        /// <summary>
        /// Control and Property are both Enums
        /// In the underlying C language int and enum values are equal
        /// Just like we sometimes cast chars to ints in C#
        /// Property can be either something from : GuiControlProperty
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiGetStyle(int control, int property);
        
        /// <summary>
        /// Convience Version of GuiGetStyle
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiGetStyle(GuiControl control, AllGuiProperties property);



        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiLoadStyle(sbyte* fileName);

        public static void GuiLoadStyle(string fileName)
        {
            using var str1 = fileName.ToUtf8Buffer();
            GuiLoadStyle(str1.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiLoadStyleDefault();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiEnableTooltip();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiDisableTooltip();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetTooltip(sbyte* tooltip);
        public static void GuiSetTooltip(string tooltip)
        {
            using var str1 = tooltip.ToUtf8Buffer();
            GuiSetTooltip(str1.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* GuiIconText(int iconId, sbyte* text);
        public static string GuiIconText(int iconId, string text)
        {
            using var str1 = text.ToUtf8Buffer();
           var result = GuiIconText(iconId,str1.AsPointer());

            return Utf8StringUtils.GetUTF8String(result);
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetIconScale(int scale);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint * GuiGetIcons();

        public static uint[] GuiGetIcons(int iconCount)
        {
           List<uint> result = new List<uint>();
            var icons = GuiGetIcons();
            for (int i = 0; i < iconCount; i++)
            {
                uint icon = icons[i];
                result.Add(icon);
            }
            return result.ToArray();
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        //public static extern char** GuiLoadIcons(sbyte* fileName, [MarshalAs(UnmanagedType.I1)] CBool loadIconsName);
        public static extern sbyte** GuiLoadIcons(sbyte* fileName, [MarshalAs(UnmanagedType.I1)] CBool loadIconsName);
        public static string[] GuiLoadIcons(string fileName, bool loadIconsName, int numberOfIcons)
        {
            using var str1 = fileName.ToUtf8Buffer();

            var result = GuiLoadIcons(str1.AsPointer(), loadIconsName);

            List<string> list = new List<string>();
            for (int i = 0; i < numberOfIcons; i++)
            {
                sbyte* current_string = result[i];
                list.Add(Utf8StringUtils.GetUTF8String(current_string));
            }
            return list.ToArray();
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiWindowBox(Rectangle bounds, sbyte* title);
        public static int GuiWindowBox(Rectangle bounds, string title)
        {
            using var str = title.ToUtf8Buffer();
            return GuiWindowBox(bounds, str.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiGroupBox(Rectangle bounds, sbyte* text);
        public static int GuiGroupBox(Rectangle bounds, string text)
        {
            using var str = text.ToUtf8Buffer();
            return GuiGroupBox(bounds, str.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiLine(Rectangle bounds, sbyte* text);
        public static int GuiLine(Rectangle bounds, string text)
        {
            using var str = text.ToUtf8Buffer();
            return GuiLine(bounds, str.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiPanel(Rectangle bounds, sbyte* text);
        public static int GuiPanel(Rectangle bounds, string text)
        {
            using var str = text.ToUtf8Buffer();
            return GuiPanel(bounds, str.AsPointer());
        }


        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiTabBar(Rectangle bounds, sbyte*[] text, int count, int * active);

        public static int GuiTabBar(Rectangle bounds, string[] text, int count, ref int active)
        {
            sbyte*[] sbyteArray = new sbyte*[text.Length];
            for(int i = 0; i < count; i++)
            {
                sbyteArray[i] = text[i].ToUtf8Buffer().AsPointer();
            }
            int* activePtr = (int*)Unsafe.AsPointer(ref active);

            return GuiTabBar(bounds, sbyteArray,count,activePtr);
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiScrollPanel(Rectangle bounds, sbyte* text, Rectangle content, Vector2 * scroll, Rectangle * view);
        public static int GuiScrollPanel(Rectangle bounds, string text, Rectangle content, ref Vector2 scroll, ref Rectangle view)
        {
            using var str = text.ToUtf8Buffer();
            var scrollPointer =(Vector2 *) Unsafe.AsPointer(ref scroll);
            var viewPointer = (Rectangle *) Unsafe.AsPointer(ref view);

            return  GuiScrollPanel(bounds, str.AsPointer(), content, scrollPointer, viewPointer);
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiLabel(Rectangle bounds, sbyte* text);
        public static int GuiLabel(Rectangle bounds, string text)
        {
            using var str = text.ToUtf8Buffer();
            return GuiLabel(bounds, str.AsPointer());
        }
    
        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiButton(Rectangle bounds, sbyte* text);
        public static int GuiButton(Rectangle bounds, string text) 
        {
            using var str = text.ToUtf8Buffer();
            return GuiButton(bounds, str.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiLabelButton(Rectangle bounds, sbyte* text);
        public static int GuiLabelButton(Rectangle bounds, string text)
        {
            using var str = text.ToUtf8Buffer();
            return GuiLabelButton(bounds, str.AsPointer());
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiToggle(Rectangle bounds, sbyte* text, CBool * active);
        public static int GuiToggle(Rectangle bounds, string text, ref CBool active)
        {
            using var str = text.ToUtf8Buffer();
            return GuiToggle(bounds, str.AsPointer(), (CBool*) Unsafe.AsPointer(ref active));
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiToggleGroup(Rectangle bounds, sbyte* text, int * active);
        public static int GuiToggleGroup(Rectangle bounds, string text, ref int active)
        {
            using var str = text.ToUtf8Buffer();
            return GuiToggleGroup(bounds, str.AsPointer(), (int*)Unsafe.AsPointer(ref active));
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiToggleSlider(Rectangle bounds, sbyte* text, int * active);
        public static int GuiToggleSlider(Rectangle bounds, string text, ref int active)
        {
            using var str = text.ToUtf8Buffer();
            return GuiToggleSlider(bounds, str.AsPointer(), (int*)Unsafe.AsPointer(ref active));
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiCheckBox(Rectangle bounds, sbyte* text, [MarshalAs(UnmanagedType.I1, MarshalCookie = "checked")] CBool* @checked);

        public static int GuiCheckBox(Rectangle bounds, string text, ref CBool @checked)
        {
            using var str = text.ToUtf8Buffer();
            return GuiCheckBox(bounds, str.AsPointer(), (CBool*)Unsafe.AsPointer(ref @checked));
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiComboBox(Rectangle bounds, sbyte* text, int * active);
        public static int GuiComboBox(Rectangle bounds, string text, ref int active)
        {
            using var str = text.ToUtf8Buffer();
            return GuiComboBox(bounds, str.AsPointer(), (int*) Unsafe.AsPointer(ref active));
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiDropdownBox(Rectangle bounds, sbyte* text, int * active, CBool editMode);
        public static int GuiDropdownBox(Rectangle bounds, string text, ref int active, bool editMode)
        {
            using var str = text.ToUtf8Buffer();
            return GuiDropdownBox(bounds, str.AsPointer(), (int*)Unsafe.AsPointer(ref active), editMode);
        }

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiSpinner(Rectangle bounds, sbyte* text, int * value, int minValue, int maxValue, CBool editMode);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiValueBox(Rectangle bounds, sbyte* text, int * value, int minValue, int maxValue, CBool editMode);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiValueBoxFloat(Rectangle bounds, sbyte* text,  sbyte* textValue,  float * value, CBool editMode);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiTextBox(Rectangle bounds, sbyte* text, int textSize, CBool editMode);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiSlider(Rectangle bounds, sbyte* textLeft, sbyte* textRight,  float * value, float minValue, float maxValue);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiSliderBar(Rectangle bounds, sbyte* textLeft, sbyte* textRight, float * value, float minValue, float maxValue);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiProgressBar(Rectangle bounds, sbyte* textLeft, sbyte* textRight, float * value, float minValue, float maxValue);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiStatusBar(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiDummyRec(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiGrid(Rectangle bounds, sbyte* text, float spacing, int subdivs, Vector2 * mouseCell);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiListView(Rectangle bounds, sbyte* text, int * scrollIndex, int * active);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiListViewEx(Rectangle bounds, sbyte*[] text, int count, int * scrollIndex, int * active, int * focus);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiMessageBox(Rectangle bounds, sbyte* title, sbyte* message, sbyte* buttons);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiTextInputBox(Rectangle bounds, sbyte* title, sbyte* message, sbyte* buttons, sbyte* text, int textMaxSize,  CBool * secretViewActive);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiColorPicker(Rectangle bounds, sbyte* text, Color * color);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiColorPanel(Rectangle bounds, sbyte* text, Color * color);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiColorBarAlpha(Rectangle bounds, sbyte* text, float * alpha);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiColorBarHue(Rectangle bounds, sbyte* text, float * value);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiColorPickerHSV(Rectangle bounds, sbyte* text, Vector3 * colorHsv);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiColorPanelHSV(Rectangle bounds, sbyte* text, Vector3 * colorHsv);
   
    }
}
