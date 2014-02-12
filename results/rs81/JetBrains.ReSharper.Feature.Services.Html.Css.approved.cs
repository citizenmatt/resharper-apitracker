[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Html.Css.CodeCompletion
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAutomaticStrategyOnWhitespaceInClassAttribute : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnWhitespaceBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
    {
        public HtmlAutomaticStrategyOnWhitespaceInClassAttribute(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore toDataContext) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool ShouldPopup(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken tokenNode) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Css.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class CssHtmlTypingAssist : JetBrains.ReSharper.Feature.Services.Css.TypingAssist.CssTypingAssistBase
    {
        public CssHtmlTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public override int TextControlToLexer(JetBrains.TextControl.ITextControl textControl, int offset) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssTagSmartEnterHandler : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ISpecialTagSmartEnterHandler
    {
        public CssTagSmartEnterHandler(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Feature.Services.Html.Css.TypingAssist.CssHtmlTypingAssist cssHtmlTypingAssist) { }
        public bool FormatOnSmartEnter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsTagSupported(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.TextControl.ITextControl textControl) { }
    }
}