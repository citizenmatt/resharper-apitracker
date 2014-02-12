[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Razor.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Convert Razor Block markup to Line markup", Group="Razor", Name="Convert Razor Block markup to Line markup")]
    public class RazorBlockToLineMarkupContextAction : JetBrains.ReSharper.Intentions.Razor.ContextActions.RazorMarkupConverterContextActionBase<JetBrains.ReSharper.Psi.Razor.Tree.IRazorBlockMarkup>
    {
        public RazorBlockToLineMarkupContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile> dataProvider) { }
    }
    public class static RazorContextActions
    {
        public const string GroupID = "Razor";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Convert Razor Line markup to Block markup", Group="Razor", Name="Convert Razor Line markup to Block markup")]
    public class RazorLineToBlockMarkupContextAction : JetBrains.ReSharper.Intentions.Razor.ContextActions.RazorMarkupConverterContextActionBase<JetBrains.ReSharper.Psi.Razor.Tree.IRazorLineMarkup>
    {
        public RazorLineToBlockMarkupContextAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile> dataProvider) { }
    }
    public abstract class RazorMarkupConverterContextActionBase<TRazorMarkup> : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
        where TRazorMarkup :  class, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup
    {
        protected RazorMarkupConverterContextActionBase(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile> dataProvider, string text, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.Razor.Parsing.RazorElementFactory, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup> factory) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Razor.QuickFixes.Mvc
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MvcChangeModelTypeQuickFix : JetBrains.ReSharper.Intentions.Web.QuickFixes.Mvc.MvcChangeModelTypeQuickFixBase
    {
        public MvcChangeModelTypeQuickFix(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected class MyItemRazor : JetBrains.ReSharper.Intentions.Web.QuickFixes.Mvc.MvcChangeModelTypeQuickFixBase.MyItem
        {
            public MyItemRazor(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
            protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        }
    }
    public abstract class MvcQuickFixTemplateProviderBase : JetBrains.ReSharper.Intentions.Web.QuickFixes.Mvc.IMvcQuickFixTemplateProvider
    {
        public abstract string GetExtension(bool viewPage, bool withMasterpage);
        public virtual string GetQuickFixTitle(bool viewPage, bool withMasterpage) { }
        public abstract System.Guid GetTemplateGuid(bool viewPage, bool withMasterpage);
        public virtual bool IsAvailable(JetBrains.ProjectModel.IProjectItem context) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Razor.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RazorNotEnclosedBlockStatementQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RazorNotEnclosedBlockStatementQuickFix(JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorNotEnclosedBlockStatementHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RazorReservedKeywordQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RazorReservedKeywordQuickFix(JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorReservedKeywordErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RazorTransitionInsideCodeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RazorTransitionInsideCodeQuickFix(JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorTransitionInsideCodeHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RazorVoidWriteCallErrorQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RazorVoidWriteCallErrorQuickFix(JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorVoidWriteCallErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}