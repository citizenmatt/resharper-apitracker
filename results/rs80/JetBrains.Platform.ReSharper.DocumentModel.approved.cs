[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.DocumentManagers
{
    
    public class DocumentOffset
    {
        public readonly JetBrains.DocumentModel.IDocument Document;
        public readonly int Value;
        public DocumentOffset(JetBrains.DocumentModel.IDocument document, int offset) { }
    }
    public class DocumentSelection
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DocumentModel.IDocument Document;
        public readonly JetBrains.Util.TextRange TextRange;
        public DocumentSelection([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, JetBrains.Util.TextRange textRange) { }
    }
    public class RangeMarker : JetBrains.DocumentModel.IRangeMarker
    {
        public static JetBrains.DocumentModel.IRangeMarker InvalidMarker;
        protected bool myIsValid;
        protected JetBrains.Util.TextRange myRangeBeforeTransaction;
        public RangeMarker(JetBrains.DocumentModel.IDocumentPointer documentPointer, JetBrains.Util.TextRange range) { }
        public JetBrains.DocumentModel.IDocument Document { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentModel.IDocumentPointer DocumentPointer { get; }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public bool IsGreedyToLeft { get; set; }
        public bool IsGreedyToRight { get; set; }
        public virtual bool IsValid { get; set; }
        public virtual JetBrains.Util.TextRange Range { get; }
        public bool Equals(JetBrains.DocumentManagers.RangeMarker other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public virtual void NotifyDocumentChanged(JetBrains.DocumentModel.DocumentChange e, int newDocumentLength) { }
    }
}
namespace JetBrains.DocumentManagers.impl
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class InMemoryDocumentFactory : JetBrains.DocumentModel.IDocumentOwner, JetBrains.DocumentModel.IInMemoryDocumentFactory
    {
        public InMemoryDocumentFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager) { }
        public JetBrains.DocumentModel.IDocumentPointer CreateDocumentPointer(JetBrains.DocumentModel.IDocument document) { }
        public JetBrains.DocumentModel.IDocument CreateSimpleDocumentFromText(string text, string moniker, JetBrains.DocumentModel.Transactions.IDocumentTransactionManager customTransactionManager = null) { }
    }
}
namespace JetBrains.DocumentModel.CommandProcessing
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DocumentCommandProcessor
    {
        public DocumentCommandProcessor(JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
        public virtual void AddUndoRedoHandlers([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.IUndoRedoHandler> handlers) { }
    }
}
namespace JetBrains.DocumentModel
{
    
    public abstract class DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.DocumentModel.IDocument> DOCUMENT;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.DocumentManagers.DocumentOffset> DOCUMENT_OFFSET;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.DocumentManagers.DocumentSelection> DOCUMENT_SELECTION;
    }
    public class static DataContextsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.DataContext.IDataContext FromDocument([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.DataContexts thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.DataContext.IDataContext FromDocumentRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.DataContexts thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentManagers.DocumentSelection range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.DataContext.IDataContext FromDocumentRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.DataContexts thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.DocumentRange range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> ToDataContext(this JetBrains.DocumentModel.DocumentRange range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> ToDataContext([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IDocument document) { }
    }
    public struct DocColumn { }
    public struct DocLine { }
    public struct DocLineColumnRange : System.IEquatable<JetBrains.DocumentModel.DocLineColumnRange>
    {
        public JetBrains.DocumentModel.DocumentCoords End;
        public JetBrains.DocumentModel.DocumentCoords Start;
        public DocLineColumnRange(JetBrains.DocumentModel.DocumentCoords start, JetBrains.DocumentModel.DocumentCoords end) { }
        public DocLineColumnRange(JetBrains.DocumentModel.DocumentCoords posStartAndEnd) { }
        public bool Contains(JetBrains.DocumentModel.DocumentCoords pos) { }
        public bool ContainsLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.DocumentModel.DocLineColumnRange other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class DocumentChange
    {
        public DocumentChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int startOffset, int oldLength, [JetBrains.Annotations.NotNullAttribute()] string newText, int oldModificationStamp, JetBrains.DocumentModel.TextModificationSide modificationSide) { }
        public DocumentChange([JetBrains.Annotations.NotNullAttribute()] string oldText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int startOffset, [JetBrains.Annotations.NotNullAttribute()] string newText, int oldLength, int oldModificationStamp, JetBrains.DocumentModel.TextModificationSide modificationSide) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.DocumentModel.TextModificationSide ModificationSide { get; }
        public JetBrains.Util.TextRange NewExtent { get; }
        public int NewLength { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string NewText { get; }
        public JetBrains.Util.TextRange OldExtent { get; }
        public int OldLength { get; }
        public int OldModificationStamp { get; }
        public string OldText { get; }
        public int StartOffset { get; }
        public override string ToString() { }
    }
    public delegate void DocumentChangedEventHandler(object sender, JetBrains.DataFlow.EventArgs<JetBrains.DocumentModel.DocumentChange> args);
    public struct DocumentCoords : System.IComparable<JetBrains.DocumentModel.DocumentCoords>, System.IEquatable<JetBrains.DocumentModel.DocumentCoords>
    {
        public static readonly JetBrains.DocumentModel.DocumentCoords Empty;
        public DocumentCoords(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> column) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> Column { get; }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> Line { get; }
        public static int Compare(JetBrains.DocumentModel.DocumentCoords left, JetBrains.DocumentModel.DocumentCoords right) { }
        public int CompareTo(JetBrains.DocumentModel.DocumentCoords other) { }
        public bool Equals(JetBrains.DocumentModel.DocumentCoords other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.DocumentModel.DocumentCoords Parse(string str) { }
        public override string ToString() { }
        public string ToString(System.IFormatProvider formatProvider) { }
        public static System.Nullable<JetBrains.DocumentModel.DocumentCoords> TryParse([JetBrains.Annotations.NotNullAttribute()] string str) { }
        public static System.Nullable<JetBrains.DocumentModel.DocumentCoords> TryParse([JetBrains.Annotations.NotNullAttribute()] string str, System.IFormatProvider formatProvider) { }
    }
    public class DocumentCopyChanged
    {
        public DocumentCopyChanged(JetBrains.DocumentModel.DocumentChange documentChange) { }
        public JetBrains.DocumentModel.DocumentChange DocumentChange { get; }
    }
    public class static DocumentExtensions
    {
        public static JetBrains.DocumentModel.IDocumentPointer ToPointer(this JetBrains.DocumentModel.IDocument document) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DocumentModelDocumentManagerEvents : System.IDisposable
    {
        public readonly JetBrains.DataFlow.ISimpleSignal AfterReplaceStream;
        public readonly JetBrains.DataFlow.ISimpleSignal BeforeReplaceStream;
        public DocumentModelDocumentManagerEvents() { }
        public void Dispose() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Range = {TextRange}, Document = {Document}")]
    public struct DocumentRange : System.IEquatable<JetBrains.DocumentModel.DocumentRange>
    {
        public static readonly JetBrains.DocumentModel.DocumentRange InvalidRange;
        public DocumentRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IRangeMarker marker) { }
        public DocumentRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int offset) { }
        public DocumentRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, JetBrains.Util.TextRange textRange) { }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        [JetBrains.Annotations.PureAttribute()]
        public bool ContainedIn(JetBrains.DocumentModel.DocumentRange documentRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains(JetBrains.DocumentModel.DocumentRange documentRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange EndOffsetRange() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.DocumentModel.DocumentRange range) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange ExtendLeft(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange ExtendRight(int offset) { }
        public override int GetHashCode() { }
        public string GetText() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange Intersect(JetBrains.DocumentModel.DocumentRange documentRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Intersects(JetBrains.DocumentModel.DocumentRange documentRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool IsValid() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange JoinLeft(JetBrains.DocumentModel.DocumentRange documentRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange JoinRight(JetBrains.DocumentModel.DocumentRange documentRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange SetEndTo(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange SetStartTo(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange Shift(int delta) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange StartOffsetRange() { }
        public override string ToString() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange TrimLeft(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.DocumentModel.DocumentRange TrimRight(int offset) { }
    }
    public class static DocumentRangeExtensions
    {
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertValid(this JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
    public class DocumentRangeMarkerEventArgs : System.EventArgs
    {
        public DocumentRangeMarkerEventArgs(JetBrains.Util.TextRange oldRange, JetBrains.Util.TextRange newRange) { }
        public JetBrains.Util.TextRange NewRange { get; }
        public JetBrains.Util.TextRange OldRange { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DocumentSettings
    {
        public DocumentSettings(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public void ExecuteWithOpenDocumentAfterModification(System.Action action) { }
        public bool GetOpenDocumentAfterModification(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
        public int GetOpenFilesCountWithoutWarningThreshold(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
        public void SetOpenDocumentAfterModification(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext, bool value) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class DocumentSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader { }
    public interface IDocument : JetBrains.Util.IUserDataHolder
    {
        JetBrains.Text.IBuffer Buffer { get; }
        JetBrains.Util.TextRange DocumentRange { get; }
        System.Text.Encoding Encoding { get; set; }
        int LastModificationStamp { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Moniker { get; }
        JetBrains.DocumentModel.IDocumentOwner Owner { get; }
        public event JetBrains.DocumentModel.DocumentChangedEventHandler BeforeDocumentChanged;
        public event JetBrains.DocumentModel.DocumentChangedEventHandler BeforeDocumentCopyChanged;
        public event JetBrains.DocumentModel.DocumentChangedEventHandler DocumentChanged;
        bool ContainsReadOnlyRegions();
        void DeleteText(JetBrains.Util.TextRange fromRange);
        void DeleteText(JetBrains.Util.TextRange fromRange, JetBrains.DocumentModel.TextModificationSide modificationSide);
        void DispatchPendingBeforeDocumentChanged(JetBrains.DocumentModel.DocumentChangedEventHandler handler);
        void DispatchPendingDocumentChanged(JetBrains.DocumentModel.DocumentChangedEventHandler handler);
        void Dump(System.IO.TextWriter to);
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Document Transaction must be used.")]
        JetBrains.Util.ModificationCookie EnsureWritable();
        void ExecuteAfterDocumentChanged(System.Action action);
        JetBrains.DocumentModel.DocumentCoords GetCoordsByOffset(int offset);
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> GetLineCount();
        int GetLineEndOffsetNoLineBreak(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line);
        int GetLineEndOffsetWithLineBreak(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line);
        JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> GetLineLength(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line);
        int GetLineStartOffset(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line);
        string GetLineText(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> lineNumber);
        int GetOffsetByCoords(JetBrains.DocumentModel.DocumentCoords coords);
        string GetText();
        string GetText(JetBrains.Util.TextRange fromRange);
        int GetTextLength();
        void InsertText(int offset, string text);
        void InsertText(int offset, string text, JetBrains.DocumentModel.TextModificationSide modificationSide);
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable MakeReadonly(JetBrains.Util.TextRange range);
        void ReplaceText(JetBrains.Util.TextRange atRange, string text);
    }
    public interface IDocumentOwner
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocumentPointer CreateDocumentPointer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document);
    }
    public interface IDocumentPointer
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.DocumentModel.IDocument GetOrCreateDocument();
    }
    public interface IIdeInMemoryDocumentFactory
    {
        JetBrains.DocumentModel.IDocument CreateIdeDocumentFromText([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string moniker, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler);
    }
    public interface IInMemoryDocumentFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocument CreateSimpleDocumentFromText([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string moniker, JetBrains.DocumentModel.Transactions.IDocumentTransactionManager customTransactionManager = null);
    }
    public class static InMemoryDocumentFactoryEx
    {
        public static JetBrains.DocumentModel.IDocument CreateSimpleDocumentFromFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public static JetBrains.DocumentModel.IDocument CreateSimpleDocumentFromFileSafe([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler = null) { }
        public static JetBrains.DocumentModel.IDocument CreateSimpleDocumentFromStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] string moniker) { }
    }
    public interface IRangeMarker
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocument Document { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DocumentModel.IDocumentPointer DocumentPointer { get; }
        JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        bool IsGreedyToLeft { get; set; }
        bool IsGreedyToRight { get; set; }
        bool IsValid { get; set; }
        JetBrains.Util.TextRange Range { get; }
    }
    public interface IRangeMarkerTipProvider
    {
        string GetTipText(JetBrains.DocumentModel.IRangeMarker marker);
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Document settings")]
    public class OpenDocumentSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Do open document after modification")]
        public bool OpenDocumentAfterModification;
        [JetBrains.Application.Settings.SettingsEntryAttribute(20, "Show warning if the product is about to open too many files after modification")]
        public int OpenFilesCountWithoutWarningThreshold;
    }
    public class static RangeMarkerExtentions
    {
        public static JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(this JetBrains.DocumentModel.DocumentRange documentRange) { }
        public static JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(this JetBrains.Util.TextRange textRange, JetBrains.DocumentModel.IDocument document) { }
        public static JetBrains.DocumentModel.IRangeMarker CreateRangeMarkerWithMappingToDocument(this JetBrains.DocumentModel.DocumentRange documentRange) { }
        public static JetBrains.DocumentModel.IRangeMarker CreateRangeMarkerWithMappingToDocument(this JetBrains.Util.TextRange textRange, JetBrains.DocumentModel.IDocument document) { }
    }
    public abstract class RangeMarkersManager
    {
        public static readonly JetBrains.Util.Key<JetBrains.Util.WeakCollection<JetBrains.DocumentModel.IRangeMarker>> RangeMarkerKey;
        public static readonly JetBrains.Util.Key RangeMarkerTimeStampKey;
    }
    public class SimpleDocumentPointer : JetBrains.DocumentModel.IDocumentPointer
    {
        public SimpleDocumentPointer(JetBrains.DocumentModel.IDocument document) { }
        public JetBrains.DocumentModel.IDocument GetOrCreateDocument() { }
    }
    public class StandaloneDocument : JetBrains.DocumentModel.impl.ManagedDocumentBase
    {
        public StandaloneDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Transactions.IDocumentTransactionManager documentTransactionManager, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string moniker, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler, JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentModel.IDocumentOwner owner) { }
        public override string Moniker { get; }
        public override bool ContainsReadOnlyRegions() { }
        public override void Dump(System.IO.TextWriter to) { }
        public override System.IDisposable MakeReadonly(JetBrains.Util.TextRange range) { }
    }
    public enum TextModificationSide
    {
        NotSpecified = 0,
        LeftSide = 1,
        RightSide = 2,
    }
}
namespace JetBrains.DocumentModel.DataContext
{
    
    public class static DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.DocumentModel.IDocument> DOCUMENT;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.DocumentManagers.DocumentOffset> DOCUMENT_OFFSET;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.DocumentManagers.DocumentSelection> DOCUMENT_SELECTION;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DocumentModelDataRules
    {
        public DocumentModelDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts contexts) { }
    }
}
namespace JetBrains.DocumentModel.Impl
{
    
    public abstract class DocumentBase : JetBrains.Util.UserDataHolder, JetBrains.DocumentModel.IDocument, JetBrains.Util.IUserDataHolder
    {
        protected bool myIsDocumentChanging;
        public int myLastModificationStamp;
        protected JetBrains.Util.Concurrency.LocalLazy<JetBrains.DocumentModel.Impl.LineIndex, JetBrains.Text.ArrayBuffer> myLineIndex;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.Application.IShellLocks myLocks;
        protected readonly JetBrains.Text.ArrayBuffer myTextBuffer;
        public DocumentBase([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentModel.IDocumentOwner owner) { }
        public virtual JetBrains.Text.IBuffer Buffer { get; }
        public JetBrains.Util.TextRange DocumentRange { get; }
        public System.Text.Encoding Encoding { get; set; }
        public bool IsExpectingCallbacksFromUnderlyingStore { get; }
        public int LastModificationStamp { get; set; }
        public abstract string Moniker { get; }
        public JetBrains.DocumentModel.IDocumentOwner Owner { get; }
        public event JetBrains.DocumentModel.DocumentChangedEventHandler BeforeDocumentChanged;
        public event JetBrains.DocumentModel.DocumentChangedEventHandler BeforeDocumentCopyChanged;
        public event JetBrains.DocumentModel.DocumentChangedEventHandler DocumentChanged;
        protected void ApplyDocumentChangeToTheOwnTextBuffer(JetBrains.DocumentModel.DocumentChange documentChange) { }
        public virtual void AssertOnDocumentModification() { }
        public abstract void ChangeDocument(JetBrains.DocumentModel.DocumentChange documentChange, int timestamp);
        public abstract bool ContainsReadOnlyRegions();
        public abstract JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.Util.TextRange range, bool mapToDocument);
        public void DeleteText(JetBrains.Util.TextRange fromRange) { }
        public abstract void DeleteText(JetBrains.Util.TextRange fromRange, JetBrains.DocumentModel.TextModificationSide modificationSide);
        public void DispatchPendingBeforeDocumentChanged(JetBrains.DocumentModel.DocumentChangedEventHandler handler) { }
        public void DispatchPendingDocumentChanged(JetBrains.DocumentModel.DocumentChangedEventHandler handler) { }
        public abstract void Dump(System.IO.TextWriter to);
        public JetBrains.Util.ModificationCookie EnsureWritable() { }
        protected void ExecuteActionsAfterChange() { }
        public void ExecuteAfterDocumentChanged(System.Action action) { }
        public void ExpectCallbacksFromUnderlyingStore([JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public JetBrains.DocumentModel.DocumentCoords GetCoordsByOffset(int offset) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> GetLineCount() { }
        public int GetLineEndOffsetNoLineBreak(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> lineNumber) { }
        public int GetLineEndOffsetWithLineBreak(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> lineNumber) { }
        protected virtual JetBrains.DocumentModel.Impl.LineIndex GetLineIndex() { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> GetLineLength(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public int GetLineStartOffset(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> lineNumber) { }
        public virtual string GetLineText(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> lineNumber) { }
        public int GetOffsetByCoords(JetBrains.DocumentModel.DocumentCoords coords) { }
        public virtual string GetText() { }
        public virtual string GetText(JetBrains.Util.TextRange range) { }
        public virtual int GetTextLength() { }
        public abstract void HandleExternalChange(JetBrains.DocumentModel.DocumentChange documentChange, int timestamp, bool underWriteLock);
        public void InsertText(int offset, string text) { }
        public abstract void InsertText(int offset, string text, JetBrains.DocumentModel.TextModificationSide modificationSide);
        public abstract System.IDisposable MakeReadonly(JetBrains.Util.TextRange range);
        public virtual JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, bool isGreedyToLeft, bool isGreedyToRight) { }
        protected void RaiseDocumentChangedEvents(JetBrains.DocumentModel.DocumentChange args, bool needCopyChangeEvent) { }
        protected void RaiseEventsBeforeChange(JetBrains.DocumentModel.DocumentChange args) { }
        public void RaiseEventsBeforeCopyChange(JetBrains.DocumentModel.DocumentChange args) { }
        public abstract void ReplaceText(JetBrains.Util.TextRange atRange, string text);
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public sealed class DocumentChangeManager : JetBrains.Application.IChangeProvider
    {
        public DocumentChangeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void FireDocumentChange(JetBrains.DocumentModel.DocumentChange args) { }
        public void FireDocumentCopyChange(JetBrains.DocumentModel.DocumentChange args) { }
    }
    public class DocumentChangesRecorder : System.IDisposable
    {
        public DocumentChangesRecorder(JetBrains.DocumentModel.IDocument document) { }
        public void Dispose() { }
        public void Pause() { }
        public void Record() { }
        public void Replay() { }
        public void Resume() { }
        public void Rewind() { }
        public void Stop() { }
    }
    public class static DocumentUtil
    {
        public static void CommitDiffChanges(JetBrains.DocumentModel.IDocument document, string oldText, string newText, JetBrains.Util.TextRange oldRange, JetBrains.Util.TextRange newRange) { }
        [System.ObsoleteAttribute("Use DocumentManager::EnsureWritableSuccess.")]
        public static void ExecuteIfWritable(this JetBrains.DocumentModel.IDocument document, System.Action action) { }
        public static void FixDocumentEncoding(JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ReadTextFromFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, bool bFailOnErrors) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ReadTextFromFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, bool bFailOnErrors, out System.Text.Encoding encoding) { }
        public static string ReadTextFromFile([JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, out System.Text.Encoding detectedEncoding) { }
        public static void SaveDocumentToFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filePath) { }
        public static void SetText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IDocument document, string text) { }
    }
    public class EditableBuffer : JetBrains.Text.IBuffer, JetBrains.Text.IEditableBuffer
    {
        public EditableBuffer(int length) { }
        public EditableBuffer() { }
        public EditableBuffer(string text) { }
        public char this[int index] { get; }
        public int Length { get; }
        public void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
        public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length) { }
        public string GetText(JetBrains.Util.TextRange range) { }
        public string GetText(int start, int length) { }
        public string GetText() { }
        public void Insert(int offset, string text) { }
        public void Remove(int offset, int length) { }
        public void Replace(int offset, int length, string text) { }
        public void Replace(int offset, int length, JetBrains.Text.BufferRange newText) { }
    }
    public class LineIndex
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly char[] EndOfLineChars;
        public LineIndex([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> LineCount { get; }
        public JetBrains.DocumentModel.DocumentCoords GetLineColByOffset(int offset) { }
        public int GetLineEndOffsetNoLineBreak(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public int GetLineEndOffsetWithLineBreak(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public int GetLineStartOffset(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetLineText(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public int GetOffsetByCoords(JetBrains.DocumentModel.DocumentCoords coords) { }
        public void UpdateByChange(JetBrains.DocumentModel.DocumentChange args) { }
        [System.Diagnostics.ConditionalAttribute("HARD_DEBUG")]
        public void Validate() { }
    }
}
namespace JetBrains.DocumentModel.impl
{
    
    public abstract class ManagedDocumentBase : JetBrains.DocumentModel.Impl.DocumentBase
    {
        protected ManagedDocumentBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Transactions.IDocumentTransactionManager documentTrancationManager, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler, JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentModel.IDocumentOwner owner) { }
        public virtual JetBrains.Text.IBuffer Buffer { get; }
        public bool IsInTemporaryState { get; }
        protected virtual void ApplyInternalDocumentChange(JetBrains.DocumentModel.DocumentChange documentChange, bool underWriteLock, int timestamp) { }
        public override void ChangeDocument(JetBrains.DocumentModel.DocumentChange documentChange, int timestamp) { }
        public override JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.Util.TextRange range, bool mapToDocument) { }
        public override void DeleteText(JetBrains.Util.TextRange fromRange, JetBrains.DocumentModel.TextModificationSide modificationSide) { }
        protected override JetBrains.DocumentModel.Impl.LineIndex GetLineIndex() { }
        public override void HandleExternalChange(JetBrains.DocumentModel.DocumentChange documentChange, int timestamp, bool underWriteLock) { }
        public void HandleExternalDocumentChange(JetBrains.DocumentModel.DocumentChange args, bool underWriteLock, int timestamp) { }
        public override void InsertText(int offset, string text, JetBrains.DocumentModel.TextModificationSide modificationSide) { }
        public override JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, bool isGreedyToLeft, bool isGreedyToRight) { }
        public override void ReplaceText(JetBrains.Util.TextRange atRange, string text) { }
    }
}
namespace JetBrains.DocumentModel.Transactions
{
    
    public class DocumentChangeInfo
    {
        public DocumentChangeInfo(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocument, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.Application.IShellLocks locks) { }
        public int ActionsCount { get; }
        public JetBrains.DocumentModel.impl.ManagedDocumentBase ManagedDocument { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentChange> ApplyChanges(JetBrains.DocumentModel.impl.ManagedDocumentBase document, bool optimizeChangesOnCommit) { }
        public JetBrains.Text.IBuffer GetBufferUnderTransaction() { }
        public JetBrains.DocumentModel.Impl.LineIndex GetLineIndex() { }
        public void MergeChanges(JetBrains.DocumentModel.Transactions.DocumentChangeInfo infoToMerge) { }
        public JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, bool isGreedyToLeft, bool isGreedyToRight, int changesCountWhenCreated) { }
        public void PushDocumentChange(JetBrains.DocumentModel.DocumentChange documentChange) { }
        public void Rollback(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction) { }
    }
    public class DocumentModificationMap
    {
        public DocumentModificationMap() { }
        public JetBrains.Util.TextRange MaxChangedRange { get; }
        public int OptimizedChangesCount { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.Transactions.DocumentModificationMap.RangePair> ReverseRanges { get; }
        public void Add(JetBrains.Util.TextRange oldRange, JetBrains.Util.TextRange newRange, JetBrains.DocumentModel.TextModificationSide modificationSide) { }
        public void Finish(JetBrains.Text.IBuffer oldBuffer, JetBrains.Text.IBuffer newBuffer) { }
        public struct RangePair
        {
            public readonly JetBrains.DocumentModel.TextModificationSide ModificationSide;
            public readonly JetBrains.Util.TextRange ModifiedRange;
            public readonly JetBrains.Util.TextRange OriginalRange;
            public RangePair(JetBrains.Util.TextRange originalRange, JetBrains.Util.TextRange modifiedRange, JetBrains.DocumentModel.TextModificationSide modificationSide) { }
            [JetBrains.Annotations.PureAttribute()]
            public JetBrains.DocumentModel.Transactions.DocumentModificationMap.RangePair Shift(int delta) { }
        }
    }
    public abstract class DocumentTransaction
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly System.Collections.Generic.Dictionary<JetBrains.DocumentModel.impl.ManagedDocumentBase, JetBrains.DocumentModel.Transactions.DocumentChangeInfo> myDirtyDocuments;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        protected DocumentTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Transactions.DocumentTransactionManager manager, JetBrains.DocumentModel.Transactions.DocumentTransaction parentTransaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, string commandName, bool optimizeChangesOnCommit, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.DocumentModel.CommandProcessing.DocumentCommandProcessor documentCommandProcessor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string CommandName { get; }
        public bool ExpectChangesFromEnsureWritable { get; }
        public bool IsCommitting { get; }
        public bool IsRollingBack { get; }
        public bool IsValid { get; }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionManager Manager { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.DocumentModel.Transactions.DocumentTransaction ParentTransaction { get; }
        public JetBrains.Util.OneToListMap<JetBrains.DocumentModel.IDocument, JetBrains.DocumentModel.Transactions.IRangeMarkerUnderTransaction> RangeMarkers { get; }
        public void AddUndoRedoHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUndoRedoHandler handler) { }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionCommitResult Commit([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.IUndoRedoHandler undoRedoHandler, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionCommitResult Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected abstract JetBrains.Util.ModificationCookie CreateEnsureWritableCoockie(out System.Collections.Generic.IList<> affectedDocuments);
        public abstract JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.Util.TextRange range, JetBrains.DocumentModel.impl.ManagedDocumentBase document);
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentChange> DoCommit(System.Collections.Generic.IDictionary<JetBrains.DocumentModel.impl.ManagedDocumentBase, JetBrains.DocumentModel.Transactions.DocumentChangeInfo> dirtyDocuments, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected virtual JetBrains.DocumentModel.Transactions.DocumentTransactionRollbackResult DoRollback() { }
        public int GetActionsCount(JetBrains.DocumentModel.impl.ManagedDocumentBase document) { }
        public JetBrains.Text.IBuffer GetBuffer(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase) { }
        public JetBrains.DocumentModel.Impl.LineIndex GetLineIndex(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase) { }
        public void HandleExternalChange(JetBrains.DocumentModel.DocumentChange documentChange) { }
        protected virtual void MergeChanges(JetBrains.DocumentModel.Transactions.DocumentTransaction childTransaction) { }
        protected void MoveRangeMarkersFromTransaction(JetBrains.DocumentModel.Transactions.IRangeMarkerUnderTransaction rangeMarker) { }
        public JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, JetBrains.DocumentModel.impl.ManagedDocumentBase document, bool isGreedyToLeft, bool isGreedyToRight, int changesCountWhenCreated) { }
        public void PushDocumentChange(JetBrains.DocumentModel.DocumentChange documentChange) { }
        protected void RegisterRangeMarker(JetBrains.DocumentModel.IDocument document, JetBrains.DocumentModel.Transactions.IRangeMarkerUnderTransaction rangeMarkerUnderTransaction) { }
        protected void ResetTransaction(JetBrains.DocumentModel.Transactions.IRangeMarkerUnderTransaction rangeMarker) { }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionRollbackResult Rollback() { }
    }
    public class DocumentTransactionCommitResult : JetBrains.DocumentModel.Transactions.DocumentTransactionResult
    {
        public DocumentTransactionCommitResult(System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> committedDocuments, JetBrains.Util.EnsureWritableResult ensureWritableResult, string ensureWritableMessage, bool succeded) { }
        public DocumentTransactionCommitResult(System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> committedDocuments, JetBrains.Util.EnsureWritableResult ensureWritableResult, string ensureWritableMessage, bool succeded, System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentChange> changes) { }
    }
    public abstract class DocumentTransactionManager : JetBrains.DocumentModel.Transactions.IDocumentTransactionManager
    {
        protected readonly JetBrains.Application.IShellLocks myLocks;
        public readonly JetBrains.DataFlow.ISimpleSignal TransactionBeginClosing;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<bool>> TransactionClosed;
        public readonly JetBrains.DataFlow.ISimpleSignal TransactionStarted;
        protected DocumentTransactionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.DocumentModel.Transactions.DocumentTransaction CurrentTransaction { get; }
        public void AssertCommittingTransaction() { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertNotUnderTransaction(string text = "Operation can not be executed under document transaction.") { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertUnderTransaction(string text = "Operation should executed under document transaction.") { }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionCommitResult CommitTransaction(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionCommitResult CommitTransaction([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.IUndoRedoHandler undoRedoHandler, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public abstract JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.DocumentModel.impl.ManagedDocumentBase document, JetBrains.Util.TextRange range, bool mapToDocument);
        protected abstract JetBrains.DocumentModel.Transactions.DocumentTransaction CreateTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction, string commandName, bool optimizeChangesOnCommit);
        public JetBrains.Util.ITransactionCookie CreateTransactionCookie(JetBrains.Util.DefaultAction defaultAction, string commandName) { }
        public JetBrains.Util.ITransactionCookie CreateTransactionCookie(JetBrains.Util.DefaultAction defaultAction, string commandName, JetBrains.Util.IUndoRedoHandler handler, bool optimizeChangesOnCommit, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool DoTransaction(string commandName, [JetBrains.Annotations.NotNullAttribute()] System.Func<bool> handler) { }
        public JetBrains.Text.IBuffer GetBuffer(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase) { }
        public JetBrains.DocumentModel.Impl.LineIndex GetLineIndex(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase) { }
        public JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, JetBrains.DocumentModel.impl.ManagedDocumentBase document, bool isGreedyToLeft, bool isGreedyToRight) { }
        public JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, JetBrains.DocumentModel.impl.ManagedDocumentBase document, bool isGreedyToLeft, bool isGreedyToRight, JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction, int changesCountWhenCreated) { }
        public JetBrains.DocumentModel.Transactions.DocumentTransactionRollbackResult RollbackTransaction() { }
        protected virtual void SaveDocumentAfterModification(JetBrains.DocumentModel.IDocument document) { }
        protected virtual void SetActiveTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction pop) { }
        public void StartTransaction(string commandName, bool optimizeChangesOnCommit = True) { }
    }
    public abstract class DocumentTransactionResult : JetBrains.Util.TransactionCommitResult
    {
        protected DocumentTransactionResult(System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> documents, JetBrains.Util.EnsureWritableResult ensureWritableResult, string ensureWritableMessage, bool succeded) { }
        protected DocumentTransactionResult(System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> documents, JetBrains.Util.EnsureWritableResult ensureWritableResult, string ensureWritableMessage, bool succeded, System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentChange> changes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentChange> Changes { get; }
        public System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> Documents { get; }
    }
    public class DocumentTransactionRollbackResult : JetBrains.DocumentModel.Transactions.DocumentTransactionResult
    {
        public DocumentTransactionRollbackResult(System.Collections.Generic.IList<JetBrains.DocumentModel.IDocument> affectedDocuments) { }
    }
    public class static DocumentTransactionUtil
    {
        public static JetBrains.DocumentModel.DocumentChange GetOptimizedChange(JetBrains.DocumentModel.DocumentChange documentChange, string oldRangeText) { }
    }
    public class DummyDocumentTransactionManager : JetBrains.DocumentModel.Transactions.IDocumentTransactionManager
    {
        public JetBrains.DocumentModel.Transactions.DocumentTransaction CurrentTransaction { get; }
        public JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.DocumentModel.impl.ManagedDocumentBase document, JetBrains.Util.TextRange range, bool mapToDocument) { }
        public JetBrains.Text.IBuffer GetBuffer(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase) { }
        public JetBrains.DocumentModel.Impl.LineIndex GetLineIndex(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase) { }
        public JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, JetBrains.DocumentModel.impl.ManagedDocumentBase document, bool isGreedyToLeft, bool isGreedyToRight) { }
    }
    public interface IDocumentTransactionManager
    {
        JetBrains.DocumentModel.Transactions.DocumentTransaction CurrentTransaction { get; }
        JetBrains.DocumentModel.IRangeMarker CreateRangeMarker(JetBrains.DocumentModel.impl.ManagedDocumentBase document, JetBrains.Util.TextRange range, bool mapToDocument);
        JetBrains.Text.IBuffer GetBuffer(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase);
        JetBrains.DocumentModel.Impl.LineIndex GetLineIndex(JetBrains.DocumentModel.impl.ManagedDocumentBase managedDocumentBase);
        JetBrains.Util.TextRange PlayChanges(JetBrains.Util.TextRange rangeBeforeTransaction, JetBrains.DocumentModel.impl.ManagedDocumentBase document, bool isGreedyToLeft, bool isGreedyToRight);
    }
    public interface IRangeMarkerUnderTransaction
    {
        void AssertIsInTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction);
        void AssertIsMovedFrom(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction);
        void MoveFromTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction);
        void MoveToTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction fromTransaction, JetBrains.DocumentModel.Transactions.DocumentTransaction toTransaction, int changesCountToAdd);
        void PlayChangesBack(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction, JetBrains.DocumentModel.DocumentChange rollbackChange, int index, int newDocumentLength);
        void ResetTransaction(JetBrains.DocumentModel.Transactions.DocumentTransaction documentTransaction);
    }
}