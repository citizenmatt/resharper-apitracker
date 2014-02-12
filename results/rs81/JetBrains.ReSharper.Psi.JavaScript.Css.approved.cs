[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.JavaScript.Css.Injections
{
    
    public class static CssPropertyNameParser
    {
        public static bool ContainsRazorCode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static string GetCssPropetyNameForJavaScript(string name) { }
        public static string GetCssPropetyNameForJavaScriptWithUnderscore(string name) { }
        public static string GetCssPropetyNameFromJavaScript(string name) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssPropertyValueIntoJsInvocationArgumentInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssPropertyValueIntoJsObjectPropertyInitializerInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssSimpleSelectorIntoJsIndexArgumentInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssSimpleSelectorIntoJsInvocationArgumentInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Css.References
{
    
    public class CssPropertyInJsInvocationArgumentReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
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
    public class CssPropertyInJsObjectPropertyInitializerReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
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
    public class JavaScriptCssClassReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
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
    public class static JavaScriptReferenceWithTokenUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewToken<TToken>(TToken oldToken, JetBrains.Text.IBuffer buffer)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<TToken> SetText<TToken>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<TToken> reference, string newText)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string newText, TOwner elementToRemoveReferences)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
}