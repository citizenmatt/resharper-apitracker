[assembly: JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute("QuickInfo", DarkForegroundColor="#999999", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Info, HighContrastForeground=JetBrains.UI.Components.Theming.SystemColor.InfoText, LightForegroundColor="#1E1E1E")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.VsIntegration.DevEleven
{
    
    public class VsTaskBody : Microsoft.VisualStudio.Shell.Interop.IVsTaskBody
    {
        public VsTaskBody(System.Action actionToExecute, JetBrains.Application.IShellLocks locks) { }
        public void DoWork(Microsoft.VisualStudio.Shell.Interop.IVsTask pTask, uint dwCount, Microsoft.VisualStudio.Shell.Interop.IVsTask[] pParentTasks, out object pResult) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.Hacks
{
    
    public abstract class SuppressOwnerlessFloatingWindowsSinceVs11
    {
        protected SuppressOwnerlessFloatingWindowsSinceVs11(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Settings.VsToolsOptionsMonitor vsToolsOptionsMonitor, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Action FEnsureOwner) { }
        [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Allows to turn off SuppressOwnerlessFloatingWindows functionality.")]
        public class SuppressOwnerlessFloatingWindowsSettingsKey
        {
            [JetBrains.Application.Settings.SettingsEntryAttribute(true, "If SuppressOwnerlessFloatingWindows is disabling independent floating windows.")]
            public bool IsDisablingIndependentFloating;
        }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.IDE
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class EditorManagerSinceVs11 : JetBrains.VsIntegration.EditorManager.VsEditorManager
    {
        public EditorManagerSinceVs11(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument vsUiShellOpenDocument, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.UI.WindowManagement.IFrameFocusHelper frameFocusHelper, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        protected override void EnablePreviewTab() { }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.Install
{
    
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class AssemblyBindingRedirectionsRegistryInstaller : JetBrains.Application.Install.IStaticInstaller { }
}
namespace JetBrains.VsIntegration.SinceVs11.Interop
{
    
    [JetBrains.VsIntegration.Application.WrapVsInterfacesAttribute()]
    public class ExposeSinceVs11Services : JetBrains.VsIntegration.Application.IExposeVsServices { }
}
namespace JetBrains.VsIntegration.SinceVs11.Markup
{
    
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public sealed class GenerateHighlighterPkgDef : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute>, JetBrains.Application.Install.IRequiresCommit
    {
        public GenerateHighlighterPkgDef() { }
        public JetBrains.Application.Install.InstallationData.InstallationData Commit(JetBrains.Application.Install.Installer installer) { }
        public JetBrains.Application.Install.InstallationData.InstallationData Install(JetBrains.Application.Install.Installer installer, System.Reflection.Assembly assembly, JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute attribute) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.Progression
{
    
    public class static DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.VsIntegration.SinceVs11.Progression.ProgressionGraphNodeData[]> GRAPH_NODES_DATA;
        public static readonly JetBrains.Application.DataContext.DataConstant<Microsoft.VisualStudio.GraphModel.GraphObject[]> RAW_GRAPH_OBJECTS;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.VsIntegration.SinceVs11.Progression.ProgressionSourceLocation[]> SOURCE_LOCATIONS;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProgressionDataRules
    {
        public static readonly System.Guid DependencyGraphExplorerGuid;
        public ProgressionDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionman, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, JetBrains.Threading.IThreading threading, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsInfo, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager) { }
    }
    public class ProgressionGraphNodeData
    {
        public ProgressionGraphNodeData([JetBrains.Annotations.CanBeNullAttribute()] string assembly, [JetBrains.Annotations.CanBeNullAttribute()] string ns, [JetBrains.Annotations.CanBeNullAttribute()] string typeElement, [JetBrains.Annotations.CanBeNullAttribute()] string typeMember) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Assembly { get; }
        public System.Nullable<System.Windows.Rect> ContentBounds { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Ns { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TypeElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TypeMember { get; }
    }
    public class ProgressionSourceLocation
    {
        public ProgressionSourceLocation(string location, int line, int column) { }
        public int Column { get; }
        public int Line { get; }
        public string Location { get; }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.ProjectModel
{
    
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class CSharpProjectPropertiesBuilder11 : JetBrains.VsIntegration.ProjectModel.ProjectProperties.CSharpProjectPropertiesBuilder
    {
        public CSharpProjectPropertiesBuilder11(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        protected override JetBrains.ProjectModel.ProjectOutputType GetOutputType(object value) { }
        protected override bool ProcessManagedProjectPropertiesDispatch(JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration, VSLangProj.ProjectProperties vsProjectProperties, VSLangProj.ProjectConfigurationProperties vsProjectConfiguration) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class JavaScriptImplicitReferences
    {
        public JavaScriptImplicitReferences(JetBrains.VsIntegration.Interop.Shim.Shell.IVsShell vsShell) { }
        public System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.SinceVs11.ProjectModel.ReferenceGroup> EnumerateAllReferenceGroups() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.SinceVs11.ProjectModel.ReferenceGroup GetReferenceGroup(JetBrains.VsIntegration.SinceVs11.ProjectModel.ReferenceGroupName name) { }
    }
    public class OutputTypeUtil
    {
        public static bool TryGetProjectOutputType(object value, out JetBrains.ProjectModel.ProjectOutputType projectOutputType) { }
    }
    public class ProjectReferenceManager11 : JetBrains.VsIntegration.DevTen.ProjectModel.ProjectReferenceManager10, Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents
    {
        public ProjectReferenceManager11(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, EnvDTE.Project project, VSLangProj.VSProject vsProject, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider, JetBrains.VsIntegration.DevTen.NuGet.NuGetReferenceManager nuGetReferenceManager) { }
        public override JetBrains.ProjectModel.Update.IProjectReferenceDescriptor CreateReferenceDescriptor(VSLangProj.Reference reference, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, System.Collections.Generic.List<string> resolvedReferences) { }
        public int OnInvalidateIcon(System.IntPtr hicon) { }
        public int OnInvalidateItems(uint itemidParent) { }
        public int OnItemAdded(uint itemidParent, uint itemidSiblingPrev, uint itemidAdded) { }
        public int OnItemDeleted(uint itemid) { }
        public int OnItemsAppended(uint itemidParent) { }
        public int OnPropertyChanged(uint itemid, int propid, uint flags) { }
    }
    [JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactoryAttribute()]
    public class ProjectReferenceManagerFactory11 : JetBrains.VsIntegration.DevTen.ProjectModel.ProjectReferenceManagerFactory10
    {
        public ProjectReferenceManagerFactory11(JetBrains.VsIntegration.DevTen.NuGet.NuGetReferenceManager nuGetReferenceManager) { }
        public override JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager Create(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, EnvDTE.Project project, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
    }
    public class ReferenceGroup
    {
        public ReferenceGroup(JetBrains.VsIntegration.SinceVs11.ProjectModel.ReferenceGroupName groupName, System.Collections.Generic.IEnumerable<string> references) { }
        public JetBrains.VsIntegration.SinceVs11.ProjectModel.ReferenceGroupName GroupName { get; }
        public System.Collections.Generic.IEnumerable<string> References { get; }
    }
    public enum ReferenceGroupName
    {
        ImplicitWindows = 0,
        ImplicitWeb = 1,
        DedicatedWorker = 2,
        Unknown = 3,
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VBProjectPropertiesBuilder11 : JetBrains.VsIntegration.ProjectModel.ProjectProperties.VBProjectPropertiesBuilder
    {
        public VBProjectPropertiesBuilder11(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        protected override JetBrains.ProjectModel.ProjectOutputType GetOutputType(object value) { }
        protected override bool ProcessManagedProjectPropertiesDispatch(JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration, VSLangProj.ProjectProperties vsProjectProperties, VSLangProj.ProjectConfigurationProperties vsProjectConfiguration) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class VSProjectModelDescriptorBuilder11 : JetBrains.VsIntegration.ProjectModel.VSProjectModelDescriptionBuilder
    {
        public VSProjectModelDescriptorBuilder11(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Update.ProjectModelUpdater projectModelUpdater, JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer projectModelExtensionsContainer, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer, JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration solutionCachesConfiguration, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable vsRunningDocumentTable, JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        protected override JetBrains.Metadata.Utils.TargetPlatformData GetTargetPlatformData(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsSolutionLoadTasksScheduler11 : JetBrains.VsIntegration.ProjectModel.VsSolutionLoadTasksScheduler
    {
        public VsSolutionLoadTasksScheduler11(JetBrains.Application.IShellLocks locks) { }
        protected override void RunTask(System.Action actionToExecute) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.TextControl
{
    
    public abstract class VsTextControlDevTenIncrementalSearchClientSinceVs11 : JetBrains.VsIntegration.SinceVs10.TextControl.VsTextControlDevTenIncrementalSearchClientSinceVs10
    {
        public static readonly string IsIncrementalSearchActive;
        public VsTextControlDevTenIncrementalSearchClientSinceVs11([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearchFactoryService> incrementalSearchFactoryService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract Microsoft.VisualStudio.Shell.Interop.IVsUIDataSource GetDataSourceFromFindManager();
        protected override bool IsVsIncrementalSearchActive(Microsoft.VisualStudio.Text.Editor.IWpfTextView wpfTextView) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs11.Theming
{
    
    public class static BundledThemeColors
    {
        public class static Environment
        {
            public static readonly System.Guid Category;
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentPaleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AccentPaleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ActiveCaptionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ActiveCaptionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AppWorkspaceBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AppWorkspaceColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideResizeGripBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideResizeGripColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey AutoHideTabTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUIBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUIBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUIBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUIBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUIFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUIFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUITextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUITextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUITitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BrandedUITitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonFaceBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonFaceColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ButtonTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CaptionTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CaptionTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerClassCompartmentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerClassCompartmentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerClassHeaderBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerClassHeaderBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCommentBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCommentBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCommentShapeBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCommentShapeBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCommentTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCommentTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCompartmentSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerCompartmentSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerConnectionRouteBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerConnectionRouteBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultConnectionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultConnectionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeSubtitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeSubtitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeTitleBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeTitleBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeTitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDefaultShapeTitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDelegateCompartmentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDelegateCompartmentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDelegateHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDelegateHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDiagramBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerDiagramBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerEmphasisBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerEmphasisBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerEnumHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerEnumHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerFieldAssociationBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerFieldAssociationColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerInheritanceBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerInheritanceColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerInterfaceCompartmentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerInterfaceCompartmentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerInterfaceHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerInterfaceHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerLassoBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerLassoColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerLollipopBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerLollipopColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerPropertyAssociationBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerPropertyAssociationColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerReferencedAssemblyBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerReferencedAssemblyBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerResizingShapeBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerResizingShapeBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerShapeBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerShapeBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerShapeShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerShapeShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerTempConnectionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerTempConnectionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerTypedefBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerTypedefColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerTypedefHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerTypedefHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerUnresolvedTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerUnresolvedTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerVBModuleCompartmentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerVBModuleCompartmentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerVBModuleHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ClassDesignerVBModuleHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseDownBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseDownBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseDownSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseDownSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseOverBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseOverBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseOverSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxButtonMouseOverSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxDisabledTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseDownTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBackgroundMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxPopupBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxPopupBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxPopupBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxPopupBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxPopupBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxPopupBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxSelectionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxSelectionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ComboBoxTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarCheckBoxBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarCheckBoxColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarCheckBoxDisabledBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarCheckBoxDisabledColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarCheckBoxMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarCheckBoxMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarDragHandleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarDragHandleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarDragHandleShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarDragHandleShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarGradientMiddleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarGradientMiddleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverOverSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverOverSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverOverSelectedIconBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverOverSelectedIconBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverOverSelectedIconBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarHoverOverSelectedIconColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuBackgroundGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuBackgroundGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuBackgroundGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuBackgroundGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuGroupHeaderLinkTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuGroupHeaderLinkTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuGroupHeaderLinkTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuGroupHeaderLinkTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuIconBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuIconBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuItemMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuItemMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuItemMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuItemMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuItemMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuItemMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuLinkTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuLinkTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuLinkTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuLinkTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuMouseOverSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuMouseOverSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuMouseOverSubmenuGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuMouseOverSubmenuGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuSubmenuGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuSubmenuGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkLinkTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkLinkTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkLinkTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkLinkTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMenuWatermarkTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBackgroundMiddleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBackgroundMiddleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverBackgroundMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverUnfocusedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarMouseOverUnfocusedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownBackgroundMiddleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownBackgroundMiddleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverBackgroundMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarOptionsMouseOverGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconDisabledBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconDisabledBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconDisabledBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSelectedIconDisabledColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSplitButtonSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarSplitButtonSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextHoverOverSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextHoverOverSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextMouseDownBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextMouseDownColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarTextSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarToolBarBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarToolBarBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarToolBarSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarToolBarSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarToolBarSeparatorHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandBarToolBarSeparatorHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfBackgroundGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfBackgroundGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfBackgroundGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfBackgroundGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfBackgroundGradientMiddleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfBackgroundGradientMiddleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfHighlightGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfHighlightGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfHighlightGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfHighlightGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfHighlightGradientMiddleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey CommandShelfHighlightGradientMiddleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlEditHintTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlEditHintTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlEditRequiredBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlEditRequiredBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlEditRequiredHintTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlEditRequiredHintTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlLinkTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlLinkTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlLinkTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlLinkTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlLinkTextPressedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlLinkTextPressedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlOutlineBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ControlOutlineColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveHighlightTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveHighlightTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipActiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveHighlightTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveHighlightTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DebuggerDataTipInactiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerSelectionDotsBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerSelectionDotsColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerTrayBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerTrayColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerWatermarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DesignerWatermarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportLinkTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportLinkTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportLinkTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportLinkTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSecondaryPageHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSecondaryPageHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSecondaryPageSubtitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSecondaryPageSubtitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSecondaryPageTitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSecondaryPageTitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSummaryPageHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSummaryPageHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSummaryPageSubtitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSummaryPageSubtitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSummaryPageTitleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportSummaryPageTitleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DiagReportTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DialogBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DialogColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DialogTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DialogTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetButtonBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetButtonBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetButtonBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetButtonBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetButtonBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetButtonBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphArrowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphArrowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DockTargetGlyphBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseDownBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseDownBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseOverBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseOverBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseOverGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DocWellOverflowButtonMouseOverGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseDownBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseDownBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseDownSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseDownSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseOverBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseOverBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseOverSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownButtonMouseOverSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownDisabledTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseDownTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBackgroundMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownPopupBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownPopupBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownPopupBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownPopupBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownPopupBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownPopupBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropDownTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropShadowBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DropShadowBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionLinkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionLinkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EditorExpansionTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundGradientMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundTexture1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundTexture1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundTexture2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey EnvironmentBackgroundTexture2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarHighlight1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarHighlight1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarHighlight2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarHighlight2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarInactive1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarInactive1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarInactive2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ExtensionManagerStarInactive2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonDownSelectedInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonHoverSelectedInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalSelectedActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalSelectedActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalSelectedInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonProvisionalSelectedInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonSelectedActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonSelectedActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonSelectedInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabButtonSelectedInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabChannelBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabChannelBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabDocumentBorderBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabDocumentBorderBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabDocumentBorderHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabDocumentBorderHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabDocumentBorderShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabDocumentBorderShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabGradientDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabGradientDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabGradientLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabGradientLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotGradientBottomBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotGradientBottomColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotGradientTopBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotGradientTopColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabHotTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveDocumentBorderBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveDocumentBorderBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveDocumentBorderEdgeBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveDocumentBorderEdgeColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveGradientBottomBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveGradientBottomColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveGradientTopBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveGradientTopColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabInactiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveDocumentBorderBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveDocumentBorderBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveDocumentBorderEdgeBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveDocumentBorderEdgeColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientBottomBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientBottomColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientTopBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveGradientTopColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabLastActiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalHoverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalHoverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalHoverForegroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalHoverForegroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalInactiveForegroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalInactiveForegroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedActiveForegroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedActiveForegroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedInactiveForegroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabProvisionalSelectedInactiveForegroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientBottomBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientBottomColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientTopBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedGradientTopColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabSelectedTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FileTabTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagActionTagBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagActionTagBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagActionTagFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagActionTagFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagObjectTagBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagObjectTagBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagObjectTagFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FormSmartTagObjectTagFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GrayTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GrayTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GridHeadingBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GridHeadingBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GridHeadingTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GridHeadingTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GridLineBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GridLineColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoIPaneBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoIPaneBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoIPaneLinkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoIPaneLinkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoIPaneTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoIPaneTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoITaskBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoITaskBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoITaskLinkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoITaskLinkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoITaskTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpHowDoITaskTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFilterBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFilterBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFilterBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFilterBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFilterTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFilterTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFrameBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFrameBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFrameTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchFrameTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchPanelRulesBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchPanelRulesColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderIconBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderIconColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderSelectedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderSelectedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderSelectedTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderSelectedTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderUnselectedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderUnselectedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderUnselectedTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchProviderUnselectedTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultLinkSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultLinkSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultLinkUnselectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultLinkUnselectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultSelectedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultSelectedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultSelectedTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchResultSelectedTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HelpSearchTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HorizontalResizeGripBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HorizontalResizeGripColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey IconActionFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey IconActionFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey IconGeneralFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey IconGeneralFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey IconGeneralStrokeBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey IconGeneralStrokeColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InactiveCaptionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InactiveCaptionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InactiveCaptionTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InactiveCaptionTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InfoBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InfoBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InfoTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey InfoTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey LightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey LightCaptionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey LightCaptionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey LightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveBuildingBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveBuildingBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveCaptionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveCaptionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveCaptionTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveCaptionTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveDebuggingBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveDebuggingBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveDefaultBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveDefaultBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconBuildingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconBuildingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconDebuggingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconDebuggingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconDefaultBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconDefaultColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconNoSolutionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveIconNoSolutionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveNoSolutionBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowActiveNoSolutionBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonDownBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonDownColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonHoverInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowButtonInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveCaptionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveCaptionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveCaptionTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveCaptionTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconBuildingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconBuildingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconDebuggingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconDebuggingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconDefaultBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconDefaultColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconNoSolutionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowInactiveIconNoSolutionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowResizeGripTexture1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowResizeGripTexture1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowResizeGripTexture2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MainWindowResizeGripTexture2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MdiClientBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MdiClientBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MenuBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MenuColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MenuTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey MenuTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemInactiveBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemInactiveBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemInactiveEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemInactiveEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemSelectedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemSelectedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectItemSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverForegroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverForegroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderHoverMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderInactiveBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderInactiveBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderInactiveEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderInactiveEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderInactiveForegroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey NewProjectProviderInactiveForegroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageContentExpanderChevronBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageContentExpanderChevronColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageContentExpanderSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageContentExpanderSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderBodyBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderBodyColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderChevronBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderChevronColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderHeaderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderHeaderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderHeaderHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderHeaderHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderHeaderPressedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderHeaderPressedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PageSideBarExpanderTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelGradientDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelGradientDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelGradientLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelGradientLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHoverOverCloseBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHoverOverCloseBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHoverOverCloseFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHoverOverCloseFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHyperlinkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHyperlinkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHyperlinkHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHyperlinkHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHyperlinkPressedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelHyperlinkPressedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelSubGroupSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelSubGroupSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTitleBarBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTitleBarColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTitleBarTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTitleBarTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTitleBarUnselectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey PanelTitleBarUnselectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBackgroundGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBackgroundGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBackgroundGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBackgroundGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBorderInsideBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBorderInsideColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBorderOutsideBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerBorderOutsideColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerContentsBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerContentsBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabBackgroundGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabBackgroundGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabBackgroundGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabBackgroundGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedHighlight1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedHighlight1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedHighlight2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedHighlight2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedInsideBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSelectedInsideBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepBottomGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepBottomGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepBottomGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepBottomGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepTopGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepTopGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepTopGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ProjectDesignerTabSepTopGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonGlyphHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonGlyphHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickCustomizeButtonTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconBuildingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconBuildingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconDebuggingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconDebuggingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconDefaultBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconDefaultColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconNoSolutionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowActiveIconNoSolutionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonDownBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonDownColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonDownGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonDownGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonHoverInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowButtonInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconBuildingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconBuildingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconDebuggingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconDebuggingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconDefaultBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconDefaultColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconNoSolutionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey RaftedWindowInactiveIconNoSolutionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScreenTipBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScreenTipBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScreenTipBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScreenTipBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScreenTipTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScreenTipTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowDisabledBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowDisabledBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphDisabledBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphDisabledColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphPressedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowGlyphPressedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowMouseOverBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowMouseOverBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowPressedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarArrowPressedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarDisabledBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarDisabledBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbDisabledBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbDisabledColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbGlyphMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbGlyphMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbGlyphPressedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbGlyphPressedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbMouseOverBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbMouseOverBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbPressedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbPressedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbPressedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ScrollBarThumbPressedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBackgroundMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxPressedBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxPressedBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxPressedBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SearchBoxPressedBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarGradientDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarGradientDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarGradientLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarGradientLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SideBarTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagHoverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagHoverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagHoverFillBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagHoverFillColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagHoverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagHoverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SmartTagTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SnaplinesBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SnaplinesColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SnaplinesPaddingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SnaplinesPaddingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SnaplinesTextBaselineBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SnaplinesTextBaselineColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SortBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SortBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SortTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SortTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SplashScreenBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SplashScreenBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageBackgroundGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageBackgroundGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageBackgroundGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageBackgroundGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonMouseOverBackgroundMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonPinDownBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonPinDownColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonPinHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonPinHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonPinnedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonPinnedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonTextHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonTextHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonUnpinnedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageButtonUnpinnedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageCheckboxCheckmarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageCheckboxCheckmarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageSelectedItemBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageSelectedItemBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageSelectedItemStrokeBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageSelectedItemStrokeColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTabMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextBodyBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextBodyColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextBodySelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextBodySelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextBodyUnselectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextBodyUnselectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextControlLinkSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextControlLinkSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextControlLinkSelectedHoverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextControlLinkSelectedHoverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextDateBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextDateColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextHeadingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextHeadingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextHeadingMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextHeadingMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextHeadingSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextHeadingSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextSubHeadingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextSubHeadingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextSubHeadingMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextSubHeadingMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextSubHeadingSelectedBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageTextSubHeadingSelectedColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageUnselectedItemBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageUnselectedItemBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageUnselectedItemBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageUnselectedItemBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageUnselectedItemStrokeBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StartPageUnselectedItemStrokeColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarBuildingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarBuildingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarBuildingTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarBuildingTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDebuggingBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDebuggingColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDebuggingTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDebuggingTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDefaultBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDefaultColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDefaultTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarDefaultTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarHighlightTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarHighlightTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarNoSolutionBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarNoSolutionColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarNoSolutionTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarNoSolutionTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey StatusBarTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TaskListGridLinesBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TaskListGridLinesColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDDarkShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDDarkShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDFaceBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDFaceColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDLightShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDLightShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ThreeDShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveGradientMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarActiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarDragHandleActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarDragHandleActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarDragHandleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarDragHandleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey TitleBarInactiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxContentTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDisabledContentTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDividerBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxDividerColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxGradientDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxGradientDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxGradientLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxGradientLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxHeadingAccentBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxHeadingAccentColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxHeadingBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxHeadingBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxHeadingEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxHeadingEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxIconHighlightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxIconHighlightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxIconShadowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxIconShadowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingMiddle1BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingMiddle1ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingMiddle2BrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolboxSelectedHeadingMiddle2ColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipHintTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipHintTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolTipTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonDownInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverActiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverActiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonHoverInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonInactiveBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonInactiveBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowButtonInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowContentTabGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowContentTabGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowContentTabGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowContentTabGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameInactiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameInactiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowFloatingFrameTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabGradientBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabGradientBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabGradientEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabGradientEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverBackgroundBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverBackgroundBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverBackgroundEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverBackgroundEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabMouseOverTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSelectedActiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSelectedActiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSelectedTabBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSelectedTabColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSelectedTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSelectedTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSeparatorBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabSeparatorColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTabTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey ToolWindowTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VerticalResizeGripBeginBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VerticalResizeGripBeginColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VerticalResizeGripEndBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VerticalResizeGripEndColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VerticalResizeGripMiddleBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VerticalResizeGripMiddleColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceBrownDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceBrownDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceBrownLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceBrownLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceBrownMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceBrownMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceDarkGoldDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceDarkGoldDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceDarkGoldLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceDarkGoldLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceDarkGoldMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceDarkGoldMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGoldDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGoldDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGoldLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGoldLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGoldMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGoldMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGreenDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGreenDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGreenLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGreenLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGreenMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceGreenMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfacePlumDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfacePlumDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfacePlumLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfacePlumLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfacePlumMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfacePlumMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceRedDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceRedDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceRedLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceRedLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceRedMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceRedMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSoftBlueDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSoftBlueDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSoftBlueLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSoftBlueLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSoftBlueMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSoftBlueMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSteelBlueDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSteelBlueDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSteelBlueLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSteelBlueLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSteelBlueMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceSteelBlueMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceStrongBlueDarkBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceStrongBlueDarkColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceStrongBlueLightBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceStrongBlueLightColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceStrongBlueMediumBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey VizSurfaceStrongBlueMediumColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WindowBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WindowColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WindowFrameBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WindowFrameColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WindowTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WindowTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WizardOrientationPanelBackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WizardOrientationPanelBackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WizardOrientationPanelTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey WizardOrientationPanelTextColorKey { get; }
        }
        public class TreeView
        {
            public static readonly System.Guid Category;
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BackgroundBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BackgroundColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BackgroundTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey BackgroundTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemGlyphMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemGlyphMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey DragOverItemTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FocusVisualBorderBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey FocusVisualBorderColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GlyphMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey GlyphMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightedSpanBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightedSpanColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightedSpanTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey HighlightedSpanTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveGlyphMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveGlyphMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemActiveTextColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveGlyphBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveGlyphColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveGlyphMouseOverBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveGlyphMouseOverColorKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveTextBrushKey { get; }
            public static Microsoft.VisualStudio.Shell.ThemeResourceKey SelectedItemInactiveTextColorKey { get; }
        }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class GenerateColorThemePkgDef : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute>, JetBrains.Application.Install.IRequiresCommit
    {
        public GenerateColorThemePkgDef() { }
        public JetBrains.Application.Install.InstallationData.InstallationData Commit(JetBrains.Application.Install.Installer installer) { }
        public JetBrains.Application.Install.InstallationData.InstallationData Install(JetBrains.Application.Install.Installer installer, System.Reflection.Assembly assembly, JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute attribute) { }
    }
    public class static PkgDefUtils
    {
        public static readonly System.Guid DarkThemeGuid;
        public static readonly System.Guid HighContrastThemeGuid;
        public static readonly System.Guid LightThemeGuid;
        public static byte[] PackThemeCategory(System.Guid categoryGuid, System.Collections.Generic.ICollection<JetBrains.VsIntegration.SinceVs11.Theming.ThemeColorRecord> colorRecords) { }
    }
    public class PlatformColors
    {
        public static readonly System.Guid Category;
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickInfoBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickInfoColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickInfoTextBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey QuickInfoTextColorKey { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class RegisterThemeColorAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public RegisterThemeColorAttribute(string colorId) { }
        public System.Type CategoryDescriptor { get; set; }
        public string ColorId { get; }
        public string DarkBackgroundColor { get; set; }
        public string DarkForegroundColor { get; set; }
        public JetBrains.UI.Components.Theming.SystemColor HighContrastBackground { get; set; }
        public bool HighContrastBackgroundSet { get; }
        public JetBrains.UI.Components.Theming.SystemColor HighContrastForeground { get; set; }
        public bool HighContrastForegroundSet { get; }
        public string LightBackgroundColor { get; set; }
        public string LightForegroundColor { get; set; }
        public interface ICategoryDescriptor
        {
            System.Guid CategoryGuid { get; }
            string CategoryName { get; }
        }
        public class PlatformCategory : JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute.ICategoryDescriptor
        {
            public System.Guid CategoryGuid { get; }
            public string CategoryName { get; }
        }
    }
    public class StatusBarColor : JetBrains.UI.Components.Theming.ThemeColor
    {
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor BuildingBackground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor BuildingForeground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor DebuggingBackground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor DebuggingForeground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor DefaultBackground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor DefaultForeground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor Foreground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor NoSolutionBackground;
        public static readonly JetBrains.VsIntegration.SinceVs11.Theming.StatusBarColor NoSolutionForeground;
    }
    public class ThemeColorRecord
    {
        public bool AutoBackground { get; set; }
        public bool AutoForeground { get; set; }
        public System.Nullable<System.Drawing.Color> Background { get; set; }
        public System.Nullable<System.Drawing.Color> Foreground { get; set; }
        public string Name { get; set; }
        public System.Nullable<uint> PaletteBackground { get; set; }
        public System.Nullable<uint> PaletteForeground { get; set; }
        public Microsoft.VisualStudio.Shell.Interop.@__VSCOLORTYPE Type { get; set; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VS11StatusBarColorsManager : JetBrains.UI.Components.Theming.StatusBarColorsManager
    {
        public VS11StatusBarColorsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public override JetBrains.Util.Pair<JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Theming.EitherColor>, JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Theming.EitherColor>> CurrentStatusBarColors { get; }
        public JetBrains.Util.Pair<JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Theming.EitherColor>, JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Theming.EitherColor>> CreateLiveStatusBarColors(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VS11ThemeManager : JetBrains.VsIntegration.UI.VsThemeManager
    {
        public VS11ThemeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Interop.Shim.Shell.IVsShell vsShell, Microsoft.VisualStudio.Shell.Interop.IVsUIShell5 vsUIShell, JetBrains.Threading.IThreading threading, Microsoft.VisualStudio.Shell.Interop.IVsUIShell2 uishell2, JetBrains.DataFlow.IViewable<JetBrains.UI.Components.Theming.IThemeColorFiller> fillers) { }
        protected override JetBrains.UI.Components.Theming.ColorTheme CreateTheme() { }
        public static System.Drawing.Color GetThemedGDIColor(Microsoft.VisualStudio.Shell.Interop.IVsUIShell5 vsUIShell, Microsoft.VisualStudio.Shell.ThemeResourceKey themeResourceKey, System.Drawing.Color defaultColor = null) { }
        public override void PrepareFrameworkElement(System.Windows.FrameworkElement element) { }
        public override void PrepareWinForm(JetBrains.DataFlow.Lifetime handleLifetime, System.IntPtr handle) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class Vs11UnitTestThemeColorFiller : JetBrains.UI.Components.Theming.UnitTestThemeColorFiller
    {
        public Vs11UnitTestThemeColorFiller(Microsoft.VisualStudio.Shell.Interop.IVsUIShell5 vsUIShell5) { }
        public override void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme t) { }
    }
}
namespace JetBrains.VsIntegration.V11.ProjectModel.SqlServerDatabaseProject
{
    
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SqlServerDatabaseProjectCSharpProjectPropertiesBuilder11 : JetBrains.VsIntegration.SinceVs11.ProjectModel.CSharpProjectPropertiesBuilder11
    {
        public SqlServerDatabaseProjectCSharpProjectPropertiesBuilder11(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public override bool RetrievePropertiesFromVSHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectLocation) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SqlServerDatabaseProjectVBProjectPropertiesBuilder11 : JetBrains.VsIntegration.SinceVs11.ProjectModel.VBProjectPropertiesBuilder11
    {
        public SqlServerDatabaseProjectVBProjectPropertiesBuilder11(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public override bool RetrievePropertiesFromVSHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectLocation) { }
    }
}
namespace Microsoft.Internal.VisualStudio.Shell.Interop
{
    
    [System.Runtime.InteropServices.GuidAttribute("07980EA1-9516-4C7C-93AD-8DBF33842CDE")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    [System.Runtime.InteropServices.TypeIdentifierAttribute()]
    public interface IVsFileChangeExPrivate { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsFileChangeIgnoreReSharperCacheFolder { }
}