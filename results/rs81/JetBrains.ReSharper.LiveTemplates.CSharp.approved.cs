[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor C# Keyword", "{47f6aff9-3c94-4a67-a11c-1c997e27aae5}", DarkForegroundColor="LightSkyBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor C# Preprocessor Directive", "{866fb44e-b4c6-40a8-8ea9-a010b14a8b6b}", DarkForegroundColor="LightGreen", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Green", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor C# Comment", "{95076b03-9a52-41ff-9f47-5d2f1d0516a6}", DarkForegroundColor="LightGreen", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Green", Layer=2000, VSPriority=40)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeCS"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates.CSharp;component/resources/LiveTemplatesCSharp/" +
    "ThemedIcons.LiveTemplatesCSharp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates-csharp", "JetBrains.ReSharper.LiveTemplates.CSharp.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.CSharp.Context
{
    
    public class CSharpContextOptions : JetBrains.UI.CommonControls.SafeUserControl
    {
        public CSharpContextOptions(JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.LiveTemplates.CSharp.Context.CSharpInsertionPoint InsertionPoint { get; set; }
        public System.Version MinimumLanguageVersion { get; set; }
        public bool Valid { get; }
        public event System.EventHandler ValidChanged;
        protected override void Dispose(bool disposing) { }
    }
    [System.FlagsAttribute()]
    public enum CSharpInsertionPoint
    {
        Everywhere = 1,
        Expression = 2,
        Statement = 4,
        TypeMember = 8,
        TypeAndNamespace = 16,
        QueryClause = 32,
    }
    public class CSharpTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public CSharpTemplateContext(JetBrains.ReSharper.LiveTemplates.CSharp.Context.CSharpInsertionPoint insertionContext) { }
        public CSharpTemplateContext(JetBrains.ReSharper.LiveTemplates.CSharp.Context.CSharpInsertionPoint insertionContext, [JetBrains.Annotations.NotNullAttribute()] System.Version minimumLanguageVersion) { }
        public JetBrains.ReSharper.LiveTemplates.CSharp.Context.CSharpInsertionPoint InsertionPoint { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Version MinimumLanguageVersion { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public static JetBrains.ReSharper.LiveTemplates.CSharp.Context.CSharpTemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public sealed class CSharpTemplateContextAcceptor : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopedTemplateAcceptorBase
    {
        public CSharpTemplateContextAcceptor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CSharpTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class InCSharpExpression : JetBrains.ReSharper.LiveTemplates.CSharp.Context.InCSharpFile
    {
        public InCSharpExpression(System.Version minimumLanguageVersion = null) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.CSharp.Context.InCSharpFile NewInstance(System.Version version) { }
        public override string ToString() { }
    }
    public class InCSharpFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public const string MinimumLanguageVersionAttributeName = "minimumLanguageVersion";
        public InCSharpFile(System.Version minimumLanguageVersion = null) { }
        public string LangDescr { get; }
        public System.Version MinimumLanguageVersion { get; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties() { }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
        public virtual JetBrains.ReSharper.LiveTemplates.CSharp.Context.InCSharpFile NewInstance(System.Version version) { }
        public override string ToString() { }
        public override System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
    public class InCSharpStatement : JetBrains.ReSharper.LiveTemplates.CSharp.Context.InCSharpExpression
    {
        public InCSharpStatement(System.Version minimumLanguageVersion = null) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.CSharp.Context.InCSharpFile NewInstance(System.Version version) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.CSharp.Hotspots
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpHotspotService : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotService
    {
        public void AcceptSessionDocument(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession hotspotSession, JetBrains.DocumentModel.IDocument document) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.CSharp.Macros
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("castToLeftSideType", LongDescription="Inserts (if required) cast to the type which is expected at the left side of assi" +
        "gnment expression.", ShortDescription="Cast to the required type (if the cast is necessary)")]
    public class CastToLeftSideTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.CSharp.Macros.CastToLeftSideTypeMacroDef))]
    public class CastToLeftSideTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMacroUtil : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroUtilBase
    {
        public CSharpMacroUtil(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage language, JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement AsDeclaredElement(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeOwner> element, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement CreateVariableDeclaredElement(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetElementTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> GetExpectedTypes(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetKeyTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetValueTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        public override void SortNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, System.Collections.Generic.List<string> names) { }
        protected override System.Collections.Generic.IList<string> SuggestNamesForIdentifier(JetBrains.ReSharper.Psi.Tree.IIdentifier treeNode) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> SuggestVariableTypes(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("fileheader", LongDescription="Inserts the file header specified in the ReSharper options.", ShortDescription="File header")]
    public class FileHeaderMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public FileHeaderMacroDef(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.FileHeaderUtils fileHeaderUtils) { }
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.CSharp.Macros.FileHeaderMacroDef), IsExpandAndSkip=true)]
    public class FileHeaderMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public FileHeaderMacroImpl(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.FileHeaderUtils fileHeaderUtils) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override bool HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.CSharp.Resources
{
    
    public sealed class LiveTemplatesCSharpThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.CSharp;component/resources/LiveTemplatesCSharp/" +
            "ThemedIcons.LiveTemplatesCSharp.Generated.Xaml", 0, "ScopeCS")]
        public sealed class ScopeCS : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.CSharp.Scope
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=90D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class CSharpProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public CSharpProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CSharpProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public CSharpProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=90D)]
    public class CSharpScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public CSharpScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase CreateUI(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public override bool HaveOptionsUIFor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    public class CSharpScopeConfig : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase, System.Windows.Markup.IComponentConnector
    {
        public CSharpScopeConfig(JetBrains.ReSharper.LiveTemplates.CSharp.Context.InCSharpFile csPoint) { }
        public override void Done() { }
        public void InitializeComponent() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CSharpScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public CSharpScopeProvider() { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext tacContext) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml(System.Xml.XmlElement scopeElement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpTemplateHighlighterProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateHighlightingProvider
    {
        public const string CommentAttribute = "ReSharper Template Editor C# Comment";
        public const string KeywordAttribute = "ReSharper Template Editor C# Keyword";
        public const string PreprocessorAttribute = "ReSharper Template Editor C# Preprocessor Directive";
        public override string GetHighlightingAttributeId(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public class InCSharpProjectFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InLanguageSpecificProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public InCSharpProjectFile() { }
        public override string DefaultFileName { get; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.CSharp.TemplateBuilder
{
    
    public class VariableDeclarationFieldEvaluator : JetBrains.ReSharper.LiveTemplates.TemplateBuilder.FieldEvaluatorBase
    {
        public VariableDeclarationFieldEvaluator(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.CollectedFields context) { }
        public override void ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}