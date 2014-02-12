[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.Html
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
    }
    public class HtmlRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
}
namespace JetBrains.ReSharper.Refactorings.Html.InplaceRefactorings
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlInplaceRenameLanguageSpecifics : JetBrains.ReSharper.InplaceRefactorings.Rename.IInplaceRenameLanguageSpecifics
    {
        public virtual bool SuggestRenameOnRenamingReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Html.Rename
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlBuiltinsRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class HtmlRename : JetBrains.ReSharper.Refactorings.RenameModel.RenameBase { }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public class HtmlTagIdConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
        {
            public HtmlTagIdConflictSearcher(string newName, JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement element) { }
            public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
        }
    }
    public class HtmlTagIdAtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase, JetBrains.ReSharper.Refactorings.Workflow.IUsagesProvider
    {
        public HtmlTagIdAtomicRename([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] string newName) { }
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
    public class HtmlTagIdRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}