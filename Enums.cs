﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayGui_cs
{
    [SuppressUnmanagedCodeSecurity]
    public static unsafe partial class RayGui
    {
        public enum GuiState
        {
            STATE_NORMAL = 0,
            STATE_FOCUSED,
            STATE_PRESSED,
            STATE_DISABLED
        }

        public enum GuiTextAlignment
        {
            TEXT_ALIGN_LEFT = 0,
            TEXT_ALIGN_CENTER,
            TEXT_ALIGN_RIGHT
        }

        public enum GuiTextAlignmentVertical
        {
            TEXT_ALIGN_TOP = 0,
            TEXT_ALIGN_MIDDLE,
            TEXT_ALIGN_BOTTOM
        }

        public enum GuiTextWrapMode
        {
            TEXT_WRAP_NONE = 0,
            TEXT_WRAP_CHAR,
            TEXT_WRAP_WORD
        }

        public enum GuiControl
        {
            DEFAULT = 0,
            LABEL,
            BUTTON,
            TOGGLE,
            SLIDER,
            PROGRESSBAR,
            CHECKBOX,
            COMBOBOX,
            DROPDOWNBOX,
            TEXTBOX,
            VALUEBOX,
            SPINNER,
            LISTVIEW,
            COLORPICKER,
            SCROLLBAR,
            STATUSBAR
        }

        /// <summary>
        /// A convience enum for using
        /// GuiSetStyle
        /// That includses All of the different control properties
        /// available for all different types of controls
        /// </summary>
        public enum AllGuiProperties
        {
            BORDER_COLOR_NORMAL = 0,
            BASE_COLOR_NORMAL,
            TEXT_COLOR_NORMAL,
            BORDER_COLOR_FOCUSED,
            BASE_COLOR_FOCUSED,
            TEXT_COLOR_FOCUSED,
            BORDER_COLOR_PRESSED,
            BASE_COLOR_PRESSED,
            TEXT_COLOR_PRESSED,
            BORDER_COLOR_DISABLED,
            BASE_COLOR_DISABLED,
            TEXT_COLOR_DISABLED,
            BORDER_WIDTH,
            TEXT_PADDING,
            TEXT_ALIGNMENT,

            TEXT_SIZE = 16,
            TEXT_SPACING,
            LINE_COLOR,
            BACKGROUND_COLOR,
            TEXT_LINE_SPACING,
            TEXT_ALIGNMENT_VERTICAL,
            TEXT_WRAP_MODE,

            GROUP_PADDING = 16,

            SLIDER_WIDTH = 16,
            SLIDER_PADDING,

            PROGRESS_PADDING = 16,

            ARROWS_SIZE = 16,
            ARROWS_VISIBLE,
            SCROLL_SLIDER_PADDING,
            SCROLL_SLIDER_SIZE,
            SCROLL_PADDING,
            SCROLL_SPEED,

            CHECK_PADDING = 16,

            COMBO_BUTTON_WIDTH = 16,
            COMBO_BUTTON_SPACING,

            ARROW_PADDING = 16,
            DROPDOWN_ITEMS_SPACING,
            DROPDOWN_ARROW_HIDDEN,
            DROPDOWN_ROLL_UP,

            TEXT_READONLY = 16,

            SPIN_BUTTON_WIDTH = 16,
            SPIN_BUTTON_SPACING,

            LIST_ITEMS_HEIGHT = 16,
            LIST_ITEMS_SPACING,
            SCROLLBAR_WIDTH,
            SCROLLBAR_SIDE,
            LIST_ITEMS_BORDER_WIDTH,

            COLOR_SELECTOR_SIZE = 16,
            HUEBAR_WIDTH,
            HUEBAR_PADDING,
            HUEBAR_SELECTOR_HEIGHT,
            HUEBAR_SELECTOR_OVERFLOW
        }

        public enum GuiControlProperty
        {
            BORDER_COLOR_NORMAL = 0,
            BASE_COLOR_NORMAL,
            TEXT_COLOR_NORMAL,
            BORDER_COLOR_FOCUSED,
            BASE_COLOR_FOCUSED,
            TEXT_COLOR_FOCUSED,
            BORDER_COLOR_PRESSED,
            BASE_COLOR_PRESSED,
            TEXT_COLOR_PRESSED,
            BORDER_COLOR_DISABLED,
            BASE_COLOR_DISABLED,
            TEXT_COLOR_DISABLED,
            BORDER_WIDTH,
            TEXT_PADDING,
            TEXT_ALIGNMENT,
        }

        public enum GuiDefaultProperty
        {
            TEXT_SIZE = 16,
            TEXT_SPACING,
            LINE_COLOR,
            BACKGROUND_COLOR,
            TEXT_LINE_SPACING,
            TEXT_ALIGNMENT_VERTICAL,
            TEXT_WRAP_MODE
        }

        public enum GuiToggleProperty
        {
            GROUP_PADDING = 16,
        }

        public enum GuiSliderProperty
        {
            SLIDER_WIDTH = 16,
            SLIDER_PADDING
        }

        public enum GuiProgressBarProperty
        {
            PROGRESS_PADDING = 16,
        }

        public enum GuiScrollBarProperty
        {
            ARROWS_SIZE = 16,
            ARROWS_VISIBLE,
            SCROLL_SLIDER_PADDING,
            SCROLL_SLIDER_SIZE,
            SCROLL_PADDING,
            SCROLL_SPEED,
        }

        public enum GuiCheckBoxProperty
        {
            CHECK_PADDING = 16
        }

        public enum GuiComboBoxProperty
        {
            COMBO_BUTTON_WIDTH = 16,
            COMBO_BUTTON_SPACING
        }

        public enum GuiDropdownBoxProperty
        {
            ARROW_PADDING = 16,
            DROPDOWN_ITEMS_SPACING,
            DROPDOWN_ARROW_HIDDEN,
            DROPDOWN_ROLL_UP
        }

        public enum GuiTextBoxProperty
        {
            TEXT_READONLY = 16,
        }

        public enum GuiSpinnerProperty
        {
            SPIN_BUTTON_WIDTH = 16,
            SPIN_BUTTON_SPACING,
        }

        public enum GuiListViewProperty
        {
            LIST_ITEMS_HEIGHT = 16,
            LIST_ITEMS_SPACING,
            SCROLLBAR_WIDTH,
            SCROLLBAR_SIDE,
            LIST_ITEMS_BORDER_WIDTH
        }

        public enum GuiColorPickerProperty
        {
            COLOR_SELECTOR_SIZE = 16,
            HUEBAR_WIDTH,
            HUEBAR_PADDING,
            HUEBAR_SELECTOR_HEIGHT,
            HUEBAR_SELECTOR_OVERFLOW
        }
        public enum GuiIconName
        {
            ICON_NONE = 0,
            ICON_FOLDER_FILE_OPEN = 1,
            ICON_FILE_SAVE_CLASSIC = 2,
            ICON_FOLDER_OPEN = 3,
            ICON_FOLDER_SAVE = 4,
            ICON_FILE_OPEN = 5,
            ICON_FILE_SAVE = 6,
            ICON_FILE_EXPORT = 7,
            ICON_FILE_ADD = 8,
            ICON_FILE_DELETE = 9,
            ICON_FILETYPE_TEXT = 10,
            ICON_FILETYPE_AUDIO = 11,
            ICON_FILETYPE_IMAGE = 12,
            ICON_FILETYPE_PLAY = 13,
            ICON_FILETYPE_VIDEO = 14,
            ICON_FILETYPE_INFO = 15,
            ICON_FILE_COPY = 16,
            ICON_FILE_CUT = 17,
            ICON_FILE_PASTE = 18,
            ICON_CURSOR_HAND = 19,
            ICON_CURSOR_POINTER = 20,
            ICON_CURSOR_CLASSIC = 21,
            ICON_PENCIL = 22,
            ICON_PENCIL_BIG = 23,
            ICON_BRUSH_CLASSIC = 24,
            ICON_BRUSH_PAINTER = 25,
            ICON_WATER_DROP = 26,
            ICON_COLOR_PICKER = 27,
            ICON_RUBBER = 28,
            ICON_COLOR_BUCKET = 29,
            ICON_TEXT_T = 30,
            ICON_TEXT_A = 31,
            ICON_SCALE = 32,
            ICON_RESIZE = 33,
            ICON_FILTER_POINT = 34,
            ICON_FILTER_BILINEAR = 35,
            ICON_CROP = 36,
            ICON_CROP_ALPHA = 37,
            ICON_SQUARE_TOGGLE = 38,
            ICON_SYMMETRY = 39,
            ICON_SYMMETRY_HORIZONTAL = 40,
            ICON_SYMMETRY_VERTICAL = 41,
            ICON_LENS = 42,
            ICON_LENS_BIG = 43,
            ICON_EYE_ON = 44,
            ICON_EYE_OFF = 45,
            ICON_FILTER_TOP = 46,
            ICON_FILTER = 47,
            ICON_TARGET_POINT = 48,
            ICON_TARGET_SMALL = 49,
            ICON_TARGET_BIG = 50,
            ICON_TARGET_MOVE = 51,
            ICON_CURSOR_MOVE = 52,
            ICON_CURSOR_SCALE = 53,
            ICON_CURSOR_SCALE_RIGHT = 54,
            ICON_CURSOR_SCALE_LEFT = 55,
            ICON_UNDO = 56,
            ICON_REDO = 57,
            ICON_REREDO = 58,
            ICON_MUTATE = 59,
            ICON_ROTATE = 60,
            ICON_REPEAT = 61,
            ICON_SHUFFLE = 62,
            ICON_EMPTYBOX = 63,
            ICON_TARGET = 64,
            ICON_TARGET_SMALL_FILL = 65,
            ICON_TARGET_BIG_FILL = 66,
            ICON_TARGET_MOVE_FILL = 67,
            ICON_CURSOR_MOVE_FILL = 68,
            ICON_CURSOR_SCALE_FILL = 69,
            ICON_CURSOR_SCALE_RIGHT_FILL = 70,
            ICON_CURSOR_SCALE_LEFT_FILL = 71,
            ICON_UNDO_FILL = 72,
            ICON_REDO_FILL = 73,
            ICON_REREDO_FILL = 74,
            ICON_MUTATE_FILL = 75,
            ICON_ROTATE_FILL = 76,
            ICON_REPEAT_FILL = 77,
            ICON_SHUFFLE_FILL = 78,
            ICON_EMPTYBOX_SMALL = 79,
            ICON_BOX = 80,
            ICON_BOX_TOP = 81,
            ICON_BOX_TOP_RIGHT = 82,
            ICON_BOX_RIGHT = 83,
            ICON_BOX_BOTTOM_RIGHT = 84,
            ICON_BOX_BOTTOM = 85,
            ICON_BOX_BOTTOM_LEFT = 86,
            ICON_BOX_LEFT = 87,
            ICON_BOX_TOP_LEFT = 88,
            ICON_BOX_CENTER = 89,
            ICON_BOX_CIRCLE_MASK = 90,
            ICON_POT = 91,
            ICON_ALPHA_MULTIPLY = 92,
            ICON_ALPHA_CLEAR = 93,
            ICON_DITHERING = 94,
            ICON_MIPMAPS = 95,
            ICON_BOX_GRID = 96,
            ICON_GRID = 97,
            ICON_BOX_CORNERS_SMALL = 98,
            ICON_BOX_CORNERS_BIG = 99,
            ICON_FOUR_BOXES = 100,
            ICON_GRID_FILL = 101,
            ICON_BOX_MULTISIZE = 102,
            ICON_ZOOM_SMALL = 103,
            ICON_ZOOM_MEDIUM = 104,
            ICON_ZOOM_BIG = 105,
            ICON_ZOOM_ALL = 106,
            ICON_ZOOM_CENTER = 107,
            ICON_BOX_DOTS_SMALL = 108,
            ICON_BOX_DOTS_BIG = 109,
            ICON_BOX_CONCENTRIC = 110,
            ICON_BOX_GRID_BIG = 111,
            ICON_OK_TICK = 112,
            ICON_CROSS = 113,
            ICON_ARROW_LEFT = 114,
            ICON_ARROW_RIGHT = 115,
            ICON_ARROW_DOWN = 116,
            ICON_ARROW_UP = 117,
            ICON_ARROW_LEFT_FILL = 118,
            ICON_ARROW_RIGHT_FILL = 119,
            ICON_ARROW_DOWN_FILL = 120,
            ICON_ARROW_UP_FILL = 121,
            ICON_AUDIO = 122,
            ICON_FX = 123,
            ICON_WAVE = 124,
            ICON_WAVE_SINUS = 125,
            ICON_WAVE_SQUARE = 126,
            ICON_WAVE_TRIANGULAR = 127,
            ICON_CROSS_SMALL = 128,
            ICON_PLAYER_PREVIOUS = 129,
            ICON_PLAYER_PLAY_BACK = 130,
            ICON_PLAYER_PLAY = 131,
            ICON_PLAYER_PAUSE = 132,
            ICON_PLAYER_STOP = 133,
            ICON_PLAYER_NEXT = 134,
            ICON_PLAYER_RECORD = 135,
            ICON_MAGNET = 136,
            ICON_LOCK_CLOSE = 137,
            ICON_LOCK_OPEN = 138,
            ICON_CLOCK = 139,
            ICON_TOOLS = 140,
            ICON_GEAR = 141,
            ICON_GEAR_BIG = 142,
            ICON_BIN = 143,
            ICON_HAND_POINTER = 144,
            ICON_LASER = 145,
            ICON_COIN = 146,
            ICON_EXPLOSION = 147,
            ICON_1UP = 148,
            ICON_PLAYER = 149,
            ICON_PLAYER_JUMP = 150,
            ICON_KEY = 151,
            ICON_DEMON = 152,
            ICON_TEXT_POPUP = 153,
            ICON_GEAR_EX = 154,
            ICON_CRACK = 155,
            ICON_CRACK_POINTS = 156,
            ICON_STAR = 157,
            ICON_DOOR = 158,
            ICON_EXIT = 159,
            ICON_MODE_2D = 160,
            ICON_MODE_3D = 161,
            ICON_CUBE = 162,
            ICON_CUBE_FACE_TOP = 163,
            ICON_CUBE_FACE_LEFT = 164,
            ICON_CUBE_FACE_FRONT = 165,
            ICON_CUBE_FACE_BOTTOM = 166,
            ICON_CUBE_FACE_RIGHT = 167,
            ICON_CUBE_FACE_BACK = 168,
            ICON_CAMERA = 169,
            ICON_SPECIAL = 170,
            ICON_LINK_NET = 171,
            ICON_LINK_BOXES = 172,
            ICON_LINK_MULTI = 173,
            ICON_LINK = 174,
            ICON_LINK_BROKE = 175,
            ICON_TEXT_NOTES = 176,
            ICON_NOTEBOOK = 177,
            ICON_SUITCASE = 178,
            ICON_SUITCASE_ZIP = 179,
            ICON_MAILBOX = 180,
            ICON_MONITOR = 181,
            ICON_PRINTER = 182,
            ICON_PHOTO_CAMERA = 183,
            ICON_PHOTO_CAMERA_FLASH = 184,
            ICON_HOUSE = 185,
            ICON_HEART = 186,
            ICON_CORNER = 187,
            ICON_VERTICAL_BARS = 188,
            ICON_VERTICAL_BARS_FILL = 189,
            ICON_LIFE_BARS = 190,
            ICON_INFO = 191,
            ICON_CROSSLINE = 192,
            ICON_HELP = 193,
            ICON_FILETYPE_ALPHA = 194,
            ICON_FILETYPE_HOME = 195,
            ICON_LAYERS_VISIBLE = 196,
            ICON_LAYERS = 197,
            ICON_WINDOW = 198,
            ICON_HIDPI = 199,
            ICON_FILETYPE_BINARY = 200,
            ICON_HEX = 201,
            ICON_SHIELD = 202,
            ICON_FILE_NEW = 203,
            ICON_FOLDER_ADD = 204,
            ICON_ALARM = 205,
            ICON_CPU = 206,
            ICON_ROM = 207,
            ICON_STEP_OVER = 208,
            ICON_STEP_INTO = 209,
            ICON_STEP_OUT = 210,
            ICON_RESTART = 211,
            ICON_BREAKPOINT_ON = 212,
            ICON_BREAKPOINT_OFF = 213,
            ICON_BURGER_MENU = 214,
            ICON_CASE_SENSITIVE = 215,
            ICON_REG_EXP = 216,
            ICON_FOLDER = 217,
            ICON_FILE = 218,
            ICON_SAND_TIMER = 219,
            ICON_WARNING = 220,
            ICON_HELP_BOX = 221,
            ICON_INFO_BOX = 222,
            ICON_PRIORITY = 223,
            ICON_LAYERS_ISO = 224,
            ICON_LAYERS2 = 225,
            ICON_MLAYERS = 226,
            ICON_MAPS = 227,
            ICON_228 = 228,
            ICON_229 = 229,
            ICON_230 = 230,
            ICON_231 = 231,
            ICON_232 = 232,
            ICON_233 = 233,
            ICON_234 = 234,
            ICON_235 = 235,
            ICON_236 = 236,
            ICON_237 = 237,
            ICON_238 = 238,
            ICON_239 = 239,
            ICON_240 = 240,
            ICON_241 = 241,
            ICON_242 = 242,
            ICON_243 = 243,
            ICON_244 = 244,
            ICON_245 = 245,
            ICON_246 = 246,
            ICON_247 = 247,
            ICON_248 = 248,
            ICON_249 = 249,
            ICON_250 = 250,
            ICON_251 = 251,
            ICON_252 = 252,
            ICON_253 = 253,
            ICON_254 = 254,
            ICON_255 = 255,
        }
    }
}
