namespace RayGui_cs
{
    [SuppressUnmanagedCodeSecurity]
    public static unsafe partial class RayGui
    {
        /// <summary>
        /// Used by DllImport to load the native library
        /// </summary>
        public const string NativeLibName = "raygui";

        public const string rayGuiVersion = "4.0";

        public const int SCROLLBAR_LEFT_SIDE = 0;
        public const int SCROLLBAR_RIGHT_SIDE = 1;


        public const int RAYGUI_MAX_CONTROLS = 16;
        public const int RAYGUI_MAX_PROPS_BASE = 16;
        public const int RAYGUI_MAX_PROPS_EXTENDED = 8;

        public const int RAYGUI_ICON_SIZE = 16;
        public const int RAYGUI_ICON_MAX_ICONS = 256;
        public const int RAYGUI_ICON_MAX_NAME_LENGTH = 32;

        public const int RAYGUI_ICON_DATA_ELEMENTS = RAYGUI_ICON_SIZE * RAYGUI_ICON_SIZE / 32;

    }
}
