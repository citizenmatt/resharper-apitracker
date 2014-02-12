[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Html.Javascript.CodeStyle
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class JavaScriptHtmlCodeFormatterFactory : JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterFactory
    {
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFormattingVisitor CreateFormattingVisitor(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData formattingData) { }
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentVisitor CreateIndentVisitor(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings formattingSettings, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentCache indentCache, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context) { }
        public static bool IsScriptTag([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, out JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag) { }
        public class JavaScriptHtmlFormattingVisitor : JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFormattingVisitor
        {
            public JavaScriptHtmlFormattingVisitor(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData formattingData) { }
            public override System.Collections.Generic.IEnumerable<string> VisitJavaScriptFile(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFile, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        }
        public class JavaScriptHtmlIndentVisitor : JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentVisitor
        {
            public JavaScriptHtmlIndentVisitor(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings formattingSettings, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentCache indentCache, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context) { }
            public override string VisitJavaScriptFile(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFile, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NoNewLinesInHtmlEventHandlers : JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterExtension
    {
        public System.Nullable<bool> FormatSingleLine(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Javascript.CustomReferences
{
    
    public class HtmlEventJavaScriptReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class HtmlLegacyEventJavaScriptReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class HtmlTagIdJavaScriptReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class HtmlTagJavaScriptReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments
{
    
    public class JavaScriptFromHtmlFileGenerator : JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Psi.PsiLanguageType>
    {
        public JavaScriptFromHtmlFileGenerator([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptFromHtmlGeneratedDocumentService service) { }
        public JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiLanguageType generatedLanguage) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.PsiLanguageType generatedLanguage) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Psi.PsiLanguageType context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.PsiLanguageType generatedLanguage) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.PsiLanguageType generatedLanguage) { }
    }
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class JavaScriptFromHtmlGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Generation.FromHtmlGeneratedDocumentServiceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.IGeneratedDocumentService, JetBrains.ReSharper.Psi.Web.Generation.IConstrainedGeneratedDocumentService
    {
        public JavaScriptFromHtmlGeneratedDocumentService(JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptGeneratedLanguageService javaScriptGeneratedLanguageService, JetBrains.ProjectModel.HtmlProjectFileType htmlProjectFileType) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Files.ICommitBuildResult> ExecuteSecondaryDocumentCommitWork(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo primaryFileModificationInfo, JetBrains.ReSharper.Psi.Files.CachedPsiFile cachedPsiFile, JetBrains.ReSharper.Psi.TreeTextRange oldTreeRange, string newText) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project) { }
        public bool HasProjectedInnerElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool HasProjectedOuterElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual bool IsEventAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute) { }
        public virtual bool IsJavascriptScriptTag([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IScriptTag scriptTag) { }
        public override bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
        protected override bool TransactionActionIsUnrelated(JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
    }
    public class JavaScriptFromHtmlSecondaryLexingProcess<TTokenTypes, TGeneratedDocumentService> : JetBrains.ReSharper.Psi.Html.Generation.FromHtmlSecondaryLexingProcessBase<TTokenTypes, TGeneratedDocumentService>
        where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
        where TGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Javascript.GeneratedDocuments.JavaScriptFromHtmlGeneratedDocumentService
    {
        public JavaScriptFromHtmlSecondaryLexingProcess(JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectFileType projectFileType, TGeneratedDocumentService service) { }
        protected override JetBrains.Util.JetTuple<int, int, JetBrains.Util.TextRange[]> GetInnerLexerRange(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<TTokenTypes> tokenNodeType) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JavaScriptGeneratedLanguageService
    {
        public JavaScriptGeneratedLanguageService(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetGeneratedLanguage([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PsiLanguageType> GetSupportedLanguages(JetBrains.ProjectModel.IProject project) { }
    }
    public class JavaScriptInWebLexer : JetBrains.ReSharper.Psi.Parsing.ILexer
    {
        public JavaScriptInWebLexer(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.Text.IBuffer buffer) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public void Advance() { }
        public void Start() { }
    }
}