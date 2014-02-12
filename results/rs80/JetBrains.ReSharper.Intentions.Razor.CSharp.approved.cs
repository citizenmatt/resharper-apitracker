[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Razor.CSharp.ContextActions
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class RazorCSharpContextActionLanguageSpecific : JetBrains.ReSharper.Feature.Services.Util.IContextActionLanguageSpecific
    {
        public bool IsApplicable(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        public bool IsAvailable(JetBrains.ReSharper.Intentions.Extensibility.IContextAction contextAction) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Razor.CSharp.QuickFixes.Mvc
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class RazorCSharpMvcQuickFixTemplateProvider : JetBrains.ReSharper.Intentions.Razor.QuickFixes.Mvc.MvcQuickFixTemplateProviderBase
    {
        public override string GetExtension(bool viewPage, bool withMasterpage) { }
        public override System.Guid GetTemplateGuid(bool viewPage, bool withMasterpage) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Razor.CSharp.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RazorNotEnclosedBlockStatementInCodeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RazorNotEnclosedBlockStatementInCodeQuickFix(JetBrains.ReSharper.Daemon.Razor.CSharp.Highlightings.RazorNotEnclosedBlockStatementInCodeHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RazorReturnValueOfHelperIsNotUsedQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RazorReturnValueOfHelperIsNotUsedQuickFix(JetBrains.ReSharper.Daemon.Razor.CSharp.Highlightings.RazorReturnValueOfHelperIsNotUsedWarning highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}