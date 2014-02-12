[assembly: JetBrains.Application.Install.InstallFileAttribute("CSS", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "CSS", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "CssDefinitions/*.*")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "CssRuleset2",
        "CssProperty",
        "CssClass",
        "CssPseudoElement",
        "CssAtRule",
        "CssId",
        "CssRuleset",
        "CssPropertyValue",
        "Css",
        "CssFunction"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
    "Css.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-css", "JetBrains.ReSharper.Psi.Css.Resources")]

namespace JetBrains.ReSharper.Psi.Css.BrowserCompatibility
{
    
    public class BrowserCompatibility
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserCompatibility All;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserCompatibility None;
        public BrowserCompatibility([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo> browsers) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo> Browsers { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo> GetUncompatibleBrowsers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserCompatibility masterValue) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserCompatibility Parse(string text, JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinitionsStorage storage) { }
        public override string ToString() { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ProjectModel.Settings.Schema.HierarchySettings), "Browser compatibility solution/project level settings", KeyNameOverride="Browsers")]
    public class BrowserCompatibilitySettings
    {
        public BrowserCompatibilitySettings() { }
        [JetBrains.Application.Settings.SettingsEntryAttribute("C7+,FF4+,IE8+,O11+,S5+", "Browsers")]
        public string Browsers { get; set; }
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable browser compatibility")]
        public bool Enable { get; set; }
    }
    public class BrowserInfo
    {
        public BrowserInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssBrowserDefinition browserDefinition, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersionsRange versionsRange) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssBrowserDefinition BrowserDefinition { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersionsRange VersionsRange { get; }
        public bool CompatibleWith(JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo masterValue) { }
        public override bool Equals(object obj) { }
        protected bool Equals(JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo other) { }
        public override int GetHashCode() { }
        public static JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo Parse(string aliasWithVersion, JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinitionsStorage storage) { }
        public override string ToString() { }
    }
    public class BrowserVersion
    {
        public static readonly JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion Max;
        public BrowserVersion(sbyte major, sbyte minor = 0) { }
        public sbyte Major { get; }
        public sbyte Minor { get; }
        public override bool Equals(object obj) { }
        protected bool Equals(JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion other) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion Parse([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public override string ToString() { }
    }
    public class BrowserVersionsRange
    {
        public BrowserVersionsRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion start, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion end) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersion Start { get; }
        public bool CompatibleWith(JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersionsRange masterRange) { }
        public override bool Equals(object obj) { }
        protected bool Equals(JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersionsRange other) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserVersionsRange Parse(string version) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.CodeStyle
{
    
    public enum ContentFormatStyle
    {
        [System.ComponentModel.DescriptionAttribute("On separate lines if not simple")]
        SEPARATE_LINES_FOR_NONSINGLE = 0,
        [System.ComponentModel.DescriptionAttribute("On separate lines")]
        SEPARATE_LINES = 1,
        [System.ComponentModel.DescriptionAttribute("Single line formating")]
        SAME_LINE = 2,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssCodeFormatter : JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormatterBase, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter, JetBrains.ReSharper.Psi.Css.CodeStyle.ICssCodeFormatter
    {
        public CssCodeFormatter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Css.CssLanguage language, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.Css.CodeStyle.ICssCustomIndentHandler> customIndentHandlers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.CodeStyle.ICssCustomIndentHandler> CustomIndentHandlers { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool CanModifyInsideNodeRange(JetBrains.ReSharper.Psi.Tree.ITreeNode leftElement, JetBrains.ReSharper.Psi.Tree.ITreeNode rightElement, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context) { }
        public override bool CanModifyNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewLine() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace(string indent, JetBrains.ReSharper.Psi.Tree.ITreeNode replacedSpace) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace() { }
        public void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode root, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile profile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore = null) { }
        public override void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode root, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public override JetBrains.ReSharper.Psi.ITreeRange Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile profile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public override void FormatDeletedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Tree.ITreeNode prevNode, JetBrains.ReSharper.Psi.Tree.ITreeNode nextNode) { }
        public override void FormatInsertedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, bool formatSurround) { }
        public override JetBrains.ReSharper.Psi.ITreeRange FormatInsertedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, JetBrains.ReSharper.Psi.ITreeRange origin) { }
        public override void FormatReplacedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode oldNode, JetBrains.ReSharper.Psi.Tree.ITreeNode newNode) { }
        public override JetBrains.ReSharper.Psi.Tree.ITokenNode GetMinimalSeparator(JetBrains.ReSharper.Psi.Tree.ITokenNode leftToken, JetBrains.ReSharper.Psi.Tree.ITokenNode rightToken) { }
        public JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile GetProfile(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        protected override bool IsFormatNextSpaces(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public override bool IsNewLine(JetBrains.ReSharper.Psi.Tree.ITreeNode ws) { }
    }
    public class CssCodeFormattingContext : JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext
    {
        public CssCodeFormattingContext(JetBrains.ReSharper.Psi.Css.CodeStyle.CssCodeFormatter cssCodeFormatter, JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.ReSharper.Psi.Tree.ITreeNode lastNode) { }
    }
    public class CssCodeFormattingSettings
    {
        public readonly JetBrains.ReSharper.Psi.CodeStyle.CommonFormatterSettingsKey CommonSettings;
        public readonly JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings GlobalSettings;
        public readonly JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatterSettingsKey Settings;
        public CssCodeFormattingSettings(JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatterSettingsKey settings, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalSettings, JetBrains.ReSharper.Psi.CodeStyle.CommonFormatterSettingsKey commonSettings) { }
    }
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("CSS")]
    public class CssCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlUpgradable, System.ICloneable
    {
        public CssCodeStyleSettings() { }
        public JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatSettingsObsolete FormatSettings { get; set; }
        public object Clone() { }
        public JetBrains.ReSharper.Psi.Css.Naming.CssNamingStyleSettings GetNamingSettings2() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class CssFormatProfile
    {
        public CssFormatProfile(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public bool DontForceBraces { get; }
        public JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile Profile { get; set; }
    }
    public class CssFormatSettingsObsolete : JetBrains.Util.UserDataHolder, JetBrains.Application.Configuration.IXmlReadable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE)]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle BRACE_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle.SEPARATE_LINES)]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle DECLARATIONS_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(1)]
        public int KEEP_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool KEEP_USER_LINEBREAKS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle.SAME_LINE)]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle MEDIA_QUERY_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(1)]
        public int MIN_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle.SEPARATE_LINES_FOR_NONSINGLE)]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle PROPERTIES_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle.SAME_LINE)]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle SELECTOR_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_FUNCTION_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_MEDIA_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_MEDIA_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_PROPERTY_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_PROPERTY_SEMICOLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_SELECTOR_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_AFTER_SEPARATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_AROUND_ATTRIBUTE_MATCH_OPERATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AROUND_OPERATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AROUND_SELECTOR_OPERATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_FUNCTION_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_MEDIA_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_MEDIA_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_PROPERTY_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_PROPERTY_SEMICOLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_SELECTOR_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_SEPARATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_ATTRIBUTE_MATCH_BRACKETS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_EXPRESSION_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_FUNCTION_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_WITHIN_MEDIA_BLOCK;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_MEDIA_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_WITHIN_PROPERTY_BLOCK;
        public JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatSettingsObsolete Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class static CssFormatterHelper
    {
        public static int BlankLinesToLineFeeds(this int blankLines, bool neeLineFeed = False) { }
        public static bool ContainsLineBreak([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingVisitor CreateFormattingVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData formattingData) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CodeStyle.Indenting.CssIndentVisitor CreateIndentVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData formattingData) { }
        public static JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode CreateNewLine() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode[] CreateNewLines(int count) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode CreateSpace() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode CreateSpace(string spaceText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode[] CreateWhitespaces([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<string> wsTexts) { }
        public static void DoDecorate(JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context, JetBrains.ReSharper.Psi.Css.CodeStyle.CssCodeFormattingSettings settings, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static void DoFormatAndIndent([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingVisitor visitor, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Indenting.CssIndentVisitor indentVisitor, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static void DoIndent([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Indenting.CssIndentVisitor visitor, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static int GetLineFeedsCount([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public static int GetLineFeedsCountTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode fromNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode toNode) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode> GetLineFeedsTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode fromNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode toNode) { }
        public static string GetSampleText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode> GetWhitespacesTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode fromNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode toNode) { }
        public static bool HasLineFeeds([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public static bool HasLineFeedsTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode fromNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode toNode) { }
        public static bool HasNewLineAfter([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool HasNewLineBefore([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool HasWhitespaceBefore([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool IsWhitespace([JetBrains.Annotations.CanBeNullAttribute()] string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode> LeftWhitespaces([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static void MakeIndent([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode indentNode, [JetBrains.Annotations.NotNullAttribute()] string indent) { }
        public static void ReplaceSpaces(JetBrains.ReSharper.Psi.Tree.ITreeNode leftNode, JetBrains.ReSharper.Psi.Tree.ITreeNode rightNode, System.Collections.Generic.IEnumerable<string> wsTexts) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode> RightWhitespaces([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode> SelfAndLeftWhitespaces([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IWhitespaceTokenNode> SelfAndRightWhitespaces([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CodeStyle.CodeFormattingSettingsKey), "Code formatting in CSS")]
    public class CssFormatterSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE, "Braces")]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle BRACE_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle.SEPARATE_LINES, "Declarations")]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle DECLARATIONS_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Max blank lines between declarations")]
        public int KEEP_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Keep existing line breaks")]
        public bool KEEP_USER_LINEBREAKS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle.SAME_LINE, "Media query")]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle MEDIA_QUERY_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Min blank lines between declarations")]
        public int MIN_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle.SEPARATE_LINES_FOR_NONSINGLE, "Properties")]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.ContentFormatStyle PROPERTIES_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle.SAME_LINE, "Selector")]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.SelectorFormatStyle SELECTOR_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After comma")]
        public bool SPACE_AFTER_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After comma")]
        public bool SPACE_AFTER_FUNCTION_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After colon")]
        public bool SPACE_AFTER_MEDIA_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After comma")]
        public bool SPACE_AFTER_MEDIA_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After colon")]
        public bool SPACE_AFTER_PROPERTY_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After semicolon")]
        public bool SPACE_AFTER_PROPERTY_SEMICOLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After comma")]
        public bool SPACE_AFTER_SELECTOR_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "After separator")]
        public bool SPACE_AFTER_SEPARATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Around match operator")]
        public bool SPACE_AROUND_ATTRIBUTE_MATCH_OPERATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Around operator")]
        public bool SPACE_AROUND_OPERATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Around operator")]
        public bool SPACE_AROUND_SELECTOR_OPERATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before comma")]
        public bool SPACE_BEFORE_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before comma")]
        public bool SPACE_BEFORE_FUNCTION_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before colon")]
        public bool SPACE_BEFORE_MEDIA_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before comma")]
        public bool SPACE_BEFORE_MEDIA_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before colon")]
        public bool SPACE_BEFORE_PROPERTY_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before semicolon")]
        public bool SPACE_BEFORE_PROPERTY_SEMICOLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before comma")]
        public bool SPACE_BEFORE_SELECTOR_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before separator")]
        public bool SPACE_BEFORE_SEPARATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within brackets")]
        public bool SPACE_WITHIN_ATTRIBUTE_MATCH_BRACKETS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_EXPRESSION_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_FUNCTION_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Within block")]
        public bool SPACE_WITHIN_MEDIA_BLOCK;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_MEDIA_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Within block")]
        public bool SPACE_WITHIN_PROPERTY_BLOCK;
    }
    public class static CssTextStyle
    {
        public static readonly JetBrains.UI.RichText.TextStyle Keyword;
        public static readonly JetBrains.UI.RichText.TextStyle PropertyName;
        public static readonly JetBrains.UI.RichText.TextStyle PropertyValue;
        public static readonly JetBrains.UI.RichText.TextStyle Selector;
        public static readonly JetBrains.UI.RichText.TextStyle ShortcutText;
        public static readonly JetBrains.UI.RichText.TextStyle String;
        public static readonly JetBrains.UI.RichText.TextStyle Text;
    }
    public interface ICssCodeFormatter : JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.CodeStyle.ICssCustomIndentHandler> CustomIndentHandlers { get; }
        void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode root, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null);
        void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null);
        JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile GetProfile(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile);
    }
    public interface ICssCodeFormatterFactory
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingVisitor CreateFormattingVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData formattingData);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.CodeStyle.Indenting.CssIndentVisitor CreateIndentVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData formattingData);
    }
    public interface ICssCustomIndentHandler
    {
        string Indent(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalSettings, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatterSettingsKey settings);
    }
    public enum SelectorFormatStyle
    {
        [System.ComponentModel.DescriptionAttribute("Single line formating")]
        SAME_LINE = 0,
        [System.ComponentModel.DescriptionAttribute("On separate lines")]
        SEPARATE_LINES = 1,
    }
}
namespace JetBrains.ReSharper.Psi.Css.CodeStyle.FormatSettingsUpgrade
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class CssFormatSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CodeStyleSettingsUpgrade
    {
        public CssFormatSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override void DoUpgrade(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting
{
    
    public class CssFormattingData
    {
        public CssFormattingData(JetBrains.ReSharper.Psi.Css.CodeStyle.CssCodeFormattingContext context, JetBrains.ReSharper.Psi.Css.CodeStyle.CssCodeFormattingSettings settings, JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile profile) { }
        public JetBrains.ReSharper.Psi.Css.CodeStyle.CssCodeFormattingContext Context { get; }
        public JetBrains.ReSharper.Psi.Css.CodeStyle.CssFormatProfile Profile { get; }
        public JetBrains.ReSharper.Psi.Css.CodeStyle.CssCodeFormattingSettings Settings { get; }
    }
    public class CssFormattingStageContext : JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext
    {
        public CssFormattingStageContext(JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingRange range) { }
        public JetBrains.ReSharper.Psi.Css.Impl.Tree.CssChildRole LeftRole { get; }
        public JetBrains.ReSharper.Psi.Css.Impl.Tree.CssChildRole RightRole { get; }
    }
    public class static CssFormattingStageUtil
    {
        public static System.Collections.Generic.IEnumerable<string> GetLBraceSpaces(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle style, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData data) { }
        public static System.Collections.Generic.IEnumerable<string> GetNodesSpace(int minLineFeeds, int maxLineFeeds, int preferedLineFeeds, bool makeSpace, bool keepUserLinebreaks, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData data) { }
        public static System.Collections.Generic.IEnumerable<string> GetRBraceSpaces(int minLineFeeds, int maxLineFeeds, int preferedLineFeeds, bool makeSpace, JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle style, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData data) { }
    }
    public class CssFormattingVisitor : JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext, System.Collections.Generic.IEnumerable<string>>
    {
        public CssFormattingVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData data) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData FormattingData { get; }
        public bool IsGenerated { get; }
        public override System.Collections.Generic.IEnumerable<string> VisitAdjacentSiblingSelector(JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector adjacentSiblingSelectorParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitAtruleset(JetBrains.ReSharper.Psi.Css.Tree.IAtruleset atrulesetParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitAtrulesetBlock(JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock atrulesetBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitAttributeMatch(JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch attributeMatchParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitAttributeSelector(JetBrains.ReSharper.Psi.Css.Tree.IAttributeSelector attributeSelectorParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitChildSelector(JetBrains.ReSharper.Psi.Css.Tree.IChildSelector childSelectorParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssAdditiveExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssAdditiveExpression cssAdditiveExpressionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssArgumentList(JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList cssArgumentListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssFile(JetBrains.ReSharper.Psi.Css.Tree.ICssFile cssFile, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssFileSection(JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection cssFileSectionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssGroupExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssGroupExpression cssGroupExpressionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssInvocationExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression cssInvocationExpressionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssMultiplicativeExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssMultiplicativeExpression cssMultiplicativeExpressionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssPageBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock cssPageBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssProperty(JetBrains.ReSharper.Psi.Css.Tree.ICssProperty cssPropertyParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssPropertyBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock cssPropertyBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssPropertyStatement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement cssPropertyStatementParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCssPropertyValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue cssPropertyValueParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitDescendantSelector(JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector descendantSelectorParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitGeneralSiblingSelector(JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector generalSiblingSelectorParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitKeyframes(JetBrains.ReSharper.Psi.Css.Tree.IKeyframes keyframesParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitKeyframesBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock keyframesBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitKeyframesRule(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule keyframesRuleParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitKeyframesRuleBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock keyframesRuleBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitKeyframesSelectorList(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList keyframesSelectorListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitMedia(JetBrains.ReSharper.Psi.Css.Tree.IMedia mediaParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitMediaBlock(JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock mediaBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitMediaFeature(JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature mediaFeatureParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitMediaQueryList(JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList mediaQueryListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitPage(JetBrains.ReSharper.Psi.Css.Tree.IPage pageParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitPseudoArgumentList(JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList pseudoArgumentListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitPseudoFunctionSelector(JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector pseudoFunctionSelectorParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitRuleset(JetBrains.ReSharper.Psi.Css.Tree.IRuleset rulesetParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitRulesetDeclarationList(JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList rulesetDeclarationListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.CodeStyle.Indenting
{
    
    public class CssIndentVisitor : JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext, string>
    {
        public CssIndentVisitor(JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData formattingData) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ContIndent { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingData FormattingData { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Impl.CodeStyle.IndentCache<JetBrains.ReSharper.Psi.Tree.ITreeNode> IndentCache { get; }
        protected string GetInBlockIndent(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle style, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context, string baseIndent) { }
        protected string GetLBraceIndent(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle style, string baseIndent) { }
        protected string GetRBraceIndent(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle style, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context, string baseIndent) { }
        public override string VisitAtruleset(JetBrains.ReSharper.Psi.Css.Tree.IAtruleset atrulesetParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitAtrulesetBlock(JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock atrulesetBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssArgumentList(JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList cssArgumentListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssFile(JetBrains.ReSharper.Psi.Css.Tree.ICssFile cssFile, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssFileSection(JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection cssFileSectionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssInvocationExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression cssInvocationExpressionParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssPageBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock cssPageBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssProperty(JetBrains.ReSharper.Psi.Css.Tree.ICssProperty cssPropertyParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssPropertyBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock cssPropertyBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitCssPropertyValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue cssPropertyValueParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitKeyframes(JetBrains.ReSharper.Psi.Css.Tree.IKeyframes keyframesParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitKeyframesBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock keyframesBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitKeyframesRule(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule keyframesRuleParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitKeyframesRuleBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock keyframesRuleBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitKeyframesSelectorList(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList keyframesSelectorListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitMedia(JetBrains.ReSharper.Psi.Css.Tree.IMedia mediaParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitMediaBlock(JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock mediaBlockParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitPage(JetBrains.ReSharper.Psi.Css.Tree.IPage pageParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitRuleset(JetBrains.ReSharper.Psi.Css.Tree.IRuleset rulesetParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
        public override string VisitRulesetDeclarationList(JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList rulesetDeclarationListParam, JetBrains.ReSharper.Psi.Css.CodeStyle.Formatting.CssFormattingStageContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css
{
    
    public class static CssBrowserCompatibility
    {
        public static bool IsMediaVendorSpecificExtension(string name) { }
        public static bool IsVendorSpecificExtension(string name) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssConstantValues
    {
        public const string ChUnits = "ch";
        public const string CmUnits = "cm";
        public const string DegUnits = "deg";
        public const string EmUnits = "em";
        public const string ExUnits = "ex";
        public const string GradUnits = "grad";
        public const string HzUnits = "Hz";
        public const string InchUnits = "in";
        public const string KhzUnits = "kHz";
        public const string MmUnits = "mm";
        public const string MsUnits = "ms";
        public const string PcUnits = "pc";
        public const string PercentUnits = "%";
        public const string PtUnits = "pt";
        public const string PxUnits = "px";
        public const string RadUnits = "rad";
        public const string RemUnits = "rem";
        public const string SUnits = "s";
        public const string TurnUnits = "turn";
        public const string VhUnits = "vh";
        public const string VminUnits = "vmin";
        public const string VwUnits = "vw";
        public CssConstantValues() { }
        public System.Drawing.Color CssHslToRgb(double alpha, double h, double s, double l) { }
        public System.Nullable<double> GetExpressionValue(int i, System.Func<JetBrains.Util.Pair<double, string>, System.Nullable<double>> constrained, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression> values) { }
        public System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Colors.IColorElement> GetNamedColors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.CssDefinitions definitions, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion languageVersion) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Nullable<JetBrains.Util.Pair<string, string>> GetNumberAndUnitsText([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression literalExpression) { }
        public bool IsValidCssNamedColor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression expression, JetBrains.ReSharper.Psi.Css.Definitions.CssDefinitions definitions, JetBrains.ReSharper.Psi.Css.CssLanguageVersion languageVersion) { }
        public System.Nullable<double> ValueNoUnits(JetBrains.Util.Pair<double, string> valueAndUnits) { }
        public System.Nullable<double> ValuePercentOnly(JetBrains.Util.Pair<double, string> valueAndUnits, int max) { }
        public System.Nullable<double> ValueWithMax(JetBrains.Util.Pair<double, string> valueAndUnits, double max) { }
    }
    public class static CssConstantValuesExtensions
    {
        public static System.Nullable<double> GetArgumentValue(this JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression cssInvocationExpression, int i, System.Func<JetBrains.Util.Pair<double, string>, System.Nullable<double>> constrained) { }
        public static System.Nullable<JetBrains.Util.Pair<double, string>> GetConstantValueAndUnits([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression propertyValueExpression) { }
        public static JetBrains.DocumentModel.DocumentRange GetUnitsDocumentRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression expression) { }
    }
    public abstract class CssElementFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.ICssFile CreateCssFile(string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract T CreateExpression<T>([JetBrains.Annotations.NotNullAttribute()] string format, params object[] args)
            where T :  class, JetBrains.ReSharper.Psi.Css.Tree.ICssExpression;
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression CreateHsl(System.Drawing.Color color);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression CreateHsla(System.Drawing.Color color);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.IImport CreateImport(string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression CreateRgb(System.Drawing.Color color);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression CreateRgba(System.Drawing.Color color);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression CreateRgbHex(System.Drawing.Color color);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.IRuleset CreateRuleSet(string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList CreateRulesetDeclarationList(string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract T CreateSelector<T>([JetBrains.Annotations.NotNullAttribute()] string format, params object[] args)
            where T :  class, JetBrains.ReSharper.Psi.Css.Tree.ISelector;
        public static JetBrains.ReSharper.Psi.Css.CssElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static JetBrains.ReSharper.Psi.Css.CssElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool applyCodeFormatter = True) { }
    }
    public class CssHierarchyBuilder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssHierarchyTree Process([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFile cssFile, System.Func<bool> isProcessingFinished) { }
    }
    public class CssHierarchyTree
    {
        public CssHierarchyTree() { }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node> Map { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node> Roots { get; }
        public class Node
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node> Items { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.Css.Tree.IMedia Media { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node Parent { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.ReSharper.Psi.Css.Tree.ISelector Selector { get; }
            public JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node Clone(JetBrains.ReSharper.Psi.Css.CssHierarchyTree tree, JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node parent) { }
            public static JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node CreateNode(JetBrains.ReSharper.Psi.Css.CssHierarchyTree tree, JetBrains.ReSharper.Psi.Css.Tree.ISelector selector, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.CssHierarchyTree.Node parent = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMedia media = null) { }
            public override string ToString() { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssInspectionsChangeManager
    {
        public CssInspectionsChangeManager(JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager changeManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("CSS")]
    public class CssLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Css.CssLanguage Instance;
        public const string Name = "CSS";
        protected CssLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected CssLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguageVersion.Converter))]
    public class CssLanguageVersion : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Psi.Css.CssLanguageVersion Css10;
        public static readonly JetBrains.ReSharper.Psi.Css.CssLanguageVersion Css20;
        public static readonly JetBrains.ReSharper.Psi.Css.CssLanguageVersion Css21;
        public static readonly JetBrains.ReSharper.Psi.Css.CssLanguageVersion Css30;
        public static readonly JetBrains.ReSharper.Psi.Css.CssLanguageVersion Default;
        public const string DefaultLanguageVrsionName = "3.0";
        public int Value { get; }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.CssLanguageVersion> EnumerateVersions() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssLanguageVersion Parse(string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssLanguageVersion TryParse(string name) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssLanguageVersionProvider : JetBrains.Application.Settings.Extentions.ICachedSettingsReader<JetBrains.ReSharper.Psi.Css.CssLanguageVersion>
    {
        public CssLanguageVersionProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore store, JetBrains.ProjectModel.Settings.Cache.SettingsCacheManager settingsCacheManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssLanguageVersion GetLanguageLevel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssLanguageVersion GetLanguageLevel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssLanguageVersion GetLanguageLevel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    public class SelectorComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.Css.Tree.ISelector>, System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Psi.Css.Tree.ISelector>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Css.SelectorComparer Instance;
        public int Compare([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector x, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector y) { }
        public bool Equals(JetBrains.ReSharper.Psi.Css.Tree.ISelector x, JetBrains.ReSharper.Psi.Css.Tree.ISelector y) { }
        public int GetHashCode(JetBrains.ReSharper.Psi.Css.Tree.ISelector obj) { }
    }
    public class SelectorSpecificity : System.IEquatable<JetBrains.ReSharper.Psi.Css.SelectorSpecificity>
    {
        public readonly int Value;
        public SelectorSpecificity(byte a, byte b, byte c, byte d) { }
        public bool Equals(JetBrains.ReSharper.Psi.Css.SelectorSpecificity other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static SelectorSpecificityCalculator
    {
        public const string InlineStyle = "resharper-inline-style";
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.SelectorSpecificity Calculate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector selector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.SelectorSpecificity Calculate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector selector, bool inline) { }
        public static bool IsInlineStyle([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector selector) { }
        public static bool IsInlineStyle([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMedia media) { }
    }
    public class SelectorSpecificityComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.Css.SelectorSpecificity>, System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.Css.Tree.ISelector>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Css.SelectorSpecificityComparer Instance;
        public int Compare([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.SelectorSpecificity x, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.SelectorSpecificity y) { }
        public int Compare([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector x, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector y) { }
    }
    public class SimpleSelectorPartComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.Css.Tree.ISelector>, System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Psi.Css.Tree.ISelector>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Css.SimpleSelectorPartComparer Instance;
        public int Compare([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector x, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector y) { }
        public bool Equals(JetBrains.ReSharper.Psi.Css.Tree.ISelector x, JetBrains.ReSharper.Psi.Css.Tree.ISelector y) { }
        public int GetHashCode(JetBrains.ReSharper.Psi.Css.Tree.ISelector obj) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.DeclaredElements
{
    
    public interface ICssColorProfileDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssDefinitionDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition Definition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string XmlDocId { get; }
    }
    public interface ICssFunction : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition Definition { get; }
        bool HaveArguments { get; }
    }
    public interface ICssFunctionDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunction, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssMediaFeatureDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssMediaFeatureDefinition Definition { get; }
    }
    public interface ICssNamedValueDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssNamedValueDefinition Definition { get; }
    }
    public interface ICssPropertyDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssPropertyDefinition Definition { get; }
    }
    public interface ICssPseudoClassDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssPseudoElementDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssPseudoFunctionDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunction, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssSelectorDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface ICssValueFrequencyDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface IKeyframesDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IPageDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IRulesetDeclaredElement : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
}
namespace JetBrains.ReSharper.Psi.Css.Definitions
{
    
    public abstract class CssDefinitions
    {
        public abstract JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinitionsStorage Storage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Definitions.CssDefinitions GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
    }
    public class CssValueDefinitionPrinter : JetBrains.ReSharper.Psi.Css.Definitions.CssValueDefinitionVisitorBase<System.Text.StringBuilder>
    {
        public CssValueDefinitionPrinter() { }
        protected virtual System.Text.StringBuilder Append(System.Text.StringBuilder builder, string value) { }
        protected virtual System.Text.StringBuilder AppendFormat(System.Text.StringBuilder builder, string format, params string[] args) { }
        protected virtual System.Text.StringBuilder CrateContext() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual string Print([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        protected static string PrintQuantity(int minOccur, int maxOccur) { }
        public override void VisitCssValueAngleDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAngleDefinition angleDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueAnyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAnyDefinition anyDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueColorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueColorDefinition colorDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueEmptyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueEmptyDefinition emptyDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueExpressionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueExpressionDefinition expressionDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueFrequencyDefinition(JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssValueFrequencyDefinition frequencyDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueGroupDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueInlineDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueIntegerDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueIntegerDefinition integerDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueInvokeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueJavaScriptDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueJavaScriptDefinition javaScriptDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueLengthDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueLengthDefinition lengthDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueNameDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNameDefinition nameDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueNullDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNullDefinition nullDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueNumberDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNumberDefinition numberDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePercentageDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePercentageDefinition percentageDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePositionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePositionDefinition positionDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePropertyReferenceDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueResolutionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueResolutionDefinition resolutionDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueSelectorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueSelectorDefinition selectorDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueStringDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueStringDefinition stringDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueTextDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTextDefinition textDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueTimeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTimeDefinition timeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueUrangeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUrangeDefinition urangeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueUriDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUriDefinition uriDefinition, System.Text.StringBuilder builder) { }
    }
    public abstract class CssValueDefinitionVisitorBase : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionVisitor
    {
        public virtual void VisitCssValueAngleDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAngleDefinition angleDefinition) { }
        public virtual void VisitCssValueAnyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAnyDefinition anyDefinition) { }
        public virtual void VisitCssValueColorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueColorDefinition colorDefinition) { }
        public virtual void VisitCssValueDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition valueDefinition) { }
        public virtual void VisitCssValueEmptyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueEmptyDefinition emptyDefinition) { }
        public virtual void VisitCssValueExpressionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueExpressionDefinition expressionDefinition) { }
        public virtual void VisitCssValueFrequencyDefinition(JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssValueFrequencyDefinition frequencyDefinition) { }
        public virtual void VisitCssValueGroupDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition) { }
        public virtual void VisitCssValueInlineDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition) { }
        public virtual void VisitCssValueIntegerDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueIntegerDefinition integerDefinition) { }
        public virtual void VisitCssValueInvokeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition) { }
        public virtual void VisitCssValueJavaScriptDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueJavaScriptDefinition javaScriptDefinition) { }
        public virtual void VisitCssValueLengthDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueLengthDefinition lengthDefinition) { }
        public virtual void VisitCssValueNameDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNameDefinition nameDefinition) { }
        public virtual void VisitCssValueNullDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNullDefinition nullDefinition) { }
        public virtual void VisitCssValueNumberDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNumberDefinition numberDefinition) { }
        public virtual void VisitCssValuePercentageDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePercentageDefinition percentageDefinition) { }
        public virtual void VisitCssValuePositionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePositionDefinition positionDefinition) { }
        public virtual void VisitCssValuePropertyReferenceDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition) { }
        public virtual void VisitCssValueResolutionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueResolutionDefinition resolutionDefinition) { }
        public virtual void VisitCssValueSelectorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueSelectorDefinition selectorDefinition) { }
        public virtual void VisitCssValueStringDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueStringDefinition stringDefinition) { }
        public virtual void VisitCssValueTextDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTextDefinition textDefinition) { }
        public virtual void VisitCssValueTimeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTimeDefinition timeDefinition) { }
        public virtual void VisitCssValueUrangeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUrangeDefinition urangeDefinition) { }
        public virtual void VisitCssValueUriDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUriDefinition uriDefinition) { }
    }
    public abstract class CssValueDefinitionVisitorBase<TContext> : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionVisitor<TContext>
    
    {
        public virtual void VisitCssValueAngleDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAngleDefinition angleDefinition, TContext context) { }
        public virtual void VisitCssValueAnyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAnyDefinition anyDefinition, TContext context) { }
        public virtual void VisitCssValueColorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueColorDefinition colorDefinition, TContext context) { }
        public virtual void VisitCssValueDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition valueDefinition, TContext context) { }
        public virtual void VisitCssValueEmptyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueEmptyDefinition emptyDefinition, TContext context) { }
        public virtual void VisitCssValueExpressionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueExpressionDefinition expressionDefinition, TContext context) { }
        public virtual void VisitCssValueFrequencyDefinition(JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssValueFrequencyDefinition frequencyDefinition, TContext context) { }
        public virtual void VisitCssValueGroupDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition, TContext context) { }
        public virtual void VisitCssValueInlineDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition, TContext context) { }
        public virtual void VisitCssValueIntegerDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueIntegerDefinition integerDefinition, TContext context) { }
        public virtual void VisitCssValueInvokeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition, TContext context) { }
        public virtual void VisitCssValueJavaScriptDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueJavaScriptDefinition javaScriptDefinition, TContext context) { }
        public virtual void VisitCssValueLengthDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueLengthDefinition lengthDefinition, TContext context) { }
        public virtual void VisitCssValueNameDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNameDefinition nameDefinition, TContext context) { }
        public virtual void VisitCssValueNullDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNullDefinition nullDefinition, TContext context) { }
        public virtual void VisitCssValueNumberDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNumberDefinition numberDefinition, TContext context) { }
        public virtual void VisitCssValuePercentageDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePercentageDefinition percentageDefinition, TContext context) { }
        public virtual void VisitCssValuePositionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePositionDefinition positionDefinition, TContext context) { }
        public virtual void VisitCssValuePropertyReferenceDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition, TContext context) { }
        public virtual void VisitCssValueResolutionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueResolutionDefinition resolutionDefinition, TContext context) { }
        public virtual void VisitCssValueSelectorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueSelectorDefinition selectorDefinition, TContext context) { }
        public virtual void VisitCssValueStringDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueStringDefinition stringDefinition, TContext context) { }
        public virtual void VisitCssValueTextDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTextDefinition textDefinition, TContext context) { }
        public virtual void VisitCssValueTimeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTimeDefinition timeDefinition, TContext context) { }
        public virtual void VisitCssValueUrangeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUrangeDefinition urangeDefinition, TContext context) { }
        public virtual void VisitCssValueUriDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUriDefinition uriDefinition, TContext context) { }
    }
    public enum CssValueGroupType
    {
        All = 0,
        And = 1,
        Any = 2,
        Or = 3,
        Default = 0,
    }
    public enum CssValueType : byte
    {
        Angle = 0,
        Color = 1,
        Frequency = 2,
        Integer = 3,
        Identifier = 4,
        Length = 5,
        Number = 6,
        Percentage = 7,
        Resolution = 8,
        String = 9,
        Time = 10,
        UnicodeRange = 11,
        Expression = 12,
        Position = 13,
        Selector = 14,
        Text = 15,
        Uri = 16,
    }
    public interface ICssAtruleDefinition
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Scope { get; }
    }
    public interface ICssBrowserDefinition
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Icon { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Prefix { get; }
    }
    public interface ICssCompasiteValueDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition> Items { get; }
    }
    public interface ICssDefinition
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserCompatibility Compatibility { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.CssLanguageVersion DeclaredIn { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Description { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.CssLanguageVersion ObsoleteIn { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ObsoleteToolTip { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.CssLanguageVersion OverriddenIn { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<string> Rules { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ToolTip { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Url { get; }
        bool IsDeclaredIn([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        bool IsObsoleteIn([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        bool IsOverridenIn([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        bool IsValid();
    }
    public interface ICssDefinitionsStorage
    {
        void Dispose();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssAtruleDefinition> EnumerateAtruleDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssBrowserDefinition> EnumerateBrowserDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition> EnumerateFunctionDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition> EnumerateFunctionDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunctionDeclaredElement> EnumerateFunctions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssMediaFeatureDefinition> EnumerateMediaFeatureDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssMediaFeatureDefinition> EnumerateMediaFeatureDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssMediaFeatureDeclaredElement> EnumerateMediaFeatures([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssNamedValueDefinition> EnumerateNamedValueDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssNamedValueDefinition> EnumerateNamedValueDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssNamedValueDeclaredElement> EnumerateNamedValues([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPropertyDeclaredElement> EnumerateProperties([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPropertyDefinition> EnumeratePropertyDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPropertyDefinition> EnumeratePropertyDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoClassDefinition> EnumeratePseudoClassDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoClassDefinition> EnumeratePseudoClassDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoClassDeclaredElement> EnumeratePseudoClasses([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoElementDefinition> EnumeratePseudoElementDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoElementDefinition> EnumeratePseudoElementDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoElementDeclaredElement> EnumeratePseudoElements([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoFunctionDefinition> EnumeratePseudoFunctionDefinitions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoFunctionDefinition> EnumeratePseudoFunctionDefinitions();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoFunctionDeclaredElement> EnumeratePseudoFunctions([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssAtruleDefinition GetAtruleByName([JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssBrowserDefinition GetBrowserById([JetBrains.Annotations.NotNullAttribute()] string id);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T> GetDefinitions<T>([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version)
            where T :  class, JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition;
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunctionDeclaredElement GetFunction([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition GetFunctionDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetFunctionSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssMediaFeatureDeclaredElement GetMediaFeature([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssMediaFeatureDefinition GetMediaFeatureDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetMediaFeatureSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssNamedValueDeclaredElement GetNamedValue([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssNamedValueDefinition GetNamedValueDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetNamedValueSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPropertyDeclaredElement GetProperty([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssPropertyDefinition GetPropertyDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertySymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoClassDeclaredElement GetPseudoClass([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoClassDefinition GetPseudoClassDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPseudoClassSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoElementDeclaredElement GetPseudoElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoElementDefinition GetPseudoElementDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPseudoElementSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoFunctionDeclaredElement GetPseudoFunction([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.IPsiServices psiServices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoFunctionDefinition GetPseudoFunctionDefinition([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPseudoFunctionSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices);
    }
    public interface ICssDescriptorsDefinition
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
    }
    public interface ICssFunctionDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition
    {
        bool IsDynamic { get; }
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Parameters { get; }
    }
    public interface ICssMediaFeatureDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string AppliesTo { get; }
        bool MinMaxPrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Value { get; }
    }
    public interface ICssNamedValueDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition ValueDefinition { get; }
    }
    public interface ICssPrimitiveValueDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition
    {
        JetBrains.ReSharper.Psi.Css.Definitions.CssValueType ValueType { get; }
    }
    public interface ICssPropertyDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string AppliesTo { get; }
        bool Inherited { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string InitialValue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string MediaGroup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Percentages { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Value { get; }
    }
    public interface ICssPseudoClassDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoDefinition { }
    public interface ICssPseudoDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition { }
    public interface ICssPseudoElementDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoDefinition { }
    public interface ICssPseudoFunctionDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoDefinition { }
    public interface ICssScopeDefinition
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
    }
    public interface ICssValueAngleDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueAnyDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueColorDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueDefinition
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition Definition { get; }
        int MaxOccur { get; }
        int MinOccur { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.CssLanguageVersion ObsoleteIn { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ObsoleteToolTip { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssCompasiteValueDefinition Parent { get; }
        bool ShowInCompletion { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ToolTip { get; }
        void Accept([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionVisitor visitor);
        void Accept<TContext>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionVisitor<TContext> visitor, TContext context);
        bool IsObsolete([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.IValidationResult Validate([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.Css.Validation.IValidationResultFactory resultFactory);
    }
    public interface ICssValueDefinitionVisitor
    {
        void VisitCssValueAngleDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAngleDefinition angleDefinition);
        void VisitCssValueAnyDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAnyDefinition anyDefinition);
        void VisitCssValueColorDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueColorDefinition colorDefinition);
        void VisitCssValueEmptyDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueEmptyDefinition emptyDefinition);
        void VisitCssValueExpressionDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueExpressionDefinition expressionDefinition);
        void VisitCssValueFrequencyDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssValueFrequencyDefinition frequencyDefinition);
        void VisitCssValueGroupDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition);
        void VisitCssValueInlineDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition);
        void VisitCssValueIntegerDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueIntegerDefinition integerDefinition);
        void VisitCssValueInvokeDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition);
        void VisitCssValueJavaScriptDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueJavaScriptDefinition javaScriptDefinition);
        void VisitCssValueLengthDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueLengthDefinition lengthDefinition);
        void VisitCssValueNameDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNameDefinition nameDefinition);
        void VisitCssValueNullDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNullDefinition nullDefinition);
        void VisitCssValueNumberDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNumberDefinition numberDefinition);
        void VisitCssValuePercentageDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePercentageDefinition percentageDefinition);
        void VisitCssValuePositionDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePositionDefinition positionDefinition);
        void VisitCssValuePropertyReferenceDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition);
        void VisitCssValueResolutionDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueResolutionDefinition resolutionDefinition);
        void VisitCssValueSelectorDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueSelectorDefinition selectorDefinition);
        void VisitCssValueStringDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueStringDefinition stringDefinition);
        void VisitCssValueTextDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTextDefinition textDefinition);
        void VisitCssValueTimeDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTimeDefinition timeDefinition);
        void VisitCssValueUrangeDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUrangeDefinition urangeDefinition);
        void VisitCssValueUriDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUriDefinition uriDefinition);
    }
    public interface ICssValueDefinitionVisitor<in TContext>
    
    {
        void VisitCssValueAngleDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAngleDefinition angleDefinition, TContext context);
        void VisitCssValueAnyDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAnyDefinition anyDefinition, TContext context);
        void VisitCssValueColorDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueColorDefinition colorDefinition, TContext context);
        void VisitCssValueEmptyDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueEmptyDefinition emptyDefinition, TContext context);
        void VisitCssValueExpressionDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueExpressionDefinition expressionDefinition, TContext context);
        void VisitCssValueFrequencyDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssValueFrequencyDefinition frequencyDefinition, TContext context);
        void VisitCssValueGroupDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition, TContext context);
        void VisitCssValueInlineDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition, TContext context);
        void VisitCssValueIntegerDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueIntegerDefinition integerDefinition, TContext context);
        void VisitCssValueInvokeDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition, TContext context);
        void VisitCssValueJavaScriptDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueJavaScriptDefinition javaScriptDefinition, TContext context);
        void VisitCssValueLengthDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueLengthDefinition lengthDefinition, TContext context);
        void VisitCssValueNameDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNameDefinition nameDefinition, TContext context);
        void VisitCssValueNullDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNullDefinition nullDefinition, TContext context);
        void VisitCssValueNumberDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNumberDefinition numberDefinition, TContext context);
        void VisitCssValuePercentageDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePercentageDefinition percentageDefinition, TContext context);
        void VisitCssValuePositionDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePositionDefinition positionDefinition, TContext context);
        void VisitCssValuePropertyReferenceDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition, TContext context);
        void VisitCssValueResolutionDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueResolutionDefinition resolutionDefinition, TContext context);
        void VisitCssValueSelectorDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueSelectorDefinition selectorDefinition, TContext context);
        void VisitCssValueStringDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueStringDefinition stringDefinition, TContext context);
        void VisitCssValueTextDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTextDefinition textDefinition, TContext context);
        void VisitCssValueTimeDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTimeDefinition timeDefinition, TContext context);
        void VisitCssValueUrangeDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUrangeDefinition urangeDefinition, TContext context);
        void VisitCssValueUriDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUriDefinition uriDefinition, TContext context);
    }
    public interface ICssValueDefinitionWithExclusion : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition
    {
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Exclusion { get; }
    }
    public interface ICssValueEmptyDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition { }
    public interface ICssValueExpressionDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueGroupDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssCompasiteValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition
    {
        bool IgnoreWhitespaces { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        new string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Separator { get; }
        JetBrains.ReSharper.Psi.Css.Definitions.CssValueGroupType Type { get; }
    }
    public interface ICssValueInlineDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssNamedValueDefinition GetCssNamedValueDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
    }
    public interface ICssValueIntegerDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueInvokeDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunctionDeclaredElement GetCssFunctionDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
    }
    public interface ICssValueJavaScriptDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueLengthDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueNameDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Value { get; }
    }
    public interface ICssValueNullDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition { }
    public interface ICssValueNumberDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValuePercentageDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValuePositionDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValuePropertyReferenceDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPropertyDeclaredElement GetCssPropertyDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
    }
    public interface ICssValueResolutionDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueSelectorDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueStringDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Value { get; }
    }
    public interface ICssValueTextDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Text { get; }
    }
    public interface ICssValueTimeDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueUrangeDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
    public interface ICssValueUriDefinition : JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinitionWithExclusion { }
}
namespace JetBrains.ReSharper.Psi.Css.Gen
{
    
    public sealed class ErrorMessages
    {
        public static string GetErrorMessage0() { }
        public static string GetErrorMessage1() { }
        public static string GetErrorMessage10() { }
        public static string GetErrorMessage100() { }
        public static string GetErrorMessage101() { }
        public static string GetErrorMessage102() { }
        public static string GetErrorMessage103() { }
        public static string GetErrorMessage104() { }
        public static string GetErrorMessage105() { }
        public static string GetErrorMessage106() { }
        public static string GetErrorMessage107() { }
        public static string GetErrorMessage108() { }
        public static string GetErrorMessage109() { }
        public static string GetErrorMessage11() { }
        public static string GetErrorMessage110() { }
        public static string GetErrorMessage12() { }
        public static string GetErrorMessage13() { }
        public static string GetErrorMessage14() { }
        public static string GetErrorMessage15() { }
        public static string GetErrorMessage16() { }
        public static string GetErrorMessage17() { }
        public static string GetErrorMessage18() { }
        public static string GetErrorMessage19() { }
        public static string GetErrorMessage2() { }
        public static string GetErrorMessage20() { }
        public static string GetErrorMessage21() { }
        public static string GetErrorMessage22() { }
        public static string GetErrorMessage23() { }
        public static string GetErrorMessage24() { }
        public static string GetErrorMessage25() { }
        public static string GetErrorMessage26() { }
        public static string GetErrorMessage27() { }
        public static string GetErrorMessage28() { }
        public static string GetErrorMessage29() { }
        public static string GetErrorMessage3() { }
        public static string GetErrorMessage30() { }
        public static string GetErrorMessage31() { }
        public static string GetErrorMessage32() { }
        public static string GetErrorMessage33() { }
        public static string GetErrorMessage34() { }
        public static string GetErrorMessage35() { }
        public static string GetErrorMessage36() { }
        public static string GetErrorMessage37() { }
        public static string GetErrorMessage38() { }
        public static string GetErrorMessage39() { }
        public static string GetErrorMessage4() { }
        public static string GetErrorMessage40() { }
        public static string GetErrorMessage41() { }
        public static string GetErrorMessage42() { }
        public static string GetErrorMessage43() { }
        public static string GetErrorMessage44() { }
        public static string GetErrorMessage45() { }
        public static string GetErrorMessage46() { }
        public static string GetErrorMessage47() { }
        public static string GetErrorMessage48() { }
        public static string GetErrorMessage49() { }
        public static string GetErrorMessage5() { }
        public static string GetErrorMessage50() { }
        public static string GetErrorMessage51() { }
        public static string GetErrorMessage52() { }
        public static string GetErrorMessage53() { }
        public static string GetErrorMessage54() { }
        public static string GetErrorMessage55() { }
        public static string GetErrorMessage56() { }
        public static string GetErrorMessage57() { }
        public static string GetErrorMessage58() { }
        public static string GetErrorMessage59() { }
        public static string GetErrorMessage6() { }
        public static string GetErrorMessage60() { }
        public static string GetErrorMessage61() { }
        public static string GetErrorMessage62() { }
        public static string GetErrorMessage63() { }
        public static string GetErrorMessage64() { }
        public static string GetErrorMessage65() { }
        public static string GetErrorMessage66() { }
        public static string GetErrorMessage67() { }
        public static string GetErrorMessage68() { }
        public static string GetErrorMessage69() { }
        public static string GetErrorMessage7() { }
        public static string GetErrorMessage70() { }
        public static string GetErrorMessage71() { }
        public static string GetErrorMessage72() { }
        public static string GetErrorMessage73() { }
        public static string GetErrorMessage74() { }
        public static string GetErrorMessage75() { }
        public static string GetErrorMessage76() { }
        public static string GetErrorMessage77() { }
        public static string GetErrorMessage78() { }
        public static string GetErrorMessage79() { }
        public static string GetErrorMessage8() { }
        public static string GetErrorMessage80() { }
        public static string GetErrorMessage81() { }
        public static string GetErrorMessage82() { }
        public static string GetErrorMessage83() { }
        public static string GetErrorMessage84() { }
        public static string GetErrorMessage85() { }
        public static string GetErrorMessage86() { }
        public static string GetErrorMessage87() { }
        public static string GetErrorMessage88() { }
        public static string GetErrorMessage89() { }
        public static string GetErrorMessage9() { }
        public static string GetErrorMessage90() { }
        public static string GetErrorMessage91() { }
        public static string GetErrorMessage92() { }
        public static string GetErrorMessage93() { }
        public static string GetErrorMessage94() { }
        public static string GetErrorMessage95() { }
        public static string GetErrorMessage96() { }
        public static string GetErrorMessage97() { }
        public static string GetErrorMessage98() { }
        public static string GetErrorMessage99() { }
    }
    public class static TokenBitsets
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_0;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_1;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_10;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_11;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_12;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_3;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_4;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_5;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_6;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_7;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_8;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_9;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_adjacentSiblingSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_alien;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_AndQuery;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_animationIdentifierName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_animationName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_animationStringName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_atruleset;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_atrulesetBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_atrulesetBlockBody;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_atrulesetValue;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_attributeMatch;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_attributeMatchOperator;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_attributeMatchValue;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_attributeName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_attributeSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_charset;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_childSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_classSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_colorProfile;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_colorProfileBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssAdditiveExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssAlienExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssArgumentList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssArgumentValue;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssColorExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssFile;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssFileSection;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssFileSectionElement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssGroupExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssIdentifierExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssInvocationExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssJavaScriptExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssLiteralExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssMultiplicativeExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssNamespace;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssNamespacePrefix;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPageBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPageBlockBody;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPrimitiveExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssProperty;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPropertyBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPropertyStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPropertyStatementList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPropertyValue;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssPropertyValueExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssStringLiteralExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssTokenExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_cssUnaryExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_descendantSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFamily;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFamilyList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFamilyName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFamilyString;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFeatureType;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFeatureTypeBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFeatureTypeProperty;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFeatureTypePropertyStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFeatureValues;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_fontFeatureValuesBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_generalSiblingSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_identifier;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_idSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_import;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_important;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_jsToken;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_keyframes;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_keyframesBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_keyframesRule;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_keyframesRuleBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_keyframesSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_keyframesSelectorList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_media;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_mediaBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_mediaBlockBody;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_mediaFeature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_mediaFeatureValue;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_mediaQuery;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_mediaQueryList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_msoNamespacePrefix;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_namespacePrefix;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_page;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_pseudoArgumentList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_pseudoArgumentValue;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_pseudoClassSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_pseudoElementSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_pseudoFunctionSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_pseudoSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_ruleset;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_rulesetDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_rulesetDeclarationList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_selector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_selectorAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_selectorElementAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_separator;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_simpleSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_typeSelector;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_unaryOperator;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_url;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_urlPrefix;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_ws;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_0;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_1;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_10;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_11;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_12;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_13;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_14;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_15;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_16;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_17;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_18;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_19;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_20;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_21;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_22;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_23;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_24;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_25;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_26;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_27;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_28;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_29;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_3;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_30;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_31;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_32;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_33;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_34;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_35;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_36;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_4;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_5;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_6;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_7;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_8;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_9;
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl
{
    
    public class CssDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementTypeBase
    {
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType ColorProfile;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType CssClass;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType CssPropertyValue;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType Function;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType Keyframes;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType MediaFeature;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType Page;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType Property;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType PseudoClass;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType PseudoElement;
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.CssDeclaredElementType Ruleset;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeInspectionSettings), "CSS language settings")]
    public class CssInspectionSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Build CSS style hierarchy")]
        public bool BuildStyleHierarchy { get; set; }
        [JetBrains.Application.Settings.SettingsEntryAttribute("3.0", "CSS language version")]
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion CssVersion { get; set; }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.ProjectSettingsUpgraderAttribute()]
    public class CssLanguageProjectSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.IProjectSettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    public class static CssVersionSettingsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.CssLanguageVersion GetCssVersion([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static void SetCssVersion([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
    }
    public class SelectorNameBuilder : JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<System.Text.StringBuilder>
    {
        public static readonly JetBrains.ReSharper.Psi.Css.Impl.SelectorNameBuilder Instance;
        public override void VisitAdjacentSiblingSelector(JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector adjacentSiblingSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitAttributeMatch(JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch attributeMatchParam, System.Text.StringBuilder context) { }
        public override void VisitAttributeSelector(JetBrains.ReSharper.Psi.Css.Tree.IAttributeSelector attributeSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitChildSelector(JetBrains.ReSharper.Psi.Css.Tree.IChildSelector childSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitClassSelector(JetBrains.ReSharper.Psi.Css.Tree.IClassSelector classSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitCssNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix cssNamespacePrefixParam, System.Text.StringBuilder context) { }
        public override void VisitDescendantSelector(JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector descendantSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitGeneralSiblingSelector(JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector generalSiblingSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitIdSelector(JetBrains.ReSharper.Psi.Css.Tree.IIdSelector idSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitMsoNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.IMsoNamespacePrefix msoNamespacePrefixParam, System.Text.StringBuilder context) { }
        public override void VisitNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix namespacePrefixParam, System.Text.StringBuilder context) { }
        public override void VisitPseudoClassSelector(JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector pseudoClassSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitPseudoElementSelector(JetBrains.ReSharper.Psi.Css.Tree.IPseudoElementSelector pseudoElementSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitPseudoFunctionSelector(JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector pseudoFunctionSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitSimpleSelector(JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector simpleSelectorParam, System.Text.StringBuilder context) { }
        public override void VisitTypeSelector(JetBrains.ReSharper.Psi.Css.Tree.ITypeSelector typeSelectorParam, System.Text.StringBuilder context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements
{
    
    public class CssClassDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssSymbolDeclaredElementBase<JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol, JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement>, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement
    {
        public CssClassDeclaredElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement SetName(string newName) { }
    }
    public class CssColorProfileDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssSymbolDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Symbols.ICssColorProfileSymbol, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssColorProfileDeclaredElement>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssColorProfileDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssColorProfileDeclaredElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public override bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssColorProfileDeclaredElement SetName(string newName) { }
    }
    public abstract class CssDefinitionDeclaredElementBase<T> : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
        where T :  class, JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition
    {
        protected CssDefinitionDeclaredElementBase([JetBrains.Annotations.NotNullAttribute()] T definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public bool CaseSensistiveName { get; }
        public T Definition { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public abstract string XmlDocId { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    public class CssFunctionDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssDefinitionDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunction, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunctionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssFunctionDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssFunctionDefinition definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public bool HaveArguments { get; }
        public override string XmlDocId { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class CssMediaFeatureDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssDefinitionDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Definitions.ICssMediaFeatureDefinition>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssMediaFeatureDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssMediaFeatureDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssMediaFeatureDefinition definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public override string XmlDocId { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class CssPropertyDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssDefinitionDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Definitions.ICssPropertyDefinition>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPropertyDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssPropertyDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssPropertyDefinition definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public override string XmlDocId { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class CssPseudoClassDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssDefinitionDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoClassDefinition>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoClassDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssPseudoClassDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoClassDefinition definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public override string XmlDocId { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class CssPseudoElementDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssDefinitionDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoElementDefinition>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoElementDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssPseudoElementDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoElementDefinition definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public override string XmlDocId { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class CssPseudoFunctionDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssDefinitionDeclaredElementBase<JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoFunctionDefinition>, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssFunction, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssPseudoFunctionDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssPseudoFunctionDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssPseudoFunctionDefinition definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public bool HaveArguments { get; }
        public override string XmlDocId { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class CssSelectorDeclaredElement : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssSimpleDeclaredElementBase, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssSelectorDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public CssSelectorDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution) { }
        public override bool CaseSensistiveName { get; }
        public override string ShortName { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override bool IsValid() { }
    }
    public abstract class CssSimpleDeclaredElementBase : JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        protected readonly JetBrains.ProjectModel.ISolution Solution;
        protected CssSimpleDeclaredElementBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public virtual bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public abstract string ShortName { get; }
        public override bool Equals(object obj) { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations();
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public virtual JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public virtual System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public virtual System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public virtual bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public abstract bool IsValid();
    }
    public abstract class CssSymbolDeclaredElementBase<TSymbol, TDeclaredElement> : JetBrains.ReSharper.Psi.Css.Impl.DeclaredElements.CssSimpleDeclaredElementBase
        where TSymbol :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
        where TDeclaredElement :  class, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        protected CssSymbolDeclaredElementBase([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public override bool CaseSensistiveName { get; }
        public override string ShortName { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Collections.Generic.IEnumerable<TSymbol> GetSymbols() { }
        public override bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool IsValid() { }
        public abstract TDeclaredElement SetName(string newName);
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.Definitions
{
    
    public class static CssValueDefinitionExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition> EnumerateLeafs([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssCompasiteValueDefinition definition) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition> EnumerateParents([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        public static int GetDistanceToRoot([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetNext<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition)
            where T :  class, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetNextSibling<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition)
            where T :  class, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetPrevSibling<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition)
            where T :  class, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetRoot<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition)
            where T :  class, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition { }
    }
    public class static CssValueDefinitionFactory
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition CreateCssValueDefinition([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssCompasiteValueDefinition parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition definition) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition CreateSingleValue([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssCompasiteValueDefinition parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition definition) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.Services
{
    
    public interface ICssSymbolFilter
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol> FilterSymbols(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol> symbols);
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.Tree
{
    
    public class CssAlienIdentifierToken : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssGenericToken, JetBrains.ReSharper.Psi.Css.Tree.ICssAlien, JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public CssAlienIdentifierToken(string text) { }
        public string Name { get; }
    }
    public class CssAlienToken : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssGenericToken, JetBrains.ReSharper.Psi.Css.Tree.ICssAlien, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public CssAlienToken(string text) { }
    }
    public enum CssChildRole : short
    {
        LAST = -1,
        NONE = 0,
        CSS_ARGUMENT = 1,
        CSS_ARGUMENT_LIST = 2,
        CSS_ATRULESET = 3,
        CSS_ATTRIBUTE_MATCH = 4,
        CSS_BLOCK = 5,
        CSS_CHARSET = 6,
        CSS_COLON = 7,
        CSS_COLOR_PROFILE = 8,
        CSS_COMMA = 9,
        CSS_DOT = 10,
        CSS_EXCLAMATION = 11,
        CSS_EXPRESSION = 12,
        CSS_FILE_SECTION = 13,
        CSS_KEYFRAMES = 14,
        CSS_FONTFACE = 15,
        CSS_FONT_FEATURE_VALUES = 16,
        CSS_IMPORT = 17,
        CSS_IMPORTANT = 18,
        CSS_LIST = 19,
        CSS_ITEM = 20,
        CSS_KEYWORD = 21,
        CSS_LBRACE = 22,
        CSS_LBRACKET = 23,
        CSS_LITERAL = 24,
        CSS_LPAREN = 25,
        CSS_LVALUE = 26,
        CSS_MEDIA = 27,
        CSS_MEDIA_QUERY = 28,
        CSS_MEDIA_FEATURE = 29,
        CSS_MEDIA_QUERY_LIST = 30,
        CSS_NAME = 31,
        CSS_NAMESPACE = 32,
        CSS_NAMESPACE_PREFIX = 33,
        CSS_OPERATOR = 34,
        CSS_OPERATOR_AND = 35,
        CSS_HASH = 36,
        CSS_PAGE = 37,
        CSS_PREFIX = 38,
        CSS_PROPERTY = 39,
        CSS_PROPERTY_LIST = 40,
        CSS_RBRACE = 41,
        CSS_RBRACKET = 42,
        CSS_RPAREN = 43,
        CSS_RULESET = 44,
        CSS_RULESET_DECLARATION = 45,
        CSS_RULESET_DECLARATION_LIST = 46,
        CSS_RULESET_LIST = 47,
        CSS_RVALUE = 48,
        CSS_SELECTOR = 49,
        CSS_SEMICOLON = 50,
        CSS_SELECTOR_LIST = 51,
        CSS_SIMPLE_SELECTOR = 52,
        CSS_STATEMENT = 53,
        CSS_STAR = 54,
        CSS_VALUE = 55,
        CSS_VERTICAL_BAR = 56,
    }
    public abstract class CssCompositeElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual void Accept(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor visitor) { }
        public virtual void Accept<TContext>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext> visitor, TContext context) { }
        public virtual TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public abstract class CssExpressionBase : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssCompositeElement, JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public JetBrains.ReSharper.Psi.Tree.ExpressionAccessType GetAccessType() { }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssExpression ReplaceBy<TExpression>(TExpression expression)
            where TExpression :  class, JetBrains.ReSharper.Psi.Css.Tree.ICssExpression { }
    }
    public abstract class CssFileElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.FileElementBase
    {
        public abstract void Accept(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor visitor);
        public abstract void Accept<TContext>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext> visitor, TContext context);
        public abstract TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context);
    }
    public class CssGenericToken : JetBrains.ReSharper.Psi.Css.Parsing.CssTokenBase
    {
        public CssGenericToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType, string text) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public override string GetText() { }
        public override JetBrains.Text.IBuffer GetTextAsBuffer() { }
        public override int GetTextLength() { }
    }
    public class CssIdentifierToken : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssGenericToken, JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public CssIdentifierToken(string text) { }
        public string Name { get; }
    }
    public class CssKeyword : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssGenericToken, JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public CssKeyword(JetBrains.ReSharper.Psi.Css.Parsing.CssTokenType tokenType, string text) { }
        public string Name { get; }
    }
    public class CssLiteralToken : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssGenericToken
    {
        public CssLiteralToken(JetBrains.ReSharper.Psi.Css.Parsing.CssTokenType tokenType, string text) { }
    }
    public class CssRecursiveElementProcessor<T> : JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<T>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<T>
    
    {
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, T context) { }
        public bool IsProcessingFinished(T context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, T context) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, T context) { }
    }
    public class static ElementBitsets
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ANIMATION_NAME_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CSS_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CSS_PRIMITIVE_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CSS_PROPERTY_VALUE_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FONT_FAMILY_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet NAMESPACE_PREFIX_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet SELECTOR_BIT_SET;
    }
    public abstract class ElementType
    {
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType _ALIEN;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType _IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType _JS_TOKEN;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ADJACENT_SIBLING_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ANIMATION_IDENTIFIER_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ANIMATION_STRING_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ATRULESET;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ATRULESET_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ATRULESET_VALUE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ATTRIBUTE_MATCH;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ATTRIBUTE_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ATTRIBUTE_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CHARSET;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CHILD_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CLASS_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType COLOR_PROFILE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType COLOR_PROFILE_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_ADDITIVE_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_ALIEN_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_ARGUMENT_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_COLOR_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_FILE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_FILE_SECTION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_GROUP_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_IDENTIFIER_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_INVOCATION_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_JAVA_SCRIPT_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_LITERAL_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_MULTIPLICATIVE_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_NAMESPACE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_NAMESPACE_PREFIX;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_PAGE_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_PROPERTY;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_PROPERTY_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_PROPERTY_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_PROPERTY_VALUE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_STRING_LITERAL_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_TOKEN_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CSS_UNARY_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DESCENDANT_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ERROR_ELEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FAMILY_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FAMILY_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FAMILY_STRING;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FEATURE_TYPE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FEATURE_TYPE_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FEATURE_TYPE_PROPERTY;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FEATURE_TYPE_PROPERTY_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FEATURE_VALUES;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FONT_FEATURE_VALUES_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType GENERAL_SIBLING_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ID_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IMPORT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IMPORTANT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYFRAMES;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYFRAMES_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYFRAMES_RULE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYFRAMES_RULE_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYFRAMES_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYFRAMES_SELECTOR_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType MEDIA;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType MEDIA_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType MEDIA_FEATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType MEDIA_QUERY;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType MEDIA_QUERY_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType MSO_NAMESPACE_PREFIX;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PAGE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PSEUDO_ARGUMENT_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PSEUDO_CLASS_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PSEUDO_ELEMENT_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PSEUDO_FUNCTION_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RULESET;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RULESET_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RULESET_DECLARATION_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SIMPLE_SELECTOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TYPE_SELECTOR;
    }
    public class PsiGeneratedGetterTestUtil : JetBrains.ReSharper.Psi.Parsing.PsiGetterTestUtil
    {
        public static void TestCssTreeNode(int level, JetBrains.ReSharper.Psi.Tree.ITreeNode param, string caller) { }
    }
    public abstract class SelectorBase : JetBrains.ReSharper.Psi.Css.Impl.Tree.CssCompositeElement, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Css.SelectorSpecificity SelectorSpecificity { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector> SimpleSelectors { get; }
        protected override void ClearCachedData() { }
        public override string ToString() { }
    }
    public abstract class TokenType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ATKEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CH_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CHARSET_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLOR_PROFILE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COMMA;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DASHMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEG_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIMENSION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOUBLECOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DPCM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DPI_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DPPX_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQUALS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EX_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXCLAMATION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FONT_FEATURE_VALUES_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GRAD_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HASH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HEXDIGIT_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HZ_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPORT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IN_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INCLUDES;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INTEGER_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType JS_TOKEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType KEYFRAMES_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType KHZ_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LPAREN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MEDIA_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MS_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NAMESPACE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_LINE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOEQUALS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PAGE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENTAGE_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType POSITION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PREFIXMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PT_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PX_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAD_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REAL_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RPAREN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType S_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SEMICOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUBSTRINGMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUFFIXMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TILDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TURN_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType UNICODERANGE_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType URI_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VERTICAL_BAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VH_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VMIN_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VW_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WHITE_SPACE;
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.Tree.References
{
    
    public class static ResolveHelper
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo CheckResolveInfo(this JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo result, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType notResolved) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.Validation.Descriptions
{
    
    public class EmptyValueExpected : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public EmptyValueExpected(JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node) { }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class ExclusionIsTrue : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public ExclusionIsTrue(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition exclusion, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Exclusion { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Node { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class ExpectedGroup : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public ExpectedGroup(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition GroupDefinition { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class ExpectedSingleValue : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public ExpectedSingleValue(JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Definition { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Node { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class ExpectedValue : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public ExpectedValue(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Definition { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class RedundantValues : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public RedundantValues(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> nodes) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Nodes { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class SeparatorIsLastValue : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public SeparatorIsLastValue(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition separator, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node) { }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Node { get; }
        public sbyte Priority { get; }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Separator { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class UnexpectedEndOfValue : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public UnexpectedEndOfValue(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode lastValueNode) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Definition { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode LastValueNode { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class UnexpectedWhitespace : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public UnexpectedWhitespace(JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node) { }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Node { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
    public class ValueShouldHaveUnits : JetBrains.ReSharper.Psi.Css.Validation.IFailDescription
    {
        public ValueShouldHaveUnits(JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition definition, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssPrimitiveValueDefinition Definition { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Node { get; }
        public sbyte Priority { get; }
        public JetBrains.DocumentModel.DocumentRange GetErrorRange() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Impl.Validation
{
    
    public class ValidationResultFactory : JetBrains.ReSharper.Psi.Css.Validation.IValidationResultFactory
    {
        public virtual JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult Fail(JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode, JetBrains.ReSharper.Psi.Css.Validation.IFailDescription description) { }
        public virtual JetBrains.ReSharper.Psi.Css.Validation.IFailCompasiteValidationResult Fail(JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode, JetBrains.ReSharper.Psi.Css.Validation.IFailDescription description, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IValidationResult> results) { }
        public virtual JetBrains.ReSharper.Psi.Css.Validation.IValidationResult Success(JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode) { }
        public virtual JetBrains.ReSharper.Psi.Css.Validation.ICompasiteValidationResult Success(JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IValidationResult> results) { }
    }
    public class static ValidationResultHelper
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> EnumerateNodes<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.LinkedListNode<T> firstNode) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> EnumerateNodes<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.LinkedListNode<T> firstNode, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.LinkedListNode<T> lastNode) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> FindNextNode(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IValidationResult> results) { }
        public static int GetDistanceToLastNode([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> result) { }
        public static int GetDistanceToRoot([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Validation.IValidationResult result) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetErrorMessage([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult> results, string singleFormat, string multyFormat, int textLength) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetNextMeaningfulNode([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> node) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetPreviousMeaningfulNode([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> node) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Validation.IValidationResult GetRoot([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Validation.IValidationResult result) { }
        public static bool IsSkippedIdentifierName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression node) { }
        public static bool IsSuccess([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Css.Validation.IValidationResult result) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string PrintErrorMessage([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult> results, string singleFormat, string multyFormat) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string PrintErrorMessage([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition> definitions, string singleFormat, string multyFormat) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult> TrimErrorMessage([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult> results, int textLength, System.Converter<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult>, string> printResults) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.LanguageImpl
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssLanguageService : JetBrains.ReSharper.Psi.LanguageService
    {
        public CssLanguageService(JetBrains.ReSharper.Psi.Css.CssLanguage language, JetBrains.ReSharper.Psi.Css.CodeStyle.ICssCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache listCache) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter CodeFormatter { get; }
        public override bool IsCaseSensitive { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.CssProjectFileType))]
    public class CssProjectFileLanguageService : JetBrains.ReSharper.Psi.IProjectFileLanguageService
    {
        public CssProjectFileLanguageService(JetBrains.ProjectModel.CssProjectFileType cssProjectFileType) { }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreprocessorDefines(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Naming
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class CssCustomRulesNamingSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CustomRulesNamingSettingsUpgrade<JetBrains.ReSharper.Psi.Css.Naming.CssNamingSettingsKey>
    {
        public CssCustomRulesNamingSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase GetSpecificSettings(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings) { }
    }
    [JetBrains.ReSharper.Psi.Naming.Elements.NamedElementsBagAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssNamedElements : JetBrains.ReSharper.Psi.Naming.Elements.ElementKindOfElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_CLASS_SELECTOR_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_FUNCTION_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_MEDIA_FEATURE_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_PROPERTY_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_PSEUDO_CLASS_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_PSEUDO_ELEMENT_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_PSEUDO_FUNCTION_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind CSS_TYPE_SELECTOR_NAME;
        protected CssNamedElements([JetBrains.Annotations.NotNullAttribute()] string name, string presentableName, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> isApplicable, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.Naming.Settings.NamingRule GetDefaultRule() { }
    }
    [JetBrains.ReSharper.Psi.Naming.Interfaces.NamingConsistencyCheckerAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssNamingConsistencyChecker : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingConsistencyChecker
    {
        public void Check(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider namingPolicyProvider, out bool isFinalResult, out JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult result) { }
        public static JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult GetCheckResult(JetBrains.ReSharper.Psi.Naming.NamingManager namingManager, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, string shortName, string ruleName, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider policyProvider) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class CssNamingPolicyProvider : JetBrains.ReSharper.Psi.Naming.Impl.CustomRulesBasedPolicyProvider<JetBrains.ReSharper.Psi.Css.Naming.CssNamingSettingsKey>
    {
        public CssNamingPolicyProvider(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy UndefinedPolicy { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssNamingPolicyProviderFactory : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProviderFactory
    {
        public CssNamingPolicyProviderFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider CreatePolicyProvider(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.Naming.Settings.NamingSettings), "CSS naming settings")]
    public class CssNamingSettingsKey : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsKeyBase { }
    [System.ObsoleteAttribute("Deprecated, use CssNamingSettingsKey")]
    public class CssNamingStyleSettings : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase
    {
        public override object Clone() { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Parsing
{
    
    public class CssFilteringLexer : JetBrains.ReSharper.Psi.Css.Parsing.CssFilteringLexerBase, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexer<int>
    {
        public CssFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer<int> lexer) { }
        public int CurrentPosition { get; set; }
    }
    public class CssFilteringLexerBase : JetBrains.ReSharper.Psi.Parsing.FilteringLexer
    {
        public CssFilteringLexerBase(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        protected override bool Skip(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public class CssLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected const int YY_CONDITIONAL = 4;
        protected const int YY_IN_JS_EXPRESSION = 3;
        protected const int YY_IN_NTH = 1;
        protected const int YY_IN_URI = 2;
        protected const int YYINITIAL = 0;
        public CssLexerGenerated(JetBrains.Text.IBuffer buffer) { }
        public CssLexerGenerated(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        protected int BufferEnd { get; set; }
        protected int BufferIndex { get; set; }
        protected int BufferStart { get; set; }
        public virtual object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    public class CssLexerImpl : JetBrains.ReSharper.Psi.Css.Parsing.CssLexerGenerated
    {
        public CssLexerImpl(JetBrains.Text.IBuffer buffer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string EscapeString([JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeName([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeStringLiteral([JetBrains.Annotations.NotNullAttribute()] string text, JetBrains.Util.RangeTranslator translator = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeStringValue([JetBrains.Annotations.NotNullAttribute()] string text, JetBrains.Util.RangeTranslator translator = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeStringValue([JetBrains.Annotations.NotNullAttribute()] string text, int start, int end, JetBrains.Util.RangeTranslator translator = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeUrl([JetBrains.Annotations.NotNullAttribute()] string url, JetBrains.Util.RangeTranslator translator = null) { }
    }
    public class CssQuickParser : JetBrains.ReSharper.Psi.Css.Parsing.ICssParser, JetBrains.ReSharper.Psi.Parsing.IParser
    {
        protected readonly JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern IdentifierIntern;
        protected readonly JetBrains.ReSharper.Psi.Parsing.ILexer Lexer;
        public CssQuickParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, System.Collections.Generic.ICollection<string> pseudoFucntions, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache listCache) { }
        protected virtual JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected virtual JetBrains.ReSharper.Psi.Css.Parsing.CssTreeStructureBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Util.ITokenIntern intern, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeBuilder.Marker> listFromCache) { }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssExpression ParseExpression() { }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssFile ParseFile() { }
        public JetBrains.ReSharper.Psi.Css.Tree.IImport ParseImport() { }
        public JetBrains.ReSharper.Psi.Css.Tree.IRuleset ParseRuleset() { }
        public JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList ParseRulesetDeclarationList() { }
        public JetBrains.ReSharper.Psi.Css.Tree.ISelector ParseSelector() { }
    }
    public abstract class CssTokenBase : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual void Accept(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor visitor) { }
        public virtual void Accept<TContext>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext> visitor, TContext context) { }
        public virtual TResult Accept<TContext, TResult>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext, TResult> visitor, TContext context) { }
        public override System.Text.StringBuilder GetText(System.Text.StringBuilder to) { }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetTokenType() { }
        public override string ToString() { }
    }
    public class CssTokenType : JetBrains.ReSharper.Psi.Parsing.TokenNodeType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN_COMMENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN_IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AND_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ATKEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BAD_CHARACTER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CDC;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CDO;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CH_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CHARSET_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLOR_PROFILE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COMMA;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COMMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet COMMENTS_OR_WHITE_SPACES;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DASHMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEG_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIMENSION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOLLAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOUBLECOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DPCM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DPI_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DPPX_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EOF;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQUALS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ESCAPE_SEQUENCE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EX_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXCLAMATION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FONT_FEATURE_VALUES_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FROM_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GENERATED_CODE_SEPARATOR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GRAD_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HASH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HEXDIGIT_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_AND;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_END;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_START;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_END;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_ENDIF;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_FALSE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_GT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_GTE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_IF;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LPAREN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LTE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_NOT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_OR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_RPAREN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_START;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_TRUE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_WHITE_SPACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HZ_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPORT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPORTANT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IN_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INCLUDES;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INTEGER_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType JS_TOKEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType KEYFRAMES_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType KHZ_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LPAREN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MEDIA_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MOD_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MS_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NAMESPACE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_LINE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOEQUALS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ONLY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PAGE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENTAGE_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType POSITION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PREFIXMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PT_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PX_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAD_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REAL_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REM_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RPAREN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType S_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SEMICOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUBSTRINGMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUFFIXMATCH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TILDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TO_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TURN_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType UNICODERANGE_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType URI_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VERTICAL_BAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VH_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VMIN_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VW_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WHITE_SPACE;
        public CssTokenType(string s, string representation, int index) { }
        public override bool IsComment { get; }
        public override bool IsConstantLiteral { get; }
        public override bool IsIdentifier { get; }
        public override bool IsKeyword { get; }
        public override bool IsStringLiteral { get; }
        public override bool IsWhitespace { get; }
        public override string TokenRepresentation { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public class CssAlienIdentifierNodeType : JetBrains.ReSharper.Psi.Css.Parsing.CssTokenType
        {
            public CssAlienIdentifierNodeType(int index) { }
            public override bool IsIdentifier { get; }
            public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        }
        public class CssAlienNodeType : JetBrains.ReSharper.Psi.Css.Parsing.CssTokenType
        {
            public CssAlienNodeType(int index) { }
            public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        }
        public class CssIdentifierNodeType : JetBrains.ReSharper.Psi.Css.Parsing.CssTokenType
        {
            public CssIdentifierNodeType(int index) { }
            public override bool IsIdentifier { get; }
            public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        }
    }
    public class CssTreeStructureBuilder : JetBrains.ReSharper.Psi.TreeBuilder.TreeStructureBuilderBase, JetBrains.ReSharper.Psi.TreeBuilder.IPsiBuilderTokenFactory
    {
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CHARSET;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FILE;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FILE_SECTION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IMPORTANT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet PrimitiveLiterals;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_BLOCK;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_VALUE;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RULESET;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RULESET_DECLARATION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RULESET_DECLARATION_LIST;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SIMPLE_SELECTOR;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType STRING_LITERAL_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TYPE_SELECTOR;
        public CssTreeStructureBuilder(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Util.ITokenIntern identifierIntern, System.Collections.Generic.ICollection<string> pseudoFucntions, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeBuilder.Marker> listFromCache) { }
        protected override JetBrains.ReSharper.Psi.TreeBuilder.PsiBuilder Builder { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CommentsOrWhiteSpacesTokens { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType NewLine { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase CreateToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        protected bool Expect(JetBrains.ReSharper.Psi.Parsing.TokenNodeType expectedToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType alterToken) { }
        protected bool Expect(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tt, JetBrains.ReSharper.Psi.Parsing.TokenNodeType expectedToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType alterToken) { }
        protected override string GetExpectedMessage(string name) { }
        protected string GetUnexpectedTokenMessage() { }
        protected override void MarkErrorAndSkipToken(string message) { }
        protected bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType expectedToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType alterToken) { }
        protected bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tt, JetBrains.ReSharper.Psi.Parsing.TokenNodeType expectedToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType alterToken) { }
        public void ParseCssFile() { }
        public void ParseExpression() { }
        public void ParseImport() { }
        public void ParseRuleset() { }
        public void ParseRulesetDeclarationList() { }
        public void ParseSelector() { }
        protected override void SkipWhitespaces() { }
    }
    public class static HtmlCommentKeywords
    {
        public const string ENDIF = "endif";
        public const string FALSE = "false";
        public const string GT = "gt";
        public const string GTE = "gte";
        public const string IF = "if";
        public const string LT = "lt";
        public const string LTE = "lte";
        public const string TRUE = "true";
    }
    public interface ICssParser : JetBrains.ReSharper.Psi.Parsing.IParser
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression ParseExpression();
        JetBrains.ReSharper.Psi.Css.Tree.ICssFile ParseFile();
        JetBrains.ReSharper.Psi.Css.Tree.IImport ParseImport();
        JetBrains.ReSharper.Psi.Css.Tree.IRuleset ParseRuleset();
        JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList ParseRulesetDeclarationList();
        JetBrains.ReSharper.Psi.Css.Tree.ISelector ParseSelector();
    }
}
namespace JetBrains.ReSharper.Psi.Css.Resolve
{
    
    public class CssLanguageVersionFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
    {
        public CssLanguageVersionFilter(JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
    }
    public class CssRuleFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
    {
        public CssRuleFilter([JetBrains.Annotations.CanBeNullAttribute()] string ruleName, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetAtRuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.CssDefinitions definitions) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Resolve.CustomReferences
{
    
    public class CssAnimationIdentifierNameReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public CssAnimationIdentifierNameReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class CssAnimationNameReferenceFactory : JetBrains.ReSharper.Psi.Css.Resolve.CustomReferences.CssPropertyIdentifierValueReferenceFactoryBase
    {
        public CssAnimationNameReferenceFactory() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference CreateReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class CssAnimationReferenceFactory : JetBrains.ReSharper.Psi.Css.Resolve.CustomReferences.CssPropertyIdentifierValueReferenceFactoryBase
    {
        public CssAnimationReferenceFactory() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference CreateReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class CssColorProfileIdentifierNameReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public CssColorProfileIdentifierNameReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class CssColorProfileNameReferenceFactory : JetBrains.ReSharper.Psi.Css.Resolve.CustomReferences.CssPropertyIdentifierValueReferenceFactoryBase
    {
        public CssColorProfileNameReferenceFactory() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference CreateReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class CssPageIdentifierNameReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public CssPageIdentifierNameReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class CssPageNameReferenceFactory : JetBrains.ReSharper.Psi.Css.Resolve.CustomReferences.CssPropertyIdentifierValueReferenceFactoryBase
    {
        public CssPageNameReferenceFactory() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference CreateReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public abstract class CssPropertyIdentifierValueReferenceFactoryBase : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        protected CssPropertyIdentifierValueReferenceFactoryBase(string propertyName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference CreateReference(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression identifierExpression);
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.Css.Tree.ICssProperty GetValidProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression valueExpression) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        protected virtual bool IsValidProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssProperty property) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Resources
{
    
    public sealed class PsiCssThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 8, "Css")]
        public sealed class Css : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 4, "CssAtRule")]
        public sealed class CssAtRule : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 2, "CssClass")]
        public sealed class CssClass : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 9, "CssFunction")]
        public sealed class CssFunction : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 5, "CssId")]
        public sealed class CssId : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 1, "CssProperty")]
        public sealed class CssProperty : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 7, "CssPropertyValue")]
        public sealed class CssPropertyValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 3, "CssPseudoElement")]
        public sealed class CssPseudoElement : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 6, "CssRuleset")]
        public sealed class CssRuleset : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Css;component/resources/PsiCssThemedIcons/ThemedIcons.Psi" +
            "Css.Generated.Xaml", 0, "CssRuleset2")]
        public sealed class CssRuleset2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Services
{
    
    public interface ICssSymbolResolver
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol> FilterSymbols(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol> symbols);
    }
    public interface ICssSymbolVisibilityManager
    {
        bool IsVisible(JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol symbol, JetBrains.ReSharper.Psi.IPsiSourceFile fromFile);
    }
}
namespace JetBrains.ReSharper.Psi.Css.Symbols
{
    
    public interface ICssAnimationSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframes GetDeclaration();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.IKeyframesDeclaredElement GetDeclaredElement();
    }
    public interface ICssClassSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        string SelectorFullName { get; }
    }
    public interface ICssColorProfileSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Tree.IColorProfile GetDeclaration();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssColorProfileDeclaredElement GetDeclaredElement();
    }
    public interface ICssPageSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Tree.IPage GetDeclaration();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.DeclaredElements.IPageDeclaredElement GetDeclaredElement();
    }
    public interface ICssTagIdSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol { }
}
namespace JetBrains.ReSharper.Psi.Css.Tree
{
    
    public class static AdjacentSiblingSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector GetByLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector GetByRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
    }
    public class static AnimationIdentifierNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAnimationIdentifierName GetByToken(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static AnimationNameNavigator { }
    public class static AnimationStringNameNavigator { }
    public class static AtrulesetBlockNavigator { }
    public class static AtrulesetNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAtruleset GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock param) { }
    }
    public class static AtrulesetValueNavigator { }
    public class static AttributeMatchNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch GetByName(JetBrains.ReSharper.Psi.Css.Tree.IAttributeName param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param) { }
    }
    public enum AttributeMatchOperation
    {
        Unknown = 0,
        PrefixMatch = 1,
        SubstringMatch = 2,
        SuffixMatch = 3,
        Includes = 4,
        DashMatch = 5,
        NoEquals = 6,
        Equals = 7,
    }
    public class static AttributeNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAttributeName GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAttributeName GetByNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix param) { }
    }
    public class static AttributeSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IAttributeSelector GetByMatch(JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch param) { }
    }
    public class static CharsetNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICharset GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression param) { }
    }
    public class static ChildSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IChildSelector GetByLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IChildSelector GetByRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
    }
    public class static ClassSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IClassSelector GetByDot(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IClassSelector GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static ColorProfileBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock GetByStatement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement param) { }
    }
    public class static ColorProfileNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IColorProfile GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock param) { }
    }
    public class static CssAdditiveExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssAdditiveExpression GetByLValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssAdditiveExpression GetByRValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param) { }
    }
    public class static CssAlienExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssAlienExpression GetByValueToken(JetBrains.ReSharper.Psi.Css.Tree.ICssAlien param) { }
    }
    public class static CssArgumentListNavigator { }
    public class static CssColorExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression GetByHash(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression GetByLiteal(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
    }
    public abstract class CssCompositeNodeType : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType
    {
        protected CssCompositeNodeType(string s, int index) { }
    }
    public class static CssExpressionNavigator { }
    public class static CssFileNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFile GetBySection(JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection param) { }
    }
    public class static CssFileSectionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByAtRuleSet(JetBrains.ReSharper.Psi.Css.Tree.IAtruleset param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByCharset(JetBrains.ReSharper.Psi.Css.Tree.ICharset param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByColorProfile(JetBrains.ReSharper.Psi.Css.Tree.IColorProfile param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByFontFeatureValue(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByImport(JetBrains.ReSharper.Psi.Css.Tree.IImport param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByKeyFrame(JetBrains.ReSharper.Psi.Css.Tree.IKeyframes param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByMedia(JetBrains.ReSharper.Psi.Css.Tree.IMedia param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByNamespace(JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByPage(JetBrains.ReSharper.Psi.Css.Tree.IPage param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetByRuleSet(JetBrains.ReSharper.Psi.Css.Tree.IRuleset param) { }
    }
    public class static CssGroupExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssGroupExpression GetByExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param) { }
    }
    public class static CssIdentifierExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static CssInvocationExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression GetByArgumentList(JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static CssJavaScriptExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssJavaScriptExpression GetByValueToken(JetBrains.ReSharper.Psi.Css.Tree.ICssJsToken param) { }
    }
    public class static CssLiteralExpressionNavigator { }
    public class static CssMultiplicativeExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssMultiplicativeExpression GetByLValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssMultiplicativeExpression GetByRValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param) { }
    }
    public class static CssNamespaceNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param) { }
    }
    public class static CssNamespacePrefixNavigator { }
    public class static CssPageBlockNavigator { }
    public class static CssPrimitiveExpressionNavigator { }
    public class static CssPropertyBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock GetByStatement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement param) { }
    }
    public class static CssPropertyNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssProperty GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssProperty GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue param) { }
    }
    public class static CssPropertyStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement GetByProperty(JetBrains.ReSharper.Psi.Css.Tree.ICssProperty param) { }
    }
    public class static CssPropertyValueExpressionNavigator { }
    public class static CssPropertyValueNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue GetByExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue GetByImportant(JetBrains.ReSharper.Psi.Css.Tree.IImportant param) { }
    }
    public class static CssStringLiteralExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression GetByLiteal(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
    }
    public class static CssTokenExpressionNavigator { }
    public class static CssUnaryExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssUnaryExpression GetByExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param) { }
    }
    public class static DescendantSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector GetByLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector GetByRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
    }
    public class static FontFamilyListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList GetByItem(JetBrains.ReSharper.Psi.Css.Tree.IFontFamily param) { }
    }
    public class static FontFamilyNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyName GetByToken(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static FontFamilyNavigator { }
    public class static FontFamilyStringNavigator { }
    public class static FontFeatureTypeBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock GetByItem(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement param) { }
    }
    public class static FontFeatureTypeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock param) { }
    }
    public class static FontFeatureTypePropertyNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue param) { }
    }
    public class static FontFeatureTypePropertyStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement GetByProperty(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty param) { }
    }
    public class static FontFeatureValuesBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock GetByItem(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType param) { }
    }
    public class static FontFeatureValuesNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues GetByFontFamilyList(JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList param) { }
    }
    public class static GeneralSiblingSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector GetByLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector GetByRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
    }
    public interface IAdjacentSiblingSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ISelector LValue { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector RValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
    }
    public interface IAnimationIdentifierName : JetBrains.ReSharper.Psi.Css.Tree.IAnimationName, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetToken(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IAnimationName : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        string Name { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Token { get; }
        void SetName(string name);
    }
    public interface IAnimationStringName : JetBrains.ReSharper.Psi.Css.Tree.IAnimationName, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IArgumentList : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> Arguments { get; }
    }
    public interface IAtruleset : JetBrains.ReSharper.Psi.Css.Tree.ICssRule, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SemicolonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock param);
    }
    public interface IAtrulesetBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssBlockWithStatements, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> ItemsEnumerable { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface IAtrulesetValue : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Values { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ValuesEnumerable { get; }
    }
    public interface IAttributeMatch : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IAttributeName Name { get; }
        JetBrains.ReSharper.Psi.Css.Tree.AttributeMatchOperation Operation { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression Value { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ValueText { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IAttributeName SetName(JetBrains.ReSharper.Psi.Css.Tree.IAttributeName param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param);
    }
    public interface IAttributeName : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix NamespacePrefix { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Prefix { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix SetNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix param);
    }
    public interface IAttributeSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracketToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch Match { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracketToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch SetMatch(JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch param);
    }
    public interface ICharset : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SemicolonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression Value { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression param);
    }
    public interface IChildSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ISelector LValue { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector RValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
    }
    public interface IClassSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode DotToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IColorProfile : JetBrains.ReSharper.Psi.Css.Tree.ICssRule, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock param);
    }
    public interface IColorProfileBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssBlockWithStatements, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> StatementsEnumerable { get; }
    }
    public interface ICssAdditiveExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression LValue { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression RValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression SetLValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression SetRValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param);
    }
    public interface ICssAlien : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ICssAlienExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssAlien> ValueTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssAlien> ValueTokensEnumerable { get; }
    }
    public interface ICssArgumentList : JetBrains.ReSharper.Psi.Css.Tree.IArgumentList, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> Arguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> ArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokensEnumerable { get; }
    }
    public interface ICssBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface ICssBlockWithStatements : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> Statements { get; }
    }
    public interface ICssColorExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPrimitiveExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ICssVersionSpecific, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode HashToken { get; }
    }
    public interface ICssCommentNode : JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ICommentNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ICssExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ICssFile : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IImport> Imports { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection> Sections { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection> SectionsEnumerable { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration> GetRulesetListByClassName([JetBrains.Annotations.NotNullAttribute()] string className);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration> GetRulesetListById([JetBrains.Annotations.NotNullAttribute()] string id);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration>>> GetRulesetMapByClassName();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration>>> GetRulesetMapById();
    }
    public interface ICssFileSection : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IAtruleset> AtRuleSets { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IAtruleset> AtRuleSetsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICharset> Charset { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICharset> CharsetEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IColorProfile> ColorProfiles { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IColorProfile> ColorProfilesEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues> FontFeatureValues { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues> FontFeatureValuesEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IImport> Imports { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IImport> ImportsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IKeyframes> KeyFrames { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IKeyframes> KeyFramesEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IMedia> Medias { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IMedia> MediasEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace> Namespaces { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace> NamespacesEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IPage> Pages { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IPage> PagesEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> RuleSets { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> RuleSetsEnumerable { get; }
    }
    public interface ICssGroupExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LParenToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RParenToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression SetExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param);
    }
    public interface ICssIdentifier : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ICssIdentifierExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface ICssInvocationExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.IInvocationExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList ArgumentList { get; }
        new JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LParenToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RParenToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList SetArgumentList(JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface ICssJavaScriptExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssJsToken> ValueTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssJsToken> ValueTokensEnumerable { get; }
    }
    public interface ICssJsToken : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ICssLiteralExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPrimitiveExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool HaveUnits { get; }
        bool IsNumber { get; }
        bool IsZeroValue { get; }
    }
    public interface ICssMultiplicativeExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression LValue { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression RValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression SetLValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssExpression SetRValue(JetBrains.ReSharper.Psi.Css.Tree.ICssExpression param);
    }
    public interface ICssNamespace : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SemicolonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression Value { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param);
    }
    public interface ICssNamespacePrefix : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ICssVersionSpecific, JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode VerticalBarToken { get; }
    }
    public interface ICssPageBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssBlockWithStatements, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> ItemsEnumerable { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface ICssPrimitiveExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LiteralToken { get; }
    }
    public interface ICssProperty : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ColonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode StartToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue Value { get; }
        bool CanOverride([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssProperty property);
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue param);
    }
    public interface ICssPropertyBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssBlockWithStatements, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> StatementsEnumerable { get; }
    }
    public interface ICssPropertyStatement : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssProperty Property { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SemicolonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssProperty SetProperty(JetBrains.ReSharper.Psi.Css.Tree.ICssProperty param);
    }
    public interface ICssPropertyValue : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression> Expression { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression> ExpressionEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IImportant> Importants { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IImportant> ImportantsEnumerable { get; }
    }
    public interface ICssPropertyValueExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ICssRule : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string RuleName { get; }
    }
    public interface ICssStringLiteralExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPrimitiveExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Value { get; }
    }
    public interface ICssTokenExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ValueToken { get; }
    }
    public interface ICssTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        void Accept(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor visitor);
        void Accept<TContext>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext> visitor, TContext context);
        TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context);
    }
    public interface ICssUnaryExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression SetExpression(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param);
    }
    public interface ICssVersionSpecific : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.TreeTextRange GetErrorTextRange();
        bool Support([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.CssLanguageVersion version);
    }
    public interface IDescendantSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ISelector LValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector RValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
    }
    public class static IdSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IIdSelector GetByHash(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IIdSelector GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public interface IFontFamily : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IFontFamilyList : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokensEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IFontFamily> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IFontFamily> ItemsEnumerable { get; }
    }
    public interface IFontFamilyName : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.IFontFamily, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier> Tokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier> TokensEnumerable { get; }
    }
    public interface IFontFamilyString : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.IFontFamily, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Token { get; }
    }
    public interface IFontFeatureType : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock param);
    }
    public interface IFontFeatureTypeBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement> ItemsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface IFontFeatureTypeProperty : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ColonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue Value { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue param);
    }
    public interface IFontFeatureTypePropertyStatement : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty Property { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SemicolonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty SetProperty(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty param);
    }
    public interface IFontFeatureValues : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock Block { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList FontFamilyList { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock param);
        JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList SetFontFamilyList(JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList param);
    }
    public interface IFontFeatureValuesBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType> ItemsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface IGeneralSiblingSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ISelector LValue { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode OperatorToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector RValue { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetLValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetRValue(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
    }
    public interface IIdSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode HashToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IImport : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList MediaQueryList { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SemicolonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression Value { get; }
        JetBrains.ReSharper.Psi.IPathDeclaredElement ResolveUrl();
        JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList SetMediaQueryList(JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param);
    }
    public interface IImportant : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ExclamationToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ImportantToken { get; }
    }
    public interface IInvocationExpression : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Tree.IArgumentList ArgumentList { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITokenNode LParenToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITokenNode RParenToken { get; }
    }
    public interface IKeyframes : JetBrains.ReSharper.Psi.Css.Tree.ICssRule, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IAnimationName AnimationName { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock Block { get; }
        JetBrains.ReSharper.Psi.Css.DeclaredElements.IKeyframesDeclaredElement DeclaredElement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IAnimationName SetAnimationName(JetBrains.ReSharper.Psi.Css.Tree.IAnimationName param);
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock param);
    }
    public interface IKeyframesBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule> ItemsEnumerable { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface IKeyframesRule : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock Block { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList SelectorList { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock param);
        JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList SetSelectorList(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList param);
    }
    public interface IKeyframesRuleBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssBlockWithStatements, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> StatementsEnumerable { get; }
    }
    public interface IKeyframesSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Value { get; }
    }
    public interface IKeyframesSelectorList : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokensEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelector> Selectors { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelector> SelectorsEnumerable { get; }
    }
    public interface IMedia : JetBrains.ReSharper.Psi.Css.Tree.ICssRule, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList MediaQueryList { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock param);
        JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList SetMediaQueryList(JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList param);
    }
    public interface IMediaBlock : JetBrains.ReSharper.Psi.Css.Tree.ICssBlock, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> ItemsEnumerable { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBraceToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBraceToken { get; }
    }
    public interface IMediaFeature : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ColonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LParenToken { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RParenToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue Value { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue SetValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue param);
    }
    public interface IMediaQuery : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> AndToken { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> AndTokenEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature> Features { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature> FeaturesEnumerable { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier MediaType { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode PrefixToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetMediaType(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IMediaQueryList : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokensEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery> MediaQueries { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery> MediaQueriesEnumerable { get; }
    }
    public class static ImportantNavigator { }
    public class static ImportNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IImport GetByMediaQueryList(JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IImport GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression param) { }
    }
    public interface IMsoNamespacePrefix : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ICssVersionSpecific, JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface INamespacePrefix : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ICssVersionSpecific, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Identifier { get; }
        string Name { get; }
    }
    public interface IPage : JetBrains.ReSharper.Psi.Css.Tree.ICssRule, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock Block { get; }
        JetBrains.ReSharper.Psi.Css.DeclaredElements.IPageDeclaredElement DeclaredElement { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode KeywordToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector PseudoPage { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock SetBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
        JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector SetPseudoPage(JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector param);
    }
    public interface IPseudoArgumentList : JetBrains.ReSharper.Psi.Css.Tree.IArgumentList, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> Arguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> ArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokensEnumerable { get; }
    }
    public interface IPseudoClassSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ColonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IPseudoElementSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ColonToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IPseudoFunctionSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.IInvocationExpression, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList ArgumentList { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ColonToken { get; }
        new JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier Identifier { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LParenToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RParenToken { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList SetArgumentList(JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier SetIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param);
    }
    public interface IRuleset : JetBrains.ReSharper.Psi.Css.Tree.ICssRule, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList DeclarationList { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock PropertyBlock { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> StatementsEnumerable { get; }
        JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList SetDeclarationList(JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList param);
        JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock SetPropertyBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock param);
    }
    public interface IRulesetDeclaration : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Css.DeclaredElements.IRulesetDeclaredElement DeclaredElement { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector Selector { get; }
        JetBrains.ReSharper.Psi.Css.Tree.ISelector SetSelector(JetBrains.ReSharper.Psi.Css.Tree.ISelector param);
    }
    public interface IRulesetDeclarationList : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokens { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaTokensEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration> Declarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration> DeclarationsEnumerable { get; }
    }
    public interface ISelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        string Name { get; }
        JetBrains.ReSharper.Psi.Css.SelectorSpecificity SelectorSpecificity { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector> SimpleSelectors { get; }
    }
    public interface ISimpleSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string ElementName { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Css.Tree.ISelector> Items { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ISelector> ItemsEnumerable { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Css.Tree.ISelector> Parts { get; }
    }
    public interface ITypeSelector : JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode, JetBrains.ReSharper.Psi.Css.Tree.ISelector, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode Identifier { get; }
        JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix NamespacePrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TagName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string TagPrefix { get; }
        JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix SetNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix param);
    }
    public interface IWhitespaceTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsNewLine { get; }
    }
    public class static KeyframesBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock GetByItem(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule param) { }
    }
    public class static KeyframesNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframes GetByAnimationName(JetBrains.ReSharper.Psi.Css.Tree.IAnimationName param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframes GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock param) { }
    }
    public class static KeyframesRuleBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock GetByStatement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement param) { }
    }
    public class static KeyframesRuleNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule GetBySelectorList(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList param) { }
    }
    public class static KeyframesSelectorListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList GetBySelector(JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelector param) { }
    }
    public class static KeyframesSelectorNavigator { }
    public class static MediaBlockNavigator
    {
        public static JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock GetByItem(JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node) { }
    }
    public class static MediaFeatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature GetByValue(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue param) { }
    }
    public class static MediaNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMedia GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMedia GetByMediaQueryList(JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList param) { }
    }
    public class static MediaQueryListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList GetByMediaQuerie(JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery param) { }
    }
    public class static MediaQueryNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery GetByFeature(JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery GetByMediaType(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static MsoNamespacePrefixNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IMsoNamespacePrefix GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static NamespacePrefixNavigator { }
    public class static PageNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPage GetByBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPage GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPage GetByPseudoPage(JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector param) { }
    }
    public class static PseudoArgumentListNavigator { }
    public class static PseudoClassSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector GetByColon(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static PseudoElementSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoElementSelector GetByColon(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoElementSelector GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static PseudoFunctionSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector GetByArgumentList(JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector GetByColon(JetBrains.ReSharper.Psi.Tree.ITreeNode param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector GetByIdentifier(JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifier param) { }
    }
    public class static RulesetDeclarationListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList GetByDeclaration(JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration param) { }
    }
    public class static RulesetDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration GetBySelector(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
    }
    public class static RulesetNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IRuleset GetByDeclarationList(JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IRuleset GetByPropertyBlock(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.IRuleset GetByStatement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement param) { }
    }
    public class static SelectorNavigator { }
    public class static SimpleSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector GetByItem(JetBrains.ReSharper.Psi.Css.Tree.ISelector param) { }
    }
    public abstract class TreeNodeVisitor
    {
        public virtual void VisitAdjacentSiblingSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector adjacentSiblingSelectorParam) { }
        public virtual void VisitAnimationIdentifierName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationIdentifierName animationIdentifierNameParam) { }
        public virtual void VisitAnimationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationName animationNameParam) { }
        public virtual void VisitAnimationStringName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationStringName animationStringNameParam) { }
        public virtual void VisitAtruleset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtruleset atrulesetParam) { }
        public virtual void VisitAtrulesetBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock atrulesetBlockParam) { }
        public virtual void VisitAtrulesetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetValue atrulesetValueParam) { }
        public virtual void VisitAttributeMatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch attributeMatchParam) { }
        public virtual void VisitAttributeName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeName attributeNameParam) { }
        public virtual void VisitAttributeSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeSelector attributeSelectorParam) { }
        public virtual void VisitCharset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICharset charsetParam) { }
        public virtual void VisitChildSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IChildSelector childSelectorParam) { }
        public virtual void VisitClassSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IClassSelector classSelectorParam) { }
        public virtual void VisitColorProfile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IColorProfile colorProfileParam) { }
        public virtual void VisitColorProfileBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock colorProfileBlockParam) { }
        public virtual void VisitCssAdditiveExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssAdditiveExpression cssAdditiveExpressionParam) { }
        public virtual void VisitCssAlienExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssAlienExpression cssAlienExpressionParam) { }
        public virtual void VisitCssArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList cssArgumentListParam) { }
        public virtual void VisitCssColorExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression cssColorExpressionParam) { }
        public virtual void VisitCssExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssExpression cssExpressionParam) { }
        public virtual void VisitCssFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFile cssFileParam) { }
        public virtual void VisitCssFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection cssFileSectionParam) { }
        public virtual void VisitCssGroupExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssGroupExpression cssGroupExpressionParam) { }
        public virtual void VisitCssIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression cssIdentifierExpressionParam) { }
        public virtual void VisitCssInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression cssInvocationExpressionParam) { }
        public virtual void VisitCssJavaScriptExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssJavaScriptExpression cssJavaScriptExpressionParam) { }
        public virtual void VisitCssLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression cssLiteralExpressionParam) { }
        public virtual void VisitCssMultiplicativeExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssMultiplicativeExpression cssMultiplicativeExpressionParam) { }
        public virtual void VisitCssNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace cssNamespaceParam) { }
        public virtual void VisitCssNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix cssNamespacePrefixParam) { }
        public virtual void VisitCssPageBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock cssPageBlockParam) { }
        public virtual void VisitCssPrimitiveExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPrimitiveExpression cssPrimitiveExpressionParam) { }
        public virtual void VisitCssProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssProperty cssPropertyParam) { }
        public virtual void VisitCssPropertyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock cssPropertyBlockParam) { }
        public virtual void VisitCssPropertyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement cssPropertyStatementParam) { }
        public virtual void VisitCssPropertyValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue cssPropertyValueParam) { }
        public virtual void VisitCssPropertyValueExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression cssPropertyValueExpressionParam) { }
        public virtual void VisitCssStringLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression cssStringLiteralExpressionParam) { }
        public virtual void VisitCssTokenExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssTokenExpression cssTokenExpressionParam) { }
        public virtual void VisitCssUnaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssUnaryExpression cssUnaryExpressionParam) { }
        public virtual void VisitDescendantSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector descendantSelectorParam) { }
        public virtual void VisitFontFamily([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamily fontFamilyParam) { }
        public virtual void VisitFontFamilyList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList fontFamilyListParam) { }
        public virtual void VisitFontFamilyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyName fontFamilyNameParam) { }
        public virtual void VisitFontFamilyString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyString fontFamilyStringParam) { }
        public virtual void VisitFontFeatureType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType fontFeatureTypeParam) { }
        public virtual void VisitFontFeatureTypeBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock fontFeatureTypeBlockParam) { }
        public virtual void VisitFontFeatureTypeProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty fontFeatureTypePropertyParam) { }
        public virtual void VisitFontFeatureTypePropertyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement fontFeatureTypePropertyStatementParam) { }
        public virtual void VisitFontFeatureValues([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues fontFeatureValuesParam) { }
        public virtual void VisitFontFeatureValuesBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock fontFeatureValuesBlockParam) { }
        public virtual void VisitGeneralSiblingSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector generalSiblingSelectorParam) { }
        public virtual void VisitIdSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IIdSelector idSelectorParam) { }
        public virtual void VisitImport([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IImport importParam) { }
        public virtual void VisitImportant([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IImportant importantParam) { }
        public virtual void VisitKeyframes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframes keyframesParam) { }
        public virtual void VisitKeyframesBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock keyframesBlockParam) { }
        public virtual void VisitKeyframesRule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule keyframesRuleParam) { }
        public virtual void VisitKeyframesRuleBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock keyframesRuleBlockParam) { }
        public virtual void VisitKeyframesSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelector keyframesSelectorParam) { }
        public virtual void VisitKeyframesSelectorList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList keyframesSelectorListParam) { }
        public virtual void VisitMedia([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMedia mediaParam) { }
        public virtual void VisitMediaBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock mediaBlockParam) { }
        public virtual void VisitMediaFeature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature mediaFeatureParam) { }
        public virtual void VisitMediaQuery([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery mediaQueryParam) { }
        public virtual void VisitMediaQueryList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList mediaQueryListParam) { }
        public virtual void VisitMsoNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMsoNamespacePrefix msoNamespacePrefixParam) { }
        public virtual void VisitNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix namespacePrefixParam) { }
        public virtual void VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual void VisitPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPage pageParam) { }
        public virtual void VisitPseudoArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList pseudoArgumentListParam) { }
        public virtual void VisitPseudoClassSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector pseudoClassSelectorParam) { }
        public virtual void VisitPseudoElementSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoElementSelector pseudoElementSelectorParam) { }
        public virtual void VisitPseudoFunctionSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector pseudoFunctionSelectorParam) { }
        public virtual void VisitRuleset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRuleset rulesetParam) { }
        public virtual void VisitRulesetDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration rulesetDeclarationParam) { }
        public virtual void VisitRulesetDeclarationList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList rulesetDeclarationListParam) { }
        public virtual void VisitSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector selectorParam) { }
        public virtual void VisitSimpleSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector simpleSelectorParam) { }
        public virtual void VisitTypeSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ITypeSelector typeSelectorParam) { }
    }
    public abstract class TreeNodeVisitor<TContext>
    
    {
        public virtual void VisitAdjacentSiblingSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector adjacentSiblingSelectorParam, TContext context) { }
        public virtual void VisitAnimationIdentifierName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationIdentifierName animationIdentifierNameParam, TContext context) { }
        public virtual void VisitAnimationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationName animationNameParam, TContext context) { }
        public virtual void VisitAnimationStringName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationStringName animationStringNameParam, TContext context) { }
        public virtual void VisitAtruleset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtruleset atrulesetParam, TContext context) { }
        public virtual void VisitAtrulesetBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock atrulesetBlockParam, TContext context) { }
        public virtual void VisitAtrulesetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetValue atrulesetValueParam, TContext context) { }
        public virtual void VisitAttributeMatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch attributeMatchParam, TContext context) { }
        public virtual void VisitAttributeName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeName attributeNameParam, TContext context) { }
        public virtual void VisitAttributeSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeSelector attributeSelectorParam, TContext context) { }
        public virtual void VisitCharset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICharset charsetParam, TContext context) { }
        public virtual void VisitChildSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IChildSelector childSelectorParam, TContext context) { }
        public virtual void VisitClassSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IClassSelector classSelectorParam, TContext context) { }
        public virtual void VisitColorProfile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IColorProfile colorProfileParam, TContext context) { }
        public virtual void VisitColorProfileBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock colorProfileBlockParam, TContext context) { }
        public virtual void VisitCssAdditiveExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssAdditiveExpression cssAdditiveExpressionParam, TContext context) { }
        public virtual void VisitCssAlienExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssAlienExpression cssAlienExpressionParam, TContext context) { }
        public virtual void VisitCssArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList cssArgumentListParam, TContext context) { }
        public virtual void VisitCssColorExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression cssColorExpressionParam, TContext context) { }
        public virtual void VisitCssExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssExpression cssExpressionParam, TContext context) { }
        public virtual void VisitCssFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFile cssFileParam, TContext context) { }
        public virtual void VisitCssFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection cssFileSectionParam, TContext context) { }
        public virtual void VisitCssGroupExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssGroupExpression cssGroupExpressionParam, TContext context) { }
        public virtual void VisitCssIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression cssIdentifierExpressionParam, TContext context) { }
        public virtual void VisitCssInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression cssInvocationExpressionParam, TContext context) { }
        public virtual void VisitCssJavaScriptExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssJavaScriptExpression cssJavaScriptExpressionParam, TContext context) { }
        public virtual void VisitCssLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression cssLiteralExpressionParam, TContext context) { }
        public virtual void VisitCssMultiplicativeExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssMultiplicativeExpression cssMultiplicativeExpressionParam, TContext context) { }
        public virtual void VisitCssNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace cssNamespaceParam, TContext context) { }
        public virtual void VisitCssNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix cssNamespacePrefixParam, TContext context) { }
        public virtual void VisitCssPageBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock cssPageBlockParam, TContext context) { }
        public virtual void VisitCssPrimitiveExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPrimitiveExpression cssPrimitiveExpressionParam, TContext context) { }
        public virtual void VisitCssProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssProperty cssPropertyParam, TContext context) { }
        public virtual void VisitCssPropertyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock cssPropertyBlockParam, TContext context) { }
        public virtual void VisitCssPropertyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement cssPropertyStatementParam, TContext context) { }
        public virtual void VisitCssPropertyValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue cssPropertyValueParam, TContext context) { }
        public virtual void VisitCssPropertyValueExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression cssPropertyValueExpressionParam, TContext context) { }
        public virtual void VisitCssStringLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression cssStringLiteralExpressionParam, TContext context) { }
        public virtual void VisitCssTokenExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssTokenExpression cssTokenExpressionParam, TContext context) { }
        public virtual void VisitCssUnaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssUnaryExpression cssUnaryExpressionParam, TContext context) { }
        public virtual void VisitDescendantSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector descendantSelectorParam, TContext context) { }
        public virtual void VisitFontFamily([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamily fontFamilyParam, TContext context) { }
        public virtual void VisitFontFamilyList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList fontFamilyListParam, TContext context) { }
        public virtual void VisitFontFamilyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyName fontFamilyNameParam, TContext context) { }
        public virtual void VisitFontFamilyString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyString fontFamilyStringParam, TContext context) { }
        public virtual void VisitFontFeatureType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType fontFeatureTypeParam, TContext context) { }
        public virtual void VisitFontFeatureTypeBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock fontFeatureTypeBlockParam, TContext context) { }
        public virtual void VisitFontFeatureTypeProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty fontFeatureTypePropertyParam, TContext context) { }
        public virtual void VisitFontFeatureTypePropertyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement fontFeatureTypePropertyStatementParam, TContext context) { }
        public virtual void VisitFontFeatureValues([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues fontFeatureValuesParam, TContext context) { }
        public virtual void VisitFontFeatureValuesBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock fontFeatureValuesBlockParam, TContext context) { }
        public virtual void VisitGeneralSiblingSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector generalSiblingSelectorParam, TContext context) { }
        public virtual void VisitIdSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IIdSelector idSelectorParam, TContext context) { }
        public virtual void VisitImport([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IImport importParam, TContext context) { }
        public virtual void VisitImportant([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IImportant importantParam, TContext context) { }
        public virtual void VisitKeyframes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframes keyframesParam, TContext context) { }
        public virtual void VisitKeyframesBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock keyframesBlockParam, TContext context) { }
        public virtual void VisitKeyframesRule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule keyframesRuleParam, TContext context) { }
        public virtual void VisitKeyframesRuleBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock keyframesRuleBlockParam, TContext context) { }
        public virtual void VisitKeyframesSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelector keyframesSelectorParam, TContext context) { }
        public virtual void VisitKeyframesSelectorList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList keyframesSelectorListParam, TContext context) { }
        public virtual void VisitMedia([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMedia mediaParam, TContext context) { }
        public virtual void VisitMediaBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock mediaBlockParam, TContext context) { }
        public virtual void VisitMediaFeature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature mediaFeatureParam, TContext context) { }
        public virtual void VisitMediaQuery([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery mediaQueryParam, TContext context) { }
        public virtual void VisitMediaQueryList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList mediaQueryListParam, TContext context) { }
        public virtual void VisitMsoNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMsoNamespacePrefix msoNamespacePrefixParam, TContext context) { }
        public virtual void VisitNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix namespacePrefixParam, TContext context) { }
        public virtual void VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual void VisitPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPage pageParam, TContext context) { }
        public virtual void VisitPseudoArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList pseudoArgumentListParam, TContext context) { }
        public virtual void VisitPseudoClassSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector pseudoClassSelectorParam, TContext context) { }
        public virtual void VisitPseudoElementSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoElementSelector pseudoElementSelectorParam, TContext context) { }
        public virtual void VisitPseudoFunctionSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector pseudoFunctionSelectorParam, TContext context) { }
        public virtual void VisitRuleset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRuleset rulesetParam, TContext context) { }
        public virtual void VisitRulesetDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration rulesetDeclarationParam, TContext context) { }
        public virtual void VisitRulesetDeclarationList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList rulesetDeclarationListParam, TContext context) { }
        public virtual void VisitSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector selectorParam, TContext context) { }
        public virtual void VisitSimpleSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector simpleSelectorParam, TContext context) { }
        public virtual void VisitTypeSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ITypeSelector typeSelectorParam, TContext context) { }
    }
    public abstract class TreeNodeVisitor<TContext, TReturn>
    
    
    {
        public virtual TReturn VisitAdjacentSiblingSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAdjacentSiblingSelector adjacentSiblingSelectorParam, TContext context) { }
        public virtual TReturn VisitAnimationIdentifierName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationIdentifierName animationIdentifierNameParam, TContext context) { }
        public virtual TReturn VisitAnimationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationName animationNameParam, TContext context) { }
        public virtual TReturn VisitAnimationStringName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAnimationStringName animationStringNameParam, TContext context) { }
        public virtual TReturn VisitAtruleset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtruleset atrulesetParam, TContext context) { }
        public virtual TReturn VisitAtrulesetBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetBlock atrulesetBlockParam, TContext context) { }
        public virtual TReturn VisitAtrulesetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAtrulesetValue atrulesetValueParam, TContext context) { }
        public virtual TReturn VisitAttributeMatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeMatch attributeMatchParam, TContext context) { }
        public virtual TReturn VisitAttributeName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeName attributeNameParam, TContext context) { }
        public virtual TReturn VisitAttributeSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IAttributeSelector attributeSelectorParam, TContext context) { }
        public virtual TReturn VisitCharset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICharset charsetParam, TContext context) { }
        public virtual TReturn VisitChildSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IChildSelector childSelectorParam, TContext context) { }
        public virtual TReturn VisitClassSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IClassSelector classSelectorParam, TContext context) { }
        public virtual TReturn VisitColorProfile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IColorProfile colorProfileParam, TContext context) { }
        public virtual TReturn VisitColorProfileBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IColorProfileBlock colorProfileBlockParam, TContext context) { }
        public virtual TReturn VisitCssAdditiveExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssAdditiveExpression cssAdditiveExpressionParam, TContext context) { }
        public virtual TReturn VisitCssAlienExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssAlienExpression cssAlienExpressionParam, TContext context) { }
        public virtual TReturn VisitCssArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssArgumentList cssArgumentListParam, TContext context) { }
        public virtual TReturn VisitCssColorExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression cssColorExpressionParam, TContext context) { }
        public virtual TReturn VisitCssExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssExpression cssExpressionParam, TContext context) { }
        public virtual TReturn VisitCssFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFile cssFileParam, TContext context) { }
        public virtual TReturn VisitCssFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection cssFileSectionParam, TContext context) { }
        public virtual TReturn VisitCssGroupExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssGroupExpression cssGroupExpressionParam, TContext context) { }
        public virtual TReturn VisitCssIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssIdentifierExpression cssIdentifierExpressionParam, TContext context) { }
        public virtual TReturn VisitCssInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression cssInvocationExpressionParam, TContext context) { }
        public virtual TReturn VisitCssJavaScriptExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssJavaScriptExpression cssJavaScriptExpressionParam, TContext context) { }
        public virtual TReturn VisitCssLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression cssLiteralExpressionParam, TContext context) { }
        public virtual TReturn VisitCssMultiplicativeExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssMultiplicativeExpression cssMultiplicativeExpressionParam, TContext context) { }
        public virtual TReturn VisitCssNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssNamespace cssNamespaceParam, TContext context) { }
        public virtual TReturn VisitCssNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssNamespacePrefix cssNamespacePrefixParam, TContext context) { }
        public virtual TReturn VisitCssPageBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPageBlock cssPageBlockParam, TContext context) { }
        public virtual TReturn VisitCssPrimitiveExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPrimitiveExpression cssPrimitiveExpressionParam, TContext context) { }
        public virtual TReturn VisitCssProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssProperty cssPropertyParam, TContext context) { }
        public virtual TReturn VisitCssPropertyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyBlock cssPropertyBlockParam, TContext context) { }
        public virtual TReturn VisitCssPropertyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement cssPropertyStatementParam, TContext context) { }
        public virtual TReturn VisitCssPropertyValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValue cssPropertyValueParam, TContext context) { }
        public virtual TReturn VisitCssPropertyValueExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression cssPropertyValueExpressionParam, TContext context) { }
        public virtual TReturn VisitCssStringLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression cssStringLiteralExpressionParam, TContext context) { }
        public virtual TReturn VisitCssTokenExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssTokenExpression cssTokenExpressionParam, TContext context) { }
        public virtual TReturn VisitCssUnaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssUnaryExpression cssUnaryExpressionParam, TContext context) { }
        public virtual TReturn VisitDescendantSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IDescendantSelector descendantSelectorParam, TContext context) { }
        public virtual TReturn VisitFontFamily([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamily fontFamilyParam, TContext context) { }
        public virtual TReturn VisitFontFamilyList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyList fontFamilyListParam, TContext context) { }
        public virtual TReturn VisitFontFamilyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyName fontFamilyNameParam, TContext context) { }
        public virtual TReturn VisitFontFamilyString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFamilyString fontFamilyStringParam, TContext context) { }
        public virtual TReturn VisitFontFeatureType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureType fontFeatureTypeParam, TContext context) { }
        public virtual TReturn VisitFontFeatureTypeBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeBlock fontFeatureTypeBlockParam, TContext context) { }
        public virtual TReturn VisitFontFeatureTypeProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypeProperty fontFeatureTypePropertyParam, TContext context) { }
        public virtual TReturn VisitFontFeatureTypePropertyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureTypePropertyStatement fontFeatureTypePropertyStatementParam, TContext context) { }
        public virtual TReturn VisitFontFeatureValues([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValues fontFeatureValuesParam, TContext context) { }
        public virtual TReturn VisitFontFeatureValuesBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IFontFeatureValuesBlock fontFeatureValuesBlockParam, TContext context) { }
        public virtual TReturn VisitGeneralSiblingSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IGeneralSiblingSelector generalSiblingSelectorParam, TContext context) { }
        public virtual TReturn VisitIdSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IIdSelector idSelectorParam, TContext context) { }
        public virtual TReturn VisitImport([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IImport importParam, TContext context) { }
        public virtual TReturn VisitImportant([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IImportant importantParam, TContext context) { }
        public virtual TReturn VisitKeyframes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframes keyframesParam, TContext context) { }
        public virtual TReturn VisitKeyframesBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesBlock keyframesBlockParam, TContext context) { }
        public virtual TReturn VisitKeyframesRule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRule keyframesRuleParam, TContext context) { }
        public virtual TReturn VisitKeyframesRuleBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesRuleBlock keyframesRuleBlockParam, TContext context) { }
        public virtual TReturn VisitKeyframesSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelector keyframesSelectorParam, TContext context) { }
        public virtual TReturn VisitKeyframesSelectorList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IKeyframesSelectorList keyframesSelectorListParam, TContext context) { }
        public virtual TReturn VisitMedia([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMedia mediaParam, TContext context) { }
        public virtual TReturn VisitMediaBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaBlock mediaBlockParam, TContext context) { }
        public virtual TReturn VisitMediaFeature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature mediaFeatureParam, TContext context) { }
        public virtual TReturn VisitMediaQuery([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaQuery mediaQueryParam, TContext context) { }
        public virtual TReturn VisitMediaQueryList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMediaQueryList mediaQueryListParam, TContext context) { }
        public virtual TReturn VisitMsoNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IMsoNamespacePrefix msoNamespacePrefixParam, TContext context) { }
        public virtual TReturn VisitNamespacePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix namespacePrefixParam, TContext context) { }
        public virtual TReturn VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual TReturn VisitPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPage pageParam, TContext context) { }
        public virtual TReturn VisitPseudoArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoArgumentList pseudoArgumentListParam, TContext context) { }
        public virtual TReturn VisitPseudoClassSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoClassSelector pseudoClassSelectorParam, TContext context) { }
        public virtual TReturn VisitPseudoElementSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoElementSelector pseudoElementSelectorParam, TContext context) { }
        public virtual TReturn VisitPseudoFunctionSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector pseudoFunctionSelectorParam, TContext context) { }
        public virtual TReturn VisitRuleset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRuleset rulesetParam, TContext context) { }
        public virtual TReturn VisitRulesetDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration rulesetDeclarationParam, TContext context) { }
        public virtual TReturn VisitRulesetDeclarationList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclarationList rulesetDeclarationListParam, TContext context) { }
        public virtual TReturn VisitSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISelector selectorParam, TContext context) { }
        public virtual TReturn VisitSimpleSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ISimpleSelector simpleSelectorParam, TContext context) { }
        public virtual TReturn VisitTypeSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ITypeSelector typeSelectorParam, TContext context) { }
    }
    public class static TypeSelectorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Css.Tree.ITypeSelector GetByNamespacePrefix(JetBrains.ReSharper.Psi.Css.Tree.INamespacePrefix param) { }
    }
}
namespace JetBrains.ReSharper.Psi.Css.Tree.References
{
    
    public class CssResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorType
    {
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType ANIMATION_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType CLASS_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType COLOR_PROFILE_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType FUNCTION_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType MEDIA_FEATURE_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType PAGE_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType PROPERTY_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType PSEUDO_CLASS_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType PSEUDO_ELEMENT_NOT_RESOLVED;
        public static JetBrains.ReSharper.Psi.Css.Tree.References.CssResolveErrorType PSEUDO_FUNCTION_NOT_RESOLVED;
        protected CssResolveErrorType(string name) { }
    }
    public interface ICssClassReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ICssInvocationReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ICssMediaFeatureReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ICssPropertyReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ICssPseudoClassReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ICssPseudoFunctionReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
}
namespace JetBrains.ReSharper.Psi.Css.Validation
{
    
    public interface ICompasiteValidationResult : JetBrains.ReSharper.Psi.Css.Validation.IValidationResult
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IValidationResult> Results { get; }
    }
    public interface IFailCompasiteValidationResult : JetBrains.ReSharper.Psi.Css.Validation.ICompasiteValidationResult, JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult, JetBrains.ReSharper.Psi.Css.Validation.IValidationResult { }
    public interface IFailDescription
    {
        sbyte Priority { get; }
        JetBrains.DocumentModel.DocumentRange GetErrorRange();
    }
    public interface IFailValidationResult : JetBrains.ReSharper.Psi.Css.Validation.IValidationResult
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.IFailDescription Description { get; }
    }
    public interface ISuccessCompasiteValidationResult : JetBrains.ReSharper.Psi.Css.Validation.ICompasiteValidationResult, JetBrains.ReSharper.Psi.Css.Validation.IValidationResult { }
    public interface ISuccessValidationResult : JetBrains.ReSharper.Psi.Css.Validation.IValidationResult { }
    public interface IValidationContext
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition Definition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> FirstNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> LastNode { get; }
        bool ContainsNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node);
    }
    public interface IValidationResult
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.IValidationContext Context { get; }
        bool IsSuccess { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> NextNode { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.ICompasiteValidationResult Parent { get; set; }
        void Accept(JetBrains.ReSharper.Psi.Css.Validation.IValidationResultVisitor visitor);
    }
    public interface IValidationResultFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.IFailValidationResult Fail([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IFailDescription description);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.IFailCompasiteValidationResult Fail([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IFailDescription description, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IValidationResult> results);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.IValidationResult Success([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Css.Validation.ICompasiteValidationResult Success([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IValidationContext context, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.LinkedListNode<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nextNode, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Validation.IValidationResult> results);
    }
    public interface IValidationResultVisitor
    {
        void VisitCompasiteValidationResult([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.ICompasiteValidationResult result);
        void VisitValidationResult([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Validation.IValidationResult result);
    }
}