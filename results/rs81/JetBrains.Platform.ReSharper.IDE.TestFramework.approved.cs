[assembly: JetBrains.Util.TestDataPathBaseAttribute("Platform\\test\\data")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.IDE
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestEnsureWritableToEditorSync : JetBrains.IDE.EnsureWritableToEditorSync
    {
        public TestEnsureWritableToEditorSync(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler handler, JetBrains.DocumentModel.DocumentSettings documentSettings, JetBrains.IDE.EditorManager editorManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
        protected override bool ShouldSkip(JetBrains.ProjectModel.IProjectFile file) { }
    }
}