[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.WebConfig.Move
{
    
    public class WebConfigMoveToNamespaceHelper : JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.WebConfig.Rename
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.WebConfig
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase CreateMoveToNamespaceHelper() { }
    }
    public class WebConfigRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
}