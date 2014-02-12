[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Html.Javascript.CustomReferences
{
    
    public class FileReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FileReferenceFactoryProvider : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public sealed class JavaScriptFileReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileReference<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode, JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode>
    {
        public JavaScriptFileReference(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode owner, JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode token, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool IsWebRootPathSupported() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public JetBrains.ReSharper.Feature.Services.Html.Javascript.CustomReferences.JavaScriptFileReference SetText(string text) { }
        public JetBrains.ReSharper.Feature.Services.Html.Javascript.CustomReferences.JavaScriptFileReference SetText(string text, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptFileReferenceBinder : JetBrains.ReSharper.Psi.Web.References.IHtmlPathBinder
    {
        public virtual string GetTargetPath<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.TreeTextRange range, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Javascript.Services
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XmlDocReferenceDependencyProvider : JetBrains.ReSharper.Psi.JavaScript.Impl.Services.IJavaScriptDependencyProvider
    {
        public XmlDocReferenceDependencyProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.JavaScriptDependentFilesModuleFactory dependentFiles, JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetDependencies(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Javascript.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class JavaScriptHtmlTypingAssist : JetBrains.ReSharper.Feature.Services.JavaScript.TypingAssist.JavaScriptTypingAssistBase, JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist, JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssistWithBraces
    {
        public JavaScriptHtmlTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public override int TextControlToLexer(JetBrains.TextControl.ITextControl textControl, int offset) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptTagSmartEnterHandler : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ISpecialTagSmartEnterHandler
    {
        public JavaScriptTagSmartEnterHandler(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Feature.Services.Html.Javascript.TypingAssist.JavaScriptHtmlTypingAssist javaScriptHtmlTypingAssist) { }
        public bool FormatOnSmartEnter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsTagSupported(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Features.Web.JavaScriptXmlDocReferenceToFile.CodeCompletion
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupInDocCommentReference : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupInDocCommentReference(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager javaScriptIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class JavaScriptCodeCompletionContextProviderInDocComment : JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.CodeCompletionContextProviderInDocCommentBase
    {
        public JavaScriptCodeCompletionContextProviderInDocComment(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager intellisenseManager) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITokenNode GetTokenNode(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "JavaScript")]
    public class JavaScriptDocCommentsAutopopupEnabledSetting
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "In doc comments")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType InDocComments;
    }
    public class JavaScriptPathReferenceReparsedContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public JavaScriptPathReferenceReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference FindReference(JetBrains.ReSharper.Psi.TreeTextRange referenceRange, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
}