[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.CodeStyle
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class AspVBHtmlCustomFormattingInfoProvider : JetBrains.ReSharper.Psi.Asp.Impl.CodeStyle.IAspCustomFormattingInfoProvider
    {
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Tree.ITreeNode> GetBlockInfo(JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.Generate
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class AspVBCodeBehindGenerator : JetBrains.ReSharper.Psi.Asp.Impl.Generate.AspCodeBehindGenerator
    {
        public const string TRAILING_COMMENT = "\'__RESHARPER__";
        public AspVBCodeBehindGenerator(JetBrains.ReSharper.Psi.VB.VBLanguage language, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator idGenerator) { }
        protected override bool AppendLineInRenderBlock { get; }
        protected override string DelimiterComment { get; }
        protected override string EndOfExpression { get; }
        protected override bool IsCaseSensitive { get; }
        protected override string LeadingComment { get; }
        protected override string TrailerComment { get; }
        protected override string UsingFormatString { get; }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateClassDeclEnd(bool closeNamespace) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateClassDeclStart(string className, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> classNameRange, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingMethodEnd() { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingMethodStart(string name) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingVariable(string name, System.Collections.Generic.IEnumerable<string> fieldNames) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateMethodEnd() { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateNamespaceStart(string namespaceName, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> namespaceNameRange, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateScriptBody(JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag scriptTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateSyntheticMethodStart() { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateUsingDirectives(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Impl.Generate.CodeBehindGeneratorData.NamespaceEntry> namespaces, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.PsiModules.WebApp
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppCommonReferenceProviderFactoryAttribute()]
    public class WebAppVBReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory
    {
        public WebAppVBReferenceProviderFactory(JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.PsiModules.Website.Properties
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspVBProjectFileCustomPsiPropertiesProvider : JetBrains.ReSharper.Psi.IProjectFileCustomPsiPropertiesProvider
    {
        public T GetCustomProperties<T>(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class VBWebsiteAppCodePsiSourceFilePropertiesFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.IWebsiteAppCodePsiSourceFilePropertiesFactory
    {
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class VBWebsiteCodeBehindPsiSourceFilePropertiesFactory : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Properties.IWebsiteCodeBehindPsiSourceFilePropertiesFactory
    {
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class VBWebsiteProjectFileCustomPsiPropertiesProvider : JetBrains.ReSharper.Psi.VB.Impl.VBProjectFileCustomPsiPropertiesProvider
    {
        public override T GetCustomProperties<T>(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.PsiModules.Website.ReferenceProviders
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsiteCommonReferenceProviderFactoryAttribute()]
    public class WebsiteVBReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory
    {
        public WebsiteVBReferenceProviderFactory(JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteVBReferenceProviderHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider
    {
        public WebsiteVBReferenceProviderHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.References
{
    
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspVBGeneratedCodeReferenceProviderFactory : JetBrains.ReSharper.Psi.Asp.Impl.References.AspGeneratedCodeReferenceProviderFactory<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>
    {
        public AspVBGeneratedCodeReferenceProviderFactory(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class AspVBTypeReferenceDecorator : JetBrains.ReSharper.Psi.Asp.Impl.References.IAspTypeReferenceDecorator
    {
        public string TypeArgumentPrefix { get; }
        public string TypeArgumentsCountFormat { get; }
        public string TypeArgumentsPrefix { get; }
        public string TypeArgumentsSuffix { get; }
        public string TypeArgumentSuffix { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class AspVBMethodGroupConvertibleFilterFactory : JetBrains.ReSharper.Psi.Asp.Impl.Resolve.IAspMethodGroupConvertibleFilterFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateMethodGroupConvertibleFilter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode context, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDelegate> eventType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Impl
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WithEventsFieldRecognizer : JetBrains.ReSharper.Psi.VB.Util.IDomainSpecificWithEventsFieldRecongnizer
    {
        public bool IsWithEvents(JetBrains.ReSharper.Psi.IField field) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Naming2
{
    
    [JetBrains.ReSharper.Psi.Naming.Interfaces.NamingConsistencyCheckerAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public sealed class AspVbCodeBehindNamingConsistencyChecker : JetBrains.ReSharper.Psi.Asp.Naming2.AspCodeBehindNamingConsistencyChecker { }
}
namespace JetBrains.ReSharper.Psi.Asp.VB.Utils
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBComplexTypeParserFactory : JetBrains.ReSharper.Psi.Asp.Utils.GenericComplexTypeParserFactory
    {
        public override System.Func<string, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser> CreateParserDelegate(bool isOpenRasta) { }
    }
}