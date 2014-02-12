[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.JavaScript.IntroduceVariable
{
    
    public class JavaScriptIntroduceVariable : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase, JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public JavaScriptIntroduceVariable(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo Process(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceExpression) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class JavaScriptIntroduceVariableHelper : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper
    {
        public override bool IsLanguageSupported { get; }
        public override bool CheckAvailability(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool CheckOccurrence(JetBrains.ReSharper.Psi.Tree.ITreeNode masterExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode occurrence) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetScope(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.JavaScript.Prelude
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase CreateIntroduceVariable(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper CreateIntroduceVariableHelper() { }
    }
    public class JavaScriptRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
}
namespace JetBrains.ReSharper.Refactorings.JavaScript.Rename
{
    
    public class JavaScriptPropertyAtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase, JetBrains.ReSharper.Refactorings.Workflow.IUsagesProvider
    {
        public JavaScriptPropertyAtomicRename(JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptProperty javaScriptProperty, string newName) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement NewDeclaredElement { get; }
        public override string NewName { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement PrimaryDeclaredElement { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> SecondaryDeclaredElements { get; }
        public void CommitCheckedOccurrences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> checkedOccurrences, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> declarationOccurrences) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateRenamesConfirmationPage(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow, System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> nextPageCreator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> GetDeclarationOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> GetReferenceOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow) { }
        public override void Rename(JetBrains.ReSharper.Refactorings.Rename.RenameRefactoring executer, JetBrains.Application.Progress.IProgressIndicator pi, bool hasConflictsWithDeclarations, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class JavaScriptPropertyRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class JavaScriptRename : JetBrains.ReSharper.Refactorings.RenameModel.RenameBase { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.JavaScript.Utils
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptRefactoringDataConstantsService : JetBrains.ReSharper.Refactorings.ExtensionsApi.IRefactoringDataConstantsService
    {
        public bool IsNameNodeSelected(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
}