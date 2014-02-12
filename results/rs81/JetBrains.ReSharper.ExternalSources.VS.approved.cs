[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.ExternalSources.VS.resources.Actions.xml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.ExternalSources.VS
{
    
    [System.Runtime.InteropServices.GuidAttribute("87DFC8DA-67B4-4954-BB89-6A277A50BAFC")]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(4160)]
    public interface Debugger3 : EnvDTE.Debugger, EnvDTE80.Debugger2
    {
        [System.Runtime.InteropServices.DispIdAttribute(111)]
        [get: System.Runtime.InteropServices.DispIdAttribute(111)]
        new EnvDTE.Breakpoints AllBreakpointsLastHit { get; }
        [System.Runtime.InteropServices.DispIdAttribute(110)]
        [get: System.Runtime.InteropServices.DispIdAttribute(110)]
        new EnvDTE.Breakpoint BreakpointLastHit { get; }
        [System.Runtime.InteropServices.DispIdAttribute(100)]
        [get: System.Runtime.InteropServices.DispIdAttribute(100)]
        new EnvDTE.Breakpoints Breakpoints { get; }
        [System.Runtime.InteropServices.DispIdAttribute(102)]
        [get: System.Runtime.InteropServices.DispIdAttribute(102)]
        new EnvDTE.dbgDebugMode CurrentMode { get; }
        [System.Runtime.InteropServices.DispIdAttribute(103)]
        [get: System.Runtime.InteropServices.DispIdAttribute(103)]
        [set: System.Runtime.InteropServices.DispIdAttribute(103)]
        new EnvDTE.Process CurrentProcess { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(104)]
        [get: System.Runtime.InteropServices.DispIdAttribute(104)]
        [set: System.Runtime.InteropServices.DispIdAttribute(104)]
        new EnvDTE.Program CurrentProgram { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(106)]
        [get: System.Runtime.InteropServices.DispIdAttribute(106)]
        [set: System.Runtime.InteropServices.DispIdAttribute(106)]
        new EnvDTE.StackFrame CurrentStackFrame { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(105)]
        [get: System.Runtime.InteropServices.DispIdAttribute(105)]
        [set: System.Runtime.InteropServices.DispIdAttribute(105)]
        new EnvDTE.Thread CurrentThread { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(112)]
        [get: System.Runtime.InteropServices.DispIdAttribute(112)]
        new EnvDTE.Processes DebuggedProcesses { get; }
        [System.Runtime.InteropServices.DispIdAttribute(200)]
        [get: System.Runtime.InteropServices.DispIdAttribute(200)]
        new EnvDTE.DTE DTE { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2101)]
        [get: System.Runtime.InteropServices.DispIdAttribute(2101)]
        object ExceptionGroups { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2100)]
        [get: System.Runtime.InteropServices.DispIdAttribute(2100)]
        [set: System.Runtime.InteropServices.DispIdAttribute(2100)]
        bool ForceContinue { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(107)]
        [get: System.Runtime.InteropServices.DispIdAttribute(107)]
        [set: System.Runtime.InteropServices.DispIdAttribute(107)]
        new bool HexDisplayMode { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(108)]
        [get: System.Runtime.InteropServices.DispIdAttribute(108)]
        [set: System.Runtime.InteropServices.DispIdAttribute(108)]
        new bool HexInputMode { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(101)]
        [get: System.Runtime.InteropServices.DispIdAttribute(101)]
        new EnvDTE.Languages Languages { get; }
        [System.Runtime.InteropServices.DispIdAttribute(109)]
        [get: System.Runtime.InteropServices.DispIdAttribute(109)]
        new EnvDTE.dbgEventReason LastBreakReason { get; }
        [System.Runtime.InteropServices.DispIdAttribute(113)]
        [get: System.Runtime.InteropServices.DispIdAttribute(113)]
        new EnvDTE.Processes LocalProcesses { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2105)]
        [get: System.Runtime.InteropServices.DispIdAttribute(2105)]
        bool OnlyLoadSymbolsManually { get; }
        [System.Runtime.InteropServices.DispIdAttribute(201)]
        [get: System.Runtime.InteropServices.DispIdAttribute(201)]
        new EnvDTE.DTE Parent { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2104)]
        [get: System.Runtime.InteropServices.DispIdAttribute(2104)]
        string SymbolCachePath { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2102)]
        [get: System.Runtime.InteropServices.DispIdAttribute(2102)]
        string SymbolPath { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2103)]
        [get: System.Runtime.InteropServices.DispIdAttribute(2103)]
        string SymbolPathState { get; }
        [System.Runtime.InteropServices.DispIdAttribute(1101)]
        [get: System.Runtime.InteropServices.DispIdAttribute(1101)]
        new EnvDTE80.Transports Transports { get; }
        [System.Runtime.InteropServices.DispIdAttribute(7)]
        new void Break(bool WaitForBreakMode = True);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        new void DetachAll();
        [System.Runtime.InteropServices.DispIdAttribute(11)]
        new void ExecuteStatement(string Statement, int Timeout = -1, bool TreatAsExpression = False);
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        new EnvDTE.Expression GetExpression(string ExpressionText, bool UseAutoExpandRules = False, int Timeout = -1);
        [System.Runtime.InteropServices.DispIdAttribute(1004)]
        new EnvDTE.Expression GetExpression2(string ExpressionText, bool UseAutoExpandRules = False, bool TreatAsStatement = False, int Timeout = -1);
        [System.Runtime.InteropServices.DispIdAttribute(1003)]
        new EnvDTE.Processes GetProcesses(EnvDTE80.Transport pTransport, string TransportQualifier);
        [System.Runtime.InteropServices.DispIdAttribute(6)]
        new void Go(bool WaitForBreakOrEnd = True);
        [System.Runtime.InteropServices.DispIdAttribute(10)]
        new void RunToCursor(bool WaitForBreakOrEnd = True);
        [System.Runtime.InteropServices.DispIdAttribute(9)]
        new void SetNextStatement();
        [System.Runtime.InteropServices.DispIdAttribute(3100)]
        void SetSymbolSettings(string SymbolPath, string SymbolPathState, string SymbolCachePath, bool OnlyLoadSymbolsManually, bool LoadSymbolsNow);
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        new void StepInto(bool WaitForBreakOrEnd = True);
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        new void StepOut(bool WaitForBreakOrEnd = True);
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        new void StepOver(bool WaitForBreakOrEnd = True);
        [System.Runtime.InteropServices.DispIdAttribute(8)]
        new void Stop(bool WaitForDesignMode = True);
        [System.Runtime.InteropServices.DispIdAttribute(300)]
        new void TerminateAll();
        [System.Runtime.InteropServices.DispIdAttribute(1001)]
        new void WriteMinidump(string FileName, EnvDTE80.dbgMinidumpOption Option);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesActivatorVs
    {
        public ExternalSourcesActivatorVs(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.IShellLocks shellLocks) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OutputPanelLogger
    {
        public OutputPanelLogger(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow> vsOutputWindow, JetBrains.Threading.IThreading threading) { }
        public void Log(string message) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PdbSpecificLoggerVs : JetBrains.Symbols.DefaultPdbSpecificLogger
    {
        public PdbSpecificLoggerVs(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.StatusBar.IStatusBar statusBar, JetBrains.ReSharper.ExternalSources.VS.OutputPanelLogger outputPanelLogger) { }
        public override void LogFailure(string format, params object[] args) { }
        public override void LogInformation(string format, params object[] args) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PdbVsOptionsBinder
    {
        public PdbVsOptionsBinder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Symbols.SourcesCache sourcesCache, JetBrains.Symbols.SymbolsCache.AppSpecificSymbolsCache appSpecificSymbolsCache, EnvDTE.DTE dte, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger2> vsDebugger, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.Application.IShellLocks shellLocks, JetBrains.VsIntegration.Settings.VsToolsOptionsMonitor vsToolsOptionsMonitor) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetDebugSourceFiles() { }
    }
}