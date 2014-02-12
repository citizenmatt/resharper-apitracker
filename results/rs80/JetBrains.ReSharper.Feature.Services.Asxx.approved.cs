[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asxx.AsxxLanguage))]
    public class AsxxBasicCodeCompletionItemsProvider : JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionItemsProviderBase<JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference>
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference reference, JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
    }
    public class AsxxCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges;
        public readonly JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxReparsedCompletionContext UnterminatedContext;
        public AsxxCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxReparsedCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override string ContextId { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
    }
    public abstract class AsxxCodeCompletionItemsProviderBase<T> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.ItemsProviderWithSymbolTable<JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext, T, JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile>
        where T :  class, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
        protected override T GetReference(JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asxx.AsxxLanguage))]
    public class AsxxCodeCompletionRangesProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
    }
    public class AsxxReparsedCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public AsxxReparsedCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asxx.AsxxLanguage))]
    public class AsxxSmartCodeCompletionItemsProvider : JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionItemsProviderBase<JetBrains.ReSharper.Psi.Asxx.References.IAsxxSmartCompleteableReference>
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.Asxx.References.IAsxxSmartCompleteableReference reference, JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Asxx.CodeCompletion.AsxxCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asxx.SelectEmbracingConstruct
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AsxxProjectFileType))]
    public class AsxxSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.WebSelectEmbracingConstructProviderBase<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile>
    {
        public AsxxSelectEmbracingConstructProvider(JetBrains.ProjectModel.AsxxProjectFileType asxxProjectFileType, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateDotSelectedRange(JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile primaryFile, JetBrains.ReSharper.Psi.TreeOffset treeOffset, bool selectBetterToken) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateElementSelectedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWrapperRange CreateWrapperRange(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primaryRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange codeBehindRange, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile) { }
    }
    public class AsxxWrapperRange : JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.WrapperRange<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile>
    {
        public AsxxWrapperRange(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange secondarySelection, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primarySelection, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile) { }
        protected override bool IsSpecialToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asxx.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class AsxxTypingAssist : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<JetBrains.ReSharper.Psi.Asxx.AsxxLanguage, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        public AsxxTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected bool HandleQuoteTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}