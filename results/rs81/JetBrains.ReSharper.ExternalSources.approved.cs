[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.ExternalSources.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "DecompiledSources",
        "SourcesFromSymbolFiles",
        "ExternalSources",
        "MetadataView"}, IconPackResourceIdentification="JetBrains.ReSharper.ExternalSources;component/resources/ExternalSourcesIcons/Them" +
    "edIcons.ExternalSources.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-external-sources", "JetBrains.ReSharper.ExternalSources.Resources")]

namespace JetBrains.ReSharper.ExternalSources.MetadataViewer
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DecompiledSourceLegalNotice
    {
        public DecompiledSourceLegalNotice(JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.UI.Application.OpensUri opensUri, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public bool CheckAndAskUser() { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class DecompiledSourceLegalNoticeSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    public class static DecompiledSourcesConstants
    {
        public const string Id = "decompiler";
        public const string PresentableShortName = "Decompiler";
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DecompiledSourcesExternalSourcesProvider : JetBrains.ReSharper.ExternalSources.MetadataViewer.DecompilerBasedExternalSourcesProvider
    {
        public DecompiledSourcesExternalSourcesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.ExternalSources.MetadataViewer.DecompiledSourceLegalNotice legalNotice) { }
        public override string Id { get; }
        public override string PresentableShortName { get; }
        public override int Priority { get; }
        protected override bool CheckOptions(JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions translatorOptions) { }
        protected override JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> GetLanguage() { }
        public override JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions GetTranslatorOptions() { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo) { }
        public static bool IsDecompilerAvailable() { }
    }
    public class static DecompilerBasedConstants
    {
        public const string CodeMinorVersionKey = "CodeVersion";
        public const string DecompilerMethodBodies = "DecompilerMethodBodies";
        public const string FullTypeNameKey = "TypeName";
        public const int MinorVersion = 3;
        public const string PsiLanguageTypeKey = "Language";
        public const string ShowCompilerGeneratedCodeKey = "ShowCompilerGeneratedCode";
        public const string ShowNonVisibleMembersKey = "ShowNonVisibleMembers";
        public const string ShowXmlDocKey = "ShowXmlDoc";
        public const string TypeCacheMonikerPrefix = "t.";
    }
    public abstract class DecompilerBasedExternalSourcesProvider : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider
    {
        protected readonly JetBrains.Application.Settings.IContextBoundSettingsStore myContextBoundSettings;
        protected DecompilerBasedExternalSourcesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public abstract string Id { get; }
        public abstract string PresentableShortName { get; }
        public abstract int Priority { get; }
        protected abstract bool CheckOptions(JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions translatorOptions);
        public System.Collections.Generic.IDictionary<string, string> GetFlags(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        protected abstract JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> GetLanguage();
        public virtual JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions GetTranslatorOptions() { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping MapFileToAssembly(JetBrains.Util.FileSystemPath file) { }
        public JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> NavigateToSources(JetBrains.ReSharper.Psi.ICompiledElement compiledElement, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem PresentType(JetBrains.Application.Progress.IProgressIndicator indicator, JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.PsiLanguageType targetLanguage, string fileName, JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions translatorOptions, System.Collections.Generic.IDictionary<string, string> currentFlags) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesSettings), "Decompiler options")]
    public class DecompilerSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Decompile method bodies")]
        public bool DecompileMethodBodies;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Decompiler legal notice is accepted by user")]
        public bool DecompilerLegalNoticeAccepted;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Reorder members according to current options")]
        public bool ReorderMembers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Show code generated by compiler")]
        public bool ShowCompilerGeneratedCode;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show XML-doc in decompiled code")]
        public bool ShowXmlDoc;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class DecompilerSettingsConverter : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DecompilerSettingsDumper : JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public DecompilerSettingsDumper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public void Dump(System.IO.TextWriter sw) { }
    }
    public class static MetadataViewerConstants
    {
        public const string Id = "metadata";
        public const string PresentableShortName = "Metadata viewer";
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MetadataViewerExternalSourcesProvider : JetBrains.ReSharper.ExternalSources.MetadataViewer.DecompilerBasedExternalSourcesProvider
    {
        public MetadataViewerExternalSourcesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public override string Id { get; }
        public override string PresentableShortName { get; }
        public override int Priority { get; }
        protected override bool CheckOptions(JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions translatorOptions) { }
        protected override JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> GetLanguage() { }
        public override JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions GetTranslatorOptions() { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class MetadataViewerTextControlsUpdater : JetBrains.Application.IChangeProvider
    {
        public MetadataViewerTextControlsUpdater(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks threading, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.ExternalSources.MetadataViewer.DecompilerBasedExternalSourcesProvider> externalSourcesProviders, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesMappingChangeManager mappingChangeManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.ReSharper.Psi.ILanguages languages) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class NavigateToDecompiledSourcesActionHandler : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.ExternalSources.MetadataViewer.NavigateToDecompiledSourcesProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class NavigateToDecompiledSourcesProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesContextNavigationProviderBase<JetBrains.ReSharper.ExternalSources.MetadataViewer.NavigateToDecompiledSourcesSolutionProvider>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NavigateToDecompiledSourcesSolutionProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesSolutionContextNavigationProviderBase
    {
        public NavigateToDecompiledSourcesSolutionProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesPointsProvider externalSourcesPointsProvider, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.ExternalSources.MetadataViewer.DecompiledSourcesExternalSourcesProvider externalSourcesProvider, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ContextNavigationGroup { get; }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider ExternalSourcesProvider { get; }
        public override string Title { get; }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class NavigateToMetadataViewActionHandler : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.ExternalSources.MetadataViewer.NavigateToMetadataViewProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class NavigateToMetadataViewProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesContextNavigationProviderBase<JetBrains.ReSharper.ExternalSources.MetadataViewer.NavigateToMetadataViewSolutionProvider> { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NavigateToMetadataViewSolutionProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesSolutionContextNavigationProviderBase
    {
        public NavigateToMetadataViewSolutionProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesPointsProvider externalSourcesPointsProvider, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.ExternalSources.MetadataViewer.MetadataViewerExternalSourcesProvider externalSourcesProvider, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ContextNavigationGroup { get; }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider ExternalSourcesProvider { get; }
        public override string Title { get; }
    }
}
namespace JetBrains.ReSharper.ExternalSources.Pdb.FolderSubstitutions
{
    
    public class FolderSubstitutionEditorDialog : System.Windows.Forms.Form
    {
        public FolderSubstitutionEditorDialog(JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution initial) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution FolderSubstitution { get; }
        protected override void Dispose(bool disposing) { }
    }
    public class FolderSubstitutionsEditor : JetBrains.UI.CommonControls.SafePanel
    {
        public FolderSubstitutionsEditor(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution> initialSubstitutions, JetBrains.UI.Application.IUIApplication uiapp) { }
        public JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution> FolderSubstitutions { get; }
    }
}
namespace JetBrains.ReSharper.ExternalSources.Pdb
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class NavigateToPdbActionHandler : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.ExternalSources.Pdb.NavigateToPdbProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class NavigateToPdbProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesContextNavigationProviderBase<JetBrains.ReSharper.ExternalSources.Pdb.NavigateToPdbSolutionProvider> { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NavigateToPdbSolutionProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesSolutionContextNavigationProviderBase
    {
        public NavigateToPdbSolutionProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesPointsProvider externalSourcesPointsProvider, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.ExternalSources.Pdb.PdbExternalSourcesProvider pdbExternalSourcesProvider, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ContextNavigationGroup { get; }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider ExternalSourcesProvider { get; }
        public override string Title { get; }
        protected override void SetSpecificOptions(JetBrains.DataFlow.Lifetime navigationLifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class PdbCmdExecutionConfirmationImpl : JetBrains.Symbols.DefaultPdbCmdExecutionConfirmation
    {
        public PdbCmdExecutionConfirmationImpl(JetBrains.Threading.IThreading mainThread) { }
        public override bool RequestCommandExecutionConfirmation(string command, string args) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PdbExternalSourcesProvider : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider
    {
        public PdbExternalSourcesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.IPdbService pdbService, JetBrains.Threading.IThreading threading, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager pdbCacheManager, JetBrains.Symbols.IPdbSpecificLogger pdbSpecificLogger, JetBrains.Symbols.Providers.ISymbolsProvidersManager symbolsProvidersManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public string Id { get; }
        public string PresentableShortName { get; }
        public int Priority { get; }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping MapFileToAssembly(JetBrains.Util.FileSystemPath file) { }
        public JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> NavigateToSources(JetBrains.ReSharper.Psi.ICompiledElement compiledElement, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
    }
}
namespace JetBrains.ReSharper.ExternalSources.ReSharperIntegration
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AssemblyInfoDecompilationHelper
    {
        public AssemblyInfoDecompilationHelper(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache, JetBrains.ReSharper.ExternalSources.MetadataViewer.MetadataViewerExternalSourcesProvider metadataViewerExternalSourcesProvider) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem GetCacheItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem GetCacheItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule assemblyPsiModule) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class AssemblyInfoNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Navigation.AssemblyInfoNavigationData>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IAssemblyInfoNavigationProvider
    {
        public AssemblyInfoNavigationProvider(JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator fileSystemPathNavigator, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService externalFiles, JetBrains.ReSharper.ExternalSources.MetadataViewer.MetadataViewerExternalSourcesProvider metadataViewerExternalSourcesProvider, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.AssemblyInfoDecompilationHelper assemblyInfoDecompilationHelper) { }
        public double Priority { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Navigation.AssemblyInfoNavigationData navigationInfo) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.AssemblyInfoNavigationData data) { }
    }
    public class CompiledXamlResourceNavigationInfo
    {
        public CompiledXamlResourceNavigationInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlExternalResource resource) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlExternalResource Resource { get; }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class CompiledXamlResourceNavigator : JetBrains.ReSharper.Features.Finding.GoToDeclaration.DeclaredElementNavigation.DefaultDeclaredElementNavigator
    {
        public CompiledXamlResourceNavigator([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer shellFeaturePartsContainer) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class DecompiledFileNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Occurences.DecompiledFileNavigationData>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IDecompiledFileNavigationProvider
    {
        public DecompiledFileNavigationProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator fileSystemPathNavigator, JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.IDE.EditorManager editorManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Occurences.DecompiledFileNavigationData decompiledFileNavigationData) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Occurences.DecompiledFileNavigationData data) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class DefaultBamlNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.ExternalSources.ReSharperIntegration.CompiledXamlResourceNavigationInfo>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Psi.ICompiledElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IDefaultCompiledElementNavigationProvider
    {
        public DefaultBamlNavigationProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Caches.IXamlAssemblyResourcesCache assemblyResourcesCache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolveManager resolveManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache decompilationCache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator fileSystemPathNavigator) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo target) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.CompiledXamlResourceNavigationInfo target) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Psi.ICompiledElement target) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.ICompiledElement data) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo data) { }
        public bool IsApplicable(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.CompiledXamlResourceNavigationInfo data) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class DefaultCompiledElementNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Psi.ICompiledElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IDefaultCompiledElementNavigationProvider
    {
        public DefaultCompiledElementNavigationProvider(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService service, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesFirstTimeNavigation firstTimeNavigation, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator fileSystemPathNavigator, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesPsiSourceFiles externalSourceFilesService, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesPointsProvider externalSourcesPointsProvider) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Psi.ICompiledElement target) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Psi.ICompiledElement target) { }
    }
    public class ExternalSourceFile
    {
        public ExternalSourceFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.Util.FileSystemPath location, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider provider, string assemblyName) { }
        public string AssemblyName { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider Provider { get; }
        public JetBrains.ReSharper.Psi.Tree.IFile PsiFile { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ExternalSourceInformationActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=5)]
    public class ExternalSourceOccurenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult findResult) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExternalSourcesFirstTimeNavigation
    {
        public ExternalSourcesFirstTimeNavigation(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public virtual bool Execute() { }
    }
    public class ExternalSourcesInformationDialog : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow
    {
        public ExternalSourcesInformationDialog(JetBrains.Util.FileSystemPath location, string fullAssemblyName, string externalSourcesProvider, JetBrains.UI.Application.IUIApplication environment, JetBrains.Util.FileSystemPath[] assemblyLocations, [JetBrains.Annotations.CanBeNullAttribute()] System.Windows.Forms.IWin32Window mainwin) { }
    }
    public class ExternalSourcesOptionsPageControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public ExternalSourcesOptionsPageControl(System.Action showAdvancedOptions, System.Action showSupportInformation, bool showDecompileCheckbox) { }
        public bool AllowDownload { get; set; }
        public bool Decompile { get; set; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesNavigationMode NavigationMode { get; set; }
        public bool ReorderTypeMembers { get; set; }
        public bool ShowXmlDoc { get; set; }
        public bool UseDebugInformation { get; set; }
        public void InitializeComponent() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesPointsProvider
    {
        public ExternalSourcesPointsProvider(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService service, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesFirstTimeNavigation firstTimeNavigation, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator fileSystemPathNavigator, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService externalSourceFilesService, JetBrains.ProjectModel.Assemblies.Impl.AssemblyFactory assemblyFactory, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCollection assemblyCollection) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint[] CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint[] CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo, JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider> providers) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule GetPsiAssemblyHonorSurfaceAssemblies([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourceFile[] ParseFiles(JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> files, JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule assemblyPsiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext, JetBrains.Application.Progress.IProgressIndicator indicator) { }
    }
    [JetBrains.ProjectModel.ProjectModelElementPresenterAttribute(100D)]
    public class ExternalSourcesProjectFilePresenter : JetBrains.ProjectModel.IProjectModelElementPresenter
    {
        public JetBrains.UI.Icons.IconId GetIcon(JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
        public string GetPresentableLocation(JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class PreciseExternalSourcesNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo>
    {
        public PreciseExternalSourcesNavigationProvider(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService service, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesFirstTimeNavigation firstTimeNavigation, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator fileSystemPathNavigator, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesPsiSourceFiles externalSourceFilesService, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesPointsProvider externalSourcesPointsProvider) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo target) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo target) { }
    }
    public class SpecificExternalSourcesContextNavigationProviderBase<TSolutionContextNavigationProvider> : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
        where TSolutionContextNavigationProvider : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.SpecificExternalSourcesSolutionContextNavigationProviderBase
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public abstract class SpecificExternalSourcesSolutionContextNavigationProviderBase
    {
        protected SpecificExternalSourcesSolutionContextNavigationProviderBase(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesPointsProvider externalSourcesPointsProvider, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public abstract string ActionId { get; }
        public abstract JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ContextNavigationGroup { get; }
        protected abstract JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider ExternalSourcesProvider { get; }
        public abstract string Title { get; }
        public virtual bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public void Navigate(JetBrains.Application.DataContext.IDataContext context) { }
        protected virtual void SetSpecificOptions(JetBrains.DataFlow.Lifetime navigationLifetime) { }
    }
}
namespace JetBrains.ReSharper.ExternalSources.Resources
{
    
    public sealed class ExternalSourcesThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.ExternalSources;component/resources/ExternalSourcesIcons/Them" +
            "edIcons.ExternalSources.Generated.Xaml", 0, "DecompiledSources")]
        public sealed class DecompiledSources : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.ExternalSources;component/resources/ExternalSourcesIcons/Them" +
            "edIcons.ExternalSources.Generated.Xaml", 2, "ExternalSources")]
        public sealed class ExternalSources : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.ExternalSources;component/resources/ExternalSourcesIcons/Them" +
            "edIcons.ExternalSources.Generated.Xaml", 3, "MetadataView")]
        public sealed class MetadataView : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.ExternalSources;component/resources/ExternalSourcesIcons/Them" +
            "edIcons.ExternalSources.Generated.Xaml", 1, "SourcesFromSymbolFiles")]
        public sealed class SourcesFromSymbolFiles : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.ExternalSources.Utils
{
    
    public class ButtonsPanel : JetBrains.UI.CommonControls.SafeTableLayoutPanel
    {
        public ButtonsPanel(JetBrains.ReSharper.ExternalSources.Utils.ButtonsPanel.Buttons buttonsFlag, JetBrains.ReSharper.ExternalSources.Utils.ButtonsPanel.ButtonsPosition buttonsPosition, JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.Button CancelButton { get; }
        public System.Windows.Forms.Button OkButton { get; }
        public void InitControls() { }
        [System.FlagsAttribute()]
        public enum Buttons
        {
            OK = 0,
            CANCEL = 1,
        }
        public enum ButtonsPosition
        {
            LEFT = 0,
            CENTER = 1,
            RIGHT = 2,
        }
    }
    public class static RetargetingUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IDeclaredElement RetargetDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule targetModule) { }
    }
}