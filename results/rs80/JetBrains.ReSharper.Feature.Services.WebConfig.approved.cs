[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct
{
    
    public class static SelectEmbracingConstructUtil
    {
        public static JetBrains.ReSharper.Psi.TreeTextRange FindParentLocalRangeByTypeInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo typeInfo, JetBrains.ReSharper.Psi.TreeTextRange locRange) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.WebConfig.CodeCompletion
{
    
    public class WebConfigCodeCompletionReparsedContext : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext
    {
        public WebConfigCodeCompletionReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.WebConfig.CodeStructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigCodeStructureProvider : JetBrains.ReSharper.Feature.Services.Xml.CodeStructure.XmlCodeStructureProvider
    {
        protected override void CreateElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.WebConfig.ReferencedCode
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigReferencedCodeSearchHelper : JetBrains.ReSharper.Feature.Services.ReferencedCode.IReferencedCodeSearchHelper
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ReferencedCode.NamespaceImportData> GetNamespaceImportsList(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetUpdatedTargets(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IClrDeclaredElement target) { }
        public bool RemoveNamespaceImport(JetBrains.ReSharper.Psi.Tree.ITreeNode importNamespaceNode) { }
    }
}