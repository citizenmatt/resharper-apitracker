[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.WebConfig.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inline configSource attribute", Group="Web.Config", Name="Inline configSource attribute", Priority=0)]
    public class InlineConfigSourceAttributeContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public InlineConfigSourceAttributeContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Opens path mapping settings for current project", Group="Web.Config", Name="Edit path mapping", Priority=0)]
    public class RunPathMappingEditorContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public RunPathMappingEditorContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigContextActionProvider : JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionProvider { }
    public class static WebConfigContextActions
    {
        public const string GroupId = "Web.Config";
    }
}
namespace JetBrains.ReSharper.Intentions.WebConfig.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AddModuleQualificationQuickFix : JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.WebConfigQuickFixBase
    {
        public AddModuleQualificationQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.ModuleQualificationMissingError error) { }
        public override string Text { get; }
        protected override void ExecuteInternal(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MakePathAbsoluteQuickFix : JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.WebConfigQuickFixBase
    {
        public MakePathAbsoluteQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.PathIsRelativeErrorHighlighting errorHighlighting) { }
        public override string Text { get; }
        protected override void ExecuteInternal(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RemoveRedundantTagQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RemoveRedundantTagQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.UnusedAddTagHighlighting highlighting) { }
        public RemoveRedundantTagQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.UnusedRemoveOrClearTagHighlighting highlighting) { }
        public RemoveRedundantTagQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.RedundantAddNamespaceTagHighlighting highlighting) { }
        public RemoveRedundantTagQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.RedundantLocationTagHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WebConfigChangePathMappingQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public WebConfigChangePathMappingQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathErrorHighlighting highlighting) { }
        public WebConfigChangePathMappingQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathWarningHighlighting highlighting) { }
        protected WebConfigChangePathMappingQuickFix(JetBrains.ReSharper.Psi.Web.References.IIgnorablePathReference pathReferecne) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WebConfigImportPathPoupQuickFix : JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.WebConfigImportPathQuickFix, JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction
    {
        public WebConfigImportPathPoupQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathErrorHighlighting highlighting) { }
        public WebConfigImportPathPoupQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathWarningHighlighting highlighting) { }
        public JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        public string PopupKey { get; }
        public string PopupMenuCaption { get; }
        public void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
        public void OnPopupShown(JetBrains.DataFlow.Lifetime showingLifetime) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WebConfigImportPathQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public WebConfigImportPathQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> GetProjectItems() { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WebConfigImportTypePopupQuickFix : JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.WebConfigImportTypeQuickFix, JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction
    {
        public WebConfigImportTypePopupQuickFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigTypeReference> highlighting) { }
        public JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        public string PopupKey { get; }
        public string PopupMenuCaption { get; }
        public void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
        public void OnPopupShown(JetBrains.DataFlow.Lifetime showingLifetime) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WebConfigImportTypeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public WebConfigImportTypeQuickFix(JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigTypeReference> highlighting) { }
        protected virtual string ItemFormat { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class WebConfigQuickFixBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public abstract string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract void ExecuteInternal(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
        public abstract bool IsAvailable(JetBrains.Util.IUserDataHolder cache);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WrongModuleQuickFix : JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.WebConfigQuickFixBase
    {
        public WrongModuleQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WrongModuleErrorHighlighting error) { }
        public override string Text { get; }
        protected override void ExecuteInternal(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.ConfigSource
{
    
    public class InlineConfigSourceBulbItem : JetBrains.ReSharper.Intentions.WebConfig.QuickFixes.ConfigSource.RemoveAttributeBulbItem<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute>
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag ResolvedTag;
        public InlineConfigSourceBulbItem(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute configSourceAttribute) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class RemoveAttributeBulbItem<T> : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
        where T : JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute
    {
        protected readonly T myAttribute;
        protected readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag myTag;
        public RemoveAttributeBulbItem(T attrubute) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class RemoveTagBulbItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        protected readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag myTag;
        protected readonly JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer myTagContainer;
        public RemoveTagBulbItem(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag tag) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class RemoveUnusedElements : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public RemoveUnusedElements(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute> unusedAttributes, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag> unusedTags, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag tag) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class WebConfigConfigSourceQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public WebConfigConfigSourceQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.ConfigSourceErrorHighlighting highlighting) { }
        public WebConfigConfigSourceQuickFix(JetBrains.ReSharper.Daemon.WebConfig.Highlightings.UnusedElementDueToConfigSourceAttributeHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}