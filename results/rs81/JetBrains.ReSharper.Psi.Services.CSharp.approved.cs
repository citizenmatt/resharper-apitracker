[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.CSharp
{
    
    public class static BlockUtil
    {
        public static System.Nullable<JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock> GetContainingNestedBlock(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static System.Nullable<JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock> GetFirstNestedBlock(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock> GetNestedBlocks(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static System.Nullable<JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock> GetNextNestedBlock(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static System.Nullable<JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock> GetPreviousNestedBlock(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public struct NestedBlock
        {
            public NestedBlock(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement ownerStatement, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement, System.Func<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock> blockSurrounder) { }
            public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement Body { get; }
            public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement OwnerStatement { get; }
            public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock SurroundWithBlock() { }
        }
    }
    public enum ContextType
    {
        DocCommentBlock = 0,
        ExtendsList = 1,
        Statement = 2,
        TypeMember = 3,
        Namespace = 4,
        File = 5,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpAnonymousObjectsAnalyser : JetBrains.ReSharper.Psi.Services.IAnonymousObjectsAnalyser
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression>> GetMemberInitializers(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsCreationExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class static CSharpCodeInsightPsiUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> EnumerateStatementsRecursively([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement GetContainingStatementStoppingAtLambdas([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> GetExpressionsInStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static bool IsAnonymousMethodVoid([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousMethodExpression anonymousMethod, params JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement[] skipStatements) { }
    }
    public class CSharpReparseContext : JetBrains.ReSharper.Psi.Services.ReparseContext
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.CSharp.CSharpReparseContext FindContext(JetBrains.ReSharper.Psi.Tree.ITreeNode origin) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Parse(string addedText) { }
    }
    public class CSharpReparseContextEx : JetBrains.ReSharper.Psi.Services.IReparseContext
    {
        public string ContextHead { get; }
        public string ContextTail { get; }
        public int HeadLength { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Origin { get; }
        public JetBrains.ReSharper.Psi.Services.ReparseContext.ContextType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.CSharp.CSharpReparseContextEx FindContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.Services.ReparseResult GetReparseResult(string newText) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Parse(string insertedText) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpTypeAnchorSerializer : JetBrains.ReSharper.Psi.Services.ITypeAnchorSerializer
    {
        public JetBrains.ReSharper.Psi.Services.TypeAnchor Deserialize(string sFullyQualifiedName) { }
        public string Serialize(JetBrains.ReSharper.Psi.Services.TypeAnchor typeAnchor) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ExpressionSelection
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpExpressionSelectionProvider : JetBrains.ReSharper.Psi.Services.ExpressionSelection.ExpressionSelectionProviderBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        protected override bool IsTokenSkipped(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.Navigation
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpTypeMemberDeclarationService : JetBrains.ReSharper.Psi.Services.ITypeMemberDeclarationService
    {
        public JetBrains.ReSharper.Psi.Tree.IDeclaration FindDeclarationByOffset(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.QueryTools
{
    
    public interface IQueryVisitor
    {
        void VisitContinuation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryContinuation continuation);
        void VisitFirstFrom([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryFirstFrom clause);
        void VisitFrom([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryFromClause clause);
        void VisitFromSelect([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryFromClause clause);
        void VisitGroupBy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryGroupClause clause);
        void VisitGroupByShort([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryGroupClause clause);
        void VisitJoin([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryJoinClause clause);
        void VisitJoinInto([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryJoinClause clause);
        void VisitJoinIntoSelect([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryJoinClause clause);
        void VisitJoinSelect([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryJoinClause clause);
        void VisitLet([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryLetClause clause);
        void VisitOrderBy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryOrderByClause clause);
        void VisitSelect([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQuerySelectClause clause);
        void VisitSelectEmpty(JetBrains.ReSharper.Psi.CSharp.Tree.IQuerySelectClause clause);
        void VisitWhere([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryWhereClause clause);
    }
    public class QueryIterator
    {
        public static void Do([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IQueryExpression queryExpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.CSharp.QueryTools.IQueryVisitor queryVisitor) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch
{
    
    public class ArrayTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public string ShortName { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.IUserTypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> getElementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.IUserTypeUsage typeUsageNode, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher elementTypeMatcher, System.Func<T, JetBrains.ReSharper.Psi.IType> getElementType) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class CSharpClassStructuralMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralMatcherBase
    {
        public CSharpClassStructuralMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher) { }
    }
    public class CSharpCommentPatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternLexer
    {
        protected override JetBrains.ReSharper.Psi.LanguageService LanguageService { get; }
        protected override bool MetaPlaceholderSupported { get; }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder GetMetaPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class CSharpDeclaredTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.TypeMatcherBase<T>, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcherCanContainOther
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public CSharpDeclaredTypeMatcher(string typeName, System.Func<T, JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage> declaredTypeUsage, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher> typeArgumentMatchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher declaredTypeMatcher = null) { }
        protected override string TypeName { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage typeUsageNode, System.Func<JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.TypePlaceholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher> getTypeMatcherFromPlaceholder, System.Func<string, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher>, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher> createDeclaredTypeMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected override JetBrains.ReSharper.Psi.IType GetElementType(T element) { }
        protected override JetBrains.ReSharper.Psi.IType GetOriginalType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool MatchTypeWithPlaceholder(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public void RegisterContainingTypePlaceholderMatches(System.Action<string, JetBrains.ReSharper.Psi.Tree.ITreeNode> register, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class CSharpExpressionStructuralMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralMatcherBase
    {
        public CSharpExpressionStructuralMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class static CSharpMatcherBuilder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class CSharpPatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternLexer
    {
        protected override JetBrains.ReSharper.Psi.LanguageService LanguageService { get; }
        protected override bool MetaPlaceholderSupported { get; }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IUnknownPlaceholder CreateUnknownPlaceholder(string name) { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder GetMetaPlaceholder(string name) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult TryParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Func<JetBrains.ReSharper.Psi.Parsing.IParser, JetBrains.ReSharper.Psi.Tree.ITreeNode> createElement, int realShift = 0, bool createUnknownPlaceholders = False, bool deleteUnusedPlaceholders = False) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpPlaceholderGuesser
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Guess(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage usage) { }
    }
    public class CSharpPlaceholderStructuralMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralMatcherBase
    {
        public CSharpPlaceholderStructuralMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher) { }
    }
    public class CSharpReplacePatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexer { }
    public class CSharpSequenceMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.SequenceMatcher<T>
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public CSharpSequenceMatcher(System.Collections.Generic.IEnumerable<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public CSharpSequenceMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<T>> elementsGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class CSharpStatementSequenceMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpSequenceMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement>
    {
        public CSharpStatementSequenceMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected override bool MoveToNextElement(System.Collections.Generic.IEnumerator<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> elementsEnumerator, out JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement currentElement) { }
    }
    public class CSharpStructuralMatcherBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralMatcher
    {
        protected CSharpStructuralMatcherBase(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher) { }
        public override System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearcherFactoryAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpStructuralSearcherFactory : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory
    {
        public CSharpStructuralSearcherFactory(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralSearchPatternFromCodeCreator patternFromCodeCreator) { }
        public bool IsInternal { get; }
        public bool SupportsIgnoreUnmatched { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
        public void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> targets, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
    public class CSharpStructuralSearchPattern : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern>, System.ICloneable
    {
        public CSharpStructuralSearchPattern() { }
        public CSharpStructuralSearchPattern(string textPattern) { }
        public CSharpStructuralSearchPattern(string textPattern, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
        public CSharpStructuralSearchPattern(string textPattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public CSharpStructuralSearchPattern(string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public CSharpStructuralSearchPattern(string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
        public CSharpStructuralSearchPattern(string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
        public string Comment { get; set; }
        public bool FormatAfterReplace { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams Params { get; set; }
        public System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> Placeholders { get; set; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternPresenter Presenter { get; }
        public string ReplaceComment { get; set; }
        public string ReplacePattern { get; set; }
        public string SearchPattern { get; set; }
        public bool ShortenReferences { get; set; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern AddPatternPlaceholder(string name, string pattern) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult Check() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder builder) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralSearchPattern other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool GuessPlaceholders() { }
        public void ReadPlaceholders(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo> placeholderInfos) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpStructuralSearchPatternFromCodeCreator : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternFromCodeCreator
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
    }
    public class CSharpStructuralSearchPatternPresenter : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.StructuralSearchPatternPresenterBase
    {
        public CSharpStructuralSearchPatternPresenter(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralSearchPattern pattern) { }
        protected override string GetListReplacement(System.Collections.IEnumerable enumerable) { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string text, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
    public class static CSharpStructuralSearchReplacer
    {
        public static void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> matches, string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, bool formatAfterReplace, bool shortenReferences) { }
        public static void Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode replaceElement, string replacePattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderReplacement[] replacements) { }
        public static void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult match, string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, bool formatAfterReplace, bool shortenReferences) { }
        public static void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, string replacePattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderReplacement[] replacements) { }
        public static void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> replaceElements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, bool formatAfterReplace, bool shortenReferences) { }
    }
    public class CSharpTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.TypeMatcherBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected override string TypeName { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> func, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> func, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute attribute, System.Func<JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute, JetBrains.ReSharper.Psi.IType> func) { }
        protected override JetBrains.ReSharper.Psi.IType GetElementType(T element) { }
        protected override JetBrains.ReSharper.Psi.IType GetOriginalType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class CSharpTypeMemberStructuralMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpStructuralMatcherBase
    {
        public CSharpTypeMemberStructuralMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher) { }
    }
    public interface ITypeMemberDeclarationMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        bool Match(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    public class NullableTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public NullableTypeMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IUserTypeUsage userTypeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> getElementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class PointerTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public PointerTypeMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IUserTypeUsage userTypeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> getElementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers
{
    
    public class ArgumentMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument>
    {
        public ArgumentMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class AsExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IAsExpression>
    {
        public AsExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IAsExpression element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class AssignmentExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression>
    {
        public AssignmentExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class AttributeMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute>
    {
        public AttributeMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute attribute, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
        public static JetBrains.ReSharper.Psi.IType CreateType(JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute a) { }
    }
    public class AwaitExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IAwaitExpression>
    {
        public AwaitExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IAwaitExpression awaitExpressionParam, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class BaseExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IBaseExpression>
    {
        public BaseExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IBaseExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class BinaryExpressionMatcher<T> : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<T>
        where T :  class, JetBrains.ReSharper.Psi.CSharp.Tree.IBinaryExpression
    {
        public BinaryExpressionMatcher(T expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public BinaryExpressionMatcher(T expression, JetBrains.ReSharper.Psi.Parsing.TokenNodeType operatorSign, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class static BinaryExpressionMatcherUtil
    {
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreateNegativeMatcher<T>(T expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params)
            where T :  class, JetBrains.ReSharper.Psi.CSharp.Tree.IBinaryExpression { }
    }
    public class BlockMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>
    {
        public BlockMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class BreakStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IBreakStatement>
    {
        public BreakStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IBreakStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class CastExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ICastExpression>
    {
        public CastExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ICastExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class CatchClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IGeneralCatchClause>
    {
        public CatchClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IGeneralCatchClause element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public abstract class CSharpElementMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ElementMatcherBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher AddMatcher(T expression, System.Func<T, JetBrains.ReSharper.Psi.Tree.ITreeNode> propertyGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.CSharpSequenceMatcher<T2> AddMatcher<T2>(T expression, System.Func<T, System.Collections.Generic.IEnumerable<T2>> elementsGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params)
            where T2 : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher AddMatcherAnyOrder<T2>(T element, System.Func<T, System.Collections.Generic.IEnumerable<T2>> elementsGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params)
            where T2 :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class CSharpIdentifierMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>
    {
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class DeclarationStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IDeclarationStatement>
    {
        public DeclarationStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IDeclarationStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class DoStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IDoStatement>
    {
        public DoStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IDoStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class EmptyStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IEmptyStatement>
    {
        public EmptyStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IEmptyStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ExpressionInitializerMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IExpressionInitializer>
    {
        public ExpressionInitializerMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IExpressionInitializer initializer, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ExpressionStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IExpressionStatement>
    {
        public ExpressionStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IExpressionStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ForeachStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IForeachStatement>
    {
        public ForeachStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IForeachStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class ForeachVariableDeclarationMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IForeachVariableDeclaration>
    {
        public ForeachVariableDeclarationMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IForeachVariableDeclaration declaration, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ForStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IForStatement>
    {
        public ForStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IForStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class IfStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement>
    {
        public IfStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class InvocationExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression>
    {
        public InvocationExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class IsExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IIsExpression>
    {
        public IsExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IIsExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class LiteralExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression>
    {
        public LiteralExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class LocalConstantDeclarationMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ILocalConstantDeclaration>
    {
        public LocalConstantDeclarationMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ILocalConstantDeclaration declaration, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class LocalVariableDeclarationMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration>
    {
        public LocalVariableDeclarationMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration declaration, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ObjectCreationExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression>
    {
        public ObjectCreationExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class PostfixOperatorExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IPostfixOperatorExpression>
    {
        public PostfixOperatorExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IPostfixOperatorExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public static bool CompareOperators(JetBrains.ReSharper.Psi.CSharp.Tree.PrefixOperatorType prefix, JetBrains.ReSharper.Psi.CSharp.Tree.PostfixOperatorType postfix) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class PrefixOperatorExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IPrefixOperatorExpression>
    {
        public PrefixOperatorExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IPrefixOperatorExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class QueryFromClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryFromClause>
    {
        public QueryFromClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryFromClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class QueryGroupClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryGroupClause>
    {
        public QueryGroupClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryGroupClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class QueryJoinMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryJoinClause>
    {
        public QueryJoinMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryJoinClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class QueryLetClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryLetClause>
    {
        public QueryLetClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryLetClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class QueryOrderByClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryOrderByClause>
    {
        public QueryOrderByClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryOrderByClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class QueryOrderingMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryOrdering>
    {
        public QueryOrderingMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryOrdering ordering, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class QuerySelectClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQuerySelectClause>
    {
        public QuerySelectClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQuerySelectClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class QueryWhereClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryWhereClause>
    {
        public QueryWhereClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryWhereClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class ReferenceExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression>
    {
        public ReferenceExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class ReferenceExpressionTypeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        public ReferenceExpressionTypeMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class ReturnStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement>
    {
        public ReturnStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class SpecificCatchClauseMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ISpecificCatchClause>
    {
        public SpecificCatchClauseMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ISpecificCatchClause element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class StatementOrBlockMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class SwitchLabelStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ISwitchLabelStatement>
    {
        public SwitchLabelStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ISwitchLabelStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class SwitchStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ISwitchStatement>
    {
        public SwitchStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ISwitchStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class ThisExpressionMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IThisExpression>
    {
        public ThisExpressionMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IThisExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class ThrowStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IThrowStatement>
    {
        public ThrowStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IThrowStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class TryStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.ITryStatement>
    {
        public TryStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ITryStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class UsingStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IUsingStatement>
    {
        public UsingStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IUsingStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class WhileStatementMatcher : JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Matchers.CSharpElementMatcher<JetBrains.ReSharper.Psi.CSharp.Tree.IWhileStatement>
    {
        public WhileStatementMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.IWhileStatement statement, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Parsers
{
    
    public class CSharpStructuralSearchAttributePatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public CSharpStructuralSearchAttributePatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class CSharpStructuralSearchClassPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public CSharpStructuralSearchClassPatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class CSharpStructuralSearchExpressionPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public static readonly JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Parsers.CSharpStructuralSearchExpressionPatternBuilder Instance;
        public CSharpStructuralSearchExpressionPatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreateElementMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class CSharpStructuralSearchStatementsPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public static readonly JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Parsers.CSharpStructuralSearchStatementsPatternBuilder Instance;
        public CSharpStructuralSearchStatementsPatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class CSharpStructuralSearchTypeMemberPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public CSharpStructuralSearchTypeMemberPatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders
{
    
    public class ArgumentPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderBase
    {
        public const string TAG_NAME = "ArgumentPlaceholder";
        public ArgumentPlaceholder(string name, int minimalOccurences, int maximalOccurences) { }
        public ArgumentPlaceholder(string name) { }
        public ArgumentPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        protected override string EntityName { get; }
        public override string[] ReplacingText { get; }
        protected override string TagName { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class ArgumentPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderMatcherBase
    {
        public ArgumentPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ArgumentPlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class CSharpUnknownPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.UnknownPlaceholder
    {
        public CSharpUnknownPlaceholder(string name) { }
        public override string[] ReplacingText { get; }
    }
    public class ElementPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public ElementPlaceholder(string name, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override string Description { get; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ElementPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class ElementPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        public ElementPlaceholderMatcher(string placeholderName, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class ExpressionPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IOtherPlaceholdersAwarePlaceholder
    {
        public const string TAG_NAME = "ExpressionPlaceholder";
        public ExpressionPlaceholder(string name, string expressionType = "", bool exactType = False) { }
        public ExpressionPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool ExactType { get; set; }
        public string ExpressionType { get; set; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ExpressionPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
        public void UsePlaceholders(System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
    public class ExpressionPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase
    {
        public ExpressionPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class IdentifierPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public const string TAG_NAME = "IdentifierPlaceholder";
        public IdentifierPlaceholder(string name, string nameRegex = null, bool nameRegexCaseSensitive = True, string type = null, bool exactType = False) { }
        public IdentifierPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool ExactType { get; }
        public System.Text.RegularExpressions.Regex NameRegex { get; set; }
        public override string[] ReplacingText { get; }
        public string Type { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IdentifierPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class IdentifierPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase
    {
        public IdentifierPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public interface IOtherPlaceholdersAwarePlaceholder
    {
        void UsePlaceholders(System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders);
    }
    public class PatternPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public PatternPlaceholder(string name, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher, string pattern) { }
        public override string Description { get; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.PatternPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class PatternPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        public PatternPlaceholderMatcher(string name, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public abstract class PlaceholderTypeMatcherBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderTypeMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        protected readonly string myType;
        protected PlaceholderTypeMatcherBase(string placeholderName, string type, bool exactType) { }
        public bool ExactType { get; }
        public string PlaceholderName { get; }
        public string ShortName { get; }
        public abstract JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public JetBrains.ReSharper.Psi.IType GetPlaceholderType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public virtual bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class StatementPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderBase
    {
        public const string TAG_NAME = "StatementPlaceholder";
        public StatementPlaceholder(string name, int minimalOccurences, int maximalOccurences) { }
        public StatementPlaceholder(string name) { }
        public StatementPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        protected override string EntityName { get; }
        public override string[] ReplacingText { get; }
        protected override string TagName { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class StatementPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderMatcherBase
    {
        public StatementPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.StatementPlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class TypeParameterDeclarationTypeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        public TypeParameterDeclarationTypeMatcher(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterDeclaration typeParameter) { }
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class TypePlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IOtherPlaceholdersAwarePlaceholder
    {
        public const string TAG_NAME = "TypePlaceholder";
        public TypePlaceholder(string name, string type = "", bool exactType = False) { }
        public TypePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool ExactType { get; set; }
        public override string[] ReplacingText { get; }
        public string Type { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.TypePlaceholder other) { }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher GetDeclaredTypeMatcher(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage> getDeclaredTypeUsage) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher GetTypeMatcher(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.IType> getElementType, bool matchVoid) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
        public void UsePlaceholders(System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
    public class TypePlaceholderElementMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        public TypePlaceholderElementMatcher(JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.TypePlaceholder placeholder, bool matchVoid) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class static TypePlacholderHelper
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage CreateDeclaredTypeUsageNode(string typeName) { }
        public static JetBrains.Util.JetTuple<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection> ParsePlaceholderType(string type, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpValueTrackingLanguageService : JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingLanguageServiceBase
    {
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetArgumentValue(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetElementFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation GetElementPresentation(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public override JetBrains.ReSharper.Psi.IType GetOwnerType(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode NodeFromDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Tree.IDeclaration declarationOfElement, JetBrains.ReSharper.Psi.IType ownerType, out string text) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode NodeFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session) { }
        public static JetBrains.UI.RichText.RichText PresentExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
    }
    public class ParameterInNodeWithOverrides : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ParameterInNodeWithOverrides(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration declaration, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack valueTrackingCallStack, JetBrains.ReSharper.Psi.ITypePointer ownerTypePointer) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ParameterNodeByRefWithOverrides : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ParameterNodeByRefWithOverrides(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration declaration, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack, JetBrains.ReSharper.Psi.ITypePointer ownerTypePointer) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [System.FlagsAttribute()]
    public enum ValueTrackingChildRoles
    {
        NoRole = 0,
        LocalDfaResult = 1,
        DestFromSource = 2,
        SourceFromDest = 4,
        UsageOfElement = 8,
        ArgumentFromParameter = 16,
        ValueOfInitializer = 32,
        ArgumentOfNullCoalescing = 64,
        ArgumentOfTernary = 128,
        CastOuter = 256,
        CastInner = 512,
        ArgumentOfDelegateConstructor = 1024,
        DelegateConstructorOfArgument = 2048,
        ThisOfQualifier = 4096,
        QualifierOfThis = 8192,
        ElementOfCollection = 16384,
        CollectionOfElement = 32768,
        BracesOfOuter = 65536,
        BracesOfInner = 131072,
        UsageOfElementWithObjectInitializer = 262144,
        SourceOfAssignmentExpression = 524288,
        AssignmentExpressionOfSource = 1048576,
        ArgumentOfNewList = 2097152,
        NewListOfArgument = 4194304,
        ArgumentOfAddRange = 8388608,
        AddRangeOfArgument = 16777216,
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.CollectionWrappers
{
    
    public class CollectionWrappersHelper
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode> ElementToCollection(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.TransitionalExpressionNode parent) { }
        public static bool IsMutableCollectionType(JetBrains.ReSharper.Psi.IType type) { }
        public static void UnwrapCollection(JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections innerNodeDirection, JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.CollectionWrappers.ElementOfCollection ownerNode, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childNode, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> unWrappedChildren, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> newChildren, out bool unWrapped) { }
    }
    public class ElementOfCollection : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public ElementOfCollection(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directionForUnwrappedNode) { }
        public override bool IsPassThrough { get; }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class PreExpandedNodeUsagesOfYieldMethod : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeUsagesOfYieldMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.PreNodes.PreExpandedNodeMethodUsage preExpandedNodeMethodUsage) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class YieldReturnedExpressionNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public YieldReturnedExpressionNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public override bool IsPassThrough { get; }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression SourceExpression { get; set; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes
{
    
    public class ConstantNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ConstantNode(JetBrains.ReSharper.Psi.ConstantValue value, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ExpandedParamarrayNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ExpandedParamarrayNode(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgumentsOwner owner, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument>> Arguments { get; }
        public override bool CanBeExpanded { get; }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public sealed class FieldLikeNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public FieldLikeNode(JetBrains.ReSharper.Psi.ITypeOwner typeOwner, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType ownerType) { }
        public override bool IsPassThrough { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeOwner> Pointer { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class InitializerExpressionNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public InitializerExpressionNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode initializer, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class LocalDeclarationNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public LocalDeclarationNode(JetBrains.ReSharper.Psi.CSharp.Tree.IVariableDeclaration declaration, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MultipleElementsNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public MultipleElementsNode(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> children, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode SourceElement { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ParameterInNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ParameterInNode(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration parameterDeclaration, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ParameterOutNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ParameterOutNode(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration parameterDeclaration, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class TransitionalExpressionNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public TransitionalExpressionNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack, JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.ValueTrackingChildRoles valueTrackingChildRole) { }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> ExpressionPointer { get; }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.ValueTrackingChildRoles ValueTrackingChildRole { get; }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool HasRole(JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.ValueTrackingChildRoles valueTrackingChildRole) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers
{
    
    public class ConstructorArgumentToProperty : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public ConstructorArgumentToProperty(JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers.DataClassProperty dataClassProperty, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections wrappedNodeDirection) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class static DataClassPropertiesFactory
    {
        public static JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers.DataClassProperty CreateOfConstructorParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers.DataClassProperty CreateOfProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeOwner typeOwner) { }
    }
    public class DataClassProperty
    {
        public DataClassProperty(JetBrains.ReSharper.Psi.ITypeOwner property, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> parameters) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> Parameters { get; }
        public JetBrains.ReSharper.Psi.ITypeOwner Property { get; }
    }
    public class DataClassPropertyPointer
    {
        public DataClassPropertyPointer(JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers.DataClassProperty dataClassProperty) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers.DataClassProperty FindDataClassPointer() { }
    }
    public class PropertyToConstructorArgument : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public PropertyToConstructorArgument(JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DataClassWrappers.DataClassProperty dataClassProperty, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections wrappedNodeDirection) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DelegateWrappers
{
    
    public class ArgumentToLambdaParameter : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public ArgumentToLambdaParameter(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, int delegateParameterIndex, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directionForUnwrappedNode, string parameterName) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class CallToLambdaReturn : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public CallToLambdaReturn(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections wrappedNodeDirection) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class LambdaParameterToCall : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public LambdaParameterToCall(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, int parameterIndex, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directionForUnwrappedNode) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class LambdaReturnToCall : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public LambdaReturnToCall(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.DelegateWrappers.Events
{
    
    public class DelegateToEventNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public DelegateToEventNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression InvocationExpression { get; }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class DelegateToEventNodePreExpanded : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public DelegateToEventNodePreExpanded(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IEvent @event) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class EventToDelegatePreExpandedNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public EventToDelegatePreExpandedNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IEvent @event) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class PreExpandedNodeEventVirtualCall : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeEventVirtualCall(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IEvent @event, bool isCallToBase, JetBrains.ReSharper.Psi.IType ownerType) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class VirtualEventToDelegatePreExpandedNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public VirtualEventToDelegatePreExpandedNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IEvent @event, bool isCallToBase) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.ThisWrapper
{
    
    public sealed class PreExpandedNodeThisWrappedNodeUsage : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeThisWrappedNodeUsage(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.ThisWrapper.PreExpandedNodeThisWrappedNodeUsage CreateFromContext(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class PreExpandedNodeUsagesOfThis : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeUsagesOfThis(JetBrains.ReSharper.Psi.IDeclaredElement element, bool isWrite, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.ITypePointer ownerType) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class QualifierNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Nodes.ThisWrapper.QualifierNode CreateOfElement(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack, JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class QualifierToThisWrapperNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public QualifierToThisWrapperNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class ThisToQualifierWrappedNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ThisToQualifierWrappedNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression Expression { get; }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ThisToQualifierWrapperNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase
    {
        public ThisToQualifierWrapperNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directionsOfWrappedNode) { }
        protected override JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode) { }
    }
    public class ThisUsageNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public ThisUsageNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode expression, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.PreNodes
{
    
    public class PreExpandedNodeCall : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeCall(JetBrains.ReSharper.Psi.IOverridableMember overridableMember, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IType ownerType, bool isWriteAccess, bool notVirtualCall) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class PreExpandedNodeFieldLikeMemberUsage : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeFieldLikeMemberUsage(JetBrains.ReSharper.Psi.ITypeOwner typeOwner, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, bool searchUsagesOfInheritors, JetBrains.ReSharper.Psi.ITypePointer ownerTypePointer) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public sealed class PreExpandedNodeMethodUsage : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeMethodUsage(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class PreExpandedNodeParameterIn : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeParameterIn(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, bool isCallToBase, bool isExpandedParameter, JetBrains.ReSharper.Psi.IType ownerType) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class PreExpandedNodeParameterOut : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeParameterOut(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class PreExpandedNodeParameterUsages : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase
    {
        public PreExpandedNodeParameterUsages(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public override void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Presentation
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpExpressionPresenter : JetBrains.ReSharper.Psi.Services.Presentation.ExpressionPresenterLanguageService
    {
        public override bool CanReduce(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override bool IsGrouppingNode(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Utils
{
    
    public class LocalValueTrackingUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression Collection { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode InitializerElement { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression> UsagesAfter { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression> UsagesBefore { get; }
        public static JetBrains.ReSharper.Psi.Services.CSharp.ValueTracking.Utils.LocalValueTrackingUtil CreateInstance(JetBrains.ReSharper.Psi.ITypeOwner variable, JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
    }
    public class static ValueTrackingUtil
    {
        public static void AddReturnFromBlocks(JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock> blocks, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ret) { }
        public static void AddValueVariable(JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock> blocks, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ret) { }
        public static string GetArgumentsOwnerText(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgumentsOwner argumentOwner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetOwnerType(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static bool IsCallToBase(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static void RemoveRedundantOverrides<T>(System.Collections.Generic.List<T> elements, JetBrains.ReSharper.Psi.IType ownerType)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
    }
}