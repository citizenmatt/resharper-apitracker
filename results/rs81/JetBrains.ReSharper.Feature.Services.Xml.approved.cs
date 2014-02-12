[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Xml.Bulbs
{
    
    public interface IXmlContextActionProvider
    {
        System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace);
        JetBrains.DocumentModel.DocumentRange[] GetTagNameDocumentRanges(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace);
        JetBrains.ReSharper.Psi.TreeTextRange[] GetTagNameRanges(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace);
    }
    public class XmlContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Feature.Services.Xml.Bulbs.IXmlContextActionProvider ContextActionProvider;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes;
        protected XmlContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, JetBrains.ReSharper.Feature.Services.Xml.Bulbs.IXmlContextActionProvider contextActionProvider) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T FindNodeAtCaret<T>()
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T FindReferenceAtCaret<T>()
            where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public bool IsInRealProject() { }
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider>
        {
            public static readonly JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider, JetBrains.ReSharper.Psi.Xml.XmlLanguage, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider> GetContextKey() { }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlContextActionProvider : JetBrains.ReSharper.Feature.Services.Xml.Bulbs.IXmlContextActionProvider
    {
        public virtual System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace) { }
        public JetBrains.DocumentModel.DocumentRange[] GetTagNameDocumentRanges(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace) { }
        public virtual JetBrains.ReSharper.Psi.TreeTextRange[] GetTagNameRanges(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.Impl
{
    
    public class static XmlCompleteTagFooterUtil
    {
        public static void GetTagFooterLookupItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, bool unclosedOnly, bool currentOnly) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlFooterItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTypeNameCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext>
    {
        public XmlTypeNameCompletionContext(JetBrains.ReSharper.Psi.Xml.XmlLanguage language, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion
{
    
    public class XmlCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public XmlCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext unterminatedContext) { }
        public override string ContextId { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext UnterminatedContext { get; }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class XmlCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext CreateSpecificCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext unterminatedContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext CreateUnterminatedContext(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetElementRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile IsAvailableImpl(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    public class XmlReparsedCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public XmlReparsedCodeCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.CodeStructure
{
    
    public class XmlCodeStructureElement<TXmlTag> : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement
        where TXmlTag :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public XmlCodeStructureElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, [JetBrains.Annotations.NotNullAttribute()] TXmlTag tag, JetBrains.UI.Icons.IconId image = null, bool showFirstAttributeAsKey = False) { }
        public JetBrains.UI.Icons.IconId Image { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public TXmlTag Tag { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        protected override void DumpSelf(System.IO.TextWriter builder) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
        public override JetBrains.Util.TextRange GetTextRange() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlCodeStructureProvider : JetBrains.ReSharper.Feature.Services.CodeStructure.IPsiFileCodeStructureProvider
    {
        public virtual JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        protected virtual void CreateElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement CreateRootElement(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file) { }
        protected virtual void ProcessTagContainer(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer tagContainer) { }
    }
    public class XmlCodeStructureRootElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement
    {
        public XmlCodeStructureRootElement(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile File { get; }
    }
    public class static XmlCodeStructureUtil
    {
        public static readonly string[] KEY_ATTRIBUTES;
        public static System.Collections.Generic.IList<JetBrains.DocumentModel.DocumentRange> GetTagNavigationRanges(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public static JetBrains.UI.RichText.RichText GetXmlTagPresentationText<TTag>([JetBrains.Annotations.NotNullAttribute()] TTag tag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute keyAttribute)
            where TTag :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
    }
    public class XmlDeclarationTagCodeStructureElement<T> : JetBrains.ReSharper.Feature.Services.Xml.CodeStructure.XmlCodeStructureElement<T>
        where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Tree.IDeclaration
    {
        public XmlDeclarationTagCodeStructureElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, T tag) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
    }
    public class XmlTagAspects<TXmlTag> : JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect
        where TXmlTag :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public static readonly string[] KEY_ATTRIBUTES;
        public XmlTagAspects([JetBrains.Annotations.NotNullAttribute()] TXmlTag tag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Icons.IconId image, bool showFirstAttributeAsKey = False) { }
        public bool InitiallyExpanded { get; }
        public JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        public TXmlTag Tag { get; }
        [JetBrains.Annotations.PureAttribute()]
        public virtual System.Collections.Generic.IList<string> CalculateQuickSearchTexts() { }
        public bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public bool CanRename() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute GetKeyAttribute() { }
        protected virtual JetBrains.DocumentModel.DocumentRange GetNameDocumentRange() { }
        public virtual JetBrains.DocumentModel.DocumentRange[] GetNavigationRanges() { }
        public System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetSourceFile() { }
        public virtual System.Collections.Generic.IList<JetBrains.DocumentModel.DocumentRange> GetTagNavigationRanges(TXmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.UI.RichText.RichText GetXmlTagPresentationText(TXmlTag tag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute keyAttribute) { }
        public string InitialName() { }
        public void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public virtual void Present(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        public virtual void Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.UI.TreeView.PresentationState state) { }
        public void Rename(string newName) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.Comment
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlBlockCommentActionProvider : JetBrains.ReSharper.Feature.Services.Comment.IBlockCommentActionProvider
    {
        public XmlBlockCommentActionProvider(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public string EndBlockCommentMarker { get; }
        public string NestedEndBlockCommentMarker { get; }
        public string NestedStartBlockCommentMarker { get; }
        public string StartBlockCommentMarker { get; }
        public JetBrains.Util.TextRange GetBlockComment(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        public int InsertBockCommentPosition(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, int position) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlLineCommentActionProvider : JetBrains.ReSharper.Feature.Services.Comment.ILineCommentActionProvider
    {
        public XmlLineCommentActionProvider(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes) { }
        public string EndLineCommentMarker { get; }
        public string StartLineCommentMarker { get; }
        public JetBrains.Util.TextRange GetLineCommentRange(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.Util.TextRange lineRange, out int startCommentLength, out int endCommentLength, out bool doNotUncomment) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class XmlMatchingBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ContextHighlighterBase
    {
        protected override void CollectHighlightings(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.DataConstants
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlDataRules
    {
        public XmlDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionman) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class XmlGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.NonCachedFileMemberProvider<JetBrains.ReSharper.Psi.Xml.XmlLanguage> { }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.Options
{
    
    public class static XmlTypingAssistOptions<TSettings>
        where TSettings : JetBrains.ReSharper.Feature.Services.Xml.Options.XmlTypingAssistSettings
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<TSettings, bool>> ChangeTagNameTracking;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings), "XML typing assistance settings", KeyNameOverride="Xml")]
    public class XmlTypingAssistSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Synchronous changing of matching tag")]
        public bool ChangedTagNameTracking;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.RearrangeCode
{
    
    public class RearrangeableAttribute : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementAppendRemove<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag>
    {
        public RearrangeableAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        protected override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag Parent { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        protected override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute AddAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute child, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute anchor) { }
        protected override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute AddBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute child, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute anchor) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> GetChildren(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parent) { }
        protected override void RemoveChild(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute child) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableTag : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
    {
        public RearrangeableTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override string Title { get; }
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag XmlTag { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.DtdProjectFileType))]
    public class DtdSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider
    {
        public DtdSelectEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    public struct NodePart
    {
        public readonly JetBrains.ReSharper.Psi.Tree.ITreeNode Node;
        public readonly JetBrains.ReSharper.Psi.TreeTextRange Range;
        public NodePart(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public NodePart(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class XmlDotSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.DotSelection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
    {
        public XmlDotSelection(JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider provider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.TreeOffset offset, bool selectBetterToken, bool useCamelHumps) { }
        protected JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenType { get; }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTokenPartSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTreeNodeSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetParentInternal(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override bool IsLiteralToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsNewLineToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsSpaceToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsWordToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.XmlProjectFileType))]
    public class XmlSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider
    {
        public XmlSelectEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange BuildCommentSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange BuildTreeNodeSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateDotSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.TreeOffset treeOffset, bool selectBetterToken, bool doUseCamelHumps) { }
        protected bool DoUseCamelHumps(JetBrains.ReSharper.Psi.Tree.ITreeNode fileNode) { }
        public virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange ExtendSelectionRange(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        public virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public virtual bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class XmlTokenPartSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TokenPartSelection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
    {
        protected readonly JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes myXmlTokenType;
        public XmlTokenPartSelection(JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider provider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        protected static bool BufferEndsWith(JetBrains.Text.IBuffer buffer, string s) { }
        protected virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTokenPartSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    public class XmlTreeNodeSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TreeNodeSelection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
    {
        public XmlTreeNodeSelection(JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider provider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public class XmlTreeRangeSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TreeRangeSelection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
    {
        public XmlTreeRangeSelection(JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider provider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public class XmlTreeRangeWithPartsSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.SelectedRangeBase<JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile>
    {
        public XmlTreeRangeWithPartsSelection(JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider provider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.NodePart first, JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.NodePart last) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.DefaultTodoContentsProvider
    {
        public XmlTodoContentsProvider(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ChangedTagNameTracker : JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.TagMarkers> ChangedTagNameDataKey;
        public static readonly JetBrains.Util.Key UseLexerForTestsKey;
        public ChangedTagNameTracker(
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, 
                    JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, 
                    JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, 
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.TextControl.ITextControlManager textControlManager, 
                    JetBrains.Application.IShellLocks shellLocks, 
                    JetBrains.ActionManagement.IActionManager actionManager, 
                    JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, 
                    JetBrains.DocumentManagers.DocumentManager documentManager, 
                    JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, 
                    JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, 
                    JetBrains.ReSharper.Psi.LanguageManager languageManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        public JetBrains.Application.CommandProcessing.ICommandProcessor CommandProcessor { get; set; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; set; }
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        protected virtual JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.ChangedTagNameTracker.MarkerFindResults FindMarkersViaLexer(JetBrains.TextControl.ITextControl textControl, int caretPosition) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.ChangedTagNameTracker.MarkerFindResults FindMarkersViaPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.TextControl.ITextControl textControl, int caretPosition) { }
        protected JetBrains.ReSharper.Psi.Parsing.CachingLexer GetCachingLexer(JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.TagMarkers GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder dataHolder) { }
        public void HandleAction(JetBrains.TextControl.ITextControl textControl, System.Action action, System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> selRangeConverter, bool shouldReCheckAfterNoMarkers) { }
        protected bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static void ProcessMarkers(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, System.Action action) { }
        public bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public static void SetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder dataHolder, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.TagMarkers markers) { }
        protected class MarkerFindResults
        {
            public static readonly JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.ChangedTagNameTracker.MarkerFindResults Unsuccessful;
            public MarkerFindResults(bool isHeader, string tagName, JetBrains.Util.TextRange secondRange, JetBrains.Util.TextRange tokenRange) { }
            public bool IsHeader { get; }
            public JetBrains.Util.TextRange SecondRange { get; }
            public bool Success { get; }
            public string TagName { get; }
            public JetBrains.Util.TextRange TokenRange { get; }
        }
    }
    public interface IXmlChangedTagNameTrackerSettingsProvider
    {
        bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.ISettingsStore settingsStore);
    }
    public class TagMarkers
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.TagMarkers DEFAULT;
        public TagMarkers(string tagName, JetBrains.DocumentModel.IRangeMarker firstTagNameRange, JetBrains.DocumentModel.IRangeMarker secondTagNameRange, bool changeTrackerCancelled, bool firstTagIsHeader) { }
        public int CaretPosition { get; set; }
        public string ChangedTagName { get; set; }
        public bool ChangeTrackerCancelled { get; set; }
        public bool FirstTagIsHeader { get; set; }
        public JetBrains.DocumentModel.IRangeMarker FirstTagNameRange { get; set; }
        public bool IsProcessingCommand { get; set; }
        public JetBrains.DocumentModel.IRangeMarker SecondTagNameRange { get; set; }
        public string TagName { get; set; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlChangedTagNameTrackerSettingsProvider : JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.IXmlChangedTagNameTrackerSettingsProvider
    {
        public virtual bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XmlTypingAssist : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<JetBrains.ReSharper.Psi.Xml.XmlLanguage, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        public XmlTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist skippingTypingAssist, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected bool HandleDelPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleSlash(JetBrains.TextControl.ITypingContext typingContext) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.Util
{
    
    public class TypingAssistUtil
    {
        public static bool GetFooterByHeader(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokens, JetBrains.ReSharper.Feature.Services.Xml.Util.TypingAssistUtil.TagNameContainerInfo header) { }
        public static bool GetHeaderByFooter(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokens, JetBrains.ReSharper.Feature.Services.Xml.Util.TypingAssistUtil.TagNameContainerInfo footer) { }
        public static JetBrains.ReSharper.Feature.Services.Xml.Util.TypingAssistUtil.TagNameContainerInfo GetTagNameContainerInfo(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokens) { }
        public static bool InsideTagHeader(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokens, JetBrains.TextControl.ITextControl textControl) { }
        public static bool IsRealTagHeader(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokens) { }
        public class TagNameContainerInfo
        {
            public TagNameContainerInfo() { }
            public bool Closed { get; }
            public int EndPosition { get; set; }
            public int NamePosition { get; set; }
            public bool SelfClosed { get; set; }
            public int StartPosition { get; set; }
            public string TagName { get; set; }
            public int TokenIndexForEnd { get; set; }
            public int TokenIndexForName { get; set; }
            public int TokenIndexForStart { get; set; }
            public JetBrains.ReSharper.Feature.Services.Xml.Util.TypingAssistUtil.TagNameType Type { get; set; }
        }
        public enum TagNameType
        {
            Header = 0,
            Footer = 1,
        }
    }
    public class static XmlContextUtil
    {
        public static System.Collections.Generic.ICollection<string> GetAttributeNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, string tagName) { }
        public static System.Collections.Generic.ICollection<string> GetTagNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file) { }
    }
}