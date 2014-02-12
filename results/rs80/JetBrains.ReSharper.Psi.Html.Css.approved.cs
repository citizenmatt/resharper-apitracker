[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Html.Css
{
    
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class CssFromHtmlGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Generation.FromHtmlGeneratedDocumentServiceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.IGeneratedDocumentService, JetBrains.ReSharper.Psi.Web.Generation.IConstrainedGeneratedDocumentService
    {
        public CssFromHtmlGeneratedDocumentService(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ProjectModel.HtmlProjectFileType htmlProjectFileType) { }
        protected virtual string ImportKeyword { get; }
        protected virtual string MediaKeyword { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Css.Reference.HtmlCssClassReference[] CreateReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo) { }
        public virtual JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFromLinkTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue hrefValue, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap genMap) { }
        public virtual JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFromStyleAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap genMap) { }
        public virtual JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFromStyleTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag styleTag, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap genMap) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project) { }
        public bool HasProjectedInnerElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool HasProjectedOuterElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual bool IsCssLinkTag([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag, out JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue hrefValue) { }
        public virtual bool IsCssStyleAttribute([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute) { }
        public static bool IsCssStyleTag([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag) { }
        public override bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
        protected override bool TransactionActionIsUnrelated(JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
    }
    public class CssFromHtmlSecondaryLexingProcess : JetBrains.ReSharper.Psi.Html.Generation.FromHtmlSecondaryLexingProcessBase<JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Css.CssFromHtmlGeneratedDocumentService>
    {
        public CssFromHtmlSecondaryLexingProcess(JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Html.Css.CssFromHtmlGeneratedDocumentService service, JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        protected override JetBrains.Util.JetTuple<int, int, JetBrains.Util.TextRange[]> GetInnerLexerRange(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes> tokenNodeType) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("CSS_HTML")]
    public class CssHtmlLanguage : JetBrains.ReSharper.Psi.Css.CssLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Html.Css.CssHtmlLanguage Instance;
        public const string Name = "CSS_HTML";
        protected CssHtmlLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected CssHtmlLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    public abstract class CssInWebLexerFactoryBase : JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        protected CssInWebLexerFactoryBase(JetBrains.ReSharper.Psi.PsiLanguageType ownerLanguage) { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.ILexer CreateCssLexer(JetBrains.Text.IBuffer buffer) { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.Token CreateInjectionToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
    public class CssRangeTranslator : JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap
    {
        public CssRangeTranslator(JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap generatedRangeMap) { }
    }
    public class LexerWithInjection : JetBrains.ReSharper.Psi.Parsing.ILexer
    {
        public LexerWithInjection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.ILexer lexer, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Parsing.Token> injections, JetBrains.ReSharper.Psi.Parsing.TokenNodeType alienTokenType) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public void Advance() { }
        public void Start() { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Css.Reference
{
    
    public class HtmlCssClassReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceWithinElementBase<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Css.Tree.References.ICssClassReference, JetBrains.ReSharper.Psi.Html.Css.Reference.IHtmlCssClassReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public HtmlCssClassReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool CaseSensitive { get; }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSmartCompletionSymbolTable() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public interface IHtmlCssClassReference : JetBrains.ReSharper.Psi.Css.Tree.References.ICssClassReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlTagAttributeReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlTagIdReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlTagReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
}
namespace JetBrains.ReSharper.Psi.Html.Css.Symbols
{
    
    public abstract class HtmlClassSymbolsProviderBase<T> : JetBrains.ReSharper.Psi.Web.Impl.Symbols.WebSymbolsSimpleProviderBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        public override bool IsEnabled { get; }
        protected override JetBrains.ReSharper.Psi.IRecursiveElementProcessor CreateProcessor(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> symbols) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IFile> GetPsiFiles(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected abstract bool IsValidTagAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute);
    }
}