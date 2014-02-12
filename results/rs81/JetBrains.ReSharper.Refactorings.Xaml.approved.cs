[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.Xaml.Common
{
    
    public sealed class CodebehindReferencesSearcher : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> LocalItems { get; }
        public bool ProcessingIsFinished { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> FindLocalElements([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public interface IStyleableProperty
    {
        JetBrains.Util.TextRange DocumentRange { get; }
        bool IsAttached { get; }
        bool IsEventSetter { get; }
        bool IsQualified { get; }
        bool IsValid { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string PropertyName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference PropertyReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode Setter { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference TypeReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter ValueSetter { get; }
    }
    public sealed class StyleablePropertiesFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty> FromContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty FromSetter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter setter, JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache cache = null, bool canBeEvent = False) { }
    }
    public sealed class StyleablePropertyEqualityComparer : System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty> Instance;
        public bool Equals(JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty x, JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty y) { }
        public int GetHashCode(JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty obj) { }
    }
    public class static StyleablePropertyExtensions
    {
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty property) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetPropertyType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty property) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IDeclaredType GetQualifierType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty property) { }
    }
    public sealed class StyleResource
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration Declaration { get; }
        public bool IsValid { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Xaml.Common.StyleResource> FromContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.Xaml.Common.StyleResource FromExplicit([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, out bool isStyle) { }
    }
    public class XamlMoveConflictsSearcherBase : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        protected static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle ResourcesStyle;
        public XamlMoveConflictsSearcherBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode targetElement, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elementsToMove = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> ElementsToMove { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference> ResourceUsages { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode SourceElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IPsiModule SourceModule { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TargetElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile TargetFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IPsiModule TargetModule { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.ITypeElement> TypeUsages { get; set; }
        protected virtual void CheckOther([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflicts) { }
        public virtual JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
    }
    public class static XamlMoveUtil
    {
        public static void FindAliases(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer tagContainer, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> removedNamespaces, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> ret) { }
        public static void FixNamespacesInFileAndRegisterTypes(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile xamlFile, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public static void RemoveUsingFromFile(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.ExtractResource
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractXamlResource"})]
    public class ExtractResourceAction : JetBrains.ReSharper.Refactorings.WorkflowNew.IntroduceWithOccurencesAction<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.IExtractResourceWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractXamlResource";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ExtractResourceConflictSearcher : JetBrains.ReSharper.Refactorings.Xaml.Common.XamlMoveConflictsSearcherBase
    {
        public ExtractResourceConflictSearcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode targetElement, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elementsToMove, JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher drivenConflictSearcher) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher DrivenConflictSearcher { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow Workflow { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
    }
    public class ExtractResourceDrivenWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.WorkflowNew.IIntroduceWorkflowWithOccurences
    {
        public ExtractResourceDrivenWorkflow([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CollapsePropertyElements { get; set; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement> CommonParent { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Expression { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool HasManyUsages { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest HighlightingRequest { get; set; }
        public bool IsMoveResource { get; }
        public bool IsNonInteractive { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> MoreUsages { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode>> Occurances { get; }
        public bool ReferenceStatically { get; set; }
        public JetBrains.ReSharper.Psi.IDeclaredType ResourceType { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement> TargetElement { get; set; }
        public string TargetResourceName { get; set; }
        public bool TargetRootTag { get; set; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public override string Title { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Usages { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public static bool IsValidResourceType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public void SetIndex(JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection SuggestResourceName(out JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, out string firstName) { }
    }
    public sealed class ExtractResourceOccuranceSearcher : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ExtractResourceOccuranceSearcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool ProcessingIsFinished { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Results { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public sealed class ExtractResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceRefactoringExec>
    {
        public ExtractResourceRefactoring(JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static void ExpandMarkupToResource([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement resource) { }
        public static void FillElementFromResource([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag targetElement) { }
    }
    public class ExtractResourceRefactoringExec : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceRefactoring>
    {
        public ExtractResourceRefactoringExec(JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class ExtractResourceWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider, JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.IExtractResourceWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IExtractResourceWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public sealed class MoveResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceRefactoringExec>
    {
        public MoveResourceRefactoring(JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class MoveResourceRefactoringExec : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.MoveResourceRefactoring>
    {
        public MoveResourceRefactoringExec(JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class ResourceDictionaryTarget
    {
        public ResourceDictionaryTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryType type, bool isDefault = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryTarget> Children { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement Element { get; }
        public bool IsDefault { get; }
        public bool IsExpanded { get; }
        public int ResourcesCount { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryType Type { get; }
        public void AddChild([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryTarget target) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryTarget BuildTargets([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public void Expand() { }
    }
    public enum ResourceDictionaryType
    {
        Element = 0,
        Application = 1,
        Dictionary = 2,
        DictionaryFile = 3,
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI
{
    
    public class ExtractResourceView : System.Windows.Controls.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage, System.IDisposable, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public ExtractResourceView([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel CurrentTarget { get; set; }
        public string Description { get; }
        public bool DoNotShow { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel> ResourcesTree { get; set; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void Dispose() { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitializeComponent() { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public sealed class ExtractResourceViewModel : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public ExtractResourceViewModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow workflow) { }
        public bool CanCollapsePropertyElements { get; }
        public bool CanReferenceDynamically { get; }
        public bool CollapsePropertyElements { get; set; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ContextElement { get; }
        public bool IsCreatingNewResource { get; }
        public bool IsTreeEnabled { get; }
        public bool ReferenceStatically { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel> ResourcesTree { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string ResourceTypeName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel RootElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel TargetDictionary { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ExtractResourceDrivenWorkflow Workflow { get; }
        public void InitTree() { }
    }
    public class ResourceDictionaryViewModel
    {
        public ResourceDictionaryViewModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryTarget target) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel> Children { get; }
        public bool HasResources { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public bool IsDefault { get; }
        public bool IsExpanded { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string OwnerName { get; }
        public int ResourcesCount { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryTarget Target { get; set; }
        public void Expand() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.UI.ResourceDictionaryViewModel Find([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ReSharper.Refactorings.Xaml.ExtractResource.ResourceDictionaryTarget> predicate) { }
        public bool IsValid() { }
        public void Navigate() { }
        public void RemoveInvalid() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractXamlStyle"})]
    public class ExtractStyleAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.IExtractStyleWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractXamlStyle";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ExtractStyleConflictsSearcher : JetBrains.ReSharper.Refactorings.Xaml.Common.XamlMoveConflictsSearcherBase
    {
        public ExtractStyleConflictsSearcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleDrivenWorkflow workflow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode targetElement, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elementsToMove, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher drivenConflictSearcher) { }
        protected override void CheckOther(JetBrains.Application.Progress.IProgressIndicator progressIndicator, System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflicts) { }
        public override JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
    }
    public class ExtractStyleDrivenWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public ExtractStyleDrivenWorkflow([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CanCreateNewStyle { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement> Element { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool HasExplicitStyle { get; }
        public override string HelpKeyword { get; }
        public bool IsExtractFromStyle { get; }
        public bool IsExtractToExisting { get; set; }
        public bool IsNonInteractive { get; set; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Xaml.Common.IStyleableProperty> Properties { get; }
        public JetBrains.DocumentManagers.DocumentSelection Selection { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Refactorings.Xaml.Common.StyleResource TargetResource { get; set; }
        public string TargetResourceName { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Xaml.Common.StyleResource> TargetResources { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetNewResourceTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection SuggestStyleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, out JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy) { }
    }
    public class ExtractStyleRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleRefactoringExec>
    {
        public ExtractStyleRefactoring(JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class ExtractStyleRefactoringExec : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleRefactoring>
    {
        public ExtractStyleRefactoringExec(JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class ExtractStyleWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider, JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.IExtractStyleWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IExtractStyleWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.UI
{
    
    public class ExtractStyleView : System.Windows.Controls.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage, System.IDisposable, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public ExtractStyleView([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.ExtractStyle.ExtractStyleDrivenWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void Dispose() { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitializeComponent() { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.InlineResource
{
    
    public interface IInlineResourceWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InlineXamlResource"})]
    public class InlineResourceAction : JetBrains.ReSharper.Refactorings.WorkflowNew.IntroduceWithOccurencesAction<JetBrains.ReSharper.Refactorings.Xaml.InlineResource.IInlineResourceWorkflowProvider>
    {
        public const string ACTION_ID = "InlineXamlResource";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class InlineResourceDrivenWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public InlineResourceDrivenWorkflow([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool ExpandMarkupExtensions { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool InlineAllUsages { get; set; }
        public bool InlineDynamicUsages { get; set; }
        public bool IsNonInteractive { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public bool RemoveInlinedResource { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration> Resource { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage> ResourceUsage { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public sealed class InlineResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceRefactoringExec>
    {
        public InlineResourceRefactoring(JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage>> CollectResourceUsages([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration resource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, [JetBrains.Annotations.NotNullAttribute()] out System.Collections.Generic.List<> dynamicUsages) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class InlineResourceRefactoringExec : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow, JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceRefactoring>
    {
        public InlineResourceRefactoringExec(JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class InlineResourceWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider, JetBrains.ReSharper.Refactorings.Xaml.InlineResource.IInlineResourceWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.InlineResource.UI
{
    
    public sealed class InlineResourceView : System.Windows.Controls.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage, System.Windows.Markup.IComponentConnector
    {
        public InlineResourceView([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.InlineResource.UI.InlineResourceViewModel ViewModel { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitializeComponent() { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public sealed class InlineResourceViewModel : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public InlineResourceViewModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow workflow) { }
        public bool AllowMarkupExtensionExpansion { get; set; }
        public bool CanFilterDynamicUsages { get; }
        public bool CanInlineSpecificUsage { get; }
        public bool CanRemoveResourceDeclaration { get; }
        public bool InlineAllUsages { get; set; }
        public bool InlineDynamicUsages { get; set; }
        public bool RemoveResourceDeclaration { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ResourceName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Xaml.InlineResource.InlineResourceDrivenWorkflow Workflow { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.MoveMembers
{
    
    public class XamlExtractSuperclass : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass
    {
        public XamlExtractSuperclass(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class XamlMoveMembersHelper : JetBrains.ReSharper.Refactorings.Unsupported.MoveMembersHelperUnsupported<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>
    {
        public XamlMoveMembersHelper(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void SetSuperclass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClassDeclaration, JetBrains.ReSharper.Psi.ITypeElement newSuper, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.MoveToNamespace
{
    
    public class XamlAdjustNamespacesHelper : JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override bool FileHasProblems(JetBrains.ReSharper.Psi.Tree.IFile file, string expectedNamespace) { }
        public override void FixFile(JetBrains.ReSharper.Psi.Tree.IFile file, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> importedNamespaces) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetImportedSymbolOfUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class XamlMoveToFolderHelperBase : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool MoveFewDeclarations(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string name, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> children) { }
        public override bool MoveSingleDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IFile targetFile, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override bool MoveWholeFile(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class XamlMoveToNamespaceHelper : JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MovePrimaryDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string newNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.Rename
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class DependencyPropertyRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class NamespaceAliasRenameProvider : JetBrains.ReSharper.Refactorings.Rename.RenameWorkflowProvider
    {
        public NamespaceAliasRenameProvider(JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Refactorings.Rename.RenameRefactoringService service, JetBrains.ActionManagement.IActionManager actionManager) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public sealed class NamespaceAliasRenameWorkflow : JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow
    {
        public NamespaceAliasRenameWorkflow(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Refactorings.Rename.RenameRefactoringService renameRefactoringService, JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class XamlElementsRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class XamlRenameAvailabilityCheckResult : JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult NotSupportedInXaml;
        protected XamlRenameAvailabilityCheckResult([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentation) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.RenamePartAttribute()]
    public class XamlRenameSuspiciousNamesService : JetBrains.ReSharper.Refactorings.Rename.IRenameSuspiciousNamesService
    {
        public string[] GetPossibleReferenceNames(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class XamlResourceDeclarationRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class XamlResourceRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.SafeDelete
{
    
    public class XamlSafeDelete : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase
    {
        public XamlSafeDelete(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover> GetExtraElementsFromDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void SetBaseTypes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredType baseClass, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredType> param, JetBrains.ReSharper.Psi.ITypeElement baseElementToRemove) { }
    }
    public class XamlSafeDeleteHelper : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported
    {
        public override bool IsLanguageSupported { get; }
        public override bool CanBeRemoved(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsBaseClassSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsInterfaceImplementationSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml.SafeDeleteFolder
{
    
    public class XamlSafeDeleteFolderHelper : JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetExternalDeclaredElements(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Xaml
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase CreateAdjustNamespaceHelper() { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase CreateMoveToFolderHelper() { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase CreateMoveToNamespaceHelper() { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateSafeDeleteBase(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase CreateSafeDeleteFolderHelper() { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateSafeDeleteHelper() { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass ExtractSuperclassRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class XamlRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper
    {
        public static readonly JetBrains.ReSharper.Refactorings.Xaml.XamlRefactoringsHelper Instance;
        public override JetBrains.ReSharper.Refactorings.Util.ReferenceComparatorDelegate GetReferenceComparator() { }
    }
}