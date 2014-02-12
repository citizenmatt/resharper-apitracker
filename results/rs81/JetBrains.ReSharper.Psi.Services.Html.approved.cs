[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.Html.CachingLexer
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlCachingLexerService : JetBrains.ReSharper.Psi.Services.MixedCachingLexerService { }
}
namespace JetBrains.ReSharper.Psi.Services.Html.StructuralSearch
{
    
    public class HtmlAttributeMatcher : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.IHtmlAttributeMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlAttributeMatcher([JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher valueMatcher, bool skipQuotes, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlTagHeaderMatcher ParentMatcher { get; set; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlAttributeValueMatcher : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.IHtmlAttributeValueMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlAttributeValueMatcher([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string valueText, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlAttributeMatcher ParentMatcher { get; set; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlDefaultMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlDefaultMatcher(string text) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class static HtmlEnumerateUtils
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode> EnumerateTagContent(this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker parent, bool recursive = False) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode> ExpandUnclosedTags(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode node) { }
    }
    public class HtmlFooterMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlFooterMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher nameMatcher) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class static HtmlMatcherBuilder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public static System.Collections.Generic.IEnumerable<string> ExtractWords(string text) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlMatcherBuilderVisitor : JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher>
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitHtmlAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitHtmlTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitTagAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitTagFooter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitTagHeader(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher VisitTokenNode(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlPlaceholderGuesser : JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>
    {
        protected virtual JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateTagPlaceholder(string name) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder VisitHtmlAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder VisitTagAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage context) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder VisitTokenNode(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage context) { }
    }
    public class HtmlSequenceStructuralMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequenceStructuralMatcher<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode>
    {
        public HtmlSequenceStructuralMatcher(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlTagContentMatcher matcher) { }
        protected override bool IsFilteredNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlStructuralMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralMatcher
    {
        public HtmlStructuralMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher) { }
        public override System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearcherFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlStructuralSearcherFactory : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory
    {
        public HtmlStructuralSearcherFactory(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, JetBrains.Application.Components.IComponentContainer container, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralSearchPatternFromCodeCreator patternFromCodeCreator) { }
        public bool IsInternal { get; }
        public bool SupportsIgnoreUnmatched { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
        public void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> targets, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
    public class HtmlStructuralSearchPattern : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern>, System.ICloneable
    {
        public HtmlStructuralSearchPattern(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, string textPattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public HtmlStructuralSearchPattern(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public HtmlStructuralSearchPattern(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, string textPattern = "", System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders = null, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams params = null) { }
        public HtmlStructuralSearchPattern(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
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
        public bool Equals(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralSearchPattern other) { }
        public override bool Equals(object obj) { }
        public bool GeneratePlaceholders(bool deleteUnusedPlaceholders, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder> metaplaceholders) { }
        public override int GetHashCode() { }
        public bool GuessPlaceholders() { }
        public void ReadPlaceholders(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo> placeholderInfos) { }
    }
    public class HtmlStructuralSearchPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public HtmlStructuralSearchPatternBuilder(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, bool generatePlaceholders, bool deleteUnusedPlaceholders, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder> metaplaceholders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlStructuralSearchPatternFromCodeCreator : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternFromCodeCreator
    {
        public HtmlStructuralSearchPatternFromCodeCreator(JetBrains.ReSharper.Psi.Html.HtmlLanguage language) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
    }
    public class HtmlStructuralSearchPatternPresenter : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.StructuralSearchPatternPresenterBase
    {
        public HtmlStructuralSearchPatternPresenter(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralSearchPattern pattern) { }
        protected override string GetListReplacement(System.Collections.IEnumerable enumerable) { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string text, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HtmlStructuralSearchReplacer
    {
        public HtmlStructuralSearchReplacer(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult match, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
        public void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> matches, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
    public class HtmlTagContentMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.SequenceMatcher<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode>
    {
        public HtmlTagContentMatcher(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> nodeMatchers, bool ignoreUnmatched) { }
        public override bool CountedAsOccurence(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode element) { }
    }
    public class HtmlTagHeaderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlTagHeaderMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher nameMatcher, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> attributeMatchers, bool ignoreUnmatched) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.UnorderedSetMatcher SeqAttributeMatcher { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlTagHeaderStructuralMatcher : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralMatcher
    {
        public HtmlTagHeaderStructuralMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher) { }
    }
    public class HtmlTagMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlTagMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher headerMatcher, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> nodeMatchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher footerMatcher, bool selfClosed, bool isStrict, bool ignoreUnmatched) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlTagNameMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlTagNameMatcher(string name) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlTagStructuralMatcher : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralMatcher
    {
        public HtmlTagStructuralMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher) { }
    }
    public class HtmlTextMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlTextMatcher(string text) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public interface IHtmlAttributeValueMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlAttributeMatcher ParentMatcher { get; set; }
    }
    public interface IPlaceholderFactory
    {
        string TagName { get; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info);
    }
    public abstract class PlaceholderFactoryBase<TPlaceholder> : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.IPlaceholderFactory
        where TPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, new ()
    {
        public virtual string TagName { get; }
        public abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info);
    }
}
namespace JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders
{
    
    public class HtmlAttributeSequencePlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderBase
    {
        public HtmlAttributeSequencePlaceholder() { }
        public HtmlAttributeSequencePlaceholder(string name, string allowedNamesRegexp = null, bool invertRegex = False, int minimalOccurences = -1, int maximalOccurences = -1) { }
        public HtmlAttributeSequencePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public string AllowedNamesRegex { get; set; }
        public override string Description { get; }
        protected override string EntityName { get; }
        public bool InvertRegex { get; set; }
        public override string[] ReplacingText { get; }
        protected override string TagName { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlAttributeSequencePlaceholderFactory : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.PlaceholderFactoryBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder>
    {
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
    }
    public class HtmlAttributeSequencePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderMatcherBase, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.IHtmlAttributeMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public HtmlAttributeSequencePlaceholderMatcher(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.Util.Key<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholderMatcher.AdditionalAttributeValues> Key { get; }
        public JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlTagHeaderMatcher ParentMatcher { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public class AdditionalAttributeValues : System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholderMatcher.AdditionalAttributeValues.AttributeStorage>
        {
            public void AddAttribute(string name, string quote, string value) { }
            public class AttributeStorage
            {
                public string Name { get; set; }
                public string Quote { get; set; }
                public string Value { get; set; }
            }
        }
    }
    public class HtmlAttributeValuePlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        public HtmlAttributeValuePlaceholder(string name, string regex = null, bool invertRegex = False) { }
        public HtmlAttributeValuePlaceholder() { }
        public HtmlAttributeValuePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        public bool InvertRegex { get; set; }
        public int MaximalOccurences { get; }
        public int MinimalOccurences { get; }
        public string Regex { get; set; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlAttributeValuePlaceholderFactory : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.PlaceholderFactoryBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder>
    {
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
    }
    public class HtmlAttributeValuePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.IHtmlAttributeValueMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher
    {
        public HtmlAttributeValuePlaceholderMatcher(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public int MaximalOccurences { get; }
        public int MinimalOccurences { get; }
        public JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlAttributeMatcher ParentMatcher { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class HtmlContentSequencePlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderBase
    {
        public HtmlContentSequencePlaceholder() { }
        public HtmlContentSequencePlaceholder(string name, string regex = null, bool tagsAllowed = True, string cssSelector = null, bool invertRegex = False, int minimalOccurences = -1, int maximalOccurences = -1, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder.CodeAllowedType codeAllowed = 0, string codeRegex = null) { }
        public HtmlContentSequencePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder.CodeAllowedType CodeAllowed { get; set; }
        public string CodeRegex { get; set; }
        public string CssSelector { get; set; }
        public override string Description { get; }
        protected override string EntityName { get; }
        public bool InvertRegex { get; set; }
        public string Regex { get; set; }
        public override string[] ReplacingText { get; }
        protected override string TagName { get; }
        public bool TagsAllowed { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
        public enum CodeAllowedType
        {
            Allowed = 0,
            Prohibited = 1,
            MustMatchRegex = 2,
            MustNotMatchRegex = 3,
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlContentSequencePlaceholderFactory : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.PlaceholderFactoryBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder>
    {
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
    }
    public class HtmlContentSequencePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderMatcherBase, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatchChecker
    {
        public HtmlContentSequencePlaceholderMatcher(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool ShouldCheckForMatching { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool VerifyMatchSafely<T>(System.Collections.Generic.IList<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, int fromElement, int count)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class HtmlMetaPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        public HtmlMetaPlaceholder(string name) { }
        public string ComputedReplacingText { get; set; }
        public string Description { get; }
        public string Name { get; }
        public string[] ReplacingText { get; }
        public System.Collections.Generic.ICollection<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlMetaPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class HtmlTagPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        protected const string CSS_SELECTOR_ATTRIBUTE = "CssSelector";
        protected const string NAME_ATTRIBUTE = "Name";
        public HtmlTagPlaceholder(string name, string cssSelector = null) { }
        public HtmlTagPlaceholder() { }
        public HtmlTagPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
        public string CssSelector { get; set; }
        public override string Description { get; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTagPlaceholderFactory : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.PlaceholderFactoryBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder>
    {
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
    }
    public class HtmlTagPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase
    {
        public HtmlTagPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder htmlTagPlaceholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        protected virtual bool CheckMatch(JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
}