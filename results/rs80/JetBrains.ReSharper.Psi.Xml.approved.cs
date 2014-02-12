[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "XmlNode",
        "XmlFile"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Xml;component/resources/PsiXmlThemedIcons/ThemedIcons.Psi" +
    "Xml.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-xml", "JetBrains.ReSharper.Psi.Xml.Resources")]

namespace JetBrains.ReSharper.Psi.Xml.CodeStyle.FormatSettingsUpgrade
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class XmlFormatSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CodeStyleSettingsUpgrade
    {
        public XmlFormatSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override void DoUpgrade(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.CodeStyle
{
    
    public enum XmlAttributeIndenting
    {
        [System.ComponentModel.DescriptionAttribute("One indent")]
        OneStep = 0,
        [System.ComponentModel.DescriptionAttribute("Two indents")]
        TwoSteps = 1,
        [System.ComponentModel.DescriptionAttribute("Align by first attribute")]
        ByFirstAttr = 2,
    }
    public enum XmlAttributesFormat
    {
        [System.ComponentModel.DescriptionAttribute("On single line")]
        OnSingleLine = 0,
        [System.ComponentModel.DescriptionAttribute("First attribute on single line")]
        FirstAttributeOnSingleLine = 1,
        [System.ComponentModel.DescriptionAttribute("Each attribute on separate lines")]
        OnDifferentLines = 2,
        [System.ComponentModel.DescriptionAttribute("Do not touch")]
        DoNotTouch = 3,
    }
    public class XmlCodeFormattingSettings : JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingSettingsBase<JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey>
    {
        public XmlCodeFormattingSettings(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey settings, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalSettings, JetBrains.ReSharper.Psi.CodeStyle.CommonFormatterSettingsKey commonSettings) { }
    }
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("XML")]
    public class XmlCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeStyleSettings>, System.ICloneable
    {
        public XmlCodeStyleSettings() { }
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatSettingsObsolete FormatSettings { get; set; }
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeStyleSettings Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlDocFormatterPredefinedSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CodeStyle.CodeFormattingSettingsKey), "Code formatting in XML documentation")]
    public class XmlDocFormatterSettingsKey : JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Space after ///")]
        public bool SpaceAtStart;
    }
    public class XmlFormatSettingsObsolete : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatSettingsObsolete>, System.ICloneable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool BlankLineAfterProcessingInstructions;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(2)]
        public int MaxBlankLines;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(2147483647)]
        public int MaxSingleLineTagLength;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool ProcessingInstructionAroundAttributeEq;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting.ByFirstAttr)]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting ProcessingInstructionAttributeIndenting;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat.DoNotTouch)]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat ProcessingInstructionAttributesFormat;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool ProcessingInstructionSpaceAfterLastAttr;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting.ByFirstAttr)]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting TagAttributeIndenting;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat.DoNotTouch)]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat TagAttributesFormat;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool TagSpaceAfterLastAttr;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool TagSpaceBeforeHeaderEnd1;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool TagSpacesAroundAttributeEq;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool WrapBeforeAttr;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool WrapInsideText;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(120)]
        public int WrapLimit;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool WrapLongLines;
        public XmlFormatSettingsObsolete() { }
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatSettingsObsolete Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CodeStyle.CodeFormattingSettingsKey), "Code formatting in XML")]
    public class XmlFormatterSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Blank line after processing instructions")]
        public bool BlankLineAfterProcessingInstructions;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlIndentingStyle.OneIndent, "Indent inside element that doesn\'t contain text")]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlIndentingStyle IndentSubtags;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlIndentingStyle.OneIndent, "Indent inside element that contain text")]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlIndentingStyle IndentTagContent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Keep existing line breaks")]
        public bool KeepUserLineBreaks;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Line breaks after start-tag and before end-tag in multiline elements")]
        public bool LinebreaksInsideMultilineTag;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Line breaks after start-tag and before end-tag in elements that contain other ele" +
            "ments and no text")]
        public bool LinebreaksInsideTagsWithTags;
        [JetBrains.Application.Settings.SettingsEntryAttribute(2, "Maximum blank lines between tags")]
        public int MaxBlankLines;
        [JetBrains.Application.Settings.SettingsEntryAttribute(2147483647, "Line breaks after start-tag and before end-tag when element is longer than")]
        public int MaxSingleLineTagLength;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Place these elements on new line regardless")]
        public string NamesOfTagsAlwaysOnNewLine;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Spaces around \'=\' in attribute")]
        public bool ProcessingInstructionAroundAttributeEq;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting.ByFirstAttr, "Attributes indenting")]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting ProcessingInstructionAttributeIndenting;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat.DoNotTouch, "Attributes format")]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat ProcessingInstructionAttributesFormat;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Space after last attribute")]
        public bool ProcessingInstructionSpaceAfterLastAttr;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Place singleline elements on new line")]
        public bool SimpleTagAlwaysOnNewLine;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Spaces after start-tag and before end-tag otherwise")]
        public bool SpacesInsideSinglelineTag;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Place multiline elements on new line")]
        public bool TagAlwaysOnNewLine;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting.ByFirstAttr, "Attributes indenting")]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributeIndenting TagAttributeIndenting;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat.DoNotTouch, "Attributes format")]
        public JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlAttributesFormat TagAttributesFormat;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Space after last attribute")]
        public bool TagSpaceAfterLastAttr;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Space before \'/>\'")]
        public bool TagSpaceBeforeHeaderEnd1;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Spaces around \'=\' in attribute")]
        public bool TagSpacesAroundAttributeEq;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Wrap tags and processing instructions")]
        public bool WrapBeforeAttr;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Wrap inside text")]
        public bool WrapInsideText;
        [JetBrains.Application.Settings.SettingsEntryAttribute(120, "Right margin (columns)")]
        public int WrapLimit;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Wrap long lines")]
        public bool WrapLongLines;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Wrap before and after elements")]
        public bool WrapOutsideOfElements;
        public XmlFormatterSettingsKey() { }
    }
    public enum XmlIndentingStyle
    {
        [System.ComponentModel.DescriptionAttribute("Do not change indenting")]
        DoNotTouch = 0,
        [System.ComponentModel.DescriptionAttribute("One indent from parent element")]
        OneIndent = 1,
        [System.ComponentModel.DescriptionAttribute("No indent from parent element")]
        ZeroIndent = 2,
        [System.ComponentModel.DescriptionAttribute("No indent at all")]
        RemoveIndent = 3,
    }
}
namespace JetBrains.ReSharper.Psi.Xml
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("DTD")]
    public class DtdLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Xml.DtdLanguage Instance;
        public const string Name = "DTD";
        protected DtdLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected DtdLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    public interface IXmlLanguageSupport
    {
        bool CanConvertAttributeToTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute);
        bool CanConvertTagToAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag);
        bool CanMakeTagEmpty(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag);
        bool CanRemoveAllTags(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove);
        bool CanRemoveTagAndKeepChildren([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove);
        [JetBrains.Annotations.NotNullAttribute()]
        string ConvertAttributeValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, out bool preserveRequired);
        [JetBrains.Annotations.NotNullAttribute()]
        string ConvertTagToValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern);
        [JetBrains.Annotations.NotNullAttribute()]
        string GetAttributeName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag);
        [JetBrains.Annotations.NotNullAttribute()]
        string GetTagName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute);
        bool IsFormattingAllowed(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        bool IsValidTagName([JetBrains.Annotations.NotNullAttribute()] string name);
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("XML")]
    public class XmlLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Xml.XmlLanguage Instance;
        public const string Name = "XML";
        protected XmlLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected XmlLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlLanguageService : JetBrains.ReSharper.Psi.Xml.XmlLanguageServiceBase
    {
        public XmlLanguageService(JetBrains.ReSharper.Psi.Xml.XmlLanguage languageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DeclaredElementPresenter { get; }
        public override bool IsCaseSensitive { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override bool CanContainCachableDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IReferenceContextCodec CreateReferenceContextCodec() { }
        public override JetBrains.ReSharper.Psi.ReferenceAccessType GetReferenceAccessType(JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsTypeMemberVisible(JetBrains.ReSharper.Psi.ITypeMember member) { }
    }
    public abstract class XmlLanguageServiceBase : JetBrains.ReSharper.Psi.LanguageService
    {
        protected readonly JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern myCommonIdentifierIntern;
        protected XmlLanguageServiceBase(JetBrains.ReSharper.Psi.Xml.XmlLanguage xmlLanguage, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public override JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter CodeFormatter { get; }
        public JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory ElementFactory { get; }
        protected JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes TokenTypes { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        protected class XmlParser : JetBrains.ReSharper.Psi.Parsing.IParser
        {
            protected readonly JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory ElementFactory;
            protected readonly JetBrains.ReSharper.Psi.Parsing.ILexer Lexer;
            protected readonly JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern myCommonIdentifierIntern;
            public XmlParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
            public virtual JetBrains.ReSharper.Psi.Tree.IFile ParseFile() { }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlLanguageSupport : JetBrains.ReSharper.Psi.Xml.IXmlLanguageSupport
    {
        public const string XmlSpace = "xml:space";
        public virtual bool CanConvertAttributeToTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public virtual bool CanConvertTagToAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public virtual bool CanMakeTagEmpty(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public virtual bool CanRemoveAllTags(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove) { }
        public virtual bool CanRemoveTagAndKeepChildren(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove) { }
        public virtual string ConvertAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, out bool preserveRequired) { }
        public virtual string ConvertTagToValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        public virtual string GetAttributeName(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.IXmlLanguageSupport GetInstance(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public virtual string GetTagName(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public virtual bool IsFormattingAllowed(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static bool IsSpacePreserved([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public virtual bool IsValidTagName(string name) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.XmlProjectFileType))]
    public class XmlProjectFileLanguageService : JetBrains.ReSharper.Psi.IProjectFileLanguageService
    {
        public XmlProjectFileLanguageService(JetBrains.ProjectModel.XmlProjectFileType xmlProjectFileType) { }
        public virtual JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public virtual JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public virtual JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreprocessorDefines(JetBrains.ProjectModel.IProject project) { }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public virtual JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes GetXmlTokenTypes(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTokenTypesImpl : JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes
    {
        public XmlTokenTypesImpl(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.Parsing.IXmlTokenBuilder xmlTokenBuilder) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Extensions
{
    
    public class static XmlAttributeExtension
    {
        public static string GetUnquotedText(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, out JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public static JetBrains.DocumentModel.DocumentRange GetUnquotedValueRange(this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.Indenting
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class XmlIndentingInfoProvider : JetBrains.ReSharper.Psi.Impl.CodeStyle.IndentingInfoProviderBase<JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormattingContext, JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings>, JetBrains.ReSharper.Psi.Impl.CodeStyle.IIndentingInfoProvider<JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormattingContext, JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings>, JetBrains.ReSharper.Psi.Impl.CodeStyle.IIndentingInfoProviderWithOneSettingsKey<JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormattingContext, JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings, JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey>
    {
        public XmlIndentingInfoProvider(JetBrains.ReSharper.Psi.Impl.CodeStyle.IFormatterDebugInfoLoggersProvider formatterDebugInfoLoggersProvider) { }
        protected override void ModifyAndProcessIndent(JetBrains.ReSharper.Psi.Tree.ITreeNode prevNode, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToIndent, string defaultIndent, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormattingContext context, JetBrains.ReSharper.Psi.Impl.CodeStyle.IIndentingStageCallback<JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings> callback) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle
{
    
    public enum WrapType
    {
        Default = 0,
        Wrap = 1,
        NoWrap = 2,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlCodeFormatter : JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormatterBase
    {
        public XmlCodeFormatter(JetBrains.ReSharper.Psi.Xml.XmlLanguage language, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.Indenting.XmlIndentingInfoProvider indentingInfoProvider) { }
        public JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.Indenting.XmlIndentingInfoProvider IndentingInfoProvider { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        protected virtual JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormattingContext CreateFormattingContext(JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.ReSharper.Psi.Tree.ITreeNode lastNode, JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings formattingSettings, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewLine() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace(string indent, JetBrains.ReSharper.Psi.Tree.ITreeNode replacedSpace) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace() { }
        public override JetBrains.ReSharper.Psi.ITreeRange Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public override void FormatDeletedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Tree.ITreeNode prevNode, JetBrains.ReSharper.Psi.Tree.ITreeNode nextNode) { }
        public override void FormatInsertedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, bool formatSurround) { }
        public override JetBrains.ReSharper.Psi.ITreeRange FormatInsertedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, JetBrains.ReSharper.Psi.ITreeRange origin) { }
        public override void FormatReplacedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode oldNode, JetBrains.ReSharper.Psi.Tree.ITreeNode newNode) { }
        protected virtual JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings GetFormattingSettings(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalFormatSettings) { }
        public override JetBrains.ReSharper.Psi.Tree.ITokenNode GetMinimalSeparator(JetBrains.ReSharper.Psi.Tree.ITokenNode leftToken, JetBrains.ReSharper.Psi.Tree.ITokenNode rightToken) { }
        public virtual bool HasSpacePreservation(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        protected override bool IsFormatNextSpaces(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public override bool IsNewLine(JetBrains.ReSharper.Psi.Tree.ITreeNode ws) { }
        public override bool IsWhitespaceToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    public class XmlCodeFormattingContext : JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext
    {
        public XmlCodeFormattingContext(JetBrains.ReSharper.Psi.Impl.CodeStyle.ICodeFormatterImpl codeFormatter, JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.ReSharper.Psi.Tree.ITreeNode lastNode, JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings formattingSettings, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public System.Collections.Generic.JetHashSet<string> NamesOfTagsAlwaysOnNewLine { get; }
        public JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile Profile { get; }
        public bool HasSpacePreservation(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlDocComments.XmlDocLanguage))]
    public class XmlDocFormatter : JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter
    {
        public XmlDocFormatter(JetBrains.ReSharper.Psi.Xml.XmlLanguage xmlLanguage, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.Indenting.XmlIndentingInfoProvider indentingInfoProvider) { }
        protected override JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings GetFormattingSettings(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalFormatSettings) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings GetGlobalFormatSettings(JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public override bool HasSpacePreservation(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
    }
    public class static XmlDocFormatterImplHelper
    {
        public static void FormatDocComment<TXmlPsi, TCommentNode>(JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentBlockNodeWithPsi<TXmlPsi, TCommentNode> node)
            where TXmlPsi :  class, JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi
            where TCommentNode :  class, JetBrains.ReSharper.Psi.Tree.ICommentNode { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode> GetSelectedDocComments(JetBrains.ReSharper.Psi.Tree.ITreeNode file, JetBrains.DocumentModel.IRangeMarker range) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl
{
    
    public class DtdLexerFactory : JetBrains.ReSharper.Psi.Parsing.XmlLexerFactory
    {
        public DtdLexerFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.XmlLexerGenerated CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.DtdProjectFileType))]
    public class DtdProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public DtdProjectFileLanguageService(JetBrains.ProjectModel.DtdProjectFileType dtdProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
    }
    public class XmlTextOccurenceSearcher : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
    {
        public XmlTextOccurenceSearcher([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public XmlTextOccurenceSearcher([JetBrains.Annotations.NotNullAttribute()] string subject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTextOccurenceSearcherFactory
    {
        public virtual JetBrains.ReSharper.Psi.Xml.Impl.XmlTextOccurenceSearchHelper<TResult> CreateHelper<TResult>(System.Collections.Generic.JetHashSet<string> names, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    public class XmlTextOccurenceSearchHelper<TResult> : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    
    {
        public XmlTextOccurenceSearchHelper(System.Collections.Generic.JetHashSet<string> names, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        protected JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> Consumer { get; }
        protected System.Collections.Generic.JetHashSet<string> Names { get; }
        public bool ProcessingIsFinished { get; }
        protected System.Collections.Generic.Stack<bool> ProcessInterior { get; }
        protected virtual bool DeclarationExists(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken textToken, JetBrains.ReSharper.Psi.TreeTextRange textRange) { }
        protected void FetchTextOccurences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken textToken, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual bool ProcessAttribute(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual bool ReferenceExists(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class XmlTreeVisitor<TContext, TReturn> : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn>
    
    
    {
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode document, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction instruction, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction processingInstruction, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue attribute, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCData cData, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentNode comment, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter footer, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFloatingTextTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentStartTokenNode startToken, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentEndTokenNode endToken, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAsteriskTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttlistStartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCdataEndTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCdataStartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommaTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlDtdStartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlElementStartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlEntityStartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlEqTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFixedTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlImpliedTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlLbracketTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlNotationStartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlOrTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPercentTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPiendTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPistartTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPlusTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlQuestionTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlRbracketTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlRequiredTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEnd1TokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagStart1TokenNode token, TContext context) { }
        public virtual TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagStartTokenNode token, TContext context) { }
        public virtual TReturn VisitAttributeContainer(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer container, TContext context) { }
        public virtual TReturn VisitNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode node, TContext context) { }
        public virtual TReturn VisitTokenNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, TContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.Parsing
{
    
    public class XmlElementFactoryForCreateAttribute : JetBrains.ReSharper.Psi.Xml.Parsing.DelegatingXmlElementFactory
    {
        public XmlElementFactoryForCreateAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    public class XmlElementFactoryForCreateTag : JetBrains.ReSharper.Psi.Xml.Parsing.DelegatingXmlElementFactory
    {
        public XmlElementFactoryForCreateTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTokenBuilder : JetBrains.ReSharper.Psi.Parsing.IXmlTokenBuilder
    {
        public XmlTokenBuilder(JetBrains.ReSharper.Psi.PsiLanguageType xmlLanguage) { }
        public virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase CreateToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.Resolve
{
    
    [System.ObsoleteAttribute("Use SimpleSymbolFilter instead")]
    public class DelegateFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilterWithErrorType
    {
        public DelegateFilter(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution, bool> acceptsDelegate) { }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class XmlResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorTypeWithTooltip
    {
        public static readonly JetBrains.ReSharper.Psi.Xml.Impl.Resolve.XmlResolveErrorType CLASS_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Impl.Resolve.XmlResolveErrorType MULTIPLE_CANDIDATES;
        public static readonly JetBrains.ReSharper.Psi.Xml.Impl.Resolve.XmlResolveErrorType NAMESPACE_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Impl.Resolve.XmlResolveErrorType TYPE_EXPECTED;
        public XmlResolveErrorType(string name, string tooltip) { }
    }
    public class static XmlResolveFilters
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsClass;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNamespace;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNotRootNamespace;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsType;
        public class IsTypeElementConvertibleTo : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsTypeElementConvertibleTo(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType, params JetBrains.ReSharper.Psi.IType[] types) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.Tree
{
    
    public class AnyContent : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IAnyContent, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent
    {
        public AnyContent(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public class EmptyContent : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent, JetBrains.ReSharper.Psi.Xml.Tree.IEmptyContent
    {
        public EmptyContent(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public class GrouppedContent : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent, JetBrains.ReSharper.Psi.Xml.Tree.IGrouppedContent
    {
        public GrouppedContent(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IElementContent> Items { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode LPar { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode RPar { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class IntSubset : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody
    {
        public IntSubset(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlLbracketTokenNode LBracket { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlRbracketTokenNode RBracket { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class ProcessingInstruction : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const short BODY_ROLE = 4;
        public const short END_ROLE = 2;
        public const short NAME_ROLE = 3;
        public const short START_ROLE = 1;
        public ProcessingInstruction(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Body { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken End { get; }
        public string InstructionTarget { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier InstructionTargetNode { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Start { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class PublicExternalId : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IExternalId, JetBrains.ReSharper.Psi.Xml.Tree.IPublicExternalId
    {
        public PublicExternalId(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public class RepetitionContent : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent, JetBrains.ReSharper.Psi.Xml.Tree.IRepetitionContent
    {
        public RepetitionContent(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IElementContent Content { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.RepetitionType RepetitionType { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class ResyncXmlElementFactory : JetBrains.ReSharper.Psi.Xml.Parsing.DelegatingXmlElementFactory
    {
        public ResyncXmlElementFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer xmlTagContainer, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory = null) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader CreateTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    public class ResyncXmlElementFactoryContext : JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext
    {
        public ResyncXmlElementFactoryContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode physicalNode) { }
        public T GetContainingNode<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode currentNode, bool returnCurrent)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetParentTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag currentTag) { }
    }
    public class SimpleContent : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent, JetBrains.ReSharper.Psi.Xml.Tree.ISimpleContent
    {
        public SimpleContent(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public class SystemExternalId : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IExternalId, JetBrains.ReSharper.Psi.Xml.Tree.ISystemExternalId
    {
        public SystemExternalId(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public class XmlAsteriskToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAsteriskTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlAsteriskToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlAttlistStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttlistStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlAttlistStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlAttribute : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const short EQ_ROLE = 1;
        public const short NAME_ROLE = 0;
        public const short UNKNOWN_ROLE = -1;
        public const short VALUE_ROLE = 2;
        public XmlAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public string AttributeName { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Eq { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Identifier { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier NameNode { get; }
        public string UnquotedValue { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue Value { get; }
        public string XmlName { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange XmlNameRange { get; }
        public string XmlNamespace { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange XmlNamespaceRange { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public abstract class XmlAttributeContainer : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const short ATTRIBUTE_ROLE = 4;
        public const short END_ROLE = 2;
        public const short NAME_ROLE = 3;
        public const short START_ROLE = 1;
        protected const short UNKNOWN_ROLE = -1;
        protected XmlAttributeContainer(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> Attributes { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> AttributesEnumerable { get; }
        public virtual string ContainerName { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken EndNode { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Name { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier NameNode { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken StartNode { get; }
        public abstract TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context);
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        protected abstract bool IsEndToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        protected abstract bool IsStartToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
    }
    public class static XmlAttributeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute GetByAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue attributeValue) { }
    }
    public class XmlCData : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCData, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlCData(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Body { get; }
        public string CData { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken End { get; }
        public bool IsOpened { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Start { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class XmlCdataEndToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCdataEndTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlCdataEndToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlCdataStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCdataStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlCdataStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlCommaToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommaTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlCommaToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlComment : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected static short BODY_ROLE;
        protected static short END_ROLE;
        protected static short START_ROLE;
        public XmlComment(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CommentBody { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CommentEnd { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CommentStart { get; }
        public string CommentText { get; }
        public bool IsOpened { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class XmlCommentEndToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentEndTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlCommentEndToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
        public override bool IsFiltered() { }
    }
    public class XmlCommentStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlCommentStartToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
        public override bool IsFiltered() { }
    }
    public abstract class XmlCompositeElement : JetBrains.ReSharper.Psi.Impl.Shared.Tree.CompositeElementWithReferences, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected XmlCompositeElement(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementTypes { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
    }
    public class XmlDtdStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDtdStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlDtdStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlElementStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlElementStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlElementStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlEntityStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlEntityStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlEntityStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlEntityToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlFloatingTextToken, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlEntityTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlEntityToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType, [JetBrains.Annotations.NotNullAttribute()] string text) { }
        public bool IsNumericEntity { get; }
        public string Name { get; }
    }
    public class XmlEqToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlEqTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlEqToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlFile : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.FileElementBase, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const short PI_ROLE = 11;
        public const short TAG_ROLE = 10;
        public const short TEXT_ROLE = 12;
        public XmlFile(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType elementType) { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> InnerTags { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction> ProcessingInstructions { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementTypes { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public TXmlTag AddTagAfter<TXmlTag>(TXmlTag tag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchor)
            where TXmlTag : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public TXmlTag AddTagBefore<TXmlTag>(TXmlTag tag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchor)
            where TXmlTag : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public T FindChildByRole<T>(short childRole, System.Predicate<T> predicate)
            where T :  class { }
        public System.Collections.Generic.IList<T> FindListOfChildrenByRole<T>(short childRole, System.Predicate<T> predicate) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public System.Collections.Generic.IList<T> GetNestedTags<T>(string xpath)
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetTag(System.Predicate<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> predicate) { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<T> GetTags<T>()
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<T> GetTags2<T>()
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public virtual void RemoveTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
    }
    public class XmlFixedToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFixedTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlFixedToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlFloatingTextToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFloatingTextTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlFloatingTextToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType, [JetBrains.Annotations.NotNullAttribute()] string text) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlIdentifier : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlFloatingTextToken, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public static readonly char NAMESPACE_DELIM;
        public XmlIdentifier(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType, string text) { }
        public string XmlName { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange XmlNameRange { get; }
        public string XmlNamespace { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange XmlNamespaceRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
    }
    public class XmlImpliedToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlImpliedTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlImpliedToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlLbracketToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlLbracketTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlLbracketToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlLparenthToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlLparenthToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlNotationStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlNotationStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlNotationStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlOrToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlOrTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlOrToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlPercentToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlPercentTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlPercentToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlPiendToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlPiendTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlPiendToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlPistartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlPistartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlPistartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlPlusToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlPlusTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlPlusToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlProcessingInstruction : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttributeContainer, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlProcessingInstruction(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public override string ContainerName { get; }
        public bool IsOpened { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        protected override bool IsEndToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsStartToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class XmlQuestionToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlQuestionTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlQuestionToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlRbracketToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlRbracketTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlRbracketToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlRequiredToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlRequiredTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlRequiredToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlRparenthToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlRparenthToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlSyntaxErrorElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ErrorElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlSyntaxErrorElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType errorType) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ErrorType { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class XmlTag : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const short FOOTER_ROLE = 2;
        public const short HEADER_ROLE = 1;
        public const short TAG_ROLE = 10;
        public const short TEXT_ROLE = 11;
        public const short UNKNOWN_ROLE = -1;
        public XmlTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter Footer { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter FooterNode { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader Header { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader HeaderNode { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> InnerTags { get; }
        public string InnerText { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken> InnerTextTokens { get; }
        public string InnerValue { get; }
        public JetBrains.ReSharper.Psi.ITreeRange InnerXml { get; }
        public bool IsEmptyTag { get; }
        public bool IsOpened { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public TXmlAttribute AddAttributeAfter<TXmlAttribute>(TXmlAttribute attribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute anchor)
            where TXmlAttribute : JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute { }
        public TXmlAttribute AddAttributeBefore<TXmlAttribute>(TXmlAttribute attribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute anchor)
            where TXmlAttribute : JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute { }
        public TXmlTag AddTagAfter<TXmlTag>(TXmlTag tag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchor)
            where TXmlTag : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public TXmlTag AddTagBefore<TXmlTag>(TXmlTag tag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchor)
            where TXmlTag : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public override JetBrains.ReSharper.Psi.Tree.IChameleonNode FindChameleonWhichCoversRange(JetBrains.ReSharper.Psi.TreeTextRange textRange) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public System.Collections.Generic.IList<T> GetNestedTags<T>(string xpath)
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetTag(System.Predicate<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> predicate) { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<T> GetTags<T>()
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<T> GetTags2<T>()
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public virtual void RemoveAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public void RemoveTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
        public override void SubTreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
    }
    public class static XmlTagContainerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer GetByTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
    }
    public class XmlTagEnd1Token : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEnd1TokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlTagEnd1Token(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlTagEndToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlTagEndToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlTagFooterNode : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const short NAME_ROLE = 3;
        public const short TAG_END_ROLE = 2;
        public const short TAG_START_ROLE = 1;
        public const short UNKNOWN_ROLE = -1;
        public XmlTagFooterNode(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken EndNode { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Name { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken StartNode { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class XmlTagHeaderNode : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttributeContainer, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlTagHeaderNode(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public bool IsClosed { get; }
        public bool IsOpened { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        protected virtual JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        protected override bool IsEndToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsStartToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class static XmlTagNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetByAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetByTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetByTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter footer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetByTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header) { }
    }
    public class XmlTagStart1Token : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagStart1TokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlTagStart1Token(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlTagStartToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTokenBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagStartTokenNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlTagStartToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public class XmlToken : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.BindedToBufferLeafElement, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XmlToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType type, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public virtual TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType GetTokenType() { }
        public override string ToString() { }
    }
    public abstract class XmlTokenBase : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected XmlTokenBase(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public abstract TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context);
        public override System.Text.StringBuilder GetText(System.Text.StringBuilder to) { }
        public override JetBrains.Text.IBuffer GetTextAsBuffer() { }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType GetTokenType() { }
        public override string ToString() { }
    }
    public class XmlValueToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlToken, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlValueToken
    {
        public XmlValueToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType type, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public string UnquotedValue { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange UnquotedValueRange { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlValueToken ValueToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class XmlWhitespaceToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlFloatingTextToken
    {
        public XmlWhitespaceToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenNodeType, [JetBrains.Annotations.NotNullAttribute()] string text) { }
        public override bool IsFiltered() { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.Tree.DTD
{
    
    public class DoctTypeDeclaration : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDocTypeDeclaration
    {
        public DoctTypeDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IExternalId ExternalId { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody IntSubset { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlDtdStartTokenNode Start { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDAttDef : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IAttDef
    {
        public static string[] TYPE_NAMES;
        public DTDAttDef(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IAttType AttributeType { get; }
        public string Name { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDAttListDecl : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDAttListDecl
    {
        public DTDAttListDecl(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IAttDef> AttDefs { get; }
        public string ElementName { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttlistStartTokenNode Start { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDAttType : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IAttType
    {
        public DTDAttType(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.AttType AttType { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode LPar { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode RPar { get; }
        public System.Collections.Generic.IEnumerable<string> Types { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDElementDecl : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDElementDecl
    {
        public DTDElementDecl(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IElementContent ContentSpec { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlElementStartTokenNode Start { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDEntityDecl : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDEntityDecl
    {
        public DTDEntityDecl(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlEntityStartTokenNode Start { get; }
        public string Value { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDFile : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlFile, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody, JetBrains.ReSharper.Psi.Xml.Tree.IDTDFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public DTDFile(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType elementType) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlLbracketTokenNode LBracket { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlRbracketTokenNode RBracket { get; }
    }
    public class DTDNDataDecl : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDNDataDecl
    {
        public DTDNDataDecl(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public string Name { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class DTDNotationDecl : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDNotationDecl
    {
        public DTDNotationDecl(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlNotationStartTokenNode Start { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.Tree.References
{
    
    public abstract class XmlQualifiableReferenceWithToken : JetBrains.ReSharper.Psi.Impl.Shared.References.QualifiableReferenceWithinElement<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
    {
        protected XmlQualifiableReferenceWithToken(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        protected XmlQualifiableReferenceWithToken(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.Refers RefersToDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public abstract class XmlReferenceWithTokenBase<T> : JetBrains.ReSharper.Psi.Impl.Shared.References.ReferenceWithinElementBase<T, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected XmlReferenceWithTokenBase(T owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.Refers RefersToDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Impl.Util
{
    
    public class static ReferenceWithTokenUtil
    {
        public static void AddRestoreTransactionAction(JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken referenceWithToken, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken> oldRange) { }
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken SetText(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange oldRange, string newText, JetBrains.ReSharper.Psi.Tree.ITreeNode elementToDropReferences = null) { }
        public static JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken SetText(JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken reference, string newText) { }
    }
    public class static XmlTagUtil
    {
        public static bool CanBeEmptyTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static void MakeCompound([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static void MakeEmptyTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Parsing
{
    
    public class DefaultXmlElementFactoryContext : JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext
    {
        public static readonly JetBrains.ReSharper.Psi.Xml.Parsing.DefaultXmlElementFactoryContext Instance;
        public T GetContainingNode<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode currentNode, bool returnCurrent)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetParentTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag currentTag) { }
    }
    public class DelegatingXmlElementFactory : JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory
    {
        public DelegatingXmlElementFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory Factory { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementType { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IAnyContent CreateAnyContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IAttDef CreateAttDef() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue CreateAttributeValue(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IAttType CreateAttType() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlCData CreateCData() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment CreateComment() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDocTypeDeclaration CreateDocTypeDeclaration() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDAttListDecl CreateDTDAttListDecl() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDElementDecl CreateDTDElementDecl() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDEntityDecl CreateDTDEntityDecl() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDNotationDecl CreateDTDNotationDecl() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IEmptyContent CreateEmptyContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement CreateError(JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType errorType) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IGrouppedContent CreateGrouppedContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier CreateIdentifier(JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody CreateIntSubset() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDNDataDecl CreateNDataDecl() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction CreatePI() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction CreatePIXml() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IExternalId CreatePublicExternalID() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IRepetitionContent CreateRepetionContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IElementContent CreateSimpleContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IExternalId CreateSystemExternalID() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader CreateTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CreateToken(JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
    }
    public interface IXmlElementFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IAnyContent CreateAnyContent();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IAttDef CreateAttDef();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue CreateAttributeValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, int startOffset, int endOffset);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IAttType CreateAttType();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlCData CreateCData();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment CreateComment();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDocTypeDeclaration CreateDocTypeDeclaration();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDAttListDecl CreateDTDAttListDecl();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDElementDecl CreateDTDElementDecl();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDEntityDecl CreateDTDEntityDecl();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDNotationDecl CreateDTDNotationDecl();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IEmptyContent CreateEmptyContent();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement CreateError(JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType errorType);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IGrouppedContent CreateGrouppedContent();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier CreateIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, int startOffset, int endOffset);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody CreateIntSubset();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDNDataDecl CreateNDataDecl();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction CreatePI();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction CreatePIXml();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IExternalId CreatePublicExternalID();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IRepetitionContent CreateRepetionContent();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IElementContent CreateSimpleContent();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IExternalId CreateSystemExternalID();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader CreateTagHeader([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CreateToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, int startOffset, int endOffset);
    }
    public interface IXmlElementFactoryContext
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        T GetContainingNode<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode currentNode, bool returnCurrent)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode;
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetParentTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag currentTag);
    }
    public class XmlElementFactory
    {
        protected readonly bool ApplyFormatter;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory Factory;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.Modules.IPsiModule Module;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.Xml.IXmlLanguageSupport Support;
        protected XmlElementFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.IXmlLanguageSupport support, bool applyFormatter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttributeForTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] string attributeText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile([JetBrains.Annotations.NotNullAttribute()] string xmlText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateRootAttribute([JetBrains.Annotations.NotNullAttribute()] string attributeText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag([JetBrains.Annotations.NotNullAttribute()] string tagText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTagForTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] string tagText, [JetBrains.Annotations.CanBeNullAttribute()] string rootTagText = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Parsing.XmlElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool applyFormatter = True) { }
    }
    public class XmlElementFactory<TXmlLanguage> : JetBrains.ReSharper.Psi.Xml.Parsing.XmlElementFactory
        where TXmlLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        protected XmlElementFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool applyFormatter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Parsing.XmlElementFactory<TXmlLanguage> GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool applyFormatter = True) { }
    }
    public class static XmlElementFactoryExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttributeRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] string attributeText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFileRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] string xmlText) { }
    }
    public class XmlTreeBuilder
    {
        public XmlTreeBuilder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        protected JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory XmlElementFactory { get; }
        protected JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementTypes { get; }
        protected JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        protected virtual void AppendNewChild(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue child) { }
        protected virtual void AppendNewChild(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment comment) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDFile BuildDTD(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile BuildXml([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile BuildXml(JetBrains.Text.IBuffer buffer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile BuildXml(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        protected virtual void OnTagContainerCreated(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer container) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory
    {
        public XmlTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.XmlLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes elementTypes) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementType { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IAnyContent CreateAnyContent() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IAttDef CreateAttDef() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue CreateAttributeValue(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IAttType CreateAttType() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlCData CreateCData() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment CreateComment() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDocTypeDeclaration CreateDocTypeDeclaration() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDAttListDecl CreateDTDAttListDecl() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDElementDecl CreateDTDElementDecl() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDEntityDecl CreateDTDEntityDecl() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDNotationDecl CreateDTDNotationDecl() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IEmptyContent CreateEmptyContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement CreateError(JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType errorType) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IGrouppedContent CreateGrouppedContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier CreateIdentifier(JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody CreateIntSubset() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IDTDNDataDecl CreateNDataDecl() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction CreatePI() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction CreatePIXml() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IExternalId CreatePublicExternalID() { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IRepetitionContent CreateRepetionContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IElementContent CreateSimpleContent() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IExternalId CreateSystemExternalID() { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader CreateTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CreateToken(JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory GetInstance<TLanguage>()
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Resources
{
    
    public sealed class PsiXmlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xml;component/resources/PsiXmlThemedIcons/ThemedIcons.Psi" +
            "Xml.Generated.Xaml", 1, "XmlFile")]
        public sealed class XmlFile : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xml;component/resources/PsiXmlThemedIcons/ThemedIcons.Psi" +
            "Xml.Generated.Xaml", 0, "XmlNode")]
        public sealed class XmlNode : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Tree
{
    
    public enum AttType
    {
        CDATA = 0,
        ID = 1,
        IDREF = 2,
        IDREFS = 3,
        ENTITY = 4,
        ENTITIES = 5,
        NMTOKEN = 6,
        NMTOKENS = 7,
        NOTATION = 8,
        ENUMERATION = 9,
        UNKNOWN = 10,
    }
    public enum GroupType
    {
        SEQUENCE = 0,
        CHOICE = 1,
    }
    public interface IAnyContent : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent { }
    public interface IAttDef : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IAttType AttributeType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
    }
    public interface IAttType : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Xml.Tree.AttType AttType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode LPar { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode RPar { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> Types { get; }
    }
    public interface IDocTypeDeclaration : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IExternalId ExternalId { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody IntSubset { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlDtdStartTokenNode Start { get; }
    }
    public interface IDTDAttListDecl : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IAttDef> AttDefs { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ElementName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttlistStartTokenNode Start { get; }
    }
    public interface IDTDBody : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlLbracketTokenNode LBracket { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlRbracketTokenNode RBracket { get; }
    }
    public interface IDTDElementDecl : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IElementContent ContentSpec { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlElementStartTokenNode Start { get; }
    }
    public interface IDTDEntityDecl : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlEntityStartTokenNode Start { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Value { get; }
    }
    public interface IDTDFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IDTDBody, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IDTDNDataDecl : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
    }
    public interface IDTDNotationDecl : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlNotationStartTokenNode Start { get; }
    }
    public interface IElementContent : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IEmptyContent : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent { }
    public interface IExternalId : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IGrouppedContent : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IElementContent> Items { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode LPar { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode RPar { get; }
    }
    public interface IProcessingInstruction : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Body { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string InstructionTarget { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier InstructionTargetNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Start { get; }
    }
    public interface IPublicExternalId : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IExternalId { }
    public interface IRepetitionContent : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IElementContent Content { get; }
        JetBrains.ReSharper.Psi.Xml.Tree.RepetitionType RepetitionType { get; }
    }
    public interface ISimpleContent : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IElementContent { }
    public interface ISystemExternalId : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IExternalId { }
    public interface IXmlAsteriskTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlAttlistStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string AttributeName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Eq { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Identifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use Identifier property instead")]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier NameNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string UnquotedValue { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue Value { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string XmlName { get; }
        JetBrains.ReSharper.Psi.TreeTextRange XmlNameRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string XmlNamespace { get; }
        JetBrains.ReSharper.Psi.TreeTextRange XmlNamespaceRange { get; }
    }
    public interface IXmlAttributeContainer : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> Attributes { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> AttributesEnumerable { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ContainerName { get; }
    }
    public interface IXmlAttributeValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string UnquotedValue { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlValueToken ValueToken { get; }
    }
    public interface IXmlCData : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Body { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string CData { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken End { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Start { get; }
    }
    public interface IXmlCdataEndTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlCdataStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlCommaTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlComment : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlCommentEndTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlCommentNode : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CommentBody { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CommentEnd { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken CommentStart { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string CommentText { get; }
    }
    public interface IXmlCommentStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlDocumentNode : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlDtdStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlElementStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlEntityStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlEntityTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        bool IsNumericEntity { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Name { get; }
    }
    public interface IXmlEqTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction> ProcessingInstructions { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementTypes { get; }
    }
    public interface IXmlFixedTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlFloatingTextTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlIdentifier : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string XmlName { get; }
        JetBrains.ReSharper.Psi.TreeTextRange XmlNameRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string XmlNamespace { get; }
        JetBrains.ReSharper.Psi.TreeTextRange XmlNamespaceRange { get; }
    }
    public interface IXmlImpliedTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlLbracketTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlLparenthTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlNotationStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlOrTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlPercentTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlPiendTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlPistartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlPlusTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlProcessingInstruction : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken EndNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken StartNode { get; }
    }
    public interface IXmlQuestionTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlRbracketTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlRequiredTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlRparenthTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlSyntaxErrorElement : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        string ErrorDescription { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ErrorType { get; }
    }
    public interface IXmlTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter Footer { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Use Footer property instead")]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter FooterNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader Header { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use Header property instead")]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader HeaderNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string InnerText { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken> InnerTextTokens { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string InnerValue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ITreeRange InnerXml { get; }
        bool IsEmptyTag { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        TXmlAttribute AddAttributeAfter<TXmlAttribute>([JetBrains.Annotations.NotNullAttribute()] TXmlAttribute attribute, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute anchor)
            where TXmlAttribute : JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute;
        [JetBrains.Annotations.NotNullAttribute()]
        TXmlAttribute AddAttributeBefore<TXmlAttribute>([JetBrains.Annotations.NotNullAttribute()] TXmlAttribute attribute, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute anchor)
            where TXmlAttribute : JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute;
        void RemoveAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute);
    }
    public interface IXmlTagContainer : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> InnerTags { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        TXmlTag AddTagAfter<TXmlTag>([JetBrains.Annotations.NotNullAttribute()] TXmlTag tag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchor)
            where TXmlTag : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag;
        [JetBrains.Annotations.NotNullAttribute()]
        TXmlTag AddTagBefore<TXmlTag>([JetBrains.Annotations.NotNullAttribute()] TXmlTag tag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchor)
            where TXmlTag : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag;
        System.Collections.Generic.IList<T> GetNestedTags<T>(string xpath)
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag;
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetTag([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> predicate);
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<T> GetTags<T>()
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag;
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<T> GetTags2<T>()
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag;
        void RemoveTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag);
    }
    public interface IXmlTagEnd1TokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlTagEndTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlTagFooter : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken EndNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken StartNode { get; }
    }
    public interface IXmlTagHeader : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken EndNode { get; }
        bool IsClosed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use Name property instead")]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier NameNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken StartNode { get; }
    }
    public interface IXmlTagStart1TokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlTagStartTokenNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlToken : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType GetTokenType();
    }
    public interface IXmlTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context);
    }
    public interface IXmlTreeVisitor<TContext, TReturn>
    
    
    {
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode document, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IProcessingInstruction instruction, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction processingInstruction, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue attribute, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCData cData, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentNode comment, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter footer, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFloatingTextTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentStartTokenNode startToken, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommentEndTokenNode endToken, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAsteriskTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttlistStartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCdataEndTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCdataStartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlCommaTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlDtdStartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlElementStartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlEntityStartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlEqTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFixedTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlImpliedTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlLbracketTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlLparenthTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlNotationStartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlOrTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPercentTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPiendTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPistartTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlPlusTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlQuestionTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlRbracketTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlRequiredTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlRparenthTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEnd1TokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagEndTokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagStart1TokenNode token, TContext context);
        TReturn Visit(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagStartTokenNode token, TContext context);
        TReturn VisitTokenNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, TContext context);
    }
    public interface IXmlValueToken : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string UnquotedValue { get; }
        JetBrains.ReSharper.Psi.TreeTextRange UnquotedValueRange { get; }
    }
    public enum RepetitionType
    {
        ZERO_OR_ONE = 0,
        ONE_OR_MORE = 1,
        ANY = 2,
        UNKNOWN = 3,
    }
    public class static XmlAttributeContainerExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TAttribute GetAttribute<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer container)
            where TAttribute :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer container, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> predicate) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer container, [JetBrains.Annotations.NotNullAttribute()] string fullName) { }
    }
    public class static XmlAttributeExtensions
    {
        public static void Remove([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute) { }
    }
    public abstract class XmlCompositeNodeType : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType
    {
        protected XmlCompositeNodeType([JetBrains.Annotations.NotNullAttribute()] string s, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes elementTypes, int index) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes XmlElementTypes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlElementTypes
    {
        public XmlElementTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ANY_CONTENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CDATA { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType COMMENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DOCTYPE { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_ATTDEF { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_ATTLIST { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_ATTTYPE { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_ELEMENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_ENTITY { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_FILE { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_NDATA { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DTD_NOTATION { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType EMPTY_CONTENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType FILE { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType GROUPPED_CONTENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType INT_SUBSET { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PI { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PI_XML { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PUBLIC_EXT_ID { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REPETITION_CONTENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SIMPLE_CONTENT { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SYNTAX_ERROR { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SYSTEM_EXT_ID { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TAG { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TAG_FOOTER { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TAG_HEADER { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XML_DOC_HOLDER { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public static TElementTypes GetInstance<TElementTypes>(JetBrains.ReSharper.Psi.PsiLanguageType languageType)
            where TElementTypes : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes { }
    }
    public class XmlSyntaxErrorType : JetBrains.Util.EnumPattern
    {
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_DEFAULT_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_DEFAULT_VALUE_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_EQ_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_NAME_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_TYPE_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ATTRIBUTE_VALUE_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType CDATA_CLOSING_SYMBOL_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType COMMA_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType COMMENT_END_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ELEMENT_CONTENT_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType ENTITY_VALUE_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType IDENTIFIER_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType INVALID_TAG_FOOTER;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType INVALID_TAG_HEADER;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType NO_OPEN_TAG_FOUND;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType OR_COMMA_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType OR_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PI_CLOSING_SYMBOL_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PUBLIC_SYSTEM_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType RBRACKET_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType RPARENTH_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType TAG_FOOTER_CLOSING_SYMBOL_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType TAG_HEADER_CLOSING_SYMBOL_EXPECTED;
        public static JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType UNEXPECTED_TOKEN;
        protected XmlSyntaxErrorType(string description) { }
        public class SymbolsExpected : JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType
        {
            public readonly string[] ExpectedSymbols;
            public SymbolsExpected(params string[] expectedSymbols) { }
        }
    }
    public class static XmlTagExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> predicate) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag, [JetBrains.Annotations.NotNullAttribute()] string fullName) { }
        public static JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> GetAttributes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static string GetFullTagName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier GetName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier GetNameNode([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static string GetTagName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static string GetTagNamespace([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static void Remove([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.Tree.References
{
    
    public interface IReferenceWithToken : JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder { }
    public interface IXmlCompleteableReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder { }
    public interface IXmlReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IXmlSmartCompleteableReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSmartCompletionSymbolTable();
    }
    public interface IXmlTypeNameCompleteableReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder { }
}
namespace JetBrains.ReSharper.Psi.Xml.Util
{
    
    public class static ModuleQualificationUtil
    {
        public static string GetModuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public static string GetModuleQualification(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public static string GetTypeName(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetTypeNameCompletionRange(string text, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        public static JetBrains.Util.TextRange GetTypeNameFullRange(string text, int offset) { }
        public static bool IsIdentifierChar(char c) { }
        public static bool IsTypeNameChar(char c) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeElement> ResolveType(string clrName, JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool caseSensitive, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
    public class static XmlAttributeUtil
    {
        public static void SetValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, string unquotedValue) { }
        public static JetBrains.DocumentModel.DocumentRange UnquotedValueDocumentRange(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange UnquotedValueRange(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
    }
    public class static XmlReferenceUtil
    {
        public static TReference FindReferenceRecursively<TReference>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement element, System.Predicate<TReference> predicate)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
    }
    public class static XPathUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<T> GetNestedTags<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer container, [JetBrains.Annotations.NotNullAttribute()] string xpath)
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
    }
}
namespace JetBrains.ReSharper.Psi.Xml.XmlDocComments
{
    
    public abstract class ClrDocCommentElementFactoryImpl : JetBrains.ReSharper.Psi.Xml.XmlDocComments.DocCommentElementFactory
    {
        protected ClrDocCommentElementFactoryImpl(JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi xmlPsi) { }
        protected abstract JetBrains.Util.Key<object> XmlResolveKey { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateException(JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.XmlDocComments.DecodeInfo> DecodeCRefs([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer file) { }
    }
    public abstract class ClrDocCommentXmlPsi<TTreeNode> : JetBrains.ReSharper.Psi.Xml.XmlDocComments.DocCommentXmlPsiBase<TTreeNode>
        where TTreeNode :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected ClrDocCommentXmlPsi(JetBrains.ReSharper.Psi.Xml.XmlDocComments.InjectedPsiHolderNode docCommentsHolder, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, bool isShifted, TTreeNode docCommentBlock) { }
        protected void BindReferences<TReference>(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.XmlDocComments.DecodeInfo> infos)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        protected static void BuildXmlPsi(JetBrains.ReSharper.Psi.Xml.XmlLanguage docCommentLanguage, JetBrains.ReSharper.Psi.Tree.ITreeNode block, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ICommentNode> allDocCommentNodes, out JetBrains.ReSharper.Psi.Xml.XmlDocComments.InjectedPsiHolderNode holderNode, out JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlPsiFile, out bool isShifted) { }
    }
    public struct DecodeInfo
    {
        public readonly object ResolveInfo;
        public JetBrains.ReSharper.Psi.TreeOffset StartOffsetInXmlTree;
        public DecodeInfo(JetBrains.ReSharper.Psi.TreeOffset startOffsetInXmlTree, object resolveInfo) { }
    }
    public class DocCommentElementFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.Xml.Parsing.XmlElementFactory Factory;
        protected DocCommentElementFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi xmlPsi) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateParameterNode([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string innerText) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateReturnNode([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(string text) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTypeParameterNode([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string innerText) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateValueNode([JetBrains.Annotations.NotNullAttribute()] string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.XmlDocComments.DocCommentElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi docCommentXmlPsi) { }
    }
    public abstract class DocCommentXmlPsiBase<TTreeNode> : JetBrains.ReSharper.Psi.Files.ISecondaryRangeTranslator, JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi
        where TTreeNode :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected int myBulkChangesCount;
        protected DocCommentXmlPsiBase(JetBrains.ReSharper.Psi.Xml.XmlDocComments.InjectedPsiHolderNode docCommentsHolder, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, bool isShifted, TTreeNode docCommentBlock) { }
        public TTreeNode DocCommentBlock { get; }
        protected abstract string DocCommentStartText { get; }
        public bool IsInChange { get; set; }
        public bool IsShifted { get; }
        public JetBrains.ReSharper.Psi.Tree.IFile OriginalFile { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile XmlFile { get; set; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddExceptionNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddParameterNodeAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddParameterNodeBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReturnsNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReturnsNodeAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReturnsNodeBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddSummaryNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddTopLevelTagWithNameAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag, string name) { }
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddTopLevelTagWithNameBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag, string name) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddTypeParameterNodeAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddTypeParameterNodeBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddValueNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddValueNodeAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddValueNodeBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        protected abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> DocCommentNodes();
        public string Dump(JetBrains.ReSharper.Psi.Tree.IFile generatedFile) { }
        public TElement FindNodeAt<TElement>(int offset)
            where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.TreeTextRange GeneratedToOriginal(JetBrains.ReSharper.Psi.TreeTextRange generatedRange) { }
        public System.IDisposable GetBulkModificationCookie() { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.TreeTextRange> GetCoveringRange(JetBrains.ReSharper.Psi.TreeTextRange originalRange) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference GetCrefReference(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetExceptionNodes() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TreeTextRange> GetIntersectedOriginalRanges(JetBrains.ReSharper.Psi.TreeTextRange generatedRange) { }
        protected static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.TreeOffset, string>> GetLines(string text) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetParameterNodes(string name) { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetReturnNodes() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetTypeParameterNodes(string name) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetValueNodes() { }
        public void Invalidate() { }
        protected virtual void InvalidateCachedData() { }
        protected virtual System.Collections.Generic.IList<string> OrderedDocCommentTags() { }
        public JetBrains.ReSharper.Psi.TreeTextRange OriginalToGenerated(JetBrains.ReSharper.Psi.TreeTextRange originalRange) { }
        public void RemoveTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag node) { }
        public abstract void SubTreeChanged();
        protected JetBrains.ReSharper.Psi.TreeOffset ToDocComment(JetBrains.ReSharper.Psi.TreeOffset offset, out int index) { }
        protected void UpdateIsShifted() { }
    }
    public interface IDocCommentBlockNodeWithPsi<TXmlPsi, TCommentNode> : JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TXmlPsi :  class, JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi
        where TCommentNode :  class, JetBrains.ReSharper.Psi.Tree.ICommentNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<TCommentNode> DocComments { get; }
        TCommentNode AddDocCommentAfter(TCommentNode nodeToAdd, TCommentNode anchor);
        TCommentNode AddDocCommentBefore(TCommentNode nodeToAdd, TCommentNode anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        TXmlPsi GetXmlPsi();
        void RemoveDocComment([JetBrains.Annotations.NotNullAttribute()] TCommentNode docCommentNode);
    }
    public interface IDocCommentXmlPsi
    {
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile XmlFile { get; set; }
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddExceptionNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddParameterNodeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddParameterNodeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReturnsNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReturnsNodeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReturnsNodeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddSummaryNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddTypeParameterNodeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddTypeParameterNodeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddValueNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddValueNodeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddValueNodeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag);
        [JetBrains.Annotations.NotNullAttribute()]
        TNode FindNodeAt<TNode>(int offset)
            where TNode :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable GetBulkModificationCookie();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference GetCrefReference(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag node);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetExceptionNodes();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetParameterNodes([JetBrains.Annotations.CanBeNullAttribute()] string name);
        JetBrains.ReSharper.Psi.IPsiServices GetPsiServices();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetReturnNodes();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetTypeParameterNodes([JetBrains.Annotations.CanBeNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> GetValueNodes();
        void RemoveTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag node);
        void SubTreeChanged();
    }
    public class InjectedPsiHolderNode : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Impl.INodeUserDataHolderOwner, JetBrains.ReSharper.Psi.Impl.IResolveIsolationScope, JetBrains.ReSharper.Psi.ISandBox, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ContextNode { get; }
        public JetBrains.ReSharper.Psi.SandBoxContextType ContextType { get; }
        public JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentXmlPsi DocCommentXmlPsi { set; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public int LevelDelta { get; }
        public System.Nullable<int> ModificationStamp { get; set; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Impl.NodeUserDataHolder NodeUserDataHolder { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public static JetBrains.ReSharper.Psi.Xml.XmlDocComments.InjectedPsiHolderNode CreateHolderFor(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule GetPsiModule() { }
        public override JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public override bool IsValid() { }
        public override void SubTreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("XMLDOC")]
    public class XmlDocLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Xml.XmlDocComments.XmlDocLanguage Instance;
        public const string Name = "XMLDOC";
        protected XmlDocLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
}