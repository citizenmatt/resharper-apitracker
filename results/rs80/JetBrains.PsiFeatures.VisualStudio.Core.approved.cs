[assembly: JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute("dotTraceProfilingTool", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "dotTraceProfilingTool", "dotTraceProfilingTool", JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute.Recursive.No, false)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "PathMappingRuleDelete1",
        "PathMappingRuleDelete2",
        "PathMappingRuleCreate",
        "PathMappingRuleIgnore",
        "PathMappingRuleSubstitute"}, IconPackResourceIdentification="JetBrains.PsiFeatures.VisualStudio.Core;component/Src/ProjectModel/PropertiesExte" +
    "nder/WebProperties/UI/PathMappingControlIcons/ThemedIcons.PathMappingControl.Gen" +
    "erated.Xaml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Ignore",
        "GeneralOptionsPage",
        "RuleDelete2",
        "RuleCreate",
        "Substitute",
        "RuleDelete1",
        "NewFolder"}, IconPackResourceIdentification="JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
    "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-features-visual-studio-core", "JetBrains.PsiFeatures.VisualStudio.Core.Resources")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-path-mapping-control", "JetBrains.PsiFeatures.VisualStudio.Core.Src.ProjectModel.PropertiesExtender.WebPr" +
    "operties.UI")]

namespace JetBrains.PsiFeatures.VisualStudio.Core.Actions.DataRules
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsCodeModelDataRules
    {
        public VsCodeModelDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionman, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsObjBrowser> vsObjBrowser, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsClassView> vsClassView, JetBrains.Threading.IThreading threading, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, JetBrains.VsIntegration.ProjectModel.VSSolutionManager vsSolutionManager) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> DeclaredElementsFromVsWindow(JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame vsWindowFrame, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsClassView> vsClassView, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsObjBrowser> vsObjBrowser, JetBrains.VsIntegration.ProjectModel.VSSolutionManager vsSolutionManager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsResourceDesignerDataRules
    {
        public VsResourceDesignerDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts contexts, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class DumpActivityTrackingTimingActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class static Dumper
    {
        public static void DumpToFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionHandler action, System.Action<System.IO.StreamWriter> writer) { }
        public static void DumpToNotepad(System.Action<System.IO.StreamWriter> writer) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "DumpProjectResolveContexts"})]
    public class DumpProjectResolveContexts : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class GenerateNewFolderActionWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow
    {
        public JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup ActionGroup { get; }
        public string ActionId { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public double Order { get; }
        public string ShortActionId { get; }
        public string Title { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsEnabled(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateNewFolderItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ActivityTracking
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ConfigurationActivityTrackingProvider : JetBrains.Application.ActivityTrackingNew.IActivityTrackingStatisticsProvider
    {
        public ConfigurationActivityTrackingProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainWindow) { }
        public void GetActivityStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Daemon
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class VSVBIdentifierTooltipProvider : JetBrains.ReSharper.Daemon.VB.Stages.VBIdentifierTooltipProvider, Microsoft.VisualStudio.Shell.Interop.IVsDebuggerEvents
    {
        public VSVBIdentifierTooltipProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter presenter, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger> vsDebugger, JetBrains.Threading.IThreading threading) { }
        public override string GetTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ExternalSources
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExternalSourcesDebugInfoVsDebugger : JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public ExternalSourcesDebugInfoVsDebugger(JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger2> vsDebugger2) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Features.Clipboard
{
    
    public class ClipboardForm : JetBrains.CommonControls.FormBase
    {
        public ClipboardForm(System.Collections.Generic.IEnumerable<System.Windows.Forms.IDataObject> clipboardEntries, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.IDataObject SelectedData { get; }
        protected override void Dispose(bool disposing) { }
        protected override void OnShown(System.EventArgs e) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FileSystemTracker
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsFileSystemTrackerAutoCommitSuppresserWhenBuildIsRunning
    {
        public VsFileSystemTrackerAutoCommitSuppresserWhenBuildIsRunning(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder solutionBuilder) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.CSharp
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupCSharp : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.CSharp.ICSharpAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.CSharp.IVsSettingCSharpAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.CSharp.IVsSettingCSharpParameterInfoOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupCSharp(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public interface ICSharpAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
    public interface IVsSettingCSharpAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingCSharpParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CSharpLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.CSharpProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.CSharp.IVsSettingCSharpAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.CSharp.IVsSettingCSharpParameterInfoOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        public CSharpLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        protected override bool HasVsIntellisenseInProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.CssProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Css.IVsSettingCssAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Css.IVsSettingCssParameterInfoOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        public CssLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        protected override bool HasVsIntellisenseInProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class HasActiveTextControlWithReSharperAutomaticIntellisenceBase<TAutomaticCompletionIsSupported> : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
        where TAutomaticCompletionIsSupported :  class, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported
    {
        protected HasActiveTextControlWithReSharperAutomaticIntellisenceBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.DataFlow.IProperty<bool> PropertyIsOverridden { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.HtmlProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlParameterInfoOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        public HtmlLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
    }
    public interface IAutomaticCompletionIsSupported
    {
        bool IsSupported(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
    }
    public interface IVsSettingOverrider
    {
        JetBrains.DataFlow.IProperty<bool> PropertyIsOverridden { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.JavaScriptProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptParameterInfoOverrider
    {
        public JavaScriptLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        protected override bool HasVsIntellisenseInProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public abstract class LookupIsShownEnabledBase<TProjectFileType>
        where TProjectFileType : JetBrains.ProjectModel.ProjectFileType
    {
        protected LookupIsShownEnabledBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public JetBrains.DataFlow.IProperty<bool> PropertyIsOverridden { get; }
        protected virtual bool HasVsIntellisenseInProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.MSBuildProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.MSBuild.IVsSettingMSBuildAutocompletionOverrider
    {
        public MSBuildLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.VBProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VB.IVsSettingVBAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VB.IVsSettingVBParameterInfoOverrider
    {
        public VBLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        protected override bool HasVsIntellisenseInProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VSAutoformatSettings : JetBrains.ReSharper.Feature.Services.Options.HostAutoFormatSettings
    {
        public VSAutoformatSettings(JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VSFormatSettingsSynchronizer vsFormatSettingsSynchronizer) { }
        public override bool PrettyListingIsEnabled { get; }
        public override void DisableAutoFormat(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VSFormatSettingsSynchronizer
    {
        public VSFormatSettingsSynchronizer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, EnvDTE.DTE dte, JetBrains.VsIntegration.Settings.VsToolsOptionsMonitor vsToolsOptionsMonitor) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Override VS autocompletion setting")]
    public class VsSavedAutocompletionValueSetting
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Override Intellisense")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsValueOldValue> OverrideIntellisense;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Override Parameter Info")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsValueOldValue> OverrideParameterInfo;
    }
    public abstract class VsSettingOverrideAutocompletionBase<TVsSettingOverrider> : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideBase<TVsSettingOverrider>
        where TVsSettingOverrider :  class, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        protected VsSettingOverrideAutocompletionBase(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<TVsSettingOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSavedAutocompletionValueSetting, JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsValueOldValue>>> Key { get; }
        protected override bool EnableSetting(bool enable) { }
        protected abstract System.Guid LangaugeGuid();
    }
    public abstract class VsSettingOverrideBase<TVsSettingOverrider>
        where TVsSettingOverrider :  class, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        protected VsSettingOverrideBase(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<TVsSettingOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager) { }
        protected abstract System.Linq.Expressions.Expression<System.Func<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSavedAutocompletionValueSetting, JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsValueOldValue>>> Key { get; }
        protected abstract string NameOfKey { get; }
        protected JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> TextManager { get; }
        protected abstract bool EnableSetting(bool enable);
    }
    public abstract class VsSettingOverrideParameterInfoBase<TVsSettingOverrider> : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideBase<TVsSettingOverrider>
        where TVsSettingOverrider :  class, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        protected VsSettingOverrideParameterInfoBase(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<TVsSettingOverrider> overriders, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSavedAutocompletionValueSetting, JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsValueOldValue>>> Key { get; }
        protected override bool EnableSetting(bool enable) { }
        protected abstract System.Guid LangaugeGuid();
    }
    public enum VsValueOldValue
    {
        NotOverridden = 0,
        OverriddenFalse = 1,
        OverriddenTrue = 2,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XamlLookupIsShownEnabled : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.LookupIsShownEnabledBase<JetBrains.ProjectModel.XamlProjectFileType>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Xaml.IVsSettingXamlAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Xaml.IVsSettingXamlParameterInfoOverrider
    {
        public XamlLookupIsShownEnabled(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Css
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupCss : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Css.ICssAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Css.IVsSettingCssAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Css.IVsSettingCssParameterInfoOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupCss(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public interface ICssAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
    public interface IVsSettingCssAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingCssParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupHtml : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IHtmlAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlParameterInfoOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupHtml(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public interface IHtmlAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
    public interface IVsSettingHtmlAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingHtmlParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideAutocompletionHtml : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideAutocompletionBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlAutocompletionOverrider>
    {
        public VsSettingOverrideAutocompletionHtml(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlAutocompletionOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideParameterInfoHtml : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideParameterInfoBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlParameterInfoOverrider>
    {
        public VsSettingOverrideParameterInfoHtml(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Html.IVsSettingHtmlParameterInfoOverrider> overriders, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupJavaScript : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IJavaScriptAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptParameterInfoOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupJavaScript(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public interface IJavaScriptAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
    public interface IVsSettingJavaScriptAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingJavaScriptParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideAutocompletionJavaScript : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideAutocompletionBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptAutocompletionOverrider>
    {
        public VsSettingOverrideAutocompletionJavaScript(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptAutocompletionOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideParameterInfoJavaScript : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideParameterInfoBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptParameterInfoOverrider>
    {
        public VsSettingOverrideParameterInfoJavaScript(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.JavaScript.IVsSettingJavaScriptParameterInfoOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.MSBuild
{
    
    public interface IVsSettingMSBuildAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideAutocompletionMSBuild : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideAutocompletionBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.MSBuild.IVsSettingMSBuildAutocompletionOverrider>
    {
        public VsSettingOverrideAutocompletionMSBuild(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.MSBuild.IVsSettingMSBuildAutocompletionOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupTypeScript : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.ITypeScriptAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.IVsSettingTypeScriptAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.IVsSettingTypeScriptParameterInfoOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupTypeScript(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public interface ITypeScriptAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
    public interface IVsSettingTypeScriptAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingTypeScriptParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideAutocompletionTypeScript : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideAutocompletionBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.IVsSettingTypeScriptAutocompletionOverrider>
    {
        public VsSettingOverrideAutocompletionTypeScript(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.IVsSettingTypeScriptAutocompletionOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSettingOverrideParameterInfoTypeScript : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VsSettingOverrideParameterInfoBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.IVsSettingTypeScriptParameterInfoOverrider>
    {
        public VsSettingOverrideParameterInfoTypeScript(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.TypeScript.IVsSettingTypeScriptParameterInfoOverrider> overriders, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> textManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override string NameOfKey { get; }
        protected override System.Guid LangaugeGuid() { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VB
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupVB : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VB.IVBAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VB.IVsSettingVBAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.VB.IVsSettingVBParameterInfoOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupVB(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
    }
    public interface IVBAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
    public interface IVsSettingVBAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingVBParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Xaml
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HasActiveTextControlWithReSharperAutopopupXaml : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.HasActiveTextControlWithReSharperAutomaticIntellisenceBase<JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Xaml.IXamlAutomaticCompletionIsSupported>, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Xaml.IVsSettingXamlAutocompletionOverrider, JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.Xaml.IVsSettingXamlParameterInfoOverrider
    {
        public HasActiveTextControlWithReSharperAutopopupXaml(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    public interface IVsSettingXamlAutocompletionOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IVsSettingXamlParameterInfoOverrider : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IVsSettingOverrider { }
    public interface IXamlAutomaticCompletionIsSupported : JetBrains.PsiFeatures.VisualStudio.Core.FormatProperties.IAutomaticCompletionIsSupported { }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.BizTalk
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class BizTalkGeneratedFilesProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProviderFilter
    {
        public BizTalkGeneratedFilesProvider(JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator> OverrideHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.Common
{
    
    public class GeneratedFilesProjectDecorator : JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator
    {
        public GeneratedFilesProjectDecorator(JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.Common.GeneratedFilesProjectHandler handler) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> OverrideModuleReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> references) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> OverrideSourceFiles(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> files) { }
    }
    public class GeneratedFilesProjectHandler : JetBrains.ReSharper.Psi.Modules.DelegatingProjectPsiModuleHandler, JetBrains.Application.IChangeProvider
    {
        public readonly JetBrains.ProjectModel.IProject Project;
        public GeneratedFilesProjectHandler(JetBrains.Application.IShellLocks locks, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, System.Func<JetBrains.ReSharper.Psi.PsiSourceFileFromPath, JetBrains.ReSharper.Psi.IPsiSourceFileProperties> propertiesFactory, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext, params JetBrains.Util.FileSystemPath[] generatedFolders) { }
        public override JetBrains.Application.IChangeProvider ChangeProvider { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GeneratedFiles { get; }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.LightSwitch
{
    
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class LightSwitch1ProjectFlavor : JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.LightSwitch.LightSwitchProjectFlavor
    {
        public static readonly System.Guid LightSwitch;
        public override string FlavorName { get; }
        public override System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class LightSwitch3ProjectFlavor : JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.LightSwitch.LightSwitchProjectFlavor
    {
        public static readonly System.Guid LightSwitch3;
        public override string FlavorName { get; }
        public override System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class LightSwitchGeneratedFilesProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProviderFilter
    {
        public LightSwitchGeneratedFilesProvider(JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks locks, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator> OverrideHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler) { }
    }
    public abstract class LightSwitchProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public abstract string FlavorName { get; }
        public abstract System.Guid Guid { get; }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.MicrosoftDynamics
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MicrosoftDynamicsGeneratedFilesProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProviderFilter
    {
        public MicrosoftDynamicsGeneratedFilesProvider(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator> OverrideHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class MicrosoftDynamicsProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid Dynamics;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.RiaServices
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RiaServicesGeneratedFilesProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProviderFilter
    {
        public RiaServicesGeneratedFilesProvider(JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks locks, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.RiaServices.RiaServicesTestProjectData data) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator> OverrideHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class RiaServicesTestProjectData : JetBrains.ProjectModel.Caches.IProjectFileDataCache
    {
        public RiaServicesTestProjectData(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Caches.ProjectFileDataCache cache) { }
        public int Version { get; }
        public object BuildData(System.Xml.XmlDocument document) { }
        public bool CanHandle(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Action OnDataChanged(JetBrains.ProjectModel.IProjectFile projectFile, object oldData, object newData) { }
        public object Read(System.IO.BinaryReader reader) { }
        public void Write(System.IO.BinaryWriter writer, object data) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.GeneratedFolders.Xamarin
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XamarinMonoDroidGeneratedFilesProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProviderFilter
    {
        public XamarinMonoDroidGeneratedFilesProvider(JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks locks, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator> OverrideHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Intentions.Bulbs
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class SendToFSharpAltEnterHandler : JetBrains.ReSharper.Intentions.Bulbs.IAltEnterHandler
    {
        public SendToFSharpAltEnterHandler(Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping, EnvDTE.DTE dte, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        public double Priority { get; }
        public bool HandleAction(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Intentions.QuickFixes.MVC
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MvcControllerQuickFixVS : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MvcControllerQuickFixVS([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference> highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MvcControllerVSCommandBulbItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public MvcControllerVSCommandBulbItem(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcControllerReference controllerReference) { }
        public string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class static MvcUtilVS
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.PsiFeatures.VisualStudio.Core.Intentions.QuickFixes.MVC.MvcUtilVS.UIAutomationData GetUIData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public enum Command
        {
            AddView = 200,
            AddController = 300,
        }
        public class UIAutomationData
        {
            public string AddControllerButtonID;
            public string AddControllerDialogID;
            public string AddViewButtonID;
            public string AddViewDialogID;
            public string ControllerNameTextBoxID;
            public System.Guid MenuGroup;
            public string PartialViewCheckBoxID;
            public string TypeCheckBoxID;
            public string TypeComboBoxID;
            public string ViewNameTextBoxID;
            public System.ComponentModel.Design.CommandID GetCommandID(JetBrains.PsiFeatures.VisualStudio.Core.Intentions.QuickFixes.MVC.MvcUtilVS.Command addView) { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MvcViewQuickFixVS : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MvcViewQuickFixVS([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference> highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MvcViewVSCommandBulbItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public MvcViewVSCommandBulbItem(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewReference viewReference) { }
        public string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.LinqToXsd
{
    
    public class VsLinqToXsdDetector : JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd.LinqToXsdDetector
    {
        public VsLinqToXsdDetector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath exePath, JetBrains.ProjectModel.IProject project, string devEnvDir, JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd.LinqToXsdSupportManager manager, JetBrains.DocumentManagers.DocumentManager documentManager, System.Action onInterrupt, System.Action onSuccessfulFinish) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsLinqToXsdSupportManager : JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd.LinqToXsdSupportManager
    {
        public VsLinqToXsdSupportManager(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper solutionWrapper = null) { }
        protected override JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd.LinqToXsdDetector CreateLinqToXsdDetector(JetBrains.ProjectModel.IProject project, System.Action onInterrupt, System.Action onSuccessfulFinish) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Lookup
{
    
    public class CodeSnippetLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public CodeSnippetLookupItem() { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsGlobalCompletionSettingsService : JetBrains.ReSharper.Feature.Services.CodeCompletion.GlobalCompletionSettingsService
    {
        public VsGlobalCompletionSettingsService(JetBrains.Threading.IThreading invocator, EnvDTE.DTE dte) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.GlobalCompletionSettings GetSettingsForLanguage(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Navigation
{
    
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class ProjectToModelReferenceNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.IProjectModelElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IProjectModelElementNavigationProvider
    {
        public ProjectToModelReferenceNavigationProvider(JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ProjectModel.IProjectModelElement element) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.IProjectModelElement element) { }
    }
    public class ProjectToModuleReferenceNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint
    {
        public ProjectToModuleReferenceNavigationPoint(JetBrains.ProjectModel.IProjectToModuleReference reference, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer synchronizer) { }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
    public class ResourceItemNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint
    {
        public ResourceItemNavigationPoint(JetBrains.ReSharper.I18n.Services.Navigation.ResourceItemOccurence occurence) { }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class VsDesignerResouceItemOccurenceNavigationProvider : JetBrains.ReSharper.I18n.Services.Navigation.ResouceItemOccurenceNavigationProvider
    {
        public VsDesignerResouceItemOccurenceNavigationProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator navigator, JetBrains.ProjectModel.ProjectFileExtensions extensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator fileTypeCoordinator, JetBrains.IDE.EditorManager editorManager) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.I18n.Services.Navigation.ResourceItemOccurence target) { }
    }
    public class VsSolutionExplorerNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint
    {
        public VsSolutionExplorerNavigationPoint(JetBrains.ProjectModel.IProjectItem item) { }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class VsSolutionExplorerNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.ProjectFileNavigationProvider, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.IProjectModelElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IProjectModelElementNavigationProvider, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IVsSolutionExplorerNavigationProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
        public override bool IsApplicable(JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.Assembly
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsModuleReferenceResolveSync : JetBrains.ProjectModel.Assemblies.Impl.ModuleReferenceResolveSync
    {
        public VsModuleReferenceResolveSync(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Assemblies.Impl.ModuleReferencesResolveStore store, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager referenceResolveManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder solutionBuilder, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.EffectiveReferencedAssemblyNamesExtractor assemblyNamesExtractor) { }
        protected override void UpdateProjectStructure() { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.Properties
{
    
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class WorkflowProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid WorkflowProjectGuid;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class WorkflowWebProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid WorkflowWebProjectGuid;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XamlVsLanguageLevelProvider : JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevelProvider
    {
        public override JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel GetLanguageLevel(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CSharpProjectPropertiesExtenderProvider : JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.ProjectPropertiesExtenderProviderBase
    {
        public CSharpProjectPropertiesExtenderProvider(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors(JetBrains.ProjectModel.IProject project) { }
        protected override bool IsSuitableProject(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class LocalizableProjectPropertiesExtenderProvider : JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.ProjectPropertiesExtenderProviderBase
    {
        public LocalizableProjectPropertiesExtenderProvider(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors(JetBrains.ProjectModel.IProject project) { }
    }
    public abstract class ProjectPropertiesExtenderProviderBase : JetBrains.VsIntegration.ProjectModel.PropertiesExtender.IPropertiesExtenderProvider
    {
        protected ProjectPropertiesExtenderProviderBase(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected JetBrains.Application.ShellLocks Locks { get; }
        protected JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public bool CanExtend(JetBrains.ProjectModel.IProjectItem projectItem) { }
        protected abstract System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        public System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetPropertyDescriptors(JetBrains.ProjectModel.IProjectItem projectItem) { }
        protected virtual bool IsSuitableProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
    }
    public class ReSharperPropertyDescriptor<T, TProjectItem> : JetBrains.VsIntegration.ProjectModel.PropertiesExtender.SimplePropertyDescriptor<T>
    
        where TProjectItem : JetBrains.ProjectModel.IProjectItem
    {
        public const string CategoryName = "ReSharper";
        public ReSharperPropertyDescriptor(JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] string name, System.Attribute[] attrs, TProjectItem projectItem, System.Func<T> getValueAction, System.Action<T> setValueAction) { }
        public ReSharperPropertyDescriptor(JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] string name, T defaultValue, string displayName, string description, TProjectItem projectItem, System.Func<T> getValueAction, System.Action<T> setValueAction) { }
        public ReSharperPropertyDescriptor(JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] string name, T defaultValue, string displayName, string description, System.Type converterType, TProjectItem projectItem, System.Func<T> getValueAction, System.Action<T> setValueAction) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionWideInspectionsProjectPropertiesExtenderProvider : JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.ProjectPropertiesExtenderProviderBase
    {
        public SolutionWideInspectionsProjectPropertiesExtenderProvider(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UseMsBuildToObtainProjectReferencesExtenderProvider : JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.ProjectPropertiesExtenderProviderBase
    {
        public UseMsBuildToObtainProjectReferencesExtenderProvider(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.Settings.Store.SolutionSettings solutionSettings) { }
        protected override System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBProjectPropertiesExtender : JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.ProjectPropertiesExtenderProviderBase
    {
        public VBProjectPropertiesExtender(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors(JetBrains.ProjectModel.IProject project) { }
        protected override bool IsSuitableProject(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsNamespaceFolderPropertiesExtenderProvider : JetBrains.VsIntegration.ProjectModel.PropertiesExtender.IPropertiesExtenderProvider
    {
        public VsNamespaceFolderPropertiesExtenderProvider(JetBrains.Application.IShellLocks locks) { }
        public bool CanExtend(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetPropertyDescriptors(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.WebProperties
{
    
    public class PathMappingEditor : System.Drawing.Design.UITypeEditor
    {
        public PathMappingEditor(JetBrains.ProjectModel.IProject project) { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsWebPathMappingManagerImpl : JetBrains.ReSharper.Psi.Impl.Paths.PathMappingManagerImpl
    {
        public VsWebPathMappingManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.ChangeManager changeManager, JetBrains.Util.Lazy.Lazy<JetBrains.UI.Application.IMainWindow> mainWindiow, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        protected override void RunPathMappingEditorImpl(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath preselectedPath) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebProjectPropertiesExtenderProvider : JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.ProjectPropertiesExtenderProviderBase
    {
        public const string NOT_SET = "Not set";
        public const string SET = "Custom";
        public WebProjectPropertiesExtenderProvider(JetBrains.Application.ShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public static string GetPathMappingValue(JetBrains.ProjectModel.IProject project) { }
        protected override System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetProjectPropertyDescriptors(JetBrains.ProjectModel.IProject project) { }
        protected override bool IsSuitableProject(JetBrains.ProjectModel.IProject project) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.WebProperties.UI
{
    
    public class PathMappingControl : System.Windows.Forms.UserControl
    {
        [System.ObsoleteAttribute("For designer only")]
        public PathMappingControl(JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public PathMappingControl(JetBrains.ProjectModel.IProject project, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public void ActivateSinglePathControl(JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.WebProperties.UI.SinglePathControl pathControl) { }
        public void AddIgnoredPath(JetBrains.Util.FileSystemPath webPath) { }
        public void AddMappedPath(JetBrains.Util.FileSystemPath webPath, JetBrains.Util.FileSystemPath realPath) { }
        protected override void Dispose(bool disposing) { }
        public System.Collections.Generic.IEnumerable<JetBrains.PsiFeatures.VisualStudio.Core.ProjectModel.PropertiesExtender.WebProperties.UI.SinglePathControl> GetSinglePathControls() { }
    }
    public class SinglePathControl : System.Windows.Forms.UserControl, JetBrains.CommonControls.Validation.IValidatorProvider
    {
        public SinglePathControl(JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public bool IsIgnored { get; set; }
        public JetBrains.Util.FileSystemPath RealPath { get; set; }
        public JetBrains.Util.FileSystemPath WebPath { get; set; }
        public event System.EventHandler Removed;
        public void Activate() { }
        protected override void Dispose(bool disposing) { }
        protected override void OnMouseEnter(System.EventArgs e) { }
        protected override void OnMouseLeave(System.EventArgs e) { }
    }
    public class WebPathMappingForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow
    {
        public WebPathMappingForm([JetBrains.Annotations.CanBeNullAttribute()] System.Windows.Forms.IWin32Window mainwin, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath PathToActivate { get; set; }
        public void AddIgnoredPath(JetBrains.Util.FileSystemPath webPath) { }
        public void AddMappedPath(JetBrains.Util.FileSystemPath webPath, JetBrains.Util.FileSystemPath realPath) { }
        protected override void Dispose(bool disposing) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetIngnoredPaths() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath>> GetMappedPaths() { }
        protected override void OnActivated(System.EventArgs e) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Resources
{
    
    public sealed class PsiFeaturesVisualStudioCoreThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 1, "GeneralOptionsPage")]
        public sealed class GeneralOptionsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 0, "Ignore")]
        public sealed class Ignore : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 6, "NewFolder")]
        public sealed class NewFolder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 3, "RuleCreate")]
        public sealed class RuleCreate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 5, "RuleDelete1")]
        public sealed class RuleDelete1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 2, "RuleDelete2")]
        public sealed class RuleDelete2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Resources/PsiFeaturesVisualStud" +
            "ioCoreIcons/ThemedIcons.PsiFeaturesVisualStudioCore.Generated.Xaml", 4, "Substitute")]
        public sealed class Substitute : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Services.Core.SymbolIcons
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.PrimaryThread)]
    public class VsPsiSymbolIconThemeSettingsLoader : JetBrains.ReSharper.Feature.Services.SymbolIcons.PsiSymbolIconThemeSettingsLoader
    {
        public VsPsiSymbolIconThemeSettingsLoader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Components.Theming.IColorThemeManager thememan) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconThemeAspect[]> GetDefaultPsiSymbolIconThemeForVs(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Version vsVersion2, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Components.Theming.IColorThemeManager thememan) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Snippets
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class HtmlSnippetsHandler
    {
        public HtmlSnippetsHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionManager, Microsoft.VisualStudio.TextManager.Interop.IVsTextManager2 vsTextManager2) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Src.ProjectModel.PropertiesExtender.WebProperties.UI
{
    
    public sealed class PathMappingControlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Src/ProjectModel/PropertiesExte" +
            "nder/WebProperties/UI/PathMappingControlIcons/ThemedIcons.PathMappingControl.Gen" +
            "erated.Xaml", 2, "PathMappingRuleCreate")]
        public sealed class PathMappingRuleCreate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Src/ProjectModel/PropertiesExte" +
            "nder/WebProperties/UI/PathMappingControlIcons/ThemedIcons.PathMappingControl.Gen" +
            "erated.Xaml", 0, "PathMappingRuleDelete1")]
        public sealed class PathMappingRuleDelete1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Src/ProjectModel/PropertiesExte" +
            "nder/WebProperties/UI/PathMappingControlIcons/ThemedIcons.PathMappingControl.Gen" +
            "erated.Xaml", 1, "PathMappingRuleDelete2")]
        public sealed class PathMappingRuleDelete2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Src/ProjectModel/PropertiesExte" +
            "nder/WebProperties/UI/PathMappingControlIcons/ThemedIcons.PathMappingControl.Gen" +
            "erated.Xaml", 3, "PathMappingRuleIgnore")]
        public sealed class PathMappingRuleIgnore : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.PsiFeatures.VisualStudio.Core;component/Src/ProjectModel/PropertiesExte" +
            "nder/WebProperties/UI/PathMappingControlIcons/ThemedIcons.PathMappingControl.Gen" +
            "erated.Xaml", 4, "PathMappingRuleSubstitute")]
        public sealed class PathMappingRuleSubstitute : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.Theming
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsLiveTemplatesColorFiller : JetBrains.UI.Components.Theming.IThemeColorFiller
    {
        public virtual void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme theme) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.Core.TypeBrowser
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class NavigateToObjectBrowserActionHandler : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.PsiFeatures.VisualStudio.Core.TypeBrowser.NavigateToObjectBrowserProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class NavigateToObjectBrowserProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public NavigateToObjectBrowserProvider(JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, JetBrains.Threading.IThreading threading) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class ObjectBrowserNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Psi.ICompiledElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IVsObjectBrowserNavigationProvider
    {
        public ObjectBrowserNavigationProvider(JetBrains.PsiFeatures.VisualStudio.Core.TypeBrowser.VsObjectBrowser vsObjectBrowser) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Psi.ICompiledElement compiledElement) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Psi.ICompiledElement compiledElement) { }
    }
    public class VBTypeBrowserElementPresenter : JetBrains.PsiFeatures.VisualStudio.Core.TypeBrowser.IVSTypeBrowserElementPresenter
    {
        public string ArraySubscriptSymbol { get; }
        public string GenericParamsDelimiter { get; }
        public string GenericParamsEnd { get; }
        public string GenericParamsStart { get; }
        public string PointerSymbol { get; }
        public string GetKeyword(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public string GetPresentation(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public void GetPresentation(JetBrains.ReSharper.Psi.ITypeMember typeMember, out string namespaceName, out string typeName, out string memberName) { }
        public string GetPresentationForTypeParametersOwner(JetBrains.ReSharper.Psi.ITypeParametersOwner typeElement) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsObjectBrowser
    {
        public VsObjectBrowser(JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsObjBrowser> vsObjBrowser, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2> vsObjectManager2, EnvDTE.DTE dte, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache) { }
        public static string GetMemberPresentation(JetBrains.ReSharper.Psi.ITypeMember typeMember, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public static string GetProjectNameAndPath(JetBrains.ProjectModel.IProject project) { }
        public static bool IsObjectBrowserActive(JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        public static bool IsObjectBrowserToolWindow(JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame vsWindowFrame) { }
        public bool Show([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement, bool activate) { }
    }
}
namespace JetBrains.ReSharper.VS.Actions
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Settings for Profile Visual Studio actions")]
    public class ProfileVisualStudioActionSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Temporary folder")]
        public readonly string TemporaryFolder;
    }
}