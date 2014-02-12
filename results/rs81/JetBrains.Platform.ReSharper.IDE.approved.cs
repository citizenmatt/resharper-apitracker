[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.IDE.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "UsageWrite",
        "XmlDocument",
        "UsageDocumentation",
        "UsageOther",
        "ExportHtml",
        "UsageRead",
        "Export",
        "HtmlDocument",
        "UsageString",
        "SearchResultsWindow",
        "UsageAttribute",
        "ExportText",
        "ExportXml",
        "PreviewToggle",
        "UsageInvocation",
        "SearchResults",
        "TextDocument",
        "UsageAll",
        "MergeOccurences",
        "Tools",
        "UsageReadWrite"}, IconPackResourceIdentification="JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
    "de.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-ide", "JetBrains.IDE.Resources")]

namespace JetBrains.IDE
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class CurrentFileTypeExceptionReportDataProvider : JetBrains.Application.ExceptionReport.IExceptionReportDataProvider
    {
        public CurrentFileTypeExceptionReportDataProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TextControl.Impl.TextControlProperties textControlProperties) { }
        public JetBrains.DataFlow.ViewableCollection<JetBrains.IDE.CurrentFileTypeExceptionReportDataProvider.IHandler> Handlers { get; }
        public void ProvideExceptionData(System.Exception ex) { }
        public interface IHandler
        {
            System.Collections.Generic.ICollection<string> Handle(JetBrains.Application.IShellLocks shellLocks, JetBrains.TextControl.ITextControl focusedTextControl);
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CurrentFileTypeExceptionReportDataProviderWithSolution : JetBrains.IDE.CurrentFileTypeExceptionReportDataProvider.IHandler
    {
        public CurrentFileTypeExceptionReportDataProviderWithSolution(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.IDE.CurrentFileTypeExceptionReportDataProvider currentFileTypeExceptionReportDataProvider, JetBrains.Application.IShellLocks shellLocks) { }
        public System.Collections.Generic.ICollection<string> Handle(JetBrains.Application.IShellLocks shellLocks, JetBrains.TextControl.ITextControl focusedTextControl) { }
    }
    public class static DataContextsEx { }
    public abstract class EditorManager
    {
        public abstract void CloseTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
        public static JetBrains.IDE.EditorManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public abstract bool IsOpenedInTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.TextControl.ITextControl OpenFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath fileName, bool activate, JetBrains.IDE.TabOptions tabOptions);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.TextControl.ITextControl OpenProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, bool activate, JetBrains.IDE.FileView fileViewPrimary, JetBrains.IDE.TabOptions tabOptions = 2);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.TextControl.ITextControl OpenProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, bool activate, JetBrains.IDE.TabOptions tabOptions = 2);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.TextControl.ITextControl TryGetTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class EnsureWritableToEditorSync
    {
        public EnsureWritableToEditorSync(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler handler, JetBrains.DocumentModel.DocumentSettings documentSettings, JetBrains.IDE.EditorManager editorManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
        protected JetBrains.DocumentModel.DocumentSettings DocumentSettings { get; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        protected virtual void OpenFiles(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> projectFiles) { }
        protected virtual bool ShouldSkip(JetBrains.ProjectModel.IProjectFile file) { }
    }
    public enum FileView
    {
        Code = 0,
        Debugging = 1,
        Designer = 2,
        Primary = 3,
        TextView = 4,
        UserChooseView = 5,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PersistableViewManager
    {
        public static readonly bool OptionTrace;
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.UI.PersistableDocument.IPersistableView CreatePersistableView([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.LifetimeDefinition lifetimeDefinition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.PersistableDocument.PersistableDocument persistableDocument, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.CrossFramework.EitherControl contentControl) { }
        [System.ObsoleteAttribute(@"Use only for creating text controls which occupy the whole view, for best integration with Visual Studio. Originally, text controls state/commans routing was coupled into the implementation, but it has been since uncoupled, so now you can create just a custom-content-view and use text controls in it freely.")]
        public virtual JetBrains.TextControl.IWinFormTextControl CreateTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.PersistableDocument.IPersistableView persistableView) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowStatistics"})]
    public class ShowStatistics : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class StatisticsForm : System.Windows.Forms.Form
    {
        public StatisticsForm(JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.UI.Application.IUIApplication environment) { }
        protected override void Dispose(bool disposing) { }
        public static JetBrains.IDE.StatisticsForm GetOrCreateInstance(JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.UI.Application.IUIApplication environment) { }
    }
    public enum TabOptions
    {
        NormalTab = 0,
        ProvisionTab = 1,
        Default = 2,
    }
}
namespace JetBrains.IDE.Resources
{
    
    public sealed class IdeThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 6, "Export")]
        public sealed class Export : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 4, "ExportHtml")]
        public sealed class ExportHtml : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 11, "ExportText")]
        public sealed class ExportText : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 12, "ExportXml")]
        public sealed class ExportXml : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 7, "HtmlDocument")]
        public sealed class HtmlDocument : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 18, "MergeOccurences")]
        public sealed class MergeOccurences : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 13, "PreviewToggle")]
        public sealed class PreviewToggle : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 15, "SearchResults")]
        public sealed class SearchResults : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 9, "SearchResultsWindow")]
        public sealed class SearchResultsWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 16, "TextDocument")]
        public sealed class TextDocument : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 19, "Tools")]
        public sealed class Tools : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 17, "UsageAll")]
        public sealed class UsageAll : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 10, "UsageAttribute")]
        public sealed class UsageAttribute : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 2, "UsageDocumentation")]
        public sealed class UsageDocumentation : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 14, "UsageInvocation")]
        public sealed class UsageInvocation : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 3, "UsageOther")]
        public sealed class UsageOther : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 5, "UsageRead")]
        public sealed class UsageRead : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 20, "UsageReadWrite")]
        public sealed class UsageReadWrite : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 8, "UsageString")]
        public sealed class UsageString : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 0, "UsageWrite")]
        public sealed class UsageWrite : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.IDE;component/resources/IdeThemedIcons/ThemedIcons.I" +
            "de.Generated.Xaml", 1, "XmlDocument")]
        public sealed class XmlDocument : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.IDE.ResultList
{
    
    public class AnonymousResultListHandler : JetBrains.IDE.ResultList.IResultListHandler
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.IDE.ResultList.AnonymousResultListHandler Empty;
        public AnonymousResultListHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.AnonymousResultListHandler.Handler FNext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.AnonymousResultListHandler.Handler FPrev, [JetBrains.Annotations.NotNullAttribute()] string sDiagName) { }
        public override string ToString() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public delegate System.Action Handler([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeExec, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.ActionPresentation presentation);
    }
    public interface IResultListHandler
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Action GoToNextLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeExec, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.ActionPresentation presentation);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Action GoToPrevLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeExec, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.ActionPresentation presentation);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ResultList_GoToNextLocationAction : JetBrains.ActionManagement.IActionHandler { }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ResultList_GoToPrevLocationAction : JetBrains.ActionManagement.IActionHandler { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResultListIdeActions : JetBrains.IDE.ResultList.IResultListHandler
    {
        protected readonly JetBrains.IDE.ResultList.ResultListValue myResultListValue;
        public ResultListIdeActions([JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.ResultListValue resultListValue) { }
        public virtual System.Action GoToNextLocation(JetBrains.DataFlow.Lifetime lifetimeExec, JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation) { }
        public virtual System.Action GoToPrevLocation(JetBrains.DataFlow.Lifetime lifetimeExec, JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResultListManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.IDE.ResultList.IResultListHandler> CurrentResultListHandler;
        public ResultListManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.ResultListValue resultListValue) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public void PublishResultList([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.LifetimeDefinition def, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.IResultListHandler list) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResultListValue
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.IDE.ResultList.IResultListHandler> CurrentResultListHandler;
        public ResultListValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    public class UIResultListPublisherAutomation
    {
        public readonly JetBrains.IDE.ResultList.IResultListHandler ResultListByOwner;
        public readonly JetBrains.IDE.ResultList.IResultListHandler ResultListWrapped;
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public UIResultListPublisherAutomation([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.ResultListManager resultListManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.IResultListHandler resultListHandler) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.DataFlow.IProperty<bool> IsKeyboardFocusWithin { get; set; }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.DataFlow.ISimpleSignal ItemExecuted { get; set; }
        public override string ToString() { }
        public enum PublishingState
        {
            NotPublished = 0,
            FocusPublished = 1,
            HardPublished = 2,
        }
    }
    public class UIResultListPublisherBehavior
    {
        public static readonly System.Windows.DependencyProperty ResultListProperty;
        public static void BindToWinForms([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.ResultList.UIResultListPublisherAutomation automation, [JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.Control view, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public static JetBrains.IDE.ResultList.UIResultListPublisherAutomation GetResultList(System.Windows.FrameworkElement element) { }
        public static void SetResultList(System.Windows.FrameworkElement element, JetBrains.IDE.ResultList.UIResultListPublisherAutomation value) { }
    }
}
namespace JetBrains.IDE.StackTrace
{
    
    public abstract class StackTraceBuilderBase : JetBrains.Util.StackTraceParser.StackTraceNodeVisitor
    {
        protected const string InvalidPathColor = "#8B8B8B";
        protected const string KeywordColor = "#0000FF";
        protected const string MethodColor = "#008B8B";
        protected const string ParameterColor = "#000000";
        protected const string TypeColor = "#00008B";
        protected StackTraceBuilderBase(JetBrains.ProjectModel.ISolution solution, JetBrains.IDE.StackTrace.StackTracePathResolverCache pathResolverCache, string text) { }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected string Text { get; }
        protected abstract void Append(string text);
        protected abstract void AppendIdentifierName(JetBrains.Util.StackTraceParser.IdentifierNode node);
        protected abstract void AppendPath(string path, int line, int column);
        protected abstract void AppendQuoted(string text);
        protected abstract void AppendQuotedNodeText(JetBrains.Util.StackTraceParser.StackTraceNode node);
        protected abstract System.IDisposable Colorize(string color);
        protected abstract System.IDisposable Link(string href);
        protected abstract System.IDisposable LinkEmuLink(string href);
        protected abstract void LinkGenerated(string uri, JetBrains.ProjectModel.IProjectFile file, int line, int col);
        public override void VisitCompositeNode(JetBrains.Util.StackTraceParser.CompositeNode node) { }
        public override void VisitIdentifier(JetBrains.Util.StackTraceParser.IdentifierNode node) { }
        public override void VisitMethod(JetBrains.Util.StackTraceParser.MethodNode node) { }
        public override void VisitParameter(JetBrains.Util.StackTraceParser.ParameterNode node) { }
        public override void VisitParameterList(JetBrains.Util.StackTraceParser.ParameterListNode node) { }
        public override void VisitPath(JetBrains.Util.StackTraceParser.PathNode node) { }
        public override void VisitText(JetBrains.Util.StackTraceParser.TextNode node) { }
    }
    public class static StackTracePathResolveHelper
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile Resolve(this JetBrains.Util.StackTraceParser.PathNode node, JetBrains.IDE.StackTrace.StackTracePathResolverCache resolverCache) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class StackTracePathResolverCache
    {
        public StackTracePathResolverCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> GetProjectFiles(string name) { }
    }
    public class static StackTraceProtocols
    {
        public const string OrdinalFileProtocol = "ordinalfile";
        public const string ProjectFileProtocol = "projectfile";
        public const string SchemeDelimiter = ":";
        public const string XmlDocProtocol = "xmldocids";
    }
}
namespace JetBrains.IDE.TreeBrowser
{
    
    public abstract class ExportTreeProviderBase : JetBrains.IDE.TreeBrowser.IExportTreeProvider
    {
        protected ExportTreeProviderBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutorSwitchingImplementation uiTaskExecutorSwitchingImplementation, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public bool Export(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("=>null,title:null;=>notnull,title:notnull")]
        public abstract System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection, out string title, out System.Windows.Forms.IWin32Window uiParent);
        public abstract bool IsApplicable(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.Export",
            "TreeModelBrowser.Export.Text",
            "TreeModelBrowser.Export.Xml",
            "TreeModelBrowser.Export.Html"})]
    public class ExportTreeViewAction : JetBrains.ActionManagement.IActionHandler
    {
        public ExportTreeViewAction(string actionId) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public enum ExportTreeViewFormat
    {
        Text = 0,
        Xml = 1,
        Html = 2,
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.ExportSelection.Text",
            "TreeModelBrowser.ExportSelection.Xml",
            "TreeModelBrowser.ExportSelection.Html"})]
    public class ExportTreeViewSelectionAction : JetBrains.ActionManagement.IActionHandler
    {
        public ExportTreeViewSelectionAction(string actionId) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.Preview.Horizontal"})]
    public class HorizontalCodeViewAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public interface IExportTreeManager
    {
        void Export(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection);
        System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection);
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat);
    }
    public interface IExportTreeProvider
    {
        bool Export(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection);
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("=>null,title:null;=>notnull,title:notnull")]
        System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection, [JetBrains.Annotations.CanBeNullAttribute()] out string title, [JetBrains.Annotations.CanBeNullAttribute()] out System.Windows.Forms.IWin32Window uiParent);
        bool IsApplicable(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat);
    }
    public interface ITreeModelBrowserPanelPersistance
    {
        System.Windows.Forms.Orientation LoadPreviewOrientation(System.Windows.Forms.Orientation def);
        int LoadPreviewSplitterPosition(System.Windows.Forms.Orientation orientation, int def);
        bool LoadPreviewVisible(bool def);
        void SavePreviewOrientation(System.Windows.Forms.Orientation value);
        void SavePreviewSplitterPosition(System.Windows.Forms.Orientation orientation, int value);
        void SavePreviewVisible(bool value);
    }
    public interface ITreePanelActions
    {
        string PreviewActionName { get; }
        System.Windows.Forms.Orientation PreviewOrientation { get; set; }
        bool PreviewSupported { get; }
        bool PreviewVisible { get; set; }
        void CollapseAll();
        void ExpandAll();
        void FocusOn([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TreeModels.TreeModelNode node);
    }
    public enum PreviewSupport
    {
        NotSupported = 0,
        Supported = 1,
        SupportedAndVisibleByDefault = 2,
        Virtual = 3,
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.Preview.Toggle"})]
    public class TogglePreviewAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class static TreeModelBrowser
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.IDE.ResultList.IResultListHandler> NAVIGATE_OCCURENCE_PROVIDER;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.IDE.TreeBrowser.ITreePanelActions> TREE_ACTIONS;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.UI.TreeView.ITreeViewController> TREE_MODEL_DESCRIPTOR;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.TreeModels.TreeModelNode> TREE_MODEL_NODE;
        public static readonly JetBrains.Application.DataContext.DataConstant<System.Collections.Generic.IList<JetBrains.TreeModels.TreeModelNode>> TREE_MODEL_NODES;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.UI.TreeView.TreeModelView> TREE_MODEL_VIEW;
        [System.ObsoleteAttribute("WinForms-only, not in use on modern trees. Use TREE_MODEL_NODE.")]
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.UI.TreeView.TreeModelViewNode> TREE_MODEL_VIEW_NODE;
        [System.ObsoleteAttribute("WinForms-only, not in use on modern trees. Use TREE_MODEL_NODES.")]
        public static readonly JetBrains.Application.DataContext.DataConstant<System.Collections.Generic.IList<JetBrains.UI.TreeView.TreeModelViewNode>> TREE_MODEL_VIEW_NODES;
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.CollapseAll"})]
    public class TreeModelBrowserCollapseAllAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.Copy"})]
    public class TreeModelBrowserCopyActionHandler : JetBrains.ActionManagement.SimpleOverridingActionHandler
    {
        public TreeModelBrowserCopyActionHandler(JetBrains.IDE.TreeBrowser.IExportTreeManager exportTreeManager) { }
        protected override void ExecuteInternal(JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public abstract class TreeModelBrowserDescriptor : JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase
    {
        protected TreeModelBrowserDescriptor(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.UI.TreeView.TreeModelPresentableView CreateView(JetBrains.IDE.TreeBrowser.TreeModelBrowserPanel panel, JetBrains.TreeModels.TreeModel model) { }
    }
    public abstract class TreeModelBrowserDescriptorBase : JetBrains.UI.TreeView.TreeViewController
    {
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected readonly JetBrains.ProjectModel.ISolution mySolution;
        protected TreeModelBrowserDescriptorBase(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual string ActionBarID { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual string ContextMenuID { get; }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> Image { get; }
        public JetBrains.DataFlow.LifetimeDefinition LifetimeDefinition { get; }
        public abstract JetBrains.TreeModels.TreeModel Model { get; }
        public abstract JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public virtual string PreviewActionName { get; }
        public virtual JetBrains.IDE.TreeBrowser.PreviewSupport PreviewSupport { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.DataFlow.IProperty<string> Title { get; }
        public event JetBrains.IDE.TreeBrowser.UpdateEventHandler UpdateRequested;
        public virtual bool AcceptOccurence(object value) { }
        public virtual bool CustomizeActionBar(JetBrains.ActionManagement.IActionBar bar) { }
        public virtual void ExportTreeView(JetBrains.UI.TreeView.TreeModelView modelView, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat format, bool onlySelection, System.IO.Stream output, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public virtual bool Navigate(JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        public virtual JetBrains.IDE.TreeBrowser.UpdateKind NeedUpdate() { }
        public virtual System.Windows.Forms.Control PreviewCreateControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame framePreview) { }
        public virtual void PreviewUpdate(System.Windows.Forms.Control previewControl, JetBrains.TreeModels.TreeModelNode modelNode, ref JetBrains.CommonControls.IPresentableItem previewCaption) { }
        protected void RequestUpdate(JetBrains.IDE.TreeBrowser.UpdateKind kind, bool immediate) { }
        public virtual void Update(JetBrains.IDE.TreeBrowser.UpdateKind updateKind) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.ExpandAll"})]
    public class TreeModelBrowserExpandAllAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TreeModelBrowserExportProvider : JetBrains.IDE.TreeBrowser.ExportTreeProviderBase
    {
        public TreeModelBrowserExportProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutorSwitchingImplementation uiTaskExecutorSwitchingImplementation, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public override System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection, out string title, out System.Windows.Forms.IWin32Window uiParent) { }
        public override bool IsApplicable(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.NextOccurence"})]
    public class TreeModelBrowserNextAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class TreeModelBrowserPanel : JetBrains.IDE.TreeBrowser.TreeModelBrowserPanelImpl, JetBrains.Application.DataContext.IDataRuleProvider, JetBrains.IDE.ResultList.IResultListHandler, JetBrains.IDE.TreeBrowser.ITreePanelActions
    {
        protected TreeModelBrowserPanel(System.Func<JetBrains.IDE.TreeBrowser.TreeModelBrowserPanel, JetBrains.TreeModels.TreeModel, JetBrains.UI.TreeView.TreeModelPresentableView> treeFactory, JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        public TreeModelBrowserPanel(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        protected System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> Rules { get; }
        public JetBrains.UI.TreeView.TreeModelView TreeModelView { get; }
        public JetBrains.UI.TreeView.TreeModelViewColorScheme TreeModelViewColorScheme { get; set; }
        protected virtual void BeforeMovePrevNext() { }
        public void CollapseAll() { }
        protected override System.Windows.Forms.Control CreateTree() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.UI.TreeView.TreeModelPresentableView CreateView(JetBrains.TreeModels.TreeModel model) { }
        protected virtual void CustomizeTreeView(JetBrains.UI.TreeView.TreeModelPresentableView treeModelView) { }
        public void ExpandAll() { }
        public void FocusOn(JetBrains.TreeModels.TreeModelNode node) { }
        public bool HasActiveViewEditor() { }
        protected virtual bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        protected virtual void ReplaceModel(JetBrains.TreeModels.TreeModel treeModel) { }
        protected override JetBrains.TreeModels.TreeModelNode SelectedModel() { }
        protected virtual void UpdateAllNodesPresentation() { }
    }
    public abstract class TreeModelBrowserPanelImpl : JetBrains.UI.CommonControls.SafeUserControl
    {
        protected static readonly System.TimeSpan KeyboardDelay;
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected TreeModelBrowserPanelImpl(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        protected JetBrains.ActionManagement.IActionBar ActionBar { get; }
        protected virtual System.Windows.Forms.Orientation DefaultPreviewOrientation { get; }
        public JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase Descriptor { get; }
        public string PreviewActionName { get; }
        public JetBrains.CommonControls.IPresentableItem PreviewCaption { get; set; }
        public System.Windows.Forms.Orientation PreviewOrientation { get; set; }
        public bool PreviewSupported { get; }
        public virtual bool PreviewVisible { get; set; }
        public JetBrains.TreeModels.TreeModel TreeModel { get; }
        protected JetBrains.IDE.TreeBrowser.UpdateKind UpdatePending { get; }
        protected virtual JetBrains.ActionManagement.IActionBar CreateActionBar(JetBrains.ActionManagement.IActionBarManager actionBarManager, string actionID) { }
        protected abstract System.Windows.Forms.Control CreateTree();
        protected override void Dispose(bool disposing) { }
        protected virtual JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetPresenter() { }
        protected virtual void InitializeCustomBar() { }
        protected virtual void InitializeCustomControl() { }
        protected override void OnCreateControl() { }
        protected virtual void OnFocusedNodeChanged(System.EventArgs e) { }
        protected override void OnHandleCreated(System.EventArgs e) { }
        protected virtual void OnLoading(System.EventArgs e) { }
        protected virtual void OnPreviewOrientationChanged() { }
        protected virtual void PerformUpdate() { }
        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData) { }
        protected abstract void ReplaceModel(JetBrains.TreeModels.TreeModel treeModel);
        protected virtual void RequestImmediateUpdate() { }
        protected virtual void RequestPendingUpdate() { }
        protected void RequestUpdate(JetBrains.IDE.TreeBrowser.UpdateKind kind, bool immediate) { }
        protected abstract JetBrains.TreeModels.TreeModelNode SelectedModel();
        public virtual void SynchronizePreview() { }
        protected abstract void UpdateAllNodesPresentation();
    }
    public class TreeModelBrowserPanelPersistanceImpl : JetBrains.IDE.TreeBrowser.ITreeModelBrowserPanelPersistance
    {
        public TreeModelBrowserPanelPersistanceImpl(string index, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public System.Windows.Forms.Orientation LoadPreviewOrientation(System.Windows.Forms.Orientation def) { }
        public int LoadPreviewSplitterPosition(System.Windows.Forms.Orientation orientation, int def) { }
        public bool LoadPreviewVisible(bool def) { }
        public void SavePreviewOrientation(System.Windows.Forms.Orientation value) { }
        public void SavePreviewSplitterPosition(System.Windows.Forms.Orientation orientation, int value) { }
        public void SavePreviewVisible(bool value) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Tree model browser state settings")]
    public class TreeModelBrowserPanelPersistanceSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Whether preview panel is visible")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> IsPreviewVisible;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Preview panel orientation")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, System.Windows.Forms.Orientation> PreviewOrientation;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Preview panel splitter horizontal position")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, int> PreviewSplitterHorizontalPosition;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Preview panel splitter vertical position")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, int> PreviewSplitterVerticalPosition;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class TreeModelBrowserPanelPersistanceSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public TreeModelBrowserPanelPersistanceSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
        public static string ParseIndexerName(string fullSettingName, string tail) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.PreviousOccurence"})]
    public class TreeModelBrowserPreviousAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "TreeModelBrowser settings")]
    public class TreeModelBrowserSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to use WPF tree")]
        public bool UseWPFTree;
    }
    public class TreeModelBrowserSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public TreeModelBrowserSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class UpdateEventArgs : System.EventArgs
    {
        public UpdateEventArgs(JetBrains.IDE.TreeBrowser.UpdateKind kind, bool immediate) { }
        public bool Immediate { get; }
        public JetBrains.IDE.TreeBrowser.UpdateKind Kind { get; }
    }
    public delegate void UpdateEventHandler(object sender, JetBrains.IDE.TreeBrowser.UpdateEventArgs e);
    public enum UpdateKind
    {
        None = 0,
        Display = 1,
        Structure = 2,
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TreeModelBrowser.Preview.Vertical"})]
    public class VerticalCodeViewAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.IDE.TreeBrowser.WPF
{
    
    public class StructuredPresenterElement : JetBrains.UI.Avalon.Controls.CustomVisualsControl<System.Windows.Controls.StackPanel>
    {
        public static readonly System.Windows.DependencyProperty StructuredPresenterProperty;
        public StructuredPresenterElement([JetBrains.Annotations.NotNullAttribute()] System.Func<string, System.Action<bool>, bool> reentrancyGuardExecuteOrQueueOrMerge) { }
        public JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> StructuredPresenter { get; set; }
        protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    }
    public class TreeModelBrowserPanelWPF : JetBrains.IDE.TreeBrowser.TreeModelBrowserPanelImpl, JetBrains.Application.DataContext.IDataRuleProvider, JetBrains.IDE.TreeBrowser.ITreePanelActions
    {
        public TreeModelBrowserPanelWPF(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF TreeModelView { get; }
        public void CollapseAll() { }
        protected override System.Windows.Forms.Control CreateTree() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF CreateView() { }
        protected virtual void CustomizeTreeView(JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF treeModelView) { }
        public void ExpandAll() { }
        public void FocusOn(JetBrains.TreeModels.TreeModelNode node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> GetDataRules() { }
        protected virtual bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus) { }
        protected virtual void ReplaceModel(JetBrains.TreeModels.TreeModel treeModel) { }
        protected override JetBrains.TreeModels.TreeModelNode SelectedModel() { }
        protected virtual void UpdateAllNodesPresentation() { }
    }
    public class TreeModelPresentableViewWPF : JetBrains.UI.Avalon.Controls.CustomVisualsControl<System.Windows.Controls.DockPanel>
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<System.Collections.Generic.IList<JetBrains.UI.Avalon.TreeListView.Contracts.INodeState>> TREE_SELECTED_NODES;
        public TreeModelPresentableViewWPF([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TreeModels.TreeModel treeModel, JetBrains.UI.TreeView.ITreeViewController treeModelBrowserDescriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.UI.TreeView.ITreeViewController Controller { get; }
        public JetBrains.Util.TypeHierarchyMap<JetBrains.UI.TreeView.ICustomModelNodePresenter> CustomPresenters { get; }
        public System.Nullable<int> DefaultExpandLevels { get; set; }
        public bool IsDisposed { get; }
        public JetBrains.TreeModels.TreeModel Model { get; set; }
        public virtual JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; set; }
        public JetBrains.TreeModels.TreeModelNode SelectedItem { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> SelectedItems { get; }
        public JetBrains.TreeModels.TreeModelNode SelectedModel { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.UI.Avalon.TreeListView.Contracts.INodeState> SelectedNodes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.PopupWindowManager.PopupWindowContextSource WindowContextSource { get; }
        public event System.Action<JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF, JetBrains.UI.Avalon.TreeListView.ContextMenuRequestArgs> ContextMenuRequested;
        public event System.EventHandler<System.EventArgs> FocusedNodeChanged;
        public event System.Action<JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF, JetBrains.UI.Avalon.TreeListView.ItemActivatedArgs> Navigate;
        public System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> AddDataRules(System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> dataRules) { }
        public void CollapseAll() { }
        public System.Collections.Generic.Dictionary<JetBrains.TreeModels.TreeModelNode, JetBrains.UI.TreeView.PresentationState> CreatePresentationSnapshot() { }
        public void ExpandAll() { }
        public void FocusOn([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TreeModels.TreeModelNode node) { }
        public JetBrains.UI.PopupWindowManager.IPopupWindowContext GetWindowContext(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected virtual void OnModelUpdating(object sender, System.EventArgs eventArgs) { }
        public bool ReentrancyGuardExecuteOrQueueOrMerge([System.ComponentModel.LocalizableAttribute(false)] string id, System.Action<bool> action) { }
        protected void ResetPresentationCaches() { }
        public void Select(System.Collections.Generic.IList<JetBrains.TreeModels.TreeModelNode> getNodes) { }
        public void UpdateAllNodesPresentation() { }
        public class MyContext : JetBrains.UI.PopupWindowManager.PopupWindowContext
        {
            public MyContext(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF tree, System.Nullable<System.Windows.Point> point = null) { }
            public override JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
        }
    }
    public class TreeModelProviderFromTreeModel : JetBrains.UI.Avalon.TreeListView.Contracts.ITreeModelChangeTracker, JetBrains.UI.Avalon.TreeListView.Contracts.ITreeModelProvider, JetBrains.UI.Avalon.TreeListView.Contracts.ITreeStateRestoreSupportAdvanced, JetBrains.UI.Avalon.TreeListView.Contracts.ITreeStateRestoreSupportSimple
    {
        public TreeModelProviderFromTreeModel(JetBrains.TreeModels.TreeModel treeModel) { }
        public object Root { get; }
        public event System.Action<JetBrains.UI.Avalon.TreeListView.Contracts.ITreeModelChangeTracker> ModelChanged;
        public event System.Action<JetBrains.UI.Avalon.TreeListView.Contracts.ITreeModelChangeTracker> ModelChanging;
        public event JetBrains.UI.Avalon.TreeListView.Contracts.ResetChangeDelegate NotifyReset;
        public System.Collections.Generic.IEnumerable<object> FromIdentity(object identity) { }
        public JetBrains.UI.Avalon.TreeListView.Contracts.ITreeStateRestoreSupportAdvanced GetAdvanced() { }
        public JetBrains.UI.Avalon.TreeListView.Contracts.ITreeModelChangeTracker GetChangeTracker() { }
        public System.Collections.IList GetChildren(object parent) { }
        public System.Collections.Generic.IEqualityComparer<object> GetCustomComparer() { }
        public object GetIdentity(object model) { }
        public object GetParent(object model) { }
        public JetBrains.UI.Avalon.TreeListView.Contracts.ITreeStateRestoreSupportSimple GetStateRestoreSupport() { }
        public bool HasChildren(object model) { }
    }
}
namespace JetBrains.IDE.TreeGridBrowser.Exporting
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TreeGridBrowserExportProvider : JetBrains.IDE.TreeBrowser.ExportTreeProviderBase
    {
        public TreeGridBrowserExportProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutorSwitchingImplementation uiTaskExecutorSwitchingImplementation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Theming.ITheming theming, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public override System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection, out string title, out System.Windows.Forms.IWin32Window uiParent) { }
        public override bool IsApplicable(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat) { }
    }
    public abstract class TreeModelCellPresentersExportBase : JetBrains.IDE.TreeGridBrowser.Exporting.TreeModelVisitor
    {
        protected TreeModelCellPresentersExportBase(JetBrains.IDE.TreeGridBrowser.ITreeViewCellPresentationsProvider cellPresentationsProvider) { }
        protected abstract void ProcessCellPresentations(int level, JetBrains.CommonControls.IPresentableItem[] cells, JetBrains.Application.Progress.IProgressIndicator progress);
        protected override void ProcessTreeModelNode(int level, JetBrains.TreeModels.TreeModelNode treeModelNode, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public abstract class TreeModelVisitor
    {
        public virtual void Process(JetBrains.TreeModels.TreeModel treeModel, System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelNode> treeModelNodes, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected abstract void ProcessTreeModelNode(int level, JetBrains.TreeModels.TreeModelNode treeModelNode, JetBrains.Application.Progress.IProgressIndicator progress);
        protected virtual void VisitTreeModelNode(int level, JetBrains.TreeModels.TreeModelNode treeModelNode, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
}
namespace JetBrains.IDE.TreeGridBrowser
{
    
    public interface IPendedActionScheduler
    {
        void Schedule(System.Action action);
    }
    public interface ITreeViewCellPresentationsProvider
    {
        JetBrains.CommonControls.IPresentableItem[] GetCellPresentations(JetBrains.TreeModels.TreeModelNode treeModelNode);
    }
    public class NodeCheckedStateChangedEventArgs : JetBrains.UI.ValueChangedEventArgs<System.Nullable<bool>>
    {
        public NodeCheckedStateChangedEventArgs(JetBrains.TreeModels.TreeModelNode node, System.Nullable<bool> previous, System.Nullable<bool> current) { }
        public JetBrains.TreeModels.TreeModelNode Node { get; }
    }
    public delegate void NodeCheckedStateChangedEventHandler(object sender, JetBrains.IDE.TreeGridBrowser.NodeCheckedStateChangedEventArgs args);
    public class TreeGridBrowserPanel : System.Windows.Controls.Grid, JetBrains.Application.DataContext.IDataRuleProvider, JetBrains.IDE.ResultList.IResultListHandler, JetBrains.IDE.TreeBrowser.ITreePanelActions
    {
        public static readonly System.Windows.DependencyProperty DefaultCheckedStateProperty;
        public static readonly System.Windows.DependencyProperty IsCheckableProperty;
        public TreeGridBrowserPanel([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionBarManager actionBarManager) { }
        public JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase Controller { get; }
        public bool DefaultCheckedState { get; set; }
        public JetBrains.TreeModels.TreeModelNode FocusedNode { get; }
        public bool IsCheckable { get; set; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.TreeModels.TreeModel Model { get; }
        public string PreviewActionName { get; }
        public System.Windows.Forms.Orientation PreviewOrientation { get; set; }
        public bool PreviewSupported { get; }
        public bool PreviewVisible { get; set; }
        public JetBrains.TreeModels.TreeModelNode SelectedNode { get; }
        public JetBrains.UI.Application.IUIApplication UIApplication { get; }
        protected JetBrains.IDE.TreeBrowser.UpdateKind UpdatePending { get; }
        public event JetBrains.IDE.TreeGridBrowser.NodeCheckedStateChangedEventHandler CheckedStateChanged;
        public event System.EventHandler FocusedNodeChanged;
        public event System.EventHandler SelectedNodesChanged;
        public void CollapseAll() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.PopupWindowManager.PopupWindowContextSource CreateWindowContextSource() { }
        public void ExpandAll() { }
        public void FocusOn(JetBrains.TreeModels.TreeModelNode targetNode) { }
        public System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> GetCheckedNodes(System.Nullable<bool> requiredCheckState = True) { }
        public System.Nullable<bool> GetCheckedState(JetBrains.TreeModels.TreeModelNode node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> GetDataRules() { }
        protected virtual JetBrains.IDE.TreeGridBrowser.IPendedActionScheduler GetPendedActionScheduler() { }
        public System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> GetSelectedNodes() { }
        protected virtual JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetStructuredPresenter() { }
        protected virtual bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        protected virtual void OnModelReadActivityCompleted() { }
        protected virtual void OnModelReadActivityStarted() { }
        protected virtual void OnMouseDoubleClick(JetBrains.TreeModels.TreeModelNode node) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        protected virtual void OnMoveToOccurence(JetBrains.TreeModels.TreeModelNode occurence) { }
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
        protected virtual void OnTreeViewUpdated() { }
        protected virtual void OnTreeViewUpdating() { }
        protected virtual void PerformUpdate() { }
        protected void RefreshStructurePresenters() { }
        protected virtual void RequestImmediateUpdate() { }
        protected virtual void RequestPendingUpdate() { }
        protected void RequestUpdate(JetBrains.IDE.TreeBrowser.UpdateKind kind, bool immediate) { }
        public void SetCheckedState(JetBrains.TreeModels.TreeModelNode node, bool checkState) { }
        protected virtual void UpdateAllNodesPresentation() { }
        public class UIElementPopupWindowContext : JetBrains.UI.PopupWindowManager.PopupWindowContext
        {
            public UIElementPopupWindowContext(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, System.Windows.UIElement uiElement, System.Nullable<System.Windows.Point> point = null) { }
            public override JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
        }
    }
    public class TreeGridPresentableNodeModel : JetBrains.UI.TreeGrid.ITreeGridNodeModel
    {
        public TreeGridPresentableNodeModel(JetBrains.TreeModels.TreeModelNode treeModelNode, JetBrains.UI.TreeGrid.ITreeGridNodeModel parent, System.Action<System.Action> withReentrancyGuard) { }
        public int Count { get; }
        public object Data { get; }
        public JetBrains.UI.TreeGrid.IFilterDescriptor Filter { get; set; }
        public bool HasChildren { get; }
        public JetBrains.UI.TreeGrid.ITreeGridNodeModel Parent { get; }
        public JetBrains.UI.TreeGrid.ISortDescription SortDescription { get; set; }
        public System.ComponentModel.ListSortDirection SortDirection { get; set; }
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler ChildrenChanged;
        public event System.EventHandler CountChanged;
        public event System.EventHandler HasChildrenChanged;
        public JetBrains.UI.TreeGrid.ITreeGridNodeModel GetChild(int index) { }
    }
    public class TreeGridPresentableNodeModelProvider : JetBrains.UI.TreeGrid.ITreeGridNodeModelProvider
    {
        public TreeGridPresentableNodeModelProvider(System.Action<System.Action> withReentrancyGuard) { }
        public JetBrains.UI.TreeGrid.ITreeGridNodeModel GetNodeModel(object data, JetBrains.UI.TreeGrid.ITreeGridNodeModel parent) { }
    }
    public class TreeGridPresentableView : System.Windows.Controls.Grid, JetBrains.Application.DataContext.IDataRuleProvider, JetBrains.IDE.TreeGridBrowser.ITreeViewCellPresentationsProvider
    {
        public static readonly System.Windows.DependencyProperty DefaultCheckedStateProperty;
        public static readonly System.Windows.DependencyProperty IsCheckableProperty;
        public int MaxTraverseDepth;
        public static readonly System.Windows.DependencyProperty ModelProperty;
        public static readonly System.Windows.DependencyProperty PresenterProperty;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.IDE.TreeGridBrowser.ITreeViewCellPresentationsProvider> TREE_VIEW_CELL_PRESENTATIONS_PROVIDER;
        public TreeGridPresentableView([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.TreeView.ITreeViewController controller, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public bool DefaultCheckedState { get; set; }
        public bool IsCheckable { get; set; }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.TreeModels.TreeModel Model { get; set; }
        public JetBrains.IDE.TreeGridBrowser.IPendedActionScheduler PendedActionScheduler { get; set; }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; set; }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.TreeModels.TreeModelNode SelectedNode { get; }
        public event JetBrains.IDE.TreeGridBrowser.NodeCheckedStateChangedEventHandler CheckedStateChanged;
        public event System.EventHandler FocusedNodeChanged;
        public event System.Action ModelReadActivityCompleted;
        public event System.Action ModelReadActivityStarted;
        public event System.Windows.Input.MouseButtonEventHandler MouseDoubleClick;
        public event System.EventHandler SelectedNodesChanged;
        public event System.EventHandler Updated;
        public event System.EventHandler Updating;
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void CollapseAll() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.PopupWindowManager.PopupWindowContextSource CreateWindowContextSource() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void ExpandAll() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void ExpandTo(JetBrains.TreeModels.TreeModelNode node) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void Focus(JetBrains.TreeModels.TreeModelNode node, bool transferKeyboardFocus) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.CommonControls.IPresentableItem[] GetCellPresentations(JetBrains.TreeModels.TreeModelNode treeModelNode) { }
        public System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> GetCheckedNodes(System.Nullable<bool> requiredCheckState = True) { }
        public System.Nullable<bool> GetCheckedState(JetBrains.TreeModels.TreeModelNode node) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> GetDataRules() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.TreeModels.TreeModelNode GetFocusedNode() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> GetSelectedNodes(bool performPendedActions = True) { }
        public JetBrains.TreeModels.TreeModelNode HitNode(System.Windows.Point mousePoint) { }
        public void InvalidateCheckedStatePresentaions() { }
        public void InvalidateStructurePresenters() { }
        public void PerformPendedActions() { }
        public void ResetCheckedStates() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void Select(JetBrains.TreeModels.TreeModelNode node) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void Select(System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> nodes) { }
        public void SetCheckedState(JetBrains.TreeModels.TreeModelNode node, bool checkState) { }
        public class UIElementPopupWindowContext : JetBrains.UI.PopupWindowManager.PopupWindowContext
        {
            public UIElementPopupWindowContext(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, System.Windows.UIElement uiElement, System.Nullable<System.Windows.Point> point = null) { }
            public override JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
        }
    }
    public class static TreeModelIteratorHelper
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> Enumerate(JetBrains.TreeModels.TreeModel treeModel) { }
        public static JetBrains.TreeModels.TreeModelNode Next(JetBrains.TreeModels.TreeModel treeModel, JetBrains.TreeModels.TreeModelNode node, System.Collections.Generic.IList<JetBrains.TreeModels.TreeModelNode> roots) { }
        public static JetBrains.TreeModels.TreeModelNode Previous(JetBrains.TreeModels.TreeModel treeModel, JetBrains.TreeModels.TreeModelNode node, System.Collections.Generic.IList<JetBrains.TreeModels.TreeModelNode> roots) { }
    }
    public class TreeModelNodePresenter : JetBrains.UI.Avalon.Controls.CustomVisualsControl<System.Windows.Controls.StackPanel>
    {
        public TreeModelNodePresenter([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> structuredPresenter, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<System.Action> updateExecutor, bool checkable, System.Func<JetBrains.TreeModels.TreeModelNode, System.Nullable<bool>> getCheckedState, System.Action<JetBrains.TreeModels.TreeModelNode, bool> setCheckedState) { }
        public void InvalidateContent() { }
        public void UpdateCheckedState() { }
        public void UpdateContentOrQueue() { }
    }
}
namespace JetBrains.IDE.UI.Options
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class OptionsPageViewFactorySolution
    {
        public OptionsPageViewFactorySolution(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Components.IComponentContainer containerParent, JetBrains.UI.Options.OptionsPageViewFactoryManager optionsPageViewFactoryManager) { }
    }
}