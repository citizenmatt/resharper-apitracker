[assembly: JetBrains.Application.CommandLineSwitchAttribute("Resume", 0)]
[assembly: JetBrains.Application.CommandLineSwitchAttribute("Suspend", 0)]
[assembly: JetBrains.Application.CommandLineSwitchAttribute("Internal", 0)]
[assembly: JetBrains.Application.CommandLineSwitchAttribute("LogLevel", 1)]
[assembly: JetBrains.Application.CommandLineSwitchAttribute("ReInit", 0)]
[assembly: JetBrains.Application.CommandLineSwitchAttribute("LogFile", 1)]
[assembly: JetBrains.Application.CommandLineSwitchAttribute("Plugin", 1)]
[assembly: JetBrains.Application.Install.InstallFileAttribute("JetNativeHooks64dll", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "x64", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "x64/JetNativeHooks.dll")]
[assembly: JetBrains.Application.Install.InstallFileAttribute("leveldb86dll", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "x86", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "x86/libleveldb.dll")]
[assembly: JetBrains.Application.Install.InstallFileAttribute("leveldb64dll", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "x64", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "x64/libleveldb.dll")]
[assembly: JetBrains.Application.Install.InstallFileAttribute("JetNativeHooks86dll", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "x86", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "x86/JetNativeHooks.dll")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:schemas-jetbrains-com:install-guid-store", "JetBrains.Application.Install.Guids")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:schemas-jetbrains-com:jetbrains-shell-extensions", "JetBrains.Application.Extensions")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:settings-storage-xaml", "JetBrains.Application.Settings.Storage.Format")]
[assembly: System.Windows.Markup.XmlnsPrefixAttribute("urn:shemas-jetbrains-com:settings-storage-xaml", "ss")]

namespace JetBrains.Application
{
    
    public enum Access
    {
        None = 0,
        PrimaryThread = 1,
        AnyThread = 2,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public sealed class AddProductIdentityToLogs
    {
        public static readonly JetBrains.DataFlow.PropertyId<System.Action<System.Text.StringBuilder>> PropExtendBuildDescription;
        public AddProductIdentityToLogs(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public static string FormatBuildDescription([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IApplicationDescriptor descriptor, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.AssemblyConfiguration> assemblyconfigurations) { }
    }
    public abstract class ApplicationDescriptor : JetBrains.Application.IApplicationDescriptor, JetBrains.Application.IProductNameAndVersion
    {
        protected ApplicationDescriptor() { }
        public abstract System.Reflection.Assembly AllAssembliesResourceAssembly { get; }
        public abstract string AllAssembliesResourceName { get; }
        public virtual JetBrains.Build.AllAssemblies.AllAssembliesXml AllAssembliesXml { get; }
        public JetBrains.DataFlow.IPropertyBag Bag { get; }
        public virtual System.DateTime BuiltOn { get; }
        public virtual string BuyURL { get; }
        public virtual JetBrains.Application.ExceptionReport.IExceptionReportStrategy DefaultExceptionReportStrategy { get; }
        public virtual bool DoCheckLicenseReuseOverNetwork { get; }
        public virtual string EvaluationURL { get; }
        public abstract JetBrains.Application.ExceptionReport.IIssueTracker IssueTracker { get; }
        public abstract JetBrains.Application.License.ILicenseSupport LicenseSupport { get; }
        public virtual System.Drawing.Image ProductAboutBoxImage { get; }
        public virtual System.DateTime ProductBirthDate { get; }
        public virtual System.Drawing.Image ProductDialogHeaderImage { get; }
        public string ProductDisplayName { get; }
        public virtual string ProductFullName { get; }
        public abstract System.Drawing.Icon ProductIcon { get; }
        public virtual string ProductName { get; }
        public System.Drawing.Image ProductSplashScreenImage { get; }
        public virtual System.Uri ProductURL { get; }
        public virtual System.Version ProductVersion { get; }
        public virtual string SampleErrorReport { get; }
        public virtual System.Uri UpdatesFilterUri { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.IApplicationDescriptor CreateInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ApplicationDescriptorAttribute attribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.IApplicationDescriptor CreateInstance(params System.Reflection.Assembly[] assemblies) { }
        public static JetBrains.Application.ApplicationDescriptorAttribute FindAttribute(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=false)]
    public class ApplicationDescriptorAttribute : System.Attribute
    {
        public ApplicationDescriptorAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type productDescriptorType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Type ApplicationDescriptorType { get; }
    }
    public class ApplicationDescriptorLite : JetBrains.Application.ApplicationDescriptor
    {
        public ApplicationDescriptorLite([JetBrains.Annotations.NotNullAttribute()] string sProductName, [JetBrains.Annotations.NotNullAttribute()] System.Reflection.Assembly allAssembliesResourceAssembly, [JetBrains.Annotations.NotNullAttribute()] string allAssembliesResourceName) { }
        public override System.Reflection.Assembly AllAssembliesResourceAssembly { get; }
        public override string AllAssembliesResourceName { get; }
        public override string BuyURL { get; }
        public override JetBrains.Application.ExceptionReport.IExceptionReportStrategy DefaultExceptionReportStrategy { get; }
        public override bool DoCheckLicenseReuseOverNetwork { get; }
        public override string EvaluationURL { get; }
        public override JetBrains.Application.ExceptionReport.IIssueTracker IssueTracker { get; }
        public override JetBrains.Application.License.ILicenseSupport LicenseSupport { get; }
        public override System.DateTime ProductBirthDate { get; }
        public override string ProductFullName { get; }
        public override System.Drawing.Icon ProductIcon { get; }
        public override string ProductName { get; }
        public override System.Uri ProductURL { get; }
    }
    public class ApplicationMutex
    {
        public ApplicationMutex(string mutexName) { }
        public void Release() { }
        public bool TryAquire() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public sealed class ApplyCommandLineKeysToLogger
    {
        public const string SwitchLog = "Log";
        public const string SwitchLogFile = "LogFile";
        public const string SwitchLogLevel = "LogLevel";
        public const string SwitchLogNormal = "Normal";
        public const string SwitchLogTrace = "Trace";
        public const string SwitchLogVerbose = "Verbose";
        public ApplyCommandLineKeysToLogger(JetBrains.Application.IProductCommandLine cmdline) { }
    }
    public class AssemblyConfiguration : JetBrains.Application.KnownValue
    {
        public AssemblyConfiguration(string value, JetBrains.Build.AllAssemblies.AllAssembliesXml allassembliesxml) { }
        public override bool IsUniversalAllowed { get; }
        protected override System.Collections.Generic.ICollection<JetBrains.Build.AllAssemblies.KnownValueXml> GetKnownValuesCollection() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class AssemblyManager
    {
        public AssemblyManager(JetBrains.Application.Parts.PartsCatalogueSet catalogueSet) { }
        public void LoadAssemblies(string loadKey, System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies) { }
        public void UnloadAssemblies(string loadKey, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies) { }
    }
    public class BeforeAcquiringWriteLockEventArgs : System.EventArgs
    {
        public static readonly JetBrains.Application.BeforeAcquiringWriteLockEventArgs AcquireInstance;
        public readonly bool IsTryAcquire;
        public static readonly JetBrains.Application.BeforeAcquiringWriteLockEventArgs TryAcquireInstance;
    }
    public delegate void ChangedEventHandler(object sender, JetBrains.Application.ChangeEventArgs changeEventArgs);
    public class ChangeEventArgs : System.EventArgs
    {
        public ChangeEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeMap changeMap) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.IChangeMap ChangeMap { get; }
    }
    public abstract class ChangeManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<JetBrains.Application.ChangeEventArgs> Changed2;
        protected ChangeManager() { }
        public abstract bool IsInChange { get; }
        [System.ObsoleteAttribute("Does not support lifetimes, see for Changed2.")]
        public event JetBrains.Application.ChangedEventHandler Changed;
        public abstract void AddDependency([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider source);
        public abstract void Dump([JetBrains.Annotations.NotNullAttribute()] System.IO.TextWriter to);
        public abstract void ExecuteAfterChange([JetBrains.Annotations.NotNullAttribute()] System.Action action);
        public abstract void OnProviderChanged([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider, [JetBrains.Annotations.NotNullAttribute()] object change, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.ITaskExecutor executor);
        public abstract void RegisterChangeProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider);
        public abstract void RemoveDependency([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider source);
        public abstract void UnregisterChangeProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider);
    }
    public class static ChangeManagerEx
    {
        public static System.IDisposable PushRegisterChangeProvider([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider) { }
    }
    public class static ChangeManagerExtension
    {
        public static void AddDependency(this JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider source) { }
        public static void RegisterChangeProvider(this JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider) { }
    }
    public class static ChangeMapEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetChange<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IChangeMap changeMap, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider)
            where T :  class { }
    }
    public delegate bool CheckForInterrupt();
    public struct CommandLineParameter
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly string Key;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly string Value;
        public CommandLineParameter([JetBrains.Annotations.CanBeNullAttribute()] string key, [JetBrains.Annotations.CanBeNullAttribute()] string value) { }
        public CommandLineParameter([JetBrains.Annotations.CanBeNullAttribute()] string key) { }
        public override string ToString() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class CommandLineSwitchAttribute : System.Attribute
    {
        public CommandLineSwitchAttribute(string name, int parameterscount = 0) { }
        public string Name { get; }
        public int ParametersCount { get; }
    }
    public class static ComposeVerdictWithPriority
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TVerdict> Create<TVerdict>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.CollectionEvents<JetBrains.Application.ComposeVerdictWithPriority.VerdictTeller<TVerdict>> tellers) { }
        public class VerdictTeller<TVerdict>
        
        {
            public readonly System.Func<TVerdict, bool> FIsPositive;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Func<JetBrains.DataFlow.Lifetime, JetBrains.DataFlow.IProperty<TVerdict>> FTell;
            public readonly double Priority;
            public VerdictTeller(double priority, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.DataFlow.IProperty<TVerdict>> FTell, System.Func<TVerdict, bool> FIsPositive) { }
        }
    }
    public enum Creation
    {
        PrimaryThread = 0,
        AnyThread = 1,
    }
    public class CyclicDependencyException : System.ApplicationException
    {
        public CyclicDependencyException(JetBrains.Application.IChangeProvider offendingProvider) { }
        public JetBrains.Application.IChangeProvider OffendingProvider { get; }
    }
    public class static DataFlowEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable AssertUiThreadFiring<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> signal, JetBrains.Threading.IThreading getComponent) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable AssertUiThreadModifications<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<T> collection, JetBrains.Threading.IThreading getComponent) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable AssertUiThreadModifications<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, JetBrains.Threading.IThreading getComponent) { }
        public static void BeginSetGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, TValue value, JetBrains.Threading.IThreading threading, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use other overloads.")]
        public static JetBrains.DataFlow.Property<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Signal<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Signal<TValue> signal, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.SimpleSignal EnsureGuarded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.SimpleSignal signal, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.CollectionEvents<TValue> EnsureGuarded<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.CollectionEvents<TValue> coll, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.DictionaryEvents<TKey, TValue> EnsureGuarded<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.DictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsurePrimaryThread<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, JetBrains.Threading.IThreading threading) { }
        public static void FlowIntoGuarded_NoReplay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard, [JetBrains.Annotations.CanBeNullAttribute()] object cookie, bool bPushInitialValuesImmediately) { }
        public static void FlowIntoGuarded_NoReplay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard, [JetBrains.Annotations.CanBeNullAttribute()] object cookie = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("This method is not used in real code, will probably be removed.")]
        public static System.IDisposable FlowIntoGuarded_Replay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TValue> target, [JetBrains.Annotations.CanBeNullAttribute()] object cookie, bool bPushInitialValuesImmediately, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Concurrency.UnguardedCallbackMerger merger, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("This method is not used in real code, will probably be removed.")]
        public static System.IDisposable FlowIntoGuarded_Replay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TValue> target, [JetBrains.Annotations.CanBeNullAttribute()] object cookie, bool bPushInitialValuesImmediately, JetBrains.Threading.IThreading invocator) { }
    }
    public class Defines
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string CompanyName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.DateTime DateTimeForSubscriptionCheck;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.DateTime DateTimeProductBirth;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Guid GuidProductUpgradeCodeInstallationCenter;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Guid GuidVsActionsCommandSet;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Guid GuidVsDynamicCommandSet;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Guid GuidVsGroupsCommandSet;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Guid GuidVsPackageCoClass;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsModeAnnotateCallStacks;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsModeAssert;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsModeReportExceptions;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsModeStatistics;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsMsiIncludePdb;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsMsiIncludeXmlDoc;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsMsiProductBinariesStrongName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsReleaseLicenseAgreement;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsReSharper;
        [JetBrains.Annotations.NotNullAttribute()]
        public static bool IsReSharperMisbehavesEnabled;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string LicenseProductFamily;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string LicenseSeed;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string LicenseSupportIdentifier;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ModeAnnotateCallStacksName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ModeAssertName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ModeReportExceptionsName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ModeStatisticsName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string MsiSupportedVsVersionsList;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NetfxRequiredVersionBuild;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NetfxRequiredVersionMajor;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NetfxRequiredVersionMinor;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NetfxRequiredVersionRevision;
        [JetBrains.Annotations.NotNullAttribute()]
        public static int NumLicenseAppVersion;
        [JetBrains.Annotations.NotNullAttribute()]
        public static int NumLicenseFeedbackRequestDays;
        [JetBrains.Annotations.NotNullAttribute()]
        public static int NumLicenseFreeTrialDays;
        [JetBrains.Annotations.NotNullAttribute()]
        public static int NumLicenseLeftDaysNotification;
        [JetBrains.Annotations.NotNullAttribute()]
        public static int NumTimeBombDays;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NUnitCpu;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NUnitInParallel;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NUnitRuntime;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NUnitVersion;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string PragmaOnce_Platform_Defines_Targets;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string PragmaOnce_Product_Defines_Targets;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductDisplayName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductFullName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductName;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductStandaloneApplicationCaps;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductUpgradeCodeLegacyVS0800;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductUpgradeCodeLegacyVS0900;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductUpgradeCodeLegacyVS1000;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProductVisualStudioIntegrationCaps;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string SccRevision;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriBuy;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriCompany;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriEvaluate;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriProduct;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriProductCommunityNewsgroups;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriProductHelp;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriProductSupportEmail;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriProductUninstallFeedback;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriProductUpdateInfoForInstaller;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Uri UriUpdatesFilterXslt;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VsPackageLoadKey;
        public class Const
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public const string CompanyName = "JetBrains";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string DateTimeForSubscriptionCheck = "0001-01-01T00:00:00";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string DateTimeProductBirth = "2003-01-01T00:00:00";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string GuidProductUpgradeCodeInstallationCenter = "{2D580069-BF69-4B47-BDEA-AF2986412F11}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string GuidVsActionsCommandSet = "{47F03277-5055-4922-899C-0F7F30D26BF1}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string GuidVsDynamicCommandSet = "{E272D1BE-8216-4919-AFA3-EEB57FAB3537}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string GuidVsGroupsCommandSet = "{9142D617-6500-478F-9DE9-3185145372D0}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string GuidVsPackageCoClass = "{0C6E6407-13FC-4878-869A-C8B4016C57FE}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsModeAnnotateCallStacks = false;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsModeAssert = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsModeReportExceptions = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsModeStatistics = false;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsMsiIncludePdb = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsMsiIncludeXmlDoc = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsMsiProductBinariesStrongName = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsReleaseLicenseAgreement = false;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsReSharper = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const bool IsReSharperMisbehavesEnabled = true;
            [JetBrains.Annotations.NotNullAttribute()]
            public const string LicenseProductFamily = "5931F436-2506-415E-A0A9-27F50D7F62BF";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string LicenseSeed = "RLA90VMnIfMXmT4jbUVOo64qnJqs6APs7SgNXcQVoeeLMp5BpmU4fdw+impX+Wpd";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string LicenseSupportIdentifier = "B74405C3-8BCD-4111-B91D-9DB82F3F3AD7";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ModeAnnotateCallStacksName = "JET_MODE_ANNOTATE_CALL_STACKS";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ModeAssertName = "JET_MODE_ASSERT";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ModeReportExceptionsName = "JET_MODE_REPORT_EXCEPTIONS";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ModeStatisticsName = "JET_MODE_STATISTICS";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string MsiSupportedVsVersionsList = "8.0;9.0;10.0;11.0;12.0";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NetfxRequiredVersionBuild = "0";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NetfxRequiredVersionMajor = "3";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NetfxRequiredVersionMinor = "5";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NetfxRequiredVersionRevision = "0";
            [JetBrains.Annotations.NotNullAttribute()]
            public const int NumLicenseAppVersion = 8000;
            [JetBrains.Annotations.NotNullAttribute()]
            public const int NumLicenseFeedbackRequestDays = 10;
            [JetBrains.Annotations.NotNullAttribute()]
            public const int NumLicenseFreeTrialDays = 30;
            [JetBrains.Annotations.NotNullAttribute()]
            public const int NumLicenseLeftDaysNotification = 3;
            [JetBrains.Annotations.NotNullAttribute()]
            public const int NumTimeBombDays = 30;
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NUnitCpu = "x86";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NUnitInParallel = "True";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NUnitRuntime = "v4.0";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string NUnitVersion = "NUnit-2.6.1";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string PragmaOnce_Platform_Defines_Targets = "True";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string PragmaOnce_Product_Defines_Targets = "True";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductDisplayName = "ReSharper";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductFullName = "ReSharper 8 EAP";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductName = "ReSharper";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductStandaloneApplicationCaps = "None";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductUpgradeCodeLegacyVS0800 = "{F790F14F-E662-4D25-89A0-9CC8677DE27A}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductUpgradeCodeLegacyVS0900 = "{5595D9CA-0517-4A8E-9129-F973460986E0}";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductUpgradeCodeLegacyVS1000 = "";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string ProductVisualStudioIntegrationCaps = "Required";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string SccRevision = "CompiledWithoutBuildServer";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriBuy = "http://www.jetbrains.com/resharper/buy/index.html";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriCompany = "http://www.jetbrains.com/";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriEvaluate = "http://confluence.jetbrains.net/display/ReSharper/ReSharper+8+EAP";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriProduct = "http://www.jetbrains.com/resharper/";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriProductCommunityNewsgroups = "news://news.jetbrains.com/jetbrains.resharper.community";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriProductHelp = "http://www.jetbrains.com/resharper/documentation/index.html";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriProductSupportEmail = "mailto:support@jetbrains.com";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriProductUninstallFeedback = "http://www.jetbrains.com/resharper/uninstall/resharper.jsp";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriProductUpdateInfoForInstaller = "http://blogs.jetbrains.com/dotnet/category/news/";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string UriUpdatesFilterXslt = "http://www.jetbrains.com/resharper/updates/online.Updates.xslt";
            [JetBrains.Annotations.NotNullAttribute()]
            public const string VsPackageLoadKey = "JetBrains s.r.o.;ReSharper;7.0;standard;CCD0JCQEREQ2PAQHAEIRH1KPE0CCE9PADJZ1JPAHM" +
                "2MARZPDJJICI2JJAIDMMIE0E1PHI3JCAJPPKRHID1Q3DRZPCPQRJ8JRRZIEDMQTJTAERQR9J9HZQPAPD" +
                "REHJ3Q3";
        }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class EditionProductConfigurationProvider : JetBrains.Application.Env.IProductConfigurationsProvider
    {
        protected readonly JetBrains.Application.IApplicationDescriptor myProduct;
        public EditionProductConfigurationProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public virtual string[] Configurations { get; }
        protected string[] GetConfigurationsByEdition([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.ProductEdition edition) { }
    }
    public class ExecuteOrQueueSingular
    {
        public ExecuteOrQueueSingular([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action FUserAction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        public ExecuteOrQueueSingular([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FUserAction, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action> FExecuteOrQueue) { }
        public void ExecuteOrQueue() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileSystemPathAllowIntern
    {
        public FileSystemPathAllowIntern(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class HostCommandLine : JetBrains.Application.ICommandLine, JetBrains.Application.IHostCommandLine
    {
        public readonly System.Collections.Generic.IList<string> myOriginalArgs;
        public readonly System.Collections.Generic.IList<string> myOriginalArgsAsReadonly;
        public HostCommandLine([JetBrains.Annotations.NotNullAttribute()] string[] args) { }
        public System.Collections.Generic.IList<string> Keys { get; }
        public System.Collections.Generic.IList<string> NonKeyedParameters { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<string> OriginalArgs { get; }
        public void AddParameters(string[] args) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCommandLineParameterText(JetBrains.Application.CommandLineParameter parameter, [JetBrains.Annotations.NotNullAttribute()] string sProductName, bool isOmittingDefaultProductName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCommandLineText([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.CommandLineParameter> parameters, [JetBrains.Annotations.NotNullAttribute()] string sProductName, bool isOmittingDefaultProductName) { }
        public System.Collections.Generic.IList<string> GetKeyValues(string key, bool isCaseSensitive = False) { }
        public bool IsKeyDefined(string key, bool isCaseSensitive) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.CommandLineParameter> Parse([JetBrains.Annotations.NotNullAttribute()] string[] args) { }
        public string TryGetKeyValue(string key, bool isCaseSensitive) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HostCulture
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual System.Globalization.CultureInfo Culture { get; }
    }
    public interface IApplicationDescriptor : JetBrains.Application.IProductNameAndVersion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Reflection.Assembly AllAssembliesResourceAssembly { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string AllAssembliesResourceName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Build.AllAssemblies.AllAssembliesXml AllAssembliesXml { get; }
        JetBrains.DataFlow.IPropertyBag Bag { get; }
        System.DateTime BuiltOn { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string BuyURL { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.ExceptionReport.IExceptionReportStrategy DefaultExceptionReportStrategy { get; }
        bool DoCheckLicenseReuseOverNetwork { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string EvaluationURL { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.ExceptionReport.IIssueTracker IssueTracker { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.License.ILicenseSupport LicenseSupport { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Drawing.Image ProductAboutBoxImage { get; }
        System.DateTime ProductBirthDate { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Drawing.Image ProductDialogHeaderImage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ProductDisplayName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ProductFullName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Drawing.Icon ProductIcon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Drawing.Image ProductSplashScreenImage { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Uri ProductURL { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string SampleErrorReport { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Uri UpdatesFilterUri { get; }
    }
    public class static IApplicationDescriptorEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.IPartsCatalogue CreatePartCatalog([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.IPartsCatalogueFilter CreatePartCatalogFilterForConfiguration([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> configurations) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.AttributeIndexedPartsCatalogue CreatePartCatalogForConfiguration([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> configurations) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.IPartsCatalogueSet FilterPartCatalogSetByConfiguration([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.PartsCatalogueSet catalogsetOriginal, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> configurations) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.ProductAssemblyXml> GetProductAssembliesXml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor descriptor, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> assemblyconfigurations) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetVersionStringForAboutBox([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor descriptor, bool prependProductFullName, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Application.AssemblyConfiguration> configsForProductEdition = null) { }
    }
    public interface IChangeMap
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        object GetChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider);
        System.Collections.Generic.IEnumerable<TChangeType> GetChanges<TChangeType>();
    }
    public interface IChangeProvider
    {
        object Execute(JetBrains.Application.IChangeMap changeMap);
    }
    public interface ICommandLine
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> Keys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> NonKeyedParameters { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IListEvents<JetBrains.Application.CommandLineParameter> Parameters { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> GetKeyValues([JetBrains.Annotations.NotNullAttribute()] string key, bool isCaseSensitive = False);
        bool IsKeyDefined([JetBrains.Annotations.NotNullAttribute()] string key, bool isCaseSensitive = False);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string TryGetKeyValue([JetBrains.Annotations.NotNullAttribute()] string key, bool isCaseSensitive = False);
    }
    public interface IExternalSourcesDebugInfoProvider
    {
        void Dump(System.IO.TextWriter sw);
    }
    public interface IHostCommandLine : JetBrains.Application.ICommandLine
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string MakeFullCommandLineKeyName([JetBrains.Annotations.NotNullAttribute()] string sKeyWithProductDecoration);
    }
    public class static IHostCommandLineEx
    {
        public static bool IsKeyDefinedInAnyProduct(this JetBrains.Application.IHostCommandLine thіs, [JetBrains.Annotations.NotNullAttribute()] string key, bool isCaseSensitive = False) { }
    }
    public class InterruptableActivityCookie : System.IDisposable
    {
        public InterruptableActivityCookie([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.CheckForInterrupt interrupt) { }
        public static void CheckAndThrow([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress = null) { }
        public void Dispose() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Application.CheckForInterrupt GetCheck() { }
        public static System.IDisposable Suspend() { }
    }
    public abstract class InterruptableReadActivity
    {
        public static readonly JetBrains.Application.CheckForInterrupt Empty;
        protected InterruptableReadActivity(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.CheckForInterrupt checkForInterrupt = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract string ThreadName { get; }
        public void DoStart() { }
        public void DoSynch() { }
        protected abstract void Finish();
        protected virtual void OnInterrupt() { }
        protected virtual void OnInterruptSyncWorkerThread() { }
        protected abstract void Start();
        protected abstract void Work();
    }
    public class InterruptableReadActivityThe : JetBrains.Application.InterruptableReadActivity
    {
        public InterruptableReadActivityThe(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks shellLocks, [JetBrains.Annotations.NotNullAttribute()] System.Func<bool> funcIsCancelled) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Action FuncCancelled { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Action FuncCompleted { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Action<bool> FuncCompletedOrCancelled { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Action FuncRun { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Action FuncStart { get; set; }
        [JetBrains.Annotations.LocalizationRequiredAttribute(false)]
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; set; }
        protected override string ThreadName { get; }
        public static void ExecuteRestartOnInterruptActivity(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, System.Action activity) { }
        protected override void Finish() { }
        protected override void OnInterrupt() { }
        protected override void Start() { }
        protected override void Work() { }
    }
    [System.ObsoleteAttribute("Use ITearDown, and in tests assemblies only.")]
    public interface IObsoleteTearDown
    {
        void TearDown();
    }
    public interface IOneTimeInitializationHandler
    {
        void PerformOneTimeInitialization();
    }
    public interface IPortListener
    {
        bool ContinueListening { get; }
        void OnBytesReceived(System.Net.IPEndPoint from, byte[] data);
    }
    public interface IProductCommandLine : JetBrains.Application.ICommandLine
    {
        bool IsKeyPrefixOptional { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string KeyPrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string MakeFullCommandLineKeyName([JetBrains.Annotations.NotNullAttribute()] string sShortKeyName);
    }
    public interface IProductNameAndVersion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string ProductName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Version ProductVersion { get; }
    }
    public interface IShellLocks : JetBrains.Threading.IThreading
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISimpleSignal AfterWriteLockReleased { get; }
        bool IsReadAccessAllowed { get; }
        bool IsReadLockHeld { get; }
        bool IsWriteAccessAllowed { get; }
        bool IsWriteLockHeld { get; }
        bool IsWriteLockRequested { get; }
        public event System.Windows.Forms.MethodInvoker AfterReadLockReleased;
        public event System.Windows.Forms.MethodInvoker BeforeAcquiringReadLock;
        public event System.EventHandler<JetBrains.Application.BeforeAcquiringWriteLockEventArgs> BeforeAcquiringWriteLock;
        void AcquireReadLock();
        void AcquireWriteLock();
        void GrantWriteAccess([JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread);
        void ReleaseReadLock();
        void ReleaseWriteLock();
        void RestoreWriteLock();
        void RevokeWriteAccess([JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread);
        void TransferWriteLock(System.Threading.Thread anotherThread);
        bool TryAcquireReadLock(int timeout);
        bool TryAcquireWriteLock(int timeout);
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable UsingReadLock();
        [JetBrains.Annotations.NotNullAttribute()]
        System.IDisposable UsingWriteLock();
    }
    public class static IShellLocksEx
    {
        public static void AcquireReadLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static void AcquireWriteLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public static void AllowNestedExecutionAndReleaseLocks([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertReadAccessAllowed([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertWriteAccessAllowed([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs) { }
        public static bool ExecuteOrQueueReadLock(this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void ExecuteOrQueueReadLock(this JetBrains.Application.IShellLocks thіs, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static bool ExecuteOrQueueReadLockEx(this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void ExecuteOrQueueReadLockEx(this JetBrains.Application.IShellLocks thіs, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void ExecuteWithLocksReleased([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void ExecuteWithReadLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static TValue ExecuteWithReadLock<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F) { }
        public static void ExecuteWithWriteLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void QueueReadLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void QueueReadLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void QueueWithReadLockWhenReadLockAvailable([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime, string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static bool TryExecuteWithReadLock([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IShellLocks thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
    }
    public abstract class KnownValue : System.IEquatable<JetBrains.Application.KnownValue>, System.IEquatable<string>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.Build.AllAssemblies.AllAssembliesXml myAllAssembliesXml;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly string myValue;
        protected KnownValue([JetBrains.Annotations.NotNullAttribute()] string value, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allassembliesxml, bool validate) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Build.AllAssemblies.AllAssembliesXml AllAssembliesXml { get; }
        public bool IsUniversal { get; }
        public abstract bool IsUniversalAllowed { get; }
        public static string UniversalValue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Value { get; }
        public void AssertValidValue([JetBrains.Annotations.NotNullAttribute()] string valuename) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.KnownValue assemblyConfiguration) { }
        public bool Equals([JetBrains.Annotations.NotNullAttribute()] string other) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.Collections.Generic.ICollection<JetBrains.Build.AllAssemblies.KnownValueXml> GetKnownValuesCollection();
        public override string ToString() { }
    }
    public enum Lifecycle
    {
        Container = 0,
        DemandReclaimable = 1,
        OneCall = 2,
        Demand = 3,
        Deferred = 4,
    }
    public class static OneTimeInitializationChecker
    {
        public static readonly string GenerationRegistryValueName;
        public static readonly string IdentityRegistryValueName;
        public static string GetActualIdentity(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public static bool IsInitializationNeeded(string identity, bool bMarkAsDone, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<System.Exception> failed, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
    }
    public abstract class OneTimeInitializationManager
    {
        public const string CommandLineForceReinitKey = "ReInit";
        protected OneTimeInitializationManager(System.Collections.Generic.IEnumerable<JetBrains.Application.IOneTimeInitializationHandler> handlers, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.IApplicationDescriptor product, JetBrains.Application.IProductCommandLine productCommandLine) { }
        protected abstract bool IsOneTimeInitAllowed { get; }
        public bool IsOneTimeInitializationRequiredForCurrentUser { get; }
        protected abstract void OnCheckFailed(System.Exception exception);
        protected void OneTimeInitialize() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    [System.ObsoleteAttribute()]
    public class PlatformObsoleteStatics : JetBrains.Application.Env.RunsProducts.IBeforeProductStartup
    {
        public PlatformObsoleteStatics([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.RunningProducts runsProducts) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public JetBrains.Application.ShellComponents Components { get; }
        [System.ObsoleteAttribute()]
        public static bool HasInstance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public static JetBrains.Application.PlatformObsoleteStatics Instance { get; }
        [System.ObsoleteAttribute()]
        public TInterface GetComponent<TInterface>()
            where TInterface :  class { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute()]
        public TInterface TryGetComponent<TInterface>()
            where TInterface :  class { }
    }
    public class ProductCommandLine : JetBrains.Application.ICommandLine, JetBrains.Application.IProductCommandLine
    {
        public ProductCommandLine(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IHostCommandLine cmdlHost, [JetBrains.Annotations.NotNullAttribute()] string sProductPrefix, bool isKeyPrefixOptional) { }
    }
    public class ProductEdition : JetBrains.Application.KnownValue
    {
        public ProductEdition(string value, JetBrains.Build.AllAssemblies.AllAssembliesXml allassembliesxml) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Description { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string DisplayName { get; }
        public override bool IsUniversalAllowed { get; }
        protected override System.Collections.Generic.ICollection<JetBrains.Build.AllAssemblies.KnownValueXml> GetKnownValuesCollection() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.ProductEdition RegistryLoadProductEdition([JetBrains.Annotations.NotNullAttribute()] string sKey, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allassemblies) { }
        public void RegistrySaveProductEdition([JetBrains.Annotations.NotNullAttribute()] string sKey) { }
    }
    public class static ProductEditionEx
    {
        public static readonly string AssemblyConfigurationPrefixForProductEdition;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.ProductEdition GetCurrentProductEditon([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public static bool IsEditionIncluded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ProductEdition edition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public static bool IsEditionIncluded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, [JetBrains.Annotations.NotNullAttribute()] string sEditionId, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public static bool SupportsEditions([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.IApplicationDescriptor product) { }
    }
    public class ProductNameAndVersion : JetBrains.Application.IProductNameAndVersion
    {
        public ProductNameAndVersion([JetBrains.Annotations.NotNullAttribute()] string productName, [JetBrains.Annotations.NotNullAttribute()] System.Version versionProduct) { }
    }
    public class SeldomInterruptChecker
    {
        public SeldomInterruptChecker() { }
        public void CheckForInterrupt() { }
    }
    public class SeldomInterruptCheckerWithCheckTime
    {
        public SeldomInterruptCheckerWithCheckTime(int checkTime) { }
        public void CheckForInterrupt() { }
    }
    public enum Sharing
    {
        Common = 0,
        Product = 1,
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, Inherited=false)]
    public class ShellComponentAttribute : JetBrains.Application.Components.ComponentAttribute
    {
        public ShellComponentAttribute(JetBrains.Application.Sharing sharing, JetBrains.Application.Lifecycle lifecycle, JetBrains.Application.Creation creation, JetBrains.Application.Access access) { }
        public ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
    }
    public class ShellComponents
    {
        public ShellComponents([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer componentContainer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Components.IComponentContainer ComponentContainer { get; }
    }
    public class static ShellComponentsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.ChangeManager Changes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.CommandProcessing.ICommandProcessor Commands([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.CommandProcessing.ICommandProcessor DocumentCommandProcessor([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.FileSystemTracker.IFileSystemTracker FileSystemTracker([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TInterface Get<TInterface>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo)
            where TInterface :  class { }
        public static bool Has<TInterface>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.ShellComponents compo)
            where TInterface :  class { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class ShellLocks : JetBrains.Application.IShellLocks, JetBrains.Threading.IThreading
    {
        public ShellLocks([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ISimpleSignal AfterWriteLockReleased { get; }
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        public JetBrains.Threading.GroupingEventHosts GroupingEvents { get; }
        public bool IsReadAccessAllowed { get; }
        public bool IsReadLockHeld { get; }
        public JetBrains.DataFlow.IProperty<bool> IsRecurringActivityAllowed { get; }
        public bool IsWriteAccessAllowed { get; }
        public bool IsWriteLockHeld { get; }
        public bool IsWriteLockRequested { get; }
        public JetBrains.Threading.ReentrancyGuard ReentrancyGuard { get; }
        public JetBrains.Threading.ThreadManager ThreadManager { get; }
        public JetBrains.Threading.TimedActionsHost TimedActions { get; }
        public event System.Windows.Forms.MethodInvoker AfterReadLockReleased;
        public event System.Windows.Forms.MethodInvoker BeforeAcquiringReadLock;
        public event System.EventHandler<JetBrains.Application.BeforeAcquiringWriteLockEventArgs> BeforeAcquiringWriteLock;
        public void AcquireReadLock() { }
        public void AcquireWriteLock() { }
        public void GrantWriteAccess([JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread) { }
        public void ReleaseReadLock() { }
        public void ReleaseWriteLock() { }
        public void RestoreWriteLock() { }
        public void RevokeWriteAccess([JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread) { }
        public void TransferWriteLock(System.Threading.Thread anotherThread) { }
        public bool TryAcquireReadLock(int timeout) { }
        public bool TryAcquireWriteLock(int timeout) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable UsingReadLock() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable UsingWriteLock() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class SocketManager
    {
        public static readonly System.Net.IPAddress MULTICAST_ADDRESS;
        public static readonly int[] MULTICAST_PORTS;
        public SocketManager(JetBrains.DataFlow.Lifetime lifetime) { }
        public void AddPortListener(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IPortListener listener, System.Net.IPAddress multicastAddress, params int[] ports) { }
        public static bool IsFromUs(System.Net.IPEndPoint from) { }
        public void Send(byte[] data) { }
    }
    public class static TimeStamp
    {
        public static int NextValue { get; }
    }
    public class TopoSorter<T> : JetBrains.Application.ISorter<T>
    
    {
        public TopoSorter(System.Func<T, T, System.Nullable<int>> comparer) { }
        public System.Collections.Generic.ICollection<T> Sort(System.Collections.Generic.ICollection<T> unsorted) { }
    }
    public class static TryReadLockCookie
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable Create(JetBrains.Application.Progress.IProgressIndicator progress, JetBrains.Application.IShellLocks shellLocks, System.Func<bool> checkForInterruptAction = null, bool releaseOnlyWhenLockHeld = False) { }
    }
    public class TryWriteLockCookie : JetBrains.Util.SafeDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.TryWriteLockCookie Create(JetBrains.Application.Progress.IProgressIndicator progress, JetBrains.Application.IShellLocks shellLocks, System.Func<bool> checkForInterruptAction = null, int maxMillisToHeldSinceLastAcquire = 200) { }
        protected override void DisposeUnmanagedResources() { }
        public void ReleaseAndSleep(int millisToSleep) { }
        public void ReleaseConditionally() { }
    }
}
namespace JetBrains.Application.ActivityTrackingNew
{
    
    public class ActivityTimingStorage
    {
        public ActivityTimingStorage() { }
        public void Clear() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<System.DateTime, string, string>> GetTiming() { }
        public void TrackActivity(string activityGroup, string activityName) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ActivityTracking : JetBrains.ActivityTracking.ActivityTrackingOld, JetBrains.Application.ActivityTrackingNew.IActivityTracking
    {
        public ActivityTracking(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.ActivityTrackingNew.ActivityTrackingSettings activityTrackingSettings, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.ActivityTrackingNew.PermanentUserId userId, System.Collections.Generic.IEnumerable<JetBrains.Application.ActivityTrackingNew.IActivityTrackingStatisticsProvider> statisticsProviders, JetBrains.Application.IApplicationDescriptor descriptor) { }
        public JetBrains.Application.ActivityTrackingNew.ActivityTimingStorage ActivityTiming { get; set; }
        public virtual void TrackAction([JetBrains.Annotations.NotNullAttribute()] string actionId) { }
        public virtual void TrackActivity([JetBrains.Annotations.NotNullAttribute()] string activityGroup, [JetBrains.Annotations.NotNullAttribute()] string activityId) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ActivityTrackingSettings : JetBrains.ActivityTracking.ActivityTrackingDefaultSettings
    {
        public ActivityTrackingSettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Communication.WebProxySettingsReader proxySettings, JetBrains.Application.Settings.ISettingsStore store, JetBrains.Threading.IThreading threading) { }
        public override System.Net.IWebProxy GetProxy() { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Feedback settings")]
    public class FeedbackSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to collect timing for each action")]
        public bool CollectActionTiming;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether send activity logs or not")]
        public bool SendActivityLogs;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to prompt user to submit feedback or not")]
        public bool ShouldPrompt;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class FeedbackSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader, JetBrains.Application.Configuration.IXmlReadable
    {
        public FeedbackSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    public interface IActivityTracking
    {
        void TrackAction(string actionId);
        void TrackActivity(string activityGroup, string activityId);
    }
    public interface IActivityTrackingStatisticsProvider
    {
        void GetActivityStatistics(JetBrains.ActivityTracking.ActivityLog log);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PermanentUserId
    {
        public System.Guid GetUniqueUserId() { }
    }
}
namespace JetBrains.Application.ActivityTrackingNew.StatisticsProviders
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class PluginsStatisticProvider : JetBrains.Application.ActivityTrackingNew.IActivityTrackingStatisticsProvider
    {
        public PluginsStatisticProvider(JetBrains.Application.PluginSupport.PluginsDirectory pluginsDirectory) { }
        public void GetActivityStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ScreenResolutionStatisticsProvider : JetBrains.Application.ActivityTrackingNew.IActivityTrackingStatisticsProvider
    {
        public void GetActivityStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
}
namespace JetBrains.Application.Application.Environment.Components
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ApplicationRestart : JetBrains.Application.Application.Environment.Components.IApplicationRestart
    {
        public virtual bool ApplicationCanRestart() { }
        public virtual void Restart() { }
    }
    public interface IApplicationRestart
    {
        bool ApplicationCanRestart();
        void Restart();
    }
}
namespace JetBrains.Application.Changes
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public sealed class ChangeManagerImpl : JetBrains.Application.ChangeManager, JetBrains.Application.Changes.IDependencyGraph, System.IDisposable
    {
        public ChangeManagerImpl(JetBrains.Threading.IThreading threading) { }
        public long EventCounter { get; }
        public override bool IsInChange { get; }
        public event JetBrains.Application.ChangedEventHandler Changed;
        public override void AddDependency([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider source) { }
        public void CheckCyclicDependency() { }
        public override void Dump([JetBrains.Annotations.NotNullAttribute()] System.IO.TextWriter to) { }
        public override void ExecuteAfterChange([JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public System.Collections.Generic.ICollection<JetBrains.Application.IChangeProvider> GetDependentNodes(JetBrains.Application.IChangeProvider changeProvider) { }
        public System.Collections.Generic.ICollection<JetBrains.Application.IChangeProvider> GetDependsUponNodes(JetBrains.Application.IChangeProvider changeProvider) { }
        [System.ObsoleteAttribute("Used for internal purposes only")]
        public JetBrains.Util.WeakToStrongDictionary<JetBrains.Application.IChangeProvider, JetBrains.Util.WeakCollection<JetBrains.Application.IChangeProvider>> NodeToIncomingNodesMap() { }
        [System.ObsoleteAttribute("Used for internal purposes only")]
        public JetBrains.Util.WeakToStrongDictionary<JetBrains.Application.IChangeProvider, JetBrains.Util.WeakCollection<JetBrains.Application.IChangeProvider>> NodeToOutgoingNodesMap() { }
        public override void OnProviderChanged([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider changeProvider, [JetBrains.Annotations.NotNullAttribute()] object change, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.ITaskExecutor executor) { }
        public override void RegisterChangeProvider(JetBrains.Application.IChangeProvider changeProvider) { }
        public override void RemoveDependency([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IChangeProvider source) { }
        public override void UnregisterChangeProvider(JetBrains.Application.IChangeProvider changeProvider) { }
    }
}
namespace JetBrains.Application.CommandProcessing
{
    
    public struct Command
    {
        public static readonly JetBrains.Application.CommandProcessing.Command Empty;
        public Command(string name) { }
        public string Name { get; }
        public override string ToString() { }
    }
    public interface ICommandProcessor
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<string> CurrentBatchChangeName { get; }
        JetBrains.Application.CommandProcessing.Command CurrentCommand { get; }
        JetBrains.DataFlow.IProperty<bool> IsExecutingCommand { get; }
        bool IsRedoInProgress { get; }
        bool IsUndoInProgress { get; }
        void BeginBatchTextChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string commandName);
        void BeginCommand([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string commandName);
        void ExecuteBeforeCurrentCommandFinished([JetBrains.Annotations.NotNullAttribute()] System.Action F);
    }
    public class static ICommandProcessorEx
    {
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public static void ExecuteOutsideCommandScope([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.CommandProcessing.ICommandProcessor thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable UsingBatchTextChange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.CommandProcessing.ICommandProcessor thіs, [JetBrains.Annotations.NotNullAttribute()] string commandName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable UsingCommand([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.CommandProcessing.ICommandProcessor thіs, [JetBrains.Annotations.NotNullAttribute()] string commandName) { }
        public static void WithCommand([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.CommandProcessing.ICommandProcessor thіs, [JetBrains.Annotations.NotNullAttribute()] string commandName, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StandaloneCommandProcessor : JetBrains.Application.CommandProcessing.ICommandProcessor
    {
        public readonly JetBrains.DataFlow.IProperty<string> myCurrentBatchChangeName;
        protected readonly JetBrains.DataFlow.IProperty<JetBrains.Application.CommandProcessing.Command> myCurrentCommand;
        protected readonly JetBrains.DataFlow.IProperty<int> myCurrentCommandNestingLevel;
        protected readonly JetBrains.DataFlow.IProperty<bool> myIsExecutingCommand;
        protected bool myIsRedoInProgress;
        protected bool myIsUndoInProgress;
        protected static readonly bool OptionTrace;
        public StandaloneCommandProcessor(JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.Application.Communication
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Sets up application\'s access to the World Wide Web.")]
    public class InternetSettings { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Communication.InternetSettings), "Governs the use of a proxy server when downloading from Internet.")]
    public class WebProxySettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "If IsCustomProxy, use this proxy hostname.")]
        public readonly string Hostname;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to use user-defined proxy settings instead of the system-wide proxy setti" +
            "ngs.")]
        public readonly bool IsCustomProxy;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", @"If IsCustomProxy, and creating custom proxy from the provided settings failed, reports the error. An empty string if last proxy use was successful. This error won't be exposed as a download exception because on this error proxy settings silently fall back to default. Always set on the global context.")]
        public readonly string LastProxyCreationError;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "If IsCustomProxy, use this proxy password (for password-protected proxies only, i" +
            "gnored if username is empty).")]
        public readonly string Password;
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "If IsCustomProxy, use this proxy port.")]
        public readonly int Port;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "If IsCustomProxy, use this proxy username (for password-protected proxies only).")]
        public readonly string Username;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class WebProxySettingsReader
    {
        public WebProxySettingsReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use an overload with either ContextRange or IContextBoundSettingsStore.")]
        public System.Net.IWebProxy GetProxySettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Net.IWebProxy GetProxySettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ContextRange contextrange) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Net.IWebProxy GetProxySettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
    }
}
namespace JetBrains.Application.ComponentModel
{
    
    public class static CatalogAssemblyAttributes
    {
        public static void ForEachAssemblyAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Parts.PartsCatalogueSet thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Type typeAssemblyAttribute, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, JetBrains.Metadata.Reader.API.IMetadataCustomAttribute, JetBrains.Metadata.Reader.API.IMetadataAssembly> FForEachAttribute) { }
    }
    public class LoggerComponent : JetBrains.Util.ILogger
    {
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
    }
}
namespace JetBrains.Application.Components
{
    
    [JetBrains.Annotations.MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class ComponentAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public ComponentAttribute() { }
        public ComponentAttribute(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
        public JetBrains.Application.Components.ProgramConfigurations ProgramConfigurations { get; set; }
    }
    [System.FlagsAttribute()]
    public enum ProgramConfigurations
    {
        NONE = 0,
        STANDALONE = 1,
        [System.ObsoleteAttribute("Place your component in a Tests assembly and use no configurations.")]
        TEST = 2,
        VS_ADDIN = 4,
        COMMAND_LINE = 8,
        ALL = 15,
    }
}
namespace JetBrains.Application.Configuration
{
    
    public class static ComponentSettingsProviderExtensions
    {
        public static void Upgrade(this JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Configuration.XmlExternalizationScope scope, string sectionName, System.Action<System.Xml.XmlElement> action) { }
    }
    [System.ObsoleteAttribute("For usage only in settings upgraders. Do not create a component!")]
    public class GlobalSettingsTable : JetBrains.Application.Configuration.SettingsTableBase
    {
        public GlobalSettingsTable(JetBrains.Application.Configuration.IComponentSettingsProvider settings, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
    }
    public interface IComponentSettingsProvider
    {
        void LoadSettings(JetBrains.Application.Configuration.IXmlReadable component, JetBrains.Application.Configuration.XmlExternalizationScope scope, string sectionName);
    }
    public interface ISaveSettings
    {
        void LoadSettings();
        void SaveSettings();
    }
    [System.ObsoleteAttribute("Deprecated functionality")]
    public interface IXmlConfigurable
    {
        void ConfigureFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element);
    }
    public interface IXmlReadable
    {
        void ReadFromXml([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement element);
    }
    public interface IXmlRegistrable
    {
        void RegisterFromXml(System.Xml.XmlElement element, System.Collections.IDictionary extraData);
    }
    public interface IXmlUpgradable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> LegacyTagNames { get; }
        bool UpgradeFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] System.Version version);
    }
    public interface IXmlWritable
    {
        void WriteToXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element);
    }
    [System.ObsoleteAttribute()]
    public abstract class SettingsComponentBase : JetBrains.Application.Configuration.IComponentSettingsProvider
    {
        protected SettingsComponentBase(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.Collections.Generic.ICollection<JetBrains.Application.Configuration.XmlExternalizationScope> ValidXmlExternalizationScopes { get; }
        public bool Init() { }
        public void LoadSettings(JetBrains.Application.Configuration.IXmlReadable component, JetBrains.Application.Configuration.XmlExternalizationScope scope, string sectionName) { }
        public void LoadSettingsWithXmlExternalizationUtil(object target, JetBrains.Application.Configuration.XmlExternalizationScope scope, string sectionName) { }
        protected abstract bool OnLoadSettingsXmlBag([JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlDocument, JetBrains.Application.Configuration.XmlExternalizationScope> funcDeserializeXmlBag);
        protected void ShouldUpgradeSettings(System.Version version) { }
    }
    public abstract class SettingsTableBase : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Util.DataStructures.ISettingsTable
    {
        protected const string ConfigName = "SettingsComponent";
        protected SettingsTableBase(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public JetBrains.Application.Configuration.SettingsTableBase.PropertiesCollection<bool> BoolProperties { get; }
        public JetBrains.Application.Configuration.SettingsTableBase.PropertiesCollection<int> IntProperties { get; }
        public JetBrains.Application.Configuration.SettingsTableBase.PropertiesCollection<string> StringProperties { get; }
        public bool GetBoolean(string settingName) { }
        public bool GetBoolean(string settingName, bool defaultVal) { }
        public int GetInteger(string settingName) { }
        public int GetInteger(string settingName, int defaultVal) { }
        public string GetString(string settingName) { }
        public string GetString(string settingName, string defaultVal) { }
        public bool IsEncrypted(string settingName) { }
        public void SetBoolean(string settingName, bool val) { }
        public void SetInteger(string settingName, int val) { }
        public void SetString(string settingName, string val) { }
        public class PropertiesCollection<TValue> : System.Collections.Generic.ICollection<JetBrains.DataFlow.IProperty<TValue>>, System.Collections.Generic.IEnumerable<JetBrains.DataFlow.IProperty<TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, JetBrains.DataFlow.IProperty<TValue>>>, System.Collections.IEnumerable
        
        {
            public PropertiesCollection() { }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public JetBrains.DataFlow.IProperty<TValue> this[string name] { get; }
            public JetBrains.DataFlow.IProperty<TValue> this[string name, TValue defaultvalue] { get; }
            public void Add(JetBrains.DataFlow.IProperty<TValue> item) { }
            public void Clear() { }
            public bool Contains(JetBrains.DataFlow.IProperty<TValue> item) { }
            public void CopyTo(JetBrains.DataFlow.IProperty<>[] array, int arrayIndex) { }
            public System.Collections.IEnumerator GetEnumerator() { }
            public bool Remove(JetBrains.DataFlow.IProperty<TValue> item) { }
        }
    }
    public abstract class SettingTablesUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        protected readonly JetBrains.Application.Env.RunsProducts.ProductConfigurations ProductConfigurations;
        protected SettingTablesUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected abstract void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable);
    }
    [System.ObsoleteAttribute()]
    public sealed class ShellSettingsComponent : JetBrains.Application.Configuration.SettingsComponentBase
    {
        public static readonly JetBrains.DataFlow.PropertyId<System.Func<System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.Util.FileSystemPath, System.Version>>>> PropGetLegacySettingsFiles;
        public ShellSettingsComponent(JetBrains.Application.IApplicationDescriptor product, JetBrains.Threading.IThreading threading, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override System.Collections.Generic.ICollection<JetBrains.Application.Configuration.XmlExternalizationScope> ValidXmlExternalizationScopes { get; }
        protected override bool OnLoadSettingsXmlBag(System.Action<System.Xml.XmlDocument, JetBrains.Application.Configuration.XmlExternalizationScope> funcDeserializeXmlBag) { }
    }
    [System.ObsoleteAttribute("For usage only in settings upgraders. Do not create a component!")]
    public class WorkspaceSettingsTable : JetBrains.Application.Configuration.SettingsTableBase
    {
        public WorkspaceSettingsTable(JetBrains.Application.Configuration.IComponentSettingsProvider settings, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.Application.Configuration.IXmlConfigurable))]
    public sealed class XmlConfigurableAttribute : System.Attribute
    {
        public XmlConfigurableAttribute(string configurationResourceName) { }
        public string ConfigurationResourceName { get; set; }
    }
    public class static XmlConfigurableHelper
    {
        public static void InitializeComponent_XmlConfigurable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Configuration.IXmlConfigurable configurable) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.All, AllowMultiple=false)]
    public class XmlExternalizableAttribute : System.Attribute
    {
        public XmlExternalizableAttribute([JetBrains.Annotations.CanBeNullAttribute()] object defaultvalue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object DefaultValue { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string SettingName { get; set; }
        public bool UseXmlSerializer { get; set; }
    }
    public enum XmlExternalizationScope
    {
        Any = 0,
        Local = 1,
        Shared = 2,
        UserSettings = 3,
        WorkspaceSettings = 4,
    }
    public class static XmlExternalizationUtil
    {
        public static string XmlExternalizableElementName;
        public static readonly string XmlStreamElementName;
        public static void ApplyDefaults(object externalizable) { }
        public static void ApplyDefaults(object externalizable, object proptoken) { }
        public static bool ArrayEquals(System.Array array1, System.Array array2) { }
        public static void ReadFromSubTag([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Configuration.IXmlReadable externalizable, [JetBrains.Annotations.NotNullAttribute()] string tagName) { }
        public static void ReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] object externalizable) { }
        public static void ReadFromXml([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] object externalizable) { }
        public static void ReadFromXml([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] object externalizable, [JetBrains.Annotations.CanBeNullAttribute()] object proptoken) { }
        public static void ReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] object externalizable, [JetBrains.Annotations.CanBeNullAttribute()] object proptoken) { }
        public static void ReadStreamElementsFromXml([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> action) { }
        public static void ReadStreamFromXml([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> action) { }
        public static void ReadStructFromXml<T>(System.Xml.XmlElement parent, ref T externalizable)
            where T :  struct { }
        public static void ReadStructFromXml<T>(System.Xml.XmlElement parent, ref T externalizable, object proptoken)
            where T :  struct { }
        public static void TryReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] object externalizable) { }
        public static void TryReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] object externalizable, [JetBrains.Annotations.CanBeNullAttribute()] object proptoken) { }
        public static void WriteStreamToXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlWriter> action) { }
        public static void WriteToSubTag([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Configuration.IXmlWritable setting, [JetBrains.Annotations.NotNullAttribute()] string tagName) { }
        public static void WriteToXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] object externalizable) { }
        public static void WriteToXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] object externalizable) { }
        public static void WriteToXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] object externalizable, object proptoken) { }
        public static void WriteToXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] object externalizable, object proptoken) { }
        public class ExternalizableMember : System.IComparable<JetBrains.Application.Configuration.XmlExternalizationUtil.ExternalizableMember>, System.IEquatable<JetBrains.Application.Configuration.XmlExternalizationUtil.ExternalizableMember>
        {
            public ExternalizableMember([JetBrains.Annotations.NotNullAttribute()] object instance, [JetBrains.Annotations.NotNullAttribute()] System.Reflection.MemberInfo member, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Configuration.XmlExternalizableAttribute attribute) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Application.Configuration.XmlExternalizableAttribute Attribute { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public object Instance { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Reflection.MemberInfo Member { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string Name { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public object UserValue { get; set; }
            public int CompareTo(JetBrains.Application.Configuration.XmlExternalizationUtil.ExternalizableMember other) { }
            public override bool Equals(object obj) { }
            public bool Equals(JetBrains.Application.Configuration.XmlExternalizationUtil.ExternalizableMember other) { }
            public override int GetHashCode() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Type GetMemberType() { }
            public object GetMemberValue([JetBrains.Annotations.CanBeNullAttribute()] object token) { }
            public object GetMemberValueRaw() { }
            public bool HasDefaultValue() { }
            public object ParseDefaultValue() { }
            public bool SetMemberValue([JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] object proptoken) { }
            public override string ToString() { }
        }
    }
    public class static XmlReadableExtensions
    {
        public static JetBrains.Application.Configuration.IXmlReadable CreateReadable([JetBrains.Annotations.NotNullAttribute()] this System.Action<System.Xml.XmlElement> action) { }
    }
}
namespace JetBrains.Application.Configuration.Upgrade
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class GlobalSettingsUpgrade : JetBrains.Application.Configuration.Upgrade.SettingsUpgradeBase<JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute>
    {
        public GlobalSettingsUpgrade(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.IShellLocks locks, JetBrains.Application.Settings.UserInterface.ResetSettings resetSettings, JetBrains.Application.Settings.Storage.DefaultFileStorages.GlobalSettings globalSettings) { }
        protected override JetBrains.Application.Configuration.IComponentSettingsProvider CreateLegacySettingsComponent() { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader settingsUpgrader, JetBrains.Application.Configuration.IComponentSettingsProvider solutionSettingsComponent, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
        protected override JetBrains.Application.Settings.SettingsScalarEntry IsUpgradedFlagEntry(JetBrains.Application.Settings.ISettingsSchema schema) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Global Settings Upgraded")]
    public class GlobalSettingsUpgradedSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Global Settings Upgraded")]
        public bool IsUpgraded;
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class GlobalSettingsUpgraderAttribute : JetBrains.Application.Parts.PartAttribute { }
    public interface IGlobalSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime);
    }
    public interface ISettingsUpgrader { }
    public abstract class SettingsUpgradeBase<TSettingsUpgrader, TComponentAttribute>
        where TSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
        where TComponentAttribute : JetBrains.Application.Parts.PartAttribute
    {
        protected abstract JetBrains.Application.Configuration.IComponentSettingsProvider CreateLegacySettingsComponent();
        protected void DoUpgrade(JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected abstract void DoUpgrade(TSettingsUpgrader settingsUpgrader, JetBrains.Application.Configuration.IComponentSettingsProvider solutionSettingsComponent, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime);
        protected abstract JetBrains.Application.Settings.SettingsScalarEntry IsUpgradedFlagEntry(JetBrains.Application.Settings.ISettingsSchema schema);
    }
    public class static SettingsUpgradeEx
    {
        public static void UpgradeIndexedValue<TSettingKey, TKey, TValue>(this JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSettingKey, JetBrains.Application.Settings.Store.IIndexedEntry<TKey, TValue>>> expression, TKey key, TValue value)
        
        
            where TValue :  class { }
        public static void UpgradeValue<TKey, T>(this JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKey, T>> expression, T value) { }
    }
}
namespace JetBrains.Application.DataContext
{
    
    public class AmbientApplicationDataRule<TValue> : JetBrains.Application.DataContext.DataRule<TValue>
        where TValue :  class
    {
        public AmbientApplicationDataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate) { }
    }
    public class AmbientApplicationOrSelectionDataRule<TValue> : JetBrains.Application.DataContext.DataRule<TValue>
        where TValue :  class
    {
        public AmbientApplicationOrSelectionDataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate) { }
    }
    public class AmbientSelectionDataRule<TValue> : JetBrains.Application.DataContext.DataRule<TValue>
        where TValue :  class
    {
        public AmbientSelectionDataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate) { }
    }
    public class AmbientSelectionMainThreadDataRule<TValue> : JetBrains.Application.DataContext.DataRule<TValue>
        where TValue :  class
    {
        public AmbientSelectionMainThreadDataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, JetBrains.Threading.IThreading mainthread, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate) { }
    }
    public class ApplicationContext
    {
        public static JetBrains.Application.DataContext.ApplicationContext Instance { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ComponentContainerForFactoring
    {
        public readonly JetBrains.Application.Components.IComponentContainer Container;
        public ComponentContainerForFactoring(JetBrains.Application.Components.IComponentContainer container) { }
    }
    public class CurrentSelectionContext
    {
        public static JetBrains.Application.DataContext.CurrentSelectionContext Instance { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public sealed class DataConstant<T> : JetBrains.Application.DataContext.IDataConstant
        where T :  class
    {
        public DataConstant([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public string Id { get; }
        public System.Type Type { get; }
        public override string ToString() { }
    }
    public class DataConstantPropertyId<T> : JetBrains.DataFlow.PropertyId<T>
        where T :  class
    {
        public DataConstantPropertyId([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<T> dataconstant) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.DataContext.DataConstant<T> DataConstant { get; }
    }
    public abstract class DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.Application.DataContext.ApplicationContext> ApplicationContext;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.Application.DataContext.ComponentContainerForFactoring> ComponentContainerForFactoring;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.Application.DataContext.CurrentSelectionContext> CurrentSelectionContext;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.Util.dataStructures.Boxed<System.Windows.Point>> ScreenPoint;
    }
    public class static DataConstantsExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static T GetComponent<T>(this JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T TryGetComponent<T>(this JetBrains.Application.DataContext.IDataContext dataContext)
            where T :  class { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DataContexts
    {
        public DataContexts([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.FindDataRules findDataRules) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.DataContext.IDataContext Empty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.DataContext.FindDataRules FindDataRules { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateAtScreenPoint([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.Windows.Point ptScreen, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateOnActiveControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateOnApplicationWideState([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateOnControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.CrossFramework.EitherControl control, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateOnSelection([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateWithDataRules([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.Application.DataContext.IDataContext CreateWithoutDataRules([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> datarulesAdditional = null) { }
        public void RegisterDataRule<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> constant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FRule)
            where TValue :  class { }
        public void RegisterDataRule([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataRule rule) { }
    }
    public class DataRule<TValue> : JetBrains.Application.DataContext.IDataRule
        where TValue :  class
    {
        protected double myPriority;
        public DataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] TValue value) { }
        public DataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate) { }
        public DataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, JetBrains.Util.JetTuple<TValue, bool>> FTryEvaluateOrMissingValue) { }
        public string Name { get; }
        public class DesperateDataRule<TValue> : JetBrains.Application.DataContext.DataRule<TValue>
            where TValue :  class
        {
            public DesperateDataRule([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate) { }
        }
    }
    public class static DataRulePriorityClasses
    {
        public const double Ambient = 1000D;
        public const double Default = 0D;
        public const double Desperate = 1000000D;
    }
    public class static DataRules
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> AddRule<TValue>([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate)
            where TValue :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> AddRule<TValue>([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] TValue value)
            where TValue :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> AddRule<TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> thіs, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, TValue> FTryEvaluate)
            where TValue :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> AddRule<TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<JetBrains.Application.DataContext.IDataRule> thіs, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TValue> dataconstant, [JetBrains.Annotations.NotNullAttribute()] TValue value)
            where TValue :  class { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.Application.DataContext.IFindDataRules))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class ExportFindDataRulesAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public double Priority;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindDataRules
    {
        public FindDataRules([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IViewable<JetBrains.Application.DataContext.IFindDataRules> finders) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> FindActiveDataRules() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> FindDataRulesAtPoint(System.Windows.Point ptScreen) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> FindDataRulesInControl(JetBrains.UI.CrossFramework.EitherControl control) { }
    }
    public interface IDataConstant
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Type Type { get; }
    }
    public interface IDataContext
    {
        bool IsEmpty { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        T GetData<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<T> dataConstant)
            where T :  class;
    }
    public class static IDataContextEx
    {
        public static bool CheckAllNotNull([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.IDataContext thіs, params JetBrains.Application.DataContext.IDataConstant[] dataConstants) { }
        public static bool CheckAllNotNull([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.IDataContext thіs, JetBrains.Application.DataContext.IDataConstant dataConstant) { }
        public static bool CheckAnyNotNull([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.IDataContext thіs, params JetBrains.Application.DataContext.IDataConstant[] dataConstants) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object GetRawData([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataConstant constant) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.PropertyBag ToPropertyBag([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.Application.DataContext.IDataConstant[] constants) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.PropertyId ToPropertyId([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.IDataConstant constant) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.PropertyId<T> ToPropertyId<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.DataContext.DataConstant<T> constant)
            where T :  class { }
    }
    public interface IDataContextProvider
    {
        JetBrains.Application.DataContext.IDataContext DataContext { get; }
    }
    public interface IDataRule
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.DataContext.IDataConstant OutputType { get; }
        double Priority { get; }
        object Evaluate([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
    }
    public interface IDataRuleProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> GetDataRules();
    }
    public interface IFindDataRules
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> FindActiveDataRules();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> FindDataRulesAtPoint(System.Windows.Point ptScreen);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> FindDataRulesInControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.CrossFramework.EitherControl control);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ShellDataRules
    {
        public ShellDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts contexts, JetBrains.Application.Components.IComponentContainer container) { }
    }
}
namespace JetBrains.Application.Env.Components
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class AnyProductSettingsLocation
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly string AllProductsFolderName;
        public static readonly string AnyVersionString;
        public static readonly string GlobalSettingsStorageFileName;
        public static readonly string LegacyUserSettingsFileName;
        public static readonly string LegacyWorkspaceSettingsFileName;
        public static readonly string ProductRegistryKeyPrefix_Software;
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetInstallDir([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.Util.FileSystemPath, System.Version>> GetLegacyUserSettingsRoamingLegacyDirs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.Util.FileSystemPath GetLegacyUserSettingsXmlPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.Util.FileSystemPath GetLegacyWorkspaceXmlPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetSettingsPathSuffix(JetBrains.Application.Env.Components.ProductSettingsLocationFlag flag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IProductNameAndVersion product = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual string GetSettingsPathSuffix([JetBrains.Annotations.CanBeNullAttribute()] string nameProduct, [JetBrains.Annotations.CanBeNullAttribute()] System.Version version, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.JetTuple<string, string>> additionalParameters) { }
        public virtual System.Collections.Generic.IList<JetBrains.Util.JetTuple<string, string>> GetSettingsPathSuffixAdditionalParameters() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetSettingsRegistryKey(JetBrains.Application.Env.Components.ProductSettingsLocationFlag flag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IProductNameAndVersion product = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetUserSettingsDir(System.Environment.SpecialFolder basefolder, JetBrains.Application.Env.Components.ProductSettingsLocationFlag flag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IProductNameAndVersion product = null) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ExtractProductCommandLineFromHostCommandLine : JetBrains.Application.ICommandLine, JetBrains.Application.IProductCommandLine
    {
        public ExtractProductCommandLineFromHostCommandLine([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IHostCommandLine hostCommandLine, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor descriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.JetEnvironment environment) { }
    }
    [System.ObsoleteAttribute()]
    public interface IComponentStartupShutdown
    {
        void OnAfterStartup();
        void OnBeforeShutdown();
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public sealed class InternalModeProductConfigurationsProvider : JetBrains.Application.Env.IProductConfigurationsProvider
    {
        public static readonly string AssemblyConfigurationInternal;
        public static readonly string AssemblyConfigurationPublic;
        public static System.Nullable<bool> OverrideInternalModeOnNextStart;
        public const string SwitchInternal = "Internal";
        public InternalModeProductConfigurationsProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IProductCommandLine cmdline) { }
        public string[] Configurations { get; }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ProductSettingsLocation
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Env.Components.AnyProductSettingsLocation AnyProductSettingsLocation;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.IApplicationDescriptor Product;
        public ProductSettingsLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath InstallDir { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetProductRegistryKey(JetBrains.Application.Env.Components.ProductSettingsLocationFlag flag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetUserSettingsNonRoamingDir(JetBrains.Application.Env.Components.ProductSettingsLocationFlag flag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetUserSettingsRoamingDir(JetBrains.Application.Env.Components.ProductSettingsLocationFlag flag) { }
    }
    public enum ProductSettingsLocationFlag
    {
        ThisProductThisVersionThisEnvironment = 0,
        ThisProductThisVersionAnyEnvironment = 1,
        [System.ObsoleteAttribute("New code should use a specific location (or a collection of them). Old code shoul" +
            "d continue using this flag if that is the desired behavior.")]
        AsInPlatform5 = 0,
        ThisProductAnyVersion = 2,
        AnyProductAnyVersion = 3,
        AnyProductPlatformVersion = 4,
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class SuspendResume
    {
        public static readonly string CmdLineResume;
        public static readonly string CmdLineSuspend;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<bool> IsSuspended;
        public static readonly string RegistryDataName_IsSuspended;
        public SuspendResume(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IProductCommandLine productCommandLine, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void Resume() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void Suspend() { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void ToggleSuspended() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class SuspendResumeProductCanBeStarted : JetBrains.Application.Env.IProductCanBeStarted
    {
        public SuspendResumeProductCanBeStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.Components.SuspendResume suspendResume) { }
    }
}
namespace JetBrains.Application.Env
{
    
    [JetBrains.Annotations.MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class EnvironmentComponentAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public EnvironmentComponentAttribute(JetBrains.Application.Sharing sharing) { }
    }
    public interface IJetHost
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Env.JetEnvironment Environment { get; }
    }
    public interface IProductCanBeStarted
    {
        double Priority { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<JetBrains.Application.Env.ProductCanBeStartedVerdict> CreateCanBeStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
    }
    public interface IProductConfigurationsProvider
    {
        string[] Configurations { get; }
    }
    public class JetEnvironment
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Env.JetEnvironmentConfiguration Configuration;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartsCatalogueSet EnvironmentPartCatalogSet;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartsCatalogueSet FullPartCatalogSet;
        public bool HasDefaultProduct;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.IApplicationDescriptor> Products;
        public JetEnvironment([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.JetEnvironmentConfiguration configuration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Components.IComponentContainer containerHostInfo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Components.ComponentContainer Container { get; }
    }
    public class JetEnvironmentConfiguration
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string[] ConfigurationNames;
        public static readonly string CpuConfigSuffix;
        public static readonly string RuntimeConfigClrPrefix;
        public static JetBrains.Application.Env.JetEnvironmentConfiguration CreateWithStandardConfigs([JetBrains.Annotations.NotNullAttribute()] params string[] configs) { }
        public bool Equals(JetBrains.Application.Env.JetEnvironmentConfiguration other) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string[] GetAllPossibleStandardConfigs() { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string[] GetStandardConfigsForCurrentRuntime() { }
    }
    public class static JetEnvironmentConfigurationEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> ConfigurationsParsedForProduct([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.JetEnvironmentConfiguration configuration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
    }
    public class static ProductCanBeStartedPriorityThresholds
    {
        public static readonly double EnvironmentReady;
        public static readonly double Licensing;
        public static readonly double UserSuspend;
    }
    public enum ProductCanBeStartedResolution
    {
        Affirmative = 0,
        NegativeTemporary = 1,
        NegativePermanentGraceful = 2,
        NegativePermanentByError = 3,
    }
    public class ProductCanBeStartedVerdict : System.IEquatable<JetBrains.Application.Env.ProductCanBeStartedVerdict>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly string Comment;
        public readonly JetBrains.Application.Env.ProductCanBeStartedResolution Resolution;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Env.ProductCanBeStartedVerdict Affirmative(string message = null) { }
        public bool Equals(JetBrains.Application.Env.ProductCanBeStartedVerdict other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Env.ProductCanBeStartedVerdict NegativePermanentByError([JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Env.ProductCanBeStartedVerdict NegativePermanentGraceful([JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Env.ProductCanBeStartedVerdict NegativeTemporary([JetBrains.Annotations.NotNullAttribute()] string message) { }
        public override string ToString() { }
    }
    public class static ProductCanBeStartedVerdictEx
    {
        public static bool IsAffirmative([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Env.ProductCanBeStartedVerdict thіs) { }
        public static bool IsNegativePermanent([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Env.ProductCanBeStartedVerdict thіs) { }
        public static bool IsWithErrors([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Env.ProductCanBeStartedVerdict thіs) { }
        public static bool ShouldBeRunningStandaloneApplicationHost([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Env.ProductCanBeStartedVerdict thіs) { }
        public static bool ShouldStartShell([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Env.ProductCanBeStartedVerdict thіs) { }
    }
    public class static ProductConfigurationsEx
    {
        public static JetBrains.Application.Env.ProductConfigurationsEx.InternalMode GetInternalMode([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations thіs) { }
        public static JetBrains.Application.Components.ProgramConfigurations GuessProgramConfiguration([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public static bool IsInternalMode([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations thіs) { }
        public enum InternalMode
        {
            PublicMode = 0,
            InternalMode = 1,
        }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public sealed class ReportsProductsAllowedToRun
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Application.Env.ProductCanBeStartedVerdict> IsProductAllowedToRun;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.IApplicationDescriptor Product;
        public ReportsProductsAllowedToRun([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Env.IProductCanBeStarted> canstart, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class RunningProducts
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.DictionaryEvents<JetBrains.Application.IApplicationDescriptor, JetBrains.Application.Components.IComponentContainer> ProductContainersComposed;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.DictionaryEvents<JetBrains.Application.IApplicationDescriptor, JetBrains.Application.Components.IComponentContainer> ProductContainersNonComposed;
        public RunningProducts([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public sealed class RunsProducts
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public readonly JetBrains.DataFlow.CollectionEvents<JetBrains.Application.IApplicationDescriptor> ProductsAllowedToRun;
        public RunsProducts([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Env.IProductConfigurationsProvider> enumShellConfigProviders, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Env.ReportsProductsAllowedToRun> arReportsProductsAllowedToRun, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.JetEnvironment environment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.RunningProducts runningProducts) { }
        public interface IBeforeProductStartup { }
        public class ProductConfigurations
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.AssemblyConfiguration[] Configurations;
            public ProductConfigurations() { }
            public ProductConfigurations([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.AssemblyConfiguration[] configurations) { }
        }
        public class ProductPartsCatalogSet
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Parts.IPartsCatalogueSet PartsCatalogueSet;
            public ProductPartsCatalogSet([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartsCatalogueSet partsCatalogueSet) { }
        }
    }
}
namespace JetBrains.Application.EventBus
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class EventBusComponent : JetBrains.Util.EventBus.IEventBus, JetBrains.Util.EventBus.IEventContext, System.IDisposable
    {
        public EventBusComponent() { }
        public void Dispose() { }
        public JetBrains.Util.EventBus.IEventRef<T> Event<T>(JetBrains.Util.EventBus.EventId<T> eventId) { }
        public JetBrains.Util.EventBus.IEventRef<T> Event<T>() { }
        public void Invoke<T>(JetBrains.Util.EventBus.EventId<T> eventId, T args) { }
        public JetBrains.Util.EventBus.IEventContext InvokeStartFinish<TStartArgs, TFinishArgs>(JetBrains.Util.EventBus.EventId<TStartArgs> startEventId, JetBrains.Util.EventBus.EventId<TFinishArgs> finishEventId, TStartArgs args, System.Func<TFinishArgs> finishArgs) { }
    }
}
namespace JetBrains.Application.ExceptionReport
{
    
    public enum CredentialsVerificationResult
    {
        Ok = 0,
        UserNameProblem = 1,
        PasswordProblem = 2,
        UserNameOrPasswordProblem = 3,
        OtherProblem = 4,
    }
    public class DefaultExceptionReportService : JetBrains.Application.ExceptionReport.IExceptionReportService { }
    public class ExceptionData : JetBrains.Application.ExceptionReport.PersistableExceptionData
    {
        public readonly JetBrains.DataFlow.ISimpleSignal Changed;
        public readonly JetBrains.DataFlow.IProperty<int> NumberOfTimesHappenedProperty;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Application.ExceptionReport.ExceptionSubmissionResult> ServerActionProperty;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Application.ExceptionReport.ExceptionDataStatus> StatusProperty;
        public readonly JetBrains.DataFlow.IProperty<System.DateTime> WhenLastHappenedProperty;
        public ExceptionData(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Exception exception, System.Version productVersion = null, System.Nullable<System.DateTime> whenHappened = null) { }
        public ExceptionData(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.PersistableExceptionData persistableExceptionData) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Exception Exception { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Application.ExceptionReport.ExceptionData PreviousException { get; set; }
        public JetBrains.Application.ExceptionReport.PersistableExceptionData ToPersistableExceptionData() { }
        public void UpdateWith(JetBrains.Application.ExceptionReport.PersistableExceptionData persistableExceptionData) { }
    }
    public class ExceptionDataStatus : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.Application.ExceptionReport.ExceptionDataStatus Created;
        public static readonly JetBrains.Application.ExceptionReport.ExceptionDataStatus Muted;
        public static readonly JetBrains.Application.ExceptionReport.ExceptionDataStatus Read;
        public static readonly JetBrains.Application.ExceptionReport.ExceptionDataStatus SubmissionInProgress;
        public static readonly JetBrains.Application.ExceptionReport.ExceptionDataStatus Submited;
        public static readonly JetBrains.Application.ExceptionReport.ExceptionDataStatus SubmittedMuted;
        protected ExceptionDataStatus([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public static JetBrains.Application.ExceptionReport.ExceptionDataStatus FromString(string status) { }
    }
    public class static ExceptionHelper
    {
        public static string FilterExceptionString(string s) { }
        public static string FormatStackTrace(System.Exception e) { }
        public static string GetExceptionHash(string excString) { }
        public static string GetExceptionHash(System.Exception exception) { }
        public static string GetExceptionSummary(System.Exception e) { }
    }
    public class ExceptionManager : JetBrains.ProjectModel.RecursiveFileSystemChangeDeltaVisitor, System.IDisposable
    {
        public JetBrains.DataFlow.ISimpleSignal ExceptionsLoaded;
        public ExceptionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ExceptionReport.ExceptionStorageLocator storageLocator, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IApplicationDescriptor applicationDescriptor, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<bool> watchExceptionStorage = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionStorageBehavior exceptionStorageBehavior = null) { }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.ExceptionReport.ExceptionData> Exceptions { get; }
        public int PendingCountProperty { get; }
        public int ReadCountProperty { get; }
        public int SubmitInProgressCountProperty { get; }
        public int UnreadCountProperty { get; }
        public bool Compare(JetBrains.Application.ExceptionReport.PersistableExceptionData x, JetBrains.Application.ExceptionReport.PersistableExceptionData y) { }
        public JetBrains.Application.ExceptionReport.ExceptionData CreateExceptionData(System.Exception exception) { }
        public void Dispose() { }
        public System.Collections.Generic.ICollection<JetBrains.Application.ExceptionReport.ExceptionData> GetNewExceptions() { }
        public override void Visit(JetBrains.ProjectModel.FileSystemChangeDelta delta) { }
    }
    public class ExceptionReporting
    {
        public ExceptionReporting(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionReportService exceptionReportService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.ITaskExecutor taskexecutor, System.Collections.Generic.IEnumerable<JetBrains.Application.ExceptionReport.IExceptionReportDataProvider> exceptionReportDataProviders, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.ExceptionReport.ExceptionStorageLocator exceptionStorageLocator, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionReportStrategy defaultStrategy = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<bool> watchExceptionStorage = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionStorageBehavior exceptionStorageBehavior = null) { }
        public ExceptionReporting([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionReportService exceptionReportService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.ITaskExecutor taskexecutor, System.Collections.Generic.IEnumerable<JetBrains.Application.ExceptionReport.IExceptionReportDataProvider> exceptionReportDataProviders, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionManager exceptionManager, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionReportStrategy defaultStrategy = null) { }
        public JetBrains.Application.ExceptionReport.ExceptionManager ExceptionManager { get; }
        public static bool IsShowingExceptionsToUser { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.ExceptionReport.IExceptionReportService Service { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Progress.ITaskExecutor TaskExecutor { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable AttachToLogger() { }
        public bool IsRelevantException(System.Exception ex) { }
        public bool IsRelevantStackTrace(string stackTraceString) { }
        public void Process(System.Exception exception) { }
        public static void SetInternalMode() { }
        public System.IDisposable SetStrategy([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionReportStrategy strategy) { }
    }
    public class ExceptionStackFrame : System.IEquatable<JetBrains.Application.ExceptionReport.ExceptionStackFrame>
    {
        public ExceptionStackFrame(int id, string fullyQualifiedTypeName, string methodName, string signature, int index, bool isAnonymous) { }
        public string FullyQualifiedTypeName { get; set; }
        public int Id { get; set; }
        public int Index { get; set; }
        public bool IsAnonymous { get; }
        public string MethodName { get; set; }
        public string Signature { get; set; }
        public bool Equals(JetBrains.Application.ExceptionReport.ExceptionStackFrame stackFrame) { }
        public override bool Equals(object obj) { }
        public string GetFrameType() { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class ExceptionStackTrace : System.IEquatable<JetBrains.Application.ExceptionReport.ExceptionStackTrace>
    {
        public ExceptionStackTrace() { }
        public System.Collections.Generic.List<string> ExceptionClasses { get; set; }
        protected System.Collections.Generic.List<string> ExceptionMessages { get; set; }
        protected System.Collections.Generic.List<int[]> ExceptionMessagesRaw { get; set; }
        public int[] FrameIds { get; set; }
        public System.Collections.Generic.List<JetBrains.Application.ExceptionReport.ExceptionStackFrame> Frames { get; set; }
        public void AddExceptionMessage(string message) { }
        public bool Equals(JetBrains.Application.ExceptionReport.ExceptionStackTrace other) { }
        public int ExceptionMessagesCount() { }
        public static double GetSimilarity(System.Collections.Generic.IList<JetBrains.Util.Diff.DiffFragment> fragments, int oldLength, int newLength, JetBrains.Application.ExceptionReport.ExceptionStackTrace.IWeightedSimilarityProvider similarityProvider) { }
        public class EquallyWeightedSimilarityProvider : JetBrains.Application.ExceptionReport.ExceptionStackTrace.IWeightedSimilarityProvider
        {
            public double EvaluateW0(int k) { }
            public double FrameWeight(int k, int i, double w0) { }
        }
        public interface IWeightedSimilarityProvider
        {
            double EvaluateW0(int length);
            double FrameWeight(int length, int index, double w0);
        }
        public class LinearWeightedSimilarityProvider : JetBrains.Application.ExceptionReport.ExceptionStackTrace.IWeightedSimilarityProvider
        {
            public double EvaluateW0(int k) { }
            public double FrameWeight(int k, int i, double w0) { }
        }
    }
    public class ExceptionStackTraceCache : System.IDisposable
    {
        public ExceptionStackTraceCache() { }
        public void Dispose() { }
        public JetBrains.Application.ExceptionReport.ExceptionStackFrame GetStackFrame(string fqtn, string method, string parameters, int index, bool isAnonymous) { }
        public JetBrains.Application.ExceptionReport.ExceptionStackTrace GetStackTrace(JetBrains.Application.ExceptionReport.PersistableExceptionData data) { }
    }
    public class static ExceptionStackTraceParser
    {
        public static JetBrains.Application.ExceptionReport.ExceptionStackTrace Parse(string text, bool needExceptionClasses, bool needExceptionMessages, JetBrains.Application.ExceptionReport.ExceptionStackTraceCache exceptionStackTraceCache) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Application.ExceptionReport.ExceptionStackFrame[] Parse(string text) { }
    }
    public abstract class ExceptionStorageLocator
    {
        protected const string ExceptionStorage = "ExceptionStorage";
        public virtual bool StoresExceptions { get; }
        public abstract JetBrains.Util.FileSystemPath GetStorageLocation();
    }
    public enum ExceptionSubmissionAction
    {
        NewIssue = 0,
        Comment = 1,
    }
    public class ExceptionSubmissionResult
    {
        protected ExceptionSubmissionResult() { }
        public JetBrains.Application.ExceptionReport.ExceptionSubmissionAction Action { get; }
        public string IssueId { get; }
        public System.Uri IssueUri { get; }
        public string Message { get; set; }
        public JetBrains.Application.ExceptionReport.ExceptionSubmissionStatus Status { get; }
        public System.DateTime WhenSubmitted { get; }
        public static JetBrains.Application.ExceptionReport.ExceptionSubmissionResult CreateConnectionProblem(string message) { }
        public static JetBrains.Application.ExceptionReport.ExceptionSubmissionResult CreateContentProblem(string message) { }
        public static JetBrains.Application.ExceptionReport.ExceptionSubmissionResult CreateLoginProblem(string message) { }
        public static JetBrains.Application.ExceptionReport.ExceptionSubmissionResult CreateSuccess(string issueId, string message, JetBrains.Application.ExceptionReport.ExceptionSubmissionAction action, System.Uri uri) { }
        public class ServerAction
        {
            public ServerAction([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.ExceptionReport.ExceptionData> action) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Action<JetBrains.Application.ExceptionReport.ExceptionData> Action { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string Text { get; }
        }
    }
    public enum ExceptionSubmissionStatus
    {
        Success = 0,
        LoginProblem = 1,
        ConnectionProblem = 2,
        ContentProblem = 3,
    }
    public interface IExceptionReportDataProvider
    {
        void ProvideExceptionData([JetBrains.Annotations.NotNullAttribute()] System.Exception ex);
    }
    public interface IExceptionReportService
    {
        void Log([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionData exception);
        void Notify([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionData exception);
        void RequireAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionData exception);
    }
    public interface IExceptionReportStrategy
    {
        void Process([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionData exception, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.IExceptionReportService service, JetBrains.Application.Progress.ITaskExecutor taskExecutor);
    }
    public interface IExceptionStorageBehavior
    {
        bool StoreExceptions { get; }
    }
    public interface IExceptionSubmitter
    {
        System.Threading.ThreadExceptionEventHandler ExceptionHandler { get; }
        public event JetBrains.Application.ExceptionReport.SubmitProgressEventHandler SubmitProgress;
        JetBrains.Application.ExceptionReport.SubmissionResult SubmitException(System.Exception e, string description, string userName, string password, int buildNumber, System.Net.IWebProxy proxy, string prevExceptionText);
    }
    public interface IIssueTracker
    {
        bool IsInternal { set; }
        System.Nullable<JetBrains.Application.ExceptionReport.LoginInformation> Register();
        void SubmitException([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionData exception, JetBrains.Application.ExceptionReport.LoginInformation loginInformation, [JetBrains.Annotations.NotNullAttribute()] string description, System.Net.IWebProxy proxy, System.Windows.Forms.IWin32Window parentWindow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        void SubmitFeedback(JetBrains.Application.ExceptionReport.LoginInformation loginInformation, [JetBrains.Annotations.NotNullAttribute()] string feedback, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        JetBrains.Application.ExceptionReport.CredentialsVerificationResult VerifyCredentials(JetBrains.Application.ExceptionReport.LoginInformation loginInformation, System.Net.IWebProxy proxy);
    }
    public struct LoginInformation
    {
        public bool IsEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Password { get; set; }
        public bool SubmitAnonymously { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string UserName { get; set; }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class ManagedThreadNameExceptionReportDataProvider : JetBrains.Application.ExceptionReport.IExceptionReportDataProvider { }
    public class NullExceptionStorageLocator : JetBrains.Application.ExceptionReport.ExceptionStorageLocator
    {
        public override bool StoresExceptions { get; }
        public override JetBrains.Util.FileSystemPath GetStorageLocation() { }
    }
    public class PersistableExceptionData
    {
        public static readonly string ExternalDataKey;
        [JetBrains.Annotations.NotNullAttribute()]
        protected string myHash;
        public PersistableExceptionData(System.Version productVersion = null, System.Nullable<System.DateTime> whenHappened = null) { }
        public PersistableExceptionData([JetBrains.Annotations.NotNullAttribute()] System.Exception exception, System.Version productVersion = null, System.Nullable<System.DateTime> whenHappened = null) { }
        public PersistableExceptionData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ExceptionReport.ExceptionData exceptionData) { }
        public System.Collections.IDictionary Data { get; set; }
        public System.Type ExceptionType { get; set; }
        public string FullStacktrace { get; }
        public string Hash { get; }
        public string HeaderText { get; }
        public string Message { get; set; }
        public int NumberOfTimesHappened { get; set; }
        public string PersistedFileName { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Version ProductVersion { get; set; }
        public JetBrains.Util.ExceptionText RenderedException { get; set; }
        public JetBrains.Application.ExceptionReport.ExceptionSubmissionResult ServerAction { get; set; }
        public string StackTrace { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string TechnicalInformation { get; }
        public System.DateTime WhenLastHappened { get; set; }
        public static void AddExternalDataLine(System.Exception ex, string line) { }
        public JetBrains.Application.ExceptionReport.ExceptionData ToExceptionData(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class PlatformSccRevisionExceptionReportDataProvider : JetBrains.Application.ExceptionReport.IExceptionReportDataProvider { }
    public class ProductExceptionStorageLocator : JetBrains.Application.ExceptionReport.ExceptionStorageLocator
    {
        public ProductExceptionStorageLocator([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.Components.AnyProductSettingsLocation settingsLocation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor applicationDescriptor, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<bool> storeExceptions = null) { }
        public override bool StoresExceptions { get; }
        public override JetBrains.Util.FileSystemPath GetStorageLocation() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ProductSccRevisionExceptionReportDataProvider : JetBrains.Application.ExceptionReport.IExceptionReportDataProvider { }
    public class ReportAllExceptionReportStrategy : JetBrains.Application.ExceptionReport.IExceptionReportStrategy
    {
        public void Process(JetBrains.Application.ExceptionReport.ExceptionData exception, JetBrains.Application.ExceptionReport.IExceptionReportService service, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
    }
    public class StoringExceptionReportService : JetBrains.Application.ExceptionReport.IExceptionReportService
    {
        public StoringExceptionReportService() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.ExceptionReport.ExceptionData> Exceptions { get; }
    }
    public class SubmissionResult
    {
        public readonly bool IsUpdated;
        public readonly System.Xml.XmlDocument RequestDescription;
        public readonly int ThreadId;
        public SubmissionResult(int threadId, bool isUpdated, System.Xml.XmlDocument requestDescription) { }
    }
    public class SubmitNothingExceptionReportStrategy : JetBrains.Application.ExceptionReport.IExceptionReportStrategy
    {
        public void Process(JetBrains.Application.ExceptionReport.ExceptionData exception, JetBrains.Application.ExceptionReport.IExceptionReportService service, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
    }
    public class SubmitProgressEventArgs : System.EventArgs
    {
        public string Message;
        public SubmitProgressEventArgs(string message) { }
    }
    public delegate void SubmitProgressEventHandler(object sender, JetBrains.Application.ExceptionReport.SubmitProgressEventArgs e);
    public class TempFolderExceptionStorageLocator : JetBrains.Application.ExceptionReport.ExceptionStorageLocator
    {
        public TempFolderExceptionStorageLocator() { }
        public TempFolderExceptionStorageLocator(string folderName) { }
        public override JetBrains.Util.FileSystemPath GetStorageLocation() { }
    }
    public class UIProgressIndicatorWrapper : JetBrains.Application.Progress.IProgressIndicator, System.IDisposable
    {
        public UIProgressIndicatorWrapper(JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Threading.IThreading threading) { }
        public string CurrentItemText { set; }
        public bool IsCanceled { get; }
        public string TaskName { get; set; }
        public void Advance(double units) { }
        public void Dispose() { }
        public void Start(int totalWorkUnits) { }
        public void Stop() { }
    }
}
namespace JetBrains.Application.Extensions
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ExtensionLocations
    {
        public ExtensionLocations(JetBrains.Application.IApplicationDescriptor product, JetBrains.Application.Env.Components.ProductSettingsLocation settingsLocation, JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ExtensionComponentSearchPaths { get; }
        public JetBrains.Util.FileSystemPath UserExtensionSettingsFilePath { get; }
        public virtual JetBrains.Util.FileSystemPath GetBaseLocation(System.Environment.SpecialFolder basefolder, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
        public virtual JetBrains.Util.FileSystemPath GetBaseLocation(System.Environment.SpecialFolder basefolder, JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, JetBrains.Application.IProductNameAndVersion product = null) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ExtensionManager
    {
        public ExtensionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtensionProvider> providers, JetBrains.Application.Extensions.IExtensionSettings settings) { }
        public JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtension> AllExtensions { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionProvider> Providers { get; }
        public JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtension> SupportedExtensions { get; }
        public JetBrains.Application.Extensions.IExtension GetExtension(string id) { }
        public bool IsInstalled(string id) { }
        public bool IsInstalled(string id, string semanticVersion) { }
    }
    public class static ExtensionManagerEx
    {
        public static System.Collections.Generic.IList<string> GetAllDependencies(this JetBrains.Application.Extensions.ExtensionManager extensionManager, string id) { }
        public static System.Collections.Generic.HashSet<string> GetAllDependents(this JetBrains.Application.Extensions.ExtensionManager extensionManager, string id) { }
        public static System.Collections.Generic.IList<JetBrains.Application.Extensions.IExtension> GetKnownExtensions(this JetBrains.Application.Extensions.ExtensionManager extensionManager) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ExtensionPluginSource : JetBrains.Application.PluginSupport.IPluginSource
    {
        public ExtensionPluginSource(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.Application.IApplicationDescriptor product, JetBrains.Threading.IThreading threading) { }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.PluginSourceInfo> PluginSources { get; }
    }
    public class ExtensionRecord : System.IEquatable<JetBrains.Application.Extensions.ExtensionRecord>
    {
        public ExtensionRecord(JetBrains.Application.Extensions.ExtensionRecord.SeverityLevel severity, [JetBrains.Annotations.NotNullAttribute()] string sender, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText message, System.Exception exception = null) { }
        public System.Exception Exception { get; }
        public JetBrains.UI.RichText.RichText Message { get; }
        public string Sender { get; }
        public JetBrains.Application.Extensions.ExtensionRecord.SeverityLevel Severity { get; }
        public bool Equals(JetBrains.Application.Extensions.ExtensionRecord other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public enum SeverityLevel
        {
            Info = 0,
            Warning = 1,
            Error = 2,
        }
    }
    public class static ExtensionRecordEx
    {
        public static void AddDiscoveredFilesMessage(this JetBrains.Application.Extensions.IExtension extension, object sender, string fileType, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> files) { }
        public static void AddInfo(this JetBrains.Application.Extensions.IExtension extension, object sender, string message) { }
        public static void AddWarning(this JetBrains.Application.Extensions.IExtension extension, object sender, string message) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExtensionRepositoryManager
    {
        public ExtensionRepositoryManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtensionRepository> repositories) { }
        public bool CanUninstall(string id) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<string> GetExtensionsRequiringRestart() { }
        public bool HasMissingExtensions() { }
        public void RestoreMissingExtensions() { }
        public void Uninstall(string id, bool removeDependencies, System.Action<JetBrains.Util.LoggingLevel, string> logger) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ExtensionSettings : JetBrains.Application.Extensions.IExtensionSettings
    {
        public ExtensionSettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
        public bool IsEnabled(string extensionId) { }
        public void SetEnabledStatus(string extensionId, bool enabled) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExtensionSettingsLoader
    {
        public const string FileType = "settings";
        public ExtensionSettingsLoader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.Threading.IThreading threading, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behaviour, JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers userInjectedSettingsLayers, JetBrains.Application.Extensions.ExtensionsSettingsMountPointProvider extensionsSettingsMountPointProvider) { }
        public void ReportDiscoveredSettingsFiles(JetBrains.Application.Extensions.IExtension extension, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> settingsFiles) { }
        public void ReportDiscoveringSettingsFiles(JetBrains.Application.Extensions.IExtension extension) { }
        public void ReportLoadingSettingsFiles(JetBrains.Application.Extensions.IExtension extension, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> settingsFiles) { }
        public void ReportRemovingSettingsFiles(JetBrains.Application.Extensions.IExtension extension, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> settingsFiles) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExtensionsSettingsMountPointProvider : JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.ISettingsStorageMountPoint>
    {
        public ExtensionsSettingsMountPointProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behaviour, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
        public JetBrains.DataFlow.IProperty<System.Windows.Media.ImageSource> Icon { get; }
        public JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity Id { get; }
    }
    public interface IExtension
    {
        JetBrains.DataFlow.IProperty<System.Nullable<bool>> Enabled { get; }
        string Id { get; }
        JetBrains.Application.Extensions.IExtensionMetadata Metadata { get; }
        JetBrains.DataFlow.ListEvents<JetBrains.Application.Extensions.ExtensionRecord> RuntimeInfoRecords { get; }
        string SemanticVersion { get; }
        JetBrains.Application.Extensions.IExtensionProvider Source { get; }
        bool Supported { get; }
        System.Version Version { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetFiles(string fileType);
    }
    public interface IExtensionCatalog
    {
        string Name { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> GetExtensions(string searchTerm, bool includePrerelease, JetBrains.Application.Extensions.SortOrder sortOrder);
        int GetExtensionsCount(string searchTerm, bool includePrerelease);
        System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> GetUpdates(bool includePrerelease);
        bool Install(JetBrains.Application.Extensions.IExtensionCatalogItem catalogItem, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events);
        bool Update(JetBrains.Application.Extensions.IExtensionCatalogItem catalogItem, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events);
        bool Update(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> catalogItems, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events);
    }
    public interface IExtensionCatalogActionEvents
    {
        bool AcceptLicenses(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> extensions);
        void Log(JetBrains.Util.LoggingLevel level, string message);
        void ProgressAvailable(string operation, int percentComplete);
    }
    public interface IExtensionCatalogItem
    {
        System.Uri AbuseUrl { get; }
        System.Nullable<int> DownloadCount { get; }
        System.Uri GalleryUrl { get; }
        string Id { get; }
        JetBrains.Application.Extensions.IExtensionMetadata Metadata { get; }
        string ReleaseNotes { get; }
        JetBrains.DataFlow.ListEvents<JetBrains.Application.Extensions.ExtensionRecord> RuntimeInfoRecords { get; }
        string SemanticVersion { get; }
        bool Supported { get; }
    }
    public interface IExtensionCatalogProvider
    {
        JetBrains.Application.Extensions.IExtensionCatalog AggregateCatalog { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalog> Catalogs { get; }
    }
    public interface IExtensionMetadata
    {
        System.Collections.Generic.IEnumerable<string> Authors { get; }
        string Copyright { get; }
        System.Nullable<System.DateTimeOffset> Created { get; }
        System.Collections.Generic.IEnumerable<string> DependencyDescriptions { get; }
        System.Collections.Generic.IEnumerable<string> DependencyIds { get; }
        string Description { get; }
        System.Uri IconUrl { get; }
        System.Uri LicenseUrl { get; }
        System.Collections.Generic.IEnumerable<string> Owners { get; }
        bool PreRelease { get; }
        System.Uri ProjectUrl { get; }
        string Summary { get; }
        System.Collections.Generic.IEnumerable<string> Tags { get; }
        string Title { get; }
    }
    public interface IExtensionProvider
    {
        JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtension> Extensions { get; }
        string Name { get; }
    }
    public interface IExtensionRepository
    {
        bool CanUninstall(string id);
        System.Collections.Generic.IEnumerable<string> GetExtensionsRequiringRestart();
        bool HasMissingExtensions();
        void RestoreMissingExtensions();
        void Uninstall(string id, bool removeDependencies, System.Collections.Generic.IEnumerable<string> dependencies, System.Action<JetBrains.Util.LoggingLevel, string> logger);
    }
    public interface IExtensionSettings
    {
        bool IsEnabled(string extensionId);
        void SetEnabledStatus(string extensionId, bool enabled);
    }
    public enum SortOrder
    {
        None = 0,
        NameAscending = 1,
        NameDescending = 2,
        MostDownloads = 3,
        MostRecent = 4,
        Relevance = 5,
    }
}
namespace JetBrains.Application.FileSystemTracker
{
    
    public class DirectoryRescanner
    {
        public DirectoryRescanner(JetBrains.DataFlow.Lifetime lifetime, System.Func<JetBrains.Util.FileSystemPath, bool> isIgnoredFolderFunc) { }
        public void CancelScan(JetBrains.Util.FileSystemPath dir) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.Application.FileSystemTracker.DirectoryRescanner.ScanCookie> GetCurrentlyScanned() { }
        public void RescanFolder(JetBrains.Util.JetFileSystemWatcher watcher, System.Action<JetBrains.Util.JetFileSystemWatcher, JetBrains.ProjectModel.Impl.FileSystemChangesPathTrie> commitAction) { }
        public class ScanCookie
        {
            public System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) Cancelled;
            public readonly System.Action<JetBrains.Util.JetFileSystemWatcher, JetBrains.ProjectModel.Impl.FileSystemChangesPathTrie> CommitAction;
            public readonly JetBrains.Application.FileSystemTracker.DirectoryRescanner DirectoryRescanner;
            public readonly JetBrains.Util.JetFileSystemWatcher Watcher;
            public ScanCookie(System.Action<JetBrains.Util.JetFileSystemWatcher, JetBrains.ProjectModel.Impl.FileSystemChangesPathTrie> commitAction, JetBrains.Util.JetFileSystemWatcher watcher, JetBrains.Application.FileSystemTracker.DirectoryRescanner directoryRescanner) { }
        }
    }
    public enum FileSystemTrackerDumpFlags
    {
        WatchersState = 1,
        AccumulatedChanges = 2,
        PendingChanges = 4,
        All = 7,
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class FileSystemTrackerImpl : JetBrains.Application.FileSystemTracker.IFileSystemTracker, JetBrains.Util.JetFileSystemWatcher.IWatcherEvents
    {
        protected JetBrains.ProjectModel.Impl.FileSystemChangesPathTrie myAccumulatedChanges;
        protected readonly object myAccumulatedChangesLock;
        protected readonly System.Collections.Generic.Dictionary<JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie, JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.Watcher> myRequestToWatcher;
        public FileSystemTrackerImpl(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Threading.IThreading threading, JetBrains.Application.Env.RunsProducts.ProductConfigurations conf = null) { }
        public virtual JetBrains.DataFlow.IProperty<bool> AutoCommitEnabled { get; }
        public virtual JetBrains.DataFlow.ISignal<JetBrains.ProjectModel.FileSystemChange> Changed { get; }
        public virtual bool Enabled { get; set; }
        public void AdviseDirectoryChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath path, bool watchRecursively, System.Action<JetBrains.ProjectModel.FileSystemChangeDelta> onChangeAction) { }
        public virtual JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseDirectoryChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath directoryPath, bool watchRecursively) { }
        public virtual JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseDirectoryChanges(JetBrains.Util.FileSystemPath directoryPath, bool watchRecursively) { }
        public virtual JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseFileChanges(JetBrains.Util.FileSystemPath filePath) { }
        public virtual void AdviseFileChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath path, System.Action<JetBrains.ProjectModel.FileSystemChangeDelta> onChangeAction) { }
        public virtual JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseFileChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath filePath) { }
        public virtual void CheckConsistency() { }
        protected void ClearChanges() { }
        public virtual void CommitChanges(JetBrains.Util.FileSystemPath[] paths = null) { }
        public virtual void DumpState(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath prefix, JetBrains.Application.FileSystemTracker.FileSystemTrackerDumpFlags flags = 7) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> GetAccumulatedChangesAndFlush(JetBrains.Util.FileSystemPath[] paths) { }
        public void IgnoreChangesInFolder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath folderPath) { }
        public bool IsDirectoryBeingWatched(JetBrains.Util.FileSystemPath directory) { }
        public void ProcessPendingRescans() { }
        public void ProcessPendingWatchers() { }
        public void SuppressAutoCommit(JetBrains.DataFlow.Lifetime lifetime, object suppresser) { }
        protected virtual void TryInitFileSystemWatcher(JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.Watcher watcher) { }
        public virtual void UnadviseChanges(params JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie[] requestCookies) { }
        protected class Watcher
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.Util.JetFileSystemWatcher FileSystemWatcher;
            public JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.WatcherNullReason FileSystemWatcherNullReason;
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.WatcherData WatcherData;
            public Watcher(JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.WatcherData path, JetBrains.Util.JetFileSystemWatcher fileSystemWatcher) { }
            public void Dump(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath volativePrefix) { }
        }
        protected class WatcherData : System.IEquatable<JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.WatcherData>
        {
            public readonly string Filter;
            public readonly bool IsRecursive;
            public readonly JetBrains.Util.FileSystemPath Path;
            public WatcherData(JetBrains.Util.FileSystemPath path, bool isRecursive, string filter) { }
            public bool Dominates(JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.WatcherData otherData) { }
            public bool Equals(JetBrains.Application.FileSystemTracker.FileSystemTrackerImpl.WatcherData watcherData) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            public string ToString(JetBrains.Util.FileSystemPath volatilePrefix) { }
        }
        protected enum WatcherNullReason
        {
            NoDirectory = 0,
            WatcherError = 1,
        }
    }
    public class FileSystemTrackerRequestCookie
    {
        public bool IsDirectory { get; }
        public bool IsRecursive { get; }
        public bool IsValid { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public void Dump(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath volatilePrefix) { }
        public bool Equals(JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public interface IFileSystemTracker
    {
        [System.ObsoleteAttribute("Use SuppressAutoCommit instead")]
        JetBrains.DataFlow.IProperty<bool> AutoCommitEnabled { get; }
        JetBrains.DataFlow.ISignal<JetBrains.ProjectModel.FileSystemChange> Changed { get; }
        bool Enabled { get; set; }
        JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseDirectoryChanges(JetBrains.Util.FileSystemPath directoryPath, bool watchRecursively);
        JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseDirectoryChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath directoryPath, bool watchRecursively);
        void AdviseDirectoryChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath path, bool watchRecursively, System.Action<JetBrains.ProjectModel.FileSystemChangeDelta> onChangeAction);
        JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseFileChanges(JetBrains.Util.FileSystemPath filePath);
        JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie AdviseFileChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath filePath);
        void AdviseFileChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath path, System.Action<JetBrains.ProjectModel.FileSystemChangeDelta> onChangeAction);
        void CheckConsistency();
        void CommitChanges(JetBrains.Util.FileSystemPath[] paths = null);
        void DumpState(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath prefix, JetBrains.Application.FileSystemTracker.FileSystemTrackerDumpFlags flags = 7);
        void IgnoreChangesInFolder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath folderPath);
        void SuppressAutoCommit(JetBrains.DataFlow.Lifetime lifetime, object suppresser);
        void UnadviseChanges(params JetBrains.Application.FileSystemTracker.FileSystemTrackerRequestCookie[] requestCookies);
    }
}
namespace JetBrains.Application.Install
{
    
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.Application.Install.IAssemblyAttributeInstaller<>))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class AssemblyAttributeInstallerAttribute : JetBrains.Application.Install.InstallerAttributeBase
    {
        public AssemblyAttributeInstallerAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type typeAttributeToInstall, JetBrains.Application.Install.InstallerVsVersionAffinity vsversionaffinity) { }
        public System.Type AttributeToInstall { get; }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Neutral)]
    public class BindingRedirectionsInstaller : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute>
    {
        public class AssemblyBindingRedirections
        {
            public AssemblyBindingRedirections([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assname, JetBrains.Build.AllAssemblies.AssemblyKind kind) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
            public string Culure { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string Name { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string NewVersionString { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string OldVersionString { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public byte[] PublicKeyTokenBytes { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string PublicKeyTokenString { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Version VersionSourceHigh { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Version VersionSourceLow { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Version VersionTarget { get; }
        }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Neutral)]
    public class DirectoryInstaller : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute> { }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.Application.Install.InstallFileAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Neutral)]
    public class FileInstaller : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.Application.Install.InstallFileAttribute> { }
    public interface IAssemblyAttributeInstaller<in TAttribute>
        where in TAttribute : System.Attribute
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.Install.InstallationData.InstallationData Install([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer, [JetBrains.Annotations.NotNullAttribute()] System.Reflection.Assembly assembly, [JetBrains.Annotations.NotNullAttribute()] TAttribute attribute);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class InstallBindingRedirectionsConfigFileAttribute : System.Attribute
    {
        public InstallBindingRedirectionsConfigFileAttribute([JetBrains.Annotations.NotNullAttribute()] string sTargetConfigFileName) { }
        public InstallBindingRedirectionsConfigFileAttribute([JetBrains.Annotations.NotNullAttribute()] string sTargetConfigFileName, JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2 sourceroot, [JetBrains.Annotations.CanBeNullAttribute()] string sSourceRelativePath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string SourceRelativePath { get; }
        public JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2 SourceRoot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string TargetConfigFileName { get; }
    }
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Neutral)]
    public class InstallDirInstaller : JetBrains.Application.Install.IStaticInstaller
    {
        public static readonly string RegistryCompanyNameValueName;
        public static readonly string RegistryInstallDirValueName;
        public static readonly string RegistryProductDIsplayNameValueName;
        public static readonly string RegistryProductFullNameValueName;
        public static readonly string RegistryProductNameValueName;
        public static readonly string RegistryProductVersionValueName;
    }
    public class Installer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> AssemblyConfigurations;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string AssemblyConfigurationsString;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.Application.Install.InstallationData.InstallationData> BeforeInstallationDataHarvestComplete;
        public readonly JetBrains.Metadata.Reader.API.MetadataLoader MetadataLoader;
        protected JetBrains.Util.OneToSetMap<System.Type, object> myMapAssemblyAttributeToInstallers;
        protected System.Collections.Generic.Dictionary<System.Type, object> myMapInstallerTypeToInstance;
        protected JetBrains.Util.OneToSetMap<System.Type, JetBrains.Application.Install.ITypeAttributeInstaller> myMapTypeAttributeToInstallers;
        protected System.Collections.Generic.HashSet<JetBrains.Application.Install.IStaticInstaller> myStaticInstallers;
        public Installer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string sAssemblyConfigurations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer.InstallerBaseFolders basefolders) { }
        public JetBrains.Application.IApplicationDescriptor ApplicationDescriptor { get; }
        public bool IsVsVersionNeutral { get; }
        protected JetBrains.Util.OneToSetMap<System.Type, object> MapAssemblyAttributeToInstallers { get; }
        public System.Collections.Generic.Dictionary<System.Type, object> MapInstallerTypeToInstance { get; }
        protected JetBrains.Util.OneToSetMap<System.Type, JetBrains.Application.Install.ITypeAttributeInstaller> MapTypeAttributeToInstallers { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Parts.IPartsCatalogue PartsCatalogue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Install.Installer.InstallerSourceFoldersResolver SourceFoldersResolver { get; }
        protected System.Collections.Generic.HashSet<JetBrains.Application.Install.IStaticInstaller> StaticInstallers { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string VsHive { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string VsRootSuffix { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Version VsVersion { get; set; }
        protected void CollectInstallers() { }
        public void ComSelfRegister(JetBrains.Application.Install.RegistrationStage stage) { }
        public static void DumpInstallationData(JetBrains.Application.Install.InstallationData.InstallationData data, JetBrains.Util.FileSystemPath sRegistryRegistrationDataFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Install.InstallationData.InstallationData GetInstallationData() { }
        protected void InvokeAssemblyAttributeInstallers(JetBrains.Application.Install.InstallationData.InstallationData retval) { }
        protected void InvokeStaticInstallers(JetBrains.Application.Install.InstallationData.InstallationData total) { }
        protected void InvokeTypeAttributeInstallers(JetBrains.Application.Install.InstallationData.InstallationData retval) { }
        public class InstallerBaseFolders
        {
            public InstallerBaseFolders(JetBrains.Util.FileSystemPath productHomeDir, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath productBinariesDir) { }
        }
        public class InstallerSourceFoldersResolver
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Install.Installer.InstallerBaseFolders BaseFolders;
            [JetBrains.Annotations.NotNullAttribute()]
            public static readonly string ReferencesDirectoryName;
            public InstallerSourceFoldersResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer.InstallerBaseFolders basefolders, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allAssembliesXml) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> FindFilesInProductBinariesDir([JetBrains.Annotations.NotNullAttribute()] string mask) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> FindFilesInReferencesDirectories([JetBrains.Annotations.NotNullAttribute()] string mask, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml.Subplatform subplatform) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> FindFilesUnderRoot(JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2 root, [JetBrains.Annotations.NotNullAttribute()] string mask, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assembly) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Util.FileSystemPath GetProductBinariesDir() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Util.FileSystemPath GetProductReferencesDir() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Util.FileSystemPath GetRootDirectory(JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2 root, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assembly) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Util.FileSystemPath GetSubplatformReferencesDir([JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml.Subplatform subplatform) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Util.FileSystemPath GetSubplatformReferencesDir([JetBrains.Annotations.NotNullAttribute()] string sSubplatformName) { }
        }
    }
    public abstract class InstallerAttributeBase : System.Attribute
    {
        public InstallerAttributeBase(JetBrains.Application.Install.InstallerVsVersionAffinity vsVersionAffinity) { }
        public JetBrains.Application.Install.InstallerVsVersionAffinity VsVersionAffinity { get; }
    }
    public enum InstallerVsVersionAffinity
    {
        Neutral = 0,
        Specific = 1,
        CallAlways = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class InstallFileAttribute : System.Attribute
    {
        public InstallFileAttribute([JetBrains.Annotations.NotNullAttribute()] string id, JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot targetroot, [JetBrains.Annotations.NotNullAttribute()] string sTargetRelativeDir, JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2 sourceroot, [JetBrains.Annotations.NotNullAttribute()] string sSourceRelativePath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string SourceRelativePath { get; }
        public JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2 SourceRoot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath TargetRelativeDir { get; }
        public JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot TargetRoot { get; }
    }
    public class InstallFromReferencesDirectoryAttribute : System.Attribute
    {
        public InstallFromReferencesDirectoryAttribute([JetBrains.Annotations.NotNullAttribute()] string id, JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot targetRoot, [JetBrains.Annotations.NotNullAttribute()] string targetRelativeDir, [JetBrains.Annotations.NotNullAttribute()] string sourceRelativeDir, JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute.Recursive recursive, bool allowEmpty = False) { }
        public bool AllowEmpty { get; }
        public string Id { get; }
        public bool IsRecursive { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath SourceRelativeDir { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath TargetRelativeDir { get; }
        public JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot TargetRoot { get; }
        public enum Recursive
        {
            No = 0,
            Yes = 1,
        }
    }
    public interface IRequiresCommit
    {
        JetBrains.Application.Install.InstallationData.InstallationData Commit(JetBrains.Application.Install.Installer installer);
    }
    public interface IStaticInstaller
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.Install.InstallationData.InstallationData InstallStatic(JetBrains.Application.Install.Installer installer);
    }
    public interface ITypeAttributeInstaller
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.Install.InstallationData.InstallationData InstallInstance(JetBrains.Application.Install.Installer installer, [JetBrains.Annotations.NotNullAttribute()] System.Type attributeOwner, [JetBrains.Annotations.NotNullAttribute()] object attributeInstance);
    }
    public class static LocalInstaller
    {
        public static void Install(JetBrains.Application.Install.InstallationData.InstallationData dataxml, JetBrains.Application.Install.RegistrationStage stage, System.Collections.Generic.IDictionary<string, string> macros, System.Func<JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot, JetBrains.Util.FileSystemPath> ResolveTargetDirRoot, System.Action<string> LogMessage, JetBrains.Application.Install.LocalInstaller.IsolationOptions isIsolatedToProductBinariesDir) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath ResolveTargetDirRoot([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer, JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot root) { }
        public enum IsolationOptions
        {
            NotIsolated = 0,
            IsolatedToProductBinariesDir = 1,
        }
    }
    public enum RegistrationStage
    {
        Register = 0,
        Unregister = 1,
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.Application.Install.IStaticInstaller))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class StaticInstallerAttribute : JetBrains.Application.Install.InstallerAttributeBase
    {
        public StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity vsversionaffinity) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.Application.Install.ITypeAttributeInstaller))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class TypeAttributeInstallerAttribute : JetBrains.Application.Install.InstallerAttributeBase
    {
        public TypeAttributeInstallerAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type typeAttributeToInstall, JetBrains.Application.Install.InstallerVsVersionAffinity vsversionaffinity) { }
        public System.Type AttributeToInstall { get; }
    }
}
namespace JetBrains.Application.Install.Guids
{
    
    public class GuidEntry
    {
        public System.Guid Guid { get; set; }
        public bool IsDefineConstant { get; set; }
        public JetBrains.Application.Install.Guids.GuidEntryKey Key { get; set; }
        public override string ToString() { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Application.Install.Guids.GuidEntryKeyConverter))]
    public sealed class GuidEntryKey : System.IEquatable<JetBrains.Application.Install.Guids.GuidEntryKey>
    {
        public GuidEntryKey([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.Install.Guids.GuidEntryKey other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class GuidEntryKeyConverter : System.ComponentModel.TypeConverter
    {
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { }
    }
    public class static GuidEntryKeys { }
    public class GuidStore
    {
        public GuidStore() { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public string AutoGuidCategory { get; set; }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Collections.Generic.List<JetBrains.Application.Install.Guids.GuidEntry> Entries { get; }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Collections.Generic.List<JetBrains.Application.Install.Guids.GuidEntry> ProposedEntries { get; }
        public System.Guid GetEntry([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Guids.GuidEntryKey key) { }
        public System.Nullable<System.Guid> TryGetEntry([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Guids.GuidEntryKey key) { }
        public System.Guid TryGetEntryOrPropose([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Guids.GuidEntryKey key) { }
    }
}
namespace JetBrains.Application.Install.InstallationData
{
    
    public class InstallationData
    {
        public InstallationData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.InstallationData.InstalledRegistry registry, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.Application.Install.InstallationData.InstalledFolder[] folders) { }
        public InstallationData() { }
        public InstallationData(JetBrains.Application.Install.InstallationData.InstalledRegistry registry) { }
        public InstallationData(JetBrains.Application.Install.InstallationData.InstalledFolder folder) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Install.InstallationData.InstalledFolder> Folders { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Install.InstallationData.InstalledRegistry Registry { get; }
        public void AssertValid() { }
        public void MergeWith(JetBrains.Application.Install.InstallationData.InstallationData addon) { }
        public void RemoveDuplicates() { }
    }
    public enum InstallationMacroName
    {
        PackageCodeBase = 0,
        SystemDir = 1,
        ProductBinariesDir = 2,
        DateTime = 3,
    }
    public enum InstallationSourceDirRoot2
    {
        ProductBinariesDir = 0,
        ReferencesDirectories = 1,
    }
    public enum InstallationTargetDirRoot
    {
        InstallDir = 0,
        DevEnvInstallDir = 1,
        DevEnvRootDir = 2,
    }
    public sealed class InstalledFile : JetBrains.Application.Install.InstallationData.InstalledFileItemBase, System.IComparable<JetBrains.Application.Install.InstallationData.InstalledFile>, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledFile>
    {
        public readonly JetBrains.Util.Lazy.Lazy<JetBrains.DataFlow.PropertyBag> Metadata;
        public InstalledFile() { }
        public InstalledFile([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public InstalledFile([JetBrains.Annotations.NotNullAttribute()] string sSourceName, [JetBrains.Annotations.NotNullAttribute()] string sTargetName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string SourceName { get; set; }
        public override void AssertValid() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledFile other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.Util.JetTuple<JetBrains.Util.FileSystemPath, string>> GetFilesByMask([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSourceDir) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class InstalledFileAccessControl
    {
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.Application.Install.InstallationData.InstalledFileAccessControl> AccessControl;
        public readonly System.Collections.Generic.IList<JetBrains.Application.Install.InstallationData.InstalledFileAccessControl.AccessControlEntry> Entries;
        public InstalledFileAccessControl() { }
        public class AccessControlEntry
        {
            public JetBrains.Interop.WinApi.AccessRights AddPermissions;
            public bool IsContinueOnError;
            public System.Version MinOsVersion;
            public JetBrains.Application.Install.InstallationData.InstalledFileAccessControl.SidOrUsername Subject;
            public void AssertValid() { }
        }
        public class SidOrUsername
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.Application.Install.InstallationData.InstalledFileAccessControl.SidOrUsername FromSid(string sid) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.Application.Install.InstallationData.InstalledFileAccessControl.SidOrUsername FromUsername(string sid) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string TryGetSid() { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string TryGetUsername() { }
        }
    }
    public class InstalledFileItemBase : System.IComparable<JetBrains.Application.Install.InstallationData.InstalledFileItemBase>, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledFileItemBase>
    {
        public InstalledFileItemBase([JetBrains.Annotations.NotNullAttribute()] string sTargetName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TargetName { get; set; }
        public virtual void AssertValid() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledFileItemBase other) { }
        public override int GetHashCode() { }
    }
    public class InstalledFolder
    {
        public InstalledFolder() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Install.InstallationData.InstalledFileItemBase> Files { get; }
        public string Id { get; set; }
        public JetBrains.Util.FileSystemPath SourceDir2 { get; set; }
        public JetBrains.Util.FileSystemPath TargetDir { get; set; }
        public JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot TargetRoot { get; set; }
        public void AssertValid() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Install.InstallationData.InstallationData ToInstallationData() { }
    }
    public class InstalledRegistry
    {
        public InstalledRegistry() { }
        public InstalledRegistry([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Install.InstallationData.InstalledRegistryKey> keys, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Install.InstallationData.InstalledRegistryValue> values) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Install.InstallationData.InstalledRegistryKey> Keys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Install.InstallationData.InstalledRegistryValue> Values { get; }
        public void AssertValid() { }
        public void MergeWith([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.InstallationData.InstalledRegistry addon) { }
        public void RemoveDuplicates() { }
        public JetBrains.Application.Install.InstallationData.InstallationData ToInstallationData() { }
    }
    public enum InstalledRegistryHive
    {
        Hkcr = 0,
        Hklm = 1,
        Hkcu = 2,
        Hkmu = 3,
    }
    public class InstalledRegistryItemBase : System.IComparable<JetBrains.Application.Install.InstallationData.InstalledRegistryItemBase>, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledRegistryItemBase>
    {
        public InstalledRegistryItemBase(JetBrains.Application.Install.InstallationData.InstalledRegistryHive hive, [JetBrains.Annotations.NotNullAttribute()] string key) { }
        public JetBrains.Application.Install.InstallationData.InstalledRegistryHive Hive { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Key { get; set; }
        public virtual void AssertValid() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledRegistryItemBase other) { }
        public override int GetHashCode() { }
    }
    public class InstalledRegistryKey : JetBrains.Application.Install.InstallationData.InstalledRegistryItemBase, System.IComparable<JetBrains.Application.Install.InstallationData.InstalledRegistryKey>, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledRegistryKey>
    {
        public InstalledRegistryKey(JetBrains.Application.Install.InstallationData.InstalledRegistryHive hive, [JetBrains.Annotations.NotNullAttribute()] string key) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Install.InstallationData.InstalledRegistryKey CreateKey([JetBrains.Annotations.NotNullAttribute()] string relpath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Install.InstallationData.InstalledRegistryValue CreateValue([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] object value) { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledRegistryKey registryKeyXml) { }
        public override string ToString() { }
    }
    public class InstalledRegistryValue : JetBrains.Application.Install.InstallationData.InstalledRegistryItemBase, System.IComparable<JetBrains.Application.Install.InstallationData.InstalledRegistryValue>, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledRegistryValue>
    {
        public InstalledRegistryValue(JetBrains.Application.Install.InstallationData.InstalledRegistryHive hive, [JetBrains.Annotations.NotNullAttribute()] string key, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] object value) { }
        public bool IsPermanent { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Name { get; set; }
        public JetBrains.Application.Install.InstallationData.InstalledRegistryValueType Type { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Value { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public byte[] ValueBinary { get; }
        public override void AssertValid() { }
        public static string DumpBytesToPkgdefString(byte[] bytes) { }
        public static string DumpBytesToWixString(byte[] bytes) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledRegistryValue registryValueXml) { }
        public override int GetHashCode() { }
        public JetBrains.Application.Install.InstallationData.InstalledRegistry ToRegistry() { }
        public override string ToString() { }
    }
    public enum InstalledRegistryValueType
    {
        Dword = 0,
        String = 1,
        Binary = 2,
    }
    public class InstalledReplaceTextInFile : JetBrains.Application.Install.InstallationData.InstalledFileItemBase, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledReplaceTextInFile>
    {
        public JetBrains.Application.Install.InstallationData.InstalledReplaceTextInFile.FileTextEncoding Encoding { get; set; }
        public JetBrains.Util.FileSystemPath OriginalDir { get; set; }
        public string OriginalName { get; set; }
        public JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot OriginalRoot { get; set; }
        public override void AssertValid() { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledReplaceTextInFile other) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string FormatMacroReference(JetBrains.Application.Install.InstallationData.InstalledReplaceTextInFile.StandardMacros macro) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Text.Encoding ResolveEncoding(JetBrains.Application.Install.InstallationData.InstalledReplaceTextInFile.FileTextEncoding encoding) { }
        public enum FileTextEncoding
        {
            Undefined = 0,
            Utf8 = 1,
            Utf16le = 2,
        }
        public enum StandardMacros
        {
            InstallDirBackslashTerminated = 0,
            InstallDirBackslashTerminatedWithBackslashesDoubled = 1,
        }
    }
    public class InstalledShellLink : JetBrains.Application.Install.InstallationData.InstalledFileItemBase, System.IEquatable<JetBrains.Application.Install.InstallationData.InstalledShellLink>
    {
        public InstalledShellLink([JetBrains.Annotations.NotNullAttribute()] string sShellLinkFileTargetName, JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot shellLinkTargetRoot, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath shellLinkTargetDir, [JetBrains.Annotations.NotNullAttribute()] string shellLinkTargetName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath ShellLinkTargetDir { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string ShellLinkTargetName { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot ShellLinkTargetRoot { get; set; }
        public override void AssertValid() { }
        public bool Equals(JetBrains.Application.Install.InstallationData.InstalledShellLink other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.Application.Interop.NativeHook.ComImport
{
    
    [System.Runtime.InteropServices.GuidAttribute("E3403EA3-34BB-4689-9365-F875E55BC2BA")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IApplicationActiveStateChangeSink
    {
        void OnApplicationActiveStateChanged(int isActive);
    }
    [System.Runtime.InteropServices.GuidAttribute("CCF6531D-A313-484D-B678-B7058974AD43")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IForegroundIdleSink
    {
        void OnForegroundIdle();
    }
    [System.Runtime.InteropServices.GuidAttribute("6C225FA3-5BD4-4EA9-A418-794A726CB32D")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInputMessageSink
    {
        void OnInputMessage(System.Void* hwnd, uint message, System.Void* wParam, System.Void* lParam, JetBrains.Interop.WinApi.POINT* ppt);
    }
    [System.Runtime.InteropServices.GuidAttribute("D8DA2488-FDDC-43CB-9C2F-12EEDB08397D")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IKeyboardMessageSink
    {
        void OnKeyboardMessage(uint virtualKeyCode, uint keystrokeMessageFlags);
    }
    [System.Runtime.InteropServices.GuidAttribute("1C7785EB-3E51-43FF-B7B7-C4377915D20D")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMouseMessageSink
    {
        void OnMouseMessage(uint message, System.Void* hwnd, JetBrains.Interop.WinApi.POINT pt, uint wHitTestCode, System.UIntPtr dwExtraInfo);
    }
    [System.Runtime.InteropServices.GuidAttribute("E56A4995-41BE-4977-9B9D-57E3D0141AE6")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface INativeHookHandler
    {
        System.Void* AdviseApplicationActiveStateChange(JetBrains.Application.Interop.NativeHook.ComImport.IApplicationActiveStateChangeSink sink);
        System.Void* AdviseForegroundIdle(JetBrains.Application.Interop.NativeHook.ComImport.IForegroundIdleSink sink);
        System.Void* AdviseInputMessage(JetBrains.Application.Interop.NativeHook.ComImport.IInputMessageSink sink);
        System.Void* AdviseKeyboardMessage(JetBrains.Application.Interop.NativeHook.ComImport.IKeyboardMessageSink sink, int isIncludingNoRemove);
        System.Void* AdviseMouseMessage(JetBrains.Application.Interop.NativeHook.ComImport.IMouseMessageSink sink, int isIncludingNoRemove);
        System.Void* AdviseWindowClassMessage(JetBrains.Application.Interop.NativeHook.ComImport.IWindowMessageSink sink, string className, uint dwMessage, int isDeferredProcessingAllowed);
        System.Void* AdviseWindowMessage(JetBrains.Application.Interop.NativeHook.ComImport.IWindowMessageSink sink, System.Void* hwnd, uint dwMessage, int isIncludingParentWindows, int isDeferredProcessingAllowed);
        System.Void* AdviseWindowRootParentChange(JetBrains.Application.Interop.NativeHook.ComImport.IWindowRootParentChangeSink sink, System.Void* hwnd);
        System.Void* AdviseWindowScreenCoordinatesChange(JetBrains.Application.Interop.NativeHook.ComImport.IWindowScreenCoordinatesChangeSink sink, System.Void* hwnd);
        System.Void* StartMouseWheelRedirectingToHoveredWindow();
        void StopMouseWheelRedirectingToHoveredWindow(System.Void* pCookie);
        void UnadviseApplicationActiveStateChange(System.Void* pCookie);
        void UnadviseForegroundIdle(System.Void* pCookie);
        void UnadviseInputMessage(System.Void* pCookie);
        void UnadviseKeyboardMessage(System.Void* pCookie);
        void UnadviseMouseMessage(System.Void* pCookie);
        void UnadviseWindowClassMessage(System.Void* pCookie);
        void UnadviseWindowMessage(System.Void* pCookie);
        void UnadviseWindowRootParentChange(System.Void* pCookie);
        void UnadviseWindowScreenCoordinatesChange(System.Void* pCookie);
    }
    [System.Runtime.InteropServices.GuidAttribute("24FDE11D-94A4-4940-9A13-86826A21FBD7")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWindowMessageSink
    {
        void OnWindowMessage(System.Void* hwnd, uint message, System.Void* wParam, System.Void* lParam, int isDeferred);
    }
    [System.Runtime.InteropServices.GuidAttribute("B374D21C-158B-4542-B917-19512AE65244")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWindowRootParentChangeSink
    {
        void OnWindowRootParentChanged(System.Void* hwnd, System.Void* hwndRootParent);
    }
    [System.Runtime.InteropServices.GuidAttribute("C05526B9-5F0C-4C54-8286-53388DB2961C")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWindowScreenCoordinatesChangeSink
    {
        void OnWindowScreenCoordinatesChanged(System.Void* hwnd, JetBrains.Interop.WinApi.RECT* pRect);
    }
    [System.Runtime.InteropServices.GuidAttribute("2B2E9B1F-C279-4EE0-A0D2-A466504997FD")]
    public class NativeHookHandler
    {
        public NativeHookHandler() { }
    }
}
namespace JetBrains.Application.Interop.NativeHook
{
    
    public class HookedMessageSelector : JetBrains.Application.Interop.NativeHook.IHookedMessageSelector
    {
        public JetBrains.Application.Interop.NativeHook.IHookedWindowAndMessage All { get; }
        public JetBrains.Application.Interop.NativeHook.IHookedWindowAndMessage this[JetBrains.Interop.WinApi.WindowsMessages message] { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Interop.NativeHook.HookedWindow Window { get; }
    }
    public class HookedWindow : JetBrains.Application.Interop.NativeHook.IHookedWindow, System.Windows.Forms.IWin32Window
    {
        public System.IntPtr Handle { get; }
        public JetBrains.Application.Interop.NativeHook.IHookedMessageSelector Messages { get; }
        public JetBrains.Application.Interop.NativeHook.IWindowsHookManager Owner { get; }
    }
    public class HookedWindowAndMessage : JetBrains.Application.Interop.NativeHook.IHookedWindowAndMessage
    {
        public JetBrains.Interop.WinApi.WindowsMessages Code { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Interop.NativeHook.IWindowsHookManager Owner { get; }
        public JetBrains.Application.Interop.NativeHook.IHookedWindow Window { get; }
        public void Advise(JetBrains.DataFlow.Lifetime lifetime, bool isDeferredProcessingAllowed, System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action) { }
    }
    public class HookedWindowSelector : JetBrains.Application.Interop.NativeHook.IHookedWindowSelector
    {
        public HookedWindowSelector([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager owner) { }
        public JetBrains.Application.Interop.NativeHook.IHookedWindow All { get; }
        public JetBrains.Application.Interop.NativeHook.IHookedWindow this[System.IntPtr windowhandle] { get; }
        public JetBrains.Application.Interop.NativeHook.IHookedWindow this[System.Windows.Forms.IWin32Window window] { get; }
        public JetBrains.Application.Interop.NativeHook.IHookedWindow this[System.Void* windowhandle] { get; }
    }
    public struct HookEventArgs
    {
        public readonly int HookCode;
        public readonly System.IntPtr lParam;
        public readonly System.IntPtr wParam;
        public HookEventArgs(int hookCode, System.IntPtr wParam, System.IntPtr lParam) { }
        public JetBrains.Interop.WinApi.CWPRETSTRUCT* GetCwpRetStruct() { }
        public JetBrains.Interop.WinApi.CWPSTRUCT* GetCwpStruct() { }
        public JetBrains.Interop.WinApi.MOUSEHOOKSTRUCT* GetMouseHookStruct() { }
        public JetBrains.Interop.WinApi.MSG* GetMsgStruct() { }
        public JetBrains.Interop.WinApi.MSLLHOOKSTRUCT* GetMsLlHookStruct() { }
        public override string ToString() { }
    }
    public interface IHookedMessageSelector
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindowAndMessage All { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindowAndMessage this[JetBrains.Interop.WinApi.WindowsMessages message] { get; }
    }
    public interface IHookedWindow : System.Windows.Forms.IWin32Window
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedMessageSelector Messages { get; }
    }
    public interface IHookedWindowAndMessage
    {
        JetBrains.Interop.WinApi.WindowsMessages Code { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindow Window { get; }
        void Advise([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, bool isDeferredProcessingAllowed, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action);
    }
    public interface IHookedWindowSelector
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindow All { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindow this[System.Windows.Forms.IWin32Window window] { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindow this[System.IntPtr windowhandle] { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Interop.NativeHook.IHookedWindow this[System.Void* windowhandle] { get; }
    }
    public interface IWindowsHookManager
    {
        JetBrains.Application.Interop.NativeHook.IHookedWindowSelector Windows { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> AdviseApplicationActiveStateChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
        void AdviseForegroundIdle([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action action);
        void AdviseInputMessage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action);
        void AdviseWindowClassMessage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string className, JetBrains.Interop.WinApi.WindowsMessages message, bool isDeferredProcessingAllowed, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action);
        void AdviseWindowMessage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.IntPtr window, JetBrains.Interop.WinApi.WindowsMessages message, bool isDeferredProcessingAllowed, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<System.IntPtr> AdviseWindowRootParentChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.IntPtr window);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<System.Windows.Rect> AdviseWindowScreenCoordinatesChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, System.IntPtr window);
        void StartMouseWheelRedirectingToHoveredWindow([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
    }
    public class ManagedWindowsHookManager : JetBrains.Application.Interop.NativeHook.IWindowsHookManager
    {
        protected readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<JetBrains.Interop.WinApi.WindowsMessages, System.Action<>[]>> myClassHandlers;
        protected readonly System.Collections.Generic.Dictionary<System.IntPtr, System.Collections.Generic.Dictionary<JetBrains.Interop.WinApi.WindowsMessages, WindowsMessageHookEntry[]>> myHookEntries;
        public ManagedWindowsHookManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter) { }
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        protected void AddRemoveClassMessageHandler([JetBrains.Annotations.NotNullAttribute()] string className, JetBrains.Interop.WinApi.WindowsMessages message, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action, JetBrains.DataFlow.AddRemove addremove) { }
        protected void AddRemoveHookEntry([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.ManagedWindowsHookManager.WindowsMessageHookEntry entry, JetBrains.DataFlow.AddRemove addremove) { }
        protected void AddRemoveMessageHandler(System.IntPtr window, JetBrains.Interop.WinApi.WindowsMessages message, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action, [JetBrains.Annotations.NotNullAttribute()] System.Delegate handlerOriginal, bool includeparents, JetBrains.DataFlow.AddRemove addremove) { }
        public void Dump(System.Xml.XmlWriter writer) { }
        public string DumpToXaml() { }
        protected System.Collections.Generic.IEnumerable<JetBrains.Application.Interop.NativeHook.ManagedWindowsHookManager.WindowsMessageHookEntry> EnumAllEntries() { }
        protected void HookUnhook() { }
        protected void HookUnhookForegroundIdle() { }
        protected bool OnHookedMessage(object sender, JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs args) { }
        [System.ObsoleteAttribute("Never used. To be removed in the next release.")]
        public void RemoveAll(object owner) { }
        protected void RemoveAll() { }
        public override string ToString() { }
        protected class WindowsMessageHookEntry
        {
            protected readonly System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> myAction;
            protected readonly JetBrains.Interop.WinApi.WindowsMessages myMessage;
            protected readonly System.Delegate myOriginalHandler;
            protected readonly System.IntPtr myOriginalTarget;
            protected readonly System.IntPtr myTarget;
            public WindowsMessageHookEntry(System.IntPtr target, System.IntPtr original, JetBrains.Interop.WinApi.WindowsMessages message, System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action, System.Delegate originalhandler) { }
            public System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> Handler { get; }
            public JetBrains.Interop.WinApi.WindowsMessages Message { get; }
            public System.Delegate OriginalHandler { get; }
            public System.IntPtr OriginalTarget { get; }
            public System.IntPtr Target { get; }
            public void Dump(System.Xml.XmlWriter writer) { }
            public override string ToString() { }
        }
    }
    public class NativeWindowsHookManager : JetBrains.Application.Interop.NativeHook.IWindowsHookManager
    {
        public NativeWindowsHookManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.ComImport.INativeHookHandler nativehooks) { }
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
    }
    [System.ObsoleteAttribute("Use WindowsHookManager.")]
    public class WindowsHook : System.IDisposable
    {
        public WindowsHook(JetBrains.Interop.WinApi.HookType code, JetBrains.Application.Interop.NativeHook.WindowsHook.HookEventHandler handler) { }
        protected WindowsHook(JetBrains.Interop.WinApi.HookType code, JetBrains.Application.Interop.NativeHook.WindowsHook.HookEventHandler handler, JetBrains.Interop.WinApi.Win32Declarations.HookProc callback) { }
        protected int CoreHookProc(int code, System.IntPtr wParam, System.IntPtr lParam) { }
        public void Dispose() { }
        protected override void Finalize() { }
        public static bool IsGlobalHook(JetBrains.Interop.WinApi.HookType type) { }
        public void Release() { }
        public delegate bool HookEventHandler(object sender, JetBrains.Application.Interop.NativeHook.HookEventArgs e);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class WindowsHookManager : JetBrains.Application.Interop.NativeHook.IWindowsHookManager
    {
        protected readonly JetBrains.Application.Interop.NativeHook.ComImport.INativeHookHandler myNativeHooks;
        public const string NativeHooksDllName = "JetNativeHooks.dll";
        public WindowsHookManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public virtual JetBrains.Application.Interop.NativeHook.IHookedWindowSelector Windows { get; }
        public virtual JetBrains.Application.Interop.NativeHook.IWindowsHookManager WindowsMessageHookInstance { get; }
        public virtual JetBrains.DataFlow.IProperty<bool> AdviseApplicationActiveStateChange(JetBrains.DataFlow.Lifetime lifetime) { }
        public virtual void AdviseForegroundIdle(JetBrains.DataFlow.Lifetime lifetime, System.Action action) { }
        public virtual void AdviseInputMessage(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action) { }
        public virtual void AdviseWindowClassMessage(JetBrains.DataFlow.Lifetime lifetime, string className, JetBrains.Interop.WinApi.WindowsMessages message, bool isDeferredProcessingAllowed, System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action) { }
        public virtual void AdviseWindowMessage(JetBrains.DataFlow.Lifetime lifetime, System.IntPtr window, JetBrains.Interop.WinApi.WindowsMessages message, bool isDeferredProcessingAllowed, System.Action<JetBrains.Application.Interop.NativeHook.WindowsMessageEventArgs> action) { }
        public virtual JetBrains.DataFlow.IProperty<System.IntPtr> AdviseWindowRootParentChange(JetBrains.DataFlow.Lifetime lifetime, System.IntPtr window) { }
        public virtual JetBrains.DataFlow.IProperty<System.Windows.Rect> AdviseWindowScreenCoordinatesChange(JetBrains.DataFlow.Lifetime lifetime, System.IntPtr window) { }
        public virtual void StartMouseWheelRedirectingToHoveredWindow(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class WindowsMessageEventArgs : System.EventArgs
    {
        public readonly System.Void* HWnd;
        public readonly System.Drawing.Point Location;
        public readonly System.IntPtr LParam;
        public System.IntPtr LResult;
        public readonly JetBrains.Interop.WinApi.WindowsMessages Message;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Interop.NativeHook.IWindowsHookManager WindowsHook;
        public readonly System.IntPtr WParam;
        public WindowsMessageEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Interop.WinApi.CWPRETSTRUCT* pMessage) { }
        public WindowsMessageEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Interop.WinApi.CWPSTRUCT* pMessage) { }
        public WindowsMessageEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Interop.WinApi.MSG* pMessage) { }
        public WindowsMessageEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman, System.Void* hwnd, uint message, System.Void* wParam, System.Void* lParam, JetBrains.Interop.WinApi.POINT* ppt = null) { }
        public System.IntPtr WindowHandle { get; }
    }
}
namespace JetBrains.Application.License
{
    
    public interface ILicenseSupport
    {
        System.Collections.Generic.IEnumerable<JetBrains.Application.ProductEdition> Editions { get; }
        int FeedbackRequestPeriod { get; }
        int FreeTrialPeriod { get; }
        int LeftDaysNotification { get; }
        System.DateTime ProductBuiltDateUsedForSubscriptionCheck { get; }
        string ProductFamily { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ProductGuid { get; }
        bool SendBuildDateAsVersionToOldServers { get; }
        int Version { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.License.LicenseData CreateLicenseData(string licenseKey, string userName, string companyName);
        JetBrains.Application.ProductEdition DecodeProductEdition(int editionCode, JetBrains.Application.IApplicationDescriptor descriptor);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetLicenseAgreement(JetBrains.Application.License.LicenseType licenseType);
        string GetLicenseServerEdition(JetBrains.Application.ProductEdition edition);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.License.LicenseData LoadLicense(JetBrains.Util.DataStructures.ISettingsTable settings, JetBrains.Util.FileSystemPath installDir);
        void SaveLicense(JetBrains.Application.License.LicenseData license, JetBrains.Util.DataStructures.ISettingsTable settings);
    }
    public class LicenseChecker
    {
        public LicenseChecker(JetBrains.Util.XMath.BigInteger n, string username, string company, string license) { }
        public LicenseChecker(string publickey, string username, string company, string license) { }
        public int CustomerId { get; }
        public int Edition { get; }
        public System.DateTime ExpirationDate { get; }
        public System.DateTime GenerationDate { get; }
        public bool HasLicense { get; }
        public bool IsChecksumOK { get; }
        public JetBrains.Application.License.LicenseType LicenseType { get; }
        public int ProductVersion { get; }
        public System.DateTime SubscriptionEndDate { get; }
        public int Type { get; }
        public int Version { get; }
        public static int CalculateUserHash(string userName, string companyName) { }
    }
    public class LicenseCheckFailureException : System.ApplicationException
    {
        public LicenseCheckFailureException(string message) { }
    }
    public class LicenseCheckResult
    {
        public static JetBrains.Application.License.LicenseCheckResult LICENSE_EXPIRED;
        public static JetBrains.Application.License.LicenseCheckResult LICENSE_INVALID;
        public static JetBrains.Application.License.LicenseCheckResult LICENSE_VALID;
        public readonly string Message;
        public LicenseCheckResult() { }
        public LicenseCheckResult(string format, params object[] args) { }
    }
    public class LicenseData : System.IEquatable<JetBrains.Application.License.LicenseData>
    {
        public LicenseData(string publicKey, string licenseKey, string userName, string companyName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.License.LicenseData.AcceptLicenseDelegate acceptLicenseDelegate) { }
        public LicenseData(string publicKey, string licenseKey, string userName, string companyName) { }
        public string CompanyName { get; set; }
        public bool ContainsSubscription { get; }
        public int CustomerId { get; }
        public int EditionCode { get; set; }
        public System.DateTime ExpirationDate { get; }
        public System.DateTime GenerationDate { get; }
        public bool IsEndless { get; }
        public string LicenseKey { get; set; }
        public JetBrains.Application.License.LicenseType LicenseType { get; }
        public int ProductVersion { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Version ProductVersionAsVersion { get; }
        public string PublicKey { get; }
        public System.DateTime SubscriptionEndDate { get; }
        public string UserName { get; set; }
        public JetBrains.Application.License.LicenseCheckResult Check() { }
        public bool Equals(JetBrains.Application.License.LicenseData licenseData) { }
        public override bool Equals(object obj) { }
        public JetBrains.Application.ProductEdition GetEdition([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.License.ILicenseSupport licenseSupport, JetBrains.Application.IApplicationDescriptor descriptor) { }
        public static JetBrains.Application.License.LicenseData GetEvaluationLicenseDataFromFile(string publicKey, JetBrains.Application.License.LicenseData.AcceptLicenseDelegate acceptor, JetBrains.Util.FileSystemPath installDir) { }
        public static JetBrains.Util.FileSystemPath GetEvaluationLicensePath(JetBrains.Util.FileSystemPath installDir) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Application.License.LicenseData GetLicenseDataFromUserSettings(string publicKey, JetBrains.Application.License.LicenseData.AcceptLicenseDelegate acceptor, JetBrains.Util.DataStructures.ISettingsTable settings) { }
        public void SaveToUserSettings(JetBrains.Util.DataStructures.ISettingsTable settings) { }
        public delegate JetBrains.Application.License.LicenseCheckResult AcceptLicenseDelegate(JetBrains.Application.License.LicenseData data);
    }
    public enum LicenseMode
    {
        NOT_FOUND = 0,
        NOT_CHECKED_YET = 1,
        NOT_REQUIRED = 2,
        EVALUATION = 3,
        USER_LICENSE = 4,
        LICENSE_SERVER_FLOATING = 5,
        LICENSE_SERVER_PERMANENT = 6,
    }
    public abstract class LicenseSupportBase : JetBrains.Application.License.ILicenseSupport
    {
        protected LicenseSupportBase(JetBrains.Application.IApplicationDescriptor descriptor) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Application.ProductEdition> Editions { get; }
        public virtual int FeedbackRequestPeriod { get; }
        public virtual int FreeTrialPeriod { get; }
        public virtual int LeftDaysNotification { get; }
        public System.DateTime ProductBuiltDateUsedForSubscriptionCheck { get; }
        public string ProductFamily { get; }
        public virtual string ProductGuid { get; }
        public abstract bool SendBuildDateAsVersionToOldServers { get; }
        public int Version { get; }
        public abstract JetBrains.Application.License.LicenseData CreateLicenseData(string licenseKey, string userName, string companyName);
        public abstract JetBrains.Application.ProductEdition DecodeProductEdition(int editionCode, JetBrains.Application.IApplicationDescriptor descriptor);
        public abstract string GetLicenseAgreement(JetBrains.Application.License.LicenseType licenseType);
        public abstract string GetLicenseServerEdition(JetBrains.Application.ProductEdition edition);
        public abstract JetBrains.Application.License.LicenseData LoadLicense(JetBrains.Util.DataStructures.ISettingsTable settings, JetBrains.Util.FileSystemPath installDir);
        public abstract void SaveLicense(JetBrains.Application.License.LicenseData license, JetBrains.Util.DataStructures.ISettingsTable settings);
    }
    public enum LicenseType
    {
        INVALID = -1,
        COMMERCIAL = 0,
        NON_COMMERCIAL = 1,
        SITE = 2,
        OPENSOURCE = 3,
        PERSONAL = 4,
        ACADEMIC = 5,
        CLASSROOM = 6,
        FLOATING = 7,
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class TimeBombComponent : JetBrains.Application.Env.IProductCanBeStarted
    {
        protected readonly JetBrains.Application.IApplicationDescriptor myApplicationDescriptor;
        public TimeBombComponent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        protected System.Nullable<System.TimeSpan> TimeBombPeriod { get; }
        protected virtual JetBrains.DataFlow.IProperty<JetBrains.Application.Env.ProductCanBeStartedVerdict> CreateCanBeStartedCore(JetBrains.DataFlow.Lifetime lifetime) { }
        protected virtual void ExecuteExpiration(JetBrains.DataFlow.Lifetime lifetime, System.DateTime end, System.Action expiredAction) { }
        protected virtual void ReportBetaExpired() { }
    }
}
namespace JetBrains.Application.Logging
{
    
    public class ShellLoggerConfiguration
    {
        public static JetBrains.Util.FileSystemPath LoggerConfigurationLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
    }
}
namespace JetBrains.Application.Parts
{
    
    public class ProgramConfigurationPartFilter : JetBrains.Application.Parts.IPartsCatalogueFilter
    {
        public ProgramConfigurationPartFilter(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(JetBrains.Application.Parts.IPartsCatalogue catalogue) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
        protected virtual bool Supported(JetBrains.Application.Parts.PartCatalogueType part) { }
    }
}
namespace JetBrains.Application.PerformanceTracking
{
    
    public interface IPerformanceTracking
    {
        void LogEnd(string actionId, string testName, JetBrains.Application.PerformanceTracking.ReportType reportType = 0);
        void LogStart(string actionId, string testName, JetBrains.Application.PerformanceTracking.ReportType reportType = 0);
    }
    public interface IPerformanceTrackingReporter
    {
        void Report(string result);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PerformanceTracking : JetBrains.Application.PerformanceTracking.IPerformanceTracking
    {
        public PerformanceTracking(System.Collections.Generic.IEnumerable<JetBrains.Application.PerformanceTracking.IPerformanceTrackingReporter> reporters) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.PerformanceTracking.IPerformanceTrackingReporter> Reporters { get; }
        public virtual void LogEnd(string actionId, string testName, JetBrains.Application.PerformanceTracking.ReportType reportType = 0) { }
        public virtual void LogStart(string actionId, string testName, JetBrains.Application.PerformanceTracking.ReportType reportType = 0) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PerformanceTrackingReporterConsoleOutput : JetBrains.Application.PerformanceTracking.IPerformanceTrackingReporter
    {
        public void Report(string result) { }
    }
    [System.FlagsAttribute()]
    public enum ReportType
    {
        Time = 0,
        Memory = 1,
    }
}
namespace JetBrains.Application.PersistentMap
{
    
    public class ByteBufferReader : JetBrains.Application.PersistentMap.IByteBufferReader
    {
        public ByteBufferReader(System.Byte* bytes) { }
        public int ReadInt() { }
        public long ReadLong() { }
        public string ReadString() { }
    }
    public class ByteBufferWriter : JetBrains.Application.PersistentMap.IByteBufferWriter
    {
        public ByteBufferWriter(System.Byte* bytes) { }
        public int Length { get; }
        public void Write(int value) { }
        public void Write(long value) { }
        public void Write(string value) { }
    }
    public sealed class CacheBuilder<TKey, TValue>
    
    
    {
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> Associativity(int associativity) { }
        public JetBrains.Application.PersistentMap.ICachedPersistentSortedMap<TKey, TValue> Build(JetBrains.Application.PersistentMap.IKeyValueDb db, JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> underlyingDb) { }
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> CacheLoad(JetBrains.Application.PersistentMap.CacheLoad cacheLoad) { }
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> Capacity(int capacity) { }
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> ConcurrencyLevel(int concurrencyLevel) { }
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> HashFunction(System.Func<TKey, int> hashFunction) { }
        public static JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> NewInstance() { }
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> WriteMiss(JetBrains.Application.PersistentMap.WriteMiss writeMiss) { }
        public JetBrains.Application.PersistentMap.CacheBuilder<TKey, TValue> WritePolicy(JetBrains.Application.PersistentMap.WritePolicy writePolicy) { }
    }
    public enum CacheLoad
    {
        Lazy = 0,
        FullSync = 1,
        FullAsync = 2,
    }
    public class ConciseBitArrayMarshaller : JetBrains.Application.PersistentMap.UnsafeNonfixedSizeMarshaler<JetBrains.Util.dataStructures.ConciseBitArray>
    {
        public static JetBrains.Application.PersistentMap.ConciseBitArrayMarshaller Instance;
        public override int GetMarshalledSize(JetBrains.Util.dataStructures.ConciseBitArray arg) { }
        public override int Marshal(JetBrains.Util.dataStructures.ConciseBitArray arg, System.Byte* buffer, int maxlen) { }
        public static JetBrains.Application.PersistentMap.IUnsafeMarshaller<System.Collections.Generic.ICollection<T>> TransformedCollectionMarshaller<T>(System.Func<T, int> directConvert, System.Func<int, T> inverseConvert) { }
        public override JetBrains.Util.dataStructures.ConciseBitArray Unmarshal(System.Byte* serializedData, int len) { }
    }
    public class DBException : System.Exception
    {
        public DBException(string str) { }
    }
    public interface IByteBufferReader
    {
        int ReadInt();
        long ReadLong();
        string ReadString();
    }
    public interface IByteBufferWriter
    {
        int Length { get; }
        void Write(int value);
        void Write(long value);
        void Write(string value);
    }
    public interface ICachedPersistentSortedMap<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        void AddToCacheOnly(TKey key, TValue value);
        void Flush();
        void Flush(TKey key);
        bool TryGetFromCacheOnly(TKey key, out TValue value);
    }
    public interface IKeyValueDb : System.IDisposable
    {
        bool IsSnapshot { get; }
        JetBrains.DataFlow.Lifetime Lifetime { get; }
        bool RemoveOnClose { get; set; }
        JetBrains.Application.PersistentMap.KeyValueDbStatus Status { get; }
        JetBrains.Application.PersistentMap.IKeyValueDb OpenSnapshot();
        JetBrains.Application.PersistentMap.IKeyValueDbTransaction StartTransaction(JetBrains.DataFlow.Lifetime lifetime = null);
    }
    public interface IKeyValueDbDriver<TDbOpenParams, TMapOpenParams>
    
    
    {
        System.Collections.Generic.ICollection<TKey> GetAsKeyCollection<TKey>(JetBrains.Application.PersistentMap.IKeyValueDb db, TMapOpenParams mapOpenParamsBase);
        JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetMap<TKey, TValue>(JetBrains.Application.PersistentMap.IKeyValueDb db, TMapOpenParams mapOpenParamsBase);
        JetBrains.Application.PersistentMap.IKeyValueDb OpenDb(TDbOpenParams dbOpenParams, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
    }
    public interface IKeyValueDbTransaction : System.IDisposable
    {
        void Add<TKey, TValue>(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map, TKey key, TValue value);
        void Clear();
        void Commit();
        JetBrains.Application.PersistentMap.IKeyValueDb GetDb();
        void Remove<TKey, TValue>(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map, TKey key);
        void Remove<TKey>(System.Collections.Generic.ICollection<TKey> collection, TKey key);
        void RemoveByInternalRepresentation(object internalRepresentation);
        void Rollback();
    }
    public interface IManyToManyDb<TA, TB, TACol, TBCol> : System.IDisposable
    
    
        where TACol : System.Collections.Generic.ICollection<>
        where TBCol : System.Collections.Generic.ICollection<>
    {
        TBCol this[TA a] { get; set; }
        TACol this[TB b] { get; set; }
        void Add(TA a, TB b);
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TA, TBCol>> EnumerateA();
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TACol, TB>> EnumerateB();
        TBCol GetByA(TA a);
        TACol GetByB(TB b);
        void Put(TA a, TBCol b);
        void Put(TACol a, TB b);
        void Remove(TA a, TB b);
        void RemoveByA(TA a);
        void RemoveByB(TB b);
        JetBrains.Application.PersistentMap.IManyToManyDbTransaction<TA, TB, TACol, TBCol> StartTransaction(JetBrains.DataFlow.Lifetime lifetime = null);
    }
    public interface IManyToManyDbTransaction<in TA, in TB, in TACol, in TBCol> : System.IDisposable
    
    
        where in TACol : System.Collections.Generic.ICollection<>
        where in TBCol : System.Collections.Generic.ICollection<>
    {
        void Commit();
        void Put(TA a, TBCol b);
        void Put(TACol a, TB b);
        void RemoveA(TA a);
        void RemoveB(TB a);
        void Rollback();
    }
    public class InMemoryDbDriver : JetBrains.Application.PersistentMap.IKeyValueDbDriver<JetBrains.Util.FileSystemPath, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase>
    {
        public static JetBrains.Application.PersistentMap.InMemoryDbDriver Instance;
        public System.Collections.Generic.ICollection<TKey> GetAsKeyCollection<TKey>(JetBrains.Application.PersistentMap.IKeyValueDb db, byte mapUniqueId, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TKey> keyMarshaller) { }
        public System.Collections.Generic.ICollection<TKey> GetAsKeyCollection<TKey>(JetBrains.Application.PersistentMap.IKeyValueDb db, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase mapOpenParamsBase) { }
        public JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetMap<TKey, TValue>(JetBrains.Application.PersistentMap.IKeyValueDb db, byte mapUniqueId, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TKey> keyMarshaller, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TValue> valueMarshaller) { }
        public JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetMap<TKey, TValue>(JetBrains.Application.PersistentMap.IKeyValueDb db, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase mapOpenParamsBase) { }
        public JetBrains.Application.PersistentMap.IKeyValueDb OpenDb(JetBrains.Util.FileSystemPath dbOpenParams, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public interface IPersistentSortedMap<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetCleaningEnumerator(System.Func<TKey, bool> cleanerPredicate);
        JetBrains.Application.PersistentMap.IKeyValueDb GetDb();
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator(bool reveredOrder);
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator(bool reveredOrder, TKey fromKey);
        JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetInSnapshot(JetBrains.Application.PersistentMap.IKeyValueDb snapshot);
    }
    public interface IUnsafeMarshaller<T>
    
    {
        int FixedSize { get; }
        int GetMarshalledSize(T arg);
        int Marshal(T arg, System.Byte* buffer, int maxlen);
        T Unmarshal(System.Byte* serializedData, int len);
    }
    public enum KeyValueDbStatus
    {
        Ready = 0,
        Closed = 1,
        Corrupted = 2,
    }
    public sealed class LevelDbDriver : JetBrains.Application.PersistentMap.IKeyValueDbDriver<JetBrains.Util.FileSystemPath, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase>
    {
        public static readonly JetBrains.Application.PersistentMap.LevelDbDriver Instance;
        public const int MapIdentifierLengthInBytes = 1;
        public System.Collections.Generic.ICollection<TKey> GetAsKeyCollection<TKey>(JetBrains.Application.PersistentMap.IKeyValueDb db, byte mapUniqueId, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TKey> keyMarshaller) { }
        public System.Collections.Generic.ICollection<TKey> GetAsKeyCollection<TKey>(JetBrains.Application.PersistentMap.IKeyValueDb db, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase mapOpenParamsBase) { }
        public JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetMap<TKey, TValue>(JetBrains.Application.PersistentMap.IKeyValueDb db, byte mapUniqueId, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TKey> keyMarshaller, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TValue> valueMarshaller) { }
        public JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetMap<TKey, TValue>(JetBrains.Application.PersistentMap.IKeyValueDb db, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase mapOpenParamsBase) { }
        public JetBrains.Application.PersistentMap.IKeyValueDb OpenDb(JetBrains.Util.FileSystemPath dir, JetBrains.DataFlow.Lifetime lifetime) { }
        public static void WriteMapIdentifierIntoRawBytes(System.Byte* rawbytes, int mapUniqueId) { }
    }
    [System.Security.SuppressUnmanagedCodeSecurityAttribute()]
    public class static LevelDbInterop
    {
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_approximate_sizes_delegate leveldb_approximate_sizes;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_bgerrcount_delegate leveldb_bgerrcount;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_cache_create_lru_delegate leveldb_cache_create_lru;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_cache_destroy_delegate leveldb_cache_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_close_delegate leveldb_close;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_comparator_destroy_delegate leveldb_comparator_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_create_default_env_delegate leveldb_create_default_env;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_create_iterator_delegate leveldb_create_iterator;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_create_snapshot_delegate leveldb_create_snapshot;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_delete_delegate leveldb_delete;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_destroy_db_delegate leveldb_destroy_db;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_env_destroy_delegate leveldb_env_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_free_delegate leveldb_free;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_get_delegate leveldb_get;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_destroy_delegate leveldb_iter_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_get_error_delegate leveldb_iter_get_error;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_key_delegate leveldb_iter_key;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_next_delegate leveldb_iter_next;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_prev_delegate leveldb_iter_prev;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_seek_delegate leveldb_iter_seek;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_seek_to_first_delegate leveldb_iter_seek_to_first;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_seek_to_last_delegate leveldb_iter_seek_to_last;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_valid_delegate leveldb_iter_valid;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_iter_value_delegate leveldb_iter_value;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_create_delegate leveldb_options_create;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_destroy_delegate leveldb_options_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_block_restart_interval_delegate leveldb_options_set_block_restart_interval;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_block_size_delegate leveldb_options_set_block_size;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_cache_delegate leveldb_options_set_cache;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_comparator_delegate leveldb_options_set_comparator;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_compression_delegate leveldb_options_set_compression;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_create_if_missing_delegate leveldb_options_set_create_if_missing;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_env_delegate leveldb_options_set_env;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_error_if_exists_delegate leveldb_options_set_error_if_exists;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_info_log_delegate leveldb_options_set_info_log;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_max_open_files_delegate leveldb_options_set_max_open_files;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_paranoid_checks_delegate leveldb_options_set_paranoid_checks;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_options_set_write_buffer_size_delegate leveldb_options_set_write_buffer_size;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_property_value_delegate leveldb_property_value;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_put_delegate leveldb_put;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_readoptions_create_delegate leveldb_readoptions_create;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_readoptions_destroy_delegate leveldb_readoptions_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_readoptions_set_fill_cache_delegate leveldb_readoptions_set_fill_cache;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_readoptions_set_snapshot_delegate leveldb_readoptions_set_snapshot;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_readoptions_set_verify_checksums_delegate leveldb_readoptions_set_verify_checksums;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_release_snapshot_delegate leveldb_release_snapshot;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_repair_db_delegate leveldb_repair_db;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_write_delegate leveldb_write;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writebatch_clear_delegate leveldb_writebatch_clear;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writebatch_create_delegate leveldb_writebatch_create;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writebatch_delete_delegate leveldb_writebatch_delete;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writebatch_destroy_delegate leveldb_writebatch_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writebatch_put_delegate leveldb_writebatch_put;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writeoptions_create_delegate leveldb_writeoptions_create;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writeoptions_destroy_delegate leveldb_writeoptions_destroy;
        public static JetBrains.Application.PersistentMap.LevelDbInterop.leveldb_writeoptions_set_sync_delegate leveldb_writeoptions_set_sync;
        public static void InitIfNecessary() { }
        public static void leveldb_destroy_database(System.IntPtr options, string name, System.Byte** errptr) { }
        public static System.IntPtr leveldb_open_database(System.IntPtr options, string name, System.Byte** errptr) { }
        public enum Compression
        {
            leveldb_no_compression = 0,
            leveldb_snappy_compression = 1,
        }
        public delegate void leveldb_approximate_sizes_delegate(System.IntPtr db, int num_ranges, System.Byte** range_start_key, System.Byte** range_start_key_len, System.Byte** range_limit_key, System.Byte** range_limit_key_len, System.Int64* sizesResult);
        public delegate int leveldb_bgerrcount_delegate(System.IntPtr db);
        public delegate System.IntPtr leveldb_cache_create_lru_delegate(System.IntPtr capacity);
        public delegate void leveldb_cache_destroy_delegate(System.IntPtr cache);
        public delegate void leveldb_close_delegate(System.IntPtr db);
        public delegate void leveldb_comparator_destroy_delegate(System.IntPtr comparator);
        public delegate System.IntPtr leveldb_create_default_env_delegate();
        public delegate System.IntPtr leveldb_create_iterator_delegate(System.IntPtr db, System.IntPtr readOptions);
        public delegate System.IntPtr leveldb_create_snapshot_delegate(System.IntPtr db);
        public delegate void leveldb_delete_delegate(System.IntPtr db, System.IntPtr options, System.Byte* key, System.IntPtr keylen, System.Byte** errptr);
        public delegate void leveldb_destroy_db_delegate(System.IntPtr options, System.Byte* name, System.Byte** errptr);
        public delegate void leveldb_env_destroy_delegate(System.IntPtr env);
        public delegate void leveldb_free_delegate(System.Byte** ptr);
        public delegate System.Byte* leveldb_get_delegate(System.IntPtr db, System.IntPtr options, System.Byte* key, System.IntPtr keylen, out System.IntPtr vallen, System.Byte** errptr);
        public delegate void leveldb_iter_destroy_delegate(System.IntPtr iterator);
        public delegate void leveldb_iter_get_error_delegate(System.IntPtr iterator, System.Byte** errptr);
        public delegate System.Byte* leveldb_iter_key_delegate(System.IntPtr iterator, out System.IntPtr klen);
        public delegate void leveldb_iter_next_delegate(System.IntPtr iterator);
        public delegate void leveldb_iter_prev_delegate(System.IntPtr iterator);
        public delegate void leveldb_iter_seek_delegate(System.IntPtr iterator, System.Byte* key, System.IntPtr klen);
        public delegate void leveldb_iter_seek_to_first_delegate(System.IntPtr iterator);
        public delegate void leveldb_iter_seek_to_last_delegate(System.IntPtr iterator);
        public delegate byte leveldb_iter_valid_delegate(System.IntPtr iterator);
        public delegate System.Byte* leveldb_iter_value_delegate(System.IntPtr iterator, out System.IntPtr vlen);
        public delegate System.IntPtr leveldb_options_create_delegate();
        public delegate void leveldb_options_destroy_delegate(System.IntPtr options);
        public delegate void leveldb_options_set_block_restart_interval_delegate(System.IntPtr options, int n);
        public delegate void leveldb_options_set_block_size_delegate(System.IntPtr options, System.IntPtr size);
        public delegate void leveldb_options_set_cache_delegate(System.IntPtr options, System.IntPtr cache);
        public delegate void leveldb_options_set_comparator_delegate(System.IntPtr db, System.IntPtr comparator);
        public delegate void leveldb_options_set_compression_delegate(System.IntPtr options, JetBrains.Application.PersistentMap.LevelDbInterop.Compression compression);
        public delegate void leveldb_options_set_create_if_missing_delegate(System.IntPtr options, byte flag);
        public delegate void leveldb_options_set_env_delegate(System.IntPtr options, System.IntPtr env);
        public delegate void leveldb_options_set_error_if_exists_delegate(System.IntPtr options, byte flag);
        public delegate void leveldb_options_set_info_log_delegate(System.IntPtr options, System.IntPtr logger);
        public delegate void leveldb_options_set_max_open_files_delegate(System.IntPtr options, int nfiles);
        public delegate void leveldb_options_set_paranoid_checks_delegate(System.IntPtr options, byte flag);
        public delegate void leveldb_options_set_write_buffer_size_delegate(System.IntPtr options, System.IntPtr size);
        public delegate System.IntPtr leveldb_property_value_delegate(System.IntPtr db, string propname);
        public delegate void leveldb_put_delegate(System.IntPtr db, System.IntPtr options, System.Byte* key, System.IntPtr keylen, System.Byte* val, System.IntPtr vallen, System.Byte** errptr);
        public delegate System.IntPtr leveldb_readoptions_create_delegate();
        public delegate void leveldb_readoptions_destroy_delegate(System.IntPtr readOptions);
        public delegate void leveldb_readoptions_set_fill_cache_delegate(System.IntPtr readOptions, byte flag);
        public delegate void leveldb_readoptions_set_snapshot_delegate(System.IntPtr readOptions, System.IntPtr snapshot);
        public delegate void leveldb_readoptions_set_verify_checksums_delegate(System.IntPtr readOptions, byte flag);
        public delegate void leveldb_release_snapshot_delegate(System.IntPtr db, System.IntPtr snapshot);
        public delegate void leveldb_repair_db_delegate(System.IntPtr options, string name, System.Byte** errptr);
        public delegate void leveldb_write_delegate(System.IntPtr db, System.IntPtr options, System.IntPtr batch, System.Byte** errptr);
        public delegate void leveldb_writebatch_clear_delegate(System.IntPtr batch);
        public delegate System.IntPtr leveldb_writebatch_create_delegate();
        public delegate void leveldb_writebatch_delete_delegate(System.IntPtr batch, System.Byte* key, System.IntPtr klen);
        public delegate void leveldb_writebatch_destroy_delegate(System.IntPtr batch);
        public delegate void leveldb_writebatch_put_delegate(System.IntPtr batch, System.Byte* key, System.IntPtr klen, System.Byte* val, System.IntPtr vlen);
        public delegate System.IntPtr leveldb_writeoptions_create_delegate();
        public delegate void leveldb_writeoptions_destroy_delegate(System.IntPtr writeOptions);
        public delegate void leveldb_writeoptions_set_sync_delegate(System.IntPtr writeOptions, byte flag);
    }
    public class PeriodicallyCommitTransaction : JetBrains.Util.SafeDisposable, JetBrains.Application.PersistentMap.IKeyValueDbTransaction, System.IDisposable
    {
        public const int DefaultBatchSize = 100;
        public const long DefaultTimeInMillis = 2000;
        public JetBrains.DataFlow.Signal<bool> OnCommit { get; }
        protected override bool WarnOnSecondDispose { get; }
        public void Add<TKey, TValue>(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map, TKey key, TValue value) { }
        public void Clear() { }
        public void Commit() { }
        protected override void DisposeUnmanagedResources() { }
        public void Flush() { }
        public JetBrains.Application.PersistentMap.IKeyValueDb GetDb() { }
        public static JetBrains.Application.PersistentMap.PeriodicallyCommitTransaction GetInstance(JetBrains.Application.PersistentMap.IKeyValueDb db, int batchsize = 100, long timeInMillis = 2000) { }
        public void Remove<TKey, TValue>(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map, TKey key) { }
        public void Remove<TKey>(System.Collections.Generic.ICollection<TKey> collection, TKey key) { }
        public void RemoveByInternalRepresentation(object internalRepresentation) { }
        public void Rollback() { }
    }
    public class PersistentManyToManyDb<TA, TB, TACol, TBCol> : JetBrains.Util.SafeDisposable, JetBrains.Application.PersistentMap.IManyToManyDb<TA, TB, TACol, TBCol>, System.IDisposable
    
    
        where TACol : System.Collections.Generic.ICollection<>
        where TBCol : System.Collections.Generic.ICollection<>
    {
        public PersistentManyToManyDb(string dbDir, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.PersistentMap.IUnsafeMarshaller<TA> keyMarshaller, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.PersistentMap.IUnsafeMarshaller<TB> valueMarshaller, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.PersistentMap.IUnsafeMarshaller<TACol> keyCollectionMarshaller, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.PersistentMap.IUnsafeMarshaller<TBCol> valueCollectionMarshaller, System.Func<TACol, TACol, System.Collections.Generic.IEnumerable<TA>> keyCollectionDiff = null, System.Func<TBCol, TBCol, System.Collections.Generic.IEnumerable<TB>> valueCollectionDiff = null, JetBrains.DataFlow.Lifetime lifetime = null) { }
        public string DbDir { get; }
        public void Add(TA a, TB b) { }
        protected override void DisposeUnmanagedResources() { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TA, TBCol>> EnumerateA() { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TACol, TB>> EnumerateB() { }
        public TBCol GetByA(TA a) { }
        public TACol GetByB(TB b) { }
        public void Put(TA a, TBCol bcoll) { }
        public void Put(TACol acoll, TB b) { }
        public void Remove(TA a, TB b) { }
        public void RemoveByA(TA a) { }
        public void RemoveByB(TB b) { }
        public JetBrains.Application.PersistentMap.IManyToManyDbTransaction<TA, TB, TACol, TBCol> StartTransaction(JetBrains.DataFlow.Lifetime lifetime = null) { }
        public class DBException<TA, TB, TACol, TBCol> : System.Exception
        
        
            where TACol : System.Collections.Generic.ICollection<>
            where TBCol : System.Collections.Generic.ICollection<>
        {
            public DBException(string str) { }
        }
    }
    public class PersistentMapCacheProvider<TKey, TValue> : JetBrains.Util.Caches.ICacheBackendProvider<TKey, TValue>
    
    
    {
        public PersistentMapCacheProvider(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map) { }
        public virtual bool ContainsKey(TKey key) { }
        public virtual void Put(TKey key, TValue val) { }
        public virtual void Remove(TKey key) { }
        public virtual bool TryGetValue(TKey key, out TValue val) { }
    }
    public abstract class PersistentMapOpenParamsBase
    {
        public abstract byte MapUniqueId { get; }
        public abstract JetBrains.Application.PersistentMap.IUnsafeMarshaller<TKey> GetKeyMarshaller<TKey>();
        public abstract JetBrains.Application.PersistentMap.IUnsafeMarshaller<TValue> GetValueMarshaller<TValue>();
        public static JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase NewInstance<TKey, TValue>(byte uniqueTableNumber, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TKey> keyMarshaller, JetBrains.Application.PersistentMap.IUnsafeMarshaller<TValue> valueMarshaller) { }
    }
    public class static PersistentMaps
    {
        public static JetBrains.Application.PersistentMap.WriteOptimizationPersistentSortedMap<TKey, TValue> BatchWritesMap<TKey, TValue>(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map, JetBrains.DataFlow.Lifetime lifetime = null, int concurrencyLevel = 0) { }
    }
    public enum ReplacementPolicy
    {
        LRU = 0,
        PLRU = 1,
        SLRU = 2,
    }
    public class UnsafeDelegatedMarshaller<TDst, TSrc> : JetBrains.Application.PersistentMap.IUnsafeMarshaller<TDst>
    
    
    {
        public UnsafeDelegatedMarshaller(JetBrains.Application.PersistentMap.IUnsafeMarshaller<TSrc> marshaller, System.Func<TDst, TSrc> tranformMarshall, System.Func<TSrc, TDst> tranformUnmarshall) { }
        public int FixedSize { get; }
        public int GetMarshalledSize(TDst arg) { }
        public int Marshal(TDst arg, System.Byte* buffer, int maxlen) { }
        public TDst Unmarshal(System.Byte* serializedData, int len) { }
    }
    public sealed class UnsafeFilteredCollectionMarshaller<T, TCol> : JetBrains.Application.PersistentMap.UnsafeNonfixedSizeMarshaler<TCol>
    
        where TCol : System.Collections.Generic.ICollection<>
    {
        public UnsafeFilteredCollectionMarshaller([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.PersistentMap.IUnsafeMarshaller<T> elemMarshaller, [JetBrains.Annotations.NotNullAttribute()] System.Func<int, TCol> emptyCollectionCreator, [JetBrains.Annotations.CanBeNullAttribute()] System.Predicate<T> filter = null) { }
        public override int GetMarshalledSize(TCol arg) { }
        public override int Marshal(TCol arg, System.Byte* buffer, int maxlen) { }
        public override TCol Unmarshal(System.Byte* serializedData, int len) { }
    }
    public abstract class UnsafeFixedSizeMarshaler<T> : JetBrains.Application.PersistentMap.IUnsafeMarshaller<T>
    
    {
        public abstract int FixedSize { get; }
        public int GetMarshalledSize(T arg) { }
        public abstract int Marshal(T arg, System.Byte* buffer, int maxlen);
        public abstract T Unmarshal(System.Byte* serializedData, int len);
    }
    public sealed class UnsafeIntMarshaller : JetBrains.Application.PersistentMap.UnsafeFixedSizeMarshaler<int>
    {
        public override int FixedSize { get; }
        public override int Marshal(int arg, System.Byte* buffer, int maxlen) { }
        public override int Unmarshal(System.Byte* serializedData, int len) { }
    }
    public sealed class UnsafeLexicographicalIntMarshaller : JetBrains.Application.PersistentMap.UnsafeFixedSizeMarshaler<int>
    {
        public override int FixedSize { get; }
        public override int Marshal(int arg, System.Byte* buffer, int maxlen) { }
        public override int Unmarshal(System.Byte* serializedData, int len) { }
    }
    public sealed class UnsafeLongMarshaller : JetBrains.Application.PersistentMap.UnsafeNonfixedSizeMarshaler<long>
    {
        public override int GetMarshalledSize(long arg) { }
        public override int Marshal(long arg, System.Byte* buffer, int maxlen) { }
        public override long Unmarshal(System.Byte* serializedData, int len) { }
    }
    public class static UnsafeMarshallers
    {
        public static readonly JetBrains.Application.PersistentMap.UnsafeFixedSizeMarshaler<int> IntMarshaller;
        public static readonly JetBrains.Application.PersistentMap.IUnsafeMarshaller<int> LexicographicalIntMarshaller;
        public static readonly JetBrains.Application.PersistentMap.IUnsafeMarshaller<long> LongMarshaller;
        public static readonly JetBrains.Application.PersistentMap.IUnsafeMarshaller<uint> UIntMarshaller;
        public static readonly JetBrains.Application.PersistentMap.IUnsafeMarshaller<string> UnicodeStringMarshaller;
        public static int Compare(System.Byte* arg1, int size1, System.Byte* arg2, int size2) { }
        public static JetBrains.Application.PersistentMap.IUnsafeMarshaller<System.Collections.Generic.List<T>> ListMarshaller<T>(JetBrains.Application.PersistentMap.IUnsafeMarshaller<T> elemMarshaller) { }
        public static int MarshalledLengthInBytes(this string s) { }
        public static bool NotNullPredicate<T>(T x)
            where T :  class { }
        public static JetBrains.Application.PersistentMap.IUnsafeMarshaller<System.Collections.Generic.JetHashSet<T>> NullFilteredCollectionMarshaller<T>(JetBrains.Application.PersistentMap.IUnsafeMarshaller<T> elemMarshaller)
            where T :  class { }
    }
    public abstract class UnsafeNonfixedSizeMarshaler<T> : JetBrains.Application.PersistentMap.IUnsafeMarshaller<T>
    
    {
        public int FixedSize { get; }
        public abstract int GetMarshalledSize(T arg);
        public abstract int Marshal(T arg, System.Byte* buffer, int maxlen);
        public abstract T Unmarshal(System.Byte* serializedData, int len);
    }
    public abstract class UnsafeReaderWriterBasedMarshaller<T> : JetBrains.Application.PersistentMap.UnsafeStreamBasedMarshaller<T>
    
    {
        protected abstract void Marshal(System.IO.BinaryWriter s, T arg);
        protected override void Marshal(System.IO.Stream s, T arg) { }
        protected abstract T Unmarshal(System.IO.BinaryReader s);
        protected override T Unmarshal(System.IO.Stream s) { }
    }
    public abstract class UnsafeStreamBasedMarshaller<T> : JetBrains.Application.PersistentMap.UnsafeNonfixedSizeMarshaler<T>
    
    {
        public override int GetMarshalledSize(T arg) { }
        public override int Marshal(T arg, System.Byte* buffer, int maxlen) { }
        protected abstract void Marshal(System.IO.Stream s, T arg);
        protected abstract T Unmarshal(System.IO.Stream s);
        public override T Unmarshal(System.Byte* serializedData, int len) { }
    }
    public class UnsafeStructAsIsMarshaller<T> : JetBrains.Application.PersistentMap.UnsafeFixedSizeMarshaler<T>
        where T :  struct
    {
        public static JetBrains.Application.PersistentMap.UnsafeStructAsIsMarshaller<T> Instance;
        protected UnsafeStructAsIsMarshaller() { }
        public override int FixedSize { get; }
        public override int Marshal(T arg, System.Byte* buffer, int maxlen) { }
        public override T Unmarshal(System.Byte* serializedData, int len) { }
    }
    public sealed class UnsafeUIntMarshaller : JetBrains.Application.PersistentMap.UnsafeFixedSizeMarshaler<uint>
    {
        public override int FixedSize { get; }
        public override int Marshal(uint arg, System.Byte* buffer, int maxlen) { }
        public override uint Unmarshal(System.Byte* serializedData, int len) { }
    }
    public sealed class UnsafeUnicodeStringMarshaller : JetBrains.Application.PersistentMap.UnsafeNonfixedSizeMarshaler<string>
    {
        public override int GetMarshalledSize(string s) { }
        public override int Marshal(string arg, System.Byte* buffer, int len) { }
        public override string Unmarshal(System.Byte* serializedData, int len) { }
    }
    public enum WriteMiss
    {
        WriteAllocate = 0,
        NoWriteAllocate = 1,
    }
    public class WriteOptimizationPersistentSortedMap<TKey, TValue> : JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        public WriteOptimizationPersistentSortedMap(JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> map, JetBrains.DataFlow.Lifetime lifetime = null, int concurrencyLevel = 0, System.Collections.Generic.IEqualityComparer<TKey> keyEqualityComparer = null) { }
        public JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> BackendMap { get; }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool ContainsKey(TKey key) { }
        public void CopyTo(System.Collections.Generic.KeyValuePair<, >[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetCleaningEnumerator(System.Func<TKey, bool> cleanerPredicate) { }
        public JetBrains.Application.PersistentMap.IKeyValueDb GetDb() { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator(bool reveredOrder) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator(bool reveredOrder, TKey fromKey) { }
        public JetBrains.Application.PersistentMap.IPersistentSortedMap<TKey, TValue> GetInSnapshot(JetBrains.Application.PersistentMap.IKeyValueDb snapshot) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool Remove(TKey key) { }
        public bool TryGetValue(TKey key, out TValue value) { }
    }
    public struct WritePolicy
    {
        public WritePolicy(uint batchSize) { }
        public uint BatchSize { get; }
    }
}
namespace JetBrains.Application.PlatformProduct
{
    
    public class PlatformApplicationDescriptor : JetBrains.Application.ApplicationDescriptor
    {
        public static readonly string PlatformAllassembliesXml;
        public override System.Reflection.Assembly AllAssembliesResourceAssembly { get; }
        public override string AllAssembliesResourceName { get; }
        public override JetBrains.Application.ExceptionReport.IIssueTracker IssueTracker { get; }
        public override JetBrains.Application.License.ILicenseSupport LicenseSupport { get; }
        public override System.Drawing.Icon ProductIcon { get; }
    }
}
namespace JetBrains.Application.PluginSupport
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class CollectPluginsInProductFolders : JetBrains.Application.PluginSupport.IPluginSource
    {
        public static readonly string InfoRecordSenderId;
        public static readonly JetBrains.Application.Env.Components.ProductSettingsLocationFlag[] UserProductSettingsLocationFlags;
        public CollectPluginsInProductFolders(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.IApplicationDescriptor product) { }
        protected virtual bool IsEnabled { get; }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.PluginSourceInfo> PluginSources { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetAllPredefinedPluginsFolders(JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, string pluginsFolderName = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetPluginsFolderMachine(JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, string pluginsFolderName = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetPluginsFoldersInUserSettings(JetBrains.Application.Env.Components.AnyProductSettingsLocation productSettingsLocation, JetBrains.Application.IProductNameAndVersion product, string pluginsFolderName = null) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class CollectPluginsOnCommandLine : JetBrains.Application.PluginSupport.IPluginSource
    {
        public static readonly string InfoRecordSenderId;
        public static readonly string PluginCommandLineSwitch;
        public CollectPluginsOnCommandLine([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductCommandLine productCommandLine, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public virtual bool IsEnabled { get; }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.PluginSourceInfo> PluginSources { get; }
    }
    public class static DiscoverPluginsInDirectory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Application.PluginSupport.Plugin> CreatePluginsFromDirectory([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathDirectory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> infoRecords, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.MetadataLoader loader) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Application.PluginSupport.Plugin> CreatePluginsFromFileSet([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, string id, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<string, JetBrains.Util.FileSystemPath>> pluginFiles, JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> infoRecords, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.MetadataLoader loader) { }
        public static string TryGetPluginTitleFromFile(string pluginOrigin, JetBrains.Util.FileSystemPath path, JetBrains.Metadata.Reader.API.MetadataLoader loader, System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> infoRecords) { }
    }
    public interface IPluginSource
    {
        JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.PluginSourceInfo> PluginSources { get; }
    }
    public class Plugin
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.FileSystemPath[] AssemblyPaths;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.Application.IApplicationDescriptor Product;
        public Plugin(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> assemblyPaths, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.PluginSupport.PluginPresentation presentation, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Reader.API.MetadataLoader metadataloader) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ID { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.IProperty<System.Nullable<bool>> IsEnabled { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.PluginSupport.PluginPresentation Presentation { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ListEvents<JetBrains.Application.PluginSupport.PluginsDirectory.Record> RuntimeInfoRecords { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=false)]
    public class PluginDescriptionAttribute : System.Attribute
    {
        public PluginDescriptionAttribute(string text) { }
        public string Text { get; }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class PluginLoader
    {
        public static readonly string InfoRecordSenderId;
        public PluginLoader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.PluginSupport.PluginsDirectory pluginsDirectory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.JetEnvironment environment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Extensions.IExtensionSettings extensionSettings, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
    }
    public class PluginPresentation
    {
        public PluginPresentation(string title, string vendor, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyNameInfo, JetBrains.UI.RichText.RichText description) { }
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyNameInfo { get; }
        public JetBrains.UI.RichText.RichText Description { get; }
        public string Title { get; }
        public string Vendor { get; }
        public System.Version Version { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.PluginSupport.PluginPresentation ReadFromAssemblies(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> assemblies, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Reader.API.MetadataLoader loader, System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> records) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryReadDescription(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> records) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryReadTitle(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> records) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryReadVendor(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> records) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class PluginsDirectory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<JetBrains.Application.PluginSupport.PluginsDirectory.Record> InfoRecords;
        public PluginsDirectory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.Application.PluginSupport.IPluginSource> pluginSources) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.Plugin> Plugins { get; }
        public class Record : System.IEquatable<JetBrains.Application.PluginSupport.PluginsDirectory.Record>
        {
            public Record(JetBrains.Application.PluginSupport.PluginsDirectory.RecordKind kind, [JetBrains.Annotations.NotNullAttribute()] string sender, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText message, System.Exception exception = null) { }
            public System.Exception Exception { get; }
            public JetBrains.Application.PluginSupport.PluginsDirectory.RecordKind Kind { get; }
            public JetBrains.UI.RichText.RichText Message { get; }
            public string Sender { get; }
            public bool Equals(JetBrains.Application.PluginSupport.PluginsDirectory.Record other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
        public enum RecordKind
        {
            Info = 0,
            Warning = 1,
            Error = 2,
        }
    }
    public class PluginSourceInfo
    {
        public PluginSourceInfo(JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.Plugin> plugins, JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.PluginsDirectory.Record> records) { }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.Plugin> Plugins { get; }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.PluginSupport.PluginsDirectory.Record> Records { get; }
        public static JetBrains.Application.PluginSupport.PluginSourceInfo FromRecord(JetBrains.DataFlow.Lifetime lifetime, object owner, params Record[] records) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=false)]
    public class PluginTitleAttribute : System.Attribute
    {
        public PluginTitleAttribute(string text) { }
        public string Text { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=false)]
    public class PluginVendorAttribute : System.Attribute
    {
        public PluginVendorAttribute(string text) { }
        public string Text { get; }
    }
}
namespace JetBrains.Application.Progress
{
    
    public class CommandLineProgressIndicator : JetBrains.Application.Progress.ProgressIndicatorBase
    {
        public CommandLineProgressIndicator(string taskName) { }
        public override string CurrentItemText { set; }
        public override string TaskName { set; }
        public override void Advance(double units) { }
        public override void Start(int totalWorkUnits) { }
        public override void Stop() { }
    }
    public class CommandLineTaskExecutor : JetBrains.Application.Progress.ITaskExecutor
    {
        public bool ExecuteTask(string name, JetBrains.Application.Progress.TaskCancelable cancelable, System.Action<JetBrains.Application.Progress.IProgressIndicator> task) { }
    }
    public interface ITaskExecutor
    {
        bool ExecuteTask([JetBrains.Annotations.NotNullAttribute()] string name, JetBrains.Application.Progress.TaskCancelable cancelable, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Progress.IProgressIndicator> task);
    }
    public class static ProgressIndicatorMarshalled
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Progress.IProgressIndicatorModel Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicatorModel modelFree, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Progress.IProgressIndicatorModel CreateWithoutSafeThreadCheck([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicatorModel modelFree, JetBrains.Threading.IThreading invocator) { }
    }
    public class SimpleTaskExecutor : JetBrains.Application.Progress.ITaskExecutor
    {
        public static JetBrains.Application.Progress.SimpleTaskExecutor Instance { get; }
        public bool ExecuteTask(string name, JetBrains.Application.Progress.TaskCancelable cancelable, System.Action<JetBrains.Application.Progress.IProgressIndicator> task) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable PushProgressCanceledInterruptableCookie(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public enum TaskCancelable
    {
        No = 0,
        Yes = 1,
    }
}
namespace JetBrains.Application.Settings
{
    
    public class ContextRange
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetNarrowContext;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetWideContext;
        protected ContextRange([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetNarrowContext, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetWideContext) { }
        public static JetBrains.Application.Settings.ContextRange ApplicationWide { get; }
        public static JetBrains.Application.Settings.ContextRange Custom([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetNarrowContext, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetWideContext) { }
        public static JetBrains.Application.Settings.ContextRange ManuallyRestrictWritesToOneContext([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetContext) { }
        public static JetBrains.Application.Settings.ContextRange Smart([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FGetNarrowContext) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Application environment settings. Generally should not be shared with the solutio" +
        "n within a team.")]
    public class EnvironmentSettings { }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Application.Settings.GuidIndex.GuidIndexConverter))]
    [System.Windows.Markup.ValueSerializerAttribute(typeof(JetBrains.Application.Settings.GuidIndex.GuidIndexValueSerializer))]
    public struct GuidIndex : System.IComparable, System.IComparable<JetBrains.Application.Settings.GuidIndex>, System.IEquatable<JetBrains.Application.Settings.GuidIndex>, System.IFormattable, System.Runtime.Serialization.ISerializable
    {
        public static JetBrains.Application.Settings.GuidIndex Empty;
        public GuidIndex(System.Guid guid) { }
        public GuidIndex([JetBrains.Annotations.CanBeNullAttribute()] string s) { }
        public GuidIndex(byte[] data) { }
        public int CompareTo(object obj) { }
        public int CompareTo(JetBrains.Application.Settings.GuidIndex other) { }
        public bool Equals(JetBrains.Application.Settings.GuidIndex other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.Application.Settings.GuidIndex NewGuid() { }
        public static JetBrains.Application.Settings.GuidIndex Parse(string s) { }
        public System.Guid ToGuid() { }
        public override string ToString() { }
        public string ToString(string format) { }
        public string ToString(string format, System.IFormatProvider formatProvider) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public class GuidIndexConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.Application.Settings.GuidIndex>
        {
            public GuidIndexConverter() { }
        }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public class GuidIndexValueSerializer : JetBrains.Util.Reflection.ValueSerializerBase<JetBrains.Application.Settings.GuidIndex>
        {
            public GuidIndexValueSerializer() { }
        }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Application housekeeping settings. Generally should not be shared with the soluti" +
        "on within a team.")]
    public class HousekeepingSettings { }
    public interface IContextBoundSettingsStore
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> InvolvedMountPoints { get; }
        [System.ObsoleteAttribute("Cannot now be changing readability on a running context-bound.")]
        bool IsIgnoringReadonlyFlag { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.ISettingsSchema Schema { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        void CreateIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        void DeleteIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        System.Collections.Generic.IEnumerable<object> EnumIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices);
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        System.Collections.Generic.IDictionary<object, object> EnumIndexedValues([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        object GetIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        JetBrains.Application.Settings.SettingsStoreChangeArgs GetSnapshot([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.SettingsKey keyRoot, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        [JetBrains.Annotations.PureAttribute()]
        object GetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        object[] GetValues([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.Settings.SettingsScalarEntry> entries, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        [JetBrains.Annotations.PureAttribute()]
        bool IsIndexedKeyDefined([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        void RemoveIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        void ResetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        void SetIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] object value);
        void SetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
    }
    public interface IContextBoundSettingsStoreLive : JetBrains.Application.Settings.IContextBoundSettingsStore, JetBrains.Application.Settings.ISettingsChangedEventSource
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IListEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> InvolvedMountPointsLive { get; }
        JetBrains.DataFlow.IProperty<TValue> GetValueProperty<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
    }
    public interface IHaveDefaultSettingsStream
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.IO.Stream GetDefaultSettingsStream([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
    }
    public interface IIsAvailable
    {
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
    }
    public interface IIsAvailableOptimization : JetBrains.Application.Settings.IIsAvailable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.IIsAvailableOptimizedGroup CreateEmptyGroup();
    }
    public interface IIsAvailableOptimizedGroup
    {
        System.Collections.Generic.IEnumerable<object> Items { get; }
        void EvaluateItems([JetBrains.Annotations.NotNullAttribute()] System.Collections.IList items, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
        bool TryAddItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] object item, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IIsAvailable availability);
    }
    public interface IProvider<TItem>
    
    {
        JetBrains.DataFlow.ICollectionEvents<TItem> Items { get; }
    }
    public interface ISettingsChangedEventSource
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.Application.Settings.SettingsStoreChangeArgs> Changed { get; }
    }
    public interface ISettingsOptimization
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        object GetKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
        void SetKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.NotNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices);
    }
    public interface ISettingsSchema
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.SettingsKey> RootKeys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsEntry GetEntry<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsEntry GetEntry<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, object>> lambdaexpression);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsIndexedEntry GetIndexedEntry<TKeyClass, TEntryMemberType>(System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsIndexedEntry GetIndexedEntry<TKeyClass, TEntryIndex, TEntryValue>(System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsIndexedKey GetIndexedKey<TKey>();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsKey GetKey([JetBrains.Annotations.NotNullAttribute()] System.Type typeSettingsClass);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsKey GetKey<TKey>();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.SettingsScalarEntry GetScalarEntry<TKeyClass, TEntryMemberType>(System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression);
    }
    public interface ISettingsStorageMountPoint
    {
        JetBrains.Application.Settings.MountPointFlags Flags { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.IIsAvailable IsAvailable { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IPropertyBag Metadata { get; }
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath PathInStorage { get; }
        double Priority { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.Storage.ISettingsStorage Storage { get; }
    }
    public class static ISettingsStorageMountPointEx
    {
        public static void MountCopyTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint target, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionThis, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionTarget, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, string sRootKey = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public static System.Collections.Generic.IEnumerable<string> MountEnumKeysObsolete([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] string sPathInMount, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static void MountEnumRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, int nTakeChildLevelOnly, System.Action<JetBrains.Application.Settings.Storage.KeyPathComponents, object> FCallback, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static void MountEnumSlow([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponents, int nTakeChildLevelOnly, System.Action<JetBrains.Application.Settings.Storage.KeyPathComponents, object> FCallback, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static void MountErase([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void MountEraseRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static void MountEraseSubtreeRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static void MountEraseSubtreeSlow([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsExact, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute()]
        public static object MountGetObsolete([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] string sPathInMount, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object MountGetRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object MountGetSlow([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsExact, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [System.ObsoleteAttribute()]
        public static void MountSetObsolete([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] string sPathInMount, [JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public static void MountSetRaw([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void MountSetSlow([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsExact, [JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    public interface ISettingsStore : JetBrains.Application.Settings.ISettingsChangedEventSource
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.DataContext.DataContexts DataContexts { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext MountingPointsTransaction { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints MountPoints { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.ISettingsSchema Schema { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        JetBrains.Application.Settings.IContextBoundSettingsStore BindToContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.IContextBoundSettingsStoreLive BindToContextLive([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ContextRange contextrange, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0);
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        JetBrains.Application.Settings.IContextBoundSettingsStore BindToContexts([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext contextNarrow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext contextWide);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.IContextBoundSettingsStore BindToContextTransient([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ContextRange contextrange, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.IContextBoundSettingsStore BindToMountPoints([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> mounts, JetBrains.Application.Settings.ISettingsStorageMountPoint mountLastInWideContext = null, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.IContextBoundSettingsStoreLive BindToMountPoints(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> mounts, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Application.Settings.ISettingsStorageMountPoint> mountLastInWideContext, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.ISettingsStoreInTransaction CreateNestedTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> GetOrderedMountPointsInContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
    }
    public interface ISettingsStoreInTransaction : JetBrains.Application.Settings.ISettingsChangedEventSource, JetBrains.Application.Settings.ISettingsStore
    {
        void CommitTransaction();
        void RevertTransaction();
    }
    public class ListWithoutPrefix<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    
    {
        public ListWithoutPrefix([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<T> body) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public T this[int index] { get; set; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { }
        public void RemoveAt(int index) { }
        public void SetBody([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<T> body) { }
    }
    public class ListWithPrefix<TItem> : System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.Generic.IList<TItem>, System.Collections.IEnumerable
    
    {
        public ListWithPrefix(TItem prefix, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TItem> body) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public TItem this[int index] { get; set; }
        public void Add(TItem item) { }
        public void Clear() { }
        public bool Contains(TItem item) { }
        public void CopyTo(TItem[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<TItem> GetEnumerator() { }
        public int IndexOf(TItem item) { }
        public void Insert(int index, TItem item) { }
        public bool Remove(TItem item) { }
        public void RemoveAt(int index) { }
    }
    [System.FlagsAttribute()]
    public enum MountPointFlags
    {
        None = 0,
        IsDefaultValues = 1,
        IsWritable = 2,
    }
    public class SettingsEntry
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string Description;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string LocalName;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartCatalogueType SettingsKeyClassMemberClrType;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string SettingsKeyClassMemberName;
        protected SettingsEntry([JetBrains.Annotations.NotNullAttribute()] string localName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey parent, [JetBrains.Annotations.NotNullAttribute()] string description, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.PartCatalogueType typeEntryMember, [JetBrains.Annotations.NotNullAttribute()] string sSettingsKeyClassMemberName) { }
        public virtual bool IsIndexed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsKey Parent { get; }
        public override string ToString() { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.All, AllowMultiple=false)]
    public class SettingsEntryAttribute : JetBrains.Application.Settings.SettingsEntryAttributeBase
    {
        public SettingsEntryAttribute([JetBrains.Annotations.CanBeNullAttribute()] object DefaultValue, [JetBrains.Annotations.NotNullAttribute()] string Description) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object DefaultValue { get; set; }
        public abstract class ReflectionHelpers : JetBrains.Application.Settings.SettingsEntryAttributeBase.ReflectionHelpers
        {
            public static readonly string DefaultValuePropertyName;
            public static TEntryMemberType GetDefaultValueFromRuntimeType<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        }
    }
    public abstract class SettingsEntryAttributeBase : System.Attribute
    {
        protected SettingsEntryAttributeBase([JetBrains.Annotations.NotNullAttribute()] string Description) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Description { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string EntryNameOverride { get; set; }
        public JetBrains.Application.Settings.SettingsStoreSerializerType ValueSerializer { get; set; }
        public abstract class ReflectionHelpers
        {
            public static readonly string DescriptionPropertyName;
            public static readonly string EntryNameOverridePropertyName;
            public static readonly System.Collections.Generic.Dictionary<string, JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId> myMapPrimitiveTypeNamesToStorageTypesWithCoersion;
            public static readonly string ValueSerializerPropertyName;
            public static string GetEntryLocalName(string membername, JetBrains.Application.Parts.PartCatalogueAttribute attribute) { }
            public static JetBrains.Application.Settings.SettingsStoreSerializerType GuessValueSerializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.PartCatalogueAttribute partattribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType membertype) { }
        }
    }
    public class SettingsIndexedEntry : JetBrains.Application.Settings.SettingsEntry
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartCatalogueType IndexClrType;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartCatalogueType IndexedValueClrType;
        public readonly JetBrains.Application.Settings.SettingsStoreSerializerType IndexedValueSerializer;
        public readonly JetBrains.Application.Settings.SettingsStoreSerializerType IndexSerializer;
        public readonly JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId SettingsStorageIndexedValueType;
        public readonly JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId SettingsStorageIndexType;
        public override bool IsIndexed { get; }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.All, AllowMultiple=false)]
    public class SettingsIndexedEntryAttribute : JetBrains.Application.Settings.SettingsEntryAttributeBase
    {
        public SettingsIndexedEntryAttribute([JetBrains.Annotations.NotNullAttribute()] string Description) { }
        public JetBrains.Application.Settings.SettingsStoreSerializerType KeySerializer { get; set; }
        public abstract class ReflectionHelpers : JetBrains.Application.Settings.SettingsEntryAttributeBase.ReflectionHelpers
        {
            public static readonly string KeySerializerPropertyName;
            public static JetBrains.Application.Settings.SettingsStoreSerializerType GuessKeySerializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.PartCatalogueAttribute partattribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType typeKey) { }
        }
    }
    public class SettingsIndexedKey : JetBrains.Application.Settings.SettingsKey
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartCatalogueType IndexClrType;
        public readonly JetBrains.Application.Settings.SettingsStoreSerializerType IndexSerializer;
        public override bool IsIndexed { get; }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class SettingsIndexedKeyAttribute : JetBrains.Application.Settings.SettingsKeyAttributeBase
    {
        public SettingsIndexedKeyAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type Parent, [JetBrains.Annotations.NotNullAttribute()] string Description, [JetBrains.Annotations.NotNullAttribute()] System.Type indexType) { }
        public JetBrains.Application.Settings.SettingsStoreSerializerType IndexSerializer { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Type IndexType { get; }
        public abstract class ReflectionHelpers : JetBrains.Application.Settings.SettingsKeyAttributeBase.ReflectionHelpers
        {
            public static readonly string KeySerializerPropertyName;
            public static readonly string MappingKeyTypePropertyName;
            public static JetBrains.Application.Settings.SettingsStoreSerializerType GuessKeySerializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.PartCatalogueAttribute partattribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.PartCatalogueType typeKey) { }
        }
    }
    public class SettingsKey
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string Description;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string LocalName;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartCatalogueType SettingsKeyClassClrType;
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.ObjectModel.ReadOnlyCollection<JetBrains.Application.Settings.SettingsKey> Children { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Settings.SettingsEntry> Entries { get; }
        public virtual bool IsIndexed { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Application.Settings.SettingsKey Parent { get; }
        public override string ToString() { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class SettingsKeyAttribute : JetBrains.Application.Settings.SettingsKeyAttributeBase
    {
        public SettingsKeyAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type parent, [JetBrains.Annotations.NotNullAttribute()] string description) { }
        public abstract class ReflectionHelpers : JetBrains.Application.Settings.SettingsKeyAttributeBase.ReflectionHelpers { }
    }
    public class SettingsKeyAttributeBase : JetBrains.Application.Parts.PartAttribute
    {
        public SettingsKeyAttributeBase([JetBrains.Annotations.NotNullAttribute()] System.Type Parent, [JetBrains.Annotations.NotNullAttribute()] string Description) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Description { get; }
        public string KeyNameOverride { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Type Parent { get; }
        public abstract class ReflectionHelpers
        {
            public static readonly string[] ClassNameSufficesToIgnoreInKeyName;
            public static readonly string DescriptionPropertyName;
            public static readonly string KeyNameOverridePropertyName;
            public static readonly string NoParentKeyTypeFullName;
            public static readonly string ParentPropertyName;
            public static string GetKeyLocalName(JetBrains.Application.Parts.PartCatalogueType typeWithAttribute, JetBrains.Application.Parts.PartCatalogueAttribute attribute) { }
        }
    }
    public class static SettingsOptimization
    {
        public static readonly JetBrains.Application.Settings.ISettingsOptimization DoMeSlowly;
        public static readonly JetBrains.Application.Settings.ISettingsOptimization OptimizeDefault;
        public class EmitLcgOptimization : JetBrains.Application.Settings.ISettingsOptimization
        {
            public EmitLcgOptimization(JetBrains.Application.Settings.Logging.ISettingsLogger logging) { }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsOptimizationComponent : JetBrains.Application.Settings.ISettingsOptimization
    {
        public SettingsOptimizationComponent(JetBrains.Application.Settings.Logging.ISettingsLogger wrapLoggerForSettings) { }
    }
    public class SettingsScalarEntry : JetBrains.Application.Settings.SettingsEntry
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly object RawDefaultValue;
        public readonly JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId SettingsStorageEntryType;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Parts.PartCatalogueType ValueClrType;
        public readonly JetBrains.Application.Settings.SettingsStoreSerializerType ValueSerializer;
        public static TValue GetDefaultValue<TKeyClass, TValue>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStore settings, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TValue>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object GetDefaultValueInEntryMemberType() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsSchema : JetBrains.Application.Settings.ISettingsSchema
    {
        public SettingsSchema(JetBrains.Application.Settings.SettingsSchemaCollector collector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.SettingsKey> RootKeys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsEntry GetEntry<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsEntry GetEntry<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, object>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsIndexedEntry GetIndexedEntry<TKeyClass, TEntryMemberType>(System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsIndexedEntry GetIndexedEntry<TKeyClass, TEntryIndex, TEntryValue>(System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsIndexedKey GetIndexedKey<TKey>() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsKey GetKey([JetBrains.Annotations.NotNullAttribute()] System.Type typeSettingsClass) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsKey GetKey<TKey>() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsScalarEntry GetScalarEntry<TKeyClass, TEntryMemberType>(System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsSchemaCollector
    {
        public SettingsSchemaCollector([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.RunsProducts.ProductPartsCatalogSet catalogset, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger settingsLogger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.SettingsKey GetKey([JetBrains.Annotations.NotNullAttribute()] System.Type typeSettingsClass) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.SettingsKey> GetRootKeys() { }
    }
    public class static SettingsStorageMountPointPriorityClasses
    {
        public static readonly double AmbientStorage;
        public static readonly double GlobalAllProductStorage;
        public static readonly double GlobalPerProductStorage;
        public static readonly double HierarchyStorage;
        public static readonly double SyntheticPriorityOfSmartLayer;
        public static readonly double TemporaryOverrideWriteOperations;
    }
    public class SettingsStoreChangeArgs
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.JetHashSet<JetBrains.Application.Settings.SettingsEntry> ChangedEntries;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.JetHashSet<JetBrains.Application.Settings.SettingsKey> ChangedKeys;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.JetHashSetSorted<JetBrains.Application.Settings.Storage.KeyPathComponents> ChangedStorageKeys;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.IList<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsKeyInstance> RootKeys;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.ISettingsSchema Schema;
        public SettingsStoreChangeArgs([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSetSorted<JetBrains.Application.Settings.Storage.KeyPathComponents> changedStorageKeys, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsSchema schema, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public class SettingsEntryInstance
        {
            public static readonly System.Func<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsEntryInstance, string> FGetLocalNameAndIndex;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly string IndexSerialized;
            public bool IsChangedItself;
            public readonly JetBrains.Application.Settings.SettingsEntry SettingsEntry;
            public SettingsEntryInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsEntry schemaentry, [JetBrains.Annotations.CanBeNullAttribute()] string indexSerialized, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public object GetIndexValue() { }
            public override string ToString() { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public object TryGetIndexValue() { }
        }
        public class SettingsKeyInstance
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Collections.Generic.IList<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsKeyInstance> Children;
            public readonly System.Collections.Generic.IList<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsEntryInstance> Entries;
            public static readonly System.Func<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsKeyInstance, string> FGetLocalNameAndIndex;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly string IndexSerialized;
            public bool IsChangedItself;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Settings.SettingsKey SettingsKey;
            public SettingsKeyInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey schemakey, [JetBrains.Annotations.CanBeNullAttribute()] string indexSerialized, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string CombineLocalNameAndIndex([JetBrains.Annotations.NotNullAttribute()] string localname, [JetBrains.Annotations.CanBeNullAttribute()] string indexSerialized) { }
            public override string ToString() { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public object TryGetIndexValue() { }
        }
    }
    public class static SettingsStoreChangeArgsEx_Visit
    {
        public static void Visit([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.SettingsStoreChangeArgs thіs, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsKeyInstance, JetBrains.Application.Settings.SettingsIndexedKey, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object>> FIndexedKey = null, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsEntryInstance, JetBrains.Application.Settings.SettingsScalarEntry, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object>> FScalarEntry = null, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsEntryInstance, JetBrains.Application.Settings.SettingsIndexedEntry, object, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object>> FIndexedEntry = null, JetBrains.Util.ILogger logger = null) { }
    }
    public class static SettingsStoreEx
    {
        public static void AdviseChange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsChangedEventSource thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsEntry entry, [JetBrains.Annotations.NotNullAttribute()] System.Action FOnChange) { }
        public static void AdviseChange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsChangedEventSource thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.NotNullAttribute()] System.Action FOnChange) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void AppendIndexedValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore settingsStore, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TEntryIndex, TEntryValue>> newValues, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static JetBrains.Application.Settings.IContextBoundSettingsStore BindToContext([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, bool isForWriting = True) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static JetBrains.Application.Settings.IContextBoundSettingsStore BindToContexts([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContextNarrow, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContextWide) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Does not work anymore. Use a transaction.")]
        public static JetBrains.Application.src.Settings.ContextBoundSettingsStore BoundToContextForTemporaryChanges([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext dataContext) { }
        public static void CopyTo([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, JetBrains.Application.Settings.SettingsKey keyRoot = null, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        public static object CreateIndexedEntryAccess([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void CreateIndexedKey<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<TEntryIndex> EnumEntryIndices<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<TEntryIndex> EnumEntryIndices<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<TEntryIndex> EnumEntryIndices<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<object> EnumEntryIndices([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        [System.ObsoleteAttribute("Use EnumIndexedValues().Keys")]
        public static System.Collections.Generic.IEnumerable<object> EnumEntryIndices([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<TEntryValue> EnumEntryValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TEntryIndex, TEntryValue>> EnumerateIndexedEntry<TKeyClass, TEntryIndex, TEntryValue>(this JetBrains.Application.Settings.ISettingsStore settingsStore, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> context, System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TKeyIndex, TKeyClass>> EnumIndexedKeys<TKeyIndex, TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TKeyIndex, TKeyClass>> EnumIndexedKeys<TKeyIndex, TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey settingsKey, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<TKeyIndex> EnumKeyIndices<TKeyClass, TKeyIndex>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<TKeyIndex> EnumKeyIndices<TKeyClass, TKeyIndex>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<TKeyIndex> EnumKeyIndices<TKeyClass, TKeyIndex>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static System.Collections.Generic.IEnumerable<object> EnumKeyIndices(this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey settkey, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        [System.ObsoleteAttribute("Use EnumIndexedKey()")]
        public static System.Collections.Generic.IEnumerable<object> EnumKeyIndices([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TEntryValue GetIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static TEntryValue GetIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static TEntryValue GetIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static object GetIndexedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TSettingsKeyClass GetKey<TSettingsKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static TSettingsKeyClass GetKey<TSettingsKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FDataContext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static TSettingsKeyClass GetKey<TSettingsKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static object GetKey([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization optimization) { }
        public static TEntryValue GetValue<TKeyClass, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static TEntryValue GetValue<TKeyClass, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static TEntryValue GetValue<TKeyClass, TEntryValue>(this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static object GetValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Bind to context live and use GetValueProperty, which is also writable.")]
        public static JetBrains.DataFlow.IProperty<TEntryMemberType> GetValueLive<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FDataContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Bind to context live and use GetValueProperty, which is also writable.")]
        public static JetBrains.DataFlow.IProperty<TEntryMemberType> GetValueLive<TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FDataContext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TEntryMemberType> GetValueProperty<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStoreLive thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use IContextBoundSettingsStoreLive::GetValueProperty.")]
        public static JetBrains.DataFlow.IProperty<TEntryMemberType> GetValuePropertyTmp<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStoreLive thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression) { }
        public static bool IsIndexedKeyDefined<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public static void RemoveIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void RemoveIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void RemoveIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void RemoveIndexedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void ResetIndexedValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore settingsStore, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        public static void ResetValue<TKeyClass, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void ResetValue<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, object>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void ResetValue<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, object>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void ResetValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry source, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        public static void SetBinding<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TEntryMemberType> propTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyindices = null) { }
        public static void SetBinding<TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TEntryMemberType> propTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyindices = null) { }
        public static void SetBinding<TKeyClass, TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryMemberType>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject taregtobj, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty targetprop) { }
        public static void SetBinding<TEntryMemberType>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject taregtobj, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty targetprop) { }
        public static void SetIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, [JetBrains.Annotations.NotNullAttribute()] TEntryValue value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, [JetBrains.Annotations.NotNullAttribute()] TEntryValue value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetIndexedValue<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryIndex entryIndex, [JetBrains.Annotations.NotNullAttribute()] TEntryValue value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetIndexedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.NotNullAttribute()] object value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetIndexedValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore settingsStore, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TEntryIndex, TEntryValue>> newValues, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        public static void SetKey<TSettingsKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] TSettingsKeyClass settingsKeyValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null)
            where TSettingsKeyClass :  class { }
        public static void SetKey([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.NotNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsOptimization optimization) { }
        public static void SetValue<TKeyClass, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryValue value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetValue<TKeyClass, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryValue value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetValue<TKeyClass, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEntryValue>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] TEntryValue value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Use BindToContextLive or BindToContextTransient.")]
        public static void SetValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.ISettingsStore thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] object value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
    }
    public enum SettingsStoreSerializerType
    {
        Auto = 0,
        Primitive = 1,
        TypeConverterToInvariantString = 2,
        XmlSerializer = 3,
        XamlSerializer = 4,
        BinaryFormatter = 5,
    }
}
namespace JetBrains.Application.Settings.Extentions
{
    
    public interface ICachedSettingsReader<out T>
    
    {
        JetBrains.Application.Settings.SettingsKey KeyExposed { get; }
        T ReadData(JetBrains.Application.Settings.IContextBoundSettingsStore store);
    }
    public interface ISettingsCache
    {
        T GetData<T>(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.Extentions.ICachedSettingsReader<T> reader)
            where T :  class;
    }
    public abstract class SettingsCacheBase : JetBrains.Application.Settings.Extentions.ISettingsCache
    {
        protected SettingsCacheBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Extentions.SettingsCacheBase parentCache, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
        protected SettingsCacheBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.Extentions.SettingsCacheBase parentCache, JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected virtual bool ContextsHaveDifferencesInternal(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dc1, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dc2, JetBrains.Application.Settings.SettingsKey key) { }
        public T GetData<T>(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.Extentions.ICachedSettingsReader<T> reader)
            where T :  class { }
    }
}
namespace JetBrains.Application.Settings.Logging
{
    
    public interface ISettingsLogger
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.ILogger Logger { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsLogging : JetBrains.Application.Settings.Logging.ISettingsLogger
    {
        public SettingsLogging([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerSystem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.RunsProducts.ProductConfigurations config) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Logging.SettingsLogging.FilterOuterWorldExceptionsLogger CollectedSettingsExceptions { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.Util.ILogger GetLoggerCore() { }
        public class FilterOuterWorldExceptionsLogger : JetBrains.Util.ILogger
        {
            public FilterOuterWorldExceptionsLogger([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerSystem) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<System.Exception> RecycleInformationalExceptions(bool isResettingTotalCounter) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<System.Exception> RecycleOuterWorldExceptions(bool isResettingTotalCounter) { }
        }
    }
    public class WrapLoggerForSettings : JetBrains.Application.Settings.Logging.ISettingsLogger
    {
        public WrapLoggerForSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
}
namespace JetBrains.Application.Settings.Storage
{
    
    public struct ContentSubstring
    {
        public readonly short RawLengthPlus1;
        public readonly short RawOffset;
        public readonly int RawValue;
        public ContentSubstring(int offset, int length) { }
        public bool IsWhole { get; }
        public static JetBrains.Application.Settings.Storage.ContentSubstring Whole { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public string ApplyTo(string content) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool AssertValid(int nTotalLen, JetBrains.Util.OnError onerror) { }
        [JetBrains.Annotations.PureAttribute()]
        public char GetFirstChar(string content) { }
        [JetBrains.Annotations.PureAttribute()]
        public int GetLength(int nTotalLen) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool GetOffsetAndLength(int nTotalLen, out uint nOffset, out uint nLength) { }
        [JetBrains.Annotations.PureAttribute()]
        public override string ToString() { }
        [JetBrains.Annotations.PureAttribute()]
        public void WriteTo(string content, [JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder sb) { }
    }
    public abstract class FileSettingsStorageProviderBase : JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.ISettingsStorageMountPoint>, JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.Storage.ISettingsStorage>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.ISettingsStorageMountPoint MountPoint;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.Storage.Persistence.XmlFileSettingsStorage XmlFileStorage;
        protected FileSettingsStorageProviderBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> path, bool isWritable, double priority, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IIsAvailable isAvailable, JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SavingEmptyContent whenNoContent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.DataFlow.PropertyId, object>> metadata = null) { }
    }
    public interface ISettingsStorage
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        void AdviseChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Settings.Storage.SettingsStorageChangeArgs> FOnChange, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.Storage.ISettingsStorageTransactionData AttachToTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionToAttach, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionOuter = null);
        void Enum(JetBrains.Application.Settings.Storage.KeyPathComponents root, int nTakeChildLevelOnly, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Settings.Storage.KeyPathComponents, object> FCallback, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null);
        void EraseSubtree(JetBrains.Application.Settings.Storage.KeyPathComponents root, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction);
        [JetBrains.Annotations.CanBeNullAttribute()]
        object Get(JetBrains.Application.Settings.Storage.KeyPathComponents key, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null);
        void Set(JetBrains.Application.Settings.Storage.KeyPathComponents key, [JetBrains.Annotations.CanBeNullAttribute()] object value, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null);
    }
    [System.ObsoleteAttribute()]
    public class static ISettingsStorageEx_Obsolete
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public static System.Collections.Generic.ICollection<string> EnumKeysObsolete([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.Storage.ISettingsStorage thіs, [JetBrains.Annotations.NotNullAttribute()] string keyPrefix, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute()]
        public static object GetObsolete([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.Storage.ISettingsStorage thіs, [JetBrains.Annotations.NotNullAttribute()] string key, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null) { }
        [System.ObsoleteAttribute()]
        public static void SetObsolete([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.Storage.ISettingsStorage thіs, [JetBrains.Annotations.NotNullAttribute()] string key, [JetBrains.Annotations.CanBeNullAttribute()] object value, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null) { }
    }
    public interface ISettingsStorageSerializable : JetBrains.Application.Settings.Storage.ISettingsStorage, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageEntriesSerialization, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageSerializationCommon { }
    public interface ISettingsStorageTransactionContext
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        void AttachStorages([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.Storage.ISettingsStorage> storages);
        void CommitAllStorages();
        [JetBrains.Annotations.NotNullAttribute()]
        TData GetTransactionData<TData>([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorage storage)
            where TData : JetBrains.Application.Settings.Storage.ISettingsStorageTransactionData;
        void RevertAllStorages();
    }
    public interface ISettingsStorageTransactionData
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Settings.Storage.ISettingsStorage Storage { get; }
        void Commit();
        void Revert();
    }
    public struct KeyPathComponent : System.IComparable<JetBrains.Application.Settings.Storage.KeyPathComponent>, System.IEquatable<JetBrains.Application.Settings.Storage.KeyPathComponent>
    {
        public readonly string Content;
        public readonly char ContentPrefix;
        public readonly JetBrains.Application.Settings.Storage.ContentSubstring ContentSubstring;
        public KeyPathComponent(string content, char prefix =  , JetBrains.Application.Settings.Storage.ContentSubstring substring = null) { }
        public bool IsNull { get; }
        public int Length { get; }
        public static JetBrains.Application.Settings.Storage.KeyPathComponent AsNormalized(JetBrains.Application.Settings.Storage.KeyPathComponent unnormalized) { }
        public bool AssertValid(JetBrains.Util.OnError onerror = null) { }
        public int CompareTo(JetBrains.Application.Settings.Storage.KeyPathComponent other) { }
        public override bool Equals(object obj) { }
        public bool Equals(string s) { }
        public bool Equals(JetBrains.Application.Settings.Storage.KeyPathComponent other) { }
        public static JetBrains.Application.Settings.Storage.KeyPathComponent FromString([JetBrains.Annotations.NotNullAttribute()] string s) { }
        public static JetBrains.Application.Settings.Storage.KeyPathComponent FromSubstring([JetBrains.Annotations.NotNullAttribute()] string s, int offset = 0, int length = -1, char prefix =  ) { }
        public char GetFirstChar() { }
        public override int GetHashCode() { }
        public string GetPathComponentSlow() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetTextWithoutFirstCharSlow() { }
        public bool IsEmpty() { }
        public override string ToString() { }
        public void Write([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder sb) { }
    }
    public struct KeyPathComponents : System.IComparable<JetBrains.Application.Settings.Storage.KeyPathComponents>, System.IEquatable<JetBrains.Application.Settings.Storage.KeyPathComponents>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Settings.Storage.KeyPathComponent> Components;
        public static readonly char PathSeparatorChar;
        public static readonly string PathSeparatorString;
        public KeyPathComponents([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.Settings.Storage.KeyPathComponent> components) { }
        public JetBrains.Application.Settings.Storage.KeyPathComponents Clone() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Application.Settings.Storage.KeyPathComponents other) { }
        public override int GetHashCode() { }
        public JetBrains.Application.Settings.Storage.KeyPathComponents Intern([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.DataStructures.ChunkHashSet<JetBrains.Application.Settings.Storage.KeyPathComponent> interneds) { }
        public static JetBrains.Application.Settings.Storage.KeyPathComponents Parse([JetBrains.Annotations.NotNullAttribute()] string s) { }
        public static JetBrains.Application.Settings.Storage.KeyPathComponents ParseInterned([JetBrains.Annotations.NotNullAttribute()] string s, JetBrains.Util.DataStructures.ChunkHashSet<JetBrains.Application.Settings.Storage.KeyPathComponent> interneds) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string RenderToStringSlow(bool isAddingLeadingSlash) { }
        public bool StartsWith(JetBrains.Application.Settings.Storage.KeyPathComponents prefix) { }
        public override string ToString() { }
    }
    public class SettingsStorageBase : JetBrains.Application.Settings.Storage.ISettingsStorage, JetBrains.Application.Settings.Storage.ISettingsStorageSerializable, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageEntriesSerialization, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageSerializationCommon
    {
        public SettingsStorageBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public string Name { get; }
        public void EraseSubtree(JetBrains.Application.Settings.Storage.KeyPathComponents root, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public override string ToString() { }
    }
    public struct SettingsStorageChangeArgs
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.dataStructures.FrugalLocalList<JetBrains.Application.Settings.Storage.KeyPathComponents> Keys;
        public SettingsStorageChangeArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.dataStructures.FrugalLocalList<JetBrains.Application.Settings.Storage.KeyPathComponents> keys) { }
    }
    public class static SettingsStorageFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Settings.Storage.ISettingsStorageSerializable CreateStorage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    public class SettingsStorageFlat : JetBrains.Application.Settings.Storage.ISettingsStorage, JetBrains.Application.Settings.Storage.ISettingsStorageSerializable, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageEntriesSerialization, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageSerializationCommon
    {
        public SettingsStorageFlat([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public override string ToString() { }
    }
    public class static SettingsStorageHelpers
    {
        public static readonly System.Collections.Generic.Dictionary<System.Type, JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId> MapPrimitiveTypesToStorageTypesWithCoersion;
        public static readonly JetBrains.Util.BidirectionalMap<JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId, System.Type> MapTypeIds;
        public static void AssertValidLocalName([JetBrains.Annotations.NotNullAttribute()] string sKeyLocalName) { }
        public static void AssertValidStoreType([JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        public static void AssertValidStoreType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object CoerceEntryDefaultValueToRuntimeType([JetBrains.Annotations.CanBeNullAttribute()] object oValue, [JetBrains.Annotations.NotNullAttribute()] System.Type typeTarget, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId GetSettingsStorageSerializedType([JetBrains.Annotations.NotNullAttribute()] string sClrTypeFullName, JetBrains.Application.Settings.SettingsStoreSerializerType valueSerializer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object GetStorageDefaultValue(JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId typeid) { }
        public static bool IsValidLocalName([JetBrains.Annotations.NotNullAttribute()] string sKeyLocalName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.OnError onerror = null) { }
        public static JetBrains.Application.Settings.SettingsStoreSerializerType ResolveAutoSerializer(JetBrains.Application.Settings.SettingsStoreSerializerType serializer, [JetBrains.Annotations.NotNullAttribute()] string sTypeFullName) { }
        public static bool ValueEquals([JetBrains.Annotations.CanBeNullAttribute()] object α, [JetBrains.Annotations.CanBeNullAttribute()] object β) { }
        public enum StorageValueTypeId
        {
            Boolean = 0,
            Integer = 1,
            Floating = 2,
            String = 3,
            Blob = 4,
        }
    }
    public enum SettingsStorageLoadFlag
    {
        FirstTime = 0,
        SecondTime = 1,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsStorageProvidersCollection : JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.ISettingsStorageMountPoint>, JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.Storage.ISettingsStorage>
    {
        public SettingsStorageProvidersCollection([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> MountPoints { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Settings.Storage.ISettingsStorage> Storages { get; }
    }
    public class SettingsStorageTransactionContext : JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext
    {
        public SettingsStorageTransactionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionOuter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TData GetTransactionData<TData>([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorage storage)
            where TData : JetBrains.Application.Settings.Storage.ISettingsStorageTransactionData { }
        public override string ToString() { }
    }
    public struct Substring : System.IComparable<JetBrains.Application.Settings.Storage.Substring>, System.IEquatable<JetBrains.Application.Settings.Storage.Substring>
    {
        public readonly string Content;
        public readonly JetBrains.Application.Settings.Storage.ContentSubstring ContentSubstring;
        public bool Equals(JetBrains.Application.Settings.Storage.Substring other) { }
        public override bool Equals(object other) { }
        public static JetBrains.Application.Settings.Storage.Substring FromString([JetBrains.Annotations.NotNullAttribute()] string s) { }
        public static JetBrains.Application.Settings.Storage.Substring FromSubstring([JetBrains.Annotations.NotNullAttribute()] string s, int offset = 0, int length = -1) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
}
namespace JetBrains.Application.Settings.Storage.DefaultFileStorages
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class GlobalAllProductsStorage : JetBrains.Application.Settings.Storage.FileSettingsStorageProviderBase
    {
        public GlobalAllProductsStorage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.Components.AnyProductSettingsLocation settingsLocation, JetBrains.Threading.IThreading threading, JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GlobalPerProductStorage : JetBrains.Application.Settings.Storage.FileSettingsStorageProviderBase
    {
        public GlobalPerProductStorage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.Components.AnyProductSettingsLocation settingsLocation, JetBrains.Threading.IThreading threading, JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, JetBrains.Application.IProductNameAndVersion product, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GlobalSettings
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity AllProductsLayerId;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> BindForWritingToAllProducts;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity ProductGlobalLayerId;
        public GlobalSettings(JetBrains.Application.Settings.Storage.DefaultFileStorages.GlobalPerProductStorage perProductStorage, JetBrains.Application.Settings.Storage.DefaultFileStorages.GlobalAllProductsStorage allProductsStorage, JetBrains.Application.Settings.ISettingsStore store) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> BindForSmartWritingToReadonlyContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mountReadonly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ContextRange contextrangeWithReadonlyMount) { }
    }
}
namespace JetBrains.Application.Settings.Storage.Format
{
    
    [System.ComponentModel.DefaultPropertyAttribute("Content")]
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Application.Settings.Storage.Format.Base64BlobConverter))]
    [System.Windows.Markup.ContentPropertyAttribute("Content")]
    [System.Windows.Markup.ValueSerializerAttribute(typeof(JetBrains.Application.Settings.Storage.Format.Base64BlobValueSerializer))]
    public class Base64Blob
    {
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public byte[] Content { get; set; }
        public bool Equals(byte[] other) { }
        public bool Equals(JetBrains.Application.Settings.Storage.Format.Base64Blob other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class Base64BlobConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.Application.Settings.Storage.Format.Base64Blob>
    {
        public Base64BlobConverter() { }
    }
    public class Base64BlobValueSerializer : JetBrains.Util.Reflection.ValueSerializerBase<JetBrains.Application.Settings.Storage.Format.Base64Blob>
    {
        public Base64BlobValueSerializer() { }
    }
}
namespace JetBrains.Application.Settings.Storage.Persistence
{
    
    public class EntriesReader
    {
        public readonly System.Collections.Generic.Dictionary<string, object> Entries;
        public readonly System.Collections.Generic.List<JetBrains.Util.Pair<string, JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition>> EntryPositions;
        public readonly System.Collections.Generic.List<JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition> ResourceDictionaryPositions;
        public EntriesReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Storage.Persistence.EntriesReader Run([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader reader, JetBrains.Application.Settings.Storage.Persistence.EntriesReader.EntryPositionsFlag entryPositionsFlag) { }
        public enum EntryPositionsFlag
        {
            Drop = 0,
            Record = 1,
        }
        public enum State
        {
            Initial = 0,
            GenericRead = 1,
            UsedUp = 2,
            ReadEntryElementStart = 3,
            ReadEntryValueBegin = 4,
            ReadEntryValueEndClear = 5,
            ReadEntryValueNodes = 6,
            ReadEntryValueEndError = 7,
            ReadEntryValueEndNewEntry = 8,
        }
    }
    public class static EntriesWriter
    {
        public static JetBrains.Application.Settings.Storage.Persistence.EntriesWriter.RunResult Run([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.Dictionary<string, object> entries, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action<System.Xml.XmlReader>> FCreateReader, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action<System.Xml.XmlWriter>> FCreateWriter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForReading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForWriting) { }
        public enum RunResult
        {
            NewSignificantContent = 0,
            NoChange = 1,
            NoSignificantContent = 2,
            NoContentAtAll = 3,
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileSettingsStorageBehavior
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ICollectionEvents<object> DiskOperationSuppression;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsDiskOperationAllowed;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsSaveToDiskAllowed;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.ILogger Logger;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ICollectionEvents<object> SaveToDiskSuppression;
        public FileSettingsStorageBehavior([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IViewable<JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior.IFileSettingsStorageBehaviorProvider> behaviorproviders, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger logging, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        public virtual bool QueryEditFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public interface IFileSettingsStorageBehaviorProvider
        {
            void Bind([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior);
            bool QueryEditFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path);
        }
    }
    public interface ISettingsStorageEntriesSerialization : JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageSerializationCommon
    {
        void Load(JetBrains.Application.Settings.Storage.SettingsStorageLoadFlag flag, [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Collections.Generic.Dictionary<string, object>> FReadEntries);
        void Save([JetBrains.Annotations.NotNullAttribute()] System.Func<System.Collections.Generic.Dictionary<string, object>, bool> FSave);
    }
    public interface ISettingsStorageSerializationCommon
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> IsDirty { get; }
        System.Nullable<bool> IsEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.Dictionary<string, object> GetInMemoryChangesDiffCopy();
    }
    public interface ISettingsStorageStreamSerialization : JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageSerializationCommon
    {
        void Load(JetBrains.Application.Settings.Storage.SettingsStorageLoadFlag flag, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action<System.IO.Stream>> FWithStream, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger);
        System.Nullable<JetBrains.Application.Settings.Storage.Persistence.EntriesWriter.RunResult> Save([JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action<System.IO.Stream>> FWithReadStream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action<System.IO.Stream>> FWithWriteStream, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForReading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForWriting);
    }
    public class LocationAwareXmlReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo
    {
        public LocationAwareXmlReader([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader underlyingReader) { }
        public override int AttributeCount { get; }
        public override string BaseURI { get; }
        public override bool CanReadBinaryContent { get; }
        public override bool CanReadValueChunk { get; }
        public override bool CanResolveEntity { get; }
        public override int Depth { get; }
        public override bool EOF { get; }
        public override bool HasAttributes { get; }
        public override bool HasValue { get; }
        public override bool IsDefault { get; }
        public override bool IsEmptyElement { get; }
        public override string LocalName { get; }
        public override string Name { get; }
        public override string NamespaceURI { get; }
        public override System.Xml.XmlNameTable NameTable { get; }
        public int NodeAbsoluteIndex { get; }
        public override System.Xml.XmlNodeType NodeType { get; }
        public override string Prefix { get; }
        public override char QuoteChar { get; }
        public override System.Xml.ReadState ReadState { get; }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get; }
        public override System.Xml.XmlReaderSettings Settings { get; }
        public override string Value { get; }
        public override System.Type ValueType { get; }
        public override string XmlLang { get; }
        public override System.Xml.XmlSpace XmlSpace { get; }
        public override void Close() { }
        public JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition CurrentPositionSnapshot() { }
        public JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition CurrentPositionVolatile() { }
        protected override void Dispose(bool disposing) { }
        public override string GetAttribute(string name) { }
        public override string GetAttribute(string name, string namespaceURI) { }
        public override string GetAttribute(int i) { }
        public override string LookupNamespace(string prefix) { }
        public override bool MoveToAttribute(string name) { }
        public override bool MoveToAttribute(string name, string ns) { }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToElement() { }
        public override bool MoveToFirstAttribute() { }
        public override bool MoveToNextAttribute() { }
        public override bool Read() { }
        public override bool ReadAttributeValue() { }
        public override int ReadValueChunk(char[] buffer, int index, int count) { }
        public override void ResolveEntity() { }
        public override string ToString() { }
        public struct NodePosition : System.IComparable<JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition>, System.IEquatable<JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition>
        {
            public JetBrains.Util.dataStructures.FrugalLocalList<System.Nullable<int>> ElementIndices;
            public JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition.ElementTagKinds ElementTagKind;
            public int OffsetFromElementTag;
            public int Depth { get; }
            public JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition Clone() { }
            public int CompareTo(JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition other) { }
            public static JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition CreateFromXmlElement([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement xmlElement) { }
            public bool Equals(JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Xml.XmlElement GetXmlElementByPosition([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument xmlDoc) { }
            public bool IsDescendantOf(JetBrains.Application.Settings.Storage.Persistence.LocationAwareXmlReader.NodePosition parent) { }
            public bool IsElement() { }
            public override string ToString() { }
            public enum ElementTagKinds
            {
                Opening = 0,
                Closing = 1,
                EmptyElement = 2,
            }
        }
    }
    public class static SettingsStorageXmlHelpers
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Xml.XmlReaderSettings XmlReaderSettingsRecommended;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Xml.XmlWriterSettings XmlWriterSettingsRecommended;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetXmlElementLocalNameByValueTypeId(JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId typeid) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetXmlKeyAttributeLocalName() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetXmlNamespaceUriByValueTypeId(JetBrains.Application.Settings.Storage.SettingsStorageHelpers.StorageValueTypeId typeid) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetXmlNamespaceUriForKeyAttribute() { }
        public class static LocalName
        {
            public static readonly string Blob;
            public static readonly string Boolean;
            public static readonly string Floating;
            public static readonly string Integer;
            public const string Key = "Key";
            public static readonly string String;
        }
        public class static NamespaceUri
        {
            public const string SettingsStorageFormat = "urn:shemas-jetbrains-com:settings-storage-xaml";
            public const string SystemInMscorlib = "clr-namespace:System;assembly=mscorlib";
            public const string SystemWindows = "http://schemas.microsoft.com/winfx/2006/xaml/presentation";
            public const string SystemWindowsMarkup = "http://schemas.microsoft.com/winfx/2006/xaml";
        }
        public class XmlNamespaceDescriptions
        {
            public XmlNamespaceDescriptions() { }
            public JetBrains.Application.Settings.Storage.Persistence.SettingsStorageXmlHelpers.XmlNamespaceDescriptions.NamespaceUriKind ResolveNamespaceUri([JetBrains.Annotations.NotNullAttribute()] string nsuri) { }
            public enum NamespaceUriKind
            {
                System = 0,
                Markup = 1,
                Settings = 2,
                Etc = 3,
                SystemWindows = 4,
            }
        }
    }
    public class SettingsStorageXmlStreamSerialization : JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageSerializationCommon, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageStreamSerialization
    {
        public SettingsStorageXmlStreamSerialization(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageEntriesSerialization storage) { }
    }
    public class SettingsStoreSerializationToXmlDiskFile
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> Path;
        public SettingsStoreSerializationToXmlDiskFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.Persistence.ISettingsStorageStreamSerialization storage, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> path, JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SavingEmptyContent whenNoContent, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior) { }
        public JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SavingEmptyContent FileWhenNoContent { get; }
        public void Reload(JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.ReloadReason reason) { }
        public void ReloadOnFileChangeRequested() { }
        public void Save(JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SaveDiffFlags flagsDiff, JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SaveForcedFlags flagsForced) { }
        public void SaveRequested() { }
        public enum ReloadReason
        {
            Initial = 0,
            FileChange = 1,
        }
        public enum SaveDiffFlags
        {
            ApplyInMemoryDiff = 0,
            OverwriteWithMemoryContent = 2,
        }
        public enum SaveForcedFlags
        {
            WriteIfPossible = 0,
            ForcedWrite = 1,
        }
        public enum SavingEmptyContent
        {
            KeepFile = 0,
            DeleteFile = 1,
        }
    }
    public class XmlFileSettingsStorage
    {
        public static readonly string SettingsStorageFileExtensionWithDot;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.Storage.ISettingsStorageSerializable Storage;
        public XmlFileSettingsStorage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> path, JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SavingEmptyContent whenNoContent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior) { }
        public JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SavingEmptyContent FileWhenNoContent { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> Path { get; }
        public void ReloadFromDiskNow() { }
        public void ReloadFromDiskRequested() { }
        public void SaveToDiskNow() { }
        public void SaveToDiskRequested() { }
        public override string ToString() { }
    }
}
namespace JetBrains.Application.Settings.Store
{
    
    public class static ContextBoundSettingStoreEx
    {
        [System.ObsoleteAttribute("Not reviewed yet, likely to change.")]
        public static void AppendIndexedValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TEntryIndex, TEntryValue>> newValues, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Slow. Use EnumIndexedValues instead.")]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TEntryIndex, TEntryValue>> EnumerateIndexedEntry<TKeyClass, TEntryIndex, TEntryValue>(this JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Not reviewed yet, likely to change.")]
        public static void ResetIndexedValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
        [System.ObsoleteAttribute("Not reviewed yet, likely to change.")]
        public static void SetIndexedValues<TKeyClass, TEntryIndex, TEntryValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryIndex, TEntryValue>>> lambdaexpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TEntryIndex, TEntryValue>> newValues, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices = null) { }
    }
    public interface IIndexedEntry<TIndex, TIndexedValue>
    
    
    {
        bool ContainsIndex([JetBrains.Annotations.NotNullAttribute()] TIndex index);
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TIndex, TIndexedValue>> EnumIndexedValues();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<TIndex> EnumPossibleIndices();
        [JetBrains.Annotations.NotNullAttribute()]
        TIndexedValue Get([JetBrains.Annotations.NotNullAttribute()] TIndex index, [JetBrains.Annotations.NotNullAttribute()] TIndexedValue defaultvalue);
        void SnapshotAndFreeze();
        [JetBrains.Annotations.CanBeNullAttribute()]
        TIndexedValue TryGet([JetBrains.Annotations.NotNullAttribute()] TIndex index);
        bool TryGet([JetBrains.Annotations.NotNullAttribute()] TIndex index, [JetBrains.Annotations.CanBeNullAttribute()] out TIndexedValue value);
    }
    public class IndexedEntry<TIndex, TIndexedValue> : JetBrains.Application.Settings.Store.IIndexedEntry<TIndex, TIndexedValue>
    
    
    {
        public IndexedEntry([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TIndex, TIndexedValue>> EnumIndexedValues() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<TIndex> EnumPossibleIndices() { }
        public void SnapshotAndFreeze() { }
    }
    public class OneToSetSettingAccessor<TKeyClass, TIndex, TValue>
    
    
    
    {
        public void Add(TIndex index, params TValue[] values) { }
        public void Clear() { }
        public static JetBrains.Application.Settings.Store.OneToSetSettingAccessor<TKeyClass, TIndex, TValue> Create(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.IDataContext dataContext, System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TValue, bool>>> expression) { }
        public static JetBrains.Application.Settings.Store.OneToSetSettingAccessor<TKeyClass, TIndex, TValue> Create(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TValue, bool>>> expression) { }
        public System.Collections.Generic.IEnumerable<TIndex> GetIndicesWithValues() { }
        public System.Collections.Generic.IEnumerable<TValue> GetValues(TIndex index) { }
        public void Remove(TIndex index, TValue value) { }
        public void RemoveIndex(TIndex index) { }
    }
    public class static SettingsIndexedKeyUtil
    {
        public static System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> AddKey<TIndex>(this System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> dictionary, JetBrains.Application.Settings.SettingsKey settingsKey, TIndex index) { }
        public static System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> CreateKeyIndices<TKeyClass, TIndex>(JetBrains.Application.Settings.ISettingsStore store, TIndex index) { }
        public static System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> CreateKeyIndices<TIndex>(JetBrains.Application.Settings.SettingsKey settingsKey, TIndex index) { }
    }
}
namespace JetBrains.Application.Settings.Store.Implementation
{
    
    [System.FlagsAttribute()]
    public enum BindToContextFlags
    {
        Normal = 0,
        IgnoreReadonlyFlag = 2,
    }
    public class ContextBoundSettingsStoreLive : JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient, JetBrains.Application.Settings.IContextBoundSettingsStore, JetBrains.Application.Settings.IContextBoundSettingsStoreLive, JetBrains.Application.Settings.ISettingsChangedEventSource
    {
        public ContextBoundSettingsStoreLive([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreLive.IContextBoundMountsInfoLive mountsinfo, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStoreChangeSink changes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch changedispatch, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public class ContextBoundMountsInfoLive : JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreLive.IContextBoundMountsInfoLive, JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.IContextBoundMountsInfo
        {
            public ContextBoundMountsInfoLive([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> mounts, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Application.Settings.ISettingsStorageMountPoint> lastWideMount) { }
        }
        public interface IContextBoundMountsInfoLive : JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.IContextBoundMountsInfo
        {
            JetBrains.DataFlow.IListEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> MountsLive { get; }
        }
    }
    public class ContextBoundSettingsStoreTransient : JetBrains.Application.Settings.IContextBoundSettingsStore
    {
        protected readonly JetBrains.Util.ILogger myLogger;
        protected readonly JetBrains.Application.Settings.ISettingsStore myStore;
        public ContextBoundSettingsStoreTransient([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeLimitOnly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.IContextBoundMountsInfo mountsinfo, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch changedispatch, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.KeyPathComponentsCached KeyPathComponentsCache { get; }
        public class ContextBoundMountsInfoTransient : JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.IContextBoundMountsInfo
        {
            public ContextBoundMountsInfoTransient([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> mounts, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint lastWideMount = null) { }
            public ContextBoundMountsInfoTransient([JetBrains.Annotations.NotNullAttribute()] params JetBrains.Application.Settings.ISettingsStorageMountPoint[] mounts) { }
            public ContextBoundMountsInfoTransient([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint[] mounts, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint lastWideMount) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.ContextBoundMountsInfoTransient FromContextRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ContextRange contextRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        }
        public interface IContextBoundMountsInfo
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            JetBrains.Application.Settings.ISettingsStorageMountPoint LastWideMount { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            JetBrains.Application.Settings.ISettingsStorageMountPoint[] Mounts { get; }
            void GetDataSync(out JetBrains.Application.Settings.ISettingsStorageMountPoint mounts, out JetBrains.Application.Settings.ISettingsStorageMountPoint mountLastWide);
        }
        protected class KeyPathComponentsCached
        {
            public static readonly int CachedKeyPathComponentsCount;
            public int myIsInUse;
            public KeyPathComponentsCached() { }
            public JetBrains.Application.Settings.Storage.KeyPathComponents BeginUse([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch changedispatch, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
            public void EndUse([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch changedispatch, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        }
    }
    public class DefaultIsAvailableOptimizedGroup : JetBrains.Application.Settings.IIsAvailableOptimizedGroup
    {
        public DefaultIsAvailableOptimizedGroup([JetBrains.Annotations.NotNullAttribute()] object item, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IIsAvailable availability) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultSettingsMountPoints : JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.ISettingsStorageMountPoint>, JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.Storage.ISettingsStorage>
    {
        public DefaultSettingsMountPoints([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger logging, JetBrains.DataFlow.IViewable<JetBrains.Application.Settings.IHaveDefaultSettingsStream> streamproviders, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        public void LoadFromResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Reflection.Assembly assembly, [JetBrains.Annotations.NotNullAttribute()] string resname) { }
        public void LoadFromStream([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream) { }
    }
    public class IsAvailable : JetBrains.Application.Settings.IIsAvailable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Application.Settings.IIsAvailable Always;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Application.Settings.IIsAvailable Never;
        public IsAvailable([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, bool> FIsAvailable) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Settings.IIsAvailable Create([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.DataContext.IDataContext, bool> FIsAvailable) { }
    }
    public class IsAvailableByDataConstant<TDataConstant> : JetBrains.Application.Settings.IIsAvailable, JetBrains.Application.Settings.IIsAvailableOptimization
        where TDataConstant :  class
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.DataContext.DataConstant<TDataConstant> Constant;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly TDataConstant Value;
        public IsAvailableByDataConstant([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataConstant<TDataConstant> constant, [JetBrains.Annotations.NotNullAttribute()] TDataConstant value, JetBrains.Application.IShellLocks locks = null) { }
    }
    public interface ISettingsChangeDispatch
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Action RegisterForDispatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FDispatch);
        void ResumeThreadDispatch();
        void SuppressThreadDispatch();
    }
    public class Provider<TItem> : JetBrains.Application.Settings.IProvider<TItem>
    
    {
        public Provider(JetBrains.DataFlow.Lifetime lifetime, string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<TItem> Items { get; }
    }
    public class static ReadonlyXmlStreamSettingsStorage
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Settings.Storage.ISettingsStorage ReadFromXmlStream([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    public class static ScalarSettingsStoreAccess
    {
        public static void CreateIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void DeleteIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, bool isForcingRemovalRecord, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object GetIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryindex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object GetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static bool IsIndexedKeyDefined([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void RemoveIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryindex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, bool isForcingRemovalRecord, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void ResetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void SetIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryindex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] object value, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void SetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] object value, bool isWritingDefaultValues, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsChangeDispatch : JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch
    {
        public static readonly System.TimeSpan OptionChangeGroupingInterval;
        public SettingsChangeDispatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger settingsLogger, System.Nullable<bool> isAsyncProhibited) { }
    }
    public class static SettingsEntryToSettingsStorageSerialization
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object DeserializeStorageKeyToEntryIndex([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object DeserializeStorageKeyToKeyIndex([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object DeserializeStorageValueToEntryValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] object valueInStorage, JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object DeserializeStorageValueToEntryValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object valueInStorage, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string SerializeEntryIndexToStorageKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object valueOfIndex, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object SerializeEntryIndexToStorageValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object valueIndexAtRuntime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object SerializeEntryValueToStorageValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] object valueInEntry, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object SerializeEntryValueToStorageValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object valueInEntry, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string SerializeKeyIndexToStorageKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] object valueOfIndex, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public class static CoreStorageSerialization
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static object DeserializeStorageKey(JetBrains.Application.Settings.SettingsStoreSerializerType serializerType, [JetBrains.Annotations.NotNullAttribute()] string valueSerialized, [JetBrains.Annotations.NotNullAttribute()] System.Type typeDeserialized, JetBrains.Util.ILogger logger) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static object DeserializeStorageValue(JetBrains.Application.Settings.SettingsStoreSerializerType serializerType, [JetBrains.Annotations.NotNullAttribute()] object valueSerialized, [JetBrains.Annotations.NotNullAttribute()] System.Type typeDeserialized, JetBrains.Util.ILogger logger) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static string SerializeStorageKey(JetBrains.Application.Settings.SettingsStoreSerializerType serializerType, [JetBrains.Annotations.NotNullAttribute()] object valueDeserialized, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static object SerializeStorageValue(JetBrains.Application.Settings.SettingsStoreSerializerType serializerType, [JetBrains.Annotations.NotNullAttribute()] object valueDeserialized, [JetBrains.Annotations.NotNullAttribute()] System.Type typeSerialized, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
            public class static StringToLocalNameSerializer
            {
                [JetBrains.Annotations.NotNullAttribute()]
                public static string Deserialize([JetBrains.Annotations.NotNullAttribute()] string sSerialized) { }
                public static bool IsLetThruChar(char ch) { }
                [JetBrains.Annotations.NotNullAttribute()]
                public static string Serialize([JetBrains.Annotations.NotNullAttribute()] string sDeserialized) { }
            }
        }
    }
    public class SettingsStorageMountPoint : JetBrains.Application.Settings.ISettingsStorageMountPoint
    {
        public SettingsStorageMountPoint([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorage storage, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath pathInStorage, JetBrains.Application.Settings.MountPointFlags flags, double priority, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IIsAvailable isAvailable, string name = null) { }
        public override string ToString() { }
        public class MountPath : System.IEquatable<JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath>
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public static readonly JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath Default;
            public MountPath([JetBrains.Annotations.NotNullAttribute()] string value) { }
            public MountPath(JetBrains.Application.Settings.Storage.KeyPathComponent pathcomponent) { }
            public JetBrains.Application.Settings.Storage.KeyPathComponent KeyPathComponent { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            [System.ObsoleteAttribute("Prefer using KeyPathComponent, this property is not consistent over leading/trail" +
                "ing slashes.")]
            public string Value { get; }
            public bool Equals(JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            public override string ToString() { }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsStorageMountPoints
    {
        public static readonly JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints Empty;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> EnumMountPointsLiveOrdered;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> MountPoints;
        public SettingsStorageMountPoints([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IViewable<JetBrains.Application.Settings.IProvider<JetBrains.Application.Settings.ISettingsStorageMountPoint>> mounts, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger logging, JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints.SelfCheckControl selfCheckControl) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> FilterMountsByContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        public class SelfCheckControl
        {
            public readonly bool OptionIsSelfCheckOn;
            protected SelfCheckControl(bool optionIsSelfCheckOn) { }
        }
        [JetBrains.Application.ShellComponentAttribute()]
        public class SelfCheckControlOffForNormalRuntime : JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints.SelfCheckControl
        {
            public SelfCheckControlOffForNormalRuntime() { }
        }
        public class SelfCheckControlOn : JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints.SelfCheckControl
        {
            public SelfCheckControlOn() { }
        }
    }
    public class SettingsStorageOnMountPoints : JetBrains.Application.Settings.Storage.ISettingsStorage
    {
        public SettingsStorageOnMountPoints([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ContextBoundSettingsStoreTransient.IContextBoundMountsInfo mountsinfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public string Name { get; }
        [System.ObsoleteAttribute()]
        public void CopyToObsolete([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mountTarget, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionThis, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transactionTarget, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, string sRootKey = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public System.Collections.Generic.ICollection<string> EnumKeysObsolete([JetBrains.Annotations.NotNullAttribute()] string keyPrefix, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public void EnumRaw(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, int nTakeChildLevelOnly, System.Action<JetBrains.Application.Settings.Storage.KeyPathComponents, object> FCallback, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public void EraseObsolete([JetBrains.Annotations.NotNullAttribute()] string key, bool isIgnoringReadonlyFlag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public void EraseRaw(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, bool isIgnoringReadonlyFlag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public void EraseSlow(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsExact, bool isIgnoringReadonlyFlag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute()]
        public JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.ValueFromMount GetExObsolete([JetBrains.Annotations.NotNullAttribute()] string key, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.ValueFromMount GetExRaw([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute()]
        public object GetObsolete([JetBrains.Annotations.NotNullAttribute()] string key, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object GetRaw(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public static bool IsMountWritable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, bool isIgnoringReadonlyFlag) { }
        [System.ObsoleteAttribute()]
        public void SetObsolete([JetBrains.Annotations.NotNullAttribute()] string key, [JetBrains.Annotations.CanBeNullAttribute()] object value, bool isIgnoreReadonlyFlag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public void SetRaw(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.CanBeNullAttribute()] object value, bool isIgnoreReadonlyFlag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SetSmartResult SetSmartRaw(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.NotNullAttribute()] object valuePrimary, JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SetFlags flags, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction) { }
        public JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SetSmartResult SetSmartRaw(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponentsWithEmptySlot, [JetBrains.Annotations.NotNullAttribute()] object valuePrimary, JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SetFlags flags, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, ref JetBrains.Application.Settings.Storage.KeyPathComponent componentSecondary, [JetBrains.Annotations.CanBeNullAttribute()] object valueSecondary) { }
        public override string ToString() { }
        [System.FlagsAttribute()]
        public enum SetFlags
        {
            IgnoreReadonlyFlag = 1,
            IsNullValueOk = 2,
            IsSecondaryNullValueOk = 4,
        }
        public struct SetSmartResult
        {
            [System.Diagnostics.ConditionalAttribute("Never_712C803FF44B4952B66809847B3C5ED0")]
            public void AddWriteData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, int layerIndex, JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SmartWriteAction action) { }
            [System.Diagnostics.ConditionalAttribute("Never_712C803FF44B4952B66809847B3C5ED0")]
            public void SetResult(bool isSuccessful, int nLayerLastSeenValueIn, JetBrains.Application.Settings.ISettingsStorageMountPoint settingsStorageMountPoint) { }
        }
        public struct SetSmartResult_ReplacedWithDummy
        {
            public int EffectiveReadLayerIndex;
            public JetBrains.Application.Settings.ISettingsStorageMountPoint EffectiveReadMountPoint;
            public bool IsSuccessful;
            public JetBrains.Util.dataStructures.FrugalLocalList<JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SetSmartResult_ReplacedWithDummy.WriteData> WrittenTo;
            public void AddWriteData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, int layerIndex, JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SmartWriteAction action) { }
            public void SetResult(bool isSuccessful, int nEffectiveReadLayerIndex, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mountEffectiveRead) { }
            public struct WriteData
            {
                public JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SmartWriteAction Action;
                public int LayerIndex;
                public JetBrains.Application.Settings.ISettingsStorageMountPoint MountPoint;
                public WriteData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint mount, int layerIndex, JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints.SmartWriteAction action) { }
            }
        }
        public enum SmartWriteAction
        {
            PassedReadonlyOk = 0,
            PassedReadonlyConflicting = 1,
            ValueAlreadyWritten = 2,
            WroteValue = 3,
            ErasedValue = 4,
        }
        public struct ValueFromMount
        {
            public int Layer;
            public JetBrains.Application.Settings.ISettingsStorageMountPoint Mount;
            public object Value;
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsStore : JetBrains.Application.Settings.ISettingsChangedEventSource, JetBrains.Application.Settings.ISettingsStore, JetBrains.Application.Settings.ISettingsStoreInTransaction
    {
        public SettingsStore([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsSchema schema, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints mountpoints, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.DataContexts dataContexts, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger logging, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch changedispatch) { }
        public JetBrains.DataFlow.ISignal<JetBrains.Application.Settings.SettingsStoreChangeArgs> Changed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.DataContext.DataContexts DataContexts { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints MountPoints { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.ISettingsSchema Schema { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.IContextBoundSettingsStore BindToContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        public JetBrains.Application.Settings.IContextBoundSettingsStoreLive BindToContextLive(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ContextRange contextrange, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0) { }
        public JetBrains.Application.Settings.IContextBoundSettingsStore BindToContexts([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext contextNarrow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext contextWide) { }
        public JetBrains.Application.Settings.IContextBoundSettingsStore BindToContextTransient(JetBrains.Application.Settings.ContextRange contextrange, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0) { }
        public JetBrains.Application.Settings.IContextBoundSettingsStore BindToMountPoints([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> mounts, JetBrains.Application.Settings.ISettingsStorageMountPoint mountLastInWideContext = null, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0) { }
        public JetBrains.Application.Settings.IContextBoundSettingsStoreLive BindToMountPoints(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> mounts, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Application.Settings.ISettingsStorageMountPoint> mountLastInWideContext, JetBrains.Application.Settings.Store.Implementation.BindToContextFlags flags = 0) { }
        public JetBrains.Application.Settings.ISettingsStoreInTransaction CreateNestedTransaction([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> GetOrderedMountPointsInContext(JetBrains.Application.DataContext.IDataContext context) { }
        public override string ToString() { }
    }
    public class SettingsStoreChangeSink
    {
        public SettingsStoreChangeSink([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.ISettingsChangeDispatch changedispatch) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Store.Implementation.SettingsStoreChangeSink.ClientInfo RegisterClientForMounts([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Application.Settings.ISettingsStorageMountPoint> mountsInitial) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Store.Implementation.SettingsStoreChangeSink.ClientInfo RegisterClientForMountsLive([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Settings.ISettingsStorageMountPoint> mountsLive) { }
        public class ClientInfo
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.DataFlow.ISignal<JetBrains.Application.Settings.SettingsStoreChangeArgs> Changed;
            public void FireChanged([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsStoreChangeArgs args) { }
        }
    }
    public class static StoreToStorageTranslation
    {
        public static void AppendEntryKeyPathComponent(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponents, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] object indexToEntry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AppendIndex([JetBrains.Annotations.NotNullAttribute()] string sKeyBase, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] object index, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AppendIndex([JetBrains.Annotations.NotNullAttribute()] string sKeyBase, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object index, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AppendLocalName([JetBrains.Annotations.NotNullAttribute()] string sKeyBase, [JetBrains.Annotations.NotNullAttribute()] string sLocalName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AppendMetadata([JetBrains.Annotations.NotNullAttribute()] string sKeyBase, [JetBrains.Annotations.NotNullAttribute()] string sMetadataName) { }
        public static bool FillKeyPathComponents(JetBrains.Application.Settings.Storage.KeyPathComponents keyPathComponents, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.Application.Settings.Storage.KeyPathComponents, bool> FCallAfterEachIndexedKey) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Application.Settings.SettingsStoreChangeArgs.SettingsKeyInstance> ParseStorageKeys([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSetSorted<JetBrains.Application.Settings.Storage.KeyPathComponents> keys, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsSchema schema, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string SettingsEntry_To_StorageKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string SettingsEntryValueAttribute_To_StorageKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> mappingKeys, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string SettingsKey_To_StorageKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public class static Metadata
        {
            public static readonly string EntryDescription;
            public static readonly string EntryIndex;
            public static readonly string EntryIndexedValue;
            public static readonly string EntryIndexedValueSerializer;
            public static readonly string EntryIndexedValueType;
            public static readonly string EntryIndexRemoved;
            public static readonly string EntryIndexSerializer;
            public static readonly string EntryIndexType;
            public static readonly string EntrySerializer;
            public static readonly string EntryType;
            public static readonly string EntryValue;
            public static readonly string InvalidEntryIndex;
            public static readonly string InvalidKeyIndex;
            public static readonly string KeyDescription;
            public static readonly string KeyIndexDefined;
            public class static AsPathComponent
            {
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryDescriptionComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexedValueComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexedValueSerializerComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexedValueTypeComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexRemovedComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexSerializerComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryIndexTypeComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntrySerializerComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryTypeComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent EntryValueComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent InvalidEntryIndexComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent InvalidKeyIndexComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent KeyDescriptionComponent;
                public static readonly JetBrains.Application.Settings.Storage.KeyPathComponent KeyIndexDefinedComponent;
            }
            public class static WithMetadataPrefixComposed
            {
                public static readonly string AtEntryDescription;
                public static readonly string AtEntryIndex;
                public static readonly string AtEntryIndexedValue;
                public static readonly string AtEntryIndexedValueSerializer;
                public static readonly string AtEntryIndexedValueType;
                public static readonly string AtEntryIndexRemoved;
                public static readonly string AtEntryIndexSerializer;
                public static readonly string AtEntryIndexType;
                public static readonly string AtEntrySerializer;
                public static readonly string AtEntryType;
                public static readonly string AtEntryValue;
                public static readonly string AtInvalidEntryIndex;
                public static readonly string AtInvalidKeyIndex;
                public static readonly string AtKeyDescription;
                public static readonly string AtKeyIndexDefined;
            }
        }
        public class static PathComposition
        {
            public static readonly char KeyPathSeparator;
            public static readonly char MetadataPrefix;
            public static readonly char ValueInLocalNamePrefix;
        }
    }
}
namespace JetBrains.Application.Settings.Upgrade
{
    
    public class static UpgradeSettingsTableUtil
    {
        public static void UpgradeBoolSetting<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Configuration.SettingsTableBase table, string propertyName, bool defaultValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, bool>> targetExpr) { }
        public static void UpgradeBoolSetting<TKeyClass, TValueClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Configuration.SettingsTableBase table, string propertyName, bool defaultValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TValueClass>> targetExpr, System.Func<bool, TValueClass> converterFunc) { }
        public static void UpgradeEnumSetting<TKeyClass, TEnumValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Configuration.SettingsTableBase table, string propertyName, TEnumValue defaultValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TEnumValue>> targetExpr) { }
        public static void UpgradeIntSetting<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Configuration.SettingsTableBase table, string propertyName, int defaultValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, int>> targetExpr) { }
        public static void UpgradeIntSetting<TKeyClass, TValueClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Configuration.SettingsTableBase table, string propertyName, int defaultValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, TValueClass>> targetExpr, System.Func<int, TValueClass> converter) { }
        public static void UpgradeStringSetting<TKeyClass>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Configuration.SettingsTableBase table, string propertyName, string defaultValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TKeyClass, string>> targetExpr) { }
    }
}
namespace JetBrains.Application.Settings.UserInterface.FileInjectedLayers
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileInjectedLayers
    {
        public FileInjectedLayers(JetBrains.Application.Settings.UserInterface.FileInjectedLayers.RegisterInjectedMounts registrar) { }
        public void InjectLayer(JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity host, JetBrains.Util.FileSystemPath file) { }
        public bool IsLayerInjected(JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity host, JetBrains.Util.FileSystemPath file) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.Application.Settings.UserInterface.InjectedLayersSettingsKey), "An injected layer created over a file path.", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class FileInjectedLayerSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Specifies the absolute path to the file-based user-injected layer. This must be d" +
            "efined for any valid file-based injected layer.")]
        public JetBrains.Util.FileSystemPath AbsolutePath;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, @"Specifies the relative path to the file-based user-injected layer, relatively to its hosting layer. This is only available when the hosting layer is also file-based and has its path available, and these paths are off the same root. When defined, this path should be preferred for restoring the mounted layer in the new session.")]
        public JetBrains.Util.FileSystemPath RelativePath;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RegisterInjectedMounts
    {
        public RegisterInjectedMounts(JetBrains.DataFlow.Lifetime lifetimeComponentUnsynchronized, JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers injections, JetBrains.Threading.IThreading threading, JetBrains.Application.Settings.Logging.ISettingsLogger logging, JetBrains.Application.Settings.SettingsSchema schema, JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void Synchronize() { }
    }
}
namespace JetBrains.Application.Settings.UserInterface
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "User-injected layers list stored in the injections host layer.")]
    public class InjectedLayersSettingsKey { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResetSettings
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity>> AfterResetSettings;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity>> BeforeResetSettings;
        public ResetSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Logging.ISettingsLogger settingslogging, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints mounts, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers injector) { }
        public void Reset(JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerid = null, System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.Application.Settings.SettingsKey, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object>>> keys = null) { }
        public void ResetAllSettings() { }
    }
    public class UserFriendlySettingsLayer
    {
        public readonly JetBrains.DataFlow.IProperty<string> DisplayName;
        public readonly JetBrains.DataFlow.IProperty<System.Windows.Media.ImageSource> Icon;
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity Id;
        public readonly JetBrains.DataFlow.IPropertyBag Metadata;
        public readonly JetBrains.DataFlow.IProperty<string> OriginText;
        public readonly double Priority;
        public readonly JetBrains.Application.Settings.IContextBoundSettingsStoreLive SettingsStoreContext;
        public bool IsDefault { get; }
        public string Name { get; }
        public override string ToString() { }
        public class Identity : System.IComparable<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity>, System.IEquatable<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity>
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly JetBrains.Application.Settings.ISettingsStorageMountPoint CharacteristicMount;
            public Identity([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStorageMountPoint characteristicMount) { }
            public bool Equals(JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            public override string ToString() { }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UserFriendlySettingsLayers
    {
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer DefaultLayer;
        public static readonly string DefaultLayerOriginText;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.Util.FileSystemPath> DiskFilePath;
        public static readonly JetBrains.DataFlow.PropertyId<string> DisplayName;
        public static readonly JetBrains.DataFlow.PropertyId<System.Windows.Media.ImageSource> Icon;
        public static readonly JetBrains.DataFlow.PropertyId<bool> IsHiddenFromUserFriendlyLayers;
        public static readonly JetBrains.DataFlow.PropertyId<bool> IsNonUserEditable;
        public static readonly JetBrains.DataFlow.PropertyId<string> Origin;
        public static readonly JetBrains.DataFlow.PropertyId<bool> SettingsLayersProductOptOut;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.ISettingsStore SettingsStore;
        public readonly JetBrains.DataFlow.ListEvents<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer> VisibleLayers;
        public readonly JetBrains.DataFlow.ListEvents<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer> WritableLayers;
        public UserFriendlySettingsLayers([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayers.Flags flags = 0) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer GetLayerById([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity identity) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer TryGetLayerById([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity identity) { }
        [System.FlagsAttribute()]
        public enum Flags
        {
            IncludeHiddenLayers = 1,
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UserInjectedSettingsLayers
    {
        public static readonly JetBrains.DataFlow.PropertyId<bool> IsHostingUserInjections;
        public static readonly JetBrains.DataFlow.PropertyId<bool> IsUserInjected;
        public readonly JetBrains.DataFlow.CollectionEvents<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer> LayersHostingUserInjections;
        public UserInjectedSettingsLayers(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoints mounts, JetBrains.Application.Settings.Logging.ISettingsLogger logging, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection providersCollection, JetBrains.Application.Settings.ISettingsStore store, JetBrains.Threading.IThreading threading) { }
        public bool CanReorderInjectedLayers([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerToMove, JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.ReorderInjectedLayersFlags how) { }
        public void DeleteUserInjectedLayer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerInjected) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer> GetAllUserInjectedLayers() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer GetLayerHostingUserInjectedLayer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerInjected) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer> GetUserInjectedLayersFromHost([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerHost) { }
        public bool IsHostingUserInjectedLayers([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerPossiblyHostingInjections) { }
        public bool IsInjectedLayerOn([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerInjected) { }
        public bool IsUserInjectedLayer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerPossiblyInjected) { }
        public void RegisterUserInjectedLayer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeInjection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.UserInjectedLayerDescriptor descriptor) { }
        public void ReorderInjectedLayers([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerToMove, JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.ReorderInjectedLayersFlags how, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity other) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer TryGetLayerHostingUserInjectedLayer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerPossiblyInjected) { }
        public bool TurnInjectedLayerOnOff(JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity layerInjected, System.Nullable<bool> desired) { }
        [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.Application.Settings.UserInterface.InjectedLayersSettingsKey), "Centrally-managed customization of injected layers of this hosting layer, like th" +
            "eir on/off state and order. Layer-kind-specific customizations are stored by inj" +
            "ection handlers under their own keys.", typeof(JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity))]
        public class InjectedLayerCustomizationSettingsKey
        {
            [JetBrains.Application.Settings.SettingsEntryAttribute("", "A custom display name given to the layer by the user. An empty string means it\'s " +
                "not defined and whatever default is on the mounting point should be used.")]
            public string DisplayName;
            [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether this injected layer is on or off.")]
            public bool IsOn;
            [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Relative priority level of this injected layer against its hosting layer.")]
            public double RelativePriority;
        }
        [System.Windows.Markup.ValueSerializerAttribute(typeof(JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity.ValueSerializer))]
        public class InjectedLayerPersistentIdentity : System.IEquatable<JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity>
        {
            public InjectedLayerPersistentIdentity([JetBrains.Annotations.NotNullAttribute()] string identity) { }
            public bool Equals(JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            public override string ToString() { }
            public class ValueSerializer : JetBrains.Util.Reflection.ValueSerializerBase<JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity>
            {
                public ValueSerializer() { }
            }
        }
        public enum ReorderInjectedLayersFlags
        {
            MakeFirst = 0,
            MakeLast = 1,
            PutBefore = 2,
            PutAfter = 3,
            UpOne = 4,
            DownOne = 5,
        }
        public class UserInjectedLayerDescriptor
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.DataFlow.ISimpleSignal DeleteRequested;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity Identity;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.DataFlow.IPropertyBag InitialMetadata;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Settings.Storage.ISettingsStorage InjectedLayerStorage;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity InjectionsHostLayer;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath MountingPathInStorage;
            public UserInjectedLayerDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity injectionsHostLayer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.UserInterface.UserInjectedSettingsLayers.InjectedLayerPersistentIdentity identity, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorage injectedLayerStorage, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStorageMountPoint.MountPath mountingPathInStorage, [JetBrains.Annotations.NotNullAttribute()] System.Action FDelete) { }
        }
    }
}
namespace JetBrains.Application.src.Settings
{
    
    [System.ObsoleteAttribute("Use ISettingsStore::BindToContextTransient or ISettingsStore::BindToContextLive.")]
    public class ContextBoundSettingsStore : JetBrains.Application.Settings.IContextBoundSettingsStore
    {
        public ContextBoundSettingsStore([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeLimit, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStorageOnMountPoints storageLayered, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.Storage.ISettingsStorageTransactionContext transaction = null) { }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public void CopyTo(JetBrains.Application.Settings.IContextBoundSettingsStore target, JetBrains.Util.ILogger logger) { }
        public void CreateIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public void DeleteIndexedKey([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public System.Collections.Generic.IEnumerable<object> EnumEntryIndices([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public System.Collections.Generic.IEnumerable<object> EnumKeyIndices([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> parentKeyIndices) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public object GetIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public JetBrains.Application.Settings.SettingsStoreChangeArgs GetSnapshot(JetBrains.Application.Settings.SettingsKey keyRoot, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        [JetBrains.Annotations.PureAttribute()]
        public object GetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public bool IsIndexedKeyDefined([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsKey key, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public void RemoveIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public void ResetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public void SetIndexedValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, [JetBrains.Annotations.NotNullAttribute()] object value) { }
        public void SetValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry entry, [JetBrains.Annotations.NotNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
        public class static IndexedEntryAccess
        {
            public class StorageKeyPrefixForIndexedValueAttrs
            {
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string EntryRootStorageKey;
                [JetBrains.Annotations.CanBeNullAttribute()]
                public readonly System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> KeyIndices;
                [JetBrains.Annotations.NotNullAttribute()]
                public readonly string Prefix;
                public StorageKeyPrefixForIndexedValueAttrs([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsIndexedEntry entry, [JetBrains.Annotations.NotNullAttribute()] object entryIndex, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices) { }
                public override string ToString() { }
            }
        }
    }
}
namespace JetBrains.Application.Threading
{
    
    public interface IMultiCoreFibers : System.IDisposable
    {
        void EnqueueJob(System.Action action);
        void EnqueuePriorityJob(System.Action action);
    }
    public class static InvocatorEx { }
    public enum LockAffinity
    {
        NoLock = 0,
        ReadLock = 1,
        WriteLock = 2,
    }
    public enum LockKind : byte
    {
        Read = 0,
        Write = 1,
        FullWrite = 2,
        Full = 3,
    }
    public class MapReduceJob<K1, V1, K2, V2>
    
    
    
    
    {
        public MapReduceJob(
                    JetBrains.Application.IShellLocks shellLocks, 
                    System.Func<bool> checkForInterrupt, 
                    System.Action<JetBrains.Application.Threading.MapReduceJob<K1, V1, K2, V2>> onSuccessAction, 
                    System.Action<JetBrains.Application.Threading.MapReduceJob<K1, V1, K2, V2>> onInterruptAction, 
                    JetBrains.Application.Threading.LockAffinity successAndInterruptLock, 
                    System.Func<K1, V1, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<K2, V2>>> mapFunction, 
                    System.Collections.Generic.IEqualityComparer<K1> key1EqualityComparer, 
                    JetBrains.Application.Threading.TaskAffinity mapTaskAffinity, 
                    JetBrains.Application.Threading.LockAffinity mapLockAffinity, 
                    int mapBatchSize, 
                    System.Func<K2, System.Collections.Generic.ICollection<V2>, System.Collections.Generic.IList<V2>> reduceFunction, 
                    System.Collections.Generic.IEqualityComparer<K2> key2EqualityComparer, 
                    JetBrains.Application.Threading.TaskAffinity reduceTaskAffinity, 
                    JetBrains.Application.Threading.LockAffinity reduceLockAffinity, 
                    int reduceBatchSize, 
                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K1, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<K2, V2>>>> precalculatedMapResults, 
                    bool continuousLocking = False) { }
        public System.Collections.Generic.IDictionary<K1, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<K2, V2>>> MapResults { get; }
        public System.Collections.Generic.IDictionary<K2, System.Collections.Generic.IList<V2>> ReduceResults { get; }
        public JetBrains.Application.Threading.MapReduceStatus Status { get; }
        public bool IsCreatedOrInProgress() { }
        public void WaitFinishAndStealReduce() { }
        public void WaitForStatusChange(System.Func<JetBrains.Application.Threading.MapReduceStatus, bool> finishWaitCondition, System.Action<JetBrains.Application.Threading.MapReduceJob<K1, V1, K2, V2>> actionToExecuteUnderLock, bool pump = True) { }
    }
    public class MapReducer
    {
        public void Execute<K1, V1, K2, V2>(JetBrains.Application.Threading.MapReduceJob<K1, V1, K2, V2> job, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K1, V1>> mapInput) { }
        public JetBrains.Application.Threading.MapReduceJob<TBuildInput, object, TBuildInput, TBuildResult> ExecuteBuildMerge<TBuildInput, TBuildResult>(JetBrains.Application.IShellLocks shellLocks, System.Func<bool> CheckForInterrupt, System.Func<TBuildInput, TBuildResult> build, System.Action<TBuildInput, TBuildResult> merge, System.Action<JetBrains.Application.Threading.MapReduceJob<TBuildInput, object, TBuildInput, TBuildResult>> finalAction, System.Action<JetBrains.Application.Threading.MapReduceJob<TBuildInput, object, TBuildInput, TBuildResult>> interruptAction, System.Collections.Generic.IEnumerable<TBuildInput> buildInput, bool sync) { }
    }
    public enum MapReduceStatus
    {
        NotStarted = 0,
        Started = 1,
        ContinuosActivityAquiredReadLock = 2,
        MapInProgress = 3,
        PreparingReduceInput = 4,
        ReduceInProgress = 5,
        ReduceStolen = 6,
        Interrupted = 7,
        FinalActionInProgress = 8,
        InterruptionInProgress = 9,
        Finished = 10,
        InterruptionCompleted = 11,
        Failure = 12,
    }
    public class static MapReduceStatusEx
    {
        public static bool IsCreatedOrInProgress(this JetBrains.Application.Threading.MapReduceStatus status) { }
        public static bool IsTerminated(this JetBrains.Application.Threading.MapReduceStatus status) { }
    }
    public class static MultiCoreFibersEx
    {
        public static void EnqueueDependentJobs(this JetBrains.Application.Threading.IMultiCoreFibers fibers, System.Collections.Generic.IEnumerable<System.Action> actionsEnumerable, JetBrains.Util.OneToSetMap<System.Action, System.Action> actionToExecuteBefore) { }
    }
    public class MultiCoreFibersPool : System.IDisposable
    {
        public static JetBrains.Application.Threading.MultiCoreFiberStrategy Strategy;
        public MultiCoreFibersPool(string name, JetBrains.Application.IShellLocks locks, JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations, bool isEnabled = True, bool takeReadLock = True) { }
        public JetBrains.Application.Threading.IMultiCoreFibers Create(string activityDescription = null) { }
        public void Dispose() { }
    }
    public enum MultiCoreFiberStrategy
    {
        Disable = 0,
        Normal = 1,
        Agressive = 2,
    }
    public struct ReleaseLockCookie : System.IDisposable
    {
        public ReleaseLockCookie(JetBrains.Application.IShellLocks locks, JetBrains.Application.Threading.LockKind lockKind) { }
        public void Dispose() { }
    }
    public enum TaskAffinity
    {
        CallerThreadSync = 0,
        UiThread = 1,
        ThreadPool = 2,
    }
    public class WorkerThread
    {
        public WorkerThread(string name, bool synchronous = False) { }
        public JetBrains.Application.Threading.WorkerThread.WaitHandle AllCurrentJobsToFinish() { }
        public void Dispose() { }
        public JetBrains.Application.Threading.WorkerThread.WaitHandle ExecuteAsync(System.Action job) { }
        public void ExecuteSync(System.Action job) { }
        public void ExecuteSync(System.Action job, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public delegate void WaitHandle();
    }
}
namespace JetBrains.Application.XmlRpc
{
    
    public class static XmlRpcEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T AsyncExecuteTimeout<T>(System.Func<CookComputing.XmlRpc.XmlRpcAsyncResult> begin, System.Func<CookComputing.XmlRpc.XmlRpcAsyncResult, T> end, System.Func<bool> abort, System.TimeSpan timeout) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static bool AsyncExecuteTimeout(System.Func<CookComputing.XmlRpc.XmlRpcAsyncResult> begin, System.Action<CookComputing.XmlRpc.XmlRpcAsyncResult> end, System.Func<bool> abort, System.TimeSpan timeout) { }
        public static T CreateService<T>() { }
    }
}
namespace JetBrains.Build.AllAssemblies
{
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AllAssemblies", IsNullable=false, Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class AllAssembliesXml
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.IList<JetBrains.Build.AllAssemblies.AllAssembliesXml.Subplatform> AllSubplatforms;
        public AllAssembliesXml() { }
        public static System.Xml.Schema.XmlSchema AllAssembliesXmlSchema { get; }
        [System.Xml.Serialization.XmlArrayItemAttribute("Assembly", IsNullable=false)]
        public JetBrains.Build.AllAssemblies.ProductAssemblyXml[] Assemblies { get; set; }
        [System.Xml.Serialization.XmlArrayItemAttribute("ConfigurationAlias", IsNullable=false)]
        public JetBrains.Build.AllAssemblies.ConfigurationAliasXml[] ConfigurationAliases { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.ProductEdition DefaultProductEdition { get; }
        [System.Xml.Serialization.XmlArrayItemAttribute("Gac", IsNullable=false)]
        public JetBrains.Build.AllAssemblies.GacAssemblyXml[] GacReferences { get; set; }
        [System.Xml.Serialization.XmlArrayItemAttribute("KnownConfiguration", IsNullable=false)]
        public JetBrains.Build.AllAssemblies.KnownValueXml[] KnownConfigurations { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("PlatformReferences")]
        public JetBrains.Build.AllAssemblies.PlatformReferencesXml[] PlatformReferences { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Product { get; set; }
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductEdition", IsNullable=false)]
        public JetBrains.Build.AllAssemblies.ProductEditionXml[] ProductEditions { get; set; }
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable=false)]
        public JetBrains.Build.AllAssemblies.ReferenceAssemblyXml[] ProductReferences { get; set; }
        public bool ExecuteConfigurationExpression([JetBrains.Annotations.NotNullAttribute()] string expression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSet<string> activeconfigs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<string> GetOrphanedConfigs() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Build.AllAssemblies.ProductAssemblyXml GetProductAssembly([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Build.AllAssemblies.AllAssembliesXml.Subplatform GetSubplatformOfAssembly([JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.ProductAssemblyXml assembly) { }
        public static JetBrains.Build.AllAssemblies.AllAssembliesXml Load(System.IO.Stream stream) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.AssemblyConfiguration ParseAssemblyConfiguration([JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.ProductEdition ParseProductEdition([JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.ProductEdition ProductEditionFromAssemblyConfigurations([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Application.AssemblyConfiguration> assemblyconfigurations, bool bAllowOtherConfigurations, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Exception> FOnError) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.Application.AssemblyConfiguration> ProductEditionToAssemblyConfigurations([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ProductEdition productedition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
        public System.Collections.Generic.List<JetBrains.Application.AssemblyConfiguration> ResolveConfigurations([JetBrains.Annotations.NotNullAttribute()] string configurations) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Build.AllAssemblies.ProductAssemblyXml TryGetProductAssembly([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public class Subplatform
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Collections.Generic.IList<JetBrains.Build.AllAssemblies.ProductAssemblyXml> Assemblies;
            public readonly string Name;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Collections.Generic.IList<JetBrains.Build.AllAssemblies.AllAssembliesXml.Subplatform> ReferencedSubplatforms;
            public Subplatform([JetBrains.Annotations.NotNullAttribute()] string name) { }
            public override string ToString() { }
        }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class AssemblyConfigurationRefXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Build.AllAssemblies.AssemblyKind.AssemblyKindConverter))]
    public class AssemblyKind : System.IEquatable<JetBrains.Build.AllAssemblies.AssemblyKind>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly string AdditionalPath;
        public readonly JetBrains.Build.AllAssemblies.AssemblyKind.KindBase BaseKind;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Build.AllAssemblies.AssemblyKind GacReferences;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Build.AllAssemblies.AssemblyKind ProductBinaries;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Build.AllAssemblies.AssemblyKind ProductReferences;
        [JetBrains.Annotations.NotNullAttribute()]
        public string DisplayName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.AssemblyKind> AllInstallableKinds([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.AssemblyKind> AllInstallableKinds([JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allassemblies) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.AssemblyKind> AllKinds([JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allassemblies) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.AssemblyKind> AllPlatformReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allassemblies) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Build.AllAssemblies.AssemblyKind other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath FindAssemblyFile([JetBrains.Annotations.NotNullAttribute()] string sAssemblyName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer.InstallerSourceFoldersResolver sourceFoldersResolver) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml> GetAssemblies([JetBrains.Annotations.NotNullAttribute()] JetBrains.Build.AllAssemblies.AllAssembliesXml allassemblies) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml> GetAssembliesInConfiguration([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml> GetAssembliesInConfiguration([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor descriptor, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> assemblyconfigurations) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml> GetAssembliesInConfiguration([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor descriptor, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSet<string> configs) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Build.AllAssemblies.AssemblyKind PlatformReferences([JetBrains.Annotations.NotNullAttribute()] string sPlatformName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath ResolveFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer.InstallerSourceFoldersResolver sourceFoldersResolver) { }
        public override string ToString() { }
        public class AssemblyKindConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.Build.AllAssemblies.AssemblyKind>
        {
            public AssemblyKindConverter() { }
        }
        public enum KindBase
        {
            ProductBinaries = 0,
            ProductReferences = 1,
            PlatformReferences = 2,
            GacReferences = 3,
        }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.GacAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.AssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.InstalledAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ReferenceAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ProductAssemblyXml))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class AssemblyNameXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.InstalledAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ReferenceAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ProductAssemblyXml))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class AssemblyXml : JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml
    {
        public AssemblyXml() { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ComSelfRegister { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasAppConfig { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasMainfest { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasProgramDatabase { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasXmlDoc { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasXmlSerializers { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ConfigurationAliasXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Configurations { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ProductAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.GacAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.AssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.InstalledAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ReferenceAssemblyXml))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ConfiguredAssemblyXml : JetBrains.Build.AllAssemblies.AssemblyNameXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Configurations { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ExcludedTypeXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class GacAssemblyXml : JetBrains.Build.AllAssemblies.ConfiguredAssemblyXml { }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ReferenceAssemblyXml))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ProductAssemblyXml))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class InstalledAssemblyXml : JetBrains.Build.AllAssemblies.AssemblyXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MsiComponentGuid { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.ProductEditionXml))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class KnownValueXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class PlatformReferencesXml : JetBrains.Build.AllAssemblies.ReferencesXml
    {
        public PlatformReferencesXml() { }
        [System.ComponentModel.DefaultValueAttribute("Platform")]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlatformName { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ProductAssemblyXml : JetBrains.Build.AllAssemblies.InstalledAssemblyXml
    {
        public ProductAssemblyXml() { }
        [System.Xml.Serialization.XmlElementAttribute("ExcludedType")]
        public JetBrains.Build.AllAssemblies.ExcludedTypeXml[] ExcludedType { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsMEF { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Subplatform { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ProductEditionXml : JetBrains.Build.AllAssemblies.KnownValueXml
    {
        [System.Xml.Serialization.XmlElementAttribute("AssemblyConfigurationRef")]
        public JetBrains.Build.AllAssemblies.AssemblyConfigurationRefXml[] AssemblyConfigurationRef { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName { get; set; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ReferenceAssemblyXml : JetBrains.Build.AllAssemblies.InstalledAssemblyXml { }
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JetBrains.Build.AllAssemblies.PlatformReferencesXml))]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:shemas-jetbrains-com:all-assemblies-xml")]
    public class ReferencesXml
    {
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public JetBrains.Build.AllAssemblies.ReferenceAssemblyXml[] Reference { get; set; }
    }
}
namespace JetBrains.ProjectModel
{
    
    public class FileSystemChange
    {
        public FileSystemChange(System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> fileSystemChangeDeltas) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> Deltas { get; }
    }
    public class FileSystemChangeDelta
    {
        public FileSystemChangeDelta(System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> childrenDeltas, JetBrains.ProjectModel.FileSystemChangeType changeType, JetBrains.Util.FileSystemPath oldPath, JetBrains.Util.FileSystemPath newPath) { }
        public JetBrains.ProjectModel.FileSystemChangeType ChangeType { get; }
        public JetBrains.Util.FileSystemPath NewPath { get; }
        public JetBrains.Util.FileSystemPath OldPath { get; }
        public void Accept(JetBrains.ProjectModel.IFileSystemChangeDeltaVisitor visitor) { }
        public void Dump(JetBrains.Util.FileSystemPath prefix, System.IO.TextWriter writer) { }
        public string Dump(JetBrains.Util.FileSystemPath prefix) { }
        public JetBrains.ProjectModel.FileSystemChangeDelta FindChangeDelta(JetBrains.Util.FileSystemPath path) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> GetChildren() { }
        public override string ToString() { }
    }
    public enum FileSystemChangeType
    {
        ADDED = 0,
        DELETED = 1,
        CHANGED = 2,
        SUBTREE_CHANGED = 3,
        RENAMED = 4,
        UNKNOWN = 5,
    }
    public interface IFileSystemChangeDeltaVisitor
    {
        void Visit(JetBrains.ProjectModel.FileSystemChangeDelta delta);
    }
    public class Pattern
    {
        public Pattern(JetBrains.Util.FileSystemPath basePath, string pattern) { }
        public JetBrains.Util.FileSystemPath BasePath { get; }
        public bool IsRecursive { get; }
        public string OriginalPattern { get; }
        public System.Text.RegularExpressions.Regex Regex { get; }
        public bool MatchWith(JetBrains.Util.FileSystemPath path) { }
        public override string ToString() { }
        public static void WritePattern(JetBrains.ProjectModel.Pattern excludePattern, System.IO.BinaryWriter writer) { }
    }
    public class RecursiveFileSystemChangeDeltaVisitor : JetBrains.ProjectModel.IFileSystemChangeDeltaVisitor
    {
        public virtual void Visit(JetBrains.ProjectModel.FileSystemChangeDelta delta) { }
    }
}
namespace JetBrains.ProjectModel.Impl
{
    
    public class FileSystemChangesPathTrie : JetBrains.Util.FileSystemPathTrie<JetBrains.Util.FileSystemEvent>
    {
        public FileSystemChangesPathTrie() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> GetDeltas(JetBrains.Util.FileSystemPath[] roots, System.Func<JetBrains.Util.FileSystemPath, bool> isIgnoredFolder) { }
        public void ProcessDeltasFromUncEntry(JetBrains.Util.QualifiedNamesTrie<JetBrains.Util.FileSystemEvent>.TrieEntry uncEntry, System.Collections.Generic.IList<JetBrains.ProjectModel.FileSystemChangeDelta> result, System.Func<JetBrains.Util.FileSystemPath, bool> isIgnoredFolder) { }
    }
    public class FileSystemScanner
    {
        public FileSystemScanner(JetBrains.ProjectModel.Pattern[] includePatterns, JetBrains.ProjectModel.Pattern[] excludePatterns) { }
        public JetBrains.Util.FileSystemPath[] RootPaths { get; }
        public JetBrains.Util.FileSystemPathTrie<JetBrains.Util.FileSystemEntryInfo> Trie { get; }
        public void Scan() { }
    }
}
namespace JetBrains.Threading
{
    
    public class Invocator : JetBrains.Threading.IThreading
    {
        public Invocator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        public JetBrains.Threading.GroupingEventHosts GroupingEvents { get; }
        public JetBrains.DataFlow.IProperty<bool> IsRecurringActivityAllowed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.ReentrancyGuard ReentrancyGuard { get; }
        public JetBrains.Threading.ThreadManager ThreadManager { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.TimedActionsHost TimedActions { get; }
    }
    public interface IThreading
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Threading.JetDispatcher Dispatcher { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Threading.GroupingEventHosts GroupingEvents { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> IsRecurringActivityAllowed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Threading.ReentrancyGuard ReentrancyGuard { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Threading.ThreadManager ThreadManager { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Threading.TimedActionsHost TimedActions { get; }
    }
    public class static IThreadingEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Threading.GroupingEvent CreateGroupingEvent([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, System.TimeSpan interval, [JetBrains.Annotations.CanBeNullAttribute()] System.Action action = null) { }
        public static bool ExecuteOrQueue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void ExecuteOrQueue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static bool ExecuteOrQueueEx([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void ExecuteOrQueueEx([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void ExecuteOrQueueWhenNotGuarded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public static void LogAssertGuarded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs) { }
        public static void Queue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void Queue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use an overload with lifetime.")]
        public static System.IDisposable QueueAt([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void QueueAt([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void QueueAt_NoReentrancyGuarding([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable QueueRecurring([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void QueueRecurring([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.IThreading thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
    }
}
namespace JetBrains.UI.CrossFramework
{
    
    public class EitherControl : System.IDisposable
    {
        public EitherControl([JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.Control control) { }
        public EitherControl([JetBrains.Annotations.NotNullAttribute()] System.Windows.UIElement element) { }
        public EitherControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Wpf.IAutomation automation) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.UI.Wpf.IAutomation Automation { get; }
        public System.Windows.Forms.Control Control { get; }
        public System.Windows.UIElement Element { get; }
        public bool IsAutomation { get; }
        public bool IsAvalon { get; }
        public bool IsDisposed { get; }
        public bool IsWinForms { get; }
        public bool IsWrapperCreated { get; }
        public JetBrains.UI.CrossFramework.EitherControl BindToLifetime([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public void Dispose() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.UI.CrossFramework.EitherControl FromAutomation([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Wpf.IAutomation automation) { }
        public static JetBrains.UI.CrossFramework.EitherControl FromObject([JetBrains.Annotations.NotNullAttribute()] object either) { }
        public override string ToString() { }
        public class DockedWindowsFormsHost : System.Windows.Forms.Integration.WindowsFormsHost
        {
            public DockedWindowsFormsHost(bool focusable = False) { }
            protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { }
        }
    }
}
namespace JetBrains.UI.Wpf
{
    
    public abstract class AAutomation : JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
    }
    public class AutomationWrapper : JetBrains.UI.Wpf.AAutomation
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly object Content;
        public AutomationWrapper([JetBrains.Annotations.CanBeNullAttribute()] object content) { }
    }
    public interface IAutomation : System.ComponentModel.INotifyPropertyChanged { }
}