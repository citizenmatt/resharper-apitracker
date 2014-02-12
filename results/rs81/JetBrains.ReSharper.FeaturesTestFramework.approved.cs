[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.AspTests.CodeCompletion
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".aspx")]
    [NUnit.Framework.CategoryAttribute("Code Completion")]
    [NUnit.Framework.CategoryAttribute("ASP.NET")]
    public abstract class AspCodeCompletionTestBase : JetBrains.ReSharper.HtmlTests.CodeCompletion.WebCodeCompletionTestBase
    {
        protected override bool ExecuteAction { get; }
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".ashx")]
    [NUnit.Framework.CategoryAttribute("Code Completion")]
    public abstract class AsxxCodeCompletionTestBase : JetBrains.ReSharper.HtmlTests.CodeCompletion.WebCodeCompletionTestBase { }
}
namespace JetBrains.ReSharper.AspTests.QuickFixes
{
    
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "System.dll",
            "System.Core.dll"})]
    public abstract class WebConfigQuickFixTestBase<T> : JetBrains.ReSharper.IntentionsTests.QuickFixTestBase<T>
        where T : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public override string ProjectBasePath { get; }
    }
}
namespace JetBrains.ReSharper.BuildScriptTests.Intentions
{
    
    public abstract class ScriptQuickFixTestBase : JetBrains.ReSharper.IntentionsTests.QuickFixTestBase<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix>
    {
        protected ScriptQuickFixTestBase(string relativePath, System.Type qfType, System.Type errorType, string name) { }
        protected override string RelativeTestDataPath { get; }
        protected override void CleanSolution() { }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IQuickFix CreateQuickFix(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class ScriptQuickFixUtil
    {
        public static JetBrains.ReSharper.Intentions.Extensibility.IQuickFix CreateQuickFix(System.Type qfType, System.Type errorType, params object[] errorParams) { }
    }
}
namespace JetBrains.ReSharper.Daemon.CSharp
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".cs")]
    [NUnit.Framework.CategoryAttribute("CSharp")]
    public abstract class CSharpHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected System.Nullable<JetBrains.ReSharper.Psi.CSharp.CSharpLanguageLevel> myLanguageLevel;
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected void DoNamedTest(JetBrains.ReSharper.Psi.CSharp.CSharpLanguageLevel level, params string[] auxFiles) { }
        protected void DoNamedTest2(JetBrains.ReSharper.Psi.CSharp.CSharpLanguageLevel level, params string[] auxFiles) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override bool HighlightingPredicate(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override void WithProject(JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Action action) { }
    }
    [JetBrains.ReSharper.TestFramework.TestNetFramework45Attribute()]
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "mscorlib.dll",
            "System.dll",
            "System.Data.dll",
            "System.Core.dll",
            "System.Xml.dll",
            "System.Web.dll",
            "System.Data.Entity.dll",
            "Microsoft.CSharp.dll",
            "AsyncCtpLibrary.dll",
            "%PRODUCT%\\JetBrains.Annotations.dll"})]
    public abstract class CSharpHighlightingTestNet45Base : JetBrains.ReSharper.Daemon.CSharp.CSharpHighlightingTestBase { }
    [JetBrains.ReSharper.TestFramework.TestNetFramework4Attribute()]
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "mscorlib.dll",
            "System.dll",
            "System.Data.dll",
            "System.Core.dll",
            "System.Xml.dll",
            "System.Web.dll",
            "System.Data.Entity.dll",
            "Microsoft.CSharp.dll",
            "AsyncCtpLibrary.dll",
            "%PRODUCT%\\JetBrains.Annotations.dll"})]
    public abstract class CSharpHighlightingTestNet4Base : JetBrains.ReSharper.Daemon.CSharp.CSharpHighlightingTestBase { }
}
namespace JetBrains.ReSharper.Daemon.JavaScript
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".js")]
    [JetBrains.ReSharper.TestFramework.TestSettingsAttribute("{FullResolveForDynamicReferences:all}")]
    [JetBrains.ReSharper.TestFramework.TestSettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.JavaScriptResolveSettingsKey))]
    [JetBrains.ReSharper.TestFramework.WebApplicationAttribute()]
    [NUnit.Framework.CategoryAttribute("JS")]
    public abstract class JavaScriptHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected override string RelativeTestDataPath { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".ts")]
    [JetBrains.ReSharper.TestFramework.WebApplicationAttribute()]
    [NUnit.Framework.CategoryAttribute("TypeScript")]
    [NUnit.Framework.CategoryAttribute("JS")]
    public abstract class TypeScriptHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected override string RelativeTestDataPath { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Test
{
    
    [NUnit.Framework.CategoryAttribute("Daemon")]
    public abstract class HighlightingTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject, JetBrains.ReSharper.TestFramework.IBaseTest
    {
        protected const string JETBRAINS_ANNOTATIONS_DLL_PATH = "%PRODUCT%\\JetBrains.Annotations.dll";
        public HighlightingTestBase() { }
        protected virtual bool ColorIdentifiers { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected virtual bool ProcessAllFiles { get; }
        public override System.Nullable<JetBrains.ProjectModel.ProjectOutputType> ProjectOutputType { get; }
        protected virtual JetBrains.ReSharper.Daemon.Test.TestHighlightingDumper CreateHighlightDumper(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.TextWriter writer) { }
        protected virtual void DoNamedTest(params string[] auxFiles) { }
        protected virtual void DoNamedTest2(params string[] auxFiles) { }
        protected override void DoOneTest(string testName) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject project) { }
        protected virtual void DoTestFiles(params string[] testFiles) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.IDaemonStage> GetActiveStages(JetBrains.ProjectModel.ISolution solution) { }
        protected override System.Collections.Generic.IEnumerable<string> GetReferencedAssemblies() { }
        protected override string[] GetSdkReferences() { }
        protected virtual bool HighlightingPredicate(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected virtual void WithProject(JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore contextBoundSettingsStore, System.Action action) { }
    }
    public abstract class TestDaemonProcess : JetBrains.ReSharper.Daemon.Impl.DaemonProcessBase
    {
        protected TestDaemonProcess(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.IDaemonStage> stages, bool fullRehighlightingRequired) { }
        protected TestDaemonProcess(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.IDaemonStage> stages) { }
        protected TestDaemonProcess(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool FullRehighlightingRequired { get; }
        public abstract void CommitHighlighters(JetBrains.ReSharper.Daemon.Impl.DaemonProcessBase.DaemonCommitContext context);
        public void DoHighlighting(JetBrains.ReSharper.Daemon.DaemonProcessKind kind) { }
        public override bool IsRangeInvalidated(JetBrains.DocumentModel.DocumentRange range) { }
    }
    public class TestHighlightingDumper : JetBrains.ReSharper.Daemon.Test.TestDaemonProcess
    {
        public TestHighlightingDumper(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.TextWriter writer, System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.IDaemonStage> stages, System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool> highlightingPredicate, JetBrains.ReSharper.Psi.PsiLanguageType compilerIdsLanguage = null) { }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.HighlightingInfo> Highlighters { get; }
        public void Clear() { }
        public override void CommitHighlighters(JetBrains.ReSharper.Daemon.Impl.DaemonProcessBase.DaemonCommitContext context) { }
        public new void DoHighlighting(JetBrains.ReSharper.Daemon.DaemonProcessKind kind) { }
        public virtual void Dump() { }
        protected virtual string GetHighlightingTypeSuffix(JetBrains.ReSharper.Daemon.HighlightingInfo info) { }
        protected virtual void WriteHighlighting(int i, string attributeId, string idstring, JetBrains.ReSharper.Daemon.HighlightingInfo info, string highlightingTypeSuffix) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        protected void WriteLine(string format, params object[] arg) { }
    }
    public class TestHighlightingDumperWithType : JetBrains.ReSharper.Daemon.Test.TestHighlightingDumper
    {
        public TestHighlightingDumperWithType(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.TextWriter writer, System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.IDaemonStage> stages, System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool> highlightingPredicate, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType compilerIdsLanguage) { }
        protected override string GetHighlightingTypeSuffix(JetBrains.ReSharper.Daemon.HighlightingInfo info) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Xaml.Test
{
    
    [JetBrains.ReSharper.PsiTests.Xaml.TestWPF30Attribute(new string[] {
            "System.Xml.Linq.dll"})]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".xaml")]
    [JetBrains.ReSharper.TestFramework.TestNetFramework35Attribute()]
    [NUnit.Framework.CategoryAttribute("XAML")]
    public abstract class XamlHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        public override string ProjectBasePath { get; }
        protected override string RelativeTestDataPath { get; }
    }
}
namespace JetBrains.ReSharper.DaemonTests.Css
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".css")]
    [NUnit.Framework.CategoryAttribute("CSS")]
    public abstract class CssHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected CssHighlightingTestBase() { }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected override string RelativeTestDataPath { get; }
        protected void DoNamedTest(JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override bool HighlightingPredicate(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override void WithProject(JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Action action) { }
    }
}
namespace JetBrains.ReSharper.DaemonTests.Html
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".html")]
    [NUnit.Framework.CategoryAttribute("HTML")]
    public abstract class HtmlHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected static readonly System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool> ourErrorAndWarningHighlightingPredicate;
        protected HtmlHighlightingTestBase() { }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected virtual JetBrains.ProjectModel.Properties.ProjectLanguage ProjectLanguage { get; }
        protected override string RelativeTestDataPath { get; }
        protected void DoNamedTest([JetBrains.Annotations.NotNullAttribute()] System.Func<System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool>, System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool>> highlightingPredicateConverter, params string[] auxFiles) { }
        protected void DoNamedTest([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool> highlightingPredicate, params string[] auxFiles) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected static System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool> HighlightingFilter(params JetBrains.ReSharper.Daemon.Severity[] allowedSeverities) { }
        protected override bool HighlightingPredicate(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected System.IDisposable UseCustomHighlightingPredicate([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.Application.Settings.IContextBoundSettingsStore, bool> highlightingPredicate) { }
    }
}
namespace JetBrains.ReSharper.DaemonTests.Razor
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestMvc3Attribute(new string[0])]
    [NUnit.Framework.CategoryAttribute("Razor")]
    public abstract class RazorHighlightingTestBase : JetBrains.ReSharper.DaemonTests.Html.HtmlHighlightingTestBase
    {
        public override string ProjectBasePath { get; }
        protected override string RelativeTestDataPath { get; }
    }
}
namespace JetBrains.ReSharper.DaemonTests.VB
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".vb")]
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "System.dll",
            "System.Data.dll",
            "System.Data.DataSetExtensions.dll",
            "System.Core.dll",
            "System.Xml.dll",
            "System.Xml.Linq.dll",
            "Microsoft.VisualBasic.dll",
            "AsyncCtpLibrary.dll",
            "%PRODUCT%\\JetBrains.Annotations.dll"})]
    [NUnit.Framework.CategoryAttribute("VB")]
    public abstract class VBHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected override JetBrains.ReSharper.Psi.PsiLanguageType CompilerIdsLanguage { get; }
        protected override void DoTestSolution(params string[] fileSet) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override bool HighlightingPredicate(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override void WithProject(JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Action action) { }
        protected class LanguageLevelCookie : System.IDisposable
        {
            public LanguageLevelCookie(JetBrains.ReSharper.DaemonTests.VB.VBHighlightingTestBase owner, JetBrains.ReSharper.Psi.VB.Impl.VBLanguageLevel level) { }
            public void Dispose() { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.Tests.CodeCompletion
{
    
    [NUnit.Framework.CategoryAttribute("CSS")]
    [NUnit.Framework.CategoryAttribute("Code Completion")]
    public abstract class CssCodeCompletionTestBase : JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.CodeCompletion.CodeCompletionTestBase
    {
        protected override bool ExecuteAction { get; }
        protected override string RelativeTestDataPath { get; }
        protected override System.Action BeforeTestStart(JetBrains.ProjectModel.IProject testProject, string documentText) { }
        protected override bool CheckAutomaticCompletionDefault() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Generate.Tests
{
    
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "%PRODUCT%\\JetBrains.Annotations.dll"})]
    [NUnit.Framework.CategoryAttribute("Generate")]
    public abstract class GenerateTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected override string[] ModifyTestFiles(string[] testFiles) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Highlighting.Tests
{
    
    public abstract class HighlightActionTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected abstract string HighlightActionName { get; }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.CodeCompletion
{
    
    [NUnit.Framework.CategoryAttribute("Code Completion")]
    public abstract class CodeCompletionTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected abstract bool ExecuteAction { get; }
        protected virtual System.Action BeforeTestStart(JetBrains.ProjectModel.IProject testProject, string documentText) { }
        protected virtual bool CheckAutomaticCompletionDefault() { }
        protected void CheckResultList(JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult result, System.IO.TextWriter writer) { }
        protected void DoCompletionAction(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult context, bool automatic, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> result, string completeItem) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual void DumpCaretPosition(JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void ExecuteCodeCompletion(JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, bool automatic, string documentText) { }
        protected void FinishHotspotSession() { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType GetEditorBrowsableProcessingType() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetItemsFromResult(JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult result, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> best) { }
        protected static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> SortByName(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> best) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.TypingAssist.Tests
{
    
    [JetBrains.ReSharper.TestFramework.TestSettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings))]
    [JetBrains.ReSharper.TestFramework.TestSettingsVariableAttribute("CharsTyped", typeof(string[]))]
    [NUnit.Framework.CategoryAttribute("Typing assist")]
    public abstract class TypingAssistTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        public const string CharsTyped = "CharsTyped";
        protected TypingAssistTestBase() { }
        protected virtual void BeforeModification([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        public static System.Nullable<bool> GetBoolSetting(JetBrains.Text.IBuffer buffer, string name, System.Nullable<bool> defaultValue = null) { }
        public static void SetTypingAssistOption<TSettings, TEntry>(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Linq.Expressions.Expression<System.Func<TSettings, TEntry>> expr, System.Nullable<TEntry> value = null)
        
            where TEntry :  struct { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CodeCompletion.Test
{
    
    [JetBrains.ReSharper.PsiTests.Xaml.TestWPF30Attribute(new string[0])]
    public abstract class XamlCodeCompletionTestBase : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.Test.XmlCodeCompletionTestBase
    {
        protected override bool ExecuteAction { get; }
        public override string ProjectBasePath { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.Test
{
    
    public abstract class XmlCodeCompletionTestBase : JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.CodeCompletion.CodeCompletionTestBase
    {
        public override string ProjectBasePath { get; }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.BulbMenu
{
    
    public abstract class BulbMenuTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        public static void Write(System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbActionKey> rootItems, string indent, System.IO.TextWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class QuickFixesProviderTest : JetBrains.ReSharper.Intentions.Bulbs.QuickFixesProvider
    {
        public QuickFixesProviderTest(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.ReSharper.Daemon.IQuickFixes quickFixes, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Daemon.Daemon daemon) { }
        protected override bool CheckViewportContains(JetBrains.Util.TextRange viewport, JetBrains.Util.TextRange range) { }
        protected override bool IsRangeInTextView(JetBrains.TextControl.Coords.TextControlPosRange txtrange) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestBulbItems : JetBrains.ReSharper.Intentions.Bulbs.BulbItems
    {
        public TestBulbItems(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Intentions.Bulbs.IBulbItemsProvider> bulbActionProviders, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool CheckViewContains(JetBrains.Util.TextRange viewport, int caretOffset) { }
        protected override void RegisterContextConsumer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, System.Action<JetBrains.DataFlow.Lifetime> onContextChanged) { }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.Clipboard
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestClipboardHelper : JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardHelper
    {
        public TestClipboardHelper(JetBrains.Threading.IThreading threading, JetBrains.UI.Clipboard clipboard, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager clipboardManager, JetBrains.DataFlow.Lifetime lifetime) { }
        public override void QueueAction(string name, System.Action<JetBrains.UI.Clipboard, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager> action) { }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.CodeCleanup
{
    
    [NUnit.Framework.CategoryAttribute("Code Cleanup")]
    public abstract class CodeCleanupMultipleFilesTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject
    {
        protected System.Action<JetBrains.Application.Settings.ISettingsStore> myPatchSettings;
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
    }
    public class CodeCleanupProfileAttribute : System.Attribute
    {
        public CodeCleanupProfileAttribute(string profile) { }
        public string Profile { get; }
    }
    [NUnit.Framework.CategoryAttribute("Code Cleanup")]
    public abstract class CodeCleanupTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected CodeCleanupTestBase() { }
        protected virtual bool ProcessAllFiles { get; }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected void DoTestFilesWithProfile(string profileName, params string[] testFiles) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupSettingsComponent codeCleanupSettings, JetBrains.TextControl.ITextControl textControl) { }
        protected class CustomProfilePathCookie : System.IDisposable
        {
            public CustomProfilePathCookie(JetBrains.ReSharper.FeaturesTestFramework.CodeCleanup.CodeCleanupTestBase test, JetBrains.Util.FileSystemPath newValue) { }
            public void Dispose() { }
        }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.Completion
{
    
    [NUnit.Framework.CategoryAttribute("Code Completion")]
    [NUnit.Framework.TestFixtureAttribute()]
    public abstract class CodeCompletionTypingTestBase<TKey, TAutopopupKey> : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    
    
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected abstract System.Linq.Expressions.Expression<System.Func<TAutopopupKey, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType>> GetAutopopupType();
        protected abstract System.Linq.Expressions.Expression<System.Func<TKey, bool>> GetCompleteOnSpaceSetting();
        protected abstract System.Linq.Expressions.Expression<System.Func<TKey, string>> GetDoNotCompleteOnSetting();
    }
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "System.dll",
            "System.Core.dll",
            "Microsoft.VisualBasic.dll",
            "System.Xml.Linq.dll",
            "System.Xml.dll"})]
    public abstract class VBCodeCompletionTestBase : JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.CodeCompletion.CodeCompletionTestBase
    {
        protected override bool ExecuteAction { get; }
        protected override System.Action BeforeTestStart(JetBrains.ProjectModel.IProject testProject, string documentText) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.Daemon
{
    
    [NUnit.Framework.CategoryAttribute("Daemon")]
    public abstract class IdentifierTooltipTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected override void DoTestFiles(params string[] testFiles) { }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.LiveTemplates
{
    
    public class static HotspotTestEx
    {
        public static void AcceptLookupItem(this JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hotspot, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem) { }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.TodoItems
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public sealed class TodoManagerTest : JetBrains.ReSharper.Feature.Services.TodoItems.TodoManager, JetBrains.ReSharper.Psi.Caches.ICache
    {
        public TodoManagerTest(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Settings.Cache.SettingsCacheManager settingsCachManager, JetBrains.Application.Settings.ISettingsStore settingStore, JetBrains.ReSharper.Feature.Services.TodoItems.TodoPatternStorage patternStorage, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.LanguageManager languageManager, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager) { }
        protected override void OnUpdated() { }
        public void SyncUpdate(bool underTransaction) { }
    }
}
namespace JetBrains.ReSharper.FeaturesTestFramework.Utils
{
    
    public class static TestCookies
    {
        public static void WithDefaultNamespace(string defaultNamespace, JetBrains.ProjectModel.IProject project, System.Action action) { }
        public static void WithProvideNamespace(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, bool>> provideNamespaceValue, JetBrains.ProjectModel.IProject project, System.Action action) { }
    }
}
namespace JetBrains.ReSharper.HtmlTests.CodeCompletion
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestAspAttribute(new string[0])]
    public abstract class WebCodeCompletionTestBase : JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.CodeCompletion.CodeCompletionTestBase
    {
        public override string ProjectBasePath { get; }
        protected override System.Action BeforeTestStart(JetBrains.ProjectModel.IProject testProject, string documentText) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected virtual void PrepareForTests() { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.Tests.ContextActions
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestAspAttribute(new string[0])]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".aspx")]
    [NUnit.Framework.CategoryAttribute("ASP.NET")]
    public abstract class AspContextActionAvailabilityTestBase<T> : JetBrains.ReSharper.Intentions.Html.Tests.ContextActions.HtmlContextActionAvailabilityTestBase<T>
        where T :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected override string RootDir { get; }
        protected override JetBrains.ReSharper.TestFramework.CaretPositionsProcessor CreateCaretPositionProcessor(JetBrains.Util.FileSystemPath temporaryDirectory) { }
    }
    public class static AspContextActionExecuteTestBase
    {
        public const string RootDir = "ASP";
    }
    [JetBrains.ReSharper.PsiTests.Asp.TestAspAttribute(new string[0])]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".aspx")]
    [NUnit.Framework.CategoryAttribute("ASP.NET")]
    public abstract class AspContextActionExecuteTestBase<T> : JetBrains.ReSharper.Intentions.Html.Tests.ContextActions.HtmlContextActionExecuteTestBase<T>
        where T :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected override string RootDir { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.Tests.QuickFixes
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestAspAttribute(new string[0])]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".aspx")]
    [NUnit.Framework.CategoryAttribute("ASP.NET")]
    public abstract class AspQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.Intentions.Html.Tests.QuickFixes.HtmlQuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override string RootDir { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.QuickFixes.Tests
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".cs")]
    public abstract class CSharpQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.IntentionsTests.QuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual JetBrains.ReSharper.Psi.CSharp.CSharpLanguageLevel GetLanguageLevel() { }
        protected override void OnQuickFixNotAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix action) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.Test
{
    
    [JetBrains.ReSharper.TestFramework.TestNetFramework4Attribute()]
    public abstract class CSharpContextActionAvailabilityTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase
    {
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider);
    }
    [JetBrains.ReSharper.TestFramework.TestNetFramework4Attribute()]
    public abstract class CSharpContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider);
    }
}
namespace JetBrains.ReSharper.Intentions.CSS.Tests.ContextActions
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".css")]
    [NUnit.Framework.CategoryAttribute("CSS")]
    public abstract class CssContextActionAvailabilityTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider);
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".css")]
    [NUnit.Framework.CategoryAttribute("CSS")]
    public abstract class CssContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider);
    }
}
namespace JetBrains.ReSharper.Intentions.Html.Tests.ContextActions
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".html")]
    [NUnit.Framework.CategoryAttribute("HTML")]
    public abstract class HtmlContextActionAvailabilityTestBase<T> : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase
        where T :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public override string ProjectBasePath { get; }
        protected override string RelativeTestDataPath { get; }
        protected virtual string RootDir { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".html")]
    [NUnit.Framework.CategoryAttribute("HTML")]
    public abstract class HtmlContextActionExecuteTestBase<T> : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
        where T :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public override string ProjectBasePath { get; }
        protected override string RelativeTestDataPath { get; }
        protected virtual string RootDir { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void DoTestSolution(JetBrains.ReSharper.TestFramework.NamedPositionsProcessor positionsProcessor) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Html.Tests.QuickFixes
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".html")]
    [NUnit.Framework.CategoryAttribute("HTML")]
    public abstract class HtmlBulbActionTestBase<TAction> : JetBrains.ReSharper.IntentionsTests.BulbActionTestBase<TAction>
    
    {
        protected override bool CheckAllFiles { get; }
        public override string ProjectBasePath { get; }
        protected override string RelativeTestDataPath { get; }
        protected virtual string RootDir { get; }
        protected override void OnNoQuickFix(JetBrains.TextControl.ITextControl textControl) { }
        protected override void OnQuickFixNotAvailable(JetBrains.TextControl.ITextControl textControl, TAction action) { }
    }
    public abstract class HtmlQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.Intentions.Html.Tests.QuickFixes.HtmlBulbActionTestBase<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override JetBrains.ReSharper.Intentions.Extensibility.IQuickFix CreateQuickFix(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteAllTexts(JetBrains.ReSharper.Intentions.Extensibility.IQuickFix fix) { }
        protected override void ExecuteQuickFix(JetBrains.ProjectModel.IProject testProject, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix fix) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Intentions.Extensibility.IQuickFix fix) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.Tests.ContextActions
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".js")]
    [NUnit.Framework.CategoryAttribute("JS")]
    public abstract class JavaScriptContextActionAvailabilityTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider);
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".js")]
    [NUnit.Framework.CategoryAttribute("JS")]
    public abstract class JavaScriptContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider);
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".js")]
    [NUnit.Framework.CategoryAttribute("JS")]
    public abstract class JavaScriptContextActionSelectionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionSelectionExecuteTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider);
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.Tests.QuickFixesTests
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".js")]
    [NUnit.Framework.CategoryAttribute("JS")]
    public abstract class JavaScriptQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.IntentionsTests.QuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix { }
}
namespace JetBrains.ReSharper.Intentions.Razor.Tests.ContextActions
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestMvc3Attribute(new string[0])]
    [NUnit.Framework.CategoryAttribute("Razor")]
    public abstract class RazorContextActionAvailabilityTestBase<T> : JetBrains.ReSharper.Intentions.Html.Tests.ContextActions.HtmlContextActionAvailabilityTestBase<T>
        where T :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected override string RootDir { get; }
    }
    public class static RazorContextActionExecuteTestBase
    {
        public const string RootDir = "Razor";
    }
    [JetBrains.ReSharper.PsiTests.Asp.TestRazorAttribute(new string[0])]
    [NUnit.Framework.CategoryAttribute("Razor")]
    public abstract class RazorContextActionExecuteTestBase<T> : JetBrains.ReSharper.Intentions.Html.Tests.ContextActions.HtmlContextActionExecuteTestBase<T>
        where T :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected override string RootDir { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.Razor.Tests.QuickFixes
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestMvc3Attribute(new string[0])]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".cshtml")]
    [NUnit.Framework.CategoryAttribute("Razor")]
    public abstract class RazorCSharpQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.Tests.CSharpQuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override bool CheckAllFiles { get; }
        protected override bool DumpTooltips { get; }
        protected override bool FailTestIfCheckFails { get; }
        public override string ProjectBasePath { get; }
        protected override string RelativeTestDataPath { get; }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
    [JetBrains.ReSharper.PsiTests.Asp.TestMvc3Attribute(new string[0])]
    [NUnit.Framework.CategoryAttribute("Razor")]
    public abstract class RazorQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.Intentions.Html.Tests.QuickFixes.HtmlQuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected abstract JetBrains.ProjectModel.Properties.ProjectLanguage ProjectLanguage { get; }
        protected override string RootDir { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override string[] ModifyTestFiles(string[] testFiles) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Test
{
    
    public class static BulbMenuTestUtil
    {
        public static void ExecuteAllTextsInMenu(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> intentionActions) { }
    }
    public abstract class ContextActionAvailabilityTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase<JetBrains.ReSharper.Intentions.Extensibility.IContextAction>
    {
        protected override System.Collections.Generic.IEnumerable<string> GetItemTexts(JetBrains.ReSharper.Intentions.Extensibility.IContextAction action) { }
        protected override bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.Extensibility.IContextAction action, JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class ContextActionAvailabilityTestBase<T> : JetBrains.ReSharper.Intentions.Test.ContextActionTestBase<T>
        where T :  class
    {
        protected void CheckPositions(System.Func<T> actionCreator, JetBrains.ReSharper.TestFramework.ParameterizedCaretPosition[] caretPositions, JetBrains.TextControl.ITextControl control, JetBrains.ProjectModel.ISolution solution, bool expectedPosition) { }
        protected abstract System.Collections.Generic.IEnumerable<string> GetItemTexts(T action);
        protected virtual void InitTextControl(JetBrains.TextControl.ITextControl control, JetBrains.ReSharper.TestFramework.CaretPosition position) { }
        protected virtual void OnActionAvailable(T action, int offset, JetBrains.TextControl.ITextControl control) { }
        protected override void ProcessAction(System.Func<T> action, JetBrains.TextControl.ITextControl control, JetBrains.ProjectModel.ISolution solution) { }
    }
    public abstract class ContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionTestBase
    {
        protected virtual bool DoDumpRanges { get; }
        protected virtual System.Text.Encoding OutputEncoding { get; }
        protected virtual void ExecuteItem(JetBrains.TextControl.ITextControl control, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction item, JetBrains.ProjectModel.ISolution solution) { }
        protected virtual string InitTextControl(JetBrains.TextControl.ITextControl control) { }
        protected override void ProcessAction(System.Func<JetBrains.ReSharper.Intentions.Extensibility.IContextAction> actionCreator, JetBrains.TextControl.ITextControl control, JetBrains.ProjectModel.ISolution solution) { }
        protected virtual void ProcessHotspot([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl control, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hostspot) { }
        protected virtual JetBrains.ReSharper.Intentions.Extensibility.IBulbAction SelectItem(JetBrains.ReSharper.Intentions.Extensibility.IContextAction action, string attr) { }
        protected virtual void WriteCodeBehind(JetBrains.DocumentModel.IDocument document, System.IO.TextWriter sw) { }
    }
    public abstract class ContextActionSelectionAvailabilityTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase
    {
        protected override void InitTextControl(JetBrains.TextControl.ITextControl control, JetBrains.ReSharper.TestFramework.CaretPosition position) { }
    }
    public abstract class ContextActionSelectionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override string InitTextControl(JetBrains.TextControl.ITextControl control) { }
    }
    [System.ComponentModel.LocalizableAttribute(false)]
    public abstract class ContextActionTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionTestBase<JetBrains.ReSharper.Intentions.Extensibility.IContextAction>
    {
        protected virtual bool DumpCaretPosition { get; }
        protected virtual bool DumpSelection { get; }
        protected override bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Intentions.Extensibility.IContextAction action, JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void ProcessDumpData(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "mscorlib.dll",
            "System.dll",
            "System.Data.dll",
            "System.Core.dll",
            "System.Xml.dll",
            "System.Data.Entity.dll",
            "Microsoft.CSharp.dll",
            "AsyncCtpLibrary.dll",
            "%PRODUCT%\\JetBrains.Annotations.dll"})]
    [System.ComponentModel.LocalizableAttribute(false)]
    public abstract class ContextActionTestBase<T> : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
        where T :  class
    {
        protected System.Collections.Generic.IEnumerable<string> AdditionalFileNames { get; }
        protected JetBrains.ProjectModel.IProject CurrentProject { get; set; }
        protected abstract string ExtraPath { get; }
        protected JetBrains.Util.FileSystemPath FilePath { get; }
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.TestFramework.CaretPositionsProcessor CreateCaretPositionProcessor(JetBrains.Util.FileSystemPath temporaryDirectory) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract T CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected JetBrains.ReSharper.TestFramework.CaretPosition GetCaretPosition(out string attr) { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.TestFramework.ParameterizedCaretPosition> GetNamedPosition(string positionName) { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.TestFramework.ParameterizedCaretPosition> GetOffPosition() { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.TestFramework.ParameterizedCaretPosition> GetOnPosition() { }
        protected virtual JetBrains.ProjectModel.IProjectFile GetProjectFile(JetBrains.ProjectModel.IProject testProject) { }
        protected JetBrains.ReSharper.Intentions.Extensibility.IContextAction InstantiateAction<TAction>(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl)
            where TAction :  class, JetBrains.ReSharper.Intentions.Extensibility.IContextAction { }
        protected abstract bool IsAvailable(T action, JetBrains.TextControl.ITextControl textControl);
        protected override string[] ModifyTestFiles(string[] testFiles) { }
        protected abstract void ProcessAction(System.Func<T> action, JetBrains.TextControl.ITextControl control, JetBrains.ProjectModel.ISolution solution);
    }
    [NUnit.Framework.CategoryAttribute("QuickFixes")]
    public abstract class QuickFixAvailabilityTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected void DoNamedTest(System.Func<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix, bool> quickFixPredicate) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual bool HighlightingPredicate(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.Tests.ContextActions
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".vb")]
    public abstract class VBContextActionAvailabilityTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionAvailabilityTestBase
    {
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider);
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".vb")]
    public abstract class VBContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider);
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.Tests.QuickFixes
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".vb")]
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "Microsoft.VisualBasic.dll"}, Inherits=true)]
    public abstract class VBQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.IntentionsTests.QuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override string RelativeTestDataPath { get; }
    }
}
namespace JetBrains.ReSharper.IntentionsTests
{
    
    [JetBrains.ReSharper.TestFramework.TestReferencesAttribute(new string[] {
            "System.Core.dll",
            "System.dll"})]
    public abstract class BulbActionTestBase<TAction> : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    
    {
        protected const string NO_HIGHLIGHTINGS_FOUND_ERROR = "No error highlightings found for QuickFix";
        protected virtual bool CheckAllFiles { get; }
        protected virtual bool DumpCaretPosition { get; }
        protected virtual bool DumpLookupList { get; }
        protected virtual bool DumpSelection { get; }
        protected virtual bool DumpTooltips { get; }
        protected virtual bool ProcessHotspots { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual System.Action BeforeTestStarted(JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected virtual void CheckBeforeSave([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract TAction CreateQuickFix(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl);
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected abstract void ExecuteAllTexts(TAction fix);
        protected abstract void ExecuteQuickFix(JetBrains.ProjectModel.IProject testProject, JetBrains.TextControl.ITextControl textControl, TAction fix);
        protected virtual System.Func<System.Collections.Generic.IList<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction>, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> GetBulbItemSelector(JetBrains.TextControl.ITextControl textControl) { }
        protected JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetCustomWarningAction(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, bool> filter) { }
        protected virtual int GetPartSelectionNumber() { }
        protected abstract bool IsAvailable(TAction fix);
        protected virtual void OnNoQuickFix(JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void OnQuickFixNotAvailable(JetBrains.TextControl.ITextControl textControl, TAction action) { }
        protected virtual void ProcessHotspot(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hostspot) { }
        protected JetBrains.ReSharper.Daemon.IHighlighting RunErrorFinder(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl, System.Type type, JetBrains.ReSharper.Daemon.DaemonProcessKind highlightingKind = 0) { }
        protected THighlighting RunErrorFinder<THighlighting>(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Daemon.DaemonProcessKind highlightingKind = 0)
            where THighlighting :  class, JetBrains.ReSharper.Daemon.IHighlighting { }
        protected JetBrains.ReSharper.Daemon.HighlightingInfo RunErrorInfoFinder<THighlighting>(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Daemon.DaemonProcessKind highlightingKind = 0, System.Predicate<JetBrains.ReSharper.Daemon.HighlightingInfo> filter = null)
            where THighlighting :  class, JetBrains.ReSharper.Daemon.IHighlighting { }
        protected class ErrorFinder<TAction> : JetBrains.ReSharper.IntentionsTests.BulbActionTestBase<TAction>.ErrorFinder<JetBrains.ReSharper.Daemon.IHighlighting>
        
        {
            public ErrorFinder(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile item, JetBrains.ReSharper.Daemon.DaemonProcessKind highlightingKind, System.Type quickFixType) { }
            protected override bool ErrorFound(JetBrains.ReSharper.Daemon.HighlightingInfo highlightingInfo) { }
        }
        protected class ErrorFinder<TAction, T> : JetBrains.ReSharper.Daemon.Test.TestDaemonProcess
        
            where T :  class, JetBrains.ReSharper.Daemon.IHighlighting
        {
            public ErrorFinder(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile item, JetBrains.ReSharper.Daemon.DaemonProcessKind highlightingKind, System.Predicate<JetBrains.ReSharper.Daemon.HighlightingInfo> filter = null) { }
            public JetBrains.ReSharper.Daemon.HighlightingInfo Error { get; }
            public override void CommitHighlighters(JetBrains.ReSharper.Daemon.Impl.DaemonProcessBase.DaemonCommitContext context) { }
            public void DoHighlighting() { }
            protected virtual bool ErrorFound(JetBrains.ReSharper.Daemon.HighlightingInfo highlightingInfo) { }
            protected virtual bool Proceed() { }
        }
    }
    [NUnit.Framework.CategoryAttribute("QuickFixes")]
    public abstract class QuickFixTestBase<TQuickFix> : JetBrains.ReSharper.IntentionsTests.BulbActionTestBase<JetBrains.ReSharper.Intentions.Extensibility.IQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override JetBrains.ReSharper.Intentions.Extensibility.IQuickFix CreateQuickFix(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteAllTexts(JetBrains.ReSharper.Intentions.Extensibility.IQuickFix fix) { }
        protected override void ExecuteQuickFix(JetBrains.ProjectModel.IProject testProject, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix fix) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Intentions.Extensibility.IQuickFix fix) { }
    }
}
namespace JetBrains.ReSharper.IntentionsTests.Xaml
{
    
    [JetBrains.ReSharper.PsiTests.Xaml.TestWPF30Attribute(new string[0])]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".xaml")]
    public abstract class XamlContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider solution) { }
    }
    [JetBrains.ReSharper.PsiTests.Xaml.TestWPF30Attribute(new string[0])]
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".xaml")]
    public abstract class XamlQuickFixTestBase<TQuickFix> : JetBrains.ReSharper.IntentionsTests.QuickFixTestBase<TQuickFix>
        where TQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected override string RelativeTestDataPath { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override string[] ModifyTestFiles(string[] testFiles) { }
        protected override void OnNoQuickFix(JetBrains.TextControl.ITextControl textControl) { }
        protected override void OnQuickFixNotAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix quickFix) { }
    }
}
namespace JetBrains.ReSharper.IntentionsTests.Xml
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".xaml")]
    public abstract class XmlContextActionExecuteTestBase : JetBrains.ReSharper.Intentions.Test.ContextActionExecuteTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected virtual JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.ReSharper.Intentions.Extensibility.IContextAction CreateContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider context);
    }
}
namespace JetBrains.ReSharper.LiveTemplatesTests.Macros
{
    
    public abstract class MacroImplTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected abstract JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementation GetMacro(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew> parameters);
    }
}
namespace JetBrains.ReSharper.RazorTests.CodeCompletion
{
    
    [JetBrains.ReSharper.PsiTests.Asp.TestRazorAttribute(new string[0])]
    [NUnit.Framework.CategoryAttribute("Razor")]
    public abstract class RazorCodeCompletionTestBase : JetBrains.ReSharper.HtmlTests.CodeCompletion.WebCodeCompletionTestBase
    {
        protected override void PrepareForTests() { }
    }
}
namespace JetBrains.ReSharper.Refactorings
{
    
    [NUnit.Framework.CategoryAttribute("Refactoring")]
    public abstract class RefactoringTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected JetBrains.ReSharper.Refactorings.WorkflowNew.IRefactoringConfiguration Configuration { get; }
        protected virtual JetBrains.ReSharper.Refactorings.WorkflowNew.IRefactoringConfiguration CreateInitialConfiguration() { }
        protected virtual void ProcessRefactoringTransactionResult(JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringTransactionResult result) { }
        protected abstract class StandardTestExecutorBase : JetBrains.ReSharper.Refactorings.WorkflowNew.SimpleWorkflowHost
        {
            protected StandardTestExecutorBase(JetBrains.ReSharper.Refactorings.RefactoringTestBase test) { }
            protected JetBrains.ProjectModel.ISolution Solution { get; }
            protected virtual void AdditionalTestChecks(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.IProject testProject) { }
            protected virtual void AdditionalWorkflowTestChecks(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow workflow, JetBrains.TextControl.ITextControl control, JetBrains.Application.DataContext.IDataContext context) { }
            public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateConflictsPage(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult conflicts) { }
            [JetBrains.Annotations.NotNullAttribute()]
            protected abstract JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow CreateRefactoringWorkflow(JetBrains.TextControl.ITextControl textControl, JetBrains.Application.DataContext.IDataContext context);
            public void ExecuteTest(JetBrains.ProjectModel.IProject testProject) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            protected static string GetSetting(JetBrains.TextControl.ITextControl textControl, string name) { }
            protected abstract void PreparePage(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage refactoringPage, JetBrains.TextControl.ITextControl textControl);
            protected virtual System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> ProvideContextData(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
            public override bool ShowPage(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage page, bool hasBack) { }
        }
    }
}
namespace JetBrains.ReSharper.StructuralSearchTests.CSharp
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".cs")]
    public abstract class CSharpStructuralSearchBaseTest : JetBrains.ReSharper.StructuralSearchTests.StructuralSearchBaseTest
    {
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        protected override string RelativeTestDataPath { get; }
        protected void TestOnePattern(string pattern, string filename = null, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams params = null, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        protected void TestOnePattern(string pattern, string filename, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        protected void TestOnePattern(string pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        protected void TestOnePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
    }
}
namespace JetBrains.ReSharper.StructuralSearchTests.Css
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".html")]
    public abstract class CssStructuralSearchBaseTest : JetBrains.ReSharper.StructuralSearchTests.StructuralSearchBaseTest
    {
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override void PrintHeader(System.IO.TextWriter output) { }
        protected void TestOnePattern(string pattern, string filename = null, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams params = null, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
    }
}
namespace JetBrains.ReSharper.StructuralSearchTests.Html
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".html")]
    public abstract class HtmlStructuralSearchBaseTest : JetBrains.ReSharper.StructuralSearchTests.StructuralSearchBaseTest
    {
        protected static readonly JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams NON_SMART_PARAMS;
        protected static readonly JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams SMART_PARAMS;
        protected static readonly JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams SMART_PARAMS_NO_IGNORE;
        protected HtmlStructuralSearchBaseTest() { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected override void PrintHeader(System.IO.TextWriter output) { }
        protected void TestOnePattern(string pattern, string filename = null, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams params = null, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
    }
}
namespace JetBrains.ReSharper.StructuralSearchTests
{
    
    public abstract class MultipleStructuralSearchPatternHighlightingBaseTest : JetBrains.ReSharper.StructuralSearchTests.StructuralSearchBaseTest
    {
        protected MultipleStructuralSearchPatternHighlightingBaseTest() { }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        protected void AddPattern<TLanguage>(string pattern, bool matchSimilar = True, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders)
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern> GetPatterns() { }
        public override void SetUp() { }
    }
    [NUnit.Framework.CategoryAttribute("Structural Search")]
    public abstract class StructuralSearchAndReplaceBaseTest : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject
    {
        protected abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
    }
    [NUnit.Framework.CategoryAttribute("Structural Search")]
    public abstract class StructuralSearchBaseTest : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject
    {
        protected abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        public override string ProjectBasePath { get; }
        protected override string TestName { get; }
        protected void DoHighlightingTest(JetBrains.ProjectModel.IProject testProject) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern> GetPatterns() { }
        protected virtual void PrintHeader(System.IO.TextWriter output) { }
        public class StructuralSearchTestDaemonProcess : JetBrains.ReSharper.Daemon.Test.TestDaemonProcess
        {
            public StructuralSearchTestDaemonProcess(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
            public override void CommitHighlighters(JetBrains.ReSharper.Daemon.Impl.DaemonProcessBase.DaemonCommitContext context) { }
            public void Dump(System.IO.TextWriter textWriter) { }
        }
    }
}
namespace JetBrains.ReSharper.StructuralSearchTests.VB
{
    
    [JetBrains.ReSharper.TestFramework.TestFileExtensionAttribute(".vb")]
    public abstract class VBStructuralSearchBaseTest : JetBrains.ReSharper.StructuralSearchTests.StructuralSearchBaseTest
    {
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        protected void TestOnePattern(string pattern, string filename, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams params = null, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        protected void TestOnePattern(string pattern, string filename, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
        protected void TestOnePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders) { }
    }
}
namespace JetBrains.ReSharper.TodoExplorer.Tests
{
    
    [NUnit.Framework.CategoryAttribute("TODO")]
    public abstract class TodoHighlightingTestBase : JetBrains.ReSharper.Daemon.Test.HighlightingTestBase
    {
        protected override string RelativeTestDataPath { get; }
        protected override JetBrains.ReSharper.Daemon.Test.TestHighlightingDumper CreateHighlightDumper(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.TextWriter writer) { }
    }
}