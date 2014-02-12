[assembly: JetBrains.Util.TestDataPathBaseAttribute("Platform\\test\\data")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Application.Test
{
    
    [NUnit.Framework.TestFixtureAttribute()]
    [System.ComponentModel.LocalizableAttribute(false)]
    public abstract class BaseTestNoShell
    {
        protected const string GoldFileNameSuffix = ".gold";
        protected const string ResultFileNameSuffix = ".tmp";
        protected BaseTestNoShell() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath BaseTestDataPath { get; }
        protected virtual bool FailTestIfCheckFails { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual string RelativeTestDataPath { get; }
        protected virtual bool RunFinalizersOnTestFixtureTearDown { get; }
        [System.ObsoleteAttribute("Use TestDataPath2, which will be renamed to TestDataPath when ready.")]
        protected string TestDataPath { get; }
        public JetBrains.Util.FileSystemPath TestDataPath2 { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual System.Reflection.MethodBase TestMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected string TestMethodName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected string TestMethodName2 { get; }
        protected static JetBrains.Util.FileSystemPath UnitTestsRootTempFolder { get; }
        public static void AssertReentrancyGuardIsClean(JetBrains.Threading.ReentrancyGuard guard) { }
        protected string CopyTestDataDirectoryToTemp(JetBrains.DataFlow.Lifetime lifetime, string relativeTestDirectoryPath) { }
        protected JetBrains.Util.FileSystemPath CopyTestDataDirectoryToTemp2(JetBrains.DataFlow.Lifetime lifetime, string relativeTestDirectoryPath) { }
        protected virtual void DoNamedTest() { }
        protected virtual void DoNamedTest2() { }
        protected virtual void DoOneTest(string testName) { }
        protected JetBrains.Util.TestFailureException ExecuteWithGold([JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test) { }
        public JetBrains.Util.TestFailureException ExecuteWithGold(string testName, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test, bool caseSensitive = True, System.Text.Encoding encoding = null, bool fullDiff = False) { }
        protected JetBrains.Util.TestFailureException ExecuteWithSpecifiedGold(JetBrains.Util.FileSystemPath goldPath, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test, bool caseSensitive = True, System.Text.Encoding encoding = null, bool fullDiff = False) { }
        [System.ObsoleteAttribute()]
        protected JetBrains.Util.TestFailureException ExecuteWithSpecifiedGold(JetBrains.Util.FileSystemPath goldPath, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test, System.Func<string, string, bool> goldLineEqualsFunc, System.Text.Encoding encoding = null) { }
        protected string[] ExpandRelativePaths(System.Collections.Generic.IEnumerable<string> testDataFiles) { }
        protected virtual string GetGoldTestDataPath(string fileName) { }
        protected JetBrains.Util.FileSystemPath GetGoldTestDataPath2(string fileName) { }
        protected virtual string GetRuntimeEnvironmentVersionForGoldTestData() { }
        protected string GetTestDataFilePath(string shortName) { }
        public JetBrains.Util.FileSystemPath GetTestDataFilePath2(string shortName) { }
        protected virtual void OnDataDifferentFromGoldFile(JetBrains.Util.TestFailureException e) { }
        [NUnit.Framework.SetUpAttribute()]
        public virtual void SetUp() { }
        protected virtual void SetUpInternal() { }
        protected virtual void StartCollectingExceptions() { }
        protected virtual void StopCollectingExceptions() { }
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TearDown() { }
        protected virtual void TearDownInternal() { }
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void TestFixtureSetUp() { }
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void TestFixtureTearDown() { }
        protected void WithExceptionsAllowed([JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
    }
}
namespace JetBrains.TestFramework.Components.ActivityTracking
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ActivityTrackingTestSettings : JetBrains.Application.ActivityTrackingNew.ActivityTrackingSettings
    {
        public ActivityTrackingTestSettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Communication.WebProxySettingsReader proxySettings, JetBrains.Application.Settings.ISettingsStore store, JetBrains.Threading.IThreading threading) { }
        public override System.TimeSpan DumpLogsInterval { get; }
        public override System.TimeSpan SubmitLogsInterval { get; }
    }
}
namespace JetBrains.TestFramework.Utils
{
    
    public class static LineByLineDiff
    {
        public static Item[] DiffInt(int[] ArrayA, int[] ArrayB) { }
        public static Item[] DiffText(string TextA, string TextB) { }
        public static Item[] DiffText(string TextA, string TextB, bool trimSpace, bool ignoreSpace, bool ignoreCase) { }
        public struct Item
        {
            public int deletedA;
            public int insertedB;
            public int StartA;
            public int StartB;
        }
    }
    public class PartCatalogueDumper
    {
        public PartCatalogueDumper(System.IO.TextWriter writer) { }
        public void Dump(JetBrains.Application.Parts.IPartsCatalogue partsCatalogue) { }
    }
    public class static TestAssemblies
    {
        public static readonly string PackagesFolderName;
        public static readonly string PluginRootMarkerFile;
        public static readonly string ProductHomeDirMarkerFile;
        public static readonly string TestAssembliesFolderName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetTestAssembliesPath() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath TryGetTestAssembliesPath() { }
    }
}
namespace JetBrains.Tests
{
    
    public class TestRandom : System.Random
    {
        public const int Seed = 239;
        public TestRandom(int seed) { }
        public TestRandom() { }
        public static JetBrains.Tests.TestRandom CreateWithRandomSeed() { }
        public System.Collections.IEnumerable GetRandomValues(System.Type type, int randomTryIterations) { }
        public System.Collections.Generic.IEnumerable<T> GetRandomValues<T>(int randomTryIterations) { }
        public System.Collections.Generic.IEnumerable<T> GetRandomValues<T>() { }
        public override int Next(int minValue, int maxValue) { }
        public override int Next(int maxValue) { }
        public double Next01() { }
        public bool NextBool() { }
        public System.Drawing.Color NextColor() { }
        public T NextEnum<T>() { }
        public System.Guid NextGuid() { }
        public long NextInt64() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath NextPath() { }
        public JetBrains.UI.RichText.RichText NextRichText(int min, int max, out string text) { }
        public JetBrains.UI.RichText.RichText NextRichText(int min, int max) { }
        public JetBrains.UI.RichText.RichText NextRichText(int max) { }
        public System.Drawing.Size NextSize(int min, int max) { }
        public System.Drawing.Size[] NextSizes(int minLen, int maxLen, int minDim, int maxDim) { }
        public string NextString(int min, int max) { }
        public string NextString() { }
        public string NextStringAlphanumeric(int min, int max) { }
        public string NextStringAlphanumeric() { }
        public JetBrains.UI.RichText.TextStyle NextTextStyle() { }
        public void Repeat(bool nullable, System.Action<string> action) { }
        public void Repeat(System.Action<int> action) { }
        public void Repeat<T>([JetBrains.Annotations.NotNullAttribute()] System.Action<T> action) { }
        public void RepeatPush<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T, System.IDisposable> action) { }
    }
}
namespace JetBrains.TestShell.Components
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileSystemTrackerTestImpl : JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl
    {
        public FileSystemTrackerTestImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.RunsProducts.ProductConfigurations conf = null) { }
        public new void ClearChanges() { }
        public bool HasChange(JetBrains.Util.FileSystemPath path) { }
        public void SimulateEventsBufferOverflow(JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie root) { }
        public void WaitForChangesIn(JetBrains.Util.FileSystemPath path) { }
    }
    public interface IFixtureTearDown
    {
        void FixtureTearDown();
    }
    public interface ITearDown
    {
        void TearDown();
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Product, JetBrains.Application.Lifecycle.Container, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.None)]
    public class TearDownComponents
    {
        public TearDownComponents(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.TestShell.Components.ITearDown> teardowns, System.Collections.Generic.IEnumerable<JetBrains.Application.IObsoleteTearDown> obsoleteteardowns, System.Collections.Generic.IEnumerable<JetBrains.TestShell.Components.IFixtureTearDown> fixtureTeardowns, JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void FixtureTearDownUnguarded() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void TearDownUnguarded() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplHostCulture : JetBrains.Application.HostCulture
    {
        public override System.Globalization.CultureInfo Culture { get; }
    }
}
namespace JetBrains.TestShell.Components.Mode
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class AsyncBehaviorProhibited
    {
        public AsyncBehaviorProhibited([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        public void SetAsyncBehaviorAllowed([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class LogToDebugStream
    {
        public LogToDebugStream() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class TestMessageBoxHandler
    {
        public TestMessageBoxHandler(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class WakeUpDispatcherThreadsPeriodically
    {
        public WakeUpDispatcherThreadsPeriodically(JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.TestShell.Components.Settings
{
    
    public class Foo : JetBrains.TestShell.Components.Settings.IFoo
    {
        public Foo(string id) { }
        public string Id { get; set; }
        public bool Equals(JetBrains.TestShell.Components.Settings.Foo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [System.Windows.Markup.ValueSerializerAttribute(typeof(JetBrains.TestShell.Components.Settings.IFooSerializer))]
    public interface IFoo
    {
        string Id { get; }
    }
    public class IFooSerializer : JetBrains.Util.Reflection.ValueSerializerBase<JetBrains.TestShell.Components.Settings.IFoo>
    {
        public IFooSerializer() { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.None)]
    public class SuppressDiskStorages : JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior.IFileSettingsStorageBehaviorProvider
    {
        public bool QueryEditFile(JetBrains.Util.FileSystemPath path) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.TestShell.Components.Settings.TestSettingsRoot), "OneToSetMap", typeof(string))]
    public class TestOneToSetMapSetting
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Values")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<int, bool> Values;
        public static void AssertGetWithoutSet(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertInterfaces(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertKeys(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertRemoveIndex(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertRemoveOne(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetGet(JetBrains.Application.Settings.ISettingsStore store) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.TestShell.Components.Settings.TestSettingsRoot), "Test Schema Key A.")]
    public class TestSettingsKeyA
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Interface test")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<JetBrains.TestShell.Components.Settings.IFoo, bool> Interfaces;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Maps IDS to Paths.")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<int, string> MapIdsToNames;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Maps names to counts.")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, int> NameToCountMap;
        [JetBrains.Application.Settings.SettingsEntryAttribute("1:0:0", "Some Period.", EntryNameOverride="Period2", ValueSerializer=JetBrains.Application.Settings.SettingsStoreSerializerType.XamlSerializer)]
        public System.Windows.Duration Period;
        [JetBrains.Application.Settings.SettingsEntryAttribute(5, "Test Int.")]
        public int SimpleInt;
        [JetBrains.Application.Settings.SettingsEntryAttribute("\\\\Dev\\Null", "Home directory path.")]
        public JetBrains.Util.FileSystemPath HomePath { get; set; }
        public static void AssertGetEntriesDefault(JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public static void AssertGetEntryDefault(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertGetKeyDefault(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertKeyEntries([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key) { }
        public static void AssertSetEntryThenGetEntries(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetEntryThenGetEntry(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetEntryThenGetKey(JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public static void AssertSetGetMapEntry(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetGetMapEntry2(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetGetMapEntry3(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetIndexedEntryThenEnumIndices(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetMapEntryThenGetKey(JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public static void AssessMapPerformanceInt(JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.Storage.ISettingsStorage storage) { }
        public static void AssessMapPerformanceString(JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.Storage.ISettingsStorage storage) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.TestShell.Components.Settings.TestSettingsRoot), "Enums test.")]
    public class TestSettingsKeyWithEnums
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues V;
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues V0;
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues V1;
        [JetBrains.Application.Settings.SettingsEntryAttribute(3, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues V3;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums/TestEnumValues.Zero | JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums/TestEnumValues.One, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues VOne;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums/TestEnumValues.Zero, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues VZero;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums/TestEnumValues.Zero | JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums/TestEnumValues.One | JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums/TestEnumValues.Two, "Test")]
        public JetBrains.TestShell.Components.Settings.TestSettingsKeyWithEnums.TestEnumValues VZeroOneTwo;
        public static void AssertDefaults(JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public static void AssertSetGet(JetBrains.Application.Settings.ISettingsStore store) { }
        [System.FlagsAttribute()]
        public enum TestEnumValues
        {
            Zero = 0,
            One = 1,
            Two = 2,
        }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.TestShell.Components.Settings.TestSettingsRoot), "Nullables")]
    public class TestSettingsKeyWithNullables
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Test")]
        public System.Nullable<bool> B;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Test")]
        public System.Nullable<bool> BFalse;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Test")]
        public System.Nullable<bool> BTrue;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Test")]
        public System.Nullable<int> N;
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Test")]
        public System.Nullable<int> N0;
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Test")]
        public System.Nullable<int> N1;
        public static void AssertDefaults(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetGet(JetBrains.Application.Settings.ISettingsStore store) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.TestShell.Components.Settings.TestSettingsRoot), "Test mapping key.", typeof(System.Guid))]
    public class TestSettingsMappedKeyA
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "ItemFlags")]
        public JetBrains.TestShell.Components.Settings.TestSettingsMappedKeyA.ItemFlags Flags;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "ItemName")]
        public string Name;
        public static void AssertSetEntriesInIndexedKeysThenEnumIndices(JetBrains.Application.Settings.ISettingsStore store) { }
        public static void AssertSetThenGetEntriesInIndexedKeys(JetBrains.Application.Settings.ISettingsStore store) { }
        public enum ItemFlags
        {
            Left = 0,
            Right = 1,
            Lost = 2,
            Found = 3,
        }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.TestShell.Components.Settings.TestSettingsMappedKeyA), "Test mapping key fields.", typeof(string))]
    public class TestSettingsMappedKeyAFields
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "ItemFieldValue")]
        public int Degree;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "ItemFieldName")]
        public string Name;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "ItemFieldType")]
        public string Type;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "ItemFieldValue")]
        public string Value;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Test Schema Root.")]
    public class TestSettingsRoot { }
}
namespace JetBrains.TestShell.Infra.AssemblyScope
{
    
    public abstract class PlatformTestEnvironmentAssembly : JetBrains.TestShell.Infra.AssemblyScope.TestEnvironmentAssembly
    {
        public override bool IsRunningTestsWithAsyncBehaviorProhibited { get; }
        public override JetBrains.Application.IApplicationDescriptor CreateApplicationDescriptor() { }
    }
    public abstract class TestEnvironmentAssembly
    {
        public const string PRODUCT_ENV_VAR = "PRODUCT";
        public virtual bool IsRunningTestsInInternalMode { get; }
        public virtual bool IsRunningTestsWithAsyncBehaviorProhibited { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.Application.IApplicationDescriptor CreateApplicationDescriptor();
        [NUnit.Framework.SetUpAttribute()]
        public virtual void SetUp() { }
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TearDown() { }
    }
}
namespace JetBrains.TestShell.Infra
{
    
    [NUnit.Framework.TestFixtureAttribute()]
    public abstract class BaseTest : JetBrains.Application.Test.BaseTestNoShell
    {
        public const string BASE_TEST_DATA = "%BASE_TEST_DATA%";
        protected const string PRODUCT_INSTALLATION = "%PRODUCT%";
        protected const string TEST_DATA = "%TEST_DATA%";
        protected JetBrains.Threading.IThreading InvocatorInstance { get; }
        protected JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.Application.Components.IComponentContainer ShellInstance { get; }
        public JetBrains.TestShell.Infra.BaseTest.ChangeSettingsTemporarilyCore ChangeSettingsTemporarily([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath EnsureAndCleanupTestSolutionFolder() { }
        public void ExecuteWithinSettingsTransaction(System.Action<JetBrains.Application.Settings.IContextBoundSettingsStore> action) { }
        public System.Collections.Generic.IEnumerable<TAttribute> GetAttributes<TAttribute>(bool inherit = True) { }
        public System.Collections.Generic.IEnumerable<TAttribute> GetAttributes<TAttribute>(System.Predicate<TAttribute> allowInheritPredicate) { }
        public System.Collections.Generic.IEnumerable<TAttribute> GetClassAttributes<TAttribute>(bool inherit = True) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetSetting([JetBrains.Annotations.NotNullAttribute()] string text, string settingName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetSetting([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder builder, string settingName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetSetting([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, string settingName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<string> GetSettings([JetBrains.Annotations.NotNullAttribute()] string text, string settingName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<string> GetSettings([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder builder, string settingName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<string> GetSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, string settingName) { }
        public void RunGuarded(System.Action action) { }
        public void RunWithAsyncBehaviorAllowed(System.Action F) { }
        public void SetAsyncBehaviorAllowed(JetBrains.DataFlow.Lifetime lifetime) { }
        [NUnit.Framework.SetUpAttribute()]
        public override void SetUp() { }
        protected override void StartCollectingExceptions() { }
        protected override void StopCollectingExceptions() { }
        [NUnit.Framework.TearDownAttribute()]
        public override void TearDown() { }
        public override void TestFixtureSetUp() { }
        public override void TestFixtureTearDown() { }
        public void ThrowLoggedExceptions(bool bGC) { }
        public class ChangeSettingsTemporarilyCore
        {
            [JetBrains.Annotations.UsedImplicitlyAttribute()]
            public ChangeSettingsTemporarilyCore([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection providersCollection) { }
            public JetBrains.Application.Settings.Storage.ISettingsStorageSerializable Storage { get; set; }
        }
        public class static Implementation
        {
            public static void RunWithAsyncBehaviorAllowed(JetBrains.TestShell.Components.Mode.AsyncBehaviorProhibited asyncBehaviorProhibited, System.Action F) { }
        }
    }
    public class JetTestHost : JetBrains.Application.Env.IJetHost
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.Tests.TestLoggerListener ExceptionTrap;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.CompoundException FinalExceptions;
        public const string PlatformTestsAssembliesConfiguration = "TestShell";
        public JetTestHost([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor testdescriptor, JetBrains.Application.HostCommandLine cmdline = null) { }
        public JetBrains.Application.Env.JetEnvironment Environment { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.TestShell.Infra.JetTestHost Instance { get; }
    }
    public class static SettingsTestHelpers
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.IPartsCatalogue CreateCatalogWithSettingsKey<TKeyClass>() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.IPartsCatalogue CreateCatalogWithSettingsKeys([JetBrains.Annotations.NotNullAttribute()] params System.Type[] keyclasses) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Components.IComponentContainer CreateContainerForSettingsStore([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class static TestLogger
    {
        public static string GetText() { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static void Log(string format, params object[] args) { }
        public static void Start() { }
        public static void Stop() { }
    }
}
namespace JetBrains.TestShell.Infra.FileSystemTracker
{
    
    public class static FileSystemTrackerTestUtil
    {
        public static System.IDisposable Disable(this JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        public static System.IDisposable Enable(this JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        public static System.IDisposable SetEnabled(this JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, bool state) { }
    }
}
namespace JetBrains.Util
{
    
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class TestDataPathBaseAttribute : System.Attribute
    {
        public TestDataPathBaseAttribute(string testDataPath) { }
        public string TestDataPath { get; }
    }
    public class TestFailureException : System.Exception
    {
        public TestFailureException(string reason) { }
    }
    public class static TestUtil
    {
        public const int FILE_SYSTEM_NOTIFICATION_TIMEOUT = 300;
        public static void AssertAreEqual(int[] array1, int[] array2) { }
        public static JetBrains.Util.TestFailureException CheckDataAgainstGoldFile([JetBrains.Annotations.NotNullAttribute()] byte[] testData, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathGold, bool throwOnError, [JetBrains.Annotations.NotNullAttribute()] System.Text.Encoding encoding, bool caseSensitive = True, bool fullDiff = False) { }
        [System.ObsoleteAttribute()]
        public static JetBrains.Util.TestFailureException CheckDataAgainstGoldFile([JetBrains.Annotations.NotNullAttribute()] byte[] testData, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathGold, bool throwOnError, [JetBrains.Annotations.NotNullAttribute()] System.Text.Encoding encoding, [JetBrains.Annotations.NotNullAttribute()] System.Func<string, string, bool> goldLineEqualsFunc) { }
        [System.ObsoleteAttribute()]
        public static JetBrains.Util.TestFailureException CheckTempFileAgainstGoldFile([JetBrains.Annotations.NotNullAttribute()] string testResultPath, [JetBrains.Annotations.NotNullAttribute()] string goldTestResultPath, bool caseSensitive, bool throwOnError, System.Text.Encoding encoding = null) { }
        public static JetBrains.Util.TestFailureException CheckTextAgainstGoldFile([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathGold, bool caseSensitive, bool throwOnError, System.Text.Encoding encoding = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetTestDataPathBase([JetBrains.Annotations.NotNullAttribute()] System.Reflection.Assembly assembly) { }
        public static void MakeReadOnly(params JetBrains.Util.FileSystemPath[] paths) { }
        public static void TouchFile(JetBrains.Util.FileSystemPath path) { }
    }
    [NUnit.Framework.TestFixtureAttribute()]
    public class TestWildcard
    {
        [NUnit.Framework.TestAttribute()]
        public void Tests() { }
    }
}
namespace JetBrains.Util.Tests
{
    
    public class TestException : System.ApplicationException
    {
        public TestException(string message) { }
        public static void Expect<TException>(System.Action action)
            where TException : System.Exception { }
        public static void ThrowExpectedThrow(System.Type typeException) { }
    }
    public class static TestLimits
    {
        public static readonly int MaxSize;
        public static readonly int MinSize;
        public static readonly int RandomTryIterations;
        public static readonly int RichTextBlockLines;
        public static readonly int StringLength;
        public static void Repeat(System.Action action) { }
        public static void RunInSta(System.Action action) { }
    }
    public class TestLoggerListener : JetBrains.Util.ILogEventListener, System.IDisposable
    {
        public TestLoggerListener() { }
        public TestLoggerListener([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, bool suppressExceptions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.CompoundException LoggedExceptions { get; }
        public event System.EventHandler ExceptionLogged;
        public void Dispose(bool captureFinallyExceptions) { }
        public void Dispose() { }
        public void OnError(string error) { }
        public void OnException(System.Exception ex) { }
        public void OnMessage(string message, JetBrains.Util.LoggingLevel level) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.CompoundException RecycleLoggedExceptions() { }
        public void ThrowLoggedExceptions() { }
    }
}