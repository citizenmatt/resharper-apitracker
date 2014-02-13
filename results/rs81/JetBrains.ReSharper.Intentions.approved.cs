[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("CaretDependentBulb", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.Intentions.Bulbs.BulbMenuOnGutterMark), Layer=2001)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon
{
    
    public interface IQuickFixes
    {
        bool CouldHavePopupQuickFix(JetBrains.ReSharper.Daemon.IHighlighting highlighting);
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> CreateAllQuickFixes(JetBrains.ReSharper.Daemon.IHighlighting highlighting);
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> CreateAvailableQuickFixes(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Util.IUserDataHolder cache);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateCustomWarningActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange highlightingRange);
        System.Type[] GetHighlightingTypesForQuickFix(System.Type quickFixType);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Intentions.Extensibility.IQuickFix InstantiateQuickfix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IHighlighting highlighting, [JetBrains.Annotations.NotNullAttribute()] System.Type quickFixType, int quickFixIndex);
        void RegisterQuickFix(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Type highlightingType, [JetBrains.Annotations.NotNullAttribute()] System.Type quickFixType, System.Type anchorQuickfixType, JetBrains.Util.BeforeOrAfter before);
        void RegisterQuickFix<THighlighting>(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<THighlighting, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> creator, [JetBrains.Annotations.NotNullAttribute()] System.Type quickFixType, System.Type anchorQuickfixType, JetBrains.Util.BeforeOrAfter before)
            where THighlighting : JetBrains.ReSharper.Daemon.IHighlighting;
    }
    public struct QuickFixInfo
    {
        public readonly System.Type AnchorQuickfixType;
        public readonly JetBrains.Util.BeforeOrAfter Before;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> Creator;
        public readonly bool IsPopupFix;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Type QuickFixType;
        public QuickFixInfo([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> creator, [JetBrains.Annotations.NotNullAttribute()] System.Type quickFixType, System.Type anchorQuickfixType, JetBrains.Util.BeforeOrAfter before, bool isPopupFix) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ActivityTracking
{
    
    public class static ActivityTrackingExtensions
    {
        public static void TrackBulbAction([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.Extensibility.IBulbAction action) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Bulbs
{
    
    [System.ObsoleteAttribute("Use QuickFixBase, ContextActionBase or BulbActionBase. Retained for simplier migr" +
        "ation from ReSharper 6 to ReSharper 7. To be removed in next major version.")]
    public abstract class BulbItemImpl : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Feature.Services.Bulbs.IBulbItem, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Intentions.Extensibility.IContextAction))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class ContextActionAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public string Group { get; set; }
        public string MergeKey { get; set; }
        public string Name { get; set; }
        public short Priority { get; set; }
    }
    public abstract class ContextActionTable
    {
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionInfo> AllActions { get; }
        public abstract bool GetEnabled(JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> disableActions, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionInfo caInfo);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract TAction InstantiateAction<TAction>(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl)
            where TAction :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction;
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IContextAction> InstantiateAvailableActions(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fDataContext, System.Collections.Generic.IDictionary<System.Type, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider> cache, JetBrains.Util.IUserDataHolder dataHolder);
    }
    [System.ObsoleteAttribute("Use IBulbAction. Retained for simplier migration from ReSharper 6 to ReSharper 7." +
        " To be removed in next major version.")]
    public interface IBulbItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction { }
    public interface IContextActionInfo
    {
        JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute Attribute { get; }
        string Description { get; }
        string Group { get; }
        string MergeKey { get; }
        string Name { get; }
        System.Type ParameterType { get; }
        System.Type Type { get; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Intentions.Extensibility.IQuickFix))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class QuickFixAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public QuickFixAttribute([JetBrains.Annotations.CanBeNullAttribute()] System.Type anchorQuickfixType, JetBrains.Util.BeforeOrAfter before) { }
        public QuickFixAttribute() { }
        public System.Type AnchorQuickfixType { get; }
        public JetBrains.Util.BeforeOrAfter Before { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Util
{
    
    public interface IContextActionLanguageSpecific
    {
        bool IsApplicable(JetBrains.ProjectModel.ProjectFileType projectFileType);
        bool IsAvailable(JetBrains.ReSharper.Intentions.Extensibility.IContextAction contextAction);
    }
}
namespace JetBrains.ReSharper.Intentions.Bulbs
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class AltEnterActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public const string ActionName = "AltEnter";
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AltEnterHandlers
    {
        public AltEnterHandlers(JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Intentions.Bulbs.IAltEnterHandler> handlers, JetBrains.DataFlow.Lifetime lifetime) { }
        public void HandleAction(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public struct BulbContext
    {
        public BulbContext(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, int documentOffset) { }
        public int DocumentOffset { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class BulbIndicatorController : JetBrains.ReSharper.Intentions.Bulbs.IndicatorControllerBase
    {
        public BulbIndicatorController(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.GutterMargin.IGutterMargin gutterMargin, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.ReSharper.Intentions.Bulbs.BulbItems bulbItems, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Theming.ITheming theming, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hooks, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool CheckEnabled(JetBrains.TextControl.ITextControl textControl) { }
        protected override bool ExecuteIndicator(JetBrains.TextControl.ITextControl textControl) { }
        protected override System.Action ShowIndicator(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class BulbItems
    {
        public static readonly JetBrains.Util.Key<System.Collections.Generic.JetHashSet<string>> StopListKey;
        public BulbItems(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Intentions.Bulbs.IBulbItemsProvider> bulbActionProviders) { }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Intentions.Bulbs.BulbItemsState> BulbItemsState { get; }
        protected virtual bool CheckViewContains(JetBrains.Util.TextRange viewport, int caretOffset) { }
        protected virtual JetBrains.TextControl.ITextControl CurrentTextControl() { }
        protected virtual void RegisterContextConsumer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, System.Action<JetBrains.DataFlow.Lifetime> onContextChanged) { }
        public void UpdateManual() { }
        public sealed class BulbCache
        {
            public BulbCache() { }
            public int CaretOffset { get; set; }
            public System.Collections.Generic.IDictionary<System.Type, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider> ContextActionCache { get; set; }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Util.UserDataHolder DataHolder { get; }
            public JetBrains.DocumentModel.IDocument Document { get; set; }
            public bool ShowAnalysisOptionsInActionList { get; set; }
            public bool ShowPopup { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public System.Collections.Generic.JetHashSet<string> StopList { get; set; }
        }
        public sealed class BulbItemsKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithoutValueBase
        {
            public static readonly JetBrains.ReSharper.Intentions.Bulbs.BulbItems.BulbItemsKey Instance;
        }
    }
    public class BulbItemsState
    {
        public BulbItemsState([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems intentionsBulbItems, JetBrains.ReSharper.Intentions.Bulbs.BulbItemsStates bulbItemsStates, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Intentions.Bulbs.BulbItemsStates BulbItemsStates { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems IntentionsBulbItems { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.TextControl.ITextControl TextControl { get; }
    }
    public enum BulbItemsStates
    {
        Invalidated = 0,
        Ready = 1,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ContextActionsProvider : JetBrains.ReSharper.Intentions.Bulbs.IBulbItemsProvider
    {
        public ContextActionsProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable) { }
        public int Priority { get; }
        public void CollectActions(JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems intentionsBulbItems, JetBrains.ReSharper.Intentions.Bulbs.BulbItems.BulbCache cacheData, JetBrains.TextControl.ITextControl textControl, JetBrains.DataFlow.Lifetime caretPositionLifetime, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, object precalculatedData) { }
        public object PreExecute(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GoodDaemonStateContextProvider
    {
        public GoodDaemonStateContextProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Daemon.Daemon daemon) { }
    }
    public sealed class GoodDaemonStateKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithoutValueBase
    {
        public static readonly JetBrains.ReSharper.Intentions.Bulbs.GoodDaemonStateKey Instance;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GutterMarkActionsProvider : JetBrains.ReSharper.Intentions.Bulbs.IBulbItemsProvider
    {
        public GutterMarkActionsProvider(JetBrains.ReSharper.Daemon.Daemon daemon, JetBrains.TextControl.GutterMargin.IGutterMargin gutterMargin) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.CaretDependentFeatures.IContextKey> ContextKeys { get; }
        public int Priority { get; }
        public void CollectActions(JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems intentionsBulbItems, JetBrains.ReSharper.Intentions.Bulbs.BulbItems.BulbCache cacheData, JetBrains.TextControl.ITextControl textControl, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, object precalculatedData) { }
        public object PreExecute(JetBrains.TextControl.ITextControl textControl) { }
    }
    public interface IAltEnterHandler
    {
        double Priority { get; }
        bool HandleAction(JetBrains.Application.DataContext.IDataContext context);
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext context);
    }
    public interface IBulbItemsProvider
    {
        int Priority { get; }
        void CollectActions(JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems intentionsBulbItems, JetBrains.ReSharper.Intentions.Bulbs.BulbItems.BulbCache cacheData, JetBrains.TextControl.ITextControl textControl, JetBrains.DataFlow.Lifetime caretPositionLifetime, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, object precalculatedData);
        object PreExecute(JetBrains.TextControl.ITextControl textControl);
    }
    public abstract class IndicatorControllerBase : JetBrains.ReSharper.Intentions.Bulbs.IAltEnterHandler
    {
        protected JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems myIntentionsBulbItems;
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected bool myShowRequested;
        protected IndicatorControllerBase(JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Intentions.Bulbs.BulbItems bulbItems, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DataFlow.Lifetime lifetime) { }
        public double Priority { get; }
        protected abstract bool CheckEnabled(JetBrains.TextControl.ITextControl textControl);
        protected abstract bool ExecuteIndicator(JetBrains.TextControl.ITextControl textControl);
        public bool HandleAction(JetBrains.Application.DataContext.IDataContext context) { }
        protected virtual bool HasItemsToIndicate() { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected abstract System.Action ShowIndicator(JetBrains.TextControl.ITextControl textControl);
    }
    public sealed class IntentionsBulbItems
    {
        public int PsiTimeStamp;
        public IntentionsBulbItems() { }
        public System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> AllBulbMenuItems { get; }
        public System.Collections.Generic.IList<JetBrains.UI.BulbMenu.BulbMenuItem> ItemsToRepost { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Intentions.Bulbs.PopupActionAndTextRange> PopupActions { get; }
        public void AddItems(System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> item) { }
        public void AddItemsNoRepost(System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> item) { }
    }
    public class PopupActionAndTextRange
    {
        public PopupActionAndTextRange(JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction popupAction, JetBrains.Util.TextRange range) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction PopupAction { get; }
        public JetBrains.Util.TextRange Range { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class PopupIndicatorController : JetBrains.ReSharper.Intentions.Bulbs.IAltEnterHandler
    {
        public PopupIndicatorController(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking, JetBrains.ReSharper.Intentions.Bulbs.BulbItems bulbItems, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Theming.ITheming theming, JetBrains.DataFlow.Lifetime lifetime) { }
        public double Priority { get; }
        public bool HandleAction(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class QuickFixesProvider : JetBrains.ReSharper.Intentions.Bulbs.IBulbItemsProvider
    {
        public QuickFixesProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.ReSharper.Daemon.IQuickFixes quickFixes, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Daemon.Daemon daemon) { }
        public int Priority { get; }
        protected virtual bool CheckViewportContains(JetBrains.Util.TextRange viewport, JetBrains.Util.TextRange range) { }
        public void CollectActions(JetBrains.ReSharper.Intentions.Bulbs.IntentionsBulbItems intentionsBulbItems, JetBrains.ReSharper.Intentions.Bulbs.BulbItems.BulbCache cacheData, JetBrains.TextControl.ITextControl textControl, JetBrains.DataFlow.Lifetime caretPositionLifetime, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, object precalculatedData) { }
        public JetBrains.UI.BulbMenu.BulbMenuItem FixToBulbMenuItem(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Intentions.Extensibility.IntentionAction intentionAction, JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.IDocument document) { }
        protected virtual bool IsRangeInTextView([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.Coords.TextControlPosRange txtrange) { }
        public object PreExecute(JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Bulk
{
    
    public abstract class BulkCodeCleanupActionBuilderBase : JetBrains.ReSharper.Intentions.Bulk.IBulkIntentionsBuilder<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction>
    {
        public BulkCodeCleanupActionBuilderBase(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFile = null, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction CreateForCaretPosition() { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction CreateForProject(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction CreateForProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction CreateForProjectFolder(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction CreateForSolution(JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile CreateProfile([JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile> fillProfile) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToIntentionActions(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbAction, JetBrains.UI.BulbMenu.IAnchor anchor);
    }
    public class static BulkItentionsBuilderEx
    {
        public static System.Predicate<JetBrains.ProjectModel.IProjectFile> CreateAcceptFilePredicateByProjectFileType<TLanguage>()
            where TLanguage : JetBrains.ProjectModel.ProjectFileType { }
        public static System.Predicate<JetBrains.ProjectModel.IProjectFile> CreateAcceptFilePredicateByPsiLanaguage<TLanguage>(JetBrains.ProjectModel.ISolution solution)
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulkActions<TAction>(this JetBrains.ReSharper.Intentions.Bulk.IBulkIntentionsBuilder<TAction> builder, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.UI.BulbMenu.IAnchor ownerAnchor, JetBrains.UI.BulbMenu.IAnchorPosition anchorPosition)
            where TAction :  class { }
    }
    public interface IBulkIntentionsBuilder<TAction>
        where TAction :  class
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        TAction CreateForCaretPosition();
        [JetBrains.Annotations.CanBeNullAttribute()]
        TAction CreateForProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        [JetBrains.Annotations.CanBeNullAttribute()]
        TAction CreateForProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        TAction CreateForProjectFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder);
        [JetBrains.Annotations.CanBeNullAttribute()]
        TAction CreateForSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToIntentionActions([JetBrains.Annotations.NotNullAttribute()] TAction bulbAction, JetBrains.UI.BulbMenu.IAnchor anchor);
    }
}
namespace JetBrains.ReSharper.Intentions.ContextActions.Bulk
{
    
    public class BulkCodeCleanupContextActionBuilder : JetBrains.ReSharper.Intentions.Bulk.BulkCodeCleanupActionBuilderBase
    {
        public BulkCodeCleanupContextActionBuilder(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFile = null, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null) { }
        public static JetBrains.ReSharper.Intentions.ContextActions.Bulk.BulkCodeCleanupContextActionBuilder CreateByProjectFileType<TProjectFileType>(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null)
            where TProjectFileType : JetBrains.ProjectModel.ProjectFileType { }
        public static JetBrains.ReSharper.Intentions.ContextActions.Bulk.BulkCodeCleanupContextActionBuilder CreateByPsiLanguage<TPsiLanguage>(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null)
            where TPsiLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToIntentionActions(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbAction, JetBrains.UI.BulbMenu.IAnchor anchor) { }
    }
}
namespace JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString
{
    
    public abstract class ClrAddFormatItemAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrUseFormatStringActionBase
    {
        protected ClrAddFormatItemAction(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override bool IsAvailableInternal() { }
    }
    public abstract class ClrRemoveFormatItemAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected ClrRemoveFormatItemAction(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ClrSurroundWithFormatAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ClrSurroundWithFormatAction(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ClrUseFormatStringAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrUseFormatStringActionBase
    {
        protected ClrUseFormatStringAction(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override bool IsAvailableInternal() { }
    }
    public abstract class ClrUseFormatStringActionBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected JetBrains.ReSharper.Psi.Util.IStringConcatenationClrWrapper myStringConcatenationClrWrapper;
        protected ClrUseFormatStringActionBase(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider) { }
        protected JetBrains.ReSharper.Psi.Tree.IExpression SelectedConcatenationArgumentExpression { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected void InjectArgument(JetBrains.ReSharper.Psi.Tree.IExpression argumentToInject) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailableInternal();
        protected static bool IsInjectableExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        protected void SurroundWithFormattingMethodIfNeeded() { }
    }
}
namespace JetBrains.ReSharper.Intentions.ContextActions
{
    
    public class static CommonContextActions
    {
        public const string GroupID = "Common";
    }
    public class ContextActionAsActionHandler<TAction> : JetBrains.ActionManagement.IActionHandler
        where TAction :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class CustomizeStatementContextAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public CustomizeStatementContextAction(JetBrains.ReSharper.Feature.Services.Bulbs.LanguageIndependentContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class InitializeActionBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected InitializeActionBase(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected abstract JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase CreateInitializeFix(JetBrains.ReSharper.Psi.IParameter parameter);
        protected abstract JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase CreateIntroduceFix(JetBrains.ReSharper.Psi.IParameter parameter);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class InitializeAutoPropertyActionBase : JetBrains.ReSharper.Intentions.ContextActions.InitializeActionBase
    {
        protected InitializeAutoPropertyActionBase(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase CreateInitializeFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase CreateIntroduceFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class InitializeFieldActionBase : JetBrains.ReSharper.Intentions.ContextActions.InitializeActionBase
    {
        protected InitializeFieldActionBase(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase CreateInitializeFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase CreateIntroduceFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public sealed class RunPathMappingEditorBulbItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public RunPathMappingEditorBulbItem(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath path) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public abstract class SurroundWithQuotesActionBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public const string Description = "Creates string literal of selection text.";
        public const string Name = "Surround with \"\"";
        public const int Priority = -20;
        protected SurroundWithQuotesActionBase(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract string MakeStringLiteral(string text);
        [JetBrains.Annotations.NotNullAttribute()]
        protected static string MakeStringLiteralBase([JetBrains.Annotations.CanBeNullAttribute()] string text) { }
    }
    public abstract class UseStringEmptyActionBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public const string Description = "Use System.String.Empty instead of \"\" literal.";
        protected readonly JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider myProvider;
        public const string Name = "Use System.String.Empty";
        protected UseStringEmptyActionBase(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider provider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression();
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsConstantExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        protected abstract void OptimizeRefs(JetBrains.DocumentModel.IRangeMarker marker, JetBrains.ReSharper.Psi.Tree.IFile file);
    }
}
namespace JetBrains.ReSharper.Intentions
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class ContextActionTableSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader { }
    [System.ObsoleteAttribute("Use BulbActionBase")]
    public abstract class QuickFixBase_Obsolete : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected const string ERROR = "<ERROR>";
        protected abstract bool IsValid { get; }
        protected virtual JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public abstract string Text { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
        protected static void FailedToModifyDocument(JetBrains.TextControl.ITextControl textControl) { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailableEx();
        protected static void ShowTooltip(JetBrains.TextControl.ITextControl textControl, string queueName, string message) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class QuickFixTable : JetBrains.ReSharper.Daemon.IQuickFixes
    {
        public QuickFixTable(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogSet, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.Application.Settings.ISettingsStore settings) { }
        public bool CouldHavePopupQuickFix(JetBrains.ReSharper.Daemon.IHighlighting highlighting) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> CreateAllQuickFixes(JetBrains.ReSharper.Daemon.IHighlighting highlighting) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> CreateAvailableQuickFixes(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Util.IUserDataHolder cache) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateCustomWarningActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange highlightingRange) { }
        public System.Type[] GetHighlightingTypesForQuickFix(System.Type quickFixType) { }
        public string GetWarningTitle(JetBrains.ReSharper.Daemon.IHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IQuickFix InstantiateQuickfix(JetBrains.ReSharper.Daemon.IHighlighting highlighting, System.Type quickFixType, int quickFixIndex) { }
        public void RegisterQuickFix(JetBrains.DataFlow.Lifetime lifetime, System.Type highlightingType, System.Type quickFixType, System.Type anchorQuickfixType, JetBrains.Util.BeforeOrAfter before) { }
        public void RegisterQuickFix<THighlighting>(JetBrains.DataFlow.Lifetime lifetime, System.Func<THighlighting, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix> creator, System.Type quickFixType, System.Type anchorQuickfixType, JetBrains.Util.BeforeOrAfter before)
            where THighlighting : JetBrains.ReSharper.Daemon.IHighlighting { }
    }
}
namespace JetBrains.ReSharper.Intentions.CreateFromUsage
{
    
    public class AlwaysConsintentGroup : JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup
    {
        public static readonly JetBrains.ReSharper.Intentions.CreateFromUsage.AlwaysConsintentGroup Instance;
        public bool IsConsistent() { }
    }
    public class ConsistencyGroupByNaming : JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup
    {
        public ConsistencyGroupByNaming(JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule, bool isConsistent) { }
        public bool Equals(JetBrains.ReSharper.Intentions.CreateFromUsage.ConsistencyGroupByNaming other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsConsistent() { }
    }
    public class CreateConstructorItem : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageItemBase<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext>, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Util.IPartBulbItem
    {
        public CreateConstructorItem(JetBrains.Util.Lazy.Lazy<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext> context, string text) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention() { }
    }
    public abstract class CreateFromUsageActionBase<TReference>
        where TReference : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected CreateFromUsageActionBase(TReference reference) { }
        protected JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected TReference Reference { get; }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateBulbActions();
        protected abstract JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget();
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected bool IsAvailableForContainer(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected bool IsAvailableForContainer(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected bool IsAvailableForTarget(JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
    }
    public abstract class CreateFromUsageActionBase2<TContext, TReference> : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Util.IPartBulbItem
        where TContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
        where TReference : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected readonly JetBrains.Util.Lazy.Lazy<TContext> myContext;
        protected CreateFromUsageActionBase2(TReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected TReference Reference { get; }
        protected abstract TContext CreateContext();
        public virtual void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected abstract JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(TContext context);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public abstract JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup();
        protected abstract JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget();
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected bool IsAvailableForContainer(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected bool IsAvailableForContainer(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected bool IsAvailableForTarget(JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
        protected virtual bool IsAvailableInternal() { }
        public void SetWorkingPart(JetBrains.ReSharper.Psi.Tree.IDeclaration partDeclaration) { }
        protected virtual void UpdateContextAndExecute(TContext context, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class CreateFromUsageFixBase : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected System.Collections.Generic.List<JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction> UnfilteredItems;
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CreateFromUsageItemBase<TContext> : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
        where TContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        protected CreateFromUsageItemBase(JetBrains.Util.Lazy.Lazy<TContext> context) { }
        protected override void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected abstract JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention();
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected TContext GetContext() { }
        public void SetWorkingPart(JetBrains.ReSharper.Psi.Tree.IDeclaration partDeclaration) { }
    }
    public class CreateMethodItem : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageItemBase<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext>, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Util.IPartBulbItem
    {
        public CreateMethodItem(JetBrains.Util.Lazy.Lazy<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext> context, string formatText) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention() { }
    }
    public class CreatePropertyItem : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageItemBase<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext>, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Util.IPartBulbItem
    {
        public CreatePropertyItem(JetBrains.Util.Lazy.Lazy<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext> context, string format) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention() { }
    }
    public interface ICreatedElementConsistencyGroup
    {
        bool IsConsistent();
    }
    public interface ICreateFromUsageAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem();
        JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup();
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TargetPartSelector : JetBrains.ReSharper.Intentions.Util.BeforeExecutionOptionSelector<JetBrains.ReSharper.Psi.Tree.IDeclaration>
    {
        public TargetPartSelector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus) { }
        protected override string JpmTitle { get; }
        public void SelectOptionByJpm(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> options, System.Action<JetBrains.ReSharper.Psi.Tree.IDeclaration> onOptionSelected) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions
{
    
    public abstract class ClrUseFormatStringForSingleArgumentAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrUseFormatStringActionBase
    {
        protected ClrUseFormatStringForSingleArgumentAction(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override bool IsAvailableInternal() { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.QuickFixes
{
    
    public abstract class RenameRefactoringFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RenameRefactoringItem, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected RenameRefactoringFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RenameRefactoringItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected readonly JetBrains.ReSharper.Psi.IDeclaredElement myElement;
        protected RenameRefactoringItem(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual string Text { get; }
        public virtual void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable() { }
    }
}
namespace JetBrains.ReSharper.Intentions.Explanatory
{
    
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class CodeInspectionWikiProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public CodeInspectionWikiProvider(JetBrains.ReSharper.Feature.Services.Explanatory.ICodeInspectionWikiDataProvider dataProvider, JetBrains.UI.Application.UIApplication uiApplication) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Extensibility
{
    
    public abstract class BulbActionBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public abstract string Text { get; }
        public virtual void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected virtual System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected virtual void ExecuteBeforeProgressAndTransaction(JetBrains.ProjectModel.ISolution solution) { }
        protected virtual void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress);
        protected static void FailedToModifyDocument(JetBrains.TextControl.ITextControl textControl) { }
        protected static void ShowTooltip(JetBrains.TextControl.ITextControl textControl, string queueName, string message) { }
        protected static void ShowTransactionFailedException(JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class ContextActionBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public abstract bool IsAvailable(JetBrains.Util.IUserDataHolder cache);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class CustomHighlightingActionProviderAttribute : JetBrains.ProjectModel.ProjectFileTypeAttribute
    {
        public CustomHighlightingActionProviderAttribute(System.Type type) { }
    }
    public interface IBulbAction
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Text { get; }
        void Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
    }
    public interface IContextAction
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems();
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder cache);
    }
    public interface ICustomHighlightingActionProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle);
    }
    public class IntentionAction
    {
        public IntentionAction(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbAction, JetBrains.UI.RichText.RichText richText, JetBrains.UI.Icons.IconId iconId, JetBrains.UI.BulbMenu.IAnchor anchor) { }
        public JetBrains.UI.BulbMenu.IAnchor Anchor { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction BulbAction { get; }
        public JetBrains.UI.Icons.IconId IconId { get; }
        public JetBrains.UI.RichText.RichText RichText { get; }
        public JetBrains.UI.BulbMenu.BulbMenuItem ToBulbMenuItem(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public class MyExecutableProxi : JetBrains.UI.BulbMenu.IExecutableItem
        {
            public MyExecutableProxi(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbAction, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
            public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction BulbAction { get; }
            public void Execute() { }
        }
    }
    public interface IPopupBulbAction
    {
        JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        string PopupKey { get; }
        string PopupMenuCaption { get; }
        void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor);
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder cache);
        void OnPopupShown(JetBrains.DataFlow.Lifetime showingLifetime);
    }
    public interface IQuickFix
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems();
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder cache);
    }
    public abstract class QuickFixBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public abstract bool IsAvailable(JetBrains.Util.IUserDataHolder cache);
    }
}
namespace JetBrains.ReSharper.Intentions.Extensibility.Menu
{
    
    public class static BulbActionExtensions
    {
        public static JetBrains.ReSharper.Intentions.Extensibility.IntentionAction ToAnnotateAction(this JetBrains.ReSharper.Intentions.Extensibility.IBulbAction action) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToContextAction(this JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbItem, JetBrains.UI.BulbMenu.IAnchor customAnchor = null) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToContextAction<T>(this System.Collections.Generic.IEnumerable<T> bulbActions)
            where T : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToGenerateAction(this JetBrains.ReSharper.Intentions.Extensibility.IBulbAction action) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToQuickFixAction(this JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbItem, JetBrains.UI.BulbMenu.IAnchor customAnchor = null) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToQuickFixAction<T>(this System.Collections.Generic.IEnumerable<T> bulbActions, JetBrains.UI.BulbMenu.IAnchor customAnchor = null)
            where T : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToRefactoringAction(this JetBrains.ReSharper.Intentions.Extensibility.IBulbAction action) { }
    }
    public class static ConfigureHighlightingAnchors
    {
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition ChangeConfigurableSeverity;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition CodeInspectionWiki;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition ConfigureItem;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition DisableByComment;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition DisableByPragma;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition EditCustomPattern;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition FindSimilarIssues;
        public static JetBrains.UI.BulbMenu.IAnchor GetConfigureAnchor(JetBrains.UI.BulbMenu.IAnchorPosition subPosition, JetBrains.ReSharper.Daemon.IHighlighting highlighting) { }
    }
    public class static IntentionsAnchors
    {
        public static readonly JetBrains.UI.BulbMenu.IAnchor AnnotateActionsAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition AnnotateAnchorPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor ConfigureActionsAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition ConfigureAnchorPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor ContextActionsAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition ContextActionsAnchorPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor QuickFixesAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition QuickFixesAnchorPosition;
    }
}
namespace JetBrains.ReSharper.Intentions.Implementor
{
    
    public abstract class ImplementMemberBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract string GetGeneratorKind();
        protected abstract JetBrains.ReSharper.Psi.IOverridableMember GetMemberToImplement();
        protected abstract System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> GetTargetTypes(JetBrains.Application.Progress.IProgressIndicator progress);
        public abstract bool IsAvailable(JetBrains.Util.IUserDataHolder cache);
        protected virtual void PostExecute() { }
        protected abstract string SelectPartText();
        protected virtual void SetBody(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration member) { }
    }
    public class MemberImplementorItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public MemberImplementorItem(string generatorKind, string text, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> targetDeclarations, JetBrains.ReSharper.Psi.ITypeMember memberToImplement, System.Action<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> bodySetter, System.Action postExecute) { }
        public override string Text { get; }
        protected override void ExecuteBeforeProgressAndTransaction(JetBrains.ProjectModel.ISolution solution) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class MemberImplementorPreparer
    {
        public static void ImplementMember(JetBrains.ReSharper.Psi.ITypeMember memberToImplement, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeElement> targetTypes, string selectPartText, string generatorKind, JetBrains.TextControl.ITextControl textControl, System.Action<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> bodySetter, System.Action postExecute) { }
    }
    public class static OverridableMembersFinder
    {
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> FindOverridableNotHiddenMembersInInheritors(JetBrains.ReSharper.Psi.ITypeElement baseType, JetBrains.ReSharper.Psi.IOverridableMember memberToOverride, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class PopupListProvider
    {
        public static JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle FirstPresenter { get; }
        public static JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle SecondPresenter { get; }
        public static int Compare(JetBrains.ReSharper.Psi.ITypeElement x, JetBrains.ReSharper.Psi.ITypeElement y) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Legacy
{
    
    [System.ObsoleteAttribute("Use BulbActionBase")]
    public abstract class ContextActionBase_Obsolete : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected bool CheckDocumentRange;
        protected readonly JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider myProvider;
        protected ContextActionBase_Obsolete(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider provider) { }
        protected virtual bool CheckSelectedElementOnExecute { get; }
        public abstract JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, string caption, params object[] param) { }
        protected abstract void ExecuteInternal(params object[] param);
        protected virtual object[] ExecuteInternalEx(params object[] param) { }
        protected virtual object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected static void FailedToModifyDocument(JetBrains.TextControl.ITextControl textControl) { }
        protected TElement FindRangeContainingElement<TElement>()
            where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailableInternal();
        protected static void ShowTooltip(JetBrains.TextControl.ITextControl textControl, string queueName, string message) { }
        protected static void ShowTransactionFailedException(JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Options
{
    
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class ChangeConfigurableSeverityWarningProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public ChangeConfigurableSeverityWarningProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.UI.Icons.IThemedIconManager commonIconsComponent) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CommonContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__Common__Context_Actions", ParentId="CodeEditing", Sequence=4.5D)]
    public class CommonContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "CommonContextActions";
        public CommonContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Context action page UI settings")]
    public class ContextActionPagesSettings
    {
        public const int SplitterDistanceDefaultPosition = 150;
        public const string SplitterDistanceSettingNameSuffix = "SplitterDistance";
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Splitter position per page")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, int> SplitterPosition;
        public static string GetSplitterPosition(System.Type t) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class ContextActionPagesSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public ContextActionPagesSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public abstract class ContextActionsPageBase : System.Windows.Forms.SplitContainer, JetBrains.UI.Options.IOptionsPage
    {
        protected ContextActionsPageBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, string actionsGroupName, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public abstract string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
        protected override void WndProc(ref System.Windows.Forms.Message msg) { }
    }
}
namespace JetBrains.ReSharper.Intentions.QuickFixes
{
    
    public abstract class AddAccessorFixBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected JetBrains.ReSharper.Intentions.QuickFixes.AddAccessorFixBase.AccessorPrefix myAccessorPrefix;
        protected AddAccessorFixBase(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Intentions.QuickFixes.AddAccessorFixBase.AccessorPrefix accessorPrefix) { }
        protected AddAccessorFixBase(JetBrains.ReSharper.Psi.IProperty property) { }
        protected abstract JetBrains.ReSharper.Psi.AccessorKind AccessorKind { get; }
        protected abstract string AccessorName { get; }
        protected JetBrains.ReSharper.Psi.IProperty AccessorOwner { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected enum AccessorPrefix
        {
            NONE = 0,
            BASE = 1,
            INTERFACE = 2,
        }
    }
    public abstract class AddParameterFixBase : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected readonly JetBrains.ReSharper.Psi.Resolve.IReference Reference;
        protected AddParameterFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.IExpression ArgumentExpression(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo);
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected abstract JetBrains.ReSharper.Psi.IParameter FindMatchingParameter(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.IParametersOwner target);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.IInvocationInfo GetInvocation();
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract JetBrains.ReSharper.Psi.IInvocationInfo MakeArgumentsOwnerCopy(JetBrains.ReSharper.Psi.IInvocationInfo argumentsOwner);
        protected abstract JetBrains.ReSharper.Psi.ParameterKind ParameterKindFromArgument(JetBrains.ReSharper.Psi.IArgumentInfo argument);
        protected virtual bool ParametersOwnerIsSuitableToAddParameter(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.IInvocationInfo argumentsOwner) { }
        protected abstract bool RemoveArgument(JetBrains.ReSharper.Psi.IInvocationInfo argumentsOwnerCopy, JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo);
    }
    public class ChangeSignatureFixBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChangeSignatureFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner target, JetBrains.ReSharper.Psi.IParametersOwner source, string extraDescription = "") { }
        public ChangeSignatureFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner target, JetBrains.ReSharper.Psi.IParametersOwner source, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, string extraDescription = "") { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeTypeFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.UI.BulbMenu.IBulbItemRichText
    {
        public JetBrains.UI.RichText.RichText RichText { get; }
        public override string Text { get; }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] CreateItems(JetBrains.ReSharper.Psi.IClrDeclaredElement lvalue, JetBrains.ReSharper.Psi.IType lvalueType, JetBrains.ReSharper.Psi.IClrDeclaredElement rvalue, JetBrains.ReSharper.Psi.IType rvalueType, JetBrains.ReSharper.Psi.PsiLanguageType executionContextLanguage) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] CreateItems(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.IClrDeclaredElement>> source, JetBrains.ReSharper.Psi.PsiLanguageType executionContextLanguage) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CheckNamespaceQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CheckNamespaceQuickFix(JetBrains.ReSharper.Daemon.Specific.CheckNamespace.CheckNamespaceHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ClrAddEmptyArgFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ClrAddEmptyArgFix(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringInexistingArgumentWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ClrEscapeUnmatchedBraceFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ClrEscapeUnmatchedBraceFix(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringUnescapedRBraceWarning warning) { }
        public ClrEscapeUnmatchedBraceFix(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringUnescapedLBraceWarning warning) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ClrRemoveRedundantArgFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ClrRemoveRedundantArgFix(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringArgumentIsNotUsedWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class ColorPickerQuickFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ColorPickerQuickFix(JetBrains.ReSharper.Feature.Services.VisualElements.ColorHighlighting highliting) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CreateDefaultConstructorFixBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase<JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected CreateDefaultConstructorFixBase(JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        protected abstract JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        protected abstract JetBrains.ReSharper.Psi.IClass BaseClass { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateBulbActions() { }
        protected virtual JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext GetContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EncapsulateFieldRefactoringFix : JetBrains.ReSharper.Intentions.QuickFixes.EncapsulateFieldRefactoringItem, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public EncapsulateFieldRefactoringFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EncapsulateFieldRefactoringItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected EncapsulateFieldRefactoringItem(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual string Text { get; }
        public virtual void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected bool IsAvailable() { }
    }
    public interface IImportTypeUtilComponent
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> Alternatives(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>>> getTypesCacheFunc);
        JetBrains.ReSharper.Psi.IReferencePointer CreateReferencePointer(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        bool ReferenceTargetCanBeType(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public class ImportOneOfGenericTypesItem : JetBrains.ReSharper.Intentions.QuickFixes.ImportTypeItemBase
    {
        public ImportOneOfGenericTypesItem(string format, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement[] genericTypeElements) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override bool IsValid { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class ImportTypeFix : JetBrains.ReSharper.Intentions.QuickFixes.ImportTypeQuickFixBase
    {
        public ImportTypeFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual string Format { get; }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> FilterConflicts(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> result, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetTypesCache(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ImportTypeItem : JetBrains.ReSharper.Intentions.QuickFixes.ImportTypeItemBase
    {
        public ImportTypeItem(string format, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override bool IsValid { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public abstract class ImportTypeItemBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public abstract JetBrains.UI.Icons.IconId Icon { get; }
        public abstract bool IsValid { get; }
    }
    public abstract class ImportTypeQuickFixBase : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected ImportTypeQuickFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public abstract JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> Alternatives() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected virtual System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> FilterConflicts(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> result, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetTypesCache(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImportTypeQuickPopupFix : JetBrains.ReSharper.Intentions.QuickFixes.ImportTypeFix, JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction
    {
        public ImportTypeQuickPopupFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string Format { get; }
        public JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        public string PopupKey { get; }
        public string PopupMenuCaption { get; }
        public void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
        public void OnPopupShown(JetBrains.DataFlow.Lifetime showingLifetime) { }
    }
    public class static ImportTypeUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> Alternatives(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>>> getTypesCacheFunc) { }
        public static JetBrains.ReSharper.Psi.IReferencePointer CreateReferencePointer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> IgnoreResolveResultCandidates(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> result, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool ReferenceTargetCanBeType(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool TargetTypeIsVisible(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int typeArgumentsCount) { }
    }
    public abstract class IncreaseVisibilityFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected readonly JetBrains.ReSharper.Psi.Resolve.IReference myTypeUsageReference;
        protected IncreaseVisibilityFixBase(JetBrains.ReSharper.Psi.ITypeMember accessibleElement, JetBrains.ReSharper.Psi.Resolve.IReference typeUsageReference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public interface IQuickFixUtilComponent
    {
        JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement, out System.Action<> moveCaretToTypeArgumentsAction, bool targetHasGenericOverloads);
    }
    public interface IVisibilityFixLanguageHelper
    {
        bool CanFixAccessibility(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public class MakeAbstractFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeAbstractFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public MakeAbstractFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassNeverInstantiatedWarningBase error) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeInternalFix : JetBrains.ReSharper.Intentions.QuickFixes.VisibilityFixBase
    {
        protected bool mySkipCheck;
        public MakeInternalFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBeInternalWarning error) { }
        public MakeInternalFix(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration ownerDeclaration, bool updateHierarchy = False, bool skipCheck = False) { }
        public MakeInternalFix(JetBrains.ReSharper.Psi.IModifiersOwner modifiersOwner, bool updateHierarchy) { }
        protected MakeInternalFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public MakeInternalFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool IsAvailableEx() { }
    }
    public class MakeNonReadonlyFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeNonReadonlyFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeNonStaticFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeNonStaticFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakePrivateFix : JetBrains.ReSharper.Intentions.QuickFixes.VisibilityFixBase
    {
        public MakePrivateFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBePrivateWarningBase error) { }
        public MakePrivateFix(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration ownerDeclaration, bool updateHierarchy) { }
        public MakePrivateFix(JetBrains.ReSharper.Psi.IModifiersOwner modifiersOwner, bool updateHierarchy) { }
        public MakePrivateFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public MakePrivateFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class MakeProtectedFix : JetBrains.ReSharper.Intentions.QuickFixes.VisibilityFixBase
    {
        protected bool mySkipCheck;
        public MakeProtectedFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBeProtectedWarningBase error) { }
        public MakeProtectedFix(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration ownerDeclaration, bool updateHierarchy) { }
        public MakeProtectedFix(JetBrains.ReSharper.Psi.IModifiersOwner modifiersOwner, bool updateHierarchy) { }
        public MakeProtectedFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public MakeProtectedFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool IsAvailableEx() { }
    }
    public class MakeProtectedInternalFix : JetBrains.ReSharper.Intentions.QuickFixes.VisibilityFixBase
    {
        public MakeProtectedInternalFix(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration ownerDeclaration, bool updateHierarchy) { }
        public MakeProtectedInternalFix(JetBrains.ReSharper.Psi.IModifiersOwner modifiersOwner, bool updateHierarchy) { }
        public MakeProtectedInternalFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public MakeProtectedInternalFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool IsAvailableEx() { }
    }
    public class MakePublicFix : JetBrains.ReSharper.Intentions.QuickFixes.VisibilityFixBase
    {
        public MakePublicFix(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration ownerDeclaration, bool updateHierarchy = False) { }
        public MakePublicFix(JetBrains.ReSharper.Psi.IModifiersOwner modifiersOwner, bool updateHierarchy = False) { }
        public MakePublicFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public MakePublicFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class MakeStaticFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeStaticFix(JetBrains.ReSharper.Psi.IDeclaredElement typeMember) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public abstract class ModifierFixBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected ModifierFixBase(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
        protected JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected JetBrains.ReSharper.Psi.IModifiersOwner ModifiersOwner { get; }
        protected abstract string ModifiersText { get; }
        public override string Text { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected static string Negate(string modifier) { }
        protected abstract void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class MoveToFolderQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MoveToFolderQuickFix(JetBrains.ReSharper.Daemon.Specific.CheckNamespace.CheckNamespaceHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MoveTypeToOuterScopeRefactoringFix : JetBrains.ReSharper.Intentions.QuickFixes.MoveTypeToOuterScopeRefactoringItem, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MoveTypeToOuterScopeRefactoringFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MoveTypeToOuterScopeRefactoringItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected MoveTypeToOuterScopeRefactoringItem(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual string Text { get; }
        public virtual void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected bool IsAvailable() { }
    }
    public class QuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public QuickFix(JetBrains.Util.Lazy.Lazy<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[]> items) { }
        public QuickFix(System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction>> items) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static QuickFixUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement, out System.Action<> moveCaretToTypeArgumentsAction, bool targetHasGenericOverloads = False) { }
    }
    public class ReferenceModuleAndTypeFix : JetBrains.ReSharper.Intentions.QuickFixes.ImportTypeQuickFixBase
    {
        public ReferenceModuleAndTypeFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetTypesCache(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public sealed class ReferenceModuleAndTypeFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public override string Text { get; }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ReferenceModuleAndTypeFixItem Create(JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement element, bool showModuleDetails) { }
        protected override void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static string PresentedItemText(bool showModuleDetails, JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public abstract class ReferenceModuleFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected readonly JetBrains.ReSharper.Psi.Tree.ITreeNode myElement;
        protected ReferenceModuleFixBase(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected JetBrains.Util.FileSystemPath FindAssemblyByName(string name) { }
        protected JetBrains.ProjectModel.IModule FindModuleByShortName(JetBrains.ProjectModel.ISolution solution, string name) { }
        protected abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Intentions.QuickFixes.ReferenceModuleFixBase.IRefenceAction> FindModulesToReference(JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService);
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected class AssemblyReferenceAction : JetBrains.ReSharper.Intentions.QuickFixes.ReferenceModuleFixBase.IRefenceAction
        {
            public AssemblyReferenceAction(JetBrains.Util.FileSystemPath path) { }
            public string Name { get; }
            public bool CanReferenceFrom(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
            public void Do(JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.ProjectModel.IProject sourceProject, JetBrains.ReSharper.Psi.Modules.IPsiModule sourcePsiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        }
        protected interface IRefenceAction
        {
            string Name { get; }
            bool CanReferenceFrom(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
            void Do(JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.ProjectModel.IProject sourceProject, JetBrains.ReSharper.Psi.Modules.IPsiModule sourcePsiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
        }
        protected class ModuleReferenceAction : JetBrains.ReSharper.Intentions.QuickFixes.ReferenceModuleFixBase.IRefenceAction
        {
            public ModuleReferenceAction(JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService, JetBrains.ProjectModel.IModule module) { }
            public string Name { get; }
            public bool CanReferenceFrom(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
            public void Do(JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.ProjectModel.IProject sourceProject, JetBrains.ReSharper.Psi.Modules.IPsiModule sourcePsiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        }
    }
    public class static ResolveProblemsFixAnchors
    {
        public static readonly JetBrains.UI.BulbMenu.IAnchor AddParameterFix;
        public static readonly JetBrains.UI.BulbMenu.IAnchor AddReferenceFix;
        public static readonly JetBrains.UI.BulbMenu.IAnchor ChangeAllFixAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchor ChangeModifiersFix;
        public static readonly JetBrains.UI.BulbMenu.IAnchor ChangeTypeFix;
        public static readonly JetBrains.UI.BulbMenu.IAnchor CreateFromUsageAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchor CustomConvertTransformationFix;
        public static readonly JetBrains.UI.BulbMenu.IAnchor ImportFix;
    }
    public abstract class VisibilityFixBase : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        protected VisibilityFixBase(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration ownerDeclaration, JetBrains.ReSharper.Psi.AccessRights accessRights, bool updateHierarchy) { }
        protected VisibilityFixBase(JetBrains.ReSharper.Psi.IModifiersOwner modifiersOwner, JetBrains.ReSharper.Psi.AccessRights accessRights, bool updateHierarchy) { }
        protected VisibilityFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeMember typeMember, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        protected VisibilityFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        protected JetBrains.ReSharper.Psi.IModifiersOwner ModifiersOwner { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IAccessor GetAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        protected virtual bool IsAvailableEx() { }
    }
    public class VisibilityFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public VisibilityFixItem(JetBrains.ReSharper.Psi.IModifiersOwner owner, JetBrains.ReSharper.Psi.AccessRights accessRights, bool updateHierarchy, JetBrains.ReSharper.Psi.PsiLanguageType languageForPresentation) { }
        public override string Text { get; }
        protected override void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
}
namespace JetBrains.ReSharper.Intentions.QuickFixes.Bulk
{
    
    public class BulkCodeCleanupQuickFix : JetBrains.ReSharper.Intentions.QuickFixes.Bulk.BulkQuickFixNoPsiTransaction
    {
        public BulkCodeCleanupQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public BulkCodeCleanupQuickFix([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
    }
    public class BulkCodeCleanupQuickFixBuilder : JetBrains.ReSharper.Intentions.Bulk.BulkCodeCleanupActionBuilderBase
    {
        public BulkCodeCleanupQuickFixBuilder(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFile = null, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.Bulk.BulkCodeCleanupQuickFixBuilder CreateByProjectFileType<TProjectFileType>(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null)
            where TProjectFileType : JetBrains.ProjectModel.ProjectFileType { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.Bulk.BulkCodeCleanupQuickFixBuilder CreateByPsiLanguage<TPsiLanguage>(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile cleanupProfile, string text, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction fixForCaretPosition = null)
            where TPsiLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToIntentionActions(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction bulbAction, JetBrains.UI.BulbMenu.IAnchor anchor) { }
    }
    public abstract class BulkQuickFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public BulkQuickFixBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public BulkQuickFixBase([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        protected System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> FilesToProcess { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected class FilesCollector : JetBrains.ProjectModel.RecursiveProjectVisitor
        {
            public FilesCollector(JetBrains.Application.Progress.IProgressIndicator progressIndicator, System.Predicate<JetBrains.ProjectModel.IProjectFile> predicate = null) { }
            public override bool ProcessingIsFinished { get; }
            public System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> ProjectFiles { get; }
            public override void VisitProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        }
    }
    public class BulkQuickFixNoPsiTransaction : JetBrains.ReSharper.Intentions.QuickFixes.Bulk.BulkQuickFixBase
    {
        public BulkQuickFixNoPsiTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiSourceFileAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public BulkQuickFixNoPsiTransaction([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiSourceFileAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class BulkQuickFixWithCommonPsiTransaction : JetBrains.ReSharper.Intentions.QuickFixes.Bulk.BulkQuickFixBase
    {
        public BulkQuickFixWithCommonPsiTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.DocumentModel.IDocument, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiTransactionAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public BulkQuickFixWithCommonPsiTransaction([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.DocumentModel.IDocument, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiTransactionAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class BulkQuickFixWithCommonTransactionBuilder : JetBrains.ReSharper.Intentions.Bulk.IBulkIntentionsBuilder<JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase>
    {
        public BulkQuickFixWithCommonTransactionBuilder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase fixForCaretPosition, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase fixForProjectFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.DocumentModel.IDocument, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiTransactionAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public BulkQuickFixWithCommonTransactionBuilder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase fixForProjectFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.DocumentModel.IDocument, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiTransactionAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public BulkQuickFixWithCommonTransactionBuilder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionText, System.Action<JetBrains.DocumentModel.IDocument, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Application.Progress.IProgressIndicator> psiTransactionAction, System.Predicate<JetBrains.ProjectModel.IProjectFile> acceptProjectFilePredicate = null) { }
        public JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase CreateForCaretPosition() { }
        public JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase CreateForProject(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase CreateForProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase CreateForProjectFolder(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase CreateForSolution(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> ToIntentionActions(JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase bulbAction, JetBrains.UI.BulbMenu.IAnchor anchor) { }
    }
    public abstract class HighlightingCleanupItemQuickFixBase<TPsiLanguage> : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase, JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem
        where TPsiLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        protected abstract string BulkText { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected abstract void ExecutePsiTransaction();
        protected virtual System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected abstract void FillProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile codeCleanupProfile);
        protected abstract JetBrains.ProjectModel.IProjectFile GetProjectFile();
        protected virtual bool IsAdditionalCheckPassed() { }
        protected abstract bool IsAllowedByProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile colCleanupProfile);
    }
    public abstract class RedundancyHighlightingCleanupItemQuickFixBase<TPsiLanguage> : JetBrains.ReSharper.Intentions.QuickFixes.Bulk.HighlightingCleanupItemQuickFixBase<TPsiLanguage>
        where TPsiLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        protected override void FillProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile codeCleanupProfile) { }
        protected override bool IsAllowedByProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile colCleanupProfile) { }
    }
}
namespace JetBrains.ReSharper.Intentions.QuickFixes.ImportPath
{
    
    public sealed class IgnorePathBulbItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public IgnorePathBulbItem(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, JetBrains.Util.FileSystemPath path) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class ImportPathBulbItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public readonly JetBrains.ProjectModel.IProjectItem ProjectItem;
        public readonly JetBrains.ReSharper.Psi.Resolve.IPathReference Reference;
        public ImportPathBulbItem(JetBrains.ReSharper.Psi.Resolve.IPathReference reference, JetBrains.ProjectModel.IProjectItem projectItem) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class static ImportPathPopupQuickFixUtil
    {
        public static JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        public static string PopupMenuCaption { get; }
        public static void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
    }
    public class static ImportPathQuickFixUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> CalculateProjectItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> CalculateProjectItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder folder) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] CreateItems(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> projectItems) { }
    }
    public sealed class SetPathMappingBulbItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public SetPathMappingBulbItem(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, JetBrains.Util.FileSystemPath path) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
}
namespace JetBrains.ReSharper.Intentions.QuickFixes.Naming
{
    
    public class AddAbbreviationFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AddAbbreviationFix(JetBrains.ReSharper.Daemon.Specific.NamingConsistencyCheck.InconsistentNamingWarning error) { }
        public static bool CanBeAbbreviation(JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy namingPolicy, bool first, bool firstInNamePart) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeNameFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChangeNameFix(JetBrains.ReSharper.Daemon.Specific.NamingConsistencyCheck.InconsistentNamingWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeNamingRuleFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition AddAbbreviationPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition ChangeNamePosition;
        public ChangeNamingRuleFix(JetBrains.ReSharper.Daemon.Specific.NamingConsistencyCheck.InconsistentNamingWarning error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class InconsistentNamingQuickFixRegistrar
    {
        public InconsistentNamingQuickFixRegistrar(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.IQuickFixes table) { }
    }
    public class RemoveAbbreviationFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RemoveAbbreviationFix(JetBrains.ReSharper.Daemon.Specific.NamingConsistencyCheck.InconsistentNamingWarning error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking
{
    
    public class CommentUnusedMemberFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CommentUnusedMemberFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public CommentUnusedMemberFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public CommentUnusedMemberFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConfigureAnnotationsFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected ConfigureAnnotationsFix(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Daemon.IHighlighting highlighting) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldCompilerWarning error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.VirtualEventNeverInvokedWarning error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.InterfaceEventNeverInvokedWarning error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInInterfaceWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInBaseWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberOnlyUsedInBaseCallsWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAbstractMemberParameterWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVirtualMemberParameterWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.ParameterOnlyPassedToSelfWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAutoPropertyAccessorWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInInterfaceWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInBaseWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassNeverInstantiatedWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public ConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverInvokedWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixParameterTypeFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixParameterTypeFix(JetBrains.ReSharper.Daemon.UsageChecking.ParameterTypeCanBeEnumerableWarningBase error) { }
        public FixParameterTypeFix(JetBrains.ReSharper.Daemon.UsageChecking.BaseTypeForParameterWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class FixReturnTypeFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixReturnTypeFix(JetBrains.ReSharper.Daemon.UsageChecking.ReturnTypeCanBeEnumerableWarningBase error) { }
        public FixReturnTypeFix(JetBrains.ReSharper.Daemon.UsageChecking.PropertyTypeCanBeEnumerableWarningBase error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public interface IFixTypeLanguageHelper
    {
        void FixArrayLengthAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        bool IsArrayLengthAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> LocalsToCorrectType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IType newType, JetBrains.ReSharper.Psi.Tree.IExpression usage);
    }
    public interface IIntroduceFromParameterLanguageHelper
    {
        bool CaseSensitive { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string IntroduceFieldPattern { get; }
        void AddAssignmentToBody(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration constructorDeclaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IStatement anchorStatement, bool insertBefore, JetBrains.ReSharper.Psi.IParameter parameter, string memberName);
        JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration AddConstructorDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration);
        void AddConstructorDeclarationStubToStruct(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration structDeclaration);
        JetBrains.ReSharper.Psi.Tree.IParameterDeclaration AddConstructorParameter(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, string name, JetBrains.ReSharper.Psi.IType type);
        void AddTypeMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration anchorMember, bool insertBefore, string pattern, string name, JetBrains.ReSharper.Psi.IType type);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> BodyStatements(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration functionDeclaration);
        bool HasChainedConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, out int argumentsCount, out JetBrains.ReSharper.Psi.IConstructor targetConstructor);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string IntroduceAutoPropertyPattern(JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        bool IsParameterToMemberAssignment(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeMember member, out JetBrains.ReSharper.Psi.IParameter parameter);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> NeighbourDeclarations(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration constructorDeclaration);
        void PassParameterToChainedConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, string parameterName, int atIndex);
    }
    public interface IMakeReturnTypeVoidLanguageHelper
    {
        string QuickFixText { get; }
        bool IsReturnScope(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        bool IsReturnStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IExpression returnValue);
        void RemoveReturnValue(JetBrains.ReSharper.Psi.Tree.IStatement returnStatement, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IStatement expressionStatementLeft);
    }
    public class InitializeAutoPropertyFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public InitializeAutoPropertyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedParameterWarningBase error) { }
        public InitializeAutoPropertyFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedParameterWarningBase error) { }
        public InitializeAutoPropertyFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override string MemberName { get; }
        public override string Text { get; }
        public override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec CreateExec() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override bool IsAvailableEx(JetBrains.ReSharper.Psi.ITypeElement typeElement, string memberName) { }
    }
    public class InitializeFieldFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public InitializeFieldFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedParameterWarningBase error) { }
        public InitializeFieldFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedParameterWarningBase error) { }
        public InitializeFieldFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override string MemberName { get; }
        public override string Text { get; }
        public override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec CreateExec() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override bool IsAvailableEx(JetBrains.ReSharper.Psi.ITypeElement typeElement, string memberName) { }
    }
    public class InitializeFromConstructorsFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected readonly JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration myFieldDeclaration;
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldWarningBase error) { }
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldCompilerWarning error) { }
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedReadonlyFieldWarning error) { }
        public InitializeFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedReadonlyFieldCompilerWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected static bool IsAppropriateConstructor(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected JetBrains.ReSharper.Psi.ILanguageManager PrepareConstructors(out JetBrains.ReSharper.Psi.ITypeElement typeElement, out string parameterName, out System.Collections.Generic.HashSet<> ctorsPassingValueByChain) { }
    }
    public class IntroduceAutoPropertyFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.InitializeAutoPropertyFix
    {
        public IntroduceAutoPropertyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedParameterWarningBase error) { }
        public IntroduceAutoPropertyFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedParameterWarningBase error) { }
        public IntroduceAutoPropertyFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override string Text { get; }
        public override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec CreateExec() { }
        protected override bool IsAvailableEx(JetBrains.ReSharper.Psi.ITypeElement typeElement, string memberName) { }
    }
    public class IntroduceFieldFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.InitializeFieldFix
    {
        public IntroduceFieldFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedParameterWarningBase error) { }
        public IntroduceFieldFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedParameterWarningBase error) { }
        public IntroduceFieldFix(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override string Text { get; }
        public override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec CreateExec() { }
        protected override bool IsAvailableEx(JetBrains.ReSharper.Psi.ITypeElement typeElement, string memberName) { }
    }
    public abstract class IntroduceFromParameterFixBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected readonly JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper myLanguageHelper;
        protected readonly JetBrains.ReSharper.Psi.IParameter myParameter;
        protected IntroduceFromParameterFixBase(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected abstract string MemberName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public abstract JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec CreateExec();
        public bool IsApplicable(bool unusedParameterOnly = False) { }
        public virtual bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailableEx(JetBrains.ReSharper.Psi.ITypeElement typeElement, string memberName);
        public class InitializeMemberExec
        {
            protected readonly System.Predicate<JetBrains.ReSharper.Psi.ITypeMember> myAnchorMembersFilter;
            protected readonly JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration myConstructorDeclaration;
            protected readonly JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper myLanguageHelper;
            protected readonly string myMemberName;
            protected readonly JetBrains.ReSharper.Psi.IParameter myParameter;
            protected readonly JetBrains.ReSharper.Psi.Tree.IParameterDeclaration myParameterDeclaration;
            public InitializeMemberExec(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds nameKind, System.Predicate<JetBrains.ReSharper.Psi.ITypeMember> anchorMembersFilter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper languageHelper) { }
            public InitializeMemberExec(JetBrains.ReSharper.Psi.IParameter parameter, string memberName, System.Predicate<JetBrains.ReSharper.Psi.ITypeMember> anchorMembersFilter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper languageHelper) { }
            protected virtual JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec.AssignmentMatch DoExecute() { }
            public void Execute() { }
            protected class AssignmentMatch
            {
                public AssignmentMatch(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> memberDeclarations, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.IParameterDeclaration> parameterDeclarations, JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper languageHelper, System.Predicate<JetBrains.ReSharper.Psi.ITypeMember> anchorMembersFilter) { }
                public JetBrains.ReSharper.Psi.Tree.IStatement AssignmentStatement { get; }
                public JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration MemberDeclaration { get; }
                public JetBrains.ReSharper.Psi.Tree.IParameterDeclaration ParameterDeclaration { get; }
                public bool Match(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
            }
        }
        protected class IntroduceMemberExec : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec
        {
            public IntroduceMemberExec([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParameter parameter, [JetBrains.Annotations.NotNullAttribute()] string pattern, JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds kind, System.Predicate<JetBrains.ReSharper.Psi.ITypeMember> anchorMembersFilter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper languageHelper) { }
            protected override JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IntroduceFromParameterFixBase.InitializeMemberExec.AssignmentMatch DoExecute() { }
        }
    }
    public interface IRemoveUnusedVarHelper
    {
        bool CanRemoveUsage(JetBrains.ReSharper.Psi.Tree.IExpression usage);
        bool CanRemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        void RemoveUsage(JetBrains.ReSharper.Psi.Tree.IExpression usage, out JetBrains.ReSharper.Psi.Tree.ITreeNode rangeToHighlight);
        void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, out JetBrains.ReSharper.Psi.Tree.ITreeNode rangeToHighlight);
    }
    public interface IToConstLanguageHelper
    {
        void FixReferenceQualifier(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public class MakeClassSealedFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MakeClassSealedFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassCanBeSealedWarningBase error) { }
        public MakeClassSealedFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassWithVirtualMembersNeverInheritedWarningBase error) { }
        public MakeClassSealedFix(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class MakeNonVirtualFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeNonVirtualFix(JetBrains.ReSharper.Daemon.UsageChecking.VirtualMemberNeverOverridenWarningBase error) { }
        public MakeNonVirtualFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class MakeReadonlyFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase, JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem
    {
        protected readonly JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration myDeclaration;
        public MakeReadonlyFix(JetBrains.ReSharper.Daemon.UsageChecking.FieldCanBeMadeReadOnlyWarningBase error) { }
        protected MakeReadonlyFix(JetBrains.ReSharper.Psi.IField field) { }
        protected override string ModifiersText { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
        public bool IsValid() { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeReturnTypeVoidFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MakeReturnTypeVoidFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMethodReturnValueWarningBase error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MarkMeansImplicitUseFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected MarkMeansImplicitUseFix(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldCompilerWarning error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.VirtualEventNeverInvokedWarning error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.InterfaceEventNeverInvokedWarning error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInInterfaceWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInBaseWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberOnlyUsedInBaseCallsWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAbstractMemberParameterWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVirtualMemberParameterWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.ParameterOnlyPassedToSelfWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAutoPropertyAccessorWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInInterfaceWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInBaseWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassNeverInstantiatedWarningBase error) { }
        public MarkMeansImplicitUseFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverInvokedWarning error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MarkUsedImplicitlyFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected MarkUsedImplicitlyFix(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldCompilerWarning error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.VirtualEventNeverInvokedWarning error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.InterfaceEventNeverInvokedWarning error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInInterfaceWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInBaseWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberOnlyUsedInBaseCallsWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAbstractMemberParameterWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVirtualMemberParameterWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.ParameterOnlyPassedToSelfWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAutoPropertyAccessorWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInInterfaceWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInBaseWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassNeverInstantiatedWarningBase error) { }
        public MarkUsedImplicitlyFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverInvokedWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override void ExecuteBeforeProgressAndTransaction(JetBrains.ProjectModel.ISolution solution) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class PullFieldFromConstructorsFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.InitializeFromConstructorsFix
    {
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldWarningBase error) { }
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedFieldCompilerWarning error) { }
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedReadonlyFieldWarning error) { }
        public PullFieldFromConstructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnassignedReadonlyFieldCompilerWarning error) { }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.IChangeSignatureTestData Data { get; set; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class RemoveRedundantTypeParamFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RemoveRedundantTypeParamFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedTypeParameterWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveUnusedElementFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RemoveUnusedElementFix(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string text = null) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldCompilerWarning error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInBaseWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberInInterfaceWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberOnlyUsedInBaseCallsWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInInterfaceWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverSubscribedToInBaseWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedParameterWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAbstractMemberParameterWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVirtualMemberParameterWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.ParameterOnlyPassedToSelfWarningBase error) { }
        public RemoveUnusedElementFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedParameterWarningBase error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
    }
    public class RemoveUnusedVarFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RemoveUnusedVarFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVariableWarning error) { }
        public RemoveUnusedVarFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVariableCompilerWarning error) { }
        public RemoveUnusedVarFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedVariableWarning error) { }
        public RemoveUnusedVarFix(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldWarningBase error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected void Find(JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.RemoveUnusedVarFix.UnusedVaribleUsagesConsumer consumer) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected class UnusedVaribleUsagesConsumer : JetBrains.ReSharper.Psi.Search.IFindResultConsumer<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, bool>>
        {
            public UnusedVaribleUsagesConsumer(JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IRemoveUnusedVarHelper helper) { }
            public bool HasUsagesThatCannotBeRemoved { get; }
            public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> Usages { get; }
            public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, bool> Build(JetBrains.ReSharper.Psi.Search.FindResult result) { }
            public JetBrains.ReSharper.Psi.Search.FindExecution Merge(JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, bool> data) { }
        }
    }
    public class ToStaticFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ToStaticFix(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBeMadeStaticWarningBase error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Intentions.SurroundItems
{
    
    public class SurroundWithAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public SurroundWithAction(JetBrains.ReSharper.Feature.Services.LiveTemplates.SurroundTemplates.SurroundManager.SurroundTemplateItem surroundTemplateItem, string text = null) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Surround items.", Group="Common", Name="Surround items")]
    public class SurroundWithActionsCreator : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public SurroundWithActionsCreator(JetBrains.ReSharper.Feature.Services.Bulbs.LanguageIndependentContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SurroundWithMoreAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public SurroundWithMoreAction(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext templateAcceptanceContext) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Util
{
    
    public abstract class AccessRightsCalculator
    {
        public static bool CanCreateAbstractMember([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IClass @class, JetBrains.ReSharper.Psi.Resolve.IReference referenceFrom) { }
        public abstract bool CheckStaticContextQualifierIsStatic(JetBrains.ReSharper.Psi.ITypeElement qualifier);
        public static JetBrains.ReSharper.Psi.AccessRights GetAccessRightsForTypeDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference sourceReference, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.AccessRights> GetAccessRightsForTypeMemberDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference sourceReference, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget targetType) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.AccessRights> GetAccessRightsForTypeMemberDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference sourceReference, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
        [System.ObsoleteAttribute("Use GetAccessRightsForTypeMemberDeclaration")]
        public static JetBrains.ReSharper.Psi.AccessRights GetAccessRightsForTypeMemberDeclarationObsolete(JetBrains.ReSharper.Psi.Resolve.IReference sourceReference, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget targetType) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration GetSourceMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement);
        public static bool GetStaticForTypeMemberDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected abstract bool SuggestStaticForTypeMemberDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public abstract class BeforeExecutionOptionSelector<TOption>
    
    {
        protected BeforeExecutionOptionSelector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus) { }
        protected abstract string JpmTitle { get; }
        public void RunWithAutoSelection(TOption selectedOption, System.Action action) { }
        public void RunWithAutoSelection(System.Func<TOption[], TOption> optionSelector, System.Action action) { }
        protected void SelectOptionByJpm(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.IEnumerable<TOption> options, [JetBrains.Annotations.InstantHandleAttribute()] System.Func<TOption, JetBrains.UI.Icons.IconId> iconForOption, [JetBrains.Annotations.InstantHandleAttribute()] System.Func<TOption, string> textForOption, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<TOption> onOptionSelected) { }
    }
    public class static CastUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.IType>> PossibleCasts(JetBrains.ReSharper.Psi.Tree.IExpression castedOperand, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> operands, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> commonBaseTypes, System.Func<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression> getCastOperand) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.IType>> PossibleTypeAndNewExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, bool removeInnerCasts, bool skipImplicitConversions, System.Func<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression> getCastOperand) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IArgumentInfo SelectCastedArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool TargetTypeIsSingleBestConversion(JetBrains.ReSharper.Psi.Tree.IExpression exprToCast, JetBrains.ReSharper.Psi.IType targetType, JetBrains.ReSharper.Psi.Tree.IExpression exprToLeave) { }
    }
    public class static ChangeTypeUtil
    {
        public static bool CanCreateTypeUsage(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static void ChangeType(JetBrains.ReSharper.Psi.IType targetType, JetBrains.ReSharper.Psi.IClrDeclaredElement clrDeclaredElement) { }
        public static JetBrains.UI.RichText.RichText GetText(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.IType targetType, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class static CommonBaseTypesUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> AllSuperTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> CommonBaseTypes([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> expressions, bool ignoreUnresolved) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> CommonBaseTypes([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> forTypes, bool ignoreUnresolved) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> ComonBaseTypesOrArrays(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> expressions, bool mostSpecific, bool ignoreUnresolved) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> MostSpecificCommonBaseTypes([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> commonBaseTypes) { }
    }
    public class static ContextActionUtils
    {
        public static void FormatWithDefaultProfile(JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        public static T GetSelectedElement<T>(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider provider, bool ignoreSpaces)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static bool IsAvailable(JetBrains.ReSharper.Intentions.Extensibility.IContextAction contextAction, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider contextActionDataProvider) { }
        public static bool LooksLikeFormatString(JetBrains.ReSharper.Psi.ConstantValue constantValue) { }
    }
    public class static ControlFlowUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> AllReachableRibs(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> FindExitsFrom([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element) { }
    }
    public abstract class ExtensionMethodImportUtilBase<TInvocationInfo>
        where TInvocationInfo :  class, JetBrains.ReSharper.Psi.IInvocationInfo
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] NonStrictResolve;
        protected static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle ourStyle;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] StrictResolve;
        protected ExtensionMethodImportUtilBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        protected JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode RootElement { get; }
        protected JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IMethod> CalculateAlternatives() { }
        public static bool CheckCandidateVisibleWithModuleReference(JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService, JetBrains.ReSharper.Psi.Resolve.IReference sourceRefernce, JetBrains.ReSharper.Psi.IMethod method) { }
        public static bool CheckCandidateVisibleWithoutModuleReference(JetBrains.ReSharper.Psi.Resolve.IReference sourceRefernce, JetBrains.ReSharper.Psi.IMethod method) { }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IMethod> GetCandidateMethods(TInvocationInfo invocationInfo);
        protected abstract InvocationCandidate[] GetInvocationInfo(ref JetBrains.ReSharper.Psi.Resolve.ResolveErrorType acceptedResolveErrors);
        protected abstract string Present(JetBrains.ReSharper.Psi.IDeclaredElement method);
        protected abstract JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveOverloadsForExtensionMethods(JetBrains.ReSharper.Intentions.Util.ExtensionMethodImportUtilBase<TInvocationInfo>.InvocationCandidate candidate, JetBrains.ReSharper.Psi.IMethod method);
        protected class InvocationCandidate<TInvocationInfo>
            where TInvocationInfo :  class, JetBrains.ReSharper.Psi.IInvocationInfo
        {
            public readonly TInvocationInfo Invocation;
            public readonly System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> TypeArguments;
            public InvocationCandidate(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeArguments, TInvocationInfo invocation) { }
        }
    }
    public interface ICommentCodeLanguageHelper
    {
        bool CanCommentDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        System.Action CommentDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        System.Action CommentTextRange(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.DocumentModel.IDocument document);
    }
    [System.ObsoleteAttribute("Use LiveTemplatesManager")]
    public class static IntentionTemplateUtil
    {
        public static void ExecuteTemplate(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange selectionRange, params JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo[] fieldInfos) { }
    }
    public interface IPartBulbItem : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        void SetWorkingPart(JetBrains.ReSharper.Psi.Tree.IDeclaration partDeclaration);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MethodSignatureSelector : JetBrains.ReSharper.Intentions.Util.BeforeExecutionOptionSelector<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature>
    {
        public MethodSignatureSelector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus) { }
        protected override string JpmTitle { get; }
        public void SelectOptionByJpm(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature> options, System.Func<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature, string> textForSignature, System.Action<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature> onOptionSelected) { }
    }
    [System.ObsoleteAttribute("Use BeforeExecutionOptionSelector derieved class (see CreateFromUsageActionBase2." +
        "UpdateContextAndExecute)")]
    public class PartSelectionBulbItemProxy : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Intentions.Util.PartSelectionBulbItemProxy Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.Util.IPartBulbItem proxiedItem, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction UnproxyItem(int declarationIndex = 0) { }
    }
    public class static PathQuickFixUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] CreateChangePathMappingItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] CreateRunPathMappingEditorItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
    public abstract class SetBodyUtil
    {
        protected abstract JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration EnsureAccessor(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration destination, JetBrains.ReSharper.Psi.AccessorKind kind);
        public void SetAccessorBody(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration destination, JetBrains.ReSharper.Psi.AccessorKind kind, JetBrains.ReSharper.Psi.Tree.ITreeNode body) { }
        public abstract void SetBody(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration destination, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode body);
    }
    public class static TextControlUtils
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.ITextControl GetAndActivateTextControl(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.ITextControl GetTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static JetBrains.UI.RichText.RichText RichFormat([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        public static JetBrains.UI.RichText.RichText RichFormat([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement decl, JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        public static JetBrains.UI.RichText.RichText RichFormat(string format, JetBrains.ReSharper.Psi.PsiLanguageType language, params object[] parms) { }
    }
    public class static ValidUtils
    {
        public static bool Valid(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool Valid(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool Valid(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool checkIsInSource) { }
    }
    public class static YCombinator
    {
        public static System.Func<T, T> Curry<T>(this JetBrains.ReSharper.Intentions.Util.YCombinator.RLambda<T, T> rLambda) { }
        public delegate TOut RLambda<TIn, TOut>(JetBrains.ReSharper.Intentions.Util.YCombinator.RLambda<TIn, TOut> rLambda, TIn a);
    }
}