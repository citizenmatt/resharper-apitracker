[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs
{
    
    public interface IJavaScriptContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory ElementFactory { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices Services { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf GetControlFlowGraf();
    }
    public class JavaScriptContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>, JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider
    {
        public JavaScriptContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services) { }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory ElementFactory { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices Services { get; }
        public JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf GetControlFlowGraf() { }
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider>
        {
            public static readonly JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.JavaScriptContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider, JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices javaScriptServices, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider> GetContextKey() { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class JavaScriptDecoration : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class ReformatCode : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
    public class SemicolonInserter
    {
        public SemicolonInserter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.Util.TextRange range) { }
        public void Run(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.AutomaticStrategies
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupInStringLiteralStratery : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupInStringLiteralStratery(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager javaScriptIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CompletionStrategyAfterSpace : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public CompletionStrategyAfterSpace(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager intellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptAutomaticStrategyOnDot : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public JavaScriptAutomaticStrategyOnDot(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager javaScriptIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptAutomaticStrategyOnIdentifier : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public JavaScriptAutomaticStrategyOnIdentifier(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager javaScriptIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion
{
    
    public enum BracketsType
    {
        Parentheses = 0,
        Brackets = 1,
    }
    public class CompletionContextInStringLiterals : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.IJavaScriptCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory
    {
        public CompletionContextInStringLiterals(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices jsServices, char quoteChar, JetBrains.ReSharper.Psi.Tree.ITokenNode ownerStringLiteral, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptReparsedCompletionContext unterminatedContext) { }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JavaScriptServices { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode OwnerStringLiteral { get; }
        public char QuoteChar { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        public JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptReparsedCompletionContext UnterminatedContext { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSymbolVisibilityFilter VisibilityFilter { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreatePropertyInStringLiteralItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class JavaScriptArgumentsContext
    {
        public string ArgumentsText { get; }
        public JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.BracketsType BracketsType { get; }
        public bool HasRPar { get; }
        public static JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptArgumentsContext Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression identifier, out JetBrains.ReSharper.Psi.TreeTextRange argumentsListRange) { }
    }
    public class JavaScriptCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.IJavaScriptCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory
    {
        public JavaScriptCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges completionRanges, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptFollowingExpressionContext followingExpression, bool isQualified, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptArgumentsContext argumentsContext, JetBrains.Util.TextRange replaceRangeWithJoinedArguments, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptReparsedCompletionContext unterminatedContext) { }
        public JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptArgumentsContext ArgumentsContext { get; }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptFollowingExpressionContext FollowingExpression { get; }
        public bool IsQualified { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JavaScriptServices { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        public JetBrains.Util.TextRange ReplaceRangeWithJoinedArguments { get; }
        public JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptReparsedCompletionContext UnterminatedContext { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSymbolVisibilityFilter VisibilityFilter { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase CreateDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool blessed) { }
        public override JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T> CreateElementPointer<T>(JetBrains.ReSharper.Psi.DeclaredElementInstance<T> instance)
            where T :  class, JetBrains.ReSharper.Psi.IDeclaredElement { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class JavaScriptCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public JavaScriptCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings.JavaScriptIntellisenseManager intellisenseManager) { }
        protected virtual bool EnabledInSettings(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class JavaScriptCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "JavaScript")]
    public class JavaScriptCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non-completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
    }
    public class JavaScriptFollowingExpressionContext
    {
        public JetBrains.Util.TextRange FollowingExpressionRange { get; }
        public string FollowingExpressionText { get; }
        public static JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptFollowingExpressionContext Create(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.ReSharper.Psi.TreeTextRange selectedTreeRange) { }
    }
    public class JavaScriptReparsedCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public JavaScriptReparsedCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference FindReference(JetBrains.ReSharper.Psi.TreeTextRange referenceRange, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public sealed class JavaScriptTailType : JetBrains.ReSharper.Psi.ExpectedTypes.TailType
    {
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType LParenthisAndLeaveCaretWithin;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType ParenthesesAndLeaveCaretWithin;
        public override JetBrains.ReSharper.Psi.Parsing.TokenNodeType[] EvaluateTail(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class JavsScriptStringLiteralCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSettingOther<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals>
    {
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.LookupItems
{
    
    public class JavaScriptDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.Impl.DeclaredElementLookupItem<JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>
    {
        public JavaScriptDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.IJavaScriptCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices jsServices, bool bind, bool blessed) { }
        public bool Blessed { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceAfterComplete(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        protected override void DecorateDisplayName(JetBrains.UI.RichText.RichText displayName, JetBrains.ReSharper.Psi.DeclaredElementInstance preferredDeclaredElement) { }
        protected override string GetText() { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class JavaScriptKeywordLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.Lookup.IKeywordLookupItem
    {
        public JavaScriptKeywordLookupItem(string text, string suffix) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules
{
    
    public class BlessedItemsFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    public interface IJavaScriptCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory
    {
        JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JavaScriptServices { get; }
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSymbolVisibilityFilter VisibilityFilter { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderAddRemoveEventListenerString : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals>
    {
        public static void AddEvents(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.IJavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression FindAddRemoveEventListenerInvoction(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderAddRemoveEventListenerStringCommonContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderOnCompleteableReferenceInsideStringLiteral : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSymbolTableBase<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals>
    {
        protected override void CollectElement(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbolInfo, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override string GetPreffix(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderOnReferenceExpression : JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.ItemsProviderOnReferenceExpressionBase { }
    public class ItemsProviderOnReferenceExpressionBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected void CollectElement(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbolInfo, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, bool blessed) { }
        protected bool DoAddLookupItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext = null) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderOnStringLiteral : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSymbolTableBase<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals>
    {
        protected override void CollectElement(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbolInfo, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.Text.IdentifierMatcher GetIdentifierMatcher(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override string GetPreffix(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderOnTypeofString : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals>
    {
        public static void AddTypeofStringItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context) { }
        public static bool IsTypeofPattern(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.CompletionContextInStringLiterals context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ItemsProviderOnTypeofStringCommonContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptCompletionItemsProviderIdentifierName : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptCompletionItemsProviderKeywords : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
    }
    public class static KeywordCompletionUtil
    {
        public static bool CanBeExpression(JetBrains.ReSharper.Psi.Tree.ITokenNode token, out bool infixOperatorIsExpected) { }
        public static bool CanBeStatement(JetBrains.ReSharper.Psi.Tree.ITokenNode token, out bool canBeElse, out bool canBeTry, out bool canBeCase, out bool canBeVarInForeach) { }
        public static JetBrains.ReSharper.Psi.Tree.ITokenNode GetAnchorToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        public static System.Collections.Generic.IEnumerable<string> GetAplicableKeywords(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.ReSharper.Psi.TreeTextRange referenceRange) { }
    }
    public class SmartSymbolTableBuilderThread
    {
        public SmartSymbolTableBuilderThread(JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference reference, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext = null) { }
        public void GetSmartSymbolTableAsync(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolTable> doWithSymbolTable) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.Filters
{
    
    public class KeywordsBetterFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for JavaScript")]
    public class IntellisenseEnabledSettingJavaScript
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "JavaScript (.js files and embedded JavaScript)")]
        public bool IntellisenseEnabled;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "JavaScript")]
    public class JavaScriptAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After dot")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterDot;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "Inside string")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType InsideString;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On letters and digits")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "Where value is expected")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType WhereValueIsExpected;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public JavaScriptIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.UsedImplicitlyAttribute()] JetBrains.ReSharper.Psi.LanguageManager manager) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.TypeScript.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for TypeScript")]
    public class IntellisenseEnabledSettingTypeScript
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "TypeScript (.ts files)")]
        public bool IntellisenseEnabled;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "TypeScript")]
    public class TypeScriptAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After dot")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterDot;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On letters and digits")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "Where value is expected")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType WhereValueIsExpected;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TypeScriptIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public TypeScriptIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.TypeScript
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.TypeScript.TypeScriptLanguage))]
    public class TsItemsProviderOnReferenceExpression : JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.ItemsProviderOnReferenceExpression
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected bool AddSmartCompletionItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext completionContext, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference reference, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext = null) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeStructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptCodeStructureProvider : JetBrains.ReSharper.Feature.Services.CodeStructure.IPsiFileCodeStructureProvider
    {
        public virtual JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        protected virtual bool IsLocalScope([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        protected virtual void ProcessCompound(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement) { }
        protected virtual void ProcessExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement) { }
        protected virtual void ProcessStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement) { }
        protected virtual void ProcessVariableStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement variableStatement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement) { }
    }
    public class JavaScriptCodeStructureRootElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement
    {
        public JavaScriptCodeStructureRootElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.UI.TreeView.PresentationState CreatePresentationState() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.CodeStructure.TypeScript
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.TypeScript.TypeScriptLanguage))]
    public class TypeScriptCodeStructureProvider : JetBrains.ReSharper.Feature.Services.JavaScript.CodeStructure.JavaScriptCodeStructureProvider
    {
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        protected override bool IsLocalScope(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        protected override void ProcessExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement) { }
        protected override void ProcessStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement) { }
    }
    public class TypeScriptCodeStructureRootElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement
    {
        public TypeScriptCodeStructureRootElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile file) { }
        public override JetBrains.UI.TreeView.PresentationState CreatePresentationState() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class JavaScriptMatchingBraceContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        public JavaScriptMatchingBraceContextHighlighter(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.JavaScriptContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.ContextSearch
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ImplementationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ImplementationContextSearch
    {
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.GoToDeclaration
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class JavaScriptDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.DefaultDeclarationSearch
    {
        public JavaScriptDeclarationSearch(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceFactory factory) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class JavaScriptSearchDeclarationsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest
    {
        public JavaScriptSearchDeclarationsRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Feature.Services.Occurences.OccurenceFactory factory, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.GoToDeclaration.TypeScript
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class TsDeclarationSearch : JetBrains.ReSharper.Feature.Services.JavaScript.GoToDeclaration.JavaScriptDeclarationSearch
    {
        public TsDeclarationSearch(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceFactory factory) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class JavaScriptGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoFileMemberProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> FindOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag includeLibraries, JetBrains.Application.CheckForInterrupt checkCancelled) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class JavaScriptGotoSymbolProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.CachedGotoSymbolBase<JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices>, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoSymbolProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        protected override JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices GetCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        public class JsPropertyNamesSearcher : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer
        {
            public JsPropertyNamesSearcher(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, System.Collections.Generic.List<string> resultList) { }
            public bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache) { }
            public System.Collections.Generic.List<string> Run() { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class JavaScriptRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.IRelatedFilesProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.Occurrences
{
    
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class JavaScriptDeclaredElementOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.DeclaredElementOccurencePresenter
    {
        protected override void DisplayCustomContainerText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override void DisplayLocationAndGlyph(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence declaredElementOccurence) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=10D)]
    public class JavaScriptOccurencePresenter : JetBrains.ReSharper.Feature.Services.Web.Navigation.WebSymbolOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    public class JavaScriptSymbolOccurrence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public JavaScriptSymbolOccurrence(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=3)]
    public class JavaScriptSymbolOccurrenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult findResult) { }
        public static JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol symbol) { }
        public static JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol symbol, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.ParameterInfo
{
    
    public class JavaScriptParameterInfoCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate
    {
        public JavaScriptParameterInfoCandidate(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature signature, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsFilteredOut { get; set; }
        public bool IsObsolete { get; }
        public JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public int PositionalParameterCount { get; }
        public bool Equals(JetBrains.ReSharper.Feature.Services.JavaScript.ParameterInfo.JavaScriptParameterInfoCandidate other) { }
        public override bool Equals(object obj) { }
        public JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        public override int GetHashCode() { }
        public void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        public JetBrains.UI.RichText.RichText GetSignature(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        public bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
    }
    public class JavaScriptParameterInfoContext : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext
    {
        public JavaScriptParameterInfoContext(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocationExpression, int argumentIndex, JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType type, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services) { }
        public int Argument { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] Candidates { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate DefaultCandidate { get; }
        public string[] NamedArguments { get; set; }
        public System.Type ParameterListNodeType { get; }
        public System.Collections.Generic.ICollection<System.Type> ParameterNodeTypes { get; }
        public JetBrains.Util.TextRange Range { get; }
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptParameterInfoContextFactory : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContextFactory
    {
        public System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public bool IsIntellisenseEnabled(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.QuickDoc
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptXmlDocLocator : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IXmlDocLocator
    {
        public JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode FindCommentNode(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range) { }
    }
    public class QuickDocJsFunctionPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocJsFunctionPresenter(JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner> elements, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class QuickDocJsFunctionProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocJsFunctionProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.RearrangeCode
{
    
    public class RearrangeableArgument : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementAppendRemove<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral>
    {
        public RearrangeableArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression argument, JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteral) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral Parent { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddAfter(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression child, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddBefore(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression child, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> GetChildren(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral parent) { }
        protected override void RemoveChild(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression child) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableArrayElement : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementAppendRemove<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression>
    {
        public RearrangeableArrayElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression argument, JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocationExpression) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression Parent { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddAfter(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression child, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddBefore(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression child, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> GetChildren(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression parent) { }
        protected override void RemoveChild(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression child) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableLiteralObjectProperty : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementAppendRemove<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral>
    {
        public RearrangeableLiteralObjectProperty(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration propertyDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral Parent { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration AddAfter(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration child, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration anchor) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration AddBefore(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration child, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration anchor) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration> GetChildren(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral parent) { }
        protected override void RemoveChild(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration child) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableParameter : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
    {
        public RearrangeableParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration parameterDeclarationDeclaration) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override string Title { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableStatement : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
    {
        public RearrangeableStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override string Title { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class static StatementsOwnerUtil
    {
        public static System.Nullable<JetBrains.ReSharper.Feature.Services.JavaScript.RearrangeCode.StatementsOwnerUtil.NestedBlock> GetContainingNestedBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public static System.Nullable<JetBrains.ReSharper.Feature.Services.JavaScript.RearrangeCode.StatementsOwnerUtil.NestedBlock> GetFirstNestedBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public static System.Nullable<JetBrains.ReSharper.Feature.Services.JavaScript.RearrangeCode.StatementsOwnerUtil.NestedBlock> GetNextNestedBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public static System.Nullable<JetBrains.ReSharper.Feature.Services.JavaScript.RearrangeCode.StatementsOwnerUtil.NestedBlock> GetPreviousNestedBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public struct NestedBlock
        {
            public NestedBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement ownerStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement, System.Func<JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock> blockSurrounder) { }
            public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Body { get; }
            public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement OwnerStatement { get; }
            public JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SurroundWithBlock() { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.ReparseContextService
{
    
    public class JavaScriptReparseContext { }
    public class KeywordCompletionReparseContext : JetBrains.ReSharper.Feature.Services.JavaScript.ReparseContextService.JavaScriptReparseContext
    {
        public JetBrains.ReSharper.Feature.Services.JavaScript.ReparseContextService.KeywordCompletionReparseContext Create(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.SelectEmbracingConstruct
{
    
    public class JavaScriptDotSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.DotSelection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
    {
        public JavaScriptDotSelection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile fileNode, JetBrains.ReSharper.Psi.TreeOffset offset, bool selectBetterToken, bool useCamelHumps) { }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTokenPartSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTreeNodeSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetParentInternal(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override bool IsLiteralToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsNewLineToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsSpaceToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsWordToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.JavaScriptProjectFileType))]
    public class JavaScriptSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider
    {
        public JavaScriptSelectEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public static JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange BuildNodeSelection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public static JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetParentRange(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.ReSharper.Psi.Tree.ITreeNode lastNode) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class JavaScriptTokenPartSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TokenPartSelection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>
    {
        public JavaScriptTokenPartSelection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile fileNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public class JavaScriptTreeRangeSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TreeRangeSelection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile>
    {
        public JavaScriptTreeRangeSelection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.DefaultTodoContentsProvider
    {
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.TypingAssist
{
    
    public class JavaScriptBracketMatcher : JetBrains.ReSharper.Feature.Services.TypingAssist.BracketMatcher
    {
        public JavaScriptBracketMatcher() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class JavaScriptTypingAssist : JetBrains.ReSharper.Feature.Services.JavaScript.TypingAssist.JavaScriptTypingAssistBase
    {
        public JavaScriptTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class JavaScriptTypingAssistBase : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistForCLikeLanguage<JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptCodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        protected JavaScriptTypingAssistBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected virtual int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        protected virtual bool AllowOneCharacterStringLiteralToBeSkipped(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected virtual bool CheckThatJavaScriptLineEndsInOpenStringLiteral(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int lineEndPos, char c, JetBrains.ReSharper.Psi.Parsing.TokenNodeType correspondingTokenType, ref int charPos, bool beforeAddingQuote) { }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.ITreeRange, JetBrains.ReSharper.Psi.ITreeRangePointer> GetRangeToFormatAfterRBrace(JetBrains.TextControl.ITextControl textControl) { }
        protected bool HandleBackspacePressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleDelPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleEnterPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleLeftBracketOrParenthTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        protected override bool IsLBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool IsRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool IsSemicolon(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual bool IsStopperTokenForStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public virtual bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public bool ReformatForSmartEnter(string dummyText, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange reparseTreeOffset, JetBrains.ReSharper.Psi.TreeOffset lBraceTreePos, JetBrains.ReSharper.Psi.TreeOffset rBraceTreePos, bool insertEnterAfter = False) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.JavaScript.TypingAssist.TypeScript
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class TypeScriptTypingAssist : JetBrains.ReSharper.Feature.Services.JavaScript.TypingAssist.JavaScriptTypingAssistBase
    {
        public TypeScriptTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Json.CodeCompletion
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon.JsonLanguage))]
    public class JsonItemsProviderOnReferenceExpression : JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.Rules.ItemsProviderOnReferenceExpressionBase { }
}
namespace JetBrains.ReSharper.Feature.Services.Json.Occurences
{
    
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=10D)]
    public class JsonOccurencePresenter : JetBrains.ReSharper.Feature.Services.Web.Navigation.WebSymbolOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
}