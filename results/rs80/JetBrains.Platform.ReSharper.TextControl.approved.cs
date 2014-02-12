[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ErrorStripeInvalid",
        "ErrorStripeOK",
        "ErrorStripeWarning",
        "ErrorStripeRunning",
        "ErrorStripeError",
        "ErrorStripeOff"}, IconPackResourceIdentification="JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
    "ThemedIcons.ErrorStripe.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-error-stripe", "JetBrains.TextControl.Src.BaseImpl")]

namespace JetBrains.IDE
{
    
    public class TextControlAnchoringRect : JetBrains.UI.AnchoringRect
    {
        protected System.Nullable<JetBrains.Util.TextRange> myRange;
        protected JetBrains.DocumentModel.IRangeMarker myRangeMarker;
        protected readonly JetBrains.TextControl.ITextControl myTextControl;
        public TextControlAnchoringRect([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, int offset, JetBrains.Application.IShellLocks locks) { }
        public TextControlAnchoringRect([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange range, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.Util.TextRange Range { get; set; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.IDE.TextControlAnchoringRect CreateBeginningOfLine([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, int offset, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.IDE.TextControlAnchoringRect CreateFromCaretStatic([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.IDE.TextControlAnchoringRect CreateFromRangeStatic([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange range, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.IDE.TextControlAnchoringRect CreateFromSelectionStatic([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
    }
    public sealed class TextControlPopupWindowContext : JetBrains.UI.PopupWindowManager.PopupWindowContext
    {
        public TextControlPopupWindowContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionManager actionman) { }
        public TextControlPopupWindowContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionManager actionman) { }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public override JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
        public bool Equals(JetBrains.IDE.TextControlPopupWindowContext other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.TextControl.Actions
{
    
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All)]
    public class ActionAttribute : System.Attribute
    {
        public ActionAttribute() { }
        public ActionAttribute(string name) { }
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All)]
    public class CaretAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All)]
    public class EditingAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true)]
    public class ShortcutAttribute : System.Attribute
    {
        public ShortcutAttribute(System.Windows.Forms.Keys key) { }
        public System.Windows.Forms.Keys Key { get; }
    }
    public class TextControlActions
    {
        public const string ACTION_PREFIX = "TextControl.";
        public const string BACKSPACE = "Backspace";
        public const string BACKSPACE_ACTION_ID = "TextControl.Backspace";
        public const string COPY = "Copy";
        public const string COPY_ACTION_ID = "TextControl.Copy";
        public const string CUT = "Cut";
        public const string CUT_ACTION_ID = "TextControl.Cut";
        public const string DELETE = "Delete";
        public const string DELETE_ACTION_ID = "TextControl.Delete";
        public const string DOCUMENT_END = "DocumentEnd";
        public const string DOCUMENT_END_ACTION_ID = "TextControl.DocumentEnd";
        public const string DOCUMENT_HOME = "DocumentHome";
        public const string DOCUMENT_HOME_ACTION_ID = "TextControl.DocumentHome";
        public const string DOWN = "Down";
        public const string DOWN_ACTION_ID = "TextControl.Down";
        public const string END = "End";
        public const string END_ACTION_ID = "TextControl.End";
        public const string ENTER = "Enter";
        public const string ENTER_ACTION_ID = "TextControl.Enter";
        public const string HOME = "Home";
        public const string HOME_ACTION_ID = "TextControl.Home";
        public const string LEFT = "Left";
        public const string LEFT_ACTION_ID = "TextControl.Left";
        public const string NEXT_WORD = "NextWord";
        public const string NEXT_WORD_ACTION_ID = "TextControl.NextWord";
        public const string PAGE_DOWN = "PageDown";
        public const string PAGE_DOWN_ACTION_ID = "TextControl.PageDown";
        public const string PAGE_UP = "PageUp";
        public const string PAGE_UP_ACTION_ID = "TextControl.PageUp";
        public const string PASTE = "Paste";
        public const string PASTE_ACTION_ID = "TextControl.Paste";
        public const string PREVIOUS_WORD = "PreviousWord";
        public const string PREVIOUS_WORD_ACTION_ID = "TextControl.PreviousWord";
        public const string REDO = "Redo";
        public const string REDO_ACTION_ID = "TextControl.Redo";
        public const string RIGHT = "Right";
        public const string RIGHT_ACTION_ID = "TextControl.Right";
        public const string SELECT_ALL = "SelectAll";
        public const string SELECT_ALL_ACTION_ID = "TextControl.SelectAll";
        public const string SELECTION_SUFFIX = ".Selection";
        public const string TAB = "Tab";
        public const string TAB_ACTION_ID = "TextControl.Tab";
        public const string UNDO = "Undo";
        public const string UNDO_ACTION_ID = "TextControl.Undo";
        public const string UP = "Up";
        public const string UP_ACTION_ID = "TextControl.Up";
        public bool ShiftMode { get; set; }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.EditingAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Backspace() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.P | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.Oemtilde | System.Windows.Forms.Keys.Oem3 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void Copy() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.EditingAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Shift)]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ShiftKey | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.P | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.NumLock | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.Oemtilde | System.Windows.Forms.Keys.Oem3 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void Cut() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.EditingAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Delete() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void DocumentEnd() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void DocumentHome() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Down() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void End() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.EditingAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Shift)]
        public void Enter() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Home() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Left() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void NextWord() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void PageDown() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void PageUp() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.EditingAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Shift)]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ShiftKey | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.P | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.NumLock | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.Oemtilde | System.Windows.Forms.Keys.Oem3 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void Paste() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void PreviousWord() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Right() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.P | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.Oemtilde | System.Windows.Forms.Keys.Oem3 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void SelectAll() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.EditingAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F18 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Tab() { }
        public void Type(char keyChar) { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.Modifiers | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Tab | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.ShiftKey | System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.FinalMode | System.Windows.Forms.Keys.HanjaMode | System.Windows.Forms.Keys.KanjiMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.P | System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Y | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.NumLock | System.Windows.Forms.Keys.Scroll | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.Oemtilde | System.Windows.Forms.Keys.Oem3 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear | System.Windows.Forms.Keys.Control)]
        public void Undo() { }
        [JetBrains.TextControl.Actions.ActionAttribute()]
        [JetBrains.TextControl.Actions.CaretAttribute()]
        [JetBrains.TextControl.Actions.ShortcutAttribute(System.Windows.Forms.Keys.KeyCode | System.Windows.Forms.Keys.None | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Cancel | System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.XButton1 | System.Windows.Forms.Keys.XButton2 | System.Windows.Forms.Keys.LineFeed | System.Windows.Forms.Keys.Clear | System.Windows.Forms.Keys.Return | System.Windows.Forms.Keys.Enter | System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Pause | System.Windows.Forms.Keys.Capital | System.Windows.Forms.Keys.CapsLock | System.Windows.Forms.Keys.KanaMode | System.Windows.Forms.Keys.HanguelMode | System.Windows.Forms.Keys.HangulMode | System.Windows.Forms.Keys.JunjaMode | System.Windows.Forms.Keys.Escape | System.Windows.Forms.Keys.IMEConvert | System.Windows.Forms.Keys.IMENonconvert | System.Windows.Forms.Keys.IMEAccept | System.Windows.Forms.Keys.IMEAceept | System.Windows.Forms.Keys.IMEModeChange | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Prior | System.Windows.Forms.Keys.PageUp | System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.PageDown | System.Windows.Forms.Keys.End | System.Windows.Forms.Keys.Home | System.Windows.Forms.Keys.Left | System.Windows.Forms.Keys.Up | System.Windows.Forms.Keys.Right | System.Windows.Forms.Keys.Down | System.Windows.Forms.Keys.Select | System.Windows.Forms.Keys.Print | System.Windows.Forms.Keys.Execute | System.Windows.Forms.Keys.Snapshot | System.Windows.Forms.Keys.PrintScreen | System.Windows.Forms.Keys.Insert | System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Help | System.Windows.Forms.Keys.D0 | System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.D3 | System.Windows.Forms.Keys.D4 | System.Windows.Forms.Keys.D5 | System.Windows.Forms.Keys.D6 | System.Windows.Forms.Keys.D7 | System.Windows.Forms.Keys.D8 | System.Windows.Forms.Keys.D9 | System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.F | System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.K | System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.U | System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.LWin | System.Windows.Forms.Keys.RWin | System.Windows.Forms.Keys.Apps | System.Windows.Forms.Keys.Sleep | System.Windows.Forms.Keys.NumPad0 | System.Windows.Forms.Keys.NumPad1 | System.Windows.Forms.Keys.NumPad2 | System.Windows.Forms.Keys.NumPad3 | System.Windows.Forms.Keys.NumPad4 | System.Windows.Forms.Keys.NumPad5 | System.Windows.Forms.Keys.NumPad6 | System.Windows.Forms.Keys.NumPad7 | System.Windows.Forms.Keys.NumPad8 | System.Windows.Forms.Keys.NumPad9 | System.Windows.Forms.Keys.Multiply | System.Windows.Forms.Keys.Add | System.Windows.Forms.Keys.Separator | System.Windows.Forms.Keys.Subtract | System.Windows.Forms.Keys.Decimal | System.Windows.Forms.Keys.Divide | System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.F3 | System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.F5 | System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.F7 | System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.F9 | System.Windows.Forms.Keys.F10 | System.Windows.Forms.Keys.F11 | System.Windows.Forms.Keys.F12 | System.Windows.Forms.Keys.F13 | System.Windows.Forms.Keys.F14 | System.Windows.Forms.Keys.F15 | System.Windows.Forms.Keys.F16 | System.Windows.Forms.Keys.F19 | System.Windows.Forms.Keys.F20 | System.Windows.Forms.Keys.F21 | System.Windows.Forms.Keys.F22 | System.Windows.Forms.Keys.F23 | System.Windows.Forms.Keys.F24 | System.Windows.Forms.Keys.LShiftKey | System.Windows.Forms.Keys.RShiftKey | System.Windows.Forms.Keys.LControlKey | System.Windows.Forms.Keys.RControlKey | System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.RMenu | System.Windows.Forms.Keys.BrowserBack | System.Windows.Forms.Keys.BrowserForward | System.Windows.Forms.Keys.BrowserRefresh | System.Windows.Forms.Keys.BrowserStop | System.Windows.Forms.Keys.BrowserSearch | System.Windows.Forms.Keys.BrowserFavorites | System.Windows.Forms.Keys.BrowserHome | System.Windows.Forms.Keys.VolumeMute | System.Windows.Forms.Keys.VolumeDown | System.Windows.Forms.Keys.VolumeUp | System.Windows.Forms.Keys.MediaNextTrack | System.Windows.Forms.Keys.MediaPreviousTrack | System.Windows.Forms.Keys.MediaStop | System.Windows.Forms.Keys.MediaPlayPause | System.Windows.Forms.Keys.LaunchMail | System.Windows.Forms.Keys.SelectMedia | System.Windows.Forms.Keys.LaunchApplication1 | System.Windows.Forms.Keys.LaunchApplication2 | System.Windows.Forms.Keys.OemSemicolon | System.Windows.Forms.Keys.Oem1 | System.Windows.Forms.Keys.Oemplus | System.Windows.Forms.Keys.Oemcomma | System.Windows.Forms.Keys.OemMinus | System.Windows.Forms.Keys.OemPeriod | System.Windows.Forms.Keys.OemQuestion | System.Windows.Forms.Keys.Oem2 | System.Windows.Forms.Keys.OemOpenBrackets | System.Windows.Forms.Keys.Oem4 | System.Windows.Forms.Keys.OemPipe | System.Windows.Forms.Keys.Oem5 | System.Windows.Forms.Keys.OemCloseBrackets | System.Windows.Forms.Keys.Oem6 | System.Windows.Forms.Keys.OemQuotes | System.Windows.Forms.Keys.Oem7 | System.Windows.Forms.Keys.Oem8 | System.Windows.Forms.Keys.OemBackslash | System.Windows.Forms.Keys.Oem102 | System.Windows.Forms.Keys.ProcessKey | System.Windows.Forms.Keys.Packet | System.Windows.Forms.Keys.Attn | System.Windows.Forms.Keys.Crsel | System.Windows.Forms.Keys.Exsel | System.Windows.Forms.Keys.EraseEof | System.Windows.Forms.Keys.Play | System.Windows.Forms.Keys.Zoom | System.Windows.Forms.Keys.NoName | System.Windows.Forms.Keys.Pa1 | System.Windows.Forms.Keys.OemClear)]
        public void Up() { }
    }
    public class TextControlSpecificEscapeActionHandler : JetBrains.ActionManagement.EscapeActionHandlerBase
    {
        public TextControlSpecificEscapeActionHandler(JetBrains.TextControl.ITextControl textControl, System.Action escapeHandler, JetBrains.ActionManagement.IActionManager actionman) { }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.TextControl.Actions.Adapters
{
    
    public class static ActionSystemAdapter
    {
        public static void Init(bool registerShortcuts, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
        public static void Init(bool registerShortcuts, JetBrains.TextControl.Actions.Adapters.ActionSystemAdapter.DoAddAction addAction, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
        public delegate JetBrains.ActionManagement.IExecutableAction DoAddAction(string actionId, JetBrains.ActionManagement.IActionManager actionManager);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class InitActionSystemAdapter
    {
        public InitActionSystemAdapter(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
        public JetBrains.ActionManagement.IActionManager ActionManager { get; }
        protected virtual void Init() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StandaloneTextControlWin32Adapter
    {
        public StandaloneTextControlWin32Adapter(JetBrains.ActionManagement.IActionManager actionman, JetBrains.Threading.IThreading invocator) { }
        public bool ProcessKey(System.Windows.Forms.Keys key, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.TextControl.BaseImpl
{
    
    public abstract class TextControlCaretBase : JetBrains.TextControl.ITextControlCaret
    {
        protected static readonly JetBrains.DataFlow.StandardPreconditions.ReadonlyToken myReadonly;
        public TextControlCaretBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.Coords.ITextControlPos> Position { get; }
        public JetBrains.TextControl.Coords.ITextControlPos PositionValue { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public event System.EventHandler<JetBrains.TextControl.CaretMovedEventArgs> CaretMoved;
        public virtual void MoveTo(JetBrains.TextControl.Coords.ITextControlPos position, JetBrains.TextControl.CaretVisualPlacement visualplace) { }
        protected abstract void MoveToCore([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos position, bool bAdvancedScrollMode);
    }
    public abstract class TextControlScrollingBase : JetBrains.TextControl.ITextControlScrolling, JetBrains.TextControl.IVisibleAreaChange
    {
        protected static readonly JetBrains.DataFlow.StandardPreconditions.ReadonlyToken myReadonly;
        protected TextControlScrollingBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.Threading.IThreading locks) { }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.Coords.TextControlPosRange> ViewportRange { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.Graphics.Rect> ViewportRect { get; }
        protected JetBrains.TextControl.Graphics.PointEx GetPointForCenter(JetBrains.TextControl.Coords.ITextControlPos position) { }
        protected bool GetPointForRelative(JetBrains.TextControl.Coords.ITextControlPos position, out JetBrains.TextControl.Graphics.PointEx point) { }
        protected JetBrains.TextControl.Graphics.PointEx GetPointForTop(JetBrains.TextControl.Coords.ITextControlPos position) { }
        public abstract void ScrollTo(JetBrains.TextControl.Graphics.PointEx canvasPosition);
        public virtual void ScrollTo(JetBrains.TextControl.Coords.ITextControlPos position, JetBrains.TextControl.TextControlScrollType scrollType) { }
    }
    public abstract class TextControlSelectionBase : JetBrains.TextControl.ISelectionChange, JetBrains.TextControl.ITextControlSelection
    {
        protected static readonly JetBrains.DataFlow.StandardPreconditions.ReadonlyToken myReadonly;
        protected TextControlSelectionBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        public JetBrains.DataFlow.IProperty<JetBrains.Util.IEquatableList<JetBrains.TextControl.Coords.TextControlPosRange>> Ranges { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public event System.EventHandler SelectionChanged;
        protected static JetBrains.Util.JetTuple<JetBrains.TextControl.DocOffsetAndVirtual, JetBrains.TextControl.DocOffsetAndVirtual> GetAnchorToActiveSpanForContinuousSelection([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.TextControlPosRange[] ranges) { }
        public abstract void RemoveSelection(bool bCollapseToAnchor);
        public abstract void SetRanges(JetBrains.TextControl.Coords.TextControlPosRange[] ranges);
    }
    public abstract class TextControlWindowBase : JetBrains.TextControl.ITextControlWindow
    {
        public readonly JetBrains.DataFlow.IProperty<bool> IsLayoutKnownByUser;
        protected readonly JetBrains.DataFlow.IProperty<bool> myIsFocusedUnguarded;
        protected static readonly JetBrains.DataFlow.StandardPreconditions.ReadonlyToken myReadonly;
        protected TextControlWindowBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> Keyboard { get; }
        public JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.TextControl.TextControlMouseEventArgs> MouseDown { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.TextControl.TextControlMouseEventArgs> MouseMove { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.TextControl.TextControlMouseEventArgs> MouseUp { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.UI.IAnchoringRect CreateViewportAnchorCore([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
        protected abstract void FocusCore();
        public override string ToString() { }
    }
}
namespace JetBrains.TextControl
{
    
    public sealed class CaretMovedEventArgs : System.EventArgs
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.Coords.ITextControlPos NewPosition;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.Coords.ITextControlPos OldPosition;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.ITextControl TextControl;
        public CaretMovedEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos posOld, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos posNew) { }
        public override string ToString() { }
    }
    public enum CaretVisualPlacement
    {
        DontScrollIfVisible = 0,
        Generic = 1,
        DirectionalUp = 2,
        DirectionalDown = 3,
    }
    public struct Column
    {
        public Column(int documenOffset) { }
        public Column(JetBrains.TextControl.VirtualSpaceType virtualSpaceType) { }
        public int Offset { get; }
        public JetBrains.TextControl.ColumnType Type { get; }
        public JetBrains.TextControl.VirtualSpaceType VirtualSpaceType { get; }
    }
    public enum ColumnType
    {
        DOCUMENT_CHAR = 0,
        VIRTUAL_SPACE = 1,
    }
    public class CreateTextControlParams<TTextControl>
        where TTextControl : JetBrains.TextControl.ITextControl
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DocumentModel.IDocument Document;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.UI.WindowManagement.WindowFrame Frame;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Type TextControlType;
        public CreateTextControlParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame) { }
    }
    public class CreateVsTextControlEitherParams : JetBrains.TextControl.CreateTextControlParams<JetBrains.TextControl.ITextControl>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.UI.CrossFramework.EitherControl ParentControl;
        public CreateVsTextControlEitherParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.CrossFramework.EitherControl parentControl) { }
    }
    public class CreateWinFormsTextControlParams : JetBrains.TextControl.CreateTextControlParams<JetBrains.TextControl.IWinFormTextControl>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.TextControl.Graphics.IEditorGraphicsProvider GraphicsProvider;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.TextControlScheme Scheme;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.TextControl.ISyntaxHighlighting SyntaxHighlighting;
        public CreateWinFormsTextControlParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.TextControlScheme scheme, JetBrains.TextControl.ISyntaxHighlighting hilite = null, JetBrains.TextControl.Graphics.IEditorGraphicsProvider graphicsprovider = null) { }
        public CreateWinFormsTextControlParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, JetBrains.Application.IShellLocks locks) { }
    }
    public abstract class DefaultTextControlSchemeManager
    {
        public readonly JetBrains.DataFlow.ISimpleSignal ColorsChanged;
        protected DefaultTextControlSchemeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public abstract System.Drawing.Color CodeEditorBackground { get; }
        public abstract System.Drawing.Color CodeEditorForeground { get; }
        public abstract System.Drawing.Color CommentColor { get; }
        public abstract System.Drawing.Color KeywordColor { get; }
        public abstract System.Drawing.Color MethodColor { get; }
        public abstract System.Drawing.Color ParameterColor { get; }
        public abstract System.Drawing.Color PreprocessorKeywordColor { get; }
        public abstract System.Drawing.Color ReadonlyBackground { get; }
        public abstract System.Drawing.Color StringColor { get; }
        public abstract System.Drawing.Color TypeColor { get; }
        public JetBrains.TextControl.TextControlScheme GetNonthemedScheme() { }
        public JetBrains.TextControl.TextControlScheme GetReadonlyScheme() { }
        public abstract JetBrains.TextControl.TextControlScheme GetScheme();
        public abstract void SetScheme(JetBrains.TextControl.TextControlScheme scheme);
    }
    public struct DocOffsetAndVirtual : System.IComparable<JetBrains.TextControl.DocOffsetAndVirtual>, System.IEquatable<JetBrains.TextControl.DocOffsetAndVirtual>
    {
        public DocOffsetAndVirtual(int offset, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> virtualDelta) { }
        public DocOffsetAndVirtual(int offset, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> virtualDelta) { }
        public DocOffsetAndVirtual(int docoffset) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> DocVirtualDelta { get; }
        public bool IsInVirtualSpace { get; }
        public int Offset { get; }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> TextControlVirtualDelta { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.TextControl.DocOffsetAndVirtual other) { }
        public override int GetHashCode() { }
        public static JetBrains.TextControl.DocOffsetAndVirtual Max(JetBrains.TextControl.DocOffsetAndVirtual l1, JetBrains.TextControl.DocOffsetAndVirtual l2) { }
        public static JetBrains.TextControl.DocOffsetAndVirtual Min(JetBrains.TextControl.DocOffsetAndVirtual l1, JetBrains.TextControl.DocOffsetAndVirtual l2) { }
        public override string ToString() { }
    }
    public abstract class EmbeddedObjectAnchor
    {
        protected internal EmbeddedObjectAnchor(bool fillLine) { }
        public bool FillLine { get; }
    }
    public sealed class EmbeddedObjectAnchorBaseline : JetBrains.TextControl.EmbeddedObjectAnchor
    {
        public EmbeddedObjectAnchorBaseline(JetBrains.TextControl.Graphics.Height ascent, JetBrains.TextControl.Graphics.Height descent, bool fillLine) { }
        public JetBrains.TextControl.Graphics.Height Ascent { get; }
        public JetBrains.TextControl.Graphics.Height Descent { get; }
    }
    public sealed class EmbeddedObjectAnchorBottom : JetBrains.TextControl.EmbeddedObjectAnchor
    {
        public EmbeddedObjectAnchorBottom(JetBrains.TextControl.Graphics.Height height, bool fillLine) { }
        public JetBrains.TextControl.Graphics.Height Height { get; }
    }
    public sealed class EmbeddedObjectAnchorTop : JetBrains.TextControl.EmbeddedObjectAnchor
    {
        public EmbeddedObjectAnchorTop(JetBrains.TextControl.Graphics.Height height, bool fillLine) { }
        public JetBrains.TextControl.Graphics.Height Height { get; }
    }
    public enum ErrorStripeIndicatorState
    {
        HIDDEN = 0,
        OFF = 1,
        INVALID = 2,
        WORKING = 3,
        ON = 4,
    }
    public struct FontAttributes
    {
        public FontAttributes(System.Drawing.Font font) { }
        public FontAttributes(System.Drawing.FontFamily fontFamily, System.Drawing.FontStyle fontStyle, float fontSize, System.Drawing.GraphicsUnit unit = 3) { }
        public System.Drawing.FontFamily FontFamily { get; }
        public float Size { get; }
        public System.Drawing.FontStyle Style { get; }
        public System.Drawing.GraphicsUnit Unit { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.TextControl.FontAttributes other) { }
        public override int GetHashCode() { }
    }
    public class static FontAttributesUtil
    {
        public static JetBrains.TextControl.FontAttributes FromFont(JetBrains.UI.Components.Fonts.EitherFont eitherFont) { }
        public static JetBrains.UI.Components.Fonts.EitherFont ToFont(JetBrains.TextControl.FontAttributes attributes) { }
    }
    public interface IEmbeddedObjectEditor : JetBrains.TextControl.IEmbeddedObjectPresentation, System.IDisposable { }
    public interface IEmbeddedObjectPresentation : System.IDisposable
    {
        JetBrains.TextControl.EmbeddedObjectAnchor Anchoring { get; }
        System.Windows.Forms.Control Control { get; }
        object State { get; }
        JetBrains.TextControl.Graphics.Width Width { get; }
    }
    public interface IEmbeddedObjectView : JetBrains.TextControl.IEmbeddedObjectPresentation, System.IDisposable { }
    public class IncorrectColumnType : System.Exception { }
    public interface IRow
    {
        int EndOffset { get; }
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> Index { get; }
        int StartOffset { get; }
        JetBrains.TextControl.Column GetColumn(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> column);
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> GetColumnByOffset(int documentOffset);
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> GetColumnCount();
        JetBrains.TextControl.ColumnType GetColumnType(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> column);
        int GetDocumentOffset(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> column);
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> GetEOLColumnIndex();
    }
    public interface IRowModel
    {
        JetBrains.TextControl.Column GetColumn(JetBrains.TextControl.TextControlLineColumn visualPosition);
        JetBrains.TextControl.IRow GetRow(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> index);
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> GetRowCount();
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> GetRowIndex(int documentOffset);
    }
    public interface ISelectionChange
    {
        JetBrains.TextControl.ITextControl TextControl { get; }
    }
    public interface ISyntaxHighlighting
    {
        JetBrains.Util.TextRange GetAttributesForOffset(JetBrains.TextControl.ITextControl textControl, int offset, out JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes);
        JetBrains.Util.TextRange OnDocumentChange(JetBrains.TextControl.ITextControl textControl, JetBrains.DocumentModel.DocumentChange args);
    }
    public interface ITextControl : JetBrains.Application.IChangeProvider, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.TextControl.ITextControlCaret Caret { get; }
        JetBrains.TextControl.Coords.ITextControlCoords Coords { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.DocumentModel.IDocument Document { get; }
        JetBrains.TextControl.ErrorStripeIndicatorState ErrorStripeIndicatorState { get; set; }
        bool IsDisposed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.Lifetime Lifetime { get; }
        JetBrains.TextControl.TextControlScheme Scheme { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.TextControl.ITextControlScrolling Scrolling { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.TextControl.ITextControlSelection Selection { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.TextControl.ITextControlWindow Window { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> BeforeDispose;
        void EmulateEnter();
        void EmulateTyping(char c);
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        void FillVirtualSpaceUntilCaret();
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable GetUpdateCookie([JetBrains.Annotations.NotNullAttribute()] string description);
        bool IsPositionInTextView([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos position);
    }
    public interface ITextControl2 : JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.TextControl.ITextControlCanvas Canvas { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        JetBrains.TextControl.IRowModel RowModel { get; }
    }
    public interface ITextControlCanvas
    {
        JetBrains.TextControl.Graphics.X GetColumnX(JetBrains.TextControl.IRow row, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> column);
        JetBrains.TextControl.Graphics.Height GetExtentHeight();
        JetBrains.TextControl.Graphics.Width GetExtentWidth();
        JetBrains.TextControl.Graphics.Height GetRowHeight(JetBrains.TextControl.IRow row);
        JetBrains.TextControl.Graphics.Width GetRowWidth(JetBrains.TextControl.IRow row);
        JetBrains.TextControl.Graphics.Y GetRowY(JetBrains.TextControl.IRow row);
    }
    public interface ITextControlCaret
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.Coords.ITextControlPos> Position { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.Coords.ITextControlPos PositionValue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        public event System.EventHandler<JetBrains.TextControl.CaretMovedEventArgs> CaretMoved;
        void MoveTo(JetBrains.TextControl.Coords.ITextControlPos position, JetBrains.TextControl.CaretVisualPlacement visualplace);
    }
    public class static ITextControlCaretEx
    {
        public static void MoveTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlCaret caret, JetBrains.TextControl.DocOffsetAndVirtual position, JetBrains.TextControl.CaretVisualPlacement visualplace) { }
        public static void MoveTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlCaret caret, int offset, JetBrains.TextControl.CaretVisualPlacement visualplace) { }
        public static void MoveTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlCaret caret, JetBrains.TextControl.TextControlLineColumn posTxt, JetBrains.TextControl.CaretVisualPlacement visualplace) { }
        public static void MoveTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlCaret caret, JetBrains.DocumentModel.DocumentCoords posDoc, JetBrains.TextControl.CaretVisualPlacement visualplace) { }
        public static void MoveTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlCaret caret, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> column, JetBrains.TextControl.CaretVisualPlacement visualplace) { }
        public static int Offset([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlCaret caret) { }
    }
    [System.ObsoleteAttribute("Phasing out. Sink events on the text control itself, or use things like Shell.Ins" +
        "tance.Components.TextControlManager().Legacy (or similar) for monitoring all of " +
        "the text controls.")]
    public interface ITextControlChange
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.TextControl.CaretMovedEventArgs CaretChange { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.TextControl.ISelectionChange SelectionChange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.TextControl.IVisibleAreaChange VisibleAreaChange { get; }
    }
    public interface ITextControlHandlerContext
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        void CallNext();
        JetBrains.Util.EnsureWritableResult EnsureWritable();
    }
    public interface ITextControlManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> CurrentFrameTextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> FocusedTextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> LastFocusedTextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.Impl.TextControlManagerDerivativesLegacy Legacy { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ICollectionEvents<JetBrains.TextControl.ITextControl> TextControls { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ICollectionEvents<JetBrains.TextControl.ITextControl> VisibleTextControls { get; }
        void AddTypingHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.TextControl.ITypingContext> FHandler, int priority = 0);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.IWinFormTextControl CreateShellTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.IWinFormTextControl CreateSimpleTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame);
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        TTextControl CreateTextControl<TTextControl>([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.CreateTextControlParams<TTextControl> param)
            where TTextControl : JetBrains.TextControl.ITextControl;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        JetBrains.TextControl.ITextControl CreateVsTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, JetBrains.UI.CrossFramework.EitherControl parent);
    }
    public interface ITextControlScrolling
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.Coords.TextControlPosRange> ViewportRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.Graphics.Rect> ViewportRect { get; }
        void ScrollTo(JetBrains.TextControl.Graphics.PointEx ptCanvas);
        void ScrollTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos position, JetBrains.TextControl.TextControlScrollType scrollType);
    }
    public interface ITextControlSelection
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.Util.IEquatableList<JetBrains.TextControl.Coords.TextControlPosRange>> Ranges { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        [System.ObsoleteAttribute("Sink Ranges.Changed directly.")]
        public event System.EventHandler SelectionChanged;
        void RemoveSelection(bool bCollapseToAnchor);
        void SetRanges([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.TextControlPosRange[] ranges);
    }
    public class static ITextControlSelectionEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.Coords.ITextControlPos GetActivePoint([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.Coords.ITextControlPos GetAnchorPoint([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        public static System.Collections.Generic.IList<string> GetSelectedText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        public static bool HasSelection([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        public static bool IsDisjoint([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        public static JetBrains.Util.TextRange OneDocRangeWithCaret([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        [System.ObsoleteAttribute("Undefined semantic. Do not use. Replace with other methods when seen (IsDisjoint," +
            " UnionOfDocRanges, OneDocRangeWithCaret).")]
        public static JetBrains.Util.TextRange RandomRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
        public static void SetRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs, JetBrains.Util.TextRange range) { }
        public static JetBrains.Util.TextRange UnionOfDocRanges([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlSelection thіs) { }
    }
    public interface ITextControlWindow
    {
        JetBrains.UI.WindowManagement.WindowFrame Frame { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> IsFocused { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> IsVisibleOnScreen { get; }
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> Keyboard { get; }
        JetBrains.DataFlow.ISignal<JetBrains.TextControl.TextControlMouseEventArgs> MouseDown { get; }
        JetBrains.DataFlow.ISignal<JetBrains.TextControl.TextControlMouseEventArgs> MouseMove { get; }
        JetBrains.DataFlow.ISignal<JetBrains.TextControl.TextControlMouseEventArgs> MouseUp { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.UI.IAnchoringRect CreateViewportAnchor([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
        void Focus();
        void Show();
    }
    public class static ITextControlWindowEx
    {
        public static void ShowOrFocus([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControlWindow winmodel, bool focus) { }
    }
    public interface ITypingContext : JetBrains.TextControl.ITextControlHandlerContext
    {
        char Char { get; }
        void QueueCommand(System.Action action);
    }
    public interface IVisibleAreaChange
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
    }
    public interface IWinFormTextControl : JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        System.Windows.Forms.Control ContentControl { get; }
    }
    public interface IWpfTextControl : JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        System.Windows.UIElement Element { get; }
    }
    [System.ObsoleteAttribute("Phasing out. Sink events on the text control itself, or use things like Shell.Ins" +
        "tance.Components.TextControlManager().Legacy (or similar) for monitoring all of " +
        "the text controls.")]
    public class MultiTextControlChange
    {
        public MultiTextControlChange(JetBrains.Application.IChangeMap changeMap) { }
        public System.Collections.Generic.IEnumerator<JetBrains.TextControl.ITextControlChange> GetEnumerator() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    [System.ObsoleteAttribute("Phasing out. Sink events on the text control itself, or use things like Shell.Ins" +
        "tance.Components.TextControlManager().Legacy (or similar) for monitoring all of " +
        "the text controls.")]
    public class MultiTextControlChangeProvider : JetBrains.Application.IChangeProvider
    {
        public MultiTextControlChangeProvider(JetBrains.Application.ChangeManager changeManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DataFlow.Lifetime lifetime) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RunningTextControls
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ICollectionEvents<JetBrains.TextControl.ITextControl> TextControls;
        public RunningTextControls([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator) { }
    }
    public class static ShellComponentsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.ITextControlManager TextControlManager([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StandaloneTextControlSwitchingGraphicsProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.TextControl.Graphics.IEditorGraphicsProvider CreateGraphicsProvider() { }
    }
    public struct TextAttributes
    {
        public TextAttributes(JetBrains.TextControl.FontAttributes font, System.Drawing.Color color, System.Drawing.Color backgroundColor, JetBrains.TextControl.DocumentMarkup.Effect effect) { }
        public TextAttributes(JetBrains.TextControl.FontAttributes font, System.Drawing.Color color, System.Drawing.Color backgroundColor, string tooltip, JetBrains.TextControl.DocumentMarkup.Effect effect) { }
        public System.Drawing.Color BackgroundColor { get; set; }
        public System.Drawing.Color Color { get; set; }
        public JetBrains.TextControl.DocumentMarkup.Effect Effect { get; set; }
        public JetBrains.TextControl.FontAttributes FontAttributes { get; set; }
        public string ToolTip { get; set; }
    }
    public struct TextControlColumn { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlCreator
    {
        protected readonly JetBrains.Application.Components.IComponentContainer myComponentContainer;
        protected readonly JetBrains.TextControl.DefaultTextControlSchemeManager myDefaultTextControlSchemeManager;
        protected readonly JetBrains.Application.IShellLocks myInvocator;
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected readonly JetBrains.TextControl.RunningTextControls myRunningTextControls;
        protected readonly JetBrains.TextControl.StandaloneTextControlSwitchingGraphicsProvider mySwitchingGraphicsProvider;
        public TextControlCreator(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Components.IComponentContainer componentContainer, JetBrains.TextControl.StandaloneTextControlSwitchingGraphicsProvider switchingGraphicsProvider, JetBrains.Application.IShellLocks invocator, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, JetBrains.TextControl.RunningTextControls runningTextControls) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.TextControl.IWinFormTextControl CreateShellTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual TTextControl CreateTextControl<TTextControl>([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.CreateTextControlParams<TTextControl> param)
            where TTextControl : JetBrains.TextControl.ITextControl { }
    }
    public class static TextControlDataConstants { }
    public class static TextControlExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable LockTextControl([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks shellLocks) { }
        public static void ShowAtCaret([JetBrains.Annotations.NotNullAttribute()] this JetBrains.UI.Tooltips.ITooltipManager thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, JetBrains.ActionManagement.IActionManager actionman) { }
    }
    public class static TextControlHelper
    {
        public static bool NotNullAndCanEdit(JetBrains.TextControl.ITextControl editor) { }
        public static bool NullOrReadonly(JetBrains.TextControl.ITextControl editor) { }
    }
    public struct TextControlLine { }
    public struct TextControlLineColumn : System.IEquatable<JetBrains.TextControl.TextControlLineColumn>
    {
        public readonly JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> Column;
        public readonly JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> Line;
        public TextControlLineColumn(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> line, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> column) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.TextControl.TextControlLineColumn other) { }
        public override int GetHashCode() { }
        public JetBrains.TextControl.TextControlLineColumn GetStartOfRow() { }
        public static JetBrains.TextControl.TextControlLineColumn Max(JetBrains.TextControl.TextControlLineColumn left, JetBrains.TextControl.TextControlLineColumn right) { }
        public static JetBrains.TextControl.TextControlLineColumn Min(JetBrains.TextControl.TextControlLineColumn left, JetBrains.TextControl.TextControlLineColumn right) { }
        public JetBrains.TextControl.TextControlLineColumn OffsetHorizontally(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> nColumnDelta) { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlManager : JetBrains.TextControl.ITextControlManager
    {
        public static readonly bool OptionTrace;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.TextControl.ITextControl> TextControlInWindowFrame;
        public TextControlManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.TextControlCreator textControlCreator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Impl.TextControlTypingHandlers typingHandlers, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Impl.TextControlProperties textControlProperties, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.RunningTextControls runningTextControls, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Impl.TextControlManagerDerivativesLegacy textControlManagerDerivativesLegacy, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager) { }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> CurrentFrameTextControl { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> FocusedTextControl { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> LastFocusedTextControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.Impl.TextControlManagerDerivativesLegacy Legacy { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.TextControl.ITextControl> TextControls { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.TextControl.ITextControl> VisibleTextControls { get; }
        public void AddTypingHandler(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.TextControl.ITypingContext> FHandler, int priority = 0) { }
        public JetBrains.TextControl.IWinFormTextControl CreateShellTextControl(JetBrains.DocumentModel.IDocument document, JetBrains.UI.WindowManagement.WindowFrame frame) { }
        public virtual JetBrains.TextControl.IWinFormTextControl CreateSimpleTextControl(JetBrains.DocumentModel.IDocument document, JetBrains.UI.WindowManagement.WindowFrame frame) { }
        public TTextControl CreateTextControl<TTextControl>(JetBrains.TextControl.CreateTextControlParams<TTextControl> param)
            where TTextControl : JetBrains.TextControl.ITextControl { }
        public JetBrains.TextControl.ITextControl CreateVsTextControl(JetBrains.DocumentModel.IDocument document, JetBrains.UI.WindowManagement.WindowFrame frame, JetBrains.UI.CrossFramework.EitherControl parent) { }
    }
    public class TextControlMouseEventArgs : System.EventArgs
    {
        public bool IsHandled;
        public readonly JetBrains.Interop.WinApi.KeyStateMasks KeysAndButtons;
        public readonly System.Drawing.Point ScreenPosition;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.ITextControl TextControl;
        public TextControlMouseEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, System.Drawing.Point ptScreen) { }
        public TextControlMouseEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, System.Nullable<JetBrains.Interop.WinApi.KeyStateMasks> keysnbuttons, System.Drawing.Point ptScreen) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.TextControlMouseEventArgs FromCurrentPositionAndState([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl tc) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.TextControlMouseEventArgs FromCurrentPositionAndStateIfOverTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl tc) { }
    }
    public class TextControlScheme : System.ICloneable
    {
        public TextControlScheme(JetBrains.TextControl.TextAttributes attributes, System.Drawing.Color caretColor, int tabSize, bool isVirtualSpace, bool hasErrorStripe) { }
        public JetBrains.TextControl.TextAttributes Attributes { get; set; }
        public System.Drawing.Color CaretColor { get; set; }
        public bool HasErrorStripe { get; set; }
        public bool HighlightCurrentLine { get; set; }
        public bool IsVirtualSpace { get; set; }
        public bool ReadOnly { get; set; }
        public int TabSize { get; set; }
        public object Clone() { }
        public JetBrains.TextControl.TextControlScheme Copy() { }
    }
    public enum TextControlScrollType
    {
        DontCare = 0,
        CenterInView = 1,
        TopOfView = 2,
        UpperHalf = 3,
        LowerHalf = 4,
        Smart = 5,
        SmartDirectionalUp = 6,
        SmartDirectionalDown = 7,
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Text editor settings")]
    public class TextControlSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to highlight current line in text editor")]
        public readonly bool HighlightCurrentLine;
    }
    public class static TypingHandlerPriority
    {
        public const int FINAL_TYPING_HANDLERS = 2147483647;
        public const int MODIFYING_BEFORE_AFTER_TYPING_HANDLERS = -1000;
        public const int READONLY_BEFORE_AFTER_TYPING_HANDLERS = -10000;
        public const int SKIPPING_TYPING_HANDLERS = -2147483648;
    }
    public enum VirtualSpaceType
    {
        TAB = 0,
        EOL = 1,
        BEYOND_EOL = 2,
    }
}
namespace JetBrains.TextControl.Coords
{
    
    public interface ITextControlCoords
    {
        JetBrains.TextControl.Coords.ITextControlPos FromCanvas(JetBrains.TextControl.Graphics.PointEx ptCanvas);
        JetBrains.TextControl.Coords.ITextControlPos FromDocLineColumn(JetBrains.DocumentModel.DocumentCoords doccoords);
        JetBrains.TextControl.Coords.ITextControlPos FromDocOffset(int docoffset);
        JetBrains.TextControl.Coords.ITextControlPos FromDocOffsetAndVirtual(JetBrains.TextControl.DocOffsetAndVirtual docoffs);
        JetBrains.TextControl.Coords.ITextControlPos FromScreen(System.Drawing.Point ptScreen);
        JetBrains.TextControl.Coords.ITextControlPos FromScreen(System.Windows.Point ptScreen);
        JetBrains.TextControl.Coords.ITextControlPos FromTextControlLineColumn(JetBrains.TextControl.TextControlLineColumn textcoords);
    }
    public interface ITextControlPos : System.IEquatable<JetBrains.TextControl.Coords.ITextControlPos>
    {
        JetBrains.TextControl.ITextControl TextControl { get; }
        JetBrains.TextControl.Graphics.Rect ToCanvas();
        JetBrains.DocumentModel.DocumentCoords ToDocLineColumn();
        int ToDocOffset();
        JetBrains.TextControl.DocOffsetAndVirtual ToDocOffsetAndVirtual();
        JetBrains.TextControl.Coords.ITextControlPos ToRetainedPos();
        System.Drawing.Rectangle ToScreen();
        JetBrains.TextControl.TextControlLineColumn ToTextControlLineColumn();
    }
    public abstract class TextControlCoordinateConversionCore
    {
        public readonly JetBrains.TextControl.ITextControl TextControl;
        protected TextControlCoordinateConversionCore([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol) { }
        public abstract JetBrains.TextControl.TextControlLineColumn Canvas_To_TextControlLineColumn(JetBrains.TextControl.Graphics.PointEx ptCanvas);
        public JetBrains.TextControl.DocOffsetAndVirtual DocLineColumn_To_DocOffset(JetBrains.DocumentModel.DocumentCoords coords) { }
        public abstract JetBrains.TextControl.TextControlLineColumn DocLineColumn_To_TextControlLineColumn(JetBrains.DocumentModel.DocumentCoords doccoords);
        public JetBrains.DocumentModel.DocumentCoords DocOffset_To_DocLineColumn(JetBrains.TextControl.DocOffsetAndVirtual docoffset) { }
        public abstract JetBrains.TextControl.TextControlLineColumn DocOffset_To_TextControlLineColumn(JetBrains.TextControl.DocOffsetAndVirtual docoffset);
        protected System.Drawing.Size GetViewportLocation() { }
        public abstract JetBrains.TextControl.TextControlLineColumn Screen_To_TextControlLineColumn(System.Drawing.Point ptScreen);
        protected abstract System.Drawing.Point Screen_To_Viewport(System.Drawing.Point ptScreen);
        public abstract JetBrains.TextControl.Graphics.Rect TextControlLineColumn_To_Canvas(JetBrains.TextControl.TextControlLineColumn posTxt);
        public abstract JetBrains.DocumentModel.DocumentCoords TextControlLineColumn_To_DocLineColumn(JetBrains.TextControl.TextControlLineColumn posTxt);
        public abstract JetBrains.TextControl.DocOffsetAndVirtual TextControlLineColumn_To_DocOffset(JetBrains.TextControl.TextControlLineColumn posTxt);
        public abstract System.Drawing.Rectangle TextControlLineColumn_To_Screen(JetBrains.TextControl.TextControlLineColumn posText);
        protected abstract System.Drawing.Point Viewport_To_Screen(System.Drawing.Point ptViewport);
    }
    public sealed class TextControlCoords : JetBrains.TextControl.Coords.ITextControlCoords
    {
        public TextControlCoords([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.TextControlCoordinateConversionCore conv) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.Coords.TextControlCoordinateConversionCore ConversionCore { get; }
    }
    public sealed class TextControlPosRange : System.IEquatable<JetBrains.TextControl.Coords.TextControlPosRange>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.Coords.ITextControlPos End;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.Coords.ITextControlPos Start;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.ITextControl TextControl;
        public TextControlPosRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos start, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlPos end) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.TextControl.Coords.TextControlPosRange other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.Coords.TextControlPosRange FromDocLineColumnRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, JetBrains.DocumentModel.DocLineColumnRange range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.Coords.TextControlPosRange FromDocRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.Coords.TextControlPosRange FromDocRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, int start, int end) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.Coords.TextControlPosRange FromTextControlLineCol([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol, JetBrains.VsIntegration.TextControl.TextControlLineColumnRange range) { }
        public override int GetHashCode() { }
        public JetBrains.DocumentModel.DocLineColumnRange ToDocLineColumnRangeNormalized() { }
        public JetBrains.DocumentModel.DocLineColumnRange ToDocLineColumnRangeUnnormalized() { }
        public JetBrains.Util.TextRange ToDocRangeNormalized() { }
        public JetBrains.TextControl.Coords.TextControlPosRange ToRetained() { }
        public override string ToString() { }
        public JetBrains.VsIntegration.TextControl.TextControlLineColumnRange ToTextControlLineColumnRangeNormalized() { }
        public JetBrains.VsIntegration.TextControl.TextControlLineColumnRange ToTextControlLineColumnRangeUnnormalized() { }
    }
}
namespace JetBrains.TextControl.Data
{
    
    public class DefaultRangeableSet<T> : JetBrains.TextControl.Data.IRangeableSet<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T :  class, JetBrains.TextControl.Data.IRangeable
    {
        public static readonly JetBrains.TextControl.Data.IRangableSetFactory<T, JetBrains.TextControl.Data.DefaultRangeableSet<T>> Factory;
        public bool IsEmpty { get; }
        public void Add(T rangeable) { }
        public void AddAllValidTo(System.Collections.Generic.ICollection<T> target) { }
        public bool Contains(T rangeable) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public void Remove(T rangeable) { }
        public override string ToString() { }
    }
    public interface IRangableSetFactory<TItem, TSet>
        where TItem : JetBrains.TextControl.Data.IRangeable
        where TSet : JetBrains.TextControl.Data.IRangeableSet<>
    {
        bool Compare(TSet s1, TSet s2);
        TSet CreateCopy(TSet set);
        TSet CreateEmpty();
    }
    public interface IRangeable
    {
        JetBrains.DocumentModel.IDocument Document { get; }
        bool IsValid { get; }
        JetBrains.Util.TextRange Range { get; }
    }
    public interface IRangeableContainer<TItem> : System.Collections.Generic.IEnumerable<TItem>, System.Collections.IEnumerable
        where TItem : JetBrains.TextControl.Data.IRangeable
    {
        public event System.Action<TItem> RemovedOnDocumentChange;
        void Add(TItem rangeable);
        void BeforeDocumentChange(JetBrains.DocumentModel.DocumentChange args);
        bool Contains(TItem rangeable);
        System.Collections.Generic.IEnumerable<TItem> GetAllInRange(JetBrains.Util.TextRange range);
        System.Collections.Generic.IEnumerable<TItem> GetAllOverRange(JetBrains.Util.TextRange range);
        JetBrains.TextControl.Data.IRangeIterator<TItem> Iterate();
        JetBrains.TextControl.Data.IRangeIterator<TItem> Iterate(int documentOffset);
        void OnDocumentChange(JetBrains.DocumentModel.DocumentChange args);
        void Remove(TItem rangeable);
    }
    public interface IRangeableSet<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T : JetBrains.TextControl.Data.IRangeable
    {
        bool IsEmpty { get; }
        void Add(T rangeable);
        void AddAllValidTo(System.Collections.Generic.ICollection<T> target);
        bool Contains(T rangeable);
        void Remove(T rangeable);
    }
    public interface IRangeIterator<TItem>
        where TItem : JetBrains.TextControl.Data.IRangeable
    {
        JetBrains.TextControl.Data.IRangeableSet<TItem> GetRangableSet();
        JetBrains.Util.TextRange GetRange();
        bool Next();
        bool Prev();
        bool Valid();
    }
    public class RangeableContainer<TItem, TSet> : JetBrains.TextControl.Data.IRangeableContainer<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.IEnumerable
        where TItem : JetBrains.TextControl.Data.IRangeable
        where TSet :  class, JetBrains.TextControl.Data.IRangeableSet<>
    {
        public RangeableContainer(JetBrains.DocumentModel.IDocument document, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.Data.IRangableSetFactory<TItem, TSet> setFactory) { }
        public event System.Action<TItem> RemovedOnDocumentChange;
        public void Add(TItem rangeable) { }
        public void BeforeDocumentChange(JetBrains.DocumentModel.DocumentChange change) { }
        public bool Contains(TItem rangeable) { }
        public System.Collections.Generic.IEnumerator<TItem> GetEnumerator() { }
        public void OnDocumentChange(JetBrains.DocumentModel.DocumentChange change) { }
        public void Remove(TItem rangeable) { }
    }
}
namespace JetBrains.TextControl.DataConstants
{
    
    public class static DataContextsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.DataContext.IDataContext FromTextControl([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.DataContexts thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Settings.ContextRange ToContextRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> ToDataContext([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlDataRules
    {
        public TextControlDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textman, JetBrains.Application.DataContext.DataContexts contexts, JetBrains.Application.IShellLocks locks, JetBrains.ActionManagement.IActionManager actionManager) { }
    }
}
namespace JetBrains.TextControl.DataContext
{
    
    public class static DataConstants
    {
        [System.ObsoleteAttribute("Wtf?? Nobody\'s suppplying it.")]
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.TextControl.ITextControl> NEAREST_TEXT_CONTROL;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.TextControl.ITextControl> TEXT_CONTROL;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.TextControl.Coords.ITextControlPos> TextControlPosition;
    }
}
namespace JetBrains.TextControl.Diagnostics
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlDebugMonitor
    {
        public readonly JetBrains.DataFlow.ISimpleSignal ShowWindow;
        public TextControlDebugMonitor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IMainWindow mainwin, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.IShellLocks locks) { }
        [JetBrains.ActionManagement.ActionHandlerAttribute()]
        public class TextControlDebugMonitor_ShowAction : JetBrains.ActionManagement.IActionHandler { }
    }
}
namespace JetBrains.TextControl.DocumentMarkup
{
    
    public enum AreaType
    {
        EXACT_RANGE = 0,
        LINES_IN_RANGE = 1,
    }
    public abstract class DocumentMarkupBase : JetBrains.TextControl.DocumentMarkup.IDocumentMarkup, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupImpl, System.IDisposable
    {
        protected readonly JetBrains.DocumentModel.IDocument myDocument;
        protected DocumentMarkupBase(JetBrains.DocumentModel.IDocument document, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.DocumentMarkup.HihglighterContext context) { }
        public JetBrains.TextControl.DocumentMarkup.HihglighterContext Context { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public event System.Action<JetBrains.TextControl.DocumentMarkup.DocumentMarkupModifiedEventArgs> Changed;
        public JetBrains.TextControl.DocumentMarkup.IHighlighter AddHighlighter(JetBrains.Util.Key key, JetBrains.Util.TextRange range, JetBrains.TextControl.DocumentMarkup.AreaType areaType, int layer, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip) { }
        public JetBrains.TextControl.DocumentMarkup.IHighlighter AddHighlighter(JetBrains.Util.Key key, JetBrains.Util.TextRange range, JetBrains.TextControl.DocumentMarkup.AreaType areaType, int layer, string attributeId, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip, JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo gutterMarkInfo = null) { }
        public System.IDisposable BatchChangeCookie() { }
        protected abstract JetBrains.TextControl.DocumentMarkup.IHighlighter CreateHighlighter(JetBrains.Util.TextRange range, JetBrains.Util.Key key, int layer, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.AreaType areaType, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.TextControl.DocumentMarkup.IHighlighter CreateHighlighter(JetBrains.Util.TextRange range, int layer, JetBrains.Util.Key key, JetBrains.TextControl.DocumentMarkup.AreaType areaType, string attributeId, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip, JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo glyphMarginInfo, JetBrains.TextControl.DocumentMarkup.HihglighterContext context);
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetHighlightersEnumerable() { }
        public System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetHighlightersEnumerable(JetBrains.Util.Key key) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetHighlightersOver(JetBrains.Util.TextRange textRange) { }
        protected virtual bool IsInSync() { }
        public virtual bool RemoveHighlighter(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
    }
    public class static DocumentMarkupEx { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DocumentMarkupManagerBase : JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager
    {
        public DocumentMarkupManagerBase(JetBrains.Application.IShellLocks locks, JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry) { }
        public JetBrains.Application.IShellLocks Locks { get; }
        protected virtual JetBrains.TextControl.DocumentMarkup.IDocumentMarkup CreateMarkupModel(JetBrains.DocumentModel.IDocument document) { }
        public virtual JetBrains.TextControl.DocumentMarkup.IDocumentMarkup GetMarkupModel(JetBrains.DocumentModel.IDocument document) { }
        public static void UnregisterMarkupModel(JetBrains.DocumentModel.IDocument document) { }
    }
    public class DocumentMarkupModifiedEventArgs
    {
        public readonly System.Collections.Generic.ICollection<JetBrains.TextControl.DocumentMarkup.IHighlighter> Added;
        public bool IsInSync;
        public readonly System.Collections.Generic.ICollection<JetBrains.TextControl.DocumentMarkup.IHighlighter> Modified;
        public readonly System.Collections.Generic.ICollection<JetBrains.TextControl.DocumentMarkup.IHighlighter> Removed;
        public DocumentMarkupModifiedEventArgs(System.Collections.Generic.ICollection<JetBrains.TextControl.DocumentMarkup.IHighlighter> added, System.Collections.Generic.ICollection<JetBrains.TextControl.DocumentMarkup.IHighlighter> removed, System.Collections.Generic.ICollection<JetBrains.TextControl.DocumentMarkup.IHighlighter> modified) { }
    }
    public struct Effect
    {
        public static readonly JetBrains.TextControl.DocumentMarkup.Effect EMPTY;
        public Effect(JetBrains.TextControl.DocumentMarkup.EffectType type, System.Drawing.Color color) { }
        public Effect(JetBrains.TextControl.DocumentMarkup.EffectType type, System.Drawing.Color color, System.Drawing.Color fillColor, double thickness) { }
        public System.Drawing.Color Color { get; }
        public System.Drawing.Color FillColor { get; }
        public double Thickness { get; }
        public JetBrains.TextControl.DocumentMarkup.EffectType Type { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public enum EffectType
    {
        NONE = 0,
        HIGHLIGHT = 1,
        TEXT = 2,
        WAVE = 3,
        SOLID_UNDERLINE = 4,
        DOTTED_OUTLINE = 5,
        SOLID_OUTLINE = 6,
        DOTTED_UNDERLINE = 7,
        GUTTER_MARK = 8,
        ERROR_STRIPE_MARK = 9,
    }
    public class EmbeddedObjectInfo
    {
        public EmbeddedObjectInfo(JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.Util.Key key) { }
        public JetBrains.Util.Key Key { get; }
        public JetBrains.DocumentModel.IRangeMarker RangeMarker { get; }
    }
    public struct ErrorStripeAttributes
    {
        public static readonly JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes Empty;
        public ErrorStripeAttributes(JetBrains.TextControl.DocumentMarkup.ErrorStripeKind kind, [JetBrains.Annotations.NotNullAttribute()] string idErrorStripeColorHighlighterAttribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ErrorStripeColorHighlighterAttributeId { get; }
        public bool IsShowing { get; }
        public JetBrains.TextControl.DocumentMarkup.ErrorStripeKind Kind { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public enum ErrorStripeKind
    {
        NONE = 0,
        WARNING = 1,
        ERROR = 2,
    }
    public class static GutterMarkInfoEx
    {
        public static JetBrains.TextControl.DocumentMarkup.PresentationObject GetPresentationObject(System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo> infos, System.Collections.Generic.ICollection<JetBrains.UI.BulbMenu.BulbActionKey> keys) { }
        public static void OnClick(this JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo info, JetBrains.UI.BulbMenu.BulbMenuComponent bulbMenu, JetBrains.UI.PopupWindowManager.PopupWindowContextSource popupWindowContextSource, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class static GutterMarkMenuLayouter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.PopupWindowManager.IPopupWindowContext Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.PopupWindowManager.PopupWindowContextSource CreateSource([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext) { }
    }
    public enum HighContrastMode
    {
        Neutral = 0,
        SameAsLight = 1,
        SameAsDark = 2,
        Automatic = 3,
        None = 4,
    }
    public class HighlighterAttributes
    {
        public static readonly JetBrains.TextControl.DocumentMarkup.HighlighterAttributes UNDEFINED;
        public static readonly System.Drawing.Color UNDEFINED_COLOR;
        public static readonly JetBrains.TextControl.DocumentMarkup.Effect UNDEFINED_EFFECT;
        public static readonly System.Drawing.FontFamily UNDEFINED_FONT_FAMILY;
        public static readonly float UNDEFINED_FONT_SIZE;
        public static readonly int UNDEFINED_FONT_STYLE;
        public static readonly System.Nullable<double> UNDEFINED_OPACITY;
        public HighlighterAttributes(JetBrains.TextControl.DocumentMarkup.HighlighterAttributes other) { }
        public HighlighterAttributes(System.Drawing.Color color, System.Drawing.Color backgroundColor) { }
        public HighlighterAttributes(System.Drawing.Color color) { }
        public HighlighterAttributes(System.Drawing.FontStyle fontStyle) { }
        public HighlighterAttributes(System.Drawing.FontFamily fontFamily, int fontStyle, float fontSize, System.Drawing.GraphicsUnit fontUnit, System.Drawing.Color color, System.Drawing.Color backgroundColor, JetBrains.TextControl.DocumentMarkup.Effect effectType, System.Nullable<double> opacityFore, System.Nullable<double> opacityBack) { }
        public HighlighterAttributes(JetBrains.TextControl.DocumentMarkup.Effect effect) { }
        public System.Drawing.Color BackgroundColor { get; }
        public System.Nullable<double> BackgroundOpacity { get; }
        public System.Drawing.Color Color { get; }
        public JetBrains.TextControl.DocumentMarkup.Effect Effect { get; }
        public System.Drawing.FontFamily FontFamily { get; }
        public float FontSize { get; }
        public int FontStyle { get; }
        public System.Drawing.GraphicsUnit FontUnit { get; }
        public System.Nullable<double> ForegroundOpacity { get; }
        public static JetBrains.TextControl.DocumentMarkup.HighlighterAttributes CreateFromAttribute(JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute attribute) { }
        public static JetBrains.TextControl.DocumentMarkup.HighlighterAttributes CreateFromAttribute(JetBrains.Application.Parts.PartCatalogueAttribute attribute) { }
        public static JetBrains.TextControl.DocumentMarkup.HighlighterAttributes FromBackgroundColor(System.Drawing.Color backgroundColor) { }
        public bool IsFontDefined() { }
        public JetBrains.TextControl.TextAttributes Join(JetBrains.TextControl.TextAttributes defaults) { }
        public JetBrains.TextControl.DocumentMarkup.HighlighterAttributes Merge(JetBrains.TextControl.DocumentMarkup.HighlighterAttributes other) { }
    }
    public abstract class HighlighterBase : JetBrains.TextControl.Data.IRangeable, JetBrains.TextControl.DocumentMarkup.IHighlighter
    {
        protected HighlighterBase(JetBrains.TextControl.DocumentMarkup.HihglighterContext context, JetBrains.TextControl.DocumentMarkup.AreaType areaType, JetBrains.Util.Key key, int layer, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip) { }
        protected HighlighterBase(JetBrains.TextControl.DocumentMarkup.HihglighterContext context, JetBrains.TextControl.DocumentMarkup.AreaType areaType, JetBrains.Util.Key key, int layer, string attributeId, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip, JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry registry, JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo gutterMarkInfo) { }
        public JetBrains.TextControl.DocumentMarkup.AreaType AreaType { get; }
        public string AttributeId { get; }
        public JetBrains.TextControl.DocumentMarkup.HighlighterAttributes Attributes { get; }
        public JetBrains.TextControl.DocumentMarkup.HihglighterContext Context { get; }
        public abstract JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes ErrorStripeAttributes { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.TextControl.DocumentMarkup.IGutterMark GutterMark { get; }
        public JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo GutterMarkInfo { get; }
        public abstract bool IsValid { get; }
        public JetBrains.Util.Key Key { get; }
        public int Layer { get; }
        public abstract JetBrains.Util.TextRange Range { get; }
        public JetBrains.UI.RichText.RichTextBlock RichTextToolTip { get; }
        public string ToolTip { get; }
        public object UserData { get; set; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HighlighterCustomization : JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization
    {
        public HighlighterCustomization([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry) { }
        protected virtual JetBrains.TextControl.DocumentMarkup.HighlighterAttributes ApplyIdeCustomizations([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.HighlighterAttributes sample, [JetBrains.Annotations.NotNullAttribute()] string sRegisteredHighlighterAttributeId) { }
    }
    public class static HighlighterLayer
    {
        public const int CARET_ROW = 1000;
        public const int DEADCODE = 3000;
        public const int ERROR = 4000;
        public const int SELECTION = 5000;
        public const int SYNTAX = 2000;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HighlightingAttributeRegistryImpl : JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry
    {
        public HighlightingAttributeRegistryImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer container) { }
        public JetBrains.TextControl.DocumentMarkup.HighlighterAttributes GetAttributes([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes GetErrorStripeAttributes(string id) { }
        public JetBrains.TextControl.DocumentMarkup.IGutterMark GetGutterMark(string id) { }
        public int GetLayer(string id) { }
        public void RegisterKey(JetBrains.DataFlow.Lifetime lifetime, string id, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes defaultAttributes) { }
    }
    public class HihglighterContext
    {
        public HihglighterContext(JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager markupManager, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager MarkupManager { get; }
    }
    public abstract class IconGutterMark : JetBrains.UI.Wpf.AAutomation, JetBrains.TextControl.DocumentMarkup.IGutterMark, JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        protected IconGutterMark([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IconId iconid, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public virtual JetBrains.UI.BulbMenu.IAnchorPosition AnchorPosition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.Icons.IconId IconId { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.Icons.IThemedIconManager ThemedIconManager { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> GetBulbMenuItems(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
        public JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo GetGutterMarkInfo(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public virtual JetBrains.UI.RichText.RichText GetRichText(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public class GutterMarkInfoImpl : JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo
        {
            public GutterMarkInfoImpl(JetBrains.TextControl.DocumentMarkup.IconGutterMark mark, JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
            public JetBrains.UI.BulbMenu.IAnchorPosition AnchorPosition { get; }
            public System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> BulbMenuItems { get; }
            public JetBrains.UI.Icons.IconId IconId { get; }
            public JetBrains.UI.RichText.RichText RichText { get; }
            public override string ToString() { }
        }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class IconGutterMarkAvalonView : JetBrains.UI.Wpf.ViewControl<JetBrains.TextControl.DocumentMarkup.IconGutterMark>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.DocumentMarkup.IconGutterMark automation) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.WindowlessControl)]
    public class IconGutterMarkWindowlessControlView : JetBrains.CommonControls.IConstrainableControl, JetBrains.CommonControls.IWindowlessControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.TextControl.DocumentMarkup.IconGutterMark>
    {
        public IconGutterMarkWindowlessControlView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.DocumentMarkup.IconGutterMark guttermark, JetBrains.UI.Icons.IThemedIconManager iconman) { }
    }
    public interface IDocumentMarkup : System.IDisposable
    {
        JetBrains.TextControl.DocumentMarkup.HihglighterContext Context { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocument Document { get; }
        public event System.Action<JetBrains.TextControl.DocumentMarkup.DocumentMarkupModifiedEventArgs> Changed;
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.IHighlighter AddHighlighter([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.Key key, JetBrains.Util.TextRange range, JetBrains.TextControl.DocumentMarkup.AreaType areaType, int layer, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.IHighlighter AddHighlighter([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.Key key, JetBrains.Util.TextRange range, JetBrains.TextControl.DocumentMarkup.AreaType areaType, int layer, [JetBrains.Annotations.NotNullAttribute()] string attributeId, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip, JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo gutterMarkInfo = null);
        System.IDisposable BatchChangeCookie();
        System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetHighlightersEnumerable();
        System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetHighlightersEnumerable(JetBrains.Util.Key key);
        System.Collections.Generic.IEnumerable<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetHighlightersOver(JetBrains.Util.TextRange textRange);
        bool RemoveHighlighter([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
    }
    public interface IDocumentMarkupImpl : JetBrains.TextControl.DocumentMarkup.IDocumentMarkup, System.IDisposable
    {
        void FireHighlighterModified(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
    }
    public interface IDocumentMarkupManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.IDocumentMarkup GetMarkupModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document);
    }
    public interface IGutterMark : JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo GetGutterMarkInfo(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
    }
    public interface IGutterMarkInfo
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.BulbMenu.IAnchorPosition AnchorPosition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> BulbMenuItems { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.Icons.IconId IconId { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.RichText.RichText RichText { get; }
    }
    public interface IHighlighter : JetBrains.TextControl.Data.IRangeable
    {
        JetBrains.TextControl.DocumentMarkup.AreaType AreaType { get; }
        string AttributeId { get; }
        JetBrains.TextControl.DocumentMarkup.HighlighterAttributes Attributes { get; }
        JetBrains.TextControl.DocumentMarkup.HihglighterContext Context { get; }
        JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes ErrorStripeAttributes { get; }
        string ErrorStripeToolTip { get; }
        JetBrains.TextControl.DocumentMarkup.IGutterMark GutterMark { get; }
        JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo GutterMarkInfo { get; }
        JetBrains.Util.Key Key { get; }
        int Layer { get; }
        JetBrains.UI.RichText.RichTextBlock RichTextToolTip { get; }
        string ToolTip { get; }
        object UserData { get; set; }
    }
    public interface IHighlighterCustomization
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.HighlighterAttributes GetCustomizedHighlighterAttributes([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.HighlighterAttributes GetCustomizedRegisteredHighlighterAttributes([JetBrains.Annotations.NotNullAttribute()] string sHighlighterAttributeId);
    }
    public class static IHighlighterEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.DocumentMarkup.HighlighterAttributes GetCustomizedHighlighterAttributes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.DocumentMarkup.IHighlighter thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization customization) { }
    }
    public interface IHighlighterTooltipProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.UI.RichText.RichTextBlock GetRichTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetTooltipForErrorStripe(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
    }
    public interface IHighlightingAttributeRegistry
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.HighlighterAttributes GetAttributes([JetBrains.Annotations.NotNullAttribute()] string id);
        JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes GetErrorStripeAttributes(string id);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.TextControl.DocumentMarkup.IGutterMark GetGutterMark(string id);
        int GetLayer(string id);
        void RegisterKey(JetBrains.DataFlow.Lifetime lifetime, string id, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes defaultAttributes);
    }
    public enum PaletteColorIndex : uint
    {
        GenericTextForeground = 0u,
        GenericTextBackground = 1u,
        PaletteBlack = 2u,
        PaletteWhite = 3u,
        PaletteMaroon = 4u,
        PaletteDarkGreen = 5u,
        PaletteBrown = 6u,
        PaletteDarkBlue = 7u,
        PalettePurple = 8u,
        PaletteAquamarine = 9u,
        PaletteLightGray = 10u,
        PaletteDarkGray = 11u,
        PaletteRed = 12u,
        PaletteGreen = 13u,
        PaletteYellow = 14u,
        PaletteBlue = 15u,
        PaletteMagenta = 16u,
        PaletteCyan = 17u,
        SelectedTextForeground = 18u,
        SelectedTextBackground = 19u,
        InactiveSelectionForeground = 20u,
        InactiveSelectionBackground = 21u,
        IndicatorMarginBackground = 22u,
        PlainTextForeground = 23u,
        PlainTextBackground = 24u,
    }
    public class PresentationObject
    {
        public JetBrains.UI.Icons.IconId IconId { get; set; }
        public JetBrains.UI.RichText.RichText RichText { get; set; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class RegisterHighlighterAttribute : JetBrains.Application.Parts.PartAttribute
    {
        [System.ObsoleteAttribute("Do not set the GUID manually.")]
        public RegisterHighlighterAttribute(string id, [JetBrains.Annotations.CanBeNullAttribute()] string guid) { }
        public RegisterHighlighterAttribute([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public bool AppendProductToThemeName { get; set; }
        public string BackgroundColor { get; set; }
        public System.Nullable<double> BackgroundOpacity { get; set; }
        public string DarkBackgroundColor { get; set; }
        public string DarkForegroundColor { get; set; }
        public string EffectColor { get; set; }
        public JetBrains.TextControl.DocumentMarkup.EffectType EffectType { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string ErrorStripeColorHighlighterAttributeId { get; set; }
        public JetBrains.TextControl.DocumentMarkup.ErrorStripeKind ErrorStripeKind { get; set; }
        public string FontFamily { get; set; }
        public float FontSize { get; set; }
        public System.Drawing.FontStyle FontStyle { get; set; }
        public System.Drawing.GraphicsUnit FontUnit { get; set; }
        public string ForegroundColor { get; set; }
        public System.Nullable<double> ForegroundOpacity { get; set; }
        [System.ObsoleteAttribute("VS-only. To get marker type GUID, call VsRegisterHighlighterAttributeEx::GetMarke" +
            "rTypeGuid. Do not set it explicitly on the attribute because it\'s now autogenera" +
            "ted.")]
        public string Guid { get; }
        public System.Type GutterMarkType { get; set; }
        public JetBrains.TextControl.DocumentMarkup.PaletteColorIndex HighContrastBackground { get; set; }
        public JetBrains.TextControl.DocumentMarkup.HighContrastMode HighContrastBackgroundMode { get; set; }
        public bool HighContrastBackgroundSet { get; }
        public JetBrains.TextControl.DocumentMarkup.PaletteColorIndex HighContrastForeground { get; set; }
        public JetBrains.TextControl.DocumentMarkup.HighContrastMode HighContrastForegroundMode { get; set; }
        public bool HighContrastForegroundSet { get; }
        public string Id { get; }
        public int Layer { get; set; }
        public string PresentableName { get; set; }
        public string ThemeEntryName { get; set; }
        public int VSPriority { get; set; }
        public static System.Drawing.Color ColorOfString(string color) { }
        public static System.Drawing.Color ColorOfString(string color, System.Drawing.Color ifNull) { }
        public static JetBrains.TextControl.DocumentMarkup.IGutterMark CreateGutterMark(JetBrains.DataFlow.Lifetime lifetime, string id, System.Type gutterMarkType, JetBrains.Application.Components.IComponentContainer containerForFactoring) { }
    }
    public class StandaloneMarkupModel : JetBrains.TextControl.DocumentMarkup.DocumentMarkupBase
    {
        public StandaloneMarkupModel(JetBrains.DocumentModel.IDocument document, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry, JetBrains.TextControl.DocumentMarkup.HihglighterContext context) { }
        protected override JetBrains.TextControl.DocumentMarkup.IHighlighter CreateHighlighter(JetBrains.Util.TextRange range, JetBrains.Util.Key key, int layer, JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.AreaType areaType, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip) { }
        protected override JetBrains.TextControl.DocumentMarkup.IHighlighter CreateHighlighter(JetBrains.Util.TextRange range, int layer, JetBrains.Util.Key key, JetBrains.TextControl.DocumentMarkup.AreaType areaType, string attributeId, JetBrains.TextControl.DocumentMarkup.ErrorStripeAttributes errorStripeAttributes, JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider tooltip, JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo glyphMarginInfo, JetBrains.TextControl.DocumentMarkup.HihglighterContext context) { }
    }
    public class StringHighlighterTooltip : JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider
    {
        public StringHighlighterTooltip(string s) { }
        public JetBrains.UI.RichText.RichTextBlock GetRichTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public string GetTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public string GetTooltipForErrorStripe(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
    }
    public class static VSPriority
    {
        public const int DEADCODE = 60;
        public const int ERRORS = 850;
        public const int IDENTIFIERS = 40;
        public const int USAGES = 10001;
    }
}
namespace JetBrains.TextControl.EditBoxTextControl
{
    
    public class CreateEditBoxTextControlParams : JetBrains.TextControl.CreateTextControlParams<JetBrains.TextControl.EditBoxTextControl.EditBoxTextControl>
    {
        public CreateEditBoxTextControlParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, JetBrains.UI.WindowManagement.WindowFrame frame) { }
    }
    public class EditBoxTextControl : JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.TextControl.IWinFormTextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.ErrorStripeIndicatorState> ErrorStripeIndicatorState;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.TextControlScheme> Scheme;
        public JetBrains.DocumentModel.IDocument Document { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Windows.Forms.RichTextBox EditBox { get; }
        public bool IsDisposed { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> BeforeDispose;
        public bool IsPositionInTextView(JetBrains.TextControl.Coords.ITextControlPos position) { }
        public void SyncToViewGuarded() { }
        public void SyncToViewUnguarded() { }
    }
    public class EditBoxTextControlCoordinateConversion : JetBrains.TextControl.Coords.TextControlCoordinateConversionCore
    {
        public EditBoxTextControlCoordinateConversion([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.EditBoxTextControl.EditBoxTextControl textcontrol) { }
        public override JetBrains.TextControl.TextControlLineColumn Canvas_To_TextControlLineColumn(JetBrains.TextControl.Graphics.PointEx ptCanvas) { }
        public override JetBrains.TextControl.TextControlLineColumn DocLineColumn_To_TextControlLineColumn(JetBrains.DocumentModel.DocumentCoords doccoords) { }
        public override JetBrains.TextControl.TextControlLineColumn DocOffset_To_TextControlLineColumn(JetBrains.TextControl.DocOffsetAndVirtual docoffset) { }
        public override JetBrains.TextControl.TextControlLineColumn Screen_To_TextControlLineColumn(System.Drawing.Point ptScreen) { }
        protected override System.Drawing.Point Screen_To_Viewport(System.Drawing.Point ptScreen) { }
        public override JetBrains.TextControl.Graphics.Rect TextControlLineColumn_To_Canvas(JetBrains.TextControl.TextControlLineColumn posTxt) { }
        public override JetBrains.DocumentModel.DocumentCoords TextControlLineColumn_To_DocLineColumn(JetBrains.TextControl.TextControlLineColumn posTxt) { }
        public override JetBrains.TextControl.DocOffsetAndVirtual TextControlLineColumn_To_DocOffset(JetBrains.TextControl.TextControlLineColumn posTxt) { }
        public override System.Drawing.Rectangle TextControlLineColumn_To_Screen(JetBrains.TextControl.TextControlLineColumn posText) { }
        protected override System.Drawing.Point Viewport_To_Screen(System.Drawing.Point ptViewport) { }
    }
}
namespace JetBrains.TextControl.ErrorStripe
{
    
    public abstract class ErrorStripeControlBase : JetBrains.TextControl.ErrorStripe.IErrorStripeControl, System.IDisposable
    {
        public JetBrains.DataFlow.ISimpleSignal IndicatorClicked { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> IndicatorIconId { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<object, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> IndicatorTooltipInquiry { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker> MarkerClicked { get; }
        public JetBrains.DataFlow.ISignal<System.Nullable<double>> MarkersBarClicked { get; }
        public JetBrains.DataFlow.IProperty<int> MarkerSlotCount { get; }
        public JetBrains.DataFlow.IProperty<System.Collections.Generic.IList<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker>> MarkersToShow { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> MarkerTooltipInquiry { get; }
        public JetBrains.DataFlow.IProperty<bool> ShouldBeVisible { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.Util.Pair<double, double>> ViewportRange { get; }
        public abstract void Dispose();
        public abstract void InvalidateErrorStripe();
    }
    public class static ErrorStripeControlEx
    {
        public static JetBrains.TextControl.ErrorStripe.IErrorStripeControl BindToDocument([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ErrorStripe.IErrorStripeControl control, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ErrorStripe.IErrorStripeDocument document) { }
    }
    public abstract class ErrorStripeDocumentBase : JetBrains.TextControl.ErrorStripe.IErrorStripeDocument
    {
        protected readonly JetBrains.Util.Lazy.Lazy<System.Collections.Generic.List<JetBrains.TextControl.DocumentMarkup.IHighlighter>> MyHighlightersToShow;
        protected ErrorStripeDocumentBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks shellLocks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization highlighterCustomization, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.DataFlow.IProperty<System.Collections.Generic.IList<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker>> DocumentMarkers { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> IndicatorIconId { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.TextControl.ErrorStripeIndicatorState> IndicatorState { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.OutEventArgs<int>> MarkerSlotCountInquiry { get; }
        public JetBrains.DataFlow.ISimpleSignal OnIndicatorClicked { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<object, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> OnIndicatorTooltipRequested { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker> OnMarkerClicked { get; }
        public JetBrains.DataFlow.ISignal<System.Nullable<double>> OnMarkersBarClicked { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> OnMarkerTooltipRequested { get; }
        public JetBrains.DataFlow.IProperty<bool> ShouldBeVisible { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public JetBrains.TextControl.ITextControlCaret TextControlCaret { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.Util.Pair<double, double>> ViewportRange { get; }
        protected double CalculateY(JetBrains.TextControl.Data.IRangeable highlighter) { }
        protected double CalculateY(JetBrains.TextControl.Coords.ITextControlPos pos) { }
        protected virtual JetBrains.TextControl.ErrorStripe.ErrorStripeDocumentBase.HighlighterPositionCache CreateHighlighterPositionCacheInstance() { }
        protected virtual bool EnsureCaretMovement() { }
        protected virtual JetBrains.UI.Icons.IconId GetIndicatorIcon(JetBrains.TextControl.ErrorStripeIndicatorState state) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected string GetIndicatorStateText() { }
        protected virtual JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip GetIndicatorTooltip() { }
        protected JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> GetTextControlLineCount() { }
        public void InvalidateDocument() { }
        protected virtual System.Collections.Generic.List<JetBrains.TextControl.DocumentMarkup.IHighlighter> ObtainAllHighlighters() { }
        protected class HighlighterPositionCache
        {
            protected readonly JetBrains.TextControl.Coords.ITextControlCoords Coords;
            public HighlighterPositionCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.ITextControlCoords coords, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine>> funcLineCount, System.Func<JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine>> funcVirtualLineCount = null) { }
            public int LineCount { get; }
            public int VirtualLineCount { get; }
            public void Freeze() { }
            public double GetPositionRatio(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> docline) { }
            protected virtual double GetPositionRatioImplementation(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> docline) { }
            public virtual JetBrains.TextControl.Coords.ITextControlPos GetTextControlPos(double docRatio) { }
        }
    }
    public class static ErrorStripeDocumentEx
    {
        public static JetBrains.TextControl.ErrorStripe.IErrorStripeDocument BindToTextControl([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ErrorStripe.IErrorStripeDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ErrorStripeEditorStyle
    {
        public static readonly System.Collections.Generic.IDictionary<System.Windows.Forms.AnchorStyles, string> ValidAnchors;
        public ErrorStripeEditorStyle(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Theming.ITheming theming) { }
    }
    public struct ErrorStripeMarker
    {
        public JetBrains.UI.Components.Theming.EitherColor Color;
        public readonly object MarkerId;
        public readonly double Position;
        public JetBrains.UI.Components.Theming.EitherColor SecondColor;
        public ErrorStripeMarker(object id, double pos, JetBrains.UI.Components.Theming.EitherColor color, JetBrains.UI.Components.Theming.EitherColor secondColor) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Error stripe settings")]
    public class ErrorStripeSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.None, "Error stripe position")]
        public System.Windows.Forms.AnchorStyles ErrorStripeAnchoring;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Show highlighters viewport range")]
        public bool RenderHighlightersViewportRange;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class ErrorStripeSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public ErrorStripeSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class ErrorStripeStyle
    {
        public ErrorStripeStyle([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ErrorStripe.ErrorStripeStyle.Brusher funcBackgroundBrusher, System.Windows.Forms.AnchorStyles location = 8) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.ErrorStripe.ErrorStripeStyle.Brusher BackgroundBrusher { get; }
        public System.Windows.Forms.AnchorStyles Location { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.ErrorStripe.ErrorStripeStyle CreateClassic() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public delegate System.Drawing.Brush Brusher();
    }
    public struct ErrorStripeTooltip
    {
        public readonly JetBrains.UI.Icons.IconId IconId;
        public readonly object RichContent;
        public readonly string TextContent;
        public ErrorStripeTooltip(string text, object rich, JetBrains.UI.Icons.IconId icon) { }
    }
    public class ErrorStripeTooltipEventArgs
    {
        public readonly System.Drawing.Point ClientPoint;
        public ErrorStripeTooltipEventArgs(System.Drawing.Point ptClient) { }
        public bool HasTooltip { get; }
        public System.Drawing.Rectangle ToolArea { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TooltipPlainTextContent { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object TooltipRichContent { get; }
        public void SetTooltip([JetBrains.Annotations.NotNullAttribute()] string plaintext, [JetBrains.Annotations.CanBeNullAttribute()] object richcontent, System.Drawing.Rectangle toolarea) { }
    }
    public interface IErrorStripeControl : System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISimpleSignal IndicatorClicked { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> IndicatorIconId { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<object, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> IndicatorTooltipInquiry { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker> MarkerClicked { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<System.Nullable<double>> MarkersBarClicked { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<int> MarkerSlotCount { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<System.Collections.Generic.IList<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker>> MarkersToShow { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> MarkerTooltipInquiry { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> ShouldBeVisible { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.Util.Pair<double, double>> ViewportRange { get; }
        void InvalidateErrorStripe();
    }
    public interface IErrorStripeDocument
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<System.Collections.Generic.IList<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker>> DocumentMarkers { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> IndicatorIconId { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.TextControl.ErrorStripeIndicatorState> IndicatorState { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.OutEventArgs<int>> MarkerSlotCountInquiry { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISimpleSignal OnIndicatorClicked { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<object, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> OnIndicatorTooltipRequested { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker> OnMarkerClicked { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<System.Nullable<double>> OnMarkersBarClicked { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.TextControl.ErrorStripe.ErrorStripeMarker, JetBrains.TextControl.ErrorStripe.ErrorStripeTooltip>> OnMarkerTooltipRequested { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> ShouldBeVisible { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.Util.Pair<double, double>> ViewportRange { get; }
    }
    public interface IErrorStripeStyleService
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ErrorStripe.ErrorStripeStyle Style { get; set; }
    }
    public class SErrorStripeStyleService : JetBrains.TextControl.ErrorStripe.IErrorStripeStyleService
    {
        public JetBrains.TextControl.ErrorStripe.ErrorStripeStyle Style { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TextControl.ErrorStripe.IErrorStripeStyleService GetInstance() { }
    }
}
namespace JetBrains.TextControl.Graphics
{
    
    public struct CharacterBox
    {
        public JetBrains.TextControl.Graphics.Height myAscent;
        public JetBrains.TextControl.Graphics.Height myDescent;
        public JetBrains.TextControl.Graphics.Width myWidth;
        public CharacterBox(JetBrains.TextControl.Graphics.Height ascent, JetBrains.TextControl.Graphics.Height descent, JetBrains.TextControl.Graphics.Width width) { }
        public JetBrains.TextControl.Graphics.Height Ascent { get; }
        public JetBrains.TextControl.Graphics.Height Descent { get; }
        public JetBrains.TextControl.Graphics.Width Width { get; }
    }
    public class DrawingEditorFont : JetBrains.TextControl.Graphics.IEditorFont, System.IDisposable
    {
        public DrawingEditorFont(System.Drawing.Graphics graphics, JetBrains.TextControl.FontAttributes attributes) { }
        public System.Drawing.Font Font { get; }
        public System.IntPtr Hfont { get; set; }
        public void Dispose() { }
        public JetBrains.TextControl.Graphics.Height GetAscent() { }
        public JetBrains.TextControl.Graphics.Size GetCharacterSize(char c) { }
        public JetBrains.TextControl.Graphics.Width GetCharacterWidth(char c) { }
        public JetBrains.TextControl.Graphics.Height GetDescent() { }
    }
    public class DrawingEditorGraphics : JetBrains.TextControl.Graphics.IEditorGraphics, System.IDisposable
    {
        public DrawingEditorGraphics(System.Drawing.Graphics graphics, System.Drawing.Color backColor) { }
        public System.Drawing.Color BackColor { get; }
        public JetBrains.TextControl.Graphics.IEditorPainter CreatePainter(System.Drawing.Graphics graphics, JetBrains.TextControl.Graphics.PointEx scrollingOffset) { }
        public void Dispose() { }
        public JetBrains.TextControl.Graphics.IEditorBrush GetBrush(System.Drawing.Color color) { }
        public JetBrains.TextControl.Graphics.IEditorFont GetEditorFont(JetBrains.TextControl.FontAttributes font) { }
        public JetBrains.TextControl.Graphics.IEditorPen GetPen(System.Drawing.Color color) { }
    }
    public enum EditorBrushType
    {
        FOREGROUND = 0,
        BACKGROUND = 1,
    }
    public sealed class FontAttributesHashTable
    {
        public FontAttributesHashTable() { }
        public FontAttributesHashTable(int initialSize) { }
        public int Count { get; }
        public object this[JetBrains.TextControl.FontAttributes key] { get; set; }
        public void Clear() { }
        public void DisposeValues() { }
    }
    public abstract class GraphicArtefact
    {
        public GraphicArtefact(JetBrains.TextControl.Graphics.Rect location) { }
        public JetBrains.TextControl.Graphics.Rect Location { get; }
        public int Timestamp { get; set; }
        public override bool Equals(object obj) { }
        public virtual bool EqualsOverPoint(JetBrains.TextControl.Graphics.GraphicArtefact artefact) { }
        public override int GetHashCode() { }
        public override string ToString() { }
        public void Write(System.IO.TextWriter writer) { }
        protected abstract void WriteImpl(System.IO.TextWriter writer);
    }
    public struct Height
    {
        public static readonly JetBrains.TextControl.Graphics.Height ZERO;
        public Height(float height) { }
        public float Value { get; }
        public bool Equals(JetBrains.TextControl.Graphics.Height x) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.TextControl.Graphics.Height Max(JetBrains.TextControl.Graphics.Height left, JetBrains.TextControl.Graphics.Height right) { }
        public override string ToString() { }
    }
    public interface IEditorBrush { }
    public interface IEditorFont
    {
        JetBrains.TextControl.Graphics.Height GetAscent();
        JetBrains.TextControl.Graphics.Size GetCharacterSize(char c);
        JetBrains.TextControl.Graphics.Width GetCharacterWidth(char c);
        JetBrains.TextControl.Graphics.Height GetDescent();
    }
    public interface IEditorGraphics : System.IDisposable
    {
        JetBrains.TextControl.Graphics.IEditorPainter CreatePainter(System.Drawing.Graphics graphics, JetBrains.TextControl.Graphics.PointEx scrollingOffset);
        JetBrains.TextControl.Graphics.IEditorBrush GetBrush(System.Drawing.Color color);
        JetBrains.TextControl.Graphics.IEditorFont GetEditorFont(JetBrains.TextControl.FontAttributes faceName);
        JetBrains.TextControl.Graphics.IEditorPen GetPen(System.Drawing.Color color);
    }
    public interface IEditorGraphicsProvider
    {
        JetBrains.TextControl.Graphics.IEditorGraphics CreateEditorGraphics(System.Windows.Forms.Control control, System.Drawing.Color backColor);
    }
    public interface IEditorPainter : System.IDisposable
    {
        JetBrains.TextControl.Graphics.IEditorGraphics Graphics { get; }
        void FillRect(JetBrains.TextControl.Graphics.Rect rect, JetBrains.TextControl.Graphics.IEditorBrush brush);
        void PutChar(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y, JetBrains.TextControl.Graphics.IEditorFont font, JetBrains.TextControl.Graphics.IEditorBrush brush, char c);
        void PutChars(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y, JetBrains.TextControl.Graphics.IEditorFont font, JetBrains.TextControl.Graphics.IEditorBrush brush, char[] buffer, int startOffset, int endOffset);
        void PutLine(JetBrains.TextControl.Graphics.Y baseline, JetBrains.TextControl.Graphics.X left, JetBrains.TextControl.Graphics.X right, JetBrains.TextControl.DocumentMarkup.EffectType effectType, JetBrains.TextControl.Graphics.IEditorPen brush);
        void PutRect(JetBrains.TextControl.Graphics.Rect rect, JetBrains.TextControl.Graphics.IEditorPen pen);
    }
    public interface IEditorPen { }
    public struct PointEx
    {
        public static readonly JetBrains.TextControl.Graphics.PointEx ORIGIN;
        public PointEx(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y) { }
        public PointEx(System.Drawing.PointF p) { }
        public JetBrains.TextControl.Graphics.X X { get; }
        public JetBrains.TextControl.Graphics.Y Y { get; }
        public bool Equals(JetBrains.TextControl.Graphics.PointEx point) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public System.Drawing.PointF ToPointF() { }
        public override string ToString() { }
    }
    public struct Rect
    {
        public static readonly JetBrains.TextControl.Graphics.Rect EMPTY;
        public Rect(JetBrains.TextControl.Graphics.X left, JetBrains.TextControl.Graphics.Y top, JetBrains.TextControl.Graphics.Width width, JetBrains.TextControl.Graphics.Height height) { }
        public Rect(System.Drawing.RectangleF rectangleF) { }
        public Rect(JetBrains.TextControl.Graphics.PointEx position, JetBrains.TextControl.Graphics.Size size) { }
        public JetBrains.TextControl.Graphics.Y Bottom { get; }
        public JetBrains.TextControl.Graphics.Height Height { get; }
        public JetBrains.TextControl.Graphics.X Left { get; }
        public JetBrains.TextControl.Graphics.PointEx Location { get; }
        public JetBrains.TextControl.Graphics.X Right { get; }
        public JetBrains.TextControl.Graphics.Size Size { get; }
        public JetBrains.TextControl.Graphics.Y Top { get; }
        public JetBrains.TextControl.Graphics.Width Width { get; }
        public bool Contains(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y) { }
        public bool Contains(JetBrains.TextControl.Graphics.PointEx p) { }
        public bool Equals(JetBrains.TextControl.Graphics.Rect rect) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IntersectsWith(JetBrains.TextControl.Graphics.Rect other) { }
        public JetBrains.TextControl.Graphics.Rect Offset(float deltaX, float deltaY) { }
        public System.Drawing.RectangleF ToRectangleF() { }
        public override string ToString() { }
    }
    public struct Size
    {
        public static readonly JetBrains.TextControl.Graphics.Size EMPTY;
        public Size(JetBrains.TextControl.Graphics.Width width, JetBrains.TextControl.Graphics.Height height) { }
        public Size(System.Drawing.SizeF sizeF) { }
        public JetBrains.TextControl.Graphics.Height Height { get; }
        public JetBrains.TextControl.Graphics.Width Width { get; }
        public bool Equals(JetBrains.TextControl.Graphics.Size size) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class TestEditorGraphics : JetBrains.TextControl.Graphics.IEditorGraphics, System.IDisposable
    {
        public TestEditorGraphics(JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager) { }
        public JetBrains.TextControl.Graphics.IEditorPainter CreatePainter(System.Drawing.Graphics graphics, JetBrains.TextControl.Graphics.PointEx scrollingOffset) { }
        public void Dispose() { }
        public JetBrains.TextControl.Graphics.IEditorBrush GetBrush(System.Drawing.Color color) { }
        public JetBrains.TextControl.Graphics.IEditorFont GetEditorFont(JetBrains.TextControl.FontAttributes faceName) { }
        public JetBrains.TextControl.Graphics.IEditorPen GetPen(System.Drawing.Color color) { }
        public JetBrains.TextControl.Graphics.TestPainter ReadPainter(System.IO.TextReader stream) { }
    }
    public class TestPainter : JetBrains.TextControl.Graphics.IEditorPainter, System.IDisposable
    {
        public TestPainter(JetBrains.TextControl.Graphics.TestEditorGraphics editorGraphics) { }
        public TestPainter(System.IO.TextReader stream, JetBrains.TextControl.Graphics.TestEditorGraphics graphics) { }
        public JetBrains.TextControl.Graphics.IEditorGraphics Graphics { get; }
        public void AssertEqual(JetBrains.TextControl.Graphics.TestPainter other, JetBrains.TextControl.Graphics.Rect bounds) { }
        public void Dispose() { }
        public void FillRect(JetBrains.TextControl.Graphics.Rect rect, JetBrains.TextControl.Graphics.IEditorBrush brush) { }
        public JetBrains.TextControl.Graphics.GraphicArtefact[] FindArtefactsOver(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y) { }
        public void PutChar(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y, JetBrains.TextControl.Graphics.IEditorFont font, JetBrains.TextControl.Graphics.IEditorBrush brush, char c) { }
        public void PutChars(JetBrains.TextControl.Graphics.X x, JetBrains.TextControl.Graphics.Y y, JetBrains.TextControl.Graphics.IEditorFont font, JetBrains.TextControl.Graphics.IEditorBrush brush, char[] buffer, int startOffset, int endOffset) { }
        public void PutLine(JetBrains.TextControl.Graphics.Y baseline, JetBrains.TextControl.Graphics.X left, JetBrains.TextControl.Graphics.X right, JetBrains.TextControl.DocumentMarkup.EffectType effectType, JetBrains.TextControl.Graphics.IEditorPen brush) { }
        public void PutRect(JetBrains.TextControl.Graphics.Rect rect, JetBrains.TextControl.Graphics.IEditorPen pen) { }
        public static int ReadInt(System.IO.TextReader stream) { }
        public static string ReadWord(System.IO.TextReader stream) { }
        public static void SkipWhitespace(System.IO.TextReader stream) { }
        public override string ToString() { }
        public void Write(System.IO.TextWriter writer) { }
    }
    public class static TextControlUtil
    {
        public static JetBrains.TextControl.Graphics.Size ObtainCharacterSize(System.Drawing.Font f, System.Drawing.Graphics g, char c) { }
    }
    public struct Width
    {
        public static readonly JetBrains.TextControl.Graphics.Width ZERO;
        public Width(float width) { }
        public float Value { get; }
        public bool Equals(JetBrains.TextControl.Graphics.Width x) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.TextControl.Graphics.Width Max(JetBrains.TextControl.Graphics.Width left, JetBrains.TextControl.Graphics.Width right) { }
        public override string ToString() { }
    }
    public struct X : System.IComparable
    {
        public static readonly JetBrains.TextControl.Graphics.X Zero;
        public X(float x) { }
        public float Value { get; }
        public int CompareTo(object obj) { }
        public bool Equals(JetBrains.TextControl.Graphics.X x) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.TextControl.Graphics.X Max(JetBrains.TextControl.Graphics.X left, JetBrains.TextControl.Graphics.X right) { }
        public static JetBrains.TextControl.Graphics.X Min(JetBrains.TextControl.Graphics.X left, JetBrains.TextControl.Graphics.X right) { }
        public override string ToString() { }
    }
    public struct Y : System.IComparable
    {
        public static readonly JetBrains.TextControl.Graphics.Y Zero;
        public Y(float y) { }
        public float Value { get; }
        public int CompareTo(object obj) { }
        public bool Equals(JetBrains.TextControl.Graphics.Y x) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.TextControl.Graphics.Y Max(JetBrains.TextControl.Graphics.Y left, JetBrains.TextControl.Graphics.Y right) { }
        public static JetBrains.TextControl.Graphics.Y Min(JetBrains.TextControl.Graphics.Y left, JetBrains.TextControl.Graphics.Y right) { }
        public override string ToString() { }
    }
}
namespace JetBrains.TextControl.GutterMargin
{
    
    public enum ContextActionsIndication
    {
        BulbIndicator = 0,
        GutterMark = 1,
        NoIndication = 2,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GutterMarginImpl : JetBrains.TextControl.GutterMargin.IGutterMargin
    {
        public GutterMarginImpl(JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore) { }
        public JetBrains.Application.Settings.Store.Implementation.SettingsStore SettingsStore { get; }
        public virtual JetBrains.UI.IAnchoringRect GetAnchorForLine(JetBrains.TextControl.ITextControl textControl, JetBrains.DocumentModel.DocumentCoords line, JetBrains.DataFlow.Lifetime lifetime) { }
        public virtual bool IsApplicable() { }
        public virtual bool IsEnabled(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "ReSharper Gutter Margin settings")]
    public class GutterMarginSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.TextControl.GutterMargin.ContextActionsIndication.GutterMark, "Context Actions Indication")]
        public JetBrains.TextControl.GutterMargin.ContextActionsIndication ContextActionsIndication;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use Gutter Margin")]
        public bool UseGutterMargin;
    }
    public interface IGutterMargin
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.IAnchoringRect GetAnchorForLine([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.DocumentModel.DocumentCoords line, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
        bool IsApplicable();
        bool IsEnabled([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
    }
}
namespace JetBrains.TextControl.Impl
{
    
    public class CanvasControl : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.Application.DataContext.IDataRuleProvider, JetBrains.TextControl.Impl.IDocumentModelChangeListener
    {
        public JetBrains.TextControl.Actions.TextControlActions Actions { get; }
        public JetBrains.TextControl.Graphics.IEditorGraphics EditorGraphics { get; }
        public JetBrains.TextControl.ITextControlScrolling ScrollingModel { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.Impl.TextControlImpl TextControl { get; }
        public void ApplySchemeColors(JetBrains.TextControl.TextControlScheme scheme) { }
        public void BeforeDocumentChange(JetBrains.DocumentModel.DocumentChange args) { }
        protected override void Dispose(bool disposing) { }
        public JetBrains.TextControl.Graphics.Rect GetCaretRect() { }
        public void Init() { }
        public void OnDocumentChange(JetBrains.DocumentModel.DocumentChange change, JetBrains.TextControl.Impl.RowModelChangeInfo args) { }
        protected override void OnGotFocus(System.EventArgs e) { }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e) { }
        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
        protected override void OnLostFocus(System.EventArgs e) { }
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnMouseWheel(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        public void PaintImpl(JetBrains.TextControl.Graphics.Rect bounds, JetBrains.TextControl.Graphics.IEditorPainter painter) { }
        protected override bool ProcessDialogChar(char charCode) { }
        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData) { }
        protected void Type(char charCode) { }
        public void UpdateCanvas(JetBrains.TextControl.Impl.CanvasUpdateArgs args) { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public struct CanvasUpdateArgs
    {
        public int firstRowChangedOnCanvas;
        public int firstRowUnchagedOnCanvas;
        public JetBrains.TextControl.Graphics.Rect invalidRect;
        public JetBrains.Util.TextRange textRange;
    }
    public class CharacterSizeCalculator : JetBrains.TextControl.Impl.ICharacterSizeCalculator
    {
        public CharacterSizeCalculator(JetBrains.TextControl.Graphics.IEditorGraphics graphics) { }
        public void CalculateCharacterSize(char c, JetBrains.TextControl.TextAttributes attributes, out JetBrains.TextControl.Graphics.CharacterBox box) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultTextControlSchemeManagerImpl : JetBrains.TextControl.DefaultTextControlSchemeManager
    {
        public DefaultTextControlSchemeManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.CommonControls.Fonts.FontsManager fontsman, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public override System.Drawing.Color CodeEditorBackground { get; }
        public override System.Drawing.Color CodeEditorForeground { get; }
        public override System.Drawing.Color CommentColor { get; }
        public override System.Drawing.Color KeywordColor { get; }
        public override System.Drawing.Color MethodColor { get; }
        public override System.Drawing.Color ParameterColor { get; }
        public override System.Drawing.Color PreprocessorKeywordColor { get; }
        public override System.Drawing.Color ReadonlyBackground { get; }
        public override System.Drawing.Color StringColor { get; }
        public override System.Drawing.Color TypeColor { get; }
        public override JetBrains.TextControl.TextControlScheme GetScheme() { }
        public override void SetScheme(JetBrains.TextControl.TextControlScheme scheme) { }
    }
    public interface ICharacterSizeCalculator
    {
        void CalculateCharacterSize(char c, JetBrains.TextControl.TextAttributes attributes, out JetBrains.TextControl.Graphics.CharacterBox box);
    }
    public interface IDocumentModelChangeListener
    {
        void BeforeDocumentChange(JetBrains.DocumentModel.DocumentChange args);
        void OnDocumentChange(JetBrains.DocumentModel.DocumentChange change, JetBrains.TextControl.Impl.RowModelChangeInfo args);
    }
    public interface ITextControlDocumentModel : System.IDisposable
    {
        JetBrains.TextControl.ITextControlCanvas Canvas { get; }
        JetBrains.DocumentModel.IDocument Document { get; }
        bool IsVirtualSpace { get; }
        JetBrains.TextControl.Impl.TextControlMarkup Markup { get; }
        JetBrains.TextControl.IRowModel RowModel { get; }
        void AddDocumentModelChangeListener(JetBrains.TextControl.Impl.IDocumentModelChangeListener listener);
        JetBrains.TextControl.IRow GetRow(int index);
        int GetRowCount();
    }
    public class RowModelChangeInfo
    {
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> myFirstAddedRow;
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> myLastAddedRow;
        public RowModelChangeInfo(JetBrains.DocumentModel.DocumentChange change) { }
        public RowModelChangeInfo(JetBrains.Util.TextRange range) { }
        public int OldLength { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public void ExtendRange(JetBrains.Util.TextRange range) { }
    }
    public sealed class TextControlChange : JetBrains.TextControl.ITextControlChange
    {
        public TextControlChange(JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.TextControl.CaretMovedEventArgs CaretChange { get; set; }
        public JetBrains.TextControl.ISelectionChange SelectionChange { get; set; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public JetBrains.TextControl.IVisibleAreaChange VisibleAreaChange { get; set; }
        public void FireIfNotEmpty(JetBrains.Application.ChangeManager changeManager) { }
        public override string ToString() { }
    }
    public class TextControlDocumentModelImpl : JetBrains.TextControl.Impl.ITextControlDocumentModel, System.IDisposable
    {
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.TextControl.Graphics.IEditorGraphics EditorGraphics { get; }
        public bool IsVirtualSpace { get; }
        public JetBrains.TextControl.Impl.TextControlMarkup Markup { get; }
        public JetBrains.TextControl.DocumentMarkup.IDocumentMarkup MarkupModel { get; }
        public JetBrains.TextControl.IRowModel RowModel { get; }
        public void AddDocumentModelChangeListener(JetBrains.TextControl.Impl.IDocumentModelChangeListener listener) { }
        public void DispatchPendingEvents() { }
        public void Dispose() { }
        public JetBrains.TextControl.IRow GetRow(int index) { }
        public int GetRowCount() { }
    }
    public class TextControlImpl : JetBrains.Util.UserDataHolder, JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.TextControl.ITextControl2, JetBrains.TextControl.IWinFormTextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [System.ObsoleteAttribute("Don\'t use the ctor directly, call TextControlManager.CreateTextControl(new Create" +
            "WinFormsTextControl()) instead.")]
        public TextControlImpl(
                    JetBrains.UI.Application.IUIApplication environment, 
                    JetBrains.DocumentModel.IDocument document, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Graphics.IEditorGraphicsProvider graphicsProvider, 
                    JetBrains.TextControl.TextControlScheme scheme, 
                    JetBrains.UI.WindowManagement.WindowFrame frame, 
                    JetBrains.Application.IShellLocks locks, 
                    JetBrains.TextControl.impl.StandaloneTextControlImmanentHighlighters immanentHighlighters, 
                    JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, 
                    JetBrains.TextControl.Actions.Adapters.StandaloneTextControlWin32Adapter standaloneTextControlWin32Adapter, 
                    JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, 
                    JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization highlighterCustomization, 
                    JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, 
                    JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry, 
                    JetBrains.UI.Theming.ITheming theming, 
                    JetBrains.UI.Clipboard clipboard, 
                    JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, 
                    JetBrains.ActionManagement.IActionManager actionManager, 
                    JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, 
                    JetBrains.TextControl.ISyntaxHighlighting syntaxHighlighting = null) { }
        public JetBrains.TextControl.Actions.TextControlActions Actions { get; }
        public JetBrains.TextControl.ITextControlCanvas Canvas { get; }
        public JetBrains.TextControl.ITextControlCaret Caret { get; }
        public System.Drawing.Color CaretColor { get; }
        public bool CaretRow { get; }
        public System.Windows.Forms.Control ContentControl { get; }
        public JetBrains.TextControl.Coords.ITextControlCoords Coords { get; }
        public JetBrains.TextControl.TextAttributes DefaultAttributes { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.TextControl.Impl.ITextControlDocumentModel DocumentModel { get; }
        public JetBrains.TextControl.ErrorStripeIndicatorState ErrorStripeIndicatorState { get; set; }
        public JetBrains.TextControl.Impl.CanvasControl InternalCanvasControl { get; }
        public bool IsDisposed { get; }
        public bool IsViewer { get; set; }
        public bool IsVirtualSpace { get; }
        public JetBrains.TextControl.DocumentMarkup.IDocumentMarkup Markup { get; }
        public JetBrains.TextControl.IRowModel RowModel { get; }
        public JetBrains.TextControl.TextControlScheme Scheme { get; set; }
        public JetBrains.TextControl.ITextControlScrolling Scrolling { get; }
        public JetBrains.TextControl.ITextControlSelection Selection { get; }
        public int TabSize { get; }
        public JetBrains.TextControl.ITextControlWindow Window { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> BeforeDispose;
        public void ApplySchemeColors(JetBrains.TextControl.TextControlScheme scheme) { }
        public JetBrains.TextControl.TextControlLineColumn CanvasToNearestVisual(JetBrains.TextControl.Graphics.PointEx canvasPosition) { }
        public void Dispose() { }
        public void EmulateEnter() { }
        public void EmulateTyping(char c) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void FillVirtualSpaceUntilCaret() { }
        public System.IDisposable GetUpdateCookie(string description) { }
        public bool IsPositionInTextView(JetBrains.TextControl.Coords.ITextControlPos position) { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlManagerDerivativesLegacy
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.Impl.TextControlProperties myTextControlProperties;
        public TextControlManagerDerivativesLegacy([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Impl.TextControlProperties textControlProperties, JetBrains.TextControl.RunningTextControls runningTextControls) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.TextControl.ITextControl FocusedTextControl { get; }
        public event System.EventHandler CaretMoved;
        public event System.EventHandler FocusedTextControlChanged;
        public event System.EventHandler LastFocusedTextControlChanged;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> TextControlCreated;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> TextControlDestroyed;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> TextControlGotFocus;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> TextControlLostFocus;
        public event System.EventHandler VisibleAreaChanged;
        public event System.EventHandler VisibleTextControlsChanged;
    }
    public class TextControlMarkup : JetBrains.TextControl.Impl.IDocumentModelChangeListener, System.IDisposable
    {
        public TextControlMarkup(JetBrains.TextControl.Impl.TextControlDocumentModelImpl model, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.TextControl.DocumentMarkup.HihglighterContext context, JetBrains.TextControl.ISyntaxHighlighting syntaxHighlighting = null) { }
        public void BeforeDocumentChange(JetBrains.DocumentModel.DocumentChange args) { }
        public void Dispose() { }
        public JetBrains.TextControl.Graphics.Width GetCharacterWidth(int offset, char c) { }
        public JetBrains.TextControl.Graphics.Width GetDefaultSpace() { }
        public JetBrains.TextControl.Data.IRangeIterator<JetBrains.TextControl.DocumentMarkup.IHighlighter> GetRangeIterator() { }
        public void OnDocumentChange(JetBrains.DocumentModel.DocumentChange change, JetBrains.TextControl.Impl.RowModelChangeInfo args) { }
        public void SetDefaultForegroundColor(System.Drawing.Color color) { }
        public delegate void HighlighterProcessor(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlProperties
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> CurrentFrameTextControl;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> FocusedTextControl;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> LastFocusedTextControl;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ICollectionEvents<JetBrains.TextControl.ITextControl> VisibleTextControls;
        public TextControlProperties(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.RunningTextControls runningTextControls, JetBrains.Threading.IThreading threading) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlTypingHandlers
    {
        public const string TypingCommandID = "Typing";
        public TextControlTypingHandlers(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
        public void AddTypingHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.TextControl.ITypingContext> FHandler, int priority = 0) { }
        public void Type(JetBrains.TextControl.ITextControl textControl, char c) { }
    }
}
namespace JetBrains.TextControl.impl
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class StandaloneTextControlImmanentHighlighters
    {
        public readonly JetBrains.Util.Key CaretRowHighlighterAttributeKey;
        public readonly string CaretRowHighlighterAttributeKeyName;
        public readonly JetBrains.Util.Key SelectionHighlighterAttributeKey;
        public readonly string SelectionHighlighterAttributeKeyName;
        public StandaloneTextControlImmanentHighlighters(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry) { }
    }
}
namespace JetBrains.TextControl.Src.BaseImpl
{
    
    public sealed class ErrorStripeThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
            "ThemedIcons.ErrorStripe.Generated.Xaml", 4, "ErrorStripeError")]
        public sealed class ErrorStripeError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
            "ThemedIcons.ErrorStripe.Generated.Xaml", 0, "ErrorStripeInvalid")]
        public sealed class ErrorStripeInvalid : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
            "ThemedIcons.ErrorStripe.Generated.Xaml", 5, "ErrorStripeOff")]
        public sealed class ErrorStripeOff : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
            "ThemedIcons.ErrorStripe.Generated.Xaml", 1, "ErrorStripeOK")]
        public sealed class ErrorStripeOK : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
            "ThemedIcons.ErrorStripe.Generated.Xaml", 3, "ErrorStripeRunning")]
        public sealed class ErrorStripeRunning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.TextControl;component/src/BaseImpl/ErrorStripeIcons/" +
            "ThemedIcons.ErrorStripe.Generated.Xaml", 2, "ErrorStripeWarning")]
        public sealed class ErrorStripeWarning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.TextControl.Util
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlChangeUnitFactory
    {
        public System.IDisposable CreateChangeUnit(JetBrains.TextControl.ITextControl textControl, string changeName) { }
        public System.IDisposable CreateChangeUnit(JetBrains.TextControl.ITextControl textControl, string changeName, System.Action finishAction) { }
        public System.IDisposable CreateChangeUnit(JetBrains.TextControl.ITextControl textControl, string changeName, JetBrains.TextControl.Util.TransactionKind kind) { }
        public virtual System.IDisposable CreateChangeUnit(JetBrains.TextControl.ITextControl textControl, string changeName, JetBrains.TextControl.Util.TransactionKind kind, System.Action finishAction) { }
    }
    public class static TextControlUtil
    {
        public static void DeleteSelection([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        public static void SelectLine([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.ITextControl textControl) { }
    }
    public enum TransactionKind
    {
        Default = 0,
        Strict = 1,
        Global = 2,
    }
}
namespace JetBrains.VsIntegration.TextControl
{
    
    public interface IVisualPositionRangesHash
    {
        System.Collections.Generic.IList<JetBrains.DocumentModel.DocLineColumnRange> SortedRanges { get; }
        System.Nullable<JetBrains.DocumentModel.DocLineColumnRange> FindContainingRange(JetBrains.DocumentModel.DocumentCoords pos);
        System.Nullable<JetBrains.DocumentModel.DocLineColumnRange> FindContainingRangeByLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line);
        void VisitAllColapserRegions(System.Action<JetBrains.DocumentModel.DocLineColumnRange> @delegate);
        void VisitColapsedRegionsBefore(JetBrains.DocumentModel.DocumentCoords pos, System.Action<JetBrains.DocumentModel.DocLineColumnRange> before, System.Action<JetBrains.DocumentModel.DocLineColumnRange> contining);
    }
    public struct TextControlLineColumnRange : System.IEquatable<JetBrains.VsIntegration.TextControl.TextControlLineColumnRange>
    {
        public readonly JetBrains.TextControl.TextControlLineColumn End;
        public readonly JetBrains.TextControl.TextControlLineColumn Start;
        public TextControlLineColumnRange(JetBrains.TextControl.TextControlLineColumn startPosition, JetBrains.TextControl.TextControlLineColumn endPosition) { }
        public TextControlLineColumnRange(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> startLine, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> startColumn, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> endLine, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> endColumn) { }
        public TextControlLineColumnRange(JetBrains.TextControl.TextControlLineColumn pos) { }
        public bool Contains(JetBrains.TextControl.TextControlLineColumn pos) { }
        public bool ContainsLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> line) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.TextControl.TextControlLineColumnRange other) { }
        public override int GetHashCode() { }
        public JetBrains.VsIntegration.TextControl.TextControlLineColumnRange ToNormalized() { }
        public override string ToString() { }
    }
    public class VisualPositionRangesHash : JetBrains.VsIntegration.TextControl.IVisualPositionRangesHash
    {
        public VisualPositionRangesHash(System.Collections.Generic.IEnumerable<System.Nullable<JetBrains.DocumentModel.DocLineColumnRange>> positions) { }
        public System.Collections.Generic.IList<JetBrains.DocumentModel.DocLineColumnRange> SortedRanges { get; }
        public System.Nullable<JetBrains.DocumentModel.DocLineColumnRange> FindContainingRange(JetBrains.DocumentModel.DocumentCoords pos) { }
        public System.Nullable<JetBrains.DocumentModel.DocLineColumnRange> FindContainingRangeByLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public void VisitAllColapserRegions(System.Action<JetBrains.DocumentModel.DocLineColumnRange> @delegate) { }
        public void VisitColapsedRegionsBefore(JetBrains.DocumentModel.DocumentCoords pos, System.Action<JetBrains.DocumentModel.DocLineColumnRange> before, System.Action<JetBrains.DocumentModel.DocLineColumnRange> contining) { }
    }
}