[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.LiveTemplates.VB.Context
{
    
    public class InVBExpression : JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile
    {
        public InVBExpression() { }
        public InVBExpression(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile NewInstance(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string ToString() { }
    }
    public class InVBFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint
    {
        public const string LanguageLevelAttributeName = "languageLevel";
        public InVBFile() { }
        public InVBFile(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        protected string LangDescr { get; }
        public JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel LanguageLevel { get; set; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties() { }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public virtual JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile NewInstance(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string ToString() { }
        public override System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
    public class InVBMethodParameter : JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile
    {
        public InVBMethodParameter() { }
        public InVBMethodParameter(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile NewInstance(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string ToString() { }
    }
    public class InVBStatement : JetBrains.ReSharper.LiveTemplates.VB.Context.InVBExpression
    {
        public InVBStatement() { }
        public InVBStatement(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile NewInstance(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string ToString() { }
    }
    public class InVBTypeAndNamespace : JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile
    {
        public InVBTypeAndNamespace() { }
        public InVBTypeAndNamespace(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile NewInstance(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string ToString() { }
    }
    public class InVBTypeMember : JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile
    {
        public InVBTypeMember() { }
        public InVBTypeMember(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile NewInstance(JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel langLevel) { }
        public override string ToString() { }
    }
    public enum VBInsertionPoint
    {
        Everywhere = 1,
        Expression = 2,
        Statement = 4,
        TypeMember = 8,
        TypeAndNamespace = 16,
        MethodParameter = 32,
    }
    public class VBTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public VBTemplateContext(JetBrains.ReSharper.LiveTemplates.VB.Context.VBInsertionPoint insertionPoint) { }
        public VBTemplateContext(JetBrains.ReSharper.LiveTemplates.VB.Context.VBInsertionPoint insertionPoint, JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel languageLevel) { }
        public JetBrains.ReSharper.LiveTemplates.VB.Context.VBInsertionPoint InsertionPoint { get; }
        public JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel LanguageLevel { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public static JetBrains.ReSharper.LiveTemplates.VB.Context.VBTemplateContext ReadFromXml(System.Xml.XmlElement element) { }
        public System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
    public class VBTemplateContextAcceptor : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopedTemplateAcceptorBase
    {
        public VBTemplateContextAcceptor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VBTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.VB.Scope
{
    
    public class InVBProjectFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InLanguageSpecificProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint
    {
        public InVBProjectFile() { }
        public override string DefaultFileName { get; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=80D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class VBProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public VBProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VBProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public VBProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=80D)]
    public class VBScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public VBScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase CreateUI(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public override bool HaveOptionsUIFor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute()]
    public class VBScopeConfig : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase, System.Windows.Markup.IComponentConnector
    {
        public VBScopeConfig(JetBrains.ReSharper.LiveTemplates.VB.Context.InVBFile point) { }
        public override void Done() { }
        public void InitializeComponent() { }
        public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VBScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public VBScopeProvider() { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml(System.Xml.XmlElement scopeElement) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.VB
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLanguageCaseProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LanguageCaseProvider
    {
        public override bool IsCaseSensitive() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class VBLiveTemplatesSupport : JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport
    {
        public string Name { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public bool Accepts(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMacroUtil : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroUtilBase
    {
        public VBMacroUtil(JetBrains.ReSharper.Psi.VB.VBLanguage language, JetBrains.ReSharper.Psi.VB.ExpectedTypes.IVBExpectedTypesProvider expectedTypesProvider) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement AsDeclaredElement(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeOwner> element, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement CreateVariableDeclaredElement(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext macroContext) { }
        public override string GetDefaultNamespace(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> GetExpectedTypes(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SortNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, System.Collections.Generic.List<string> names) { }
        protected override System.Collections.Generic.IList<string> SuggestNamesForIdentifier(JetBrains.ReSharper.Psi.Tree.IIdentifier treeNode) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBTemplateFormatter : JetBrains.ReSharper.Feature.Services.LiveTemplates.Formatting.ITemplateFormatter
    {
        public bool SupportsShorteningQualifiedReferences { get; }
        public void BeforeFormatting(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution) { }
        public void ShortenQualifiedReferences(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution) { }
    }
}