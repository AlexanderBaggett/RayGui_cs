
namespace RayGui_cs
{
    [SuppressUnmanagedCodeSecurity]
    public static unsafe partial class RayGui
    { 
        [StructLayout(LayoutKind.Sequential)]
        public struct GuiStyleProp
        {
            public ushort controlId;
            public ushort propertyId;
            public int propertyValue;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GuiTextBoxState
        {
            public int cursor;
            public int start;
            public int index;
            public int select;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GuiTextBoxEditMode
        {
            //[MarshalAs(UnmanagedType.I1)]
            //public bool editMode;
            public CBool editMode;
            public int framesCounter;
        }
    }
}
