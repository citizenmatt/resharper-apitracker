[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Web.VB.Impl.Languages
{
    
    [JetBrains.ReSharper.Psi.Web.Languages.WebCodeBehindLanguageSupportAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCodeBehindLanguageSupport : JetBrains.ReSharper.Psi.Web.Languages.IWebCodeBehindLanguageSupport
    {
        public VBCodeBehindLanguageSupport(JetBrains.ReSharper.Psi.VB.VBLanguage language) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType CodeBehindLanguage { get; }
        public bool IsCaseSensitive { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Web.VB.Impl.PsiModules
{
    
    public class MicrosoftVisualBasicAssemblyCookie : System.IDisposable
    {
        public MicrosoftVisualBasicAssemblyCookie(JetBrains.ProjectModel.IProject owner, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferencesResolveStore myReferencesResolveStore) { }
        public void Dispose() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IPsiModuleReference GetReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, bool fromProject) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IPsiModuleReference ToPsiModuleReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules) { }
    }
    public class WebsiteMyFileHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebsiteMyFileHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferencesResolveStore moduleReferencesResolveStore, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteMyFileHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteMyFileHelperFactory(JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferencesResolveStore moduleReferencesResolveStore, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteMyFileModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        public readonly JetBrains.ReSharper.Psi.VB.Impl.CompilerGeneratedFiles.VBCompilerGeneratedFilesMixin Mixin;
        public WebsiteMyFileModule(JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferencesResolveStore moduleReferencesResolveStore, JetBrains.ReSharper.Psi.Web.VB.Impl.PsiModules.MicrosoftVisualBasicAssemblyCookie visualBasicAssemblyCookie, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguage { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class WebVBProjectFileClassifier : JetBrains.ReSharper.Psi.Web.PsiModules.IWebProjectFileClassifier
    {
        public bool CanBeAppCodeFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeAspFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeCodeBehindFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.VB.Impl.References
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBStringLiteralPathBinder : JetBrains.ReSharper.Psi.Web.References.StringLiteralPathBinder
    {
        public VBStringLiteralPathBinder(JetBrains.ReSharper.Psi.Util.IStringLiteralAltererProvider stringLiteralAltererProvider) { }
    }
}