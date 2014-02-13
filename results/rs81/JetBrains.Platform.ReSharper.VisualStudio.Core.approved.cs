[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.VsIntegration.resources.Actions.xml")]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("Current Line", "{E0CF99E4-7D06-4a42-A62F-FCFC321C2347}", AppendProductToThemeName=true, BackgroundColor="LightYellow:Cyan", DarkBackgroundColor="Black", HighContrastBackground=JetBrains.TextControl.DocumentMarkup.PaletteColorIndex.PaletteDarkGray, ThemeEntryName="Current Line Highlight")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ProductSuspended"}, IconPackResourceIdentification="JetBrains.Platform.ReSharper.VisualStudio.Core;component/resources/VsIntegrationT" +
    "hemedIcons/ThemedIcons.VsIntegration.Generated.Xaml")]
[assembly: JetBrains.VsIntegration.EditorManager.Install.InstallVsEditorFactoryAttribute(typeof(JetBrains.VsIntegration.PersistableView.VsPersistableViewEditorFactory), null)]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute("ReSharperPropertiesExtenderProvider", "{0A7F7E5E-5D30-41DD-9065-1A294D736F44}", "551FD355-291C-4B2E-B9E7-151513EA8CDC")]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute("ReSharperPropertiesExtenderProvider", "{914FE278-054A-45DB-BF9E-5F22484CC84C}", "551FD355-291C-4B2E-B9E7-151513EA8CDC")]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute("ReSharperPropertiesExtenderProvider", "{932DC619-2EAA-4192-B7E6-3D15AD31DF49}", "551FD355-291C-4B2E-B9E7-151513EA8CDC")]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute("ReSharperPropertiesExtenderProvider", "{E0FDC879-C32A-4751-A3D3-0B3824BD575F}", "551FD355-291C-4B2E-B9E7-151513EA8CDC")]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute("ReSharperPropertiesExtenderProvider", "{4EF9F003-DE95-4d60-96B0-212979F2A857}", "551FD355-291C-4B2E-B9E7-151513EA8CDC")]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute("ReSharperPropertiesExtenderProvider", "{EEF81A81-D390-4725-B16D-E103E0F967B4}", "551FD355-291C-4B2E-B9E7-151513EA8CDC")]
[assembly: JetBrains.VsIntegration.ProjectModel.VSRegisterObjectAttribute(typeof(JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtenderProvider))]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-vs-integration", "JetBrains.VsIntegration.Resources")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:schemas-jetbrains-com:jetbrains-visualstudio-actionidstore", "JetBrains.VsIntegration.ActionManagement")]
[assembly: System.Windows.Markup.XmlnsPrefixAttribute("urn:schemas-jetbrains-com:jetbrains-visualstudio-actionidstore", "vsid")]

namespace JetBrains.VsIntegration.ActionManagement.ActionManagementEvents
{
    
    public class BeforeActionExecutedEventArgs
    {
        public BeforeActionExecutedEventArgs(string actionId) { }
        public string ActionId { get; }
    }
    public class VsCommandExecutedEventArgs
    {
        public VsCommandExecutedEventArgs(string commandId) { }
        public string CommandId { get; }
    }
}
namespace JetBrains.VsIntegration.ActionManagement
{
    
    public class BulkShortcutChangeProcessor
    {
        public BulkShortcutChangeProcessor() { }
        public JetBrains.Util.OneToSetMap<string, JetBrains.VsIntegration.ActionManagement.VsShortcut> ShortcutsToAdd { get; }
        public JetBrains.Util.OneToSetMap<string, JetBrains.VsIntegration.ActionManagement.VsShortcut> ShortcutsToRemove { get; }
        public void AddShortcut(string commandName, JetBrains.VsIntegration.ActionManagement.VsShortcut shortcut) { }
        public void RemoveShortcut(string commandName, JetBrains.VsIntegration.ActionManagement.VsShortcut shortcut) { }
    }
    public class static ChangeExportedVsSettingsUtil
    {
        public static void UpdateShortcuts(System.IO.TextWriter to, JetBrains.Util.FileSystemPath exportedSettingsPath, System.Func<string, string, string, bool, bool> onShortcutLine, System.Action<System.IO.TextWriter, System.Collections.Generic.IDictionary<string, string>> writeShortcutsAction) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.VsIntegration.ActionManagement.VsActionManagerSettings), "Shortcuts conflicts for actions with set shortcuts", typeof(string))]
    public class ConflictingActionsSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Conflicting shortcuts")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<JetBrains.ActionManagement.ActionShortcut, bool> Shortcuts;
    }
    public class static DebugVsActionManagerServices
    {
        public static void DumpBindings(EnvDTE.DTE dte) { }
        public static void DumpBindings(System.IO.TextWriter tw, EnvDTE.DTE dte) { }
        public static void DumpCommandBar(System.IO.TextWriter to, int level, Microsoft.VisualStudio.CommandBars.CommandBar commandBar, EnvDTE.DTE dte) { }
        public static void DumpCommandBarControl(System.IO.TextWriter to, int level, Microsoft.VisualStudio.CommandBars.CommandBarControl control, EnvDTE.DTE dte) { }
        public static void DumpCommandBars(System.IO.TextWriter to, EnvDTE.DTE dte) { }
        public static void RemoveProductCommandsAndButtons(JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, EnvDTE.DTE dte, JetBrains.UI.StatusBar.IStatusBar statusBar, JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("313D94B9-8D5F-4BBD-B43B-A3950578E1B8")]
    public interface IVsCtoData
    {
        System.Guid ActionsCommandSetGuid { get; }
        System.Guid DynamicCommandSetGuid { get; }
        System.Guid GroupsCommandSetGuid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.VsIntegration.ActionManagement.VsCtoActionData TryGetActionDataByVsCommandID([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID CommandID);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.ComponentModel.Design.CommandID TryGetVsCommandIDByActionID([JetBrains.Annotations.NotNullAttribute()] string ActionID);
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.VsIntegration.ActionManagement.VsActionManagerSettings), "Cached map of KeyboardShortcut to VS command", typeof(JetBrains.ActionManagement.KeyboardShortcut))]
    public class KeyboardShortcutToVsCommandSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Conflicting shortcuts")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<JetBrains.VsIntegration.ActionManagement.VsCommand, bool> Commands;
    }
    public class static OleCmdText
    {
        public static string GetText([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.OLECMDTEXT* pOleText) { }
        public static void SetText([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.OLECMDTEXT* pOleText, [JetBrains.Annotations.NotNullAttribute()] string text) { }
    }
    public class static TodoRemove
    {
        [System.ObsoleteAttribute("Possibly, should use control name for the command name rather than caption?.. Or " +
            "CommandID?..")]
        public static bool ControlCaptionMatchesName(string cmdName, Microsoft.VisualStudio.CommandBars.CommandBarControl commandBarControl) { }
    }
    public class VsActionIdEntry
    {
        public string ActionId { get; set; }
        public int VsId { get; set; }
        public override string ToString() { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Entries")]
    [System.Windows.Markup.ContentPropertyAttribute("Entries")]
    public class VsActionIdStore
    {
        public VsActionIdStore() { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Collections.Generic.IList<JetBrains.VsIntegration.ActionManagement.VsActionIdEntry> Entries { get; }
        public void AssertValid([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
        public int ProposeNextId([JetBrains.Annotations.CanBeNullAttribute()] string sSeed) { }
        public System.Nullable<int> TryGetVsId([JetBrains.Annotations.NotNullAttribute()] string sActionId) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsActionLoader : JetBrains.ActionManagement.ActionLoader.ActionLoader
    {
        public VsActionLoader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ActionManagement.VsActionManager actionManager, JetBrains.VsIntegration.ActionManagement.VsShortcutManager shortcutManager, JetBrains.Application.Parts.PartsCatalogueSet catalogSet, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, EnvDTE.DTE dte) { }
        public JetBrains.VsIntegration.ActionManagement.VsActionManager ActionManager { get; }
        public override void OnAfterLoadActions(System.Collections.Generic.ICollection<JetBrains.ActionManagement.ActionsXmlInfo> infos) { }
        public override void OnAfterLoadActions(JetBrains.ActionManagement.ActionsXmlInfo info) { }
        public override void OnBeforeLoadActions(System.Collections.Generic.ICollection<JetBrains.ActionManagement.ActionsXmlInfo> infos) { }
        public override void OnBeforeLoadActions(JetBrains.ActionManagement.ActionsXmlInfo info) { }
        protected override void ProcessInsert(System.Xml.XmlElement e, JetBrains.ActionManagement.ActionsXmlInfo info, System.Collections.Generic.IDictionary<string, JetBrains.Application.Parts.PartCatalogueType> mapIconClasses) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsActionManager : JetBrains.ActionManagement.ActionManager, JetBrains.ActionManagement.ActionLoader.IActionLoadClient
    {
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ISimpleSignal BeforeActionsUpdated;
        public VsActionManager(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.Application.IApplicationDescriptor applicationDescriptor, 
                    JetBrains.VsIntegration.Package.VsPackageCommandTargetHandlers vsPackageCommandTargetHandlers, 
                    JetBrains.VsIntegration.Application.VsUIHostCommandDispatcher oleCommandTarget, 
                    Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping, 
                    EnvDTE.DTE dte, 
                    Microsoft.VisualStudio.Shell.Interop.IVsProfferCommands3 vsProfferCommands3, 
                    Microsoft.VisualStudio.Shell.Interop.IVsUIShell ivsUiShell, 
                    Microsoft.VisualStudio.Shell.Interop.IVsRegisterPriorityCommandTarget vsRegisterPriorityCommandTarget, 
                    JetBrains.VsIntegration.ActionManagement.IVsCtoData vsCtoData, 
                    JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, 
                    JetBrains.UI.Application.UIApplication uiApplication, 
                    JetBrains.UI.Application.HelpSystem helpSystem, 
                    JetBrains.Application.IShellLocks shellLocks, 
                    JetBrains.Application.Parts.PartsCatalogueSet catalogSet, 
                    JetBrains.Application.DataContext.DataContexts dataContexts, 
                    JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo packageInfo) { }
        public bool IsActionManagerInitializing { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ActionManagement.IExecutableAction LastActionToExecute { get; set; }
        public bool ReplaceVSCommandsOption { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.ActionManagement.VsActionManagerCommandSets VsCommandSets { get; }
        protected override void CoreExecuteAction(JetBrains.ActionManagement.IExecutableAction action, JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public override JetBrains.ActionManagement.IExecutableAction CreateAction([JetBrains.Annotations.NotNullAttribute()] string actionId, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.ActionPresentation defaultPresentation, [JetBrains.Annotations.CanBeNullAttribute()] string overridenActionID, [JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement actionElement, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ActionManagement.ActionsXmlInfo actionsxmlinfo) { }
        public override JetBrains.ActionManagement.IActionGroup CreateActionGroup(string actionId, JetBrains.ActionManagement.ActionPresentation defaultPresentation, bool isShared, bool updatesActionsOnUpdate, string overridenActionId) { }
        public override JetBrains.ActionManagement.IActionWithGroup CreateActionWithGroup(string actionId, JetBrains.ActionManagement.ActionPresentation defaultPresentation, string overridenActionId) { }
        public JetBrains.ActionManagement.IExecutableAction CreateNonVsAction(string actionId, JetBrains.ActionManagement.ActionPresentation presentation) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public void ExecuteOverridenAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IExecutableAction executableAction, [JetBrains.Annotations.CanBeNullAttribute()] object VariantIn, [JetBrains.Annotations.CanBeNullAttribute()] object VariantOut) { }
        public override bool ExecuteShortcut(System.Windows.Forms.Keys shortcut, bool bIncludeHostActions) { }
        public void ExecuteVsCommand([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, ref object customIn, ref object customOut) { }
        public override int GetActionIndex(JetBrains.ActionManagement.IActionGroup actionGroup, JetBrains.ActionManagement.IActionBase action) { }
        public string GetCachedText(string actionID) { }
        public override string GetLocationInMainMenu([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IExecutableAction action) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<System.ComponentModel.Design.CommandID> GetVsMenuIDsByActionGroupID([JetBrains.Annotations.NotNullAttribute()] string sActionGroupId) { }
        protected void Init() { }
        public JetBrains.Interop.WinApi.HResults OleCommandTargetExec([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, Microsoft.VisualStudio.OLE.Interop.OLECMDEXECOPT nCmdExecOpt, [JetBrains.Annotations.CanBeNullAttribute()] System.IntPtr vIn, [JetBrains.Annotations.CanBeNullAttribute()] System.IntPtr vOut, JetBrains.VsIntegration.ActionManagement.VsActionManager.VsCommandHandlerStage stage) { }
        public void OleCommandTargetExec_Product_ComboBox(bool isAuxiliaryCommand, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IExecutableAction executableAction, System.IntPtr varIn, System.IntPtr varOut) { }
        public JetBrains.Interop.WinApi.HResults OleCommandTargetQueryStatus(System.Guid guidCmdSet, Microsoft.VisualStudio.OLE.Interop.OLECMD[] olecmds, Microsoft.VisualStudio.OLE.Interop.OLECMDTEXT* pOleText, JetBrains.VsIntegration.ActionManagement.VsActionManager.VsCommandHandlerStage stage) { }
        public override void RemoveAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IUpdatableAction action) { }
        public override JetBrains.ActionManagement.IActionBase TryGetAction([JetBrains.Annotations.NotNullAttribute()] string actionId) { }
        public override bool UpdateAction(JetBrains.ActionManagement.IUpdatableAction action, JetBrains.Application.DataContext.IDataContext dataContext = null) { }
        public class static DataConstants
        {
            public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.VsIntegration.ActionManagement.VsActionManager.DataConstants.ComboBoxData> COMBO_BOX_DATA;
            public class ComboBoxData
            {
                public string CurrentItem { get; set; }
                public string[] Items { get; set; }
            }
        }
        public enum VsCommandHandlerStage
        {
            PackageRouting = 0,
            FirstChance = 1,
        }
    }
    public class VsActionManagerCommandSets
    {
        public VsActionManagerCommandSets([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ActionManagement.IVsCtoData ctoData) { }
        public System.Guid ActionsCommandSetGuid { get; }
        public System.Guid DynamicCommandSetGuid { get; }
        public System.Guid GroupsCommandSetGuid { get; }
        public void ExceptionAddGuids(System.Exception ex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetActionIDByVsCommandID([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.ComponentModel.Design.CommandID GetVsCommandIDByActionID([JetBrains.Annotations.NotNullAttribute()] string actionID) { }
        public bool IsAuxiliaryCommand([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        public bool IsCtoAction([JetBrains.Annotations.NotNullAttribute()] string actionid) { }
        public bool IsCtoVsCommand([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        public bool IsProductCommandSet([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        public bool IsProductRuntimeAction([JetBrains.Annotations.NotNullAttribute()] string actionid) { }
        public bool IsProductRuntimeCommandSet([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        public void RegisterRuntimeCommand([JetBrains.Annotations.NotNullAttribute()] string actionid, [JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        public void RevokeRuntimeCommand([JetBrains.Annotations.NotNullAttribute()] string actionid) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TryGetActionIDByVsCommandID([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.ComponentModel.Design.CommandID TryGetVsCommandIDByActionID([JetBrains.Annotations.NotNullAttribute()] string actionID) { }
    }
    public class static VsActionManagerEx
    {
        public static void ExecuteVsCommand([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ActionManagement.VsActionManager actionman, System.Guid cmdGroupGUID, JetBrains.VsIntegration.VSStd97CmdID cmdid) { }
        public static void ExecuteVsCommand([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ActionManagement.VsActionManager actionman, [JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
        public static void ExecuteVsCommand([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ActionManagement.VsActionManager actionman, System.Guid cmdGroupGUID, JetBrains.VsIntegration.VSStd97CmdID cmdid, ref object customIn, ref object customOut) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "VS shortcuts, conflicts etc")]
    public class VsActionManagerSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Actions with shortcuts set")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> ActionsWithShortcuts;
        [JetBrains.Application.Settings.SettingsEntryAttribute("NotSet", "Shortcuts scheme")]
        public string ShortcutSchemeName;
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class VsActionManagerSettingsStorage
    {
        public VsActionManagerSettingsStorage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.Settings.ISettingsSchema settingsSchema, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.Threading.IThreading threading, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.Settings.Storage.Persistence.IFileSettingsStorageBehavior settingsStorageBehavior, JetBrains.Application.Settings.Logging.ISettingsLogger settingsLogger, JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch settingsChangeDispatch, JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints.SelfCheckControl selfCheckControl, JetBrains.Application.Settings.Storage.InternKeyPathComponent interned) { }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class VsActionManagerSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    public class static VsAddInActionManagerDtCommandTarget
    {
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public static void Exec(JetBrains.VsIntegration.ActionManagement.VsActionManager manager, string CmdName, EnvDTE.vsCommandExecOption ExecuteOption, ref object VariantIn, ref object VariantOut, ref bool Handled, EnvDTE.DTE dte, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public static void QueryStatus(JetBrains.VsIntegration.ActionManagement.VsActionManager manager, string CmdName, EnvDTE.vsCommandStatusTextWanted NeededText, ref EnvDTE.vsCommandStatus StatusOption, ref object CommandText, EnvDTE.DTE dte, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsBindingsConverter
    {
        public VsBindingsConverter(JetBrains.VsIntegration.ActionManagement.VsLocalizer vsLocalizer) { }
        public string ScopeToBindingsString(string scope) { }
        public string ShortcutToBindingsString(string shortcutString) { }
        public JetBrains.Util.Pair<string, JetBrains.ActionManagement.ActionShortcut> ToActionShortcut(string bindingString) { }
        public string ToBindingStringForWriting(string s) { }
        public string ToBindingStringForWriting(string scope, JetBrains.ActionManagement.ActionShortcut shortcut) { }
    }
    [System.ComponentModel.TypeConverterAttribute("JetBrains.VsIntegration.ActionManagement.VsCommandConverter")]
    public class VsCommand : System.IEquatable<JetBrains.VsIntegration.ActionManagement.VsCommand>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.ComponentModel.Design.CommandID CommandID;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.ActionManagement.VsShortcut Shortcut;
        public VsCommand([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ActionManagement.VsShortcut shortcut) { }
        public bool Equals(JetBrains.VsIntegration.ActionManagement.VsCommand other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static VsCommandActionManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetVsCommandName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IExecutableAction action, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping) { }
        public static string MakeVsAppIdForDynamicCommand(JetBrains.ActionManagement.IUpdatableAction action, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string TranslateActionIdToVsCommandAppIdSuffix([JetBrains.Annotations.NotNullAttribute()] string actionId) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.ComponentModel.Design.CommandID TryGetOverriddenVsCommandID([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IExecutableAction action) { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class VsCommandConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.VsIntegration.ActionManagement.VsCommand>
    {
        public VsCommandConverter() { }
    }
    public class static VsCommandExtensions
    {
        public static void ClearBindings([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<object> GetBindings([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.ComponentModel.Design.CommandID GetCommandID([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command) { }
        public static void PrependBinding([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command, JetBrains.VsIntegration.ActionManagement.VsBindingsConverter converter, string scope, JetBrains.ActionManagement.ActionShortcut shortcut) { }
        public static void PrependBindings([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command, JetBrains.VsIntegration.ActionManagement.VsBindingsConverter converter, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, JetBrains.ActionManagement.ActionShortcut>> shortcuts) { }
        public static void RemoveBindingsTo([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command, JetBrains.VsIntegration.ActionManagement.VsBindingsConverter converter, JetBrains.ActionManagement.ActionShortcut shortcut, string scope) { }
        public static void ReplaceBindings([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Command command, JetBrains.VsIntegration.ActionManagement.VsBindingsConverter converter, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, JetBrains.ActionManagement.ActionShortcut>> shortcuts) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.Command TryGetItem([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Commands commands, [JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid) { }
    }
    public class static VsCommandHelpers
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.CommandBars.CommandBar> EnumDescendantCommandBars([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.CommandBars.CommandBar root, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.CompoundException cex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<Microsoft.VisualStudio.CommandBars.CommandBarControl, Microsoft.VisualStudio.CommandBars.CommandBarPopup[]>> EnumDescendantControls([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.CommandBars.CommandBar root, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.CompoundException cex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetLocationInMainMenu([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, EnvDTE.DTE dte) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static Microsoft.VisualStudio.CommandBars.CommandBarControl GetOrCreateChildControl([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.CommandBars.CommandBar parentCommandBar, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.Command command, int position, EnvDTE.DTE dte) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static EnvDTE.Command GetVsCommandAutomationObject([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, EnvDTE.DTE dte) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.Command TryGetVsCommandAutomationObject([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, EnvDTE.DTE dte) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryMapVsCommandIDToVsCommandName([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.ComponentModel.Design.CommandID TryMapVsCommandNameToVsCommandID([JetBrains.Annotations.NotNullAttribute()] string commandname, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VsCommandIDToVsCommandName([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.ComponentModel.Design.CommandID VsCommandNameToVsCommandID([JetBrains.Annotations.NotNullAttribute()] string commandname, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping) { }
    }
    public class static VsCommandHelpersTodo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.OneToSetMap<string, Microsoft.VisualStudio.CommandBars.CommandBar> CacheCommandBarsByName(EnvDTE.DTE dte) { }
        public static void DeleteReSharperMenuItemsFromCommandBar(Microsoft.VisualStudio.CommandBars.CommandBar commandBar, JetBrains.Application.Progress.IProgressIndicator pi, EnvDTE.DTE dte, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        public static void DeleteReSharperMenuItemsFromCommandBarPopup(Microsoft.VisualStudio.CommandBars.CommandBarPopup popup, JetBrains.Application.Progress.IProgressIndicator pi, EnvDTE.DTE dte, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        public static void FindCommandBarsRecursivelyForDynamicGroup(Microsoft.VisualStudio.CommandBars.CommandBar bar, JetBrains.ActionManagement.IActionGroup group, System.Collections.Generic.List<Microsoft.VisualStudio.CommandBars.CommandBar> result) { }
        public static System.Collections.Generic.IList<Microsoft.VisualStudio.CommandBars.CommandBar> GetCommandBarsByActionGroup(JetBrains.ActionManagement.IActionGroup actionGroup, ref JetBrains.Util.OneToSetMap<, > cacheCommandBarsByName, EnvDTE.DTE dte) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        [System.ObsoleteAttribute("?? use either name or commandid. ???")]
        public static void ParseVsCommandNameOrCommandId([JetBrains.Annotations.NotNullAttribute()] string commandstring, [JetBrains.Annotations.CanBeNullAttribute()] out System.ComponentModel.Design.CommandID commandid, [JetBrains.Annotations.CanBeNullAttribute()] out string cmdName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.VisualStudio.CommandBars.CommandBarControl TryFindReSharperCommandBarControlByActionId([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.CommandBars.CommandBar parentCommandBar, [JetBrains.Annotations.NotNullAttribute()] string actionID, EnvDTE.DTE dte, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        public static void TryFindVsMenuItem([JetBrains.Annotations.NotNullAttribute()] string actionId, [JetBrains.Annotations.CanBeNullAttribute()] out Microsoft.VisualStudio.CommandBars.CommandBar commandBar, [JetBrains.Annotations.CanBeNullAttribute()] out Microsoft.VisualStudio.CommandBars.CommandBarButton commandButton, out System.Nullable<> indexInCommandBar, EnvDTE.DTE dte) { }
        public static void TryGetVsCommandBarControlByCommandID([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.CommandBars.CommandBar commandBar, [JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, [JetBrains.Annotations.CanBeNullAttribute()] out Microsoft.VisualStudio.CommandBars.CommandBarControl control, out System.Nullable<> index, EnvDTE.DTE dte) { }
        public static void TryGetVsCommandBarControlByName([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.CommandBars.CommandBar commandBar, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] out Microsoft.VisualStudio.CommandBars.CommandBarControl control, out System.Nullable<> index, EnvDTE.DTE dte) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.ComponentModel.Design.CommandID TryGetVsControlCommandID([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.CommandBars.CommandBarControl control, EnvDTE.DTE dte) { }
    }
    public class VsCommandIDConverter : System.ComponentModel.TypeConverter
    {
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, [JetBrains.Annotations.NotNullAttribute()] object value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.ComponentModel.Design.CommandID ConvertFromInvariantString([JetBrains.Annotations.NotNullAttribute()] string value) { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, [JetBrains.Annotations.NotNullAttribute()] object value, [JetBrains.Annotations.NotNullAttribute()] System.Type destinationType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ConvertToInvariantString([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID value) { }
    }
    public class VsConflictingShortcutForm : System.Windows.Forms.Form
    {
        public VsConflictingShortcutForm(JetBrains.UI.Application.IUIApplication environment, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager) { }
        public bool ApplyToAll { get; }
        public JetBrains.VsIntegration.ActionManagement.VsConflictingShortcutForm.UseShortcutResult Result { get; }
        protected override void Dispose(bool disposing) { }
        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
        public void SetAction(JetBrains.ActionManagement.IExecutableAction value) { }
        public void SetShortcut(JetBrains.ActionManagement.ActionShortcut value) { }
        public enum UseShortcutResult
        {
            NONE = 0,
            USE_RESHARPER = 1,
            USE_VS = 2,
            USE_VS_AND_CUSTOMIZE = 3,
        }
    }
    public class VsCtoActionData
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public string ID;
        public bool IsAuxiliaryCommand;
        public bool IsDynamicGroupStart;
        public VsCtoActionData([JetBrains.Annotations.NotNullAttribute()] string ID, bool IsDynamicGroupStart, bool IsAuxiliaryCommand) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsDataRules
    {
        public VsDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionman, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.VsIntegration.ProjectModel.VSSolutionManager vsSolutionManager, JetBrains.Threading.IThreading threading) { }
        public static JetBrains.ProjectModel.IProjectModelElement[] GetProjectModelElements([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, JetBrains.VsIntegration.ProjectModel.VSSolutionManager vsSolutionManager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsLocalizer
    {
        public const string XamlUIDesignerScope = "XAML UI Designer";
        public VsLocalizer(EnvDTE.DTE dte, JetBrains.VsIntegration.Interop.Shim.Shell.IVsShell vsShell, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
        public string GlobalizeString(string localized) { }
        public string LocalizeString(string globalized) { }
    }
    public class VsOverridenActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public event System.Action Executed;
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsPopupWindowContextDataRules
    {
        public const string ArchitectureExplorerGuid = "{AD44982B-6881-4925-83D1-038964FFF086}";
        public VsPopupWindowContextDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionman, JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, EnvDTE.DTE dte, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.Threading.IThreading threading) { }
    }
    [System.ComponentModel.TypeConverterAttribute("JetBrains.VsIntegration.ActionManagement.VsShortcutConverter")]
    public class VsShortcut : JetBrains.ActionManagement.ActionShortcut
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string Scope;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ActionManagement.ActionShortcut Shortcut;
        public VsShortcut([JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.ActionShortcut shortcut, [JetBrains.Annotations.NotNullAttribute()] string scope) { }
        public VsShortcut([JetBrains.Annotations.NotNullAttribute()] string bindingsString, JetBrains.VsIntegration.ActionManagement.VsBindingsConverter bindingsConverter) { }
        public override JetBrains.ActionManagement.KeyboardShortcut[] KeyboardShortcuts { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class VsShortcutConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.VsIntegration.ActionManagement.VsShortcut>
    {
        public VsShortcutConverter() { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class VsShortcutManager : JetBrains.UI.ActionSystem.ShortcutManager.ShortcutManagerBase<JetBrains.UI.ActionSystem.ShortcutManager.SchemeEntry>, JetBrains.ActionManagement.ActionLoader.IActionLoadClient
    {
        public const string GlobalScope = "Global";
        public static readonly JetBrains.DataFlow.PropertyId<bool> IsOobeChoosingAltKeyboardScheme;
        public const string TextEditorScope = "Text Editor";
        public VsShortcutManager(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.VsIntegration.ActionManagement.VsActionManager actionManager, 
                    JetBrains.Application.IApplicationDescriptor descriptor, 
                    JetBrains.VsIntegration.ActionManagement.VsBindingsConverter bindingsConverter, 
                    EnvDTE.DTE dte, 
                    JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor, 
                    Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, 
                    JetBrains.UI.Application.IMainWindow mainWindow, 
                    JetBrains.VsIntegration.ActionManagement.VsActionManagerSettingsStorage shortcutsSettingsStorage, 
                    JetBrains.Application.DataContext.DataContexts dataContexts, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.VsIntegration.Settings.VsToolsOptionsMonitor toolsOptionsMonitor, 
                    Microsoft.VisualStudio.Shell.Interop.IVsProfileDataManager vsProfileDataManager, 
                    JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, 
                    JetBrains.VsIntegration.ActionManagement.VsLocalizer vsLocalizer) { }
        public override void AddShortcut(JetBrains.ActionManagement.ShortcutScheme scheme, JetBrains.ActionManagement.IExecutableAction action, JetBrains.ActionManagement.ShortcutScope scope, JetBrains.ActionManagement.ActionShortcut shortcut) { }
        public override void ApplyShortcutScheme(JetBrains.ActionManagement.ShortcutScheme scheme, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override void ApplyShortcutToCurrentScheme(JetBrains.ActionManagement.IExecutableAction action, JetBrains.ActionManagement.ShortcutScope scope, JetBrains.ActionManagement.ActionShortcut shortcut) { }
        protected override JetBrains.UI.ActionSystem.ShortcutManager.SchemeEntry CreateSchemeEntry(JetBrains.ActionManagement.ShortcutScheme scheme) { }
        public System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ActionManagement.ActionShortcut, JetBrains.ActionManagement.ShortcutScope>> GetBaseShortcuts(JetBrains.ActionManagement.IExecutableAction action) { }
        public override System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ActionManagement.ActionShortcut, JetBrains.ActionManagement.ShortcutScope>> GetShortcutsWithScopes(JetBrains.ActionManagement.IExecutableAction action) { }
        public System.Collections.Generic.IList<string> GetVsScopes(JetBrains.ActionManagement.ShortcutScope scope) { }
        public void OnAfterBulkShortcutsChange(bool doApply) { }
        public void OnAfterLoadActions(JetBrains.ActionManagement.ActionsXmlInfo info) { }
        public void OnAfterLoadActions(System.Collections.Generic.ICollection<JetBrains.ActionManagement.ActionsXmlInfo> infos) { }
        public void OnBeforeBulkShortcutsChange() { }
        public void OnBeforeLoadActions(JetBrains.ActionManagement.ActionsXmlInfo info) { }
        public void OnBeforeLoadActions(System.Collections.Generic.ICollection<JetBrains.ActionManagement.ActionsXmlInfo> infos) { }
        public override void RemoveShortcut(JetBrains.ActionManagement.ShortcutScheme scheme, JetBrains.ActionManagement.IExecutableAction action, JetBrains.ActionManagement.ShortcutScope scope, JetBrains.ActionManagement.ActionShortcut shortcut) { }
        protected override void RemoveShortcutFromCurrentScheme(JetBrains.ActionManagement.IExecutableAction action, JetBrains.ActionManagement.ShortcutScope scope, JetBrains.ActionManagement.ActionShortcut shortcut) { }
    }
}
namespace JetBrains.VsIntegration.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class CollapseInSolutionExplorerAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowReferencesGivenByVS"})]
    public class ShowReferencesGivenByVs : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class VsCloseAllAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.VsIntegration.ActivityTracking
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsActionsTracker
    {
        public VsActionsTracker(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ActionManagement.VsActionManager actionManager, EnvDTE.DTE dte, Microsoft.VisualStudio.Shell.Interop.IVsCmdNameMapping vsCmdNameMapping, JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking) { }
    }
}
namespace JetBrains.VsIntegration.Application
{
    
    public interface IExposeVsServices
    {
        void Register([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap map);
    }
    public class static IServiceProviderEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TInterface GetService<TService, TInterface>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.OLE.Interop.IServiceProvider sp)
        
            where TInterface :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object GetService([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.OLE.Interop.IServiceProvider sp, System.Guid ssid, System.Guid iid) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TInterface TryGetService<TService, TInterface>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.OLE.Interop.IServiceProvider sp)
        
            where TInterface :  class { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object TryGetService([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.OLE.Interop.IServiceProvider sp, System.Guid serviceGuid, System.Guid interfaceGuid) { }
    }
    public interface IVsEnvironmentInformation
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath DevEnvInstallDir { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string VsHive { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string VsRootSuffix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Version VsVersion2 { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Version VsVersion4 { get; }
        string GetVisualStudioGlobalRegistryPath();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath GetVsAppDataPath(System.Environment.SpecialFolder spec);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath GetVsInstallDirFromRegistry();
        string GetVsRegistryKey(string sSubkey);
    }
    public class JetVisualStudioHost : JetBrains.Application.Env.IJetHost
    {
        public static readonly string ConfigurationVsPrefix;
        public JetBrains.Application.Env.JetEnvironment Environment { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Application.JetVisualStudioHost GetOrCreateHost([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IServiceProvider vsServiceProvider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string MakeVsVersionCongiguration([JetBrains.Annotations.NotNullAttribute()] System.Version vsVersion2) { }
    }
    public class RawVsServiceProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly Microsoft.VisualStudio.OLE.Interop.IServiceProvider Value;
        public RawVsServiceProvider([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IServiceProvider value) { }
    }
    public class static ShellComponentsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ActionManagement.VsActionManager VsActionManager([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ActionManagement.IActionManager actionman) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Interop.Events.VsSelection VsSelection([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Application.ShellComponentsVsShims VsShims([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
    }
    public struct ShellComponentsVsShims
    {
        public ShellComponentsVsShims(JetBrains.Application.Components.IComponentContainer shell) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Components.IComponentContainer Shell { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents VsRunningDocumentTableEvents() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.Interop.Events.VsTextManagerEvents VsTextManagerEvents() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class VsAnyProductSettingsLocation : JetBrains.Application.Env.Components.AnyProductSettingsLocation
    {
        public VsAnyProductSettingsLocation(JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.Util.FileSystemPath, System.Version>> GetLegacyUserSettingsRoamingLegacyDirs(JetBrains.Application.IProductNameAndVersion product) { }
        public override System.Collections.Generic.IList<JetBrains.Util.JetTuple<string, string>> GetSettingsPathSuffixAdditionalParameters() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsCommandProcessor : JetBrains.Application.CommandProcessing.StandaloneCommandProcessor
    {
        public VsCommandProcessor(JetBrains.DataFlow.Lifetime lifetime, EnvDTE.DTE dte) { }
        public void NotifyBeforeTextBufferChange() { }
        public void WithVsCommand(System.ComponentModel.Design.CommandID commandid, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsDocumentCommandProcessor : JetBrains.DocumentModel.CommandProcessing.DocumentCommandProcessor
    {
        public VsDocumentCommandProcessor(JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.VsIntegration.DocumentModel.IVsOleUndoManagerProvider vsOleUndoManagerProvider) { }
        public override void AddUndoRedoHandlers(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.Util.IUndoRedoHandler> handlers) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class VsEnvironmentInformation : JetBrains.VsIntegration.Application.IVsEnvironmentInformation
    {
        public VsEnvironmentInformation([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 localRegistry2) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetVsInstallDirFromRegistry() { }
        public class static Discovery
        {
            public static readonly string VisualStudioRegistryPathNoHive;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static JetBrains.Util.FileSystemPath GetDevEnvDir([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 lreg) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.Util.FileSystemPath GetMsEnvDllPath() { }
            public static string GetVisualStudioRegistryPath([JetBrains.Annotations.NotNullAttribute()] string sVsHive) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.Util.FileSystemPath GetVsAppDataPath(System.Environment.SpecialFolder spec, [JetBrains.Annotations.NotNullAttribute()] System.Version versionVs, [JetBrains.Annotations.NotNullAttribute()] string sVsRootSuffix) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string GetVsHive([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 lreg) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.Util.FileSystemPath GetVsInstallDirFromRegistry([JetBrains.Annotations.NotNullAttribute()] string sLocalRegistryRoot) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string GetVsRootSuffix([JetBrains.Annotations.NotNullAttribute()] System.Version vsVersion, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 localRegistry2) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static System.Version GetVsVersion4() { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static System.Version TryGetVsVersionFromDllVersion() { }
        }
    }
    public class VsEnvironmentInformationEmulated : JetBrains.VsIntegration.Application.IVsEnvironmentInformation
    {
        public VsEnvironmentInformationEmulated([JetBrains.Annotations.NotNullAttribute()] System.Version versionVs, [JetBrains.Annotations.CanBeNullAttribute()] string sRootSuffix) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class VsExtensionManagerSupportedProductsProvider : JetBrains.Application.Extensions.IExtensionManagerSupportedProductsProvider
    {
        public VsExtensionManagerSupportedProductsProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.IProductNameAndVersion> GetSupportedProducts() { }
    }
    public class VsHostCommandLine : JetBrains.Application.ICommandLine, JetBrains.Application.IHostCommandLine
    {
        public VsHostCommandLine([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine vsAppCommandLine, [JetBrains.Annotations.NotNullAttribute()] string sVsHiveRootSuffix, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath startupDirectory) { }
        public System.Collections.Generic.IList<string> Keys { get; }
        public System.Collections.Generic.IList<string> NonKeyedParameters { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCommandLineArgName([JetBrains.Annotations.NotNullAttribute()] string sArgName, [JetBrains.Annotations.NotNullAttribute()] string sProductName, [JetBrains.Annotations.NotNullAttribute()] string sVsRootSuffix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCommandLineText([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.CommandLineParameter> parameters, [JetBrains.Annotations.NotNullAttribute()] string sProductName, [JetBrains.Annotations.NotNullAttribute()] string sVsRootSuffix) { }
        public System.Collections.Generic.IList<string> GetKeyValues(string key, bool isCaseSensitive) { }
        public bool IsKeyDefined(string key, bool isCaseSensitive) { }
        public string TryGetKeyValue(string key, bool isCaseSensitive) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.Deferred, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.AnyThread)]
    public class VsHostCulture : JetBrains.Application.HostCulture
    {
        public VsHostCulture(Microsoft.VisualStudio.Shell.Interop.IUIHostLocale uiHostLocale) { }
        public override System.Globalization.CultureInfo Culture { get; }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class VsNonZombiedProductCanBeStarted : JetBrains.Application.Env.IProductCanBeStarted
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<Microsoft.VisualStudio.OLE.Interop.IServiceProvider> SiteNonZombiedGuarded;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<Microsoft.VisualStudio.OLE.Interop.IServiceProvider> SiteNonZombiedUnguarded;
        public VsNonZombiedProductCanBeStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.RawVsServiceProvider rsp, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
    }
    public class VsServiceProviderResolver : JetBrains.Application.Components.IValueResolver
    {
        public VsServiceProviderResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IServiceProvider vsServiceProvider) { }
        public VsServiceProviderResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IServiceProvider vsServiceProvider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartsCatalogueSet catalogset) { }
        public void DiscoverInterfaceWrappersInCatalog([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartsCatalogueSet catalogset) { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
        [System.FlagsAttribute()]
        public enum VsServiceFlags
        {
            IsLazyOnly = 1,
            IsOptional = 2,
        }
        public class VsServiceMap
        {
            public readonly Microsoft.VisualStudio.OLE.Interop.IServiceProvider VsServiceProvider;
            public VsServiceMap([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IServiceProvider vsServiceProvider) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap Ban<TInterface>(string comment = null) { }
            [JetBrains.Annotations.PureAttribute()]
            public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap.QueryServiceProxy QueryService<TService>() { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            [JetBrains.Annotations.PureAttribute()]
            public JetBrains.Application.Components.IValueDescriptor Resolve([JetBrains.Annotations.NotNullAttribute()] System.Type typeInterface, JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceFlags outside) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap Wrapper<TInterface>([JetBrains.Annotations.NotNullAttribute()] System.Func<TInterface> FCreateInstance, JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceFlags flags) { }
            public class DeferredComponentDescriptorWithLazyFlag : JetBrains.Application.Components.IComponentDescriptor, JetBrains.Application.Components.IValueDescriptor
            {
                public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceFlags Flags;
                public DeferredComponentDescriptorWithLazyFlag([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Application.Components.IValueRegistration> registrations, [JetBrains.Annotations.NotNullAttribute()] System.Func<object> factory) { }
                public override string ToString() { }
            }
            public class QueryServiceProxy
            {
                public QueryServiceProxy(System.Type typeServiceGuid, System.Func<System.Type, System.Type, JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap.DeferredComponentDescriptorWithLazyFlag> FRegisterRervice) { }
                [JetBrains.Annotations.NotNullAttribute()]
                public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap.QueryServiceProxy As<TInterface>() { }
                [JetBrains.Annotations.NotNullAttribute()]
                public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap.QueryServiceProxy LazyOnly() { }
                [JetBrains.Annotations.NotNullAttribute()]
                public JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap.QueryServiceProxy Optional() { }
            }
        }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class VsShowMsdnHelp : JetBrains.UI.Application.IShowHelp
    {
        public VsShowMsdnHelp(JetBrains.Util.Lazy.Lazy<JetBrains.VsIntegration.Application.IVsEnvironmentInformation> vsEnvironmentInformation, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.VSHelp80.Help2> vsHelp2) { }
    }
    public class VsUIHostCommandDispatcher : Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget Raw;
        public VsUIHostCommandDispatcher(Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget oleCommandTarget) { }
        public int Exec(ref System.Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, System.IntPtr pvaIn, System.IntPtr pvaOut) { }
        public int QueryStatus(ref System.Guid pguidCmdGroup, uint cCmds, Microsoft.VisualStudio.OLE.Interop.OLECMD[] prgCmds, System.IntPtr pCmdText) { }
    }
    public class static VsVersion
    {
        public static readonly System.Version VS71;
        public static readonly System.Version VS80;
        public static readonly System.Version VS90;
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.VsIntegration.Application.IExposeVsServices))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class WrapVsInterfacesAttribute : JetBrains.Application.Parts.PartAttribute { }
}
namespace JetBrains.VsIntegration.CodeEditorEmbedding
{
    
    public class CodeEditorUserControl : JetBrains.UI.CommonControls.SafeUserControl, Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget
    {
        public CodeEditorUserControl(JetBrains.UI.Application.IUIApplication environment) { }
        public Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow CodeWindow { get; }
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView VsTextView { get; }
        protected override void Dispose(bool disposing) { }
        public int Exec(ref System.Guid pguidCmdGroup, uint nCmdId, uint nCmdexecopt, System.IntPtr pvaIn, System.IntPtr pvaOut) { }
        public void Init(JetBrains.VsIntegration.Application.RawVsServiceProvider serviceProvider, JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textLines, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        protected override bool IsInputKey(System.Windows.Forms.Keys keyData) { }
        protected override void OnGotFocus(System.EventArgs e) { }
        protected override void OnSizeChanged(System.EventArgs e) { }
        public override bool PreProcessMessage(ref System.Windows.Forms.Message msg) { }
        public int QueryStatus(ref System.Guid pguidCmdGroup, uint cCmds, Microsoft.VisualStudio.OLE.Interop.OLECMD[] prgCmds, System.IntPtr pCmdText) { }
    }
    public class CreateVsCodeEditorParams : JetBrains.TextControl.CreateTextControlParams<JetBrains.VsIntegration.CodeEditorEmbedding.VsCodeEditorControl>
    {
        public CreateVsCodeEditorParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame) { }
    }
    public class VsCodeEditorControl : JetBrains.VsIntegration.CodeEditorEmbedding.CodeEditorUserControl, JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.TextControl.IWinFormTextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public static readonly JetBrains.Util.Key<JetBrains.VsIntegration.CodeEditorEmbedding.VsCodeEditorControl> VsCodeEditorUserDataKey;
        public VsCodeEditorControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.RawVsServiceProvider sp, JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer vsTextBuffer, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.VsIntegration.Whidbey.TextControl.VsTextControlOleCommandTarget CommandFilter { get; }
        public bool IsReadOnly { get; }
        public bool IsVsAlive { get; }
        public bool IsVsDead { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.TextControl.VsTextControlCommon VsTextControl { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> JetBrains.TextControl.ITextControl.BeforeDispose;
        public void AttachToTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.TextControl.VsTextControlCommon textcontrol) { }
        protected override void Dispose(bool disposing) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.CodeEditorEmbedding.VsCodeEditorControl GetByTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol) { }
        public Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget GetVsTextViewOleCommandTarget() { }
        public void PushOleCommandFilter(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget filter, out Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget callnext) { }
        public void SyncToVsGuarded() { }
        public void SyncToVsUnguarded() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.CodeEditorEmbedding.VsCodeEditorControl TryGetByTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol) { }
    }
}
namespace JetBrains.VsIntegration.DocumentModel
{
    
    public class static DocumentEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.VisualStudio.OLE.Interop.IOleUndoManager TryGetOleUndoManager([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IDocument document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.IVsOleUndoManagerProvider vsOleUndoManagerProvider) { }
    }
    public interface IVsOleUndoManagerProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        Microsoft.VisualStudio.OLE.Interop.IOleUndoManager TryGetOleUndoManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document);
    }
    public class ParentUndoUnit : Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit, Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit, System.IDisposable
    {
        public ParentUndoUnit(Microsoft.VisualStudio.OLE.Interop.IOleUndoManager undoManager, string description) { }
        public void Add(Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit pUU) { }
        public int Close(Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit pPUU, int fCommit) { }
        protected virtual JetBrains.VsIntegration.DocumentModel.ParentUndoUnit CreateRedoUnit(Microsoft.VisualStudio.OLE.Interop.IOleUndoManager pUndoManager) { }
        public void Dispose() { }
        public virtual void Do(Microsoft.VisualStudio.OLE.Interop.IOleUndoManager pUndoManager) { }
        public int FindUnit(Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit pUU) { }
        public void GetDescription(out string pBstr) { }
        public void GetParentState(out uint pdwState) { }
        public void GetUnitType(out System.Guid pClsid, out int plID) { }
        public void OnNextAdd() { }
        public void Open(Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit pPUU) { }
    }
    public abstract class VsDocumentCommon : JetBrains.DocumentModel.impl.ManagedDocumentBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2> PersistDocData;
        protected VsDocumentCommon([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.DocumentModelDocumentManagerEvents documentManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.Transactions.IDocumentTransactionManager transactionManager, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler, JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentModel.IDocumentOwner owner) { }
        public override void AssertOnDocumentModification() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsDocumentManagerSynchronization
    {
        public readonly JetBrains.Util.Concurrency.UnguardedCallbackMerger UnguardedCallbacks;
        public VsDocumentManagerSynchronization(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading) { }
    }
    public abstract class VsDocumentOperationsCommon : JetBrains.DocumentManagers.impl.DocumentOperationsImpl
    {
        protected VsDocumentOperationsCommon(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents vsRunningDocumentTableEvents, JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable rdt, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
    }
    public class VsDocumentOperationsHandlerWhidbey : JetBrains.VsIntegration.Whidbey.DocumentModel.IDocumentOperationsHandlerWhidbey, Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferDataEvents, Microsoft.VisualStudio.TextManager.Interop.IVsTextLinesEvents, Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamEvents, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.DataFlow.ICollectionEvents<object>> UserReadOnlyLocks;
        public VsDocumentOperationsHandlerWhidbey([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer vsTextStream, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEx vsFileChangeEx, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage) { }
        public bool ContainsPendingChanges { get; }
        public string Moniker { get; }
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer VsTextStream { get; }
        public event System.Action PendingChangesExecuted;
        public void Dispose() { }
        public void ExecutePendingChanges() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable ExpectChangeCallbackForOurActivity(System.Nullable<JetBrains.Util.TextRange> oldrange, System.Nullable<JetBrains.Util.TextRange> newrange) { }
        public string GetText(out System.Text.Encoding encoding) { }
        public int GetTextLength() { }
        public bool IsExpectingChangeCallbackForOurActivity(System.Nullable<JetBrains.Util.TextRange> oldrange, System.Nullable<JetBrains.Util.TextRange> newrange) { }
        public void SetDocument(JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey value) { }
        public void SynchronizeDocument(bool reconcile) { }
    }
    public class static VsRegisterHighlighterAttributeEx
    {
        public static System.Guid GetMarkerTypeGuid([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute attr, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        public static System.Guid GetMarkerTypeGuid(JetBrains.Application.Parts.PartCatalogueAttribute attr, JetBrains.Application.IProductNameAndVersion product) { }
    }
}
namespace JetBrains.VSIntegration.DocumentModel
{
    
    public class GroupingChangeUnit : System.IDisposable
    {
        public GroupingChangeUnit([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleUndoManager undoManager, [JetBrains.Annotations.NotNullAttribute()] string changeName, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
        public void Dispose() { }
    }
}
namespace JetBrains.VsIntegration.DocumentModel.Whidbey
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MapVsCookieToProjectFile
    {
        public MapVsCookieToProjectFile(JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable rdt) { }
        public System.Collections.Generic.ICollection<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE> VsCookies { get; }
        public void RemoveMapping(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE left, JetBrains.ProjectModel.IProjectFile right) { }
        public void SetMapping(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE left, JetBrains.ProjectModel.IProjectFile right, bool bIgnoreConflicts) { }
        public JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE TryGetDocCookieByTextBuffer(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.Whidbey.DocumentModel.VsTextBufferData TryGetTextBufferDataByDocCookie(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile TryMapDocCookieToProjectFile(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        public JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE TryMapProjectFileToDocCookie([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsDocumentManagerDocumentFactory : JetBrains.DocumentManagers.impl.StandaloneDocumentManagerDocumentFactory
    {
        public VsDocumentManagerDocumentFactory(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentModelDocumentManagerEvents documentManagerEvents, Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEx vsFileChangeEx, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.VsIntegration.DocumentModel.Whidbey.MapVsCookieToProjectFile mapping, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.DocumentManagers.Transactions.SolutionDocumentTransactionManager solutionDocumentTransactionManager) { }
        public override JetBrains.DocumentModel.IDocument CreateDocument(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.DocumentModel.IDocumentOwner owner) { }
        public override JetBrains.DocumentModel.IDocument CreateDocument(JetBrains.Util.FileSystemPath location, JetBrains.DocumentModel.IDocumentOwner owner) { }
    }
    public class VsDocumentWhidbey : JetBrains.VsIntegration.DocumentModel.VsDocumentCommon, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.Util.JetTuple<JetBrains.Util.TextRange, int>> AfterReplaceStream;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.Util.JetTuple<JetBrains.Util.TextRange, int>> BeforeReplaceStream;
        public VsDocumentWhidbey(JetBrains.DocumentModel.DocumentModelDocumentManagerEvents documentManager, JetBrains.DocumentModel.Transactions.IDocumentTransactionManager transactionManager, JetBrains.VsIntegration.Whidbey.DocumentModel.IDocumentOperationsHandlerWhidbey documentOperationsHandler, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler, JetBrains.Application.IShellLocks locks, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.DocumentModel.IDocumentOwner documentOwner) { }
        public JetBrains.VsIntegration.Whidbey.DocumentModel.IDocumentOperationsHandlerWhidbey DocumentOperationsHandler { get; }
        public override string Moniker { get; }
        public event System.EventHandler OnImplementationSwitch;
        protected override void ApplyInternalDocumentChange(JetBrains.DocumentModel.DocumentChange documentChange, bool underWriteLock, int timestamp) { }
        public void AttachToVsTextBuffer(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textStream, Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEx vsFileChangeEx, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        public bool ContainsPendingChanges() { }
        public override bool ContainsReadOnlyRegions() { }
        public void Dispose() { }
        public override void Dump(System.IO.TextWriter to) { }
        public void ExecutePendingChanges() { }
        public override string GetLineText(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> lineNumber) { }
        public override string GetText() { }
        public override string GetText(JetBrains.Util.TextRange fromRange) { }
        public override int GetTextLength() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer GetVsTextStream() { }
        public override System.IDisposable MakeReadonly(JetBrains.Util.TextRange range) { }
        public void OnCloseInEditor(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool OnVsTextBufferLoadCompleted(JetBrains.VsIntegration.DocumentModel.VsDocumentOperationsHandlerWhidbey vsdoh) { }
        public void SetDocumentOperationsHandler(JetBrains.VsIntegration.Whidbey.DocumentModel.IDocumentOperationsHandlerWhidbey value, bool creatingDocument, bool synchronizeText = True) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.DocumentModel.VsDocumentOperationsHandlerWhidbey TryGetVsDocumentOperationsHandler() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer TryGetVsTextStream() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsInMemoryDocumentFactoryWhidbey : JetBrains.DocumentManagers.impl.IdeInMemoryDocumentFactory
    {
        public VsInMemoryDocumentFactoryWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentModel.DocumentModelDocumentManagerEvents documentManagerEvents, JetBrains.Application.IShellLocks locks, Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEx vsFileChangeEx, Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 localRegistry2, JetBrains.VsIntegration.Application.RawVsServiceProvider rawVsServiceProvider, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager) { }
        public override JetBrains.DocumentModel.IDocument CreateIdeDocumentFromText(string text, string moniker, System.Func<JetBrains.DocumentModel.IDocument, JetBrains.Util.ModificationCookie> ensureWritableHandler) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsOleUndoManagerProviderWhidbey : JetBrains.VsIntegration.DocumentModel.IVsOleUndoManagerProvider { }
}
namespace JetBrains.VsIntegration.EditorManager.Install
{
    
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class InstallVsEditorFactoryAttribute : JetBrains.Application.Parts.PartAttribute
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Type FactoryBaseClass;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly string PresentableName;
        public InstallVsEditorFactoryAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type factoryBaseClass, [JetBrains.Annotations.CanBeNullAttribute()] string presentableName) { }
    }
    public class VsEditorFactoryHelpers
    {
        public static string GetEmittedFactoryClassLocalName([JetBrains.Annotations.NotNullAttribute()] System.Type typeFactory) { }
        public static System.Guid GetFactoryGuid([JetBrains.Annotations.NotNullAttribute()] System.Type typeFactoryBaseClass, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        public static void RegisterVsEditorFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory instance, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsRegisterEditors vsRegisterEditors) { }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.VsIntegration.EditorManager.Install.InstallVsEditorFactoryAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class VsEditorFactoryInstaller : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.VsIntegration.EditorManager.Install.InstallVsEditorFactoryAttribute> { }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageEmitEditorFactory : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitPackageServices, JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitSourceFiles
    {
        public VsPackageEmitEditorFactory(JetBrains.Application.Parts.IPartsCatalogue catalog, JetBrains.Application.IProductNameAndVersion product) { }
    }
}
namespace JetBrains.VsIntegration.EditorManager
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsEditorManager : JetBrains.IDE.EditorManager
    {
        public VsEditorManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument vsUiShellOpenDocument, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.UI.WindowManagement.IFrameFocusHelper frameFocusHelper, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public override void CloseTextControl(JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void EnablePreviewTab() { }
        public override bool IsOpenedInTextControl(JetBrains.ProjectModel.IProjectFile file) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public override JetBrains.TextControl.ITextControl OpenFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath fileName, bool activate, JetBrains.IDE.TabOptions tabOptions) { }
        protected virtual bool OpenInProvisionTab(JetBrains.IDE.TabOptions tabOptions) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public override JetBrains.TextControl.ITextControl OpenProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, bool activate, JetBrains.IDE.TabOptions tabOptions = 2) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public override JetBrains.TextControl.ITextControl OpenProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, bool activate, JetBrains.IDE.FileView fileViewPrimary, JetBrains.IDE.TabOptions tabOptions = 2) { }
        public override JetBrains.TextControl.ITextControl TryGetTextControl(JetBrains.ProjectModel.IProjectFile file) { }
    }
}
namespace JetBrains.VsIntegration.Extension
{
    
    public class static DteEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static Microsoft.VisualStudio.CommandBars.CommandBars CommandBars([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.DTE dte) { }
    }
    public class static ILocalRegistryEx
    {
        public static object CreateObject([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.ILocalRegistry localRegistry, System.Guid clsid, System.Guid iid) { }
        public static object CreateObjectWithSite([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.ILocalRegistry localRegistry, System.Guid clsid, System.Guid iid, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IServiceProvider serviceProvider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetLocalRegistryRoot([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 lreg) { }
    }
    public class static IVsFilterKeysEx
    {
        public static bool TranslateAcceleratorEx([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsFilterKeys2 filterKeys2, Microsoft.VisualStudio.OLE.Interop.MSG oleMsg, Microsoft.VisualStudio.Shell.Interop.@__VSTRANSACCELEXFLAGS scope) { }
        public static bool TranslateAcceleratorEx([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsFilterKeys2 filterKeys2, System.Windows.Interop.MSG winMsg, Microsoft.VisualStudio.Shell.Interop.@__VSTRANSACCELEXFLAGS scope) { }
    }
}
namespace JetBrains.VsIntegration.Features.Debugger
{
    
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("8FE5CC0C-8C34-40E2-90A6-00940417A962")]
    public class DebuggerHostApi : JetBrains.VsIntegration.Features.Debugger.IDebuggerHostApi
    {
        public DebuggerHostApi([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Features.Debugger.DebuggerHostServer server) { }
        public void AttachToProcess(uint pid) { }
        public void DetachAll() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Features.Debugger.IDebuggerHostApi GetInstance(uint process, [JetBrains.Annotations.NotNullAttribute()] string sProductName) { }
    }
    public class DebuggerHostClient
    {
        public static void AttachDebugger([JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.Process debugger, [JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.Process debuggee, [JetBrains.Annotations.NotNullAttribute()] string sProductName) { }
        public static void DetachAll([JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.Process debugger, [JetBrains.Annotations.NotNullAttribute()] string sProductName) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DebuggerHostServer
    {
        public static readonly bool OptionTrace;
        public DebuggerHostServer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger2> vsDebugger2, Microsoft.VisualStudio.Shell.Interop.IVsUIShell vsUiShell, EnvDTE.DTE getService, JetBrains.Application.IApplicationDescriptor product, JetBrains.Threading.IThreading invocator) { }
        public void AttachToProcess(uint pid) { }
        public void DetachAll() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Features.Debugger.IDebuggerHostApi GetInstance([JetBrains.Annotations.NotNullAttribute()] uint process, [JetBrains.Annotations.NotNullAttribute()] string sProductName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object GetInstanceDynamic([JetBrains.Annotations.NotNullAttribute()] uint process, [JetBrains.Annotations.NotNullAttribute()] string sProductName) { }
        public static string GetRemoteIdentity([JetBrains.Annotations.NotNullAttribute()] uint process, [JetBrains.Annotations.NotNullAttribute()] string sProductName) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("151AB269-1EC6-4841-B860-70E96D77FD4A")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    public interface IDebuggerHostApi
    {
        void AttachToProcess(uint pid);
        void DetachAll();
    }
}
namespace JetBrains.VsIntegration.IDE
{
    
    public class AnonymousOleCommandTarget : Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget
    {
        public AnonymousOleCommandTarget(JetBrains.DataFlow.OuterLifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.IDE.AnonymousOleCommandTarget.QueryStatusHandler FQueryStatus, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.IDE.AnonymousOleCommandTarget.ExecHandler FExec, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Threading.IThreading threading) { }
        public delegate JetBrains.Interop.WinApi.HResults ExecHandler([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, Microsoft.VisualStudio.OLE.Interop.OLECMDEXECOPT nCmdExecOpt, System.IntPtr vIn, System.IntPtr vOut);
        public delegate JetBrains.Interop.WinApi.Declarations.Constants.OLECMDF QueryStatusHandler([JetBrains.Annotations.NotNullAttribute()] System.ComponentModel.Design.CommandID commandid, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.dataStructures.Boxed<string> sOutCmdText);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class Dev10AsyncCtpDetector
    {
        public Dev10AsyncCtpDetector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.ViewableProjectsCollection projects, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
        public bool IsAsyncCtpEnabled(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class JetVsOleComponent : Microsoft.VisualStudio.OLE.Interop.IOleComponent
    {
        public JetVsOleComponent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleComponentManager oleComponentManager, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsFilterKeys2 vsFilterKeys2) { }
        public void RegisterWindow(System.Windows.Window window) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsDebuggerMonitor : Microsoft.VisualStudio.Shell.Interop.IVsDebuggerEvents
    {
        public VsDebuggerMonitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.DTE dte, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger> vsDebugger) { }
        public JetBrains.DataFlow.IProperty<JetBrains.VsIntegration.IDE.VsDebuggerState> DebuggerState { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.IDE.VsDebuggerState> DebuggerStateChanged { get; }
        public bool EditAndContinueEnabled { get; }
        protected virtual bool GetEditAndContinue() { }
    }
    public enum VsDebuggerState
    {
        Null = 0,
        Off = 1,
        Breakpoint = 2,
        Running = 3,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsOnIdle : Microsoft.VisualStudio.OLE.Interop.IOleComponent
    {
        public VsOnIdle([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleComponentManager oleComponentManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.ApplicationIdleEvent applicationIdleEvent) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsResultListIdeActions : JetBrains.IDE.ResultList.ResultListIdeActions
    {
        public VsResultListIdeActions([JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.ResultListValue resultListValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        public override System.Action GoToNextLocation(JetBrains.DataFlow.Lifetime lifetimeExec, JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation) { }
        public override System.Action GoToPrevLocation(JetBrains.DataFlow.Lifetime lifetimeExec, JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsResultListSync
    {
        public VsResultListSync(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, JetBrains.IDE.ResultList.ResultListValue resultListValue, JetBrains.Threading.IThreading threading, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.Application.Settings.ISettingsStore settings, JetBrains.Util.ILogger logger) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Controls interaction between our ResultList and Visual Studio\'s SEID_ResultList s" +
        "election item.")]
    public class VsSeidResultListSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enables two-way synchronization with Visual Studio: our result lists are traversi" +
            "ble with standard VS shortcuts, and our shortcuts would walk standard VS lists l" +
            "ike Output and Errors.")]
        public bool IsSynchronizingResultListWithVsSeidResultList;
    }
}
namespace JetBrains.VsIntegration.Infra
{
    
    public sealed class ConnectionPointCookie<TEventInterface>
        where TEventInterface :  class
    {
        public static void CreateApartmentThreaded([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Runtime.InteropServices.ComTypes.IConnectionPointContainer source, [JetBrains.Annotations.NotNullAttribute()] TEventInterface sink, [JetBrains.Annotations.NotNullAttribute()] string origin) { }
        public static void CreateSingleThreaded([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Runtime.InteropServices.ComTypes.IConnectionPointContainer source, [JetBrains.Annotations.NotNullAttribute()] TEventInterface sink, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] string origin) { }
    }
    public sealed class ConnectionPointVsCookie<TEventInterface>
        where TEventInterface :  class
    {
        public static void CreateApartmentThreaded([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer source, [JetBrains.Annotations.NotNullAttribute()] TEventInterface sink, [JetBrains.Annotations.NotNullAttribute()] string origin) { }
        public static void CreateSingleThreaded([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer source, [JetBrains.Annotations.NotNullAttribute()] TEventInterface sink, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] string origin) { }
    }
    public class static IVsSolutionEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetSolutionHitem([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsSolution vssol) { }
    }
}
namespace JetBrains.VsIntegration.Install
{
    
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.Application.CommandLineSwitchAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class CommandLineInstallerVs : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.Application.CommandLineSwitchAttribute> { }
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class EmittedVsPackageInstaller : JetBrains.Application.Install.IStaticInstaller { }
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class InstallDirInstallerVs : JetBrains.Application.Install.IStaticInstaller { }
    public class static InstallerEx
    {
        public static JetBrains.VsIntegration.Application.IVsEnvironmentInformation VsEnvironment([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Install.Installer thіs) { }
    }
    public class static RegistrationUtil
    {
        public static void CleanupUIFromVisualStudio(string vsVersion, string vsRootSuffix, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetDevEnvInstallDirFromRegistry([JetBrains.Annotations.NotNullAttribute()] string sVsHive) { }
        public class MessageFilter : JetBrains.VsIntegration.Install.RegistrationUtil.IOleMessageFilter
        {
            public static void Register() { }
            public static void Revoke() { }
        }
    }
}
namespace JetBrains.VsIntegration.Install.VsPackageAssembly
{
    
    public class BitmapResource
    {
        public readonly JetBrains.UI.Icons.IconId Bitmap;
        public readonly int ResourceID;
        public readonly JetBrains.VsIntegration.Install.VsPackageAssembly.VsBitmapResourceKind ResourceKind;
        public bool IsAllocatedBy([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Install.VsPackageAssembly.BitmapResourceAllocator bitmapResourceAllocator) { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class BitmapResourceAllocator
    {
        public BitmapResourceAllocator() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.VsIntegration.Install.VsPackageAssembly.BitmapResource> Resources { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.Install.VsPackageAssembly.BitmapResource Allocate([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IconId bmp, JetBrains.VsIntegration.Install.VsPackageAssembly.VsBitmapResourceKind reskind) { }
        public void Freeze() { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class EmitAssemblyReferencesForClasses : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitMsbuildItems
    {
        public EmitAssemblyReferencesForClasses(System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitSourceFiles> emitterscode) { }
        public class AssemblyWithHintPath
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Util.FileSystemPath HintPath;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Metadata.Utils.AssemblyNameInfo Name;
            public AssemblyWithHintPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath hintPath) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.VsIntegration.Install.VsPackageAssembly.EmitAssemblyReferencesForClasses.AssemblyWithHintPath FromAssembly([JetBrains.Annotations.NotNullAttribute()] System.Reflection.Assembly ass) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.VsIntegration.Install.VsPackageAssembly.EmitAssemblyReferencesForClasses.AssemblyWithHintPath FromType([JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class EmitBitmapResourcesToResx : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitResXDataNodes
    {
        public EmitBitmapResourcesToResx(System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitBitmapResources> bitmapemitters, JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterParameters parameters, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.UI.Icons.IThemedIconManager iconman, JetBrains.VsIntegration.Install.VsPackageAssembly.BitmapResourceAllocator bitmapResourceAllocator) { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class EmitCodeClassesToDiskFiles : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitMsbuildItems
    {
        public EmitCodeClassesToDiskFiles(System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitSourceFiles> emitterscode, JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterParameters parameters, JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo packageinfo) { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class EmitResXDataNodesToFile : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitMsbuildItems
    {
        public EmitResXDataNodesToFile([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitResXDataNodes> resxemitters, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterParameters parameters) { }
    }
    public interface IEmitBitmapResources
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.BitmapResource> CommitToResources();
    }
    public interface IEmitMsbuildItems
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.MsbuildItem> CommitToMsbuildItems();
    }
    public interface IEmitPackageServices
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<System.Type, System.CodeDom.CodeTypeReference>> CommitToPackageServices();
    }
    public interface IEmitResXDataNodes
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<System.Resources.ResXDataNode> CommitToResX();
    }
    public interface IEmitSourceFiles
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<System.CodeDom.CodeTypeDeclaration> CommitToSourceFiles();
    }
    public interface IVsExtensionClipart
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Drawing.Image BmpForVsSplashScreen { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Drawing.Image ProductPreviewExtensionManager { get; }
    }
    public class MsbuildItem
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string ItemName;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string ItemSpec;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.IDictionary<string, string> Metadata;
        public MsbuildItem([JetBrains.Annotations.NotNullAttribute()] string itemName, [JetBrains.Annotations.NotNullAttribute()] string itemSpec) { }
        public MsbuildItem([JetBrains.Annotations.NotNullAttribute()] string itemName, [JetBrains.Annotations.NotNullAttribute()] string itemSpec, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<string, string> metadata) { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class ProductIconClassesIndex
    {
        public ProductIconClassesIndex([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartsCatalogue catalog) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.Icons.CompiledIcons.CompiledIconId GetIconId([JetBrains.Annotations.NotNullAttribute()] string sIconTypeFullName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyUsage, [JetBrains.Annotations.NotNullAttribute()] string sReferencingObjectName) { }
    }
    public enum VsBitmapResourceKind
    {
        CommandImage = 0,
        WindowFrameBitmap = 1,
    }
    public class static VsPackageAssemblyConstants
    {
        public static readonly int BitmapResourceBaseId;
        public static readonly int CtoResourceId;
        public static readonly uint IdBmpSplash;
        public static readonly uint IdIcoLogoForAboutbox;
        public static readonly int PackageLoadKeyResourceId;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.Icons.IconThemeAspect GetDefaultGenericIconThemeForVs([JetBrains.Annotations.NotNullAttribute()] System.Version vsVersion2, System.Nullable<bool> isDarkTheme = null, System.Nullable<bool> isMonochrome = null) { }
    }
    public class VsPackageAssemblyEmitterComponentAttribute : JetBrains.Application.Components.ComponentAttribute { }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageAssemblyEmitterIconManager : JetBrains.UI.Icons.IThemedIconManager
    {
        public VsPackageAssemblyEmitterIconManager(JetBrains.DataFlow.Lifetime lifeComponentsGuarded, JetBrains.Threading.IThreading threading, JetBrains.Util.ILogger logger, JetBrains.Application.Parts.IPartsCatalogue catalog, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
    }
    public class VsPackageAssemblyEmitterParameters
    {
        public readonly System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> CsprojImports;
        public readonly JetBrains.Util.FileSystemPath EmitOutputFolder;
        public readonly JetBrains.Util.FileSystemPath ProductBinariesDir;
        public readonly JetBrains.Util.FileSystemPath VsActionIdStoreFile;
        public readonly System.Collections.Generic.List<JetBrains.Util.FileSystemPath> VsMenuDefFiles;
        public VsPackageAssemblyEmitterParameters([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath emitOutputFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath productBinariesDir, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> csprojImports, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathVsActionIdStoreFile, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.Util.FileSystemPath> vsmenudef) { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageClassEmitter : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitSourceFiles
    {
        public VsPackageClassEmitter(JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo packageinfo, JetBrains.Application.IApplicationDescriptor product, System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitPackageServices> emitterssvc, JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClipartWriter clipart) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.CodeDom.CodeTypeDeclaration Run([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo packageinfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.Util.JetTuple<System.Type, System.CodeDom.CodeTypeReference>> services, JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageClipartResourceIds properties) { }
        public struct PackageClipartResourceIds
        {
            public System.Nullable<uint> IdBmpSplash;
            public System.Nullable<uint> IdIcoLogoForAboutbox;
        }
        [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
        [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
        public class PackageInfo
        {
            public PackageInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product, [JetBrains.Annotations.NotNullAttribute()] System.Version vsVersion2) { }
            public PackageInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
            public PackageInfo(JetBrains.Application.Install.Installer installer) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public string PackageAssembly_FullName { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string PackageAssembly_LocalName { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string PackageClass_FullName { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string PackageClass_LocalName { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string PackageClass_Namespace { get; }
            public System.Guid PackageGuid { get; }
            public JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo.PackageLoadKeyInfo PackageLoadKey { get; }
            public class PackageLoadKeyInfo
            {
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string CompanyName;
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string PLK;
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string ProductName;
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string ProductVersion2;
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string VsMinEdition;
                public PackageLoadKeyInfo([JetBrains.Annotations.NotNullAttribute()] string companyName, [JetBrains.Annotations.NotNullAttribute()] string productName, [JetBrains.Annotations.NotNullAttribute()] string productVersion2, [JetBrains.Annotations.NotNullAttribute()] string vsMinEdition, [JetBrains.Annotations.NotNullAttribute()] string plk) { }
                [JetBrains.Annotations.NotNullAttribute()]
                public static JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo.PackageLoadKeyInfo Parse([JetBrains.Annotations.NotNullAttribute()] string value) { }
                public override string ToString() { }
            }
        }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageClipartWriter : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitResXDataNodes
    {
        public VsPackageClipartWriter(JetBrains.Application.IApplicationDescriptor product, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterParameters parameters, JetBrains.VsIntegration.Install.VsPackageAssembly.IVsExtensionClipart vsExtensionClipart) { }
        public JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageClipartResourceIds GetClipart() { }
    }
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageLoadKeyEmitter : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitResXDataNodes
    {
        public VsPackageLoadKeyEmitter(JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageClassEmitter.PackageInfo packageinfo) { }
    }
    public class static VsResourceHelper
    {
        public static void WriteIconBitmapFile(JetBrains.UI.Icons.IconId iconid, JetBrains.Util.FileSystemPath path, System.Version vsVersion, JetBrains.UI.Icons.IThemedIconManager iconman, JetBrains.VsIntegration.Install.VsPackageAssembly.VsBitmapResourceKind reskind) { }
    }
}
namespace JetBrains.VsIntegration.Interop.Declarations
{
    
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("9C52F596-60FB-4144-BE49-ADCA8F044790")]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(4160)]
    public interface CSharpProjectProperties4 : VSLangProj.ProjectProperties, VSLangProj2.ProjectProperties2, VSLangProj80.ProjectProperties3
    {
        [System.Runtime.InteropServices.DispIdAttribute(12201)]
        [get: System.Runtime.InteropServices.DispIdAttribute(12201)]
        [set: System.Runtime.InteropServices.DispIdAttribute(12201)]
        string ApplicationManifest { get; set; }
        [System.Runtime.InteropServices.ComAliasNameAttribute("VSLangProj80.DWORD")]
        [System.Runtime.InteropServices.DispIdAttribute(12200)]
        [get: System.Runtime.InteropServices.DispIdAttribute(12200)]
        [set: System.Runtime.InteropServices.DispIdAttribute(12200)]
        uint TargetFramework { get; set; }
    }
    [System.Runtime.InteropServices.GuidAttribute("289E9AF2-4973-11D1-AE81-00A0C90F26F4")]
    public enum DisconnectMode
    {
        HostShutdown = 0,
        UserClosed = 1,
        UISetupComplete = 2,
        SolutionClosed = 3,
    }
    [System.Runtime.InteropServices.GuidAttribute("289E9AF1-4973-11D1-AE81-00A0C90F26F4")]
    public enum ext_ConnectMode
    {
        AfterStartup = 0,
        Startup = 1,
        External = 2,
        CommandLine = 3,
        Solution = 4,
        UISetup = 5,
    }
    [System.Runtime.InteropServices.GuidAttribute("B65AD801-ABAF-11D0-BB8B-00A0C90F2744")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(4160)]
    public interface IDTExtensibility2
    {
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        void OnAddInsUpdate(ref System.Array custom);
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        void OnBeginShutdown(ref System.Array custom);
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void OnConnection(object Application, JetBrains.VsIntegration.Interop.Declarations.ext_ConnectMode ConnectMode, object AddInInst, ref System.Array custom);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void OnDisconnection(JetBrains.VsIntegration.Interop.Declarations.DisconnectMode RemoveMode, ref System.Array custom);
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        void OnStartupComplete(ref System.Array custom);
    }
    [System.Runtime.InteropServices.GuidAttribute("39D4F2AE-776E-4948-BDA3-8DEE4C5D4ABD")]
    public enum pkgOptionInfer
    {
        pkgOptionInferOff = 0,
        pkgOptionInferOn = 1,
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.GuidAttribute("C530B098-ACC9-434E-9671-124EAA73FA00")]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(4160)]
    public interface VBProjectProperties4 : VSLangProj.ProjectProperties, VSLangProj2.ProjectProperties2, VSLangProj80.ProjectProperties3, VSLangProj80.VBProjectProperties3
    {
        [System.Runtime.InteropServices.DispIdAttribute(12201)]
        [get: System.Runtime.InteropServices.DispIdAttribute(12201)]
        [set: System.Runtime.InteropServices.DispIdAttribute(12201)]
        string ApplicationManifest { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(15101)]
        [get: System.Runtime.InteropServices.DispIdAttribute(15101)]
        [set: System.Runtime.InteropServices.DispIdAttribute(15101)]
        JetBrains.VsIntegration.Interop.Declarations.pkgOptionInfer OptionInfer { get; set; }
        [System.Runtime.InteropServices.ComAliasNameAttribute("VSLangProj80.DWORD")]
        [System.Runtime.InteropServices.DispIdAttribute(12200)]
        [get: System.Runtime.InteropServices.DispIdAttribute(12200)]
        [set: System.Runtime.InteropServices.DispIdAttribute(12200)]
        uint TargetFramework { get; set; }
    }
}
namespace JetBrains.VsIntegration.Interop.Declarations.TextManager
{
    
    public enum BufferLockFlags : uint
    {
        BLF_READ = 0u,
        BLF_READ_AND_WRITE = 1u,
    }
    [System.FlagsAttribute()]
    public enum BUFFERSTATEFLAGS : uint
    {
        BSF_USER_READONLY = 1u,
        BSF_FILESYS_READONLY = 2u,
        BSF_MODIFIED = 4u,
        BSF_SUPPRESS_UI = 8u,
        BSF_RESERVED = 4294967288u,
    }
    [JetBrains.Util.NoReorder()]
    [System.Runtime.InteropServices.ComConversionLossAttribute()]
    public struct FONTCOLORPREFERENCES
    {
        [System.Runtime.InteropServices.ComConversionLossAttribute()]
        public System.Void* hBoldViewFont;
        [System.Runtime.InteropServices.ComConversionLossAttribute()]
        public System.Void* hRegularViewFont;
        public System.Void* pColorTable;
        [System.Runtime.InteropServices.ComConversionLossAttribute()]
        public System.Void* pguidColorCategory;
        [System.Runtime.InteropServices.ComConversionLossAttribute()]
        public System.Void* pguidColorService;
        [System.Runtime.InteropServices.ComConversionLossAttribute()]
        public System.Void* pguidFontCategory;
    }
    [JetBrains.Util.NoReorder()]
    public struct FRAMEPREFERENCES
    {
        public uint fHorzScrollbar;
        public uint fVertScrollbar;
    }
    public enum GetSelectedAtomFlags : uint
    {
        gsaDefault = 0u,
    }
    [JetBrains.Util.NoReorder()]
    public struct LANGPREFERENCES
    {
        public uint fAutoListMembers;
        public uint fAutoListParams;
        public uint fDropdownBar;
        public uint fHideAdvancedAutoListMembers;
        public uint fHotURLs;
        public uint fInsertTabs;
        public uint fLineNumbers;
        public uint fShowCompletion;
        public uint fShowSmartIndent;
        public uint fTwoWayTreeview;
        public uint fVirtualSpace;
        public uint fWordWrap;
        public System.Guid guidLang;
        public JetBrains.VsIntegration.Interop.Declarations.TextManager.vsIndentStyle IndentStyle;
        [System.Runtime.CompilerServices.FixedBufferAttribute(typeof(byte), 24)]
        public JetBrains.VsIntegration.Interop.Declarations.TextManager.LANGPREFERENCES.<szFileType>e__FixedBuffer0 szFileType;
        public uint uIndentSize;
        public uint uTabSize;
    }
    public enum RelativeSelectionStateFlags : uint
    {
        RSS_DEFAULT = 0u,
        RSS_TOP_LAYER = 0u,
        RSS_BUFFER = 1u,
        RSS_RELATIVE_LAYER = 2u,
        RSS_TRACKSEL = 16u,
        RSS_SET_WITHOUT_SCROLLING = 4096u,
        RSS_SET_TO_NEAREST_LOCAL = 8192u,
        [System.ObsoleteAttribute("old flags for compatibility")]
        rssDefault = 0u,
        [System.ObsoleteAttribute("old flags for compatibility")]
        rssTopLayer = 0u,
        [System.ObsoleteAttribute("old flags for compatibility")]
        rssBuffer = 1u,
        [System.ObsoleteAttribute("old flags for compatibility")]
        rssRelativeLayer = 2u,
        [System.ObsoleteAttribute("old flags for compatibility")]
        rssTrackSel = 16u,
    }
    [JetBrains.Util.NoReorder()]
    public struct SELECTIONSTATE
    {
        public JetBrains.VsIntegration.Interop.Declarations.TextManager.SELECTIONSTATEFLAGS dwFlags;
        public uint dwReserved;
        public JetBrains.VsIntegration.Interop.Declarations.TextManager.ViewCol iActiveCol;
        public long iActiveLine;
        public JetBrains.VsIntegration.Interop.Declarations.TextManager.ViewCol iAnchorCol;
        public long iAnchorLine;
    }
    public enum SELECTIONSTATEFLAGS : uint
    {
        ssfDefault = 0u,
        ssfColumn = 1u,
    }
    [JetBrains.Util.NoReorder()]
    public struct ViewCol { }
    [JetBrains.Util.NoReorder()]
    public struct VIEWPREFERENCES
    {
        public uint fAutoDelimiterHighlight;
        public uint fDragDropEditing;
        public uint fDragDropMove;
        public uint fGoToAnchorAfterEscape;
        public uint fOvertype;
        public uint fSelectionMargin;
        public uint fUndoCaretMovements;
        public uint fVisibleWhitespace;
        public uint fWidgetMargin;
    }
    [System.Runtime.InteropServices.GuidAttribute("BCCEBE05-D29C-11D2-AABD-00C04F688DDE")]
    public enum vsIndentStyle
    {
        vsIndentStyleNone = 0,
        vsIndentStyleDefault = 1,
        vsIndentStyleSmart = 2,
    }
    public class static VsTextBufferGuids
    {
        public static readonly System.Guid DetectCharSet;
        public static readonly System.Guid DetectLangSID;
        public static readonly System.Guid Encoding;
        public static readonly System.Guid EncodingPromptOnLoad;
        public static readonly System.Guid EncodingVSTFF;
        public static readonly System.Guid IsDiskFile;
        public static readonly System.Guid Moniker;
    }
}
namespace JetBrains.VsIntegration.Interop.Declarations.VsShell
{
    
    public class Consts
    {
        public static readonly System.IntPtr DOCDATAEXISTING_UNKNOWN;
    }
    public enum FRAMECLOSE : uint
    {
        NoSave = 65792u,
        SaveIfDirty = 66048u,
        PromptSave = 66560u,
    }
    public enum FRAMESHOW
    {
        Hidden = 0,
        WinHidden = 0,
        WinShown = 1,
        TabActivated = 2,
        TabDeactivated = 3,
        WinRestored = 4,
        WinMinimized = 5,
        WinMaximized = 6,
        WinClosed = 7,
        DestroyMultInst = 8,
        AutoHideSlideBegin = 9,
    }
    public enum FRAMESHOW2
    {
        Hidden = 0,
        WinHidden = 0,
        WinShown = 1,
        TabActivated = 2,
        TabDeactivated = 3,
        WinRestored = 4,
        WinMinimized = 5,
        WinMaximized = 6,
        WinClosed = 7,
        DestroyMultInst = 8,
        AutoHideSlideBegin = 9,
        BeforeWinHidden = 10,
        AutoHideSlideEnd = 11,
    }
    public enum PropertySheetPageFlags : uint
    {
        PSP_DEFAULT = 0u,
        PSP_DLGINDIRECT = 1u,
        PSP_HASHELP = 32u,
        PSP_HIDEHEADER = 2048u,
        PSP_PREMATURE = 1024u,
        PSP_USECALLBACK = 128u,
        PSP_USEREFPARENT = 64u,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.GuidAttribute("E8B06F51-6D01-11D2-AA7D-00C04F990343")]
    public interface SVsWebBrowsingService { }
    public struct VSCOOKIE : System.IEquatable<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE>
    {
        public static readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE Invalid;
        public void AssertValid() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public enum VSCREATEWEBBROWSER : uint
    {
        VSCWB_AutoShow = 1u,
        VSCWB_AddToMRU = 2u,
        VSCWB_ReuseExisting = 16u,
        VSCWB_ForceNew = 32u,
        VSCWB_FrameMdiChild = 0u,
        VSCWB_FrameFloat = 64u,
        VSCWB_FrameDock = 128u,
        VSCWB_StartHome = 256u,
        VSCWB_StartSearch = 512u,
        VSCWB_StartCustom = 1024u,
        VSCWB_NoHistory = 65536u,
        VSCWB_NoReadCache = 131072u,
        VSCWB_NoWriteToCache = 262144u,
        VSCWB_AllowAutosearch = 524288u,
        VSCWB_OptionNoDocProps = 0u,
        VSCWB_OptionShowDocProps = 16777216u,
        VSCWB_OptionCustomDocProps = 33554432u,
        VSCWB_OptionDisableFind = 67108864u,
        VSCWB_OptionDisableDockable = 134217728u,
        VSCWB_OptionDisableStatusBar = 268435456u,
        VSCWB_StartURLMask = 3840u,
        VSCWB_NavOptionMask = 983040u,
        VSCWB_OptionsMask = 4278190080u,
    }
    public enum VSFPROPID
    {
        VSFPROPID_NIL = -1,
        VSFPROPID_LAST = -3000,
        VSFPROPID_Type = -3000,
        VSFPROPID_DocView = -3001,
        VSFPROPID_SPFrame = -3002,
        VSFPROPID_SPProjContext = -3003,
        VSFPROPID_Caption = -3004,
        [System.ObsoleteAttribute()]
        VSFPROPID_Obsolete3005 = -3005,
        [System.ObsoleteAttribute()]
        VSFPROPID_Obsolete3006 = -3006,
        VSFPROPID_WindowState = -3007,
        VSFPROPID_FrameMode = -3008,
        VSFPROPID_IsWindowTabbed = -3009,
        VSFPROPID_UserContext = -3010,
        VSFPROPID_ViewHelper = -3011,
        VSFPROPID_ShortCaption = -3012,
        VSFPROPID_WindowHelpKeyword = -3013,
        VSFPROPID_WindowHelpCmdText = -3014,
        VSFPROPID_DocCookie = -4000,
        VSFPROPID_OwnerCaption = -4001,
        VSFPROPID_EditorCaption = -4002,
        VSFPROPID_pszMkDocument = -4003,
        VSFPROPID_DocData = -4004,
        VSFPROPID_Hierarchy = -4005,
        VSFPROPID_ItemID = -4006,
        VSFPROPID_CmdUIGuid = -4007,
        VSFPROPID_CreateDocWinFlags = -4008,
        VSFPROPID_guidEditorType = -4009,
        VSFPROPID_pszPhysicalView = -4010,
        VSFPROPID_InheritKeyBindings = -4011,
        VSFPROPID_RDTDocData = -4012,
        VSFPROPID_AltDocData = -4013,
        VSFPROPID_GuidPersistenceSlot = -5000,
        [System.ObsoleteAttribute()]
        VSFPROPID_GuidAutoActivate = -5001,
        VSFPROPID_CreateToolWinFlags = -5002,
        VSFPROPID_ExtWindowObject = -5003,
        VSFPROPID_MultiInstanceToolNum = -5004,
        VSFPROPID_BitmapResource = -5006,
        VSFPROPID_BitmapIndex = -5007,
        VSFPROPID_ToolbarHost = -5008,
        VSFPROPID_HideToolwinContainer = -5009,
        VSFPROPID_FIRST = -5009,
    }
    public enum VSHPROPID
    {
        VSHPROPID_NIL = -1,
        VSHPROPID_LAST = -1000,
        VSHPROPID_Parent = -1000,
        VSHPROPID_FirstChild = -1001,
        VSHPROPID_NextSibling = -1002,
        [System.ObsoleteAttribute()]
        VSHPROPID_Root = -1003,
        VSHPROPID_TypeGuid = -1004,
        VSHPROPID_SaveName = -2002,
        VSHPROPID_Caption = -2003,
        VSHPROPID_IconImgList = -2004,
        VSHPROPID_IconIndex = -2005,
        VSHPROPID_Expandable = -2006,
        VSHPROPID_ExpandByDefault = -2011,
        [System.ObsoleteAttribute()]
        VSHPROPID_ProjectName = -2012,
        VSHPROPID_Name = -2012,
        VSHPROPID_IconHandle = -2013,
        VSHPROPID_OpenFolderIconHandle = -2014,
        VSHPROPID_OpenFolderIconIndex = -2015,
        VSHPROPID_CmdUIGuid = -2016,
        VSHPROPID_SelContainer = -2017,
        VSHPROPID_BrowseObject = -2018,
        VSHPROPID_AltHierarchy = -2019,
        VSHPROPID_AltItemid = -2020,
        VSHPROPID_ProjectDir = -2021,
        VSHPROPID_SortPriority = -2022,
        VSHPROPID_UserContext = -2023,
        VSHPROPID_EditLabel = -2026,
        VSHPROPID_ExtObject = -2027,
        VSHPROPID_ExtSelectedItem = -2028,
        VSHPROPID_StateIconIndex = -2029,
        VSHPROPID_ProjectType = -2030,
        VSHPROPID_TypeName = -2030,
        VSHPROPID_ReloadableProjectFile = -2031,
        VSHPROPID_HandlesOwnReload = -2031,
        VSHPROPID_ParentHierarchy = -2032,
        VSHPROPID_ParentHierarchyItemid = -2033,
        VSHPROPID_ItemDocCookie = -2034,
        VSHPROPID_Expanded = -2035,
        [System.ObsoleteAttribute()]
        VSHPROPID_ConfigurationProvider = -2036,
        VSHPROPID_ImplantHierarchy = -2037,
        VSHPROPID_OwnerKey = -2038,
        VSHPROPID_StartupServices = -2040,
        VSHPROPID_FirstVisibleChild = -2041,
        VSHPROPID_NextVisibleSibling = -2042,
        VSHPROPID_IsHiddenItem = -2043,
        VSHPROPID_IsNonMemberItem = -2044,
        VSHPROPID_IsNonLocalStorage = -2045,
        VSHPROPID_StorageType = -2046,
        VSHPROPID_ItemSubType = -2047,
        VSHPROPID_OverlayIconIndex = -2048,
        VSHPROPID_DefaultNamespace = -2049,
        VSHPROPID_IsNonSearchable = -2051,
        VSHPROPID_IsFindInFilesForegroundOnly = -2052,
        VSHPROPID_CanBuildFromMemory = -2053,
        VSHPROPID_PreferredLanguageSID = -2054,
        VSHPROPID_ShowProjInSolutionPage = -2055,
        VSHPROPID_AllowEditInRunMode = -2056,
        VSHPROPID_IsNewUnsavedItem = -2057,
        VSHPROPID_ShowOnlyItemCaption = -2058,
        VSHPROPID_ProjectIDGuid = -2059,
        VSHPROPID_DesignerVariableNaming = -2060,
        VSHPROPID_DesignerFunctionVisibility = -2061,
        VSHPROPID_HasEnumerationSideEffects = -2062,
        VSHPROPID_DefaultEnableBuildProjectCfg = -2063,
        VSHPROPID_DefaultEnableDeployProjectCfg = -2064,
        VSHPROPID_DescriptiveName = -2108,
        VSHPROPID_BuildAction = -2107,
        VSHPROPID_BuildDependencies = -2106,
        VSHPROPID_DesignTimeDependencies = -2105,
        VSHPROPID_SupportsAspNetIntegration = -2104,
        VSHPROPID_ExternalItem = -2103,
        VSHPROPID_TargetFrameworkMoniker = -2102,
        VSHPROPID_TargetPlatformVersion = -2115,
        VSHPROPID_TargetPlatformIdentifier = -2114,
    }
    public struct VSITEMID : System.IComparable<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID>, System.IEquatable<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID>
    {
        public static readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID VSITEMID_NIL;
        public static readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID VSITEMID_ROOT;
        public static readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID VSITEMID_SELECTION;
        public int CompareTo(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID other) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public enum VSPREVIEWRESOLUTION
    {
        PR_Default = 0,
        PR_640x480 = 1,
        PR_800x600 = 2,
        PR_1024x768 = 3,
    }
    [System.FlagsAttribute()]
    public enum VSRDTATTRIB : uint
    {
        RDTA_Hierarchy = 1u,
        RDTA_ItemID = 2u,
        RDTA_MkDocument = 4u,
        RDTA_DocDataIsDirty = 8u,
        RDTA_DocDataIsNotDirty = 16u,
        RDTA_NOTIFYDOCCHANGEDMASK = 4294901760u,
        RDTA_DocDataReloaded = 65536u,
        RDTA_AltHierarchyItemID = 131072u,
    }
    [System.FlagsAttribute()]
    public enum VSRDTFLAGS : uint
    {
        RDT_NoLock = 0u,
        RDT_ReadLock = 1u,
        RDT_EditLock = 2u,
        RDT_RequestUnlock = 4u,
        RDT_LOCKMASK = 7u,
        RDT_DontSaveAs = 8u,
        RDT_NonCreatable = 16u,
        RDT_DontSave = 32u,
        RDT_DontAutoOpen = 64u,
        RDT_CaseSensitive = 128u,
        RDT_CantSave = 40u,
        RDT_VirtualDocument = 4096u,
        RDT_ProjSlnDocument = 8192u,
        RDT_PlaceHolderDoc = 16384u,
        RDT_CanBuildFromMemory = 32768u,
        RDT_DontAddToMRU = 65536u,
        RDT_DOCMASK = 4294963448u,
        RDT_Unlock_NoSave = 256u,
        RDT_Unlock_SaveIfDirty = 512u,
        RDT_Unlock_PromptSave = 1024u,
        RDT_SAVEMASK = 3840u,
    }
    public enum VSRDTSAVEOPTIONS : uint
    {
        SaveIfDirty = 0u,
        PromptSave = 1u,
        ForceSave = 2u,
        SaveNoChildren = 4u,
        SaveOnlyChildren = 8u,
        ActivateDocOnErr = 16u,
        DocClose = 65536u,
        Reserved = 4294901760u,
    }
    public enum VSREGDOCLOCKHOLDER : uint
    {
        RDLH_WeakLockHolder = 1u,
    }
    public enum VSSETFRAMEPOS
    {
        SFP_fDock = 1,
        SFP_fDockBottom = 32,
        SFP_fDockLeft = 48,
        SFP_fDockRight = 64,
        SFP_fDockTop = 16,
        SFP_fFloat = 3,
        SFP_fMdiChild = 4,
        SFP_fMove = -2147483648,
        SFP_fSize = 1073741824,
        SFP_fTab = 2,
        SFP_fTabFirst = 16,
        SFP_fTabLast = 32,
        SFP_fTabNext = 64,
        SFP_fTabPrevious = 48,
        SFP_maskFrameMode = 15,
        SFP_maskPosition = 240,
    }
    public enum VSSPROPID
    {
        VSSPROPID_AddExistItemFilter = -9005,
        VSSPROPID_AnimationsOn = -9015,
        VSSPROPID_AppDataDir = -9021,
        VSSPROPID_DetectFileChanges = -9018,
        VSSPROPID_FindInFilesFilter = -9004,
        VSSPROPID_FIRST = -9031,
        VSSPROPID_hinstComplexScript = -9010,
        VSSPROPID_hinstMSO = -9011,
        VSSPROPID_hmsoinstMSO = -9025,
        VSSPROPID_InstallDirectory = -9007,
        VSSPROPID_IsComplexScriptAvail = -9009,
        VSSPROPID_IsInCommandLineMode = -9022,
        VSSPROPID_IsInOfficeMode = -9006,
        VSSPROPID_IsInteractive = -9017,
        VSSPROPID_LAST = -9000,
        VSSPROPID_MDIState = -9001,
        VSSPROPID_ObjectMgrTypesImgList = -9027,
        VSSPROPID_OpenFileFilter = -9003,
        VSSPROPID_OpenFromCurrDocDir = -9019,
        VSSPROPID_PreBuildRunPreview = -9008,
        VSSPROPID_PreBuildRunPreviewSaveOpts = -9031,
        VSSPROPID_ProcessingPendingMessageFilterMsg = -9016,
        VSSPROPID_RecordState = -9013,
        VSSPROPID_ReloadChangedFiles = -9020,
        VSSPROPID_SCCGlyphsImgList = -9028,
        VSSPROPID_ShowMiscFilesProject = -9026,
        VSSPROPID_ShowOutputPaneOnBuildBegin = -9023,
        VSSPROPID_ShowTasklistOnBuildEnd = -9024,
        VSSPROPID_StartupDir = -9000,
        VSSPROPID_SuppressMessageFilterBusyDialog = -9029,
        VSSPROPID_ViewSourceMode = -9012,
        VSSPROPID_VirtualRegistryRoot = -9002,
        VSSPROPID_VisualStudioProjDir = -9030,
        VSSPROPID_Zombie = -9014,
        VSFPROPID_ToolWindowUsesDocSelection = -9051,
        VSSPROPID_AutohideToolFrame = -9050,
        VSSPROPID_BuildOutOfDateProjects = -9043,
        VSSPROPID_FIRST2 = -9051,
        VSSPROPID_InstallRootDir = -9041,
        VSSPROPID_IsAcademic = -9035,
        VSSPROPID_IsAppThemed = -9036,
        VSSPROPID_MainWindowPos = -9034,
        VSSPROPID_MainWindowSize = -9033,
        VSSPROPID_MainWindowVisibility = -9045,
        VSSPROPID_RunAfterBuildErrors = -9044,
        VSSPROPID_SccProviderChanged = -9032,
        VSSPROPID_SKUEdition = -9046,
        VSSPROPID_SolutionExplorerSortingEnabled = -9042,
        VSSPROPID_SqmRegistryRoot = -9049,
        VSSPROPID_SubSKUEdition = -9047,
        VSSPROPID_VisualStudioDir = -9037,
        VSSPROPID_VsTemplateUserZipItemFolder = -9039,
        VSSPROPID_VsTemplateUserZipProjectFolder = -9038,
        VSSPROPID_WaitingForSecondKeyChord = -9048,
        VSSPROPID_CommonAppDataDir = -9052,
        VSSPROPID_FIRST3 = -9052,
        VSSPROPID_FIRST4 = -9061,
        VSSPROPID_IsModal = -9058,
        VSSPROPID_LayoutIsRightToLeft = -9056,
        VSSPROPID_LocalAppDataDir = -9055,
        VSSPROPID_MainWindowDataSource = -9059,
        VSSPROPID_OpenFileStartDir = -9057,
        VSSPROPID_ShellInitialized = -9053,
        VSSPROPID_VisualEffectsAllowed = -9061,
        VSSPROPID_VisualEffectsOption = -9060,
        VSSPROPID_ZeroConfigProjectDir = -9054,
        VSSPROPID_NativeScrollbarThemeModePropName = -9074,
    }
    public enum VSWBCUSTOMURL
    {
        VSWBCU_Home = 0,
        VSWBCU_Search = 1,
        VSWBCU_Credits = 2,
    }
    public enum VSWBDOCINFOINDEX
    {
        VSWBDI_DocDispatch = 0,
        VSWBDI_DocName = 1,
        VSWBDI_DocURL = 2,
        VSWBDI_DocType = 3,
        VSWBDI_DocStatusText = 4,
        VSWBDI_DocBusyStatus = 5,
        VSWBDI_DocReadyState = 6,
        VSWBDI_DocSize = 7,
        VSWBDI_DocLastCtxMenuPos = 8,
    }
    public enum VSWBNAVIGATEFLAGS
    {
        VSNWB_ForceNew = 1,
        VSNWB_AddToMRU = 2,
        VSNWB_VsURLOnly = 4,
        VSNWB_WebURLOnly = 8,
    }
    public enum VSWBREFRESHTYPE
    {
        VSWBR_Normal = 0,
        VSWBR_IfExpired = 1,
        VSWBR_Completely = 3,
    }
}
namespace JetBrains.VsIntegration.Interop.Events
{
    
    public class IVsWindowFrameNotify
    {
        public readonly JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame Frame;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.VsIntegration.Interop.Declarations.VsShell.FRAMECLOSE, JetBrains.VsIntegration.Interop.Declarations.VsShell.FRAMECLOSE>> OnClose;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.VsIntegration.Interop.Declarations.VsShell.FRAMESHOW2>> OnShow;
        public IVsWindowFrameNotify([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame frame) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsRunningDocumentTableEvents
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents.AfterAttributeExChangeEventArgs> AfterAttributeChangeEx;
        public readonly JetBrains.DataFlow.ISimpleSignal AfterDocumentWindowHide;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE>> AfterFirstDocumentLock;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE>> AfterSave;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents.BeforeDocumentWindowShowArgs> BeforeDocumentWindowShow;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE>> BeforeLastDocumentUnlock;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE>> BeforeSave;
        public VsRunningDocumentTableEvents(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable vsRunningDocumentTable) { }
        public class AfterAttributeExChangeEventArgs
        {
            public readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTATTRIB Attribs;
            public readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE DocCookie;
            public readonly JetBrains.VsIntegration.ProjectModel.VsHierarchyItem HierNew;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly JetBrains.VsIntegration.ProjectModel.VsHierarchyItem HierOld;
            public readonly string MonikerDocNew;
            public readonly string MonikerDocOld;
            public AfterAttributeExChangeEventArgs(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTATTRIB attribs, JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hierOld, string monikerDocOld, JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hierNew, string monikerDocNew) { }
        }
        public struct BeforeDocumentWindowShowArgs
        {
            public BeforeDocumentWindowShowArgs(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE vscookie, bool isFirstShow, JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame frame) { }
            public JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE DocCookie { get; }
            public JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame Frame { get; }
            public bool IsFirstShow { get; }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsSelection
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Events.VsSelection.CmdUIContextChangedEventArgs> CmdUIContextChanged;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Events.VsSelection.ElementValueChangedEventArgs> ElementValueChanged;
        public readonly bool OptionTrace;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame> SelectedWindowFrame;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ICollectionEvents<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> Selection;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Events.VsSelection.SelectionChangedEventArgs> SelectionChanged;
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection VsMonitorSelection;
        public VsSelection([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution) { }
        public class CmdUIContextChangedEventArgs : System.EventArgs
        {
            public CmdUIContextChangedEventArgs(uint dwCmdUICookie, int fActive) { }
            public uint DwCmdUICookie { get; set; }
            public int FActive { get; set; }
        }
        public class ElementValueChangedEventArgs : System.EventArgs
        {
            public readonly JetBrains.VsIntegration.VSSELELEMID ElementId;
            public readonly object ValueNew;
            public readonly object ValueOld;
            public ElementValueChangedEventArgs(JetBrains.VsIntegration.VSSELELEMID elementid, object old, object @new) { }
        }
        public class SelectionChangedEventArgs : System.EventArgs
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> ItemsNew;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> ItemsOld;
            public SelectionChangedEventArgs([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> itemsOld, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> itemsNew) { }
            public SelectionChangedEventArgs([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> itemsNew) { }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextManagerEvents
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView> RegisterView;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView> UnregisterView;
        public readonly JetBrains.DataFlow.ISimpleSignal UserPreferencesChanged;
        public VsTextManagerEvents(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager, JetBrains.Threading.IThreading threading) { }
    }
}
namespace JetBrains.VsIntegration.Interop.Extension
{
    
    public class static IVsUserDataEx
    {
        public static TValue GetData<TValue>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.TextManager.Interop.IVsUserData userdata, System.Guid key) { }
        public static TValue GetData<TValue>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.TextManager.Interop.IVsUserData userdata, System.Guid key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> FCreateIfMissing) { }
        public static void SetData<TValue>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.TextManager.Interop.IVsUserData userdata, System.Guid key, TValue value) { }
        public static bool TryGetData<TValue>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.TextManager.Interop.IVsUserData userdata, System.Guid key, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> FWithData) { }
        public static TValue TryGetData<TValue>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.TextManager.Interop.IVsUserData userdata, System.Guid key) { }
    }
    public class static IVsWindowFrameEx
    {
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView[] GetTextViewsFromWindowFrame(this JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame pFrame) { }
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView TryGetTextViewFromWindowFrame(this JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame pFrame) { }
    }
}
namespace JetBrains.VsIntegration.Interop.Shim.Shell
{
    
    public struct IVsMonitorSelection
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection Raw;
        public IVsMonitorSelection([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection RawNotNull { get; }
        public void AssertNotNull() { }
        public uint GetCmdUIContextCookie(System.Guid context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> GetCurrentSelection([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame GetSelectedWindowFrame() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.ISelectionContainer GetSelectionContainer() { }
        public bool IsCmdUIContextActive(uint context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public TValue TryGetCurrentElementValue<TValue>(JetBrains.VsIntegration.VSSELELEMID elementid) { }
    }
    public struct IVsMultiItemSelect
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.Shell.Interop.IVsMultiItemSelect Raw;
        public IVsMultiItemSelect([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsMultiItemSelect raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsMultiItemSelect RawNotNull { get; }
        public void AssertNotNull() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> GetSelectedItems(Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution) { }
    }
    public struct IVsRunningDocumentTable
    {
        public static readonly JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable Null;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable Raw;
        public IVsRunningDocumentTable([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable RawNotNull { get; }
        public void AssertNotNull() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.JetTuple<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE> FindAndLockDocument(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTFLAGS dwRDTLockType, [JetBrains.Annotations.NotNullAttribute()] string pszMkDocument) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public void FindAndLockDocument(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTFLAGS dwRDTLockType, [JetBrains.Annotations.NotNullAttribute()] string pszMkDocument, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, [JetBrains.Annotations.CanBeNullAttribute()] out object docdata, out JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE doccookie) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem FindAndLockDocument_TryGetHierarchyItemByMoniker([JetBrains.Annotations.NotNullAttribute()] string moniker) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public void FindOrRegisterAndLockDocument(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTFLAGS dwRDTLockType, [JetBrains.Annotations.NotNullAttribute()] string pszMkDocument, JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitemPreferred, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitemActual, [JetBrains.Annotations.CanBeNullAttribute()] out object docdata, out JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE doccookie) { }
        [JetBrains.Annotations.PureAttribute()]
        public void GetDocumentInfo(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie, out JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTFLAGS pgrfRDTFlags, out uint pdwReadLocks, out uint pdwEditLocks, [JetBrains.Annotations.NotNullAttribute()] out string pbstrMkDocument, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, out object pDocData) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public object GetDocumentInfo_DocData(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetDocumentInfo_HierarchyItem(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer GetDocumentInfo_TextBuffer(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE> GetRunningDocumentsEnum() { }
        public void SaveDocuments(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTSAVEOPTIONS grfSaveOpts, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem TryGetDocumentInfo_HierarchyItem(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        public void UnlockDocument(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSRDTFLAGS flags, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE dwCookie) { }
    }
    public struct IVsShell
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.Shell.Interop.IVsShell Raw;
        public IVsShell([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsShell raw) { }
        public int Edition { get; }
        public string InstallDir { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsShell RawNotNull { get; }
        public int SubEdition { get; }
        public void AdviseBroadcastMessages([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<uint, System.IntPtr, System.IntPtr> handler) { }
        public void AdviseShellPropertyChanges([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.VsIntegration.Interop.Declarations.VsShell.VSSPROPID, object> handler) { }
        public TValue GetProperty<TValue>(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSSPROPID prop) { }
        public Microsoft.VisualStudio.Shell.Interop.IVsPackage LoadPackage(System.Guid guid) { }
    }
    public struct IVsWindowFrame : System.IEquatable<JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame>
    {
        public static readonly JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame Null;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame Raw;
        public IVsWindowFrame([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame RawNotNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.Interop.Events.IVsWindowFrameNotify Advise([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public void AssertNotNull() { }
        public void CloseFrame(JetBrains.VsIntegration.Interop.Declarations.VsShell.FRAMECLOSE grfSaveOptions) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame other) { }
        public System.Guid GetGuidProperty(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSFPROPID propid) { }
        public override int GetHashCode() { }
        public TValue GetProperty<TValue>(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSFPROPID propid) { }
        public void Hide() { }
        public bool IsOnScreen() { }
        public bool IsVisible() { }
        public void SetProperty<TValue>(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSFPROPID propid, TValue var) { }
        public void Show() { }
        public void ShowNoActivate() { }
        public override string ToString() { }
        public System.Nullable<System.Guid> TryGetWindowObjectKind() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TInterface TryQueryViewInterface<TInterface>()
            where TInterface :  class { }
    }
}
namespace JetBrains.VsIntegration.Interop.Shim.TextManager
{
    
    public struct IVsTextBuffer : System.IEquatable<JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer>
    {
        public static readonly JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer Null;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer Raw;
        public IVsTextBuffer([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.IProperty<JetBrains.DocumentModel.IDocument> JetDocument { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer RawNotNull { get; }
        public void AssertNotNull() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamMarker CreateStreamMarker(Microsoft.VisualStudio.TextManager.Interop.MARKERTYPE iMarkerType, int iPos, int iLength, [JetBrains.Annotations.CanBeNullAttribute()] Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient pClient) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public int EnumMarkers_Count(int iPos, int iLen, Microsoft.VisualStudio.TextManager.Interop.MARKERTYPE iMarkerType, Microsoft.VisualStudio.TextManager.Interop.ENUMMARKERFLAGS dwFlags) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamMarker> EnumMarkers_Enumerable(int iPos, int iLen, Microsoft.VisualStudio.TextManager.Interop.MARKERTYPE iMarkerType, Microsoft.VisualStudio.TextManager.Interop.ENUMMARKERFLAGS dwFlags) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer GetConnectionPointContainerVs() { }
        public override int GetHashCode() { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> GetLengthOfLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> iLine) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> GetLineCount() { }
        public JetBrains.DocumentModel.DocumentCoords GetLineIndexOfPosition(int iPosition) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetLineText(JetBrains.DocumentModel.DocumentCoords start, JetBrains.DocumentModel.DocumentCoords end) { }
        public int GetPositionOfLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> iLine) { }
        public int GetPositionOfLineIndex(JetBrains.DocumentModel.DocumentCoords lineindex) { }
        public int GetSize() { }
        public JetBrains.VsIntegration.Interop.Declarations.TextManager.BUFFERSTATEFLAGS GetStateFlags() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetStream(JetBrains.Util.TextRange range) { }
        public TValue GetUserData<TValue>(System.Guid data) { }
        public void InitializeContent(string pszText) { }
        public bool IsImplementingAllTextBufferInterfaces() { }
        public void Reload(bool fUndoable) { }
        public int ReplaceStreamEx(Microsoft.VisualStudio.TextManager.Interop.REPLACE_TEXT_FLAGS dwFlags, int iPos, int iOldLen, [JetBrains.Annotations.NotNullAttribute()] string pszText, int iNewLen) { }
        public void SetStateFlags(JetBrains.VsIntegration.Interop.Declarations.TextManager.BUFFERSTATEFLAGS dwReadOnlyFlags) { }
        public void SetUserData<TValue>(System.Guid data, TValue value) { }
        public Microsoft.VisualStudio.OLE.Interop.IOleUndoManager TryGetUndoManager() { }
        public bool TryGetUserData<TValue>(System.Guid data, System.Action<TValue> FWithData) { }
        public TValue TryGetUserData<TValue>(System.Guid data) { }
    }
    public struct IVsTextLayer
    {
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextLayer Null;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer Raw;
        public IVsTextLayer([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer RawNotNull { get; }
        public void AssertNotNull() { }
        public System.Nullable<JetBrains.TextControl.TextControlLineColumn> BaseLineIndexToLocal(JetBrains.DocumentModel.DocumentCoords posDoc) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlColumn> GetLengthOfLine(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> line) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> GetLineCount() { }
        public string GetLineText(JetBrains.VsIntegration.TextControl.TextControlLineColumnRange range) { }
        public System.Nullable<JetBrains.DocumentModel.DocumentCoords> LocalLineIndexToBase(JetBrains.TextControl.TextControlLineColumn posTxt) { }
    }
    public struct IVsTextView : System.IEquatable<JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView>
    {
        public static readonly JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView Null;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly Microsoft.VisualStudio.TextManager.Interop.IVsTextView Raw;
        public IVsTextView([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.TextManager.Interop.IVsTextView raw) { }
        public bool IsNotNull { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.TextManager.Interop.IVsTextView RawNotNull { get; }
        public void AddCommandFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget filter, [JetBrains.Annotations.NotNullAttribute()] out Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget callnext) { }
        public void AssertNotNull() { }
        public System.Nullable<JetBrains.TextControl.TextControlLineColumn> BaseLineIndexToLocal(JetBrains.DocumentModel.DocumentCoords posDoc) { }
        public void CenterColumns(JetBrains.DocumentModel.DocumentCoords posDoc, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> iColCount) { }
        public void CenterLines(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> iTopLine, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> iCount) { }
        public void ClearSelection(bool fMoveToAnchor) { }
        public void EnsureSpanVisible(JetBrains.DocumentModel.DocLineColumnRange range) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView other) { }
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer GetBuffer() { }
        public JetBrains.DocumentModel.DocumentCoords GetCaretPos() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer GetConnectionpointContainerVs() { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.TextControl.Graphics.Height GetLineHeight() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget GetOleCommandTarget() { }
        public System.Drawing.Point GetPointOfLineColumn(JetBrains.DocumentModel.DocumentCoords position) { }
        public void GetScrollInfo(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView.ScrollBarAxis iBar, out int piMinUnit, out int piMaxUnit, out int piVisibleUnits, out int piFirstVisibleUnit) { }
        public JetBrains.DocumentModel.DocLineColumnRange GetSelection() { }
        public JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextLayer GetTopmostLayer() { }
        [JetBrains.Annotations.PureAttribute()]
        public System.IntPtr GetWindowHandle() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool IsCompletorWindowActive() { }
        public bool IsDetachedFromBuffer() { }
        public System.Nullable<JetBrains.DocumentModel.DocumentCoords> LocalLineIndexToBase(JetBrains.TextControl.TextControlLineColumn posTxt) { }
        public void ReplaceTextOnLine(JetBrains.DocumentModel.DocumentCoords position, int iCharsToReplace, string pszNewText) { }
        public void SendExplicitFocus() { }
        public void SetBuffer(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer buffer) { }
        public void SetCaretPos(JetBrains.DocumentModel.DocumentCoords position) { }
        public void SetScrollPosition(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView.ScrollBarAxis iBar, int iFirstVisibleUnit) { }
        public void SetSelection(JetBrains.DocumentModel.DocLineColumnRange range) { }
        public void UpdateCompletionStatus([JetBrains.Annotations.CanBeNullAttribute()] Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet pCompSet, uint dwFlags) { }
        public enum ScrollBarAxis
        {
            Horizontal = 0,
            Vertical = 1,
        }
    }
}
namespace JetBrains.VsIntegration
{
    
    [JetBrains.Util.NoReorder()]
    public class LOGFONT
    {
        public byte lfCharSet;
        public byte lfClipPrecision;
        public int lfEscapement;
        public string lfFaceName;
        public int lfHeight;
        public byte lfItalic;
        public int lfOrientation;
        public byte lfOutPrecision;
        public byte lfPitchAndFamily;
        public byte lfQuality;
        public byte lfStrikeOut;
        public byte lfUnderline;
        public int lfWeight;
        public int lfWidth;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SettingsStatisticProvider : JetBrains.ProjectModel.IActivityLogContributorSolutionComponent
    {
        public SettingsStatisticProvider(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayers userFriendlySettingsLayers, JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers userInjectedSettingsLayers, JetBrains.Application.Settings.Storage.DefaultFileStorages.GlobalSettings globalSettings, JetBrains.ProjectModel.Settings.Store.SolutionSettings solutionSettings) { }
        public void ProcessSolutionStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
    public class static VsColorUtilities
    {
        public static System.Drawing.Color GetColorFromColorableItem(EnvDTE.ColorableItems colorableItems, JetBrains.VsIntegration.TextControl.VsColorTypeEnum vsColorType) { }
        public static System.Drawing.Color GetColorFromVS(string displayItemName, System.Drawing.Color defaultColor, JetBrains.VsIntegration.TextControl.VsColorTypeEnum vsColorType, EnvDTE.DTE dte) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.ColorableItems TryGetColorableItemsByName([JetBrains.Annotations.NotNullAttribute()] string displayItemName, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.DTE dte) { }
    }
    public class static VsConstants
    {
        public const uint ALL = 1u;
        public const int CB_SETDROPPEDWIDTH = 352;
        public const uint CEF_CLONEFILE = 1u;
        public const uint CEF_OPENASNEW = 8u;
        public const uint CEF_OPENFILE = 2u;
        public const uint CEF_SILENT = 4u;
        public const int CLSCTX_INPROC_SERVER = 1;
        public static readonly System.Guid CLSID_ComPlusOnlyDebugEngine;
        public static readonly System.Guid CLSID_HtmDocData;
        public static readonly System.Guid CLSID_HtmedPackage;
        public static readonly System.Guid CLSID_HtmlLanguageService;
        public static readonly System.Guid CLSID_MiscellaneousFilesProject;
        public static readonly System.Guid CLSID_SolutionItemsProject;
        public static readonly System.Guid CLSID_VsCfgProviderEventsHelper;
        public static readonly System.Guid CLSID_VsDocOutlinePackage;
        public static readonly System.Guid CLSID_VsEnvironmentPackage;
        public static readonly System.Guid CLSID_VsTaskList;
        public static readonly System.Guid CLSID_VsTaskListPackage;
        public static readonly System.Guid CLSID_VsUIHierarchyWindow;
        public const int CPDN_SELCHANGED = 2304;
        public const int CPDN_SELDBLCLICK = 2305;
        public const int CPPM_CLEARSELECTION = 2314;
        public const int CPPM_GETSELECTION = 2311;
        public const int CPPM_INITIALIZELIST = 2309;
        public const int CPPM_INITIALIZETAB = 2312;
        public const int CPPM_QUERYCANSELECT = 2310;
        public const int CPPM_SETMULTISELECT = 2313;
        public static readonly System.Guid CSharpLanguageServiceGuid;
        public static readonly System.Guid CssLanguageServiceGuid;
        public const uint DocumentFrame = 2u;
        public const int DWL_MSGRESULT = 0;
        public const int FILE_ATTRIBUTE_READONLY = 1;
        public const int GMEM_DDESHARE = 8192;
        public const int GMEM_MOVEABLE = 2;
        public const int GMEM_ZEROINIT = 64;
        public static readonly System.Guid GUID_Addins;
        public static readonly System.Guid GUID_BuildOutputWindowPane;
        public static readonly System.Guid GUID_COMClassicPage;
        public static readonly System.Guid GUID_COMPlusPage;
        public static readonly System.Guid GUID_DefaultEditor;
        public static readonly System.Guid GUID_ExternalEditor;
        public static readonly System.Guid GUID_HTMEDAllowExistingDocData;
        public static readonly System.Guid GUID_HtmlEditorFactory;
        public static readonly System.Guid GUID_OutWindowDebugPane;
        public static readonly System.Guid GUID_OutWindowGeneralPane;
        public static readonly System.Guid GUID_PropertyBrowserToolWindow;
        public static readonly System.Guid GUID_SolutionPage;
        public static readonly System.Guid GUID_TextEditorFactory;
        public static readonly System.Guid GUID_VsNewProjectPseudoFolder;
        public static readonly System.Guid GUID_VSStandardCommandSet97;
        public static readonly System.Guid GUID_VsTaskListViewAll;
        public static readonly System.Guid GUID_VsTaskListViewCheckedTasks;
        public static readonly System.Guid GUID_VsTaskListViewCommentTasks;
        public static readonly System.Guid GUID_VsTaskListViewCompilerTasks;
        public static readonly System.Guid GUID_VsTaskListViewCurrentFileTasks;
        public static readonly System.Guid GUID_VsTaskListViewHTMLTasks;
        public static readonly System.Guid GUID_VsTaskListViewShortcutTasks;
        public static readonly System.Guid GUID_VsTaskListViewUncheckedTasks;
        public static readonly System.Guid GUID_VsTaskListViewUserTasks;
        public static readonly System.Guid GUID_VsUIHierarchyWindowCmds;
        public static readonly System.Guid GuidClassView;
        public static readonly System.Guid GuidObjBrowser;
        public static readonly System.Guid GuidSolutionExplorer;
        [System.ObsoleteAttribute("Use GUID_VSStandardCommandSet97")]
        public static readonly System.Guid guidVSStd97;
        public const int HTMENU = 5;
        public static readonly System.Guid HtmlLanguageServiceGuid;
        public static readonly System.Guid HtmlXLanguageServiceGuid;
        public const int IEI_DoNotLoadDocData = 268435456;
        public static readonly System.Guid IID_IObjectWithSite;
        public static readonly System.Guid IID_IServiceProvider;
        public static readonly System.Guid IID_IUnknown;
        public static System.IntPtr InvalidIntPtr;
        public static readonly System.Guid JavaScriptLanguageServiceGuid;
        public static readonly System.Guid LOGVIEWID_Code;
        public static readonly System.Guid LOGVIEWID_Debugging;
        public static readonly System.Guid LOGVIEWID_Designer;
        public static readonly System.Guid LOGVIEWID_Primary;
        public static readonly System.Guid LOGVIEWID_TextView;
        public static readonly System.Guid LOGVIEWID_UserChooseView;
        public const int LVM_SETEXTENDEDLISTVIEWSTYLE = 4150;
        public const int LVS_EX_LABELTIP = 16384;
        public const int OLECLOSE_NOSAVE = 1;
        public const int OLECLOSE_PROMPTSAVE = 2;
        public const int OLECLOSE_SAVEIFDIRTY = 0;
        public const int OLEIVERB_DISCARDUNDOSTATE = -6;
        public const int OLEIVERB_HIDE = -3;
        public const int OLEIVERB_INPLACEACTIVATE = -5;
        public const int OLEIVERB_OPEN = -2;
        public const int OLEIVERB_PRIMARY = 0;
        public const int OLEIVERB_PROPERTIES = -7;
        public const int OLEIVERB_SHOW = -1;
        public const int OLEIVERB_UIACTIVATE = -4;
        public const uint PropertyBrowserSID = 4u;
        public const int PSN_APPLY = -202;
        public const int PSN_KILLACTIVE = -201;
        public const int PSN_RESET = -203;
        public const int PSN_SETACTIVE = -200;
        public const int ROSTATUS_NotReadOnly = 0;
        public const int ROSTATUS_ReadOnly = 1;
        public const int ROSTATUS_Unknown = -1;
        public static readonly System.Guid ScriptLanguageServiceGuid;
        public const uint SELECTED = 2u;
        public static readonly System.Guid SID_SUIHostCommandDispatcher;
        public static readonly System.Guid SID_SVsGeneralOutputWindowPane;
        public static readonly System.Guid SID_SVsToolboxActiveXDataProvider;
        public const uint StartupProject = 3u;
        public static readonly System.Guid TextEditorFontsAndColorsCategoryGuid;
        public static readonly System.Guid TypeScriptLanguageServiceGuid;
        public static readonly System.Guid UICONTEXT_CodeWindow;
        public static readonly System.Guid UICONTEXT_Debugging;
        public static readonly System.Guid UICONTEXT_DesignMode;
        public static readonly System.Guid UICONTEXT_Dragging;
        public static readonly System.Guid UICONTEXT_EmptySolution;
        public static readonly System.Guid UICONTEXT_FullScreenMode;
        public static readonly System.Guid UICONTEXT_NoSolution;
        public static readonly System.Guid UICONTEXT_SolutionBuilding;
        public static readonly System.Guid UICONTEXT_SolutionExists;
        public static readonly System.Guid UICONTEXT_SolutionHasMultipleProjects;
        public static readonly System.Guid UICONTEXT_SolutionHasSingleProject;
        public const int UNDO_E_CLIENTABORT = -2147205119;
        public const uint UndoManager = 0u;
        public const uint UserContext = 5u;
        public static readonly System.Guid VBLanguageServiceGuid;
        public const int VS_E_BUSY = -2147220992;
        public const int VS_E_INCOMPATIBLEDOCDATA = -2147213334;
        public const int VS_E_PACKAGENOTLOADED = -2147213343;
        public const int VS_E_PROJECTALREADYEXISTS = -2147213344;
        public const int VS_E_PROJECTMIGRATIONFAILED = -2147213339;
        public const int VS_E_PROJECTNOTLOADED = -2147213342;
        public const int VS_E_SOLUTIONALREADYOPEN = -2147213340;
        public const int VS_E_SOLUTIONNOTOPEN = -2147213341;
        public const int VS_E_SPECIFYING_OUTPUT_UNSUPPORTED = -2147220991;
        public const int VS_E_UNSUPPORTEDFORMAT = -2147213333;
        public const uint VSCOOKIE_NIL = 0u;
        public const uint VSITEMID_NIL = 4294967295u;
        public const uint VSITEMID_ROOT = 4294967294u;
        public const uint VSITEMID_SELECTION = 4294967293u;
        public const int VSM_ENTERMODAL = 4179;
        public const int VSM_EXITMODAL = 4180;
        public const int VSM_TOOLBARMETRICSCHANGE = 4178;
        public static readonly System.Guid VSStd2K;
        public const uint WindowFrame = 1u;
        public static readonly System.Guid XamlLanguageServiceGuid;
        public static readonly System.Guid XMLLanguageServiceGuid;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsExceptionStorageBehavior : JetBrains.Application.ExceptionReport.IExceptionStorageBehavior
    {
        public VsExceptionStorageBehavior(JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
        public bool StoreExceptions { get; }
    }
    public enum VSSELELEMID
    {
        SEID_UndoManager = 0,
        SEID_WindowFrame = 1,
        SEID_DocumentFrame = 2,
        SEID_StartupProject = 3,
        SEID_PropertyBrowserSID = 4,
        SEID_UserContext = 5,
        SEID_ResultList = 6,
        SEID_LastWindowFrame = 7,
    }
    public enum VSStd2KCmdID
    {
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Backspace")]
        ECMD_BACKSPACE = 2,
        ECMD_BACKTAB = 5,
        ECMD_BOL = 19,
        ECMD_BOL_EXT = 20,
        ECMD_BOL_EXT_COL = 124,
        ECMD_BOTTOMLINE = 33,
        ECMD_BOTTOMLINE_EXT = 34,
        ECMD_CANCEL = 103,
        ECMD_COMMENT_BLOCK = 136,
        ECMD_COMMENTBLOCK = 98,
        ECMD_COMPLETEWORD = 107,
        ECMD_COMPLETION_HIDE_ADVANCED = 142,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Copy")]
        ECMD_COPY = 59,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Cut")]
        ECMD_CUT = 58,
        ECMD_CUTLINE = 61,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Delete")]
        ECMD_DELETE = 6,
        ECMD_DELETEALLTEMPBOOKMARKS = 75,
        ECMD_DELETEBLANKLINES = 63,
        ECMD_DELETELINE = 62,
        ECMD_DELETETOBOL = 66,
        ECMD_DELETETOEOL = 65,
        ECMD_DELETEWHITESPACE = 64,
        ECMD_DELETEWORDLEFT = 92,
        ECMD_DELETEWORDRIGHT = 91,
        ECMD_DOUBLECLICK = 134,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Down")]
        ECMD_DOWN = 13,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Down.Selection")]
        ECMD_DOWN_EXT = 14,
        ECMD_DOWN_EXT_COL = 120,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("End")]
        ECMD_END = 17,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("End.Selection")]
        ECMD_END_EXT = 18,
        ECMD_EOL = 23,
        ECMD_EOL_EXT = 24,
        ECMD_EOL_EXT_COL = 125,
        ECMD_EXTERNALLY_HANDLED_WIDGET_CLICK = 135,
        ECMD_FIND = 79,
        ECMD_FINDAGAIN = 86,
        ECMD_FINDNEXT = 82,
        ECMD_FINDNEXTWORD = 83,
        ECMD_FINDPREV = 84,
        ECMD_FINDPREVWORD = 85,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("DocumentHome")]
        ECMD_FIRSTCHAR = 21,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("DocumentHome.Selection")]
        ECMD_FIRSTCHAR_EXT = 22,
        ECMD_FIRSTNONWHITENEXT = 110,
        ECMD_FIRSTNONWHITEPREV = 109,
        ECMD_FORMATDOCUMENT = 143,
        ECMD_FORMATSELECTION = 112,
        ECMD_GOBACK = 55,
        ECMD_GOTOBRACE = 53,
        ECMD_GOTOBRACE_EXT = 54,
        ECMD_GOTOLINE = 52,
        ECMD_GOTONEXTBOOKMARK = 77,
        ECMD_GOTOPREVBOOKMARK = 78,
        ECMD_HANDLEIMEMESSAGE = 140,
        ECMD_HELPKEYWORD = 111,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Home")]
        ECMD_HOME = 15,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Home.Selection")]
        ECMD_HOME_EXT = 16,
        ECMD_INDENT = 69,
        ECMD_INSERTFILE = 114,
        ECMD_ISEARCH = 122,
        ECMD_ISEARCHBACK = 123,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("DocumentEnd")]
        ECMD_LASTCHAR = 25,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("DocumentEnd.Selection")]
        ECMD_LASTCHAR_EXT = 26,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Left")]
        ECMD_LEFT = 7,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Left.Selection")]
        ECMD_LEFT_EXT = 8,
        ECMD_LEFT_EXT_COL = 117,
        ECMD_NAVIGATETOURL = 139,
        ECMD_OPENFILE = 138,
        ECMD_OPENLINEABOVE = 67,
        ECMD_OPENLINEBELOW = 68,
        ECMD_OPENURL = 113,
        ECMD_OUTLN_COLLAPSE_TO_DEF = 133,
        ECMD_OUTLN_HIDE_SELECTION = 128,
        ECMD_OUTLN_START_AUTOHIDING = 144,
        ECMD_OUTLN_STOP_HIDING_ALL = 131,
        ECMD_OUTLN_STOP_HIDING_CURRENT = 132,
        ECMD_OUTLN_TOGGLE_ALL = 130,
        ECMD_OUTLN_TOGGLE_CURRENT = 129,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("PageDown")]
        ECMD_PAGEDN = 29,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("PageDown.Selection")]
        ECMD_PAGEDN_EXT = 30,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("PageUp")]
        ECMD_PAGEUP = 27,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("PageUp.Selection")]
        ECMD_PAGEUP_EXT = 28,
        ECMD_PARAMINFO = 104,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Paste")]
        ECMD_PASTE = 60,
        ECMD_QUICKINFO = 116,
        ECMD_REDO = 73,
        ECMD_REDONOMOVE = 74,
        ECMD_REPLACE = 80,
        ECMD_REPLACE_ALL = 81,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Enter")]
        ECMD_RETURN = 3,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Right")]
        ECMD_RIGHT = 9,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Right.Selection")]
        ECMD_RIGHT_EXT = 10,
        ECMD_RIGHT_EXT_COL = 118,
        ECMD_SCROLLBOTTOM = 41,
        ECMD_SCROLLCENTER = 42,
        ECMD_SCROLLDN = 36,
        ECMD_SCROLLLEFT = 39,
        ECMD_SCROLLPAGEDN = 38,
        ECMD_SCROLLPAGEUP = 37,
        ECMD_SCROLLRIGHT = 40,
        ECMD_SCROLLTOP = 43,
        ECMD_SCROLLUP = 35,
        ECMD_SELECTALL = 44,
        ECMD_SELECTCURRENTWORD = 90,
        ECMD_SELECTMODE = 56,
        ECMD_SELLOWCASE = 47,
        ECMD_SELSWAPANCHOR = 51,
        ECMD_SELTABIFY = 45,
        ECMD_SELTITLECASE = 50,
        ECMD_SELTOGGLECASE = 49,
        ECMD_SELTOGOBACK = 141,
        ECMD_SELUNTABIFY = 46,
        ECMD_SELUPCASE = 48,
        ECMD_SETREPEATCOUNT = 100,
        ECMD_SHOWCONTEXTMENU = 102,
        ECMD_SHOWMEMBERLIST = 108,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Tab")]
        ECMD_TAB = 4,
        ECMD_TOGGLE_OVERTYPE_MODE = 57,
        ECMD_TOGGLECARETPASTEPOS = 106,
        ECMD_TOGGLESHORTCUT = 115,
        ECMD_TOGGLETEMPBOOKMARK = 76,
        ECMD_TOGGLEVISSPACE = 105,
        ECMD_TOGGLEWORDWRAP = 121,
        ECMD_TOPLINE = 31,
        ECMD_TOPLINE_EXT = 32,
        ECMD_TRANSPOSECHAR = 87,
        ECMD_TRANSPOSELINE = 89,
        ECMD_TRANSPOSEWORD = 88,
        ECMD_TYPECHAR = 1,
        ECMD_UNCOMMENT_BLOCK = 137,
        ECMD_UNCOMMENTBLOCK = 99,
        ECMD_UNDO = 71,
        ECMD_UNDONOMOVE = 72,
        ECMD_UNINDENT = 70,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Up")]
        ECMD_UP = 11,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Up.Selection")]
        ECMD_UP_EXT = 12,
        ECMD_UP_EXT_COL = 119,
        ECMD_WIDGETMARGIN_LBTNDOWN = 101,
        ECMD_WORDNEXT = 96,
        ECMD_WORDNEXT_EXT = 97,
        ECMD_WORDNEXT_EXT_COL = 127,
        ECMD_WORDPREV = 93,
        ECMD_WORDPREV_EXT = 94,
        ECMD_WORDPREV_EXT_COL = 126,
    }
    public enum VSStd97CmdID
    {
        CmdIdCloseSolution = 219,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Copy")]
        CmdIdCopy = 15,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Cut")]
        CmdIdCut = 16,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Delete")]
        CmdIdDelete = 17,
        CmdIdExit = 229,
        CmdIdFileClose = 223,
        CmdIdFileNew = 221,
        CmdIdFileOpen = 222,
        CmdIdFind = 97,
        CmdIdGoto = 231,
        CmdIdNewProject = 216,
        CmdIdOpenProject = 217,
        CmdIdOpenSolution = 218,
        CmdIdPageSetup = 227,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("Paste")]
        CmdIdPaste = 26,
        CmdIdPrint = 27,
        CmdIdPrintPreview = 228,
        CmdIdRedo = 29,
        CmdIdReplace = 230,
        CmdIdSave = 110,
        CmdIdSaveAs = 111,
        CmdIdSaveOptions = 959,
        CmdIdSaveProjectItemAs = 226,
        CmdIdSaveSolution = 224,
        CmdIdSaveSolutionAs = 225,
        [JetBrains.VsIntegration.TextControl.TextControlActionAttribute("SelectAll")]
        CmdIdSelectAll = 31,
        CmdIdUndo = 43,
        CmdIdCancelBuild = 890,
        CmdIdBuildSln = 882,
        CmdIdRebuildSln = 883,
        CmdIdDeploySln = 884,
        CmdIdCleanSln = 885,
        CmdIdBuildSel = 886,
        CmdIdRebuildSel = 887,
        CmdIdDeploySel = 888,
        CmdIdCleanSel = 889,
        CmdIdCustomizeKeyboard = 263,
    }
}
namespace JetBrains.VsIntegration.Markup
{
    
    public interface IVsDocumentMarkup
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable MakeReadonly(JetBrains.Util.TextRange range);
    }
    public abstract class VsHighlighterCustomizationCommon : JetBrains.TextControl.DocumentMarkup.HighlighterCustomization
    {
        protected VsHighlighterCustomizationCommon([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DefaultTextControlSchemeManager textControlSchemeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        protected override JetBrains.TextControl.DocumentMarkup.HighlighterAttributes ApplyIdeCustomizations([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.HighlighterAttributes sample, [JetBrains.Annotations.NotNullAttribute()] string sRegisteredHighlighterAttributeId) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.TextControl.DocumentMarkup.HighlighterAttributes ApplyVsCustomizations([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.HighlighterAttributes sample, [JetBrains.Annotations.NotNullAttribute()] string sRegisteredHighlighterAttributeId);
    }
}
namespace JetBrains.VsIntegration.Package
{
    
    public interface ISupplementaryPackage : Microsoft.VisualStudio.Shell.Interop.IVsPackage
    {
        bool IsActive { set; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Suspend",
            "Resume",
            "ToggleSuspended"})]
    public class PackageSuspendResumeActions : JetBrains.ActionManagement.IActionHandler
    {
        public const string Resume = "Resume";
        public const string Suspend = "Suspend";
        public const string ToggleSuspended = "ToggleSuspended";
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract class VsPackage : JetBrains.VsIntegration.Package.VsPackageSdkStub, Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct, Microsoft.VisualStudio.Shell.Interop.IVsToolWindowFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.IApplicationDescriptor ApplicationDescriptor;
        public static readonly System.Guid GeneralOptionPageGuid;
        public static readonly string GeneralOptionPageName;
        public readonly JetBrains.DataFlow.IProperty<Microsoft.VisualStudio.OLE.Interop.IServiceProvider> SiteNonZombied;
        protected VsPackage(string sAppDescriptorAssemblyQualifiedName, System.Type[] services = null) { }
        public uint IdBmpSplash { get; set; }
        public uint IdIcoLogoForAboutbox { get; set; }
        public int CreateToolWindow(ref System.Guid rguidPersistenceSlot, uint dwToolWindowId) { }
        protected override JetBrains.Interop.WinApi.HResults GetPropertyPage(ref System.Guid guid, Microsoft.VisualStudio.Shell.Interop.VSPROPSHEETPAGE* pPage) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class VsPackageCommandTargetHandlers
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.CollectionEvents<JetBrains.VsIntegration.Package.VsPackageSdkStub.ExecHandler> ExecHandlers;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.CollectionEvents<JetBrains.VsIntegration.Package.VsPackageSdkStub.QueryStatusHandler> QueryStatusHandlers;
        public VsPackageCommandTargetHandlers([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class static VsPackageGeneralOptionsPage
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Windows.Media.Visual CreateView([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.JetVisualStudioHost host) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Windows.Media.Visual CreateView([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Application.Env.Components.SuspendResume> suspendResume, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.UI.Options.OptionsManager> optionsManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> isProductRunning, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.UI.About.AboutBox> aboutbox, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Application.Env.RunsProducts.ProductConfigurations> configuration, JetBrains.DataFlow.IProperty<JetBrains.Application.IProductCommandLine> commandline, [JetBrains.Annotations.CanBeNullAttribute()] System.Version vsVersion2, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.UI.Application.HelpSystem> helpsystem, JetBrains.DataFlow.IProperty<JetBrains.Application.Env.ReportsProductsAllowedToRun> verdict) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract class VsPackageSdkStub : Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget, Microsoft.VisualStudio.OLE.Interop.IServiceProvider, Microsoft.VisualStudio.Shell.Interop.IVsPackage, System.ComponentModel.Design.IServiceContainer, System.IServiceProvider
    {
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Disposables;
        protected readonly System.Collections.Generic.List<JetBrains.VsIntegration.Package.VsPackageSdkStub.ExecHandler> myExecHandlers;
        protected readonly System.Collections.Generic.List<JetBrains.VsIntegration.Package.VsPackageSdkStub.QueryStatusHandler> myQueryStatusHandlers;
        protected readonly JetBrains.DataFlow.IProperty<Microsoft.VisualStudio.OLE.Interop.IServiceProvider> Site;
        protected VsPackageSdkStub() { }
        public bool IsZombied { get; }
        protected void Dispose(bool disposing) { }
        protected virtual JetBrains.Interop.WinApi.HResults GetPropertyPage(ref System.Guid guid, Microsoft.VisualStudio.Shell.Interop.VSPROPSHEETPAGE* pPage) { }
        protected object GetService(System.Type serviceType) { }
        public delegate JetBrains.Interop.WinApi.HResults ExecHandler(System.ComponentModel.Design.CommandID commandid, Microsoft.VisualStudio.OLE.Interop.OLECMDEXECOPT nCmdExecOpt, System.IntPtr vIn, System.IntPtr vOut);
        public delegate JetBrains.Interop.WinApi.HResults QueryStatusHandler(ref System.Guid guidGroupRef, uint nCmds, Microsoft.VisualStudio.OLE.Interop.OLECMD[] oleCmd, Microsoft.VisualStudio.OLE.Interop.OLECMDTEXT* pOleText);
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class VsPackageUniversalActionHandlers
    {
        public VsPackageUniversalActionHandlers([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Package.VsPackageCommandTargetHandlers handlers, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ActionManagement.IVsCtoData vsCtoData, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.Components.SuspendResume suspendResume) { }
    }
}
namespace JetBrains.VsIntegration.PersistableView
{
    
    public abstract class VsPersistableViewEditorFactory : Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory { }
}
namespace JetBrains.VsIntegration.ProjectModel
{
    
    public class AddedFilesOrFoldersUtil
    {
        public static JetBrains.Util.OneToSetMap<Microsoft.VisualStudio.Shell.Interop.IVsProject, string> CreateByAddedFilesOrDirectories(int cProjects, int cFiles, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgpszMkDocuments) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class BizTalkReferencesHelper
    {
        public BizTalkReferencesHelper(JetBrains.ProjectModel.PlatformManager platformManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> AddBizTalkHiddenReferences(JetBrains.ProjectModel.ProjectImpl project, System.Collections.Generic.JetHashSet<string> referencedAssemblyNames) { }
    }
    public class CannotMakeWritableException : System.Exception
    {
        public CannotMakeWritableException(string message) { }
        public CannotMakeWritableException(string message, System.Exception exception) { }
    }
    public interface IBuildSettingsOverrider
    {
        string AdditionalConditionalConstants { get; }
        JetBrains.Util.FileSystemPath OutputFolder { get; }
        bool OverrideOutputFolder { get; }
    }
    public interface IVSDescriptorBuilder
    {
        bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties);
    }
    public interface IVSProjectFilePropertiesBuilder : JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder
    {
        bool FillProjectFilePropertiesDispatch(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, object browseObject, JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties);
    }
    public interface IVsProjectReferenceManager
    {
        JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        void AddAssemblyReference(JetBrains.Util.FileSystemPath assemblyFilePath);
        void AddProjectReference(EnvDTE.Project projectToReference);
        System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> GetProjectReferences(System.Collections.Generic.List<string> resolvedReferences);
        void RemoveReference(JetBrains.ProjectModel.IProjectToModuleReference reference);
    }
    public interface IVsProjectReferenceManagerFactory
    {
        JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager Create(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.Project project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider);
    }
    public class static MSBuildExtensions
    {
        public const string AddAdditionalExplicitAssemblyReferences = "AddAdditionalExplicitAssemblyReferences";
        public const string AdditionalExplicitAssemblyReferences = "AdditionalExplicitAssemblyReferences";
        public const string NoStdLib = "NoStdLib";
        public static bool GetBoolValue(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, string propertyName, bool defaultValue, string activeConfigurationName = null) { }
        public static string GetStringValue(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, string propertyName, string defaultValue) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class OutputAssembliesVs : JetBrains.ProjectModel.Build.OutputAssemblies
    {
        public OutputAssembliesVs(JetBrains.ProjectModel.Assemblies.Impl.AssemblyFactory assemblyFactory, JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.ViewableProjectsCollection projects, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.FileSystemTracker.IFileSystemTracker tracker, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection collection, JetBrains.ProjectModel.Impl.AssemblyInfoCache cache) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectFilePropertiesBuilder : JetBrains.VsIntegration.ProjectModel.ProjectFilePropertiesBuilderBase
    {
        public override bool FillProjectFilePropertiesDispatch(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, object browseObject, JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectFilePropertiesBuilderBase : JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder
    {
        public virtual bool FillProjectFilePropertiesDispatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, [JetBrains.Annotations.CanBeNullAttribute()] object browseObject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    public class static ProjectModelExtensionContainerEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TBuilder GetApplicableBuilder<TBuilder>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer projectModelExtensionsContainer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectProperties projectProperties)
            where TBuilder :  class, JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TBuilder TryGetApplicableBuilder<TBuilder>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer projectModelExtensionsContainer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectProperties projectProperties)
            where TBuilder :  class, JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder { }
    }
    public class ProjectModelStatistics
    {
        public ProjectModelStatistics() { }
        public void AddFile(JetBrains.Util.FileSystemPath fileSystemPath) { }
        public void AddProject(System.Guid projectTypeGuid, System.Collections.Generic.IEnumerable<System.Guid> projectTypeGuids) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectModelSynchronizer
    {
        protected readonly JetBrains.Application.IShellLocks myLocks;
        protected readonly JetBrains.VsIntegration.Application.IVsEnvironmentInformation myVsEnvironmentInformation;
        protected readonly JetBrains.VsIntegration.ProjectModel.VsHierarchyToProjectInfoMap myVsHierarchyToProjectInfoMap;
        protected readonly Microsoft.VisualStudio.Shell.Interop.IVsSolution myVsSolution;
        public ProjectModelSynchronizer(
                    JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, 
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.Application.IShellLocks locks, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, 
                    Microsoft.VisualStudio.Shell.Interop.IVsExternalFilesManager vsExternalFilesManager, 
                    JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable vsRunningDocumentTable, 
                    JetBrains.ProjectModel.PlatformManager platformManager, 
                    JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents vsRunningDocumentTableEvents, 
                    JetBrains.ProjectModel.impl.SpecialFiles.SpecialFilesManager specialFilesManager, 
                    JetBrains.VsIntegration.ProjectModel.BizTalkReferencesHelper bizTalkReferencesHelper, 
                    JetBrains.VsIntegration.ProjectModel.WinJSWindowsSDKReferenceHelper winJsReferenceHelper, 
                    JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactory vsProjectReferenceManagerFactory, 
                    JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, 
                    JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, 
                    JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager, 
                    JetBrains.ProjectModel.Update.ProjectModelUpdater updater, 
                    JetBrains.VsIntegration.ProjectModel.VSProjectModelDescriptionBuilder descriptionBuilder, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, 
                    JetBrains.ProjectModel.References.SdkReferencesManager sdkReferencesManager, 
                    JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper, 
                    JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, 
                    JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer, 
                    JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, 
                    JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtenderProviderManager extenderProviderManager, 
                    JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, 
                    JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider, 
                    JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer projectModelExtensionsContainer, 
                    JetBrains.VsIntegration.Settings.VsSaveMonitor saveMonitor, 
                    JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor, 
                    JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        public JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer ProjectModelExtensionsContainer { get; }
        protected virtual bool DoUseMsbuildToResolveAssemblyReferences(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        protected virtual void EnsureProjectLoadedAndSync(JetBrains.ProjectModel.IProject project) { }
        protected virtual void EnsureProjectSync(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hitem) { }
        public static JetBrains.ProjectModel.BuildAction GetBuildAction(VSLangProj.prjBuildAction value, string itemType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProject GetContainingProjectMappedToHierarchy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetHierarchyItemByProjectItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement projectModelElement, bool forceBackgroundLoad) { }
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetHierarchyItemByProjectItemCore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, bool isFileExpected, bool forceBackgroundLoad, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onError) { }
        public static JetBrains.Util.JetTuple<string, JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> GetProjectFilePathOrProjectLocation(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VSProjectInfo GetProjectInfoByProject(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.VsIntegration.ProjectModel.VSProjectInfo GetProjectInfoByProject(EnvDTE.Project extObject) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectModelElement GetProjectItemByHierarchyItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, bool lookInReferences) { }
        public static System.Collections.Generic.ICollection<System.Guid> GetProjectTypeGuids(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.Util.FileSystemPath projectFilePath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Version GetTargetFrameworkVersion([JetBrains.Annotations.CanBeNullAttribute()] EnvDTE.Project extProject) { }
        public void HandleAdd(JetBrains.Util.OneToSetMap<Microsoft.VisualStudio.Shell.Interop.IVsProject, string> addedItemsMap, bool files) { }
        public void HandleChangeProjectParent(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public void HandleRename(int cFiles, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgszMkOldNames, string[] rgszMkNewNames, bool[] alreadyOnDisks) { }
        public void HandleRenameProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public void LoadFileInformation([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile newFile) { }
        public void OnActiveProjectCfgChange(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pIVsHierarchy) { }
        protected internal void OnAddHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, bool updateProjectReferences, int nAttempt = 0) { }
        public void OnRemoveHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public bool RefreshProjectProperties(JetBrains.ProjectModel.IProject project, bool notifyChangeManager) { }
        protected virtual void RemoveMapping(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem TryGetHierarchyItemByProjectItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement projectItem, bool forceBackgroundLoad) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile TryGetOrCreateProjectItemByHierarchyItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectModelElement TryGetProjectItemByHierarchyItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, bool lookInReferences) { }
        public System.Collections.Generic.List<string> TryResolveAssemblyReferencesUsingMsBuild(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        protected virtual System.Collections.Generic.List<string> TryResolveAssemblyReferencesUsingMsBuildInternal(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        public virtual void UpdateAllProjectsReferences() { }
        protected void UpdateProjectReferences(JetBrains.VsIntegration.ProjectModel.VSProjectInfo pi) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "ProjectModelSynchronizer settings")]
    public class ProjectModelSynchronizerSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to use MSBuild to obtain project references. Will be removed one VS11 fix" +
            "es slowdown in References API. The setting is obsolete to support Visual Studio " +
            "2012 build 50214.")]
        public readonly bool UseMsBuildToObtainProjectReferences;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Force use MsBuild to resolve assembly references for certain projects. Use the op" +
            "tion in case when references are not static (i.e. generated by msbuild step or a" +
            "dded conditionally)")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<System.Guid, bool> UseMsbuildToObtainProjectReferencesForCertainProjects;
        public const string UseMsbuildToObtainProjectReferencesForCertainProjectsDescription = "Force use MsBuild to resolve assembly references for certain projects. Use the op" +
            "tion in case when references are not static (i.e. generated by msbuild step or a" +
            "dded conditionally)";
    }
    public class ProjectReferenceEntry
    {
        public ProjectReferenceEntry(System.Guid projectGuid, string projectName, string relativeOutputPath, bool isIgnored) { }
        public bool IsIgnored { get; set; }
        public System.Guid ProjectGuid { get; }
        public string ProjectName { get; }
        public string RelativeOutputPath { get; }
    }
    public class ProjectReferenceManager : JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerBase
    {
        protected readonly JetBrains.ProjectModel.Caches.ProjectFileDataCache myProjectFileDataCache;
        protected readonly JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer myProjectModelSynchronizer;
        protected readonly JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider myReferencesProvider;
        public ProjectReferenceManager(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, [JetBrains.Annotations.NotNullAttribute()] VSLangProj.VSProject vsProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
        public override void AddAssemblyReference(JetBrains.Util.FileSystemPath assemblyPath) { }
        public override void AddProjectReference(EnvDTE.Project project) { }
        protected virtual void AddReferencesFromMsBuild(System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> references, System.Collections.Generic.List<string> resolvedReferences) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.Update.IProjectReferenceDescriptor CreateReferenceDescriptor(VSLangProj.Reference reference, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, System.Collections.Generic.List<string> resolvedReferences) { }
        protected virtual JetBrains.ProjectModel.Update.IProjectReferenceProperties CreateReferenceProperties(JetBrains.ProjectModel.Update.IProjectReferenceDescriptor descriptor, VSLangProj.Reference reference) { }
        protected virtual void FixReferencesWithoutDescriptor(System.Collections.Generic.List<VSLangProj.Reference> referencesWithoutDescriptor, System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> result, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.List<string> resolvedReferences) { }
        public override System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> GetProjectReferences([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.List<string> resolvedReferences) { }
        protected void OnReferenceEvent(VSLangProj.Reference reference) { }
        public override void RemoveReference(JetBrains.ProjectModel.IProjectToModuleReference projectToModuleReference) { }
    }
    [JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactoryAttribute()]
    public class ProjectReferenceManagerFactory : JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManagerFactory
    {
        public virtual JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager Create(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, EnvDTE.Project project, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectReferencesProvider : JetBrains.ProjectModel.Caches.IProjectFileDataCache
    {
        public ProjectReferencesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Caches.ProjectFileDataCache cache) { }
        public int Version { get; }
        public object BuildData(System.Xml.XmlDocument document) { }
        public bool CanHandle(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Action OnDataChanged(JetBrains.ProjectModel.IProjectFile projectFile, object oldData, object newData) { }
        public object Read(System.IO.BinaryReader reader) { }
        public void Write(System.IO.BinaryWriter writer, object data) { }
    }
    public class PropertiesDictionary
    {
        public PropertiesDictionary([JetBrains.Annotations.CanBeNullAttribute()] EnvDTE.Properties properties) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public EnvDTE.Property GetPropertyUnsafe(string propertyName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public EnvDTE.Property TryGetProperty(string propertyName) { }
    }
    public class static PropertiesEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static EnvDTE.Property GetPropertyUnsafe([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Properties properties, string propertyName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.Property TryGetProperty([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Properties properties, string propertyName) { }
    }
    public class static PropertyExtensions
    {
        public static bool GetBoolValueSafe([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Property property) { }
        public static int GetIntValueSafe([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Property property) { }
        public static string GetStringValueSafe([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Property property, string defaultValue = null) { }
        public static T GetValueSafe<T>([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Property property, T defaultValue = null) { }
        public static bool HasValue([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Property property) { }
        public static bool HasValueOfType<T>([JetBrains.Annotations.NotNullAttribute()] this EnvDTE.Property property) { }
    }
    public class static ReferenceExtension
    {
        public static string GetAliases([JetBrains.Annotations.NotNullAttribute()] this VSLangProj.Reference reference) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyName(this VSLangProj.Reference pReference) { }
        public static bool GetCopyLocal([JetBrains.Annotations.NotNullAttribute()] this VSLangProj.Reference reference) { }
        public static bool GetEmbedInteropTypes([JetBrains.Annotations.NotNullAttribute()] this VSLangProj.Reference reference) { }
        public static string GetReferencePath([JetBrains.Annotations.NotNullAttribute()] this VSLangProj.Reference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.Project GetSourceProject([JetBrains.Annotations.NotNullAttribute()] VSLangProj.Reference reference) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SolutionLoadStatistics : JetBrains.ProjectModel.IActivityLogContributorSolutionComponent
    {
        public SolutionLoadStatistics(JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
        public void ProcessSolutionStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionStatisticsProvider : JetBrains.ProjectModel.IActivityLogContributorSolutionComponent
    {
        public SolutionStatisticsProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer) { }
        public void ProcessSolutionStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
    public abstract class VsEnsureWritableHandler : JetBrains.ProjectModel.Model2.Transaction.EnsureWritableHandler
    {
        protected VsEnsureWritableHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2 vsQueryEditQuerySave2, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks locks) { }
        protected override void OnMakingWritable(JetBrains.ProjectModel.MakingWritableEventArgs args) { }
        protected override JetBrains.ProjectModel.Model2.Transaction.EnsureWritableHandler.QueryIsWritableResult QueryIsWritable(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class VsEnsureWritableToEditorSync : JetBrains.IDE.EnsureWritableToEditorSync
    {
        public VsEnsureWritableToEditorSync(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler handler, JetBrains.DocumentModel.DocumentSettings documentSettings, JetBrains.IDE.EditorManager editorManager, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IApplicationDescriptor descriptor) { }
        protected override void OpenFiles(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> projectFiles) { }
        protected override bool ShouldSkip(JetBrains.ProjectModel.IProjectFile file) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsEnsureWritableVbWhileDebugging
    {
        public VsEnsureWritableVbWhileDebugging([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.IDE.VsDebuggerMonitor debuggerMonitor) { }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public sealed class VsExtenderInstaller : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.VsIntegration.ProjectModel.VSRegisterExtenderAttribute>
    {
        public const string RegExtenderSuffix = "Extenders";
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "VsFileSystemSynchronizer settings")]
    public class VsFileSystemSynchronizerSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "When synchronization is performed")]
        public bool SynchronizeOnFrameActivation;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class VsFileSystemSynchronizerSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public VsFileSystemSynchronizerSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class static VsHierarchyEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem FindHierarchyItemByCanonicalName([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, string canonicalName, bool isFileExpected) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.Project GetExtProject([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public static System.Guid GetGuidPropertySafe([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSHPROPID propid) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProjectFilePath([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetProjectTypeGuidsString([JetBrains.Annotations.CanBeNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetRootItem([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public static bool IsHierarchyWithSideEffects([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public static bool IsMiscFilesHierarchy([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer) { }
        public static bool IsPartOfSolution(this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy vsHierarchy, Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer) { }
        public static bool IsSolutionHierarchy([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public static bool IsTopLevelHierarchy(this Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath TryGetFileSystemPath([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
    }
    public class VsHierarchyItem : System.IEquatable<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem>
    {
        public VsHierarchyItem([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID itemid) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsHierarchy Hierarchy { get; }
        public bool IsNullItem { get; }
        public bool IsRootItem { get; }
        public bool IsSelectionItem { get; }
        public JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID ItemId { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem CreateRoot([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem other) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetItem(JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID itemid) { }
        public override string ToString() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem TryCreate([JetBrains.Annotations.CanBeNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID itemid) { }
    }
    public class static VsHierarchyItemEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> Children([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetCanonicalName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetFirstChild([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetFirstVisibleChild([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetNextSibling([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetNextVisibleSibling([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetParent([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem GetParentFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetPath([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static EnvDTE.ProjectItems GetProjectItems([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetProperty<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem item, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSHPROPID propid) { }
        public static JetBrains.VsIntegration.Interop.Declarations.VsShell.VSITEMID GetVsitemidProperty([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSHPROPID propid) { }
        public static bool IsNonMemberItem([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null => true")]
        public static bool IsNullOrEmpty([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        public static bool IsSolutionHierarchyItem([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.VisualStudio.Shell.Interop.IVsProject TryGetVsProject([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> VisibleChildren([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem) { }
    }
    public class VsHierarchyToProjectInfoMap
    {
        public VsHierarchyToProjectInfoMap(JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer) { }
        public void AddHierarchy([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        public void AddHitem([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hItem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISdkModule sdkModule) { }
        public System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, JetBrains.VsIntegration.ProjectModel.VSProjectInfo>> GetAllInfos() { }
        public System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.ProjectModel.VSProjectInfo> GetAllProjectInfos() { }
        public void Rehash() { }
        public void RemoveHierarchy([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        public void RemoveHitem([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hItem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsHierarchy TryGetHierarchyByProjectInfo(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VSProjectInfo TryGetProjectInfoByHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VSProjectInfo TryGetProjectInfoByProject(EnvDTE.Project envDteProject) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.VSProjectInfo TryGetProjectInfoByProject(JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ISdkModule TryGetSdkProjectInfoByHitem(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem vsHierarchyItem) { }
    }
    public class VSProjectBuilderBase<TBuilder>
        where TBuilder :  class, JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder
    {
        public VSProjectBuilderBase(JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer extensionsContainer) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class VSProjectFilePropertiesBuilder
    {
        public VSProjectFilePropertiesBuilder(JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer extensionsContainer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder GetApplicableBuilder(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    public class VSProjectInfo : System.IDisposable
    {
        public VSProjectInfo(
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, 
                    [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy vsHierarchy, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.BizTalkReferencesHelper bizTalkReferencesHelper, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.WinJSWindowsSDKReferenceHelper winJsReferenceHelper, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactory vsProjectReferenceManagerFactory, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.PlatformManager platformManager, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.ProjectModelUpdater projectModelUpdater, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager ReferenceManager { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.VisualStudio.Shell.Interop.IVsHierarchy VsHierarchy { get; }
        public void BindImportsChangedEvents() { }
        public void Dispose() { }
        protected override void Finalize() { }
        public EnvDTE.Project GetExtProject() { }
        public void SetVsHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy vsHierarchy) { }
        public void UpdateReferencesAfterBuild() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class VSProjectModelDescriptionBuilder
    {
        public VSProjectModelDescriptionBuilder(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Update.ProjectModelUpdater projectModelUpdater, JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer projectModelExtensionsContainer, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer, JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration solutionCachesConfiguration, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable vsRunningDocumentTable, JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        public JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectDescriptor, bool> BuildDescriptor(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Update.UpdateFlags flags, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, JetBrains.ProjectModel.IProject> projectLookup) { }
        public System.Collections.Generic.Dictionary<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectDescriptor, bool>> BuildDescriptors(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> hierarchies, JetBrains.ProjectModel.Update.UpdateFlags flags, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, JetBrains.ProjectModel.IProject> projectLookup = null) { }
        public JetBrains.ProjectModel.Properties.IProjectFileProperties CreateFileProperties(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.Util.FileSystemPath filePath, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Update.IProjectDescriptor CreateProjectDescriptorWithMissingItems(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, JetBrains.ProjectModel.IProject> projectLookup = null) { }
        protected virtual JetBrains.ProjectModel.PlatformID GetDefaultPlatformId() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.Metadata.Utils.TargetPlatformData GetTargetPlatformData(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
    }
    public abstract class VsProjectReferenceManagerBase : JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager
    {
        protected readonly JetBrains.Application.IShellLocks myLocks;
        protected VsProjectReferenceManagerBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager) { }
        protected JetBrains.ProjectModel.IProject Project { get; }
        protected JetBrains.VsIntegration.ProjectModel.VSProjectInfo ProjectInfo { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public abstract void AddAssemblyReference(JetBrains.Util.FileSystemPath assemblyPath);
        public abstract void AddProjectReference(EnvDTE.Project project);
        protected void CallExpectingChange(System.Action action) { }
        protected void ExecuteIfExpectingChangeOrQueue(string name, System.Action action) { }
        public virtual System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> GetProjectReferences(System.Collections.Generic.List<string> resolvedReferences) { }
        public abstract void RemoveReference(JetBrains.ProjectModel.IProjectToModuleReference reference);
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class VsProjectReferenceManagerFactory
    {
        public VsProjectReferenceManagerFactory(System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManagerFactory> referenceManagerFactories, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager CreateReferenceManager(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.Project vsProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class VsProjectReferenceManagerFactoryAttribute : JetBrains.ProjectModel.SolutionInstanceComponentAttribute { }
    public class static VSProjectSafeWrapper
    {
        public static VSLangProj.References GetReferences(VSLangProj.VSProject @this) { }
    }
    public class static VSProjectUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public static System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> Enumerate([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IEnumHierarchies enumHier) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetReferencedProjectName([JetBrains.Annotations.NotNullAttribute()] EnvDTE.Project referencedProject, [JetBrains.Annotations.NotNullAttribute()] VSLangProj.Reference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public static Microsoft.VisualStudio.Shell.Interop.IVsHierarchy TryGetNextHierarchy([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Shell.Interop.IEnumHierarchies enumHier) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class VSRegisterExtenderAttribute : System.Attribute
    {
        public VSRegisterExtenderAttribute(string name, string catid, string guid) { }
        public System.Guid CATID { get; }
        public System.Guid Guid { get; }
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class VSRegisterObjectAttribute : System.Attribute
    {
        public VSRegisterObjectAttribute(System.Type type) { }
        public System.Type Type { get; }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.VsIntegration.ProjectModel.VSRegisterObjectAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public sealed class VsRegisterObjectInstaller : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.VsIntegration.ProjectModel.VSRegisterObjectAttribute>
    {
        public const string RegExtenderSuffix = "CLSID";
    }
    public class static VsSdkReferencesUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetDefaultProperty(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem referenceVsHitem) { }
        public static bool IsReferencesFolder(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem childHitem) { }
        public static JetBrains.VsIntegration.ProjectModel.VsHierarchyItem LocateHierarchyItem(JetBrains.ProjectModel.ISdkModule topLevelProject, JetBrains.VsIntegration.ProjectModel.VsHierarchyItem projectVsHitem) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VSSolutionExplorer : JetBrains.ProjectModel.ISolutionExplorer
    {
        public VSSolutionExplorer(Microsoft.VisualStudio.Shell.Interop.IVsUIShell ivsUiShell, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.Application.IShellLocks locks) { }
        public Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchyWindow ActivateToolWindow(bool activate) { }
        public bool CollapseInSolutionExplorer(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.CollapseRequest> collapseRequests) { }
        public bool ShowInSolutionExplorer(JetBrains.ProjectModel.IProjectItem projectItem, bool activate) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsSolutionLoadTasksScheduler : JetBrains.ProjectModel.Tasks.SolutionLoadTasksSchedulerSync
    {
        public VsSolutionLoadTasksScheduler(JetBrains.Application.IShellLocks locks) { }
        public override void DispatchTasks(bool background) { }
        protected override void Pause() { }
        protected virtual void RunTask(System.Action actionToExecute) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VSSolutionManager : JetBrains.ProjectModel.SolutionManagerBase, JetBrains.Application.Env.Components.IComponentStartupShutdown, JetBrains.ProjectModel.ISolutionOpeningOwner, JetBrains.ProjectModel.ISolutionOwner, Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents, Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents2, Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3, Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents4, Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2, Microsoft.VisualStudio.Shell.Interop.IVsUpdateSolutionEvents
    {
        protected const string DUMMY_SOLUTION_FILE = "TempSolution";
        protected readonly Microsoft.VisualStudio.Shell.Interop.IVsSolution myVsSolution;
        public VSSolutionManager(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.Util.ILogger logger, 
                    JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, 
                    JetBrains.Application.Components.IComponentContainer componentContainer, 
                    JetBrains.Application.IShellLocks locks, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolutionBuildManager2 vsSolutionBuildManager2, 
                    Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2 vsTrackProjectDocuments2, 
                    JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, 
                    JetBrains.Threading.IThreading threading, 
                    JetBrains.ProjectModel.PlatformManager platformManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, 
                    System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IQuerySolutionCloseHandler> solutionCloseHandlers, 
                    JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, 
                    JetBrains.ProjectModel.Properties.ProjectFlavoursFactory projectFlavoursFactory, 
                    JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, 
                    JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, 
                    JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer, 
                    JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public override bool IsRealSolutionOwner { get; }
        protected JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.Util.Concurrency.UnguardedCallbackMerger UnguardedCallbacks { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper VsSolutionWrapper { get; set; }
        public bool CloseSolution(JetBrains.ProjectModel.ISolution solution) { }
        protected override bool CloseSolutionInstance(JetBrains.ProjectModel.SolutionInstance instance) { }
        protected virtual void EnqueueLoadFromCache(JetBrains.ProjectModel.Impl.SolutionElement solutionElement) { }
        public int OnActiveProjectCfgChange(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pIVsHierarchy) { }
        public int OnAfterAddDirectoriesEx(int cProjects, int cDirectories, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSADDDIRECTORYFLAGS[] rgFlags) { }
        public int OnAfterAddFilesEx(int cProjects, int cFiles, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSADDFILEFLAGS[] rgFlags) { }
        public int OnAfterAsynchOpenProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy, int fAdded) { }
        public int OnAfterChangeProjectParent(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        public int OnAfterCloseSolution(object pUnkReserved) { }
        public int OnAfterClosingChildren(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        public int OnAfterLoadProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pStubHierarchy, Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pRealHierarchy) { }
        public int OnAfterMergeSolution(object pUnkReserved) { }
        public int OnAfterOpeningChildren(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        public virtual int OnAfterOpenProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy, int fAdded) { }
        public virtual int OnAfterOpenSolution(object pUnkReserved, int fNewSolution) { }
        public int OnAfterRemoveDirectories(int cProjects, int cDirectories, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSREMOVEDIRECTORYFLAGS[] rgFlags) { }
        public int OnAfterRemoveFiles(int cProjects, int cFiles, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSREMOVEFILEFLAGS[] rgFlags) { }
        public int OnAfterRenameDirectories(int cProjects, int cDirs, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgszMkOldNames, string[] rgszMkNewNames, Microsoft.VisualStudio.Shell.Interop.VSRENAMEDIRECTORYFLAGS[] rgFlags) { }
        public int OnAfterRenameFiles(int cProjects, int cFiles, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgszMkOldNames, string[] rgszMkNewNames, Microsoft.VisualStudio.Shell.Interop.VSRENAMEFILEFLAGS[] rgFlags) { }
        public int OnAfterRenameProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        public int OnAfterSccStatusChanged(int cProjects, int cFiles, Microsoft.VisualStudio.Shell.Interop.IVsProject[] rgpProjects, int[] rgFirstIndices, string[] rgpszMkDocuments, uint[] rgdwSccStatus) { }
        public virtual void OnAfterStartup() { }
        public int OnBeforeCloseProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy, int fRemoved) { }
        public int OnBeforeCloseSolution(object pUnkReserved) { }
        public int OnBeforeClosingChildren(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        public int OnBeforeOpeningChildren(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy) { }
        public int OnBeforeUnloadProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pRealHierarchy, Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pStubHierarchy) { }
        public int OnQueryAddDirectories(Microsoft.VisualStudio.Shell.Interop.IVsProject pProject, int cDirectories, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSQUERYADDDIRECTORYFLAGS[] rgFlags, Microsoft.VisualStudio.Shell.Interop.VSQUERYADDDIRECTORYRESULTS[] pSummaryResult, Microsoft.VisualStudio.Shell.Interop.VSQUERYADDDIRECTORYRESULTS[] rgResults) { }
        public int OnQueryAddFiles(Microsoft.VisualStudio.Shell.Interop.IVsProject pProject, int cFiles, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSQUERYADDFILEFLAGS[] rgFlags, Microsoft.VisualStudio.Shell.Interop.VSQUERYADDFILERESULTS[] pSummaryResult, Microsoft.VisualStudio.Shell.Interop.VSQUERYADDFILERESULTS[] rgResults) { }
        public int OnQueryChangeProjectParent(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy, Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pNewParentHier, ref int pfCancel) { }
        public int OnQueryCloseProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy, int fRemoving, ref int pfCancel) { }
        public int OnQueryCloseSolution(object pUnkReserved, ref int pfCancel) { }
        public int OnQueryRemoveDirectories(Microsoft.VisualStudio.Shell.Interop.IVsProject pProject, int cDirectories, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSQUERYREMOVEDIRECTORYFLAGS[] rgFlags, Microsoft.VisualStudio.Shell.Interop.VSQUERYREMOVEDIRECTORYRESULTS[] pSummaryResult, Microsoft.VisualStudio.Shell.Interop.VSQUERYREMOVEDIRECTORYRESULTS[] rgResults) { }
        public int OnQueryRemoveFiles(Microsoft.VisualStudio.Shell.Interop.IVsProject pProject, int cFiles, string[] rgpszMkDocuments, Microsoft.VisualStudio.Shell.Interop.VSQUERYREMOVEFILEFLAGS[] rgFlags, Microsoft.VisualStudio.Shell.Interop.VSQUERYREMOVEFILERESULTS[] pSummaryResult, Microsoft.VisualStudio.Shell.Interop.VSQUERYREMOVEFILERESULTS[] rgResults) { }
        public int OnQueryRenameDirectories(Microsoft.VisualStudio.Shell.Interop.IVsProject pProject, int cDirs, string[] rgszMkOldNames, string[] rgszMkNewNames, Microsoft.VisualStudio.Shell.Interop.VSQUERYRENAMEDIRECTORYFLAGS[] rgFlags, Microsoft.VisualStudio.Shell.Interop.VSQUERYRENAMEDIRECTORYRESULTS[] pSummaryResult, Microsoft.VisualStudio.Shell.Interop.VSQUERYRENAMEDIRECTORYRESULTS[] rgResults) { }
        public int OnQueryRenameFiles(Microsoft.VisualStudio.Shell.Interop.IVsProject pProject, int cFiles, string[] rgszMkOldNames, string[] rgszMkNewNames, Microsoft.VisualStudio.Shell.Interop.VSQUERYRENAMEFILEFLAGS[] rgFlags, Microsoft.VisualStudio.Shell.Interop.VSQUERYRENAMEFILERESULTS[] pSummaryResult, Microsoft.VisualStudio.Shell.Interop.VSQUERYRENAMEFILERESULTS[] rgResults) { }
        public int OnQueryUnloadProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pRealHierarchy, ref int pfCancel) { }
        public JetBrains.ProjectModel.ISolution OpenExistingSolution(JetBrains.Util.FileSystemPath solutionFilePath) { }
        protected void OpenVSSolution(bool openSolution, bool sync) { }
        public void StartOpenExistingSolution(JetBrains.Util.FileSystemPath solutionFilePath, System.Action callback) { }
        protected bool TryGetSolutionFilePath(bool afterOpenSolution, out JetBrains.Util.FileSystemPath solutionFilePath) { }
        public int UpdateSolution_Begin(ref int pfCancelUpdate) { }
        public int UpdateSolution_Cancel() { }
        public int UpdateSolution_Done(int fSucceeded, int fModified, int fCancelCommand) { }
        public int UpdateSolution_StartUpdate(ref int pfCancelUpdate) { }
    }
    public class VsSolutionWrapper
    {
        public VsSolutionWrapper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacksMerger) { }
        public System.Collections.Generic.Dictionary<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> ProjectsBeingUnloaded { get; }
        public JetBrains.ProjectModel.SolutionLoadStates SolutionLoadState { get; set; }
        public JetBrains.Util.Concurrency.UnguardedCallbackMerger UnguardedCallbacksMerger { get; }
        public System.Collections.Generic.Dictionary<Microsoft.VisualStudio.Shell.Interop.IVsHierarchy, System.Guid> UnloadedProjects { get; }
        public JetBrains.Util.Collections.CountingSet<Microsoft.VisualStudio.Shell.Interop.IVsProject> VsProjectsToIgnoreEventsFrom { get; }
        public void IgnoreEventsFromVsProject(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.Shell.Interop.IVsProject vsProject) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class WellKnownFoldersTracker
    {
        public WellKnownFoldersTracker(JetBrains.Application.FileSystemTracker.IFileSystemTracker tracker, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class WinJSWindowsSDKReferenceHelper
    {
        public WinJSWindowsSDKReferenceHelper([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Update.IProjectReferenceDescriptor GetWindowsSdkReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> references) { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.DataContexts
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsDataRulesSolution
    {
        public VsDataRulesSolution(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.ActionManager actionManager, JetBrains.Threading.IThreading threading, JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, JetBrains.ProjectModel.ISolution solution, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer synchronizer) { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.ProjectContent
{
    
    public interface IVSProjectContentBuilder : JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder
    {
        void CreateMissingItems(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles);
        void FillProjectDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem rootItem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles);
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VSDefaultProjectContentBuilder : JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder, JetBrains.VsIntegration.ProjectModel.ProjectContent.IVSProjectContentBuilder
    {
        protected readonly JetBrains.ProjectModel.ProjectFileExtensions myProjectFileExtensions;
        public VSDefaultProjectContentBuilder(JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions) { }
        protected virtual JetBrains.ProjectModel.Update.IProjectItemDescriptor CreateChildItemDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem childHitem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.IProjectFolderDescriptor parentFolderDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public virtual void CreateMissingItems(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public virtual void FillProjectDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem rootItem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VsPerformanceAnalyzerContentBuilder : JetBrains.VsIntegration.ProjectModel.ProjectContent.VSDefaultProjectContentBuilder
    {
        public VsPerformanceAnalyzerContentBuilder(JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions) { }
        protected override JetBrains.ProjectModel.Update.IProjectItemDescriptor CreateChildItemDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem childHitem, JetBrains.ProjectModel.Update.IProjectFolderDescriptor parentFolderDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.ProjectModel
{
    
    public interface IVsEditorGuidToFileTypeConverter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.ProjectFileType GetFileType(System.Guid editorGuid, string extension = null);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StandardEditorsToFileTypeConverter : JetBrains.VsIntegration.ProjectModel.ProjectModel.IVsEditorGuidToFileTypeConverter
    {
        public StandardEditorsToFileTypeConverter() { }
        public JetBrains.ProjectModel.ProjectFileType GetFileType(System.Guid editorGuid, string extension = null) { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.ProjectProperties
{
    
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class CSharpProjectPropertiesBuilder : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ManagedProjectPropertiesBuilder
    {
        public CSharpProjectPropertiesBuilder(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected override void ProcessConfigurationsAutomation(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase projectConfiguration, JetBrains.Util.FileSystemPath projectLocation) { }
        protected override bool ProcessManagedProjectPropertiesDispatch(JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration, VSLangProj.ProjectProperties vsProjectProperties, VSLangProj.ProjectConfigurationProperties vsProjectConfiguration) { }
    }
    public interface IProjectPropertiesFactoryVs
    {
        JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData);
        bool IsApplicable(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId);
    }
    public interface ISafeProperty
    {
        string PropertyName { get; }
        T GetPropertyValue<T>(T defaultValue = null);
    }
    public interface IVSProjectPropertiesBuilder : JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder
    {
        void RefreshImportedNamespaces(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties);
        bool RetrievePropertiesFromVSHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectLocation);
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class JavaScriptMetroStyleProjectPropertiesBuilder : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ManagedProjectPropertiesBuilder
    {
        public JavaScriptMetroStyleProjectPropertiesBuilder(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public override void RefreshImportedNamespaces(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public override bool RetrievePropertiesFromVSHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectLocation) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ManagedProjectPropertiesBuilder : JetBrains.VsIntegration.ProjectModel.IVSDescriptorBuilder, JetBrains.VsIntegration.ProjectModel.ProjectProperties.IVSProjectPropertiesBuilder
    {
        public ManagedProjectPropertiesBuilder(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        protected JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor ActiveConfigurationAccessor { get; }
        protected void CheckForExceptions([JetBrains.Annotations.InstantHandleAttribute()] System.Action getPropertyValue, ref bool result) { }
        protected static JetBrains.ProjectModel.Properties.DebugType GetDebugType(string type) { }
        protected virtual JetBrains.ProjectModel.ProjectOutputType GetOutputType([JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected virtual void ProcessBuildSettingsAutomation(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedBuildSettings) { }
        protected virtual void ProcessConfigurationsAutomation(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase projectConfiguration, JetBrains.Util.FileSystemPath projectLocation) { }
        protected virtual bool ProcessManagedProjectPropertiesDispatch([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration) { }
        protected virtual bool ProcessManagedProjectPropertiesDispatch(JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration, VSLangProj.ProjectProperties vsProjectProperties, VSLangProj.ProjectConfigurationProperties vsProjectConfiguration) { }
        public virtual void RefreshImportedNamespaces(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public virtual bool RetrievePropertiesFromVSHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectLocation) { }
    }
    public class MsBuildPropertyInstanceWrapper { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectActiveConfigurationAccessor
    {
        public ProjectActiveConfigurationAccessor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.ILogger logger, EnvDTE.DTE dte) { }
        public void AllowCachedAccess(JetBrains.DataFlow.Lifetime lifetime) { }
        public EnvDTE.Configuration GetActiveConfiguration(EnvDTE.Project vsProject) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectPropertiesFactoryVs : JetBrains.VsIntegration.ProjectModel.ProjectProperties.IProjectPropertiesFactoryVs
    {
        public ProjectPropertiesFactoryVs(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> factories) { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> Factories { get; }
        public virtual JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public virtual bool IsApplicable(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectPropertiesFactoryVsFromHierarchy : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectPropertiesFactoryVs
    {
        public ProjectPropertiesFactoryVsFromHierarchy(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> factories) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
    }
    public class SafeEnvDTEProperty : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty
    {
        public SafeEnvDTEProperty(EnvDTE.Property property) { }
        public string PropertyName { get; }
        public T GetPropertyValue<T>(T defaultValue = null) { }
    }
    public class static SafePropertyWrapperEx
    {
        public static bool GetBoolValueSafe([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property) { }
        public static int GetIntValueSafe([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property) { }
        public static string GetStringValueSafe(this JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property, string defaultValue = null) { }
        public static bool HasValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property) { }
        public static bool HasValueOfType<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SolutionFolderProjectPropertiesFactoryVs : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public override System.Guid FactoryGuid { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VBProjectPropertiesBuilder : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ManagedProjectPropertiesBuilder
    {
        public VBProjectPropertiesBuilder(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected override void ProcessBuildSettingsAutomation(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedBuildSettings) { }
        protected override void ProcessConfigurationsAutomation(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty property, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase projectConfiguration, JetBrains.Util.FileSystemPath projectLocation) { }
        protected override bool ProcessManagedProjectPropertiesDispatch(JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration, VSLangProj.ProjectProperties vsProjectProperties, VSLangProj.ProjectConfigurationProperties vsProjectConfiguration) { }
    }
    public abstract class VcxProjectPropertiesBuilder : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ManagedProjectPropertiesBuilder
    {
        protected VcxProjectPropertiesBuilder(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected abstract void ProcessVCProject(EnvDTE.Project project, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, EnvDTE.Configuration configuration, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration);
        public override void RefreshImportedNamespaces(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public virtual bool RetrievePropertiesFromVSHierarchy(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectLocation) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class WebSiteProjectFlavourFactoryVs : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectPropertiesFactoryVsFromHierarchy
    {
        public WebSiteProjectFlavourFactoryVs(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> factories) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.PropertiesExtender
{
    
    public interface IPropertiesExtenderProvider
    {
        bool CanExtend([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem);
        System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetPropertyDescriptors(JetBrains.ProjectModel.IProjectItem projectItem);
    }
    [System.ComponentModel.TypeDescriptionProviderAttribute(typeof(JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtenderTypeDescriptionProvider))]
    [System.Runtime.InteropServices.ClassInterfaceAttribute(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class PropertiesExtender
    {
        public PropertiesExtender(System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> properties) { }
        public System.ComponentModel.PropertyDescriptorCollection Properties { get; }
        public void Clear() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("551FD355-291C-4B2E-B9E7-151513EA8CDC")]
    public class PropertiesExtenderProvider : EnvDTE.IExtenderProvider
    {
        public const string CATID_ASPFolder = "{0A7F7E5E-5D30-41DD-9065-1A294D736F44}";
        public const string CATID_CSharpFolder = "{914FE278-054A-45DB-BF9E-5F22484CC84C}";
        public const string CATID_CSharpProject = "{4EF9F003-DE95-4d60-96B0-212979F2A857}";
        public const string CATID_VBFolder = "{932DC619-2EAA-4192-B7E6-3D15AD31DF49}";
        public const string CATID_VBProject = "{E0FDC879-C32A-4751-A3D3-0B3824BD575F}";
        public const string CATID_WebSite = "{EEF81A81-D390-4725-B16D-E103E0F967B4}";
        public const string ProviderGuid = "551FD355-291C-4B2E-B9E7-151513EA8CDC";
        public const string ProviderName = "ReSharperPropertiesExtenderProvider";
        public static void Advise([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtenderProvider.CanExtendParams> canExtendAction, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtenderProvider.GetExtenderParams> getExtenderAction) { }
        public bool CanExtend(string ExtenderCATID, string ExtenderName, object ExtendeeObject) { }
        public object GetExtender(string ExtenderCATID, string ExtenderName, object ExtendeeObject, EnvDTE.IExtenderSite ExtenderSite, int Cookie) { }
        public class CanExtendParams
        {
            public CanExtendParams(string extenderCatid, string extenderName, object extendeeObject) { }
            public bool CanExtend { get; set; }
            public object ExtendeeObject { get; }
            public string ExtenderCATID { get; }
            public string ExtenderName { get; }
        }
        public class GetExtenderParams
        {
            public GetExtenderParams(string extenderCatid, string extenderName, object extendeeObject, EnvDTE.IExtenderSite extenderSite, int cookie) { }
            public int Cookie { get; }
            public object ExtendeeObject { get; }
            public JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtender Extender { get; set; }
            public string ExtenderCATID { get; }
            public string ExtenderName { get; }
            public EnvDTE.IExtenderSite ExtenderSite { get; }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PropertiesExtenderProviderManager
    {
        public PropertiesExtenderProviderManager(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<bool> ExtendersAllowed { get; }
    }
    public class PropertiesExtenderTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
    {
        public PropertiesExtenderTypeDescriptionProvider() { }
        public override System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { }
    }
    public class SimplePropertyDescriptor<T> : System.ComponentModel.PropertyDescriptor
    
    {
        public SimplePropertyDescriptor(JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] string name, System.Attribute[] attrs, System.Func<T> getValueAction, System.Action<T> setValueAction) { }
        public SimplePropertyDescriptor(JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] string name, T defaultValue, string displayName, string description, string categoryName, System.Func<T> getValueAction, System.Action<T> setValueAction) { }
        public SimplePropertyDescriptor(JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] string name, T defaultValue, string displayName, string description, string categoryName, System.Type converterType, System.Func<T> getValueAction, System.Action<T> setValueAction) { }
        public override System.Type ComponentType { get; }
        public override bool IsReadOnly { get; }
        public override System.Type PropertyType { get; }
        public override bool CanResetValue(object component) { }
        public static System.Attribute[] CreateAttributes(T defaultValue, string displayName, string description, string categoryName, System.Type converterType = null, params System.Attribute[] moreAttributes) { }
        public override object GetValue(object component) { }
        public override void ResetValue(object component) { }
        public override void SetValue(object component, object value) { }
        public override bool ShouldSerializeValue(object component) { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.Transactions.Actions
{
    
    public class VsAddReferenceAction : JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction
    {
        public VsAddReferenceAction(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule moduleToReference, JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        public override void Commit() { }
    }
    public class VsAddReferenceAction2 : JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction2
    {
        public VsAddReferenceAction2(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedAssembly, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer) { }
        public override void Commit() { }
    }
    public class VsRemoveReferenceAction : JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveReferenceAction
    {
        public VsRemoveReferenceAction(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCollection assemblyCollection) { }
        public override void Commit() { }
    }
}
namespace JetBrains.VsIntegration.ProjectModel.Transactions
{
    
    [JetBrains.ProjectModel.Properties.SolutionProjectModelExtensionAttribute()]
    public class DefaultVsFilesAndFoldersEditor : JetBrains.VsIntegration.ProjectModel.Transactions.IVsFilesAndFoldersEditor
    {
        protected readonly JetBrains.DocumentManagers.DocumentManager myDocumentManager;
        protected readonly JetBrains.DocumentManagers.impl.DocumentManagerOperations myDocumentOperations;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        protected readonly JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer myProjectModelSynchronizer;
        protected readonly JetBrains.VsIntegration.ProjectModel.VSSolutionExplorer mySolutionExplorer;
        protected readonly JetBrains.Util.Concurrency.UnguardedCallbackMerger myUnguardedCallbacks;
        protected readonly JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization myVSDocumentManagerSynchronization;
        public DefaultVsFilesAndFoldersEditor(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.VsIntegration.ProjectModel.VSSolutionExplorer solutionExplorer, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        protected void AssertIsVsSolution() { }
        public virtual JetBrains.ProjectModel.Transaction.Actions.AddFileAction CreateAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location) { }
        public virtual JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction CreateAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath) { }
        public virtual JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction CreateCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public virtual JetBrains.ProjectModel.Model2.Transaction.Actions.MoveAction CreateMoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public virtual JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction CreateRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public virtual JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction CreateRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    public interface IVsFilesAndFoldersEditor
    {
        JetBrains.ProjectModel.Transaction.Actions.AddFileAction CreateAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location);
        JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction CreateAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath);
        JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction CreateCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem);
        JetBrains.ProjectModel.Model2.Transaction.Actions.MoveAction CreateMoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem);
        JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction CreateRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem);
        JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction CreateRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName);
        bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties);
    }
}
namespace JetBrains.VsIntegration.Resources
{
    
    public sealed class VsIntegrationThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.VisualStudio.Core;component/resources/VsIntegrationT" +
            "hemedIcons/ThemedIcons.VsIntegration.Generated.Xaml", 0, "ProductSuspended")]
        public sealed class ProductSuspended : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.VsIntegration.Settings
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.None)]
    public class VSFileSettingsStorageQueryWritabilityHandler : JetBrains.Application.Settings.Storage.Persistence.IFileSettingsStorageBehaviorProvider
    {
        public VSFileSettingsStorageQueryWritabilityHandler(Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2 vsQueryEditQuery) { }
        public void Bind(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.Storage.Persistence.IFileSettingsStorageBehavior behavior) { }
        public bool QueryEditFile(JetBrains.Util.FileSystemPath path) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsSaveMonitor
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISimpleSignal SaveExecuted;
        public VsSaveMonitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.DTE dte) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsToolsOptionsMonitor
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISimpleSignal VsOptionsMightHaveChanged;
        public VsToolsOptionsMonitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.DTE dte) { }
    }
}
namespace JetBrains.VsIntegration.Template
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsTemplateManager
    {
        public VsTemplateManager(JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, EnvDTE.DTE dte, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.VsIntegration.Interop.Shim.Shell.IVsShell vsShell, Microsoft.VisualStudio.Shell.Interop.IVsExtensibility3 vsExtensibility) { }
        public void AddFromTemplate(JetBrains.ProjectModel.IProjectFolder folder, JetBrains.Util.FileSystemPath templatePath, string name) { }
        public void AddFromTemplate(JetBrains.ProjectModel.IProjectFolder folder, JetBrains.Util.FileSystemPath templatePath, string name, System.Collections.Generic.IDictionary<string, object> customParameters) { }
        public JetBrains.Util.FileSystemPath GetProjectItemTemplate(string templateName, string language) { }
        public JetBrains.Util.FileSystemPath GetProjectTemplate(string templateName, string language) { }
        public bool RunWizard(JetBrains.ProjectModel.IProjectFolder folder, JetBrains.Util.FileSystemPath templatePath, string name, System.Collections.Generic.IDictionary<string, object> customParameters) { }
    }
}
namespace JetBrains.VsIntegration.TextControl
{
    
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class TextControlActionAttribute : System.Attribute
    {
        public TextControlActionAttribute(string textControlActionName) { }
        public string TextControlActionName { get; }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class TextControlSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TypeSpace"})]
    public class TypeSpaceAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public enum VsColorTypeEnum
    {
        FOREGROUND = 0,
        BACKGROUND = 1,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsDefaultTextControlSchemeManager : JetBrains.TextControl.Impl.DefaultTextControlSchemeManagerImpl, System.IDisposable
    {
        public const string CurrentLineDisplayItem = "Current Line";
        public VsDefaultTextControlSchemeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.CommonControls.Fonts.FontsManager fontsman, EnvDTE.DTE dte, Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager, JetBrains.Threading.IThreading threading, JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.VsIntegration.Settings.VsToolsOptionsMonitor vsToolsOptionsMonitor) { }
        public override System.Drawing.Color CodeEditorBackground { get; }
        public override System.Drawing.Color CodeEditorForeground { get; }
        public override System.Drawing.Color CommentColor { get; }
        public override System.Drawing.Color KeywordColor { get; }
        public override System.Drawing.Color MethodColor { get; }
        public override System.Drawing.Color ParameterColor { get; }
        public override System.Drawing.Color PreprocessorKeywordColor { get; }
        public override System.Drawing.Color ReadonlyBackground { get; }
        public override System.Drawing.Color StringColor { get; }
        public override System.Drawing.Color TypeColor { get; }
        public System.Drawing.Imaging.ImageAttributes GetCurrentLineAttributes() { }
        public override JetBrains.TextControl.TextControlScheme GetScheme() { }
        public override void SetScheme(JetBrains.TextControl.TextControlScheme scheme) { }
    }
    public class static VsEditorCommands
    {
        public static string GetActionID(System.ComponentModel.Design.CommandID commandid) { }
        public static System.Collections.Generic.ICollection<string> GetActionIDs() { }
        public static bool IsEnter(System.ComponentModel.Design.CommandID commandid) { }
        public static bool IsTyping(System.ComponentModel.Design.CommandID cmdid) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsInitActionSystemAdapter : JetBrains.TextControl.Actions.Adapters.InitActionSystemAdapter
    {
        public VsInitActionSystemAdapter(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.VsIntegration.TextControl.VsTextControlsActionSystemInit vsTextControlsActionSystemInit) { }
        protected override void Init() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextControlChangeUnitFactory : JetBrains.TextControl.Util.TextControlChangeUnitFactory
    {
        public VsTextControlChangeUnitFactory(JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager> vsLinkedUndoTransactionManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.VsIntegration.DocumentModel.IVsOleUndoManagerProvider vsOleUndoManagerProvider, JetBrains.Threading.IThreading threading) { }
        public override System.IDisposable CreateChangeUnit(JetBrains.TextControl.ITextControl textControl, string changeName, JetBrains.TextControl.Util.TransactionKind kind, System.Action finishAction) { }
    }
    public abstract class VsTextControlCommon : JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime DisposablesUnguarded;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.ErrorStripeIndicatorState> ErrorStripeIndicatorState;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.TextControl.Impl.TextControlChange> FireTextControlChange;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Lifetime;
        protected readonly JetBrains.DocumentModel.Impl.DocumentChangeManager myDocumentChangeManager;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.TextControlScheme> Scheme;
        protected VsTextControlCommon([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.VsDocumentCommon document, JetBrains.Application.IShellLocks shellLocks, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager) { }
        public abstract JetBrains.TextControl.ITextControlCaret Caret { get; }
        public JetBrains.VsIntegration.Whidbey.TextControl.VsTextControlOleCommandTarget CommandFilter { get; }
        public abstract JetBrains.TextControl.Coords.ITextControlCoords Coords { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public bool IsDisposed { get; }
        public virtual bool IsReadOnly { get; }
        public virtual bool IsVsAlive { get; }
        public bool IsVsDead { get; }
        public JetBrains.Application.IShellLocks Locks { get; }
        public abstract JetBrains.TextControl.ITextControlScrolling Scrolling { get; }
        public abstract JetBrains.TextControl.ITextControlSelection Selection { get; }
        public abstract JetBrains.TextControl.ITextControlWindow Window { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> BeforeDispose;
        public void Dispose() { }
        public void EmulateEnter() { }
        public void EmulateTyping(char c) { }
        protected abstract object Execute(JetBrains.Application.IChangeMap changeMap);
        public abstract void FillVirtualSpaceUntilCaret();
        public virtual System.IDisposable GetUpdateCookie([JetBrains.Annotations.NotNullAttribute()] string description) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction GetVsTextViewCompoundAction();
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget GetVsTextViewOleCommandTarget();
        protected virtual void Init_AfterFieldInit() { }
        public virtual bool IsPositionInTextView(JetBrains.TextControl.Coords.ITextControlPos position) { }
        public abstract void PushOleCommandFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget filter, [JetBrains.Annotations.NotNullAttribute()] out Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget callnext);
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public abstract void SyncToVsGuarded();
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void SyncToVsUnguarded() { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextControlCreatorCommon : JetBrains.TextControl.TextControlCreator
    {
        public VsTextControlCreatorCommon(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Components.IComponentContainer componentContainer, JetBrains.TextControl.StandaloneTextControlSwitchingGraphicsProvider switchingGraphicsProvider, JetBrains.Application.IShellLocks invocator, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, JetBrains.TextControl.RunningTextControls runningTextControls) { }
        public override JetBrains.TextControl.IWinFormTextControl CreateShellTextControl(JetBrains.DocumentModel.IDocument document, JetBrains.UI.WindowManagement.WindowFrame frame) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public sealed class VsTextControlsActionSystemInit
    {
        public VsTextControlsActionSystemInit([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ActionManagement.VsActionLoader vsActionLoader, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IShortcutManager shortcutManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextControlTypingHandlersCommon : JetBrains.TextControl.Impl.TextControlTypingHandlers
    {
        public VsTextControlTypingHandlersCommon(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor) { }
    }
}
namespace JetBrains.VsIntegration.ToolWindowManagement
{
    
    public class VsToolWindowFrame : JetBrains.UI.ToolWindowManagement.TopLevelToolWindowFrameBase, Microsoft.VisualStudio.Shell.Interop.IVsWindowFrameNotify, Microsoft.VisualStudio.Shell.Interop.IVsWindowFrameNotify2
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Theming.EitherColor> ToolWindowBackground;
        public VsToolWindowFrame(JetBrains.DataFlow.Lifetime lifetime, int iconResourceId, JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor toolWindowDescriptor, Microsoft.VisualStudio.Shell.Interop.IVsUIShell vsUiShell, Microsoft.VisualStudio.Shell.Interop.IVsUIShell2 vsUiShell2, JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.UndoManager.VsOleUndoManagerFactory oleUndoManagerFactory, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public System.Guid Guid { get; }
        public override void Close() { }
        public static void CreateToolWindow(Microsoft.VisualStudio.Shell.Interop.IVsUIShell vsUiShell, JetBrains.UI.ToolWindowManagement.ToolWindowId id, System.Guid persistenceGuid, string defaultCaption, Microsoft.VisualStudio.Shell.Interop.IVsUIShell2 vsUiShell2) { }
        public Microsoft.VisualStudio.OLE.Interop.IOleUndoManager GetOleUndoManager() { }
        public int OnClose(ref uint pgrfSaveOptions) { }
        public int OnDockableChange(int fDockable) { }
        public int OnMove() { }
        public int OnShow(int fShow) { }
        public int OnSize() { }
        public override void Show(bool activate = True) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTopLevelToolWindowFrameFactory : JetBrains.UI.ToolWindowManagement.TopLevelToolWindowFrameFactory
    {
        public VsTopLevelToolWindowFrameFactory(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.Shell.Interop.IVsUIShell vsUiShell, Microsoft.VisualStudio.Shell.Interop.IVsUIShell2 vsUiShell2, JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, JetBrains.VsIntegration.UndoManager.VsOleUndoManagerFactory oleUndoManagerFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.WindowManagement.IVsToolWindowIconResourceIds toolWindowIconResourceIds, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public override JetBrains.UI.ToolWindowManagement.TopLevelToolWindowFrameBase CreateTopLevelFrame(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor toolWindowDescriptor) { }
        public override bool IsFrameRequired(JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor toolWindowDescriptor) { }
    }
}
namespace JetBrains.VsIntegration.UI
{
    
    public class ErrorSavingSettingsForm : System.Windows.Forms.Form
    {
        public ErrorSavingSettingsForm(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public string ErrorMessage { set; }
        public JetBrains.Util.FileSystemPath Path { set; }
        public System.Func<string> TrySaveFunction { set; }
        public System.Action<System.IO.Stream> WriteAction { set; }
        protected override void Dispose(bool disposing) { }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsFontsManager : JetBrains.UI.CommonControls.Fonts.FontsManager
    {
        public VsFontsManager(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage vsFontAndColorStorage, EnvDTE.DTE dte, Microsoft.VisualStudio.Shell.Interop.IUIHostLocale iuiHostLocale, JetBrains.Threading.IThreading threading, Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager) { }
        public static System.Drawing.Font GetVSEditorFont(Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager) { }
    }
    public class static VsSpecialColorTableFromSysColorEx
    {
        public static void PopulateVsSpecialColorTable(Microsoft.VisualStudio.Shell.Interop.IVsUIShell2 vsUiShell2) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsStatusBarTextCommon
    {
        public VsStatusBarTextCommon(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.StatusBar.IStatusBar statusbar, JetBrains.UI.StatusBar.SubclassedStatusBar subclassedStatusBar, EnvDTE.DTE dte, JetBrains.Threading.IThreading threading) { }
    }
    public enum VSSYSCOLOREX
    {
        VSCOLOR_08_ACCENT_BORDER = -5,
        VSCOLOR_08_ACCENT_DARK = -6,
        VSCOLOR_08_ACCENT_LIGHT = -7,
        VSCOLOR_08_ACCENT_MEDIUM = -8,
        VSCOLOR_08_ACCENT_PALE = -9,
        VSCOLOR_08_COMMANDBAR_BORDER = -10,
        VSCOLOR_08_COMMANDBAR_DRAGHANDLE = -11,
        VSCOLOR_08_COMMANDBAR_DRAGHANDLE_SHADOW = -12,
        VSCOLOR_08_COMMANDBAR_GRADIENT_BEGIN = -13,
        VSCOLOR_08_COMMANDBAR_GRADIENT_END = -14,
        VSCOLOR_08_COMMANDBAR_GRADIENT_MIDDLE = -15,
        VSCOLOR_08_COMMANDBAR_HOVER = -16,
        VSCOLOR_08_COMMANDBAR_HOVEROVERSELECTED = -17,
        VSCOLOR_08_COMMANDBAR_HOVEROVERSELECTEDICON = -18,
        VSCOLOR_08_COMMANDBAR_HOVEROVERSELECTEDICON_BORDER = -19,
        VSCOLOR_08_COMMANDBAR_SELECTED = -20,
        VSCOLOR_08_COMMANDBAR_SHADOW = -21,
        VSCOLOR_08_COMMANDBAR_TEXT_ACTIVE = -22,
        VSCOLOR_08_COMMANDBAR_TEXT_HOVER = -23,
        VSCOLOR_08_COMMANDBAR_TEXT_INACTIVE = -24,
        VSCOLOR_08_COMMANDBAR_TEXT_SELECTED = -25,
        VSCOLOR_08_CONTROL_EDIT_HINTTEXT = -26,
        VSCOLOR_08_CONTROL_EDIT_REQUIRED_BACKGROUND = -27,
        VSCOLOR_08_CONTROL_EDIT_REQUIRED_HINTTEXT = -28,
        VSCOLOR_08_CONTROL_LINK_TEXT = -29,
        VSCOLOR_08_CONTROL_LINK_TEXT_HOVER = -30,
        VSCOLOR_08_CONTROL_LINK_TEXT_PRESSED = -31,
        VSCOLOR_08_CONTROL_OUTLINE = -32,
        VSCOLOR_08_DEBUGGER_DATATIP_ACTIVE_BACKGROUND = -33,
        VSCOLOR_08_DEBUGGER_DATATIP_ACTIVE_BORDER = -34,
        VSCOLOR_08_DEBUGGER_DATATIP_ACTIVE_HIGHLIGHT = -35,
        VSCOLOR_08_DEBUGGER_DATATIP_ACTIVE_HIGHLIGHTTEXT = -36,
        VSCOLOR_08_DEBUGGER_DATATIP_ACTIVE_SEPARATOR = -37,
        VSCOLOR_08_DEBUGGER_DATATIP_ACTIVE_TEXT = -38,
        VSCOLOR_08_DEBUGGER_DATATIP_INACTIVE_BACKGROUND = -39,
        VSCOLOR_08_DEBUGGER_DATATIP_INACTIVE_BORDER = -40,
        VSCOLOR_08_DEBUGGER_DATATIP_INACTIVE_HIGHLIGHT = -41,
        VSCOLOR_08_DEBUGGER_DATATIP_INACTIVE_HIGHLIGHTTEXT = -42,
        VSCOLOR_08_DEBUGGER_DATATIP_INACTIVE_SEPARATOR = -43,
        VSCOLOR_08_DEBUGGER_DATATIP_INACTIVE_TEXT = -44,
        VSCOLOR_08_DESIGNER_BACKGROUND = -45,
        VSCOLOR_08_DESIGNER_SELECTIONDOTS = -46,
        VSCOLOR_08_DESIGNER_TRAY = -47,
        VSCOLOR_08_DESIGNER_WATERMARK = -48,
        VSCOLOR_08_EDITOR_EXPANSION_BORDER = -49,
        VSCOLOR_08_EDITOR_EXPANSION_FILL = -50,
        VSCOLOR_08_EDITOR_EXPANSION_LINK = -51,
        VSCOLOR_08_EDITOR_EXPANSION_TEXT = -52,
        VSCOLOR_08_ENVIRONMENT_BACKGROUND = -53,
        VSCOLOR_08_ENVIRONMENT_BACKGROUND_GRADIENTBEGIN = -54,
        VSCOLOR_08_ENVIRONMENT_BACKGROUND_GRADIENTEND = -55,
        VSCOLOR_08_FILETAB_BORDER = -56,
        VSCOLOR_08_FILETAB_CHANNELBACKGROUND = -57,
        VSCOLOR_08_FILETAB_GRADIENTDARK = -58,
        VSCOLOR_08_FILETAB_GRADIENTLIGHT = -59,
        VSCOLOR_08_FILETAB_SELECTEDBACKGROUND = -60,
        VSCOLOR_08_FILETAB_SELECTEDBORDER = -61,
        VSCOLOR_08_FILETAB_SELECTEDTEXT = -62,
        VSCOLOR_08_FILETAB_TEXT = -63,
        VSCOLOR_08_FORMSMARTTAG_ACTIONTAG_BORDER = -64,
        VSCOLOR_08_FORMSMARTTAG_ACTIONTAG_FILL = -65,
        VSCOLOR_08_FORMSMARTTAG_OBJECTTAG_BORDER = -66,
        VSCOLOR_08_FORMSMARTTAG_OBJECTTAG_FILL = -67,
        VSCOLOR_08_GRID_HEADING_BACKGROUND = -68,
        VSCOLOR_08_GRID_HEADING_TEXT = -69,
        VSCOLOR_08_GRID_LINE = -70,
        VSCOLOR_08_HELP_HOWDOI_PANE_BACKGROUND = -71,
        VSCOLOR_08_HELP_HOWDOI_PANE_LINK = -72,
        VSCOLOR_08_HELP_HOWDOI_PANE_TEXT = -73,
        VSCOLOR_08_HELP_HOWDOI_TASK_BACKGROUND = -74,
        VSCOLOR_08_HELP_HOWDOI_TASK_LINK = -75,
        VSCOLOR_08_HELP_HOWDOI_TASK_TEXT = -76,
        VSCOLOR_08_HELP_SEARCH_BACKGROUND = -92,
        VSCOLOR_08_HELP_SEARCH_BORDER = -79,
        VSCOLOR_08_HELP_SEARCH_FITLER_BACKGROUND = -81,
        VSCOLOR_08_HELP_SEARCH_FITLER_BORDER = -82,
        VSCOLOR_08_HELP_SEARCH_FITLER_TEXT = -80,
        VSCOLOR_08_HELP_SEARCH_FRAME_BACKGROUND = -77,
        VSCOLOR_08_HELP_SEARCH_FRAME_TEXT = -78,
        VSCOLOR_08_HELP_SEARCH_PANEL_RULES = -94,
        VSCOLOR_08_HELP_SEARCH_PROVIDER_ICON = -87,
        VSCOLOR_08_HELP_SEARCH_PROVIDER_SELECTED_BACKGROUND = -85,
        VSCOLOR_08_HELP_SEARCH_PROVIDER_SELECTED_TEXT = -86,
        VSCOLOR_08_HELP_SEARCH_PROVIDER_UNSELECTED_BACKGROUND = -83,
        VSCOLOR_08_HELP_SEARCH_PROVIDER_UNSELECTED_TEXT = -84,
        VSCOLOR_08_HELP_SEARCH_RESULT_LINK_SELECTED = -88,
        VSCOLOR_08_HELP_SEARCH_RESULT_LINK_UNSELECTED = -89,
        VSCOLOR_08_HELP_SEARCH_RESULT_SELECTED_BACKGROUND = -90,
        VSCOLOR_08_HELP_SEARCH_RESULT_SELECTED_TEXT = -91,
        VSCOLOR_08_HELP_SEARCH_TEXT = -93,
        VSCOLOR_08_LASTEX = -178,
        VSCOLOR_08_MDICLIENT_BORDER = -95,
        VSCOLOR_08_PANEL_BORDER = -96,
        VSCOLOR_08_PANEL_GRADIENTDARK = -97,
        VSCOLOR_08_PANEL_GRADIENTLIGHT = -98,
        VSCOLOR_08_PANEL_HOVEROVERCLOSE_BORDER = -99,
        VSCOLOR_08_PANEL_HOVEROVERCLOSE_FILL = -100,
        VSCOLOR_08_PANEL_HYPERLINK = -101,
        VSCOLOR_08_PANEL_HYPERLINK_HOVER = -102,
        VSCOLOR_08_PANEL_HYPERLINK_PRESSED = -103,
        VSCOLOR_08_PANEL_SEPARATOR = -104,
        VSCOLOR_08_PANEL_SUBGROUPSEPARATOR = -105,
        VSCOLOR_08_PANEL_TEXT = -106,
        VSCOLOR_08_PANEL_TITLEBAR = -107,
        VSCOLOR_08_PANEL_TITLEBAR_TEXT = -108,
        VSCOLOR_08_PANEL_TITLEBAR_UNSELECTED = -109,
        VSCOLOR_08_PROJECTDESIGNER_BACKGROUND_GRADIENTBEGIN = -110,
        VSCOLOR_08_PROJECTDESIGNER_BACKGROUND_GRADIENTEND = -111,
        VSCOLOR_08_PROJECTDESIGNER_BORDER_INSIDE = -113,
        VSCOLOR_08_PROJECTDESIGNER_BORDER_OUTSIDE = -112,
        VSCOLOR_08_PROJECTDESIGNER_CONTENTS_BACKGROUND = -114,
        VSCOLOR_08_PROJECTDESIGNER_TAB_BACKGROUND_GRADIENTBEGIN = -115,
        VSCOLOR_08_PROJECTDESIGNER_TAB_BACKGROUND_GRADIENTEND = -116,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SELECTED_BACKGROUND = -121,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SELECTED_BORDER = -118,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SELECTED_HIGHLIGHT1 = -119,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SELECTED_HIGHLIGHT2 = -120,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SELECTED_INSIDEBORDER = -117,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SEP_BOTTOM_GRADIENTBEGIN = -122,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SEP_BOTTOM_GRADIENTEND = -123,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SEP_TOP_GRADIENTBEGIN = -124,
        VSCOLOR_08_PROJECTDESIGNER_TAB_SEP_TOP_GRADIENTEND = -125,
        VSCOLOR_08_SCREENTIP_BACKGROUND = -127,
        VSCOLOR_08_SCREENTIP_BORDER = -126,
        VSCOLOR_08_SCREENTIP_TEXT = -128,
        VSCOLOR_08_SIDEBAR_BACKGROUND = -129,
        VSCOLOR_08_SIDEBAR_GRADIENTDARK = -130,
        VSCOLOR_08_SIDEBAR_GRADIENTLIGHT = -131,
        VSCOLOR_08_SIDEBAR_TEXT = -132,
        VSCOLOR_08_SMARTTAG_BORDER = -133,
        VSCOLOR_08_SMARTTAG_FILL = -134,
        VSCOLOR_08_SMARTTAG_HOVER_BORDER = -135,
        VSCOLOR_08_SMARTTAG_HOVER_FILL = -136,
        VSCOLOR_08_SMARTTAG_HOVER_TEXT = -137,
        VSCOLOR_08_SMARTTAG_TEXT = -138,
        VSCOLOR_08_SNAPLINES = -139,
        VSCOLOR_08_SNAPLINES_PADDING = -140,
        VSCOLOR_08_SNAPLINES_TEXTBASELINE = -141,
        VSCOLOR_08_SORT_BACKGROUND = -142,
        VSCOLOR_08_SORT_TEXT = -143,
        VSCOLOR_08_TASKLIST_GRIDLINES = -144,
        VSCOLOR_08_TITLEBAR_ACTIVE = -145,
        VSCOLOR_08_TITLEBAR_ACTIVE_GRADIENTBEGIN = -146,
        VSCOLOR_08_TITLEBAR_ACTIVE_GRADIENTEND = -147,
        VSCOLOR_08_TITLEBAR_ACTIVE_TEXT = -148,
        VSCOLOR_08_TITLEBAR_INACTIVE = -149,
        VSCOLOR_08_TITLEBAR_INACTIVE_GRADIENTBEGIN = -150,
        VSCOLOR_08_TITLEBAR_INACTIVE_GRADIENTEND = -151,
        VSCOLOR_08_TITLEBAR_INACTIVE_TEXT = -152,
        VSCOLOR_08_TOOLBOX_BACKGROUND = -153,
        VSCOLOR_08_TOOLBOX_DIVIDER = -154,
        VSCOLOR_08_TOOLBOX_GRADIENTDARK = -155,
        VSCOLOR_08_TOOLBOX_GRADIENTLIGHT = -156,
        VSCOLOR_08_TOOLBOX_HEADINGACCENT = -157,
        VSCOLOR_08_TOOLBOX_HEADINGBEGIN = -158,
        VSCOLOR_08_TOOLBOX_HEADINGEND = -159,
        VSCOLOR_08_TOOLBOX_ICON_HIGHLIGHT = -160,
        VSCOLOR_08_TOOLBOX_ICON_SHADOW = -161,
        VSCOLOR_08_TOOLWINDOW_BACKGROUND = -162,
        VSCOLOR_08_TOOLWINDOW_BORDER = -163,
        VSCOLOR_08_TOOLWINDOW_BUTTON_DOWN = -164,
        VSCOLOR_08_TOOLWINDOW_BUTTON_DOWN_BORDER = -165,
        VSCOLOR_08_TOOLWINDOW_BUTTON_HOVER_ACTIVE = -166,
        VSCOLOR_08_TOOLWINDOW_BUTTON_HOVER_ACTIVE_BORDER = -167,
        VSCOLOR_08_TOOLWINDOW_BUTTON_HOVER_INACTIVE = -168,
        VSCOLOR_08_TOOLWINDOW_BUTTON_HOVER_INACTIVE_BORDER = -169,
        VSCOLOR_08_TOOLWINDOW_TAB_BORDER = -172,
        VSCOLOR_08_TOOLWINDOW_TAB_GRADIENTBEGIN = -173,
        VSCOLOR_08_TOOLWINDOW_TAB_GRADIENTEND = -174,
        VSCOLOR_08_TOOLWINDOW_TAB_SELECTEDTAB = -171,
        VSCOLOR_08_TOOLWINDOW_TAB_SELECTEDTEXT = -176,
        VSCOLOR_08_TOOLWINDOW_TAB_TEXT = -175,
        VSCOLOR_08_TOOLWINDOW_TEXT = -170,
        VSCOLOR_08_WIZARD_ORIENTATIONPANEL_BACKGROUND = -177,
        VSCOLOR_08_WIZARD_ORIENTATIONPANEL_TEXT = -178,
        VSCOLOR_09_BRANDEDUI_BACKGROUND = -190,
        VSCOLOR_09_BRANDEDUI_BORDER = -188,
        VSCOLOR_09_BRANDEDUI_FILL = -191,
        VSCOLOR_09_BRANDEDUI_TEXT = -189,
        VSCOLOR_09_BRANDEDUI_TITLE = -187,
        VSCOLOR_09_FILETAB_DOCUMENTBORDER_BACKGROUND = -185,
        VSCOLOR_09_FILETAB_DOCUMENTBORDER_HIGHLIGHT = -186,
        VSCOLOR_09_FILETAB_DOCUMENTBORDER_SHADOW = -184,
        VSCOLOR_09_FILETAB_HOT_GRADIENTBOTTOM = -183,
        VSCOLOR_09_FILETAB_HOT_GRADIENTTOP = -182,
        VSCOLOR_09_FILETAB_SELECTED_GRADIENTBOTTOM = -181,
        VSCOLOR_09_FILETAB_SELECTED_GRADIENTTOP = -180,
        VSCOLOR_09_LASTEX2 = -191,
        VSCOLOR_09_SPLASHSCREEN_BORDER = -179,
        VSCOLOR_10_LASTEX3 = -505,
        VSCOLOR_10_VIZSURFACE_STRONGBLUE_MEDIUM = -505,
        VSCOLOR_10_VIZSURFACE_STRONGBLUE_LIGHT = -504,
        VSCOLOR_10_VIZSURFACE_STRONGBLUE_DARK = -503,
        VSCOLOR_10_VIZSURFACE_STEELBLUE_MEDIUM = -502,
        VSCOLOR_10_VIZSURFACE_STEELBLUE_LIGHT = -501,
        VSCOLOR_10_VIZSURFACE_STEELBLUE_DARK = -500,
        VSCOLOR_10_VIZSURFACE_SOFTBLUE_MEDIUM = -499,
        VSCOLOR_10_VIZSURFACE_SOFTBLUE_LIGHT = -498,
        VSCOLOR_10_VIZSURFACE_SOFTBLUE_DARK = -497,
        VSCOLOR_10_VIZSURFACE_RED_MEDIUM = -496,
        VSCOLOR_10_VIZSURFACE_RED_LIGHT = -495,
        VSCOLOR_10_VIZSURFACE_RED_DARK = -494,
        VSCOLOR_10_VIZSURFACE_PLUM_MEDIUM = -493,
        VSCOLOR_10_VIZSURFACE_PLUM_LIGHT = -492,
        VSCOLOR_10_VIZSURFACE_PLUM_DARK = -491,
        VSCOLOR_10_VIZSURFACE_GREEN_MEDIUM = -490,
        VSCOLOR_10_VIZSURFACE_GREEN_LIGHT = -489,
        VSCOLOR_10_VIZSURFACE_GREEN_DARK = -488,
        VSCOLOR_10_VIZSURFACE_GOLD_MEDIUM = -487,
        VSCOLOR_10_VIZSURFACE_GOLD_LIGHT = -486,
        VSCOLOR_10_VIZSURFACE_GOLD_DARK = -485,
        VSCOLOR_10_VIZSURFACE_DARKGOLD_MEDIUM = -484,
        VSCOLOR_10_VIZSURFACE_DARKGOLD_LIGHT = -483,
        VSCOLOR_10_VIZSURFACE_DARKGOLD_DARK = -482,
        VSCOLOR_10_VIZSURFACE_BROWN_MEDIUM = -481,
        VSCOLOR_10_VIZSURFACE_BROWN_LIGHT = -480,
        VSCOLOR_10_VIZSURFACE_BROWN_DARK = -479,
        VSCOLOR_10_TOOLWINDOW_TAB_MOUSEOVER_TEXT = -478,
        VSCOLOR_10_TOOLWINDOW_TAB_MOUSEOVER_BORDER = -477,
        VSCOLOR_10_TOOLWINDOW_TAB_MOUSEOVER_BACKGROUND_END = -476,
        VSCOLOR_10_TOOLWINDOW_TAB_MOUSEOVER_BACKGROUND_BEGIN = -475,
        VSCOLOR_10_TOOLWINDOW_FLOATING_FRAME = -474,
        VSCOLOR_10_TOOLWINDOW_CONTENTTAB_GRADIENTEND = -473,
        VSCOLOR_10_TOOLWINDOW_CONTENTTAB_GRADIENTBEGIN = -472,
        VSCOLOR_10_TOOLWINDOW_BUTTON_DOWN_ACTIVE_GLYPH = -471,
        VSCOLOR_10_TOOLWINDOW_BUTTON_HOVER_ACTIVE_GLYPH = -470,
        VSCOLOR_10_TOOLWINDOW_BUTTON_ACTIVE_GLYPH = -469,
        VSCOLOR_10_TOOLWINDOW_BUTTON_DOWN_INACTIVE_GLYPH = -468,
        VSCOLOR_10_TOOLWINDOW_BUTTON_HOVER_INACTIVE_GLYPH = -467,
        VSCOLOR_10_TOOLWINDOW_BUTTON_INACTIVE_BORDER = -466,
        VSCOLOR_10_TOOLWINDOW_BUTTON_INACTIVE = -465,
        VSCOLOR_10_TOOLWINDOW_BUTTON_INACTIVE_GLYPH = -464,
        VSCOLOR_10_TOOLBOX_SELECTED_HEADING_END = -463,
        VSCOLOR_10_TOOLBOX_SELECTED_HEADING_MIDDLE2 = -462,
        VSCOLOR_10_TOOLBOX_SELECTED_HEADING_MIDDLE1 = -461,
        VSCOLOR_10_TOOLBOX_SELECTED_HEADING_BEGIN = -460,
        VSCOLOR_10_TITLEBAR_ACTIVE_GRADIENTMIDDLE2 = -459,
        VSCOLOR_10_TITLEBAR_ACTIVE_GRADIENTMIDDLE1 = -458,
        VSCOLOR_10_STATUSBAR_TEXT = -457,
        VSCOLOR_10_STARTPAGE_UNSELECTEDITEM_STROKE = -456,
        VSCOLOR_10_STARTPAGE_UNSELECTEDITEM_BACKGROUND_END = -455,
        VSCOLOR_10_STARTPAGE_UNSELECTEDITEM_BACKGROUND_BEGIN = -454,
        VSCOLOR_10_STARTPAGE_TEXT_SUBHEADING_SELECTED = -453,
        VSCOLOR_10_STARTPAGE_TEXT_SUBHEADING_MOUSEOVER = -452,
        VSCOLOR_10_STARTPAGE_TEXT_SUBHEADING = -451,
        VSCOLOR_10_STARTPAGE_TEXT_HEADING_SELECTED = -450,
        VSCOLOR_10_STARTPAGE_TEXT_HEADING_MOUSEOVER = -449,
        VSCOLOR_10_STARTPAGE_TEXT_HEADING = -448,
        VSCOLOR_10_STARTPAGE_TEXT_DATE = -447,
        VSCOLOR_10_STARTPAGE_TEXT_CONTROL_LINK_SELECTED_HOVER = -446,
        VSCOLOR_10_STARTPAGE_TEXT_CONTROL_LINK_SELECTED = -445,
        VSCOLOR_10_STARTPAGE_TEXT_BODY_UNSELECTED = -444,
        VSCOLOR_10_STARTPAGE_TEXT_BODY_SELECTED = -443,
        VSCOLOR_10_STARTPAGE_TEXT_BODY = -442,
        VSCOLOR_10_STARTPAGE_TAB_MOUSEOVER_BACKGROUND_END = -441,
        VSCOLOR_10_STARTPAGE_TAB_MOUSEOVER_BACKGROUND_BEGIN = -440,
        VSCOLOR_10_STARTPAGE_TAB_BACKGROUND_END = -439,
        VSCOLOR_10_STARTPAGE_TAB_BACKGROUND_BEGIN = -438,
        VSCOLOR_10_STARTPAGE_SEPARATOR = -437,
        VSCOLOR_10_STARTPAGE_SELECTEDITEM_STROKE = -436,
        VSCOLOR_10_STARTPAGE_SELECTEDITEM_BACKGROUND = -435,
        VSCOLOR_10_STARTPAGE_BUTTONTEXT_HOVER = -434,
        VSCOLOR_10_STARTPAGE_BUTTONTEXT = -433,
        VSCOLOR_10_STARTPAGE_BUTTON_UNPINNED = -432,
        VSCOLOR_10_STARTPAGE_BUTTON_PIN_HOVER = -431,
        VSCOLOR_10_STARTPAGE_BUTTON_PIN_DOWN = -430,
        VSCOLOR_10_STARTPAGE_BUTTON_PINNED = -429,
        VSCOLOR_10_STARTPAGE_BUTTON_MOUSEOVER_BACKGROUND_MIDDLE2 = -428,
        VSCOLOR_10_STARTPAGE_BUTTON_MOUSEOVER_BACKGROUND_MIDDLE1 = -427,
        VSCOLOR_10_STARTPAGE_BUTTON_MOUSEOVER_BACKGROUND_END = -426,
        VSCOLOR_10_STARTPAGE_BUTTON_MOUSEOVER_BACKGROUND_BEGIN = -425,
        VSCOLOR_10_STARTPAGE_BUTTON_BORDER = -424,
        VSCOLOR_10_STARTPAGE_BACKGROUND_GRADIENTEND = -423,
        VSCOLOR_10_STARTPAGE_BACKGROUND_GRADIENTBEGIN = -422,
        VSCOLOR_10_SEARCHBOX_PRESSED_BORDER = -421,
        VSCOLOR_10_SEARCHBOX_PRESSED_BACKGROUND = -420,
        VSCOLOR_10_SEARCHBOX_MOUSEOVER_BORDER = -419,
        VSCOLOR_10_SEARCHBOX_MOUSEOVER_BACKGROUND_END = -418,
        VSCOLOR_10_SEARCHBOX_MOUSEOVER_BACKGROUND_MIDDLE2 = -417,
        VSCOLOR_10_SEARCHBOX_MOUSEOVER_BACKGROUND_MIDDLE1 = -416,
        VSCOLOR_10_SEARCHBOX_MOUSEOVER_BACKGROUND_BEGIN = -415,
        VSCOLOR_10_SEARCHBOX_BORDER = -414,
        VSCOLOR_10_SEARCHBOX_BACKGROUND = -413,
        VSCOLOR_10_SCROLLBAR_THUMB_PRESSED_BACKGROUND = -412,
        VSCOLOR_10_SCROLLBAR_THUMB_MOUSEOVER_BACKGROUND = -411,
        VSCOLOR_10_SCROLLBAR_THUMB_GLYPH = -410,
        VSCOLOR_10_SCROLLBAR_THUMB_BORDER = -409,
        VSCOLOR_10_SCROLLBAR_THUMB_BACKGROUND = -408,
        VSCOLOR_10_SCROLLBAR_DISABLED_BACKGROUND = -407,
        VSCOLOR_10_SCROLLBAR_BACKGROUND = -406,
        VSCOLOR_10_SCROLLBAR_ARROW_PRESSED_BACKGROUND = -405,
        VSCOLOR_10_SCROLLBAR_ARROW_MOUSEOVER_BACKGROUND = -404,
        VSCOLOR_10_SCROLLBAR_ARROW_DISABLED_BACKGROUND = -403,
        VSCOLOR_10_SCROLLBAR_ARROW_BACKGROUND = -402,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_TEXT = -401,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_SEPARATOR = -400,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_HEADER_PRESSED = -399,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_HEADER_HOVER = -398,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_HEADER = -397,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_CHEVRON = -396,
        VSCOLOR_10_PAGE_SIDEBAREXPANDER_BODY = -395,
        VSCOLOR_10_PAGE_CONTENTEXPANDER_SEPARATOR = -394,
        VSCOLOR_10_PAGE_CONTENTEXPANDER_CHEVRON = -393,
        VSCOLOR_10_NEWPROJECT_ITEM_INACTIVE_BORDER = -392,
        VSCOLOR_10_NEWPROJECT_ITEM_INACTIVE_END = -391,
        VSCOLOR_10_NEWPROJECT_ITEM_INACTIVE_BEGIN = -390,
        VSCOLOR_10_NEWPROJECT_ITEM_SELECTED = -389,
        VSCOLOR_10_NEWPROJECT_ITEM_SELECTED_BORDER = -388,
        VSCOLOR_10_NEWPROJECT_PROVIDER_INACTIVE_END = -387,
        VSCOLOR_10_NEWPROJECT_PROVIDER_INACTIVE_BEGIN = -386,
        VSCOLOR_10_NEWPROJECT_PROVIDER_INACTIVE_FOREGROUND = -385,
        VSCOLOR_10_NEWPROJECT_PROVIDER_HOVER_END = -384,
        VSCOLOR_10_NEWPROJECT_PROVIDER_HOVER_MIDDLE2 = -383,
        VSCOLOR_10_NEWPROJECT_PROVIDER_HOVER_MIDDLE1 = -382,
        VSCOLOR_10_NEWPROJECT_PROVIDER_HOVER_BEGIN = -381,
        VSCOLOR_10_NEWPROJECT_PROVIDER_HOVER_FOREGROUND = -380,
        VSCOLOR_10_NEWPROJECT_BACKGROUND = -379,
        VSCOLOR_10_FILETAB_SELECTED_GRADIENTMIDDLE2 = -378,
        VSCOLOR_10_FILETAB_SELECTED_GRADIENTMIDDLE1 = -377,
        VSCOLOR_10_FILETAB_LASTACTIVE_GLYPH = -376,
        VSCOLOR_10_FILETAB_LASTACTIVE_TEXT = -375,
        VSCOLOR_10_FILETAB_LASTACTIVE_DOCUMENTBORDER_EDGE = -374,
        VSCOLOR_10_FILETAB_LASTACTIVE_DOCUMENTBORDER_BACKGROUND = -373,
        VSCOLOR_10_FILETAB_LASTACTIVE_GRADIENTBOTTOM = -372,
        VSCOLOR_10_FILETAB_LASTACTIVE_GRADIENTMIDDLE2 = -371,
        VSCOLOR_10_FILETAB_LASTACTIVE_GRADIENTMIDDLE1 = -370,
        VSCOLOR_10_FILETAB_LASTACTIVE_GRADIENTTOP = -369,
        VSCOLOR_10_FILETAB_INACTIVE_TEXT = -368,
        VSCOLOR_10_FILETAB_INACTIVE_DOCUMENTBORDER_EDGE = -367,
        VSCOLOR_10_FILETAB_INACTIVE_DOCUMENTBORDER_BACKGROUND = -366,
        VSCOLOR_10_FILETAB_INACTIVE_GRADIENTBOTTOM = -365,
        VSCOLOR_10_FILETAB_INACTIVE_GRADIENTTOP = -364,
        VSCOLOR_10_FILETAB_HOT_GLYPH = -363,
        VSCOLOR_10_FILETAB_HOT_TEXT = -362,
        VSCOLOR_10_FILETAB_HOT_BORDER = -361,
        VSCOLOR_10_EXTENSIONMANAGER_STAR_INACTIVE2 = -360,
        VSCOLOR_10_EXTENSIONMANAGER_STAR_INACTIVE1 = -359,
        VSCOLOR_10_EXTENSIONMANAGER_STAR_HIGHLIGHT2 = -358,
        VSCOLOR_10_EXTENSIONMANAGER_STAR_HIGHLIGHT1 = -357,
        VSCOLOR_10_ENVIRONMENT_BACKGROUND_TEXTURE2 = -356,
        VSCOLOR_10_ENVIRONMENT_BACKGROUND_TEXTURE1 = -355,
        VSCOLOR_10_ENVIRONMENT_BACKGROUND_GRADIENTMIDDLE2 = -354,
        VSCOLOR_10_ENVIRONMENT_BACKGROUND_GRADIENTMIDDLE1 = -353,
        VSCOLOR_10_DROPSHADOW_BACKGROUND = -352,
        VSCOLOR_10_DROPDOWN_POPUP_BORDER = -351,
        VSCOLOR_10_DROPDOWN_POPUP_BACKGROUND_END = -350,
        VSCOLOR_10_DROPDOWN_POPUP_BACKGROUND_BEGIN = -349,
        VSCOLOR_10_DROPDOWN_MOUSEOVER_GLYPH = -348,
        VSCOLOR_10_DROPDOWN_MOUSEOVER_BORDER = -347,
        VSCOLOR_10_DROPDOWN_MOUSEOVER_BACKGROUND_END = -346,
        VSCOLOR_10_DROPDOWN_MOUSEOVER_BACKGROUND_MIDDLE2 = -345,
        VSCOLOR_10_DROPDOWN_MOUSEOVER_BACKGROUND_MIDDLE1 = -344,
        VSCOLOR_10_DROPDOWN_MOUSEOVER_BACKGROUND_BEGIN = -343,
        VSCOLOR_10_DROPDOWN_MOUSEDOWN_BORDER = -342,
        VSCOLOR_10_DROPDOWN_MOUSEDOWN_BACKGROUND = -341,
        VSCOLOR_10_DROPDOWN_GLYPH = -340,
        VSCOLOR_10_DROPDOWN_DISABLED_GLYPH = -339,
        VSCOLOR_10_DROPDOWN_DISABLED_BORDER = -338,
        VSCOLOR_10_DROPDOWN_DISABLED_BACKGROUND = -337,
        VSCOLOR_10_DROPDOWN_BORDER = -336,
        VSCOLOR_10_DROPDOWN_BACKGROUND = -335,
        VSCOLOR_10_DOCKTARGET_GLYPH_BORDER = -334,
        VSCOLOR_10_DOCKTARGET_GLYPH_ARROW = -333,
        VSCOLOR_10_DOCKTARGET_GLYPH_BACKGROUND_END = -332,
        VSCOLOR_10_DOCKTARGET_GLYPH_BACKGROUND_BEGIN = -331,
        VSCOLOR_10_DOCKTARGET_BUTTON_BORDER = -330,
        VSCOLOR_10_DOCKTARGET_BUTTON_BACKGROUND_END = -329,
        VSCOLOR_10_DOCKTARGET_BUTTON_BACKGROUND_BEGIN = -328,
        VSCOLOR_10_DOCKTARGET_BORDER = -327,
        VSCOLOR_10_DOCKTARGET_BACKGROUND = -326,
        VSCOLOR_10_DIAGREPORT_TEXT = -325,
        VSCOLOR_10_DIAGREPORT_SUMMARYPAGE_TITLE = -324,
        VSCOLOR_10_DIAGREPORT_SUMMARYPAGE_SUBTITLE = -323,
        VSCOLOR_10_DIAGREPORT_SUMMARYPAGE_HEADER = -322,
        VSCOLOR_10_DIAGREPORT_SECONDARYPAGE_TITLE = -321,
        VSCOLOR_10_DIAGREPORT_SECONDARYPAGE_SUBTITLE = -320,
        VSCOLOR_10_DIAGREPORT_SECONDARYPAGE_HEADER = -319,
        VSCOLOR_10_DIAGREPORT_BACKGROUND = -318,
        VSCOLOR_10_COMMANDSHELF_HIGHLIGHT_GRADIENTEND = -317,
        VSCOLOR_10_COMMANDSHELF_HIGHLIGHT_GRADIENTMIDDLE = -316,
        VSCOLOR_10_COMMANDSHELF_HIGHLIGHT_GRADIENTBEGIN = -315,
        VSCOLOR_10_COMMANDSHELF_BACKGROUND_GRADIENTEND = -314,
        VSCOLOR_10_COMMANDSHELF_BACKGROUND_GRADIENTMIDDLE = -313,
        VSCOLOR_10_COMMANDSHELF_BACKGROUND_GRADIENTBEGIN = -312,
        VSCOLOR_10_COMMANDBAR_TOOLBAR_SEPARATOR = -311,
        VSCOLOR_10_COMMANDBAR_TOOLBAR_BORDER = -310,
        VSCOLOR_10_COMMANDBAR_SELECTED_BORDER = -309,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEOVER_GLYPH = -308,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEOVER_BACKGROUND_END = -307,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEOVER_BACKGROUND_MIDDLE2 = -306,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEOVER_BACKGROUND_MIDDLE1 = -305,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEOVER_BACKGROUND_BEGIN = -304,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEDOWN_BACKGROUND_END = -303,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEDOWN_BACKGROUND_MIDDLE = -302,
        VSCOLOR_10_COMMANDBAR_OPTIONS_MOUSEDOWN_BACKGROUND_BEGIN = -301,
        VSCOLOR_10_COMMANDBAR_OPTIONS_GLYPH = -300,
        VSCOLOR_10_COMMANDBAR_OPTIONS_BACKGROUND = -299,
        VSCOLOR_10_COMMANDBAR_MOUSEOVER_BACKGROUND_END = -298,
        VSCOLOR_10_COMMANDBAR_MOUSEOVER_BACKGROUND_MIDDLE2 = -297,
        VSCOLOR_10_COMMANDBAR_MOUSEOVER_BACKGROUND_MIDDLE1 = -296,
        VSCOLOR_10_COMMANDBAR_MOUSEOVER_BACKGROUND_BEGIN = -295,
        VSCOLOR_10_COMMANDBAR_MOUSEDOWN_BORDER = -294,
        VSCOLOR_10_COMMANDBAR_MOUSEDOWN_BACKGROUND_END = -293,
        VSCOLOR_10_COMMANDBAR_MOUSEDOWN_BACKGROUND_MIDDLE = -292,
        VSCOLOR_10_COMMANDBAR_MOUSEDOWN_BACKGROUND_BEGIN = -291,
        VSCOLOR_10_COMMANDBAR_MENU_SUBMENU_GLYPH = -290,
        VSCOLOR_10_COMMANDBAR_MENU_SEPARATOR = -289,
        VSCOLOR_10_COMMANDBAR_MENU_MOUSEOVER_SUBMENU_GLYPH = -288,
        VSCOLOR_10_COMMANDBAR_MENU_ICONBACKGROUND = -287,
        VSCOLOR_10_COMMANDBAR_MENU_BORDER = -286,
        VSCOLOR_10_COMMANDBAR_MENU_BACKGROUND_GRADIENTEND = -285,
        VSCOLOR_10_COMMANDBAR_MENU_BACKGROUND_GRADIENTBEGIN = -284,
        VSCOLOR_10_COMMANDBAR_CHECKBOX = -283,
        VSCOLOR_10_COMBOBOX_POPUP_BORDER = -282,
        VSCOLOR_10_COMBOBOX_POPUP_BACKGROUND_END = -281,
        VSCOLOR_10_COMBOBOX_POPUP_BACKGROUND_BEGIN = -280,
        VSCOLOR_10_COMBOBOX_MOUSEOVER_GLYPH = -279,
        VSCOLOR_10_COMBOBOX_MOUSEOVER_BORDER = -278,
        VSCOLOR_10_COMBOBOX_MOUSEOVER_BACKGROUND_END = -277,
        VSCOLOR_10_COMBOBOX_MOUSEOVER_BACKGROUND_MIDDLE2 = -276,
        VSCOLOR_10_COMBOBOX_MOUSEOVER_BACKGROUND_MIDDLE1 = -275,
        VSCOLOR_10_COMBOBOX_MOUSEOVER_BACKGROUND_BEGIN = -274,
        VSCOLOR_10_COMBOBOX_MOUSEDOWN_BORDER = -273,
        VSCOLOR_10_COMBOBOX_MOUSEDOWN_BACKGROUND = -272,
        VSCOLOR_10_COMBOBOX_GLYPH = -271,
        VSCOLOR_10_COMBOBOX_DISABLED_GLYPH = -270,
        VSCOLOR_10_COMBOBOX_DISABLED_BORDER = -269,
        VSCOLOR_10_COMBOBOX_DISABLED_BACKGROUND = -268,
        VSCOLOR_10_COMBOBOX_BORDER = -267,
        VSCOLOR_10_COMBOBOX_BACKGROUND = -266,
        VSCOLOR_10_CLASSDESIGNER_VBMODULEHEADER = -265,
        VSCOLOR_10_CLASSDESIGNER_VBMODULECOMPARTMENT = -264,
        VSCOLOR_10_CLASSDESIGNER_UNRESOLVEDTEXT = -263,
        VSCOLOR_10_CLASSDESIGNER_TYPEDEFHEADER = -262,
        VSCOLOR_10_CLASSDESIGNER_TYPEDEF = -261,
        VSCOLOR_10_CLASSDESIGNER_TEMPCONNECTION = -260,
        VSCOLOR_10_CLASSDESIGNER_SHAPESHADOW = -259,
        VSCOLOR_10_CLASSDESIGNER_SHAPEBORDER = -258,
        VSCOLOR_10_CLASSDESIGNER_RESIZINGSHAPEBORDER = -257,
        VSCOLOR_10_CLASSDESIGNER_REFERENCEDASSEMBLYBORDER = -256,
        VSCOLOR_10_CLASSDESIGNER_PROPERTYASSOCIATION = -255,
        VSCOLOR_10_CLASSDESIGNER_LOLLIPOP = -254,
        VSCOLOR_10_CLASSDESIGNER_LASSO = -253,
        VSCOLOR_10_CLASSDESIGNER_INTERFACECOMPARTMENT = -252,
        VSCOLOR_10_CLASSDESIGNER_INTERFACEHEADER = -251,
        VSCOLOR_10_CLASSDESIGNER_INHERITANCE = -250,
        VSCOLOR_10_CLASSDESIGNER_GRADIENTEND = -249,
        VSCOLOR_10_CLASSDESIGNER_FIELDASSOCIATION = -248,
        VSCOLOR_10_CLASSDESIGNER_ENUMHEADER = -247,
        VSCOLOR_10_CLASSDESIGNER_EMPHASISBORDER = -246,
        VSCOLOR_10_CLASSDESIGNER_DIAGRAMBACKGROUND = -245,
        VSCOLOR_10_CLASSDESIGNER_DELEGATEHEADER = -244,
        VSCOLOR_10_CLASSDESIGNER_DELEGATECOMPARTMENT = -243,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTSHAPETITLE = -242,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTSHAPETEXT = -241,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTSHAPESUBTITLE = -240,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTSHAPEBORDER = -239,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTSHAPEBACKGROUND = -238,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTSHAPETITLEBACKGROUND = -237,
        VSCOLOR_10_CLASSDESIGNER_DEFAULTCONNECTION = -236,
        VSCOLOR_10_CLASSDESIGNER_CONNECTIONROUTEBORDER = -235,
        VSCOLOR_10_CLASSDESIGNER_COMPARTMENTSEPARATOR = -234,
        VSCOLOR_10_CLASSDESIGNER_COMMENTTEXT = -233,
        VSCOLOR_10_CLASSDESIGNER_COMMENTSHAPEBACKGROUND = -232,
        VSCOLOR_10_CLASSDESIGNER_COMMENTBORDER = -231,
        VSCOLOR_10_CLASSDESIGNER_CLASSHEADERBACKGROUND = -230,
        VSCOLOR_10_CLASSDESIGNER_CLASSCOMPARTMENT = -229,
        VSCOLOR_10_AUTOHIDE_RESIZEGRIP = -228,
        VSCOLOR_10_AUTOHIDE_TAB_MOUSEOVER_BORDER = -227,
        VSCOLOR_10_AUTOHIDE_TAB_MOUSEOVER_BACKGROUND_END = -226,
        VSCOLOR_10_AUTOHIDE_TAB_MOUSEOVER_BACKGROUND_BEGIN = -225,
        VSCOLOR_10_AUTOHIDE_TAB_MOUSEOVER_TEXT = -224,
        VSCOLOR_10_AUTOHIDE_TAB_BORDER = -223,
        VSCOLOR_10_AUTOHIDE_TAB_BACKGROUND_END = -222,
        VSCOLOR_10_AUTOHIDE_TAB_BACKGROUND_BEGIN = -221,
        VSCOLOR_10_AUTOHIDE_TAB_TEXT = -220,
        VSCOLOR_10_WINDOWTEXT = -219,
        VSCOLOR_10_WINDOWFRAME = -218,
        VSCOLOR_10_WINDOW = -217,
        VSCOLOR_10_THREEDSHADOW = -216,
        VSCOLOR_10_THREEDLIGHTSHADOW = -215,
        VSCOLOR_10_THREEDHIGHLIGHT = -214,
        VSCOLOR_10_THREEDFACE = -213,
        VSCOLOR_10_THREEDDARKSHADOW = -212,
        VSCOLOR_10_SCROLLBAR = -211,
        VSCOLOR_10_MENUTEXT = -210,
        VSCOLOR_10_MENU = -209,
        VSCOLOR_10_INFOTEXT = -208,
        VSCOLOR_10_INFOBACKGROUND = -207,
        VSCOLOR_10_INACTIVECAPTIONTEXT = -206,
        VSCOLOR_10_INACTIVECAPTION = -205,
        VSCOLOR_10_INACTIVEBORDER = -204,
        VSCOLOR_10_HIGHLIGHTTEXT = -203,
        VSCOLOR_10_HIGHLIGHT = -202,
        VSCOLOR_10_GRAYTEXT = -201,
        VSCOLOR_10_CAPTIONTEXT = -200,
        VSCOLOR_10_BUTTONTEXT = -199,
        VSCOLOR_10_BUTTONSHADOW = -198,
        VSCOLOR_10_BUTTONHIGHLIGHT = -197,
        VSCOLOR_10_BUTTONFACE = -196,
        VSCOLOR_10_BACKGROUND = -195,
        VSCOLOR_10_APPWORKSPACE = -194,
        VSCOLOR_10_ACTIVECAPTION = -193,
        VSCOLOR_10_ACTIVEBORDER = -192,
    }
    public class VsThemeColor : JetBrains.UI.Components.Theming.ThemeColor
    {
        public static readonly JetBrains.VsIntegration.UI.VsThemeColor QuickInfoForeground;
        public VsThemeColor([JetBrains.Annotations.NotNullAttribute()] string name, System.Drawing.Color defaultColor, bool alphaAllowed = False) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.PrimaryThread)]
    public class VsThemedIconSettingsLoader : JetBrains.UI.Icons.Settings.ThemedIconSettingsLoader
    {
        public VsThemedIconSettingsLoader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore store, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironment, JetBrains.UI.Components.Theming.IColorThemeManager thememan) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsThemeManager : JetBrains.UI.Components.Theming.ThemeManager
    {
        public VsThemeManager(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsUIShell2 vsUiShell2, JetBrains.Threading.IThreading threading, JetBrains.DataFlow.IViewable<JetBrains.UI.Components.Theming.IThemeColorFiller> fillers) { }
        protected override JetBrains.UI.Components.Theming.ColorTheme CreateTheme() { }
    }
}
namespace JetBrains.VsIntegration.UndoManager
{
    
    public abstract class DataConstants : JetBrains.Application.DataContext.DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<Microsoft.VisualStudio.OLE.Interop.IOleUndoManager> OleUndoManager;
    }
    public class HandlersUndoRedoUnit : JetBrains.VsIntegration.UndoManager.UndoRedoUnit
    {
        public HandlersUndoRedoUnit(JetBrains.Util.IUndoRedoHandler[] handlers) { }
        protected override string Description { get; }
        protected override void Do() { }
        protected override void Redo() { }
        protected override void Undo() { }
    }
    public abstract class UndoRedoUnit
    {
        protected UndoRedoUnit() { }
        protected abstract string Description { get; }
        protected virtual string UndoDescription { get; }
        public void Do([JetBrains.Annotations.CanBeNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleUndoManager manager) { }
        protected virtual void Do() { }
        protected virtual void DoWithoutUndoManager() { }
        protected abstract void Redo();
        protected abstract void Undo();
    }
    public abstract class UndoUnitBase : Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit
    {
        protected abstract string Description { get; }
        public abstract void Do(Microsoft.VisualStudio.OLE.Interop.IOleUndoManager pUndoManager);
        public void GetDescription(out string pBstr) { }
        public void GetUnitType(out System.Guid pClsid, out int plID) { }
        public void OnNextAdd() { }
    }
    public class static UndoUnitUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit> EnumerateUndoUnits([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.OLE.Interop.IOleUndoManager undoManager) { }
        public static string GetDescription([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit undoUnit) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsOleUndoManagerFactory
    {
        public VsOleUndoManagerFactory(Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2 localRegistry2, JetBrains.VsIntegration.Application.RawVsServiceProvider rawVsServiceProvider) { }
        public Microsoft.VisualStudio.OLE.Interop.IOleUndoManager TryCreateUndoManager() { }
    }
}
namespace JetBrains.VSIntegration.Updates
{
    
    [System.Xml.Serialization.XmlRootAttribute("LocalInfo")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public class UpdateLocalEnvironmentInfoVs : JetBrains.UI.Updates.UpdateLocalEnvironmentInfo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.UI.Updates.UpdatesLocalInfoManager.QueryStringContainerAttribute()]
        [System.Xml.Serialization.XmlElementAttribute()]
        public JetBrains.VSIntegration.Updates.UpdateLocalEnvironmentInfoVs.DotNetInfo DotNet;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.UI.Updates.UpdatesLocalInfoManager.QueryStringContainerAttribute()]
        [System.Xml.Serialization.XmlElementAttribute()]
        public JetBrains.VSIntegration.Updates.UpdateLocalEnvironmentInfoVs.VsInfo VisualStudio;
        public UpdateLocalEnvironmentInfoVs() { }
        public class DotNetInfo
        {
            [JetBrains.UI.Updates.UpdatesLocalInfoManager.QueryStringParamAttribute()]
            [System.Xml.Serialization.XmlElementAttribute()]
            public string Versions;
        }
        public class VsInfo
        {
            [JetBrains.UI.Updates.UpdatesLocalInfoManager.QueryStringParamAttribute()]
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int Edition;
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Hive;
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RootSuffix;
            [JetBrains.UI.Updates.UpdatesLocalInfoManager.QueryStringParamAttribute()]
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int SubEdition;
            [JetBrains.UI.Updates.UpdatesLocalInfoManager.QueryStringContainerAttribute()]
            [System.Xml.Serialization.XmlElementAttribute()]
            public JetBrains.UI.Updates.UpdateLocalEnvironmentInfo.VersionSubInfo Version;
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UpdatesLocalInfoManagerVs : JetBrains.UI.Updates.UpdatesLocalInfoManager
    {
        public UpdatesLocalInfoManagerVs(JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.VsIntegration.Interop.Shim.Shell.IVsShell vsShell, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IApplicationDescriptor product, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.ActivityTrackingNew.PermanentUserId permanentUserId, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.UI.Application.ILicenseCheckerComponent licenseCheckerComponent, JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.Application.PluginSupport.PluginsDirectory pluginDirectory) { }
        protected void CollectCore([JetBrains.Annotations.NotNullAttribute()] JetBrains.VSIntegration.Updates.UpdateLocalEnvironmentInfoVs info) { }
        public override JetBrains.UI.Updates.UpdateLocalEnvironmentInfo CollectLocalEnvironmentInfo() { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.DocumentModel
{
    
    public class FileSystemDocumentOperationsHandlerWhidbey : JetBrains.VsIntegration.Whidbey.DocumentModel.IDocumentOperationsHandlerWhidbey
    {
        public FileSystemDocumentOperationsHandlerWhidbey(JetBrains.Util.FileSystemPath fileSystemPath, JetBrains.ProjectModel.ISolution solution) { }
        public bool ContainsPendingChanges { get; }
        public System.Text.Encoding DetectedEncoding { get; }
        public bool FileDidNotExist { get; }
        public bool IsLoadCompleted { get; }
        public string Moniker { get; }
        public event System.Action PendingChangesExecuted;
        public bool ContainsReadOnlyRegions() { }
        public void Dump(System.IO.TextWriter to) { }
        public void ExecutePendingChanges() { }
        public System.IDisposable ExpectChangeCallbackForOurActivity(System.Nullable<JetBrains.Util.TextRange> oldrange, System.Nullable<JetBrains.Util.TextRange> newrange) { }
        public string GetText(out System.Text.Encoding encoding) { }
        public int GetTextLength() { }
        public void ReplaceText(JetBrains.Util.TextRange range, string newText) { }
        public void SetDocument(JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey value) { }
        public void SynchronizeDocument(bool reconcile) { }
    }
    public interface IDocumentOperationsHandlerWhidbey
    {
        bool ContainsPendingChanges { get; }
        bool IsLoadCompleted { get; }
        string Moniker { get; }
        public event System.Action PendingChangesExecuted;
        bool ContainsReadOnlyRegions();
        void Dump(System.IO.TextWriter to);
        void ExecutePendingChanges();
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable ExpectChangeCallbackForOurActivity(System.Nullable<JetBrains.Util.TextRange> oldrange, System.Nullable<JetBrains.Util.TextRange> newrange);
        string GetText(out System.Text.Encoding encoding);
        int GetTextLength();
        void ReplaceText(JetBrains.Util.TextRange range, string newText);
        void SetDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey value);
        void SynchronizeDocument(bool reconcile = True);
    }
    public class static IVsTextBufferEx
    {
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView[] GetTextViews([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer, JetBrains.Threading.IThreading threading, Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager) { }
        public static bool IsIgnoreBuffer(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer) { }
        public static void SetIgnoreBuffer([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer, bool ignore) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsDocumentManagerWhidbey
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.Util.JetTuple<JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView, JetBrains.VsIntegration.Whidbey.DocumentModel.VsTextBufferData, JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame>, bool>> OnNewTextViewCreateTextControl;
        public VsDocumentManagerWhidbey(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.Application.IShellLocks locks, 
                    JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, 
                    JetBrains.ProjectModel.impl.SpecialFiles.SpecialFilesManager specialFilesManager, 
                    JetBrains.DocumentManagers.DocumentManager documentManager, 
                    JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, 
                    JetBrains.VsIntegration.DocumentModel.Whidbey.MapVsCookieToProjectFile mapVsCookieToProjectFile, 
                    JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, 
                    JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents vsRunningDocumentTableEvents, 
                    JetBrains.VsIntegration.Interop.Events.VsTextManagerEvents vsTextManagerEvents, 
                    JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable rdt, 
                    Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEx vsFileChangeEx, 
                    JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, 
                    JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.DocumentModel.Transactions.DocumentTransactionManager documentTransactionManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey TryGetVsDocumentByVsTextBuffer(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsDocumentOperationsWhidbey : JetBrains.VsIntegration.DocumentModel.VsDocumentOperationsCommon
    {
        public VsDocumentOperationsWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.VsIntegration.DocumentModel.Whidbey.MapVsCookieToProjectFile mapVsCookieToProjectFile, JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentToProjectFileMappingStorage, JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable rdt, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents vsRunningDocumentTableEvents, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        public override void SaveDocument(JetBrains.DocumentModel.IDocument document) { }
        public override void SaveDocumentAfterModification(JetBrains.DocumentModel.IDocument document) { }
        public override void SynchronizeDocumentContentsWithFile(JetBrains.DocumentModel.IDocument document, JetBrains.Util.FileSystemPath documentPath) { }
    }
    public class VsTextBufferData : System.IEquatable<JetBrains.VsIntegration.Whidbey.DocumentModel.VsTextBufferData>
    {
        public readonly JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE DocCookie;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer TextBuffer;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.ProjectModel.VsHierarchyItem VsHierarchyItem;
        public VsTextBufferData([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.VsIntegration.Interop.Declarations.VsShell.VSCOOKIE docCookie) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.VsIntegration.Whidbey.DocumentModel.VsTextBufferData other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.Interop.Shim
{
    
    public class static ConversionWhidbey
    {
        public static JetBrains.DocumentModel.DocumentCoords EndNew(this Microsoft.VisualStudio.TextManager.Interop.TextLineChange tchange) { }
        public static JetBrains.DocumentModel.DocumentCoords EndOld(this Microsoft.VisualStudio.TextManager.Interop.TextLineChange tchange) { }
        public static JetBrains.DocumentModel.DocumentCoords Start(this Microsoft.VisualStudio.TextManager.Interop.TextLineChange tchange) { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.Markup
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsFirstRunClearFontsAndColorsCache : JetBrains.Application.IOneTimeInitializationHandler
    {
        public VsFirstRunClearFontsAndColorsCache(Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager vsFontAndColorCacheManager) { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.TextControl
{
    
    public class VsTextControlOleCommandTarget : Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<System.ComponentModel.CancelEventArgs> BeforeDelegateToTypingHandlers;
        public readonly JetBrains.DataFlow.IProperty<bool> IsDelegatingBackToVs;
        public bool CanDelegateToVs() { }
        public void DelegateToVs() { }
    }
}
namespace JetBrains.VsIntegration.WindowManagement.Install
{
    
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageEmitToolWindowIcons : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitBitmapResources, JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitPackageServices, JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitSourceFiles
    {
        public VsPackageEmitToolWindowIcons(JetBrains.Application.Parts.IPartsCatalogue catalog, JetBrains.VsIntegration.Install.VsPackageAssembly.ProductIconClassesIndex iconindex, JetBrains.VsIntegration.Install.VsPackageAssembly.BitmapResourceAllocator bitmaps) { }
        public System.Collections.Generic.IEnumerable<System.CodeDom.CodeTypeDeclaration> CommitToSourceFiles() { }
    }
    [JetBrains.Application.Install.TypeAttributeInstallerAttribute(typeof(JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public sealed class VsToolWindowInstaller : JetBrains.Application.Install.ITypeAttributeInstaller
    {
        public const string DEFAULT_CAPTION_ATTR = "DefaultCaption";
        public const string PRODUCT_NEUTRAL_ID_ATTR = "ToolWindowProductNeutralId";
        public const string PRODUCTNAME_ATTR = "ProductName";
        public const string TOOLBAR_ACTION_GROUP_ID_ATTR = "ToolbarActionGroupId";
        public const string WINDOW_PANE_TYPE_ATTR = "WindowPaneType";
        public static string GetToolWindowRegistryKey(string vsRoot, System.Guid toolWindowGuid) { }
        public JetBrains.Application.Install.InstallationData.InstallationData InstallInstance(JetBrains.Application.Install.Installer installer, System.Type attributeOwner, object attributeInstance) { }
    }
}
namespace JetBrains.VsIntegration.WindowManagement
{
    
    [System.Runtime.InteropServices.GuidAttribute("38E86818-A4FA-443C-9BC1-2B0B27B09985")]
    public interface IVsToolWindowIconResourceIds
    {
        System.Nullable<int> TryGetIconResourceId([JetBrains.Annotations.NotNullAttribute()] string sProductNeutralToolWindowId);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsFrameFocusHelper : JetBrains.UI.WindowManagement.IFrameFocusHelper
    {
        public VsFrameFocusHelper(JetBrains.VsIntegration.Interop.Shim.Shell.IVsMonitorSelection vsMonitorSelection, JetBrains.CommonControls.FocusManager focusManager) { }
        public void KeepCurrentFrame(System.Action nested) { }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.VsIntegration.WindowManagement.VSKeyboardBindingScopeAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class VSKeyboardBindingScope : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.VsIntegration.WindowManagement.VSKeyboardBindingScopeAttribute> { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class VSKeyboardBindingScopeAttribute : System.Attribute
    {
        public bool AllowNavKeyBinding { get; set; }
        public string KeyboardBindingScopeGuid { get; set; }
        public string PackageGuid { get; set; }
        public string ResourceID { get; set; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsWindowFrameManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame> VsWindowFrameKey;
        public VsWindowFrameManager(JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.WindowManagement.WindowFrame CreateFromVsWindowFrame(JetBrains.DataFlow.Lifetime lifetimeOuter, JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame vsWindowFrame) { }
        public static JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame TryGetSelfOrParentVsWindowFrame([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame) { }
    }
}