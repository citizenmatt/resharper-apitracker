[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.VsIntegration.JustVs09.ProjectModel
{
    
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VcxProjectPropertiesBuilder09 : JetBrains.VsIntegration.ProjectModel.ProjectProperties.VcxProjectPropertiesBuilder
    {
        public VcxProjectPropertiesBuilder09(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        protected override void ProcessVCProject(EnvDTE.Project project, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, EnvDTE.Configuration configuration, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration) { }
    }
}
namespace JetBrains.VsIntegration.VX.ProjectModel.Transactions
{
    
    public class static VcxActionUtil
    {
        public static void Commit(JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbackMerger, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, System.Action action) { }
        public static System.Collections.Generic.IList<Microsoft.VisualStudio.VCProjectEngine.VCFile> GetFileOrAllFilesInFolder(Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.ProjectModel.IProjectItem projectItem) { }
        public static void RefreshProjectInSolutionExplorer(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer, JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    public class VcxAddFileAction : JetBrains.ProjectModel.Transaction.Actions.AddFileAction
    {
        public VcxAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
    public class VcxAddFolderAction : JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction
    {
        public VcxAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, JetBrains.Util.FileSystemPath folderPath, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
    public class VcxCopyAction : JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction
    {
        public VcxCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
        protected override void CopyDocument(JetBrains.ProjectModel.IProjectFile oldProjectFile, JetBrains.ProjectModel.IProjectFile newProjectFile) { }
    }
    [JetBrains.ProjectModel.Properties.SolutionProjectModelExtensionAttribute()]
    public class VcxFilesAndFoldersEditor : JetBrains.VsIntegration.ProjectModel.Transactions.DefaultVsFilesAndFoldersEditor
    {
        public VcxFilesAndFoldersEditor(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.VsIntegration.ProjectModel.VSSolutionExplorer solutionExplorer, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        public override JetBrains.ProjectModel.Transaction.Actions.AddFileAction CreateAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction CreateAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, JetBrains.Util.FileSystemPath folderPath) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction CreateCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.MoveAction CreateMoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction CreateRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction CreateRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    public class VcxRemoveAction : JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction
    {
        public VcxRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
    public class VcxRenameAction : JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction
    {
        public VcxRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
}
namespace JetBrains.VsIntegration.VX.ProjectModel
{
    
    public class VCProjectEngineMirror
    {
        protected void CheckForExceptions([JetBrains.Annotations.InstantHandleAttribute()] System.Action getPropertyValue, ref bool result) { }
        protected virtual void FetchConfigurationProperties(JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration, Microsoft.VisualStudio.VCProjectEngine.VCConfiguration vcConfiguration, string configurationName, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, Microsoft.VisualStudio.VCProjectEngine.VCProjectEngine vcProjectEngine, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, ref bool result) { }
        protected virtual JetBrains.ProjectModel.ProjectOutputType GetOutputType(Microsoft.VisualStudio.VCProjectEngine.VCConfiguration vcConfiguration, JetBrains.Util.FileSystemPath primaryOutputPath) { }
        protected virtual void ProcessCompilerToolProperties(Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool compilerTool, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration) { }
        public void ProcessVCProject(EnvDTE.Project project, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, EnvDTE.Configuration activeConfiguration, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VcxProjectContentBuilderMirror : JetBrains.VsIntegration.ProjectModel.ProjectContent.VSDefaultProjectContentBuilder
    {
        public VcxProjectContentBuilderMirror(JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions) { }
        public override void CreateMissingItems(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public override void FillProjectDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem rootItem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VcxProjectEventHandler
    {
        public VcxProjectEventHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.ViewableProjectsCollection projectsCollection, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer pms, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler solutionLoadTasksScheduler, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
    }
}