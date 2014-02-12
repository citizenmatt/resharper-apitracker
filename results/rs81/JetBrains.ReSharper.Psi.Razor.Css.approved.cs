[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Razor.Css
{
    
    public abstract class CssFromRazorGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Css.CssFromHtmlGeneratedDocumentService
    {
        protected CssFromRazorGeneratedDocumentService(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ProjectModel.RazorProjectFileType razorProjectFileType) { }
        protected override string ImportKeyword { get; }
        protected override string MediaKeyword { get; }
        public override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFromLinkTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue hrefValue, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap genMap) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
    }
    public class CssRazorLexer : JetBrains.ReSharper.Psi.Parsing.ILexer
    {
        public CssRazorLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public void Advance() { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.ArrayOfTokens ProcessTokens(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public void Start() { }
    }
}