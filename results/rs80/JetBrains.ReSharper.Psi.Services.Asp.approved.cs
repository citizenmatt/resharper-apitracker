[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.Asp
{
    
    public interface IAspLanguageSpecificUtil
    {
        bool IsPageClassDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration);
        bool IsUserTextDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
}
namespace JetBrains.ReSharper.Psi.Services.Asp.StructuralSearch
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspPlaceholderGuesser : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlPlaceholderGuesser
    {
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateTagPlaceholder(string name) { }
    }
    [JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearcherFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspStructuralSearcherFactory : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralSearcherFactory
    {
        public AspStructuralSearcherFactory(JetBrains.ReSharper.Psi.Asp.AspLanguage language, JetBrains.Application.Components.IComponentContainer container, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.HtmlStructuralSearchPatternFromCodeCreator creator) { }
    }
    public class AspTagPlaceholder : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder
    {
        public AspTagPlaceholder(string name, string cssSelector = null, string controlType = null, bool exactType = True) { }
        public AspTagPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
        public AspTagPlaceholder() { }
        public string ControlType { get; set; }
        public override string Description { get; }
        public bool ExactType { get; set; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.Asp.StructuralSearch.AspTagPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspTagPlaceholderFactory : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholderFactory
    {
        public override string TagName { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreatePlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo info) { }
    }
    public class AspTagPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholderMatcher
    {
        public AspTagPlaceholderMatcher(JetBrains.ReSharper.Psi.Services.Asp.StructuralSearch.AspTagPlaceholder placeholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        protected override bool CheckMatch(JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public override bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class AspTagPlaceholderTypeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderTypeMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        public AspTagPlaceholderTypeMatcher(JetBrains.ReSharper.Psi.Services.Asp.StructuralSearch.AspTagPlaceholder placeholder) { }
        public bool ExactType { get; }
        public string PlaceholderName { get; }
        public string ShortName { get; }
        public JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.IType GetPlaceholderType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
}