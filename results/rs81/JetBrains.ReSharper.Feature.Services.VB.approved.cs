[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.VB
{
    
    public class AttributeInfoCandidateFactory : JetBrains.ReSharper.Feature.Services.VB.ICandidateFactory
    {
        public AttributeInfoCandidateFactory(JetBrains.ReSharper.Psi.IClass _class) { }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate CreateCandidate(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, bool isExtensionMethod) { }
        public void FilterCandidates(JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextBase context, JetBrains.ReSharper.Psi.VB.Tree.IArgumentList argList) { }
    }
    public abstract class VBAutomaticStrategyOnSymbolBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public VBAutomaticStrategyOnSymbolBase(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBAutopopupEnabledSettingsKey, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType>> settingsEntryExpression) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected abstract char GetSymbol();
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBHtmlAttributesPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.HtmlAttributesPresenterBase
    {
        public VBHtmlAttributesPresenter(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter typePresenter, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlEnumPresenter enumPresenter) { }
        protected override string GetArrayBrackets() { }
        protected override char GetAttributeCloseChar() { }
        protected override char GetAttributeOpenChar() { }
        protected override string GetAttributePropertyAssignChar() { }
        protected override string GetNew() { }
        protected override string GetNewLine() { }
        protected override string GetNull() { }
        protected override string GetTypeOf() { }
        protected override JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter GetTypePresenter() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBHtmlEnumPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.HtmlEnumPresenterBase
    {
        public VBHtmlEnumPresenter(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ExtractTreeNode(JetBrains.ReSharper.Psi.IField element) { }
        protected override string TryGetXmlDocId(JetBrains.ReSharper.Psi.Tree.ITreeNode child) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBHtmlTypePresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter
    {
        public void PresentName(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IType type) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBImplementMembersRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMergeImportItemsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public class VBMissingMemberLookupItem : JetBrains.ReSharper.Feature.Services.CodeCompletion.MissingMemberLookupItemBase
    {
        public VBMissingMemberLookupItem(string name, JetBrains.ReSharper.Psi.OverridableMemberInstance instance, bool isExplicitImplementation, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void RemoveIdentifier(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
        protected override void SetOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBObjectInitializerContextFactory : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContextFactory
    {
        public System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public bool IsIntellisenseEnabled(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
    public class VBOverridableMemberLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBOverridableMemberLookupItem(string name, JetBrains.ReSharper.Psi.OverridableMemberInstance instance, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBParameterInfoUtil
    {
        public static void FillNamedArguments(JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext context, JetBrains.ReSharper.Psi.VB.Tree.IArgumentList argList) { }
        public static int GetParameterPosition(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITokenNode> commaList, JetBrains.ReSharper.Psi.TreeOffset caretPos) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange(JetBrains.ReSharper.Psi.Tree.ITreeNode list, JetBrains.ReSharper.Psi.Tree.ITokenNode lPar, JetBrains.ReSharper.Psi.Tree.ITokenNode rPar) { }
    }
    public class VBPartialMethodLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBPartialMethodLookupItem(string name, JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToRemove, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, bool displayPrivateKeyword, bool displaySubKeyword, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSoftAfterDimRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorElementProviderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBWithEventsFieldsProvider : JetBrains.ReSharper.Feature.Services.Generate.GeneratorEventsProviderBase<JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext>
    {
        public override double Priority { get; }
        public override void Populate(JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBXmlDocHeaderPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.CommonXmlDocHeaderPresenter
    {
        public VBXmlDocHeaderPresenter(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter typePresenter, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlAttributesPresenter attributesPresenter, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlEnumPresenter enumPresenter) { }
        public override void Present(System.Text.StringBuilder header, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBXmlDocLocator : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IXmlDocLocator
    {
        public JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode FindCommentNode(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Bulbs
{
    
    public interface IVBContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>
    {
        JetBrains.ReSharper.Psi.VB.VBElementFactory ElementFactory { get; }
        JetBrains.ReSharper.Psi.VB.ControlFlow.IVBControlFlowGraf GetControlFlowGraf();
        bool InspectControlFlowGraf();
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionDataBuilderAttribute(typeof(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider))]
    public class VBContextActionDataBuilder : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class VBContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>, JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider
    {
        public VBContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        public JetBrains.ReSharper.Psi.VB.VBElementFactory ElementFactory { get; }
        public JetBrains.ReSharper.Psi.VB.ControlFlow.IVBControlFlowGraf GetControlFlowGraf() { }
        public bool InspectControlFlowGraf() { }
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider>
        {
            public static readonly JetBrains.ReSharper.Feature.Services.VB.Bulbs.VBContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider, JetBrains.ReSharper.Psi.VB.VBLanguage, JetBrains.ReSharper.Psi.VB.Tree.IVBFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.VB.Tree.IVBFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider> GetContextKey() { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class OptimizeImports : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public static readonly JetBrains.ReSharper.Feature.Services.VB.CodeCleanup.OptimizeImports.ShortenReferencesDescriptor SHORTEN_REFERENCES_DESCRIPTOR;
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
        [System.ComponentModel.CategoryAttribute("Visual Basic .NET")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.DisplayNameAttribute("Shorten qualified references")]
        public class ShortenReferencesDescriptor : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor
        {
            public ShortenReferencesDescriptor() { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.VB.CodeCleanup.OptimizeImports)})]
    public class ReformatCode : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Infrastructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLookupItemsPresenter : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ILookupItemPresenter
    {
        public JetBrains.UI.RichText.RichTextBlock Present(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion
{
    
    public interface ISmartCompleatebleReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBCodeCompletionCache : JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionCache { }
    public abstract class VBCodeCompletionContextBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        protected readonly JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBReparsedCodeCompletionContext myUnterminatedContext;
        public VBCodeCompletionContextBase(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext codeCompletionContext, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionCache Cache { get; }
        public override string ContextId { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase ExpectedTypeContext { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public bool IsQualified { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        public JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBReparsedCodeCompletionContext UnterminatedContext { get; }
        protected abstract string GetContextId();
        public bool IsQualifiedReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class VBCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public VBCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public static bool IsKeyword(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public class VBCodeCompletionContextSimple : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase
    {
        public VBCodeCompletionContextSimple(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext codeCompletionContext, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        protected override string GetContextId() { }
    }
    public class VBCodeCompletionContextSmart : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase
    {
        public VBCodeCompletionContextSmart(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext codeCompletionContext, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public bool UnderDelegateCreation { get; }
        protected override string GetContextId() { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBCodeCompletionUtil
    {
        public static JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem CreateLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementInstance, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ExpectedTypes.TailType>> GetConcreteTypes(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> types, JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext, bool withInheritors = True, bool onlyInheritors = False) { }
        public static bool IsAttribute(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public static JetBrains.ReSharper.Psi.ExpectedTypes.TailType MergeTailTypes(JetBrains.ReSharper.Psi.ExpectedTypes.TailType firstTail, JetBrains.ReSharper.Psi.ExpectedTypes.TailType secondTail) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class VBCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntelliSenseCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntelliSenseCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntelliSenseCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntelliSenseCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntelliSenseCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCompletionRangesProviderForSimpleContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCompletionRangesProviderForSmartContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBConstructorCallItemsProvider : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase, JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpressionReference>
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpressionReference reference, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBEnumMembers : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpandItemsProviderImportExtensionMethods : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderImportExtensionMethodsBase
    {
        public VBExpandItemsProviderImportExtensionMethods(JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        protected override bool WithReferences { get; }
        protected override JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBExtensionMethodsLookupItem CreateMethodsLookupItem(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.INamespace, string> key, JetBrains.Util.ReadOnlyCollection<JetBrains.ReSharper.Psi.IMethod> itemMethods) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple specificContext) { }
        protected override bool ShouldBeIncluded(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methods) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBImportCompletionProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.IImportCompletionCacheProvider { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBImportCompletionWorkflow : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public abstract class VBItemsProviderBase<TContext, TReference> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.ItemsProviderWithSymbolTable<TContext, TReference, JetBrains.ReSharper.Psi.VB.Tree.IVBFile>
        where TContext : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase
        where TReference :  class, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementInstance, TContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(TContext context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(TReference reference, TContext context) { }
        protected JetBrains.ReSharper.Psi.Tree.IDeclaration GetOriginalDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration tmpDeclaration, TContext context) { }
        protected override TReference GetReference(TContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBItemsProviderImportExtensionMethods : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderImportExtensionMethodsBase
    {
        protected override bool WithReferences { get; }
        protected override JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBExtensionMethodsLookupItem CreateMethodsLookupItem(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.INamespace, string> key, JetBrains.Util.ReadOnlyCollection<JetBrains.ReSharper.Psi.IMethod> itemMethods) { }
    }
    public abstract class VBItemsProviderImportExtensionMethodsBase : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected abstract bool WithReferences { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected abstract JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBExtensionMethodsLookupItem CreateMethodsLookupItem(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.INamespace, string> key, JetBrains.Util.ReadOnlyCollection<JetBrains.ReSharper.Psi.IMethod> itemMethods);
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected virtual bool ShouldBeIncluded(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methods) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBItemsProviderImportMethodsFromModules : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBItemsProviderNameCompletion : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        public override bool IsDynamic { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple specificContext) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLookupServiceProvider : JetBrains.ReSharper.Feature.Services.Lookup.ILookupServiceProvider
    {
        public void BindToDeclaredElement<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T> instance, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange range)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public JetBrains.Util.TextRange BindToDeclaredElements<T>(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T>> instances, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange range)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public void BindToType(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange range, JetBrains.ReSharper.Psi.ITypePointer typePointer) { }
        public string BuildQualifierText(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Psi.Resolve.QualifierKind qualifierKind) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBParameterNameItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    public class VBReparsedCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public VBReparsedCodeCompletionContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText, int referenceOffset) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class VBTokenUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITokenNode GetNextMeaningfulToken(JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
        public static JetBrains.ReSharper.Psi.Tree.ITokenNode GetPrevMeaningfulToken(JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Keyword
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBItemsProviderKeywords : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBThenProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems
{
    
    public class AddressOfLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBMethodsLookupItemBase, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.IVBPreferredLookupItem
    {
        public AddressOfLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod> method, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase owner) { }
        public AddressOfLookupItem(string name, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase owner) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class LambdaLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.IVBPreferredLookupItem
    {
        public LambdaLookupItem(JetBrains.ReSharper.Psi.IDelegate delegat, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, bool isIterator = False) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public int inc(ref int i) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MemberInitializerLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MemberInitializerLookupItem(string name, JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer initializer, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NamedParameterLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NamedParameterLookupItem(string name) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class PreferredTextLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.IVBPreferredLookupItem
    {
        public PreferredTextLookupItem(string text) { }
        public PreferredTextLookupItem(string text, string typeText) { }
        public PreferredTextLookupItem(string text, JetBrains.UI.Icons.IconId image) { }
        public PreferredTextLookupItem(string text, string typeText, bool emphasize) { }
    }
    public class VBAttributeLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBAttributeLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance instance, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    public class VBConstructorLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBConstructorLookupItem(string name, JetBrains.ReSharper.Psi.ITypeElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class VBCreateEventHandlerLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.Impl.CreateNewEventHandlerLookupItem<JetBrains.ReSharper.Psi.Resolve.IReference>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.IVBPreferredLookupItem
    {
        public VBCreateEventHandlerLookupItem(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredType eventType, JetBrains.ReSharper.Psi.IDelegate @delegate, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, string expectedName, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> expectedRoots, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
    }
    public class VBCreateLocalVariableLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.CreateLocalVariableLookupItemBase, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.IVBPreferredLookupItem
    {
        public VBCreateLocalVariableLookupItem(JetBrains.ReSharper.Psi.IType type, string expectedName, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> expectedRoots, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected override string ArgumentModifier { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected override JetBrains.ReSharper.Psi.Tree.IDeclaration CreateLocalVariableDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode nameElement, string safeName, JetBrains.ReSharper.Feature.Services.Lookup.CreateLocalVariableLookupItemBase.ElementFinder nameElementFinder) { }
    }
    public class VBDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
    {
        public VBDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public VBDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance instance, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public bool FixTypeInName { get; set; }
        public override JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PresenterStyle { get; }
        public override bool RemovesTypeQualifier { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.Util.TextRange DoReplaceText(JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange replaceRange, string typeInName) { }
        protected override void InsertTailType(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, int offset, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class VBDeclaredElementLookupItemUtil
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle NoParametersPresenter;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PresenterStyle;
        public static JetBrains.Util.TextRange FixReplaceRangeForEscapedName(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange replaceRange) { }
        public static bool GetBind(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance) { }
        public static JetBrains.ReSharper.Psi.Resolve.QualifierKind GetQualifierKind(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance) { }
        public static string GetSimpleTypeNameString([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance) { }
        public static bool IsEscapingNecessary(JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange replaceRange) { }
    }
    public class VBEnumMemberLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBEnumMemberLookupItem(string shortName, JetBrains.ReSharper.Psi.IField field, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class VBExtensionMethodsLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBMethodsLookupItemBase
    {
        public VBExtensionMethodsLookupItem(string name, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, bool showSignatures) { }
        protected virtual bool AddInformationText { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PresenterStyle { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class VBExtensionMethodsWithReferenceLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBExtensionMethodsLookupItem
    {
        public VBExtensionMethodsWithReferenceLookupItem(string name, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, bool showSignatures, JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        protected override bool AddInformationText { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule ReferencedModule { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class VBGenerateConstructorLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
    {
        public VBGenerateConstructorLookupItem(string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IXmlDocIdOwner> elements, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override string Text { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
    }
    public class VBGenericTypeElementsLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBGenericTypeElementsLookupItem(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> typeElements, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PresenterStyle { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class VBKeywordLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.KeywordLookupItem
    {
        public VBKeywordLookupItem(string text) { }
        protected override void InsertTailType(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, int offset, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
    }
    public class VBMethodsLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBMethodsLookupItemBase
    {
        public VBMethodsLookupItem(JetBrains.ReSharper.Psi.PsiLanguageType languageType, string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public static JetBrains.ReSharper.Psi.ExpectedTypes.TailType CalculateTailType(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods) { }
        protected override JetBrains.Util.TextRange DoReplaceText(JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange replaceRange, string typeInName) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class VBMethodsLookupItemBase : JetBrains.ReSharper.Feature.Services.Lookup.MethodsLookupItem
    {
        protected VBMethodsLookupItemBase(JetBrains.ReSharper.Psi.PsiLanguageType languageType, string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle NoParametersPresenter { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PresenterStyle { get; }
    }
    public class VBModuleMethodsLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.MethodsLookupItem
    {
        public VBModuleMethodsLookupItem(string name, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, bool showSignatures) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class VBParameterNameLookupItem : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.LookupItems.VBDeclaredElementLookupItem
    {
        public VBParameterNameLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class VBPropertyLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
    {
        public VBPropertyLookupItem(string propertyName, string id, bool isReadonly, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override string Text { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Rules.Combo
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBComboNullComparisonProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBComboReturnProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Rules.Double
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBDoubleCompletionRangesProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase specificContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpandBasicCompletionProvider : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Rules.Double.VBExpandBasicCompletionProviderBase { }
    public abstract class VBExpandBasicCompletionProviderBase : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple specificContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpandImportCompletionProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.ExpandImportCompletionProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        public VBExpandImportCompletionProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem CreateLookupItem(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, System.Linq.IGrouping<string, JetBrains.ReSharper.Psi.ITypeElement> typeElements) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetRanges(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override bool IsQualifiedContext(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpandSmartCompletionRule : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase specificContext) { }
    }
    public class VBExpandSmartCompletionWithStaticMembersRule : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple specificContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Rules.Generate
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBConstructorRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBOverrideRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPartialMethodRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPartialRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPropertyRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode GetResolveContext(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration declaration) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Rules
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBAddAwaitTaskMethods : JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBItemsProviderBase<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart context) { }
        protected override bool IsIncluded(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSmart context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBFilterExtensionMethodsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBFixTailTypeRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMergeConstructorsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMergeGenericTypesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        public static void MergeGenericTypes(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMergeMethodsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        public static void DoTransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        public static JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase DoTransformSingleItem(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase lookupItem) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPreferExactTypesInComparison : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPreferLocalSymbolsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPushExtensionMethodsDownRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSimpleTypeItemsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSmartConstructorRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase specificContext) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSoftAfterUsingRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSoftenCompletionBehaviourForLoopVariablesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSoftenCompletionBehaviourForTemplateItemsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBUnitTestCategorySuggestionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "VB.NET")]
    public class VBAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After dot")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterDot;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After \'new\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterNew;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "After \'_\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterUnderscore;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "In doc comments")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnDocComment;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "Letter and digits")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "Where value is expected")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType WhereValueIsExpected;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "VB.NET")]
    public class VBIntelliSenseCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for VB.NET")]
    public class VBIntellisenseEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "VB.NET (.vb files and VB.NET code in supported server pages)")]
        public bool IntellisenseEnabled;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public VBIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Strategies
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyOnDocCommentTags : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public VBAutomaticStrategyOnDocCommentTags(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyOnDot : JetBrains.ReSharper.Feature.Services.VB.VBAutomaticStrategyOnSymbolBase
    {
        public VBAutomaticStrategyOnDot(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override char GetSymbol() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyOnIdentifier : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public VBAutomaticStrategyOnIdentifier(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyOnNew : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public VBAutomaticStrategyOnNew(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyOnOverrideOrPartial : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public VBAutomaticStrategyOnOverrideOrPartial(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager intelliSenseManager) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyOnUnderscore : JetBrains.ReSharper.Feature.Services.VB.VBAutomaticStrategyOnSymbolBase
    {
        public VBAutomaticStrategyOnUnderscore(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override char GetSymbol() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBAutomaticStrategyWhereValueIsExpected : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public VBAutomaticStrategyWhereValueIsExpected(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Settings.VBIntellisenseManager vbIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CodeStructure
{
    
    public class VBCodeStructureEndRegion : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructurePreprocessorElement, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockEnd
    {
        public VBCodeStructureEndRegion(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement, JetBrains.ReSharper.Psi.VB.Tree.IPreprocessorDirective preprocessorDirective, JetBrains.ReSharper.Feature.Services.VB.CodeStructure.VBCodeStructureProcessingState state) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockStart ParentBlock { get; }
        public override bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        protected override string GetText() { }
        public override void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCodeStructureEnregionService : JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureEnregionService
    {
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Execute(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> elements) { }
    }
    public class VBCodeStructureProcessingState
    {
        public VBCodeStructureProcessingState(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        public JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions Options { get; }
        public System.Collections.Generic.Stack<JetBrains.ReSharper.Feature.Services.VB.CodeStructure.VBCodeStructureRegion> Regions { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCodeStructureProvider : JetBrains.ReSharper.Feature.Services.CodeStructure.IPsiFileCodeStructureProvider
    {
        public JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        public static bool CanMoveElements(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement anchor, JetBrains.UI.TreeView.RelativeLocation relativeLocation, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode EncloseInRegion(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> items) { }
        public static void MoveElements(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement anchor, JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> elements) { }
        public static void ProcessChildren(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement structureElement, JetBrains.ReSharper.Feature.Services.VB.CodeStructure.VBCodeStructureProcessingState state) { }
    }
    public class VBCodeStructureRegion : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructurePreprocessorElement, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockStart
    {
        public VBCodeStructureRegion(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement, JetBrains.ReSharper.Psi.VB.Tree.IPreprocessorDirective preprocessorDirective, JetBrains.ReSharper.Feature.Services.VB.CodeStructure.VBCodeStructureProcessingState state) { }
        public JetBrains.ReSharper.Feature.Services.VB.CodeStructure.VBCodeStructureEndRegion EndRegion { get; set; }
        public bool Expanded { get; set; }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockStart ParentBlock { get; }
        public override bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public override bool CanRemove() { }
        public override bool CanRename() { }
        protected override string GetText() { }
        public override string InitialName() { }
        public override void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public override void Remove() { }
        public override void Rename(string newName) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.CompleteStatement
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCompleteStatementActionProvider : JetBrains.ReSharper.Feature.Services.CompleteStatement.ElementBasedCompleteStatementActionProvider { }
}
namespace JetBrains.ReSharper.Feature.Services.VB.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class VBFormatItemAndMatchingArgumentContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ClrFormatItemAndMatchingArgumentContextHighlighter
    {
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.VB.Bulbs.VBContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class VBMatchingBraceContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.VB.Bulbs.VBContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.ContextNavigation
{
    
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBContextNavigationUtil { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExitsFinder : JetBrains.ReSharper.Feature.Services.ContextNavigation.Util.IFunctionExitsFinder
    {
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetReachableExitKeywordsRanges(JetBrains.ReSharper.Psi.Tree.IDeclaration functionDeclaration) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetReachableExitNodes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBExtensionMethodsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IExtensionMethodsContextSearch
    {
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.ExtensionMethodsSearchRequest GetExtensionMethodsRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public JetBrains.ReSharper.Psi.IType GetTypeOutOfSelectedElement(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsSelectedElementAssociatedWithType(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBFunctionExitsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFunctionExitsContextSearch
    {
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBParameterDeclarationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ParameterDeclarationContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IParameterDeclarationContextSearch
    {
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBSubstitutionsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ISubstitutionContextSearch
    {
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchSubstitutionRequest GetSubstitutionRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMemberBodyOperations : JetBrains.ReSharper.Feature.Services.Generate.IMemberBodyOperations
    {
        public VBMemberBodyOperations(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock CreateBodyBlock(JetBrains.ReSharper.Psi.VB.Tree.IVBFunctionDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock CreateDefaultMethodBody(JetBrains.ReSharper.Psi.VB.Tree.IVBFunctionDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock CreateDelegatingBody(JetBrains.ReSharper.Psi.VB.Tree.IVBFunctionDeclaration declaration, JetBrains.ReSharper.Psi.IClrDeclaredElement qualifier, JetBrains.ReSharper.Psi.IOverridableMember delegateTo) { }
        public JetBrains.Util.TextRange GetBodyRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public void RemoveBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.Util.TextRange SetBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBFunctionDeclaration declaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IBlock bodyBlock) { }
        public JetBrains.Util.TextRange SetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.GenerateMemberBody.MethodImplementationKind implementationKind) { }
        public JetBrains.Util.TextRange SetBodyToDefault(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.Util.TextRange SetDelegatingCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IClrDeclaredElement qualifier, JetBrains.ReSharper.Psi.IOverridableMember delegateTo) { }
        public JetBrains.Util.TextRange SetParameterlessMethodCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IMethod methodToCall) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBPropertyBodyUtil
    {
        public VBPropertyBodyUtil(JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody.VBMemberBodyOperations bodyOperations) { }
        public void CreateBackingField(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration, string backingFieldName) { }
        public System.Collections.Generic.IEnumerable<string> GetBackingFieldCandidates(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
        public bool IsBackingFieldAvailable(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration, string fieldName) { }
        public void SetAutoPropertyBody(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration declaration) { }
        public JetBrains.Util.TextRange SetBackingFieldBody(JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration declaration, string backingFieldName) { }
        public JetBrains.Util.TextRange SetBackingFieldBody(JetBrains.ReSharper.Psi.VB.Tree.IAccessorOwnerDeclaration declaration, string backingFieldName) { }
        public JetBrains.Util.TextRange SetDefaultBody(JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration declaration) { }
        public JetBrains.Util.TextRange SetDefaultBody(JetBrains.ReSharper.Psi.VB.Tree.IAccessorOwnerDeclaration declaration) { }
        public string SuggestBackingFieldName(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration property) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Generate
{
    
    public class VbEqualityHelper
    {
        public VbEqualityHelper(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.ITypeElement type, JetBrains.ReSharper.Psi.VB.VBElementFactory factory, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Generate.GeneratorEqualityMember> members) { }
        public JetBrains.ReSharper.Psi.VB.VBElementFactory Factory { get; }
        public bool HasMembers { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public JetBrains.ReSharper.Psi.ITypeElement Type { get; }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBExpression CreateEqualityCheckExpression(JetBrains.ReSharper.Psi.VB.VBElementFactory factory, JetBrains.ReSharper.Psi.IType commonType, object lhsComparand, object rhsComparand) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock GenerateComparatorEqualsBody(object lhsComprand, object rhsComparand) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock GenerateGetHashCodeBody(bool emitBaseCall, [JetBrains.Annotations.CanBeNullAttribute()] object operand = null) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock GenerateObjectEqualsBody(object comparand, JetBrains.ReSharper.Feature.Services.VB.Generate.VbEqualityHelper.TypeCheckMode mode) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlock GenerateTypedEqualsBody(object comparand, bool emitBaseCall, bool emitChecks) { }
        public enum TypeCheckMode
        {
            ExactType = 0,
            ThisType = 1,
            Subclass = 2,
        }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBEventSubscriptionsBuilder : JetBrains.ReSharper.Feature.Services.Generate.GenerateEventSubscriptionsBuilderBase<JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext>
    {
        public JetBrains.ReSharper.Feature.Services.Generate.IMemberBodyOperations BodyOperations { get; }
        public override double Priority { get; }
        protected override string GetEventName(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext context) { }
        protected virtual JetBrains.ReSharper.Psi.IDelegate GetMatchingDelegateType(JetBrains.ReSharper.Feature.Services.Generate.GeneratorEventElement element, ref JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override void Process(JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext context) { }
        public void Process(JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext context, bool emitHandles, JetBrains.ReSharper.Psi.AccessRights handlerAccessRights) { }
    }
    public class VBGenerateUtil
    {
        public static void CopyTypeParametersConstraints(JetBrains.ReSharper.Psi.ITypeParametersOwner from, JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration toMethod, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration CreateEventHandlerDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration classDeclaration, JetBrains.ReSharper.Psi.IDelegate handlerDelegateType, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static string CreateFieldName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static string CreateFieldPresentation(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration CreateMemberDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration classDeclaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.IOverridableMember member, bool forDelegation, ref JetBrains.ReSharper.Psi.Resolve.ISubstitution newSubstitution, bool uniqueName = True) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.IProperty> GetAutoProperties(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode resolveContext) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.IField> GetFieldsFiltered(JetBrains.ReSharper.Psi.ITypeElement typeElement, bool allowStatic) { }
        public static bool IsPartial(JetBrains.ReSharper.Psi.ITypeElement type) { }
        public static JetBrains.ReSharper.Psi.IType MakeSafeType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode context) { }
    }
    public class VBGeneratorContext : JetBrains.ReSharper.Feature.Services.Generate.GeneratorContextBase
    {
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; set; }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration ClassDeclaration { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ProjectModel.IProject Project { get; }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Root { get; }
        public static JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext CreateContext(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext CreateContext(string kind, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        public override void Dispose() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetSelectionTreeRange() { }
        public TTypeMemberDeclaration PutMemberDeclaration<TTypeMemberDeclaration>(TTypeMemberDeclaration declaration, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement = null, [JetBrains.Annotations.InstantHandleAttribute()] System.Func<TTypeMemberDeclaration, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> itemCreator = null)
            where TTypeMemberDeclaration : JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBGeneratorContextFactory : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.Application.DataContext.IDataContext context) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
    }
    public abstract class VBGeneratorProviderBase : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElementProvider
    {
        public abstract double Priority { get; }
        public abstract void Populate(JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext context);
        public void Populate(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBInheritanceAnalyzer : JetBrains.ReSharper.Feature.Services.Generate.InheritanceAnalyzer.IInheritanceAnalyzer
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> GetMissingMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> GetOverridableMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> IInheritanceAnalyzer_GetMissingMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> IInheritanceAnalyzer_GetOverridableMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
    }
    public class VBNotifyPropertyChangedUtil
    {
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBStatement EmitNotifyCall([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod notifyMethod, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration notifyContext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IProperty propertyToNotify, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IField backingField) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Intentions.DataProviders
{
    
    public class AnonymousFunctionTypeProvider
    {
        public AnonymousFunctionTypeProvider(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage Create(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression value) { }
    }
    public class DeclaredTypeProvider
    {
        public DeclaredTypeProvider(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage Create(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression value) { }
    }
    public class EmptyTypeProvider
    {
        public EmptyTypeProvider(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage Create() { }
    }
    public class MethodGroupTypeProvider
    {
        public MethodGroupTypeProvider(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage Create(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
    }
    public class VBMemberSignatureProvider : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignatureProvider
    {
        public VBMemberSignatureProvider(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromArgumentInfos(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.IVBArgumentInfo> arguments, JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromArgumentInfos(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.IVBArgumentInfo> arguments, JetBrains.ReSharper.Psi.IType[] returnTypes, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromArguments(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument> arguments, JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromArguments(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument> arguments, JetBrains.ReSharper.Psi.IType[] returnTypes, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromInvocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.IVBInvocationInfo invocationInfo, bool checkOnlyResolved, JetBrains.ReSharper.Psi.IType defaultType, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Psi.IType defaultType) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage CreateTypeForEventInvocation(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression indexExpression) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage CreateTypeImageFromExpression(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression value) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Intentions.Finders
{
    
    public class VBClassExtendsFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassExtendsFinder
    {
        public VBClassExtendsFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBConstructorInitializerArgumentsFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ConstructorInitializerArgumentsFinder
    {
        public VBConstructorInitializerArgumentsFinder(JetBrains.ReSharper.Psi.VB.Tree.IConstructorDeclaration constructorDeclaration) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBFinderFactory : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.FinderFactory
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.FinderFactory Instance;
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassExtendsFinder CreateClassExtendsFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ConstructorInitializerArgumentsFinder CreateConstructorInitializerArgumentsFinder(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MethodNameFinder CreateMethodNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParamNameFinder CreateParamNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParamTypeUsageFinder CreateParamTypeUsageFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ReturnTypeFinder CreateReturnTypeFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeOwnerDeclarationFinder parent) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeArgumentFinder CreateTypeArgumentFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder parent, int typeArgIndex) { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeKindFinder CreateTypeKindFinders(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent) { }
    }
    public class VBMethodNameFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MethodNameFinder
    {
        public VBMethodNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBParamNameFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParamNameFinder
    {
        public VBParamNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBParamTypeUsageFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParamTypeUsageFinder
    {
        public VBParamTypeUsageFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int index) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBReturnTypeFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ReturnTypeFinder
    {
        public VBReturnTypeFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBTypeArgumentFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeArgumentFinder
    {
        public VBTypeArgumentFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder parent, int typeArgIndex) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
    }
    public class VBTypeKindFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeKindFinder
    {
        public VBTypeKindFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetTypeKindRanges(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Intentions.MemberBody.LockupItems
{
    
    public class AutoPropertyLookupItem : JetBrains.ReSharper.Feature.Services.VB.Intentions.MemberBody.LockupItems.PropertyBodyLookupItemBase
    {
        public AutoPropertyLookupItem(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody.VBPropertyBodyUtil propertyBodyUtil) { }
        public override JetBrains.UI.RichText.RichText DisplayName { get; }
        protected override void SetBody(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
    }
    public class MethodBodyLookupItem : JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates.MemberBodyLookupBase
    {
        public MethodBodyLookupItem(string message, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody.VBMemberBodyOperations bodyOperations) { }
        public override JetBrains.UI.RichText.RichText DisplayName { get; }
        protected override void DoCommand(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public abstract class PropertyBodyLookupItemBase : JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates.MemberBodyLookupBase
    {
        protected PropertyBodyLookupItemBase(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        protected override void DoCommand(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected abstract void SetBody(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration);
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Intentions.MemberBody
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMemberBodyTemplateItemsProvider : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IMemberBodyTemplateItemsProvider
    {
        public VBMemberBodyTemplateItemsProvider(JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody.VBPropertyBodyUtil propertyBodyUtil, JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody.VBMemberBodyOperations bodyOperations) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItems(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Intentions.Util
{
    
    public class VBReferenceCollectingUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression> CollectInvocationExpressions(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression indexExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode scopeElement) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression> CollectReferenceExpressions(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode scopeElement) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IReferenceName> CollectReferenceNames(JetBrains.ReSharper.Psi.VB.Tree.IReferenceName referenceExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode scopeElement) { }
    }
    public class VBTypeProcessUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IExpressionType> Expand(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IExpressionType> types, JetBrains.ReSharper.Psi.IType objectType) { }
        public static System.Collections.Generic.IList<string> GuessTypeParamNames(int count, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode destinationAnchor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.VBElementFactory factory) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Intentions
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBAnnotateWithAttributeIntention : JetBrains.ReSharper.Feature.Services.Intentions.IAnnotateWithAttributeIntention
    {
        public void Annotate(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement markBy, JetBrains.ReSharper.Psi.AttributeValue[] fixedArguments, JetBrains.Util.Pair<, >[] namedArguments) { }
        public bool HasAnnotation(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement annotationType) { }
        public void UpdateAnnotations(JetBrains.ReSharper.Psi.Tree.IDeclaration markedDeclaration, JetBrains.ReSharper.Feature.Services.Intentions.UpdateArgumentsDelegate provideArguments) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBChangeBaseTypeRequiredIntention : JetBrains.ReSharper.Feature.Services.Intentions.IChangeBaseTypeRequiredIntention
    {
        public System.Action<JetBrains.TextControl.ITextControl> Execute(JetBrains.ReSharper.Psi.IClass classToProcess, JetBrains.ReSharper.Psi.IDeclaredType fromType, JetBrains.ReSharper.Psi.IDeclaredType toType) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBChangeSignatureIntention : JetBrains.ReSharper.Feature.Services.Intentions.IChangeSignatureIntention
    {
        public void ChangeSignature(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration signatureToChange, JetBrains.ReSharper.Psi.IParametersOwner sourcePattern, JetBrains.ReSharper.Psi.Resolve.ISubstitution sourceSubstitution, JetBrains.ReSharper.Feature.Services.Intentions.SignatureChangeKind changeKind) { }
        protected static void FixParameters(JetBrains.ReSharper.Psi.VB.Tree.IVBParametersOwnerDeclaration declaration, JetBrains.ReSharper.Psi.InvocableSignature signature, string[] paramNames) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBIntentionLanguageService : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IntentionLanguageSpecific
    {
        public VBIntentionLanguageService(JetBrains.ReSharper.Feature.Services.VB.Generate.MemberBody.VBPropertyBodyUtil propertyBodyUtil) { }
        public override string ClassKeyword { get; }
        public override string EnumKeyword { get; }
        public override JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.FinderFactory FinderFactory { get; }
        public override string InterfaceKeyword { get; }
        public override bool IsVoidMethodDeclarationHasTypeUsage { get; }
        public override string StructKeyword { get; }
        public override JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration AddAccessorDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ownerDeclaration, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        public override void AddBaseConstructorCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration constructorDeclaration) { }
        public override void AddBaseType(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.IDeclaredType inheritsFrom) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration AddToOwnerDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declarationToAdd, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
        public override T AddToTarget<T>(T declarationToAdd, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
        public override JetBrains.ReSharper.Psi.ITypeParameter AddTypeParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration typeParametersOwner, string typeParameterName) { }
        public override bool CanUseExplicitly(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateClassDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool isStatic) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateConstDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateConstructorDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateDelegateDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateEnumMember(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateEventDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateFieldDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateIndexerDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool inInterface, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateInterfaceDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateMethodDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool inInterface, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreatePropertyDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool inInterface, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public override JetBrains.ReSharper.Psi.ITypeConversionRule GetTypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override System.Collections.Generic.IList<string> GuessTypeParamNames(int count, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public override bool IsPurePropertyDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
        public override void SetAccessorBodies(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration typeMemberDeclaration, JetBrains.ReSharper.Psi.GenerateMemberBody.AccessorImplementationKind accessrorImplementationKind, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders) { }
        public override void SetAccessorOwnerName(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration accessorOwnerDeclaration, string name) { }
        public override void SetIsParamArray(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration parameterDeclaration, bool isSet) { }
        public override void SetPartial(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, bool isPartial) { }
        public override void ToExtensionMethod(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration method) { }
        public override bool TypeMembersAreStaticImplicitly(JetBrains.ReSharper.Psi.Tree.IDeclaration targetDeclaration) { }
        public override bool TypeSupportsOnlyStaticMembers(JetBrains.ReSharper.Psi.Tree.ITreeNode targetDeclaration) { }
        public class BackingFieldTypeFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder
        {
            public BackingFieldTypeFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeOwnerDeclarationFinder parent) { }
            public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
            public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSetAccessRightsIntention : JetBrains.ReSharper.Feature.Services.Intentions.ISetAccessRightsIntention
    {
        public void SetAccessRights(JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration declaration, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.LinqTools
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLinqToolsLanguageHelper : JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper
    {
        public VBLinqToolsLanguageHelper() { }
        public string[] AssignAnyPatterns { get; }
        public string[] AssignmentAndReturnPatterns { get; }
        public bool CanOmitTrivialSelect { get; }
        public string[] CastPatterns { get; }
        public string[] CountPatterns { get; }
        public string[] DeclarationAndReturnPatterns { get; }
        public string[] DistinctPatterns { get; }
        public string[] DistinctPatternsWithContinue { get; }
        public string[] DistinctSetVarDeclPatterns { get; }
        public string[] ElementAccessPatterns { get; }
        public string[] EqualsPatterns { get; }
        public string[] FirstOrDefaultPatternsWithBreak { get; }
        public string[] FirstOrDefaultPatternsWithReturn { get; }
        public string[] ForLoopPatterns { get; }
        public string FromQueryExplicitTypeFormatString { get; }
        public string FromQueryFormatString { get; }
        public string[] IfAnyPatterns { get; }
        public string[] IfAnyPatternsWithBreak { get; }
        public string LetQueryFormatString { get; }
        public string[] MaxPatterns { get; }
        public string[] MinPatterns { get; }
        public string[] OfTypePatterns { get; }
        public string[] OfTypePatternsWithContinue1 { get; }
        public string[] OfTypePatternsWithContinue2 { get; }
        public string[] ReturnAnyPatterns { get; }
        public string SelectIntoQueryFormatString { get; }
        public string[] SelectOrLetPatterns { get; }
        public string SelectQueryFormatString { get; }
        public string[] SumPatterns { get; }
        public string[] TakeWhilePatterns { get; }
        public string[] TypeInstantiationOneParamPatterns { get; }
        public string[] TypeInstantiationPatterns { get; }
        public System.Collections.Generic.IEnumerable<System.Type> TypesToMarkOnCopy { get; }
        public bool VariablesInLoopCollectionConflictWithIterator { get; }
        public string[] WhereInversePatterns { get; }
        public string[] WherePatterns { get; }
        public string WhereQueryFormatString { get; }
        public string[] YieldReturnPatterns { get; }
        public JetBrains.ReSharper.Psi.Tree.IStatement AddStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.Tree.IStatement anchor, bool before) { }
        public bool CanReplaceCastOperator(JetBrains.ReSharper.Psi.IType sourceType, JetBrains.ReSharper.Psi.IType targetType, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public void ChangeVariableType(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration declaration, JetBrains.ReSharper.Psi.IType newType) { }
        public bool CheckNoEscapes(JetBrains.ReSharper.Psi.Tree.IStatement statement, JetBrains.ReSharper.Feature.Services.LinqTools.EscapeType escapeTypes, System.Predicate<JetBrains.ReSharper.Psi.Tree.IStatement> filter) { }
        public JetBrains.ReSharper.Psi.ConstantValue ConvertConstantValueToTypeImplicit(JetBrains.ReSharper.Psi.ConstantValue value, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.IFile context) { }
        public void CopyLocal(JetBrains.ReSharper.Psi.Tree.IExpression refExpression) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement CreateAddValueStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeOwner targetVar, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement CreateAssignmentStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeOwner targetVar, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateCastExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IType type) { }
        public JetBrains.ReSharper.Psi.ILocalVariable CreateDummyVariable(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IType type) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateElementPlaceholder(string name, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateExpressionPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement CreateForeachStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.IType elementType, bool useImplicitType, string iteratorName, JetBrains.ReSharper.Psi.Tree.IExpression enumerableExpr, JetBrains.ReSharper.Psi.Tree.IStatementsRange body, bool forceUseBlock) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateIdentifierPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement CreateIfStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression condition, JetBrains.ReSharper.Psi.Tree.IStatementsRange thenStatements) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateInvocationExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IMethod targetMethod, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeArgs, object qualifier, string methodName, params object[] args) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement CreateInvocationStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IMethod targetMethod, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeArgs, object qualifier, string methodName, params object[] args) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateLambdaExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string[] argNames, JetBrains.ReSharper.Psi.Tree.IExpression body) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateLogicalAndExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression condition1, JetBrains.ReSharper.Psi.Tree.IExpression condition2) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateOneElementArrayCreationExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Tree.IExpression element) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string text, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateQueryExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text, System.Collections.Generic.IEnumerable<object> args) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement CreateReturnStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression returnValue) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateStatementPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateStatementsPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateSumExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression operand1, JetBrains.ReSharper.Psi.Tree.IExpression operand2) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateTypePlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateVariableUsageExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeOwner variable) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateVariableUsageExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string variableName) { }
        public JetBrains.ReSharper.Psi.ILocalVariable DeclareTempVariable(JetBrains.ReSharper.Psi.IType type, string name, ref JetBrains.ReSharper.Psi.Tree.IStatementsRange beforeStatementsRange) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression ElementAccessByArgument(JetBrains.ReSharper.Psi.Tree.IExpression argument) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference ElementAccessReference(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression GenerateFunctionalForm(JetBrains.ReSharper.Psi.Tree.IExpression queryExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression GetInitializer(JetBrains.ReSharper.Psi.Tree.IDeclaration localVarDeclaration) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetScopeToCopy(JetBrains.ReSharper.Psi.Tree.IStatement loop) { }
        public bool HasAwaitExpressions(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression InvertCondition(JetBrains.ReSharper.Psi.Tree.IExpression condition) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference InvocationExpressionReference(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public bool IsCastExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, ref JetBrains.ReSharper.Psi.Tree.IExpression operand) { }
        public bool IsCastExpressionOperand(JetBrains.ReSharper.Psi.Tree.IExpression expression, ref JetBrains.ReSharper.Psi.Tree.IExpression castExpr) { }
        public bool IsForeachStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.Tree.IStatementsRange body, ref JetBrains.ReSharper.Psi.ILocalVariable iteratorVar, ref JetBrains.ReSharper.Psi.Tree.IExpression collectionExpr) { }
        public bool IsForStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.Tree.IStatementsRange body) { }
        public bool IsImplicitlyTyped(JetBrains.ReSharper.Psi.ILocalVariable local) { }
        public bool IsInvocation(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.IMethod targetMethod, ref JetBrains.ReSharper.Psi.Tree.IExpression qualifier, ref System.Collections.Generic.IList<> args) { }
        public bool IsInvocation(JetBrains.ReSharper.Psi.Tree.IExpression expression, ref JetBrains.ReSharper.Psi.IMethod targetMethod, ref JetBrains.ReSharper.Psi.Tree.IExpression qualifier, ref System.Collections.Generic.IList<> args) { }
        public bool IsInvocationQualifier(JetBrains.ReSharper.Psi.Tree.IExpression qualifier, ref JetBrains.ReSharper.Psi.Tree.IExpression invocation, ref JetBrains.ReSharper.Psi.IMethod targetMethod, ref System.Collections.Generic.IList<> args) { }
        public bool IsLabelStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public bool IsLastExecutedStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, bool allowIfs, ref JetBrains.ReSharper.Psi.Tree.IExpression valueReturned, ref JetBrains.ReSharper.Psi.Tree.IStatement returnStatementToRemove) { }
        public bool IsLoopBodyBlock(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public bool IsReturnOwner(JetBrains.ReSharper.Psi.Tree.ITreeNode node, ref JetBrains.ReSharper.Psi.IType returnType) { }
        public bool IsSimpleExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public bool IsVariableAssignment(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.ITypeOwner variable, ref JetBrains.ReSharper.Psi.Tree.IExpression valueAssigned) { }
        public bool IsVariableAssignmentValue(JetBrains.ReSharper.Psi.Tree.IExpression expression, ref JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.ITypeOwner variable) { }
        public bool IsVariableUsage(JetBrains.ReSharper.Psi.Tree.IExpression expression, string name) { }
        public bool IsWriteElementAccess(JetBrains.ReSharper.Psi.Tree.IExpression refExpr) { }
        public bool IsYieldStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression ReferenceExpressionByQualifier(JetBrains.ReSharper.Psi.Tree.IExpression qualifier) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression ReferenceExpressionByReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference ReferenceExpressionReference(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public void RemoveStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public void RenameVarRef(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression newExpr, ref JetBrains.ReSharper.Psi.Tree.IExpression expr) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression ReplaceBy(JetBrains.ReSharper.Psi.Tree.IExpression oldExpr, JetBrains.ReSharper.Psi.Tree.IExpression newExpr) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement ReplaceBy(JetBrains.ReSharper.Psi.Tree.IStatement oldStatement, JetBrains.ReSharper.Psi.Tree.IStatement newStatement) { }
        public void SetInitializer(JetBrains.ReSharper.Psi.Tree.IDeclaration localVarDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression value) { }
        public void SetTypeOrVar(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration localVarDeclaration, JetBrains.ReSharper.Psi.IType type) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration SingleVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public JetBrains.ReSharper.Psi.Tree.IStatementsRange SkipStatements(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IStatement> statements, int n) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> StatementsAfter(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> StatementsBefore(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public JetBrains.ReSharper.Psi.Tree.IStatementsRange StatementsToRange(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IStatement> statements) { }
        public JetBrains.ReSharper.Psi.Tree.IStatementsRange StatementToRange(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public JetBrains.ReSharper.Psi.Tree.IStatementsRange ToStatementsRange(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public JetBrains.ReSharper.Psi.ITypeConversionRule TypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public bool VarCanAggregateMultipleTimes(JetBrains.ReSharper.Psi.ILocalVariable workingVar, JetBrains.ReSharper.Psi.Tree.IStatement setVarDeclStatement) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.LiveTemplates
{
    
    public abstract class BaseTemplateExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression
    {
        protected BaseTemplateExpression(string suggestedName) { }
        protected virtual bool LookupSuggestedNameIfEmpty { get; }
        public object Clone() { }
        public virtual string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected abstract System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItemsImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext);
        public virtual void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBTemplateUtil
    {
        public class TypeTemplateExpression : JetBrains.ReSharper.Feature.Services.VB.LiveTemplates.BaseTemplateExpression
        {
            public TypeTemplateExpression(string suggestedName, JetBrains.ReSharper.Psi.IType defaultType, JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool canIntroduceImplicit, bool preferImplicit) { }
            protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItemsImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.My.Analyses.CallHierarchy
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCallHierarchyLanguageSpecific : JetBrains.ReSharper.Feature.Services.CallHierarchy.Impl.ICallHierarchyLanguageSpecific
    {
        public JetBrains.ReSharper.Psi.IEvent ExtractEventReadWrite(JetBrains.ReSharper.Psi.Resolve.IReference reference, out bool isSubscription) { }
        public JetBrains.ReSharper.Psi.IConstructor ExtractImplicitBaseConstructorCall(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> ExtractInitializersFromDeclaration(JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration initializerOwner) { }
        public JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult ExtractSubscriber(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> ExtractSubscribersFromDeclaration(JetBrains.ReSharper.Psi.ITypeMember delegateTypeMember, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression GetClosure(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Feature.Services.CallHierarchy.Impl.EventAccessType GetEventAccessType(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression GetQuery(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetReferenceElement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string GetUnresolvedPresentation(JetBrains.ReSharper.Psi.Tree.ITreeNode unresolvedElement) { }
        public bool IsIncomingSkippedReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool IsMethodGroupReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Naming
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VBPredefinedNamingPolicySettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Navigation
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBOccurenceKindProvider : JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.IOccurenceKindProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllPossibleOccurenceKinds() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBSpecificGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrSpecificGotoFileMemberProvider
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Psi
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBReferencedCodeSearchHelper : JetBrains.ReSharper.Feature.Services.Psi.ReferencedCodeSearchHelperBase, JetBrains.ReSharper.Feature.Services.ReferencedCode.IReferencedCodeSearchHelper
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ReferencedCode.NamespaceImportData> GetNamespaceImportsList(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetUpdatedTargets(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IClrDeclaredElement target) { }
        public bool RemoveNamespaceImport(JetBrains.ReSharper.Psi.Tree.ITreeNode importNamespaceNode) { }
    }
    public class VBUnresolvedTypesChooser : JetBrains.ReSharper.Feature.Services.Psi.IUnresolvedTypesChooser
    {
        public VBUnresolvedTypesChooser(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public void AddUnresolvedTypes(string typeText, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> result) { }
        public JetBrains.ReSharper.Psi.IType Apply(string typeText, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> boundTypes) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.RearrangeCode
{
    
    public class RearrangeableAnonymousMemberDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IAnonymousMemberDeclaration>
    {
        public RearrangeableAnonymousMemberDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousMemberDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IAnonymousMemberDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IAnonymousMemberDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousMemberDeclaration element) { }
        }
    }
    public class RearrangeableArgument : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument>
    {
        public RearrangeableArgument(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument element) { }
        }
    }
    public class RearrangeableArrayInitalizer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        public RearrangeableArrayInitalizer(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression element) { }
        }
    }
    public class RearrangeableAttribute : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IAttribute>
    {
        public RearrangeableAttribute(JetBrains.ReSharper.Psi.VB.Tree.IAttribute element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IAttribute> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IAttribute>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IAttribute element) { }
        }
    }
    public class RearrangeableBaseType : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage>
    {
        public RearrangeableBaseType(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage> GetSiblings() { }
    }
    public class RearrangeableBlockItem : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IBlock>
    {
        public JetBrains.ReSharper.Psi.VB.StatementsRange StatementsRange { get; set; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction dir) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IBlock>.TypeBase
        {
            public override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IBlock>.ILogicalItem CreateItem(JetBrains.ReSharper.Psi.Tree.ITreeNode cursor, JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IBlock>.ILogicalItem prevItem) { }
        }
    }
    public class RearrangeableCaseClause : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ICaseClause>
    {
        public RearrangeableCaseClause(JetBrains.ReSharper.Psi.VB.Tree.ICaseClause element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ICaseClause> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ICaseClause>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ICaseClause element) { }
        }
    }
    public class RearrangeableCaseStatement : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement>
    {
        public RearrangeableCaseStatement(JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement element) { }
        }
    }
    public class RearrangeableClassItem : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IClassBody>
    {
        public JetBrains.ReSharper.Psi.VB.Impl.DeclarationsRange DeclarationsRange { get; set; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IClassBody>.TypeBase
        {
            public override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IClassBody>.ILogicalItem CreateItem(JetBrains.ReSharper.Psi.Tree.ITreeNode cursor, JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IClassBody>.ILogicalItem prevItem) { }
        }
    }
    public class RearrangeableCollectionElementInitializer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ICollectionElementInitializer>
    {
        public RearrangeableCollectionElementInitializer(JetBrains.ReSharper.Psi.VB.Tree.ICollectionElementInitializer element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ICollectionElementInitializer> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ICollectionElementInitializer>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ICollectionElementInitializer element) { }
        }
    }
    public class RearrangeableConstantDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration>
    {
        public RearrangeableConstantDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration element) { }
        }
    }
    public class RearrangeableEnumItem : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IEnumDeclaration>
    {
        public RearrangeableEnumItem(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IEnumDeclaration>.ILogicalItem> selectedItems, JetBrains.ReSharper.Psi.VB.Tree.IEnumDeclaration holder, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IEnumDeclaration>.ILogicalItem> holderItems) { }
        public JetBrains.ReSharper.Psi.VB.Impl.DeclarationsRange DeclarationsRange { get; set; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableEraseExpression : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        public RearrangeableEraseExpression(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression element) { }
        }
    }
    public class RearrangeableEventSpecifier : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IEventSpecifier>
    {
        public RearrangeableEventSpecifier(JetBrains.ReSharper.Psi.VB.Tree.IEventSpecifier element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IEventSpecifier> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IEventSpecifier>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IEventSpecifier element) { }
        }
    }
    public class RearrangeableImportDirective : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IImportDirective>
    {
        public RearrangeableImportDirective(JetBrains.ReSharper.Psi.VB.Tree.IImportDirective element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IImportDirective> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IImportDirective>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IImportDirective element) { }
        }
    }
    public class RearrangeableInterfaceInherits : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage>
    {
        public RearrangeableInterfaceInherits(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage element) { }
        }
    }
    public class RearrangeableInterfaceMemberSpecifier : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier>
    {
        public RearrangeableInterfaceMemberSpecifier(JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier element) { }
        }
    }
    public class RearrangeableJoinCondition : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IJoinCondition>
    {
        public RearrangeableJoinCondition(JetBrains.ReSharper.Psi.VB.Tree.IJoinCondition element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IJoinCondition> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IJoinCondition>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IJoinCondition element) { }
        }
    }
    public class RearrangeableLambdaParameter : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ILambdaParameterDeclaration>
    {
        public RearrangeableLambdaParameter(JetBrains.ReSharper.Psi.VB.Tree.ILambdaParameterDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ILambdaParameterDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ILambdaParameterDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ILambdaParameterDeclaration element) { }
        }
    }
    public class RearrangeableLocalDeclarationList : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ILocalDeclarationList>
    {
        public RearrangeableLocalDeclarationList(JetBrains.ReSharper.Psi.VB.Tree.ILocalDeclarationList element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ILocalDeclarationList> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ILocalDeclarationList>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ILocalDeclarationList element) { }
        }
    }
    public class RearrangeableLocalVariableDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration>
    {
        public RearrangeableLocalVariableDeclaration(JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration element) { }
        }
    }
    public class RearrangeableMemberInitializer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer>
    {
        public RearrangeableMemberInitializer(JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer element) { }
        }
    }
    public class RearrangeableOption : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IOptionStatement>
    {
        public RearrangeableOption(JetBrains.ReSharper.Psi.VB.Tree.IOptionStatement element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IOptionStatement> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IOptionStatement>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IOptionStatement element) { }
        }
    }
    public class RearrangeableOrderExpression : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IOrderExpression>
    {
        public RearrangeableOrderExpression(JetBrains.ReSharper.Psi.VB.Tree.IOrderExpression element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IOrderExpression> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IOrderExpression>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IOrderExpression element) { }
        }
    }
    public class RearrangeableParameter : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration>
    {
        public RearrangeableParameter(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration element) { }
        }
    }
    public class RearrangeablePropertyAccessor : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration>
    {
        public RearrangeablePropertyAccessor(JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration element) { }
        }
    }
    public class RearrangeableQueryOperator : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IQueryOperator>
    {
        public RearrangeableQueryOperator(JetBrains.ReSharper.Psi.VB.Tree.IQueryOperator element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IQueryOperator> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IQueryOperator>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IQueryOperator element) { }
        }
    }
    public class RearrangeableRedimClause : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IRedimClause>
    {
        public RearrangeableRedimClause(JetBrains.ReSharper.Psi.VB.Tree.IRedimClause element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IRedimClause> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IRedimClause>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IRedimClause element) { }
        }
    }
    public class RearrangeableStatementInLineIf : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVBStatement>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBStatement> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVBStatement>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVBStatement element) { }
        }
    }
    public class RearrangeableTypeArgument : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage>
    {
        public RearrangeableTypeArgument(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage element) { }
        }
    }
    public class RearrangeableTypeOrNamespaceHolderItem : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration>
    {
        public RearrangeableTypeOrNamespaceHolderItem(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration>.ILogicalItem> selectedItems, JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration holder, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration>.ILogicalItem> holderItems) { }
        public JetBrains.ReSharper.Psi.VB.Impl.DeclarationsRange DeclarationsRange { get; set; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.VB.RearrangeCode.RearrangeableVBLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration>.TypeBase
        {
            public override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration>.ILogicalItem CreateItem(JetBrains.ReSharper.Psi.Tree.ITreeNode cursor, JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration>.ILogicalItem prevItem) { }
        }
    }
    public class RearrangeableTypeParameterConstraint : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint>
    {
        public RearrangeableTypeParameterConstraint(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint element) { }
        }
    }
    public class RearrangeableTypeParameterOfMethod : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfMethodDeclaration>
    {
        public RearrangeableTypeParameterOfMethod(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfMethodDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfMethodDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfMethodDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfMethodDeclaration element) { }
        }
    }
    public class RearrangeableTypeParameterOfType : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration>
    {
        public RearrangeableTypeParameterOfType(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration element) { }
        }
    }
    public class RearrangeableUsingVariableDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration>
    {
        public RearrangeableUsingVariableDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration element) { }
        }
    }
    public class RearrangeableVariableDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration>
    {
        public RearrangeableVariableDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration element) { }
        }
    }
    public class RearrangeableVariableDeclarationList : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList>
    {
        public RearrangeableVariableDeclarationList(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList element) { }
        }
    }
    public abstract class RearrangeableVBLogicalItemBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>
        where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected RearrangeableVBLogicalItemBase(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> selectedItems, THolder holder, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> holderItems) { }
        public abstract class TypeBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.TypeBase
            where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            protected override bool TreeNodeIsNewLine(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        }
    }
    public class RearrangeableXmlAttribute : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.VB.Tree.IVBXmlAttribute>
    {
        public RearrangeableXmlAttribute(JetBrains.ReSharper.Psi.VB.Tree.IVBXmlAttribute element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBXmlAttribute> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.VB.Tree.IVBXmlAttribute>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.VB.Tree.IVBXmlAttribute element) { }
        }
    }
    public class RearrangeableXmlElement : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
    {
        public RearrangeableXmlElement(JetBrains.ReSharper.Psi.VB.Tree.IVBXmlElement tag) { }
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
}
namespace JetBrains.ReSharper.Feature.Services.VB.SelectEmbracingConstruct
{
    
    public class VBDotSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.DotSelection<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
    {
        public VBDotSelection(JetBrains.ReSharper.Psi.VB.Tree.IVBFile fileNode, JetBrains.ReSharper.Psi.TreeOffset offset, bool selectBetterToken, bool useCamelHumps) { }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTokenPartSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTreeNodeSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetParentInternal(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override bool IsLiteralToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsNewLineToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsPrevTokenBetter(JetBrains.ReSharper.Psi.Tree.ITokenNode prevToken, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override bool IsSpaceToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsWordToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class VBSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider
    {
        public VBSelectEmbracingConstructProvider(JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class VBTokenPartSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TokenPartSelection<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>
    {
        public VBTokenPartSelection(JetBrains.ReSharper.Psi.VB.Tree.IVBFile fileNode, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public class VBTreeNodeSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TreeNodeSelection<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
    {
        public VBTreeNodeSelection(JetBrains.ReSharper.Psi.VB.Tree.IVBFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
    }
    public class VBTreeRangeSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TreeRangeSelection<JetBrains.ReSharper.Psi.VB.Tree.IVBFile>
    {
        public VBTreeRangeSelection(JetBrains.ReSharper.Psi.VB.Tree.IVBFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.DefaultTodoContentsProvider
    {
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.TypingAssist
{
    
    public class TypingAssistContext
    {
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType PrevMeaningfulTokenType;
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType;
        public int TypedPosition;
    }
    public class VBBracketMatcher : JetBrains.ReSharper.Feature.Services.TypingAssist.BracketMatcher
    {
        public VBBracketMatcher() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class VBTypingAssist : JetBrains.ReSharper.Feature.Services.VB.TypingAssist.VBTypingAssistBase
    {
        public VBTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class VBTypingAssistBase : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<JetBrains.ReSharper.Psi.VB.VBLanguage, JetBrains.ReSharper.Psi.VB.CodeStyle.IVBCodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        protected VBTypingAssistBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected virtual int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        public bool HandleQuoteTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        public virtual bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.Util
{
    
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class PsiUtil
    {
        public static JetBrains.ReSharper.Psi.IType CalculateCommonReturnType(JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode node) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.ILoopStatement FindLoop(JetBrains.ReSharper.Psi.VB.Tree.IContinueStatement continueStatement) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> GetExits(JetBrains.ReSharper.Psi.VB.ControlFlow.IVBControlFlowElement element) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBExpression InvertCondition(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VbBaseClassUtil : JetBrains.ReSharper.Feature.Services.Util.IBaseClassUtil
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetBaseDeclarationsReferences(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBTypeValidator : JetBrains.ReSharper.Feature.Services.Util.ITypeValidator
    {
        public bool IsValidExpression(string expr) { }
        public bool IsValidName(string name) { }
        public bool IsValidParameterType(string type) { }
        public bool IsValidReturnType(string type) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.VB.VisualElements
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBColorDeclaredElementSearcher : JetBrains.ReSharper.Feature.Services.Colors.IColorDeclaredElementSearcher
    {
        public System.Collections.Generic.IEnumerable<string> GetWords(JetBrains.ReSharper.Psi.Colors.IColorDeclaredElement element) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VisualElementFactory : JetBrains.ReSharper.Feature.Services.VisualElements.IVisualElementFactory
    {
        public JetBrains.ReSharper.Psi.Colors.IColorReference GetColorReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}