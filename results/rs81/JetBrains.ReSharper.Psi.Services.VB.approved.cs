[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.VB
{
    
    public enum ContextType
    {
        DocCommentBlock = 0,
        ExtendsList = 1,
        Statement = 2,
        TypeMember = 3,
        Namespace = 4,
        File = 5,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VbAnonymousObjectsAnalyser : JetBrains.ReSharper.Psi.Services.IAnonymousObjectsAnalyser
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression>> GetMemberInitializers(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsCreationExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBDefaultValueCreation : JetBrains.ReSharper.Psi.Services.DefaultValueUtil.IDefaultValueCreation
    {
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateArrayConstructorCall(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateConstantValue(JetBrains.ReSharper.Psi.ConstantValue value, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateDefaultConstructorCall(JetBrains.ReSharper.Psi.IType valueType, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateNull(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateTypeDefaultExpression(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLanguageReferenceSelector : JetBrains.ReSharper.Psi.Services.ILanguageReferenceSelector
    {
        public JetBrains.ReSharper.Psi.IConstructor GetBaseConstructor(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidates(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind preferenceKind) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLocalSymbolsServiceProvider : JetBrains.ReSharper.Psi.Services.CodeInsight.LocalSymbolsServiceProviderBase<JetBrains.ReSharper.Psi.VB.Tree.IBlock, JetBrains.ReSharper.Psi.VB.Tree.IVBStatement>
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable FilterVisibleVariables(JetBrains.ReSharper.Psi.Resolve.ISymbolTable table, JetBrains.ReSharper.Psi.Resolve.IAccessContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList.TypedAndNamedEntity> GetAdditionalEntries(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPlaceholderGuesser
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Guess(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage usage) { }
    }
    public class VBReparseContextEx : JetBrains.ReSharper.Psi.Services.ReparseContextBase
    {
        public JetBrains.ReSharper.Psi.Services.VB.ContextType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.VB.VBReparseContextEx FindContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public override JetBrains.ReSharper.Psi.Services.ReparseResult GetReparseResult(string newText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Parse(string insertedText) { }
    }
    public class VBReparseContextKeywords : JetBrains.ReSharper.Psi.Services.ReparseContextShortBase
    {
        public JetBrains.ReSharper.Psi.Services.VB.ContextType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.VB.VBReparseContextKeywords FindContext(JetBrains.ReSharper.Psi.Tree.ITreeNode origin) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Parse(string addedText) { }
    }
    public class VBStringLiteralParser
    {
        [System.ComponentModel.LocalizableAttribute(false)]
        public static string Parse([JetBrains.Annotations.NotNullAttribute()] string literalText, out JetBrains.Util.RangeTranslator translator) { }
    }
    public class VBStructuralSearchStatementsPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public static readonly JetBrains.ReSharper.Psi.Services.VB.VBStructuralSearchStatementsPatternBuilder Instance;
        public VBStructuralSearchStatementsPatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.ExpressionSelection
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpressionSelectionProvider : JetBrains.ReSharper.Psi.Services.ExpressionSelection.ExpressionSelectionProviderBase<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        protected override bool IsTokenSkipped(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.Impl
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBTypeAnchorSerializer : JetBrains.ReSharper.Psi.Services.ITypeAnchorSerializer
    {
        public JetBrains.ReSharper.Psi.Services.TypeAnchor Deserialize(string sFullyQualifiedName) { }
        public string Serialize(JetBrains.ReSharper.Psi.Services.TypeAnchor typeAnchor) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.Navigation
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBTypeMemberDeclarationService : JetBrains.ReSharper.Psi.Services.ITypeMemberDeclarationService
    {
        public JetBrains.ReSharper.Psi.Tree.IDeclaration FindDeclarationByOffset(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers
{
    
    public class AssociativeExpressionMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.IExpressionMatcher
        where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression
    {
        public AssociativeExpressionMatcher(T expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult MatchExpression(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class BinaryExpressionMatcher<T> : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBExpressionMatcher<T>
        where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression
    {
        public BinaryExpressionMatcher(T expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public BinaryExpressionMatcher(T expression, JetBrains.ReSharper.Psi.Parsing.TokenNodeType sign, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class BinaryExpressionMatcherUtil
    {
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreateNegativeMatcher<T>(T expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params)
            where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression { }
    }
    public interface IExpressionMatcher
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult MatchExpression(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    public class IndexExpressionMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBExpressionMatcher<JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression>
    {
        public IndexExpressionMatcher(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class LambdaFunctionMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBElementMatcher<JetBrains.ReSharper.Psi.VB.Tree.ILambdaFunctionExpression>
    {
        public LambdaFunctionMatcher(JetBrains.ReSharper.Psi.VB.Tree.ILambdaFunctionExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class NextClauseMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBElementMatcher<JetBrains.ReSharper.Psi.VB.Tree.INextClause>
    {
        public NextClauseMatcher(JetBrains.ReSharper.Psi.VB.Tree.INextClause clause, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override System.Collections.Generic.IEnumerable<string> Words { get; }
    }
    public class ParenthesizedExpressionMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBExpressionMatcher<JetBrains.ReSharper.Psi.VB.Tree.IParenthesizedExpression>
    {
        public ParenthesizedExpressionMatcher(JetBrains.ReSharper.Psi.VB.Tree.IParenthesizedExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class PositionalArgumentMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBElementMatcher<JetBrains.ReSharper.Psi.VB.Tree.IPositionalArgument>
    {
        public PositionalArgumentMatcher(JetBrains.ReSharper.Psi.VB.Tree.IPositionalArgument argument, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ReferenceExpressionMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBExpressionMatcher<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression>
    {
        public ReferenceExpressionMatcher(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class ReferenceExpressionTypeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        public ReferenceExpressionTypeMatcher(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class SmartIfStatementMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public SmartIfStatementMatcher(JetBrains.ReSharper.Psi.VB.Tree.ILineIfStatement lineIf, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public SmartIfStatementMatcher(JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement blockIf, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class VBElementMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ElementMatcherBase<T>
        where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode
    {
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher AddMatcher(T expression, System.Func<T, JetBrains.ReSharper.Psi.Tree.ITreeNode> propertyGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.VBSequenceMatcher<T2> AddMatcher<T2>(T expression, System.Func<T, System.Collections.Generic.IList<T2>> elementsGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params)
            where T2 : JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode { }
    }
    public abstract class VBExpressionMatcher<T> : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBElementMatcher<T>
        where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression
    {
        protected VBExpressionMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode GetExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class VBIdentifierMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class VBLiteralExpressionMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Matchers.VBExpressionMatcher<JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression>
    {
        public VBLiteralExpressionMatcher(JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression expression, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Parsers
{
    
    public class VBStructuralSearchExpressionPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public static readonly JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Parsers.VBStructuralSearchExpressionPatternBuilder Instance;
        public VBStructuralSearchExpressionPatternBuilder(bool guessPlaceholders = False) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders
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
        public ArgumentPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> enumerable) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class DeclaredTypePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.PlaceholderTypeMatcherBase
    {
        public DeclaredTypePlaceholderMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder placeholder, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage> func) { }
        public override JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ElementPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public ElementPlaceholder(string name, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override string Description { get; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ElementPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class ElementPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        public ElementPlaceholderMatcher(string name, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class ExpressionPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public const string TAG_NAME = "ExpressionPlaceholder";
        public ExpressionPlaceholder(string name) { }
        public ExpressionPlaceholder(string name, string exprType) { }
        public ExpressionPlaceholder(string name, string exprType, bool exact) { }
        public ExpressionPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool ExactType { get; set; }
        public string ExpressionType { get; set; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ExpressionPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class ExpressionPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase
    {
        public ExpressionPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class ExpressionPlaceholderTypeMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.PlaceholderTypeMatcherBase
    {
        public ExpressionPlaceholderTypeMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder) { }
        public override JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class IdentifierPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public const string TAG_NAME = "IdentifierPlaceholder";
        public IdentifierPlaceholder(string name) { }
        public IdentifierPlaceholder(string name, string nameRegex, bool nameRegexCaseSensitive) { }
        public IdentifierPlaceholder(string name, string nameRegex, bool nameRegexCaseSensitive, string type, bool exactType) { }
        public IdentifierPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool ExactType { get; set; }
        public System.Text.RegularExpressions.Regex NameRegex { get; set; }
        public override string[] ReplacingText { get; }
        public string Type { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.IdentifierPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class IdentifierPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase
    {
        public IdentifierPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class IdentifierPlaceholderTypeMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.PlaceholderTypeMatcherBase
    {
        public IdentifierPlaceholderTypeMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder) { }
        public override JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MetaPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder
    {
        public MetaPlaceholder(string name) { }
        public string Description { get; }
        public string Name { get; }
        public string[] ReplacingText { get; }
        public System.Collections.Generic.ICollection<string> Words { get; }
        public object Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.MetaPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder ICloneable_Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public abstract class PlaceholderTypeMatcherBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderTypeMatcher
    {
        public PlaceholderTypeMatcherBase(string placeholderName, string type, bool exactType) { }
        public bool ExactType { get; }
        public string PlaceholderName { get; }
        public string ShortName { get; }
        public abstract JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public JetBrains.ReSharper.Psi.IType GetPlaceholderType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
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
        public StatementPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> enumerable) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class TypePlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public const string TAG_NAME = "TypePlaceholder";
        public TypePlaceholder(string name) { }
        public TypePlaceholder(string name, string type, bool exactType) { }
        public TypePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool ExactType { get; set; }
        public override string[] ReplacingText { get; }
        public string Type { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder other) { }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher GetDeclaredTypeMatcher(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage> func) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher GetTypeMatcher(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.IType> func) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class TypePlaceholderElementMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        public TypePlaceholderElementMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder placeholder) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> IElementMatcher_Children { get; }
        public System.Collections.Generic.IEnumerable<string> IElementMatcher_Words { get; }
        public string IPlaceholderMatcher_PlaceholderName { get; }
        public bool IElementMatcher_Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher IPlaceholderMatcher_CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class TypePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.PlaceholderTypeMatcherBase
    {
        public TypePlaceholderMatcher(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder placeholder, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.IType> getElementType) { }
        public override JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.VB.StructuralSearch
{
    
    public class VBCommentPatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternLexer
    {
        protected override JetBrains.ReSharper.Psi.LanguageService LanguageService { get; }
        protected override bool MetaPlaceholderSupported { get; }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder GetMetaPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class VBDeclaredTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.TypeMatcherBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected override string TypeName { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage> func, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected override bool CheckSubstition(JetBrains.ReSharper.Psi.Resolve.ISubstitution subst, JetBrains.ReSharper.Psi.ITypeElement elDeclaredTypeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected override JetBrains.ReSharper.Psi.IType GetElementType(T element) { }
        protected override JetBrains.ReSharper.Psi.IType GetOriginalType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class VBExpressionStructuralMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralMatcher
    {
        public VBExpressionStructuralMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher) { }
        public override System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class VBMatcherBuilder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class VBNullableTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
        where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode
    {
        public VBNullableTypeMatcher(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> func, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class VBPatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternLexer
    {
        protected override JetBrains.ReSharper.Psi.LanguageService LanguageService { get; }
        protected override bool MetaPlaceholderSupported { get; }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IUnknownPlaceholder CreateUnknownPlaceholder(string name) { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder GetMetaPlaceholder(string name) { }
        protected override bool IsErrorElementBeforeOffset(JetBrains.ReSharper.Psi.Tree.IErrorElement errorElement, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult TryParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Func<JetBrains.ReSharper.Psi.Parsing.IParser, JetBrains.ReSharper.Psi.Tree.ITreeNode> createElement, int realShift = 0, bool createUnknownPlaceholders = False, bool deleteUnusedPlaceholders = False) { }
    }
    public class VBReplacePatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexer { }
    public class VBSequenceMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.SequenceMatcher<T>
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public VBSequenceMatcher(System.Collections.Generic.IEnumerable<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public VBSequenceMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<T>> elementsGetter, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class VBStatementSequenceMatcher : JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.VBSequenceMatcher<JetBrains.ReSharper.Psi.VB.Tree.IVBStatement>
    {
        public VBStatementSequenceMatcher(JetBrains.ReSharper.Psi.VB.Tree.IBlock block, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    [JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearcherFactoryAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBStructuralSearcherFactory : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory
    {
        public VBStructuralSearcherFactory(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.VBStructuralSearchPatternFromCodeCreator patternFromCodeCreator) { }
        public bool IsInternal { get; }
        public bool SupportsIgnoreUnmatched { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
        public void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> targets, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
    public class VBStructuralSearchPattern : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern
    {
        public VBStructuralSearchPattern(string pattern) { }
        public VBStructuralSearchPattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders1) { }
        public VBStructuralSearchPattern(string pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders1) { }
        public VBStructuralSearchPattern() { }
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
        public object Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder builder) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.VBStructuralSearchPattern other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool GuessPlaceholders() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern ICloneable_Clone() { }
        public void ReadPlaceholders(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo> placeholderInfos) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBStructuralSearchPatternFromCodeCreator : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternFromCodeCreator
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
    }
    public class VBStructuralSearchPatternPresenter : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.StructuralSearchPatternPresenterBase
    {
        public VBStructuralSearchPatternPresenter(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
        protected override string GetListReplacement(System.Collections.IEnumerable enumerable) { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string text, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
    public class VBStructuralSearchReplacer
    {
        public static void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result, string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, bool formatAfterReplace, bool shortenReferences) { }
        public static void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> structuralMatchResults, string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, bool formatAfterReplace, bool shortenReferences) { }
    }
    public class VBTypeMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.TypeMatcherBase<T>
        where T :  class, JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode
    {
        protected override string TypeName { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> getElementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher Build(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsageNode, System.Func<T, JetBrains.ReSharper.Psi.IType> func, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        protected override bool CheckEmptySubstitution(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override JetBrains.ReSharper.Psi.IType GetElementType(T element) { }
        protected override JetBrains.ReSharper.Psi.IType GetOriginalType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}