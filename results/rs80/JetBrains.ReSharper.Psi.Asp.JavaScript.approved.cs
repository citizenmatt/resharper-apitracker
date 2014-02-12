[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Asp.JavaScript.GeneratedDocuments
{
    
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class JavaScriptFromAspGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptFromHtmlGeneratedDocumentService
    {
        public JavaScriptFromAspGeneratedDocumentService(JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptGeneratedLanguageService javaScriptGeneratedLanguageService, JetBrains.ProjectModel.AspProjectFileType aspProjectFileType) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override bool IsEventAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute) { }
        public override bool IsJavascriptScriptTag(JetBrains.ReSharper.Psi.Html.Tree.IScriptTag scriptTag) { }
    }
    public class JavaScriptFromAspSecondaryLexingProcess : JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptFromHtmlSecondaryLexingProcess<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes, JetBrains.ReSharper.Psi.Asp.JavaScript.GeneratedDocuments.JavaScriptFromAspGeneratedDocumentService>
    {
        public JavaScriptFromAspSecondaryLexingProcess(JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ReSharper.Psi.Asp.JavaScript.GeneratedDocuments.JavaScriptFromAspGeneratedDocumentService service) { }
    }
}