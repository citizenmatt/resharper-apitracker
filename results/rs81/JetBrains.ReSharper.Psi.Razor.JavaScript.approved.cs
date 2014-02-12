[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Razor.JavaScript.GeneratedDocuments
{
    
    public abstract class JavaScriptFromRazorGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptFromHtmlGeneratedDocumentService
    {
        protected JavaScriptFromRazorGeneratedDocumentService(JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptGeneratedLanguageService javaScriptGeneratedLanguageService, JetBrains.ProjectModel.RazorProjectFileType razorProjectFileType) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
    }
    public class JavaScriptFromRazorSecondaryLexingProcess : JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptFromHtmlSecondaryLexingProcess<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes, JetBrains.ReSharper.Psi.Razor.JavaScript.GeneratedDocuments.JavaScriptFromRazorGeneratedDocumentService>
    {
        public JavaScriptFromRazorSecondaryLexingProcess(JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ReSharper.Psi.Razor.JavaScript.GeneratedDocuments.JavaScriptFromRazorGeneratedDocumentService service) { }
    }
}