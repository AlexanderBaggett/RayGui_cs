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

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiLoadStyleDefault();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiEnableTooltip();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiDisableTooltip();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetTooltip(sbyte* tooltip);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* GuiIconText(int iconId, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiSetIconScale(int scale);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int * GuiGetIcons();

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int * GuiLoadIcons(sbyte* fileName, [MarshalAs(UnmanagedType.I1)] CBool loadIconsName);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiWindowBox(Rectangle bounds, sbyte* title);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiGroupBox(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiLine(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiPanel(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiTabBar(Rectangle bounds, sbyte*[] text, int count, int * active);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiScrollPanel(Rectangle bounds, sbyte* text, Rectangle content, Vector2 * scroll, Rectangle * view);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiLabel(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiButton(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiLabelButton(Rectangle bounds, sbyte* text);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiToggle(Rectangle bounds, sbyte* text, CBool * active);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiToggleGroup(Rectangle bounds, sbyte* text, int * active);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiToggleSlider(Rectangle bounds, sbyte* text, int * active);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiCheckBox(Rectangle bounds, sbyte* text, [MarshalAs(UnmanagedType.I1, MarshalCookie = "checked")] CBool* @checked);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiComboBox(Rectangle bounds, sbyte* text, int * active);

        [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GuiDropdownBox(Rectangle bounds, sbyte* text, int * active, CBool editMode);

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
