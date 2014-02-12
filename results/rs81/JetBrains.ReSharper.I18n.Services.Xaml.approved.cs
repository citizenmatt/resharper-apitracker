[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.Xaml.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class SetResourceVisibilityToPublicFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SetResourceVisibilityToPublicFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}