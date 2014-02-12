[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.Css.StructuralSearch
{
    
    public class CssAdjacentSiblingMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssAdjacentSiblingMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher siblingMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher nodeMatcher, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssAttributeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssAttributeMatcher(string prefix, string name, JetBrains.ReSharper.Psi.Css.Tree.AttributeMatchOperation operation, string valueText, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssChildMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssChildMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher parentMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher nodeMatcher, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssDescendantMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssDescendantMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher parentMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher nodeMatcher, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssFirstChildMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssFirstChildMatcher(bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssGeneralSiblingMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssGeneralSiblingMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher siblingMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher nodeMatcher, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssLastChildMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssLastChildMatcher(bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssNotMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssNotMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class CssRootMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssRootMatcher(bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
    public class static CssSelectorMatcherBuilder
    {
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Build([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode node, JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternMatcherBuilderParams @params) { }
    }
    public class CssSelectorStructuralMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralMatcher
    {
        public CssSelectorStructuralMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher elementMatcher) { }
        public override System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearcherFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssStructuralSearcherFactory : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory
    {
        public bool IsInternal { get; }
        public bool SupportsIgnoreUnmatched { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection) { }
        public void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> targets, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
    public class CssStructuralSearchPattern : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern>, System.ICloneable
    {
        public CssStructuralSearchPattern() { }
        public CssStructuralSearchPattern(string textPattern) { }
        public CssStructuralSearchPattern(string textPattern, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
        public CssStructuralSearchPattern(string textPattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public CssStructuralSearchPattern(string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        public CssStructuralSearchPattern(string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
        public CssStructuralSearchPattern(string textPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
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
        public bool Equals(JetBrains.ReSharper.Psi.Services.Css.StructuralSearch.CssStructuralSearchPattern other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool GuessPlaceholders() { }
        public void ReadPlaceholders(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo> placeholderInfos) { }
    }
    public class CssStructuralSearchPatternBuilder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class CssStructuralSearchPatternPresenter : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.StructuralSearchPatternPresenterBase
    {
        public CssStructuralSearchPatternPresenter(JetBrains.ReSharper.Psi.Services.Css.StructuralSearch.CssStructuralSearchPattern pattern) { }
        protected override string GetListReplacement(System.Collections.IEnumerable enumerable) { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string text, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
    }
    public class static CssStructuralSearchReplacer
    {
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult match, string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, bool formatAfterReplace, bool shortenReferences) { }
        public static void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> targets, string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, bool formatAfterReplace, bool shortenReferences) { }
    }
    public class CssTagNameMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public CssTagNameMatcher(string tagPrefix, string tagName, bool isStrict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override string ToString() { }
    }
}