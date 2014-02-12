[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.IntentionsTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.CSharp.Analyses.CallHieracrhy
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCallHierarchyLanguageSpecific : JetBrains.ReSharper.Feature.Services.CallHierarchy.Impl.ICallHierarchyLanguageSpecific
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
        public bool HasBody(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration functionDeclaration) { }
        public bool IsIncomingSkippedReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool IsMethodGroupReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Bulbs
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionDataBuilderAttribute(typeof(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider))]
    public class CSharpContextActionDataBuilder : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class CSharpContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile>, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile>, JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider
    {
        public CSharpContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file) { }
        public JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory ElementFactory { get; }
        public JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowGraf GetControlFlowGraf() { }
        public JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowAnalysisResult InspectControlFlowGraf() { }
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider>
        {
            public static readonly JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.CSharpContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider, JetBrains.ReSharper.Psi.CSharp.CSharpLanguage, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider> GetContextKey() { }
        }
    }
    public interface ICSharpContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile>
    {
        JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory ElementFactory { get; }
        JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowGraf GetControlFlowGraf();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowAnalysisResult InspectControlFlowGraf();
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.OptimizeUsings)})]
    public class ArrangeThisQualifier : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor DESCRIPTOR;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor[] DESCRIPTORS;
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
    public class static CommonCleanupUtils
    {
        public static void InvokeAsExtensionMethod(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression expression) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileHeaderUtils : JetBrains.ReSharper.Feature.Services.CodeCleanup.IFileHeaderUtils
    {
        public FileHeaderUtils(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager liveTemplatesManager, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CreatedDateTimeMacroDef createdDateTimeMacro, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CurrentDateTimeMacroDef currentDateTimeMacro, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CurrentDateMacroDef currentDateMacro) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.TemplateField>> EnumerateFieldGroups() { }
        public bool InsertHeader(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int startOffset) { }
        public bool IsHeaderEmpty(JetBrains.DocumentModel.IDocument document) { }
        public void UpdateFileHeader(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.OptimizeUsings)})]
    public class HighlightingCleanupModule : JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupModuleBase<JetBrains.ReSharper.Psi.CSharp.CSharpLanguage>
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor CONVERT_TO_AUTO_PROPERTY_DESCRIPTOR;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor MAKE_FIELD_READONLY_DESCRIPTOR;
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
        public override void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class OptimizeUsings : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.OptimizeUsings.ShortenReferenceStyleDescriptor SHORTEN_REFERENCE_STYLE_DESCRIPTOR;
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
        [System.ComponentModel.CategoryAttribute("C#")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.DisplayNameAttribute("Shorten qualified references")]
        public class ShortenReferenceStyleDescriptor : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor
        {
            public ShortenReferenceStyleDescriptor() { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.OptimizeUsings)})]
    public class ReformatCode : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReformatCode)})]
    public class ReorderTypeMembers : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.OptimizeUsings)})]
    public class ReplaceByVar : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.Descriptor USE_VAR_DESCRIPTOR;
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
        public enum BehavourStyle
        {
            [System.ComponentModel.DescriptionAttribute("Do not change")]
            DISABLED = 0,
            [System.ComponentModel.DescriptionAttribute("Can change explicit type to \'var\'")]
            CAN_CHANGE_TO_IMPLICIT = 1,
            [System.ComponentModel.DescriptionAttribute("Can change \'var\' to explicit type")]
            CAN_CHANGE_TO_EXPLICIT = 2,
            [System.ComponentModel.DescriptionAttribute("Can change explicit type to \'var\' and vice versa")]
            CAN_CHANGE_BOTH = 3,
        }
        [System.ComponentModel.CategoryAttribute("C#")]
        [System.ComponentModel.DisplayNameAttribute("Use \'var\' in declaration")]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public class Descriptor : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor<JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.Options>
        {
            public Descriptor() { }
            public override JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.Options Load(System.Xml.XmlElement element) { }
            public override string Present(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
            public override void Save(System.Xml.XmlElement element, JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.Options value) { }
        }
        public enum ForeachVariableStyle
        {
            [System.ComponentModel.DescriptionAttribute("Always use explicit type")]
            ALWAYS_EXPLICIT = 0,
            [System.ComponentModel.DescriptionAttribute("Always use \'var\'")]
            ALWAYS_IMPLICIT = 1,
            [System.ComponentModel.DescriptionAttribute("Use \'var\' except for built-in types")]
            IMPLICIT_EXCEPT_PRIMITIVE_TYPES = 2,
            [System.ComponentModel.DescriptionAttribute("Use \'var\' except for simple types")]
            IMPLICIT_EXCEPT_SIMPLE_TYPES = 3,
        }
        public enum LocalVariableStyle
        {
            [System.ComponentModel.DescriptionAttribute("Always use explicit type")]
            ALWAYS_EXPLICIT = 0,
            [System.ComponentModel.DescriptionAttribute("Always use \'var\'")]
            ALWAYS_IMPLICIT = 1,
            [System.ComponentModel.DescriptionAttribute("Use \'var\' except for built-in types")]
            IMPLICIT_EXCEPT_PRIMITIVE_TYPES = 2,
            [System.ComponentModel.DescriptionAttribute("Use \'var\' except for simple types")]
            IMPLICIT_EXCEPT_SIMPLE_TYPES = 3,
            [System.ComponentModel.DescriptionAttribute("Use \'var\' only when initializer has type usage")]
            IMPLICIT_WHEN_INITIALIZER_HAS_TYPE = 4,
        }
        public class Options
        {
            public Options() { }
            [System.ComponentModel.DisplayNameAttribute("Replace direction")]
            public JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.BehavourStyle BehavourStyle { get; set; }
            [System.ComponentModel.BrowsableAttribute(false)]
            public bool CanChangeToExplicit { get; }
            [System.ComponentModel.BrowsableAttribute(false)]
            public bool CanChangeToImplicit { get; }
            [System.ComponentModel.DisplayNameAttribute("\'foreach\' iterator declaration style")]
            public JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.ForeachVariableStyle ForeachVariableStyle { get; set; }
            [System.ComponentModel.DisplayNameAttribute("Local variable declaration style")]
            public JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.ReplaceByVar.LocalVariableStyle LocalVariableStyle { get; set; }
            public override string ToString() { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.OptimizeUsings)})]
    public class UpdateFileHeader : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public UpdateFileHeader(JetBrains.ReSharper.Feature.Services.CSharp.CodeCleanup.FileHeaderUtils fileHeaderUtils) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion
{
    
    public class AddCatchClauseVariableLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public AddCatchClauseVariableLookupItem() { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public enum BracketsType
    {
        Parentheses = 0,
        Brackets = 1,
    }
    public class CodeCompletionArgumentsContext
    {
        public string ArgumentsText { get; }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.BracketsType BracketsType { get; }
        public bool HasRPar { get; }
        public static JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CodeCompletionArgumentsContext Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpIdentifier identifier, out JetBrains.ReSharper.Psi.TreeTextRange argumentsListRange) { }
    }
    public class CodeCompletionContextOptions
    {
        public bool CreateSeparateItemsForOverloads { get; }
        public bool PrefilterByPrefix { get; }
    }
    public class CodeCompletionFollowingExpressionContext
    {
        public JetBrains.Util.TextRange FollowingExpressionRange { get; }
        public string FollowingExpressionText { get; }
        public static JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CodeCompletionFollowingExpressionContext Create(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file, JetBrains.ReSharper.Psi.TreeTextRange selectedTreeRange) { }
    }
    public class ConstructorFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    public class ConstructorLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TypeLookupItem, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.IConstructorLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        protected readonly string myContainer;
        public ConstructorLookupItem(JetBrains.ReSharper.Psi.IType type, string argumentContextString, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override JetBrains.ReSharper.Psi.ITypePointer GetTypePointerForBinding() { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class CreateAnonymousDelegateLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public CreateAnonymousDelegateLookupItem(JetBrains.ReSharper.Psi.IDelegate d, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public object GetData(string dataID) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class static CSharpCodeCompletionUtil
    {
        public static JetBrains.ReSharper.Psi.IType GetTypeToInstantiate(JetBrains.ReSharper.Psi.IDeclaredType expectedType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode contextElement) { }
        public static bool HasTypeParametersWhichCannotBeResolved(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
    }
    public class CSharpDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
    {
        public CSharpDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance instance, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public bool EscapeKeywords { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public override bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        protected override JetBrains.Util.TextRange DoReplaceText(JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange replaceRange, string typeInName) { }
        protected override string GetText() { }
        protected override string MakeSafe(string shortName) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class CSharpEnumMemberLookupItem : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpDeclaredElementLookupItem
    {
        public CSharpEnumMemberLookupItem(string name, JetBrains.ReSharper.Psi.IField field, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpImportCompletionProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.IImportCompletionCacheProvider { }
    public class CSharpLookupItemFactory
    {
        public CSharpLookupItemFactory(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem CloneTypeElementLookupItem(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpTypeElementLookupItem originalItem, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> typeElements) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase CreateAttributeLookupItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool showContainer, bool isBasicCompletion) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.ConstructorLookupItem CreateConstructorLookupItem(JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool includeFollowingExpression = True) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance instance, bool includeFollowingExpression = True) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateEnumMemberLookupItem(string name, JetBrains.ReSharper.Psi.IField field, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem CreateKeywordLookupItem(string text) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateLabelLookupItem(string name, JetBrains.ReSharper.Psi.ILabel label) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Lookup.MethodsLookupItem CreateMethodsLookupItem(string name, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, bool typeParametersAreInferrable, bool includeFollowingExpression = True) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.LookupItems.OverridableMemberLookupItem CreateOverridableMemberLookupItem(string name, JetBrains.ReSharper.Psi.OverridableMemberInstance overridableMemberInstance) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.LookupItems.PartialMethodLookupItem CreatePartialMethodLookupItem(string name, JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToRemove) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem CreatePreprocessorLookupItem(string text, string type, bool emphasize) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem CreateTextLookupItem(string text, bool isDynamic = False) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem CreateTextLookupItem(string text, string type, bool emphasize, bool isDynamic) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpTypeElementLookupItem CreateTypeElementLookupItem(System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> typeElements, bool showContainer, bool basicImportItem) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpTypeElementLookupItem CreateTypeElementLookupItemNoInit(System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> typeElements, bool showContainer, bool basicImportItem) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem CreateTypeElementWithReferenceLookupItem(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> typeElementsEnumerable, JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem CreateTypeLookupItem(JetBrains.ReSharper.Psi.IType type) { }
        public void Freeze(JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem item) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem InitializeLookupItem(JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase item) { }
        public void InitializeTypeElementLookupItem(System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> typeElements, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpTypeElementLookupItem item) { }
        public void SetFunctionParameters<T>(System.Collections.Generic.IEnumerable<T> functions, JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem item, bool includeFollowingExpression = True)
            where T :  class, JetBrains.ReSharper.Psi.IFunction { }
    }
    public class CSharpReparsedCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public CSharpReparsedCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class CSharpTypeElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem, JetBrains.Util.IUserDataHolder
    {
        protected readonly string myPresentedName;
        [JetBrains.Annotations.NotNullAttribute()]
        protected static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle Presenter;
        public CSharpTypeElementLookupItem([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> typeElements, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, bool basicImportItem) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        public bool BasicImportItem { get; }
        public bool Bind { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        public override string Identity { get; }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public bool InsertAngleBrackets { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance PreferredDeclaredElement { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class ElementsParmetersInfo
    {
        public ElementsParmetersInfo(JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider policyProvider, JetBrains.ReSharper.Psi.Naming.NamingManager namingManager) { }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, int> Corellations { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredElement, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType>> ElementsMatched { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToInvokeWithoutParameters { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToInvokeWithParameters { get; }
        public JetBrains.ReSharper.Psi.Naming.NamingManager NamingManager { get; }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider PolicyProvider { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class FileReferenceCSharpItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.FileReferenceItemsProvider<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IFileReference GetReference(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public interface IConstructorLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem { }
    public class IndexerLookupItem : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.IParameterInfoProvidingLookupItem, JetBrains.Util.IUserDataHolder
    {
        public IndexerLookupItem(bool showSignatures, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance> indexers, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> Candidates { get; }
        public bool CanShrink { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public bool HasCandidates { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance PreferredDeclaredElement { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate> CreateCandidates() { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class static KeywordCompletionUtil
    {
        public static System.Collections.Generic.IEnumerable<string> GetTypeKeywords() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.KeywordCompletionUtil.KeywordCompletionResult> Suggest(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToReplace, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeAtCaretPosition, int minKeywordLength, string prefix) { }
        public struct KeywordCompletionResult
        {
            public KeywordCompletionResult(string keyword, JetBrains.ReSharper.Psi.ExpectedTypes.TailType type) { }
            public string Keyword { get; }
            public JetBrains.ReSharper.Psi.ExpectedTypes.TailType Type { get; }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class NewStatementSmartCompletionType : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public NewStatementSmartCompletionType(JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider) { }
        public static void AddConstructorItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ExpectedTypes.TailType>> types, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode contextNode, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes, out bool allAreObjects, out System.Collections.Generic.HashSet<> priorityItems, bool forceRequireInheritors = False) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public class ShortArrayConstructorLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.IConstructorLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public ShortArrayConstructorLookupItem(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override string Text { get; set; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class static SmartCompletionUtil
    {
        public static bool IsDeclaredElementExpected(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.ElementsParmetersInfo elementsParametersInfo) { }
        public static bool MatchesByModifier(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedTypeModifiers expectedTypeModifiers) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class TypeUsageSmartCompletionType : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.TypeUsageSmartCompletionTypeBase
    {
        public TypeUsageSmartCompletionType(JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.TypeUsageSmartCompletionTypeBase.Data data) { }
    }
    public class TypeUsageSmartCompletionTypeBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContextWithSharedData<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.TypeUsageSmartCompletionTypeBase.Data>
    {
        public TypeUsageSmartCompletionTypeBase(JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider) { }
        protected override JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.TypeUsageSmartCompletionTypeBase.Data IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public class Data
        {
            public Data(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes) { }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> ExpectedTypes { get; }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UprgadeCSharpCompletingCharsSettings
    {
        public const string VSDefaultCompleteCharacters = "{}[]().,:;+-*/%&|^!~=<>?@#\'\\\\\"";
        public UprgadeCSharpCompletingCharsSettings(JetBrains.ReSharper.Feature.Services.CodeCompletion.GlobalCompletionSettingsService globalCompletionSettingsService) { }
        public void UpdateSettingsIfNecessary(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.AutomaticStrategies
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupInStringLiteralStratery : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupInStringLiteralStratery(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager csIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupOnDocCommentIdentifierStrategy : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupOnDocCommentIdentifierStrategy(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupOnIdentifierStrategy : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupOnIdentifierStrategy(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager manager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupOnNewStrategy : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupOnNewStrategy(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupOnOverrideOrPartialStrategy : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupOnOverrideOrPartialStrategy(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager intellisenseManager) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupOnPunctuatorStrategy : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupOnPunctuatorStrategy(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupWhereValueExpectedStrategy : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public AutopopupWhereValueExpectedStrategy(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CompletionInDocComments
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class CSharpCodeCompletionContextProviderInDocComment : JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.CodeCompletionContextProviderInDocCommentBase
    {
        public CSharpCodeCompletionContextProviderInDocComment(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITokenNode GetTokenNode(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CallToBasePreferenceItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext codeCompletionContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ClrLocalSymbolsPreferenceItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpAutoCastItemProviderSmart : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CSharpCodeCompletionCache : JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionCache { }
    public class CSharpCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public CSharpCodeCompletionContext(
                    JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider, 
                    JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, 
                    JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext terminatedContext, 
                    JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, 
                    bool isQualified, 
                    JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext, 
                    JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges completionRanges, 
                    JetBrains.ReSharper.Psi.Tree.ITreeNode nodeInFile, 
                    JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext unterminatedContext, 
                    bool thereIsBraceAfterCaret, 
                    JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CodeCompletionFollowingExpressionContext followingExpression, 
                    bool hasTypeArguments, 
                    JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CodeCompletionArgumentsContext argumentsContext, 
                    string typeArgumentsText, 
                    JetBrains.Util.TextRange replaceRangeWithJoinedArguments, 
                    JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public JetBrains.ReSharper.Psi.Resolve.IAccessContext AccessContext { get; }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CodeCompletionArgumentsContext ArgumentsContext { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionCache CodeCompletionCache { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges CompletionRanges { get; }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.ExpectedTypeCompletionContext ExpectedTypesContext { get; }
        public JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider ExpectedTypesProvider { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CodeCompletionFollowingExpressionContext FollowingExpression { get; }
        public bool HasTypeArguments { get; }
        public bool IsQualified { get; }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpLookupItemFactory LookupItemsFactory { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode NodeInFile { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public JetBrains.Util.TextRange ReplaceRangeWithJoinedArguments { get; }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext TerminatedContext { get; }
        public bool ThereIsBraceAfterCaret { get; }
        public string TypeArgumentsText { get; }
        public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext UnterminatedContext { get; }
        public bool IsAccessible(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class CSharpCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        protected readonly JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager myCSharpIntellisenseManager;
        public CSharpCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext CreateReparseContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.TreeTextRange selectedTreeRange, string newText) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class CSharpCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpConditionalSymbolsItemProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public abstract class CSharpItemsProviderBase<TCodeCompletionContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TCodeCompletionContext>
        where TCodeCompletionContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected bool AddBasicItemsInternal(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override void AddItemsGroups(TCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateLookupItem(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, string name, bool isQualified) { }
        protected void GetLookupItemsFromSymbolTable(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, bool includeFollowingExpression = True) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected virtual bool IncludeDeclaredElement(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(TCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpItemsProviderBasic : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpLookupItemsPresenter : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ILookupItemPresenter
    {
        public JetBrains.UI.RichText.RichTextBlock Present(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpStringFormattingItemProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public class ExpectedTypeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase
    {
        public readonly JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext ReparseContextUsed;
        public ExpectedTypeCompletionContext(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> elementsToExclude, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement> elementsToReplace, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext reparseContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToExclude { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToReplace { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.HeadType HeadType { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; }
        public static void EvaluateElementsToExclude(bool isQualified, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> elementsToExclude, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement> elementsToReplace) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetExpressionForExpectedTypes(out JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext resparseContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext terminatedContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class PropertyBetterThenMethod : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public class PropertyBetterThenMethodFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    public class TypeArgumentListFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class TypeMemberBetterThenType : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public class TypeMemberBetterThenTypeFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class TypePreferenceItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public class VariablesAndParameters : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public VariablesAndParameters(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem> items) { }
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.LookupItems
{
    
    public class CreateLocalVariableLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.CreateLocalVariableLookupItemBase
    {
        public CreateLocalVariableLookupItem(JetBrains.ReSharper.Psi.IType type, string expectedName, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> expectedRoots, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected override string ArgumentModifier { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected override JetBrains.ReSharper.Psi.Tree.IDeclaration CreateLocalVariableDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode nameElement, string safeName, JetBrains.ReSharper.Feature.Services.Lookup.CreateLocalVariableLookupItemBase.ElementFinder nameElementFinder) { }
    }
    public class CSharpTypeElementWithReferenceLookupItem : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpTypeElementLookupItem
    {
        public CSharpTypeElementWithReferenceLookupItem([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> typeElements, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule ReferencedModule { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class GenerateConstructorLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
    {
        public GenerateConstructorLookupItem(string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IXmlDocIdOwner> elements, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override string Text { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class MissingMemberLookupItem : JetBrains.ReSharper.Feature.Services.CodeCompletion.MissingMemberLookupItemBase
    {
        public MissingMemberLookupItem(string name, JetBrains.ReSharper.Psi.OverridableMemberInstance instance, bool isExplicitImplementation, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void RemoveIdentifier(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
        protected override void SetOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
    }
    public class OverridableMemberLookupItem : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpDeclaredElementLookupItem
    {
        public OverridableMemberLookupItem(string name, JetBrains.ReSharper.Psi.OverridableMemberInstance instance, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class PartialMethodLookupItem : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpDeclaredElementLookupItem
    {
        public PartialMethodLookupItem(string name, JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class PropertyLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
    {
        public PropertyLookupItem(string name, bool readOnly, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IField> instance, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override string Text { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class StaticMemberLookupItem : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpDeclaredElementLookupItem
    {
        public StaticMemberLookupItem([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance instance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AliasRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AmbiguityRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public AmbiguityRule(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.FilterDuplicatesRule filterDuplicatesRule, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.NewStatementRule newStatementRule) { }
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AnonymousMemberDeclarationRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AnonymousTypePropertiesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AttributeListRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute GetAttribute(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AttributePropertyListRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AutomaticCompletionWhereValueIsExpected : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class BaseClassesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class BasicImportCompletionRule : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ImportCodeCompletionForTypesBase
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpIncludeTemplatesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpPushExtensionMethodsDownRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class DocCommentCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class EditorBrowsableVisibilityRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public class ExceptionDerivativesInCatchBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClass> GetAccessibleExceptions(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExceptionDerivativesInCatchBasic : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ExceptionDerivativesInCatchBase
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public class ExpandSmartCompletionWithStaticMembersRule : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExtensionMethodImportCompletionItemsProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ExtensionMethodImportCompletionItemsProviderBase
    {
        protected override bool WithoutReferences { get; }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.MethodsLookupItem CreateLookupItem(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, string name, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methodArray, bool showSignatures) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public abstract class ExtensionMethodImportCompletionItemsProviderBase : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected abstract bool WithoutReferences { get; }
        protected abstract JetBrains.ReSharper.Feature.Services.Lookup.MethodsLookupItem CreateLookupItem(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, string name, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methodArray, bool showSignatures);
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected virtual bool ShouldBeIncluded(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methods) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class FilterDuplicatesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class HighlightMembersOfCurrentClassRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ImportCodeCompletionForDocCommentProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ImportCodeCompletionForTypesItemsProviderBase
    {
        public ImportCodeCompletionForDocCommentProvider(JetBrains.ReSharper.Feature.Services.CodeCompletion.NextTypingHandler nextTypingHandler, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks shellLocks) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public class ImportCodeCompletionForTypesBase : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected void AddTypes(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext, string prefix, bool isBasic) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ImportCodeCompletionForTypesItemsProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ImportCodeCompletionForTypesItemsProviderBase
    {
        public ImportCodeCompletionForTypesItemsProvider(JetBrains.ReSharper.Feature.Services.CodeCompletion.NextTypingHandler nextTypingHandler, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks shellLocks) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public class ImportCodeCompletionForTypesItemsProviderBase : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ImportCodeCompletionForTypesBase
    {
        protected ImportCodeCompletionForTypesItemsProviderBase(JetBrains.ReSharper.Feature.Services.CodeCompletion.NextTypingHandler nextTypingHandler, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks shellLocks) { }
        protected bool BuildResultForTypes(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class IndexersRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class KeywordCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class LambdaParameterNameExpectedRuleWithReparse : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class MemberInitializerExpressionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class MethodGroupOrLambdaExpectedRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContextWithSharedData<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.MethodGroupOrLambdaExpectedRule.Data>
    {
        public MethodGroupOrLambdaExpectedRule(JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider) { }
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.MethodGroupOrLambdaExpectedRule.Data data) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.MethodGroupOrLambdaExpectedRule.Data data) { }
        protected override JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.MethodGroupOrLambdaExpectedRule.Data IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public class Data
        {
            public Data(bool mightStartWithIdentifier) { }
            public bool MightStartWithIdentifier { get; }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class MethodGroupOrLambdaExpectedRuleForLambdaParameterName : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class NamedArgumentsRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public NamedArgumentsRule(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage language) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class NamespaceDeclarationRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public NamespaceDeclarationRule(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpNamespaceDeclaration GetNamespaceDeclarationNode(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class NameSuggestionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public override bool IsDynamic { get; }
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class NewStatementRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class NoTemplatesAfterDotRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ObjectInitializerRule : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class PreferExactTypesInComparison : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class PreprocessorRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class PropertyNameSameToTypeRule : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class QueryClauseRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class RangesProviderRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SoftLookupAfterFloatingPoint : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SoftWhereLambdaExpected : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SoftWhereNumericValueExpected : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SubnamespacesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class UnitTestCategorySuggestionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class UsingNamespaceRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.Combo
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ComboNullComparisonProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ComboReturnProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SmartConstructorRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.Double
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class DoubleCompletionRangesProviderRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionType, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public abstract class ExpandBasicCompletionProviderBase : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExpandBasicCompletionQualifiedProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.Double.ExpandBasicCompletionProviderBase { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExpandExtensionMethodImportCompletionItemsProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ExtensionMethodImportCompletionItemsProviderBase
    {
        public ExpandExtensionMethodImportCompletionItemsProvider(JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        protected override bool WithoutReferences { get; }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.MethodsLookupItem CreateLookupItem(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, string name, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methodArray, bool showSignatures) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool ShouldBeIncluded(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IMethod> methods) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExpandImportCompletionProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.ExpandImportCompletionProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public ExpandImportCompletionProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem CreateLookupItem(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Linq.IGrouping<string, JetBrains.ReSharper.Psi.ITypeElement> typeElements) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetRanges(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsQualifiedContext(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExpandSmartCompletionRule : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.Generate
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ConstructorRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ImplementMembersRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class OverrideRule : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class PartialMethodRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext codeCompletionContext, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class PartialRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class PropertyRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "C#")]
    public class CSharpAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After dot")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterDot;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After \'new\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType AfterNew;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "In doc comments")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType InDocComments;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "In string literals")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType InStringLiterals;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "Letter and digits")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "Where value is expected")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType WhereValueIsExpected;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "C#")]
    public class CSharpCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non-completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Upgraded from VS settings")]
        public bool UpgradedFromVSSettings;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CSharpIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public CSharpIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "C# IntelliSense enabled")]
    public class IntellisenseEnabledSettingCSharp
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "C# (.cs files and C# code in supported server pages)")]
        public bool IntellisenseEnabled;
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion
{
    
    public enum CastType
    {
        Hard = 0,
        Soft = 1,
    }
    public class CorellationAndProximityComparer
    {
        public CorellationAndProximityComparer([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, int> corellations) { }
        public int Compare(JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem x, JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem y) { }
    }
    public class CreateDelegateLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public CreateDelegateLookupItem(JetBrains.ReSharper.Psi.IDelegate d, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, string expectedName, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> expectedRoots, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public object GetData(string dataID) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class CreateLambdaLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public CreateLambdaLookupItem(JetBrains.ReSharper.Psi.IDelegate d, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public object GetData(string dataID) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public interface ISmartCompleatebleReference { }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.Providers
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AddAwaitTaskMethods : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IncludeDeclaredElement(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AddTypeArray : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public class static CodeCompletionSharedDataKeys
    {
        public static readonly JetBrains.Util.Key<System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredType, JetBrains.ReSharper.Psi.IDeclaredType[]>> TypeInheritorsKey;
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class DelegateTypeInEventDeclaration : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IncludeDeclaredElement(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExceptionDerivativesInCatchSmart : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Rules.ExceptionDerivativesInCatchBase
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ExpressionStatement : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IncludeDeclaredElement(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class FilterEnumMembersInCase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class ItemsProviderForSmartCompletableReference : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    public abstract class SmartCompletionOfAttributes : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        public static void AddAttributeToCompletionList(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, System.AttributeTargets attributeTargets, JetBrains.ReSharper.Psi.IClass @class, JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext) { }
        public static bool AttributeTargetsMatch(JetBrains.ReSharper.Psi.IClass @class, System.AttributeTargets attributeTargets) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute GetAttribute(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public static System.AttributeTargets GetTargets(JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute attribute) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SmartCompletionOfAttributesNonQualified : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.Providers.SmartCompletionOfAttributes
    {
        public SmartCompletionOfAttributesNonQualified(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SmartCompletionOfAttributesQualified : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpItemsProviderBase<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IncludeDeclaredElement(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SmartTypeInCast : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContextWithSharedData<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.Providers.SmartTypeInCast.Data>
    {
        protected JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider myExpectedTypesProvider;
        public SmartTypeInCast(JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ICSharpExpectedTypesProvider expectedTypesProvider) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.Providers.SmartTypeInCast.Data data) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext speciificContext, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.Providers.SmartTypeInCast.Data data) { }
        protected override JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.Providers.SmartTypeInCast.Data IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public class Data
        {
            public Data(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.CastType castType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour autocompletionBehaviour, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToReplace) { }
            public JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour AutocompletionBehaviour { get; }
            public JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.CastType CastType { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> ExpectedTypes { get; }
            public JetBrains.ReSharper.Psi.Tree.ITreeNode NodeToReplace { get; }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CodeStructure
{
    
    public class CSharpCodeStructureProcessingState
    {
        public CSharpCodeStructureProcessingState(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        public JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions Options { get; }
        public System.Collections.Generic.Stack<JetBrains.ReSharper.Feature.Services.CSharp.CodeStructure.CSharpCodeStructureRegion> Regions { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCodeStructureProvider : JetBrains.ReSharper.Feature.Services.CodeStructure.IPsiFileCodeStructureProvider
    {
        public virtual JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        public static bool CanMoveElements(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement anchor, JetBrains.UI.TreeView.RelativeLocation relativeLocation, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode EncloseInRegion(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> items) { }
        public static void MoveElements(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement anchor, JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> elements) { }
        protected static void ProcessChildren(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement structureElement, JetBrains.ReSharper.Feature.Services.CSharp.CodeStructure.CSharpCodeStructureProcessingState state) { }
        public static void RenameRegion(JetBrains.ReSharper.Feature.Services.CSharp.CodeStructure.CSharpCodeStructureRegion region, string name) { }
    }
    public class CSharpCodeStructureRegion : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructurePreprocessorElement, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlock, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockStart
    {
        public CSharpCodeStructureRegion(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement, JetBrains.ReSharper.Psi.Tree.ITreeNode preprocessorDirective, JetBrains.ReSharper.Feature.Services.CSharp.CodeStructure.CSharpCodeStructureProcessingState state) { }
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
    public class CSharpCodeStructureRootElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement
    {
        public CSharpCodeStructureRootElement(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file) { }
        public override JetBrains.UI.TreeView.PresentationState CreatePresentationState() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.CompleteStatement
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCompleteStatementActionProvider : JetBrains.ReSharper.Feature.Services.CompleteStatement.ElementBasedCompleteStatementActionProvider
    {
        public CSharpCompleteStatementActionProvider() { }
    }
    public class static MatchingUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITokenNode FollowedBy(this JetBrains.ReSharper.Psi.Tree.ITokenNode e, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public static T Follows<T>(this JetBrains.ReSharper.Psi.Tree.ITokenNode e)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITokenNode { }
        public static P HasParent<P>(this JetBrains.ReSharper.Psi.Tree.ITreeNode e)
            where P :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T Is<T>(this JetBrains.ReSharper.Psi.Tree.ITreeNode e)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T IsAfter<T>(this JetBrains.ReSharper.Psi.Tree.ITreeNode e)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T IsBefore<T>(this JetBrains.ReSharper.Psi.Tree.ITreeNode e)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static bool Match(this JetBrains.ReSharper.Psi.Tree.ITreeNode e) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class CSharpFormatItemAndMatchingArgumentContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ClrFormatItemAndMatchingArgumentContextHighlighter
    {
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.CSharpContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class CSharpMatchingBraceContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.CSharpContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class CSharpTypeParametersMatchingBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ContextHighlighterBase
    {
        protected override void CollectHighlightings(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.CSharpContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.ContextNavigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpConflictDeclarationsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IConflictDeclarationsContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpExitsFinder : JetBrains.ReSharper.Feature.Services.ContextNavigation.Util.IFunctionExitsFinder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetReachableExitKeywordsRanges(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetReachableExitNodes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpExtensionMethodsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IExtensionMethodsContextSearch
    {
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.ExtensionMethodsSearchRequest GetExtensionMethodsRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public static bool IsSelectedElementAssociatedWithType(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpFlowTargetContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFlowTargetContextSearch
    {
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode>> SearchTargetAndFinallyBlocks(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpFunctionExitsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFunctionExitsContextSearch
    {
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpImplementationsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IImplementingMembersContextSearch
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElements(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetImplementingMemebersDocumentRange(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpParameterDeclarationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ParameterDeclarationContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IParameterDeclarationContextSearch
    {
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpSubstitutionsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ISubstitutionContextSearch
    {
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchSubstitutionRequest GetSubstitutionRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp
{
    
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpEventSubscriptionsBuilder : JetBrains.ReSharper.Feature.Services.Generate.GenerateEventSubscriptionsBuilderBase<JetBrains.ReSharper.Feature.Services.CSharp.Generate.CSharpGeneratorContext>
    {
        public CSharpEventSubscriptionsBuilder(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public override double Priority { get; }
        public virtual JetBrains.ReSharper.Psi.IDelegate GetMatchingDelegateType(JetBrains.ReSharper.Feature.Services.Generate.GeneratorEventElement declaredElement, out JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override void Process(JetBrains.ReSharper.Feature.Services.CSharp.Generate.CSharpGeneratorContext context) { }
        public virtual void Process(JetBrains.ReSharper.Feature.Services.CSharp.Generate.CSharpGeneratorContext context, JetBrains.ReSharper.Psi.AccessRights handlerAccessRights) { }
    }
    public class IntroduceVariableResult
    {
        public readonly JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> NodePointer;
        public readonly JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo ReplaceInfo;
        public readonly string[] SuggestedNames;
        public IntroduceVariableResult(JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo replaceInfo, string[] suggestedNames, JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> nodePointer) { }
    }
    public class static IntroduceVariableUtil
    {
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Feature.Services.CSharp.IntroduceVariableUtil.ExpressionData> MarkKey;
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetCommonLambda(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> allReferences, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isInnerElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo IntroduceVariable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression targetExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode scope) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.CSharp.IntroduceVariableResult IntroduceVariable(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceExpression, bool checkVar, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Tree.ITreeNode containingLambdaElement) { }
        public class ExpressionData
        {
            public bool Remove { get; set; }
        }
        public class Processor : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            public Processor() { }
            public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Elements { get; }
            public bool ProcessingIsFinished { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public class static QueryToExtensionMethodsUtil
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GenerateFunctionalForm(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryExpression queryExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.DataConstants
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class CSharpDataRules
    {
        public CSharpDataRules(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.DataFlow.Lifetime lifetime) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetVarTypeFromContext(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Generate
{
    
    public class static CSharpBuilderOptions
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Psi.GenerateMemberBody.GenerateMemberBodySettings, JetBrains.ReSharper.Psi.GenerateMemberBody.AccessorImplementationKind>> AccessorImplementationKey;
        public const string AccessRights = "AccessRights";
        public static readonly string[] AccessRightsChoices;
        public const string CanBeNull = "CanBeNull";
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Psi.GenerateMemberBody.GenerateMemberBodySettings, bool>> CopyXmlDocumentationKey;
        public const string DebuggerStepsThrough = "DebuggerStepsThrough";
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Psi.GenerateMemberBody.GenerateMemberBodySettings, bool>> DebuggerStepThroughKey;
        public const string FieldName = "FieldName";
        public const string ImplementationKind = "ImplementationKind";
        public const string ImplementationKindAbstract = "Abstract member";
        public static readonly string[] ImplementationKindChoices;
        public const string ImplementationKindExplicit = "Explicit implementation";
        public const string ImplementationKindPublicMember = "Public member";
        public const string ImplementationKindVirtual = "Virtual member";
        public const string NotifyPropertyChanged = "NotifyPropertyChanged";
        public const string PropertyBody = "PropertyBody";
        public const string PropertyBodyAutomatic = "Automatic property";
        public const string PropertyBodyBackingField = "Property with backing field";
        public static readonly string[] PropertyBodyChoices;
        public const string PropertyBodyDefault = "Default body (from options)";
        public static readonly System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.GenerateMemberBody.AccessorImplementationKind, string> PropertyBodyOptions;
        public const string ReadOnly = "ReadOnly";
        public static readonly string[] ReadOnlyChoices;
        public const string Virtual = "Virtual";
        public const string WrapInRegion = "WrapInRegion";
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Psi.GenerateMemberBody.GenerateMemberBodySettings, bool>> WrapInRegionKey;
        public const string XmlDocumentation = "XmlDocumentation";
        public static JetBrains.ReSharper.Psi.AccessRights GetAccessRights(string optionValue) { }
    }
    public class CSharpEqualityHelper
    {
        public CSharpEqualityHelper(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.ITypeElement type, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Generate.GeneratorEqualityMember> members) { }
        public JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory Factory { get; }
        public bool HasMembers { get; }
        public JetBrains.ReSharper.Psi.ITypeElement Type { get; }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateEqualityCheckExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType commonType, [JetBrains.Annotations.NotNullAttribute()] object lhsComparand, [JetBrains.Annotations.NotNullAttribute()] object rhsComparand) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock GenerateComparatorEqualsBody(object lhsComparand, object rhsComparand) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock GenerateGetHashCodeBody(bool emitBaseCall, [JetBrains.Annotations.CanBeNullAttribute()] object operand = null) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock GenerateObjectEqualsBody(object comparand, JetBrains.ReSharper.Feature.Services.CSharp.Generate.CSharpEqualityHelper.TypeCheckMode mode) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock GenerateTypedEqualsBody(object comparand, bool emitBaseCall, bool emitChecks) { }
        public enum TypeCheckMode
        {
            ExactType = 0,
            ThisType = 1,
            Subclass = 2,
        }
    }
    public class static CSharpGenerateUtil
    {
        public static void CopyTypeParametersConstraints(JetBrains.ReSharper.Psi.ITypeParametersOwner from, JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration to, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration CreateEventHandlerDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration classDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDelegate handlerDelegateType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static string CreateFieldName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration CreateMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration classDeclaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.IOverridableMember member, bool forDelegation, out JetBrains.ReSharper.Psi.Resolve.ISubstitution newSubstitution) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        public static bool IsPartial([JetBrains.Annotations.AssertionConditionAttribute(JetBrains.Annotations.AssertionConditionType.IS_NOT_NULL)] JetBrains.ReSharper.Psi.ITypeElement type) { }
        public static JetBrains.ReSharper.Psi.IType MakeSafeType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode context) { }
    }
    public class CSharpGeneratorContext : JetBrains.ReSharper.Feature.Services.Generate.GeneratorContextBase
    {
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration ClassDeclaration { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ProjectModel.IProject Project { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Root { get; }
        public static JetBrains.ReSharper.Feature.Services.CSharp.Generate.CSharpGeneratorContext CreateContext(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static JetBrains.ReSharper.Feature.Services.CSharp.Generate.CSharpGeneratorContext CreateContext(string kind, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        public override void Dispose() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetSelectionTreeRange() { }
        public TClassMemberDeclaration PutMemberDeclaration<TClassMemberDeclaration>(TClassMemberDeclaration declaration, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement = null, [JetBrains.Annotations.InstantHandleAttribute()] System.Func<TClassMemberDeclaration, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> itemCreator = null, string regionName = null)
            where TClassMemberDeclaration :  class, JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpGeneratorContextFactory : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.Application.DataContext.IDataContext context) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
    }
    public class static CSharpNotifyPropertyChangedUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> EmitDependentNotifications([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod notifyMethod, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration notifyContext, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.ITypeMember[] propertyOrFields) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement EmitNotifyCall([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod notifyMethod, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration notifyContext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IProperty propertyToNotify, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IField backingField) { }
    }
    public sealed class CSharpOverridesUtil : JetBrains.ReSharper.Psi.Util.OverridesUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode[] AddCallToBase(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static void CallGenericMethod(JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration getEnumeratorDeclaration, JetBrains.ReSharper.Psi.OverridableMemberInstance genericMethodInstance) { }
        public static bool CanCallGenericMethod(JetBrains.ReSharper.Psi.OverridableMemberInstance moreGenericInstance, JetBrains.ReSharper.Psi.OverridableMemberInstance lessGenericInstance, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static bool CanOverrideImplicitly(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static JetBrains.ReSharper.Psi.AccessRights GetAccessRights(JetBrains.ReSharper.Psi.IOverridableMember superMember, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration OverridableMemberDeclaration(JetBrains.ReSharper.Psi.IOverridableMember typeMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration inheritorDeclaration) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration OverridableMemberDeclaration(JetBrains.ReSharper.Psi.IOverridableMember typeMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration inheritorDeclaration, bool addConstraints, bool preserveComments) { }
    }
    public class RegionDecorator
    {
        public RegionDecorator(JetBrains.ReSharper.Psi.Tree.ITreeNode regionsContainer) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.Generate.RegionDecorator.RegionPreserver CreateRegionPreserver(JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        public void ExtendWrappedRegion(JetBrains.ReSharper.Psi.Tree.ITreeNode wrappedNode, string typePresentation) { }
        public void WrapInRegion(JetBrains.ReSharper.Psi.Tree.ITreeNode wrappedNode, string typePresentation) { }
        public class RegionPreserver
        {
            public RegionPreserver(JetBrains.ReSharper.Feature.Services.CSharp.Generate.RegionDecorator decorator, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
            public void PreserveRegion(JetBrains.ReSharper.Psi.Tree.ITreeNode newAnchor) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Generate.MemberBody
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMemberBodyOperations : JetBrains.ReSharper.Feature.Services.Generate.IMemberBodyOperations
    {
        public CSharpMemberBodyOperations(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.Util.TextRange GetBodyRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public void RemoveBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.Util.TextRange SetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.GenerateMemberBody.MethodImplementationKind implementationKind) { }
        public JetBrains.Util.TextRange SetBodyToDefault(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.Util.TextRange SetDelegatingCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IClrDeclaredElement qualifier, JetBrains.ReSharper.Psi.IOverridableMember delegateTo) { }
        public JetBrains.Util.TextRange SetParameterlessMethodCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IMethod methodToCall) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpPropertyBodyUtil
    {
        public CSharpPropertyBodyUtil(JetBrains.ReSharper.Feature.Services.CSharp.Generate.MemberBody.CSharpMemberBodyOperations bodyOperations) { }
        public void CreateBackingField(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration, string backingFieldName) { }
        public System.Collections.Generic.IEnumerable<string> GetBackingFieldCandidates(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration) { }
        public bool IsBackingFieldAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration, string fieldName) { }
        public JetBrains.Util.TextRange SetAutoPropertyBody(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration declaration) { }
        public JetBrains.Util.TextRange SetAutoPropertyBody(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorOwnerDeclaration declaration) { }
        public JetBrains.Util.TextRange SetBackingFieldBody(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration declaration, string backingFieldName) { }
        public JetBrains.Util.TextRange SetBackingFieldBody(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorOwnerDeclaration declaration, string backingFieldName) { }
        public JetBrains.Util.TextRange SetDefaultBody(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration declaration) { }
        public JetBrains.Util.TextRange SetDefaultBody(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorOwnerDeclaration declaration) { }
        public string SuggestBackingFieldName(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration property) { }
    }
    public class static CSharpReturnStatementMemberBodyProvider
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IBlock CreateBody(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFunctionDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Intentions
{
    
    public class static CopyLocalFixUtil
    {
        public static void Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpAnnotateWithAttributeIntention : JetBrains.ReSharper.Feature.Services.Intentions.IAnnotateWithAttributeIntention
    {
        public void Annotate(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement markBy, JetBrains.ReSharper.Psi.AttributeValue[] fixedArguments, JetBrains.Util.Pair<, >[] namedArguments) { }
        public bool HasAnnotation(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement annotationType) { }
        public void UpdateAnnotations(JetBrains.ReSharper.Psi.Tree.IDeclaration markedDeclaration, JetBrains.ReSharper.Feature.Services.Intentions.UpdateArgumentsDelegate provideArguments) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpChangeSignatureIntention : JetBrains.ReSharper.Feature.Services.Intentions.IChangeSignatureIntention
    {
        public CSharpChangeSignatureIntention(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage language, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingLanguageService namingLanguageService) { }
        public void ChangeSignature(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration signatureToChange, JetBrains.ReSharper.Psi.IParametersOwner sourcePattern, JetBrains.ReSharper.Psi.Resolve.ISubstitution sourceSubstitution, JetBrains.ReSharper.Feature.Services.Intentions.SignatureChangeKind changeKind) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCreateConstIntention : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.ICreateConstDeclarationIntention
    {
        public JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteEx(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstDeclarationContext context) { }
    }
    public class static CSharpImplementInterfaceIntention
    {
        public static System.Action<JetBrains.TextControl.ITextControl> Implement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement implementor, params JetBrains.ReSharper.Psi.IDeclaredType[] interfacesToImplement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Action<JetBrains.TextControl.ITextControl> Implement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration declaration, params JetBrains.ReSharper.Psi.IDeclaredType[] interfacesToImplement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpIntentionLanguageService : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IntentionLanguageSpecific
    {
        public CSharpIntentionLanguageService(JetBrains.ReSharper.Feature.Services.CSharp.Generate.MemberBody.CSharpPropertyBodyUtil propertyBodyUtil) { }
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
        public override JetBrains.ReSharper.Psi.ITypeConversionRule GetTypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode expr) { }
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
    public class static CSharpObjectInitializerToAssignmentsIntention
    {
        public static void Execute(System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer>> initalizersGenerator, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression GetCreationExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer initializer, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer> list) { }
        public static bool IsAvailable(System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer>> initializersGenerator, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpSetAccessRightsIntention : JetBrains.ReSharper.Feature.Services.Intentions.ISetAccessRightsIntention
    {
        public void SetAccessRights(JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration declaration, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Intentions.DataProviders
{
    
    public class CSharpMethodSignatureProvider : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignatureProvider
    {
        public CSharpMethodSignatureProvider(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromArguments([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument> arguments, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromArguments([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument> arguments, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> returnTypes, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromInvocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression referenceExpression, bool checkOnlyResolved, JetBrains.ReSharper.Psi.IType defaultType) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromInvocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.ICSharpInvocationInfo invocationInfo, bool checkOnlyResolved, JetBrains.ReSharper.Psi.IType defaultType, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage CreateTypeImageFromExpression(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression value, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Intentions.MemberBody.LookupItems
{
    
    public class AutoPropertyLookupItem : JetBrains.ReSharper.Feature.Services.CSharp.Intentions.MemberBody.LookupItems.PropertyBodyLookupItemBase
    {
        public AutoPropertyLookupItem(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CSharp.Generate.MemberBody.CSharpPropertyBodyUtil propertyBodyUtil) { }
        public override JetBrains.UI.RichText.RichText DisplayName { get; }
        protected override void SetBody(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration) { }
    }
    public abstract class PropertyBodyLookupItemBase : JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates.MemberBodyLookupBase
    {
        protected PropertyBodyLookupItemBase(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        protected override void DoCommand(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected abstract void SetBody(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.LinqTools
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpLinqToolsLanguageHelper : JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper
    {
        public CSharpLinqToolsLanguageHelper() { }
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
        public bool IsCastExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IExpression operand) { }
        public bool IsCastExpressionOperand(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IExpression castExpr) { }
        public bool IsForeachStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.Tree.IStatementsRange body, out JetBrains.ReSharper.Psi.ILocalVariable iteratorVar, out JetBrains.ReSharper.Psi.Tree.IExpression collectionExpr) { }
        public bool IsForStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.Tree.IStatementsRange body) { }
        public bool IsImplicitlyTyped(JetBrains.ReSharper.Psi.ILocalVariable local) { }
        public bool IsInvocation(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args) { }
        public bool IsInvocation(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args) { }
        public bool IsInvocationQualifier(JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out JetBrains.ReSharper.Psi.Tree.IExpression invocation, out JetBrains.ReSharper.Psi.IMethod targetMethod, out System.Collections.Generic.IList<> args) { }
        public bool IsLabelStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public bool IsLastExecutedStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, bool allowIfs, out JetBrains.ReSharper.Psi.Tree.IExpression valueReturned, out JetBrains.ReSharper.Psi.Tree.IStatement returnStatementToRemove) { }
        public bool IsLoopBodyBlock(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public bool IsReturnOwner(JetBrains.ReSharper.Psi.Tree.ITreeNode node, out JetBrains.ReSharper.Psi.IType returnType) { }
        public bool IsSimpleExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public bool IsVariableAssignment(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeOwner variable, out JetBrains.ReSharper.Psi.Tree.IExpression valueAssigned) { }
        public bool IsVariableAssignmentValue(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeOwner variable) { }
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
    public class CSharpStructuralSearchMatchersCacheExtension : JetBrains.ReSharper.Feature.Services.LinqTools.IStructuralSearchMatchersCacheExtension
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateExpressionMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateStatementMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.LinqTools.FromLinq
{
    
    public class static FromLinqUtil
    {
        public static bool CanGenerateExpressionByDelegate(JetBrains.ReSharper.Psi.Tree.IExpression @delegate, bool withSecondWorkingVar) { }
        public static JetBrains.ReSharper.Psi.ILocalVariable DeclareIndexVariable(ref JetBrains.ReSharper.Psi.CSharp.Tree.IForeachStatement loop, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression @delegate, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Psi.ITypeOwner DeclareResultVariableIfNeeded<TExpression>(ref TExpression expression, [JetBrains.Annotations.CanBeNullAttribute()] string nameSuggested, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile)
            where TExpression :  class, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ILocalVariable DetectIndexVariable(JetBrains.ReSharper.Psi.CSharp.Tree.IForeachStatement loop, out JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement incrementStatement, out JetBrains.ReSharper.Psi.CSharp.Tree.IDeclarationStatement indexVarDecl) { }
        public static JetBrains.ReSharper.Psi.Tree.IExpression GenerateExpressionByDelegate(JetBrains.ReSharper.Psi.Tree.IExpression @delegate, string workingVarName, [JetBrains.Annotations.CanBeNullAttribute()] string secondWorkingVarName, JetBrains.ReSharper.Psi.Tree.ITreeNode scope) { }
        public static bool HasExitsFrom(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement ImproveForeach(JetBrains.ReSharper.Psi.CSharp.Tree.IForeachStatement loop, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
        public static void IncrementIndexVariable(JetBrains.ReSharper.Psi.ILocalVariable variable, JetBrains.ReSharper.Psi.CSharp.Tree.IForeachStatement loop, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement existingIncrement) { }
        public static bool InlineLocal(JetBrains.ReSharper.Psi.ILocalVariable variable, bool ifOneUsageOnly) { }
        public static bool IsSimpleExpression(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expr) { }
        public static bool MatchEnumerableMethod(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocation, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache, out JetBrains.ReSharper.Psi.IMethod method, out JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, out System.Collections.Generic.Dictionary<, > arguments) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression SkipParenthesisDown(this JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expr) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression SkipParenthesisUp(this JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expr) { }
        public static object TypeOrVar(this JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
    }
    public class static Transform
    {
        public static bool IsAvailableOnInvocation(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocation, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
        public static bool IsAvailableOnQuery(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryExpression query, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static void TransformInvocation(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocation, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
        public static void TransformQuery(JetBrains.ReSharper.Psi.CSharp.Tree.IQueryExpression query, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.LiveTemplates
{
    
    public class static CSharpTemplateUtil
    {
        public static JetBrains.ReSharper.LiveTemplates.TemplateField CreateTypeTemplateField(string name, JetBrains.ReSharper.Psi.IType[] types, JetBrains.ReSharper.Psi.IType defaultType, string typeParameterName, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.ReSharper.LiveTemplates.TemplateField CreateTypeTemplateField(JetBrains.ReSharper.Psi.ExpectedTypes.IExpectedTypeConstraint typeConstraint, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode anchor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType objType, bool canBeVar, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public static void ExecuteTemplate<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.ExpectedTypes.IExpectedTypeConstraint typeConstraint, T templateFieldRangeNode, bool canBeVar, JetBrains.Util.TextRange selectionRange, System.Action postAction = null, System.Collections.Generic.IEnumerable<T> additionalNodesForHotsposts = null)
            where T : JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode { }
        public class TypeTemplateExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.SuggestedNameTemplateExpression
        {
            public TypeTemplateExpression(string suggestedName, JetBrains.ReSharper.Psi.IType[] types, JetBrains.ReSharper.Psi.IType defaultType, JetBrains.ReSharper.Psi.Modules.IPsiModule project, bool hasVar, bool makeVarFirst, JetBrains.ReSharper.Feature.Services.TypeSuggestion.SuggestedConstKinds constKinds, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
            public TypeTemplateExpression(string suggestedName, JetBrains.ReSharper.Psi.IType[] types, JetBrains.ReSharper.Psi.IType defaultType, JetBrains.ReSharper.Psi.Modules.IPsiModule project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
            public string TypeParameterName { set; }
            protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItemsImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class CSharpTemplateUtilSettingsGlobalUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public CSharpTemplateUtilSettingsGlobalUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class CSharpTemplateUtilSettingsSolutionUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public CSharpTemplateUtilSettingsSolutionUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeStyleSettings), "Whether or not live templates should use “var” instead of a specific type name")]
    public class LiveTemplatesUseVarSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to use var instead of type")]
        public bool PreferVar;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to use var instead of type")]
        public bool UseVar;
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Naming
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class CSharpPredefinedNamingPolicySettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpCachedGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrSpecificGotoFileMemberProvider
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected override bool IsIndexer(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CSharpOccurenceKindProvider : JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.IOccurenceKindProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllPossibleOccurenceKinds() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ExternalSourcesFileMemberProvider : JetBrains.ReSharper.Feature.Services.CSharp.Navigation.CSharpCachedGotoFileMemberProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.IOccurence CreateOccurence(JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrGotoFileMemberProvider.ClrFileMemberData clrFileMemberData) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeElement> GetPsiSourceFileTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile primarySourceFile) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected override bool IsValidMemberOfSourceFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.IDeclaredElement typeMember, JetBrains.ReSharper.Psi.ITypeElement contatiningTypeElement) { }
        protected override bool IsValidSecondaryMember(JetBrains.ReSharper.Psi.IPsiSourceFile primarySourceFile, JetBrains.ReSharper.Psi.IDeclaredElement typeMember, JetBrains.ReSharper.Psi.ITypeElement containingTypeElement) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.ParameterInfo
{
    
    public class CsParameterInfoInvocationContext
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument> Arguments { get; }
        public JetBrains.Util.TextRange BoundsRange { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> Candidates { get; }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgumentsOwner Invocation { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyAssignment> PropertyAssignments { get; }
        public static JetBrains.ReSharper.Feature.Services.CSharp.ParameterInfo.CsParameterInfoInvocationContext CreateInvocationContext(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeOffset caretTreeOffset, JetBrains.ReSharper.Psi.TreeOffset leftParOffset, JetBrains.ReSharper.Feature.Services.CSharp.ParameterInfo.CsParameterInfoInvocationContext.UseParentContext useParent) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.ApplicableInvocationCandidate> GetAcceptedCandidates() { }
        public JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate GetDefaultInvocable() { }
        public int GetDefaultInvocableIndex() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> GetFilteredOut() { }
        [System.FlagsAttribute()]
        public enum UseParentContext
        {
            NONE = 0,
            ON_LPARENTH = 1,
            ON_RPARENTH = 2,
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Psi
{
    
    public class CSharpUnresolvedTypesChooser : JetBrains.ReSharper.Feature.Services.Psi.IUnresolvedTypesChooser
    {
        public CSharpUnresolvedTypesChooser([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public void AddUnresolvedTypes(string typeText, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> result) { }
        public JetBrains.ReSharper.Psi.IType Apply(string typeText, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> boundTypes) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.QuickDoc
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpHtmlAttributesPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.HtmlAttributesPresenterBase
    {
        public CSharpHtmlAttributesPresenter(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter typePresenter, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlEnumPresenter enumPresenter) { }
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
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpHtmlEnumMemberPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.HtmlEnumPresenterBase
    {
        public CSharpHtmlEnumMemberPresenter(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ExtractTreeNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IField element) { }
        protected override string PresentEnum(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool isFieldDeclaration) { }
        protected override string TryGetXmlDocId(JetBrains.ReSharper.Psi.Tree.ITreeNode child) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpHtmlTypePresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter
    {
        public void PresentName(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IType type) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class CSharpQuickQueryRangeVariableProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public CSharpQuickQueryRangeVariableProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpXmlDocLocator : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IXmlDocLocator
    {
        public JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode FindCommentNode(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range) { }
    }
    public class QuickDocQueryRangeVariablePresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocQueryRangeVariablePresenter(JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.DeclaredElements.IQueryRangeVariable element) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode
{
    
    public class RearrangeableAnonymousMethodParameter : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousMethodParameterDeclaration>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousMethodParameterDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousMethodParameterDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousMethodParameterDeclaration element) { }
        }
    }
    public class RearrangeableArgument : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument element) { }
        }
    }
    public class RearrangeableArrayExpressionInitializer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IVariableInitializer>
    {
        public RearrangeableArrayExpressionInitializer(JetBrains.ReSharper.Psi.CSharp.Tree.IVariableInitializer element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IVariableInitializer> GetSiblings() { }
    }
    public class RearrangeableAssignmentExpressionOperand : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        public RearrangeableAssignmentExpressionOperand([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public string Title { get; }
        public bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableAttributeSection : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IAttributeSection>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IAttributeSection> GetSiblings() { }
    }
    public class RearrangeableBaseType : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage>.TypeBase<JetBrains.ReSharper.Psi.CSharp.Tree.IUserDeclaredTypeUsage>
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.IUserDeclaredTypeUsage element) { }
            protected override JetBrains.ReSharper.Psi.CSharp.Tree.IUserDeclaredTypeUsage GetSelectedElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableBinaryExpressionOperand : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        public RearrangeableBinaryExpressionOperand([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public string Title { get; }
        public bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public abstract class RearrangeableBlockBase : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableCSharpLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>
    {
        protected RearrangeableBlockBase(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>.ILogicalItem> selectedItems, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>.ILogicalItem> blockItems) { }
        protected abstract class BlockTypeBase : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableCSharpLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>.ILogicalItem CreateItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode cursor, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IBlock>.ILogicalItem prevItem) { }
        }
    }
    public class RearrangeableBlockBrace : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableBlockBase
    {
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableBlockItem : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableBlockBase
    {
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableCaseStatement : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        public RearrangeableCaseStatement(JetBrains.ReSharper.Psi.CSharp.Tree.ISwitchLabelStatement switchLabelStatement) { }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public string Title { get; }
        public bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableCatchClause : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode> GetSiblings() { }
    }
    public class RearrangeableClassItem : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableCSharpLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration>
    {
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableCollectionElementInitializer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer>
    {
        public RearrangeableCollectionElementInitializer(JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer element) { }
        }
    }
    public class RearrangeableCSharpAttribute : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IAttribute> GetSiblings() { }
    }
    public abstract class RearrangeableCSharpLogicalItemBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>
        where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected RearrangeableCSharpLogicalItemBase(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> selectedItems, THolder holder, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> holderItems) { }
        protected abstract class TypeBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.TypeBase
            where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            protected override bool TreeNodeIsNewLine(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        }
    }
    public class RearrangeableDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IMultipleDeclarationMember>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IMultipleDeclarationMember> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.IMultipleDeclarationMember>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.IMultipleDeclarationMember member) { }
        }
    }
    public class RearrangeableDocCommentAttribute : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        public RearrangeableDocCommentAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute) { }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public string Title { get; }
        public bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableDocCommentTag : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        public RearrangeableDocCommentTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public string Title { get; }
        public bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableElseIfBranch : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement>
    {
        public override JetBrains.DocumentModel.DocumentRange Range { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement> GetSiblings() { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement Swap(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement child, JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement target) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement>.TypeBase<JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement>
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement element) { }
            protected override JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement GetSelectedElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableEnumItem : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableCSharpLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.IEnumDeclaration>
    {
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableEventAccessor : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration>
    {
        public RearrangeableEventAccessor(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration> GetSiblings() { }
    }
    public class RearrangeableIfCondition : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>.TypeBase<JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement>
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement element) { }
            protected override JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement GetSelectedElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
    public class RearrangeableLambdaParameterDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ILambdaParameterDeclaration>
    {
        public RearrangeableLambdaParameterDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.ILambdaParameterDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ILambdaParameterDeclaration> GetSiblings() { }
    }
    public class RearrangeableLocalConstantDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ILocalConstantDeclaration>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ILocalConstantDeclaration> GetSiblings() { }
    }
    public class RearrangeableLocalVariableDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration> GetSiblings() { }
    }
    public class RearrangeableMemberInitializer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer element) { }
        }
    }
    public class RearrangeableMethodConstraintsClause : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraintsClause>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraintsClause> GetSiblings() { }
    }
    public class RearrangeableParameter : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
    {
        public RearrangeableParameter(JetBrains.ReSharper.Psi.CSharp.Tree.IRegularParameterDeclaration parameterDeclaration) { }
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
    public class RearrangeablePropertyAccessor : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration>
    {
        public RearrangeablePropertyAccessor(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration element) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration> GetSiblings() { }
    }
    public class RearrangeableQueryClause : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryClause>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IQueryClause> GetSiblings() { }
    }
    public class RearrangeableTernaryExpressionResult : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression element) { }
        }
    }
    public class RearrangeableTypeArgument : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeUsage>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeUsage> GetSiblings() { }
    }
    public class RearrangeableTypeConstraintsClause : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraintsClause>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraintsClause> GetSiblings() { }
    }
    public class RearrangeableTypeOrNamespaceHolderItem : JetBrains.ReSharper.Feature.Services.CSharp.RearrangeCode.RearrangeableCSharpLogicalItemBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeAndNamespaceHolderDeclaration>
    {
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public override JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public class RearrangeableTypeParameterConstraint : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint> GetSiblings() { }
    }
    public class RearrangeableTypeParameterOfMethod : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterOfMethodDeclaration>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterOfMethodDeclaration> GetSiblings() { }
    }
    public class RearrangeableTypeParameterOfType : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterOfTypeDeclaration>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterOfTypeDeclaration> GetSiblings() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.SelectEmbracingConstruct
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.CSharpProjectFileType))]
    public class CSharpSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider
    {
        public CSharpSelectEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.DefaultTodoContentsProvider
    {
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.TypingAssist
{
    
    public class CSharpAngleBracketMatcher : JetBrains.ReSharper.Feature.Services.TypingAssist.BracketMatcher
    {
        public CSharpAngleBracketMatcher() { }
    }
    public class CSharpBraceMatcher : JetBrains.ReSharper.Feature.Services.TypingAssist.BracketMatcher
    {
        public CSharpBraceMatcher() { }
    }
    public class CSharpBracketMatcher : JetBrains.ReSharper.Feature.Services.TypingAssist.BracketMatcher
    {
        public CSharpBracketMatcher() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public sealed class CSharpTypingAssist : JetBrains.ReSharper.Feature.Services.CSharp.TypingAssist.CSharpTypingAssistBase
    {
        public CSharpTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
    public abstract class CSharpTypingAssistBase : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistForCLikeLanguage<JetBrains.ReSharper.Psi.CSharp.CSharpLanguage, JetBrains.ReSharper.Psi.CSharp.CodeStyle.ICSharpCodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        protected CSharpTypingAssistBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected virtual int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        protected virtual bool CheckThatCSharpLineEndsInOpenStringLiteral(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int lineEndPos, char c, JetBrains.ReSharper.Psi.Parsing.TokenNodeType correspondingTokenType, bool isStringWithAt, ref int charPos, bool defaultReturnValue) { }
        protected virtual void DoSmartIndentOnEnter(JetBrains.TextControl.ITextControl textControl) { }
        protected virtual bool FindMatchingBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, out int rBracePos) { }
        protected virtual bool FindNodesForBraces(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, int lBracePos, int rBracePos, out JetBrains.ReSharper.Psi.Tree.ITokenNode lBraceNode, out JetBrains.ReSharper.Psi.Tree.ITokenNode rBraceNode, out JetBrains.ReSharper.Psi.TreeOffset lBraceTreePos, out JetBrains.ReSharper.Psi.TreeOffset rBraceTreePos) { }
        protected virtual void FormatCustomRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected virtual void FormatNonCSharpRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, int offset, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        protected static string GetCodeBehindIndent(JetBrains.ReSharper.Feature.Services.CSharp.TypingAssist.CSharpTypingAssistBase typingAssist, JetBrains.TextControl.ITextControl textControl, int lexerOffset, string indent) { }
        protected virtual string GetIndent(JetBrains.TextControl.ITextControl textControl, int lexerOffset) { }
        protected bool HandleDelPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleEnterPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleLeftBraceTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        protected bool HandleLeftBracketOrParenthTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        protected bool HandleRightBraceTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        protected virtual void InsertLeftBrace(JetBrains.TextControl.ITypingContext typingContext) { }
        protected virtual bool IsCustomLParenth(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected virtual bool IsCustomTokenSuitableForCloseParenth(JetBrains.ReSharper.Psi.Parsing.TokenNodeType nextTokenType, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected virtual bool IsLBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected override bool IsLBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual bool IsNewLineToken(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected virtual bool IsRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected override bool IsRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool IsSemicolon(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual bool IsStopperTokenForStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected virtual bool NeedAutoinsertCloseBracket(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected virtual bool NeedSkipCloseBracket(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, char charTyped) { }
        protected void OverrideSettingsForFormattingOnEnter(JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
        public abstract bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile);
        protected virtual JetBrains.ReSharper.Psi.TreeOffset ReparseAndFormatOnEnter(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.TreeOffset lBraceTreePos, JetBrains.ReSharper.Psi.TreeOffset rBraceTreePos, int charPos, JetBrains.ReSharper.Psi.Tree.ITokenNode lBraceNode, JetBrains.ReSharper.Psi.Tree.ITokenNode rBraceNode, bool afterLBrace, ref JetBrains.ReSharper.Psi.Tree.IFile file) { }
        protected virtual bool ShouldSkipToken(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected virtual bool TryReparseAndFormatOnEnterAfterNonCSharpLBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, int lBracePos, int rBracePos) { }
        protected virtual bool TryReparseAndFormatOnEnterBeforeNonCSharpRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, int lBracePos, int rBracePos) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.Util
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpBaseClassUtil : JetBrains.ReSharper.Feature.Services.Util.IBaseClassUtil
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetBaseDeclarationsReferences(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpTypeValidator : JetBrains.ReSharper.Feature.Services.Util.ITypeValidator
    {
        public virtual bool IsValidExpression(string expr) { }
        public virtual bool IsValidName(string name) { }
        public virtual bool IsValidParameterType(string type) { }
        public virtual bool IsValidReturnType(string type) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CSharp.VisualElements
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpColorDeclaredElementSearcher : JetBrains.ReSharper.Feature.Services.Colors.IColorDeclaredElementSearcher
    {
        public System.Collections.Generic.IEnumerable<string> GetWords(JetBrains.ReSharper.Psi.Colors.IColorDeclaredElement element) { }
    }
}