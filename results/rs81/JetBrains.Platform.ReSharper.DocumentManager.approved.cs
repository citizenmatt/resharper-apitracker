[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.DocumentManagers
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class DocumentManager
    {
        public const bool OptionDontAssertNonVsDocumentModifications = true;
        public static readonly bool OptionTrace;
        public DocumentManager(JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage mapping, JetBrains.DocumentManagers.DocumentsOnProjectFiles documentsOnProjectFiles, JetBrains.DocumentManagers.SolutionDocumentChangeEventsAggregator solutionDocumentChangeEventsAggregator, JetBrains.DocumentManagers.SolutionDocumentChangeProvider solutionDocumentChangeProvider, JetBrains.DocumentManagers.ProjectModelAwareRangeMarkerManager projectModelAwareRangeMarkerManager) { }
        public JetBrains.DataFlow.ISignal<JetBrains.DocumentModel.DocumentChange> BeforeAnyDocumentChanged { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DocumentModel.DocumentChange> BeforeAnyDocumentCopyChanged { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentManagers.SolutionDocumentChangeProvider ChangeProvider { get; }
        public JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.DocumentModel.DocumentRange documentRange) { }
        public void EnsureWritable([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument doc, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Util.ModificationCookie> withCookie) { }
        public void EnsureWritableSuccess([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument doc, [JetBrains.Annotations.NotNullAttribute()] System.Action onSucceeded) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Inject me!")]
        public static JetBrains.DocumentManagers.DocumentManager GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentModel.IDocument GetOrCreateDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentModel.IDocument GetOrCreateDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile GetProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile TryGetProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
    }
    public class static DocumentManagerExtensions
    {
        public static JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddDocument(this JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentManager docman, JetBrains.DocumentModel.IDocument document) { }
        public static void AddDocuments(this JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentManager docman, System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IDocument> documents) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DocumentModel.IDocument GetDocument([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class DocumentSavedEventArgs : System.EventArgs
    {
        public DocumentSavedEventArgs(JetBrains.DocumentModel.IDocument document) { }
        public JetBrains.DocumentModel.IDocument Document { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DocumentsOnProjectFiles : JetBrains.DocumentModel.IDocumentOwner
    {
        public DocumentsOnProjectFiles(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage storage, JetBrains.DocumentManagers.IDocumentManagerDocumentFactory documentFactory) { }
        public void ClearDocuments() { }
        public JetBrains.DocumentModel.IDocumentPointer CreateDocumentPointer(JetBrains.DocumentModel.IDocument document) { }
        public JetBrains.DocumentModel.IDocument GetOrCreateDocument(JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentModel.IDocument GetOrCreateDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile GetProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath TryGetDocumentFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        public class DocumentPointerOnProjectFile : JetBrains.DocumentModel.IDocumentPointer
        {
            public DocumentPointerOnProjectFile(JetBrains.DocumentManagers.DocumentsOnProjectFiles storage, JetBrains.ProjectModel.IProjectFile projectFile) { }
            public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
            public JetBrains.DocumentModel.IDocument GetOrCreateDocument() { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DocumentToProjectFileMappingStorage
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.Util.Pair<JetBrains.ProjectModel.IProjectFile, JetBrains.DocumentModel.IDocument>> Added;
        public readonly JetBrains.DataFlow.Signal<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.DocumentModel.IDocument, JetBrains.Util.FileSystemPath>> RemovedExplicitly;
        public DocumentToProjectFileMappingStorage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> GetAllDocuments() { }
        public JetBrains.DocumentModel.IDocument TryGetDocument(JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.DocumentModel.IDocument TryGetDocumentByPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filePath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.DocumentModel.IDocument TryGetDocumentByProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath TryGetDocumentFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile TryGetInvalidProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile TryGetProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
    }
    public interface IDocumentManagerDocumentFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocument CreateDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.DocumentModel.IDocumentOwner owner);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocument CreateDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filePath, JetBrains.DocumentModel.IDocumentOwner owner);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectFilesRemovedOnDocumentTransactionCommit
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.ProjectModel.IProjectFile> ProjectFileRemoved;
        public ProjectFilesRemovedOnDocumentTransactionCommit(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentModel.Transactions.DocumentTransactionManager documentTransactionManager, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectModelAwareRangeMarkerManager
    {
        public ProjectModelAwareRangeMarkerManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage) { }
        public JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
    public class static RangeMarkerExtentions
    {
        public static JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(this JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile TryGetProjectFile(this JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.DocumentManagers.DocumentManager documentManager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RangeMarkersManagerImpl : JetBrains.DocumentModel.RangeMarkersManager, JetBrains.Application.IChangeProvider
    {
        public RangeMarkersManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.Application.ChangeManager changeManager) { }
        public class CollectRangeMarkersEventArgs : System.EventArgs
        {
            public readonly JetBrains.DocumentModel.IDocument Document;
            public readonly System.Collections.Generic.IList<System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker>> RangeMarkers;
            public CollectRangeMarkersEventArgs(JetBrains.DocumentModel.IDocument document) { }
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class InvalidateFileMarkersOnProjectModelChange
        {
            public InvalidateFileMarkersOnProjectModelChange(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.RangeMarkersManagerImpl rangeMarkersManagerImpl, JetBrains.DocumentManagers.ProjectFilesRemovedOnDocumentTransactionCommit projectFilesRemovedOnDocumentTransactionCommit, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage) { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionDocumentChangeEventsAggregator
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DocumentModel.DocumentChange> BeforeAnyDocumentChanged;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DocumentModel.DocumentChange> BeforeAnyDocumentCopyChanged;
        public SolutionDocumentChangeEventsAggregator(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage storage) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionDocumentChangeProvider : JetBrains.Application.IChangeProvider
    {
        public SolutionDocumentChangeProvider(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.Application.ChangeManager changeManager) { }
    }
}
namespace JetBrains.DocumentManagers.impl
{
    
    public abstract class DocumentManagerOperations
    {
        public event System.EventHandler<JetBrains.DocumentManagers.DocumentSavedEventArgs> AfterDocumentSaved;
        public event JetBrains.ProjectModel.BeforeReloadedEventHandler BeforeDocumentReloaded;
        [System.ObsoleteAttribute("Defunct in VS implementation.")]
        public event JetBrains.ProjectModel.BeforeSavedEventHandler BeforeDocumentSaved;
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IDocument> GetUnsavedDocuments();
        public abstract bool IsDocumentUnsaved([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document);
        protected virtual void OnAfterDocumentSaved(JetBrains.DocumentManagers.DocumentSavedEventArgs e) { }
        protected virtual void OnBeforeDocumentReloaded(JetBrains.ProjectModel.BeforeReloadedEventArgs e) { }
        protected virtual void OnBeforeDocumentSaved(JetBrains.ProjectModel.BeforeSavedEventArgs e) { }
        public abstract void SaveAllDocuments();
        public abstract void SaveDocument(JetBrains.DocumentModel.IDocument document);
        public abstract void SaveDocumentAfterModification(JetBrains.DocumentModel.IDocument document);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DocumentOperationsImpl : JetBrains.DocumentManagers.impl.DocumentManagerOperations
    {
        protected readonly JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage myDocumentToProjectFileMappingStorage;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        public DocumentOperationsImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        protected static void AssertNoDocumentTransaction(JetBrains.DocumentModel.IDocument document) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IDocument> GetUnsavedDocuments() { }
        public override bool IsDocumentUnsaved([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        protected virtual void OnSaveException(JetBrains.DocumentModel.IDocument document, System.Exception e) { }
        public override void SaveAllDocuments() { }
        public override void SaveDocument(JetBrains.DocumentModel.IDocument document) { }
        public override void SaveDocumentAfterModification(JetBrains.DocumentModel.IDocument document) { }
        protected void SaveDocumentInternal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        public virtual void SynchronizeDocumentContentsWithFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, JetBrains.Util.FileSystemPath documentPath) { }
        public void SynchronizeDocumentContentsWithFile_Standalone([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, JetBrains.Util.FileSystemPath documentPath) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class IdeInMemoryDocumentFactory : JetBrains.DocumentModel.IDocumentOwner, JetBrains.DocumentModel.IIdeInMemoryDocumentFactory
    {
        public IdeInMemoryDocumentFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager) { }
        protected JetBrains.DocumentModel.Transactions.IDocumentTransactionManager DummyTransactionManager { get; }
        public JetBrains.DocumentModel.IDocumentPointer CreateDocumentPointer(JetBrains.DocumentModel.IDocument document) { }
        public virtual JetBrains.DocumentModel.IDocument CreateIdeDocumentFromText(string text, string moniker, System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler) { }
    }
    public class ProjectFileDocumentChange : JetBrains.DocumentModel.DocumentChange
    {
        public ProjectFileDocumentChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.DocumentChange documentChange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    public class ProjectFileDocumentCopyChange : JetBrains.DocumentModel.DocumentChange
    {
        public ProjectFileDocumentCopyChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.DocumentChange documentChange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    public class static ProjectFileUtil
    {
        public static string ReadTextFromFile(JetBrains.ProjectModel.IProjectFile file, out System.Text.Encoding detectedEncoding) { }
        public static string ReadTextFromFile(JetBrains.Util.FileSystemPath path, out System.Text.Encoding detectedEncoding) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class StandaloneDocumentManagerDocumentFactory : JetBrains.DocumentManagers.IDocumentManagerDocumentFactory
    {
        protected readonly JetBrains.DocumentModel.Impl.DocumentChangeManager myDocumentChangeManager;
        protected readonly JetBrains.DocumentManagers.Transactions.SolutionDocumentTransactionManager myDocumentTransactionManager;
        protected readonly JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler myEnsureWritableHandler;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        public StandaloneDocumentManagerDocumentFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentManagers.Transactions.SolutionDocumentTransactionManager documentTransactionManager) { }
        public virtual JetBrains.DocumentModel.IDocument CreateDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.DocumentModel.IDocumentOwner owner) { }
        public virtual JetBrains.DocumentModel.IDocument CreateDocument(JetBrains.Util.FileSystemPath filePath, JetBrains.DocumentModel.IDocumentOwner owner) { }
    }
}
namespace JetBrains.DocumentManagers.Transactions.Actions
{
    
    public class StandaloneAddReferenceAction : JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction
    {
        public StandaloneAddReferenceAction(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule moduleToReference, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        public override void Commit() { }
    }
    public class StandaloneAddReferenceAction2 : JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction2
    {
        public StandaloneAddReferenceAction2(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedAssembly, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        public override void Commit() { }
    }
    public class StandaloneRemoveReferenceAction : JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveReferenceAction
    {
        public StandaloneRemoveReferenceAction(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        public override void Commit() { }
    }
}
namespace JetBrains.DocumentManagers.Transactions
{
    
    public class RangeMarkerUnderTransaction : JetBrains.DocumentManagers.RangeMarker, JetBrains.DocumentModel.Transactions.IRangeMarkerUnderTransaction
    {
        public RangeMarkerUnderTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction ownerTransaction, int actionsCountWhenCreated, JetBrains.DocumentModel.IDocumentPointer documentPointer, JetBrains.Util.TextRange range) { }
        public int ActionsCountWhenCreated { get; }
        public override bool IsValid { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.DocumentModel.Transactions.DocumentTransaction OwnerTransaction { get; }
        public override JetBrains.Util.TextRange Range { get; }
        public void AssertIsInTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction) { }
        public void AssertIsMovedFrom(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction) { }
        public void MoveFromTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction) { }
        public void MoveToTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction fromTransaction, JetBrains.DocumentModel.Transactions.DocumentTransaction toTransaction, int changesCountToAdd) { }
        public override void NotifyDocumentChanged(JetBrains.DocumentModel.DocumentChange e, int newDocumentLength) { }
        public void PlayChangesBack(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction, JetBrains.DocumentModel.DocumentChange rollbackChange, int index, int newDocumentLength) { }
        public void ResetTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionDocumentTransactionManager : JetBrains.DocumentModel.Transactions.DocumentTransactionManager
    {
        public SolutionDocumentTransactionManager(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelTransactionManager projectModelTransactionManager, JetBrains.DocumentModel.DocumentSettings documentSettings, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.CommandProcessing.DocumentCommandProcessor documentCommandProcessor) { }
        public override JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.DocumentModel.impl.ManagedDocumentBase document, JetBrains.Util.TextRange range, bool mapToDocument) { }
        protected override JetBrains.DocumentModel.Transactions.DocumentTransaction CreateTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction parentTransaction, string commandName, bool optimizeChangesOnCommit) { }
        protected override void SaveDocumentAfterModification(JetBrains.DocumentModel.IDocument document) { }
        protected override void SetActiveTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction transaction) { }
    }
    public class SolutionProjectDocumentTransaction : JetBrains.DocumentModel.Transactions.DocumentTransaction, JetBrains.ProjectModel.IProjectModelTransactionHandler
    {
        public SolutionProjectDocumentTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Transactions.DocumentTransactionManager manager, JetBrains.DocumentModel.Transactions.DocumentTransaction parentTransaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, string commandName, bool optimizeChangesOnCommit, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.DocumentModel.CommandProcessing.DocumentCommandProcessor documentCommandProcessor) { }
        protected override JetBrains.Util.ModificationCookie CreateEnsureWritableCoockie(out System.Collections.Generic.IList<> affectedDocuments) { }
        public override JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.Util.TextRange range, JetBrains.DocumentModel.impl.ManagedDocumentBase document) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentChange> DoCommit(System.Collections.Generic.IDictionary<JetBrains.DocumentModel.impl.ManagedDocumentBase, JetBrains.DocumentModel.Transactions.DocumentChangeInfo> dirtyDocuments, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.DocumentModel.Transactions.DocumentTransactionRollbackResult DoRollback() { }
        protected override void MergeChanges(JetBrains.DocumentModel.Transactions.DocumentTransaction childTransaction) { }
        public void RegisterNewChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ITransactionAction transactionAction) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class StandaloneProjectModelEditor : JetBrains.ProjectModel.ProjectModelEditorBase
    {
        public StandaloneProjectModelEditor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.IProjectModelTransactionManager projectModelTransactionManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Assemblies.Impl.ModuleReferenceResolveManager moduleReferenceResolveManager) { }
        protected override JetBrains.ProjectModel.Transaction.Actions.AddFileAction CreateAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction CreateAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, JetBrains.Util.FileSystemPath folderPath) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction CreateAddReferenceAction(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule referenceToAdd) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction2 CreateAddReferenceAction2(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedLibrary) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction CreateCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.MoveAction CreateMoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction CreateRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveReferenceAction CreateRemoveReferenceAction(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction CreateRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName) { }
    }
    public class static TextRangeExtensions
    {
        public static JetBrains.DocumentModel.DocumentRange CreateDocumentRange(this JetBrains.Util.TextRange textRange, JetBrains.DocumentModel.IDocument document) { }
        public static JetBrains.DocumentModel.DocumentRange CreateDocumentRange(this JetBrains.Util.TextRange textRange, JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ProjectModel
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectModelTransactionFactory : JetBrains.ProjectModel.IProjectModelTransactionFactory
    {
        public ProjectModelTransactionFactory(JetBrains.DocumentManagers.Transactions.SolutionDocumentTransactionManager documentTransactionManager, JetBrains.ProjectModel.IProjectModelEditor projectModelEditor) { }
        public JetBrains.ProjectModel.IProjectModelTransactionCookie CreateTransactionCookie(JetBrains.Util.DefaultAction defaultAction, string commandName, JetBrains.Util.IUndoRedoHandler handler, bool optimizeChangesOnCommit, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectModelTransactionManager : JetBrains.ProjectModel.IProjectModelTransactionManager
    {
        public ProjectModelTransactionManager(JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectModelTransactionHandler CurrentTransactionHandler { get; }
        public void SetCurrentTransactionHandler(JetBrains.ProjectModel.IProjectModelTransactionHandler transactionHandler) { }
    }
}