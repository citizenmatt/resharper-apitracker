[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Xml.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces continuous CData elements with their escaped content", Group="XML", Name="Convert CData to text")]
    public class CDataToTextContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public CDataToTextContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts tag attribute to nested element.", Group="XML", Name="Convert attribute to nested element")]
    public class ConvertAttributeToTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ConvertAttributeToTagContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts nested tag to an attribute of enclosing tag.", Group="XML", Name="Convert tag to attribute", Priority=-1)]
    public class ConvertTagToAttributeContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ConvertTagToAttributeContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Splits empty tag to opening and closing tags", Group="XML", Name="Expand empty tag", Priority=-4)]
    public class ExpandEmptyTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ExpandEmptyTagContextAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds or updates module qualification for the type reference.", Group="XML", Name="Add module qualification")]
    public class FixModuleQualificationContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public static readonly JetBrains.Util.Key<System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute>> KEY;
        public FixModuleQualificationContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts from empty opening and closing tags into empty tag", Group="XML", Name="Collapse empty tag", Priority=0)]
    public class MakeEmptyTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public MakeEmptyTagContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes all the tags with specified name but keeps its children intact", Group="XML", Name="Remove all tags with specified name and promote their children", Priority=-9)]
    public class RemoveAllTagsAndKeepChildrenContextAction : JetBrains.ReSharper.Intentions.Xml.ContextActions.RemoveTagAndKeepChildrenContextAction
    {
        public RemoveAllTagsAndKeepChildrenContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes the attribute from tag", Group="XML", Name="Remove tag attribute", Priority=-3)]
    public class RemoveAttributeAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveAttributeAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes the tag but keeps its children intact", Group="XML", Name="Remove tag and promote its children", Priority=-9)]
    public class RemoveTagAndKeepChildrenContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider Provider;
        public RemoveTagAndKeepChildrenContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetTagToRemove([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider context) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
        protected static void RemoveTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces all attributes with the same name in the file for current tag with diffe" +
        "rent name", Group="XML", Name="Replace all attributes", Priority=-8)]
    public class ReplaceAllAttributesContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ReplaceAllAttributesContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override void ExecuteBeforeProgressAndTransaction(JetBrains.ProjectModel.ISolution solution) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    public class ReplaceAllAttributesForm : System.Windows.Forms.Form
    {
        protected System.Windows.Forms.Label myLabel;
        public ReplaceAllAttributesForm() { }
        public ReplaceAllAttributesForm(string attributeName, string tagName, System.Collections.Generic.ICollection<string> suggestedNames) { }
        public string NewName { get; }
        public bool ReplaceInAllTags { get; }
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces all tags with the same name in the file with different tag", Group="XML", Name="Replace all tags", Priority=-11)]
    public class ReplaceAllTagsContextAction : JetBrains.ReSharper.Intentions.Xml.ContextActions.ReplaceTagContextAction
    {
        public ReplaceAllTagsContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replace tag with different tag", Group="XML", Name="Replace tag", Priority=-10)]
    public class ReplaceTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider Provider;
        public ReplaceTagContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetTagToReplace(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider context, out JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier name) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Surrounds text with CData element, unescapes text if necessary", Group="XML", Name="Convert text to CData")]
    public class TextToCDataContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public TextToCDataContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected static JetBrains.ReSharper.Psi.TreeTextRange GetTextRange(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider context, out string text) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder dataHolder) { }
    }
    public class static XmlContextActions
    {
        public const string GroupID = "XML";
    }
}
namespace JetBrains.ReSharper.Intentions.Xml.DisableWarning
{
    
    public abstract class DisableByCommentWarningActionBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected readonly string mySeverityId;
        protected DisableByCommentWarningActionBase(JetBrains.DocumentModel.DocumentRange highlightingRange, [JetBrains.Annotations.NotNullAttribute()] string severityId) { }
        protected abstract string ClosingText { get; }
        protected abstract string OpeningText { get; }
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.XmlProjectFileType))]
    public class DisableByCommentWarningActionProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public DisableByCommentWarningActionProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Xml.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CloseTagsQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CloseTagsQuickFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlTagIsNotClosedHighlighting2 highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MisplacedCommentQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MisplacedCommentQuickFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlMisplacedCommentErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class TagFooterFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public TagFooterFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlTagFooterErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XmlPIQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XmlPIQuickFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlPIErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XmlSyntaxErrorQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XmlSyntaxErrorQuickFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlSyntaxErrorHighlighting errorHighlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XmlTagIsNotClosedQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XmlTagIsNotClosedQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlTagIsNotClosedHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}