[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Intentions.Html.resources.Actions.xml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Html.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts html entity from numbered form to named and visa versa", Group="HTML", Name="Convert html entity")]
    public class ConvertHtmlEntityContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ConvertHtmlEntityContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Splits a self-closing tag into opening and closing tags", Group="HTML", Name="Expand empty tag", Priority=0)]
    public class ExpandEmptyTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ExpandEmptyTagContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static HtmlContextActions
    {
        public const string GroupID = "HTML";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts from empty opening and closing tags into empty tag", Group="HTML", Name="Collapse empty tag")]
    public class MakeEmptyTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MakeEmptyTagContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class RemoveAttributeContextActionBase<TAttribute> : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
        where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
    {
        protected RemoveAttributeContextActionBase(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes tag attribute", Group="HTML", Name="Remove tag attribute", Priority=-5)]
    public class RemoveTagAttributeContextAction : JetBrains.ReSharper.Intentions.Html.ContextActions.RemoveAttributeContextActionBase<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>
    {
        public RemoveTagAttributeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes tag leaving its content intact", Group="HTML", Name="Remove tag", Priority=-5)]
    public class RemoveTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveTagContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer GetActiveTag() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ReorderAttributesContextActionBase<TAttribute, TAttributeContainer> : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
        where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
        where TAttributeContainer :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<>
    {
        protected ReorderAttributesContextActionBase(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Reorders tag attributes alphabetically", Group="HTML", Name="Reorder tag attributes", Priority=-10)]
    public class ReorderTagAttributesContextAction : JetBrains.ReSharper.Intentions.Html.ContextActions.ReorderAttributesContextActionBase<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader>
    {
        public ReorderTagAttributesContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces all tags with the same name in the file with different tag", Group="HTML", Name="Replace all tags", Priority=-2)]
    public class ReplaceAllTagsContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ReplaceAllTagsContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> FilterTagPlaceholders([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer activeTag, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> tokens) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer GetActiveTag() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces tag with different tag", Group="HTML", Name="Replace tag", Priority=-1)]
    public class ReplaceTagContextAction : JetBrains.ReSharper.Intentions.Html.ContextActions.ReplaceAllTagsContextAction
    {
        public ReplaceTagContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> FilterTagPlaceholders(JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer activeTag, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> tokens) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Opens path mapping settings for current project", Group="HTML", Name="Edit path mapping", Priority=0)]
    public class RunPathMappingEditorContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public RunPathMappingEditorContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Html.QuickFixes.DisableWarning
{
    
    public abstract class HtmlDisableWarningByCommentActionBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected readonly string myId;
        protected HtmlDisableWarningByCommentActionBase(JetBrains.DocumentModel.DocumentRange range, string id) { }
        protected abstract string ClosingText { get; }
        protected abstract string OpeningText { get; }
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class HtmlDisableWarningByCommentActionProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public HtmlDisableWarningByCommentActionProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Html.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class HtmlConditionalCommentQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public HtmlConditionalCommentQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlConditionalCommentErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class HtmlRemoveDeadCodeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public HtmlRemoveDeadCodeQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlDeadCodeHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class HtmlTagNotClosedQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public HtmlTagNotClosedQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlTagNotClosedHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Html.QuickFixes.Import
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class HtmlChangePathMappingQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public HtmlChangePathMappingQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlPathWarningHighlighting highlighting) { }
        protected HtmlChangePathMappingQuickFix(JetBrains.ReSharper.Psi.Web.References.IIgnorablePathReference pathReferecne) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class HtmlImportPathQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public HtmlImportPathQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlPathWarningHighlighting highlighting) { }
        protected HtmlImportPathQuickFix(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReferecne) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> GetProjectItems() { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Html.Table
{
    
    public abstract class HighlightHtmlActionBase : JetBrains.ReSharper.Intentions.Html.Table.HtmlActionBase
    {
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetEntryHighlightingRages(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag element) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Highlight HTML action settings")]
    public class HighlightHtmlActionSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Explanation how to dismiss HTML highlightings is already shown")]
        public bool HintUsed { get; set; }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class HighlightHtmlActionSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public HighlightHtmlActionSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "HighlightTableColumn"})]
    public class HighlightTableColumnAction : JetBrains.ReSharper.Intentions.Html.Table.HighlightHtmlActionBase
    {
        public override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetEntryHighlightingRages(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag element) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "HighlightTableRow"})]
    public class HighlightTableRowAction : JetBrains.ReSharper.Intentions.Html.Table.HighlightHtmlActionBase
    {
        public override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
    }
    public abstract class HtmlActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public abstract void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, int> GetHtmlFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class InsertTableActionBase : JetBrains.ReSharper.Intentions.Html.Table.HtmlActionBase
    {
        public abstract bool InsertBefore { get; }
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.DocumentModel.IRangeMarker>> GetNewTags(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag cell, JetBrains.ProjectModel.IProjectFile projectFile);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InsertTableColumnBefore",
            "InsertTableColumnAfter"})]
    public class InsertTableColumnAction : JetBrains.ReSharper.Intentions.Html.Table.InsertTableActionBase
    {
        public const string AfterActionID = "InsertTableColumnAfter";
        public const string BeforeActionID = "InsertTableColumnBefore";
        public InsertTableColumnAction(string actionId) { }
        public override bool InsertBefore { get; }
        public override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.DocumentModel.IRangeMarker>> GetNewTags(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag entry, JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Insert table column after", Group="HTML", Name="Insert table column after", Priority=50)]
    public class InsertTableColumnAfterContextAction : JetBrains.ReSharper.Intentions.Html.Table.InsertTableContextActionBase
    {
        public InsertTableColumnAfterContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> provider) { }
        protected override string ActionId { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Insert table column before", Group="HTML", Name="Insert table column before", Priority=50)]
    public class InsertTableColumnBeforeContextAction : JetBrains.ReSharper.Intentions.Html.Table.InsertTableContextActionBase
    {
        public InsertTableColumnBeforeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> provider) { }
        protected override string ActionId { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
    }
    public abstract class InsertTableContextActionBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected InsertTableContextActionBase(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> provider) { }
        protected abstract string ActionId { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public abstract string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset);
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InsertTableRowBefore",
            "InsertTableRowAfter"})]
    public class InsertTableRowAction : JetBrains.ReSharper.Intentions.Html.Table.InsertTableActionBase
    {
        public const string AfterActionID = "InsertTableRowAfter";
        public const string BeforeActionID = "InsertTableRowBefore";
        public InsertTableRowAction(string actionId) { }
        public override bool InsertBefore { get; }
        public override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.DocumentModel.IRangeMarker>> GetNewTags([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag row, JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Insert table row after", Group="HTML", Name="Insert table row after", Priority=50)]
    public class InsertTableRowAfterContextAction : JetBrains.ReSharper.Intentions.Html.Table.InsertTableContextActionBase
    {
        public InsertTableRowAfterContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> provider) { }
        protected override string ActionId { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Insert table row before", Group="HTML", Name="Insert table row before", Priority=50)]
    public class InsertTableRowBeforeContextAction : JetBrains.ReSharper.Intentions.Html.Table.InsertTableContextActionBase
    {
        public InsertTableRowBeforeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> provider) { }
        protected override string ActionId { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetEntry(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
    }
    public class static TableActionsUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetColumn([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag cell) { }
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetCurrentCell([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetCurrentRow([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, int offset) { }
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetNewRow([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag row) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetRow([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag cell) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetSpacesBeforeTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
    }
}