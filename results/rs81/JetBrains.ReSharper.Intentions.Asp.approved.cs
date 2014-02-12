[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Intentions.Asp.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "MasterPage"}, IconPackResourceIdentification="JetBrains.ReSharper.Intentions.Asp;component/resources/IntentionsAspThemedIcons/T" +
    "hemedIcons.IntentionsAsp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-intentions-asp", "JetBrains.ReSharper.Intentions.Asp.Resources")]

namespace JetBrains.ReSharper.Intentions.Asp.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Add CodeBehind file", Group="ASP.NET", Name="Add CodeBehind file", Priority=0)]
    public class AddCodeBehindFileContextAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public AddCodeBehindFileContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public string Text { get; }
        public static void AddCodeBehind([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] string commandText, JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> provider, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>, JetBrains.ReSharper.Psi.Asp.Tree.IAspMainDirective> directiver = null, System.Action<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationWithRangeContainer> actor = null) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static string GetCodeBehindAttributeName(JetBrains.ProjectModel.IProject project) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static AspContextActions
    {
        public const string GroupID = "ASP.NET";
    }
    public abstract class AspContextActionWithReferenceBase<T> : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
        where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected AspContextActionWithReferenceBase(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public abstract JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public T Reference { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates event", Group="ASP.NET", Name="Create event", Priority=20)]
    public class AspCreateEventContextAction : JetBrains.ReSharper.Intentions.Asp.ContextActions.AspContextActionWithReferenceBase<JetBrains.ReSharper.Psi.Asp.References.IHtmlAttributeOrPropertyReference>
    {
        public AspCreateEventContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates method", Group="ASP.NET", Name="Create method", Priority=20)]
    public class AspCreateMethodContextAction : JetBrains.ReSharper.Intentions.Asp.ContextActions.AspCreateMethodContextActionBase<JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference>
    {
        public AspCreateMethodContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
    }
    public abstract class AspCreateMethodContextActionBase<T> : JetBrains.ReSharper.Intentions.Asp.ContextActions.AspContextActionWithReferenceBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference
    {
        protected AspCreateMethodContextActionBase(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates ObjectDataSource\'s method", Group="ASP.NET", Name="Create ObjectDataSource\'s method", Priority=20)]
    public class AspCreateOdsMethodContextAction : JetBrains.ReSharper.Intentions.Asp.ContextActions.AspCreateMethodContextActionBase<JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference>
    {
        public AspCreateOdsMethodContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates property", Group="ASP.NET", MergeKey="ASP_CreateProperty", Name="Create property", Priority=20)]
    public class AspCreatePropertyFromAttributeContextAction : JetBrains.ReSharper.Intentions.Asp.ContextActions.AspContextActionWithReferenceBase<JetBrains.ReSharper.Psi.Asp.References.IHtmlAttributeOrPropertyReference>
    {
        public AspCreatePropertyFromAttributeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates property", Group="ASP.NET", MergeKey="ASP_CreateProperty", Name="Create property", Priority=20)]
    public class AspCreatePropertyFromSubPropertyContextAction : JetBrains.ReSharper.Intentions.Asp.ContextActions.AspContextActionWithReferenceBase<JetBrains.ReSharper.Psi.Asp.References.ISubPropertyReference>
    {
        public AspCreatePropertyFromSubPropertyContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds image\'s width and height attributes", Group="ASP.NET", Name="Add attributes for image dimensions", Priority=100)]
    public class AspImageSizeContextAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public AspImageSizeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Imports type", Group="ASP.NET", Name="Import type", Priority=20)]
    public class AspImportTypeContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public AspImportTypeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Convert tag and vice versa", Group="ASP.NET", Name="Convert tag", Priority=20)]
    public class ConvertTagContextAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ConvertTagContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer GetActiveTag() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merge server scripts content", Group="ASP.NET", Name="Merge server scripts content", Priority=0)]
    public class MergeScriptletsContextAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MergeScriptletsContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Move server script content to codebehind", Group="ASP.NET", Name="Move server script content to codebehind", Priority=0)]
    public class MoveScriptletToCodeBehindContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public MoveScriptletToCodeBehindContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Remove CodeBehind file", Group="ASP.NET", Name="Remove CodeBehind file", Priority=0)]
    public class RemoveCodeBehindFileContextAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveCodeBehindFileContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes directive attribute", Group="ASP.NET", Name="Remove directive attribute", Priority=-5)]
    public class RemoveDirectiveAttributeContextAction : JetBrains.ReSharper.Intentions.Html.ContextActions.RemoveAttributeContextActionBase<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>
    {
        public RemoveDirectiveAttributeContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Reorders directive attributes alphabetically", Group="ASP.NET", Name="Reorder directive attributes", Priority=-10)]
    public class ReorderDirectiveAttributesContextAction : JetBrains.ReSharper.Intentions.Html.ContextActions.ReorderAttributesContextActionBase<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective>
    {
        public ReorderDirectiveAttributesContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.Generate
{
    
    public class AspGenerateContentActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public AspGenerateContentActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class AspGenerateContentItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspAttributeWithOptionalValueQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspAttributeWithOptionalValueQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspAttributeWithOptionalValueWarningHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspChangeSignatureQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspChangeSignatureQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference> highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCodeBehindFileQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspCodeBehindFileQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlPathWarningHighlighting pathWarningHighlighting) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCodeFileWithoutInheritsAttributeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspCodeFileWithoutInheritsAttributeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspCodeFileWithoutInheritsAttributeErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public class RemoveCodefileAttributeItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
        {
            public RemoveCodefileAttributeItem(JetBrains.ReSharper.Psi.Asp.Tree.IAspMainDirective mainDirective) { }
            public override string Text { get; }
            protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreateMissingAttributeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AspCreateMissingAttributeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspMissingAttributeHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreatePlaceholderQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspCreatePlaceholderQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IContentPlaceholderReference> highlighting) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspImageQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspImageQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspImageWarningHighlighting imageWarning) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspOptimizeRegisterDirectivesQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspOptimizeRegisterDirectivesQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspUnusedRegisterDirectiveHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspScriptLanguageQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspScriptLanguageQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspScriptLanguageErrorHighlighting error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspTagToAttributeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspTagToAttributeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IHtmlTagOrPropertyReference> highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public sealed class AspCreateClassQuickFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference>, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspCreateClassQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference> error) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateBulbActions() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreateEventHandlerQuickFix : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreateMethodFromUsageQuickFixBase<JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference>
    {
        public AspCreateEventHandlerQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference> highlighting) { }
        protected override JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference> CreateHelper(JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference reference) { }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class AspCreateFromUsageQuickFixBase<T> : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
        where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected readonly T Reference;
        protected AspCreateFromUsageQuickFixBase(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<T> highlighting) { }
        public abstract JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration() { }
        protected virtual JetBrains.ReSharper.Psi.ITypeElement GetTargetTypeElement() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected virtual bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsSuitableTargetDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration typeDeclaration);
    }
    public abstract class AspCreateMethodFromUsageQuickFixBase<T> : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreateFromUsageQuickFixBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected AspCreateMethodFromUsageQuickFixBase(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<T> highlighting) { }
        protected JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<T> Helper { get; }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected abstract JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<T> CreateHelper(T reference);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected override JetBrains.ReSharper.Psi.ITypeElement GetTargetTypeElement() { }
        protected override bool IsSuitableTargetDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration typeDeclaration) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreateMethodQuickFix : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreateMethodFromUsageQuickFixBase<JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference>
    {
        public AspCreateMethodQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference> highlighting) { }
        protected override JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference> CreateHelper(JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference reference) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreateOdsMethodQuickFix : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreateMethodFromUsageQuickFixBase<JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference>
    {
        public AspCreateOdsMethodQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference> highlighting) { }
        protected override JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference> CreateHelper(JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference reference) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreatePropertyFromAttributeQuickFix : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreatePropertyQuickFixBase<JetBrains.ReSharper.Psi.Asp.References.IHtmlAttributeOrPropertyReference>
    {
        public AspCreatePropertyFromAttributeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IHtmlAttributeOrPropertyReference> highlighting) { }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreatePropertyFromSubpropertyReferenceQuickFix : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreatePropertyQuickFixBase<JetBrains.ReSharper.Psi.Asp.References.ISubPropertyReference>
    {
        public AspCreatePropertyFromSubpropertyReferenceQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.ISubPropertyReference> highlighting) { }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreatePropertyFromTagQuickFix : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreatePropertyQuickFixBase<JetBrains.ReSharper.Psi.Asp.References.IHtmlTagOrPropertyReference>
    {
        public AspCreatePropertyFromTagQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IHtmlTagOrPropertyReference> highlighting) { }
        protected override bool IsAvailableInternal(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class AspCreatePropertyQuickFixBase<T> : JetBrains.ReSharper.Intentions.Asp.QuickFixes.CreateFromUsage.AspCreateFromUsageQuickFixBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected AspCreatePropertyQuickFixBase(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<T> highlighting) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override bool IsSuitableTargetDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration typeDeclaration) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.QuickFixes.Import
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute(typeof(JetBrains.ReSharper.Intentions.Html.QuickFixes.Import.HtmlChangePathMappingQuickFix), JetBrains.Util.BeforeOrAfter.Before)]
    public class AspCreateFileQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspCreateFileQuickFix(JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlPathWarningHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspImportTagNameQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspImportTagNameQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.ITagNameReference> tagNameReferenceHighlighting) { }
        public AspImportTagNameQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveWarningHighlighting<JetBrains.ReSharper.Psi.Asp.References.ITagNameReference> tagNameReferenceHighlighting) { }
        protected virtual string ItemFormat { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspImportTypeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AspImportTypeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference> typeReferenceHighlighting) { }
        public AspImportTypeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.ITagNameReference> tagNameReferenceHighlighting) { }
        public AspImportTypeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IHtmlTagOrPropertyReference> tagOrPropertyReferenceHighlighting) { }
        public AspImportTypeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveWarningHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference> typeReferenceHighlighting) { }
        public AspImportTypeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveWarningHighlighting<JetBrains.ReSharper.Psi.Asp.References.ITagNameReference> tagNameReferenceHighlighting) { }
        public AspImportTypeQuickFix(JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveWarningHighlighting<JetBrains.ReSharper.Psi.Asp.References.IHtmlTagOrPropertyReference> tagOrPropertyReferenceHighlighting) { }
        protected virtual string ItemFormat { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> GetAlternatives() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.QuickFixes.Mvc
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class GenericMvcLanguageHelper : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcLanguageHelper
    {
        public virtual JetBrains.ReSharper.Psi.IType GetAssigmentType(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetAttributeDeclarations(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node) { }
        public virtual bool IsAttribute(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MvcActionControllerQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MvcActionControllerQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference> highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MvcChangeModelTypeQuickFix : JetBrains.ReSharper.Intentions.Web.QuickFixes.Mvc.MvcChangeModelTypeQuickFixBase
    {
        public MvcChangeModelTypeQuickFix(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class MvcQuickFixTemplateProviderBase : JetBrains.ReSharper.Intentions.Web.QuickFixes.Mvc.IMvcQuickFixTemplateProvider
    {
        public virtual string GetExtension(bool viewPage, bool withMasterpage) { }
        public virtual string GetQuickFixTitle(bool viewPage, bool withMasterpage) { }
        public abstract System.Guid GetTemplateGuid(bool viewPage, bool withMasterpage);
        public virtual bool IsAvailable(JetBrains.ProjectModel.IProjectItem context) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MvcViewQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MvcViewQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference> highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.Resources
{
    
    public sealed class IntentionsAspThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Intentions.Asp;component/resources/IntentionsAspThemedIcons/T" +
            "hemedIcons.IntentionsAsp.Generated.Xaml", 0, "MasterPage")]
        public sealed class MasterPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.Util
{
    
    public class static AspImportTypeUtil
    {
        public const string ItemFormat = "Import type \'{0}\'";
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> CalculateAlternatives([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> GetAllReferences(JetBrains.ReSharper.Psi.Resolve.IReference mainReference) { }
    }
}