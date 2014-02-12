[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Web.WinRT.CodeCompletion
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class HtmlWinRTCompletingCharsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSettingOther<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext>
    {
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlWinRTControlItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetRanges(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Web.WinRT.CustomReferences
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.WinRT.LanguageImpl.JavaScriptWinRTLanguage))]
    public class JavaScriptWinRTFileReferenceBinder : JetBrains.ReSharper.Feature.Services.Html.Javascript.CustomReferences.JavaScriptFileReferenceBinder
    {
        public override string GetTargetPath<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
}