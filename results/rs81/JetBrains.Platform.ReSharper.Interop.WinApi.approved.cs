[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Concurrency
{
    
    [System.Runtime.InteropServices.GuidAttribute("CB2F6723-AB3A-11d2-9C40-00C04FA30A3E")]
    public class CorRuntimeHost
    {
        public CorRuntimeHost() { }
    }
}
namespace JetBrains.Interop.WinApi
{
    
    [System.FlagsAttribute()]
    public enum AccessRights : uint
    {
        GENERIC_READ = 2147483648u,
        GENERIC_WRITE = 1073741824u,
        GENERIC_EXECUTE = 536870912u,
        GENERIC_ALL = 268435456u,
        ACCESS_SYSTEM_SECURITY = 16777216u,
        DELETE = 65536u,
        READ_CONTROL = 131072u,
        WRITE_DAC = 262144u,
        WRITE_OWNER = 524288u,
        SYNCHRONIZE = 1048576u,
        STANDARD_RIGHTS_READ = 131072u,
        STANDARD_RIGHTS_WRITE = 131072u,
        STANDARD_RIGHTS_EXECUTE = 131072u,
        STANDARD_RIGHTS_ALL = 2031616u,
        SPECIFIC_RIGHTS_ALL = 65535u,
        MAXIMUM_ALLOWED = 33554432u,
        STANDARD_RIGHTS_REQUIRED = 983040u,
    }
    public class static Advapi32Dll
    {
        public static bool AdjustTokenPrivileges(System.Void* TokenHandle, bool DisableAllPrivileges, JetBrains.Interop.WinApi.TOKEN_PRIVILEGES* NewState, uint BufferLengthInBytes, JetBrains.Interop.WinApi.TOKEN_PRIVILEGES* PreviousState, System.UInt32* ReturnLengthInBytes) { }
        public static bool GetTokenInformation(System.Void* TokenHandle, JetBrains.Interop.WinApi.Declarations.Constants.TOKEN_INFORMATION_CLASS TokenInformationClass, System.Void* TokenInformation, uint TokenInformationLength, System.UInt32* ReturnLength) { }
        public static bool LookupPrivilegeValueW(string lpSystemName, string lpName, JetBrains.Interop.WinApi.LUID* lpLuid) { }
        public static bool OpenProcessToken(System.Void* ProcessHandle, uint DesiredAccess, System.Void** TokenHandle) { }
        public static int QueryServiceStatusEx(System.Void* hService, JetBrains.Interop.WinApi.SC_STATUS_TYPE InfoLevel, System.Void* lpBuffer, uint cbBufSize, System.UInt32* pcbBytesNeeded) { }
        public static int RegCloseKey(System.Void* hKey) { }
        public static int RegCreateKeyExW(System.Void* hKey, string lpSubKey, uint Reserved, string lpClass, uint dwOptions, uint samDesired, System.Void* lpSecurityAttributes, System.Void** phkResult, System.UInt32* lpdwDisposition) { }
        public static int RegDeleteKeyExW(System.Void* hKey, string lpSubKey, uint samDesired, uint Reserved) { }
        public static int RegDeleteValueW(System.Void* hKey, string lpValueName) { }
        public static int RegEnumKeyExW(System.Void* hKey, uint index, System.Text.StringBuilder lpName, System.UInt32* lpcName, System.UInt32* lpReserved, System.Text.StringBuilder lpClass, System.UInt32* lpcClass, System.Runtime.InteropServices.ComTypes.FILETIME* lpftLastWriteTime) { }
        public static int RegEnumValueW(System.Void* hKey, uint index, System.Text.StringBuilder lpValueName, System.UInt32* lpcValueName, System.UInt32* lpReserved, System.UInt32* lpType, System.Byte* lpData, System.UInt32* lpcbData) { }
        public static int RegLoadKeyW(System.Void* hKey, string lpSubKey, string lpFile) { }
        public static int RegOpenKeyExW(System.Void* hKey, string lpSubKey, uint ulOptions, uint samDesired, System.Void** phkResult) { }
        public static int RegQueryInfoKeyW(System.Void* hKey, System.Text.StringBuilder lpClass, System.UInt32* lpcbClass, System.UInt32* lpReserved, System.UInt32* lpcSubKeys, System.UInt32* lpcbMaxSubKeyLen, System.UInt32* lpcbMaxClassLen, System.UInt32* lpcValues, System.UInt32* lpcbMaxValueNameLen, System.UInt32* lpcbMaxValueLen, System.UInt32* lpcbSecurityDescriptor, System.Runtime.InteropServices.ComTypes.FILETIME* lpftLastWriteTime) { }
        public static int RegQueryValueExW(System.Void* hKey, string lpValueName, System.UInt32* lpReserved, System.UInt32* lpType, System.Byte* lpData, System.UInt32* lpcbData) { }
        public static int RegSetValueExW(System.Void* hKey, string lpValueName, uint Reserved, uint dwType, System.Byte* lpData, uint cbData) { }
        public static int RegUnLoadKeyW(System.Void* hKey, string lpSubKey) { }
        public static uint SetNamedSecurityInfoW(string objectName, JetBrains.Interop.WinApi.Declarations.Structures.SE_OBJECT_TYPE objectType, uint securityInfo, System.Void* psidOwner, System.Void* psidGroup, System.Void* pdacl, System.Void* psacl) { }
    }
    public delegate System.UIntPtr CallBack(System.IntPtr hwnd, JetBrains.Interop.WinApi.WindowsMessages msg, System.IntPtr wParam, System.IntPtr lParam);
    public enum CombineRgnStyles
    {
        RGN_AND = 1,
        RGN_OR = 2,
        RGN_XOR = 3,
        RGN_DIFF = 4,
        RGN_COPY = 5,
        RGN_MIN = 1,
        RGN_MAX = 5,
    }
    public class static ConnectDll
    {
        public class static Helpers
        {
            public static bool IsInternetConnected() { }
        }
    }
    [System.FlagsAttribute()]
    public enum CorSymSearchPolicyAttributes : uint
    {
        AllowRegistryAccess = 1u,
        AllowSymbolServerAccess = 2u,
        AllowOriginalPathAccess = 4u,
        AllowReferencePathAccess = 8u,
    }
    public enum CSIDL
    {
        CSIDL_DESKTOP = 0,
        CSIDL_INTERNET = 1,
        CSIDL_PROGRAMS = 2,
        CSIDL_CONTROLS = 3,
        CSIDL_PRINTERS = 4,
        CSIDL_PERSONAL = 5,
        CSIDL_FAVORITES = 6,
        CSIDL_STARTUP = 7,
        CSIDL_RECENT = 8,
        CSIDL_SENDTO = 9,
        CSIDL_BITBUCKET = 10,
        CSIDL_STARTMENU = 11,
        CSIDL_MYDOCUMENTS = 5,
        CSIDL_MYMUSIC = 13,
        CSIDL_MYVIDEO = 14,
        CSIDL_DESKTOPDIRECTORY = 16,
        CSIDL_DRIVES = 17,
        CSIDL_NETWORK = 18,
        CSIDL_NETHOOD = 19,
        CSIDL_FONTS = 20,
        CSIDL_TEMPLATES = 21,
        CSIDL_COMMON_STARTMENU = 22,
        CSIDL_COMMON_PROGRAMS = 23,
        CSIDL_COMMON_STARTUP = 24,
        CSIDL_COMMON_DESKTOPDIRECTORY = 25,
        CSIDL_APPDATA = 26,
        CSIDL_PRINTHOOD = 27,
        CSIDL_LOCAL_APPDATA = 28,
        CSIDL_ALTSTARTUP = 29,
        CSIDL_COMMON_ALTSTARTUP = 30,
        CSIDL_COMMON_FAVORITES = 31,
        CSIDL_INTERNET_CACHE = 32,
        CSIDL_COOKIES = 33,
        CSIDL_HISTORY = 34,
        CSIDL_COMMON_APPDATA = 35,
        CSIDL_WINDOWS = 36,
        CSIDL_SYSTEM = 37,
        CSIDL_PROGRAM_FILES = 38,
        CSIDL_MYPICTURES = 39,
        CSIDL_PROFILE = 40,
        CSIDL_SYSTEMX86 = 41,
        CSIDL_PROGRAM_FILESX86 = 42,
        CSIDL_PROGRAM_FILES_COMMON = 43,
        CSIDL_PROGRAM_FILES_COMMONX86 = 44,
        CSIDL_COMMON_TEMPLATES = 45,
        CSIDL_COMMON_DOCUMENTS = 46,
        CSIDL_COMMON_ADMINTOOLS = 47,
        CSIDL_ADMINTOOLS = 48,
        CSIDL_CONNECTIONS = 49,
        CSIDL_COMMON_MUSIC = 53,
        CSIDL_COMMON_PICTURES = 54,
        CSIDL_COMMON_VIDEO = 55,
        CSIDL_RESOURCES = 56,
        CSIDL_RESOURCES_LOCALIZED = 57,
        CSIDL_COMMON_OEM_LINKS = 58,
        CSIDL_CDBURN_AREA = 59,
        CSIDL_COMPUTERSNEARME = 61,
        CSIDL_FLAG_CREATE = 32768,
        CSIDL_FLAG_DONT_VERIFY = 16384,
        CSIDL_FLAG_DONT_UNEXPAND = 8192,
        CSIDL_FLAG_NO_ALIAS = 4096,
        CSIDL_FLAG_PER_USER_INIT = 2048,
        CSIDL_FLAG_MASK = 65280,
    }
    [JetBrains.Util.NoReorder()]
    public struct CWPRETSTRUCT
    {
        public System.Void* hwnd;
        public System.IntPtr lParam;
        public System.IntPtr lResult;
        public uint message;
        public System.IntPtr wParam;
    }
    [JetBrains.Util.NoReorder()]
    public struct CWPSTRUCT
    {
        public System.Void* hwnd;
        public System.IntPtr lParam;
        public uint message;
        public System.IntPtr wParam;
    }
    public enum DialogBoxCommandId
    {
        IDOK = 1,
        IDCANCEL = 2,
        IDABORT = 3,
        IDRETRY = 4,
        IDIGNORE = 5,
        IDYES = 6,
        IDNO = 7,
        IDCLOSE = 8,
        IDHELP = 9,
        IDTRYAGAIN = 10,
        IDCONTINUE = 11,
        IDTIMEOUT = 32000,
    }
    public enum DialogCodes
    {
        DLGC_WANTARROWS = 1,
        DLGC_WANTTAB = 2,
        DLGC_WANTALLKEYS = 4,
        DLGC_WANTMESSAGE = 4,
        DLGC_HASSETSEL = 8,
        DLGC_DEFPUSHBUTTON = 16,
        DLGC_UNDEFPUSHBUTTON = 32,
        DLGC_RADIOBUTTON = 64,
        DLGC_WANTCHARS = 128,
        DLGC_STATIC = 256,
        DLGC_BUTTON = 8192,
    }
    [JetBrains.Util.NoReorder()]
    public struct DLGITEMTEMPLATE
    {
        public ushort _r1;
        public ushort _r2;
        public ushort _r3;
        public ushort _static;
        public ushort atom;
        public short cx;
        public short cy;
        public JetBrains.Interop.WinApi.WindowExStyles dwExtendedStyle;
        public ushort id;
        public JetBrains.Interop.WinApi.WindowStyles style;
        public short x;
        public short y;
    }
    [JetBrains.Util.NoReorder()]
    public struct DLGTEMPLATE
    {
        public ushort cdit;
        public short cx;
        public short cy;
        public ushort dialog;
        public JetBrains.Interop.WinApi.WindowExStyles dwExtendedStyle;
        public ushort font;
        public ushort menu;
        public JetBrains.Interop.WinApi.DLGITEMTEMPLATE pannel;
        public JetBrains.Interop.WinApi.WindowStyles style;
        public short x;
        public short y;
    }
    public enum DrawTextFormatFlags
    {
        DT_TOP = 0,
        DT_LEFT = 0,
        DT_CENTER = 1,
        DT_RIGHT = 2,
        DT_VCENTER = 4,
        DT_BOTTOM = 8,
        DT_WORDBREAK = 16,
        DT_SINGLELINE = 32,
        DT_EXPANDTABS = 64,
        DT_TABSTOP = 128,
        DT_NOCLIP = 256,
        DT_EXTERNALLEADING = 512,
        DT_CALCRECT = 1024,
        DT_NOPREFIX = 2048,
        DT_INTERNAL = 4096,
        DT_EDITCONTROL = 8192,
        DT_PATH_ELLIPSIS = 16384,
        DT_END_ELLIPSIS = 32768,
        DT_MODIFYSTRING = 65536,
        DT_RTLREADING = 131072,
        DT_WORD_ELLIPSIS = 262144,
    }
    public enum EditBoxControlMargins : short
    {
        EC_LEFTMARGIN = 1,
        EC_RIGHTMARGIN = 2,
        EC_USEFONTINFO = -1,
    }
    public class static Gdi32Dll
    {
        public static int BitBlt(System.Void* hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, System.Void* hdcSrc, int nXSrc, int nYSrc, uint dwRop) { }
        public static System.Void* CreateCompatibleDC(System.Void* hdc) { }
        public static System.Void* CreateDCW(string lpszDriver, string lpszDevice, string lpszOutput, System.Void* lpInitData) { }
        public static System.Void* CreateDIBitmap(System.Void* hdc, JetBrains.Interop.WinApi.Declarations.Structures.BITMAPINFOHEADER* lpbmih, uint fdwInit, System.Void* lpbInit, JetBrains.Interop.WinApi.Declarations.Structures.BITMAPINFO* lpbmi, uint fuUsage) { }
        public static System.Void* CreateDIBSection(System.Void* hdc, JetBrains.Interop.WinApi.Declarations.Structures.BITMAPINFO* pbmi, uint iUsage, System.Void** ppvBits, System.Void* hSection, int dwOffset) { }
        public static System.Void* CreatePen(int fnPenStyle, int nWidth, uint crColor) { }
        public static System.IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse) { }
        public static System.Void* CreateSolidBrush(uint crColor) { }
        public static int DeleteDC(System.Void* hDC) { }
        public static int DeleteObject(System.Void* hGDIObj) { }
        public static int GdiFlush() { }
        public static int GetDeviceCaps(System.Void* hdc, int capindex) { }
        public static System.Void* GetStockObject(int fnObject) { }
        public static int Rectangle(System.Void* hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect) { }
        public static System.Void* SelectObject(System.Void* hDC, System.Void* hGDIObj) { }
        public static int StretchBlt(System.Void* hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, System.Void* hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, uint dwRop) { }
    }
    public enum GetAncestorFlags : uint
    {
        GA_PARENT = 1u,
        GA_ROOT = 2u,
        GA_ROOTOWNER = 3u,
    }
    [JetBrains.Util.NoReorder()]
    public struct GUITHREADINFO
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public uint cbSize;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public uint flags;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Void* hwndActive;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Void* hwndCapture;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Void* hwndCaret;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Void* hwndFocus;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Void* hwndMenuOwner;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Void* hwndMoveSize;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.Interop.WinApi.RECT rcCaret;
        public static JetBrains.Interop.WinApi.GUITHREADINFO NewWithSize() { }
    }
    [JetBrains.Util.NoReorder()]
    public struct HDITEM
    {
        public int cchTextMax;
        public int cxy;
        public JetBrains.Interop.WinApi.HeaderItemFlag fmt;
        public System.IntPtr hbm;
        public int iImage;
        public int iOrder;
        public System.IntPtr lParam;
        public JetBrains.Interop.WinApi.HeaderItemMask mask;
        public System.IntPtr pszText;
        public System.IntPtr pvFilter;
        public uint type;
    }
    [System.FlagsAttribute()]
    public enum HeaderItemFlag
    {
        HDF_LEFT = 0,
        HDF_RIGHT = 1,
        HDF_CENTER = 2,
        HDF_JUSTIFYMASK = 3,
        HDF_RTLREADING = 4,
        HDF_OWNERDRAW = 32768,
        HDF_STRING = 16384,
        HDF_BITMAP = 8192,
        HDF_BITMAP_ON_RIGHT = 4096,
        HDF_IMAGE = 2048,
        HDF_SORTUP = 1024,
        HDF_SORTDOWN = 512,
    }
    [System.FlagsAttribute()]
    public enum HeaderItemMask : uint
    {
        HDI_WIDTH = 1u,
        HDI_HEIGHT = 1u,
        HDI_TEXT = 2u,
        HDI_FORMAT = 4u,
        HDI_LPARAM = 8u,
        HDI_BITMAP = 16u,
        HDI_IMAGE = 32u,
        HDI_DI_SETITEM = 64u,
        HDI_ORDER = 128u,
        HDI_FILTER = 256u,
    }
    public enum HitTestResult
    {
        HTERROR = -2,
        HTTRANSPARENT = -1,
        HTNOWHERE = 0,
        HTCLIENT = 1,
        HTCAPTION = 2,
        HTSYSMENU = 3,
        HTGROWBOX = 4,
        HTSIZE = 4,
        HTMENU = 5,
        HTHSCROLL = 6,
        HTVSCROLL = 7,
        HTMINBUTTON = 8,
        HTMAXBUTTON = 9,
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17,
        HTBORDER = 18,
        HTREDUCE = 8,
        HTZOOM = 9,
        HTSIZEFIRST = 10,
        HTSIZELAST = 17,
        HTOBJECT = 19,
        HTCLOSE = 20,
        HTHELP = 21,
    }
    public enum HookType
    {
        WH_JOURNALRECORD = 0,
        WH_JOURNALPLAYBACK = 1,
        WH_KEYBOARD = 2,
        WH_GETMESSAGE = 3,
        WH_CALLWNDPROC = 4,
        WH_CBT = 5,
        WH_SYSMSGFILTER = 6,
        WH_MOUSE = 7,
        WH_HARDWARE = 8,
        WH_DEBUG = 9,
        WH_SHELL = 10,
        WH_FOREGROUNDIDLE = 11,
        WH_CALLWNDPROCRET = 12,
        WH_KEYBOARD_LL = 13,
        WH_MOUSE_LL = 14,
    }
    public class static HResultHelpers
    {
        public static void Assert(int hresult, params int[] expectedHRFailure) { }
        public static void Assert(int hresult) { }
        public static void Assert(JetBrains.Interop.WinApi.HResults hresult) { }
        public static void Assert(int hresult, string comment) { }
        public static void Assert(JetBrains.Interop.WinApi.HResults hresult, string comment) { }
        public static void Assert(JetBrains.Interop.WinApi.HResults hresult, System.Action<System.Exception> FComment) { }
        public static bool FAILED(JetBrains.Interop.WinApi.HResults hresult) { }
        public static bool FAILED(int hresult) { }
        public static bool SUCCEEDED(JetBrains.Interop.WinApi.HResults hresult) { }
        public static bool SUCCEEDED(int hresult) { }
    }
    public enum HResults
    {
        COR_E_ABANDONEDMUTEX = -2146233043,
        COR_E_AMBIGUOUSMATCH = -2147475171,
        COR_E_APPDOMAINUNLOADED = -2146234348,
        COR_E_APPLICATION = -2146232832,
        COR_E_ARGUMENT = -2147024809,
        COR_E_ARGUMENTOUTOFRANGE = -2146233086,
        COR_E_ARITHMETIC = -2147024362,
        COR_E_ARRAYTYPEMISMATCH = -2146233085,
        COR_E_BADIMAGEFORMAT = -2147024885,
        COR_E_CANNOTUNLOADAPPDOMAIN = -2146234347,
        COR_E_COMEMULATE = -2146233035,
        COR_E_CONTEXTMARSHAL = -2146233084,
        COR_E_CUSTOMATTRIBUTEFORMAT = -2146232827,
        COR_E_DATAMISALIGNED = -2146233023,
        COR_E_DIVIDEBYZERO = -2147352558,
        COR_E_DLLNOTFOUND = -2146233052,
        COR_E_DUPLICATEWAITOBJECT = -2146233047,
        COR_E_ENTRYPOINTNOTFOUND = -2146233053,
        COR_E_EXCEPTION = -2146233088,
        COR_E_EXECUTIONENGINE = -2146233082,
        COR_E_FIELDACCESS = -2146233081,
        COR_E_FORMAT = -2146233033,
        COR_E_HOSTPROTECTION = -2146232768,
        COR_E_INDEXOUTOFRANGE = -2146233080,
        COR_E_INSUFFICIENTMEMORY = -2146233027,
        COR_E_INVALIDCAST = -2147467262,
        COR_E_INVALIDCOMOBJECT = -2146233049,
        COR_E_INVALIDFILTERCRITERIA = -2146232831,
        COR_E_INVALIDOLEVARIANTTYPE = -2146233039,
        COR_E_INVALIDOPERATION = -2146233079,
        COR_E_INVALIDPROGRAM = -2146233030,
        COR_E_KEYNOTFOUND = -2146232969,
        COR_E_MARSHALDIRECTIVE = -2146233035,
        COR_E_MEMBERACCESS = -2146233062,
        COR_E_METHODACCESS = -2146233072,
        COR_E_MISSINGFIELD = -2146233071,
        COR_E_MISSINGMANIFESTRESOURCE = -2146233038,
        COR_E_MISSINGMEMBER = -2146233070,
        COR_E_MISSINGMETHOD = -2146233069,
        COR_E_MISSINGSATELLITEASSEMBLY = -2146233034,
        COR_E_MULTICASTNOTSUPPORTED = -2146233068,
        COR_E_NOTFINITENUMBER = -2146233048,
        COR_E_NOTSUPPORTED = -2146233067,
        COR_E_NULLREFERENCE = -2147467261,
        COR_E_OBJECTDISPOSED = -2146232798,
        COR_E_OPERATIONCANCELED = -2146233029,
        COR_E_OUTOFMEMORY = -2147024882,
        COR_E_OVERFLOW = -2146233066,
        COR_E_PLATFORMNOTSUPPORTED = -2146233031,
        COR_E_RANK = -2146233065,
        COR_E_REFLECTIONTYPELOAD = -2146232830,
        COR_E_RUNTIMEWRAPPED = -2146233026,
        COR_E_SAFEARRAYRANKMISMATCH = -2146233032,
        COR_E_SAFEARRAYTYPEMISMATCH = -2146233037,
        COR_E_SAFEHANDLEMISSINGATTRIBUTE = -2146232797,
        COR_E_SECURITY = -2146233078,
        COR_E_SEMAPHOREFULL = -2146233045,
        COR_E_SERIALIZATION = -2146233076,
        COR_E_STACKOVERFLOW = -2147023895,
        COR_E_SYNCHRONIZATIONLOCK = -2146233064,
        COR_E_SYSTEM = -2146233087,
        COR_E_TARGET = -2146232829,
        COR_E_TARGETINVOCATION = -2146232828,
        COR_E_TARGETPARAMCOUNT = -2147352562,
        COR_E_THREADABORTED = -2146233040,
        COR_E_THREADINTERRUPTED = -2146233063,
        COR_E_THREADSTART = -2146233051,
        COR_E_THREADSTATE = -2146233056,
        COR_E_THREADSTOP = -2146233055,
        COR_E_TIMEOUT = -2146233083,
        COR_E_TYPEINITIALIZATION = -2146233036,
        COR_E_TYPELOAD = -2146233054,
        COR_E_TYPEUNLOADED = -2146234349,
        COR_E_UNAUTHORIZEDACCESS = -2147024891,
        COR_E_UNSUPPORTEDFORMAT = -2146233053,
        COR_E_VERIFICATION = -2146233075,
        COR_E_WAITHANDLECANNOTBEOPENED = -2146233044,
        CORSEC_E_CRYPTO = -2146233296,
        CORSEC_E_CRYPTO_UNEX_OPER = -2146233295,
        CORSEC_E_MIN_GRANT_FAIL = -2146233321,
        CORSEC_E_NO_EXEC_PERM = -2146233320,
        CORSEC_E_POLICY_EXCEPTION = -2146233322,
        CORSEC_E_XMLSYNTAX = -2146233320,
        E_FAIL = -2147467259,
        E_NOTIMPL = -2147467263,
        E_POINTER = -2147467261,
        S_OK = 0,
        FUSION_E_INVALID_NAME = -2146234297,
        FUSION_E_REF_DEF_MISMATCH = -2146234304,
        NTE_FAIL = -2146893792,
        STATUS_INFO_LENGTH_MISMATCH = -1073741820,
        CO_E_CLASSSTRING = -2147221005,
        CO_E_NOTINITIALIZED = -2147221008,
        DB_E_ABORTLIMITREACHED = -2147217871,
        DB_E_ALREADYINITIALIZED = -2147217838,
        DB_E_ASYNCNOTSUPPORTED = -2147217771,
        DB_E_BADACCESSORFLAGS = -2147217850,
        DB_E_BADACCESSORHANDLE = -2147217920,
        DB_E_BADACCESSORTYPE = -2147217845,
        DB_E_BADBINDINFO = -2147217912,
        DB_E_BADBOOKMARK = -2147217906,
        DB_E_BADCHAPTER = -2147217914,
        DB_E_BADCOLUMNID = -2147217903,
        DB_E_BADCOMMANDFLAGS = -2147217780,
        DB_E_BADCOMMANDID = -2147217802,
        DB_E_BADCOMPAREOP = -2147217881,
        DB_E_BADCONSTRAINTFORM = -2147217800,
        DB_E_BADCONSTRAINTID = -2147217781,
        DB_E_BADCONSTRAINTTYPE = -2147217801,
        DB_E_BADCONVERTFLAG = -2147217828,
        DB_E_BADCOPY = -2147217863,
        DB_E_BADDEFERRABILITY = -2147217799,
        DB_E_BADDYNAMICERRORID = -2147217830,
        DB_E_BADHRESULT = -2147217832,
        DB_E_BADINDEXID = -2147217806,
        DB_E_BADINITSTRING = -2147217805,
        DB_E_BADLOCKMODE = -2147217905,
        DB_E_BADLOOKUPID = -2147217831,
        DB_E_BADMATCHTYPE = -2147217792,
        DB_E_BADORDINAL = -2147217835,
        DB_E_BADPARAMETERNAME = -2147217827,
        DB_E_BADPRECISION = -2147217862,
        DB_E_BADPROPERTYVALUE = -2147217852,
        DB_E_BADRATIO = -2147217902,
        DB_E_BADRECORDNUM = -2147217854,
        DB_E_BADREGIONHANDLE = -2147217878,
        DB_E_BADROWHANDLE = -2147217916,
        DB_E_BADSCALE = -2147217861,
        DB_E_BADSOURCEHANDLE = -2147217840,
        DB_E_BADSTARTPOSITION = -2147217890,
        DB_E_BADSTATUSVALUE = -2147217880,
        DB_E_BADSTORAGEFLAG = -2147217882,
        DB_E_BADSTORAGEFLAGS = -2147217849,
        DB_E_BADTABLEID = -2147217860,
        DB_E_BADTYPE = -2147217859,
        DB_E_BADTYPENAME = -2147217872,
        DB_E_BADUPDATEDELETERULE = -2147217782,
        DB_E_BADVALUES = -2147217901,
        DB_E_BOOKMARKSKIPPED = -2147217853,
        DB_E_BYREFACCESSORNOTSUPPORTED = -2147217848,
        DB_E_CANCELED = -2147217842,
        DB_E_CANNOTCONNECT = -2147217770,
        DB_E_CANNOTFREE = -2147217894,
        DB_E_CANNOTRESTART = -2147217896,
        DB_E_CANTCANCEL = -2147217899,
        DB_E_CANTCONVERTVALUE = -2147217913,
        DB_E_CANTFETCHBACKWARDS = -2147217884,
        DB_E_CANTFILTER = -2147217825,
        DB_E_CANTORDER = -2147217824,
        DB_E_CANTSCROLLBACKWARDS = -2147217879,
        DB_E_CANTTRANSLATE = -2147217869,
        DB_E_CHAPTERNOTRELEASED = -2147217841,
        DB_E_COMMANDNOTPERSISTED = -2147217817,
        DB_E_CONCURRENCYVIOLATION = -2147217864,
        DB_E_COSTLIMIT = -2147217907,
        DB_E_DATAOVERFLOW = -2147217833,
        DB_E_DELETEDROW = -2147217885,
        DB_E_DIALECTNOTSUPPORTED = -2147217898,
        DB_E_DROPRESTRICTED = -2147217776,
        DB_E_DUPLICATECOLUMNID = -2147217858,
        DB_E_DUPLICATECONSTRAINTID = -2147217767,
        DB_E_DUPLICATEDATASOURCE = -2147217897,
        DB_E_DUPLICATEID = -2147217816,
        DB_E_DUPLICATEINDEXID = -2147217868,
        DB_E_DUPLICATETABLEID = -2147217857,
        DB_E_ERRORSINCOMMAND = -2147217900,
        DB_E_ERRORSOCCURRED = -2147217887,
        DB_E_GOALREJECTED = -2147217892,
        DB_E_INDEXINUSE = -2147217866,
        DB_E_INTEGRITYVIOLATION = -2147217873,
        DB_E_INVALID = -2147217851,
        DB_E_INVALIDTRANSITION = -2147217876,
        DB_E_LIMITREJECTED = -2147217909,
        DB_E_MAXPENDCHANGESEXCEEDED = -2147217836,
        DB_E_MISMATCHEDPROVIDER = -2147217803,
        DB_E_MULTIPLESTATEMENTS = -2147217874,
        DB_E_MULTIPLESTORAGE = -2147217826,
        DB_E_NEWLYINSERTED = -2147217893,
        DB_E_NOAGGREGATION = -2147217886,
        DB_E_NOCOLUMN = -2147217819,
        DB_E_NOCOMMAND = -2147217908,
        DB_E_NOINDEX = -2147217867,
        DB_E_NOLOCALE = -2147217855,
        DB_E_NONCONTIGUOUSRANGE = -2147217877,
        DB_E_NOPROVIDERSREGISTERED = -2147217804,
        DB_E_NOQUERY = -2147217889,
        DB_E_NOSOURCEOBJECT = -2147217775,
        DB_E_NOTABLE = -2147217865,
        DB_E_NOTAREFERENCECOLUMN = -2147217910,
        DB_E_NOTASUBREGION = -2147217875,
        DB_E_NOTCOLLECTION = -2147217773,
        DB_E_NOTFOUND = -2147217895,
        DB_E_NOTPREPARED = -2147217846,
        DB_E_NOTREENTRANT = -2147217888,
        DB_E_NOTSUPPORTED = -2147217837,
        DB_E_NULLACCESSORNOTSUPPORTED = -2147217847,
        DB_E_OBJECTCREATIONLIMITREACHED = -2147217815,
        DB_E_OBJECTMISMATCH = -2147217779,
        DB_E_OBJECTOPEN = -2147217915,
        DB_E_OUTOFSPACE = -2147217766,
        DB_E_PARAMNOTOPTIONAL = -2147217904,
        DB_E_PARAMUNAVAILABLE = -2147217839,
        DB_E_PENDINGCHANGES = -2147217834,
        DB_E_PENDINGINSERT = -2147217829,
        DB_E_REOLEDBNLY = -2147217772,
        DB_E_REOLEDBNLYACCESSOR = -2147217918,
        DB_E_RESOURCEEXISTS = -2147217768,
        DB_E_RESOURCELOCKED = -2147217774,
        DB_E_RESOURCEOUTOFSCOPE = -2147217778,
        DB_E_ROWLIMITEXCEEDED = -2147217919,
        DB_E_ROWSETINCOMMAND = -2147217870,
        DB_E_ROWSNOTRELEASED = -2147217883,
        DB_E_SCHEMAVIOLATION = -2147217917,
        DB_E_TABLEINUSE = -2147217856,
        DB_E_TIMEOUT = -2147217769,
        DB_E_UNSUPPORTEDCONVERSION = -2147217891,
        DB_E_WRITEONLYACCESSOR = -2147217844,
        DB_S_ASYNCHRONOUS = 265936,
        DB_S_BADROWHANDLE = 265939,
        DB_S_BOOKMARKSKIPPED = 265923,
        DB_S_BUFFERFULL = 265928,
        DB_S_CANTRELEASE = 265930,
        DB_S_COLUMNSCHANGED = 265937,
        DB_S_COLUMNTYPEMISMATCH = 265921,
        DB_S_COMMANDREEXECUTED = 265927,
        DB_S_DELETEDROW = 265940,
        DB_S_DIALECTIGNORED = 265933,
        DB_S_ENDOFROWSET = 265926,
        DB_S_ERRORSOCCURRED = 265946,
        DB_S_ERRORSRETURNED = 265938,
        DB_S_GOALCHANGED = 265931,
        DB_S_LOCKUPGRADED = 265944,
        DB_S_MULTIPLECHANGES = 265948,
        DB_S_NONEXTROWSET = 265925,
        DB_S_NORESULT = 265929,
        DB_S_NOROWSPECIFICCOLUMNS = 265949,
        DB_S_NOTSINGLETON = 265943,
        DB_S_PARAMUNAVAILABLE = 265947,
        DB_S_PROPERTIESCHANGED = 265945,
        DB_S_ROWLIMITEXCEEDED = 265920,
        DB_S_STOPLIMITREACHED = 265942,
        DB_S_TOOMANYCHANGES = 265941,
        DB_S_TYPEINFOOVERRIDDEN = 265922,
        DB_S_UNWANTEDOPERATION = 265932,
        DB_S_UNWANTEDPHASE = 265934,
        DB_S_UNWANTEDREASON = 265935,
        DB_SEC_E_AUTH_FAILED = -2147217843,
        DB_SEC_E_PERMISSIONDENIED = -2147217911,
        DB_SEC_E_SAFEMODE_DENIED = -2147217765,
        E_ABORT = -2147467260,
        E_ACCESSDENIED = -2147024891,
        E_HANDLE = -2147024890,
        E_INVALIDARG = -2147024809,
        E_NOINTERFACE = -2147467262,
        E_OUTOFMEMORY = -2147024882,
        E_UNEXPECTED = -2147418113,
        MD_E_BADCOORDINATE = -2147217822,
        MD_E_BADTUPLE = -2147217823,
        MD_E_INVALIDAXIS = -2147217821,
        MD_E_INVALIDCELLRANGE = -2147217820,
        REGDB_E_CLASSNOTREG = -2147221164,
        S_FALSE = 1,
        SEC_E_BADTRUSTEEID = -2147217814,
        SEC_E_INVALIDACCESSENTRY = -2147217807,
        SEC_E_INVALIDACCESSENTRYLIST = -2147217809,
        SEC_E_INVALIDOBJECT = -2147217811,
        SEC_E_INVALIDOWNER = -2147217808,
        SEC_E_NOMEMBERSHIPSUPPORT = -2147217812,
        SEC_E_NOOWNER = -2147217810,
        SEC_E_NOTRUSTEEID = -2147217813,
        STG_E_ABNORMALAPIEXIT = -2147286790,
        STG_E_ACCESSDENIED = -2147287035,
        STG_E_BADBASEADDRESS = -2147286768,
        STG_E_CANTSAVE = -2147286781,
        STG_E_DISKISWRITEPROTECTED = -2147287021,
        STG_E_DOCFILECORRUPT = -2147286775,
        STG_E_EXTANTMARSHALLINGS = -2147286776,
        STG_E_FILEALREADYEXISTS = -2147286960,
        STG_E_FILENOTFOUND = -2147287038,
        STG_E_INCOMPLETE = -2147286527,
        STG_E_INSUFFICIENTMEMORY = -2147287032,
        STG_E_INUSE = -2147286784,
        STG_E_INVALIDFLAG = -2147286785,
        STG_E_INVALIDFUNCTION = -2147287039,
        STG_E_INVALIDHANDLE = -2147287034,
        STG_E_INVALIDHEADER = -2147286789,
        STG_E_INVALIDNAME = -2147286788,
        STG_E_INVALIDPARAMETER = -2147286953,
        STG_E_INVALIDPOINTER = -2147287031,
        STG_E_LOCKVIOLATION = -2147287007,
        STG_E_MEDIUMFULL = -2147286928,
        STG_E_NOMOREFILES = -2147287022,
        STG_E_NOTCURRENT = -2147286783,
        STG_E_NOTFILEBASEDSTORAGE = -2147286777,
        STG_E_OLDDLL = -2147286779,
        STG_E_OLDFORMAT = -2147286780,
        STG_E_PATHNOTFOUND = -2147287037,
        STG_E_PROPSETMISMATCHED = -2147286800,
        STG_E_READFAULT = -2147287010,
        STG_E_REVERTED = -2147286782,
        STG_E_SEEKERROR = -2147287015,
        STG_E_SHAREREQUIRED = -2147286778,
        STG_E_SHAREVIOLATION = -2147287008,
        STG_E_TERMINATED = -2147286526,
        STG_E_TOOMANYOPENFILES = -2147287036,
        STG_E_UNIMPLEMENTEDFUNCTION = -2147286786,
        STG_E_UNKNOWN = -2147286787,
        STG_E_WRITEFAULT = -2147287011,
        STG_S_BLOCK = 197121,
        STG_S_CONVERTED = 197120,
        STG_S_MONITORING = 197123,
        STG_S_RETRYNOW = 197122,
        XACT_E_ABORTED = -2147168231,
        XACT_E_ALREADYINPROGRESS = -2147168232,
        XACT_E_ALREADYOTHERSINGLEPHASE = -2147168256,
        XACT_E_CANTRETAIN = -2147168255,
        XACT_E_CLERKEXISTS = -2147168127,
        XACT_E_CLERKNOTFOUND = -2147168128,
        XACT_E_COMMITFAILED = -2147168254,
        XACT_E_COMMITPREVENTED = -2147168253,
        XACT_E_CONNECTION_DENIED = -2147168227,
        XACT_E_CONNECTION_DOWN = -2147168228,
        XACT_E_DEST_TMNOTAVAILABLE = -2147168222,
        XACT_E_FIRST = -2147168256,
        XACT_E_HEURISTICABORT = -2147168252,
        XACT_E_HEURISTICCOMMIT = -2147168251,
        XACT_E_HEURISTICDAMAGE = -2147168250,
        XACT_E_HEURISTICDANGER = -2147168249,
        XACT_E_INDOUBT = -2147168234,
        XACT_E_INVALIDCOOKIE = -2147168235,
        XACT_E_INVALIDLSN = -2147168124,
        XACT_E_ISOLATIONLEVEL = -2147168248,
        XACT_E_LAST = -2147168222,
        XACT_E_LOGFULL = -2147168230,
        XACT_E_NOASYNC = -2147168247,
        XACT_E_NOENLIST = -2147168246,
        XACT_E_NOIMPORTOBJECT = -2147168236,
        XACT_E_NOISORETAIN = -2147168245,
        XACT_E_NORESOURCE = -2147168244,
        XACT_E_NOTCURRENT = -2147168243,
        XACT_E_NOTIMEOUT = -2147168233,
        XACT_E_NOTRANSACTION = -2147168242,
        XACT_E_NOTSUPPORTED = -2147168241,
        XACT_E_RECOVERYINPROGRESS = -2147168126,
        XACT_E_REENLISTTIMEOUT = -2147168226,
        XACT_E_REPLAYREQUEST = -2147168123,
        XACT_E_TIP_CONNECT_FAILED = -2147168225,
        XACT_E_TIP_PROTOCOL_ERROR = -2147168224,
        XACT_E_TIP_PULL_FAILED = -2147168223,
        XACT_E_TMNOTAVAILABLE = -2147168229,
        XACT_E_TRANSACTIONCLOSED = -2147168125,
        XACT_E_UNKNOWNRMGRID = -2147168240,
        XACT_E_WRONGSTATE = -2147168239,
        XACT_E_WRONGUOW = -2147168238,
        XACT_E_XTIONEXISTS = -2147168237,
        XACT_S_ABORTING = 315400,
        XACT_S_ALLNORETAIN = 315399,
        XACT_S_ASYNC = 315392,
        XACT_S_DEFECT = 315393,
        XACT_S_FIRST = 315392,
        XACT_S_LAST = 315401,
        XACT_S_MADECHANGESCONTENT = 315397,
        XACT_S_MADECHANGESINFORM = 315398,
        XACT_S_OKINFORM = 315396,
        XACT_S_REOLEDBNLY = 315394,
        XACT_S_SINGLEPHASE = 315401,
        XACT_S_SOMENORETAIN = 315395,
        BUFFER_E_DEST_TOO_SMALL = -2147217402,
        BUFFER_E_LOCKED = -2147217404,
        BUFFER_E_READONLY = -2147217407,
        BUFFER_E_READONLY_REGION = -2147217406,
        BUFFER_E_SCC_READONLY = -2147217403,
        BUFFER_E_TIMEOUT = -2147217405,
        MARKER_E_BUFFERDESTROYED = -2147217400,
        MARKER_E_INVALIDATED = -2147217401,
        VIEW_E_LOCATION_HIDDEN = -2147213307,
        VIEW_E_NO_BOOKMARKS = -2147213311,
        VIEW_E_NO_DEBUGGER = -2147213310,
        VIEW_E_USERREADONLY = -2147213308,
        LINKEDUNDO_E_INTERVENING_ACTION = -2147209215,
        UNDO_E_CLIENTABORT = -2147205119,
        TIP_S_ONLYIFNOMARKER = 278529,
        STG_E_INVALIDCODEPAGE = -2147286272,
        STG_E_NOTTEXT = -2147286270,
        STG_S_DATALOSS = 197377,
        COR_E_DIRECTORYNOTFOUND = -2147024893,
        COR_E_ENDOFSTREAM = -2147024858,
        COR_E_FILELOAD = -2146232799,
        COR_E_FILENOTFOUND = -2147024894,
        COR_E_IO = -2146232800,
        COR_E_PATHTOOLONG = -2147024690,
        COR_E_REMOTING = -2146233077,
        COR_E_SERVER = -2146233074,
        COR_E_ISOSTORE = -2146233264,
        AdapterMapping = -2146232013,
        Configuration = -2146232062,
        Data = -2146232032,
        DataAdapter = -2146232012,
        DataConstraint = -2146232022,
        DataDeletedRowInaccessible = -2146232031,
        DataDuplicateName = -2146232030,
        DataInRowChangingEvent = -2146232029,
        DataInvalidConstraint = -2146232028,
        DataMissingPrimaryKey = -2146232027,
        DataNoNullAllowed = -2146232026,
        DataReadOnly = -2146232025,
        DataRowNotInTable = -2146232024,
        DataVersionNotFound = -2146232023,
        DBConcurrency = -2146232011,
        EFail = -2147467259,
        Install = -2146232057,
        InternalBufferOverflow = -2146232059,
        InvalidUdt = -2146232009,
        License = -2146232063,
        NteBadKeySet = -2146893802,
        OdbcException = -2146232009,
        OperationAborted = -2146232010,
        OracleException = -2146232008,
        ServiceControllerTimeout = -2146232058,
        SqlException = -2146232060,
        SqlNullValue = -2146232015,
        SqlTruncate = -2146232014,
        SqlType = -2146232016,
        StrongTyping = -2146232021,
        Win32AccessDenied = -2147024891,
        Win32InvalidHandle = -2147024890,
        Xml = -2146232000,
        XmlSchema = -2146231999,
        XmlXPath = -2146231997,
        XmlXslt = -2146231998,
        E_FILENOTFOUND = -2147024894,
        E_INSUFFICIENT_BUFFER = -2147024774,
        E_INVALID_DATA = -2147024883,
        E_PATHNOTFOUND = -2147024893,
        ERROR_NOT_SUPPORTED = -2147024846,
        ERROR_TOO_MANY_CMDS = -2147024840,
        WSAECONNABORTED = -2147014843,
        WSAECONNRESET = -2147014842,
        FACILITY_NT_BIT = 268435456,
        FACILITY_MASK = 2147418112,
        FACILITY_WINCODEC_ERROR = 144179200,
        COMPONENT_MASK = 57344,
        COMPONENT_WINCODEC_ERROR = 8192,
        D3DERR_OUTOFVIDEOMEMORY = -2005532292,
        HRESULT_ERROR_REVISION_MISMATCH = -2147023590,
        OLECMDERR_E_FIRST = -2147221248,
        OLECMDERR_E_NOTSUPPORTED = -2147221248,
        OLECMDERR_E_DISABLED = -2147221247,
        OLECMDERR_E_NOHELP = -2147221246,
        OLECMDERR_E_CANCELED = -2147221245,
        OLECMDERR_E_UNKNOWNGROUP = -2147221244,
    }
    public enum HwndSpecial
    {
        HWND_TOP = 0,
        HWND_BOTTOM = 1,
        HWND_TOPMOST = -1,
        HWND_NOTOPMOST = -2,
        HWND_MESSAGE = -3,
    }
    public class static IpHlpApiDll
    {
        public static int GetExtendedTcpTable(System.Void* pTcpTable, System.UInt32* pdwSize, bool bOrder, uint ulAf, JetBrains.Interop.WinApi.Declarations.Constants.TCP_TABLE_CLASS tableClass, uint reserved) { }
    }
    public class static Kernel32Dll
    {
        public static int CloseHandle(System.Void* hObject) { }
        public static System.Void* ConvertThreadToFiber(System.Void* lpParameter) { }
        public static bool CopyFileW(string lpExistingFileName, string lpNewFileName, bool bFailIfExists) { }
        public static bool CreateDirectoryW(string lpPathName, System.IntPtr lpSecurityAttributes) { }
        public static System.Void* CreateFiber(System.IntPtr dwStackSize, System.Void* lpStartAddress, System.Void* lpParameter) { }
        public static System.Void* CreateFileMappingW(System.Void* hFile, JetBrains.Interop.WinApi.SECURITY_ATTRIBUTES* lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName) { }
        public static Microsoft.Win32.SafeHandles.SafeFileHandle CreateFileW(string lpFileName, JetBrains.Interop.WinApi.AccessRights dwDesiredAccess, JetBrains.Interop.WinApi.Declarations.Constants.FileShareFlags dwShareMode, JetBrains.Interop.WinApi.SECURITY_ATTRIBUTES* securityAttributes, JetBrains.Interop.WinApi.Declarations.Constants.CreationDisposition dwCreationDisposition, JetBrains.Interop.WinApi.Declarations.Constants.FileFlagsAndAttributes dwFlagsAndAttributes, System.IntPtr hTemplateFile) { }
        public static System.Void* CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessID) { }
        public static void DeleteFiber(System.Void* lpFiber) { }
        public static bool DeleteFile(string name) { }
        public static bool DeleteFileW(string lpFileName) { }
        public static bool FindClose(System.IntPtr handle) { }
        public static JetBrains.Interop.WinApi.Wrappers.SafeFindHandle FindFirstFileW(string fileName, out JetBrains.Interop.WinApi.Declarations.Structures.WIN32_FIND_DATA data) { }
        public static bool FindNextFileW(JetBrains.Interop.WinApi.Wrappers.SafeFindHandle hndFindFile, out JetBrains.Interop.WinApi.Declarations.Structures.WIN32_FIND_DATA pFindFileData) { }
        public static System.Void* FindResourceW(System.Void* hModule, string lpName, string lpType) { }
        public static int FreeLibrary(System.Void* hModule) { }
        [System.ObsoleteAttribute("This function is normally implemented either in inline ASM or as a compiler intri" +
            "nsic that ")]
        public static System.Void* GetCurrentFiber() { }
        public static System.Void* GetCurrentProcess() { }
        public static uint GetCurrentProcessId() { }
        public static uint GetCurrentThreadId() { }
        public static bool GetFileAttributesExW(string lpFileName, JetBrains.Interop.WinApi.Declarations.Constants.GET_FILEEX_INFO_LEVELS fInfoLevelId, out JetBrains.Interop.WinApi.Declarations.Structures.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }
        public static uint GetFileAttributesW(string lpFileName) { }
        public static bool GetFileSizeEx(System.IntPtr hFile, out long lpFileSize) { }
        [System.ObsoleteAttribute("Does not work in .NET, because reports interop/marshalling error status rather th" +
            "an WinAPI one.")]
        public static uint GetLastError() { }
        public static uint GetLongPathName(string lpszShortPath, System.Text.StringBuilder lpszLongPath, uint cchBuffer) { }
        public static uint GetModuleFileNameW(System.Void* hModule, System.Char* lpFilename, uint nSize) { }
        public static System.Void* GetModuleHandleW(string lpModuleName) { }
        public static void GetNativeSystemInfo(JetBrains.Interop.WinApi.SYSTEM_INFO* lpSystemInfo) { }
        public static int GetPackageFullName(System.Void* hProcess, System.UInt32* packageFullNameLength, System.Char* packageFullName) { }
        public static uint GetPrivateProfileIntW(string lpAppName, string lpKeyName, int nDefault, string lpFileName) { }
        public static uint GetPrivateProfileStringW(string lpAppName, string lpKeyName, string lpDefault, System.UInt16* lpReturnedString, uint nSize, string lpFileName) { }
        public static System.Void* GetProcAddress(System.Void* hModule, string lpProcName) { }
        public static uint GetShortPathName(string lpszLongPath, System.Text.StringBuilder lpszShortPath, uint cchBuffer) { }
        public static void GetSystemInfo(JetBrains.Interop.WinApi.SYSTEM_INFO* lpSystemInfo) { }
        public static uint GetTickCount() { }
        public static int GlobalMemoryStatusEx(out JetBrains.Interop.WinApi.MEMORYSTATUSEX* lpBuffer) { }
        public static bool IsWow64Process(System.Void* hProcess, out bool wow64Process) { }
        public static System.Void* LoadLibraryW(string lpFileName) { }
        public static System.Void* LoadResource(System.Void* hModule, System.Void* hResInfo) { }
        public static System.Void* LockResource(System.Void* hResData) { }
        public static System.Void* MapViewOfFile(System.Void* hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, System.UIntPtr dwNumberOfBytesToMap) { }
        public static int MoveFileExW(string lpExistingFileName, string lpNewFileName, uint dwFlags) { }
        public static bool MoveFileW(string lpExistingFileName, string lpNewFileName) { }
        public static void OutputDebugStringW(string lpOutputString) { }
        public static int Process32FirstW(System.Void* hSnapshot, System.Void* lppe) { }
        public static int Process32NextW(System.Void* hSnapshot, System.Void* lppe) { }
        public static int QueryPerformanceCounter(System.UInt64* lpPerformanceCount) { }
        public static int QueryPerformanceFrequency(System.UInt64* lpFrequency) { }
        public static bool ReadDirectoryChangesW(Microsoft.Win32.SafeHandles.SafeFileHandle hDirectory, System.Runtime.InteropServices.HandleRef lpBuffer, uint nBufferLength, bool bWatchSubtree, System.IO.NotifyFilters dwNotifyFilter, out uint lpBytesReturned, System.Threading.NativeOverlapped* overlappedPointer, System.Runtime.InteropServices.HandleRef lpCompletionRoutine) { }
        public static bool RemoveDirectoryW(string lpPathName) { }
        public static void RtlCopyMemory(System.Void* Destination, System.Void* Source, System.UIntPtr Length) { }
        public static void RtlMoveMemory(System.Void* Destination, System.Void* Source, System.UIntPtr Length) { }
        public static int SetDllDirectory(string lpPathName) { }
        public static JetBrains.Interop.WinApi.Declarations.Constants.Win32ErrorMode SetErrorMode(JetBrains.Interop.WinApi.Declarations.Constants.Win32ErrorMode uMode) { }
        public static bool SetFileAttributesW(string lpFileName, uint dwFileAttributes) { }
        public static bool SetFileTime(Microsoft.Win32.SafeHandles.SafeFileHandle hFile, JetBrains.Interop.WinApi.Declarations.Structures.FILE_TIME* lpCreationTime, JetBrains.Interop.WinApi.Declarations.Structures.FILE_TIME* lpLastAccessTime, JetBrains.Interop.WinApi.Declarations.Structures.FILE_TIME* lpLastWriteTime) { }
        public static uint SizeofResource(System.Void* hModule, System.Void* hResInfo) { }
        public static void SwitchToFiber(System.Void* lpFiber) { }
        public static int UnmapViewOfFile(System.Void* lpBaseAddress) { }
        public static System.Void* VirtualAlloc(System.Void* lpAddress, System.IntPtr dwSize, uint flAllocationType, uint flProtect) { }
        public static int VirtualProtect(System.Void* lpAddress, System.IntPtr dwSize, uint flNewProtect, System.UInt32* lpflOldProtect) { }
        public static System.IntPtr VirtualQuery(System.Void* lpAddress, JetBrains.Interop.WinApi.Declarations.Structures.MEMORY_BASIC_INFORMATION* lpBuffer, System.IntPtr dwLength) { }
        public static uint WaitForMultipleObjects(uint nCount, System.Void** lpHandles, int bWaitAll, uint dwMilliseconds) { }
        public static uint WaitForSingleObject(System.Void* hHandle, uint dwMilliseconds) { }
        public static byte Wow64EnableWow64FsRedirection(byte Wow64FsEnableRedirection) { }
        public static int WritePrivateProfileStringW(string lpAppName, string lpKeyName, string lpString, string lpFileName) { }
        public class static Helpers
        {
            public static object CoCreateInstanceExplicit(string sDllFilename, System.Guid guidClsid) { }
            public static double GetHighPrecisionSystemTime() { }
            public static string GetModulePath(System.Void* hModule) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string GetProfileString([JetBrains.Annotations.NotNullAttribute()] string sFilePath, [JetBrains.Annotations.NotNullAttribute()] string sSection, [JetBrains.Annotations.NotNullAttribute()] string sKey, [JetBrains.Annotations.NotNullAttribute()] string sDefaultValue) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static byte[] GetWin32Resource([JetBrains.Annotations.NotNullAttribute()] string sDllFilename, [JetBrains.Annotations.NotNullAttribute()] string sResourceName, [JetBrains.Annotations.NotNullAttribute()] string sResourceType) { }
            public static bool IsWow64Process() { }
            public static bool IsWow64Process(System.Void* process) { }
            public static bool WaitForSingleObject(System.IntPtr handle, System.TimeSpan timeout) { }
        }
    }
    [System.FlagsAttribute()]
    public enum KeyAccessRights : uint
    {
        KEY_QUERY_VALUE = 1u,
        KEY_SET_VALUE = 2u,
        KEY_CREATE_SUB_KEY = 4u,
        KEY_ENUMERATE_SUB_KEYS = 8u,
        KEY_NOTIFY = 16u,
        KEY_CREATE_LINK = 32u,
        KEY_WOW64_32KEY = 512u,
        KEY_WOW64_64KEY = 256u,
        KEY_WOW64_RES = 768u,
        KEY_READ = 131097u,
        KEY_WRITE = 131078u,
        KEY_EXECUTE = 131097u,
        KEY_ALL_ACCESS = 983103u,
    }
    public struct KEYBDINPUT
    {
        public System.UIntPtr dwExtraInfo;
        public int dwFlags;
        public int time;
        public short wScan;
        public short wVk;
    }
    [System.FlagsAttribute()]
    public enum KeyStateMasks
    {
        MK_LBUTTON = 1,
        MK_RBUTTON = 2,
        MK_SHIFT = 4,
        MK_CONTROL = 8,
        MK_MBUTTON = 16,
        MK_XBUTTON1 = 32,
        MK_XBUTTON2 = 64,
        MaskKeyboard = 12,
        MaskMouse = 115,
    }
    public enum KF_FLAG : uint
    {
        KF_FLAG_CREATE = 32768u,
        KF_FLAG_DONT_VERIFY = 16384u,
        KF_FLAG_DONT_UNEXPAND = 8192u,
        KF_FLAG_NO_ALIAS = 4096u,
        KF_FLAG_INIT = 2048u,
        KF_FLAG_DEFAULT_PATH = 1024u,
        KF_FLAG_NOT_PARENT_RELATIVE = 512u,
        KF_FLAG_SIMPLE_IDLIST = 256u,
    }
    public class static KNOWNFOLDERID
    {
        public static readonly System.Guid FOLDERID_AddNewPrograms;
        public static readonly System.Guid FOLDERID_AdminTools;
        public static readonly System.Guid FOLDERID_AppUpdates;
        public static readonly System.Guid FOLDERID_CDBurning;
        public static readonly System.Guid FOLDERID_ChangeRemovePrograms;
        public static readonly System.Guid FOLDERID_CommonAdminTools;
        public static readonly System.Guid FOLDERID_CommonOEMLinks;
        public static readonly System.Guid FOLDERID_CommonPrograms;
        public static readonly System.Guid FOLDERID_CommonStartMenu;
        public static readonly System.Guid FOLDERID_CommonStartup;
        public static readonly System.Guid FOLDERID_CommonTemplates;
        public static readonly System.Guid FOLDERID_ComputerFolder;
        public static readonly System.Guid FOLDERID_ConflictFolder;
        public static readonly System.Guid FOLDERID_ConnectionsFolder;
        public static readonly System.Guid FOLDERID_Contacts;
        public static readonly System.Guid FOLDERID_ControlPanelFolder;
        public static readonly System.Guid FOLDERID_Cookies;
        public static readonly System.Guid FOLDERID_Desktop;
        public static readonly System.Guid FOLDERID_Documents;
        public static readonly System.Guid FOLDERID_Downloads;
        public static readonly System.Guid FOLDERID_Favorites;
        public static readonly System.Guid FOLDERID_Fonts;
        public static readonly System.Guid FOLDERID_Games;
        public static readonly System.Guid FOLDERID_GameTasks;
        public static readonly System.Guid FOLDERID_History;
        public static readonly System.Guid FOLDERID_InternetCache;
        public static readonly System.Guid FOLDERID_InternetFolder;
        public static readonly System.Guid FOLDERID_Links;
        public static readonly System.Guid FOLDERID_LocalAppData;
        public static readonly System.Guid FOLDERID_LocalAppDataLow;
        public static readonly System.Guid FOLDERID_LocalizedResourcesDir;
        public static readonly System.Guid FOLDERID_Music;
        public static readonly System.Guid FOLDERID_NetHood;
        public static readonly System.Guid FOLDERID_NetworkFolder;
        public static readonly System.Guid FOLDERID_OriginalImages;
        public static readonly System.Guid FOLDERID_PhotoAlbums;
        public static readonly System.Guid FOLDERID_Pictures;
        public static readonly System.Guid FOLDERID_Playlists;
        public static readonly System.Guid FOLDERID_PrintersFolder;
        public static readonly System.Guid FOLDERID_PrintHood;
        public static readonly System.Guid FOLDERID_Profile;
        public static readonly System.Guid FOLDERID_ProgramData;
        public static readonly System.Guid FOLDERID_ProgramFiles;
        public static readonly System.Guid FOLDERID_ProgramFilesCommon;
        public static readonly System.Guid FOLDERID_ProgramFilesCommonX64;
        public static readonly System.Guid FOLDERID_ProgramFilesCommonX86;
        public static readonly System.Guid FOLDERID_ProgramFilesX64;
        public static readonly System.Guid FOLDERID_ProgramFilesX86;
        public static readonly System.Guid FOLDERID_Programs;
        public static readonly System.Guid FOLDERID_Public;
        public static readonly System.Guid FOLDERID_PublicDesktop;
        public static readonly System.Guid FOLDERID_PublicDocuments;
        public static readonly System.Guid FOLDERID_PublicDownloads;
        public static readonly System.Guid FOLDERID_PublicGameTasks;
        public static readonly System.Guid FOLDERID_PublicMusic;
        public static readonly System.Guid FOLDERID_PublicPictures;
        public static readonly System.Guid FOLDERID_PublicVideos;
        public static readonly System.Guid FOLDERID_QuickLaunch;
        public static readonly System.Guid FOLDERID_Recent;
        public static readonly System.Guid FOLDERID_RecordedTV;
        public static readonly System.Guid FOLDERID_RecycleBinFolder;
        public static readonly System.Guid FOLDERID_ResourceDir;
        public static readonly System.Guid FOLDERID_RoamingAppData;
        public static readonly System.Guid FOLDERID_SampleMusic;
        public static readonly System.Guid FOLDERID_SamplePictures;
        public static readonly System.Guid FOLDERID_SamplePlaylists;
        public static readonly System.Guid FOLDERID_SampleVideos;
        public static readonly System.Guid FOLDERID_SavedGames;
        public static readonly System.Guid FOLDERID_SavedSearches;
        public static readonly System.Guid FOLDERID_SEARCH_CSC;
        public static readonly System.Guid FOLDERID_SEARCH_MAPI;
        public static readonly System.Guid FOLDERID_SearchHome;
        public static readonly System.Guid FOLDERID_SendTo;
        public static readonly System.Guid FOLDERID_SidebarDefaultParts;
        public static readonly System.Guid FOLDERID_SidebarParts;
        public static readonly System.Guid FOLDERID_StartMenu;
        public static readonly System.Guid FOLDERID_Startup;
        public static readonly System.Guid FOLDERID_SyncManagerFolder;
        public static readonly System.Guid FOLDERID_SyncResultsFolder;
        public static readonly System.Guid FOLDERID_SyncSetupFolder;
        public static readonly System.Guid FOLDERID_System;
        public static readonly System.Guid FOLDERID_SystemX86;
        public static readonly System.Guid FOLDERID_Templates;
        public static readonly System.Guid FOLDERID_TreeProperties;
        public static readonly System.Guid FOLDERID_UserProfiles;
        public static readonly System.Guid FOLDERID_UsersFiles;
        public static readonly System.Guid FOLDERID_Videos;
        public static readonly System.Guid FOLDERID_Windows;
    }
    public enum ListBoxStyles
    {
        LBS_NOTIFY = 1,
        LBS_SORT = 2,
        LBS_MULTIPLESEL = 4,
        LBS_OWNERDRAWFIXED = 16,
        LBS_OWNERDRAWVARIABLE = 32,
        LBS_HASSTRINGS = 64,
        LBS_USETABSTOPS = 128,
        LBS_NOINTEGRALHEIGHT = 256,
        LBS_MULTICOLUMN = 512,
        LBS_WANTKEYBOARDINPUT = 1024,
        LBS_EXTENDEDSEL = 2048,
        LBS_DISABLENOSCROLL = 4096,
        LBS_NODATA = 8192,
        LBS_NOSEL = 16384,
        LBS_COMBOBOX = 32768,
        LBS_STANDARD = 10485763,
    }
    [JetBrains.Util.NoReorder()]
    public struct LUID
    {
        public int HighPart;
        public uint LowPart;
    }
    [JetBrains.Util.NoReorder()]
    public struct LUID_AND_ATTRIBUTES
    {
        public JetBrains.Interop.WinApi.SePrivilege Attributes;
        public JetBrains.Interop.WinApi.LUID Luid;
    }
    public class static Macros
    {
        public static int GET_X_LPARAM(System.IntPtr lParam) { }
        public static int GET_Y_LPARAM(System.IntPtr lParam) { }
        public static ushort HIWORD(uint l) { }
        public static ushort HIWORD(System.IntPtr l) { }
        public static ushort LOWORD(uint l) { }
        public static ushort LOWORD(System.IntPtr l) { }
        public static uint MAKEDWORD(ushort loword, ushort hiword) { }
    }
    [JetBrains.Util.NoReorder()]
    public struct MEMORYSTATUSEX
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public ulong ullAvailExtendedVirtual;
        public ulong ullAvailPageFile;
        public ulong ullAvailPhys;
        public ulong ullAvailVirtual;
        public ulong ullTotalPageFile;
        public ulong ullTotalPhys;
        public ulong ullTotalVirtual;
        public static JetBrains.Interop.WinApi.MEMORYSTATUSEX NewWithSize() { }
    }
    public enum MessageBeepType
    {
        Default = -1,
        Ok = 0,
        Error = 16,
        Question = 32,
        Warning = 48,
        Information = 64,
    }
    [System.FlagsAttribute()]
    public enum MessageBoxFlags : uint
    {
        MB_OK = 0u,
        MB_OKCANCEL = 1u,
        MB_ABORTRETRYIGNORE = 2u,
        MB_YESNOCANCEL = 3u,
        MB_YESNO = 4u,
        MB_RETRYCANCEL = 5u,
        MB_CANCELTRYCONTINUE = 6u,
        MB_ICONHAND = 16u,
        MB_ICONQUESTION = 32u,
        MB_ICONEXCLAMATION = 48u,
        MB_ICONASTERISK = 64u,
        MB_USERICON = 128u,
        MB_ICONWARNING = 48u,
        MB_ICONERROR = 16u,
        MB_ICONINFORMATION = 64u,
        MB_ICONSTOP = 16u,
        MB_DEFBUTTON1 = 0u,
        MB_DEFBUTTON2 = 256u,
        MB_DEFBUTTON3 = 512u,
        MB_DEFBUTTON4 = 768u,
        MB_APPLMODAL = 0u,
        MB_SYSTEMMODAL = 4096u,
        MB_TASKMODAL = 8192u,
        MB_HELP = 16384u,
        MB_NOFOCUS = 32768u,
        MB_SETFOREGROUND = 65536u,
        MB_DEFAULT_DESKTOP_ONLY = 131072u,
        MB_TOPMOST = 262144u,
        MB_RIGHT = 524288u,
        MB_RTLREADING = 1048576u,
        MB_SERVICE_NOTIFICATION = 2097152u,
        MB_TYPEMASK = 15u,
        MB_ICONMASK = 240u,
        MB_DEFMASK = 3840u,
        MB_MODEMASK = 12288u,
        MB_MISCMASK = 49152u,
    }
    [JetBrains.Util.NoReorder()]
    public struct MOUSEHOOKSTRUCT
    {
        public System.UIntPtr dwExtraInfo;
        public System.Void* hwnd;
        public JetBrains.Interop.WinApi.POINT pt;
        public uint wHitTestCode;
    }
    public struct MOUSEINPUT
    {
        public System.UIntPtr dwExtraInfo;
        public int dwFlags;
        public int dx;
        public int dy;
        public int mouseData;
        public int time;
    }
    [JetBrains.Util.NoReorder()]
    public struct MSG
    {
        public System.Void* hwnd;
        public System.IntPtr lParam;
        public uint message;
        public JetBrains.Interop.WinApi.POINT pt;
        public uint time;
        public System.IntPtr wParam;
    }
    [System.FlagsAttribute()]
    public enum MsgWaitForMultipleObjectsFlags : uint
    {
        MWMO_WAITALL = 1u,
        MWMO_ALERTABLE = 2u,
        MWMO_INPUTAVAILABLE = 4u,
    }
    public class static MsiDll
    {
        public static uint MsiCloseHandle(System.Void* hAny) { }
        public static uint MsiGetProductPropertyW(System.Void* hProduct, string szProperty, System.Char* lpValueBuf, System.UInt32* pcchValueBuf) { }
        public static uint MsiOpenPackageExW(string szPackagePath, uint dwOptions, System.Void** hProduct) { }
    }
    public class static MsImg32Dll
    {
        public static int AlphaBlend(System.Void* hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, System.Void* hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, JetBrains.Interop.WinApi.Declarations.Structures.BLENDFUNCTION blendFunction) { }
    }
    [JetBrains.Util.NoReorder()]
    public struct MSLLHOOKSTRUCT { }
    [JetBrains.Util.NoReorder()]
    public struct MSOCRINFO
    {
        public uint cbSize;
        public uint grfcadvf;
        public uint grfcrf;
        public uint uIdleTimeInterval;
        public static JetBrains.Interop.WinApi.MSOCRINFO NewWithSize() { }
    }
    [JetBrains.Util.NoReorder()]
    public struct NMHDR
    {
        public uint code;
        public System.Void* hwndFrom;
        public System.UIntPtr idFrom;
    }
    public class static NtDllDll
    {
        public static int RtlQueryElevationFlags(JetBrains.Interop.WinApi.Declarations.Constants.ELEVATION_FLAGS* pFlags) { }
    }
    [System.FlagsAttribute()]
    public enum OFN : uint
    {
        OFN_READONLY = 1u,
        OFN_OVERWRITEPROMPT = 2u,
        OFN_HIDEREADONLY = 4u,
        OFN_NOCHANGEDIR = 8u,
        OFN_SHOWHELP = 16u,
        OFN_ENABLEHOOK = 32u,
        OFN_ENABLETEMPLATE = 64u,
        OFN_ENABLETEMPLATEHANDLE = 128u,
        OFN_NOVALIDATE = 256u,
        OFN_ALLOWMULTISELECT = 512u,
        OFN_EXTENSIONDIFFERENT = 1024u,
        OFN_PATHMUSTEXIST = 2048u,
        OFN_FILEMUSTEXIST = 4096u,
        OFN_CREATEPROMPT = 8192u,
        OFN_SHAREAWARE = 16384u,
        OFN_NOREADONLYRETURN = 32768u,
        OFN_NOTESTFILECREATE = 65536u,
        OFN_NONETWORKBUTTON = 131072u,
        OFN_NOLONGNAMES = 262144u,
        OFN_EXPLORER = 524288u,
        OFN_NODEREFERENCELINKS = 1048576u,
        OFN_LONGNAMES = 2097152u,
        OFN_ENABLEINCLUDENOTIFY = 4194304u,
        OFN_ENABLESIZING = 8388608u,
        OFN_DONTADDTORECENT = 33554432u,
        OFN_FORCESHOWHIDDEN = 268435456u,
    }
    [JetBrains.Util.NoReorder()]
    public struct OFNOTIFYEX
    {
        public JetBrains.Interop.WinApi.NMHDR hdr;
        public JetBrains.Interop.WinApi.OPENFILENAME* lpOFN;
        public System.Void* pidl;
        public System.Void* psf;
    }
    public class static Ole32Dll
    {
        public static int CoRegisterMessageFilter(JetBrains.Interop.WinApi.Declarations.Interfaces.IOleMessageFilter newFilter, out JetBrains.Interop.WinApi.Declarations.Interfaces.IOleMessageFilter oldFilter) { }
        public static int CreateBindCtx(uint reserved, out System.Runtime.InteropServices.ComTypes.IBindCtx ppbc) { }
        public static int CreateItemMoniker(string lpszDelim, string lpszItem, out System.Runtime.InteropServices.ComTypes.IMoniker moniker) { }
        public static int GetRunningObjectTable(uint reserved, out System.Runtime.InteropServices.ComTypes.IRunningObjectTable pprot) { }
        public static int OleInitialize(int pvReserved) { }
        public static int RegisterActiveObject(object punk, ref System.Guid rclsid, uint dwFlags, out uint pdwRegister) { }
        public static int StgCreateDocfile(string pwcsName, uint grfMode, uint reserved, System.Void** ppstgOpen) { }
        public static int StgCreateStorageEx(string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, JetBrains.Interop.WinApi.Declarations.Structures.STGOPTIONS* pStgOptions, System.Void* pSecurityDescriptor, System.Guid* riid, System.Void** ppObjectOpen) { }
        public static int StgOpenStorageEx(string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, JetBrains.Interop.WinApi.Declarations.Structures.STGOPTIONS* pStgOptions, System.Void* reserved2, System.Guid* riid, System.Void** ppObjectOpen) { }
        public class static NonPreserveSig
        {
            public static System.Runtime.InteropServices.ComTypes.IMoniker CreateItemMoniker(string lpszDelim, string lpszItem) { }
            public static System.Runtime.InteropServices.ComTypes.IRunningObjectTable GetRunningObjectTable(uint reserved) { }
        }
    }
    public class static OleAut32Dll
    {
        public static uint VariantClear(System.Void* pvarg) { }
        public static void VariantInit(System.Void* pvarg) { }
    }
    public enum OleCmdErr
    {
        OLECMDERR_E_FIRST = -2147221248,
        OLECMDERR_E_NOTSUPPORTED = -2147221248,
        OLECMDERR_E_DISABLED = -2147221247,
        OLECMDERR_E_NOHELP = -2147221246,
        OLECMDERR_E_CANCELED = -2147221245,
        OLECMDERR_E_UNKNOWNGROUP = -2147221244,
    }
    [JetBrains.Util.NoReorder()]
    public struct OPENFILENAME
    {
        public JetBrains.Interop.WinApi.OFN Flags;
        public System.IntPtr hInstance;
        public System.IntPtr hwndOwner;
        public System.IntPtr lCustData;
        public System.Void* lpfnHook;
        public System.IntPtr lpstrCustomFilter;
        public System.IntPtr lpstrDefExt;
        public System.IntPtr lpstrFile;
        public System.IntPtr lpstrFileTitle;
        public System.IntPtr lpstrFilter;
        public System.IntPtr lpstrInitialDir;
        public System.IntPtr lpstrTitle;
        public System.IntPtr lpTemplateName;
        public uint lStructSize;
        public ushort nFileExtension;
        public ushort nFileOffset;
        public uint nFilterIndex;
        public uint nMaxCustFilter;
        public uint nMaxFile;
        public uint nMaxFileTitle;
    }
    public struct PAINTSTRUCT
    {
        public bool fErase;
        public bool fIncUpdate;
        public bool fRestore;
        public System.IntPtr hdc;
        public JetBrains.Interop.WinApi.RECT rcPaint;
        public byte[] rgbReserved;
    }
    public enum PDTIMER_FLAGS
    {
        PDTIMER_RESET = 1,
        PDTIMER_PAUSE = 2,
        PDTIMER_RESUME = 3,
    }
    public enum PeekMessageOptions : uint
    {
        PM_NOREMOVE = 0u,
        PM_REMOVE = 1u,
        PM_NOYIELD = 2u,
        PM_QS_INPUT = 67567616u,
        PM_QS_POSTMESSAGE = 9961472u,
        PM_QS_PAINT = 2097152u,
        PM_QS_SENDMESSAGE = 4194304u,
    }
    public enum PenStyles
    {
        PS_SOLID = 0,
        PS_DASH = 1,
        PS_DOT = 2,
        PS_DASHDOT = 3,
        PS_DASHDOTDOT = 4,
        PS_NULL = 5,
        PS_INSIDEFRAME = 6,
        PS_USERSTYLE = 7,
        PS_ALTERNATE = 8,
        PS_STYLE_MASK = 15,
        PS_ENDCAP_ROUND = 0,
        PS_ENDCAP_SQUARE = 256,
        PS_ENDCAP_FLAT = 512,
        PS_ENDCAP_MASK = 3840,
        PS_JOIN_ROUND = 0,
        PS_JOIN_BEVEL = 4096,
        PS_JOIN_MITER = 8192,
        PS_JOIN_MASK = 61440,
        PS_COSMETIC = 0,
        PS_GEOMETRIC = 65536,
        PS_TYPE_MASK = 983040,
    }
    [JetBrains.Util.NoReorder()]
    public struct POINT
    {
        public static readonly JetBrains.Interop.WinApi.POINT Empty;
        public int x;
        public int y;
        public POINT(System.Drawing.Point p) { }
        public POINT(System.Windows.Point p) { }
        public POINT(int x, int y) { }
        public POINT(int dw) { }
        public POINT(System.IntPtr lParam) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public struct POINTAPI
    {
        public static readonly JetBrains.Interop.WinApi.POINTAPI Empty;
        public int x;
        public int y;
        public POINTAPI(System.Drawing.Point p) { }
        public POINTAPI(int X, int Y) { }
        public POINTAPI(int dw) { }
        public POINTAPI(System.IntPtr lParam) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    [System.FlagsAttribute()]
    public enum PrintWindowFlags : uint
    {
        PRF_CHECKVISIBLE = 1u,
        PRF_NONCLIENT = 2u,
        PRF_CLIENT = 4u,
        PRF_ERASEBKGND = 8u,
        PRF_CHILDREN = 16u,
        PRF_OWNED = 32u,
    }
    public class static Privileges
    {
        public static void Adjust([JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.Process process, NameAndAttributes[] data, bool throwIfNotAllAssigned) { }
        public struct NameAndAttributes
        {
            public JetBrains.Interop.WinApi.SePrivilege Attributes;
            public string SeName;
        }
    }
    [JetBrains.Util.NoReorder()]
    public struct PROCESSENTRY32
    {
        public uint cntThreads;
        public uint cntUsage;
        public uint dwFlags;
        public uint dwSize;
        public int pcPriClassBase;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(char), 260)]
        public JetBrains.Interop.WinApi.PROCESSENTRY32.<szExeFile>e__FixedBuffer7 szExeFile;
        public System.IntPtr th32DefaultHeapID;
        public uint th32ModuleID;
        public uint th32ParentProcessID;
        public uint th32ProcessID;
        public static JetBrains.Interop.WinApi.PROCESSENTRY32 NewWithSize() { }
    }
    public enum ProcessorArchitecture : ushort
    {
        PROCESSOR_ARCHITECTURE_INTEL = 0,
        PROCESSOR_ARCHITECTURE_MIPS = 1,
        PROCESSOR_ARCHITECTURE_ALPHA = 2,
        PROCESSOR_ARCHITECTURE_PPC = 3,
        PROCESSOR_ARCHITECTURE_SHX = 4,
        PROCESSOR_ARCHITECTURE_ARM = 5,
        PROCESSOR_ARCHITECTURE_IA64 = 6,
        PROCESSOR_ARCHITECTURE_ALPHA64 = 7,
        PROCESSOR_ARCHITECTURE_MSIL = 8,
        PROCESSOR_ARCHITECTURE_AMD64 = 9,
        PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10,
        PROCESSOR_ARCHITECTURE_NEUTRAL = 11,
        PROCESSOR_ARCHITECTURE_UNKNOWN = 65535,
    }
    public enum Product : uint
    {
        PRODUCT_UNDEFINED = 0u,
        PRODUCT_ULTIMATE = 1u,
        PRODUCT_HOME_BASIC = 2u,
        PRODUCT_HOME_PREMIUM = 3u,
        PRODUCT_ENTERPRISE = 4u,
        PRODUCT_HOME_BASIC_N = 5u,
        PRODUCT_BUSINESS = 6u,
        PRODUCT_STANDARD_SERVER = 7u,
        PRODUCT_DATACENTER_SERVER = 8u,
        PRODUCT_SMALLBUSINESS_SERVER = 9u,
        PRODUCT_ENTERPRISE_SERVER = 10u,
        PRODUCT_STARTER = 11u,
        PRODUCT_DATACENTER_SERVER_CORE = 12u,
        PRODUCT_STANDARD_SERVER_CORE = 13u,
        PRODUCT_ENTERPRISE_SERVER_CORE = 14u,
        PRODUCT_ENTERPRISE_SERVER_IA64 = 15u,
        PRODUCT_BUSINESS_N = 16u,
        PRODUCT_WEB_SERVER = 17u,
        PRODUCT_CLUSTER_SERVER = 18u,
        PRODUCT_HOME_SERVER = 19u,
        PRODUCT_STORAGE_EXPRESS_SERVER = 20u,
        PRODUCT_STORAGE_STANDARD_SERVER = 21u,
        PRODUCT_STORAGE_WORKGROUP_SERVER = 22u,
        PRODUCT_STORAGE_ENTERPRISE_SERVER = 23u,
        PRODUCT_SERVER_FOR_SMALLBUSINESS = 24u,
        PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 25u,
        PRODUCT_HOME_PREMIUM_N = 26u,
        PRODUCT_ENTERPRISE_N = 27u,
        PRODUCT_ULTIMATE_N = 28u,
        PRODUCT_WEB_SERVER_CORE = 29u,
        PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 30u,
        PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 31u,
        PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 32u,
        PRODUCT_SMALLBUSINESS_SERVER_PRIME = 33u,
        PRODUCT_HOME_PREMIUM_SERVER = 34u,
        PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 35u,
        PRODUCT_STANDARD_SERVER_V = 36u,
        PRODUCT_DATACENTER_SERVER_V = 37u,
        PRODUCT_ENTERPRISE_SERVER_V = 38u,
        PRODUCT_DATACENTER_SERVER_CORE_V = 39u,
        PRODUCT_STANDARD_SERVER_CORE_V = 40u,
        PRODUCT_ENTERPRISE_SERVER_CORE_V = 41u,
        PRODUCT_HYPERV = 42u,
        PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 43u,
        PRODUCT_STORAGE_STANDARD_SERVER_CORE = 44u,
        PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 45u,
        PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 46u,
        PRODUCT_STARTER_N = 47u,
        PRODUCT_PROFESSIONAL = 48u,
        PRODUCT_PROFESSIONAL_N = 49u,
        PRODUCT_SB_SOLUTION_SERVER = 50u,
        PRODUCT_SERVER_FOR_SB_SOLUTIONS = 51u,
        PRODUCT_STANDARD_SERVER_SOLUTIONS = 52u,
        PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 53u,
        PRODUCT_SB_SOLUTION_SERVER_EM = 54u,
        PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 55u,
        PRODUCT_SOLUTION_EMBEDDEDSERVER = 56u,
        PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 57u,
        PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 59u,
        PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 60u,
        PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 61u,
        PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 62u,
        PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 63u,
        PRODUCT_CLUSTER_SERVER_V = 64u,
        PRODUCT_EMBEDDED = 65u,
        PRODUCT_STARTER_E = 66u,
        PRODUCT_HOME_BASIC_E = 67u,
        PRODUCT_HOME_PREMIUM_E = 68u,
        PRODUCT_PROFESSIONAL_E = 69u,
        PRODUCT_ENTERPRISE_E = 70u,
        PRODUCT_ULTIMATE_E = 71u,
        PRODUCT_ENTERPRISE_EVALUATION = 72u,
        PRODUCT_PRERELEASE = 74u,
        PRODUCT_MULTIPOINT_STANDARD_SERVER = 76u,
        PRODUCT_MULTIPOINT_PREMIUM_SERVER = 77u,
        PRODUCT_STANDARD_EVALUATION_SERVER = 79u,
        PRODUCT_DATACENTER_EVALUATION_SERVER = 80u,
        PRODUCT_PRERELEASE_ARM = 81u,
        PRODUCT_PRERELEASE_N = 82u,
        PRODUCT_ENTERPRISE_N_EVALUATION = 84u,
        PRODUCT_EMBEDDEDINDUSTRY = 85u,
        PRODUCT_EMBEDDEDA = 86u,
        PRODUCT_EMBEDDEDINDUSTRYA = 87u,
        PRODUCT_EMBEDDEDAUTOMOTIVE = 88u,
        PRODUCT_EMBEDDEDE = 89u,
        PRODUCT_EMBEDDEDINDUSTRYAE = 90u,
        PRODUCT_EMBEDDEDINDUSTRYE = 91u,
        PRODUCT_THINPC = 92u,
        PRODUCT_PROFESSIONAL_PLUS = 93u,
        PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 95u,
        PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 96u,
        PRODUCT_UNLICENSED = 2882382797u,
    }
    public enum ProductType : ushort
    {
        VER_NT_WORKSTATION = 1,
        VER_NT_DOMAIN_CONTROLLER = 2,
        VER_NT_SERVER = 3,
    }
    public enum PROGDLG_FLAGS
    {
        PROGDLG_NORMAL = 0,
        PROGDLG_MODAL = 1,
        PROGDLG_AUTOTIME = 2,
        PROGDLG_NOTIME = 4,
        PROGDLG_NOMINIMIZE = 8,
        PROGDLG_NOPROGRESSBAR = 16,
        PROGDLG_MARQUEEPROGRESS = 32,
        PROGDLG_NOCANCEL = 64,
    }
    public class static PsApiDll
    {
        public static int EnumProcessModules(System.Void* hProcess, System.Void** lphModule, uint cb, System.UInt32* lpcbNeeded) { }
    }
    [System.FlagsAttribute()]
    public enum QueueStatusFlags : uint
    {
        QS_KEY = 1u,
        QS_MOUSEMOVE = 2u,
        QS_MOUSEBUTTON = 4u,
        QS_POSTMESSAGE = 8u,
        QS_TIMER = 16u,
        QS_PAINT = 32u,
        QS_SENDMESSAGE = 64u,
        QS_HOTKEY = 128u,
        QS_ALLPOSTMESSAGE = 256u,
        QS_RAWINPUT = 1024u,
        QS_MOUSE = 6u,
        QS_INPUT = 1031u,
        QS_ALLEVENTS = 1215u,
        QS_ALLINPUT = 1279u,
    }
    [JetBrains.Util.NoReorder()]
    public struct RECT
    {
        public int bottom;
        public static JetBrains.Interop.WinApi.RECT Empty;
        public int left;
        public int right;
        public int top;
        public RECT(int left, int top, int right, int bottom) { }
        public RECT(System.Drawing.Rectangle rect) { }
        public int Height { get; }
        public int Width { get; }
        public override string ToString() { }
    }
    [System.FlagsAttribute()]
    public enum RegOpenCreateDisposition : uint
    {
        REG_CREATED_NEW_KEY = 1u,
        REG_OPENED_EXISTING_KEY = 2u,
    }
    [System.FlagsAttribute()]
    public enum RegOpenCreateOptions : uint
    {
        REG_OPTION_RESERVED = 0u,
        REG_OPTION_NON_VOLATILE = 0u,
        REG_OPTION_VOLATILE = 1u,
        REG_OPTION_CREATE_LINK = 2u,
        REG_OPTION_BACKUP_RESTORE = 4u,
        REG_OPTION_OPEN_LINK = 8u,
        REG_LEGAL_OPTION = 15u,
    }
    public enum RegValueType : uint
    {
        REG_NONE = 0u,
        REG_SZ = 1u,
        REG_EXPAND_SZ = 2u,
        REG_BINARY = 3u,
        REG_DWORD = 4u,
        REG_DWORD_LITTLE_ENDIAN = 4u,
        REG_DWORD_BIG_ENDIAN = 5u,
        REG_LINK = 6u,
        REG_MULTI_SZ = 7u,
        REG_RESOURCE_LIST = 8u,
        REG_FULL_RESOURCE_DESCRIPTOR = 9u,
        REG_RESOURCE_REQUIREMENTS_LIST = 10u,
        REG_QWORD = 11u,
        REG_QWORD_LITTLE_ENDIAN = 11u,
    }
    public enum SC_STATUS_TYPE
    {
        SC_STATUS_PROCESS_INFO = 0,
    }
    [System.FlagsAttribute()]
    public enum ScrollWindowFlags : uint
    {
        SW_ERASE = 0u,
        SW_INVALIDATE = 1u,
        SW_SCROLLCHILDREN = 2u,
        SW_SMOOTHSCROLL = 3u,
    }
    [JetBrains.Util.NoReorder()]
    public struct SECURITY_ATTRIBUTES
    {
        public int bInheritHandle;
        public System.Void* lpSecurityDescriptor;
        public uint nLength;
    }
    public class static SeName
    {
        public static readonly string SE_ASSIGNPRIMARYTOKEN_NAME;
        public static readonly string SE_AUDIT_NAME;
        public static readonly string SE_BACKUP_NAME;
        public static readonly string SE_CHANGE_NOTIFY_NAME;
        public static readonly string SE_CREATE_GLOBAL_NAME;
        public static readonly string SE_CREATE_PAGEFILE_NAME;
        public static readonly string SE_CREATE_PERMANENT_NAME;
        public static readonly string SE_CREATE_SYMBOLIC_LINK_NAME;
        public static readonly string SE_CREATE_TOKEN_NAME;
        public static readonly string SE_DEBUG_NAME;
        public static readonly string SE_ENABLE_DELEGATION_NAME;
        public static readonly string SE_IMPERSONATE_NAME;
        public static readonly string SE_INC_BASE_PRIORITY_NAME;
        public static readonly string SE_INC_WORKING_SET_NAME;
        public static readonly string SE_INCREASE_QUOTA_NAME;
        public static readonly string SE_LOAD_DRIVER_NAME;
        public static readonly string SE_LOCK_MEMORY_NAME;
        public static readonly string SE_MACHINE_ACCOUNT_NAME;
        public static readonly string SE_MANAGE_VOLUME_NAME;
        public static readonly string SE_PROF_SINGLE_PROCESS_NAME;
        public static readonly string SE_RELABEL_NAME;
        public static readonly string SE_REMOTE_SHUTDOWN_NAME;
        public static readonly string SE_RESTORE_NAME;
        public static readonly string SE_SECURITY_NAME;
        public static readonly string SE_SHUTDOWN_NAME;
        public static readonly string SE_SYNC_AGENT_NAME;
        public static readonly string SE_SYSTEM_ENVIRONMENT_NAME;
        public static readonly string SE_SYSTEM_PROFILE_NAME;
        public static readonly string SE_SYSTEMTIME_NAME;
        public static readonly string SE_TAKE_OWNERSHIP_NAME;
        public static readonly string SE_TCB_NAME;
        public static readonly string SE_TIME_ZONE_NAME;
        public static readonly string SE_TRUSTED_CREDMAN_ACCESS_NAME;
        public static readonly string SE_UNDOCK_NAME;
        public static readonly string SE_UNSOLICITED_INPUT_NAME;
    }
    [System.FlagsAttribute()]
    public enum SePrivilege : uint
    {
        SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1u,
        SE_PRIVILEGE_ENABLED = 2u,
        SE_PRIVILEGE_REMOVED = 4u,
        SE_PRIVILEGE_USED_FOR_ACCESS = 2147483648u,
    }
    [JetBrains.Util.NoReorder()]
    public struct SERVICE_STATUS_PROCESS
    {
        public uint dwCheckPoint;
        public uint dwControlsAccepted;
        public uint dwCurrentState;
        public uint dwProcessId;
        public uint dwServiceFlags;
        public uint dwServiceSpecificExitCode;
        public uint dwServiceType;
        public uint dwWaitHint;
        public uint dwWin32ExitCode;
    }
    [System.FlagsAttribute()]
    public enum ServiceAccept : uint
    {
        SERVICE_ACCEPT_STOP = 1u,
        SERVICE_ACCEPT_PAUSE_CONTINUE = 2u,
        SERVICE_ACCEPT_SHUTDOWN = 4u,
        SERVICE_ACCEPT_PARAMCHANGE = 8u,
        SERVICE_ACCEPT_NETBINDCHANGE = 16u,
        SERVICE_ACCEPT_HARDWAREPROFILECHANGE = 32u,
        SERVICE_ACCEPT_POWEREVENT = 64u,
        SERVICE_ACCEPT_SESSIONCHANGE = 128u,
        SERVICE_ACCEPT_PRESHUTDOWN = 256u,
    }
    public enum ServiceFlags : uint
    {
        SERVICE_RUNS_IN_SYSTEM_PROCESS = 1u,
    }
    public enum ServiceState : uint
    {
        SERVICE_STOPPED = 1u,
        SERVICE_START_PENDING = 2u,
        SERVICE_STOP_PENDING = 3u,
        SERVICE_RUNNING = 4u,
        SERVICE_CONTINUE_PENDING = 5u,
        SERVICE_PAUSE_PENDING = 6u,
        SERVICE_PAUSED = 7u,
    }
    [System.FlagsAttribute()]
    public enum ServiceType : uint
    {
        SERVICE_KERNEL_DRIVER = 1u,
        SERVICE_FILE_SYSTEM_DRIVER = 2u,
        SERVICE_ADAPTER = 4u,
        SERVICE_RECOGNIZER_DRIVER = 8u,
        SERVICE_DRIVER = 11u,
        SERVICE_WIN32_OWN_PROCESS = 16u,
        SERVICE_WIN32_SHARE_PROCESS = 32u,
        SERVICE_WIN32 = 48u,
        SERVICE_INTERACTIVE_PROCESS = 256u,
        SERVICE_TYPE_ALL = 319u,
    }
    [System.FlagsAttribute()]
    public enum SetLayeredWindowAttributesFlags : uint
    {
        LWA_COLORKEY = 1u,
        LWA_ALPHA = 2u,
    }
    [System.FlagsAttribute()]
    public enum SetWindowPosFlags : uint
    {
        SWP_NOSIZE = 1u,
        SWP_NOMOVE = 2u,
        SWP_NOZORDER = 4u,
        SWP_NOREDRAW = 8u,
        SWP_NOACTIVATE = 16u,
        SWP_FRAMECHANGED = 32u,
        SWP_SHOWWINDOW = 64u,
        SWP_HIDEWINDOW = 128u,
        SWP_NOCOPYBITS = 256u,
        SWP_NOOWNERZORDER = 512u,
        SWP_NOSENDCHANGING = 1024u,
        SWP_DEFERERASE = 8192u,
        SWP_ASYNCWINDOWPOS = 16384u,
        SWP_NOREPOSITION = 512u,
        SWP_DRAWFRAME = 32u,
    }
    public class static Shell32Dll
    {
        public static int Shell_NotifyIconW(uint message, System.Void* pnid) { }
        public static int ShellExecuteExW(ref JetBrains.Interop.WinApi.SHELLEXECUTEINFO lpExecInfo) { }
        public static System.UIntPtr SHGetFileInfoW(string pszPath, uint dwFileAttributes, JetBrains.Interop.WinApi.SHFILEINFO* psfi, uint cbFileInfo, uint uFlags) { }
        public static int SHGetKnownFolderPath(System.Guid* rfid, uint dwFlags, System.Void* hToken, System.Char** ppszPath) { }
    }
    public struct SHELLEXECUTEINFO
    {
        public uint cbSize;
        public uint dwHotKey;
        public JetBrains.Interop.WinApi.SHELLEXECUTEINFO_MASK fMask;
        public System.IntPtr hIcon;
        public System.IntPtr hInstApp;
        public System.Void* hkeyClass;
        public System.IntPtr hProcess;
        public System.IntPtr hwnd;
        public string lpClass;
        public string lpDirectory;
        public string lpFile;
        public System.Void* lpIDList;
        public string lpParameters;
        public string lpVerb;
        public JetBrains.Interop.WinApi.ShowWindowCommands nShow;
    }
    public enum SHELLEXECUTEINFO_MASK : uint
    {
        SEE_MASK_DEFAULT = 0u,
        SEE_MASK_CLASSNAME = 1u,
        SEE_MASK_CLASSKEY = 3u,
        SEE_MASK_IDLIST = 4u,
        SEE_MASK_INVOKEIDLIST = 12u,
        SEE_MASK_ICON = 16u,
        SEE_MASK_HOTKEY = 32u,
        SEE_MASK_NOCLOSEPROCESS = 64u,
        SEE_MASK_CONNECTNETDRV = 128u,
        SEE_MASK_NOASYNC = 256u,
        SEE_MASK_FLAG_DDEWAIT = 256u,
        SEE_MASK_DOENVSUBST = 512u,
        SEE_MASK_FLAG_NO_UI = 1024u,
        SEE_MASK_UNICODE = 16384u,
        SEE_MASK_NO_CONSOLE = 32768u,
        SEE_MASK_ASYNCOK = 1048576u,
        SEE_MASK_NOQUERYCLASSSTORE = 16777216u,
        SEE_MASK_HMONITOR = 2097152u,
        SEE_MASK_NOZONECHECKS = 8388608u,
        SEE_MASK_WAITFORINPUTIDLE = 33554432u,
        SEE_MASK_FLAG_LOG_USAGE = 67108864u,
    }
    public struct SHFILEINFO
    {
        public uint dwAttributes;
        public System.Void* hIcon;
        public int iIcon;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(ushort), 260)]
        public JetBrains.Interop.WinApi.SHFILEINFO.<szDisplayName>e__FixedBuffer1 szDisplayName;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(ushort), 80)]
        public JetBrains.Interop.WinApi.SHFILEINFO.<szTypeName>e__FixedBuffer2 szTypeName;
    }
    public class static SHFolderDll
    {
        public static int SHGetFolderPathW(System.Void* hwndOwner, int nFolder, System.Void* hToken, uint dwFlags, System.Text.StringBuilder lpszPath) { }
    }
    public enum SHGFP_TYPE
    {
        SHGFP_TYPE_CURRENT = 0,
        SHGFP_TYPE_DEFAULT = 1,
    }
    public class static ShlwapiDll
    {
        public static int SHDeleteKeyW(System.Void* hkey, string pszSubKey) { }
    }
    public enum ShowWindowCommands
    {
        SW_HIDE = 0,
        SW_SHOWNORMAL = 1,
        SW_NORMAL = 1,
        SW_SHOWMINIMIZED = 2,
        SW_SHOWMAXIMIZED = 3,
        SW_MAXIMIZE = 3,
        SW_SHOWNOACTIVATE = 4,
        SW_SHOW = 5,
        SW_MINIMIZE = 6,
        SW_SHOWMINNOACTIVE = 7,
        SW_SHOWNA = 8,
        SW_RESTORE = 9,
        SW_SHOWDEFAULT = 10,
        SW_FORCEMINIMIZE = 11,
        SW_MAX = 11,
    }
    public enum StockCursors
    {
        IDC_APPSTARTING = 32650,
        IDC_ARROW = 32512,
        IDC_CROSS = 32515,
        IDC_HAND = 32649,
        IDC_HELP = 32651,
        IDC_IBEAM = 32513,
        IDC_ICON = 32641,
        IDC_NO = 32648,
        IDC_SIZE = 32640,
        IDC_SIZEALL = 32646,
        IDC_SIZENESW = 32643,
        IDC_SIZENS = 32645,
        IDC_SIZENWSE = 32642,
        IDC_SIZEWE = 32644,
        IDC_UPARROW = 32516,
        IDC_WAIT = 32514,
    }
    public enum StockLogicalObjects
    {
        WHITE_BRUSH = 0,
        LTGRAY_BRUSH = 1,
        GRAY_BRUSH = 2,
        DKGRAY_BRUSH = 3,
        BLACK_BRUSH = 4,
        NULL_BRUSH = 5,
        HOLLOW_BRUSH = 5,
        WHITE_PEN = 6,
        BLACK_PEN = 7,
        NULL_PEN = 8,
        OEM_FIXED_FONT = 10,
        ANSI_FIXED_FONT = 11,
        ANSI_VAR_FONT = 12,
        SYSTEM_FONT = 13,
        DEVICE_DEFAULT_FONT = 14,
        DEFAULT_PALETTE = 15,
        SYSTEM_FIXED_FONT = 16,
        DEFAULT_GUI_FONT = 17,
        DC_BRUSH = 18,
        DC_PEN = 19,
    }
    [System.FlagsAttribute()]
    public enum SuiteMask : ushort
    {
        VER_SUITE_SMALLBUSINESS = 1,
        VER_SUITE_ENTERPRISE = 2,
        VER_SUITE_BACKOFFICE = 4,
        VER_SUITE_COMMUNICATIONS = 8,
        VER_SUITE_TERMINAL = 16,
        VER_SUITE_SMALLBUSINESS_RESTRICTED = 32,
        VER_SUITE_EMBEDDEDNT = 64,
        VER_SUITE_DATACENTER = 128,
        VER_SUITE_SINGLEUSERTS = 256,
        VER_SUITE_PERSONAL = 512,
        VER_SUITE_BLADE = 1024,
        VER_SUITE_EMBEDDED_RESTRICTED = 2048,
        VER_SUITE_SECURITY_APPLIANCE = 4096,
        VER_SUITE_STORAGE_SERVER = 8192,
        VER_SUITE_COMPUTE_SERVER = 16384,
        VER_SUITE_WH_SERVER = 32768,
    }
    [JetBrains.Util.NoReorder()]
    public struct SYSTEM_INFO
    {
        public System.UIntPtr dwActiveProcessorMask;
        public uint dwAllocationGranularity;
        public uint dwNumberOfProcessors;
        public uint dwPageSize;
        public uint dwProcessorType;
        public System.IntPtr lpMaximumApplicationAddress;
        public System.IntPtr lpMinimumApplicationAddress;
        public ushort wProcessorArchitecture;
        public ushort wProcessorLevel;
        public ushort wProcessorRevision;
        public ushort wReserved;
    }
    public enum SystemMetricsCodes
    {
        SM_CXSCREEN = 0,
        SM_CYSCREEN = 1,
        SM_CXVSCROLL = 2,
        SM_CYHSCROLL = 3,
        SM_CYCAPTION = 4,
        SM_CXBORDER = 5,
        SM_CYBORDER = 6,
        SM_CXDLGFRAME = 7,
        SM_CYDLGFRAME = 8,
        SM_CYVTHUMB = 9,
        SM_CXHTHUMB = 10,
        SM_CXICON = 11,
        SM_CYICON = 12,
        SM_CXCURSOR = 13,
        SM_CYCURSOR = 14,
        SM_CYMENU = 15,
        SM_CXFULLSCREEN = 16,
        SM_CYFULLSCREEN = 17,
        SM_CYKANJIWINDOW = 18,
        SM_MOUSEPRESENT = 19,
        SM_CYVSCROLL = 20,
        SM_CXHSCROLL = 21,
        SM_DEBUG = 22,
        SM_SWAPBUTTON = 23,
        SM_RESERVED1 = 24,
        SM_RESERVED2 = 25,
        SM_RESERVED3 = 26,
        SM_RESERVED4 = 27,
        SM_CXMIN = 28,
        SM_CYMIN = 29,
        SM_CXSIZE = 30,
        SM_CYSIZE = 31,
        SM_CXFRAME = 32,
        SM_CYFRAME = 33,
        SM_CXMINTRACK = 34,
        SM_CYMINTRACK = 35,
        SM_CXDOUBLECLK = 36,
        SM_CYDOUBLECLK = 37,
        SM_CXICONSPACING = 38,
        SM_CYICONSPACING = 39,
        SM_MENUDROPALIGNMENT = 40,
        SM_PENWINDOWS = 41,
        SM_DBCSENABLED = 42,
        SM_CMOUSEBUTTONS = 43,
        SM_CXFIXEDFRAME = 7,
        SM_CYFIXEDFRAME = 8,
        SM_CXSIZEFRAME = 32,
        SM_CYSIZEFRAME = 33,
        SM_SECURE = 44,
        SM_CXEDGE = 45,
        SM_CYEDGE = 46,
        SM_CXMINSPACING = 47,
        SM_CYMINSPACING = 48,
        SM_CXSMICON = 49,
        SM_CYSMICON = 50,
        SM_CYSMCAPTION = 51,
        SM_CXSMSIZE = 52,
        SM_CYSMSIZE = 53,
        SM_CXMENUSIZE = 54,
        SM_CYMENUSIZE = 55,
        SM_ARRANGE = 56,
        SM_CXMINIMIZED = 57,
        SM_CYMINIMIZED = 58,
        SM_CXMAXTRACK = 59,
        SM_CYMAXTRACK = 60,
        SM_CXMAXIMIZED = 61,
        SM_CYMAXIMIZED = 62,
        SM_NETWORK = 63,
        SM_CLEANBOOT = 67,
        SM_CXDRAG = 68,
        SM_CYDRAG = 69,
        SM_SHOWSOUNDS = 70,
        SM_CXMENUCHECK = 71,
        SM_CYMENUCHECK = 72,
        SM_SLOWMACHINE = 73,
        SM_MIDEASTENABLED = 74,
        SM_MOUSEWHEELPRESENT = 75,
        SM_XVIRTUALSCREEN = 76,
        SM_YVIRTUALSCREEN = 77,
        SM_CXVIRTUALSCREEN = 78,
        SM_CYVIRTUALSCREEN = 79,
        SM_CMONITORS = 80,
        SM_SAMEDISPLAYFORMAT = 81,
        SM_IMMENABLED = 82,
        SM_CXFOCUSBORDER = 83,
        SM_CYFOCUSBORDER = 84,
        SM_TABLETPC = 86,
        SM_MEDIACENTER = 87,
        SM_STARTER = 88,
        SM_SERVERR2 = 89,
        SM_MOUSEHORIZONTALWHEELPRESENT = 91,
        SM_CXPADDEDBORDER = 92,
        SM_CMETRICS = 93,
        SM_REMOTESESSION = 4096,
        SM_SHUTTINGDOWN = 8192,
        SM_REMOTECONTROL = 8193,
        SM_CARETBLINKINGENABLED = 8194,
    }
    [System.FlagsAttribute()]
    public enum TH32CS : uint
    {
        TH32CS_SNAPHEAPLIST = 1u,
        TH32CS_SNAPPROCESS = 2u,
        TH32CS_SNAPTHREAD = 4u,
        TH32CS_SNAPMODULE = 8u,
        TH32CS_SNAPALL = 15u,
        TH32CS_INHERIT = 2147483648u,
    }
    [System.FlagsAttribute()]
    public enum ThreadAccess
    {
        TERMINATE = 1,
        SUSPEND_RESUME = 2,
        GET_CONTEXT = 8,
        SET_CONTEXT = 16,
        SET_INFORMATION = 32,
        QUERY_INFORMATION = 64,
        SET_THREAD_TOKEN = 128,
        IMPERSONATE = 256,
        DIRECT_IMPERSONATION = 512,
    }
    [JetBrains.Util.NoReorder()]
    public struct TOKEN_PRIVILEGES
    {
        public uint PrivilegeCount;
        public JetBrains.Interop.WinApi.LUID_AND_ATTRIBUTES Privileges;
        public static uint SizeOf(int nPrivileges) { }
        public static void StructureToPtr(JetBrains.Interop.WinApi.TOKEN_PRIVILEGES* pTokenPrivileges, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Interop.WinApi.LUID_AND_ATTRIBUTES> privileges) { }
    }
    [System.FlagsAttribute()]
    public enum TokenSpecificAccessRights : uint
    {
        TOKEN_ASSIGN_PRIMARY = 1u,
        TOKEN_DUPLICATE = 2u,
        TOKEN_IMPERSONATE = 4u,
        TOKEN_QUERY = 8u,
        TOKEN_QUERY_SOURCE = 16u,
        TOKEN_ADJUST_PRIVILEGES = 32u,
        TOKEN_ADJUST_GROUPS = 64u,
        TOKEN_ADJUST_DEFAULT = 128u,
        TOKEN_ADJUST_SESSIONID = 256u,
        TOKEN_ALL_ACCESS_P = 983295u,
        TOKEN_ALL_ACCESS = 983551u,
        TOKEN_READ = 131080u,
        TOKEN_WRITE = 131296u,
        TOKEN_EXECUTE = 131072u,
    }
    public class static User32Dll
    {
        public static uint BringWindowToTop(System.Void* hWnd) { }
        public static System.IntPtr CallWindowProcW(System.Void* lpPrevWndFunc, System.Void* hWnd, uint Msg, System.IntPtr wParam, System.IntPtr lParam) { }
        public static int ClientToScreen(System.Void* hWnd, JetBrains.Interop.WinApi.POINT* lpPoint) { }
        public static System.Void* CreateDesktopW(string lpszDesktop, string lpszDevice, System.Void* pDevmode, uint dwFlags, uint dwDesiredAccess, System.Void* lpsa) { }
        public static int DestroyIcon(System.Void* hIcon) { }
        public static int DestroyWindow(System.Void* hWnd) { }
        public static System.IntPtr DispatchMessageW(JetBrains.Interop.WinApi.MSG* lpmsg) { }
        public static int EnableMenuItem(System.Void* hMenu, uint uIDEnableItem, uint uEnable) { }
        public static int EnableWindow(System.Void* hWnd, int bEnable) { }
        public static int EnumChildWindows(System.Void* hWndParent, System.Void* lpEnumFunc, System.IntPtr lParam) { }
        public static int EnumThreadWindows(uint dwThreadId, System.Void* lpfn, System.IntPtr lParam) { }
        public static int EnumWindows(System.Void* lpEnumFunc, System.IntPtr lParam) { }
        public static int FillRect(System.Void* hDC, JetBrains.Interop.WinApi.RECT* lprc, System.Void* hbr) { }
        public static uint FlashWindowEx(JetBrains.Interop.WinApi.Declarations.Structures.FLASHWINFO* pfwi) { }
        public static System.Void* GetActiveWindow() { }
        public static System.Void* GetAncestor(System.Void* hwnd, uint gaFlags) { }
        public static short GetAsyncKeyState(int vKey) { }
        public static int GetClassNameW(System.Void* hWnd, System.Char* lpClassName, int nMaxCount) { }
        public static int GetClientRect(System.Void* hWnd, JetBrains.Interop.WinApi.RECT* lpRect) { }
        public static int GetCursorInfo(JetBrains.Interop.WinApi.Declarations.Structures.CURSORINFO* pci) { }
        [System.ObsoleteAttribute("Use GetCursorInfo instead. This function fails in 32-bit apps on 64-bit systems u" +
            "p to NT 6.0 when lpPoint is above 2GB.")]
        public static int GetCursorPos(JetBrains.Interop.WinApi.POINT* lpPoint) { }
        public static System.Void* GetDesktopWindow() { }
        public static System.Void* GetDlgItem(System.Void* hDlg, int nIDDlgItem) { }
        public static System.Void* GetFocus() { }
        public static System.Void* GetForegroundWindow() { }
        public static int GetGUIThreadInfo(uint idThread, JetBrains.Interop.WinApi.GUITHREADINFO* lpgui) { }
        public static short GetKeyState(int nVirtKey) { }
        public static int GetMessageW(JetBrains.Interop.WinApi.MSG* lpMsg, System.Void* hWnd, uint wMsgFilterMin, uint wMsgFilterMax) { }
        public static System.Void* GetParent(System.Void* hWnd) { }
        public static System.Void* GetSystemMenu(System.Void* hWnd, int bRevert) { }
        public static int GetSystemMetrics(int nIndex) { }
        public static System.Void* GetThreadDesktop(uint dwThreadId) { }
        public static System.Void* GetWindowLongPtrW(System.Void* hWnd, int nIndex) { }
        public static int GetWindowRect(System.Void* hWnd, JetBrains.Interop.WinApi.RECT* lpRect) { }
        public static int GetWindowTextW(System.Void* hWnd, System.Char* lpString, int nMaxCount) { }
        public static uint GetWindowThreadProcessId(System.Void* hWnd, System.UInt32* lpdwProcessId) { }
        public static int InvalidateRect(System.Void* hWnd, JetBrains.Interop.WinApi.RECT* lpRect, int bErase) { }
        public static int IsChild(System.Void* hWndParent, System.Void* hWnd) { }
        public static uint IsIconic(System.Void* hWnd) { }
        public static int IsWindow(System.Void* hWnd) { }
        public static int IsWindowEnabled(System.Void* hWnd) { }
        public static uint IsWindowUnicode(System.Void* hWnd) { }
        public static int IsWindowVisible(System.Void* hWnd) { }
        public static uint IsZoomed(System.Void* hWnd) { }
        [System.ObsoleteAttribute("Note  This function has been superseded. Use SendInput instead. ©MSDN")]
        public static void keybd_event(byte bVk, byte bScan, uint dwFlags, System.UIntPtr dwExtraInfo) { }
        public static System.Void* LoadCursorW(System.Void* hInstance, System.Char* lpCursorName) { }
        public static int LoadStringW(System.Void* hInstance, uint uID, System.UInt16* lpBuffer, int nBufferMax) { }
        public static int MapWindowPoints(System.Void* hWndFrom, System.Void* hWndTo, JetBrains.Interop.WinApi.POINT* lpPoints, uint cPoints) { }
        public static int MessageBoxW(System.Void* hWnd, string lpText, string lpCaption, uint uType) { }
        [System.ObsoleteAttribute("Note  This function has been superseded. Use SendInput instead. ©MSDN")]
        public static void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, System.UIntPtr dwExtraInfo) { }
        public static uint MsgWaitForMultipleObjects(uint nCount, System.Void** pHandles, int bWaitAll, uint dwMilliseconds, uint dwWakeMask) { }
        public static uint MsgWaitForMultipleObjectsEx(uint nCount, System.Void** pHandles, uint dwMilliseconds, uint dwWakeMask, uint dwFlags) { }
        public static System.Void* OpenDesktopW(string lpszDesktop, uint dwFlags, int fInherit, uint dwDesiredAccess) { }
        public static System.Void* OpenWindowStationW(string lpszWinSta, int fInherit, uint dwDesiredAccess) { }
        public static int PeekMessageW(JetBrains.Interop.WinApi.MSG* lpMsg, System.Void* hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg) { }
        public static int PostMessageW(System.Void* hWnd, uint Msg, System.IntPtr wParam, System.IntPtr lParam) { }
        public static void PostQuitMessage(int exitCode) { }
        public static int PostThreadMessageW(uint idThread, uint Msg, System.IntPtr wParam, System.IntPtr lParam) { }
        public static int PrintWindow(System.Void* hwnd, System.Void* hdcBlt, uint nFlags) { }
        public static uint RegisterWindowMessageW(string lpString) { }
        public static int ScreenToClient(System.Void* hWnd, JetBrains.Interop.WinApi.POINT* lpPoint) { }
        public static System.IntPtr SendMessageTimeoutW(System.Void* hWnd, uint Msg, System.IntPtr wParam, System.IntPtr lParam, uint fuFlags, uint uTimeout, System.UInt32* lpdwResult) { }
        public static System.IntPtr SendMessageW(System.Void* hWnd, uint Msg, System.IntPtr wParam, System.IntPtr lParam) { }
        public static System.Void* SetActiveWindow(System.Void* hWnd) { }
        public static System.Void* SetCursor(System.Void* hCursor) { }
        public static System.Void* SetFocus(System.Void* hWnd) { }
        public static int SetForegroundWindow(System.Void* hWnd) { }
        public static int SetLayeredWindowAttributes(System.Void* hwnd, uint crKey, byte bAlpha, uint dwFlags) { }
        public static System.Void* SetParent(System.Void* hWndChild, System.Void* hWndNewParent) { }
        public static int SetProcessWindowStation(System.Void* hWinSta) { }
        public static int SetThreadDesktop(System.Void* hDesktop) { }
        public static System.Void* SetWindowLongPtrW(System.Void* hWnd, int nIndex, System.Void* dwNewLong) { }
        public static uint ShowWindow(System.Void* hWnd, int nCmdShow) { }
        public static void SwitchToThisWindow(System.Void* hWnd, uint fAltTab) { }
        public static int TranslateMessage(JetBrains.Interop.WinApi.MSG* lpMsg) { }
        public static int UpdateLayeredWindow(System.Void* hwnd, System.Void* hdcDst, JetBrains.Interop.WinApi.POINT* pptDst, JetBrains.Interop.WinApi.Declarations.Structures.SIZE* psize, System.Void* hdcSrc, JetBrains.Interop.WinApi.POINT* pptSrc, uint crKey, JetBrains.Interop.WinApi.Declarations.Structures.BLENDFUNCTION* pblend, uint dwFlags) { }
        public static int ValidateRect(System.Void* hWnd, JetBrains.Interop.WinApi.RECT* lpRect) { }
        public static short VkKeyScanW(char ch) { }
        public static int WaitMessage() { }
        public static System.Void* WindowFromPoint(JetBrains.Interop.WinApi.POINT Point) { }
        public class static Helpers
        {
            public static bool BringWindowToTop(System.IntPtr hWnd) { }
            public static System.IntPtr CallWindowProcW(JetBrains.Interop.WinApi.User32Dll.Helpers.WndProcCallBack lpPrevWndFunc, System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowsMessages Msg, System.IntPtr param, System.IntPtr lParam) { }
            public static System.Drawing.Point ClientToScreen(System.IntPtr hwnd, System.Drawing.Point ptClient) { }
            public static System.Drawing.Rectangle ClientToScreen(System.IntPtr hwnd, System.Drawing.Rectangle rcClient) { }
            public static bool DestroyWindow(System.IntPtr hwnd) { }
            public static void DisableWindow(System.IntPtr hwnd) { }
            public static void EnableWindow(System.IntPtr hwnd) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static System.Collections.Generic.List<System.IntPtr> GetChildWindowHandles(System.IntPtr parent) { }
            public static System.Drawing.Rectangle GetClientRect(System.IntPtr hwnd) { }
            public static System.Drawing.Point GetCursorInfo() { }
            public static System.IntPtr GetDlgItem(System.IntPtr hDlg, int nDlgItem) { }
            public static System.IntPtr GetFocus() { }
            public static System.Void* GetFocusOnAnyThreadInAnyProcess() { }
            public static System.Void* GetFocusOnAnyThreadInOurProcess() { }
            public static System.IntPtr GetParent(System.IntPtr hwnd) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static System.Collections.Generic.List<System.IntPtr> GetThreadTopLevelWindowHandles(uint dwThreadId) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static System.Collections.Generic.List<System.IntPtr> GetTopLevelWindowHandles() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string GetWindowClassName(System.IntPtr hwnd) { }
            public static System.Void* GetWindowLongPtrW(System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowLongPtrIndex nIndex) { }
            public static int GetWindowProcessId(System.IntPtr hwnd) { }
            public static System.Drawing.Rectangle GetWindowRect(System.IntPtr hwnd) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string GetWindowText(System.IntPtr hwnd) { }
            public static int GetWindowThreadId(System.IntPtr hwnd) { }
            public static bool InvalidateRect(System.IntPtr hWnd, System.Nullable<System.Drawing.Rectangle> rect, bool erase) { }
            public static bool IsIconic(System.IntPtr hWnd) { }
            public static bool IsThreadWithMessageQueue(uint threadid) { }
            public static bool IsWindow(System.IntPtr handle) { }
            public static bool IsWindowEnabled(System.IntPtr handle) { }
            public static bool IsWindowVisible(System.IntPtr handle) { }
            public static bool IsZoomed(System.IntPtr hWnd) { }
            public static bool PostMessage(System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowsMessages msg, System.IntPtr wParam, System.IntPtr lParam) { }
            public static System.Drawing.Point ScreenToClient(System.IntPtr hwnd, System.Drawing.Point ptScreen) { }
            public static System.Drawing.Rectangle ScreenToClient(System.IntPtr hwnd, System.Drawing.Rectangle rcScreen) { }
            public static System.IntPtr SendMessageTimeoutW(System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowsMessages msg, System.IntPtr wParam, System.IntPtr lParam, JetBrains.Interop.WinApi.Declarations.Constants.SMTO fuFlags, uint uTimeout, out uint dwResult) { }
            public static System.IntPtr SendMessageW(System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowsMessages msg, System.IntPtr wParam, System.IntPtr lParam) { }
            public static System.IntPtr SetActiveWindow(System.IntPtr hWnd) { }
            public static System.IntPtr SetFocus(System.IntPtr hWnd) { }
            public static bool SetForegroundWindow(System.IntPtr hWnd) { }
            public static bool SetLayeredWindowAttributes([JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.IWin32Window window, System.Drawing.Color colorkey, double alpha, JetBrains.Interop.WinApi.SetLayeredWindowAttributesFlags flags) { }
            public static void SetWindowExStyle(System.Windows.Forms.IWin32Window hwnd, JetBrains.Interop.WinApi.WindowExStyles style, bool set) { }
            public static void SetWindowExStyle(System.Void* hwnd, JetBrains.Interop.WinApi.WindowExStyles style, bool set) { }
            public static System.Void* SetWindowLongPtrW(System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowLongPtrIndex nIndex, System.Void* dwNewLong) { }
            public static void SetWindowStyle(System.Windows.Forms.IWin32Window hwnd, JetBrains.Interop.WinApi.WindowStyles style, bool set) { }
            public static void SetWindowStyle(System.Void* hwnd, JetBrains.Interop.WinApi.WindowStyles style, bool set) { }
            public static void SetWindowStyleRaw(System.Void* hwnd, uint style, JetBrains.Interop.WinApi.WindowLongPtrIndex index, bool set) { }
            public static bool ShowWindow(System.IntPtr hWnd, JetBrains.Interop.WinApi.ShowWindowCommands nCmdShow) { }
            public static void SwitchToThisWindow(System.IntPtr hWnd, bool fAltTab) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static string TryGetWindowClassName(System.IntPtr hwnd) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static string TryLoadStringResource([JetBrains.Annotations.NotNullAttribute()] string sDllFilename, uint nResourceId) { }
            public delegate int EnumWindowsProc(System.Void* hwnd, System.IntPtr lParam);
            public delegate System.IntPtr WndProcCallBack(System.IntPtr hWnd, JetBrains.Interop.WinApi.WindowsMessages Msg, System.IntPtr wParam, System.IntPtr lParam);
        }
        public class static Only32Bit { }
        public class static Only64Bit
        {
            public static System.Void* GetWindowLongPtrW(System.Void* hWnd, int nIndex) { }
            public static System.Void* SetWindowLongPtrW(System.Void* hWnd, int nIndex, System.Void* dwNewLong) { }
        }
    }
    public class static UxThemeDll
    {
        public static int CloseThemeData(System.Void* hTheme) { }
        public static int DrawThemeBackground(System.Void* hTheme, System.Void* hdc, int iPartId, int iStateId, JetBrains.Interop.WinApi.RECT* pRect, JetBrains.Interop.WinApi.RECT* pClipRect) { }
        public static bool IsAvailable() { }
        public static System.Void* OpenThemeData(System.Void* hwnd, string pszClassList) { }
    }
    public class static VersionDll
    {
        public static uint GetFileVersionInfoSizeW(string lptstrFilename, System.UInt32* lpdwHandle) { }
        public static int GetFileVersionInfoW(string lptstrFilename, uint dwHandle, uint dwLen, System.Void* lpData) { }
        public static int VerQueryValueW(System.Void* pBlock, string lpSubBlock, System.Void** lplpBuffer, System.UInt32* puLen) { }
        public class static Helpers
        {
            public static JetBrains.Interop.WinApi.VS_FIXEDFILEINFO GetFileVersionInfo(string fileName) { }
        }
    }
    public enum VirtualKey
    {
        VK_LBUTTON = 1,
        VK_RBUTTON = 2,
        VK_CANCEL = 3,
        VK_MBUTTON = 4,
        VK_XBUTTON1 = 5,
        VK_XBUTTON2 = 6,
        VK_BACK = 8,
        VK_TAB = 9,
        VK_CLEAR = 12,
        VK_RETURN = 13,
        VK_SHIFT = 16,
        VK_CONTROL = 17,
        VK_MENU = 18,
        VK_PAUSE = 19,
        VK_CAPITAL = 20,
        VK_KANA = 21,
        VK_HANGEUL = 21,
        VK_HANGUL = 21,
        VK_JUNJA = 23,
        VK_FINAL = 24,
        VK_HANJA = 25,
        VK_KANJI = 25,
        VK_ESCAPE = 27,
        VK_CONVERT = 28,
        VK_NONCONVERT = 29,
        VK_ACCEPT = 30,
        VK_MODECHANGE = 31,
        VK_SPACE = 32,
        VK_PRIOR = 33,
        VK_NEXT = 34,
        VK_END = 35,
        VK_HOME = 36,
        VK_LEFT = 37,
        VK_UP = 38,
        VK_RIGHT = 39,
        VK_DOWN = 40,
        VK_SELECT = 41,
        VK_PRINT = 42,
        VK_EXECUTE = 43,
        VK_SNAPSHOT = 44,
        VK_INSERT = 45,
        VK_DELETE = 46,
        VK_HELP = 47,
        VK_LWIN = 91,
        VK_RWIN = 92,
        VK_APPS = 93,
        VK_SLEEP = 95,
        VK_NUMPAD0 = 96,
        VK_NUMPAD1 = 97,
        VK_NUMPAD2 = 98,
        VK_NUMPAD3 = 99,
        VK_NUMPAD4 = 100,
        VK_NUMPAD5 = 101,
        VK_NUMPAD6 = 102,
        VK_NUMPAD7 = 103,
        VK_NUMPAD8 = 104,
        VK_NUMPAD9 = 105,
        VK_MULTIPLY = 106,
        VK_ADD = 107,
        VK_SEPARATOR = 108,
        VK_SUBTRACT = 109,
        VK_DECIMAL = 110,
        VK_DIVIDE = 111,
        VK_F1 = 112,
        VK_F2 = 113,
        VK_F3 = 114,
        VK_F4 = 115,
        VK_F5 = 116,
        VK_F6 = 117,
        VK_F7 = 118,
        VK_F8 = 119,
        VK_F9 = 120,
        VK_F10 = 121,
        VK_F11 = 122,
        VK_F12 = 123,
        VK_F13 = 124,
        VK_F14 = 125,
        VK_F15 = 126,
        VK_F16 = 127,
        VK_F17 = 128,
        VK_F18 = 129,
        VK_F19 = 130,
        VK_F20 = 131,
        VK_F21 = 132,
        VK_F22 = 133,
        VK_F23 = 134,
        VK_F24 = 135,
        VK_NUMLOCK = 144,
        VK_SCROLL = 145,
        VK_OEM_NEC_EQUAL = 146,
        VK_OEM_FJ_JISHO = 146,
        VK_OEM_FJ_MASSHOU = 147,
        VK_OEM_FJ_TOUROKU = 148,
        VK_OEM_FJ_LOYA = 149,
        VK_OEM_FJ_ROYA = 150,
        VK_LSHIFT = 160,
        VK_RSHIFT = 161,
        VK_LCONTROL = 162,
        VK_RCONTROL = 163,
        VK_LMENU = 164,
        VK_RMENU = 165,
        VK_BROWSER_BACK = 166,
        VK_BROWSER_FORWARD = 167,
        VK_BROWSER_REFRESH = 168,
        VK_BROWSER_STOP = 169,
        VK_BROWSER_SEARCH = 170,
        VK_BROWSER_FAVORITES = 171,
        VK_BROWSER_HOME = 172,
        VK_VOLUME_MUTE = 173,
        VK_VOLUME_DOWN = 174,
        VK_VOLUME_UP = 175,
        VK_MEDIA_NEXT_TRACK = 176,
        VK_MEDIA_PREV_TRACK = 177,
        VK_MEDIA_STOP = 178,
        VK_MEDIA_PLAY_PAUSE = 179,
        VK_LAUNCH_MAIL = 180,
        VK_LAUNCH_MEDIA_SELECT = 181,
        VK_LAUNCH_APP1 = 182,
        VK_LAUNCH_APP2 = 183,
        VK_OEM_1 = 186,
        VK_OEM_PLUS = 187,
        VK_OEM_COMMA = 188,
        VK_OEM_MINUS = 189,
        VK_OEM_PERIOD = 190,
        VK_OEM_2 = 191,
        VK_OEM_3 = 192,
        VK_OEM_4 = 219,
        VK_OEM_5 = 220,
        VK_OEM_6 = 221,
        VK_OEM_7 = 222,
        VK_OEM_8 = 223,
        VK_OEM_AX = 225,
        VK_OEM_102 = 226,
        VK_ICO_HELP = 227,
        VK_ICO_00 = 228,
        VK_PROCESSKEY = 229,
        VK_ICO_CLEAR = 230,
        VK_PACKET = 231,
        VK_OEM_RESET = 233,
        VK_OEM_JUMP = 234,
        VK_OEM_PA1 = 235,
        VK_OEM_PA2 = 236,
        VK_OEM_PA3 = 237,
        VK_OEM_WSCTRL = 238,
        VK_OEM_CUSEL = 239,
        VK_OEM_ATTN = 240,
        VK_OEM_FINISH = 241,
        VK_OEM_COPY = 242,
        VK_OEM_AUTO = 243,
        VK_OEM_ENLW = 244,
        VK_OEM_BACKTAB = 245,
        VK_ATTN = 246,
        VK_CRSEL = 247,
        VK_EXSEL = 248,
        VK_EREOF = 249,
        VK_PLAY = 250,
        VK_ZOOM = 251,
        VK_NONAME = 252,
        VK_PA1 = 253,
        VK_OEM_CLEAR = 254,
    }
    [JetBrains.Util.NoReorder()]
    public struct VS_FIXEDFILEINFO
    {
        public uint dwFileDateLS;
        public uint dwFileDateMS;
        public uint dwFileFlags;
        public uint dwFileFlagsMask;
        public uint dwFileOS;
        public uint dwFileSubtype;
        public uint dwFileType;
        public uint dwFileVersionLS;
        public uint dwFileVersionMS;
        public uint dwProductVersionLS;
        public uint dwProductVersionMS;
        public uint dwSignature;
        public uint dwStrucVersion;
        public System.Version FileVersion { get; }
        public System.Version ProductVersion { get; }
    }
    public class static Win32Declarations
    {
        public const int AC_SRC_ALPHA = 1;
        public const int AC_SRC_OVER = 0;
        public static readonly int CLSCTX_INPROC_SERVER;
        public const uint FE_FONTSMOOTHINGCLEARTYPE = 2u;
        public const uint SPI_GETCLEARTYPE = 4168u;
        public const uint SPI_GETFONTSMOOTHING = 74u;
        public const uint SPI_GETFONTSMOOTHINGTYPE = 8202u;
        public const uint SPI_SETFONTSMOOTHING = 75u;
        public const uint SPI_SETFONTSMOOTHINGTYPE = 8203u;
        public const int WM_CHANGECBCHAIN = 781;
        public const int WM_DRAWCLIPBOARD = 776;
        public static int AdjustWindowRectEx(ref JetBrains.Interop.WinApi.RECT lpRect, uint dwStyle, int bMenu, uint dwExStyle) { }
        public static System.IntPtr BeginPaint(System.IntPtr hWnd, out JetBrains.Interop.WinApi.PAINTSTRUCT lpPaint) { }
        public static bool BitBlt(System.IntPtr hdcDst, int xDst, int yDst, int cx, int cy, System.IntPtr hdcSrc, int xSrc, int ySrc, uint ulRop) { }
        public static int CallNextHookEx(System.IntPtr hhook, int code, System.IntPtr wParam, System.IntPtr lParam) { }
        public static bool ChangeClipboardChain(System.IntPtr hWndRemove, System.IntPtr hWndNewNext) { }
        public static bool CloseHandle(System.IntPtr hObject) { }
        [System.Security.SecurityCriticalAttribute()]
        [System.Security.SuppressUnmanagedCodeSecurityAttribute()]
        public static object CoCreateInstance(ref System.Guid clsid, object punkOuter, int context, ref System.Guid iid) { }
        public static System.Drawing.Color ColorFromCOLORREF(uint colorref) { }
        public static byte[] COLORREFToRGB(uint colorref) { }
        public static int ColorToRGB(System.Drawing.Color color) { }
        public static JetBrains.Interop.WinApi.Win32Declarations.RegionResult CombineRgn(System.IntPtr hrgnDest, System.IntPtr hrgnSrc1, System.IntPtr hrgnSrc2, JetBrains.Interop.WinApi.CombineRgnStyles fnCombineMode) { }
        public static System.IntPtr CreateCompatibleBitmap(System.IntPtr hdc, int nWidth, int nHeight) { }
        [System.ObsoleteAttribute()]
        public static System.IntPtr CreateCompatibleDC(System.IntPtr hdc) { }
        public static System.IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect) { }
        [System.ObsoleteAttribute()]
        public static int DeleteDC(System.IntPtr hDC) { }
        [System.ObsoleteAttribute()]
        public static int DeleteObject(System.IntPtr hGDIObj) { }
        public static int DrawFrameControl(System.IntPtr hdc, ref JetBrains.Interop.WinApi.RECT bounds, JetBrains.Interop.WinApi.Win32Declarations.FrameControlType frameControlType, JetBrains.Interop.WinApi.Win32Declarations.FrameControlState frameControlState) { }
        public static int DrawText(System.IntPtr hDC, string lpString, int nCount, ref JetBrains.Interop.WinApi.RECT lpRect, JetBrains.Interop.WinApi.DrawTextFormatFlags flags) { }
        public static int DwmExtendFrameIntoClientArea(System.IntPtr hwnd, JetBrains.Interop.WinApi.Win32Declarations.MARGINS margins) { }
        public static bool DwmIsCompositionEnabled() { }
        public static System.IntPtr EndPaint(System.IntPtr hWnd, ref JetBrains.Interop.WinApi.PAINTSTRUCT lpPaint) { }
        public static int EndTask(System.IntPtr hWnd, int fShutDown, int fForce) { }
        public static bool EnumChildWindows(System.IntPtr hWnd, JetBrains.Interop.WinApi.Win32Declarations.EnumWindowsCallback lpfn, int lParam) { }
        public static JetBrains.Interop.WinApi.Win32Declarations.RegionResult ExtSelectClipRgn(System.IntPtr hdc, System.IntPtr hrgn, JetBrains.Interop.WinApi.CombineRgnStyles fnMode) { }
        public static int FillRect(System.IntPtr hdc, ref JetBrains.Interop.WinApi.RECT lprc, System.IntPtr hbr) { }
        public static System.IntPtr FindWindow(string lpClassName, string lpWindowName) { }
        public static System.IntPtr FindWindowEx(System.IntPtr hwndParent, System.IntPtr hwndChildAfter, string lpszClass, string lpszWindow) { }
        public static System.IntPtr GetAncestor(System.IntPtr hwnd, JetBrains.Interop.WinApi.GetAncestorFlags flags) { }
        public static System.IntPtr GetCapture() { }
        public static int GetCaretBlinkTime() { }
        public static bool GetCaretPos(ref JetBrains.Interop.WinApi.POINTAPI lpPoint) { }
        public static bool GetClientRect(System.IntPtr hwnd, ref JetBrains.Interop.WinApi.RECT rect) { }
        public static uint GetCurrentThreadId() { }
        public static System.IntPtr GetDC(System.IntPtr ptr) { }
        public static bool GetKeyboardState(byte[] lpKeyState) { }
        public static System.IntPtr GetParent(System.IntPtr hWnd) { }
        public static System.IntPtr GetProp(System.IntPtr hwnd, string lpString) { }
        public static System.IntPtr GetStockObject(JetBrains.Interop.WinApi.Win32Declarations.StockObject stockobject) { }
        public static JetBrains.Interop.WinApi.Win32Declarations.RegionResult GetUpdateRgn(System.IntPtr hWnd, System.IntPtr hRgn, bool bErase) { }
        public static int GetUserNameEx(JetBrains.Interop.WinApi.Win32Declarations.EXTENDED_NAME_FORMAT nameFormat, System.Text.StringBuilder userName, ref uint userNameSize) { }
        public static bool GetWindowRect(System.IntPtr hWnd, out JetBrains.Interop.WinApi.RECT lpRect) { }
        public static System.Drawing.Rectangle GetWindowRect(System.IntPtr hWnd) { }
        public static int GetWindowText(System.IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount) { }
        public static int GetWindowTextLength(System.IntPtr hWnd) { }
        public static bool HideCaret(System.IntPtr hwnd) { }
        public static ushort HIWORD(uint l) { }
        public static ushort HIWORD(System.IntPtr l) { }
        public static System.IntPtr LoadCursor(System.IntPtr hInstance, System.IntPtr cursor) { }
        public static System.IntPtr LoadCursor(JetBrains.Interop.WinApi.StockCursors cursor) { }
        public static ushort LOWORD(uint l) { }
        public static ushort LOWORD(System.IntPtr l) { }
        public static bool MessageBeep(JetBrains.Interop.WinApi.MessageBeepType type) { }
        public static int MoveWindow(System.IntPtr hWnd, int X, int Y, int nWidth, int nHeight, int bRepaint) { }
        public static int MsgWaitForMultipleObjects(int nCount, int pHandles, bool fWaitAll, int dwMilliseconds, int dwWakeMask) { }
        public static System.IntPtr OpenThread(JetBrains.Interop.WinApi.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId) { }
        public static int ReleaseCapture() { }
        public static System.IntPtr ReleaseDC(System.IntPtr hWnd, System.IntPtr hDc) { }
        public static System.IntPtr RemoveProp(System.IntPtr hwnd, string lpString) { }
        public static JetBrains.Interop.WinApi.Win32Declarations.RegionResult ScrollWindowEx(System.IntPtr hWnd, int dx, int dy, ref JetBrains.Interop.WinApi.RECT prcScroll, ref JetBrains.Interop.WinApi.RECT prcClip, System.IntPtr hrgnUpdate, ref JetBrains.Interop.WinApi.RECT prcUpdate, JetBrains.Interop.WinApi.ScrollWindowFlags flags) { }
        public static JetBrains.Interop.WinApi.Win32Declarations.RegionResult ScrollWindowEx(System.IntPtr hWnd, int dx, int dy, ref JetBrains.Interop.WinApi.RECT prcScroll, ref JetBrains.Interop.WinApi.RECT prcClip, System.IntPtr hrgnUpdate, System.IntPtr prcUpdate, JetBrains.Interop.WinApi.ScrollWindowFlags flags) { }
        [System.ObsoleteAttribute()]
        public static System.IntPtr SelectObject(System.IntPtr hDC, System.IntPtr hGDIObj) { }
        public static System.IntPtr SetCapture(System.IntPtr hWnd) { }
        public static System.IntPtr SetClipboardViewer(System.IntPtr hWndNewViewer) { }
        public static System.IntPtr SetCursor(System.IntPtr hCursor) { }
        public static int SetDCBrushColor(System.IntPtr hdc, int colorref) { }
        public static System.IntPtr SetFocus(System.IntPtr hWnd) { }
        public static bool SetLayeredWindowAttributes(System.IntPtr hwnd, uint crKey, byte bAlpha, JetBrains.Interop.WinApi.Win32Declarations.SetLayeredWindowAttributesFlags dwFlags) { }
        public static bool SetProp(System.IntPtr hwnd, string lpString, System.IntPtr hData) { }
        public static int SetWindowOrgEx(System.IntPtr hdc, int X, int Y, out JetBrains.Interop.WinApi.POINTAPI lpPoint) { }
        public static bool SetWindowPos(System.IntPtr hWnd, System.IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, JetBrains.Interop.WinApi.SetWindowPosFlags uFlags) { }
        public static int SetWindowRgn(System.IntPtr hWnd, System.IntPtr hRgn, bool bRedraw) { }
        public static System.IntPtr SetWindowsHookEx(JetBrains.Interop.WinApi.HookType code, JetBrains.Interop.WinApi.Win32Declarations.HookProc func, System.IntPtr hInstance, int threadID) { }
        public static bool ShowCaret(System.IntPtr hwnd) { }
        public static int SignedHIWORD(System.IntPtr n) { }
        public static int SignedHIWORD(int n) { }
        public static int SignedLOWORD(System.IntPtr n) { }
        public static int SignedLOWORD(int n) { }
        public static string StrFormatByteSize(long nSize) { }
        public static System.IntPtr StrFormatByteSize64A(long nSize, byte[] pBuffer, uint nBufSize) { }
        public static System.IntPtr StrFormatByteSize64A(long nSize, System.Text.StringBuilder pBuffer, uint nBufSize) { }
        public static bool TerminateThread(System.IntPtr hThread, uint dwExitCode) { }
        public static int TrackPopupMenuEx(System.IntPtr hmenu, JetBrains.Interop.WinApi.Win32Declarations.TrackPopupMenuExFlags fuFlags, int x, int y, System.IntPtr hwnd, System.IntPtr lptpm_PassNullHere) { }
        public static int UnhookWindowsHookEx(System.IntPtr hhook) { }
        public static int VarR8FromStr(string strIn, int lcid, int dwFlags, out double result) { }
        public static int ZwQuerySystemInformation(JetBrains.Interop.WinApi.Win32Declarations.SYSTEM_INFORMATION_CLASS SystemInformationClass, byte[] SystemInformation, uint SystemInformationLength, out uint ReturnLength) { }
        public delegate bool EnumWindowsCallback(System.IntPtr hWnd, System.IntPtr lParam);
        public enum EXTENDED_NAME_FORMAT
        {
            NameUnknown = 0,
            NameFullyQualifiedDN = 1,
            NameSamCompatible = 2,
            NameDisplay = 3,
            NameUniqueId = 6,
            NameCanonical = 7,
            NameUserPrincipal = 8,
            NameCanonicalEx = 9,
            NameServicePrincipal = 10,
            NameDnsDomain = 12,
        }
        public enum FrameControlState : uint
        {
            DFCS_BUTTONPUSH = 16u,
        }
        public enum FrameControlType : uint
        {
            DFC_BUTTON = 4u,
            DFC_CAPTION = 1u,
            DFC_MENU = 2u,
            DFC_POPUPMENU = 5u,
            DFC_SCROLL = 3u,
        }
        public delegate int HookProc(int code, System.IntPtr wParam, System.IntPtr lParam);
        public class MARGINS
        {
            public int Bottom;
            public int Left;
            public int Right;
            public int Top;
            public MARGINS() { }
            public MARGINS(int uniformvalue) { }
            public static JetBrains.Interop.WinApi.Win32Declarations.MARGINS Null { get; }
            public static JetBrains.Interop.WinApi.Win32Declarations.MARGINS WholeSurface { get; }
        }
        public enum RegionResult
        {
            ERROR = 0,
            NULLREGION = 1,
            SIMPLEREGION = 2,
            COMPLEXREGION = 3,
            RGN_ERROR = 0,
        }
        [System.FlagsAttribute()]
        public enum SetLayeredWindowAttributesFlags : uint
        {
            LWA_COLORKEY = 1u,
            LWA_ALPHA = 2u,
        }
        public enum StatusBarBorders
        {
            Horizontal = 0,
            Vertical = 1,
            Separator = 2,
        }
        [System.FlagsAttribute()]
        public enum StatusBarStyles
        {
            SBT_OWNERDRAW = 4096,
            SBT_NOBORDERS = 256,
            SBT_POPOUT = 512,
            SBT_RTLREADING = 1024,
            SBT_NOTABPARSING = 2048,
        }
        public enum StockObject
        {
            BLACK_BRUSH = 4,
            DKGRAY_BRUSH = 3,
            DC_BRUSH = 18,
            GRAY_BRUSH = 2,
            HOLLOW_BRUSH = 5,
            LTGRAY_BRUSH = 1,
            NULL_BRUSH = 5,
            WHITE_BRUSH = 0,
            BLACK_PEN = 7,
            DC_PEN = 19,
            WHITE_PEN = 6,
            ANSI_FIXED_FONT = 11,
            ANSI_VAR_FONT = 12,
            DEVICE_DEFAULT_FONT = 14,
            DEFAULT_GUI_FONT = 17,
            OEM_FIXED_FONT = 10,
            SYSTEM_FONT = 13,
            SYSTEM_FIXED_FONT = 16,
            DEFAULT_PALETTE = 15,
        }
        public enum SYSTEM_INFORMATION_CLASS
        {
            SystemBasicInformation = 0,
            SystemProcessorInformation = 1,
            SystemPerformanceInformation = 2,
            SystemTimeOfDayInformation = 3,
            SystemNotImplemented1 = 4,
            SystemProcessesAndThreadsInformation = 5,
            SystemCallCounts = 6,
            SystemConfigurationInformation = 7,
            SystemProcessorTimes = 8,
            SystemGlobalFlag = 9,
            SystemNotImplemented2 = 10,
            SystemModuleInformation = 11,
            SystemLockInformation = 12,
            SystemNotImplemented3 = 13,
            SystemNotImplemented4 = 14,
            SystemNotImplemented5 = 15,
            SystemHandleInformation = 16,
            SystemObjectInformation = 17,
            SystemPagefileInformation = 18,
            SystemInstructionEmulationCounts = 19,
            SystemInvalidInfoClass1 = 20,
            SystemCacheInformation = 21,
            SystemPoolTagInformation = 22,
            SystemProcessorStatistics = 23,
            SystemDpcInformation = 24,
            SystemNotImplemented6 = 25,
            SystemLoadImage = 26,
            SystemUnloadImage = 27,
            SystemTimeAdjustment = 28,
            SystemNotImplemented7 = 29,
            SystemNotImplemented8 = 30,
            SystemNotImplemented9 = 31,
            SystemCrashDumpInformation = 32,
            SystemExceptionInformation = 33,
            SystemCrashDumpStateInformation = 34,
            SystemKernelDebuggerInformation = 35,
            SystemContextSwitchInformation = 36,
            SystemRegistryQuotaInformation = 37,
            SystemLoadAndCallImage = 38,
            SystemPrioritySeparation = 39,
            SystemNotImplemented10 = 40,
            SystemNotImplemented11 = 41,
            SystemInvalidInfoClass2 = 42,
            SystemInvalidInfoClass3 = 43,
            SystemTimeZoneInformation = 44,
            SystemLookasideInformation = 45,
            SystemSetTimeSlipEvent = 46,
            SystemCreateSession = 47,
            SystemDeleteSession = 48,
            SystemInvalidInfoClass4 = 49,
            SystemRangeStartInformation = 50,
            SystemVerifierInformation = 51,
            SystemAddVerifier = 52,
            SystemSessionProcessesInformation = 53,
        }
        public enum TernaryRasterOperations
        {
            SRCCOPY = 13369376,
            SRCPAINT = 15597702,
            SRCAND = 8913094,
            SRCINVERT = 6684742,
            SRCERASE = 4457256,
            NOTSRCCOPY = 3342344,
            NOTSRCERASE = 1114278,
            MERGECOPY = 12583114,
            MERGEPAINT = 12255782,
            PATCOPY = 15728673,
            PATPAINT = 16452105,
            PATINVERT = 5898313,
            DSTINVERT = 5570569,
            BLACKNESS = 66,
            WHITENESS = 16711778,
        }
        [System.FlagsAttribute()]
        public enum TrackPopupMenuExFlags : uint
        {
            TPM_CENTERALIGN = 4u,
            TPM_LEFTALIGN = 0u,
            TPM_RIGHTALIGN = 8u,
            TPM_BOTTOMALIGN = 32u,
            TPM_TOPALIGN = 0u,
            TPM_VCENTERALIGN = 16u,
            TPM_NONOTIFY = 128u,
            TPM_RETURNCMD = 256u,
            TPM_LEFTBUTTON = 0u,
            TPM_RIGHTBUTTON = 2u,
            TPM_HORNEGANIMATION = 2048u,
            TPM_HORPOSANIMATION = 1024u,
            TPM_NOANIMATION = 16384u,
            TPM_VERNEGANIMATION = 8192u,
            TPM_VERPOSANIMATION = 4096u,
            TPM_HORIZONTAL = 0u,
            TPM_VERTICAL = 64u,
            TPM_RECURSE = 1u,
        }
        public enum WmSizeFlags : uint
        {
            SIZE_RESTORED = 0u,
            SIZE_MINIMIZED = 1u,
            SIZE_MAXIMIZED = 2u,
            SIZE_MAXSHOW = 3u,
            SIZE_MAXHIDE = 4u,
        }
    }
    public class Win32InteropException : System.ApplicationException
    {
        public Win32InteropException([JetBrains.Annotations.NotNullAttribute()] string message, [JetBrains.Annotations.NotNullAttribute()] System.Exception innerException) { }
        public Win32InteropException([JetBrains.Annotations.NotNullAttribute()] string message) { }
    }
    public class static WinDef
    {
        public static uint CBM_INIT;
        public static readonly string DesktopDefault;
        public static readonly System.IntPtr HWND_BROADCAST;
        public static readonly System.Void* INVALID_HANDLE_VALUE;
        public const int MAX_PATH = 260;
        public static readonly int MAXIMUM_WAIT_OBJECTS;
        public static readonly int SizeOfVariant;
        public static readonly int USER_TIMER_MAXIMUM;
        public static readonly int USER_TIMER_MINIMUM;
        public static readonly string WinSta0;
    }
    [System.FlagsAttribute()]
    public enum WindowClassStyles : uint
    {
        CS_BYTEALIGNCLIENT = 4096u,
        CS_BYTEALIGNWINDOW = 8192u,
        CS_CLASSDC = 64u,
        CS_DBLCLKS = 8u,
        CS_DROPSHADOW = 131072u,
        CS_GLOBALCLASS = 16384u,
        CS_HREDRAW = 2u,
        CS_NOCLOSE = 512u,
        CS_OWNDC = 32u,
        CS_PARENTDC = 128u,
        CS_SAVEBITS = 2048u,
        CS_VREDRAW = 1u,
        CS_IME = 65536u,
    }
    [System.FlagsAttribute()]
    public enum WindowExStyles : uint
    {
        WS_EX_DLGMODALFRAME = 1u,
        WS_EX_NOPARENTNOTIFY = 4u,
        WS_EX_TOPMOST = 8u,
        WS_EX_ACCEPTFILES = 16u,
        WS_EX_TRANSPARENT = 32u,
        WS_EX_MDICHILD = 64u,
        WS_EX_TOOLWINDOW = 128u,
        WS_EX_WINDOWEDGE = 256u,
        WS_EX_CLIENTEDGE = 512u,
        WS_EX_CONTEXTHELP = 1024u,
        WS_EX_RIGHT = 4096u,
        WS_EX_LEFT = 0u,
        WS_EX_RTLREADING = 8192u,
        WS_EX_LTRREADING = 0u,
        WS_EX_LEFTSCROLLBAR = 16384u,
        WS_EX_RIGHTSCROLLBAR = 0u,
        WS_EX_CONTROLPARENT = 65536u,
        WS_EX_STATICEDGE = 131072u,
        WS_EX_APPWINDOW = 262144u,
        WS_EX_OVERLAPPEDWINDOW = 768u,
        WS_EX_PALETTEWINDOW = 392u,
        WS_EX_LAYERED = 524288u,
        WS_EX_NOINHERITLAYOUT = 1048576u,
        WS_EX_LAYOUTRTL = 4194304u,
        WS_EX_COMPOSITED = 33554432u,
        WS_EX_NOACTIVATE = 134217728u,
    }
    public enum WindowLongPtrIndex
    {
        GWL_EXSTYLE = -20,
        GWL_STYLE = -16,
        GWLP_WNDPROC = -4,
        GWLP_HINSTANCE = -6,
        GWLP_HWNDPARENT = -8,
        GWLP_ID = -12,
        GWLP_USERDATA = -21,
        DWLP_DLGPROC = 4,
        DWLP_MSGRESULT = 0,
        DWLP_USER = 8,
    }
    public enum WindowsMessages : uint
    {
        WM_NULL = 0u,
        WM_MOVE = 3u,
        WM_SIZE = 5u,
        WM_ACTIVATE = 6u,
        WM_SETFOCUS = 7u,
        WM_KILLFOCUS = 8u,
        WM_GETTEXT = 13u,
        WM_GETTEXTLENGTH = 14u,
        WM_QUIT = 18u,
        WM_SYSCOLORCHANGE = 21u,
        WM_ACTIVATEAPP = 28u,
        WM_CANCELMODE = 31u,
        WM_SETCURSOR = 32u,
        WM_GETICON = 127u,
        WM_SETICON = 128u,
        WM_NCHITTEST = 132u,
        WM_NCPAINT = 133u,
        WM_NCCALCSIZE = 131u,
        WM_NCACTIVATE = 134u,
        WM_NCMOUSEFIRST = 160u,
        WM_NCMOUSEMOVE = 160u,
        WM_NCLBUTTONDOWN = 161u,
        WM_NCLBUTTONUP = 162u,
        WM_NCLBUTTONDBLCLK = 163u,
        WM_NCRBUTTONDOWN = 164u,
        WM_NCRBUTTONUP = 165u,
        WM_NCRBUTTONDBLCLK = 166u,
        WM_NCMBUTTONDOWN = 167u,
        WM_NCMBUTTONUP = 168u,
        WM_NCMBUTTONDBLCLK = 169u,
        WM_NCMOUSELAST = 169u,
        WM_NOTIFY = 78u,
        WM_USER = 1024u,
        WM_HSCROLL = 276u,
        WM_VSCROLL = 277u,
        WM_PASTE = 770u,
        WM_PAINT = 15u,
        WM_PRINT = 791u,
        WM_PRINTCLIENT = 792u,
        WM_APPCOMMAND = 793u,
        WM_SETREDRAW = 11u,
        WM_SETTEXT = 12u,
        WM_SHOWWINDOW = 24u,
        WM_CONTEXTMENU = 123u,
        WM_CREATE = 1u,
        WM_DESTROY = 2u,
        WM_ERASEBKGND = 20u,
        WM_INITDIALOG = 272u,
        WM_COMMAND = 273u,
        WM_SYSCOMMAND = 274u,
        WM_TIMER = 275u,
        WM_ENTERIDLE = 289u,
        WM_MOUSEACTIVATE = 33u,
        WM_WINDOWPOSCHANGING = 70u,
        WM_WINDOWPOSCHANGED = 71u,
        WM_ENTERMENULOOP = 529u,
        WM_EXITMENULOOP = 530u,
        WM_CAPTURECHANGED = 533u,
        WM_POWERBROADCAST = 536u,
        WM_THEMECHANGED = 794u,
        WM_CLOSE = 16u,
        WM_QUERYENDSESSION = 17u,
        WM_ENDSESSION = 22u,
        WM_GETDLGCODE = 135u,
        WM_KEYFIRST = 256u,
        WM_KEYDOWN = 256u,
        WM_KEYUP = 257u,
        WM_CHAR = 258u,
        WM_DEADCHAR = 259u,
        WM_SYSKEYDOWN = 260u,
        WM_SYSKEYUP = 261u,
        WM_SYSCHAR = 262u,
        WM_SYSDEADCHAR = 263u,
        WM_UNICHAR = 265u,
        WM_KEYLAST = 265u,
        WM_MOUSEFIRST = 512u,
        WM_MOUSEMOVE = 512u,
        WM_LBUTTONDOWN = 513u,
        WM_LBUTTONUP = 514u,
        WM_LBUTTONDBLCLK = 515u,
        WM_RBUTTONDOWN = 516u,
        WM_RBUTTONUP = 517u,
        WM_RBUTTONDBLCLK = 518u,
        WM_MBUTTONDOWN = 519u,
        WM_MBUTTONUP = 520u,
        WM_MBUTTONDBLCLK = 521u,
        WM_MOUSEWHEEL = 522u,
        WM_XBUTTONDOWN = 523u,
        WM_XBUTTONUP = 524u,
        WM_XBUTTONDBLCLK = 525u,
        WM_MOUSELAST = 525u,
        WM_MOUSEHOVER = 673u,
        WM_MOUSELEAVE = 675u,
        WM_SIZING = 532u,
        WM_MOVING = 534u,
        WM_IME_STARTCOMPOSITION = 269u,
        WM_IME_ENDCOMPOSITION = 270u,
        WM_IME_COMPOSITION = 271u,
        WM_IME_KEYLAST = 271u,
        WM_IME_NOTIFY = 642u,
        WM_PARENTNOTIFY = 528u,
        WM_REFLECT = 8192u,
        CCM_FIRST = 8192u,
        CCM_LAST = 8704u,
        CCM_SETBKCOLOR = 8193u,
        CCM_SETCOLORSCHEME = 8194u,
        CCM_GETCOLORSCHEME = 8195u,
        CCM_GETDROPTARGET = 8196u,
        CCM_SETUNICODEFORMAT = 8197u,
        CCM_GETUNICODEFORMAT = 8198u,
        CCM_SETVERSION = 8199u,
        CCM_GETVERSION = 8200u,
        CCM_SETNOTIFYWINDOW = 8201u,
        CCM_SETWINDOWTHEME = 8203u,
        CCM_DPISCALE = 8204u,
        SB_SETPARTS = 1028u,
        SB_GETPARTS = 1030u,
        SB_GETBORDERS = 1031u,
        SB_SETMINHEIGHT = 1032u,
        SB_SIMPLE = 1033u,
        SB_GETRECT = 1034u,
        SB_ISSIMPLE = 1038u,
        SB_SETICON = 1039u,
        SB_SETTIPTEXTA = 1040u,
        SB_SETTIPTEXTW = 1041u,
        SB_GETTIPTEXTA = 1042u,
        SB_GETTIPTEXTW = 1043u,
        SB_GETICON = 1044u,
        SB_SETUNICODEFORMAT = 8197u,
        SB_GETUNICODEFORMAT = 8198u,
        SB_SETTEXTA = 1025u,
        SB_SETTEXTW = 1035u,
        SB_GETTEXTA = 1026u,
        SB_GETTEXTW = 1037u,
        SB_GETTEXTLENGTHA = 1027u,
        SB_GETTEXTLENGTHW = 1036u,
        SB_SETBKCOLOR = 8193u,
        SB_SIMPLEID = 255u,
        WM_DWMCOMPOSITIONCHANGED = 798u,
        WM_DWMNCRENDERINGCHANGED = 799u,
        WM_DWMCOLORIZATIONCOLORCHANGED = 800u,
        WM_DWMWINDOWMAXIMIZEDCHANGE = 801u,
        WM_GETTITLEBARINFOEX = 831u,
        WM_SETTINGCHANGE = 26u,
        WM_WININICHANGE = 26u,
        WM_GETOBJECT = 61u,
        WM_COMPACTING = 65u,
        WM_COMMNOTIFY = 68u,
        WM_POWER = 72u,
        WM_COPYDATA = 74u,
        WM_CANCELJOURNAL = 75u,
        EM_GETSEL = 176u,
        EM_SETSEL = 177u,
        EM_GETRECT = 178u,
        EM_SETRECT = 179u,
        EM_SETRECTNP = 180u,
        EM_SCROLL = 181u,
        EM_LINESCROLL = 182u,
        EM_SCROLLCARET = 183u,
        EM_GETMODIFY = 184u,
        EM_SETMODIFY = 185u,
        EM_GETLINECOUNT = 186u,
        EM_LINEINDEX = 187u,
        EM_SETHANDLE = 188u,
        EM_GETHANDLE = 189u,
        EM_GETTHUMB = 190u,
        EM_LINELENGTH = 193u,
        EM_REPLACESEL = 194u,
        EM_GETLINE = 196u,
        EM_LIMITTEXT = 197u,
        EM_CANUNDO = 198u,
        EM_UNDO = 199u,
        EM_FMTLINES = 200u,
        EM_LINEFROMCHAR = 201u,
        EM_SETTABSTOPS = 203u,
        EM_SETPASSWORDCHAR = 204u,
        EM_EMPTYUNDOBUFFER = 205u,
        EM_GETFIRSTVISIBLELINE = 206u,
        EM_SETREADONLY = 207u,
        EM_SETWORDBREAKPROC = 208u,
        EM_GETWORDBREAKPROC = 209u,
        EM_GETPASSWORDCHAR = 210u,
        EM_SETMARGINS = 211u,
        EM_GETMARGINS = 212u,
        EM_SETLIMITTEXT = 197u,
        EM_GETLIMITTEXT = 213u,
        EM_POSFROMCHAR = 214u,
        EM_CHARFROMPOS = 215u,
        EM_SETIMESTATUS = 216u,
        EM_GETIMESTATUS = 217u,
        HDM_FIRST = 4608u,
        HDM_SETITEMA = 4612u,
        HDM_SETITEMW = 4620u,
        HDM_GETITEMA = 4611u,
        HDM_GETITEMW = 4619u,
        HDM_GETIMAGELIST = 4617u,
        HDM_SETIMAGELIST = 4616u,
        LVM_FIRST = 4096u,
        LVM_GETHEADER = 4127u,
        CDM_FIRST = 1124u,
        CDM_LAST = 1224u,
        CDM_GETFILEPATH = 1125u,
        CDM_GETFOLDERPATH = 1126u,
        CDM_SETCONTROLTEXT = 1128u,
        CDM_HIDECONTROL = 1129u,
        LB_INITSTORAGE = 424u,
    }
    public enum WindowsNotify
    {
        CDN_FIRST = -601,
        CDN_LAST = -699,
        CDN_INITDONE = -601,
        CDN_SELCHANGE = -602,
        CDN_FOLDERCHANGE = -603,
        CDN_SHAREVIOLATION = -604,
        CDN_HELP = -605,
        CDN_FILEOK = -606,
        CDN_TYPECHANGE = -607,
        CDN_INCLUDEITEM = -608,
    }
    [System.FlagsAttribute()]
    public enum WindowStyles : uint
    {
        DS_3DLOOK = 4u,
        DS_FIXEDSYS = 8u,
        DS_NOFAILCREATE = 16u,
        DS_CONTROL = 1024u,
        DS_CENTER = 2048u,
        DS_CENTERMOUSE = 4096u,
        DS_CONTEXTHELP = 8192u,
        WS_OVERLAPPED = 0u,
        WS_POPUP = 2147483648u,
        WS_CHILD = 1073741824u,
        WS_MINIMIZE = 536870912u,
        WS_VISIBLE = 268435456u,
        WS_DISABLED = 134217728u,
        WS_CLIPSIBLINGS = 67108864u,
        WS_CLIPCHILDREN = 33554432u,
        WS_MAXIMIZE = 16777216u,
        WS_CAPTION = 12582912u,
        WS_BORDER = 8388608u,
        WS_DLGFRAME = 4194304u,
        WS_VSCROLL = 2097152u,
        WS_HSCROLL = 1048576u,
        WS_SYSMENU = 524288u,
        WS_THICKFRAME = 262144u,
        WS_GROUP = 131072u,
        WS_TABSTOP = 65536u,
        WS_MINIMIZEBOX = 131072u,
        WS_MAXIMIZEBOX = 65536u,
        WS_TILED = 0u,
        WS_ICONIC = 536870912u,
        WS_SIZEBOX = 262144u,
        WS_TILEDWINDOW = 13565952u,
        WS_OVERLAPPEDWINDOW = 13565952u,
        WS_POPUPWINDOW = 2156396544u,
        WS_CHILDWINDOW = 1073741824u,
    }
    [JetBrains.Util.NoReorder()]
    public enum WinError
    {
        FACILITY_WINRM = 51,
        FACILITY_WINDOWSUPDATE = 36,
        FACILITY_WINDOWS_DEFENDER = 80,
        FACILITY_WINDOWS_CE = 24,
        FACILITY_WINDOWS = 8,
        FACILITY_URT = 19,
        FACILITY_UMI = 22,
        FACILITY_TPM_SOFTWARE = 41,
        FACILITY_TPM_SERVICES = 40,
        FACILITY_SXS = 23,
        FACILITY_STORAGE = 3,
        FACILITY_STATE_MANAGEMENT = 34,
        FACILITY_SSPI = 9,
        FACILITY_SCARD = 16,
        FACILITY_SHELL = 39,
        FACILITY_SETUPAPI = 15,
        FACILITY_SECURITY = 9,
        FACILITY_RPC = 1,
        FACILITY_PLA = 48,
        FACILITY_WIN32 = 7,
        FACILITY_CONTROL = 10,
        FACILITY_NULL = 0,
        FACILITY_NDIS = 52,
        FACILITY_METADIRECTORY = 35,
        FACILITY_MSMQ = 14,
        FACILITY_MEDIASERVER = 13,
        FACILITY_INTERNET = 12,
        FACILITY_ITF = 4,
        FACILITY_USERMODE_HYPERVISOR = 53,
        FACILITY_HTTP = 25,
        FACILITY_GRAPHICS = 38,
        FACILITY_FWP = 50,
        FACILITY_FVE = 49,
        FACILITY_USERMODE_FILTER_MANAGER = 31,
        FACILITY_DPLAY = 21,
        FACILITY_DISPATCH = 2,
        FACILITY_DIRECTORYSERVICE = 37,
        FACILITY_CONFIGURATION = 33,
        FACILITY_COMPLUS = 17,
        FACILITY_USERMODE_COMMONLOG = 26,
        FACILITY_CMI = 54,
        FACILITY_CERT = 11,
        FACILITY_BACKGROUNDCOPY = 32,
        FACILITY_ACS = 20,
        FACILITY_AAF = 18,
        ERROR_SUCCESS = 0,
        NO_ERROR = 0,
        SEC_E_OK = 0,
        ERROR_INVALID_FUNCTION = 1,
        ERROR_FILE_NOT_FOUND = 2,
        ERROR_PATH_NOT_FOUND = 3,
        ERROR_TOO_MANY_OPEN_FILES = 4,
        ERROR_ACCESS_DENIED = 5,
        ERROR_INVALID_HANDLE = 6,
        ERROR_ARENA_TRASHED = 7,
        ERROR_NOT_ENOUGH_MEMORY = 8,
        ERROR_INVALID_BLOCK = 9,
        ERROR_BAD_ENVIRONMENT = 10,
        ERROR_BAD_FORMAT = 11,
        ERROR_INVALID_ACCESS = 12,
        ERROR_INVALID_DATA = 13,
        ERROR_OUTOFMEMORY = 14,
        ERROR_INVALID_DRIVE = 15,
        ERROR_CURRENT_DIRECTORY = 16,
        ERROR_NOT_SAME_DEVICE = 17,
        ERROR_NO_MORE_FILES = 18,
        ERROR_WRITE_PROTECT = 19,
        ERROR_BAD_UNIT = 20,
        ERROR_NOT_READY = 21,
        ERROR_BAD_COMMAND = 22,
        ERROR_CRC = 23,
        ERROR_BAD_LENGTH = 24,
        ERROR_SEEK = 25,
        ERROR_NOT_DOS_DISK = 26,
        ERROR_SECTOR_NOT_FOUND = 27,
        ERROR_OUT_OF_PAPER = 28,
        ERROR_WRITE_FAULT = 29,
        ERROR_READ_FAULT = 30,
        ERROR_GEN_FAILURE = 31,
        ERROR_SHARING_VIOLATION = 32,
        ERROR_LOCK_VIOLATION = 33,
        ERROR_WRONG_DISK = 34,
        ERROR_SHARING_BUFFER_EXCEEDED = 36,
        ERROR_HANDLE_EOF = 38,
        ERROR_HANDLE_DISK_FULL = 39,
        ERROR_NOT_SUPPORTED = 50,
        ERROR_REM_NOT_LIST = 51,
        ERROR_DUP_NAME = 52,
        ERROR_BAD_NETPATH = 53,
        ERROR_NETWORK_BUSY = 54,
        ERROR_DEV_NOT_EXIST = 55,
        ERROR_TOO_MANY_CMDS = 56,
        ERROR_ADAP_HDW_ERR = 57,
        ERROR_BAD_NET_RESP = 58,
        ERROR_UNEXP_NET_ERR = 59,
        ERROR_BAD_REM_ADAP = 60,
        ERROR_PRINTQ_FULL = 61,
        ERROR_NO_SPOOL_SPACE = 62,
        ERROR_PRINT_CANCELLED = 63,
        ERROR_NETNAME_DELETED = 64,
        ERROR_NETWORK_ACCESS_DENIED = 65,
        ERROR_BAD_DEV_TYPE = 66,
        ERROR_BAD_NET_NAME = 67,
        ERROR_TOO_MANY_NAMES = 68,
        ERROR_TOO_MANY_SESS = 69,
        ERROR_SHARING_PAUSED = 70,
        ERROR_REQ_NOT_ACCEP = 71,
        ERROR_REDIR_PAUSED = 72,
        ERROR_FILE_EXISTS = 80,
        ERROR_CANNOT_MAKE = 82,
        ERROR_FAIL_I24 = 83,
        ERROR_OUT_OF_STRUCTURES = 84,
        ERROR_ALREADY_ASSIGNED = 85,
        ERROR_INVALID_PASSWORD = 86,
        ERROR_INVALID_PARAMETER = 87,
        ERROR_NET_WRITE_FAULT = 88,
        ERROR_NO_PROC_SLOTS = 89,
        ERROR_TOO_MANY_SEMAPHORES = 100,
        ERROR_EXCL_SEM_ALREADY_OWNED = 101,
        ERROR_SEM_IS_SET = 102,
        ERROR_TOO_MANY_SEM_REQUESTS = 103,
        ERROR_INVALID_AT_INTERRUPT_TIME = 104,
        ERROR_SEM_OWNER_DIED = 105,
        ERROR_SEM_USER_LIMIT = 106,
        ERROR_DISK_CHANGE = 107,
        ERROR_DRIVE_LOCKED = 108,
        ERROR_BROKEN_PIPE = 109,
        ERROR_OPEN_FAILED = 110,
        ERROR_BUFFER_OVERFLOW = 111,
        ERROR_DISK_FULL = 112,
        ERROR_NO_MORE_SEARCH_HANDLES = 113,
        ERROR_INVALID_TARGET_HANDLE = 114,
        ERROR_INVALID_CATEGORY = 117,
        ERROR_INVALID_VERIFY_SWITCH = 118,
        ERROR_BAD_DRIVER_LEVEL = 119,
        ERROR_CALL_NOT_IMPLEMENTED = 120,
        ERROR_SEM_TIMEOUT = 121,
        ERROR_INSUFFICIENT_BUFFER = 122,
        ERROR_INVALID_NAME = 123,
        ERROR_INVALID_LEVEL = 124,
        ERROR_NO_VOLUME_LABEL = 125,
        ERROR_MOD_NOT_FOUND = 126,
        ERROR_PROC_NOT_FOUND = 127,
        ERROR_WAIT_NO_CHILDREN = 128,
        ERROR_CHILD_NOT_COMPLETE = 129,
        ERROR_DIRECT_ACCESS_HANDLE = 130,
        ERROR_NEGATIVE_SEEK = 131,
        ERROR_SEEK_ON_DEVICE = 132,
        ERROR_IS_JOIN_TARGET = 133,
        ERROR_IS_JOINED = 134,
        ERROR_IS_SUBSTED = 135,
        ERROR_NOT_JOINED = 136,
        ERROR_NOT_SUBSTED = 137,
        ERROR_JOIN_TO_JOIN = 138,
        ERROR_SUBST_TO_SUBST = 139,
        ERROR_JOIN_TO_SUBST = 140,
        ERROR_SUBST_TO_JOIN = 141,
        ERROR_BUSY_DRIVE = 142,
        ERROR_SAME_DRIVE = 143,
        ERROR_DIR_NOT_ROOT = 144,
        ERROR_DIR_NOT_EMPTY = 145,
        ERROR_IS_SUBST_PATH = 146,
        ERROR_IS_JOIN_PATH = 147,
        ERROR_PATH_BUSY = 148,
        ERROR_IS_SUBST_TARGET = 149,
        ERROR_SYSTEM_TRACE = 150,
        ERROR_INVALID_EVENT_COUNT = 151,
        ERROR_TOO_MANY_MUXWAITERS = 152,
        ERROR_INVALID_LIST_FORMAT = 153,
        ERROR_LABEL_TOO_LONG = 154,
        ERROR_TOO_MANY_TCBS = 155,
        ERROR_SIGNAL_REFUSED = 156,
        ERROR_DISCARDED = 157,
        ERROR_NOT_LOCKED = 158,
        ERROR_BAD_THREADID_ADDR = 159,
        ERROR_BAD_ARGUMENTS = 160,
        ERROR_BAD_PATHNAME = 161,
        ERROR_SIGNAL_PENDING = 162,
        ERROR_MAX_THRDS_REACHED = 164,
        ERROR_LOCK_FAILED = 167,
        ERROR_BUSY = 170,
        ERROR_CANCEL_VIOLATION = 173,
        ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174,
        ERROR_INVALID_SEGMENT_NUMBER = 180,
        ERROR_INVALID_ORDINAL = 182,
        ERROR_ALREADY_EXISTS = 183,
        ERROR_INVALID_FLAG_NUMBER = 186,
        ERROR_SEM_NOT_FOUND = 187,
        ERROR_INVALID_STARTING_CODESEG = 188,
        ERROR_INVALID_STACKSEG = 189,
        ERROR_INVALID_MODULETYPE = 190,
        ERROR_INVALID_EXE_SIGNATURE = 191,
        ERROR_EXE_MARKED_INVALID = 192,
        ERROR_BAD_EXE_FORMAT = 193,
        ERROR_ITERATED_DATA_EXCEEDS_64k = 194,
        ERROR_INVALID_MINALLOCSIZE = 195,
        ERROR_DYNLINK_FROM_INVALID_RING = 196,
        ERROR_IOPL_NOT_ENABLED = 197,
        ERROR_INVALID_SEGDPL = 198,
        ERROR_AUTODATASEG_EXCEEDS_64k = 199,
        ERROR_RING2SEG_MUST_BE_MOVABLE = 200,
        ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201,
        ERROR_INFLOOP_IN_RELOC_CHAIN = 202,
        ERROR_ENVVAR_NOT_FOUND = 203,
        ERROR_NO_SIGNAL_SENT = 205,
        ERROR_FILENAME_EXCED_RANGE = 206,
        ERROR_RING2_STACK_IN_USE = 207,
        ERROR_META_EXPANSION_TOO_LONG = 208,
        ERROR_INVALID_SIGNAL_NUMBER = 209,
        ERROR_THREAD_1_INACTIVE = 210,
        ERROR_LOCKED = 212,
        ERROR_TOO_MANY_MODULES = 214,
        ERROR_NESTING_NOT_ALLOWED = 215,
        ERROR_EXE_MACHINE_TYPE_MISMATCH = 216,
        ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217,
        ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218,
        ERROR_BAD_PIPE = 230,
        ERROR_PIPE_BUSY = 231,
        ERROR_NO_DATA = 232,
        ERROR_PIPE_NOT_CONNECTED = 233,
        ERROR_MORE_DATA = 234,
        ERROR_VC_DISCONNECTED = 240,
        ERROR_INVALID_EA_NAME = 254,
        ERROR_EA_LIST_INCONSISTENT = 255,
        WAIT_TIMEOUT = 258,
        ERROR_NO_MORE_ITEMS = 259,
        ERROR_CANNOT_COPY = 266,
        ERROR_DIRECTORY = 267,
        ERROR_EAS_DIDNT_FIT = 275,
        ERROR_EA_FILE_CORRUPT = 276,
        ERROR_EA_TABLE_FULL = 277,
        ERROR_INVALID_EA_HANDLE = 278,
        ERROR_EAS_NOT_SUPPORTED = 282,
        ERROR_NOT_OWNER = 288,
        ERROR_TOO_MANY_POSTS = 298,
        ERROR_PARTIAL_COPY = 299,
        ERROR_OPLOCK_NOT_GRANTED = 300,
        ERROR_INVALID_OPLOCK_PROTOCOL = 301,
        ERROR_DISK_TOO_FRAGMENTED = 302,
        ERROR_DELETE_PENDING = 303,
        ERROR_MR_MID_NOT_FOUND = 317,
        ERROR_SCOPE_NOT_FOUND = 318,
        ERROR_INVALID_ADDRESS = 487,
        ERROR_ARITHMETIC_OVERFLOW = 534,
        ERROR_PIPE_CONNECTED = 535,
        ERROR_PIPE_LISTENING = 536,
        ERROR_EA_ACCESS_DENIED = 994,
        ERROR_OPERATION_ABORTED = 995,
        ERROR_IO_INCOMPLETE = 996,
        ERROR_IO_PENDING = 997,
        ERROR_NOACCESS = 998,
        ERROR_SWAPERROR = 999,
        ERROR_STACK_OVERFLOW = 1001,
        ERROR_INVALID_MESSAGE = 1002,
        ERROR_CAN_NOT_COMPLETE = 1003,
        ERROR_INVALID_FLAGS = 1004,
        ERROR_UNRECOGNIZED_VOLUME = 1005,
        ERROR_FILE_INVALID = 1006,
        ERROR_FULLSCREEN_MODE = 1007,
        ERROR_NO_TOKEN = 1008,
        ERROR_BADDB = 1009,
        ERROR_BADKEY = 1010,
        ERROR_CANTOPEN = 1011,
        ERROR_CANTREAD = 1012,
        ERROR_CANTWRITE = 1013,
        ERROR_REGISTRY_RECOVERED = 1014,
        ERROR_REGISTRY_CORRUPT = 1015,
        ERROR_REGISTRY_IO_FAILED = 1016,
        ERROR_NOT_REGISTRY_FILE = 1017,
        ERROR_KEY_DELETED = 1018,
        ERROR_NO_LOG_SPACE = 1019,
        ERROR_KEY_HAS_CHILDREN = 1020,
        ERROR_CHILD_MUST_BE_VOLATILE = 1021,
        ERROR_NOTIFY_ENUM_DIR = 1022,
        ERROR_DEPENDENT_SERVICES_RUNNING = 1051,
        ERROR_INVALID_SERVICE_CONTROL = 1052,
        ERROR_SERVICE_REQUEST_TIMEOUT = 1053,
        ERROR_SERVICE_NO_THREAD = 1054,
        ERROR_SERVICE_DATABASE_LOCKED = 1055,
        ERROR_SERVICE_ALREADY_RUNNING = 1056,
        ERROR_INVALID_SERVICE_ACCOUNT = 1057,
        ERROR_SERVICE_DISABLED = 1058,
        ERROR_CIRCULAR_DEPENDENCY = 1059,
        ERROR_SERVICE_DOES_NOT_EXIST = 1060,
        ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061,
        ERROR_SERVICE_NOT_ACTIVE = 1062,
        ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063,
        ERROR_EXCEPTION_IN_SERVICE = 1064,
        ERROR_DATABASE_DOES_NOT_EXIST = 1065,
        ERROR_SERVICE_SPECIFIC_ERROR = 1066,
        ERROR_PROCESS_ABORTED = 1067,
        ERROR_SERVICE_DEPENDENCY_FAIL = 1068,
        ERROR_SERVICE_LOGON_FAILED = 1069,
        ERROR_SERVICE_START_HANG = 1070,
        ERROR_INVALID_SERVICE_LOCK = 1071,
        ERROR_SERVICE_MARKED_FOR_DELETE = 1072,
        ERROR_SERVICE_EXISTS = 1073,
        ERROR_ALREADY_RUNNING_LKG = 1074,
        ERROR_SERVICE_DEPENDENCY_DELETED = 1075,
        ERROR_BOOT_ALREADY_ACCEPTED = 1076,
        ERROR_SERVICE_NEVER_STARTED = 1077,
        ERROR_DUPLICATE_SERVICE_NAME = 1078,
        ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079,
        ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080,
        ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081,
        ERROR_NO_RECOVERY_PROGRAM = 1082,
        ERROR_SERVICE_NOT_IN_EXE = 1083,
        ERROR_NOT_SAFEBOOT_SERVICE = 1084,
        ERROR_END_OF_MEDIA = 1100,
        ERROR_FILEMARK_DETECTED = 1101,
        ERROR_BEGINNING_OF_MEDIA = 1102,
        ERROR_SETMARK_DETECTED = 1103,
        ERROR_NO_DATA_DETECTED = 1104,
        ERROR_PARTITION_FAILURE = 1105,
        ERROR_INVALID_BLOCK_LENGTH = 1106,
        ERROR_DEVICE_NOT_PARTITIONED = 1107,
        ERROR_UNABLE_TO_LOCK_MEDIA = 1108,
        ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109,
        ERROR_MEDIA_CHANGED = 1110,
        ERROR_BUS_RESET = 1111,
        ERROR_NO_MEDIA_IN_DRIVE = 1112,
        ERROR_NO_UNICODE_TRANSLATION = 1113,
        ERROR_DLL_INIT_FAILED = 1114,
        ERROR_SHUTDOWN_IN_PROGRESS = 1115,
        ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116,
        ERROR_IO_DEVICE = 1117,
        ERROR_SERIAL_NO_DEVICE = 1118,
        ERROR_IRQ_BUSY = 1119,
        ERROR_MORE_WRITES = 1120,
        ERROR_COUNTER_TIMEOUT = 1121,
        ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122,
        ERROR_FLOPPY_WRONG_CYLINDER = 1123,
        ERROR_FLOPPY_UNKNOWN_ERROR = 1124,
        ERROR_FLOPPY_BAD_REGISTERS = 1125,
        ERROR_DISK_RECALIBRATE_FAILED = 1126,
        ERROR_DISK_OPERATION_FAILED = 1127,
        ERROR_DISK_RESET_FAILED = 1128,
        ERROR_EOM_OVERFLOW = 1129,
        ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130,
        ERROR_POSSIBLE_DEADLOCK = 1131,
        ERROR_MAPPED_ALIGNMENT = 1132,
        ERROR_SET_POWER_STATE_VETOED = 1140,
        ERROR_SET_POWER_STATE_FAILED = 1141,
        ERROR_TOO_MANY_LINKS = 1142,
        ERROR_OLD_WIN_VERSION = 1150,
        ERROR_APP_WRONG_OS = 1151,
        ERROR_SINGLE_INSTANCE_APP = 1152,
        ERROR_RMODE_APP = 1153,
        ERROR_INVALID_DLL = 1154,
        ERROR_NO_ASSOCIATION = 1155,
        ERROR_DDE_FAIL = 1156,
        ERROR_DLL_NOT_FOUND = 1157,
        ERROR_NO_MORE_USER_HANDLES = 1158,
        ERROR_MESSAGE_SYNC_ONLY = 1159,
        ERROR_SOURCE_ELEMENT_EMPTY = 1160,
        ERROR_DESTINATION_ELEMENT_FULL = 1161,
        ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162,
        ERROR_MAGAZINE_NOT_PRESENT = 1163,
        ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164,
        ERROR_DEVICE_REQUIRES_CLEANING = 1165,
        ERROR_DEVICE_DOOR_OPEN = 1166,
        ERROR_DEVICE_NOT_CONNECTED = 1167,
        ERROR_NOT_FOUND = 1168,
        ERROR_NO_MATCH = 1169,
        ERROR_SET_NOT_FOUND = 1170,
        ERROR_POINT_NOT_FOUND = 1171,
        ERROR_NO_TRACKING_SERVICE = 1172,
        ERROR_NO_VOLUME_ID = 1173,
        ERROR_UNABLE_TO_REMOVE_REPLACED = 1175,
        ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176,
        ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177,
        ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178,
        ERROR_JOURNAL_NOT_ACTIVE = 1179,
        ERROR_POTENTIAL_FILE_FOUND = 1180,
        ERROR_JOURNAL_ENTRY_DELETED = 1181,
        ERROR_BAD_DEVICE = 1200,
        ERROR_CONNECTION_UNAVAIL = 1201,
        ERROR_DEVICE_ALREADY_REMEMBERED = 1202,
        ERROR_NO_NET_OR_BAD_PATH = 1203,
        ERROR_BAD_PROVIDER = 1204,
        ERROR_CANNOT_OPEN_PROFILE = 1205,
        ERROR_BAD_PROFILE = 1206,
        ERROR_NOT_CONTAINER = 1207,
        ERROR_EXTENDED_ERROR = 1208,
        ERROR_INVALID_GROUPNAME = 1209,
        ERROR_INVALID_COMPUTERNAME = 1210,
        ERROR_INVALID_EVENTNAME = 1211,
        ERROR_INVALID_DOMAINNAME = 1212,
        ERROR_INVALID_SERVICENAME = 1213,
        ERROR_INVALID_NETNAME = 1214,
        ERROR_INVALID_SHARENAME = 1215,
        ERROR_INVALID_PASSWORDNAME = 1216,
        ERROR_INVALID_MESSAGENAME = 1217,
        ERROR_INVALID_MESSAGEDEST = 1218,
        ERROR_SESSION_CREDENTIAL_CONFLICT = 1219,
        ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220,
        ERROR_DUP_DOMAINNAME = 1221,
        ERROR_NO_NETWORK = 1222,
        ERROR_CANCELLED = 1223,
        ERROR_USER_MAPPED_FILE = 1224,
        ERROR_CONNECTION_REFUSED = 1225,
        ERROR_GRACEFUL_DISCONNECT = 1226,
        ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227,
        ERROR_ADDRESS_NOT_ASSOCIATED = 1228,
        ERROR_CONNECTION_INVALID = 1229,
        ERROR_CONNECTION_ACTIVE = 1230,
        ERROR_NETWORK_UNREACHABLE = 1231,
        ERROR_HOST_UNREACHABLE = 1232,
        ERROR_PROTOCOL_UNREACHABLE = 1233,
        ERROR_PORT_UNREACHABLE = 1234,
        ERROR_REQUEST_ABORTED = 1235,
        ERROR_CONNECTION_ABORTED = 1236,
        ERROR_RETRY = 1237,
        ERROR_CONNECTION_COUNT_LIMIT = 1238,
        ERROR_LOGIN_TIME_RESTRICTION = 1239,
        ERROR_LOGIN_WKSTA_RESTRICTION = 1240,
        ERROR_INCORRECT_ADDRESS = 1241,
        ERROR_ALREADY_REGISTERED = 1242,
        ERROR_SERVICE_NOT_FOUND = 1243,
        ERROR_NOT_AUTHENTICATED = 1244,
        ERROR_NOT_LOGGED_ON = 1245,
        ERROR_CONTINUE = 1246,
        ERROR_ALREADY_INITIALIZED = 1247,
        ERROR_NO_MORE_DEVICES = 1248,
        ERROR_NO_SUCH_SITE = 1249,
        ERROR_DOMAIN_CONTROLLER_EXISTS = 1250,
        ERROR_ONLY_IF_CONNECTED = 1251,
        ERROR_OVERRIDE_NOCHANGES = 1252,
        ERROR_BAD_USER_PROFILE = 1253,
        ERROR_NOT_SUPPORTED_ON_SBS = 1254,
        ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255,
        ERROR_HOST_DOWN = 1256,
        ERROR_NON_ACCOUNT_SID = 1257,
        ERROR_NON_DOMAIN_SID = 1258,
        ERROR_APPHELP_BLOCK = 1259,
        ERROR_ACCESS_DISABLED_BY_POLICY = 1260,
        ERROR_REG_NAT_CONSUMPTION = 1261,
        ERROR_CSCSHARE_OFFLINE = 1262,
        ERROR_PKINIT_FAILURE = 1263,
        ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264,
        ERROR_DOWNGRADE_DETECTED = 1265,
        ERROR_MACHINE_LOCKED = 1271,
        ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273,
        ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274,
        ERROR_DRIVER_BLOCKED = 1275,
        ERROR_INVALID_IMPORT_OF_NON_DLL = 1276,
        ERROR_ACCESS_DISABLED_WEBBLADE = 1277,
        ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278,
        ERROR_RECOVERY_FAILURE = 1279,
        ERROR_ALREADY_FIBER = 1280,
        ERROR_ALREADY_THREAD = 1281,
        ERROR_STACK_BUFFER_OVERRUN = 1282,
        ERROR_PARAMETER_QUOTA_EXCEEDED = 1283,
        ERROR_DEBUGGER_INACTIVE = 1284,
        ERROR_DELAY_LOAD_FAILED = 1285,
        ERROR_VDM_DISALLOWED = 1286,
        ERROR_UNIDENTIFIED_ERROR = 1287,
        ERROR_NOT_ALL_ASSIGNED = 1300,
        ERROR_SOME_NOT_MAPPED = 1301,
        ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302,
        ERROR_LOCAL_USER_SESSION_KEY = 1303,
        ERROR_NULL_LM_PASSWORD = 1304,
        ERROR_UNKNOWN_REVISION = 1305,
        ERROR_REVISION_MISMATCH = 1306,
        ERROR_INVALID_OWNER = 1307,
        ERROR_INVALID_PRIMARY_GROUP = 1308,
        ERROR_NO_IMPERSONATION_TOKEN = 1309,
        ERROR_CANT_DISABLE_MANDATORY = 1310,
        ERROR_NO_LOGON_SERVERS = 1311,
        ERROR_NO_SUCH_LOGON_SESSION = 1312,
        ERROR_NO_SUCH_PRIVILEGE = 1313,
        ERROR_PRIVILEGE_NOT_HELD = 1314,
        ERROR_INVALID_ACCOUNT_NAME = 1315,
        ERROR_USER_EXISTS = 1316,
        ERROR_NO_SUCH_USER = 1317,
        ERROR_GROUP_EXISTS = 1318,
        ERROR_NO_SUCH_GROUP = 1319,
        ERROR_MEMBER_IN_GROUP = 1320,
        ERROR_MEMBER_NOT_IN_GROUP = 1321,
        ERROR_LAST_ADMIN = 1322,
        ERROR_WRONG_PASSWORD = 1323,
        ERROR_ILL_FORMED_PASSWORD = 1324,
        ERROR_PASSWORD_RESTRICTION = 1325,
        ERROR_LOGON_FAILURE = 1326,
        ERROR_ACCOUNT_RESTRICTION = 1327,
        ERROR_INVALID_LOGON_HOURS = 1328,
        ERROR_INVALID_WORKSTATION = 1329,
        ERROR_PASSWORD_EXPIRED = 1330,
        ERROR_ACCOUNT_DISABLED = 1331,
        ERROR_NONE_MAPPED = 1332,
        ERROR_TOO_MANY_LUIDS_REQUESTED = 1333,
        ERROR_LUIDS_EXHAUSTED = 1334,
        ERROR_INVALID_SUB_AUTHORITY = 1335,
        ERROR_INVALID_ACL = 1336,
        ERROR_INVALID_SID = 1337,
        ERROR_INVALID_SECURITY_DESCR = 1338,
        ERROR_BAD_INHERITANCE_ACL = 1340,
        ERROR_SERVER_DISABLED = 1341,
        ERROR_SERVER_NOT_DISABLED = 1342,
        ERROR_INVALID_ID_AUTHORITY = 1343,
        ERROR_ALLOTTED_SPACE_EXCEEDED = 1344,
        ERROR_INVALID_GROUP_ATTRIBUTES = 1345,
        ERROR_BAD_IMPERSONATION_LEVEL = 1346,
        ERROR_CANT_OPEN_ANONYMOUS = 1347,
        ERROR_BAD_VALIDATION_CLASS = 1348,
        ERROR_BAD_TOKEN_TYPE = 1349,
        ERROR_NO_SECURITY_ON_OBJECT = 1350,
        ERROR_CANT_ACCESS_DOMAIN_INFO = 1351,
        ERROR_INVALID_SERVER_STATE = 1352,
        ERROR_INVALID_DOMAIN_STATE = 1353,
        ERROR_INVALID_DOMAIN_ROLE = 1354,
        ERROR_NO_SUCH_DOMAIN = 1355,
        ERROR_DOMAIN_EXISTS = 1356,
        ERROR_DOMAIN_LIMIT_EXCEEDED = 1357,
        ERROR_INTERNAL_DB_CORRUPTION = 1358,
        ERROR_INTERNAL_ERROR = 1359,
        ERROR_GENERIC_NOT_MAPPED = 1360,
        ERROR_BAD_DESCRIPTOR_FORMAT = 1361,
        ERROR_NOT_LOGON_PROCESS = 1362,
        ERROR_LOGON_SESSION_EXISTS = 1363,
        ERROR_NO_SUCH_PACKAGE = 1364,
        ERROR_BAD_LOGON_SESSION_STATE = 1365,
        ERROR_LOGON_SESSION_COLLISION = 1366,
        ERROR_INVALID_LOGON_TYPE = 1367,
        ERROR_CANNOT_IMPERSONATE = 1368,
        ERROR_RXACT_INVALID_STATE = 1369,
        ERROR_RXACT_COMMIT_FAILURE = 1370,
        ERROR_SPECIAL_ACCOUNT = 1371,
        ERROR_SPECIAL_GROUP = 1372,
        ERROR_SPECIAL_USER = 1373,
        ERROR_MEMBERS_PRIMARY_GROUP = 1374,
        ERROR_TOKEN_ALREADY_IN_USE = 1375,
        ERROR_NO_SUCH_ALIAS = 1376,
        ERROR_MEMBER_NOT_IN_ALIAS = 1377,
        ERROR_MEMBER_IN_ALIAS = 1378,
        ERROR_ALIAS_EXISTS = 1379,
        ERROR_LOGON_NOT_GRANTED = 1380,
        ERROR_TOO_MANY_SECRETS = 1381,
        ERROR_SECRET_TOO_LONG = 1382,
        ERROR_INTERNAL_DB_ERROR = 1383,
        ERROR_TOO_MANY_CONTEXT_IDS = 1384,
        ERROR_LOGON_TYPE_NOT_GRANTED = 1385,
        ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386,
        ERROR_NO_SUCH_MEMBER = 1387,
        ERROR_INVALID_MEMBER = 1388,
        ERROR_TOO_MANY_SIDS = 1389,
        ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390,
        ERROR_NO_INHERITANCE = 1391,
        ERROR_FILE_CORRUPT = 1392,
        ERROR_DISK_CORRUPT = 1393,
        ERROR_NO_USER_SESSION_KEY = 1394,
        ERROR_LICENSE_QUOTA_EXCEEDED = 1395,
        ERROR_WRONG_TARGET_NAME = 1396,
        ERROR_MUTUAL_AUTH_FAILED = 1397,
        ERROR_TIME_SKEW = 1398,
        ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399,
        ERROR_INVALID_WINDOW_HANDLE = 1400,
        ERROR_INVALID_MENU_HANDLE = 1401,
        ERROR_INVALID_CURSOR_HANDLE = 1402,
        ERROR_INVALID_ACCEL_HANDLE = 1403,
        ERROR_INVALID_HOOK_HANDLE = 1404,
        ERROR_INVALID_DWP_HANDLE = 1405,
        ERROR_TLW_WITH_WSCHILD = 1406,
        ERROR_CANNOT_FIND_WND_CLASS = 1407,
        ERROR_WINDOW_OF_OTHER_THREAD = 1408,
        ERROR_HOTKEY_ALREADY_REGISTERED = 1409,
        ERROR_CLASS_ALREADY_EXISTS = 1410,
        ERROR_CLASS_DOES_NOT_EXIST = 1411,
        ERROR_CLASS_HAS_WINDOWS = 1412,
        ERROR_INVALID_INDEX = 1413,
        ERROR_INVALID_ICON_HANDLE = 1414,
        ERROR_PRIVATE_DIALOG_INDEX = 1415,
        ERROR_LISTBOX_ID_NOT_FOUND = 1416,
        ERROR_NO_WILDCARD_CHARACTERS = 1417,
        ERROR_CLIPBOARD_NOT_OPEN = 1418,
        ERROR_HOTKEY_NOT_REGISTERED = 1419,
        ERROR_WINDOW_NOT_DIALOG = 1420,
        ERROR_CONTROL_ID_NOT_FOUND = 1421,
        ERROR_INVALID_COMBOBOX_MESSAGE = 1422,
        ERROR_WINDOW_NOT_COMBOBOX = 1423,
        ERROR_INVALID_EDIT_HEIGHT = 1424,
        ERROR_DC_NOT_FOUND = 1425,
        ERROR_INVALID_HOOK_FILTER = 1426,
        ERROR_INVALID_FILTER_PROC = 1427,
        ERROR_HOOK_NEEDS_HMOD = 1428,
        ERROR_GLOBAL_ONLY_HOOK = 1429,
        ERROR_JOURNAL_HOOK_SET = 1430,
        ERROR_HOOK_NOT_INSTALLED = 1431,
        ERROR_INVALID_LB_MESSAGE = 1432,
        ERROR_SETCOUNT_ON_BAD_LB = 1433,
        ERROR_LB_WITHOUT_TABSTOPS = 1434,
        ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435,
        ERROR_CHILD_WINDOW_MENU = 1436,
        ERROR_NO_SYSTEM_MENU = 1437,
        ERROR_INVALID_MSGBOX_STYLE = 1438,
        ERROR_INVALID_SPI_VALUE = 1439,
        ERROR_SCREEN_ALREADY_LOCKED = 1440,
        ERROR_HWNDS_HAVE_DIFF_PARENT = 1441,
        ERROR_NOT_CHILD_WINDOW = 1442,
        ERROR_INVALID_GW_COMMAND = 1443,
        ERROR_INVALID_THREAD_ID = 1444,
        ERROR_NON_MDICHILD_WINDOW = 1445,
        ERROR_POPUP_ALREADY_ACTIVE = 1446,
        ERROR_NO_SCROLLBARS = 1447,
        ERROR_INVALID_SCROLLBAR_RANGE = 1448,
        ERROR_INVALID_SHOWWIN_COMMAND = 1449,
        ERROR_NO_SYSTEM_RESOURCES = 1450,
        ERROR_NONPAGED_SYSTEM_RESOURCES = 1451,
        ERROR_PAGED_SYSTEM_RESOURCES = 1452,
        ERROR_WORKING_SET_QUOTA = 1453,
        ERROR_PAGEFILE_QUOTA = 1454,
        ERROR_COMMITMENT_LIMIT = 1455,
        ERROR_MENU_ITEM_NOT_FOUND = 1456,
        ERROR_INVALID_KEYBOARD_HANDLE = 1457,
        ERROR_HOOK_TYPE_NOT_ALLOWED = 1458,
        ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459,
        ERROR_TIMEOUT = 1460,
        ERROR_INVALID_MONITOR_HANDLE = 1461,
        ERROR_INCORRECT_SIZE = 1462,
        ERROR_EVENTLOG_FILE_CORRUPT = 1500,
        ERROR_EVENTLOG_CANT_START = 1501,
        ERROR_LOG_FILE_FULL = 1502,
        ERROR_EVENTLOG_FILE_CHANGED = 1503,
        ERROR_INSTALL_SERVICE_FAILURE = 1601,
        ERROR_INSTALL_USEREXIT = 1602,
        ERROR_INSTALL_FAILURE = 1603,
        ERROR_INSTALL_SUSPEND = 1604,
        ERROR_UNKNOWN_PRODUCT = 1605,
        ERROR_UNKNOWN_FEATURE = 1606,
        ERROR_UNKNOWN_COMPONENT = 1607,
        ERROR_UNKNOWN_PROPERTY = 1608,
        ERROR_INVALID_HANDLE_STATE = 1609,
        ERROR_BAD_CONFIGURATION = 1610,
        ERROR_INDEX_ABSENT = 1611,
        ERROR_INSTALL_SOURCE_ABSENT = 1612,
        ERROR_INSTALL_PACKAGE_VERSION = 1613,
        ERROR_PRODUCT_UNINSTALLED = 1614,
        ERROR_BAD_QUERY_SYNTAX = 1615,
        ERROR_INVALID_FIELD = 1616,
        ERROR_DEVICE_REMOVED = 1617,
        ERROR_INSTALL_ALREADY_RUNNING = 1618,
        ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619,
        ERROR_INSTALL_PACKAGE_INVALID = 1620,
        ERROR_INSTALL_UI_FAILURE = 1621,
        ERROR_INSTALL_LOG_FAILURE = 1622,
        ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623,
        ERROR_INSTALL_TRANSFORM_FAILURE = 1624,
        ERROR_INSTALL_PACKAGE_REJECTED = 1625,
        ERROR_FUNCTION_NOT_CALLED = 1626,
        ERROR_FUNCTION_FAILED = 1627,
        ERROR_INVALID_TABLE = 1628,
        ERROR_DATATYPE_MISMATCH = 1629,
        ERROR_UNSUPPORTED_TYPE = 1630,
        ERROR_CREATE_FAILED = 1631,
        ERROR_INSTALL_TEMP_UNWRITABLE = 1632,
        ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633,
        ERROR_INSTALL_NOTUSED = 1634,
        ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635,
        ERROR_PATCH_PACKAGE_INVALID = 1636,
        ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637,
        ERROR_PRODUCT_VERSION = 1638,
        ERROR_INVALID_COMMAND_LINE = 1639,
        ERROR_INSTALL_REMOTE_DISALLOWED = 1640,
        ERROR_SUCCESS_REBOOT_INITIATED = 1641,
        ERROR_PATCH_TARGET_NOT_FOUND = 1642,
        ERROR_PATCH_PACKAGE_REJECTED = 1643,
        ERROR_INSTALL_TRANSFORM_REJECTED = 1644,
        ERROR_INSTALL_REMOTE_PROHIBITED = 1645,
        RPC_S_INVALID_STRING_BINDING = 1700,
        RPC_S_WRONG_KIND_OF_BINDING = 1701,
        RPC_S_INVALID_BINDING = 1702,
        RPC_S_PROTSEQ_NOT_SUPPORTED = 1703,
        RPC_S_INVALID_RPC_PROTSEQ = 1704,
        RPC_S_INVALID_STRING_UUID = 1705,
        RPC_S_INVALID_ENDPOINT_FORMAT = 1706,
        RPC_S_INVALID_NET_ADDR = 1707,
        RPC_S_NO_ENDPOINT_FOUND = 1708,
        RPC_S_INVALID_TIMEOUT = 1709,
        RPC_S_OBJECT_NOT_FOUND = 1710,
        RPC_S_ALREADY_REGISTERED = 1711,
        RPC_S_TYPE_ALREADY_REGISTERED = 1712,
        RPC_S_ALREADY_LISTENING = 1713,
        RPC_S_NO_PROTSEQS_REGISTERED = 1714,
        RPC_S_NOT_LISTENING = 1715,
        RPC_S_UNKNOWN_MGR_TYPE = 1716,
        RPC_S_UNKNOWN_IF = 1717,
        RPC_S_NO_BINDINGS = 1718,
        RPC_S_NO_PROTSEQS = 1719,
        RPC_S_CANT_CREATE_ENDPOINT = 1720,
        RPC_S_OUT_OF_RESOURCES = 1721,
        RPC_S_SERVER_UNAVAILABLE = 1722,
        RPC_S_SERVER_TOO_BUSY = 1723,
        RPC_S_INVALID_NETWORK_OPTIONS = 1724,
        RPC_S_NO_CALL_ACTIVE = 1725,
        RPC_S_CALL_FAILED = 1726,
        RPC_S_CALL_FAILED_DNE = 1727,
        RPC_S_PROTOCOL_ERROR = 1728,
        RPC_S_UNSUPPORTED_TRANS_SYN = 1730,
        RPC_S_UNSUPPORTED_TYPE = 1732,
        RPC_S_INVALID_TAG = 1733,
        RPC_S_INVALID_BOUND = 1734,
        RPC_S_NO_ENTRY_NAME = 1735,
        RPC_S_INVALID_NAME_SYNTAX = 1736,
        RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737,
        RPC_S_UUID_NO_ADDRESS = 1739,
        RPC_S_DUPLICATE_ENDPOINT = 1740,
        RPC_S_UNKNOWN_AUTHN_TYPE = 1741,
        RPC_S_MAX_CALLS_TOO_SMALL = 1742,
        RPC_S_STRING_TOO_LONG = 1743,
        RPC_S_PROTSEQ_NOT_FOUND = 1744,
        RPC_S_PROCNUM_OUT_OF_RANGE = 1745,
        RPC_S_BINDING_HAS_NO_AUTH = 1746,
        RPC_S_UNKNOWN_AUTHN_SERVICE = 1747,
        RPC_S_UNKNOWN_AUTHN_LEVEL = 1748,
        RPC_S_INVALID_AUTH_IDENTITY = 1749,
        RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750,
        EPT_S_INVALID_ENTRY = 1751,
        EPT_S_CANT_PERFORM_OP = 1752,
        EPT_S_NOT_REGISTERED = 1753,
        RPC_S_NOTHING_TO_EXPORT = 1754,
        RPC_S_INCOMPLETE_NAME = 1755,
        RPC_S_INVALID_VERS_OPTION = 1756,
        RPC_S_NO_MORE_MEMBERS = 1757,
        RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758,
        RPC_S_INTERFACE_NOT_FOUND = 1759,
        RPC_S_ENTRY_ALREADY_EXISTS = 1760,
        RPC_S_ENTRY_NOT_FOUND = 1761,
        RPC_S_NAME_SERVICE_UNAVAILABLE = 1762,
        RPC_S_INVALID_NAF_ID = 1763,
        RPC_S_CANNOT_SUPPORT = 1764,
        RPC_S_NO_CONTEXT_AVAILABLE = 1765,
        RPC_S_INTERNAL_ERROR = 1766,
        RPC_S_ZERO_DIVIDE = 1767,
        RPC_S_ADDRESS_ERROR = 1768,
        RPC_S_FP_DIV_ZERO = 1769,
        RPC_S_FP_UNDERFLOW = 1770,
        RPC_S_FP_OVERFLOW = 1771,
        RPC_X_NO_MORE_ENTRIES = 1772,
        RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773,
        RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774,
        RPC_X_SS_IN_NULL_CONTEXT = 1775,
        RPC_X_SS_CONTEXT_DAMAGED = 1777,
        RPC_X_SS_HANDLES_MISMATCH = 1778,
        RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779,
        RPC_X_NULL_REF_POINTER = 1780,
        RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781,
        RPC_X_BYTE_COUNT_TOO_SMALL = 1782,
        RPC_X_BAD_STUB_DATA = 1783,
        ERROR_INVALID_USER_BUFFER = 1784,
        ERROR_UNRECOGNIZED_MEDIA = 1785,
        ERROR_NO_TRUST_LSA_SECRET = 1786,
        ERROR_NO_TRUST_SAM_ACCOUNT = 1787,
        ERROR_TRUSTED_DOMAIN_FAILURE = 1788,
        ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789,
        ERROR_TRUST_FAILURE = 1790,
        RPC_S_CALL_IN_PROGRESS = 1791,
        ERROR_NETLOGON_NOT_STARTED = 1792,
        ERROR_ACCOUNT_EXPIRED = 1793,
        ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794,
        ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795,
        ERROR_UNKNOWN_PORT = 1796,
        ERROR_UNKNOWN_PRINTER_DRIVER = 1797,
        ERROR_UNKNOWN_PRINTPROCESSOR = 1798,
        ERROR_INVALID_SEPARATOR_FILE = 1799,
        ERROR_INVALID_PRIORITY = 1800,
        ERROR_INVALID_PRINTER_NAME = 1801,
        ERROR_PRINTER_ALREADY_EXISTS = 1802,
        ERROR_INVALID_PRINTER_COMMAND = 1803,
        ERROR_INVALID_DATATYPE = 1804,
        ERROR_INVALID_ENVIRONMENT = 1805,
        RPC_S_NO_MORE_BINDINGS = 1806,
        ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807,
        ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808,
        ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809,
        ERROR_DOMAIN_TRUST_INCONSISTENT = 1810,
        ERROR_SERVER_HAS_OPEN_HANDLES = 1811,
        ERROR_RESOURCE_DATA_NOT_FOUND = 1812,
        ERROR_RESOURCE_TYPE_NOT_FOUND = 1813,
        ERROR_RESOURCE_NAME_NOT_FOUND = 1814,
        ERROR_RESOURCE_LANG_NOT_FOUND = 1815,
        ERROR_NOT_ENOUGH_QUOTA = 1816,
        RPC_S_NO_INTERFACES = 1817,
        RPC_S_CALL_CANCELLED = 1818,
        RPC_S_BINDING_INCOMPLETE = 1819,
        RPC_S_COMM_FAILURE = 1820,
        RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821,
        RPC_S_NO_PRINC_NAME = 1822,
        RPC_S_NOT_RPC_ERROR = 1823,
        RPC_S_UUID_LOCAL_ONLY = 1824,
        RPC_S_SEC_PKG_ERROR = 1825,
        RPC_S_NOT_CANCELLED = 1826,
        RPC_X_INVALID_ES_ACTION = 1827,
        RPC_X_WRONG_ES_VERSION = 1828,
        RPC_X_WRONG_STUB_VERSION = 1829,
        RPC_X_INVALID_PIPE_OBJECT = 1830,
        RPC_X_WRONG_PIPE_ORDER = 1831,
        RPC_X_WRONG_PIPE_VERSION = 1832,
        RPC_S_GROUP_MEMBER_NOT_FOUND = 1898,
        EPT_S_CANT_CREATE = 1899,
        RPC_S_INVALID_OBJECT = 1900,
        ERROR_INVALID_TIME = 1901,
        ERROR_INVALID_FORM_NAME = 1902,
        ERROR_INVALID_FORM_SIZE = 1903,
        ERROR_ALREADY_WAITING = 1904,
        ERROR_PRINTER_DELETED = 1905,
        ERROR_INVALID_PRINTER_STATE = 1906,
        ERROR_PASSWORD_MUST_CHANGE = 1907,
        ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908,
        ERROR_ACCOUNT_LOCKED_OUT = 1909,
        OR_INVALID_OXID = 1910,
        OR_INVALID_OID = 1911,
        OR_INVALID_SET = 1912,
        RPC_S_SEND_INCOMPLETE = 1913,
        RPC_S_INVALID_ASYNC_HANDLE = 1914,
        RPC_S_INVALID_ASYNC_CALL = 1915,
        RPC_X_PIPE_CLOSED = 1916,
        RPC_X_PIPE_DISCIPLINE_ERROR = 1917,
        RPC_X_PIPE_EMPTY = 1918,
        ERROR_NO_SITENAME = 1919,
        ERROR_CANT_ACCESS_FILE = 1920,
        ERROR_CANT_RESOLVE_FILENAME = 1921,
        RPC_S_ENTRY_TYPE_MISMATCH = 1922,
        RPC_S_NOT_ALL_OBJS_EXPORTED = 1923,
        RPC_S_INTERFACE_NOT_EXPORTED = 1924,
        RPC_S_PROFILE_NOT_ADDED = 1925,
        RPC_S_PRF_ELT_NOT_ADDED = 1926,
        RPC_S_PRF_ELT_NOT_REMOVED = 1927,
        RPC_S_GRP_ELT_NOT_ADDED = 1928,
        RPC_S_GRP_ELT_NOT_REMOVED = 1929,
        ERROR_KM_DRIVER_BLOCKED = 1930,
        ERROR_CONTEXT_EXPIRED = 1931,
        ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932,
        ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933,
        ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934,
        ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935,
        ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936,
        ERROR_INVALID_PIXEL_FORMAT = 2000,
        ERROR_BAD_DRIVER = 2001,
        ERROR_INVALID_WINDOW_STYLE = 2002,
        ERROR_METAFILE_NOT_SUPPORTED = 2003,
        ERROR_TRANSFORM_NOT_SUPPORTED = 2004,
        ERROR_CLIPPING_NOT_SUPPORTED = 2005,
        ERROR_INVALID_CMM = 2010,
        ERROR_INVALID_PROFILE = 2011,
        ERROR_TAG_NOT_FOUND = 2012,
        ERROR_TAG_NOT_PRESENT = 2013,
        ERROR_DUPLICATE_TAG = 2014,
        ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015,
        ERROR_PROFILE_NOT_FOUND = 2016,
        ERROR_INVALID_COLORSPACE = 2017,
        ERROR_ICM_NOT_ENABLED = 2018,
        ERROR_DELETING_ICM_XFORM = 2019,
        ERROR_INVALID_TRANSFORM = 2020,
        ERROR_COLORSPACE_MISMATCH = 2021,
        ERROR_INVALID_COLORINDEX = 2022,
        ERROR_CONNECTED_OTHER_PASSWORD = 2108,
        ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109,
        ERROR_BAD_USERNAME = 2202,
        ERROR_NOT_CONNECTED = 2250,
        ERROR_OPEN_FILES = 2401,
        ERROR_ACTIVE_CONNECTIONS = 2402,
        ERROR_DEVICE_IN_USE = 2404,
        ERROR_UNKNOWN_PRINT_MONITOR = 3000,
        ERROR_PRINTER_DRIVER_IN_USE = 3001,
        ERROR_SPOOL_FILE_NOT_FOUND = 3002,
        ERROR_SPL_NO_STARTDOC = 3003,
        ERROR_SPL_NO_ADDJOB = 3004,
        ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005,
        ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006,
        ERROR_INVALID_PRINT_MONITOR = 3007,
        ERROR_PRINT_MONITOR_IN_USE = 3008,
        ERROR_PRINTER_HAS_JOBS_QUEUED = 3009,
        ERROR_SUCCESS_REBOOT_REQUIRED = 3010,
        ERROR_SUCCESS_RESTART_REQUIRED = 3011,
        ERROR_PRINTER_NOT_FOUND = 3012,
        ERROR_PRINTER_DRIVER_WARNED = 3013,
        ERROR_PRINTER_DRIVER_BLOCKED = 3014,
        ERROR_WINS_INTERNAL = 4000,
        ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001,
        ERROR_STATIC_INIT = 4002,
        ERROR_INC_BACKUP = 4003,
        ERROR_FULL_BACKUP = 4004,
        ERROR_REC_NON_EXISTENT = 4005,
        ERROR_RPL_NOT_ALLOWED = 4006,
        ERROR_DHCP_ADDRESS_CONFLICT = 4100,
        ERROR_WMI_GUID_NOT_FOUND = 4200,
        ERROR_WMI_INSTANCE_NOT_FOUND = 4201,
        ERROR_WMI_ITEMID_NOT_FOUND = 4202,
        ERROR_WMI_TRY_AGAIN = 4203,
        ERROR_WMI_DP_NOT_FOUND = 4204,
        ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205,
        ERROR_WMI_ALREADY_ENABLED = 4206,
        ERROR_WMI_GUID_DISCONNECTED = 4207,
        ERROR_WMI_SERVER_UNAVAILABLE = 4208,
        ERROR_WMI_DP_FAILED = 4209,
        ERROR_WMI_INVALID_MOF = 4210,
        ERROR_WMI_INVALID_REGINFO = 4211,
        ERROR_WMI_ALREADY_DISABLED = 4212,
        ERROR_WMI_READ_ONLY = 4213,
        ERROR_WMI_SET_FAILURE = 4214,
        ERROR_INVALID_MEDIA = 4300,
        ERROR_INVALID_LIBRARY = 4301,
        ERROR_INVALID_MEDIA_POOL = 4302,
        ERROR_DRIVE_MEDIA_MISMATCH = 4303,
        ERROR_MEDIA_OFFLINE = 4304,
        ERROR_LIBRARY_OFFLINE = 4305,
        ERROR_EMPTY = 4306,
        ERROR_NOT_EMPTY = 4307,
        ERROR_MEDIA_UNAVAILABLE = 4308,
        ERROR_RESOURCE_DISABLED = 4309,
        ERROR_INVALID_CLEANER = 4310,
        ERROR_UNABLE_TO_CLEAN = 4311,
        ERROR_OBJECT_NOT_FOUND = 4312,
        ERROR_DATABASE_FAILURE = 4313,
        ERROR_DATABASE_FULL = 4314,
        ERROR_MEDIA_INCOMPATIBLE = 4315,
        ERROR_RESOURCE_NOT_PRESENT = 4316,
        ERROR_INVALID_OPERATION = 4317,
        ERROR_MEDIA_NOT_AVAILABLE = 4318,
        ERROR_DEVICE_NOT_AVAILABLE = 4319,
        ERROR_REQUEST_REFUSED = 4320,
        ERROR_INVALID_DRIVE_OBJECT = 4321,
        ERROR_LIBRARY_FULL = 4322,
        ERROR_MEDIUM_NOT_ACCESSIBLE = 4323,
        ERROR_UNABLE_TO_LOAD_MEDIUM = 4324,
        ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325,
        ERROR_UNABLE_TO_INVENTORY_SLOT = 4326,
        ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327,
        ERROR_TRANSPORT_FULL = 4328,
        ERROR_CONTROLLING_IEPORT = 4329,
        ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330,
        ERROR_CLEANER_SLOT_SET = 4331,
        ERROR_CLEANER_SLOT_NOT_SET = 4332,
        ERROR_CLEANER_CARTRIDGE_SPENT = 4333,
        ERROR_UNEXPECTED_OMID = 4334,
        ERROR_CANT_DELETE_LAST_ITEM = 4335,
        ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336,
        ERROR_VOLUME_CONTAINS_SYS_FILES = 4337,
        ERROR_INDIGENOUS_TYPE = 4338,
        ERROR_NO_SUPPORTING_DRIVES = 4339,
        ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340,
        ERROR_IEPORT_FULL = 4341,
        ERROR_FILE_OFFLINE = 4350,
        ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351,
        ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352,
        ERROR_NOT_A_REPARSE_POINT = 4390,
        ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391,
        ERROR_INVALID_REPARSE_DATA = 4392,
        ERROR_REPARSE_TAG_INVALID = 4393,
        ERROR_REPARSE_TAG_MISMATCH = 4394,
        ERROR_VOLUME_NOT_SIS_ENABLED = 4500,
        ERROR_DEPENDENT_RESOURCE_EXISTS = 5001,
        ERROR_DEPENDENCY_NOT_FOUND = 5002,
        ERROR_DEPENDENCY_ALREADY_EXISTS = 5003,
        ERROR_RESOURCE_NOT_ONLINE = 5004,
        ERROR_HOST_NODE_NOT_AVAILABLE = 5005,
        ERROR_RESOURCE_NOT_AVAILABLE = 5006,
        ERROR_RESOURCE_NOT_FOUND = 5007,
        ERROR_SHUTDOWN_CLUSTER = 5008,
        ERROR_CANT_EVICT_ACTIVE_NODE = 5009,
        ERROR_OBJECT_ALREADY_EXISTS = 5010,
        ERROR_OBJECT_IN_LIST = 5011,
        ERROR_GROUP_NOT_AVAILABLE = 5012,
        ERROR_GROUP_NOT_FOUND = 5013,
        ERROR_GROUP_NOT_ONLINE = 5014,
        ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015,
        ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016,
        ERROR_RESMON_CREATE_FAILED = 5017,
        ERROR_RESMON_ONLINE_FAILED = 5018,
        ERROR_RESOURCE_ONLINE = 5019,
        ERROR_QUORUM_RESOURCE = 5020,
        ERROR_NOT_QUORUM_CAPABLE = 5021,
        ERROR_CLUSTER_SHUTTING_DOWN = 5022,
        ERROR_INVALID_STATE = 5023,
        ERROR_RESOURCE_PROPERTIES_STORED = 5024,
        ERROR_NOT_QUORUM_CLASS = 5025,
        ERROR_CORE_RESOURCE = 5026,
        ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027,
        ERROR_QUORUMLOG_OPEN_FAILED = 5028,
        ERROR_CLUSTERLOG_CORRUPT = 5029,
        ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030,
        ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031,
        ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032,
        ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033,
        ERROR_QUORUM_OWNER_ALIVE = 5034,
        ERROR_NETWORK_NOT_AVAILABLE = 5035,
        ERROR_NODE_NOT_AVAILABLE = 5036,
        ERROR_ALL_NODES_NOT_AVAILABLE = 5037,
        ERROR_RESOURCE_FAILED = 5038,
        ERROR_CLUSTER_INVALID_NODE = 5039,
        ERROR_CLUSTER_NODE_EXISTS = 5040,
        ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041,
        ERROR_CLUSTER_NODE_NOT_FOUND = 5042,
        ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043,
        ERROR_CLUSTER_NETWORK_EXISTS = 5044,
        ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045,
        ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046,
        ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047,
        ERROR_CLUSTER_INVALID_REQUEST = 5048,
        ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049,
        ERROR_CLUSTER_NODE_DOWN = 5050,
        ERROR_CLUSTER_NODE_UNREACHABLE = 5051,
        ERROR_CLUSTER_NODE_NOT_MEMBER = 5052,
        ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053,
        ERROR_CLUSTER_INVALID_NETWORK = 5054,
        ERROR_CLUSTER_NODE_UP = 5056,
        ERROR_CLUSTER_IPADDR_IN_USE = 5057,
        ERROR_CLUSTER_NODE_NOT_PAUSED = 5058,
        ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059,
        ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060,
        ERROR_CLUSTER_NODE_ALREADY_UP = 5061,
        ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062,
        ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063,
        ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064,
        ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065,
        ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066,
        ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067,
        ERROR_INVALID_OPERATION_ON_QUORUM = 5068,
        ERROR_DEPENDENCY_NOT_ALLOWED = 5069,
        ERROR_CLUSTER_NODE_PAUSED = 5070,
        ERROR_NODE_CANT_HOST_RESOURCE = 5071,
        ERROR_CLUSTER_NODE_NOT_READY = 5072,
        ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073,
        ERROR_CLUSTER_JOIN_ABORTED = 5074,
        ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075,
        ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076,
        ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077,
        ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078,
        ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079,
        ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080,
        ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081,
        ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082,
        ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083,
        ERROR_RESMON_INVALID_STATE = 5084,
        ERROR_CLUSTER_GUM_NOT_LOCKER = 5085,
        ERROR_QUORUM_DISK_NOT_FOUND = 5086,
        ERROR_DATABASE_BACKUP_CORRUPT = 5087,
        ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088,
        ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089,
        ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890,
        ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891,
        ERROR_CLUSTER_MEMBERSHIP_HALT = 5892,
        ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893,
        ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894,
        ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895,
        ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896,
        ERROR_CLUSTER_PARAMETER_MISMATCH = 5897,
        ERROR_NODE_CANNOT_BE_CLUSTERED = 5898,
        ERROR_CLUSTER_WRONG_OS_VERSION = 5899,
        ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900,
        ERROR_CLUSCFG_ALREADY_COMMITTED = 5901,
        ERROR_CLUSCFG_ROLLBACK_FAILED = 5902,
        ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903,
        ERROR_CLUSTER_OLD_VERSION = 5904,
        ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905,
        ERROR_ENCRYPTION_FAILED = 6000,
        ERROR_DECRYPTION_FAILED = 6001,
        ERROR_FILE_ENCRYPTED = 6002,
        ERROR_NO_RECOVERY_POLICY = 6003,
        ERROR_NO_EFS = 6004,
        ERROR_WRONG_EFS = 6005,
        ERROR_NO_USER_KEYS = 6006,
        ERROR_FILE_NOT_ENCRYPTED = 6007,
        ERROR_NOT_EXPORT_FORMAT = 6008,
        ERROR_FILE_READ_ONLY = 6009,
        ERROR_DIR_EFS_DISALLOWED = 6010,
        ERROR_EFS_SERVER_NOT_TRUSTED = 6011,
        ERROR_BAD_RECOVERY_POLICY = 6012,
        ERROR_EFS_ALG_BLOB_TOO_BIG = 6013,
        ERROR_VOLUME_NOT_SUPPORT_EFS = 6014,
        ERROR_EFS_DISABLED = 6015,
        ERROR_EFS_VERSION_NOT_SUPPORT = 6016,
        ERROR_NO_BROWSER_SERVERS_FOUND = 6118,
        SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200,
        ERROR_CTX_WINSTATION_NAME_INVALID = 7001,
        ERROR_CTX_INVALID_PD = 7002,
        ERROR_CTX_PD_NOT_FOUND = 7003,
        ERROR_CTX_WD_NOT_FOUND = 7004,
        ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005,
        ERROR_CTX_SERVICE_NAME_COLLISION = 7006,
        ERROR_CTX_CLOSE_PENDING = 7007,
        ERROR_CTX_NO_OUTBUF = 7008,
        ERROR_CTX_MODEM_INF_NOT_FOUND = 7009,
        ERROR_CTX_INVALID_MODEMNAME = 7010,
        ERROR_CTX_MODEM_RESPONSE_ERROR = 7011,
        ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012,
        ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013,
        ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014,
        ERROR_CTX_MODEM_RESPONSE_BUSY = 7015,
        ERROR_CTX_MODEM_RESPONSE_VOICE = 7016,
        ERROR_CTX_TD_ERROR = 7017,
        ERROR_CTX_WINSTATION_NOT_FOUND = 7022,
        ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023,
        ERROR_CTX_WINSTATION_BUSY = 7024,
        ERROR_CTX_BAD_VIDEO_MODE = 7025,
        ERROR_CTX_GRAPHICS_INVALID = 7035,
        ERROR_CTX_LOGON_DISABLED = 7037,
        ERROR_CTX_NOT_CONSOLE = 7038,
        ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040,
        ERROR_CTX_CONSOLE_DISCONNECT = 7041,
        ERROR_CTX_CONSOLE_CONNECT = 7042,
        ERROR_CTX_SHADOW_DENIED = 7044,
        ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045,
        ERROR_CTX_INVALID_WD = 7049,
        ERROR_CTX_SHADOW_INVALID = 7050,
        ERROR_CTX_SHADOW_DISABLED = 7051,
        ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052,
        ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053,
        ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054,
        ERROR_CTX_LICENSE_CLIENT_INVALID = 7055,
        ERROR_CTX_LICENSE_EXPIRED = 7056,
        ERROR_CTX_SHADOW_NOT_RUNNING = 7057,
        ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058,
        ERROR_ACTIVATION_COUNT_EXCEEDED = 7059,
        FRS_ERR_INVALID_API_SEQUENCE = 8001,
        FRS_ERR_STARTING_SERVICE = 8002,
        FRS_ERR_STOPPING_SERVICE = 8003,
        FRS_ERR_INTERNAL_API = 8004,
        FRS_ERR_INTERNAL = 8005,
        FRS_ERR_SERVICE_COMM = 8006,
        FRS_ERR_INSUFFICIENT_PRIV = 8007,
        FRS_ERR_AUTHENTICATION = 8008,
        FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009,
        FRS_ERR_PARENT_AUTHENTICATION = 8010,
        FRS_ERR_CHILD_TO_PARENT_COMM = 8011,
        FRS_ERR_PARENT_TO_CHILD_COMM = 8012,
        FRS_ERR_SYSVOL_POPULATE = 8013,
        FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014,
        FRS_ERR_SYSVOL_IS_BUSY = 8015,
        FRS_ERR_SYSVOL_DEMOTE = 8016,
        FRS_ERR_INVALID_SERVICE_PARAMETER = 8017,
        DS_S_SUCCESS = 0,
        ERROR_DS_NOT_INSTALLED = 8200,
        ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201,
        ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202,
        ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203,
        ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204,
        ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205,
        ERROR_DS_BUSY = 8206,
        ERROR_DS_UNAVAILABLE = 8207,
        ERROR_DS_NO_RIDS_ALLOCATED = 8208,
        ERROR_DS_NO_MORE_RIDS = 8209,
        ERROR_DS_INCORRECT_ROLE_OWNER = 8210,
        ERROR_DS_RIDMGR_INIT_ERROR = 8211,
        ERROR_DS_OBJ_CLASS_VIOLATION = 8212,
        ERROR_DS_CANT_ON_NON_LEAF = 8213,
        ERROR_DS_CANT_ON_RDN = 8214,
        ERROR_DS_CANT_MOD_OBJ_CLASS = 8215,
        ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216,
        ERROR_DS_GC_NOT_AVAILABLE = 8217,
        ERROR_SHARED_POLICY = 8218,
        ERROR_POLICY_OBJECT_NOT_FOUND = 8219,
        ERROR_POLICY_ONLY_IN_DS = 8220,
        ERROR_PROMOTION_ACTIVE = 8221,
        ERROR_NO_PROMOTION_ACTIVE = 8222,
        ERROR_DS_OPERATIONS_ERROR = 8224,
        ERROR_DS_PROTOCOL_ERROR = 8225,
        ERROR_DS_TIMELIMIT_EXCEEDED = 8226,
        ERROR_DS_SIZELIMIT_EXCEEDED = 8227,
        ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228,
        ERROR_DS_COMPARE_FALSE = 8229,
        ERROR_DS_COMPARE_TRUE = 8230,
        ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231,
        ERROR_DS_STRONG_AUTH_REQUIRED = 8232,
        ERROR_DS_INAPPROPRIATE_AUTH = 8233,
        ERROR_DS_AUTH_UNKNOWN = 8234,
        ERROR_DS_REFERRAL = 8235,
        ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236,
        ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237,
        ERROR_DS_INAPPROPRIATE_MATCHING = 8238,
        ERROR_DS_CONSTRAINT_VIOLATION = 8239,
        ERROR_DS_NO_SUCH_OBJECT = 8240,
        ERROR_DS_ALIAS_PROBLEM = 8241,
        ERROR_DS_INVALID_DN_SYNTAX = 8242,
        ERROR_DS_IS_LEAF = 8243,
        ERROR_DS_ALIAS_DEREF_PROBLEM = 8244,
        ERROR_DS_UNWILLING_TO_PERFORM = 8245,
        ERROR_DS_LOOP_DETECT = 8246,
        ERROR_DS_NAMING_VIOLATION = 8247,
        ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248,
        ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249,
        ERROR_DS_SERVER_DOWN = 8250,
        ERROR_DS_LOCAL_ERROR = 8251,
        ERROR_DS_ENCODING_ERROR = 8252,
        ERROR_DS_DECODING_ERROR = 8253,
        ERROR_DS_FILTER_UNKNOWN = 8254,
        ERROR_DS_PARAM_ERROR = 8255,
        ERROR_DS_NOT_SUPPORTED = 8256,
        ERROR_DS_NO_RESULTS_RETURNED = 8257,
        ERROR_DS_CONTROL_NOT_FOUND = 8258,
        ERROR_DS_CLIENT_LOOP = 8259,
        ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260,
        ERROR_DS_SORT_CONTROL_MISSING = 8261,
        ERROR_DS_OFFSET_RANGE_ERROR = 8262,
        ERROR_DS_ROOT_MUST_BE_NC = 8301,
        ERROR_DS_ADD_REPLICA_INHIBITED = 8302,
        ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303,
        ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304,
        ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305,
        ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306,
        ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307,
        ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308,
        ERROR_DS_USER_BUFFER_TO_SMALL = 8309,
        ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310,
        ERROR_DS_ILLEGAL_MOD_OPERATION = 8311,
        ERROR_DS_OBJ_TOO_LARGE = 8312,
        ERROR_DS_BAD_INSTANCE_TYPE = 8313,
        ERROR_DS_MASTERDSA_REQUIRED = 8314,
        ERROR_DS_OBJECT_CLASS_REQUIRED = 8315,
        ERROR_DS_MISSING_REQUIRED_ATT = 8316,
        ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317,
        ERROR_DS_ATT_ALREADY_EXISTS = 8318,
        ERROR_DS_CANT_ADD_ATT_VALUES = 8320,
        ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321,
        ERROR_DS_RANGE_CONSTRAINT = 8322,
        ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323,
        ERROR_DS_CANT_REM_MISSING_ATT = 8324,
        ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325,
        ERROR_DS_ROOT_CANT_BE_SUBREF = 8326,
        ERROR_DS_NO_CHAINING = 8327,
        ERROR_DS_NO_CHAINED_EVAL = 8328,
        ERROR_DS_NO_PARENT_OBJECT = 8329,
        ERROR_DS_PARENT_IS_AN_ALIAS = 8330,
        ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331,
        ERROR_DS_CHILDREN_EXIST = 8332,
        ERROR_DS_OBJ_NOT_FOUND = 8333,
        ERROR_DS_ALIASED_OBJ_MISSING = 8334,
        ERROR_DS_BAD_NAME_SYNTAX = 8335,
        ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336,
        ERROR_DS_CANT_DEREF_ALIAS = 8337,
        ERROR_DS_OUT_OF_SCOPE = 8338,
        ERROR_DS_OBJECT_BEING_REMOVED = 8339,
        ERROR_DS_CANT_DELETE_DSA_OBJ = 8340,
        ERROR_DS_GENERIC_ERROR = 8341,
        ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342,
        ERROR_DS_CLASS_NOT_DSA = 8343,
        ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344,
        ERROR_DS_ILLEGAL_SUPERIOR = 8345,
        ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346,
        ERROR_DS_NAME_TOO_MANY_PARTS = 8347,
        ERROR_DS_NAME_TOO_LONG = 8348,
        ERROR_DS_NAME_VALUE_TOO_LONG = 8349,
        ERROR_DS_NAME_UNPARSEABLE = 8350,
        ERROR_DS_NAME_TYPE_UNKNOWN = 8351,
        ERROR_DS_NOT_AN_OBJECT = 8352,
        ERROR_DS_SEC_DESC_TOO_SHORT = 8353,
        ERROR_DS_SEC_DESC_INVALID = 8354,
        ERROR_DS_NO_DELETED_NAME = 8355,
        ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356,
        ERROR_DS_NCNAME_MUST_BE_NC = 8357,
        ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358,
        ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359,
        ERROR_DS_INVALID_DMD = 8360,
        ERROR_DS_OBJ_GUID_EXISTS = 8361,
        ERROR_DS_NOT_ON_BACKLINK = 8362,
        ERROR_DS_NO_CROSSREF_FOR_NC = 8363,
        ERROR_DS_SHUTTING_DOWN = 8364,
        ERROR_DS_UNKNOWN_OPERATION = 8365,
        ERROR_DS_INVALID_ROLE_OWNER = 8366,
        ERROR_DS_COULDNT_CONTACT_FSMO = 8367,
        ERROR_DS_CROSS_NC_DN_RENAME = 8368,
        ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369,
        ERROR_DS_REPLICATOR_ONLY = 8370,
        ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371,
        ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372,
        ERROR_DS_NAME_REFERENCE_INVALID = 8373,
        ERROR_DS_CROSS_REF_EXISTS = 8374,
        ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375,
        ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376,
        ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377,
        ERROR_DS_DUP_RDN = 8378,
        ERROR_DS_DUP_OID = 8379,
        ERROR_DS_DUP_MAPI_ID = 8380,
        ERROR_DS_DUP_SCHEMA_ID_GUID = 8381,
        ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382,
        ERROR_DS_SEMANTIC_ATT_TEST = 8383,
        ERROR_DS_SYNTAX_MISMATCH = 8384,
        ERROR_DS_EXISTS_IN_MUST_HAVE = 8385,
        ERROR_DS_EXISTS_IN_MAY_HAVE = 8386,
        ERROR_DS_NONEXISTENT_MAY_HAVE = 8387,
        ERROR_DS_NONEXISTENT_MUST_HAVE = 8388,
        ERROR_DS_AUX_CLS_TEST_FAIL = 8389,
        ERROR_DS_NONEXISTENT_POSS_SUP = 8390,
        ERROR_DS_SUB_CLS_TEST_FAIL = 8391,
        ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392,
        ERROR_DS_EXISTS_IN_AUX_CLS = 8393,
        ERROR_DS_EXISTS_IN_SUB_CLS = 8394,
        ERROR_DS_EXISTS_IN_POSS_SUP = 8395,
        ERROR_DS_RECALCSCHEMA_FAILED = 8396,
        ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397,
        ERROR_DS_CANT_DELETE = 8398,
        ERROR_DS_ATT_SCHEMA_REQ_ID = 8399,
        ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400,
        ERROR_DS_CANT_CACHE_ATT = 8401,
        ERROR_DS_CANT_CACHE_CLASS = 8402,
        ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403,
        ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404,
        ERROR_DS_CANT_RETRIEVE_DN = 8405,
        ERROR_DS_MISSING_SUPREF = 8406,
        ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407,
        ERROR_DS_CODE_INCONSISTENCY = 8408,
        ERROR_DS_DATABASE_ERROR = 8409,
        ERROR_DS_GOVERNSID_MISSING = 8410,
        ERROR_DS_MISSING_EXPECTED_ATT = 8411,
        ERROR_DS_NCNAME_MISSING_CR_REF = 8412,
        ERROR_DS_SECURITY_CHECKING_ERROR = 8413,
        ERROR_DS_SCHEMA_NOT_LOADED = 8414,
        ERROR_DS_SCHEMA_ALLOC_FAILED = 8415,
        ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416,
        ERROR_DS_GCVERIFY_ERROR = 8417,
        ERROR_DS_DRA_SCHEMA_MISMATCH = 8418,
        ERROR_DS_CANT_FIND_DSA_OBJ = 8419,
        ERROR_DS_CANT_FIND_EXPECTED_NC = 8420,
        ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421,
        ERROR_DS_CANT_RETRIEVE_CHILD = 8422,
        ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423,
        ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424,
        ERROR_DS_BAD_HIERARCHY_FILE = 8425,
        ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426,
        ERROR_DS_CONFIG_PARAM_MISSING = 8427,
        ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428,
        ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429,
        ERROR_DS_INTERNAL_FAILURE = 8430,
        ERROR_DS_UNKNOWN_ERROR = 8431,
        ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432,
        ERROR_DS_REFUSING_FSMO_ROLES = 8433,
        ERROR_DS_MISSING_FSMO_SETTINGS = 8434,
        ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435,
        ERROR_DS_DRA_GENERIC = 8436,
        ERROR_DS_DRA_INVALID_PARAMETER = 8437,
        ERROR_DS_DRA_BUSY = 8438,
        ERROR_DS_DRA_BAD_DN = 8439,
        ERROR_DS_DRA_BAD_NC = 8440,
        ERROR_DS_DRA_DN_EXISTS = 8441,
        ERROR_DS_DRA_INTERNAL_ERROR = 8442,
        ERROR_DS_DRA_INCONSISTENT_DIT = 8443,
        ERROR_DS_DRA_CONNECTION_FAILED = 8444,
        ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445,
        ERROR_DS_DRA_OUT_OF_MEM = 8446,
        ERROR_DS_DRA_MAIL_PROBLEM = 8447,
        ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448,
        ERROR_DS_DRA_REF_NOT_FOUND = 8449,
        ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450,
        ERROR_DS_DRA_DB_ERROR = 8451,
        ERROR_DS_DRA_NO_REPLICA = 8452,
        ERROR_DS_DRA_ACCESS_DENIED = 8453,
        ERROR_DS_DRA_NOT_SUPPORTED = 8454,
        ERROR_DS_DRA_RPC_CANCELLED = 8455,
        ERROR_DS_DRA_SOURCE_DISABLED = 8456,
        ERROR_DS_DRA_SINK_DISABLED = 8457,
        ERROR_DS_DRA_NAME_COLLISION = 8458,
        ERROR_DS_DRA_SOURCE_REINSTALLED = 8459,
        ERROR_DS_DRA_MISSING_PARENT = 8460,
        ERROR_DS_DRA_PREEMPTED = 8461,
        ERROR_DS_DRA_ABANDON_SYNC = 8462,
        ERROR_DS_DRA_SHUTDOWN = 8463,
        ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464,
        ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465,
        ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466,
        ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467,
        ERROR_DS_DUP_LINK_ID = 8468,
        ERROR_DS_NAME_ERROR_RESOLVING = 8469,
        ERROR_DS_NAME_ERROR_NOT_FOUND = 8470,
        ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471,
        ERROR_DS_NAME_ERROR_NO_MAPPING = 8472,
        ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473,
        ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474,
        ERROR_DS_CONSTRUCTED_ATT_MOD = 8475,
        ERROR_DS_WRONG_OM_OBJ_CLASS = 8476,
        ERROR_DS_DRA_REPL_PENDING = 8477,
        ERROR_DS_DS_REQUIRED = 8478,
        ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479,
        ERROR_DS_NON_BASE_SEARCH = 8480,
        ERROR_DS_CANT_RETRIEVE_ATTS = 8481,
        ERROR_DS_BACKLINK_WITHOUT_LINK = 8482,
        ERROR_DS_EPOCH_MISMATCH = 8483,
        ERROR_DS_SRC_NAME_MISMATCH = 8484,
        ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485,
        ERROR_DS_DST_NC_MISMATCH = 8486,
        ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487,
        ERROR_DS_SRC_GUID_MISMATCH = 8488,
        ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489,
        ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490,
        ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491,
        ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492,
        ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493,
        ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494,
        ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495,
        ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496,
        ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497,
        ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498,
        ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499,
        ERROR_DS_INVALID_SEARCH_FLAG = 8500,
        ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501,
        ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502,
        ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503,
        ERROR_DS_SAM_INIT_FAILURE = 8504,
        ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505,
        ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506,
        ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507,
        ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508,
        ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509,
        ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510,
        ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511,
        ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512,
        ERROR_DS_INVALID_GROUP_TYPE = 8513,
        ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514,
        ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515,
        ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516,
        ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517,
        ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518,
        ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519,
        ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520,
        ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521,
        ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522,
        ERROR_DS_NAMING_MASTER_GC = 8523,
        ERROR_DS_DNS_LOOKUP_FAILURE = 8524,
        ERROR_DS_COULDNT_UPDATE_SPNS = 8525,
        ERROR_DS_CANT_RETRIEVE_SD = 8526,
        ERROR_DS_KEY_NOT_UNIQUE = 8527,
        ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528,
        ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529,
        ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530,
        ERROR_DS_CANT_START = 8531,
        ERROR_DS_INIT_FAILURE = 8532,
        ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533,
        ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534,
        ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535,
        ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536,
        ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537,
        ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538,
        ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539,
        ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540,
        ERROR_SAM_INIT_FAILURE = 8541,
        ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542,
        ERROR_DS_DRA_SCHEMA_CONFLICT = 8543,
        ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544,
        ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545,
        ERROR_DS_NC_STILL_HAS_DSAS = 8546,
        ERROR_DS_GC_REQUIRED = 8547,
        ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548,
        ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549,
        ERROR_DS_CANT_ADD_TO_GC = 8550,
        ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551,
        ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552,
        ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553,
        ERROR_DS_INVALID_NAME_FOR_SPN = 8554,
        ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555,
        ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556,
        ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557,
        ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558,
        ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559,
        ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560,
        ERROR_DS_INIT_FAILURE_CONSOLE = 8561,
        ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562,
        ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563,
        ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564,
        ERROR_DS_FOREST_VERSION_TOO_LOW = 8565,
        ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566,
        ERROR_DS_INCOMPATIBLE_VERSION = 8567,
        ERROR_DS_LOW_DSA_VERSION = 8568,
        ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569,
        ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570,
        ERROR_DS_NAME_NOT_UNIQUE = 8571,
        ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572,
        ERROR_DS_OUT_OF_VERSION_STORE = 8573,
        ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574,
        ERROR_DS_NO_REF_DOMAIN = 8575,
        ERROR_DS_RESERVED_LINK_ID = 8576,
        ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577,
        ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578,
        ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579,
        ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580,
        ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581,
        ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582,
        ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583,
        ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584,
        ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585,
        ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586,
        ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587,
        ERROR_DS_NOT_CLOSEST = 8588,
        ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589,
        ERROR_DS_SINGLE_USER_MODE_FAILED = 8590,
        ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591,
        ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592,
        ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593,
        ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594,
        ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595,
        ERROR_DS_NO_MSDS_INTID = 8596,
        ERROR_DS_DUP_MSDS_INTID = 8597,
        ERROR_DS_EXISTS_IN_RDNATTID = 8598,
        ERROR_DS_AUTHORIZATION_FAILED = 8599,
        ERROR_DS_INVALID_SCRIPT = 8600,
        ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601,
        ERROR_DS_CROSS_REF_BUSY = 8602,
        ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603,
        ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604,
        ERROR_DS_DUPLICATE_ID_FOUND = 8605,
        ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606,
        ERROR_DS_GROUP_CONVERSION_ERROR = 8607,
        ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608,
        ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609,
        ERROR_DS_ROLE_NOT_VERIFIED = 8610,
        ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611,
        ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612,
        ERROR_DS_EXISTING_AD_CHILD_NC = 8613,
        ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614,
        ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615,
        ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616,
        ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617,
        DNS_ERROR_RESPONSE_CODES_BASE = 9000,
        DNS_ERROR_RCODE_NO_ERROR = 0,
        DNS_ERROR_MASK = 9000,
        DNS_ERROR_RCODE_FORMAT_ERROR = 9001,
        DNS_ERROR_RCODE_SERVER_FAILURE = 9002,
        DNS_ERROR_RCODE_NAME_ERROR = 9003,
        DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004,
        DNS_ERROR_RCODE_REFUSED = 9005,
        DNS_ERROR_RCODE_YXDOMAIN = 9006,
        DNS_ERROR_RCODE_YXRRSET = 9007,
        DNS_ERROR_RCODE_NXRRSET = 9008,
        DNS_ERROR_RCODE_NOTAUTH = 9009,
        DNS_ERROR_RCODE_NOTZONE = 9010,
        DNS_ERROR_RCODE_BADSIG = 9016,
        DNS_ERROR_RCODE_BADKEY = 9017,
        DNS_ERROR_RCODE_BADTIME = 9018,
        DNS_ERROR_RCODE_LAST = 9018,
        DNS_ERROR_PACKET_FMT_BASE = 9500,
        DNS_INFO_NO_RECORDS = 9501,
        DNS_ERROR_BAD_PACKET = 9502,
        DNS_ERROR_NO_PACKET = 9503,
        DNS_ERROR_RCODE = 9504,
        DNS_ERROR_UNSECURE_PACKET = 9505,
        DNS_STATUS_PACKET_UNSECURE = 9505,
        DNS_ERROR_NO_MEMORY = 14,
        DNS_ERROR_INVALID_NAME = 123,
        DNS_ERROR_INVALID_DATA = 13,
        DNS_ERROR_GENERAL_API_BASE = 9550,
        DNS_ERROR_INVALID_TYPE = 9551,
        DNS_ERROR_INVALID_IP_ADDRESS = 9552,
        DNS_ERROR_INVALID_PROPERTY = 9553,
        DNS_ERROR_TRY_AGAIN_LATER = 9554,
        DNS_ERROR_NOT_UNIQUE = 9555,
        DNS_ERROR_NON_RFC_NAME = 9556,
        DNS_STATUS_FQDN = 9557,
        DNS_STATUS_DOTTED_NAME = 9558,
        DNS_STATUS_SINGLE_PART_NAME = 9559,
        DNS_ERROR_INVALID_NAME_CHAR = 9560,
        DNS_ERROR_NUMERIC_NAME = 9561,
        DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562,
        DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563,
        DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564,
        DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565,
        DNS_ERROR_ZONE_BASE = 9600,
        DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601,
        DNS_ERROR_NO_ZONE_INFO = 9602,
        DNS_ERROR_INVALID_ZONE_OPERATION = 9603,
        DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604,
        DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605,
        DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606,
        DNS_ERROR_ZONE_LOCKED = 9607,
        DNS_ERROR_ZONE_CREATION_FAILED = 9608,
        DNS_ERROR_ZONE_ALREADY_EXISTS = 9609,
        DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610,
        DNS_ERROR_INVALID_ZONE_TYPE = 9611,
        DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612,
        DNS_ERROR_ZONE_NOT_SECONDARY = 9613,
        DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614,
        DNS_ERROR_WINS_INIT_FAILED = 9615,
        DNS_ERROR_NEED_WINS_SERVERS = 9616,
        DNS_ERROR_NBSTAT_INIT_FAILED = 9617,
        DNS_ERROR_SOA_DELETE_INVALID = 9618,
        DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619,
        DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620,
        DNS_ERROR_ZONE_IS_SHUTDOWN = 9621,
        DNS_ERROR_DATAFILE_BASE = 9650,
        DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651,
        DNS_ERROR_INVALID_DATAFILE_NAME = 9652,
        DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653,
        DNS_ERROR_FILE_WRITEBACK_FAILED = 9654,
        DNS_ERROR_DATAFILE_PARSING = 9655,
        DNS_ERROR_DATABASE_BASE = 9700,
        DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701,
        DNS_ERROR_RECORD_FORMAT = 9702,
        DNS_ERROR_NODE_CREATION_FAILED = 9703,
        DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704,
        DNS_ERROR_RECORD_TIMED_OUT = 9705,
        DNS_ERROR_NAME_NOT_IN_ZONE = 9706,
        DNS_ERROR_CNAME_LOOP = 9707,
        DNS_ERROR_NODE_IS_CNAME = 9708,
        DNS_ERROR_CNAME_COLLISION = 9709,
        DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710,
        DNS_ERROR_RECORD_ALREADY_EXISTS = 9711,
        DNS_ERROR_SECONDARY_DATA = 9712,
        DNS_ERROR_NO_CREATE_CACHE_DATA = 9713,
        DNS_ERROR_NAME_DOES_NOT_EXIST = 9714,
        DNS_WARNING_PTR_CREATE_FAILED = 9715,
        DNS_WARNING_DOMAIN_UNDELETED = 9716,
        DNS_ERROR_DS_UNAVAILABLE = 9717,
        DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718,
        DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719,
        DNS_ERROR_OPERATION_BASE = 9750,
        DNS_INFO_AXFR_COMPLETE = 9751,
        DNS_ERROR_AXFR = 9752,
        DNS_INFO_ADDED_LOCAL_WINS = 9753,
        DNS_ERROR_SECURE_BASE = 9800,
        DNS_STATUS_CONTINUE_NEEDED = 9801,
        DNS_ERROR_SETUP_BASE = 9850,
        DNS_ERROR_NO_TCPIP = 9851,
        DNS_ERROR_NO_DNS_SERVERS = 9852,
        DNS_ERROR_DP_BASE = 9900,
        DNS_ERROR_DP_DOES_NOT_EXIST = 9901,
        DNS_ERROR_DP_ALREADY_EXISTS = 9902,
        DNS_ERROR_DP_NOT_ENLISTED = 9903,
        DNS_ERROR_DP_ALREADY_ENLISTED = 9904,
        DNS_ERROR_DP_NOT_AVAILABLE = 9905,
        DNS_ERROR_DP_FSMO_ERROR = 9906,
        WSAEINTR = 10004,
        WSAEBADF = 10009,
        WSAEACCES = 10013,
        WSAEFAULT = 10014,
        WSAEINVAL = 10022,
        WSAEMFILE = 10024,
        WSAEWOULDBLOCK = 10035,
        WSAEINPROGRESS = 10036,
        WSAEALREADY = 10037,
        WSAENOTSOCK = 10038,
        WSAEDESTADDRREQ = 10039,
        WSAEMSGSIZE = 10040,
        WSAEPROTOTYPE = 10041,
        WSAENOPROTOOPT = 10042,
        WSAEPROTONOSUPPORT = 10043,
        WSAESOCKTNOSUPPORT = 10044,
        WSAEOPNOTSUPP = 10045,
        WSAEPFNOSUPPORT = 10046,
        WSAEAFNOSUPPORT = 10047,
        WSAEADDRINUSE = 10048,
        WSAEADDRNOTAVAIL = 10049,
        WSAENETDOWN = 10050,
        WSAENETUNREACH = 10051,
        WSAENETRESET = 10052,
        WSAECONNABORTED = 10053,
        WSAECONNRESET = 10054,
        WSAENOBUFS = 10055,
        WSAEISCONN = 10056,
        WSAENOTCONN = 10057,
        WSAESHUTDOWN = 10058,
        WSAETOOMANYREFS = 10059,
        WSAETIMEDOUT = 10060,
        WSAECONNREFUSED = 10061,
        WSAELOOP = 10062,
        WSAENAMETOOLONG = 10063,
        WSAEHOSTDOWN = 10064,
        WSAEHOSTUNREACH = 10065,
        WSAENOTEMPTY = 10066,
        WSAEPROCLIM = 10067,
        WSAEUSERS = 10068,
        WSAEDQUOT = 10069,
        WSAESTALE = 10070,
        WSAEREMOTE = 10071,
        WSASYSNOTREADY = 10091,
        WSAVERNOTSUPPORTED = 10092,
        WSANOTINITIALISED = 10093,
        WSAEDISCON = 10101,
        WSAENOMORE = 10102,
        WSAECANCELLED = 10103,
        WSAEINVALIDPROCTABLE = 10104,
        WSAEINVALIDPROVIDER = 10105,
        WSAEPROVIDERFAILEDINIT = 10106,
        WSASYSCALLFAILURE = 10107,
        WSASERVICE_NOT_FOUND = 10108,
        WSATYPE_NOT_FOUND = 10109,
        WSA_E_NO_MORE = 10110,
        WSA_E_CANCELLED = 10111,
        WSAEREFUSED = 10112,
        WSAHOST_NOT_FOUND = 11001,
        WSATRY_AGAIN = 11002,
        WSANO_RECOVERY = 11003,
        WSANO_DATA = 11004,
        WSA_QOS_RECEIVERS = 11005,
        WSA_QOS_SENDERS = 11006,
        WSA_QOS_NO_SENDERS = 11007,
        WSA_QOS_NO_RECEIVERS = 11008,
        WSA_QOS_REQUEST_CONFIRMED = 11009,
        WSA_QOS_ADMISSION_FAILURE = 11010,
        WSA_QOS_POLICY_FAILURE = 11011,
        WSA_QOS_BAD_STYLE = 11012,
        WSA_QOS_BAD_OBJECT = 11013,
        WSA_QOS_TRAFFIC_CTRL_ERROR = 11014,
        WSA_QOS_GENERIC_ERROR = 11015,
        WSA_QOS_ESERVICETYPE = 11016,
        WSA_QOS_EFLOWSPEC = 11017,
        WSA_QOS_EPROVSPECBUF = 11018,
        WSA_QOS_EFILTERSTYLE = 11019,
        WSA_QOS_EFILTERTYPE = 11020,
        WSA_QOS_EFILTERCOUNT = 11021,
        WSA_QOS_EOBJLENGTH = 11022,
        WSA_QOS_EFLOWCOUNT = 11023,
        WSA_QOS_EUNKOWNPSOBJ = 11024,
        WSA_QOS_EPOLICYOBJ = 11025,
        WSA_QOS_EFLOWDESC = 11026,
        WSA_QOS_EPSFLOWSPEC = 11027,
        WSA_QOS_EPSFILTERSPEC = 11028,
        WSA_QOS_ESDMODEOBJ = 11029,
        WSA_QOS_ESHAPERATEOBJ = 11030,
        WSA_QOS_RESERVED_PETYPE = 11031,
        ERROR_SXS_SECTION_NOT_FOUND = 14000,
        ERROR_SXS_CANT_GEN_ACTCTX = 14001,
        ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002,
        ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003,
        ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004,
        ERROR_SXS_MANIFEST_PARSE_ERROR = 14005,
        ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006,
        ERROR_SXS_KEY_NOT_FOUND = 14007,
        ERROR_SXS_VERSION_CONFLICT = 14008,
        ERROR_SXS_WRONG_SECTION_TYPE = 14009,
        ERROR_SXS_THREAD_QUERIES_DISABLED = 14010,
        ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011,
        ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012,
        ERROR_SXS_UNKNOWN_ENCODING = 14013,
        ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014,
        ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015,
        ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016,
        ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017,
        ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018,
        ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019,
        ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020,
        ERROR_SXS_DUPLICATE_DLL_NAME = 14021,
        ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022,
        ERROR_SXS_DUPLICATE_CLSID = 14023,
        ERROR_SXS_DUPLICATE_IID = 14024,
        ERROR_SXS_DUPLICATE_TLBID = 14025,
        ERROR_SXS_DUPLICATE_PROGID = 14026,
        ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027,
        ERROR_SXS_FILE_HASH_MISMATCH = 14028,
        ERROR_SXS_POLICY_PARSE_ERROR = 14029,
        ERROR_SXS_XML_E_MISSINGQUOTE = 14030,
        ERROR_SXS_XML_E_COMMENTSYNTAX = 14031,
        ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032,
        ERROR_SXS_XML_E_BADNAMECHAR = 14033,
        ERROR_SXS_XML_E_BADCHARINSTRING = 14034,
        ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035,
        ERROR_SXS_XML_E_BADCHARDATA = 14036,
        ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037,
        ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038,
        ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039,
        ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040,
        ERROR_SXS_XML_E_INTERNALERROR = 14041,
        ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042,
        ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043,
        ERROR_SXS_XML_E_MISSING_PAREN = 14044,
        ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045,
        ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046,
        ERROR_SXS_XML_E_INVALID_DECIMAL = 14047,
        ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048,
        ERROR_SXS_XML_E_INVALID_UNICODE = 14049,
        ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050,
        ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051,
        ERROR_SXS_XML_E_UNCLOSEDTAG = 14052,
        ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053,
        ERROR_SXS_XML_E_MULTIPLEROOTS = 14054,
        ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055,
        ERROR_SXS_XML_E_BADXMLDECL = 14056,
        ERROR_SXS_XML_E_MISSINGROOT = 14057,
        ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058,
        ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059,
        ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060,
        ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061,
        ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062,
        ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063,
        ERROR_SXS_XML_E_UNCLOSEDDECL = 14064,
        ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065,
        ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066,
        ERROR_SXS_XML_E_INVALIDENCODING = 14067,
        ERROR_SXS_XML_E_INVALIDSWITCH = 14068,
        ERROR_SXS_XML_E_BADXMLCASE = 14069,
        ERROR_SXS_XML_E_INVALID_STANDALONE = 14070,
        ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071,
        ERROR_SXS_XML_E_INVALID_VERSION = 14072,
        ERROR_SXS_XML_E_MISSINGEQUALS = 14073,
        ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074,
        ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075,
        ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076,
        ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077,
        ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078,
        ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079,
        ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080,
        ERROR_IPSEC_QM_POLICY_EXISTS = 13000,
        ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001,
        ERROR_IPSEC_QM_POLICY_IN_USE = 13002,
        ERROR_IPSEC_MM_POLICY_EXISTS = 13003,
        ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004,
        ERROR_IPSEC_MM_POLICY_IN_USE = 13005,
        ERROR_IPSEC_MM_FILTER_EXISTS = 13006,
        ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007,
        ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008,
        ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009,
        ERROR_IPSEC_MM_AUTH_EXISTS = 13010,
        ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011,
        ERROR_IPSEC_MM_AUTH_IN_USE = 13012,
        ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013,
        ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014,
        ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015,
        ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016,
        ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017,
        ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018,
        ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019,
        ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020,
        ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021,
        ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022,
        ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023,
        WARNING_IPSEC_MM_POLICY_PRUNED = 13024,
        WARNING_IPSEC_QM_POLICY_PRUNED = 13025,
        ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800,
        ERROR_IPSEC_IKE_AUTH_FAIL = 13801,
        ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802,
        ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803,
        ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804,
        ERROR_IPSEC_IKE_TIMED_OUT = 13805,
        ERROR_IPSEC_IKE_NO_CERT = 13806,
        ERROR_IPSEC_IKE_SA_DELETED = 13807,
        ERROR_IPSEC_IKE_SA_REAPED = 13808,
        ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809,
        ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810,
        ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811,
        ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812,
        ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813,
        ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814,
        ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815,
        ERROR_IPSEC_IKE_ERROR = 13816,
        ERROR_IPSEC_IKE_CRL_FAILED = 13817,
        ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818,
        ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819,
        ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820,
        ERROR_IPSEC_IKE_DH_FAIL = 13822,
        ERROR_IPSEC_IKE_INVALID_HEADER = 13824,
        ERROR_IPSEC_IKE_NO_POLICY = 13825,
        ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826,
        ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827,
        ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828,
        ERROR_IPSEC_IKE_PROCESS_ERR = 13829,
        ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830,
        ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831,
        ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832,
        ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833,
        ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834,
        ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835,
        ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836,
        ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837,
        ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838,
        ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839,
        ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840,
        ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841,
        ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842,
        ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843,
        ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844,
        ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845,
        ERROR_IPSEC_IKE_INVALID_COOKIE = 13846,
        ERROR_IPSEC_IKE_NO_PEER_CERT = 13847,
        ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848,
        ERROR_IPSEC_IKE_POLICY_CHANGE = 13849,
        ERROR_IPSEC_IKE_NO_MM_POLICY = 13850,
        ERROR_IPSEC_IKE_NOTCBPRIV = 13851,
        ERROR_IPSEC_IKE_SECLOADFAIL = 13852,
        ERROR_IPSEC_IKE_FAILSSPINIT = 13853,
        ERROR_IPSEC_IKE_FAILQUERYSSP = 13854,
        ERROR_IPSEC_IKE_SRVACQFAIL = 13855,
        ERROR_IPSEC_IKE_SRVQUERYCRED = 13856,
        ERROR_IPSEC_IKE_GETSPIFAIL = 13857,
        ERROR_IPSEC_IKE_INVALID_FILTER = 13858,
        ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859,
        ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860,
        ERROR_IPSEC_IKE_INVALID_POLICY = 13861,
        ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862,
        ERROR_IPSEC_IKE_INVALID_SITUATION = 13863,
        ERROR_IPSEC_IKE_DH_FAILURE = 13864,
        ERROR_IPSEC_IKE_INVALID_GROUP = 13865,
        ERROR_IPSEC_IKE_ENCRYPT = 13866,
        ERROR_IPSEC_IKE_DECRYPT = 13867,
        ERROR_IPSEC_IKE_POLICY_MATCH = 13868,
        ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869,
        ERROR_IPSEC_IKE_INVALID_HASH = 13870,
        ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871,
        ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872,
        ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873,
        ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874,
        ERROR_IPSEC_IKE_INVALID_SIG = 13875,
        ERROR_IPSEC_IKE_LOAD_FAILED = 13876,
        ERROR_IPSEC_IKE_RPC_DELETE = 13877,
        ERROR_IPSEC_IKE_BENIGN_REINIT = 13878,
        ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879,
        ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881,
        ERROR_IPSEC_IKE_MM_LIMIT = 13882,
        ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883,
        ERROR_IPSEC_IKE_NEG_STATUS_END = 13884,
        APPMODEL_ERROR_NO_PACKAGE = 15700,
        APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701,
        APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702,
        APPMODEL_ERROR_NO_APPLICATION = 15703,
        SEVERITY_SUCCESS = 0,
        SEVERITY_ERROR = 1,
        NOERROR = 0,
        E_UNEXPECTED = -2147418113,
        E_NOTIMPL = -2147467263,
        E_OUTOFMEMORY = -2147024882,
        E_INVALIDARG = -2147024809,
        E_NOINTERFACE = -2147467262,
        E_POINTER = -2147467261,
        E_HANDLE = -2147024890,
        E_ABORT = -2147467260,
        E_FAIL = -2147467259,
        E_ACCESSDENIED = -2147024891,
        E_PENDING = -2147483638,
        CO_E_INIT_TLS = -2147467258,
        CO_E_INIT_SHARED_ALLOCATOR = -2147467257,
        CO_E_INIT_MEMORY_ALLOCATOR = -2147467256,
        CO_E_INIT_CLASS_CACHE = -2147467255,
        CO_E_INIT_RPC_CHANNEL = -2147467254,
        CO_E_INIT_TLS_SET_CHANNEL_CONTROL = -2147467253,
        CO_E_INIT_TLS_CHANNEL_CONTROL = -2147467252,
        CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = -2147467251,
        CO_E_INIT_SCM_MUTEX_EXISTS = -2147467250,
        CO_E_INIT_SCM_FILE_MAPPING_EXISTS = -2147467249,
        CO_E_INIT_SCM_MAP_VIEW_OF_FILE = -2147467248,
        CO_E_INIT_SCM_EXEC_FAILURE = -2147467247,
        CO_E_INIT_ONLY_SINGLE_THREADED = -2147467246,
        CO_E_CANT_REMOTE = -2147467245,
        CO_E_BAD_SERVER_NAME = -2147467244,
        CO_E_WRONG_SERVER_IDENTITY = -2147467243,
        CO_E_OLE1DDE_DISABLED = -2147467242,
        CO_E_RUNAS_SYNTAX = -2147467241,
        CO_E_CREATEPROCESS_FAILURE = -2147467240,
        CO_E_RUNAS_CREATEPROCESS_FAILURE = -2147467239,
        CO_E_RUNAS_LOGON_FAILURE = -2147467238,
        CO_E_LAUNCH_PERMSSION_DENIED = -2147467237,
        CO_E_START_SERVICE_FAILURE = -2147467236,
        CO_E_REMOTE_COMMUNICATION_FAILURE = -2147467235,
        CO_E_SERVER_START_TIMEOUT = -2147467234,
        CO_E_CLSREG_INCONSISTENT = -2147467233,
        CO_E_IIDREG_INCONSISTENT = -2147467232,
        CO_E_NOT_SUPPORTED = -2147467231,
        CO_E_RELOAD_DLL = -2147467230,
        CO_E_MSI_ERROR = -2147467229,
        CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT = -2147467228,
        CO_E_SERVER_PAUSED = -2147467227,
        CO_E_SERVER_NOT_PAUSED = -2147467226,
        CO_E_CLASS_DISABLED = -2147467225,
        CO_E_CLRNOTAVAILABLE = -2147467224,
        CO_E_ASYNC_WORK_REJECTED = -2147467223,
        CO_E_SERVER_INIT_TIMEOUT = -2147467222,
        CO_E_NO_SECCTX_IN_ACTIVATE = -2147467221,
        CO_E_TRACKER_CONFIG = -2147467216,
        CO_E_THREADPOOL_CONFIG = -2147467215,
        CO_E_SXS_CONFIG = -2147467214,
        CO_E_MALFORMED_SPN = -2147467213,
        S_OK = 0,
        S_FALSE = 1,
        OLE_E_FIRST = -2147221504,
        OLE_E_LAST = -2147221249,
        OLE_S_FIRST = 262144,
        OLE_S_LAST = 262399,
        OLE_E_OLEVERB = -2147221504,
        OLE_E_ADVF = -2147221503,
        OLE_E_ENUM_NOMORE = -2147221502,
        OLE_E_ADVISENOTSUPPORTED = -2147221501,
        OLE_E_NOCONNECTION = -2147221500,
        OLE_E_NOTRUNNING = -2147221499,
        OLE_E_NOCACHE = -2147221498,
        OLE_E_BLANK = -2147221497,
        OLE_E_CLASSDIFF = -2147221496,
        OLE_E_CANT_GETMONIKER = -2147221495,
        OLE_E_CANT_BINDTOSOURCE = -2147221494,
        OLE_E_STATIC = -2147221493,
        OLE_E_PROMPTSAVECANCELLED = -2147221492,
        OLE_E_INVALIDRECT = -2147221491,
        OLE_E_WRONGCOMPOBJ = -2147221490,
        OLE_E_INVALIDHWND = -2147221489,
        OLE_E_NOT_INPLACEACTIVE = -2147221488,
        OLE_E_CANTCONVERT = -2147221487,
        OLE_E_NOSTORAGE = -2147221486,
        DV_E_FORMATETC = -2147221404,
        DV_E_DVTARGETDEVICE = -2147221403,
        DV_E_STGMEDIUM = -2147221402,
        DV_E_STATDATA = -2147221401,
        DV_E_LINDEX = -2147221400,
        DV_E_TYMED = -2147221399,
        DV_E_CLIPFORMAT = -2147221398,
        DV_E_DVASPECT = -2147221397,
        DV_E_DVTARGETDEVICE_SIZE = -2147221396,
        DV_E_NOIVIEWOBJECT = -2147221395,
        DRAGDROP_E_FIRST = -2147221248,
        DRAGDROP_E_LAST = -2147221233,
        DRAGDROP_S_FIRST = 262400,
        DRAGDROP_S_LAST = 262415,
        DRAGDROP_E_NOTREGISTERED = -2147221248,
        DRAGDROP_E_ALREADYREGISTERED = -2147221247,
        DRAGDROP_E_INVALIDHWND = -2147221246,
        CLASSFACTORY_E_FIRST = -2147221232,
        CLASSFACTORY_E_LAST = -2147221217,
        CLASSFACTORY_S_FIRST = 262416,
        CLASSFACTORY_S_LAST = 262431,
        CLASS_E_NOAGGREGATION = -2147221232,
        CLASS_E_CLASSNOTAVAILABLE = -2147221231,
        CLASS_E_NOTLICENSED = -2147221230,
        MARSHAL_E_FIRST = -2147221216,
        MARSHAL_E_LAST = -2147221201,
        MARSHAL_S_FIRST = 262432,
        MARSHAL_S_LAST = 262447,
        DATA_E_FIRST = -2147221200,
        DATA_E_LAST = -2147221185,
        DATA_S_FIRST = 262448,
        DATA_S_LAST = 262463,
        VIEW_E_FIRST = -2147221184,
        VIEW_E_LAST = -2147221169,
        VIEW_S_FIRST = 262464,
        VIEW_S_LAST = 262479,
        VIEW_E_DRAW = -2147221184,
        REGDB_E_FIRST = -2147221168,
        REGDB_E_LAST = -2147221153,
        REGDB_S_FIRST = 262480,
        REGDB_S_LAST = 262495,
        REGDB_E_READREGDB = -2147221168,
        REGDB_E_WRITEREGDB = -2147221167,
        REGDB_E_KEYMISSING = -2147221166,
        REGDB_E_INVALIDVALUE = -2147221165,
        REGDB_E_CLASSNOTREG = -2147221164,
        REGDB_E_IIDNOTREG = -2147221163,
        REGDB_E_BADTHREADINGMODEL = -2147221162,
        CAT_E_FIRST = -2147221152,
        CAT_E_LAST = -2147221151,
        CAT_E_CATIDNOEXIST = -2147221152,
        CAT_E_NODESCRIPTION = -2147221151,
        CS_E_FIRST = -2147221148,
        CS_E_LAST = -2147221137,
        CS_E_PACKAGE_NOTFOUND = -2147221148,
        CS_E_NOT_DELETABLE = -2147221147,
        CS_E_CLASS_NOTFOUND = -2147221146,
        CS_E_INVALID_VERSION = -2147221145,
        CS_E_NO_CLASSSTORE = -2147221144,
        CS_E_OBJECT_NOTFOUND = -2147221143,
        CS_E_OBJECT_ALREADY_EXISTS = -2147221142,
        CS_E_INVALID_PATH = -2147221141,
        CS_E_NETWORK_ERROR = -2147221140,
        CS_E_ADMIN_LIMIT_EXCEEDED = -2147221139,
        CS_E_SCHEMA_MISMATCH = -2147221138,
        CS_E_INTERNAL_ERROR = -2147221137,
        CACHE_E_FIRST = -2147221136,
        CACHE_E_LAST = -2147221121,
        CACHE_S_FIRST = 262512,
        CACHE_S_LAST = 262527,
        CACHE_E_NOCACHE_UPDATED = -2147221136,
        OLEOBJ_E_FIRST = -2147221120,
        OLEOBJ_E_LAST = -2147221105,
        OLEOBJ_S_FIRST = 262528,
        OLEOBJ_S_LAST = 262543,
        OLEOBJ_E_NOVERBS = -2147221120,
        OLEOBJ_E_INVALIDVERB = -2147221119,
        CLIENTSITE_E_FIRST = -2147221104,
        CLIENTSITE_E_LAST = -2147221089,
        CLIENTSITE_S_FIRST = 262544,
        CLIENTSITE_S_LAST = 262559,
        INPLACE_E_NOTUNDOABLE = -2147221088,
        INPLACE_E_NOTOOLSPACE = -2147221087,
        INPLACE_E_FIRST = -2147221088,
        INPLACE_E_LAST = -2147221073,
        INPLACE_S_FIRST = 262560,
        INPLACE_S_LAST = 262575,
        ENUM_E_FIRST = -2147221072,
        ENUM_E_LAST = -2147221057,
        ENUM_S_FIRST = 262576,
        ENUM_S_LAST = 262591,
        CONVERT10_E_FIRST = -2147221056,
        CONVERT10_E_LAST = -2147221041,
        CONVERT10_S_FIRST = 262592,
        CONVERT10_S_LAST = 262607,
        CONVERT10_E_OLESTREAM_GET = -2147221056,
        CONVERT10_E_OLESTREAM_PUT = -2147221055,
        CONVERT10_E_OLESTREAM_FMT = -2147221054,
        CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = -2147221053,
        CONVERT10_E_STG_FMT = -2147221052,
        CONVERT10_E_STG_NO_STD_STREAM = -2147221051,
        CONVERT10_E_STG_DIB_TO_BITMAP = -2147221050,
        CLIPBRD_E_FIRST = -2147221040,
        CLIPBRD_E_LAST = -2147221025,
        CLIPBRD_S_FIRST = 262608,
        CLIPBRD_S_LAST = 262623,
        CLIPBRD_E_CANT_OPEN = -2147221040,
        CLIPBRD_E_CANT_EMPTY = -2147221039,
        CLIPBRD_E_CANT_SET = -2147221038,
        CLIPBRD_E_BAD_DATA = -2147221037,
        CLIPBRD_E_CANT_CLOSE = -2147221036,
        MK_E_FIRST = -2147221024,
        MK_E_LAST = -2147221009,
        MK_S_FIRST = 262624,
        MK_S_LAST = 262639,
        MK_E_CONNECTMANUALLY = -2147221024,
        MK_E_EXCEEDEDDEADLINE = -2147221023,
        MK_E_NEEDGENERIC = -2147221022,
        MK_E_UNAVAILABLE = -2147221021,
        MK_E_SYNTAX = -2147221020,
        MK_E_NOOBJECT = -2147221019,
        MK_E_INVALIDEXTENSION = -2147221018,
        MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = -2147221017,
        MK_E_NOTBINDABLE = -2147221016,
        MK_E_NOTBOUND = -2147221015,
        MK_E_CANTOPENFILE = -2147221014,
        MK_E_MUSTBOTHERUSER = -2147221013,
        MK_E_NOINVERSE = -2147221012,
        MK_E_NOSTORAGE = -2147221011,
        MK_E_NOPREFIX = -2147221010,
        MK_E_ENUMERATION_FAILED = -2147221009,
        CO_E_FIRST = -2147221008,
        CO_E_LAST = -2147220993,
        CO_S_FIRST = 262640,
        CO_S_LAST = 262655,
        CO_E_NOTINITIALIZED = -2147221008,
        CO_E_ALREADYINITIALIZED = -2147221007,
        CO_E_CANTDETERMINECLASS = -2147221006,
        CO_E_CLASSSTRING = -2147221005,
        CO_E_IIDSTRING = -2147221004,
        CO_E_APPNOTFOUND = -2147221003,
        CO_E_APPSINGLEUSE = -2147221002,
        CO_E_ERRORINAPP = -2147221001,
        CO_E_DLLNOTFOUND = -2147221000,
        CO_E_ERRORINDLL = -2147220999,
        CO_E_WRONGOSFORAPP = -2147220998,
        CO_E_OBJNOTREG = -2147220997,
        CO_E_OBJISREG = -2147220996,
        CO_E_OBJNOTCONNECTED = -2147220995,
        CO_E_APPDIDNTREG = -2147220994,
        CO_E_RELEASED = -2147220993,
        EVENT_E_FIRST = -2147220992,
        EVENT_E_LAST = -2147220961,
        EVENT_S_FIRST = 262656,
        EVENT_S_LAST = 262687,
        EVENT_S_SOME_SUBSCRIBERS_FAILED = 262656,
        EVENT_E_ALL_SUBSCRIBERS_FAILED = -2147220991,
        EVENT_S_NOSUBSCRIBERS = 262658,
        EVENT_E_QUERYSYNTAX = -2147220989,
        EVENT_E_QUERYFIELD = -2147220988,
        EVENT_E_INTERNALEXCEPTION = -2147220987,
        EVENT_E_INTERNALERROR = -2147220986,
        EVENT_E_INVALID_PER_USER_SID = -2147220985,
        EVENT_E_USER_EXCEPTION = -2147220984,
        EVENT_E_TOO_MANY_METHODS = -2147220983,
        EVENT_E_MISSING_EVENTCLASS = -2147220982,
        EVENT_E_NOT_ALL_REMOVED = -2147220981,
        EVENT_E_COMPLUS_NOT_INSTALLED = -2147220980,
        EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = -2147220979,
        EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = -2147220978,
        EVENT_E_INVALID_EVENT_CLASS_PARTITION = -2147220977,
        EVENT_E_PER_USER_SID_NOT_LOGGED_ON = -2147220976,
        XACT_E_FIRST = -2147168256,
        XACT_E_LAST = -2147168215,
        XACT_S_FIRST = 315392,
        XACT_S_LAST = 315408,
        XACT_E_ALREADYOTHERSINGLEPHASE = -2147168256,
        XACT_E_CANTRETAIN = -2147168255,
        XACT_E_COMMITFAILED = -2147168254,
        XACT_E_COMMITPREVENTED = -2147168253,
        XACT_E_HEURISTICABORT = -2147168252,
        XACT_E_HEURISTICCOMMIT = -2147168251,
        XACT_E_HEURISTICDAMAGE = -2147168250,
        XACT_E_HEURISTICDANGER = -2147168249,
        XACT_E_ISOLATIONLEVEL = -2147168248,
        XACT_E_NOASYNC = -2147168247,
        XACT_E_NOENLIST = -2147168246,
        XACT_E_NOISORETAIN = -2147168245,
        XACT_E_NORESOURCE = -2147168244,
        XACT_E_NOTCURRENT = -2147168243,
        XACT_E_NOTRANSACTION = -2147168242,
        XACT_E_NOTSUPPORTED = -2147168241,
        XACT_E_UNKNOWNRMGRID = -2147168240,
        XACT_E_WRONGSTATE = -2147168239,
        XACT_E_WRONGUOW = -2147168238,
        XACT_E_XTIONEXISTS = -2147168237,
        XACT_E_NOIMPORTOBJECT = -2147168236,
        XACT_E_INVALIDCOOKIE = -2147168235,
        XACT_E_INDOUBT = -2147168234,
        XACT_E_NOTIMEOUT = -2147168233,
        XACT_E_ALREADYINPROGRESS = -2147168232,
        XACT_E_ABORTED = -2147168231,
        XACT_E_LOGFULL = -2147168230,
        XACT_E_TMNOTAVAILABLE = -2147168229,
        XACT_E_CONNECTION_DOWN = -2147168228,
        XACT_E_CONNECTION_DENIED = -2147168227,
        XACT_E_REENLISTTIMEOUT = -2147168226,
        XACT_E_TIP_CONNECT_FAILED = -2147168225,
        XACT_E_TIP_PROTOCOL_ERROR = -2147168224,
        XACT_E_TIP_PULL_FAILED = -2147168223,
        XACT_E_DEST_TMNOTAVAILABLE = -2147168222,
        XACT_E_TIP_DISABLED = -2147168221,
        XACT_E_NETWORK_TX_DISABLED = -2147168220,
        XACT_E_PARTNER_NETWORK_TX_DISABLED = -2147168219,
        XACT_E_XA_TX_DISABLED = -2147168218,
        XACT_E_UNABLE_TO_READ_DTC_CONFIG = -2147168217,
        XACT_E_UNABLE_TO_LOAD_DTC_PROXY = -2147168216,
        XACT_E_ABORTING = -2147168215,
        XACT_E_CLERKNOTFOUND = -2147168128,
        XACT_E_CLERKEXISTS = -2147168127,
        XACT_E_RECOVERYINPROGRESS = -2147168126,
        XACT_E_TRANSACTIONCLOSED = -2147168125,
        XACT_E_INVALIDLSN = -2147168124,
        XACT_E_REPLAYREQUEST = -2147168123,
        XACT_S_ASYNC = 315392,
        XACT_S_DEFECT = 315393,
        XACT_S_READONLY = 315394,
        XACT_S_SOMENORETAIN = 315395,
        XACT_S_OKINFORM = 315396,
        XACT_S_MADECHANGESCONTENT = 315397,
        XACT_S_MADECHANGESINFORM = 315398,
        XACT_S_ALLNORETAIN = 315399,
        XACT_S_ABORTING = 315400,
        XACT_S_SINGLEPHASE = 315401,
        XACT_S_LOCALLY_OK = 315402,
        XACT_S_LASTRESOURCEMANAGER = 315408,
        CONTEXT_E_FIRST = -2147164160,
        CONTEXT_E_LAST = -2147164113,
        CONTEXT_S_FIRST = 319488,
        CONTEXT_S_LAST = 319535,
        CONTEXT_E_ABORTED = -2147164158,
        CONTEXT_E_ABORTING = -2147164157,
        CONTEXT_E_NOCONTEXT = -2147164156,
        CONTEXT_E_WOULD_DEADLOCK = -2147164155,
        CONTEXT_E_SYNCH_TIMEOUT = -2147164154,
        CONTEXT_E_OLDREF = -2147164153,
        CONTEXT_E_ROLENOTFOUND = -2147164148,
        CONTEXT_E_TMNOTAVAILABLE = -2147164145,
        CO_E_ACTIVATIONFAILED = -2147164127,
        CO_E_ACTIVATIONFAILED_EVENTLOGGED = -2147164126,
        CO_E_ACTIVATIONFAILED_CATALOGERROR = -2147164125,
        CO_E_ACTIVATIONFAILED_TIMEOUT = -2147164124,
        CO_E_INITIALIZATIONFAILED = -2147164123,
        CONTEXT_E_NOJIT = -2147164122,
        CONTEXT_E_NOTRANSACTION = -2147164121,
        CO_E_THREADINGMODEL_CHANGED = -2147164120,
        CO_E_NOIISINTRINSICS = -2147164119,
        CO_E_NOCOOKIES = -2147164118,
        CO_E_DBERROR = -2147164117,
        CO_E_NOTPOOLED = -2147164116,
        CO_E_NOTCONSTRUCTED = -2147164115,
        CO_E_NOSYNCHRONIZATION = -2147164114,
        CO_E_ISOLEVELMISMATCH = -2147164113,
        OLE_S_USEREG = 262144,
        OLE_S_STATIC = 262145,
        OLE_S_MAC_CLIPFORMAT = 262146,
        DRAGDROP_S_DROP = 262400,
        DRAGDROP_S_CANCEL = 262401,
        DRAGDROP_S_USEDEFAULTCURSORS = 262402,
        DATA_S_SAMEFORMATETC = 262448,
        VIEW_S_ALREADY_FROZEN = 262464,
        CACHE_S_FORMATETC_NOTSUPPORTED = 262512,
        CACHE_S_SAMECACHE = 262513,
        CACHE_S_SOMECACHES_NOTUPDATED = 262514,
        OLEOBJ_S_INVALIDVERB = 262528,
        OLEOBJ_S_CANNOT_DOVERB_NOW = 262529,
        OLEOBJ_S_INVALIDHWND = 262530,
        INPLACE_S_TRUNCATED = 262560,
        CONVERT10_S_NO_PRESENTATION = 262592,
        MK_S_REDUCED_TO_SELF = 262626,
        MK_S_ME = 262628,
        MK_S_HIM = 262629,
        MK_S_US = 262630,
        MK_S_MONIKERALREADYREGISTERED = 262631,
        SCHED_S_TASK_READY = 267008,
        SCHED_S_TASK_RUNNING = 267009,
        SCHED_S_TASK_DISABLED = 267010,
        SCHED_S_TASK_HAS_NOT_RUN = 267011,
        SCHED_S_TASK_NO_MORE_RUNS = 267012,
        SCHED_S_TASK_NOT_SCHEDULED = 267013,
        SCHED_S_TASK_TERMINATED = 267014,
        SCHED_S_TASK_NO_VALID_TRIGGERS = 267015,
        SCHED_S_EVENT_TRIGGER = 267016,
        SCHED_E_TRIGGER_NOT_FOUND = -2147216631,
        SCHED_E_TASK_NOT_READY = -2147216630,
        SCHED_E_TASK_NOT_RUNNING = -2147216629,
        SCHED_E_SERVICE_NOT_INSTALLED = -2147216628,
        SCHED_E_CANNOT_OPEN_TASK = -2147216627,
        SCHED_E_INVALID_TASK = -2147216626,
        SCHED_E_ACCOUNT_INFORMATION_NOT_SET = -2147216625,
        SCHED_E_ACCOUNT_NAME_NOT_FOUND = -2147216624,
        SCHED_E_ACCOUNT_DBASE_CORRUPT = -2147216623,
        SCHED_E_NO_SECURITY_SERVICES = -2147216622,
        SCHED_E_UNKNOWN_OBJECT_VERSION = -2147216621,
        SCHED_E_UNSUPPORTED_ACCOUNT_OPTION = -2147216620,
        SCHED_E_SERVICE_NOT_RUNNING = -2147216619,
        CO_E_CLASS_CREATE_FAILED = -2146959359,
        CO_E_SCM_ERROR = -2146959358,
        CO_E_SCM_RPC_FAILURE = -2146959357,
        CO_E_BAD_PATH = -2146959356,
        CO_E_SERVER_EXEC_FAILURE = -2146959355,
        CO_E_OBJSRV_RPC_FAILURE = -2146959354,
        MK_E_NO_NORMALIZED = -2146959353,
        CO_E_SERVER_STOPPING = -2146959352,
        MEM_E_INVALID_ROOT = -2146959351,
        MEM_E_INVALID_LINK = -2146959344,
        MEM_E_INVALID_SIZE = -2146959343,
        CO_S_NOTALLINTERFACES = 524306,
        CO_S_MACHINENAMENOTFOUND = 524307,
        DISP_E_UNKNOWNINTERFACE = -2147352575,
        DISP_E_MEMBERNOTFOUND = -2147352573,
        DISP_E_PARAMNOTFOUND = -2147352572,
        DISP_E_TYPEMISMATCH = -2147352571,
        DISP_E_UNKNOWNNAME = -2147352570,
        DISP_E_NONAMEDARGS = -2147352569,
        DISP_E_BADVARTYPE = -2147352568,
        DISP_E_EXCEPTION = -2147352567,
        DISP_E_OVERFLOW = -2147352566,
        DISP_E_BADINDEX = -2147352565,
        DISP_E_UNKNOWNLCID = -2147352564,
        DISP_E_ARRAYISLOCKED = -2147352563,
        DISP_E_BADPARAMCOUNT = -2147352562,
        DISP_E_PARAMNOTOPTIONAL = -2147352561,
        DISP_E_BADCALLEE = -2147352560,
        DISP_E_NOTACOLLECTION = -2147352559,
        DISP_E_DIVBYZERO = -2147352558,
        DISP_E_BUFFERTOOSMALL = -2147352557,
        TYPE_E_BUFFERTOOSMALL = -2147319786,
        TYPE_E_FIELDNOTFOUND = -2147319785,
        TYPE_E_INVDATAREAD = -2147319784,
        TYPE_E_UNSUPFORMAT = -2147319783,
        TYPE_E_REGISTRYACCESS = -2147319780,
        TYPE_E_LIBNOTREGISTERED = -2147319779,
        TYPE_E_UNDEFINEDTYPE = -2147319769,
        TYPE_E_QUALIFIEDNAMEDISALLOWED = -2147319768,
        TYPE_E_INVALIDSTATE = -2147319767,
        TYPE_E_WRONGTYPEKIND = -2147319766,
        TYPE_E_ELEMENTNOTFOUND = -2147319765,
        TYPE_E_AMBIGUOUSNAME = -2147319764,
        TYPE_E_NAMECONFLICT = -2147319763,
        TYPE_E_UNKNOWNLCID = -2147319762,
        TYPE_E_DLLFUNCTIONNOTFOUND = -2147319761,
        TYPE_E_BADMODULEKIND = -2147317571,
        TYPE_E_SIZETOOBIG = -2147317563,
        TYPE_E_DUPLICATEID = -2147317562,
        TYPE_E_INVALIDID = -2147317553,
        TYPE_E_TYPEMISMATCH = -2147316576,
        TYPE_E_OUTOFBOUNDS = -2147316575,
        TYPE_E_IOERROR = -2147316574,
        TYPE_E_CANTCREATETMPFILE = -2147316573,
        TYPE_E_CANTLOADLIBRARY = -2147312566,
        TYPE_E_INCONSISTENTPROPFUNCS = -2147312509,
        TYPE_E_CIRCULARTYPE = -2147312508,
        STG_E_INVALIDFUNCTION = -2147287039,
        STG_E_FILENOTFOUND = -2147287038,
        STG_E_PATHNOTFOUND = -2147287037,
        STG_E_TOOMANYOPENFILES = -2147287036,
        STG_E_ACCESSDENIED = -2147287035,
        STG_E_INVALIDHANDLE = -2147287034,
        STG_E_INSUFFICIENTMEMORY = -2147287032,
        STG_E_INVALIDPOINTER = -2147287031,
        STG_E_NOMOREFILES = -2147287022,
        STG_E_DISKISWRITEPROTECTED = -2147287021,
        STG_E_SEEKERROR = -2147287015,
        STG_E_WRITEFAULT = -2147287011,
        STG_E_READFAULT = -2147287010,
        STG_E_SHAREVIOLATION = -2147287008,
        STG_E_LOCKVIOLATION = -2147287007,
        STG_E_FILEALREADYEXISTS = -2147286960,
        STG_E_INVALIDPARAMETER = -2147286953,
        STG_E_MEDIUMFULL = -2147286928,
        STG_E_PROPSETMISMATCHED = -2147286800,
        STG_E_ABNORMALAPIEXIT = -2147286790,
        STG_E_INVALIDHEADER = -2147286789,
        STG_E_INVALIDNAME = -2147286788,
        STG_E_UNKNOWN = -2147286787,
        STG_E_UNIMPLEMENTEDFUNCTION = -2147286786,
        STG_E_INVALIDFLAG = -2147286785,
        STG_E_INUSE = -2147286784,
        STG_E_NOTCURRENT = -2147286783,
        STG_E_REVERTED = -2147286782,
        STG_E_CANTSAVE = -2147286781,
        STG_E_OLDFORMAT = -2147286780,
        STG_E_OLDDLL = -2147286779,
        STG_E_SHAREREQUIRED = -2147286778,
        STG_E_NOTFILEBASEDSTORAGE = -2147286777,
        STG_E_EXTANTMARSHALLINGS = -2147286776,
        STG_E_DOCFILECORRUPT = -2147286775,
        STG_E_BADBASEADDRESS = -2147286768,
        STG_E_DOCFILETOOLARGE = -2147286767,
        STG_E_NOTSIMPLEFORMAT = -2147286766,
        STG_E_INCOMPLETE = -2147286527,
        STG_E_TERMINATED = -2147286526,
        STG_S_CONVERTED = 197120,
        STG_S_BLOCK = 197121,
        STG_S_RETRYNOW = 197122,
        STG_S_MONITORING = 197123,
        STG_S_MULTIPLEOPENS = 197124,
        STG_S_CONSOLIDATIONFAILED = 197125,
        STG_S_CANNOTCONSOLIDATE = 197126,
        STG_E_STATUS_COPY_PROTECTION_FAILURE = -2147286267,
        STG_E_CSS_AUTHENTICATION_FAILURE = -2147286266,
        STG_E_CSS_KEY_NOT_PRESENT = -2147286265,
        STG_E_CSS_KEY_NOT_ESTABLISHED = -2147286264,
        STG_E_CSS_SCRAMBLED_SECTOR = -2147286263,
        STG_E_CSS_REGION_MISMATCH = -2147286262,
        STG_E_RESETS_EXHAUSTED = -2147286261,
        RPC_E_CALL_REJECTED = -2147418111,
        RPC_E_CALL_CANCELED = -2147418110,
        RPC_E_CANTPOST_INSENDCALL = -2147418109,
        RPC_E_CANTCALLOUT_INASYNCCALL = -2147418108,
        RPC_E_CANTCALLOUT_INEXTERNALCALL = -2147418107,
        RPC_E_CONNECTION_TERMINATED = -2147418106,
        RPC_E_SERVER_DIED = -2147418105,
        RPC_E_CLIENT_DIED = -2147418104,
        RPC_E_INVALID_DATAPACKET = -2147418103,
        RPC_E_CANTTRANSMIT_CALL = -2147418102,
        RPC_E_CLIENT_CANTMARSHAL_DATA = -2147418101,
        RPC_E_CLIENT_CANTUNMARSHAL_DATA = -2147418100,
        RPC_E_SERVER_CANTMARSHAL_DATA = -2147418099,
        RPC_E_SERVER_CANTUNMARSHAL_DATA = -2147418098,
        RPC_E_INVALID_DATA = -2147418097,
        RPC_E_INVALID_PARAMETER = -2147418096,
        RPC_E_CANTCALLOUT_AGAIN = -2147418095,
        RPC_E_SERVER_DIED_DNE = -2147418094,
        RPC_E_SYS_CALL_FAILED = -2147417856,
        RPC_E_OUT_OF_RESOURCES = -2147417855,
        RPC_E_ATTEMPTED_MULTITHREAD = -2147417854,
        RPC_E_NOT_REGISTERED = -2147417853,
        RPC_E_FAULT = -2147417852,
        RPC_E_SERVERFAULT = -2147417851,
        RPC_E_CHANGED_MODE = -2147417850,
        RPC_E_INVALIDMETHOD = -2147417849,
        RPC_E_DISCONNECTED = -2147417848,
        RPC_E_RETRY = -2147417847,
        RPC_E_SERVERCALL_RETRYLATER = -2147417846,
        RPC_E_SERVERCALL_REJECTED = -2147417845,
        RPC_E_INVALID_CALLDATA = -2147417844,
        RPC_E_CANTCALLOUT_ININPUTSYNCCALL = -2147417843,
        RPC_E_WRONG_THREAD = -2147417842,
        RPC_E_THREAD_NOT_INIT = -2147417841,
        RPC_E_VERSION_MISMATCH = -2147417840,
        RPC_E_INVALID_HEADER = -2147417839,
        RPC_E_INVALID_EXTENSION = -2147417838,
        RPC_E_INVALID_IPID = -2147417837,
        RPC_E_INVALID_OBJECT = -2147417836,
        RPC_S_CALLPENDING = -2147417835,
        RPC_S_WAITONTIMER = -2147417834,
        RPC_E_CALL_COMPLETE = -2147417833,
        RPC_E_UNSECURE_CALL = -2147417832,
        RPC_E_TOO_LATE = -2147417831,
        RPC_E_NO_GOOD_SECURITY_PACKAGES = -2147417830,
        RPC_E_ACCESS_DENIED = -2147417829,
        RPC_E_REMOTE_DISABLED = -2147417828,
        RPC_E_INVALID_OBJREF = -2147417827,
        RPC_E_NO_CONTEXT = -2147417826,
        RPC_E_TIMEOUT = -2147417825,
        RPC_E_NO_SYNC = -2147417824,
        RPC_E_FULLSIC_REQUIRED = -2147417823,
        RPC_E_INVALID_STD_NAME = -2147417822,
        CO_E_FAILEDTOIMPERSONATE = -2147417821,
        CO_E_FAILEDTOGETSECCTX = -2147417820,
        CO_E_FAILEDTOOPENTHREADTOKEN = -2147417819,
        CO_E_FAILEDTOGETTOKENINFO = -2147417818,
        CO_E_TRUSTEEDOESNTMATCHCLIENT = -2147417817,
        CO_E_FAILEDTOQUERYCLIENTBLANKET = -2147417816,
        CO_E_FAILEDTOSETDACL = -2147417815,
        CO_E_ACCESSCHECKFAILED = -2147417814,
        CO_E_NETACCESSAPIFAILED = -2147417813,
        CO_E_WRONGTRUSTEENAMESYNTAX = -2147417812,
        CO_E_INVALIDSID = -2147417811,
        CO_E_CONVERSIONFAILED = -2147417810,
        CO_E_NOMATCHINGSIDFOUND = -2147417809,
        CO_E_LOOKUPACCSIDFAILED = -2147417808,
        CO_E_NOMATCHINGNAMEFOUND = -2147417807,
        CO_E_LOOKUPACCNAMEFAILED = -2147417806,
        CO_E_SETSERLHNDLFAILED = -2147417805,
        CO_E_FAILEDTOGETWINDIR = -2147417804,
        CO_E_PATHTOOLONG = -2147417803,
        CO_E_FAILEDTOGENUUID = -2147417802,
        CO_E_FAILEDTOCREATEFILE = -2147417801,
        CO_E_FAILEDTOCLOSEHANDLE = -2147417800,
        CO_E_EXCEEDSYSACLLIMIT = -2147417799,
        CO_E_ACESINWRONGORDER = -2147417798,
        CO_E_INCOMPATIBLESTREAMVERSION = -2147417797,
        CO_E_FAILEDTOOPENPROCESSTOKEN = -2147417796,
        CO_E_DECODEFAILED = -2147417795,
        CO_E_ACNOTINITIALIZED = -2147417793,
        CO_E_CANCEL_DISABLED = -2147417792,
        RPC_E_UNEXPECTED = -2147352577,
        ERROR_AUDITING_DISABLED = -1073151999,
        ERROR_ALL_SIDS_FILTERED = -1073151998,
        NTE_BAD_UID = -2146893823,
        NTE_BAD_HASH = -2146893822,
        NTE_BAD_KEY = -2146893821,
        NTE_BAD_LEN = -2146893820,
        NTE_BAD_DATA = -2146893819,
        NTE_BAD_SIGNATURE = -2146893818,
        NTE_BAD_VER = -2146893817,
        NTE_BAD_ALGID = -2146893816,
        NTE_BAD_FLAGS = -2146893815,
        NTE_BAD_TYPE = -2146893814,
        NTE_BAD_KEY_STATE = -2146893813,
        NTE_BAD_HASH_STATE = -2146893812,
        NTE_NO_KEY = -2146893811,
        NTE_NO_MEMORY = -2146893810,
        NTE_EXISTS = -2146893809,
        NTE_PERM = -2146893808,
        NTE_NOT_FOUND = -2146893807,
        NTE_DOUBLE_ENCRYPT = -2146893806,
        NTE_BAD_PROVIDER = -2146893805,
        NTE_BAD_PROV_TYPE = -2146893804,
        NTE_BAD_PUBLIC_KEY = -2146893803,
        NTE_BAD_KEYSET = -2146893802,
        NTE_PROV_TYPE_NOT_DEF = -2146893801,
        NTE_PROV_TYPE_ENTRY_BAD = -2146893800,
        NTE_KEYSET_NOT_DEF = -2146893799,
        NTE_KEYSET_ENTRY_BAD = -2146893798,
        NTE_PROV_TYPE_NO_MATCH = -2146893797,
        NTE_SIGNATURE_FILE_BAD = -2146893796,
        NTE_PROVIDER_DLL_FAIL = -2146893795,
        NTE_PROV_DLL_NOT_FOUND = -2146893794,
        NTE_BAD_KEYSET_PARAM = -2146893793,
        NTE_FAIL = -2146893792,
        NTE_SYS_ERR = -2146893791,
        NTE_SILENT_CONTEXT = -2146893790,
        NTE_TOKEN_KEYSET_STORAGE_FULL = -2146893789,
        NTE_TEMPORARY_PROFILE = -2146893788,
        NTE_FIXEDPARAMETER = -2146893787,
        SEC_E_INSUFFICIENT_MEMORY = -2146893056,
        SEC_E_INVALID_HANDLE = -2146893055,
        SEC_E_UNSUPPORTED_FUNCTION = -2146893054,
        SEC_E_TARGET_UNKNOWN = -2146893053,
        SEC_E_INTERNAL_ERROR = -2146893052,
        SEC_E_SECPKG_NOT_FOUND = -2146893051,
        SEC_E_NOT_OWNER = -2146893050,
        SEC_E_CANNOT_INSTALL = -2146893049,
        SEC_E_INVALID_TOKEN = -2146893048,
        SEC_E_CANNOT_PACK = -2146893047,
        SEC_E_QOP_NOT_SUPPORTED = -2146893046,
        SEC_E_NO_IMPERSONATION = -2146893045,
        SEC_E_LOGON_DENIED = -2146893044,
        SEC_E_UNKNOWN_CREDENTIALS = -2146893043,
        SEC_E_NO_CREDENTIALS = -2146893042,
        SEC_E_MESSAGE_ALTERED = -2146893041,
        SEC_E_OUT_OF_SEQUENCE = -2146893040,
        SEC_E_NO_AUTHENTICATING_AUTHORITY = -2146893039,
        SEC_I_CONTINUE_NEEDED = 590610,
        SEC_I_COMPLETE_NEEDED = 590611,
        SEC_I_COMPLETE_AND_CONTINUE = 590612,
        SEC_I_LOCAL_LOGON = 590613,
        SEC_E_BAD_PKGID = -2146893034,
        SEC_E_CONTEXT_EXPIRED = -2146893033,
        SEC_I_CONTEXT_EXPIRED = 590615,
        SEC_E_INCOMPLETE_MESSAGE = -2146893032,
        SEC_E_INCOMPLETE_CREDENTIALS = -2146893024,
        SEC_E_BUFFER_TOO_SMALL = -2146893023,
        SEC_I_INCOMPLETE_CREDENTIALS = 590624,
        SEC_I_RENEGOTIATE = 590625,
        SEC_E_WRONG_PRINCIPAL = -2146893022,
        SEC_I_NO_LSA_CONTEXT = 590627,
        SEC_E_TIME_SKEW = -2146893020,
        SEC_E_UNTRUSTED_ROOT = -2146893019,
        SEC_E_ILLEGAL_MESSAGE = -2146893018,
        SEC_E_CERT_UNKNOWN = -2146893017,
        SEC_E_CERT_EXPIRED = -2146893016,
        SEC_E_ENCRYPT_FAILURE = -2146893015,
        SEC_E_DECRYPT_FAILURE = -2146893008,
        SEC_E_ALGORITHM_MISMATCH = -2146893007,
        SEC_E_SECURITY_QOS_FAILED = -2146893006,
        SEC_E_UNFINISHED_CONTEXT_DELETED = -2146893005,
        SEC_E_NO_TGT_REPLY = -2146893004,
        SEC_E_NO_IP_ADDRESSES = -2146893003,
        SEC_E_WRONG_CREDENTIAL_HANDLE = -2146893002,
        SEC_E_CRYPTO_SYSTEM_INVALID = -2146893001,
        SEC_E_MAX_REFERRALS_EXCEEDED = -2146893000,
        SEC_E_MUST_BE_KDC = -2146892999,
        SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = -2146892998,
        SEC_E_TOO_MANY_PRINCIPALS = -2146892997,
        SEC_E_NO_PA_DATA = -2146892996,
        SEC_E_PKINIT_NAME_MISMATCH = -2146892995,
        SEC_E_SMARTCARD_LOGON_REQUIRED = -2146892994,
        SEC_E_SHUTDOWN_IN_PROGRESS = -2146892993,
        SEC_E_KDC_INVALID_REQUEST = -2146892992,
        SEC_E_KDC_UNABLE_TO_REFER = -2146892991,
        SEC_E_KDC_UNKNOWN_ETYPE = -2146892990,
        SEC_E_UNSUPPORTED_PREAUTH = -2146892989,
        SEC_E_DELEGATION_REQUIRED = -2146892987,
        SEC_E_BAD_BINDINGS = -2146892986,
        SEC_E_MULTIPLE_ACCOUNTS = -2146892985,
        SEC_E_NO_KERB_KEY = -2146892984,
        SEC_E_CERT_WRONG_USAGE = -2146892983,
        SEC_E_DOWNGRADE_DETECTED = -2146892976,
        SEC_E_SMARTCARD_CERT_REVOKED = -2146892975,
        SEC_E_ISSUING_CA_UNTRUSTED = -2146892974,
        SEC_E_REVOCATION_OFFLINE_C = -2146892973,
        SEC_E_PKINIT_CLIENT_FAILURE = -2146892972,
        SEC_E_SMARTCARD_CERT_EXPIRED = -2146892971,
        SEC_E_NO_S4U_PROT_SUPPORT = -2146892970,
        SEC_E_CROSSREALM_DELEGATION_FAILURE = -2146892969,
        SEC_E_REVOCATION_OFFLINE_KDC = -2146892968,
        SEC_E_ISSUING_CA_UNTRUSTED_KDC = -2146892967,
        SEC_E_KDC_CERT_EXPIRED = -2146892966,
        SEC_E_KDC_CERT_REVOKED = -2146892965,
        SEC_E_NO_SPM = -2146893052,
        SEC_E_NOT_SUPPORTED = -2146893054,
        CRYPT_E_MSG_ERROR = -2146889727,
        CRYPT_E_UNKNOWN_ALGO = -2146889726,
        CRYPT_E_OID_FORMAT = -2146889725,
        CRYPT_E_INVALID_MSG_TYPE = -2146889724,
        CRYPT_E_UNEXPECTED_ENCODING = -2146889723,
        CRYPT_E_AUTH_ATTR_MISSING = -2146889722,
        CRYPT_E_HASH_VALUE = -2146889721,
        CRYPT_E_INVALID_INDEX = -2146889720,
        CRYPT_E_ALREADY_DECRYPTED = -2146889719,
        CRYPT_E_NOT_DECRYPTED = -2146889718,
        CRYPT_E_RECIPIENT_NOT_FOUND = -2146889717,
        CRYPT_E_CONTROL_TYPE = -2146889716,
        CRYPT_E_ISSUER_SERIALNUMBER = -2146889715,
        CRYPT_E_SIGNER_NOT_FOUND = -2146889714,
        CRYPT_E_ATTRIBUTES_MISSING = -2146889713,
        CRYPT_E_STREAM_MSG_NOT_READY = -2146889712,
        CRYPT_E_STREAM_INSUFFICIENT_DATA = -2146889711,
        CRYPT_I_NEW_PROTECTION_REQUIRED = 593938,
        CRYPT_E_BAD_LEN = -2146885631,
        CRYPT_E_BAD_ENCODE = -2146885630,
        CRYPT_E_FILE_ERROR = -2146885629,
        CRYPT_E_NOT_FOUND = -2146885628,
        CRYPT_E_EXISTS = -2146885627,
        CRYPT_E_NO_PROVIDER = -2146885626,
        CRYPT_E_SELF_SIGNED = -2146885625,
        CRYPT_E_DELETED_PREV = -2146885624,
        CRYPT_E_NO_MATCH = -2146885623,
        CRYPT_E_UNEXPECTED_MSG_TYPE = -2146885622,
        CRYPT_E_NO_KEY_PROPERTY = -2146885621,
        CRYPT_E_NO_DECRYPT_CERT = -2146885620,
        CRYPT_E_BAD_MSG = -2146885619,
        CRYPT_E_NO_SIGNER = -2146885618,
        CRYPT_E_PENDING_CLOSE = -2146885617,
        CRYPT_E_REVOKED = -2146885616,
        CRYPT_E_NO_REVOCATION_DLL = -2146885615,
        CRYPT_E_NO_REVOCATION_CHECK = -2146885614,
        CRYPT_E_REVOCATION_OFFLINE = -2146885613,
        CRYPT_E_NOT_IN_REVOCATION_DATABASE = -2146885612,
        CRYPT_E_INVALID_NUMERIC_STRING = -2146885600,
        CRYPT_E_INVALID_PRINTABLE_STRING = -2146885599,
        CRYPT_E_INVALID_IA5_STRING = -2146885598,
        CRYPT_E_INVALID_X500_STRING = -2146885597,
        CRYPT_E_NOT_CHAR_STRING = -2146885596,
        CRYPT_E_FILERESIZED = -2146885595,
        CRYPT_E_SECURITY_SETTINGS = -2146885594,
        CRYPT_E_NO_VERIFY_USAGE_DLL = -2146885593,
        CRYPT_E_NO_VERIFY_USAGE_CHECK = -2146885592,
        CRYPT_E_VERIFY_USAGE_OFFLINE = -2146885591,
        CRYPT_E_NOT_IN_CTL = -2146885590,
        CRYPT_E_NO_TRUSTED_SIGNER = -2146885589,
        CRYPT_E_MISSING_PUBKEY_PARA = -2146885588,
        CRYPT_E_OSS_ERROR = -2146881536,
        OSS_MORE_BUF = -2146881535,
        OSS_NEGATIVE_UINTEGER = -2146881534,
        OSS_PDU_RANGE = -2146881533,
        OSS_MORE_INPUT = -2146881532,
        OSS_DATA_ERROR = -2146881531,
        OSS_BAD_ARG = -2146881530,
        OSS_BAD_VERSION = -2146881529,
        OSS_OUT_MEMORY = -2146881528,
        OSS_PDU_MISMATCH = -2146881527,
        OSS_LIMITED = -2146881526,
        OSS_BAD_PTR = -2146881525,
        OSS_BAD_TIME = -2146881524,
        OSS_INDEFINITE_NOT_SUPPORTED = -2146881523,
        OSS_MEM_ERROR = -2146881522,
        OSS_BAD_TABLE = -2146881521,
        OSS_TOO_LONG = -2146881520,
        OSS_CONSTRAINT_VIOLATED = -2146881519,
        OSS_FATAL_ERROR = -2146881518,
        OSS_ACCESS_SERIALIZATION_ERROR = -2146881517,
        OSS_NULL_TBL = -2146881516,
        OSS_NULL_FCN = -2146881515,
        OSS_BAD_ENCRULES = -2146881514,
        OSS_UNAVAIL_ENCRULES = -2146881513,
        OSS_CANT_OPEN_TRACE_WINDOW = -2146881512,
        OSS_UNIMPLEMENTED = -2146881511,
        OSS_OID_DLL_NOT_LINKED = -2146881510,
        OSS_CANT_OPEN_TRACE_FILE = -2146881509,
        OSS_TRACE_FILE_ALREADY_OPEN = -2146881508,
        OSS_TABLE_MISMATCH = -2146881507,
        OSS_TYPE_NOT_SUPPORTED = -2146881506,
        OSS_REAL_DLL_NOT_LINKED = -2146881505,
        OSS_REAL_CODE_NOT_LINKED = -2146881504,
        OSS_OUT_OF_RANGE = -2146881503,
        OSS_COPIER_DLL_NOT_LINKED = -2146881502,
        OSS_CONSTRAINT_DLL_NOT_LINKED = -2146881501,
        OSS_COMPARATOR_DLL_NOT_LINKED = -2146881500,
        OSS_COMPARATOR_CODE_NOT_LINKED = -2146881499,
        OSS_MEM_MGR_DLL_NOT_LINKED = -2146881498,
        OSS_PDV_DLL_NOT_LINKED = -2146881497,
        OSS_PDV_CODE_NOT_LINKED = -2146881496,
        OSS_API_DLL_NOT_LINKED = -2146881495,
        OSS_BERDER_DLL_NOT_LINKED = -2146881494,
        OSS_PER_DLL_NOT_LINKED = -2146881493,
        OSS_OPEN_TYPE_ERROR = -2146881492,
        OSS_MUTEX_NOT_CREATED = -2146881491,
        OSS_CANT_CLOSE_TRACE_FILE = -2146881490,
        CRYPT_E_ASN1_ERROR = -2146881280,
        CRYPT_E_ASN1_INTERNAL = -2146881279,
        CRYPT_E_ASN1_EOD = -2146881278,
        CRYPT_E_ASN1_CORRUPT = -2146881277,
        CRYPT_E_ASN1_LARGE = -2146881276,
        CRYPT_E_ASN1_CONSTRAINT = -2146881275,
        CRYPT_E_ASN1_MEMORY = -2146881274,
        CRYPT_E_ASN1_OVERFLOW = -2146881273,
        CRYPT_E_ASN1_BADPDU = -2146881272,
        CRYPT_E_ASN1_BADARGS = -2146881271,
        CRYPT_E_ASN1_BADREAL = -2146881270,
        CRYPT_E_ASN1_BADTAG = -2146881269,
        CRYPT_E_ASN1_CHOICE = -2146881268,
        CRYPT_E_ASN1_RULE = -2146881267,
        CRYPT_E_ASN1_UTF8 = -2146881266,
        CRYPT_E_ASN1_PDU_TYPE = -2146881229,
        CRYPT_E_ASN1_NYI = -2146881228,
        CRYPT_E_ASN1_EXTENDED = -2146881023,
        CRYPT_E_ASN1_NOEOD = -2146881022,
        CERTSRV_E_BAD_REQUESTSUBJECT = -2146877439,
        CERTSRV_E_NO_REQUEST = -2146877438,
        CERTSRV_E_BAD_REQUESTSTATUS = -2146877437,
        CERTSRV_E_PROPERTY_EMPTY = -2146877436,
        CERTSRV_E_INVALID_CA_CERTIFICATE = -2146877435,
        CERTSRV_E_SERVER_SUSPENDED = -2146877434,
        CERTSRV_E_ENCODING_LENGTH = -2146877433,
        CERTSRV_E_ROLECONFLICT = -2146877432,
        CERTSRV_E_RESTRICTEDOFFICER = -2146877431,
        CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED = -2146877430,
        CERTSRV_E_NO_VALID_KRA = -2146877429,
        CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL = -2146877428,
        CERTSRV_E_NO_CAADMIN_DEFINED = -2146877427,
        CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE = -2146877426,
        CERTSRV_E_NO_DB_SESSIONS = -2146877425,
        CERTSRV_E_ALIGNMENT_FAULT = -2146877424,
        CERTSRV_E_ENROLL_DENIED = -2146877423,
        CERTSRV_E_TEMPLATE_DENIED = -2146877422,
        CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE = -2146877421,
        CERTSRV_E_UNSUPPORTED_CERT_TYPE = -2146875392,
        CERTSRV_E_NO_CERT_TYPE = -2146875391,
        CERTSRV_E_TEMPLATE_CONFLICT = -2146875390,
        CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED = -2146875389,
        CERTSRV_E_ARCHIVED_KEY_REQUIRED = -2146875388,
        CERTSRV_E_SMIME_REQUIRED = -2146875387,
        CERTSRV_E_BAD_RENEWAL_SUBJECT = -2146875386,
        CERTSRV_E_BAD_TEMPLATE_VERSION = -2146875385,
        CERTSRV_E_TEMPLATE_POLICY_REQUIRED = -2146875384,
        CERTSRV_E_SIGNATURE_POLICY_REQUIRED = -2146875383,
        CERTSRV_E_SIGNATURE_COUNT = -2146875382,
        CERTSRV_E_SIGNATURE_REJECTED = -2146875381,
        CERTSRV_E_ISSUANCE_POLICY_REQUIRED = -2146875380,
        CERTSRV_E_SUBJECT_UPN_REQUIRED = -2146875379,
        CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED = -2146875378,
        CERTSRV_E_SUBJECT_DNS_REQUIRED = -2146875377,
        CERTSRV_E_ARCHIVED_KEY_UNEXPECTED = -2146875376,
        CERTSRV_E_KEY_LENGTH = -2146875375,
        CERTSRV_E_SUBJECT_EMAIL_REQUIRED = -2146875374,
        CERTSRV_E_UNKNOWN_CERT_TYPE = -2146875373,
        CERTSRV_E_CERT_TYPE_OVERLAP = -2146875372,
        XENROLL_E_KEY_NOT_EXPORTABLE = -2146873344,
        XENROLL_E_CANNOT_ADD_ROOT_CERT = -2146873343,
        XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = -2146873342,
        XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = -2146873341,
        XENROLL_E_RESPONSE_KA_HASH_MISMATCH = -2146873340,
        XENROLL_E_KEYSPEC_SMIME_MISMATCH = -2146873339,
        TRUST_E_SYSTEM_ERROR = -2146869247,
        TRUST_E_NO_SIGNER_CERT = -2146869246,
        TRUST_E_COUNTER_SIGNER = -2146869245,
        TRUST_E_CERT_SIGNATURE = -2146869244,
        TRUST_E_TIME_STAMP = -2146869243,
        TRUST_E_BAD_DIGEST = -2146869232,
        TRUST_E_BASIC_CONSTRAINTS = -2146869223,
        TRUST_E_FINANCIAL_CRITERIA = -2146869218,
        MSSIPOTF_E_OUTOFMEMRANGE = -2146865151,
        MSSIPOTF_E_CANTGETOBJECT = -2146865150,
        MSSIPOTF_E_NOHEADTABLE = -2146865149,
        MSSIPOTF_E_BAD_MAGICNUMBER = -2146865148,
        MSSIPOTF_E_BAD_OFFSET_TABLE = -2146865147,
        MSSIPOTF_E_TABLE_TAGORDER = -2146865146,
        MSSIPOTF_E_TABLE_LONGWORD = -2146865145,
        MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = -2146865144,
        MSSIPOTF_E_TABLES_OVERLAP = -2146865143,
        MSSIPOTF_E_TABLE_PADBYTES = -2146865142,
        MSSIPOTF_E_FILETOOSMALL = -2146865141,
        MSSIPOTF_E_TABLE_CHECKSUM = -2146865140,
        MSSIPOTF_E_FILE_CHECKSUM = -2146865139,
        MSSIPOTF_E_FAILED_POLICY = -2146865136,
        MSSIPOTF_E_FAILED_HINTS_CHECK = -2146865135,
        MSSIPOTF_E_NOT_OPENTYPE = -2146865134,
        MSSIPOTF_E_FILE = -2146865133,
        MSSIPOTF_E_CRYPT = -2146865132,
        MSSIPOTF_E_BADVERSION = -2146865131,
        MSSIPOTF_E_DSIG_STRUCTURE = -2146865130,
        MSSIPOTF_E_PCONST_CHECK = -2146865129,
        MSSIPOTF_E_STRUCTURE = -2146865128,
        NTE_OP_OK = 0,
        TRUST_E_PROVIDER_UNKNOWN = -2146762751,
        TRUST_E_ACTION_UNKNOWN = -2146762750,
        TRUST_E_SUBJECT_FORM_UNKNOWN = -2146762749,
        TRUST_E_SUBJECT_NOT_TRUSTED = -2146762748,
        DIGSIG_E_ENCODE = -2146762747,
        DIGSIG_E_DECODE = -2146762746,
        DIGSIG_E_EXTENSIBILITY = -2146762745,
        DIGSIG_E_CRYPTO = -2146762744,
        PERSIST_E_SIZEDEFINITE = -2146762743,
        PERSIST_E_SIZEINDEFINITE = -2146762742,
        PERSIST_E_NOTSELFSIZING = -2146762741,
        TRUST_E_NOSIGNATURE = -2146762496,
        CERT_E_EXPIRED = -2146762495,
        CERT_E_VALIDITYPERIODNESTING = -2146762494,
        CERT_E_ROLE = -2146762493,
        CERT_E_PATHLENCONST = -2146762492,
        CERT_E_CRITICAL = -2146762491,
        CERT_E_PURPOSE = -2146762490,
        CERT_E_ISSUERCHAINING = -2146762489,
        CERT_E_MALFORMED = -2146762488,
        CERT_E_UNTRUSTEDROOT = -2146762487,
        CERT_E_CHAINING = -2146762486,
        TRUST_E_FAIL = -2146762485,
        CERT_E_REVOKED = -2146762484,
        CERT_E_UNTRUSTEDTESTROOT = -2146762483,
        CERT_E_REVOCATION_FAILURE = -2146762482,
        CERT_E_CN_NO_MATCH = -2146762481,
        CERT_E_WRONG_USAGE = -2146762480,
        TRUST_E_EXPLICIT_DISTRUST = -2146762479,
        CERT_E_UNTRUSTEDCA = -2146762478,
        CERT_E_INVALID_POLICY = -2146762477,
        CERT_E_INVALID_NAME = -2146762476,
        SPAPI_E_EXPECTED_SECTION_NAME = -2146500608,
        SPAPI_E_BAD_SECTION_NAME_LINE = -2146500607,
        SPAPI_E_SECTION_NAME_TOO_LONG = -2146500606,
        SPAPI_E_GENERAL_SYNTAX = -2146500605,
        SPAPI_E_WRONG_INF_STYLE = -2146500352,
        SPAPI_E_SECTION_NOT_FOUND = -2146500351,
        SPAPI_E_LINE_NOT_FOUND = -2146500350,
        SPAPI_E_NO_BACKUP = -2146500349,
        SPAPI_E_NO_ASSOCIATED_CLASS = -2146500096,
        SPAPI_E_CLASS_MISMATCH = -2146500095,
        SPAPI_E_DUPLICATE_FOUND = -2146500094,
        SPAPI_E_NO_DRIVER_SELECTED = -2146500093,
        SPAPI_E_KEY_DOES_NOT_EXIST = -2146500092,
        SPAPI_E_INVALID_DEVINST_NAME = -2146500091,
        SPAPI_E_INVALID_CLASS = -2146500090,
        SPAPI_E_DEVINST_ALREADY_EXISTS = -2146500089,
        SPAPI_E_DEVINFO_NOT_REGISTERED = -2146500088,
        SPAPI_E_INVALID_REG_PROPERTY = -2146500087,
        SPAPI_E_NO_INF = -2146500086,
        SPAPI_E_NO_SUCH_DEVINST = -2146500085,
        SPAPI_E_CANT_LOAD_CLASS_ICON = -2146500084,
        SPAPI_E_INVALID_CLASS_INSTALLER = -2146500083,
        SPAPI_E_DI_DO_DEFAULT = -2146500082,
        SPAPI_E_DI_NOFILECOPY = -2146500081,
        SPAPI_E_INVALID_HWPROFILE = -2146500080,
        SPAPI_E_NO_DEVICE_SELECTED = -2146500079,
        SPAPI_E_DEVINFO_LIST_LOCKED = -2146500078,
        SPAPI_E_DEVINFO_DATA_LOCKED = -2146500077,
        SPAPI_E_DI_BAD_PATH = -2146500076,
        SPAPI_E_NO_CLASSINSTALL_PARAMS = -2146500075,
        SPAPI_E_FILEQUEUE_LOCKED = -2146500074,
        SPAPI_E_BAD_SERVICE_INSTALLSECT = -2146500073,
        SPAPI_E_NO_CLASS_DRIVER_LIST = -2146500072,
        SPAPI_E_NO_ASSOCIATED_SERVICE = -2146500071,
        SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = -2146500070,
        SPAPI_E_DEVICE_INTERFACE_ACTIVE = -2146500069,
        SPAPI_E_DEVICE_INTERFACE_REMOVED = -2146500068,
        SPAPI_E_BAD_INTERFACE_INSTALLSECT = -2146500067,
        SPAPI_E_NO_SUCH_INTERFACE_CLASS = -2146500066,
        SPAPI_E_INVALID_REFERENCE_STRING = -2146500065,
        SPAPI_E_INVALID_MACHINENAME = -2146500064,
        SPAPI_E_REMOTE_COMM_FAILURE = -2146500063,
        SPAPI_E_MACHINE_UNAVAILABLE = -2146500062,
        SPAPI_E_NO_CONFIGMGR_SERVICES = -2146500061,
        SPAPI_E_INVALID_PROPPAGE_PROVIDER = -2146500060,
        SPAPI_E_NO_SUCH_DEVICE_INTERFACE = -2146500059,
        SPAPI_E_DI_POSTPROCESSING_REQUIRED = -2146500058,
        SPAPI_E_INVALID_COINSTALLER = -2146500057,
        SPAPI_E_NO_COMPAT_DRIVERS = -2146500056,
        SPAPI_E_NO_DEVICE_ICON = -2146500055,
        SPAPI_E_INVALID_INF_LOGCONFIG = -2146500054,
        SPAPI_E_DI_DONT_INSTALL = -2146500053,
        SPAPI_E_INVALID_FILTER_DRIVER = -2146500052,
        SPAPI_E_NON_WINDOWS_NT_DRIVER = -2146500051,
        SPAPI_E_NON_WINDOWS_DRIVER = -2146500050,
        SPAPI_E_NO_CATALOG_FOR_OEM_INF = -2146500049,
        SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = -2146500048,
        SPAPI_E_NOT_DISABLEABLE = -2146500047,
        SPAPI_E_CANT_REMOVE_DEVINST = -2146500046,
        SPAPI_E_INVALID_TARGET = -2146500045,
        SPAPI_E_DRIVER_NONNATIVE = -2146500044,
        SPAPI_E_IN_WOW64 = -2146500043,
        SPAPI_E_SET_SYSTEM_RESTORE_POINT = -2146500042,
        SPAPI_E_INCORRECTLY_COPIED_INF = -2146500041,
        SPAPI_E_SCE_DISABLED = -2146500040,
        SPAPI_E_UNKNOWN_EXCEPTION = -2146500039,
        SPAPI_E_PNP_REGISTRY_ERROR = -2146500038,
        SPAPI_E_REMOTE_REQUEST_UNSUPPORTED = -2146500037,
        SPAPI_E_NOT_AN_INSTALLED_OEM_INF = -2146500036,
        SPAPI_E_INF_IN_USE_BY_DEVICES = -2146500035,
        SPAPI_E_DI_FUNCTION_OBSOLETE = -2146500034,
        SPAPI_E_NO_AUTHENTICODE_CATALOG = -2146500033,
        SPAPI_E_AUTHENTICODE_DISALLOWED = -2146500032,
        SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER = -2146500031,
        SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED = -2146500030,
        SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = -2146500029,
        SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH = -2146500028,
        SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE = -2146500027,
        SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW = -2146499840,
        SPAPI_E_ERROR_NOT_INSTALLED = -2146496512,
        SCARD_S_SUCCESS = 0,
        SCARD_F_INTERNAL_ERROR = -2146435071,
        SCARD_E_CANCELLED = -2146435070,
        SCARD_E_INVALID_HANDLE = -2146435069,
        SCARD_E_INVALID_PARAMETER = -2146435068,
        SCARD_E_INVALID_TARGET = -2146435067,
        SCARD_E_NO_MEMORY = -2146435066,
        SCARD_F_WAITED_TOO_LONG = -2146435065,
        SCARD_E_INSUFFICIENT_BUFFER = -2146435064,
        SCARD_E_UNKNOWN_READER = -2146435063,
        SCARD_E_TIMEOUT = -2146435062,
        SCARD_E_SHARING_VIOLATION = -2146435061,
        SCARD_E_NO_SMARTCARD = -2146435060,
        SCARD_E_UNKNOWN_CARD = -2146435059,
        SCARD_E_CANT_DISPOSE = -2146435058,
        SCARD_E_PROTO_MISMATCH = -2146435057,
        SCARD_E_NOT_READY = -2146435056,
        SCARD_E_INVALID_VALUE = -2146435055,
        SCARD_E_SYSTEM_CANCELLED = -2146435054,
        SCARD_F_COMM_ERROR = -2146435053,
        SCARD_F_UNKNOWN_ERROR = -2146435052,
        SCARD_E_INVALID_ATR = -2146435051,
        SCARD_E_NOT_TRANSACTED = -2146435050,
        SCARD_E_READER_UNAVAILABLE = -2146435049,
        SCARD_P_SHUTDOWN = -2146435048,
        SCARD_E_PCI_TOO_SMALL = -2146435047,
        SCARD_E_READER_UNSUPPORTED = -2146435046,
        SCARD_E_DUPLICATE_READER = -2146435045,
        SCARD_E_CARD_UNSUPPORTED = -2146435044,
        SCARD_E_NO_SERVICE = -2146435043,
        SCARD_E_SERVICE_STOPPED = -2146435042,
        SCARD_E_UNEXPECTED = -2146435041,
        SCARD_E_ICC_INSTALLATION = -2146435040,
        SCARD_E_ICC_CREATEORDER = -2146435039,
        SCARD_E_UNSUPPORTED_FEATURE = -2146435038,
        SCARD_E_DIR_NOT_FOUND = -2146435037,
        SCARD_E_FILE_NOT_FOUND = -2146435036,
        SCARD_E_NO_DIR = -2146435035,
        SCARD_E_NO_FILE = -2146435034,
        SCARD_E_NO_ACCESS = -2146435033,
        SCARD_E_WRITE_TOO_MANY = -2146435032,
        SCARD_E_BAD_SEEK = -2146435031,
        SCARD_E_INVALID_CHV = -2146435030,
        SCARD_E_UNKNOWN_RES_MNG = -2146435029,
        SCARD_E_NO_SUCH_CERTIFICATE = -2146435028,
        SCARD_E_CERTIFICATE_UNAVAILABLE = -2146435027,
        SCARD_E_NO_READERS_AVAILABLE = -2146435026,
        SCARD_E_COMM_DATA_LOST = -2146435025,
        SCARD_E_NO_KEY_CONTAINER = -2146435024,
        SCARD_E_SERVER_TOO_BUSY = -2146435023,
        SCARD_W_UNSUPPORTED_CARD = -2146434971,
        SCARD_W_UNRESPONSIVE_CARD = -2146434970,
        SCARD_W_UNPOWERED_CARD = -2146434969,
        SCARD_W_RESET_CARD = -2146434968,
        SCARD_W_REMOVED_CARD = -2146434967,
        SCARD_W_SECURITY_VIOLATION = -2146434966,
        SCARD_W_WRONG_CHV = -2146434965,
        SCARD_W_CHV_BLOCKED = -2146434964,
        SCARD_W_EOF = -2146434963,
        SCARD_W_CANCELLED_BY_USER = -2146434962,
        SCARD_W_CARD_NOT_AUTHENTICATED = -2146434961,
        COMADMIN_E_OBJECTERRORS = -2146368511,
        COMADMIN_E_OBJECTINVALID = -2146368510,
        COMADMIN_E_KEYMISSING = -2146368509,
        COMADMIN_E_ALREADYINSTALLED = -2146368508,
        COMADMIN_E_APP_FILE_WRITEFAIL = -2146368505,
        COMADMIN_E_APP_FILE_READFAIL = -2146368504,
        COMADMIN_E_APP_FILE_VERSION = -2146368503,
        COMADMIN_E_BADPATH = -2146368502,
        COMADMIN_E_APPLICATIONEXISTS = -2146368501,
        COMADMIN_E_ROLEEXISTS = -2146368500,
        COMADMIN_E_CANTCOPYFILE = -2146368499,
        COMADMIN_E_NOUSER = -2146368497,
        COMADMIN_E_INVALIDUSERIDS = -2146368496,
        COMADMIN_E_NOREGISTRYCLSID = -2146368495,
        COMADMIN_E_BADREGISTRYPROGID = -2146368494,
        COMADMIN_E_AUTHENTICATIONLEVEL = -2146368493,
        COMADMIN_E_USERPASSWDNOTVALID = -2146368492,
        COMADMIN_E_CLSIDORIIDMISMATCH = -2146368488,
        COMADMIN_E_REMOTEINTERFACE = -2146368487,
        COMADMIN_E_DLLREGISTERSERVER = -2146368486,
        COMADMIN_E_NOSERVERSHARE = -2146368485,
        COMADMIN_E_DLLLOADFAILED = -2146368483,
        COMADMIN_E_BADREGISTRYLIBID = -2146368482,
        COMADMIN_E_APPDIRNOTFOUND = -2146368481,
        COMADMIN_E_REGISTRARFAILED = -2146368477,
        COMADMIN_E_COMPFILE_DOESNOTEXIST = -2146368476,
        COMADMIN_E_COMPFILE_LOADDLLFAIL = -2146368475,
        COMADMIN_E_COMPFILE_GETCLASSOBJ = -2146368474,
        COMADMIN_E_COMPFILE_CLASSNOTAVAIL = -2146368473,
        COMADMIN_E_COMPFILE_BADTLB = -2146368472,
        COMADMIN_E_COMPFILE_NOTINSTALLABLE = -2146368471,
        COMADMIN_E_NOTCHANGEABLE = -2146368470,
        COMADMIN_E_NOTDELETEABLE = -2146368469,
        COMADMIN_E_SESSION = -2146368468,
        COMADMIN_E_COMP_MOVE_LOCKED = -2146368467,
        COMADMIN_E_COMP_MOVE_BAD_DEST = -2146368466,
        COMADMIN_E_REGISTERTLB = -2146368464,
        COMADMIN_E_SYSTEMAPP = -2146368461,
        COMADMIN_E_COMPFILE_NOREGISTRAR = -2146368460,
        COMADMIN_E_COREQCOMPINSTALLED = -2146368459,
        COMADMIN_E_SERVICENOTINSTALLED = -2146368458,
        COMADMIN_E_PROPERTYSAVEFAILED = -2146368457,
        COMADMIN_E_OBJECTEXISTS = -2146368456,
        COMADMIN_E_COMPONENTEXISTS = -2146368455,
        COMADMIN_E_REGFILE_CORRUPT = -2146368453,
        COMADMIN_E_PROPERTY_OVERFLOW = -2146368452,
        COMADMIN_E_NOTINREGISTRY = -2146368450,
        COMADMIN_E_OBJECTNOTPOOLABLE = -2146368449,
        COMADMIN_E_APPLID_MATCHES_CLSID = -2146368442,
        COMADMIN_E_ROLE_DOES_NOT_EXIST = -2146368441,
        COMADMIN_E_START_APP_NEEDS_COMPONENTS = -2146368440,
        COMADMIN_E_REQUIRES_DIFFERENT_PLATFORM = -2146368439,
        COMADMIN_E_CAN_NOT_EXPORT_APP_PROXY = -2146368438,
        COMADMIN_E_CAN_NOT_START_APP = -2146368437,
        COMADMIN_E_CAN_NOT_EXPORT_SYS_APP = -2146368436,
        COMADMIN_E_CANT_SUBSCRIBE_TO_COMPONENT = -2146368435,
        COMADMIN_E_EVENTCLASS_CANT_BE_SUBSCRIBER = -2146368434,
        COMADMIN_E_LIB_APP_PROXY_INCOMPATIBLE = -2146368433,
        COMADMIN_E_BASE_PARTITION_ONLY = -2146368432,
        COMADMIN_E_START_APP_DISABLED = -2146368431,
        COMADMIN_E_CAT_DUPLICATE_PARTITION_NAME = -2146368425,
        COMADMIN_E_CAT_INVALID_PARTITION_NAME = -2146368424,
        COMADMIN_E_CAT_PARTITION_IN_USE = -2146368423,
        COMADMIN_E_FILE_PARTITION_DUPLICATE_FILES = -2146368422,
        COMADMIN_E_CAT_IMPORTED_COMPONENTS_NOT_ALLOWED = -2146368421,
        COMADMIN_E_AMBIGUOUS_APPLICATION_NAME = -2146368420,
        COMADMIN_E_AMBIGUOUS_PARTITION_NAME = -2146368419,
        COMADMIN_E_REGDB_NOTINITIALIZED = -2146368398,
        COMADMIN_E_REGDB_NOTOPEN = -2146368397,
        COMADMIN_E_REGDB_SYSTEMERR = -2146368396,
        COMADMIN_E_REGDB_ALREADYRUNNING = -2146368395,
        COMADMIN_E_MIG_VERSIONNOTSUPPORTED = -2146368384,
        COMADMIN_E_MIG_SCHEMANOTFOUND = -2146368383,
        COMADMIN_E_CAT_BITNESSMISMATCH = -2146368382,
        COMADMIN_E_CAT_UNACCEPTABLEBITNESS = -2146368381,
        COMADMIN_E_CAT_WRONGAPPBITNESS = -2146368380,
        COMADMIN_E_CAT_PAUSE_RESUME_NOT_SUPPORTED = -2146368379,
        COMADMIN_E_CAT_SERVERFAULT = -2146368378,
        COMQC_E_APPLICATION_NOT_QUEUED = -2146368000,
        COMQC_E_NO_QUEUEABLE_INTERFACES = -2146367999,
        COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = -2146367998,
        COMQC_E_NO_IPERSISTSTREAM = -2146367997,
        COMQC_E_BAD_MESSAGE = -2146367996,
        COMQC_E_UNAUTHENTICATED = -2146367995,
        COMQC_E_UNTRUSTED_ENQUEUER = -2146367994,
        MSDTC_E_DUPLICATE_RESOURCE = -2146367743,
        COMADMIN_E_OBJECT_PARENT_MISSING = -2146367480,
        COMADMIN_E_OBJECT_DOES_NOT_EXIST = -2146367479,
        COMADMIN_E_APP_NOT_RUNNING = -2146367478,
        COMADMIN_E_INVALID_PARTITION = -2146367477,
        COMADMIN_E_SVCAPP_NOT_POOLABLE_OR_RECYCLABLE = -2146367475,
        COMADMIN_E_USER_IN_SET = -2146367474,
        COMADMIN_E_CANTRECYCLELIBRARYAPPS = -2146367473,
        COMADMIN_E_CANTRECYCLESERVICEAPPS = -2146367471,
        COMADMIN_E_PROCESSALREADYRECYCLED = -2146367470,
        COMADMIN_E_PAUSEDPROCESSMAYNOTBERECYCLED = -2146367469,
        COMADMIN_E_CANTMAKEINPROCSERVICE = -2146367468,
        COMADMIN_E_PROGIDINUSEBYCLSID = -2146367467,
        COMADMIN_E_DEFAULT_PARTITION_NOT_IN_SET = -2146367466,
        COMADMIN_E_RECYCLEDPROCESSMAYNOTBEPAUSED = -2146367465,
        COMADMIN_E_PARTITION_ACCESSDENIED = -2146367464,
        COMADMIN_E_PARTITION_MSI_ONLY = -2146367463,
        COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_1_0_FORMAT = -2146367462,
        COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_NONBASE_PARTITIONS = -2146367461,
        COMADMIN_E_COMP_MOVE_SOURCE = -2146367460,
        COMADMIN_E_COMP_MOVE_DEST = -2146367459,
        COMADMIN_E_COMP_MOVE_PRIVATE = -2146367458,
        COMADMIN_E_BASEPARTITION_REQUIRED_IN_SET = -2146367457,
        COMADMIN_E_CANNOT_ALIAS_EVENTCLASS = -2146367456,
        COMADMIN_E_PRIVATE_ACCESSDENIED = -2146367455,
        COMADMIN_E_SAFERINVALID = -2146367454,
        COMADMIN_E_REGISTRY_ACCESSDENIED = -2146367453,
        COMADMIN_E_PARTITIONS_DISABLED = -2146367452,
    }
    public class static WinInetDll
    {
        public const string DllName = "WinInet.dll";
        public static int InternetGetCookieW(string lpszUrl, string lpszCookieName, System.Char* lpszCookieData, System.UInt32* lpdwSize) { }
        public static int InternetSetCookieW(string lpszUrl, string lpszCookieName, string lpszCookieData) { }
        public class static Helpers
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static string InternetGetCookie([JetBrains.Annotations.NotNullAttribute()] string uri) { }
            public static void InternetSetCookie([JetBrains.Annotations.NotNullAttribute()] string uri, [JetBrains.Annotations.NotNullAttribute()] string cookies) { }
        }
    }
    public enum WmActivateCodes : uint
    {
        Inactive = 0u,
        Active = 1u,
        ClickActive = 2u,
    }
    public enum WmMouseActivateReturnCodes
    {
        MA_ACTIVATE = 1,
        MA_ACTIVATEANDEAT = 2,
        MA_NOACTIVATE = 3,
        MA_NOACTIVATEANDEAT = 4,
    }
}
namespace JetBrains.Interop.WinApi.Declarations.Constants
{
    
    public enum BiCompression : uint
    {
        BI_RGB = 0u,
        BI_RLE8 = 1u,
        BI_RLE4 = 2u,
        BI_BITFIELDS = 3u,
        BI_JPEG = 4u,
        BI_PNG = 5u,
    }
    public enum CreationDisposition : uint
    {
        New = 1u,
        CreateAlways = 2u,
        OpenExisting = 3u,
        OpenAlways = 4u,
        TruncateExisting = 5u,
    }
    public enum DeviceCapabilityIndex
    {
        DRIVERVERSION = 0,
        TECHNOLOGY = 2,
        HORZSIZE = 4,
        VERTSIZE = 6,
        HORZRES = 8,
        VERTRES = 10,
        BITSPIXEL = 12,
        PLANES = 14,
        NUMBRUSHES = 16,
        NUMPENS = 18,
        NUMMARKERS = 20,
        NUMFONTS = 22,
        NUMCOLORS = 24,
        PDEVICESIZE = 26,
        CURVECAPS = 28,
        LINECAPS = 30,
        POLYGONALCAPS = 32,
        TEXTCAPS = 34,
        CLIPCAPS = 36,
        RASTERCAPS = 38,
        ASPECTX = 40,
        ASPECTY = 42,
        ASPECTXY = 44,
        SHADEBLENDCAPS = 45,
        LOGPIXELSX = 88,
        LOGPIXELSY = 90,
        SIZEPALETTE = 104,
        NUMRESERVED = 106,
        COLORRES = 108,
        PHYSICALWIDTH = 110,
        PHYSICALHEIGHT = 111,
        PHYSICALOFFSETX = 112,
        PHYSICALOFFSETY = 113,
        SCALINGFACTORX = 114,
        SCALINGFACTORY = 115,
        VREFRESH = 116,
        DESKTOPVERTRES = 117,
        DESKTOPHORZRES = 118,
        BLTALIGNMENT = 119,
    }
    public enum DibColors : uint
    {
        DIB_RGB_COLORS = 0u,
        DIB_PAL_COLORS = 1u,
    }
    public enum EItsCompact
    {
        ITS_COMPACT_DATA = 0,
        ITS_COMPACT_DATA_AND_PATH = 1,
    }
    [System.FlagsAttribute()]
    public enum ELEVATION_FLAGS : uint
    {
        ELEVATION_UAC_ENABLED = 1u,
        ELEVATION_VIRTUALIZATION_ENABLED = 2u,
        ELEVATION_INSTALLER_DETECTION_ENABLED = 4u,
    }
    [System.FlagsAttribute()]
    public enum FileAttribute : uint
    {
        FILE_ATTRIBUTE_READONLY = 1u,
        FILE_ATTRIBUTE_HIDDEN = 2u,
        FILE_ATTRIBUTE_SYSTEM = 4u,
        FILE_ATTRIBUTE_DIRECTORY = 16u,
        FILE_ATTRIBUTE_ARCHIVE = 32u,
        FILE_ATTRIBUTE_DEVICE = 64u,
        FILE_ATTRIBUTE_NORMAL = 128u,
        FILE_ATTRIBUTE_TEMPORARY = 256u,
        FILE_ATTRIBUTE_SPARSE_FILE = 512u,
        FILE_ATTRIBUTE_REPARSE_POINT = 1024u,
        FILE_ATTRIBUTE_COMPRESSED = 2048u,
        FILE_ATTRIBUTE_OFFLINE = 4096u,
        FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192u,
        FILE_ATTRIBUTE_ENCRYPTED = 16384u,
        FILE_ATTRIBUTE_VIRTUAL = 65536u,
    }
    [System.FlagsAttribute()]
    public enum FileFlagsAndAttributes : uint
    {
        Readonly = 1u,
        Hidden = 2u,
        System = 4u,
        Directory = 16u,
        Archive = 32u,
        Device = 64u,
        Normal = 128u,
        Temporary = 256u,
        SparseFile = 512u,
        ReparsePoint = 1024u,
        Compressed = 2048u,
        Offline = 4096u,
        NotContentIndexed = 8192u,
        Encrypted = 16384u,
        WriteThrough = 2147483648u,
        Overlapped = 1073741824u,
        NoBuffering = 536870912u,
        RandomAccess = 268435456u,
        SequentialScan = 134217728u,
        DeleteOnClose = 67108864u,
        BackupSemantics = 33554432u,
        PosixSemantics = 16777216u,
        OpenReparsePoint = 2097152u,
        OpenNoRecall = 1048576u,
        FirstPipeInstance = 524288u,
    }
    public enum FileMapAccess : uint
    {
        FILE_MAP_COPY = 1u,
        FILE_MAP_WRITE = 2u,
        FILE_MAP_READ = 4u,
        FILE_MAP_ALL_ACCESS = 983071u,
        FILE_MAP_EXECUTE = 32u,
    }
    public enum FileNotifyAction
    {
        Added = 1,
        Removed = 2,
        Modified = 3,
        RenamedOldName = 4,
        RenamedNewName = 5,
    }
    [System.FlagsAttribute()]
    public enum FileShareFlags : uint
    {
        None = 0u,
        Read = 1u,
        Write = 2u,
        Delete = 4u,
    }
    [System.FlagsAttribute()]
    public enum FLASHWINFOFLAGS : uint
    {
        FLASHW_STOP = 0u,
        FLASHW_CAPTION = 1u,
        FLASHW_TRAY = 2u,
        FLASHW_ALL = 3u,
        FLASHW_TIMER = 4u,
        FLASHW_TIMERNOFG = 12u,
    }
    public enum GET_FILEEX_INFO_LEVELS
    {
        GetFileExInfoStandard = 0,
        GetFileExMaxInfoLevel = 1,
    }
    public class static HKEY
    {
        public static readonly System.Void* HKEY_CLASSES_ROOT;
        public static readonly System.Void* HKEY_CURRENT_CONFIG;
        public static readonly System.Void* HKEY_CURRENT_USER;
        public static readonly System.Void* HKEY_DYN_DATA;
        public static readonly System.Void* HKEY_LOCAL_MACHINE;
        public static readonly System.Void* HKEY_PERFORMANCE_DATA;
        public static readonly System.Void* HKEY_PERFORMANCE_NLSTEXT;
        public static readonly System.Void* HKEY_PERFORMANCE_TEXT;
        public static readonly System.Void* HKEY_USERS;
    }
    public enum HookCode
    {
        HC_ACTION = 0,
        HC_NOREMOVE = 3,
    }
    public class static KEYEVENTF
    {
        public static readonly uint KEYEVENTF_EXTENDEDKEY;
        public static readonly uint KEYEVENTF_KEYUP;
    }
    [System.FlagsAttribute()]
    public enum MemoryAllocationTypes : uint
    {
        MEM_COMMIT = 4096u,
        MEM_RESERVE = 8192u,
        MEM_RESET = 524288u,
        MEM_FREE = 65536u,
        MEM_LARGE_PAGES = 536870912u,
        MEM_PHYSICAL = 4194304u,
        MEM_TOP_DOWN = 1048576u,
        MEM_WRITE_WATCH = 2097152u,
    }
    [System.FlagsAttribute()]
    public enum MemoryPageTypes : uint
    {
        MEM_IMAGE = 16777216u,
        MEM_MAPPED = 262144u,
        MEM_PRIVATE = 131072u,
    }
    [System.FlagsAttribute()]
    public enum MemoryProtectionConstants : uint
    {
        PAGE_EXECUTE = 16u,
        PAGE_EXECUTE_READ = 32u,
        PAGE_EXECUTE_READWRITE = 64u,
        PAGE_EXECUTE_WRITECOPY = 128u,
        PAGE_NOACCESS = 1u,
        PAGE_READONLY = 2u,
        PAGE_READWRITE = 4u,
        PAGE_WRITECOPY = 8u,
        PAGE_GUARD = 256u,
        PAGE_NOCACHE = 512u,
        PAGE_WRITECOMBINE = 1024u,
    }
    public enum MF : uint
    {
        MF_INSERT = 0u,
        MF_CHANGE = 128u,
        MF_APPEND = 256u,
        MF_DELETE = 512u,
        MF_REMOVE = 4096u,
        MF_BYCOMMAND = 0u,
        MF_BYPOSITION = 1024u,
        MF_SEPARATOR = 2048u,
        MF_ENABLED = 0u,
        MF_GRAYED = 1u,
        MF_DISABLED = 2u,
        MF_UNCHECKED = 0u,
        MF_CHECKED = 8u,
        MF_USECHECKBITMAPS = 512u,
        MF_STRING = 0u,
        MF_BITMAP = 4u,
        MF_OWNERDRAW = 256u,
        MF_POPUP = 16u,
        MF_MENUBARBREAK = 32u,
        MF_MENUBREAK = 64u,
        MF_UNHILITE = 0u,
        MF_HILITE = 128u,
        MF_DEFAULT = 4096u,
        MF_SYSMENU = 8192u,
        MF_HELP = 16384u,
        MF_RIGHTJUSTIFY = 16384u,
    }
    public enum MIB_TCP_STATE : uint
    {
        MIB_TCP_STATE_CLOSED = 1u,
        MIB_TCP_STATE_LISTEN = 2u,
        MIB_TCP_STATE_SYN_SENT = 3u,
        MIB_TCP_STATE_SYN_RCVD = 4u,
        MIB_TCP_STATE_ESTAB = 5u,
        MIB_TCP_STATE_FIN_WAIT1 = 6u,
        MIB_TCP_STATE_FIN_WAIT2 = 7u,
        MIB_TCP_STATE_CLOSE_WAIT = 8u,
        MIB_TCP_STATE_CLOSING = 9u,
        MIB_TCP_STATE_LAST_ACK = 10u,
        MIB_TCP_STATE_TIME_WAIT = 11u,
        MIB_TCP_STATE_DELETE_TCB = 12u,
    }
    public class static MOUSEEVENTF
    {
        public static readonly uint MOUSEEVENTF_ABSOLUTE;
        public static readonly uint MOUSEEVENTF_HWHEEL;
        public static readonly uint MOUSEEVENTF_LEFTDOWN;
        public static readonly uint MOUSEEVENTF_LEFTUP;
        public static readonly uint MOUSEEVENTF_MIDDLEDOWN;
        public static readonly uint MOUSEEVENTF_MIDDLEUP;
        public static readonly uint MOUSEEVENTF_MOVE;
        public static readonly uint MOUSEEVENTF_MOVE_NOCOALESCE;
        public static readonly uint MOUSEEVENTF_RIGHTDOWN;
        public static readonly uint MOUSEEVENTF_RIGHTUP;
        public static readonly uint MOUSEEVENTF_VIRTUALDESK;
        public static readonly uint MOUSEEVENTF_WHEEL;
        public static readonly uint MOUSEEVENTF_XDOWN;
        public static readonly uint MOUSEEVENTF_XUP;
    }
    public enum MoveFileAttributes : uint
    {
        MOVEFILE_REPLACE_EXISTING = 1u,
        MOVEFILE_COPY_ALLOWED = 2u,
        MOVEFILE_DELAY_UNTIL_REBOOT = 4u,
        MOVEFILE_WRITE_THROUGH = 8u,
        MOVEFILE_CREATE_HARDLINK = 16u,
        MOVEFILE_FAIL_IF_NOT_TRACKABLE = 32u,
    }
    public class static MsoConstants
    {
        public const int msocadvfModal = 1;
        public const int msocadvfRecording = 8;
        public const int msocadvfRedrawOff = 2;
        public const int msocadvfWarningsOff = 4;
        public const int msoccontextAll = 0;
        public const int msoccontextMine = 1;
        public const int msoccontextOthers = 2;
        public const int msochostfExclusiveBorderSpace = 1;
        public const int msocrfExclusiveActivation = 128;
        public const int msocrfExclusiveBorderSpace = 64;
        public const int msocrfMaster = 512;
        public const int msocrfNeedAllActiveNotifs = 32;
        public const int msocrfNeedAllMacEvents = 256;
        public const int msocrfNeedIdleTime = 1;
        public const int msocrfNeedPeriodicIdleTime = 2;
        public const int msocrfNeedSpecActiveNotifs = 16;
        public const int msocrfPreTranslateAll = 8;
        public const int msocrfPreTranslateKeys = 4;
        public const int msocstateModal = 1;
        public const int msocstateRecording = 4;
        public const int msocstateRedrawOff = 2;
        public const int msocstateWarningsOff = 3;
        public const int msocWindowComponent = 2;
        public const int msocWindowDlgOwner = 3;
        public const int msocWindowFrameOwner = 1;
        public const int msocWindowFrameToplevel = 0;
        public const int msogacActive = 0;
        public const int msogacTracking = 1;
        public const int msogacTrackingOrActive = 2;
        public const int msoidlefAll = -1;
        public const int msoidlefNonPeriodic = 2;
        public const int msoidlefPeriodic = 1;
        public const int msoidlefPriority = 4;
        public const int msoloopDebug = 3;
        public const int msoloopDoEvents = 2;
        public const int msoloopDoEventsModal = -2;
        public const int msoloopFocusWait = 1;
        public const int msoloopMain = -1;
        public const int msoloopModalAlert = 5;
        public const int msoloopModalForm = 4;
    }
    [System.FlagsAttribute()]
    public enum MSOCRF : uint
    {
        msocrfNeedIdleTime = 1u,
        msocrfNeedPeriodicIdleTime = 2u,
        msocrfPreTranslateKeys = 4u,
        msocrfPreTranslateAll = 8u,
        msocrfNeedSpecActiveNotifs = 16u,
        msocrfNeedAllActiveNotifs = 32u,
        msocrfExclusiveBorderSpace = 64u,
        msocrfExclusiveActivation = 128u,
        msocrfNeedAllMacEvents = 256u,
        msocrfMaster = 512u,
    }
    public enum OBJID
    {
        OBJID_WINDOW = 0,
        OBJID_SYSMENU = -1,
        OBJID_TITLEBAR = -2,
        OBJID_MENU = -3,
        OBJID_CLIENT = -4,
        OBJID_VSCROLL = -5,
        OBJID_HSCROLL = -6,
        OBJID_SIZEGRIP = -7,
        OBJID_CARET = -8,
        OBJID_CURSOR = -9,
        OBJID_ALERT = -10,
        OBJID_SOUND = -11,
        OBJID_QUERYCLASSNAMEIDX = -12,
        OBJID_NATIVEOM = -16,
    }
    [System.FlagsAttribute()]
    public enum OLECADVF : uint
    {
        olecadvfModal = 1u,
        olecadvfRedrawOff = 2u,
        olecadvfWarningsOff = 4u,
        olecadvfRecording = 8u,
    }
    [System.FlagsAttribute()]
    public enum OLECMDF : uint
    {
        OLECMDF_SUPPORTED = 1u,
        OLECMDF_ENABLED = 2u,
        OLECMDF_LATCHED = 4u,
        OLECMDF_NINCHED = 8u,
        OLECMDF_INVISIBLE = 16u,
        OLECMDF_DEFHIDEONCTXTMENU = 32u,
    }
    [System.FlagsAttribute()]
    public enum OLECRF : uint
    {
        olecrfNeedIdleTime = 1u,
        olecrfNeedPeriodicIdleTime = 2u,
        olecrfPreTranslateKeys = 4u,
        olecrfPreTranslateAll = 8u,
        olecrfNeedSpecActiveNotifs = 16u,
        olecrfNeedAllActiveNotifs = 32u,
        olecrfExclusiveBorderSpace = 64u,
        olecrfExclusiveActivation = 128u,
        msocrfNeedAllMacEvents = 256u,
        msocrfMaster = 512u,
    }
    public enum PropSheetPageProcMsg : uint
    {
        PSPCB_ADDREF = 0u,
        PSPCB_CREATE = 2u,
        PSPCB_RELEASE = 1u,
    }
    public enum RasterOperations : uint
    {
        SRCCOPY = 13369376u,
        SRCPAINT = 15597702u,
        SRCAND = 8913094u,
        SRCINVERT = 6684742u,
        SRCERASE = 4457256u,
        NOTSRCCOPY = 3342344u,
        NOTSRCERASE = 1114278u,
        MERGECOPY = 12583114u,
        MERGEPAINT = 12255782u,
        PATCOPY = 15728673u,
        PATPAINT = 16452105u,
        PATINVERT = 5898313u,
        DSTINVERT = 5570569u,
        BLACKNESS = 66u,
        WHITENESS = 16711778u,
        NOMIRRORBITMAP = 2147483648u,
        CAPTUREBLT = 1073741824u,
    }
    public enum SectionFlags : uint
    {
        SECTION_QUERY = 1u,
        SECTION_MAP_WRITE = 2u,
        SECTION_MAP_READ = 4u,
        SECTION_MAP_EXECUTE = 8u,
        SECTION_EXTEND_SIZE = 16u,
        SECTION_MAP_EXECUTE_EXPLICIT = 32u,
        SECTION_ALL_ACCESS = 983071u,
    }
    [System.FlagsAttribute()]
    public enum SHGetFileInfoFlags : uint
    {
        SHGFI_ADDOVERLAYS = 32u,
        SHGFI_ATTR_SPECIFIED = 131072u,
        SHGFI_ATTRIBUTES = 2048u,
        SHGFI_DISPLAYNAME = 512u,
        SHGFI_EXETYPE = 8192u,
        SHGFI_ICON = 256u,
        SHGFI_ICONLOCATION = 4096u,
        SHGFI_LARGEICON = 0u,
        SHGFI_LINKOVERLAY = 32768u,
        SHGFI_OPENICON = 2u,
        SHGFI_OVERLAYINDEX = 64u,
        SHGFI_PIDL = 8u,
        SHGFI_SELECTED = 65536u,
        SHGFI_SHELLICONSIZE = 4u,
        SHGFI_SMALLICON = 1u,
        SHGFI_SYSICONINDEX = 16384u,
        SHGFI_TYPENAME = 1024u,
        SHGFI_USEFILEATTRIBUTES = 16u,
    }
    public enum SMTO : uint
    {
        SMTO_NORMAL = 0u,
        SMTO_BLOCK = 1u,
        SMTO_ABORTIFHUNG = 2u,
        SMTO_NOTIMEOUTIFNOTHUNG = 8u,
        SMTO_ERRORONEXIT = 32u,
    }
    public enum STGFMT : uint
    {
        STGFMT_STORAGE = 0u,
        STGFMT_NATIVE = 1u,
        STGFMT_FILE = 3u,
        STGFMT_ANY = 4u,
        STGFMT_DOCFILE = 5u,
        STGFMT_DOCUMENT = 0u,
    }
    [System.FlagsAttribute()]
    public enum STGM : uint
    {
        STGM_DIRECT = 0u,
        STGM_TRANSACTED = 65536u,
        STGM_SIMPLE = 134217728u,
        STGM_READ = 0u,
        STGM_WRITE = 1u,
        STGM_READWRITE = 2u,
        STGM_SHARE_DENY_NONE = 64u,
        STGM_SHARE_DENY_READ = 48u,
        STGM_SHARE_DENY_WRITE = 32u,
        STGM_SHARE_EXCLUSIVE = 16u,
        STGM_PRIORITY = 262144u,
        STGM_DELETEONRELEASE = 67108864u,
        STGM_NOSCRATCH = 1048576u,
        STGM_CREATE = 4096u,
        STGM_CONVERT = 131072u,
        STGM_FAILIFTHERE = 0u,
        STGM_NOSNAPSHOT = 2097152u,
        STGM_DIRECT_SWMR = 4194304u,
    }
    public enum SystemCommand : ushort
    {
        SC_SIZE = 61440,
        SC_MOVE = 61456,
        SC_MINIMIZE = 61472,
        SC_MAXIMIZE = 61488,
        SC_NEXTWINDOW = 61504,
        SC_PREVWINDOW = 61520,
        SC_CLOSE = 61536,
        SC_VSCROLL = 61552,
        SC_HSCROLL = 61568,
        SC_MOUSEMENU = 61584,
        SC_KEYMENU = 61696,
        SC_ARRANGE = 61712,
        SC_RESTORE = 61728,
        SC_TASKLIST = 61744,
        SC_SCREENSAVE = 61760,
        SC_HOTKEY = 61776,
        SC_DEFAULT = 61792,
        SC_MONITORPOWER = 61808,
        SC_CONTEXTHELP = 61824,
        SC_SEPARATOR = 61455,
    }
    public enum TCP_TABLE_CLASS
    {
        TCP_TABLE_BASIC_LISTENER = 0,
        TCP_TABLE_BASIC_CONNECTIONS = 1,
        TCP_TABLE_BASIC_ALL = 2,
        TCP_TABLE_OWNER_PID_LISTENER = 3,
        TCP_TABLE_OWNER_PID_CONNECTIONS = 4,
        TCP_TABLE_OWNER_PID_ALL = 5,
        TCP_TABLE_OWNER_MODULE_LISTENER = 6,
        TCP_TABLE_OWNER_MODULE_CONNECTIONS = 7,
        TCP_TABLE_OWNER_MODULE_ALL = 8,
    }
    public enum TOKEN_ELEVATION_TYPE
    {
        TokenElevationTypeDefault = 1,
        TokenElevationTypeFull = 2,
        TokenElevationTypeLimited = 3,
    }
    public enum TOKEN_INFORMATION_CLASS
    {
        TokenUser = 1,
        TokenGroups = 2,
        TokenPrivileges = 3,
        TokenOwner = 4,
        TokenPrimaryGroup = 5,
        TokenDefaultDacl = 6,
        TokenSource = 7,
        TokenType = 8,
        TokenImpersonationLevel = 9,
        TokenStatistics = 10,
        TokenRestrictedSids = 11,
        TokenSessionId = 12,
        TokenGroupsAndPrivileges = 13,
        TokenSessionReference = 14,
        TokenSandBoxInert = 15,
        TokenAuditPolicy = 16,
        TokenOrigin = 17,
        TokenElevationType = 18,
        TokenLinkedToken = 19,
        TokenElevation = 20,
        TokenHasRestrictions = 21,
        TokenAccessInformation = 22,
        TokenVirtualizationAllowed = 23,
        TokenVirtualizationEnabled = 24,
        TokenIntegrityLevel = 25,
        TokenUIAccess = 26,
        TokenMandatoryPolicy = 27,
        TokenLogonSid = 28,
        TokenIsAppContainer = 29,
        TokenCapabilities = 30,
        TokenAppContainerSid = 31,
        TokenAppContainerNumber = 32,
        TokenUserClaimAttributes = 33,
        TokenDeviceClaimAttributes = 34,
        TokenRestrictedUserClaimAttributes = 35,
        TokenRestrictedDeviceClaimAttributes = 36,
        TokenDeviceGroups = 37,
        TokenRestrictedDeviceGroups = 38,
        TokenSecurityAttributes = 39,
        TokenIsRestricted = 40,
        MaxTokenInfoClass = 41,
    }
    public enum UpdateLayeredWindowFlags : uint
    {
        ULW_COLORKEY = 1u,
        ULW_ALPHA = 2u,
        ULW_OPAQUE = 4u,
    }
    public enum UxThemeClasses
    {
        AEROWIZARDSTYLE = 0,
        AEROWIZARD = 1,
        BUTTON = 2,
        BUTTONSTYLE = 3,
        CLOCK = 4,
        COMBOBOX = 5,
        COMMUNICATIONS = 6,
        CONTROLPANEL = 7,
        DATEPICKER = 8,
        DRAGDROP = 9,
        EDIT = 10,
        EXPLORERBAR = 11,
        FLYOUT = 12,
        GLOBALS = 13,
        HEADER = 14,
        LISTBOX = 15,
        LISTVIEW = 16,
        MENU = 17,
        MENUBAND = 18,
        NAVIGATION = 19,
        PAGE = 20,
        PROGRESS = 21,
        REBAR = 22,
        SCROLLBAR = 23,
        SPIN = 24,
        STARTPANEL = 25,
        STATUS = 26,
        TAB = 27,
        TASKBAND = 28,
        TASKBAR = 29,
        TASKDIALOG = 30,
        TEXTSTYLE = 31,
        TOOLBAR = 32,
        TOOLTIP = 33,
        TRACKBAR = 34,
        TRAYNOTIFY = 35,
        TREEVIEW = 36,
        WINDOW = 37,
    }
    public class UxThemeParts
    {
        public enum AEROWIZARDPARTS
        {
            AW_TITLEBAR = 1,
            AW_HEADERAREA = 2,
            AW_CONTENTAREA = 3,
            AW_COMMANDAREA = 4,
            AW_BUTTON = 5,
        }
        public enum ARROWBTNSTATES
        {
            ABS_UPNORMAL = 1,
            ABS_UPHOT = 2,
            ABS_UPPRESSED = 3,
            ABS_UPDISABLED = 4,
            ABS_DOWNNORMAL = 5,
            ABS_DOWNHOT = 6,
            ABS_DOWNPRESSED = 7,
            ABS_DOWNDISABLED = 8,
            ABS_LEFTNORMAL = 9,
            ABS_LEFTHOT = 10,
            ABS_LEFTPRESSED = 11,
            ABS_LEFTDISABLED = 12,
            ABS_RIGHTNORMAL = 13,
            ABS_RIGHTHOT = 14,
            ABS_RIGHTPRESSED = 15,
            ABS_RIGHTDISABLED = 16,
            ABS_UPHOVER = 17,
            ABS_DOWNHOVER = 18,
            ABS_LEFTHOVER = 19,
            ABS_RIGHTHOVER = 20,
        }
        public enum BACKGROUNDSTATES
        {
            EBS_NORMAL = 1,
            EBS_HOT = 2,
            EBS_DISABLED = 3,
            EBS_FOCUSED = 4,
            EBS_READONLY = 5,
            EBS_ASSIST = 6,
        }
        public enum BACKGROUNDWITHBORDERSTATES
        {
            EBWBS_NORMAL = 1,
            EBWBS_HOT = 2,
            EBWBS_DISABLED = 3,
            EBWBS_FOCUSED = 4,
        }
        public enum BALLOONSTATES
        {
            TTBS_NORMAL = 1,
            TTBS_LINK = 2,
        }
        public enum BALLOONSTEMSTATES
        {
            TTBSS_POINTINGUPLEFTWALL = 1,
            TTBSS_POINTINGUPCENTERED = 2,
            TTBSS_POINTINGUPRIGHTWALL = 3,
            TTBSS_POINTINGDOWNRIGHTWALL = 4,
            TTBSS_POINTINGDOWNCENTERED = 5,
            TTBSS_POINTINGDOWNLEFTWALL = 6,
        }
        public enum BARBACKGROUNDSTATES
        {
            MB_ACTIVE = 1,
            MB_INACTIVE = 2,
        }
        public enum BARITEMSTATES
        {
            MBI_NORMAL = 1,
            MBI_HOT = 2,
            MBI_PUSHED = 3,
            MBI_DISABLED = 4,
            MBI_DISABLEDHOT = 5,
            MBI_DISABLEDPUSHED = 6,
        }
        public enum BODYSTATES
        {
            FBS_NORMAL = 1,
            FBS_EMPHASIZED = 2,
        }
        public enum BORDER_HSCROLLSTATES
        {
            LBPSH_NORMAL = 1,
            LBPSH_FOCUSED = 2,
            LBPSH_HOT = 3,
            LBPSH_DISABLED = 4,
        }
        public enum BORDER_HVSCROLLSTATES
        {
            LBPSHV_NORMAL = 1,
            LBPSHV_FOCUSED = 2,
            LBPSHV_HOT = 3,
            LBPSHV_DISABLED = 4,
        }
        public enum BORDER_NOSCROLLSTATES
        {
            LBPSN_NORMAL = 1,
            LBPSN_FOCUSED = 2,
            LBPSN_HOT = 3,
            LBPSN_DISABLED = 4,
        }
        public enum BORDER_VSCROLLSTATES
        {
            LBPSV_NORMAL = 1,
            LBPSV_FOCUSED = 2,
            LBPSV_HOT = 3,
            LBPSV_DISABLED = 4,
        }
        public enum BORDERSTATES
        {
            CBB_NORMAL = 1,
            CBB_HOT = 2,
            CBB_FOCUSED = 3,
            CBB_DISABLED = 4,
        }
        public enum BUTTONPARTS
        {
            BP_PUSHBUTTON = 1,
            BP_RADIOBUTTON = 2,
            BP_CHECKBOX = 3,
            BP_GROUPBOX = 4,
            BP_USERBUTTON = 5,
            BP_COMMANDLINK = 6,
            BP_COMMANDLINKGLYPH = 7,
        }
        public enum CAPTIONSTATES
        {
            CS_ACTIVE = 1,
            CS_INACTIVE = 2,
            CS_DISABLED = 3,
        }
        public enum CHECKBOXSTATES
        {
            CBS_UNCHECKEDNORMAL = 1,
            CBS_UNCHECKEDHOT = 2,
            CBS_UNCHECKEDPRESSED = 3,
            CBS_UNCHECKEDDISABLED = 4,
            CBS_CHECKEDNORMAL = 5,
            CBS_CHECKEDHOT = 6,
            CBS_CHECKEDPRESSED = 7,
            CBS_CHECKEDDISABLED = 8,
            CBS_MIXEDNORMAL = 9,
            CBS_MIXEDHOT = 10,
            CBS_MIXEDPRESSED = 11,
            CBS_MIXEDDISABLED = 12,
            CBS_IMPLICITNORMAL = 13,
            CBS_IMPLICITHOT = 14,
            CBS_IMPLICITPRESSED = 15,
            CBS_IMPLICITDISABLED = 16,
            CBS_EXCLUDEDNORMAL = 17,
            CBS_EXCLUDEDHOT = 18,
            CBS_EXCLUDEDPRESSED = 19,
            CBS_EXCLUDEDDISABLED = 20,
        }
        public enum CHEVRONSTATES
        {
            CHEVS_NORMAL = 1,
            CHEVS_HOT = 2,
            CHEVS_PRESSED = 3,
        }
        public enum CHEVRONVERTSTATES
        {
            CHEVSV_NORMAL = 1,
            CHEVSV_HOT = 2,
            CHEVSV_PRESSED = 3,
        }
        public enum CLOSEBUTTONSTATES
        {
            CBS_NORMAL = 1,
            CBS_HOT = 2,
            CBS_PUSHED = 3,
            CBS_DISABLED = 4,
        }
        public enum CLOSESTATES
        {
            TTCS_NORMAL = 1,
            TTCS_HOT = 2,
            TTCS_PRESSED = 3,
        }
        public enum COLLAPSEBUTTONSTATES
        {
            LVCB_NORMAL = 1,
            LVCB_HOVER = 2,
            LVCB_PUSHED = 3,
        }
        public enum COMBOBOXPARTS
        {
            CP_DROPDOWNBUTTON = 1,
            CP_BACKGROUND = 2,
            CP_TRANSPARENTBACKGROUND = 3,
            CP_BORDER = 4,
            CP_READONLY = 5,
            CP_DROPDOWNBUTTONRIGHT = 6,
            CP_DROPDOWNBUTTONLEFT = 7,
            CP_CUEBANNER = 8,
        }
        public enum COMBOBOXSTYLESTATES
        {
            CBXS_NORMAL = 1,
            CBXS_HOT = 2,
            CBXS_PRESSED = 3,
            CBXS_DISABLED = 4,
        }
        public enum COMMANDLINKGLYPHSTATES
        {
            CMDLGS_NORMAL = 1,
            CMDLGS_HOT = 2,
            CMDLGS_PRESSED = 3,
            CMDLGS_DISABLED = 4,
            CMDLGS_DEFAULTED = 5,
        }
        public enum COMMANDLINKSTATES
        {
            CMDLS_NORMAL = 1,
            CMDLS_HOT = 2,
            CMDLS_PRESSED = 3,
            CMDLS_DISABLED = 4,
            CMDLS_DEFAULTED = 5,
            CMDLS_DEFAULTED_ANIMATING = 6,
        }
        public enum COMMUNICATIONSPARTS
        {
            CSST_TAB = 1,
        }
        public enum CONTENTAREASTATES
        {
            AW_S_CONTENTAREA_NOMARGIN = 1,
        }
        public enum CONTENTLINKSTATES
        {
            CPCL_NORMAL = 1,
            CPCL_HOT = 2,
            CPCL_PRESSED = 3,
            CPCL_DISABLED = 4,
        }
        public enum CONTENTPANESTATES
        {
            TDLGCPS_STANDALONE = 1,
        }
        public enum CONTROLLABELSTATES
        {
            TS_CONTROLLABEL_NORMAL = 1,
            TS_CONTROLLABEL_DISABLED = 2,
        }
        public enum CONTROLPANELPARTS
        {
            CPANEL_NAVIGATIONPANE = 1,
            CPANEL_CONTENTPANE = 2,
            CPANEL_NAVIGATIONPANELABEL = 3,
            CPANEL_CONTENTPANELABEL = 4,
            CPANEL_TITLE = 5,
            CPANEL_BODYTEXT = 6,
            CPANEL_HELPLINK = 7,
            CPANEL_TASKLINK = 8,
            CPANEL_GROUPTEXT = 9,
            CPANEL_CONTENTLINK = 10,
            CPANEL_SECTIONTITLELINK = 11,
            CPANEL_LARGECOMMANDAREA = 12,
            CPANEL_SMALLCOMMANDAREA = 13,
            CPANEL_BUTTON = 14,
            CPANEL_MESSAGETEXT = 15,
            CPANEL_NAVIGATIONPANELINE = 16,
            CPANEL_CONTENTPANELINE = 17,
            CPANEL_BANNERAREA = 18,
            CPANEL_BODYTITLE = 19,
        }
        public enum COPYSTATES
        {
            DDCOPY_HIGHLIGHT = 1,
            DDCOPY_NOHIGHLIGHT = 2,
        }
        public enum CREATELINKSTATES
        {
            DDCREATELINK_HIGHLIGHT = 1,
            DDCREATELINK_NOHIGHLIGHT = 2,
        }
        public enum CUEBANNERSTATES
        {
            CBCB_NORMAL = 1,
            CBCB_HOT = 2,
            CBCB_PRESSED = 3,
            CBCB_DISABLED = 4,
        }
        public enum DATEBORDERSTATES
        {
            DPDB_NORMAL = 1,
            DPDB_HOT = 2,
            DPDB_FOCUSED = 3,
            DPDB_DISABLED = 4,
        }
        public enum DATEPICKERPARTS
        {
            DP_DATETEXT = 1,
            DP_DATEBORDER = 2,
            DP_SHOWCALENDARBUTTONRIGHT = 3,
        }
        public enum DATETEXTSTATES
        {
            DPDT_NORMAL = 1,
            DPDT_DISABLED = 2,
            DPDT_SELECTED = 3,
        }
        public enum Defines
        {
            TMTVS_RESERVEDLOW = 100000,
            TMTVS_RESERVEDHIGH = 19999,
        }
        public enum DOWNHORZSTATES
        {
            DNHZS_NORMAL = 1,
            DNHZS_HOT = 2,
            DNHZS_PRESSED = 3,
            DNHZS_DISABLED = 4,
        }
        public enum DOWNSTATES
        {
            DNS_NORMAL = 1,
            DNS_HOT = 2,
            DNS_PRESSED = 3,
            DNS_DISABLED = 4,
        }
        public enum DRAGDROPPARTS
        {
            DD_COPY = 1,
            DD_MOVE = 2,
            DD_UPDATEMETADATA = 3,
            DD_CREATELINK = 4,
            DD_WARNING = 5,
            DD_NONE = 6,
            DD_IMAGEBG = 7,
            DD_TEXTBG = 8,
        }
        public enum DROPDOWNBUTTONLEFTSTATES
        {
            CBXSL_NORMAL = 1,
            CBXSL_HOT = 2,
            CBXSL_PRESSED = 3,
            CBXSL_DISABLED = 4,
        }
        public enum DROPDOWNBUTTONRIGHTSTATES
        {
            CBXSR_NORMAL = 1,
            CBXSR_HOT = 2,
            CBXSR_PRESSED = 3,
            CBXSR_DISABLED = 4,
        }
        public enum EDITBORDER_HSCROLLSTATES
        {
            EPSH_NORMAL = 1,
            EPSH_HOT = 2,
            EPSH_FOCUSED = 3,
            EPSH_DISABLED = 4,
        }
        public enum EDITBORDER_HVSCROLLSTATES
        {
            EPSHV_NORMAL = 1,
            EPSHV_HOT = 2,
            EPSHV_FOCUSED = 3,
            EPSHV_DISABLED = 4,
        }
        public enum EDITBORDER_NOSCROLLSTATES
        {
            EPSN_NORMAL = 1,
            EPSN_HOT = 2,
            EPSN_FOCUSED = 3,
            EPSN_DISABLED = 4,
        }
        public enum EDITBORDER_VSCROLLSTATES
        {
            EPSV_NORMAL = 1,
            EPSV_HOT = 2,
            EPSV_FOCUSED = 3,
            EPSV_DISABLED = 4,
        }
        public enum EDITPARTS
        {
            EP_EDITTEXT = 1,
            EP_CARET = 2,
            EP_BACKGROUND = 3,
            EP_PASSWORD = 4,
            EP_BACKGROUNDWITHBORDER = 5,
            EP_EDITBORDER_NOSCROLL = 6,
            EP_EDITBORDER_HSCROLL = 7,
            EP_EDITBORDER_VSCROLL = 8,
            EP_EDITBORDER_HVSCROLL = 9,
        }
        public enum EDITTEXTSTATES
        {
            ETS_NORMAL = 1,
            ETS_HOT = 2,
            ETS_SELECTED = 3,
            ETS_DISABLED = 4,
            ETS_FOCUSED = 5,
            ETS_READONLY = 6,
            ETS_ASSIST = 7,
            ETS_CUEBANNER = 8,
        }
        public enum EXPANDBUTTONSTATES
        {
            LVEB_NORMAL = 1,
            LVEB_HOVER = 2,
            LVEB_PUSHED = 3,
        }
        public enum EXPANDOBUTTONSTATES
        {
            TDLGEBS_NORMAL = 1,
            TDLGEBS_HOVER = 2,
            TDLGEBS_PRESSED = 3,
            TDLGEBS_EXPANDEDNORMAL = 4,
            TDLGEBS_EXPANDEDHOVER = 5,
            TDLGEBS_EXPANDEDPRESSED = 6,
        }
        public enum EXPLORERBARPARTS
        {
            EBP_HEADERBACKGROUND = 1,
            EBP_HEADERCLOSE = 2,
            EBP_HEADERPIN = 3,
            EBP_IEBARMENU = 4,
            EBP_NORMALGROUPBACKGROUND = 5,
            EBP_NORMALGROUPCOLLAPSE = 6,
            EBP_NORMALGROUPEXPAND = 7,
            EBP_NORMALGROUPHEAD = 8,
            EBP_SPECIALGROUPBACKGROUND = 9,
            EBP_SPECIALGROUPCOLLAPSE = 10,
            EBP_SPECIALGROUPEXPAND = 11,
            EBP_SPECIALGROUPHEAD = 12,
        }
        public enum FILLSTATES
        {
            PBFS_NORMAL = 1,
            PBFS_ERROR = 2,
            PBFS_PAUSED = 3,
            PBFS_PARTIAL = 4,
        }
        public enum FILLVERTSTATES
        {
            PBFVS_NORMAL = 1,
            PBFVS_ERROR = 2,
            PBFVS_PAUSED = 3,
            PBFVS_PARTIAL = 4,
        }
        public enum FLYOUTPARTS
        {
            FLYOUT_HEADER = 1,
            FLYOUT_BODY = 2,
            FLYOUT_LABEL = 3,
            FLYOUT_LINK = 4,
            FLYOUT_DIVIDER = 5,
            FLYOUT_WINDOW = 6,
            FLYOUT_LINKAREA = 7,
            FLYOUT_LINKHEADER = 8,
        }
        public enum FRAMESTATES
        {
            FS_ACTIVE = 1,
            FS_INACTIVE = 2,
        }
        public enum GLYPHSTATES
        {
            GLPS_CLOSED = 1,
            GLPS_OPENED = 2,
        }
        public enum GROUPBOXSTATES
        {
            GBS_NORMAL = 1,
            GBS_DISABLED = 2,
        }
        public enum GROUPHEADERLINESTATES
        {
            LVGHL_OPEN = 1,
            LVGHL_OPENHOT = 2,
            LVGHL_OPENSELECTED = 3,
            LVGHL_OPENSELECTEDHOT = 4,
            LVGHL_OPENSELECTEDNOTFOCUSED = 5,
            LVGHL_OPENSELECTEDNOTFOCUSEDHOT = 6,
            LVGHL_OPENMIXEDSELECTION = 7,
            LVGHL_OPENMIXEDSELECTIONHOT = 8,
            LVGHL_CLOSE = 9,
            LVGHL_CLOSEHOT = 10,
            LVGHL_CLOSESELECTED = 11,
            LVGHL_CLOSESELECTEDHOT = 12,
            LVGHL_CLOSESELECTEDNOTFOCUSED = 13,
            LVGHL_CLOSESELECTEDNOTFOCUSEDHOT = 14,
            LVGHL_CLOSEMIXEDSELECTION = 15,
            LVGHL_CLOSEMIXEDSELECTIONHOT = 16,
        }
        public enum GROUPHEADERSTATES
        {
            LVGH_OPEN = 1,
            LVGH_OPENHOT = 2,
            LVGH_OPENSELECTED = 3,
            LVGH_OPENSELECTEDHOT = 4,
            LVGH_OPENSELECTEDNOTFOCUSED = 5,
            LVGH_OPENSELECTEDNOTFOCUSEDHOT = 6,
            LVGH_OPENMIXEDSELECTION = 7,
            LVGH_OPENMIXEDSELECTIONHOT = 8,
            LVGH_CLOSE = 9,
            LVGH_CLOSEHOT = 10,
            LVGH_CLOSESELECTED = 11,
            LVGH_CLOSESELECTEDHOT = 12,
            LVGH_CLOSESELECTEDNOTFOCUSED = 13,
            LVGH_CLOSESELECTEDNOTFOCUSEDHOT = 14,
            LVGH_CLOSEMIXEDSELECTION = 15,
            LVGH_CLOSEMIXEDSELECTIONHOT = 16,
        }
        public enum HEADERAREASTATES
        {
            AW_S_HEADERAREA_NOMARGIN = 1,
        }
        public enum HEADERCLOSESTATES
        {
            EBHC_NORMAL = 1,
            EBHC_HOT = 2,
            EBHC_PRESSED = 3,
        }
        public enum HEADERDROPDOWNFILTERSTATES
        {
            HDDFS_NORMAL = 1,
            HDDFS_SOFTHOT = 2,
            HDDFS_HOT = 3,
        }
        public enum HEADERDROPDOWNSTATES
        {
            HDDS_NORMAL = 1,
            HDDS_SOFTHOT = 2,
            HDDS_HOT = 3,
        }
        public enum HEADERITEMLEFTSTATES
        {
            HILS_NORMAL = 1,
            HILS_HOT = 2,
            HILS_PRESSED = 3,
        }
        public enum HEADERITEMRIGHTSTATES
        {
            HIRS_NORMAL = 1,
            HIRS_HOT = 2,
            HIRS_PRESSED = 3,
        }
        public enum HEADERITEMSTATES
        {
            HIS_NORMAL = 1,
            HIS_HOT = 2,
            HIS_PRESSED = 3,
            HIS_SORTEDNORMAL = 4,
            HIS_SORTEDHOT = 5,
            HIS_SORTEDPRESSED = 6,
            HIS_ICONNORMAL = 7,
            HIS_ICONHOT = 8,
            HIS_ICONPRESSED = 9,
            HIS_ICONSORTEDNORMAL = 10,
            HIS_ICONSORTEDHOT = 11,
            HIS_ICONSORTEDPRESSED = 12,
        }
        public enum HEADEROVERFLOWSTATES
        {
            HOFS_NORMAL = 1,
            HOFS_HOT = 2,
        }
        public enum HEADERPARTS
        {
            HP_HEADERITEM = 1,
            HP_HEADERITEMLEFT = 2,
            HP_HEADERITEMRIGHT = 3,
            HP_HEADERSORTARROW = 4,
            HP_HEADERDROPDOWN = 5,
            HP_HEADERDROPDOWNFILTER = 6,
            HP_HEADEROVERFLOW = 7,
        }
        public enum HEADERPINSTATES
        {
            EBHP_NORMAL = 1,
            EBHP_HOT = 2,
            EBHP_PRESSED = 3,
            EBHP_SELECTEDNORMAL = 4,
            EBHP_SELECTEDHOT = 5,
            EBHP_SELECTEDPRESSED = 6,
        }
        public enum HEADERSORTARROWSTATES
        {
            HSAS_SORTEDUP = 1,
            HSAS_SORTEDDOWN = 2,
        }
        public enum HEADERSTYLESTATES
        {
            HBG_DETAILS = 1,
            HBG_ICON = 2,
        }
        public enum HELPBUTTONSTATES
        {
            HBS_NORMAL = 1,
            HBS_HOT = 2,
            HBS_PUSHED = 3,
            HBS_DISABLED = 4,
        }
        public enum HELPLINKSTATES
        {
            CPHL_NORMAL = 1,
            CPHL_HOT = 2,
            CPHL_PRESSED = 3,
            CPHL_DISABLED = 4,
        }
        public enum HORZSCROLLSTATES
        {
            HSS_NORMAL = 1,
            HSS_HOT = 2,
            HSS_PUSHED = 3,
            HSS_DISABLED = 4,
        }
        public enum HORZTHUMBSTATES
        {
            HTS_NORMAL = 1,
            HTS_HOT = 2,
            HTS_PUSHED = 3,
            HTS_DISABLED = 4,
        }
        public enum HOTGLYPHSTATES
        {
            HGLPS_CLOSED = 1,
            HGLPS_OPENED = 2,
        }
        public enum HYPERLINKTEXTSTATES
        {
            TS_HYPERLINK_NORMAL = 1,
            TS_HYPERLINK_HOT = 2,
            TS_HYPERLINK_PRESSED = 3,
            TS_HYPERLINK_DISABLED = 4,
        }
        public enum IEBARMENUSTATES
        {
            EBM_NORMAL = 1,
            EBM_HOT = 2,
            EBM_PRESSED = 3,
        }
        public enum ITEMSTATES
        {
            LBPSI_HOT = 1,
            LBPSI_HOTSELECTED = 2,
            LBPSI_SELECTED = 3,
            LBPSI_SELECTEDNOTFOCUS = 4,
        }
        public enum LABELSTATES
        {
            FLS_NORMAL = 1,
            FLS_SELECTED = 2,
            FLS_EMPHASIZED = 3,
            FLS_DISABLED = 4,
        }
        public enum LINKHEADERSTATES
        {
            FLH_NORMAL = 1,
            FLH_HOVER = 2,
        }
        public enum LINKSTATES
        {
            FLYOUTLINK_NORMAL = 1,
            FLYOUTLINK_HOVER = 2,
        }
        public enum LISTBOXPARTS
        {
            LBCP_BORDER_HSCROLL = 1,
            LBCP_BORDER_HVSCROLL = 2,
            LBCP_BORDER_NOSCROLL = 3,
            LBCP_BORDER_VSCROLL = 4,
            LBCP_ITEM = 5,
        }
        public enum LISTITEMSTATES
        {
            LISS_NORMAL = 1,
            LISS_HOT = 2,
            LISS_SELECTED = 3,
            LISS_DISABLED = 4,
            LISS_SELECTEDNOTFOCUS = 5,
            LISS_HOTSELECTED = 6,
        }
        public enum LISTVIEWPARTS
        {
            LVP_LISTITEM = 1,
            LVP_LISTGROUP = 2,
            LVP_LISTDETAIL = 3,
            LVP_LISTSORTEDDETAIL = 4,
            LVP_EMPTYTEXT = 5,
            LVP_GROUPHEADER = 6,
            LVP_GROUPHEADERLINE = 7,
            LVP_EXPANDBUTTON = 8,
            LVP_COLLAPSEBUTTON = 9,
            LVP_COLUMNDETAIL = 10,
        }
        public enum MAXBUTTONSTATES
        {
            MAXBS_NORMAL = 1,
            MAXBS_HOT = 2,
            MAXBS_PUSHED = 3,
            MAXBS_DISABLED = 4,
        }
        public enum MAXCAPTIONSTATES
        {
            MXCS_ACTIVE = 1,
            MXCS_INACTIVE = 2,
            MXCS_DISABLED = 3,
        }
        public enum MENUPARTS
        {
            MENU_MENUITEM_TMSCHEMA = 1,
            MENU_MENUDROPDOWN_TMSCHEMA = 2,
            MENU_MENUBARITEM_TMSCHEMA = 3,
            MENU_MENUBARDROPDOWN_TMSCHEMA = 4,
            MENU_CHEVRON_TMSCHEMA = 5,
            MENU_SEPARATOR_TMSCHEMA = 6,
            MENU_BARBACKGROUND = 7,
            MENU_BARITEM = 8,
            MENU_POPUPBACKGROUND = 9,
            MENU_POPUPBORDERS = 10,
            MENU_POPUPCHECK = 11,
            MENU_POPUPCHECKBACKGROUND = 12,
            MENU_POPUPGUTTER = 13,
            MENU_POPUPITEM = 14,
            MENU_POPUPSEPARATOR = 15,
            MENU_POPUPSUBMENU = 16,
            MENU_SYSTEMCLOSE = 17,
            MENU_SYSTEMMAXIMIZE = 18,
            MENU_SYSTEMMINIMIZE = 19,
            MENU_SYSTEMRESTORE = 20,
        }
        public enum MINBUTTONSTATES
        {
            MINBS_NORMAL = 1,
            MINBS_HOT = 2,
            MINBS_PUSHED = 3,
            MINBS_DISABLED = 4,
        }
        public enum MINCAPTIONSTATES
        {
            MNCS_ACTIVE = 1,
            MNCS_INACTIVE = 2,
            MNCS_DISABLED = 3,
        }
        public enum MOVESTATES
        {
            DDMOVE_HIGHLIGHT = 1,
            DDMOVE_NOHIGHLIGHT = 2,
        }
        public enum NAV_BACKBUTTONSTATES
        {
            NAV_BB_NORMAL = 1,
            NAV_BB_HOT = 2,
            NAV_BB_PRESSED = 3,
            NAV_BB_DISABLED = 4,
        }
        public enum NAV_FORWARDBUTTONSTATES
        {
            NAV_FB_NORMAL = 1,
            NAV_FB_HOT = 2,
            NAV_FB_PRESSED = 3,
            NAV_FB_DISABLED = 4,
        }
        public enum NAV_MENUBUTTONSTATES
        {
            NAV_MB_NORMAL = 1,
            NAV_MB_HOT = 2,
            NAV_MB_PRESSED = 3,
            NAV_MB_DISABLED = 4,
        }
        public enum NAVIGATIONPARTS
        {
            NAV_BACKBUTTON = 1,
            NAV_FORWARDBUTTON = 2,
            NAV_MENUBUTTON = 3,
        }
        public enum NONESTATES
        {
            DDNONE_HIGHLIGHT = 1,
            DDNONE_NOHIGHLIGHT = 2,
        }
        public enum NORMALGROUPCOLLAPSESTATES
        {
            EBNGC_NORMAL = 1,
            EBNGC_HOT = 2,
            EBNGC_PRESSED = 3,
        }
        public enum NORMALGROUPEXPANDSTATES
        {
            EBNGE_NORMAL = 1,
            EBNGE_HOT = 2,
            EBNGE_PRESSED = 3,
        }
        public enum POPUPCHECKBACKGROUNDSTATES
        {
            MCB_DISABLED = 1,
            MCB_NORMAL = 2,
            MCB_BITMAP = 3,
        }
        public enum POPUPCHECKSTATES
        {
            MC_CHECKMARKNORMAL = 1,
            MC_CHECKMARKDISABLED = 2,
            MC_BULLETNORMAL = 3,
            MC_BULLETDISABLED = 4,
        }
        public enum POPUPITEMSTATES
        {
            MPI_NORMAL = 1,
            MPI_HOT = 2,
            MPI_DISABLED = 3,
            MPI_DISABLEDHOT = 4,
        }
        public enum POPUPSUBMENUSTATES
        {
            MSM_NORMAL = 1,
            MSM_DISABLED = 2,
        }
        public enum PROGRESSPARTS
        {
            PP_BAR = 1,
            PP_BARVERT = 2,
            PP_CHUNK = 3,
            PP_CHUNKVERT = 4,
            PP_FILL = 5,
            PP_FILLVERT = 6,
            PP_PULSEOVERLAY = 7,
            PP_MOVEOVERLAY = 8,
            PP_PULSEOVERLAYVERT = 9,
            PP_MOVEOVERLAYVERT = 10,
            PP_TRANSPARENTBAR = 11,
            PP_TRANSPARENTBARVERT = 12,
        }
        public enum PUSHBUTTONSTATES
        {
            PBS_NORMAL = 1,
            PBS_HOT = 2,
            PBS_PRESSED = 3,
            PBS_DISABLED = 4,
            PBS_DEFAULTED = 5,
            PBS_DEFAULTED_ANIMATING = 6,
        }
        public enum RADIOBUTTONSTATES
        {
            RBS_UNCHECKEDNORMAL = 1,
            RBS_UNCHECKEDHOT = 2,
            RBS_UNCHECKEDPRESSED = 3,
            RBS_UNCHECKEDDISABLED = 4,
            RBS_CHECKEDNORMAL = 5,
            RBS_CHECKEDHOT = 6,
            RBS_CHECKEDPRESSED = 7,
            RBS_CHECKEDDISABLED = 8,
        }
        public enum READONLYSTATES
        {
            CBRO_NORMAL = 1,
            CBRO_HOT = 2,
            CBRO_PRESSED = 3,
            CBRO_DISABLED = 4,
        }
        public enum REBARPARTS
        {
            RP_GRIPPER = 1,
            RP_GRIPPERVERT = 2,
            RP_BAND = 3,
            RP_CHEVRON = 4,
            RP_CHEVRONVERT = 5,
            RP_BACKGROUND = 6,
            RP_SPLITTER = 7,
            RP_SPLITTERVERT = 8,
        }
        public enum RESTOREBUTTONSTATES
        {
            RBS_NORMAL = 1,
            RBS_HOT = 2,
            RBS_PUSHED = 3,
            RBS_DISABLED = 4,
        }
        public enum SCROLLBARPARTS
        {
            SBP_ARROWBTN = 1,
            SBP_THUMBBTNHORZ = 2,
            SBP_THUMBBTNVERT = 3,
            SBP_LOWERTRACKHORZ = 4,
            SBP_UPPERTRACKHORZ = 5,
            SBP_LOWERTRACKVERT = 6,
            SBP_UPPERTRACKVERT = 7,
            SBP_GRIPPERHORZ = 8,
            SBP_GRIPPERVERT = 9,
            SBP_SIZEBOX = 10,
        }
        public enum SCROLLBARSTYLESTATES
        {
            SCRBS_NORMAL = 1,
            SCRBS_HOT = 2,
            SCRBS_PRESSED = 3,
            SCRBS_DISABLED = 4,
            SCRBS_HOVER = 5,
        }
        public enum SECTIONTITLELINKSTATES
        {
            CPSTL_NORMAL = 1,
            CPSTL_HOT = 2,
        }
        public enum SHOWCALENDARBUTTONRIGHTSTATES
        {
            DPSCBR_NORMAL = 1,
            DPSCBR_HOT = 2,
            DPSCBR_PRESSED = 3,
            DPSCBR_DISABLED = 4,
        }
        public enum SIZEBOXSTATES
        {
            SZB_RIGHTALIGN = 1,
            SZB_LEFTALIGN = 2,
            SZB_TOPRIGHTALIGN = 3,
            SZB_TOPLEFTALIGN = 4,
            SZB_HALFBOTTOMRIGHTALIGN = 5,
            SZB_HALFBOTTOMLEFTALIGN = 6,
            SZB_HALFTOPRIGHTALIGN = 7,
            SZB_HALFTOPLEFTALIGN = 8,
        }
        public enum SPECIALGROUPCOLLAPSESTATES
        {
            EBSGC_NORMAL = 1,
            EBSGC_HOT = 2,
            EBSGC_PRESSED = 3,
        }
        public enum SPECIALGROUPEXPANDSTATES
        {
            EBSGE_NORMAL = 1,
            EBSGE_HOT = 2,
            EBSGE_PRESSED = 3,
        }
        public enum SPINPARTS
        {
            SPNP_UP = 1,
            SPNP_DOWN = 2,
            SPNP_UPHORZ = 3,
            SPNP_DOWNHORZ = 4,
        }
        public enum SPLITTERSTATES
        {
            SPLITS_NORMAL = 1,
            SPLITS_HOT = 2,
            SPLITS_PRESSED = 3,
        }
        public enum SPLITTERVERTSTATES
        {
            SPLITSV_NORMAL = 1,
            SPLITSV_HOT = 2,
            SPLITSV_PRESSED = 3,
        }
        public enum STANDARDSTATES
        {
            TTSS_NORMAL = 1,
            TTSS_LINK = 2,
        }
        public enum STATUSPARTS
        {
            SP_PANE = 1,
            SP_GRIPPERPANE = 2,
            SP_GRIPPER = 3,
        }
        public enum SYSBUTTONSTATES
        {
            SBS_NORMAL = 1,
            SBS_HOT = 2,
            SBS_PUSHED = 3,
            SBS_DISABLED = 4,
        }
        public enum SYSTEMCLOSESTATES
        {
            MSYSC_NORMAL = 1,
            MSYSC_DISABLED = 2,
        }
        public enum SYSTEMMAXIMIZESTATES
        {
            MSYSMX_NORMAL = 1,
            MSYSMX_DISABLED = 2,
        }
        public enum SYSTEMMINIMIZESTATES
        {
            MSYSMN_NORMAL = 1,
            MSYSMN_DISABLED = 2,
        }
        public enum SYSTEMRESTORESTATES
        {
            MSYSR_NORMAL = 1,
            MSYSR_DISABLED = 2,
        }
        public enum TABITEMBOTHEDGESTATES
        {
            TIBES_NORMAL = 1,
            TIBES_HOT = 2,
            TIBES_SELECTED = 3,
            TIBES_DISABLED = 4,
            TIBES_FOCUSED = 5,
        }
        public enum TABITEMLEFTEDGESTATES
        {
            TILES_NORMAL = 1,
            TILES_HOT = 2,
            TILES_SELECTED = 3,
            TILES_DISABLED = 4,
            TILES_FOCUSED = 5,
        }
        public enum TABITEMRIGHTEDGESTATES
        {
            TIRES_NORMAL = 1,
            TIRES_HOT = 2,
            TIRES_SELECTED = 3,
            TIRES_DISABLED = 4,
            TIRES_FOCUSED = 5,
        }
        public enum TABITEMSTATES
        {
            TIS_NORMAL = 1,
            TIS_HOT = 2,
            TIS_SELECTED = 3,
            TIS_DISABLED = 4,
            TIS_FOCUSED = 5,
        }
        public enum TABPARTS
        {
            TABP_TABITEM = 1,
            TABP_TABITEMLEFTEDGE = 2,
            TABP_TABITEMRIGHTEDGE = 3,
            TABP_TABITEMBOTHEDGE = 4,
            TABP_TOPTABITEM = 5,
            TABP_TOPTABITEMLEFTEDGE = 6,
            TABP_TOPTABITEMRIGHTEDGE = 7,
            TABP_TOPTABITEMBOTHEDGE = 8,
            TABP_PANE = 9,
            TABP_BODY = 10,
            TABP_AEROWIZARDBODY = 11,
        }
        public enum TABSTATES
        {
            CSTB_NORMAL = 1,
            CSTB_HOT = 2,
            CSTB_SELECTED = 3,
        }
        public enum TASKDIALOGPARTS
        {
            TDLG_PRIMARYPANEL = 1,
            TDLG_MAININSTRUCTIONPANE = 2,
            TDLG_MAINICON = 3,
            TDLG_CONTENTPANE = 4,
            TDLG_CONTENTICON = 5,
            TDLG_EXPANDEDCONTENT = 6,
            TDLG_COMMANDLINKPANE = 7,
            TDLG_SECONDARYPANEL = 8,
            TDLG_CONTROLPANE = 9,
            TDLG_BUTTONSECTION = 10,
            TDLG_BUTTONWRAPPER = 11,
            TDLG_EXPANDOTEXT = 12,
            TDLG_EXPANDOBUTTON = 13,
            TDLG_VERIFICATIONTEXT = 14,
            TDLG_FOOTNOTEPANE = 15,
            TDLG_FOOTNOTEAREA = 16,
            TDLG_FOOTNOTESEPARATOR = 17,
            TDLG_EXPANDEDFOOTERAREA = 18,
            TDLG_PROGRESSBAR = 19,
            TDLG_IMAGEALIGNMENT = 20,
            TDLG_RADIOBUTTONPANE = 21,
        }
        public enum TASKLINKSTATES
        {
            CPTL_NORMAL = 1,
            CPTL_HOT = 2,
            CPTL_PRESSED = 3,
            CPTL_DISABLED = 4,
            CPTL_PAGE = 5,
        }
        public enum TEXTSTYLEPARTS
        {
            TEXT_MAININSTRUCTION = 1,
            TEXT_INSTRUCTION = 2,
            TEXT_BODYTITLE = 3,
            TEXT_BODYTEXT = 4,
            TEXT_SECONDARYTEXT = 5,
            TEXT_HYPERLINKTEXT = 6,
            TEXT_EXPANDED = 7,
            TEXT_LABEL = 8,
            TEXT_CONTROLLABEL = 9,
        }
        public enum THUMBBOTTOMSTATES
        {
            TUBS_NORMAL = 1,
            TUBS_HOT = 2,
            TUBS_PRESSED = 3,
            TUBS_FOCUSED = 4,
            TUBS_DISABLED = 5,
        }
        public enum THUMBLEFTSTATES
        {
            TUVLS_NORMAL = 1,
            TUVLS_HOT = 2,
            TUVLS_PRESSED = 3,
            TUVLS_FOCUSED = 4,
            TUVLS_DISABLED = 5,
        }
        public enum THUMBRIGHTSTATES
        {
            TUVRS_NORMAL = 1,
            TUVRS_HOT = 2,
            TUVRS_PRESSED = 3,
            TUVRS_FOCUSED = 4,
            TUVRS_DISABLED = 5,
        }
        public enum THUMBSTATES
        {
            TUS_NORMAL = 1,
            TUS_HOT = 2,
            TUS_PRESSED = 3,
            TUS_FOCUSED = 4,
            TUS_DISABLED = 5,
        }
        public enum THUMBTOPSTATES
        {
            TUTS_NORMAL = 1,
            TUTS_HOT = 2,
            TUTS_PRESSED = 3,
            TUTS_FOCUSED = 4,
            TUTS_DISABLED = 5,
        }
        public enum THUMBVERTSTATES
        {
            TUVS_NORMAL = 1,
            TUVS_HOT = 2,
            TUVS_PRESSED = 3,
            TUVS_FOCUSED = 4,
            TUVS_DISABLED = 5,
        }
        public enum TICSSTATES
        {
            TSS_NORMAL = 1,
        }
        public enum TICSVERTSTATES
        {
            TSVS_NORMAL = 1,
        }
        public enum TITLEBARSTATES
        {
            AW_S_TITLEBAR_ACTIVE = 1,
            AW_S_TITLEBAR_INACTIVE = 2,
        }
        public enum TOOLBARPARTS
        {
            TP_BUTTON = 1,
            TP_DROPDOWNBUTTON = 2,
            TP_SPLITBUTTON = 3,
            TP_SPLITBUTTONDROPDOWN = 4,
            TP_SEPARATOR = 5,
            TP_SEPARATORVERT = 6,
        }
        public enum TOOLBARSTYLESTATES
        {
            TS_NORMAL = 1,
            TS_HOT = 2,
            TS_PRESSED = 3,
            TS_DISABLED = 4,
            TS_CHECKED = 5,
            TS_HOTCHECKED = 6,
            TS_NEARHOT = 7,
            TS_OTHERSIDEHOT = 8,
        }
        public enum TOOLTIPPARTS
        {
            TTP_STANDARD = 1,
            TTP_STANDARDTITLE = 2,
            TTP_BALLOON = 3,
            TTP_BALLOONTITLE = 4,
            TTP_CLOSE = 5,
            TTP_BALLOONSTEM = 6,
        }
        public enum TOPTABITEMBOTHEDGESTATES
        {
            TTIBES_NORMAL = 1,
            TTIBES_HOT = 2,
            TTIBES_SELECTED = 3,
            TTIBES_DISABLED = 4,
            TTIBES_FOCUSED = 5,
        }
        public enum TOPTABITEMLEFTEDGESTATES
        {
            TTILES_NORMAL = 1,
            TTILES_HOT = 2,
            TTILES_SELECTED = 3,
            TTILES_DISABLED = 4,
            TTILES_FOCUSED = 5,
        }
        public enum TOPTABITEMRIGHTEDGESTATES
        {
            TTIRES_NORMAL = 1,
            TTIRES_HOT = 2,
            TTIRES_SELECTED = 3,
            TTIRES_DISABLED = 4,
            TTIRES_FOCUSED = 5,
        }
        public enum TOPTABITEMSTATES
        {
            TTIS_NORMAL = 1,
            TTIS_HOT = 2,
            TTIS_SELECTED = 3,
            TTIS_DISABLED = 4,
            TTIS_FOCUSED = 5,
        }
        public enum TRACKBARPARTS
        {
            TKP_TRACK = 1,
            TKP_TRACKVERT = 2,
            TKP_THUMB = 3,
            TKP_THUMBBOTTOM = 4,
            TKP_THUMBTOP = 5,
            TKP_THUMBVERT = 6,
            TKP_THUMBLEFT = 7,
            TKP_THUMBRIGHT = 8,
            TKP_TICS = 9,
            TKP_TICSVERT = 10,
        }
        public enum TRACKBARSTYLESTATES
        {
            TKS_NORMAL = 1,
        }
        public enum TRACKSTATES
        {
            TRS_NORMAL = 1,
        }
        public enum TRACKVERTSTATES
        {
            TRVS_NORMAL = 1,
        }
        public enum TRANSPARENTBACKGROUNDSTATES
        {
            CBTBS_NORMAL = 1,
            CBTBS_HOT = 2,
            CBTBS_DISABLED = 3,
            CBTBS_FOCUSED = 4,
        }
        public enum TRANSPARENTBARSTATES
        {
            PBBS_NORMAL = 1,
            PBBS_PARTIAL = 2,
        }
        public enum TRANSPARENTBARVERTSTATES
        {
            PBBVS_NORMAL = 1,
            PBBVS_PARTIAL = 2,
        }
        public enum TREEITEMSTATES
        {
            TREIS_NORMAL = 1,
            TREIS_HOT = 2,
            TREIS_SELECTED = 3,
            TREIS_DISABLED = 4,
            TREIS_SELECTEDNOTFOCUS = 5,
            TREIS_HOTSELECTED = 6,
        }
        public enum TREEVIEWPARTS
        {
            TVP_TREEITEM = 1,
            TVP_GLYPH = 2,
            TVP_BRANCH = 3,
            TVP_HOTGLYPH = 4,
        }
        public enum UPDATEMETADATASTATES
        {
            DDUPDATEMETADATA_HIGHLIGHT = 1,
            DDUPDATEMETADATA_NOHIGHLIGHT = 2,
        }
        public enum UPHORZSTATES
        {
            UPHZS_NORMAL = 1,
            UPHZS_HOT = 2,
            UPHZS_PRESSED = 3,
            UPHZS_DISABLED = 4,
        }
        public enum UPSTATES
        {
            UPS_NORMAL = 1,
            UPS_HOT = 2,
            UPS_PRESSED = 3,
            UPS_DISABLED = 4,
        }
        public enum VERTSCROLLSTATES
        {
            VSS_NORMAL = 1,
            VSS_HOT = 2,
            VSS_PUSHED = 3,
            VSS_DISABLED = 4,
        }
        public enum VERTTHUMBSTATES
        {
            VTS_NORMAL = 1,
            VTS_HOT = 2,
            VTS_PUSHED = 3,
            VTS_DISABLED = 4,
        }
        public enum WARNINGSTATES
        {
            DDWARNING_HIGHLIGHT = 1,
            DDWARNING_NOHIGHLIGHT = 2,
        }
        public enum WINDOWPARTS
        {
            WP_CAPTION = 1,
            WP_SMALLCAPTION = 2,
            WP_MINCAPTION = 3,
            WP_SMALLMINCAPTION = 4,
            WP_MAXCAPTION = 5,
            WP_SMALLMAXCAPTION = 6,
            WP_FRAMELEFT = 7,
            WP_FRAMERIGHT = 8,
            WP_FRAMEBOTTOM = 9,
            WP_SMALLFRAMELEFT = 10,
            WP_SMALLFRAMERIGHT = 11,
            WP_SMALLFRAMEBOTTOM = 12,
            WP_SYSBUTTON = 13,
            WP_MDISYSBUTTON = 14,
            WP_MINBUTTON = 15,
            WP_MDIMINBUTTON = 16,
            WP_MAXBUTTON = 17,
            WP_CLOSEBUTTON = 18,
            WP_SMALLCLOSEBUTTON = 19,
            WP_MDICLOSEBUTTON = 20,
            WP_RESTOREBUTTON = 21,
            WP_MDIRESTOREBUTTON = 22,
            WP_HELPBUTTON = 23,
            WP_MDIHELPBUTTON = 24,
            WP_HORZSCROLL = 25,
            WP_HORZTHUMB = 26,
            WP_VERTSCROLL = 27,
            WP_VERTTHUMB = 28,
            WP_DIALOG = 29,
            WP_CAPTIONSIZINGTEMPLATE = 30,
            WP_SMALLCAPTIONSIZINGTEMPLATE = 31,
            WP_FRAMELEFTSIZINGTEMPLATE = 32,
            WP_SMALLFRAMELEFTSIZINGTEMPLATE = 33,
            WP_FRAMERIGHTSIZINGTEMPLATE = 34,
            WP_SMALLFRAMERIGHTSIZINGTEMPLATE = 35,
            WP_FRAMEBOTTOMSIZINGTEMPLATE = 36,
            WP_SMALLFRAMEBOTTOMSIZINGTEMPLATE = 37,
            WP_FRAME = 38,
        }
    }
    [System.FlagsAttribute()]
    public enum VsCommandFlags : uint
    {
        cCommandFlagNoKeyCustomize = 1u,
        cCommandFlagNoButtonCustomize = 2u,
        cCommandFlagNoCustomize = 3u,
        cCommandFlagTextContextUseBtn = 4u,
        cCommandFlagTextChanges = 8u,
        cCommandFlagDefaultDisabled = 16u,
        cCommandFlagDefaultInvisible = 32u,
        cCommandFlagDynamicVisibility = 64u,
        cCommandFlagRepeat = 128u,
        cCommandFlagDynamicItemStart = 256u,
        cCommandFlagCommandWellOnly = 512u,
        cCommandFlagPict = 1024u,
        cCommandFlagText = 2048u,
        cCommandFlagIconAndText = 3072u,
        cCommandFlagAllowParams = 4096u,
        cCommandFlagFilterKeys = 8192u,
        cCommandFlagPostExec = 16384u,
        cCommandFlagDontCache = 32768u,
        cCommandFlagFixMenuController = 65536u,
        cCommandFlagNoShowOnMenuController = 131072u,
        cCommandFlagRouteToDocuments = 262144u,
        cCommandFlagNoAutoComplete = 524288u,
        cCommandFlagTextMenuUseBtn = 1048576u,
        cCommandFlagTextMenuCtrlUseMnu = 2097152u,
        cCommandFlagTextCascadeUseBtn = 4194304u,
        cCommandFlagCaseSensitive = 8388608u,
        cCommandFlagMenuDefaultDocked = 16777216u,
        cCommandFlagMenuNoToolbarClose = 33554432u,
        cCommandFlagMenuNotInTbList = 67108864u,
        cCommandFlagMenuAlwaysCreate = 134217728u,
        cCommandFlagProfferedCmd = 268435456u,
        cCommandFlagTextIsAnchor = 536870912u,
        cCommandFlagStretchHorizontally = 1073741824u,
    }
    public enum VsCommandType : uint
    {
        Separator = 0u,
        Button = 1u,
        MenuButton = 2u,
        Swatch = 3u,
        SplitDropDown = 4u,
        DropDownCombo = 16u,
        MRUCombo = 32u,
        DynamicCombo = 48u,
        OwnerDropDownCombo = 64u,
        IndexCombo = 80u,
        Menu = 256u,
        MenuController = 512u,
        MenuToolbar = 768u,
        MenuContext = 1024u,
        MenuToolWindowToolbar = 1280u,
        MenuControllerLatched = 1536u,
        Shared = 268435456u,
        AppID = 536870912u,
    }
    public enum WaitResult : uint
    {
        WAIT_ABANDONED = 128u,
        WAIT_OBJECT_0 = 0u,
        WAIT_TIMEOUT = 258u,
        WAIT_FAILED = 4294967295u,
    }
    [System.FlagsAttribute()]
    public enum Win32ErrorMode : uint
    {
        SEM_FAILCRITICALERRORS = 1u,
        SEM_NOGPFAULTERRORBOX = 2u,
        SEM_NOALIGNMENTFAULTEXCEPT = 4u,
        SEM_NOOPENFILEERRORBOX = 32768u,
    }
}
namespace JetBrains.Interop.WinApi.Declarations.Functions
{
    
    public delegate uint LPFNPSPCALLBACK(System.Void* hwnd, uint nMsg, JetBrains.Interop.WinApi.Declarations.Structures.PROPSHEETPAGE* ppsp);
}
namespace JetBrains.Interop.WinApi.Declarations.Interfaces
{
    
    [System.Runtime.InteropServices.GuidAttribute("00021401-0000-0000-C000-000000000046")]
    public class CLSID_ShellLink
    {
        public CLSID_ShellLink() { }
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("CB2F6722-AB3A-11d2-9C40-00C04FA30A3E")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICorRuntimeHost
    {
        int CloseEnum(System.IntPtr hEnum);
        int CreateDomain(string pwzFriendlyName, object pIdentityArray, out object pAppDomain);
        int CreateDomainEx(string pwzFriendlyName, object pSetup, object pEvidence, out object pAppDomain);
        int CreateDomainSetup(out object pAppDomainSetup);
        int CreateEvidence(out object pEvidence);
        int CreateLogicalThreadState();
        int CurrentDomain(out object pAppDomain);
        int DeleteLogicalThreadState();
        int EnumDomains(out System.IntPtr hEnum);
        int GetConfiguration(out object pConfiguration);
        int GetDefaultDomain(out object pAppDomain);
        int LocksHeldByLogicalThread(out uint pCount);
        int MapFile(System.IntPtr hFile, out System.IntPtr hMapAddress);
        int NextDomain(System.IntPtr hEnum, out object pAppDomain);
        int Start();
        int Stop();
        int SwitchInLogicalThreadState(ref uint pFiberCookie);
        int SwitchOutLogicalThreadState(out uint FiberCookie);
        int UnloadDomain(object pAppDomain);
    }
    [System.Runtime.InteropServices.CoClassAttribute(typeof(JetBrains.Interop.WinApi.Declarations.Interfaces.ITStorageClass))]
    [System.Runtime.InteropServices.GuidAttribute("88CC31DE-27AB-11D0-9DF9-00A0C922E6EC")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IITStorage
    {
        int Compact(string name, JetBrains.Interop.WinApi.Declarations.Constants.EItsCompact compact);
        int DefaultControlData(JetBrains.Interop.WinApi.Declarations.Structures.CItsControlData** controlData);
        int SetControlData(System.Void* controlData);
        int StgCreateDocfile(string name, uint grfMode, uint reserved, out JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage storage);
        int StgCreateDocfileOnILockBytes(System.Void* plkbyt, uint grfMode, uint reserved, out JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage storage);
        int StgIsStorageFile(string name);
        int StgIsStorageILockBytes(System.Void* plkbyt);
        int StgOpenStorage(string name, JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage pstgPriority, uint grfMode, System.Void* snbExclude, uint reserved, out JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage storage);
        int StgOpenStorageOnILockBytes(System.Void* plkbyt, JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage pStgPriority, uint grfMode, System.Void* snbExclude, uint reserved, out JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage storage);
        int StgSetTimes(string lpszName, System.Runtime.InteropServices.ComTypes.FILETIME* cTime, System.Runtime.InteropServices.ComTypes.FILETIME* aTime, System.Runtime.InteropServices.ComTypes.FILETIME* mTime);
    }
    [System.Runtime.InteropServices.GuidAttribute("000C0600-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsoComponent
    {
        bool FContinueMessageLoop(int uReason, int pvLoopData, JetBrains.Interop.WinApi.MSG[] pMsgPeeked);
        bool FDebugMessage(System.IntPtr hInst, int msg, System.IntPtr wParam, System.IntPtr lParam);
        bool FDoIdle(int grfidlef);
        bool FPreTranslateMessage(ref JetBrains.Interop.WinApi.MSG msg);
        bool FQueryTerminate(bool fPromptUser);
        System.IntPtr HwndGetWindow(int dwWhich, int dwReserved);
        void OnActivationChange(JetBrains.Interop.WinApi.Declarations.Interfaces.IMsoComponent component, bool fSameComponent, int pcrinfo, bool fHostIsActivating, int pchostinfo, int dwReserved);
        void OnAppActivate(bool fActive, int dwOtherThreadId);
        void OnEnterState(int uStateId, bool fEnter);
        void OnLoseActivation();
        void Terminate();
    }
    [System.Runtime.InteropServices.GuidAttribute("000C0601-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsoComponentManager
    {
        bool FContinueIdle();
        bool FCreateSubComponentManager(object punkOuter, object punkServProv, ref System.Guid riid, out System.IntPtr ppvObj);
        bool FDebugMessage(System.IntPtr hInst, uint msg, System.IntPtr wParam, System.IntPtr lParam);
        bool FGetActiveComponent(uint dwgac, out JetBrains.Interop.WinApi.Declarations.Interfaces.IMsoComponent[] ppic, JetBrains.Interop.WinApi.MSOCRINFO* pcrinfo, int dwReserved);
        bool FGetParentComponentManager(out JetBrains.Interop.WinApi.Declarations.Interfaces.IMsoComponentManager ppicm);
        bool FInState(int uStateId, System.IntPtr pvoid);
        bool FOnComponentActivate(System.IntPtr dwComponentId);
        bool FOnComponentExitState(System.IntPtr dwComponentId, int uStateId, int uContext, int cpicmExclude, int rgpicmExclude);
        bool FPushMessageLoop(System.IntPtr dwComponentId, int uReason, int pvLoopData);
        bool FRegisterComponent(JetBrains.Interop.WinApi.Declarations.Interfaces.IMsoComponent component, JetBrains.Interop.WinApi.MSOCRINFO* pcrinfo, out System.IntPtr dwComponentId);
        bool FRevokeComponent(System.IntPtr dwComponentId);
        bool FSetTrackingComponent(System.IntPtr dwComponentId, bool fTrack);
        bool FUpdateComponentRegistration(System.IntPtr dwComponentId, JetBrains.Interop.WinApi.MSOCRINFO* pcrinfo);
        void OnComponentEnterState(System.IntPtr dwComponentId, int uStateId, int uContext, int cpicmExclude, int rgpicmExclude, int dwReserved);
        int QueryService(ref System.Guid guidService, ref System.Guid iid, out object ppvObj);
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("00000016-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleMessageFilter
    {
        int HandleInComingCall(uint dwCallType, System.IntPtr hTaskCaller, uint dwTickCount, System.IntPtr lpInterfaceInfo);
        int MessagePending(System.IntPtr hTaskCallee, uint dwTickCount, uint dwPendingType);
        int RetryRejectedCall(System.IntPtr hTaskCallee, uint dwTickCount, uint dwRejectType);
    }
    [System.Runtime.InteropServices.GuidAttribute("6D5140C1-7436-11CE-8034-00AA006009FA")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleServiceProvider
    {
        int QueryService(ref System.Guid guidService, ref System.Guid riid, out System.IntPtr ppvObject);
    }
    [System.Runtime.InteropServices.GuidAttribute("6D5140C1-7436-11CE-8034-00AA006009FA")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IServiceProvider
    {
        object QueryService(System.Guid* guidService, System.Guid* riid);
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("000214F9-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IShellLinkW
    {
        JetBrains.Interop.WinApi.HResults GetArguments(System.Char* pszArgs, int cch);
        JetBrains.Interop.WinApi.HResults GetDescription(System.Char* pszName, int cch);
        JetBrains.Interop.WinApi.HResults GetHotkey(System.UInt16* pwHotkey);
        JetBrains.Interop.WinApi.HResults GetIconLocation(System.Char* pszIconPath, int cch, System.Int32* piIcon);
        JetBrains.Interop.WinApi.HResults GetIDList(System.Void** ppidl);
        JetBrains.Interop.WinApi.HResults GetPath(System.Char* pszFile, int cch, System.Void* pfd, uint fFlags);
        JetBrains.Interop.WinApi.HResults GetShowCmd(System.Int32* piShowCmd);
        JetBrains.Interop.WinApi.HResults GetWorkingDirectory(System.Char* pszDir, int cch);
        JetBrains.Interop.WinApi.HResults Resolve(System.Void* hwnd, uint fFlags);
        JetBrains.Interop.WinApi.HResults SetArguments(System.Char* pszArgs);
        JetBrains.Interop.WinApi.HResults SetDescription(System.Char* pszName);
        JetBrains.Interop.WinApi.HResults SetHotkey(ushort wHotkey);
        JetBrains.Interop.WinApi.HResults SetIconLocation(System.Char* pszIconPath, int iIcon);
        JetBrains.Interop.WinApi.HResults SetIDList(System.Void* pidl);
        JetBrains.Interop.WinApi.HResults SetPath(System.Char* pszFile);
        JetBrains.Interop.WinApi.HResults SetRelativePath(System.Char* pszPathRel, uint dwReserved);
        JetBrains.Interop.WinApi.HResults SetShowCmd(int iShowCmd);
        JetBrains.Interop.WinApi.HResults SetWorkingDirectory(System.Char* pszDir);
    }
    [System.Runtime.InteropServices.GuidAttribute("0000000B-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStorage
    {
        void Commit(uint grfCommitFlags);
        void CopyTo(uint ciidExclude, System.Guid* pIIDExclude, System.Char** snbExclude, JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage stgDest);
        JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage CreateStorage(string pwcsName, uint grfMode, uint reserved1, uint reserved2);
        JetBrains.Interop.WinApi.Declarations.Interfaces.IStream CreateStream(string pwcsName, uint grfMode, uint reserved1, uint reserved2);
        void DestroyElement(string pwcsName);
        void EnumElements(uint reserved1, System.Void* reserved2, uint reserved3, out object ppVal);
        void MoveElementTo(string pwcsName, JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage stgDest, string pwcsNewName, uint grfFlags);
        JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage OpenStorage(string pwcsName, JetBrains.Interop.WinApi.Declarations.Interfaces.IStorage pstgPriority, uint grfMode, System.Char** snbExclude, uint reserved);
        JetBrains.Interop.WinApi.Declarations.Interfaces.IStream OpenStream(string pwcsName, System.Void* reserved1, uint grfMode, uint reserved2);
        void RenameElement(string pwcsOldName, string pwcsNewName);
        void Revert();
        void SetClass(System.Guid* clsid);
        void SetElementTimes(string pwcsName, System.Runtime.InteropServices.ComTypes.FILETIME* pctime, System.Runtime.InteropServices.ComTypes.FILETIME* patime, System.Runtime.InteropServices.ComTypes.FILETIME* pmtime);
        void SetStateBits(uint grfStateBits, uint grfMask);
        void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pStatStg, uint grfStatFlag);
    }
    [System.Runtime.InteropServices.GuidAttribute("0000000C-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    [System.Security.SuppressUnmanagedCodeSecurityAttribute()]
    public interface IStream
    {
        JetBrains.Interop.WinApi.Declarations.Interfaces.IStream Clone();
        void Commit(uint grfCommitFlags);
        ulong CopyTo(JetBrains.Interop.WinApi.Declarations.Interfaces.IStream pstm, ulong cb, out System.UInt64* pcbRead);
        void LockRegion(ulong libOffset, ulong cb, uint dwLockType);
        uint Read(System.Void* pv, uint cb);
        void Revert();
        ulong Seek(long dlibMove, uint dwOrigin);
        void SetSize(ulong libNewSize);
        void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pStatstg, uint grfStatFlag);
        void UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);
        uint Write(System.Void* pv, uint cb);
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute(0)]
    [System.Runtime.InteropServices.GuidAttribute("5D02926A-212E-11D0-9DF9-00A0C922E6EC")]
    public class ITStorageClass
    {
        public ITStorageClass() { }
    }
}
namespace JetBrains.Interop.WinApi.Declarations
{
    
    [System.FlagsAttribute()]
    public enum LogoutOptions : uint
    {
        ENDSESSION_CLOSEAPP = 1u,
        ENDSESSION_CRITICAL = 1073741824u,
        ENDSESSION_LOGOFF = 2147483648u,
    }
}
namespace JetBrains.Interop.WinApi.Declarations.Structures
{
    
    [JetBrains.Util.NoReorder()]
    public struct BITMAPINFO
    {
        public System.UInt32* bmiColors;
        public JetBrains.Interop.WinApi.Declarations.Structures.BITMAPINFOHEADER bmiHeader;
    }
    [JetBrains.Util.NoReorder()]
    public struct BITMAPINFOHEADER
    {
        public ushort biBitCount;
        public uint biClrImportant;
        public uint biClrUsed;
        public uint biCompression;
        public int biHeight;
        public ushort biPlanes;
        public uint biSize;
        public uint biSizeImage;
        public int biWidth;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
    }
    [JetBrains.Util.NoReorder()]
    public struct BLENDFUNCTION
    {
        public byte AlphaFormat;
        public byte BlendFlags;
        public byte BlendOp;
        public byte SourceConstantAlpha;
        public static JetBrains.Interop.WinApi.Declarations.Structures.BLENDFUNCTION GetPerPixelBlender(byte constantalpha) { }
        public static JetBrains.Interop.WinApi.Declarations.Structures.BLENDFUNCTION GetPerPixelBlender() { }
        public static JetBrains.Interop.WinApi.Declarations.Structures.BLENDFUNCTION GetUniformBlender(byte constantalpha) { }
        public static JetBrains.Interop.WinApi.Declarations.Structures.BLENDFUNCTION GetUniformBlender() { }
    }
    [JetBrains.Util.NoReorder()]
    public struct CItsControlData
    {
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(uint), 1)]
        public JetBrains.Interop.WinApi.Declarations.Structures.CItsControlData.<Data>e__FixedBuffer0 Data;
        public uint Num;
    }
    [JetBrains.Util.NoReorder()]
    public struct CURSORINFO
    {
        public uint cbSize;
        public uint flags;
        public System.Void* hCursor;
        public JetBrains.Interop.WinApi.POINT ptScreenPos;
        public static JetBrains.Interop.WinApi.Declarations.Structures.CURSORINFO NewWithSize() { }
    }
    public struct FILE_TIME
    {
        public uint ftTimeHigh;
        public uint ftTimeLow;
        public FILE_TIME(long fileTime) { }
        public long ToTicks() { }
    }
    [JetBrains.Util.NoReorder()]
    public struct FLASHWINFO
    {
        public uint cbSize;
        public uint dwFlags;
        public uint dwTimeout;
        public System.Void* hwnd;
        public uint uCount;
    }
    [JetBrains.Util.NoReorder()]
    public struct MEMORY_BASIC_INFORMATION
    {
        public System.Void* AllocationBase;
        public uint AllocationProtect;
        public System.Void* BaseAddress;
        public uint Protect;
        public System.IntPtr RegionSize;
        public uint State;
        public uint Type;
    }
    public struct MIB_TCP6ROW
    {
        public uint dwLocalPort;
        public uint dwLocalScopeId;
        public uint dwRemotePort;
        public uint dwRemoteScopeId;
        public JetBrains.Interop.WinApi.Declarations.Constants.MIB_TCP_STATE dwState;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(byte), 16)]
        public JetBrains.Interop.WinApi.Declarations.Structures.MIB_TCP6ROW.<ucLocalAddr>e__FixedBuffer3 ucLocalAddr;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(byte), 16)]
        public JetBrains.Interop.WinApi.Declarations.Structures.MIB_TCP6ROW.<ucRemoteAddr>e__FixedBuffer4 ucRemoteAddr;
    }
    public struct MIB_TCP6ROW_OWNER_PID
    {
        public uint dwLocalPort;
        public uint dwLocalScopeId;
        public uint dwOwningPid;
        public uint dwRemotePort;
        public uint dwRemoteScopeId;
        public JetBrains.Interop.WinApi.Declarations.Constants.MIB_TCP_STATE dwState;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(byte), 16)]
        public JetBrains.Interop.WinApi.Declarations.Structures.MIB_TCP6ROW_OWNER_PID.<ucLocalAddr>e__FixedBuffer5 ucLocalAddr;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(byte), 16)]
        public JetBrains.Interop.WinApi.Declarations.Structures.MIB_TCP6ROW_OWNER_PID.<ucRemoteAddr>e__FixedBuffer6 ucRemoteAddr;
    }
    public struct MIB_TCPROW
    {
        public uint dwLocalAddr;
        public uint dwLocalPort;
        public uint dwRemoteAddr;
        public uint dwRemotePort;
        public JetBrains.Interop.WinApi.Declarations.Constants.MIB_TCP_STATE dwState;
    }
    public struct MIB_TCPROW_OWNER_PID
    {
        public uint dwLocalAddr;
        public uint dwLocalPort;
        public uint dwOwningPid;
        public uint dwRemoteAddr;
        public uint dwRemotePort;
        public JetBrains.Interop.WinApi.Declarations.Constants.MIB_TCP_STATE dwState;
    }
    public struct PROPSHEETPAGE
    {
        public uint dwFlags;
        public uint dwSize;
        public JetBrains.Interop.WinApi.Declarations.Structures.PROPSHEETPAGE.UnionIconHandleOrString hIcon_pszIcon;
        public System.Void* hInstance;
        public System.IntPtr lParam;
        public System.UInt32* pcRefParent;
        public System.Void* pfnCallback;
        public System.Void* pfnDlgProc;
        public JetBrains.Interop.WinApi.Declarations.Structures.PROPSHEETPAGE.UnionTemplateOrResource pszTemplate_pResource;
        public System.Char* pszTitle;
        public struct UnionIconHandleOrString
        {
            public System.Void* hIcon;
            public System.Char* pszIcon;
        }
        public struct UnionTemplateOrResource
        {
            public System.Void* pResource;
            public System.Char* pszTemplate;
        }
    }
    public enum SE_OBJECT_TYPE
    {
        SE_UNKNOWN_OBJECT_TYPE = 0,
        SE_FILE_OBJECT = 1,
        SE_SERVICE = 2,
        SE_PRINTER = 3,
        SE_REGISTRY_KEY = 4,
        SE_LMSHARE = 5,
        SE_KERNEL_OBJECT = 6,
        SE_WINDOW_OBJECT = 7,
        SE_DS_OBJECT = 8,
        SE_DS_OBJECT_ALL = 9,
        SE_PROVIDER_DEFINED_OBJECT = 10,
        SE_WMIGUID_OBJECT = 11,
        SE_REGISTRY_WOW64_32KEY = 12,
    }
    [System.FlagsAttribute()]
    public enum SECURITY_INFORMATION : uint
    {
        OWNER_SECURITY_INFORMATION = 1u,
        GROUP_SECURITY_INFORMATION = 2u,
        DACL_SECURITY_INFORMATION = 4u,
        SACL_SECURITY_INFORMATION = 8u,
    }
    [JetBrains.Util.NoReorder()]
    public struct SIZE : System.IEquatable<JetBrains.Interop.WinApi.Declarations.Structures.SIZE>
    {
        public int cx;
        public int cy;
        public SIZE(int CX, int CY) { }
        public SIZE(System.Drawing.Size size) { }
        public bool Equals(JetBrains.Interop.WinApi.Declarations.Structures.SIZE other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    [JetBrains.Util.NoReorder()]
    public struct STGOPTIONS
    {
        public System.Char* pwcsTemplateFile;
        public ushort reserved;
        public uint ulSectorSize;
        public ushort usVersion;
    }
    public struct TOKEN_ELEVATION
    {
        public uint TokenIsElevated;
    }
    public struct WIN32_FILE_ATTRIBUTE_DATA
    {
        public uint dwFileAttributes;
        public uint ftCreationTimeHigh;
        public uint ftCreationTimeLow;
        public uint ftLastAccessTimeHigh;
        public uint ftLastAccessTimeLow;
        public uint ftLastWriteTimeHigh;
        public uint ftLastWriteTimeLow;
        public uint nFileSizeHigh;
        public uint nFileSizeLow;
    }
    [JetBrains.Util.NoReorder()]
    public class WIN32_FIND_DATA
    {
        public string cAlternateFileName;
        public string cFileName;
        public int dwFileAttributes;
        public int dwReserved0;
        public int dwReserved1;
        public JetBrains.Interop.WinApi.Declarations.Structures.FILE_TIME ftCreationTime;
        public JetBrains.Interop.WinApi.Declarations.Structures.FILE_TIME ftLastAccessTime;
        public JetBrains.Interop.WinApi.Declarations.Structures.FILE_TIME ftLastWriteTime;
        public int nFileSizeHigh;
        public int nFileSizeLow;
    }
    [JetBrains.Util.NoReorder()]
    public struct WINDOWPOS
    {
        public int cx;
        public int cy;
        public uint flags;
        public System.Void* hwnd;
        public System.Void* hwndInsertAfter;
        public int x;
        public int y;
        public void SetRectangle(System.Drawing.Rectangle rect) { }
        public System.Drawing.Rectangle ToRectangle() { }
    }
}
namespace JetBrains.Interop.WinApi.Interfaces
{
    
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.GuidAttribute("00000001-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IClassFactory
    {
        void CreateInstance(object pUnkOuter, System.Guid riid, out object ppvObject);
        void LockServer(bool fLock);
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("00000114-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleWindow
    {
        void ContextSensitiveHelp(int fEnterMode);
        System.IntPtr GetWindow();
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("EBBC7C04-315E-11D2-B62F-006097DF5BD4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IProgressDialog
    {
        int HasUserCancelled();
        void SetAnimation(System.IntPtr hInstAnimation, int idAnimation);
        void SetCancelMsg(string pwzCancelMsg, System.IntPtr pvResevered);
        void SetLine(int dwLineNum, string pwzString, int fCompactPath, System.IntPtr pvResevered);
        void SetProgress(int dwCompleted, int dwTotal);
        void SetProgress64(decimal ullCompleted, decimal ullTotal);
        void SetTitle(string pwzTitle);
        void StartProgressDialog(System.IntPtr hwndParent, object punkEnableModless, JetBrains.Interop.WinApi.PROGDLG_FLAGS dwFlags, System.IntPtr pvResevered);
        void StopProgressDialog();
        void Timer(JetBrains.Interop.WinApi.PDTIMER_FLAGS dwTimerAction, System.IntPtr pvResevered);
    }
}
namespace JetBrains.Interop.WinApi.Modules.UI
{
    
    public class static ControlPaintUnsafe
    {
        public static bool DrawThemeBackground(System.Void* hwnd, System.Void* hdc, string sThemeClassList, int nThemePartId, int nThemeStateId, System.Drawing.Rectangle rectArea, System.Drawing.Rectangle rectClip) { }
        public static bool PaintStatusBarBackgroundTheme(System.IntPtr hwnd, [JetBrains.Annotations.NotNullAttribute()] System.Drawing.Graphics g, System.Drawing.Rectangle rectArea, System.Drawing.Rectangle rectClip) { }
    }
}
namespace JetBrains.Interop.WinApi.Wrappers
{
    
    public class static Elevations
    {
        public static JetBrains.Interop.WinApi.Declarations.Constants.TOKEN_ELEVATION_TYPE GetElevationType([JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.Process process) { }
        public static uint GetSessionId([JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.Process process) { }
        public static bool IsUACEnabled() { }
    }
    public class static RunningObjectTable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TObject GetRunningObject<TObject>([JetBrains.Annotations.NotNullAttribute()] string name)
            where TObject :  class { }
        public static System.Collections.Generic.ICollection<JetBrains.Interop.WinApi.Wrappers.RunningObjectTable.BoundObject<T>> GetRunningObjects<T>()
            where T :  class { }
        public static System.Collections.Generic.ICollection<JetBrains.Interop.WinApi.Wrappers.RunningObjectTable.BoundObject<T>> GetRunningObjects<T>([JetBrains.Annotations.NotNullAttribute()] System.Predicate<string> displayNameFilter)
            where T :  class { }
        public static System.Collections.Generic.ICollection<JetBrains.Interop.WinApi.Wrappers.RunningObjectTable.BoundObject<T>> GetRunningObjects<T>([JetBrains.Annotations.NotNullAttribute()] System.Predicate<System.Runtime.InteropServices.ComTypes.IMoniker> filter)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable RegisterObject([JetBrains.Annotations.NotNullAttribute()] object o, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TObject TryGetRunningObject<TObject>([JetBrains.Annotations.NotNullAttribute()] string name)
            where TObject :  class { }
        public struct BoundObject<T>
        
        {
            public System.Runtime.InteropServices.ComTypes.IMoniker Moniker { get; set; }
            public T Object { get; set; }
        }
    }
    public sealed class SafeFindHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeFindHandle() { }
        protected override bool ReleaseHandle() { }
    }
    public struct Win32Window : System.Windows.Forms.IWin32Window
    {
        public Win32Window(System.IntPtr handle) { }
        public Win32Window(System.Void* handle) { }
        public System.IntPtr Handle { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.Debugger
{
    
    public enum ROTFLAGS : uint
    {
        ROTFLAGS_REGISTRATIONKEEPSALIVE_Stub = 1u,
        ROTFLAGS_ALLOWANYCLIENT_Stub = 2u,
    }
}