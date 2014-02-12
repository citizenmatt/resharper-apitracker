[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Web.QuickFixes.Mvc
{
    
    public interface IMvcQuickFixTemplateProvider
    {
        string GetExtension(bool viewPage, bool withMasterpage);
        string GetQuickFixTitle(bool viewPage, bool withMasterpage);
        System.Guid GetTemplateGuid(bool viewPage, bool withMasterpage);
        bool IsAvailable(JetBrains.ProjectModel.IProjectItem context);
    }
    public abstract class MvcChangeModelTypeQuickFixBase : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public abstract JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public abstract bool IsAvailable(JetBrains.Util.IUserDataHolder cache);
        protected abstract class MyItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
        {
            protected readonly JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType myHighlighting;
            protected MyItem(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
            public override string Text { get; }
            protected void BindReference(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Resolve.IReference typeReference) { }
        }
    }
}