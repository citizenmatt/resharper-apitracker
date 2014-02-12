[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Refactorings.Css.resources.Actions.xml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.Css.ExtractStyle
{
    
    public class ExtractStyle : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow, JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleRefactoring>
    {
        public ExtractStyle(JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractStyle"})]
    public class ExtractStyleAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Css.ExtractStyle.IExtractStyleWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractStyle";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ExtractStyleDrivenWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.IWorkflowExec>
    {
        public ExtractStyleDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Css.ExtractStyle.RefactoringActions.IExtractStyleRefactoringAction Action { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement>> PropertyStatements { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> Ruleset { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.DocumentManagers.DocumentSelection Selection { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Selector { get; set; }
        public override string Title { get; }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Css.ExtractStyle.IExtractStyleDataProvider dataProvider) { }
    }
    public class ExtractStyleRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow, JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyle>
    {
        public ExtractStyleRefactoring(JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ExtractStyleWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ExtractStyleWindow(JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.Application.IShellLocks shellLocks) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class ExtractStyleWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Css.ExtractStyle.IExtractStyleWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IExtractStyleDataProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Selector { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement>> GetSelectedPropertyStatements([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> ruleset);
    }
    public interface IExtractStyleWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.Css.ExtractStyle.RefactoringActions
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExtractStyleFromCssRefactoringAction : JetBrains.ReSharper.Refactorings.Css.ExtractStyle.RefactoringActions.IExtractStyleRefactoringAction
    {
        public bool CanExtract(JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> pointer) { }
        public bool CanExtractStyletTo(JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> pointer, JetBrains.ProjectModel.IProjectFile targetFile) { }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> Execute(JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public string OfferDefaultTargetFile(JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> pointer) { }
        public string OfferTargetFile(JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> pointer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExtractStyleFromHtmlRefactoringAction : JetBrains.ReSharper.Refactorings.Css.ExtractStyle.RefactoringActions.IExtractStyleRefactoringAction
    {
        public bool CanExtract(JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> pointer) { }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> Execute(JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow workflow, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public interface IExtractStyleRefactoringAction
    {
        bool CanExtract([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> pointer);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Css.ExtractStyle.ExtractStyleDrivenWorkflow workflow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi);
    }
}
namespace JetBrains.ReSharper.Refactorings.Css
{
    
    public class static HtmlCssHelper
    {
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection CreateStyleTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile) { }
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection CreateStyleTag2(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile) { }
        public static void FixClassAttribute(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag, System.Collections.Generic.JetHashSet<string> classes) { }
        public static void FixIdAttribute(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag, string id) { }
        public static JetBrains.ReSharper.Psi.Css.Tree.ICssFileSection GetCssSectionForStyleTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile) { }
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetCurrentTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile currentHtmlFile, JetBrains.DocumentModel.DocumentRange range) { }
        public static JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute GetIdAttribute(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag) { }
        public static bool IsEmptyTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag htmlTag) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Css.InplaceRefactorings
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssInplaceRenameLanguageSpecifics : JetBrains.ReSharper.InplaceRefactorings.Rename.IInplaceRenameLanguageSpecifics
    {
        public bool SuggestRenameOnRenamingReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Css.MoveStyle
{
    
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class CssMoveWorkflowProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IMoveStyleDataProvider
    {
        JetBrains.ProjectModel.IProjectFile TargetFile { get; }
        JetBrains.ReSharper.Refactorings.Css.MoveStyle.RefactoringActions.IMoveStyleRefactoringAction GetAction(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> declaration);
        bool GetInsertImportDirective(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> declaration);
    }
    public class MoveStyleDrivenWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.IWorkflowExec>
    {
        public MoveStyleDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Refactorings.Css.MoveStyle.RefactoringActions.IMoveStyleRefactoringAction Action { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> Declarations { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool InsertImportDirective { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ProjectModel.IProjectFile TargetFile { get; set; }
        public override string Title { get; }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Css.MoveStyle.IMoveStyleDataProvider dataProvider) { }
    }
    public class MoveStyleRefactoring : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public MoveStyleRefactoring(JetBrains.ReSharper.Refactorings.Css.MoveStyle.MoveStyleDrivenWorkflow workflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveStyleWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveStyleWindow(JetBrains.ReSharper.Refactorings.Css.MoveStyle.MoveStyleDrivenWorkflow workflow, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Css.MoveStyle.RefactoringActions
{
    
    public interface IMoveStyleRefactoringAction
    {
        bool SupportImportDerictive { get; }
        bool CanMove(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> declarations);
        bool CanMoveTo(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> declarations, JetBrains.ProjectModel.IProjectFile targetFile);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> Execute(JetBrains.ReSharper.Refactorings.Css.MoveStyle.MoveStyleDrivenWorkflow workflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.Application.Progress.IProgressIndicator pi);
        string OfferDefaultTargetFile(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> declarations);
        string OfferTargetFile(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Css.Tree.ICssRule>> declarations);
    }
}
namespace JetBrains.ReSharper.Refactorings.Css.Prelude
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
    }
    public class CssRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
}
namespace JetBrains.ReSharper.Refactorings.Css.Rename
{
    
    public class CssClassAtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase, JetBrains.ReSharper.Refactorings.Workflow.IUsagesProvider
    {
        public CssClassAtomicRename(JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement element, string newName) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement NewDeclaredElement { get; }
        public override string NewName { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement PrimaryDeclaredElement { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> SecondaryDeclaredElements { get; }
        public virtual void CommitCheckedOccurrences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> checkedOccurrences, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> getCheckedDeclarations) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateRenamesConfirmationPage(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow, System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> nextPageCreator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> GetDeclarationOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> GetReferenceOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow) { }
        public override void Rename(JetBrains.ReSharper.Refactorings.Rename.RenameRefactoring executer, JetBrains.Application.Progress.IProgressIndicator pi, bool hasConflictsWithDeclarations, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CssClassRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.RenamePartAttribute()]
    public class CssPrimaryDeclaredElementForRenameProvider : JetBrains.ReSharper.Refactorings.Rename.IPrimaryDeclaredElementForRenameProvider
    {
        public JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class CssRename : JetBrains.ReSharper.Refactorings.RenameModel.RenameBase { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public class CssClassConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
        {
            public CssClassConflictSearcher(JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement element, string newName) { }
            public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
        }
    }
}