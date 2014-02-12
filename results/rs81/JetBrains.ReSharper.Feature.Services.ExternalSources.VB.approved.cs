[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.ExternalSources.VB.MetadataTranslator
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMetadataTranslator : JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.IMetadataTranslator
    {
        public bool IsAvailable { get; }
        public bool IsMethodBodiesDecompilationSupported { get; }
        public string TranslateAssemblyInfo(JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule context, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public string TranslateTopLevelTypeElement(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule context, JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions options, JetBrains.Application.Progress.IProgressIndicator indicator) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.VB.src.Utils
{
    
    public class VBDeclaredElementBinderInstance
    {
        public VBDeclaredElementBinderInstance(JetBrains.ReSharper.Psi.VB.Tree.IVBFile file, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public void BindDeclarations() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.VB.Utils
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBDeclaredElementBinder : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.DeclaredElementBinder
    {
        public override void BindDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool failOnUnresolvedSymbols) { }
    }
}