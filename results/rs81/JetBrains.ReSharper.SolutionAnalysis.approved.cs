[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("SWEA.FileErrors", "Solution-Wide Analysis Errors", false)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.Intentions.VB.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.SolutionAnalysisTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.IntentionsTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"SolutionAnalysisMemoryChecker, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"HighlightingTest, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.VSIntegrationTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.SolutionAnalysis
{
    
    public class AdditionalAnalysisInfo
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.FileContentInfo FileContentInfo;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.HierarchyInfo HierarchyInfo;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.UsagesInfo UsagesInfo;
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.AdditionalAnalysisInfo Build(JetBrains.ReSharper.Daemon.SolutionAnalysis.UsagesInfo usagesInfo, JetBrains.ReSharper.Daemon.SolutionAnalysis.HierarchyInfo hierarchyInfo, JetBrains.ReSharper.Daemon.SolutionAnalysis.FileContentInfo fileContentInfo) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.AdditionalAnalysisInfo ReadFrom(System.IO.BinaryReader reader, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class static CollectInspectionResults
    {
        public static bool Do(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> files, JetBrains.Application.Progress.ITaskExecutor taskExecutor, System.Action<JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuePointer> issueConsumer) { }
    }
    public class ConfigurableIssueType : JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType
    {
        public const byte IssueTypeFlag = 1;
        public ConfigurableIssueType(string configurableSeverityId, JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager) { }
        public string CompoundItemName { get; }
        public string ConfigurableSeverityId { get; }
        public string GroupId { get; }
        public string LeafPresentation { get; }
        public string Presentation { get; }
        public bool SolutionAnalysisRequired { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class static ExternalizationUtil
    {
        public static string ReadNullableString(this System.IO.BinaryReader reader) { }
        public static void WriteNullableString(this System.IO.BinaryWriter writer, string s) { }
    }
    public class FileContentInfo : JetBrains.ReSharper.Daemon.UsageChecking.IFileContentInfo
    {
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.UsageChecking.IDeclarationInfo> TopLevelDeclarations { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileContentInfo FromDaemonProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Daemon.SolutionAnalysis.FileContentInfo oldInfo) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileContentInfo ReadFrom(System.IO.BinaryReader reader, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class HierarchyInfo
    {
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.UsageChecking.ElementId> AbstractMembers;
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.UsageChecking.ElementId> InterfaceMembers;
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.MemberIdInheritanceInfo> MemberInheritances;
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.UsageChecking.ElementId> MembersCannotBeInternal;
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.TypeElementIdInheritanceInfo> TypeInheritances;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.HierarchyInfo FromDaemonProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process) { }
        public static JetBrains.ReSharper.Daemon.UsageChecking.ElementId GetMemberId(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.HierarchyInfo ReadFrom(System.IO.BinaryReader reader) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class HighlightingResult
    {
        public HighlightingResult(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file) { }
        public bool Completed { get; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, JetBrains.ReSharper.Daemon.SolutionAnalysis.StageHighlightingResult>> StageResults { get; }
        public void AddStageResult(string stageId, JetBrains.ReSharper.Daemon.SolutionAnalysis.StageHighlightingResult result, bool fullRehighlight, System.Collections.Generic.IEnumerable<JetBrains.Util.TextRange> ranges) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResult Clone() { }
        public void Complete(bool incrementalPass, out bool anythingDropped) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData> EnumerateIssueDatas() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuePointer> EnumerateIssues(JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResultsMap resultsMap, System.Func<JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuePointer, bool> predicate) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResult ReadFrom(System.IO.BinaryReader reader, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, JetBrains.ReSharper.Daemon.SolutionAnalysis.StageIdManager stageIdManager, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClasses issueClasses) { }
        public void UpdatableRanges(System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> updateFunc) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class HighlightingResultsMap : JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IUpdatableTextRangesSource, JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueSet
    {
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IgnoreChangedHandler IgnoreChanged;
        public HighlightingResultsMap(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Func<JetBrains.ProjectModel.IProjectFile, JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper> wrapperForFile) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueGroup AllIssues { get; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueGroup Errors { get; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResult this[JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file] { get; }
        public event System.Action<System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile>> FilesToBeReanalyzedChanged;
        public void AddStageResult(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, string stageId, System.Nullable<int> settingsHash, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData[] issues, bool fullRehighlight, System.Collections.Generic.IEnumerable<JetBrains.Util.TextRange> ranges) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResult CompleteResult(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, bool incrementalPass) { }
        public void FileAnalyzed(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file) { }
        public void OnIgnoreChanged(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file) { }
        public void RemoveResult(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file) { }
        public void Reset() { }
        public void ResultLoaded(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResult result) { }
        public void SetFilesToBeReanalyzed(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper> slowFiles, int totalSlowFiles, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper> filesToAnalyzeQuickly) { }
        public void UpdatableRangesInFile(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> updateFunc) { }
    }
    public delegate void IgnoreChangedHandler(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResult result);
    public interface IIssue
    {
        JetBrains.ProjectModel.IProjectFile File { get; }
        bool Ignored { get; set; }
        JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType IssueType { get; }
        bool IsValid { get; }
        string Message { get; }
        int NavigationOffset { get; }
        System.Nullable<JetBrains.Util.TextRange> Range { get; }
        JetBrains.ReSharper.Daemon.Severity GetSeverity();
        JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStore);
    }
    public interface IIssueGroup
    {
        public event System.Action<JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper> FileIssuesChanged;
        public event System.Action FilesWithIssuesChanged;
        public event System.Action IssuesChanged;
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetFilesWithIssues(bool includeIgnored = False);
        int GetFilesWithIssuesCount(bool includeIgnored = False);
        int GetIssueCount(bool includeIgnored = False);
        int GetIssueCount(JetBrains.ProjectModel.IProjectFile file, bool includeIgnored = False);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuePointer> GetIssues(bool includeIgnored = False);
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuePointer> GetIssues(JetBrains.ProjectModel.IProjectFile file, bool includeIgnored = False);
        bool IsEmpty(bool includeIgnored = False);
        void RunOperationFromNonPrimaryThread(System.Action operation);
    }
    public interface IIssueSet
    {
        JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueGroup AllIssues { get; }
        JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueGroup Errors { get; }
        int FilesToBeReanalyzedCount { get; }
        int TotalFilesToBeAnalyzed { get; }
        public event System.Action<System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile>> FilesToBeReanalyzedChanged;
        bool IsFileToBeReanalyzed(JetBrains.ProjectModel.IProjectFile file);
    }
    [System.ComponentModel.TypeConverterAttribute("JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueTypeConverter")]
    public interface IIssueType
    {
        string CompoundItemName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ConfigurableSeverityId { get; }
        string GroupId { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string LeafPresentation { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Presentation { get; }
        bool SolutionAnalysisRequired { get; }
        JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory);
        void WriteTo(System.IO.BinaryWriter writer);
    }
    public class InvisibleDocumentDaemonProcess : JetBrains.ReSharper.Daemon.Impl.DaemonProcessBase
    {
        public InvisibleDocumentDaemonProcess(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool FullRehighlightingRequired { get; }
        public void DoHighlighting() { }
        public override bool IsRangeInvalidated(JetBrains.DocumentModel.DocumentRange range) { }
    }
    public class IssueClass
    {
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType IssueType { get; }
        public int NavigationOffsetPatch { get; }
        public object ExtractFormatStringArguments(string message, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings) { }
        public string FormMessage(object arguments) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class IssueClasses
    {
        public IssueClasses() { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClass GetIssueClass(JetBrains.ReSharper.Daemon.HighlightingAttributeBase attribute, int navigationOffsetPatch) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClass GetIssueClass(JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager, JetBrains.ReSharper.Daemon.HighlightingInfo highlightingInfo) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClass ReadFrom(System.IO.BinaryReader reader, JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager) { }
    }
    public struct IssueData
    {
        public IssueData(JetBrains.Util.TextRange range, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClass issueClass, string message, bool ignored, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings) { }
        public IssueData(string message, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClass issueClass, bool ignored, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings) { }
        public bool Ignored { get; set; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType IssueType { get; }
        public bool IsValid { get; }
        public string Message { get; }
        public int NavigationOffset { get; }
        public System.Nullable<JetBrains.Util.TextRange> Range { get; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData Clone() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData other) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData ReadFrom(System.IO.BinaryReader reader, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClasses issueClasses, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public void UpdateRange(System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> updateFunc) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public struct IssuePointer : JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue
    {
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData[] Array;
        public readonly int Index;
        public IssuePointer(JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData[] array, int index, JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper fileWrapper, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.SolutionAnalysis.HighlightingResultsMap resultsMap) { }
        public JetBrains.ProjectModel.IProjectFile File { get; }
        public JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper FileWrapper { get; }
        public bool Ignored { get; set; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType IssueType { get; }
        public bool IsValid { get; }
        public string Message { get; }
        public int NavigationOffset { get; }
        public System.Nullable<JetBrains.Util.TextRange> Range { get; }
        public bool Equals(JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuePointer other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Daemon.Severity GetSeverity() { }
        public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory) { }
        public override string ToString() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class IssueStrings
    {
        public IssueStrings() { }
        public string Intern(string s) { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class IssueTypeConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType>
    {
        public IssueTypeConverter() { }
    }
    public class static IssueTypeExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType GetIssueType(this JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType GetIssueType(this JetBrains.ReSharper.Daemon.HighlightingAttributeBase attribute, JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType ReadFrom(System.IO.BinaryReader reader, JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class IssueTypesManager
    {
        public IssueTypesManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalog, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> AllIssueTypes { get; }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueTypesManager Instance { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> GetIssueTypesByCompoundItemName(string compoundItemName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> GetIssueTypesByGroupId(string groupId) { }
    }
    public struct MemberIdInheritanceInfo
    {
        public readonly JetBrains.ReSharper.Daemon.UsageChecking.ElementId BaseMemberId;
        public readonly JetBrains.ReSharper.Daemon.UsageChecking.MemberInheritanceKind InheritanceKind;
        public readonly JetBrains.ReSharper.Daemon.UsageChecking.ElementId MemberId;
        public MemberIdInheritanceInfo(JetBrains.ReSharper.Daemon.UsageChecking.MemberInheritanceInfo info) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.MemberIdInheritanceInfo ReadFrom(System.IO.BinaryReader reader) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class OverridenSeverityIssueType : JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType
    {
        public const byte IssueTypeFlag = 2;
        public OverridenSeverityIssueType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType issueType, JetBrains.ReSharper.Daemon.Severity overridenSeverity) { }
        public string CompoundItemName { get; }
        public string ConfigurableSeverityId { get; }
        public string GroupId { get; }
        public string LeafPresentation { get; }
        public string Presentation { get; }
        public bool SolutionAnalysisRequired { get; }
        protected bool Equals(JetBrains.ReSharper.Daemon.SolutionAnalysis.OverridenSeverityIssueType other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionAnalysisManager : System.IDisposable
    {
        public const string FileErrorsGroup = "SWEA.FileErrors";
        public SolutionAnalysisManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImagesManager fileImagesManager, JetBrains.ReSharper.Daemon.SolutionAnalysis.StageIdManager stageIdManager, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClasses issueClasses, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ProjectModel.ProjectModelElementPointerManager projectModelElementPointerManager, JetBrains.ReSharper.Daemon.Impl.DaemonAutoDisableStrategy autoDisableStrategy) { }
        public bool AnalysisComplete { get; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueSet IssueSet { get; }
        public bool Loaded { get; }
        public bool Paused { get; set; }
        public JetBrains.ReSharper.Psi.IPsiConfiguration PsiConfiguration { get; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.StageIdManager StageIdManager { get; }
        public event System.Action AnalysisCompleteChanged;
        public event System.Action<JetBrains.ProjectModel.IProjectFile> FileAnalyzed;
        public event System.Action OnLoaded;
        public event System.Action OnPausedChanged;
        public void AllFilesAnalyzed() { }
        public void AnalysisCompleted([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile file, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Psi.Dependencies.DependencySet dependencies, bool analysisSupported, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public void AnalysisStageCompleted(JetBrains.ProjectModel.IProjectFile file, System.Type stageType, System.Nullable<int> settingsHash, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.HighlightingInfo> highlightings, bool fullRehighlight, System.Collections.Generic.IEnumerable<JetBrains.Util.TextRange> ranges, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData[] BuildIssues(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.HighlightingInfo> highlightings, JetBrains.ProjectModel.IProjectFile file, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, out JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper projectFileWrapper) { }
        public bool CheckCanLoad() { }
        public void CompactDataStructures() { }
        public bool FetchGlobalUsageAnalysisData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file, out JetBrains.ReSharper.Daemon.UsageChecking.IGlobalUsageChecker usageChecker, out JetBrains.ReSharper.Daemon.UsageChecking.IFileContentInfo fileContentInfo) { }
        public void FilePartlyReanalyzed(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetFilesToAnalyze() { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.SolutionAnalysisManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public bool Load() { }
        public void ReanalyzeAll() { }
        public void ReanalyzeFile(JetBrains.ProjectModel.IProjectFile file) { }
        public void ReanalyzeIfSettingsChanged(JetBrains.ProjectModel.IProjectFile file) { }
        public void RegisterUpdatableTextRangesSource(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IUpdatableTextRangesSource source) { }
        public void Unload() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class SolutionAnalysisServiceImpl : JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisService
    {
        public SolutionAnalysisServiceImpl(JetBrains.ReSharper.Daemon.SolutionAnalysis.SolutionAnalysisManager analysisManager, JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisIndicator solutionAnalysisIndicator, JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImagesManager fileImagesManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Psi.Dependencies.DependencyStore dependencyStore, JetBrains.ReSharper.Daemon.Impl.DaemonAutoDisableStrategy daemonAutoDisableStrategy, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.GeneratedCode.DaemonExcludedFilesManager daemonExcludedFiles) { }
        public override bool AnalysisComplete { get; set; }
        public override bool Loaded { get; }
        public override bool Paused { get; }
        public override JetBrains.ReSharper.Daemon.UsageChecking.IGlobalUsageChecker UsageChecker { get; }
        public override void AllFilesAnalyzed() { }
        public override void AnalysisCompleted(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.ReSharper.Psi.Dependencies.DependencySet dependencies, bool analysisSupported, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public override void AnalysisStageCompleted(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Daemon.IDaemonStage stage, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.HighlightingInfo> highlightings, bool fullRehighlight, System.Collections.Generic.IEnumerable<JetBrains.Util.TextRange> ranges, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public override void AnalyzeInvisibleFile(JetBrains.ProjectModel.IProjectFile file) { }
        public override bool CheckCanLoad() { }
        public override void CompactDataStructures() { }
        public override bool FetchGlobalUsageAnalysisData(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, out JetBrains.ReSharper.Daemon.UsageChecking.IGlobalUsageChecker usageChecker, out JetBrains.ReSharper.Daemon.UsageChecking.IFileContentInfo fileContentInfo) { }
        public override void FilePartlyReanalyzed(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public override System.Nullable<JetBrains.ReSharper.Daemon.UsageChecking.ElementId> GetElementId(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> GetFilesToAnalyze(JetBrains.ReSharper.Daemon.IInterruptable interruptable) { }
        public override JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisService.FileImagesCacheInitializationResult InitializeFileImagesCache() { }
        public override bool Load() { }
        public override void NavigateInErrorsView(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool ShowEnablingAnalysisWarning(System.Windows.Forms.IWin32Window parent) { }
        public override void Unload() { }
    }
    public class StageHighlightingResult
    {
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData[] Issues;
        public readonly System.Nullable<int> SettingsHash;
        public StageHighlightingResult(JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueData[] issues, System.Nullable<int> settingsHash) { }
        public bool IsEmpty { get; }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.StageHighlightingResult ReadFrom(System.IO.BinaryReader reader, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueStrings issueStrings, JetBrains.ReSharper.Daemon.SolutionAnalysis.IssueClasses issueClasses, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public void UpdatableRanges(System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> updateFunc) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StageIdManager
    {
        public StageIdManager() { }
        public string InternId(string id) { }
        public string StageId(System.Type stageType) { }
    }
    public class StaticIssueType : JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType
    {
        public const byte IssueTypeFlag = 0;
        public StaticIssueType(JetBrains.ReSharper.Daemon.Severity staticSeverity, string groupId, [JetBrains.Annotations.CanBeNullAttribute()] string title) { }
        public string CompoundItemName { get; }
        public string ConfigurableSeverityId { get; }
        public string GroupId { get; }
        public string LeafPresentation { get; }
        public string Presentation { get; }
        public bool SolutionAnalysisRequired { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SweaSuppressor
    {
        public SweaSuppressor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder builder, JetBrains.ReSharper.Daemon.SolutionAnalysis.SolutionAnalysisManager solutionAnalysisManager) { }
    }
    public struct TypeElementIdInheritanceInfo
    {
        public readonly JetBrains.ReSharper.Daemon.UsageChecking.ElementId BaseTypeElementId;
        public readonly JetBrains.ReSharper.Daemon.UsageChecking.ElementId TypeElementId;
        public TypeElementIdInheritanceInfo(JetBrains.ReSharper.Daemon.UsageChecking.ElementId typeElementId, JetBrains.ReSharper.Daemon.UsageChecking.ElementId baseTypeElementId) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.TypeElementIdInheritanceInfo ReadFrom(System.IO.BinaryReader reader) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class UsagesInfo
    {
        public readonly JetBrains.Util.ReadOnlyDictionary<JetBrains.ReSharper.Daemon.UsageChecking.ElementId, JetBrains.ReSharper.Daemon.UsageChecking.UsageState> ElementsUsed;
        public UsagesInfo(System.Collections.Generic.IDictionary<JetBrains.ReSharper.Daemon.UsageChecking.ElementId, JetBrains.ReSharper.Daemon.UsageChecking.UsageState> elementsUsed) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.UsagesInfo FromDaemonProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.UsagesInfo ReadFrom(System.IO.BinaryReader reader) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages
{
    
    public class DependencyToHashMap : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>>, System.Collections.Generic.IDictionary<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>>, System.Collections.IEnumerable
    {
        public DependencyToHashMap() { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public JetBrains.ReSharper.Psi.Dependencies.Hash this[JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency key] { get; set; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency> Keys { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Dependencies.Hash> Values { get; }
        public void Add(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency key, JetBrains.ReSharper.Psi.Dependencies.Hash value) { }
        public void Add(System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash> item) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash> item) { }
        public bool ContainsKey(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency key) { }
        public void CopyTo(System.Collections.Generic.KeyValuePair<, >[] array, int arrayIndex) { }
        public JetBrains.Util.DataStructures.ConvertedEnumerator<System.Collections.Generic.KeyValuePair<int, int>, System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>> GetEnumerator() { }
        public bool Remove(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency key) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash> item) { }
        public bool TryGetValue(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency key, out JetBrains.ReSharper.Psi.Dependencies.Hash value) { }
    }
    public class FileImage
    {
        public FileImage(JetBrains.ReSharper.Psi.Modules.IPsiModule module, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Dependencies.Hash>>> dependencyToHashes) { }
        public FileImage(JetBrains.ReSharper.Psi.Modules.IPsiModule module, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Dependencies.Hash>>> dependencyToHashes, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.NamespaceDependency, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Dependencies.Hash>>> namespaceDependencyToHashes, System.Collections.Generic.ICollection<string> emptyNamespaceDeclarations, System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.UsingsForType> usings, System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.ModulePropertyValue> propertyDependencies) { }
        public FileImage(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Dependencies.Hash>>> dependencyToHashes) { }
        public int DependenciesAndHashesId { get; }
        public JetBrains.ReSharper.Psi.Dependencies.MetaModuleId MetaModuleId { get; }
        public string ModuleId { get; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.NamespaceDependency, JetBrains.ReSharper.Psi.Dependencies.Hash>> NamespaceDependencyToHash { get; }
        public System.Collections.Generic.IEnumerable<string> NamespacesDeclared { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.UsingsForType> Usings { get; }
        public bool CheckForModulePropertiesChange(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        protected override void Finalize() { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImage ReadData(System.IO.BinaryReader reader, JetBrains.ProjectModel.ISolution solution) { }
        public void TestDump(System.IO.TextWriter builder) { }
        public void WriteData(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FileImagesBuilder
    {
        public FileImagesBuilder(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Dependencies.IFileImageContributor> fileImageContributors, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Psi.Dependencies.DependencyFactory dependencyFactory) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.ImagesData BuildImagesData(JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.ImagesData BuildImagesData(JetBrains.ReSharper.Psi.IPsiAssembly assembly, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool ShouldBuildImageData(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class FileImagesManager : JetBrains.Application.IChangeProvider, JetBrains.ReSharper.Psi.Caches.ICache, JetBrains.ReSharper.Psi.Caches.ISwitchingCache, System.IDisposable
    {
        public bool DisableFlushChanges;
        public FileImagesManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Dependencies.DependencyFactory dependencyFactory, JetBrains.ReSharper.Daemon.IDaemonThread daemonThread, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImagesBuilder imagesBuilder, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager, JetBrains.Application.ChangeManager changeManager) { }
        public JetBrains.DataFlow.IProperty<bool> Active { get; }
        public bool CheckThread { get; set; }
        public bool HasChangesToFlush { get; }
        public bool HasDirtyFiles { get; }
        public bool Loaded { get; set; }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.UsingsInfoCache UsingsInfoCache { get; }
        public void Dispose() { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public JetBrains.ReSharper.Psi.Dependencies.DependencySet FlushChanges(out bool everythingChanged) { }
        public JetBrains.ReSharper.Psi.Dependencies.DependencySet FlushChanges(JetBrains.ReSharper.Daemon.IInterruptable interruptable, out bool everythingChanged) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Dependencies.Hash> GetHashesForDependencies(System.Collections.Generic.ICollection<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency> dependencies) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash GetHashForDependency(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency dependency) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash GetHashForUsingsDependency(JetBrains.ReSharper.Psi.Dependencies.UsingsDependency dependency) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImagesManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public string GetStatistics() { }
        public JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisService.FileImagesCacheInitializationResult Initialize() { }
        public void MarkAsDirty(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Release() { }
        public void Save(JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public void TestDump(System.IO.TextWriter builder) { }
        public void UnloadIfInitialized() { }
    }
    public class ImagesData
    {
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImage[] Images;
        public readonly long Timestamp;
        public ImagesData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.FileImage[] images, long timestamp) { }
    }
    public class LightUsingsInfo
    {
        public LightUsingsInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo usingsInfo) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash Hash { get; }
        public int Id { get; }
        public JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo GetUsingsInfo() { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.LightUsingsInfo ReadFrom(System.IO.BinaryReader reader, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public struct ModulePropertyValue
    {
        public readonly JetBrains.ReSharper.Psi.Dependencies.ModuleProperty Property;
        public readonly JetBrains.ReSharper.Psi.Dependencies.Hash ValueHash;
        public ModulePropertyValue(JetBrains.ReSharper.Psi.Dependencies.ModuleProperty property, JetBrains.ReSharper.Psi.Dependencies.Hash valueHash) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.ModulePropertyValue ReadFrom(System.IO.BinaryReader reader) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class NamespaceDependency
    {
        public readonly bool HasAnythingInternal;
        public readonly string QualfierNamespaceName;
        public NamespaceDependency(string qualfierNamespaceName, string name, bool hasAnythingInternal) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.NamespaceDependency ReadFrom(System.IO.BinaryReader reader) { }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency ToDependency(JetBrains.ReSharper.Psi.Dependencies.DependencyFactory dependencyFactory, JetBrains.ReSharper.Psi.Dependencies.MetaModuleId moduleId) { }
        public override string ToString() { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class static ThreadingEx
    {
        public static void ExecutePooledEx(this JetBrains.Threading.IThreading threading, System.Action action) { }
    }
    public class UsingsForType
    {
        public UsingsForType(JetBrains.ReSharper.Psi.Dependencies.UsingsTypeInfo typeInfo, JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.LightUsingsInfo usingsInfo) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.LightUsingsInfo LightUsingsInfo { get; }
        public JetBrains.ReSharper.Psi.Dependencies.UsingsTypeInfo Type { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.UsingsForType ReadFrom(System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.Dependencies.NumberToModuleTable table, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteTo(System.IO.BinaryWriter writer, JetBrains.ReSharper.Psi.Dependencies.ModuleToNumberTable table) { }
    }
    public class UsingsInfoCache : JetBrains.ReSharper.Psi.Util.Caches.AbstractPersistentCache<int, JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo>
    {
        public UsingsInfoCache(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration) { }
        protected override JetBrains.Util.FileSystemPath CacheDirectory { get; }
        protected override bool CheckTotalConsistency { get; }
        protected override int FormatVersion { get; }
        protected override string LoadSaveProgressText { get; }
        public int AddInfo(JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo info) { }
        public void CleanUp(System.Collections.Generic.JetHashSet<int> actualIds) { }
        protected override void DataLoaded(int key, JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo data, bool keyValid, out System.Action waitToContinue) { }
        protected override System.IDisposable DataLock() { }
        protected override bool IsKeyValid(int key) { }
        protected override JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo ReadData(System.IO.BinaryReader reader, int key) { }
        protected override bool ReadKey(System.IO.BinaryReader reader, out int key) { }
        protected override void WriteData(System.IO.BinaryWriter writer, int key, JetBrains.ReSharper.Psi.Dependencies.IUsingsInfo info) { }
        protected override void WriteKey(System.IO.BinaryWriter writer, int key) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class UsingsInfoFactoryManager
    {
        public UsingsInfoFactoryManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.Dependencies.IUsingsInfoFactory> factories) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.FileImages.UsingsInfoFactoryManager Instance { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Dependencies.IUsingsInfoFactory FactoryById(string id) { }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuesSerializer
{
    
    public class IssuesReportReader
    {
        public IssuesReportReader(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuesSerializer.IssuesReportReader.Data GetData() { }
        public void Load(System.IO.Stream stream) { }
        public static JetBrains.ReSharper.Daemon.SolutionAnalysis.IssuesSerializer.IssuesReportReader.Data LoadFromFile(JetBrains.ProjectModel.ISolution solution, JetBrains.Util.FileSystemPath path) { }
        public class Data
        {
            public Data(JetBrains.DataStructures.ImmutableArray<JetBrains.ProjectModel.IProjectModelElement> scope, JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> issueTypes, JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue> issues) { }
            public JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue> Issues { get; }
            public JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> IssueTypes { get; }
            public JetBrains.DataStructures.ImmutableArray<JetBrains.ProjectModel.IProjectModelElement> Scope { get; }
        }
        public class IssuesReportIssue : JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue
        {
            public IssuesReportIssue(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.TextRange range, string message, JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType issueType) { }
            public JetBrains.ProjectModel.IProjectFile File { get; }
            public bool Ignored { get; set; }
            public JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType IssueType { get; }
            public bool IsValid { get; }
            public string Message { get; }
            public int NavigationOffset { get; }
            public System.Nullable<JetBrains.Util.TextRange> Range { get; set; }
            public JetBrains.ReSharper.Daemon.Severity GetSeverity() { }
            public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStore) { }
            public void UpdateRange(System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> updateFunc) { }
        }
        public class IssuesReportIssueType : JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType
        {
            public IssuesReportIssueType(string id, string groupId, JetBrains.ReSharper.Daemon.Severity severity, string description) { }
            public string CompoundItemName { get; }
            public string ConfigurableSeverityId { get; }
            public string GroupId { get; }
            public string LeafPresentation { get; }
            public string Presentation { get; }
            public bool SolutionAnalysisRequired { get; }
            public JetBrains.ReSharper.Daemon.Severity GetSeverity(System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> settingsStoreFactory) { }
            public void WriteTo(System.IO.BinaryWriter writer) { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class IssuesReportWriter
    {
        public IssuesReportWriter(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Explanatory.ICodeInspectionWikiDataProvider inspectionWikiData, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public void WriteReport(JetBrains.Application.Progress.IProgressIndicator progress, System.IO.Stream writer, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectModelElement> scope, System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue> issues) { }
        public void WriteReport(JetBrains.Application.Progress.IProgressIndicator progress, System.IO.Stream writer, JetBrains.Util.FileSystemPath baseDirectory, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectModelElement> scope, System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue> issues, System.Version toolVersion = null) { }
    }
}