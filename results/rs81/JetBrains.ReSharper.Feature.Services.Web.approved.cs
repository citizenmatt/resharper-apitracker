[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Web.Navigation
{
    
    public class WebGotoFileMemberCachedBase : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> FindOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag includeLibraries, JetBrains.Application.CheckForInterrupt checkCancelled) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=2)]
    public class WebOccurenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult findResult) { }
    }
    public class WebSymbolOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public WebSymbolOccurence(JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol webSymbol, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        public JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol WebSymbol { get; }
        public override string GetDisplayNameText() { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=10D)]
    public class WebSymbolOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.RangeOccurencePresenter
    {
        protected override JetBrains.UI.RichText.RichText GetDisplayText(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct
{
    
    public interface IWebSelectEmbracingConstructProvider<in TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider
        where in TFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateDotSelectedRange(TFile primaryFile, JetBrains.ReSharper.Psi.TreeOffset treeOffset, bool selectBetterToken);
        JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateElementSelectedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWrapperRange CreateWrapperRange(JetBrains.DocumentModel.IDocument document, TFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primaryRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange codeBehindRange, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile);
    }
    public interface IWrapperRange : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange { }
    public abstract class WebSelectEmbracingConstructProviderBase<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider, JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile>
        where TFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected WebSelectEmbracingConstructProviderBase(JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateDotSelectedRange(TFile primaryFile, JetBrains.ReSharper.Psi.TreeOffset treeOffset, bool selectBetterToken);
        public abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateElementSelectedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        public abstract JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWrapperRange CreateWrapperRange(JetBrains.DocumentModel.IDocument document, TFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primaryRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange codeBehindRange, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile);
        protected bool DoUseCamelHumps(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public abstract class WrapperRange<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange, JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWrapperRange
        where TFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected WrapperRange(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primarySelection, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange secondarySelection, TFile primaryFile, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        protected abstract bool IsSpecialToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Web.TypingAssist
{
    
    public class static WebTypingAssistUtil
    {
        public static System.Nullable<int> AdjustLineIndent<TLanguage, TTokenNode>(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, int originalOffset, int currentOffset)
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
            where TTokenNode :  class, JetBrains.ReSharper.Psi.Tree.ITokenNode { }
        public static bool FindTokenAt([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int offset) { }
        public static bool FindTokenAt<TTokenNodeType>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int offset)
            where TTokenNodeType :  class, JetBrains.ReSharper.Psi.Parsing.ITokenNodeType { }
        public static bool IsProjectFileSupported<TProjectFileType, TLanguageType>(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution)
            where TProjectFileType : JetBrains.ProjectModel.ProjectFileType
            where TLanguageType : JetBrains.ReSharper.Psi.PsiLanguageType { }
        public static bool IsSupported<TTokenNodeType>(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.TextControl.ITextControl textControl, bool checkSelection = True)
            where TTokenNodeType :  class, JetBrains.ReSharper.Psi.Parsing.ITokenNodeType { }
    }
}