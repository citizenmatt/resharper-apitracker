[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Xaml.Bulbs
{
    
    public class XamlContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Feature.Services.Xml.Bulbs.IXmlContextActionProvider ContextActionProvider;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes;
        protected XamlContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile xmlFile, JetBrains.ReSharper.Feature.Services.Xml.Bulbs.IXmlContextActionProvider contextActionProvider) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T FindNodeAtCaret<T>()
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T FindReferenceAtCaret<T>()
            where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider>
        {
            public static readonly JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider, JetBrains.ReSharper.Psi.Xaml.XamlLanguage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider> GetContextKey() { }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlContextActionProvider : JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionProvider
    {
        public override System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange[] GetTagNameRanges(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToReplace) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class CollapseEmptyTags : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies
{
    
    public abstract class XamlAutomaticStrategyOnCharacterBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public abstract bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken FindCurrentToken(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl);
        public virtual bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XamlAutomaticStrategyOnIdentifier : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies.XamlAutomaticStrategyOnCharacterBase
    {
        public XamlAutomaticStrategyOnIdentifier(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.Settings.XamlIntellisenseManager manager) { }
        public override bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public override bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class XamlAutomaticStrategyOnListedCharacters : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies.XamlAutomaticStrategyOnCharacterBase
    {
        public override bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected abstract bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies.XamlAutomaticStrategyOnListedCharacters.StartChar> GetStartChars([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes) { }
        protected sealed class StartChar
        {
            public readonly char Char;
            public readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PrevToken;
            public readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType Token;
            public StartChar(char c, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType prevToken = null) { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XamlAutomaticStrategyOnPunctuation : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies.XamlAutomaticStrategyOnListedCharacters
    {
        public XamlAutomaticStrategyOnPunctuation(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.Settings.XamlIntellisenseManager manager) { }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies.XamlAutomaticStrategyOnListedCharacters.StartChar> GetStartChars(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xml) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class XamlAutomaticStrategyOnWhitespaceBase : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.AutomaticStrategies.XamlAutomaticStrategyOnCharacterBase
    {
        public XamlAutomaticStrategyOnWhitespaceBase(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.Settings.XamlIntellisenseManager xamlIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlAutoProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlBasicProviderBase<JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.Resolve.ICompleteableReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ICompleteableReference GetReference(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlBasicProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlBasicProviderBase<JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ICompleteableReference GetReference(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    public abstract class XamlBasicProviderBase<TReference> : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlItemProvider<TReference>
        where TReference :  class, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
    {
        protected override void AddLookupItemsForDeclaredElement(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, TReference reference, string name) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(TReference reference, string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override bool EvaluateLookupItems(TReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected virtual JetBrains.ReSharper.Psi.ExpectedTypes.TailType EvaluateTail(JetBrains.ReSharper.Psi.IDeclaredElement element, TReference reference) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(TReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlConstantValuesProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlElementPropertyAutoProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlElementPropertyProviderBase
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlElementPropertyBasicProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlElementPropertyProviderBase
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    public abstract class XamlElementPropertyProviderBase : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlPropertyProviderBase
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateSettedPropertiesFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool EvaluateLookupItems(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference GetReference(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlElementPropertySmartProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlElementPropertyProviderBase
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    public abstract class XamlItemProvider<TReference> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.ItemsProviderWithSymbolTable<JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext, TReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile>
        where TReference :  class, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
    {
        protected override void AddLookupItemsForDeclaredElement(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, TReference reference, string name) { }
        protected abstract JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(TReference reference, string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges);
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        public bool ExpandNamespaceAliases([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected string GetDisplayName(TReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, out bool isMarkupExtension) { }
        protected JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> PresentProperty(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, out string displayName) { }
        public bool SmartBehaviorForAuto([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlMarkupPropertyAutoProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlMarkupPropertyProviderBase
    {
        protected override bool EvaluateLookupItems(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlMarkupPropertyBasicProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlMarkupPropertyProviderBase
    {
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    public abstract class XamlMarkupPropertyProviderBase : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlPropertyProviderBase
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateSettedPropertiesFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference GetReference(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlMarkupPropertySmartProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlMarkupPropertyProviderBase
    {
        protected override bool EvaluateLookupItems(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlNameProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContextWithSharedData<JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlNameProvider.Data>
    {
        public override bool IsDynamic { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlNameProvider.Data data) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlNameProvider.Data data) { }
        protected override JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlNameProvider.Data IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        public class Data
        {
            public bool ItemsAdded;
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlNamespaceBasicProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlItemProvider<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference reference, string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override bool EvaluateLookupItems(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference GetReference(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    public abstract class XamlPropertyProviderBase : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlItemProvider<JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateSettedPropertiesFilter(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context);
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference reference, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context);
        protected sealed class SettedPropertiesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public SettedPropertiesFilter(JetBrains.ReSharper.Psi.Resolve.IReference currentReference, System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference>> getSettedProperties) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlTagNameBasicProvider : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.ItemsProviders.XamlBasicProviderBase<JetBrains.ReSharper.Psi.Resolve.ICompleteableReference>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(JetBrains.ReSharper.Psi.Resolve.ICompleteableReference reference, string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ICompleteableReference GetReference(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for XAML")]
    public class IntellisenseEnabledSettingXaml
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "XAML (.xaml files)")]
        public bool IntellisenseEnabled;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "XAML")]
    public class XamlAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On identifiers")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdentifiers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On punctuation")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnPunctuation;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On space")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnSpace;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XamlIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public XamlIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion
{
    
    public class static ValueReferenceUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetTypeDeclaration(JetBrains.ReSharper.Psi.Xaml.Tree.IValueReference valueReference, out JetBrains.ReSharper.Psi.IDeclaredType eventType, out JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public static string SuggestName(JetBrains.ReSharper.Psi.Xaml.Tree.IValueReference reference) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class VsCompletorPaneDisabler
    {
        public VsCompletorPaneDisabler(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionHost codeCompletionHost, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager) { }
    }
    public class XamlCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext
    {
        public XamlCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlMarkupPropertyReparsedContext markupPropertyContext, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlNamespaceAliasReparsedContext namespaceAliasContext, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlStaticResourceReparsedContext resourceContext, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlTypeNameReparsedContext importTypeContext, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlTagNameReparsedContext tagNameContext) { }
        public override string ContextId { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlTypeNameReparsedContext ImportTypeContext { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlMarkupPropertyReparsedContext MarkupPropertyContext { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlNamespaceAliasReparsedContext NamespaceAliasContext { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlStaticResourceReparsedContext StaticResourceContext { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlTagNameReparsedContext TagNameContext { get; set; }
        public TReference GetReferenceUnderCaret<TReference>()
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class XamlCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContextProvider
    {
        public XamlCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.Settings.XamlIntellisenseManager xamlIntellisenseManager) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile IsAvailableImpl(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class XamlCompletingCharsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSettingOther<JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext>
    {
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context) { }
    }
    public class XamlDeclaredElementLookupItem<T> : JetBrains.ReSharper.Feature.Services.Lookup.Impl.DeclaredElementLookupItem<T, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile>
        where T :  class, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
    {
        public XamlDeclaredElementLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string displayName, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public JetBrains.UI.Icons.IconId CustomIcon { get; set; }
        protected bool DiscardSuffix { get; set; }
        public JetBrains.UI.RichText.RichText DisplayPrefix { get; set; }
        public override string Identity { get; }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public string Prefix { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceAfterComplete(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        protected override void DecorateDisplayName(JetBrains.UI.RichText.RichText displayName, JetBrains.ReSharper.Psi.DeclaredElementInstance preferredDeclaredElement) { }
        protected override JetBrains.Util.TextRange DoReplaceText(JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange replaceRange, string typeInName) { }
        protected override void InsertTailType(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, int offset, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected void InsertTextAndFormatNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, [JetBrains.Annotations.NotNullAttribute()] string textToInsert, System.Nullable<int> caretOffset, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsReferenceValid(JetBrains.Util.TextRange nameRange, T reference) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        protected override void PlaybackSuffix(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix) { }
        protected void PopulateAutoCompletion() { }
        protected void SetCharsToSkipTypingAssist([JetBrains.Annotations.NotNullAttribute()] string chars) { }
    }
    public class XamlMarkupPropertyLookupItem : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlDeclaredElementLookupItem<JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyReference>
    {
        public XamlMarkupPropertyLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string displayName, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, bool isMarkupProperty) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceAfterComplete(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        protected bool MarkupPropertyCodeCompletion([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, bool needComma) { }
    }
    public class XamlMarkupPropertyReparsedContext : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlReparsedCodeCompletionContext
    {
        public XamlMarkupPropertyReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string text, int shift) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; set; }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
    }
    public class XamlNamespaceAliasReparsedContext : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlReparsedCodeCompletionContext
    {
        public const string CLR_NAMESPACE = "clr-namespace:a";
        public const string USING_NAMESPACE = "using:a";
        public XamlNamespaceAliasReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias alias, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; set; }
        public string ReparsePrefix { get; }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
    }
    public class XamlNamespaceLookupItem : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlDeclaredElementLookupItem<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference>
    {
        public XamlNamespaceLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementInstance, JetBrains.ReSharper.Psi.Modules.IPsiModule module, string displayName, JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule NamespaceModule { get; }
        protected override void DecorateDisplayName(JetBrains.UI.RichText.RichText displayName, JetBrains.ReSharper.Psi.DeclaredElementInstance preferredDeclaredElement) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class XamlReparsedCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext
    {
        public XamlReparsedCodeCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
    }
    public class XamlStaticResourceReparsedContext : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlReparsedCodeCompletionContext
    {
        public XamlStaticResourceReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
    }
    public class XamlTagNameReparsedContext : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlReparsedCodeCompletionContext
    {
        public XamlTagNameReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string text) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; set; }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
    }
    public class XamlTailType : JetBrains.ReSharper.Psi.ExpectedTypes.TailType
    {
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType Colon;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType Dot;
    }
    public class XamlTypeNameReparsedContext : JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.XamlReparsedCodeCompletionContext
    {
        public XamlTypeNameReparsedContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; set; }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class XamlMatchingBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ContextHighlighterBase
    {
        protected override void CollectHighlightings(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.DataConstants
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class XamlDataRules
    {
        public XamlDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionman) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.Intentions
{
    
    public class CreateDependencyPropertyDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public string PropertyName;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage PropertyType;
    }
    public interface ICreateAttachedPropertyIntention : JetBrains.ReSharper.Feature.Services.Xaml.Intentions.ICreateDependencyPropertyIntentionBase { }
    public interface ICreateDependencyPropertyIntention : JetBrains.ReSharper.Feature.Services.Xaml.Intentions.ICreateDependencyPropertyIntentionBase { }
    public interface ICreateDependencyPropertyIntentionBase
    {
        JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteEx(JetBrains.ReSharper.Feature.Services.Xaml.Intentions.CreateDependencyPropertyDeclarationContext context);
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlSetAccessRightsIntention : JetBrains.ReSharper.Feature.Services.Intentions.ISetAccessRightsIntention
    {
        public void SetAccessRights(JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration declaration, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("dependancyPropertyType", LongDescription="Evaluates to dependency property type specific to current framework", ShortDescription="DependencyProperty type")]
    public class DependencyPropertyTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.DependencyPropertyTypeMacroDef))]
    public class DependencyPropertyTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class XamlFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.XamlFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
    }
    public abstract class XamlFileTemplatesSupportBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport
    {
        protected abstract JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public abstract string Name { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public virtual bool Accepts(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-120D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class XamlProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public XamlProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XamlProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public XamlProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope
{
    
    public class InAnyXamlProject : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string DefaultFileName { get; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InSilverlightXamlProject : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope.InAnyXamlProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InWinRTXamlProject : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope.InAnyXamlProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InWPFXamlProject : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope.InAnyXamlProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InXamlSpecificProject : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope.InAnyXamlProject
    {
        public InXamlSpecificProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.ProjectLanguage projectLanguage) { }
        public override System.Guid GetDefaultUID() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.MatchingBrace
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlMatchingBraceProvider : JetBrains.ReSharper.Feature.Services.MatchingBrace.ISimpleMatchingBraceProvider, JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        public XamlMatchingBraceProvider(JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes xamlTokenTypes) { }
        public int Compare(JetBrains.ReSharper.Psi.Parsing.TokenNodeType x, JetBrains.ReSharper.Psi.Parsing.TokenNodeType y) { }
        public JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
        public bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class XamlClrGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrGotoFileMemberProvider
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected override bool IsSourceFileAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.Options
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings), "XAML typing assistance settings", KeyNameOverride="Xaml")]
    public class XamlTypingAssistSettings : JetBrains.ReSharper.Feature.Services.Xml.Options.XmlTypingAssistSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Auto-insert tag footer in code completion")]
        public bool AutoInsertTagFooter;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Expand namespace aliases in code completion")]
        public bool ExpandNamespaceAliasesInCodeCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use smart behavior for automatic code completion")]
        public bool UseSmartBehaviorForAutoCompletion;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.RearrangeCode
{
    
    public class RearrangeableMarkupAttribute : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementAppendRemove<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue>
    {
        public RearrangeableMarkupAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute) { }
        protected override JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue Parent { get; }
        protected override JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute AddAfter(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue parent, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute child, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute anchor) { }
        protected override JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute AddBefore(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue parent, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute child, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute anchor) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute> GetChildren(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue parent) { }
        protected override void RemoveChild(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue parent, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute child) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute(Level=110)]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableXamlTag : JetBrains.ReSharper.Feature.Services.Xml.RearrangeCode.RearrangeableTag
    {
        public RearrangeableXamlTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.SearchDomainFactory domainFactory) { }
        public override string Title { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute(Level=110)]
        public class AttributeType : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute(Level=110)]
        public class TagType : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public TagType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.SearchDomainFactory domainFactory) { }
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.TypingAssist
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlChangedTagNameTrackerSettingsProvider : JetBrains.ReSharper.Feature.Services.Xml.TypingAssist.XmlChangedTagNameTrackerSettingsProvider
    {
        public override bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.VisualElements
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlColorDeclaredElementSearcher : JetBrains.ReSharper.Feature.Services.Colors.IColorDeclaredElementSearcher
    {
        public System.Collections.Generic.IEnumerable<string> GetWords(JetBrains.ReSharper.Psi.Colors.IColorDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Xaml.Generate
{
    
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorElementProviderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlEventsProvider : JetBrains.ReSharper.Feature.Services.Generate.GeneratorEventsProviderBase<JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext>
    {
        public override double Priority { get; }
        public override void Populate(JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlEventSubscriptionsBuilder : JetBrains.ReSharper.Feature.Services.Generate.GenerateEventSubscriptionsBuilderBase<JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext>
    {
        public override double Priority { get; }
        protected override string GetEventName(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext context) { }
        protected override void Process(JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext context) { }
        protected override string SuggestEventHandlerPrefix(JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext context) { }
    }
    public class XamlGeneratorContext : JetBrains.ReSharper.Feature.Services.Generate.GeneratorContextBase
    {
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> CodebehindDeclarations { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ProjectModel.IProject Project { get; }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Root { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile XamlFile { get; set; }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration XamlTypeDeclaration { get; }
        public static JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext CreateContext(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement FindXamlObjectElement(out JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetSelectionTreeRange() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlGeneratorContextFactory : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
    }
}