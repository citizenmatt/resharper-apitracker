[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.Razor.Move.MoveToFolder
{
    
    public class RazorMoveToFolderHelper : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase
    {
        public override bool CanMoveSingleTypeDeclaration { get; }
        public override bool IsLanguageSupported { get; }
        public override string GetCanMoveToProjectFolderError(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public override bool MoveWholeFile(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string name, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Razor.MoveHelper
{
    
    public interface IMoveHelperDataProvider : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticDataProvider
    {
        string FileName { get; }
    }
    public interface IMoveHelperWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public class MoveHelperMakeStaticDataProvider : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticDataProvider
    {
        public static readonly JetBrains.ReSharper.Psi.TreeNodeMarker Marker;
        public MoveHelperMakeStaticDataProvider(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public string Name { get; }
        public JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ToStaticPolicy Policy { get; }
        public virtual bool Show { get; }
        public virtual void PreProcessParameters(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ParameterFromExpression> parameters) { }
    }
    public class MoveHelperMoveStaticMembersWorkflow : JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow
    {
        public MoveHelperMoveStaticMembersWorkflow(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow moveToFileWorkflow) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.MemberInfo> IncludedMembers { get; }
        protected override string NewFileExtension { get; }
        protected override bool CanMove(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetMakeStaticRefactoring(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticRefactoring value) { }
    }
    public class MoveHelperRefactoring : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public MoveHelperRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver refactoringDriver, JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar, JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticRefactoring makeStaticRefactoring, JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersRefactoring moveRefactoring) { }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class static MoveHelperUtil
    {
        public static bool ExecuteSequence([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi, [JetBrains.Annotations.NotNullAttribute()] params System.Func<, >[] executors) { }
    }
    public class MoveHelperWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.IWorkflowExec>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow
    {
        public MoveHelperWorkflow(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow staticWorkflow, string actionId, JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.Util.FileSystemPath FileLocation { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public JetBrains.Util.FileSystemPath FolderLocation { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public string NewFileExtension { get; }
        public string NewFileName { get; }
        public JetBrains.ProjectModel.IProjectModelElementPointer ProjectFolderPointer { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage(string newFileName, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Razor.MoveHelper.IMoveHelperDataProvider provider) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Razor.MoveStaticMembers
{
    
    public class RazorMoveStaticMembers : JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers
    {
        public RazorMoveStaticMembers(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTypeDeclaration(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> PasteDeclaration(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.TypeMemberCopy copy, out JetBrains.ReSharper.Psi.ITypeMember newTypeMember) { }
        public override void RemoveOldDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Razor.Prelude
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorRefactoringLanguageService : JetBrains.ReSharper.Refactorings.Html.HtmlRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers CreateMoveStaticMembers(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase CreateMoveToFolderHelper() { }
    }
    public class RazorRefactoringsHelper : JetBrains.ReSharper.Refactorings.Html.HtmlRefactoringsHelper { }
}
namespace JetBrains.ReSharper.Refactorings.Razor.Rename
{
    
    public class RazorRename : JetBrains.ReSharper.Refactorings.Html.Rename.HtmlRename { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorRenameHelper : JetBrains.ReSharper.Refactorings.Html.Rename.HtmlRenameHelper
    {
        public override bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
    }
    public class RazorSectionAtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase, JetBrains.ReSharper.Refactorings.Workflow.IUsagesProvider
    {
        public RazorSectionAtomicRename(JetBrains.ReSharper.Psi.Razor.DeclaredElements.IRazorSectionDeclaredElement razorSectionDeclaredElement, string newName) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement NewDeclaredElement { get; }
        public override string NewName { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement PrimaryDeclaredElement { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> SecondaryDeclaredElements { get; }
        public void CommitCheckedOccurrences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> checkedOccurrences, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> getCheckedDeclarations) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateRenamesConfirmationPage(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow, System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> nextPageCreator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> GetDeclarationOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> GetReferenceOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow) { }
        public override void Rename(JetBrains.ReSharper.Refactorings.Rename.RenameRefactoring executer, JetBrains.Application.Progress.IProgressIndicator pi, bool hasConflictsWithDeclarations, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class RazorSectionRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}