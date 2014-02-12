[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty
{
    
    public interface IIntroduceMSBuildPropertyWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IIntroduceNAntPropertyWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class IntroduceMSBuildPropertyWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IIntroduceMSBuildPropertyWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class IntroduceNAntPropertyWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IIntroduceNAntPropertyWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class IntroducePropertyConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
    }
    public class IntroducePropertyConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public IntroducePropertyConflictSearcher(JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    public class IntroducePropertyPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public IntroducePropertyPage(JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring introduceVariableRefactoring, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring IntroducePropertyRefactoring { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public abstract class IntroducePropertyRefactoring
    {
        protected readonly JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase myFile;
        protected readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken> myOccurrences;
        protected string myPropertyName;
        protected readonly string myReplaceText;
        protected readonly JetBrains.Util.TextRange mySelectionRange;
        protected readonly JetBrains.TextControl.ITextControl myTextControl;
        public IntroducePropertyRefactoring(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.TextRange range, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Psi.Tree.IFile File { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken> Occurrences { get; }
        public string PropertyName { get; set; }
        public bool ReplaceOccurrences { get; set; }
        public void Execute() { }
        protected abstract void ExecuteInternal();
        protected JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase FindRootTag() { }
    }
    public abstract class IntroducePropertyRefactoringWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override bool MightModifyManyDocuments { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        protected abstract JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring CreateRefactoring(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.TextRange selectionRange, JetBrains.TextControl.ITextControl textControl);
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected abstract bool IsSuitableBuildFile(JetBrains.ProjectModel.IProjectFile file);
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator taskExecutorCreator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.MSBuild
{
    
    public class IntroduceMSBuildPropertyRefactoring : JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring
    {
        public IntroduceMSBuildPropertyRefactoring(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.TextRange range, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteInternal() { }
        protected string MakePropertyTag() { }
    }
    public class IntroduceMSBuildPropertyRefactoringWorkflow : JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoringWorkflow
    {
        protected override JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring CreateRefactoring(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.TextRange selectionRange, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsSuitableBuildFile(JetBrains.ProjectModel.IProjectFile file) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.NAnt
{
    
    public class IntroduceNAntPropertyRefactoring : JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring
    {
        public IntroduceNAntPropertyRefactoring(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.TextRange range, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteInternal() { }
    }
    public class IntroduceNAntPropertyRefactoringWorkflow : JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoringWorkflow
    {
        protected override JetBrains.ReSharper.Refactorings.BuildScripts.IntroduceProperty.IntroducePropertyRefactoring CreateRefactoring(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.TextRange selectionRange, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsSuitableBuildFile(JetBrains.ProjectModel.IProjectFile file) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.BuildScripts
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildScriptRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateSafeDeleteBase(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateSafeDeleteHelper() { }
    }
    public class MSBuildScriptRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntBuildScriptRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateSafeDeleteBase(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateSafeDeleteHelper() { }
    }
    public class NAntBuildScriptRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
}
namespace JetBrains.ReSharper.Refactorings.BuildScripts.Rename
{
    
    public class BuildScriptRenameConflictsSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public BuildScriptRenameConflictsSearcher(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MsBuildRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.BuildScripts.SafeDelete2
{
    
    public class BuildScriptSafeDelete : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase
    {
        public BuildScriptSafeDelete(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class BuildScriptSafeDeleteHelper : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported
    {
        public override bool IsLanguageSupported { get; }
        public override bool CanBeRemoved(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsBaseClassSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsInterfaceImplementationSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.BuildScripts.src
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildTextOccurenceSearcherFactory : JetBrains.ReSharper.Psi.Xml.Impl.XmlTextOccurenceSearcherFactory
    {
        public override JetBrains.ReSharper.Psi.Xml.Impl.XmlTextOccurenceSearchHelper<TResult> CreateHelper<TResult>(System.Collections.Generic.JetHashSet<string> names, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    public class MSBuildTextOccurenceSearchHelper<TResult> : JetBrains.ReSharper.Psi.Xml.Impl.XmlTextOccurenceSearchHelper<TResult>
    
    {
        public MSBuildTextOccurenceSearchHelper(System.Collections.Generic.JetHashSet<string> names, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        protected override bool DeclarationExists(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken textToken, JetBrains.ReSharper.Psi.TreeTextRange textRange) { }
    }
}