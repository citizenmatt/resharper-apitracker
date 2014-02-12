[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.resources.actions.xml")]
[assembly: JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute("BundledPackages", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "packages", "plugins", JetBrains.Application.Install.InstallFromReferencesDirectoryAttribute.Recursive.No, true)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Generate",
        "FuncZoneRefactoringQuickFix",
        "Navigate",
        "AddFolder",
        "FuncZoneAnalyze",
        "Refactor",
        "AnalyzeReferences",
        "FindSymbolsExternalToScope",
        "GenerateQuickFix",
        "ExpandHaircomb",
        "Analyze",
        "OverrideOptions",
        "NavigateToSource",
        "FuncZoneRefactoring",
        "FuncZoneGenerateQuickFix",
        "RemoveUnusedRefactoring",
        "AutoScrollToSource",
        "RefactorQuickFix",
        "OverrideOptionsBack",
        "FuncZoneGenerate",
        "FuncZoneNavigate",
        "FindDependentCode"}, IconPackResourceIdentification="JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
    "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "MvcOptionsPage",
        "Spaces",
        "BlankLines",
        "Others",
        "LineBreaks"}, IconPackResourceIdentification="JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedOption" +
    "sIcons/ThemedIcons.PsiFeaturesUnsortedOptions.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-features-unsorted", "JetBrains.Resources.Icons")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-features-unsorted-options", "JetBrains.Resources.Icons")]

namespace JetBrains.Application
{
    
    public class static CommandCookie
    {
        [System.ObsoleteAttribute("Inline this method and replace Shell.Instance.GetComponent with an imported IComm" +
            "andProcessor instance.")]
        public static System.IDisposable Create(string name) { }
    }
    public struct ReadLockCookie : System.IDisposable
    {
        public static System.IDisposable Create() { }
        public static System.IDisposable Create(bool takeLock) { }
        public void Dispose() { }
        public static void Execute([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void GuardedExecute([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static bool TryExecute([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public sealed class Shell : JetBrains.Application.Env.RunsProducts.IBeforeProductStartup
    {
        public Shell([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.RunningProducts runsProducts) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public System.Collections.Generic.IList<JetBrains.Application.AssemblyConfiguration> AssemblyConfigurations { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Import IProductCommandLine.")]
        public JetBrains.Application.IProductCommandLine CommandLine { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.ShellComponents Components { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute()]
        public JetBrains.Application.IApplicationDescriptor Descriptor { get; }
        public static bool HasInstance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Shell Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Import IThreading (if you already have IShellLocks, it\'ll do).")]
        public JetBrains.Threading.IThreading Invocator { get; }
        [System.ObsoleteAttribute("Inject RunsProducts.ProductConfigurations and use .IsInternalMode() extension met" +
            "hod")]
        public bool IsInInternalMode { get; }
        [System.ObsoleteAttribute("Use separate test components (can be inherited from real ones)")]
        public bool IsTestShell { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Import IShellLocks.")]
        public JetBrains.Application.IShellLocks Locks { get; }
        [System.ObsoleteAttribute("Import IThreading and use its Dispatcher.")]
        public JetBrains.Threading.JetDispatcher PrimaryDispatcher { get; }
        [System.ObsoleteAttribute("Import IThreading and use its Dispatcher.")]
        public System.Threading.Thread PrimaryThread { get; }
        [System.ObsoleteAttribute("Modify behavior through components that are conditionally constructed (eg VS-spec" +
            "ific).")]
        public JetBrains.Application.Components.ProgramConfigurations ProgramConfiguration { get; }
        [System.ObsoleteAttribute("Currently, the state only so vaguely reflects the status of the component contain" +
            "er. Import components in all of the critical places.")]
        public JetBrains.Application.Components.ComponentStorageState State { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public TInterface GetComponent<TInterface>()
            where TInterface :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<TInterface> GetComponents<TInterface>()
            where TInterface :  class { }
        public bool HasComponent<TInterface>()
            where TInterface :  class { }
        public void SaveSettings() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TInterface TryGetComponent<TInterface>()
            where TInterface :  class { }
    }
    public struct WriteLockCookie : System.IDisposable
    {
        public static System.IDisposable Create() { }
        public static System.IDisposable Create(bool takeLock) { }
        public void Dispose() { }
        public static void Execute([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
    }
}
namespace JetBrains.ReSharper.Extenions.Settings
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultExtensionManagerSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream
    {
        public string Name { get; }
        public virtual System.IO.Stream GetDefaultSettingsStream(JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.ReSharper
{
    
    public class ReSharperApplicationDescriptor : JetBrains.Application.ApplicationDescriptor
    {
        public ReSharperApplicationDescriptor() { }
        public override System.Reflection.Assembly AllAssembliesResourceAssembly { get; }
        public override string AllAssembliesResourceName { get; }
        public override bool DoCheckLicenseReuseOverNetwork { get; }
        public override JetBrains.Application.ExceptionReport.IIssueTracker IssueTracker { get; }
        public override JetBrains.Application.License.ILicenseSupport LicenseSupport { get; }
        public override System.Drawing.Image ProductAboutBoxImage { get; }
        public override System.Drawing.Image ProductDialogHeaderImage { get; }
        public override System.Drawing.Icon ProductIcon { get; }
        public override string SampleErrorReport { get; }
        public class ProductVersionOverride : JetBrains.ReSharper.ReSharperApplicationDescriptor
        {
            public ProductVersionOverride([JetBrains.Annotations.NotNullAttribute()] System.Version versionOverride) { }
            public override System.Version ProductVersion { get; }
        }
    }
    public class static ReSharperEditions
    {
        public static bool IsCSharpEditionIncluded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public static bool IsVBNetEditionIncluded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
        public class static Ids
        {
            public const string Csharp = "Csharp";
            public const string Full = "Full";
            public const string Vbnet = "Vbnet";
        }
    }
    public class static ReSharperHelpIds
    {
        public const string Accessing_Decompiled_Files = "Accessing_Decompiled_Files";
        public const string Actions_List = "Actions_List";
        public const string Architecture__Comparing_Dependency_Snapshots = "Architecture__Comparing_Dependency_Snapshots";
        public const string Architecture__Getting_Dependency_Snapshot = "Architecture__Getting_Dependency_Snapshot";
        public const string Architecture__Project_Dependencies_Exploration = "Architecture__Project_Dependencies_Exploration";
        public const string Architecture__Working_with_Dependency_Graph = "Architecture__Working_with_Dependency_Graph";
        public const string Assemblies_from_Global_Assembly_Cache = "Assemblies_from_Global_Assembly_Cache";
        public const string CA = "CA";
        public const string Code_Analysis__Annotations_in_Source_Code = "Code_Analysis__Annotations_in_Source_Code";
        public const string Code_Analysis__Call_Tracking = "Code_Analysis__Call_Tracking";
        public const string Code_Analysis__Code_Annotations = "Code_Analysis__Code_Annotations";
        public const string Code_Analysis__Code_Highlighting = "Code_Analysis__Code_Highlighting";
        public const string Code_Analysis__Code_Inspections = "Code_Analysis__Code_Inspections";
        public const string Code_Analysis__Configuring_Warnings = "Code_Analysis__Configuring_Warnings";
        public const string Code_Analysis__Examples_of_Quick_Fixes = "Code_Analysis__Examples_of_Quick_Fixes";
        public const string Code_Analysis__External_Annotations = "Code_Analysis__External_Annotations";
        public const string Code_Analysis__Find_Similar_Issues = "Code_Analysis__Find_Similar_Issues";
        public const string Code_Analysis__Finding_Out_What_Is_Wrong_With_Your_Code = "Code_Analysis__Finding_Out_What_Is_Wrong_With_Your_Code";
        public const string Code_Analysis__Fix_in_Scope = "Code_Analysis__Fix_in_Scope";
        public const string Code_Analysis__Index = "Code_Analysis__Index";
        public const string Code_Analysis__Inspect_This = "Code_Analysis__Inspect_This";
        public const string Code_Analysis__Investigations = "Code_Analysis__Investigations";
        public const string Code_Analysis__Navigating_Between_Code_Highlights = "Code_Analysis__Navigating_Between_Code_Highlights";
        public const string Code_Analysis__Performance_of_Solution_Wide_Analysis = "Code_Analysis__Performance_of_Solution_Wide_Analysis";
        public const string Code_Analysis__Project_Hierarchy = "Code_Analysis__Project_Hierarchy";
        public const string Code_Analysis__Quick_Fixes = "Code_Analysis__Quick_Fixes";
        public const string Code_Analysis__Sharing_Inspection_Results = "Code_Analysis__Sharing_Inspection_Results";
        public const string Code_Analysis__Solution_Wide_Analysis = "Code_Analysis__Solution_Wide_Analysis";
        public const string Code_Analysis__Solution_Wide_Analysis__Configuring_Solution_Wide_Analysis = "Code_Analysis__Solution_Wide_Analysis__Configuring_Solution_Wide_Analysis";
        public const string Code_Analysis__Solution_Wide_Analysis__Enabling_Solution_Wide_Analysis = "Code_Analysis__Solution_Wide_Analysis__Enabling_Solution_Wide_Analysis";
        public const string Code_Analysis__Solution_Wide_Analysis__Solution_Wide_Code_Inspections = "Code_Analysis__Solution_Wide_Analysis__Solution_Wide_Code_Inspections";
        public const string Code_Analysis__Solution_Wide_Analysis__Viewing_Errors_In_Solution = "Code_Analysis__Solution_Wide_Analysis__Viewing_Errors_In_Solution";
        public const string Code_Analysis__Solution_Wide_Analysis__Viewing_Inspection_Results = "Code_Analysis__Solution_Wide_Analysis__Viewing_Inspection_Results";
        public const string Code_Analysis__Status_Indicator = "Code_Analysis__Status_Indicator";
        public const string Code_Analysis__String_Formatting_Methods = "Code_Analysis__String_Formatting_Methods";
        public const string Code_Analysis__Value_Analysis = "Code_Analysis__Value_Analysis";
        public const string Code_Analysis__Value_Tracking = "Code_Analysis__Value_Tracking";
        public const string Code_Cleanup__Creating_Custom_Profiles = "Code_Cleanup__Creating_Custom_Profiles";
        public const string Code_Cleanup__Default_Profiles = "Code_Cleanup__Default_Profiles";
        public const string Code_Cleanup__Index = "Code_Cleanup__Index";
        public const string Code_Cleanup__Running_Code_Cleanup = "Code_Cleanup__Running_Code_Cleanup";
        public const string Code_Cleanup__Usage_Scenarios = "Code_Cleanup__Usage_Scenarios";
        public const string Code_Cleanup__Usage_Scenarios__Configuring_and_Inserting_a_Default_File_Header = "Code_Cleanup__Usage_Scenarios__Configuring_and_Inserting_a_Default_File_Header";
        public const string Code_Cleanup__Usage_Scenarios__Migrating_to_CSharp_3_0 = "Code_Cleanup__Usage_Scenarios__Migrating_to_CSharp_3_0";
        public const string Code_Cleanup__Usage_Scenarios__Optimizing_Using_Directives = "Code_Cleanup__Usage_Scenarios__Optimizing_Using_Directives";
        public const string Code_Cleanup__Usage_Scenarios__Reformatting_Code = "Code_Cleanup__Usage_Scenarios__Reformatting_Code";
        public const string Code_Cleanup__Usage_Scenarios__Reformatting_XML = "Code_Cleanup__Usage_Scenarios__Reformatting_XML";
        public const string Code_Cleanup__Usage_Scenarios__Removing_Code_Redundancies = "Code_Cleanup__Usage_Scenarios__Removing_Code_Redundancies";
        public const string Code_Cleanup__Usage_Scenarios__Reordering_Type_Members = "Code_Cleanup__Usage_Scenarios__Reordering_Type_Members";
        public const string Code_Cleanup__Usage_Scenarios__Shortening_Qualified_References = "Code_Cleanup__Usage_Scenarios__Shortening_Qualified_References";
        public const string Code_Coverage_during_Manual_Testing = "Code_Coverage_during_Manual_Testing";
        public const string Code_Coverage_of_Unit_Tests = "Code_Coverage_of_Unit_Tests";
        public const string Code_Generation__Delegating_Members = "Code_Generation__Delegating_Members";
        public const string Code_Generation__Equality_Members = "Code_Generation__Equality_Members";
        public const string Code_Generation__Formatting_Members = "Code_Generation__Formatting_Members";
        public const string Code_Generation__Generating_Code_from_Usage = "Code_Generation__Generating_Code_from_Usage";
        public const string Code_Generation__Generating_Equality_Comparer = "Code_Generation__Generating_Equality_Comparer";
        public const string Code_Generation__Implementing_Overriding_Methods = "Code_Generation__Implementing_Overriding_Methods";
        public const string Code_Generation__Index = "Code_Generation__Index";
        public const string Code_Generation__Partial_Methods = "Code_Generation__Partial_Methods";
        public const string Code_Generation__Properties = "Code_Generation__Properties";
        public const string Code_Generation__Type_Constructors = "Code_Generation__Type_Constructors";
        public const string Code_Outlining = "Code_Outlining";
        public const string Code_Presentation_Options = "Code_Presentation_Options";
        public const string Code_Viewer = "Code_Viewer";
        public const string Coding_Assistance__Auto_Inserting_Parentheses_and_Quotes = "Coding_Assistance__Auto_Inserting_Parentheses_and_Quotes";
        public const string Coding_Assistance__Code_Completion = "Coding_Assistance__Code_Completion";
        public const string Coding_Assistance__Code_Completion__Double = "Coding_Assistance__Code_Completion__Double";
        public const string Coding_Assistance__Code_Completion__Generative = "Coding_Assistance__Code_Completion__Generative";
        public const string Coding_Assistance__Code_Completion__Smart = "Coding_Assistance__Code_Completion__Smart";
        public const string Coding_Assistance__Code_Completion__Symbol = "Coding_Assistance__Code_Completion__Symbol";
        public const string Coding_Assistance__Code_Completion__Type_Name = "Coding_Assistance__Code_Completion__Type_Name";
        public const string Coding_Assistance__Color_Assistance = "Coding_Assistance__Color_Assistance";
        public const string Coding_Assistance__Comment_Uncomment_Code = "Coding_Assistance__Comment_Uncomment_Code";
        public const string Coding_Assistance__Complete_Statement = "Coding_Assistance__Complete_Statement";
        public const string Coding_Assistance__Configuring_Delimiters_Matching = "Coding_Assistance__Configuring_Delimiters_Matching";
        public const string Coding_Assistance__Context_Actions = "Coding_Assistance__Context_Actions";
        public const string Coding_Assistance__Context_Actions__Applying_Context_Actions = "Coding_Assistance__Context_Actions__Applying_Context_Actions";
        public const string Coding_Assistance__Context_Actions__Configuring_Context_Actions = "Coding_Assistance__Context_Actions__Configuring_Context_Actions";
        public const string Coding_Assistance__Context_Actions__Examples_of_Context_Actions = "Coding_Assistance__Context_Actions__Examples_of_Context_Actions";
        public const string Coding_Assistance__Duplicate_Line_Block = "Coding_Assistance__Duplicate_Line_Block";
        public const string Coding_Assistance__Extend_Shrink_Selection = "Coding_Assistance__Extend_Shrink_Selection";
        public const string Coding_Assistance__Importing_Namespaces = "Coding_Assistance__Importing_Namespaces";
        public const string Coding_Assistance__Index = "Coding_Assistance__Index";
        public const string Coding_Assistance__INotifyPropertyChanged_Support = "Coding_Assistance__INotifyPropertyChanged_Support";
        public const string Coding_Assistance__Matching_Delimiters = "Coding_Assistance__Matching_Delimiters";
        public const string Coding_Assistance__Moving_Code_Elements = "Coding_Assistance__Moving_Code_Elements";
        public const string Coding_Assistance__Moving_Code_Elements__Examples = "Coding_Assistance__Moving_Code_Elements__Examples";
        public const string Coding_Assistance__Multiple_Entries_Clipboard = "Coding_Assistance__Multiple_Entries_Clipboard";
        public const string Coding_Assistance__Naming_Style = "Coding_Assistance__Naming_Style";
        public const string Coding_Assistance__Parameter_Info = "Coding_Assistance__Parameter_Info";
        public const string Coding_Assistance__Quick_Documentation = "Coding_Assistance__Quick_Documentation";
        public const string Coding_Assistance__Surrounding_with_Region = "Coding_Assistance__Surrounding_with_Region";
        public const string Coding_Assistance__Syntax_Highlighting = "Coding_Assistance__Syntax_Highlighting";
        public const string Configuring__Index = "Configuring__Index";
        public const string Configuring_Caches_Location = "Configuring_Caches_Location";
        public const string Configuring_Code_Completion = "Configuring_Code_Completion";
        public const string Configuring_Code_Viewer = "Configuring_Code_Viewer";
        public const string Configuring_Keyboard_Shortcuts = "Configuring_Keyboard_Shortcuts";
        public const string Configuring_Parameter_Information = "Configuring_Parameter_Information";
        public const string Configuring_Product_Options = "Configuring_Product_Options";
        public const string Configuring_Syntax_Highlighting = "Configuring_Syntax_Highlighting";
        public const string Configuring_Unit_Testing_Support = "Configuring_Unit_Testing_Support";
        public const string Coverage_of_Selected_Unit_Tests = "Coverage_of_Selected_Unit_Tests";
        public const string Coverage_of_Unit_Test_Session = "Coverage_of_Unit_Test_Session";
        public const string Coverage_of_Unit_Tests_in_the_Solution_Part = "Coverage_of_Unit_Tests_in_the_Solution_Part";
        public const string Coverage_of_Unit_Tests_in_the_Whole_Solution = "Coverage_of_Unit_Tests_in_the_Whole_Solution";
        public const string Design_time_Inspection = "Design_time_Inspection";
        public const string dotCover__Adjusting_Coverage_Filters = "dotCover__Adjusting_Coverage_Filters";
        public const string dotCover__Analyzing_Test_Coverage = "dotCover__Analyzing_Test_Coverage";
        public const string dotCover__Basic_Concepts = "dotCover__Basic_Concepts";
        public const string dotCover__Color_Scheme = "dotCover__Color_Scheme";
        public const string dotCover__Console_Runner_Commands = "dotCover__Console_Runner_Commands";
        public const string dotCover__Console_Runner_Configuration = "dotCover__Console_Runner_Configuration";
        public const string dotCover__Coverage_Analysis_on_Third_Party_Server = "dotCover__Coverage_Analysis_on_Third_Party_Server";
        public const string dotCover__Detecting_Hot_Spots = "dotCover__Detecting_Hot_Spots";
        public const string dotCover__Exporting_Coverage_Results = "dotCover__Exporting_Coverage_Results";
        public const string dotCover__Integration_with_Other_Tools = "dotCover__Integration_with_Other_Tools";
        public const string dotCover__Introducing_Console_Runner = "dotCover__Introducing_Console_Runner";
        public const string dotCover__Locating_Code_Items_in_Coverage_Tree = "dotCover__Locating_Code_Items_in_Coverage_Tree";
        public const string dotCover__Referecne__Index = "dotCover__Referecne__Index";
        public const string dotCover__Reference_Coverage_Filters = "dotCover__Reference_Coverage_Filters";
        public const string dotCover__Server_Test_Coverage = "dotCover__Server_Test_Coverage";
        public const string dotCover__Setting_up_Coverage_Analysis_JetBrains_TeamCity = "dotCover__Setting_up_Coverage_Analysis_JetBrains_TeamCity";
        public const string dotCover__Setting_up_Coverage_Filters = "dotCover__Setting_up_Coverage_Filters";
        public const string dotCover__Sharing_Coverage_Filters = "dotCover__Sharing_Coverage_Filters";
        public const string dotCover__Starting_Coverage_Assessment_for_Unit_Tests = "dotCover__Starting_Coverage_Assessment_for_Unit_Tests";
        public const string dotCover__Visual_Studio_Integration = "dotCover__Visual_Studio_Integration";
        public const string dotCover_Controller = "dotCover_Controller";
        public const string dotCover_Coverage_Configuration = "dotCover_Coverage_Configuration";
        public const string dotCover_Introduction = "dotCover_Introduction";
        public const string dotCover_Manual__dotNET_Process = "dotCover_Manual__dotNET_Process";
        public const string dotCover_Manual__IIS = "dotCover_Manual__IIS";
        public const string dotCover_Manual__Silverlight_Applications = "dotCover_Manual__Silverlight_Applications";
        public const string dotCover_Manual__Standalone_Applications = "dotCover_Manual__Standalone_Applications";
        public const string dotCover_Manual__WCF_Service_Libraries = "dotCover_Manual__WCF_Service_Libraries";
        public const string dotCover_Manual__Web_Development_Server = "dotCover_Manual__Web_Development_Server";
        public const string dotCover_Manual__Windows_Services = "dotCover_Manual__Windows_Services";
        public const string dotCover_Manual__Windows_Store_Application = "dotCover_Manual__Windows_Store_Application";
        public const string dotCover_Searching_Coverage_Tree = "dotCover_Searching_Coverage_Tree";
        public const string dotCover_Supported_Languages_and_Frameworks = "dotCover_Supported_Languages_and_Frameworks";
        public const string dotPeek_Introduction = "dotPeek_Introduction";
        public const string Excluding_Nodes_from_Coverage_Snapshot = "Excluding_Nodes_from_Coverage_Snapshot";
        public const string Exploring_Assemblies = "Exploring_Assemblies";
        public const string Exploring_Folders = "Exploring_Folders";
        public const string Exporting_Assembly_to_Project = "Exporting_Assembly_to_Project";
        public const string Inspecting_Code_in_Specific_Scope = "Inspecting_Code_in_Specific_Scope";
        public const string Introduction__Concepts = "Introduction__Concepts";
        public const string Introduction__Conventions = "Introduction__Conventions";
        public const string Introduction__Editions = "Introduction__Editions";
        public const string Introduction__Feature_Map = "Introduction__Feature_Map";
        public const string Introduction__Index = "Introduction__Index";
        public const string Introduction__Network_Activity = "Introduction__Network_Activity";
        public const string Introduction__Overview = "Introduction__Overview";
        public const string Introduction__ReSharper_vs_Visual_Studio = "Introduction__ReSharper_vs_Visual_Studio";
        public const string Introduction__Supported_Languages = "Introduction__Supported_Languages";
        public const string Introduction__Troubleshooting = "Introduction__Troubleshooting";
        public const string Introduction__Whats_New = "Introduction__Whats_New";
        public const string Managing_Assemblies = "Managing_Assemblies";
        public const string Managing_Color_Themes = "Managing_Color_Themes";
        public const string Managing_Extensions = "Managing_Extensions";
        public const string Matching_Coverage_Snapshot_with_Project_Structure = "Matching_Coverage_Snapshot_with_Project_Structure";
        public const string Navigation_and_Search__Bookmarks = "Navigation_and_Search__Bookmarks";
        public const string Navigation_and_Search__CamelHumps = "Navigation_and_Search__CamelHumps";
        public const string Navigation_and_Search__Collapsing_All_Nodes_in_Solution_Explorer = "Navigation_and_Search__Collapsing_All_Nodes_in_Solution_Explorer";
        public const string Navigation_and_Search__Context_Dependent_Navigation = "Navigation_and_Search__Context_Dependent_Navigation";
        public const string Navigation_and_Search__Finding_Usages = "Navigation_and_Search__Finding_Usages";
        public const string Navigation_and_Search__Finding_Usages__Finding_Dependencies_and_Referenced_Code = "Navigation_and_Search__Finding_Usages__Finding_Dependencies_and_Referenced_Code";
        public const string Navigation_and_Search__Finding_Usages__Finding_Usages_Advanced = "Navigation_and_Search__Finding_Usages__Finding_Usages_Advanced";
        public const string Navigation_and_Search__Finding_Usages__Finding_Usages_of_a_Symbol = "Navigation_and_Search__Finding_Usages__Finding_Usages_of_a_Symbol";
        public const string Navigation_and_Search__Finding_Usages__Highlighting_Usages_in_File = "Navigation_and_Search__Finding_Usages__Highlighting_Usages_in_File";
        public const string Navigation_and_Search__Finding_Usages__Optimizing_References = "Navigation_and_Search__Finding_Usages__Optimizing_References";
        public const string Navigation_and_Search__Finding_Usages__Viewing_Filtering_and_Grouping_Results = "Navigation_and_Search__Finding_Usages__Viewing_Filtering_and_Grouping_Results";
        public const string Navigation_and_Search__Go_to_Base = "Navigation_and_Search__Go_to_Base";
        public const string Navigation_and_Search__Go_to_Containing_Declaration = "Navigation_and_Search__Go_to_Containing_Declaration";
        public const string Navigation_and_Search__Go_to_Declaration = "Navigation_and_Search__Go_to_Declaration";
        public const string Navigation_and_Search__Go_to_File = "Navigation_and_Search__Go_to_File";
        public const string Navigation_and_Search__Go_to_File_Member = "Navigation_and_Search__Go_to_File_Member";
        public const string Navigation_and_Search__Go_to_Implementation = "Navigation_and_Search__Go_to_Implementation";
        public const string Navigation_and_Search__Go_to_Inheritor = "Navigation_and_Search__Go_to_Inheritor";
        public const string Navigation_and_Search__Go_to_Last_Edit_Location = "Navigation_and_Search__Go_to_Last_Edit_Location";
        public const string Navigation_and_Search__Go_to_Next_Previous_Member = "Navigation_and_Search__Go_to_Next_Previous_Member";
        public const string Navigation_and_Search__Go_to_Previous_Next_Location = "Navigation_and_Search__Go_to_Previous_Next_Location";
        public const string Navigation_and_Search__Go_to_Related_Files = "Navigation_and_Search__Go_to_Related_Files";
        public const string Navigation_and_Search__Go_to_Symbol = "Navigation_and_Search__Go_to_Symbol";
        public const string Navigation_and_Search__Go_to_Type = "Navigation_and_Search__Go_to_Type";
        public const string Navigation_and_Search__Go_to_Type_Declaration = "Navigation_and_Search__Go_to_Type_Declaration";
        public const string Navigation_and_Search__Go_to_Usage = "Navigation_and_Search__Go_to_Usage";
        public const string Navigation_and_Search__Highlighting_Current_Line = "Navigation_and_Search__Highlighting_Current_Line";
        public const string Navigation_and_Search__Index = "Navigation_and_Search__Index";
        public const string Navigation_and_Search__Locating_a_File_in_Solution_Explorer = "Navigation_and_Search__Locating_a_File_in_Solution_Explorer";
        public const string Navigation_and_Search__Navigate_from_Here = "Navigation_and_Search__Navigate_from_Here";
        public const string Navigation_and_Search__Navigate_from_Here__Assembly_Explorer = "Navigation_and_Search__Navigate_from_Here__Assembly_Explorer";
        public const string Navigation_and_Search__Navigate_from_Here__Conflicting_Declarations = "Navigation_and_Search__Navigate_from_Here__Conflicting_Declarations";
        public const string Navigation_and_Search__Navigate_from_Here__Control_Flow_Target = "Navigation_and_Search__Navigate_from_Here__Control_Flow_Target";
        public const string Navigation_and_Search__Navigate_from_Here__Decompiled_Code = "Navigation_and_Search__Navigate_from_Here__Decompiled_Code";
        public const string Navigation_and_Search__Navigate_from_Here__Extension_Methods = "Navigation_and_Search__Navigate_from_Here__Extension_Methods";
        public const string Navigation_and_Search__Navigate_from_Here__External_Source_File = "Navigation_and_Search__Navigate_from_Here__External_Source_File";
        public const string Navigation_and_Search__Navigate_from_Here__Function_Exits = "Navigation_and_Search__Navigate_from_Here__Function_Exits";
        public const string Navigation_and_Search__Navigate_from_Here__Generic_Substitutions = "Navigation_and_Search__Navigate_from_Here__Generic_Substitutions";
        public const string Navigation_and_Search__Navigate_from_Here__Implementing_Members = "Navigation_and_Search__Navigate_from_Here__Implementing_Members";
        public const string Navigation_and_Search__Navigate_from_Here__Member_Overloads = "Navigation_and_Search__Navigate_from_Here__Member_Overloads";
        public const string Navigation_and_Search__Navigate_from_Here__Metadata_Sources = "Navigation_and_Search__Navigate_from_Here__Metadata_Sources";
        public const string Navigation_and_Search__Navigate_from_Here__Object_Browser = "Navigation_and_Search__Navigate_from_Here__Object_Browser";
        public const string Navigation_and_Search__Navigate_from_Here__Overriding_Members = "Navigation_and_Search__Navigate_from_Here__Overriding_Members";
        public const string Navigation_and_Search__Navigate_from_Here__Parameter_Declaration = "Navigation_and_Search__Navigate_from_Here__Parameter_Declaration";
        public const string Navigation_and_Search__Navigate_from_Here__Test_Explorer = "Navigation_and_Search__Navigate_from_Here__Test_Explorer";
        public const string Navigation_and_Search__Navigate_from_Here__Todo_Explorer = "Navigation_and_Search__Navigate_from_Here__Todo_Explorer";
        public const string Navigation_and_Search__Navigating_Between_To_do_Items = "Navigation_and_Search__Navigating_Between_To_do_Items";
        public const string Navigation_and_Search__Navigating_to_Exception = "Navigation_and_Search__Navigating_to_Exception";
        public const string Navigation_and_Search__Navigating_to_External_Sources = "Navigation_and_Search__Navigating_to_External_Sources";
        public const string Navigation_and_Search__Navigating_to_Overriding_Implementing_or_Hiding_Methods = "Navigation_and_Search__Navigating_to_Overriding_Implementing_or_Hiding_Methods";
        public const string Navigation_and_Search__Navigating_to_Recent_Edits = "Navigation_and_Search__Navigating_to_Recent_Edits";
        public const string Navigation_and_Search__Navigating_to_Recent_Files = "Navigation_and_Search__Navigating_to_Recent_Files";
        public const string Navigation_and_Search__Navigating_to_Recent_Locations = "Navigation_and_Search__Navigating_to_Recent_Locations";
        public const string Navigation_and_Search__Navigation_from_Symbols = "Navigation_and_Search__Navigation_from_Symbols";
        public const string Navigation_and_Search__Peek_Definition = "Navigation_and_Search__Peek_Definition";
        public const string Navigation_and_Search__Search = "Navigation_and_Search__Search";
        public const string Navigation_and_Search__SSR__Creating_and_Managing_Patterns = "Navigation_and_Search__SSR__Creating_and_Managing_Patterns";
        public const string Navigation_and_Search__SSR__Replacing_Code_with_Pattern = "Navigation_and_Search__SSR__Replacing_Code_with_Pattern";
        public const string Navigation_and_Search__SSR__Searching_for_Code_with_Pattern = "Navigation_and_Search__SSR__Searching_for_Code_with_Pattern";
        public const string Navigation_and_Search__Structural_Search_and_Replace = "Navigation_and_Search__Structural_Search_and_Replace";
        public const string Navigation_and_Search__Viewing_File_Structure = "Navigation_and_Search__Viewing_File_Structure";
        public const string Navigation_and_Search__Viewing_Type_Hierarchy = "Navigation_and_Search__Viewing_Type_Hierarchy";
        public const string Navigation_to_Covering_Tests = "Navigation_to_Covering_Tests";
        public const string Opening_Assembly_Files = "Opening_Assembly_Files";
        public const string Project_Level_Assistance = "Project_Level_Assistance";
        public const string Refactorings__Adjust_Namespaces = "Refactorings__Adjust_Namespaces";
        public const string Refactorings__Change_Signature = "Refactorings__Change_Signature";
        public const string Refactorings__Convert_Abstract_Class_to_Interface = "Refactorings__Convert_Abstract_Class_to_Interface";
        public const string Refactorings__Convert_Anonymous_to_Named_Type = "Refactorings__Convert_Anonymous_to_Named_Type";
        public const string Refactorings__Convert_Extension_Method_to_Plain_Static = "Refactorings__Convert_Extension_Method_to_Plain_Static";
        public const string Refactorings__Convert_Indexer_to_Method = "Refactorings__Convert_Indexer_to_Method";
        public const string Refactorings__Convert_Interface_to_Abstract_Class = "Refactorings__Convert_Interface_to_Abstract_Class";
        public const string Refactorings__Convert_Iterator_to_Method = "Refactorings__Convert_Iterator_to_Method";
        public const string Refactorings__Convert_Method_to_Indexer = "Refactorings__Convert_Method_to_Indexer";
        public const string Refactorings__Convert_Method_to_Property = "Refactorings__Convert_Method_to_Property";
        public const string Refactorings__Convert_Property_to_Auto_Property = "Refactorings__Convert_Property_to_Auto_Property";
        public const string Refactorings__Convert_Property_to_Method = "Refactorings__Convert_Property_to_Method";
        public const string Refactorings__Convert_Static_to_Extension_Method = "Refactorings__Convert_Static_to_Extension_Method";
        public const string Refactorings__Copy_Type = "Refactorings__Copy_Type";
        public const string Refactorings__Encapsulate_Field = "Refactorings__Encapsulate_Field";
        public const string Refactorings__Extract_Class = "Refactorings__Extract_Class";
        public const string Refactorings__Extract_Class_from_Parameters = "Refactorings__Extract_Class_from_Parameters";
        public const string Refactorings__Extract_Interface = "Refactorings__Extract_Interface";
        public const string Refactorings__Extract_Method = "Refactorings__Extract_Method";
        public const string Refactorings__Extract_Superclass = "Refactorings__Extract_Superclass";
        public const string Refactorings__Index = "Refactorings__Index";
        public const string Refactorings__Inline_Class = "Refactorings__Inline_Class";
        public const string Refactorings__Inline_Field = "Refactorings__Inline_Field";
        public const string Refactorings__Inline_Method = "Refactorings__Inline_Method";
        public const string Refactorings__Inline_Parameter = "Refactorings__Inline_Parameter";
        public const string Refactorings__Inline_Variable = "Refactorings__Inline_Variable";
        public const string Refactorings__Inplace_Refactorings = "Refactorings__Inplace_Refactorings";
        public const string Refactorings__Introduce_Field = "Refactorings__Introduce_Field";
        public const string Refactorings__Introduce_Parameter = "Refactorings__Introduce_Parameter";
        public const string Refactorings__Introduce_Variable = "Refactorings__Introduce_Variable";
        public const string Refactorings__Make_Method_Non_Static = "Refactorings__Make_Method_Non_Static";
        public const string Refactorings__Make_Method_Static = "Refactorings__Make_Method_Static";
        public const string Refactorings__Move = "Refactorings__Move";
        public const string Refactorings__Move__Instance_Method_to_Another_Type = "Refactorings__Move__Instance_Method_to_Another_Type";
        public const string Refactorings__Move__Type_to_Another_File = "Refactorings__Move__Type_to_Another_File";
        public const string Refactorings__Move__Type_to_Another_Namespace = "Refactorings__Move__Type_to_Another_Namespace";
        public const string Refactorings__Move__Type_to_Another_Type = "Refactorings__Move__Type_to_Another_Type";
        public const string Refactorings__Move__Type_to_Folder = "Refactorings__Move__Type_to_Folder";
        public const string Refactorings__Move__Type_to_Outer_Scope = "Refactorings__Move__Type_to_Outer_Scope";
        public const string Refactorings__Move_Types_into_Matching_Files = "Refactorings__Move_Types_into_Matching_Files";
        public const string Refactorings__Pull_Members_Up = "Refactorings__Pull_Members_Up";
        public const string Refactorings__Push_Members_Down = "Refactorings__Push_Members_Down";
        public const string Refactorings__Push_Pull_Parameters = "Refactorings__Push_Pull_Parameters";
        public const string Refactorings__Remove_Unused_References = "Refactorings__Remove_Unused_References";
        public const string Refactorings__Rename = "Refactorings__Rename";
        public const string Refactorings__Replace_Constructor_with_Factory_Method = "Refactorings__Replace_Constructor_with_Factory_Method";
        public const string Refactorings__Resolving_Conflicts_in_Refactorings = "Refactorings__Resolving_Conflicts_in_Refactorings";
        public const string Refactorings__Safe_Delete = "Refactorings__Safe_Delete";
        public const string Refactorings__Transform_Out_Parameters = "Refactorings__Transform_Out_Parameters";
        public const string Refactorings__Use_Base_Type_Where_Possible = "Refactorings__Use_Base_Type_Where_Possible";
        public const string Reference__Action_Bar = "Reference__Action_Bar";
        public const string Reference__Add_Coverage_Filter = "Reference__Add_Coverage_Filter";
        public const string Reference__Add_Edit_Highlighting_Pattern = "Reference__Add_Edit_Highlighting_Pattern";
        public const string Reference__Architecture_View = "Reference__Architecture_View";
        public const string Reference__Assembly_Explorer = "Reference__Assembly_Explorer";
        public const string Reference__Choose_Macro = "Reference__Choose_Macro";
        public const string Reference__Choose_Template = "Reference__Choose_Template";
        public const string Reference__Code_Annotation_Attributes = "Reference__Code_Annotation_Attributes";
        public const string Reference__Code_Cleanup = "Reference__Code_Cleanup";
        public const string Reference__Context_Actions = "Reference__Context_Actions";
        public const string Reference__Cover_Application = "Reference__Cover_Application";
        public const string Reference__Coverage_Results_Browser = "Reference__Coverage_Results_Browser";
        public const string Reference__Create_Pattern = "Reference__Create_Pattern";
        public const string Reference__Dialog_Boxes = "Reference__Dialog_Boxes";
        public const string Reference__Export_Data = "Reference__Export_Data";
        public const string Reference__Extension_Manager = "Reference__Extension_Manager";
        public const string Reference__Go_to_Line = "Reference__Go_to_Line";
        public const string Reference__Hot_Spot_Session = "Reference__Hot_Spot_Session";
        public const string Reference__Index = "Reference__Index";
        public const string Reference__Inspection_Options = "Reference__Inspection_Options";
        public const string Reference__Keyboard_Shortcuts = "Reference__Keyboard_Shortcuts";
        public const string Reference__License_Information = "Reference__License_Information";
        public const string Reference__Navigation_Log = "Reference__Navigation_Log";
        public const string Reference__Obtain_Permanent_License = "Reference__Obtain_Permanent_License";
        public const string Reference__Open_from_GAC = "Reference__Open_from_GAC";
        public const string Reference__Options = "Reference__Options";
        public const string Reference__Options__Code_Inspection = "Reference__Options__Code_Inspection";
        public const string Reference__Options__Code_Inspection__Code_Annotations = "Reference__Options__Code_Inspection__Code_Annotations";
        public const string Reference__Options__Code_Inspection__Custom_Patterns = "Reference__Options__Code_Inspection__Custom_Patterns";
        public const string Reference__Options__Code_Inspection__Generated_Code = "Reference__Options__Code_Inspection__Generated_Code";
        public const string Reference__Options__Code_Inspection__Inspection_Severity = "Reference__Options__Code_Inspection__Inspection_Severity";
        public const string Reference__Options__Code_Inspection__Settings = "Reference__Options__Code_Inspection__Settings";
        public const string Reference__Options__Environment = "Reference__Options__Environment";
        public const string Reference__Options__Environment__Completing_Characters = "Reference__Options__Environment__Completing_Characters";
        public const string Reference__Options__Environment__Editor = "Reference__Options__Environment__Editor";
        public const string Reference__Options__Environment__Editor__Editor_Appearance = "Reference__Options__Environment__Editor__Editor_Appearance";
        public const string Reference__Options__Environment__Editor__Editor_Behavior = "Reference__Options__Environment__Editor__Editor_Behavior";
        public const string Reference__Options__Environment__Extension_Manager = "Reference__Options__Environment__Extension_Manager";
        public const string Reference__Options__Environment__General = "Reference__Options__Environment__General";
        public const string Reference__Options__Environment__IntelliSense = "Reference__Options__Environment__IntelliSense";
        public const string Reference__Options__Environment__IntelliSense__Autopopup = "Reference__Options__Environment__IntelliSense__Autopopup";
        public const string Reference__Options__Environment__IntelliSense__Completion_Appearance = "Reference__Options__Environment__IntelliSense__Completion_Appearance";
        public const string Reference__Options__Environment__IntelliSense__Completion_Behavior = "Reference__Options__Environment__IntelliSense__Completion_Behavior";
        public const string Reference__Options__Environment__IntelliSense__General = "Reference__Options__Environment__IntelliSense__General";
        public const string Reference__Options__Environment__IntelliSense__Parameter_Info = "Reference__Options__Environment__IntelliSense__Parameter_Info";
        public const string Reference__Options__Environment__Languages = "Reference__Options__Environment__Languages";
        public const string Reference__Options__Environment__Plugins = "Reference__Options__Environment__Plugins";
        public const string Reference__Options__Environment__ReSharper_Feedback = "Reference__Options__Environment__ReSharper_Feedback";
        public const string Reference__Options__Environment__Search_and_Navigation = "Reference__Options__Environment__Search_and_Navigation";
        public const string Reference__Options__Environment__Updates = "Reference__Options__Environment__Updates";
        public const string Reference__Options__Environment__Visual_Studio_Integration = "Reference__Options__Environment__Visual_Studio_Integration";
        public const string Reference__Options__Environment__Web_Proxy_Settings = "Reference__Options__Environment__Web_Proxy_Settings";
        public const string Reference__Options__General_Formatter_Style = "Reference__Options__General_Formatter_Style";
        public const string Reference__Options__Languages = "Reference__Options__Languages";
        public const string Reference__Options__Languages__ASP_NET = "Reference__Options__Languages__ASP_NET";
        public const string Reference__Options__Languages__ASP_NET__Context_Actions = "Reference__Options__Languages__ASP_NET__Context_Actions";
        public const string Reference__Options__Languages__ASP_NET__Editor = "Reference__Options__Languages__ASP_NET__Editor";
        public const string Reference__Options__Languages__ASP_NET__Other = "Reference__Options__Languages__ASP_NET__Other";
        public const string Reference__Options__Languages__ASP_NET__Web_Naming_Style = "Reference__Options__Languages__ASP_NET__Web_Naming_Style";
        public const string Reference__Options__Languages__Build_Scripts = "Reference__Options__Languages__Build_Scripts";
        public const string Reference__Options__Languages__Build_Scripts__Context_Actions = "Reference__Options__Languages__Build_Scripts__Context_Actions";
        public const string Reference__Options__Languages__Common__Code_Style_Sharing = "Reference__Options__Languages__Common__Code_Style_Sharing";
        public const string Reference__Options__Languages__Common__Context_Actions = "Reference__Options__Languages__Common__Context_Actions";
        public const string Reference__Options__Languages__Common__File_Header_Text = "Reference__Options__Languages__Common__File_Header_Text";
        public const string Reference__Options__Languages__Common__Generated_Members = "Reference__Options__Languages__Common__Generated_Members";
        public const string Reference__Options__Languages__CSharp = "Reference__Options__Languages__CSharp";
        public const string Reference__Options__Languages__CSharp__Context_Actions = "Reference__Options__Languages__CSharp__Context_Actions";
        public const string Reference__Options__Languages__CSharp__CSharp_Naming_Style = "Reference__Options__Languages__CSharp__CSharp_Naming_Style";
        public const string Reference__Options__Languages__CSharp__Formatting_Style = "Reference__Options__Languages__CSharp__Formatting_Style";
        public const string Reference__Options__Languages__CSharp__Formatting_Style__Blank_Lines = "Reference__Options__Languages__CSharp__Formatting_Style__Blank_Lines";
        public const string Reference__Options__Languages__CSharp__Formatting_Style__Braces_Layout = "Reference__Options__Languages__CSharp__Formatting_Style__Braces_Layout";
        public const string Reference__Options__Languages__CSharp__Formatting_Style__Line_Breaks_and_Wrapping = "Reference__Options__Languages__CSharp__Formatting_Style__Line_Breaks_and_Wrapping" +
            "";
        public const string Reference__Options__Languages__CSharp__Formatting_Style__Other = "Reference__Options__Languages__CSharp__Formatting_Style__Other";
        public const string Reference__Options__Languages__CSharp__Formatting_Style__Spaces = "Reference__Options__Languages__CSharp__Formatting_Style__Spaces";
        public const string Reference__Options__Languages__CSharp__Localization = "Reference__Options__Languages__CSharp__Localization";
        public const string Reference__Options__Languages__CSharp__Namespace_Imports = "Reference__Options__Languages__CSharp__Namespace_Imports";
        public const string Reference__Options__Languages__CSharp__Type_Members_Layout = "Reference__Options__Languages__CSharp__Type_Members_Layout";
        public const string Reference__Options__Languages__CSS = "Reference__Options__Languages__CSS";
        public const string Reference__Options__Languages__CSS__Context_Actions = "Reference__Options__Languages__CSS__Context_Actions";
        public const string Reference__Options__Languages__CSS__Formatting_Style = "Reference__Options__Languages__CSS__Formatting_Style";
        public const string Reference__Options__Languages__CSS__Formatting_Style__Code_Layout = "Reference__Options__Languages__CSS__Formatting_Style__Code_Layout";
        public const string Reference__Options__Languages__CSS__Formatting_Style__Line_Breaks = "Reference__Options__Languages__CSS__Formatting_Style__Line_Breaks";
        public const string Reference__Options__Languages__CSS__Formatting_Style__Spaces = "Reference__Options__Languages__CSS__Formatting_Style__Spaces";
        public const string Reference__Options__Languages__CSS__Inspections = "Reference__Options__Languages__CSS__Inspections";
        public const string Reference__Options__Languages__HTML = "Reference__Options__Languages__HTML";
        public const string Reference__Options__Languages__HTML__Context_Actions = "Reference__Options__Languages__HTML__Context_Actions";
        public const string Reference__Options__Languages__HTML__Editor = "Reference__Options__Languages__HTML__Editor";
        public const string Reference__Options__Languages__HTML__Formatting_Style = "Reference__Options__Languages__HTML__Formatting_Style";
        public const string Reference__Options__Languages__HTML__Other = "Reference__Options__Languages__HTML__Other";
        public const string Reference__Options__Languages__JavaScript = "Reference__Options__Languages__JavaScript";
        public const string Reference__Options__Languages__JavaScript__Context_Actions = "Reference__Options__Languages__JavaScript__Context_Actions";
        public const string Reference__Options__Languages__JavaScript__Formatting_Style = "Reference__Options__Languages__JavaScript__Formatting_Style";
        public const string Reference__Options__Languages__JavaScript__Formatting_Style__Braces_Layout = "Reference__Options__Languages__JavaScript__Formatting_Style__Braces_Layout";
        public const string Reference__Options__Languages__JavaScript__Formatting_Style__Line_Breaks = "Reference__Options__Languages__JavaScript__Formatting_Style__Line_Breaks";
        public const string Reference__Options__Languages__JavaScript__Formatting_Style__Other = "Reference__Options__Languages__JavaScript__Formatting_Style__Other";
        public const string Reference__Options__Languages__JavaScript__Formatting_Style__Spaces = "Reference__Options__Languages__JavaScript__Formatting_Style__Spaces";
        public const string Reference__Options__Languages__JavaScript__Inspections_Analysis = "Reference__Options__Languages__JavaScript__Inspections_Analysis";
        public const string Reference__Options__Languages__JavaScript__Naming_Style = "Reference__Options__Languages__JavaScript__Naming_Style";
        public const string Reference__Options__Languages__Razor = "Reference__Options__Languages__Razor";
        public const string Reference__Options__Languages__Razor__Context_Actions = "Reference__Options__Languages__Razor__Context_Actions";
        public const string Reference__Options__Languages__Razor__Editor = "Reference__Options__Languages__Razor__Editor";
        public const string Reference__Options__Languages__Razor__Namespace_Imports = "Reference__Options__Languages__Razor__Namespace_Imports";
        public const string Reference__Options__Languages__TypeScript = "Reference__Options__Languages__TypeScript";
        public const string Reference__Options__Languages__TypeScript__Formatting_Braces_Layout = "Reference__Options__Languages__TypeScript__Formatting_Braces_Layout";
        public const string Reference__Options__Languages__TypeScript__Formatting_Line_Breaks = "Reference__Options__Languages__TypeScript__Formatting_Line_Breaks";
        public const string Reference__Options__Languages__TypeScript__Formatting_Other = "Reference__Options__Languages__TypeScript__Formatting_Other";
        public const string Reference__Options__Languages__TypeScript__Formatting_Spaces = "Reference__Options__Languages__TypeScript__Formatting_Spaces";
        public const string Reference__Options__Languages__TypeScript__Formatting_Style = "Reference__Options__Languages__TypeScript__Formatting_Style";
        public const string Reference__Options__Languages__TypeScript_Naming_Style = "Reference__Options__Languages__TypeScript_Naming_Style";
        public const string Reference__Options__Languages__Visual_Basic__NET = "Reference__Options__Languages__Visual_Basic__NET";
        public const string Reference__Options__Languages__Visual_Basic__NET__Context_Actions = "Reference__Options__Languages__Visual_Basic__NET__Context_Actions";
        public const string Reference__Options__Languages__Visual_Basic__NET__Formatting_Style = "Reference__Options__Languages__Visual_Basic__NET__Formatting_Style";
        public const string Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Blank_Lines = "Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Blank_Lines";
        public const string Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Line_Breaks_and_Wrapping = "Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Line_Breaks_a" +
            "nd_Wrapping";
        public const string Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Other = "Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Other";
        public const string Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Spaces = "Reference__Options__Languages__Visual_Basic__NET__Formatting_Style__Spaces";
        public const string Reference__Options__Languages__Visual_Basic__NET__Inspections = "Reference__Options__Languages__Visual_Basic__NET__Inspections";
        public const string Reference__Options__Languages__Visual_Basic__NET__Namespace_Imports = "Reference__Options__Languages__Visual_Basic__NET__Namespace_Imports";
        public const string Reference__Options__Languages__Visual_Basic__NET__VB_Naming_Style = "Reference__Options__Languages__Visual_Basic__NET__VB_Naming_Style";
        public const string Reference__Options__Languages__XAML = "Reference__Options__Languages__XAML";
        public const string Reference__Options__Languages__XAML__Context_Actions = "Reference__Options__Languages__XAML__Context_Actions";
        public const string Reference__Options__Languages__XAML__Editor = "Reference__Options__Languages__XAML__Editor";
        public const string Reference__Options__Languages__XAML__Xaml_Naming_Style = "Reference__Options__Languages__XAML__Xaml_Naming_Style";
        public const string Reference__Options__Languages__XML = "Reference__Options__Languages__XML";
        public const string Reference__Options__Languages__XML__Context_Actions = "Reference__Options__Languages__XML__Context_Actions";
        public const string Reference__Options__Languages__XML__Editor = "Reference__Options__Languages__XML__Editor";
        public const string Reference__Options__Languages__XML__Formatting_Style = "Reference__Options__Languages__XML__Formatting_Style";
        public const string Reference__Options__Tools = "Reference__Options__Tools";
        public const string Reference__Options__Tools__Code_Cleanup = "Reference__Options__Tools__Code_Cleanup";
        public const string Reference__Options__Tools__External_Sources = "Reference__Options__Tools__External_Sources";
        public const string Reference__Options__Tools__Localization = "Reference__Options__Tools__Localization";
        public const string Reference__Options__Tools__To_Do_Items = "Reference__Options__Tools__To_Do_Items";
        public const string Reference__Options__Tools__Unit_Testing = "Reference__Options__Tools__Unit_Testing";
        public const string Reference__Options__Tools__Unit_Testing__MSTest = "Reference__Options__Tools__Unit_Testing__MSTest";
        public const string Reference__Options__Tools__Unit_Testing__NUnit = "Reference__Options__Tools__Unit_Testing__NUnit";
        public const string Reference__Options__Tools__Unit_Testing__QUnit = "Reference__Options__Tools__Unit_Testing__QUnit";
        public const string Reference__Options__XML_Doc_Comments = "Reference__Options__XML_Doc_Comments";
        public const string Reference__Options__XML_Doc_Comments_Formatting_Style = "Reference__Options__XML_Doc_Comments_Formatting_Style";
        public const string Reference__Options_Decompiler = "Reference__Options_Decompiler";
        public const string Reference__Properties = "Reference__Properties";
        public const string Reference__Quick_Find = "Reference__Quick_Find";
        public const string Reference__ReSharper_Tips = "Reference__ReSharper_Tips";
        public const string Reference__Search_Properties = "Reference__Search_Properties";
        public const string Reference__Search_with_Pattern = "Reference__Search_with_Pattern";
        public const string Reference__Settings_Layers = "Reference__Settings_Layers";
        public const string Reference__Symbol_Icons = "Reference__Symbol_Icons";
        public const string Reference__Template_Editor = "Reference__Template_Editor";
        public const string Reference__Templates__Predefined = "Reference__Templates__Predefined";
        public const string Reference__Templates_Explorer = "Reference__Templates_Explorer";
        public const string Reference__Templates_Explorer__File_Templates = "Reference__Templates_Explorer__File_Templates";
        public const string Reference__Templates_Explorer__File_Templates__Predefined = "Reference__Templates_Explorer__File_Templates__Predefined";
        public const string Reference__Templates_Explorer__Live_Templates = "Reference__Templates_Explorer__Live_Templates";
        public const string Reference__Templates_Explorer__Live_Templates__Predefined = "Reference__Templates_Explorer__Live_Templates__Predefined";
        public const string Reference__Templates_Explorer__Live_Templates__Predefined__Razor = "Reference__Templates_Explorer__Live_Templates__Predefined__Razor";
        public const string Reference__Templates_Explorer__Surround_Templates = "Reference__Templates_Explorer__Surround_Templates";
        public const string Reference__Templates_Explorer__Surround_With_Templates__Predefined = "Reference__Templates_Explorer__Surround_With_Templates__Predefined";
        public const string Reference__Text_Editor_Features = "Reference__Text_Editor_Features";
        public const string Reference__VS_Options_Page = "Reference__VS_Options_Page";
        public const string Reference__Windows = "Reference__Windows";
        public const string Reference__Windows__Analyze_References = "Reference__Windows__Analyze_References";
        public const string Reference__Windows__Errors_in_Solution = "Reference__Windows__Errors_in_Solution";
        public const string Reference__Windows__File_Structure_Window = "Reference__Windows__File_Structure_Window";
        public const string Reference__Windows__Find_Results_Window = "Reference__Windows__Find_Results_Window";
        public const string Reference__Windows__Inspection_Results = "Reference__Windows__Inspection_Results";
        public const string Reference__Windows__Pattern_Catalogue = "Reference__Windows__Pattern_Catalogue";
        public const string Reference__Windows__Stack_Trace_Explorer = "Reference__Windows__Stack_Trace_Explorer";
        public const string Reference__Windows__To_do_Explorer = "Reference__Windows__To_do_Explorer";
        public const string Reference__Windows__Type_Hierarchy_Window = "Reference__Windows__Type_Hierarchy_Window";
        public const string Reference__Windows__Unit_Test_Explorer = "Reference__Windows__Unit_Test_Explorer";
        public const string Reference__Windows__Unit_Test_Sessions = "Reference__Windows__Unit_Test_Sessions";
        public const string ReSharper_by_Language__CSharp = "ReSharper_by_Language__CSharp";
        public const string ReSharper_by_Language__CSS = "ReSharper_by_Language__CSS";
        public const string ReSharper_by_Language__CSS__Changing_Color_Values_in_Style_Sheets = "ReSharper_by_Language__CSS__Changing_Color_Values_in_Style_Sheets";
        public const string ReSharper_by_Language__CSS__Code_Analysis_and_Coding_Assistance = "ReSharper_by_Language__CSS__Code_Analysis_and_Coding_Assistance";
        public const string ReSharper_by_Language__CSS__Code_Cleanup = "ReSharper_by_Language__CSS__Code_Cleanup";
        public const string ReSharper_by_Language__CSS__Navigation = "ReSharper_by_Language__CSS__Navigation";
        public const string ReSharper_by_Language__CSS__Refactorings = "ReSharper_by_Language__CSS__Refactorings";
        public const string ReSharper_by_Language__CSS__Templates = "ReSharper_by_Language__CSS__Templates";
        public const string ReSharper_by_Language__HTML = "ReSharper_by_Language__HTML";
        public const string ReSharper_by_Language__Index = "ReSharper_by_Language__Index";
        public const string ReSharper_by_Language__JavaScript = "ReSharper_by_Language__JavaScript";
        public const string ReSharper_by_Language__JavaScript__Code_Analysis_and_Coding_Assistance = "ReSharper_by_Language__JavaScript__Code_Analysis_and_Coding_Assistance";
        public const string ReSharper_by_Language__JavaScript__Code_Cleanup = "ReSharper_by_Language__JavaScript__Code_Cleanup";
        public const string ReSharper_by_Language__JavaScript__Navigation = "ReSharper_by_Language__JavaScript__Navigation";
        public const string ReSharper_by_Language__JavaScript__Refactorings = "ReSharper_by_Language__JavaScript__Refactorings";
        public const string ReSharper_by_Language__JavaScript__Templates = "ReSharper_by_Language__JavaScript__Templates";
        public const string ReSharper_by_Language__JavaScript__Unit_Testing = "ReSharper_by_Language__JavaScript__Unit_Testing";
        public const string ReSharper_by_Language__MSBuild = "ReSharper_by_Language__MSBuild";
        public const string ReSharper_by_Language__TypeScript = "ReSharper_by_Language__TypeScript";
        public const string ReSharper_by_Language__Visual_Basic = "ReSharper_by_Language__Visual_Basic";
        public const string ReSharper_by_Language__Visual_Basic__Code_Analysis_and_Coding_Assistance = "ReSharper_by_Language__Visual_Basic__Code_Analysis_and_Coding_Assistance";
        public const string ReSharper_by_Language__Visual_Basic__Code_Cleanup = "ReSharper_by_Language__Visual_Basic__Code_Cleanup";
        public const string ReSharper_by_Language__Visual_Basic__Code_Generation_and_Templates = "ReSharper_by_Language__Visual_Basic__Code_Generation_and_Templates";
        public const string ReSharper_by_Language__Visual_Basic__Navigation_and_Search = "ReSharper_by_Language__Visual_Basic__Navigation_and_Search";
        public const string ReSharper_by_Language__Visual_Basic__Refactorings = "ReSharper_by_Language__Visual_Basic__Refactorings";
        public const string ReSharper_by_Language__XAML = "ReSharper_by_Language__XAML";
        public const string ReSharper_by_Language__XAML__Code_Analysis_and_Coding_Assistance = "ReSharper_by_Language__XAML__Code_Analysis_and_Coding_Assistance";
        public const string ReSharper_by_Language__XAML__Navigation_and_Search = "ReSharper_by_Language__XAML__Navigation_and_Search";
        public const string ReSharper_by_Language__XAML__Refactorings = "ReSharper_by_Language__XAML__Refactorings";
        public const string ReSharper_by_Language__XML = "ReSharper_by_Language__XML";
        public const string ReSharper_by_Language__XML__Code_Cleanup = "ReSharper_by_Language__XML__Code_Cleanup";
        public const string Resolving_Keyboard_Shortcut_Conflicts = "Resolving_Keyboard_Shortcut_Conflicts";
        public const string Resources__Code_Completion = "Resources__Code_Completion";
        public const string Resources__Editing_Resource_Value = "Resources__Editing_Resource_Value";
        public const string Resources__Index = "Resources__Index";
        public const string Resources__Navigation = "Resources__Navigation";
        public const string Resources__Navigation__Find_Usages = "Resources__Navigation__Find_Usages";
        public const string Resources__Navigation__Navigation_between_Code_and_Resx_Files = "Resources__Navigation__Navigation_between_Code_and_Resx_Files";
        public const string Resources__Navigation__Navigation_between_Cultures = "Resources__Navigation__Navigation_between_Cultures";
        public const string Resources__Navigation__Navigation_within_Rex_Files = "Resources__Navigation__Navigation_within_Rex_Files";
        public const string Resources__Quick_Documentation = "Resources__Quick_Documentation";
        public const string Resources__Quick_Fixes = "Resources__Quick_Fixes";
        public const string Resources__Refactorings = "Resources__Refactorings";
        public const string Resources__Refactorings__Inline_Resource = "Resources__Refactorings__Inline_Resource";
        public const string Resources__Refactorings__Move_Resource = "Resources__Refactorings__Move_Resource";
        public const string Resources__Refactorings__Move_to_Resource = "Resources__Refactorings__Move_to_Resource";
        public const string Resources__Refactorings__Rename_Resource = "Resources__Refactorings__Rename_Resource";
        public const string Resources__Refactorings__Safe_Delete = "Resources__Refactorings__Safe_Delete";
        public const string Running_Applications_under_dotCover_Control = "Running_Applications_under_dotCover_Control";
        public const string Saving_and_Loading_Coverage_Snapshot = "Saving_and_Loading_Coverage_Snapshot";
        public const string Sharing_Configuration_Options = "Sharing_Configuration_Options";
        public const string Sharing_Unit_Test_Runner = "Sharing_Unit_Test_Runner";
        public const string Specifying_License_Information = "Specifying_License_Information";
        public const string Starting_Manual_Test_Session = "Starting_Manual_Test_Session";
        public const string Starting_Manual_Test_Session_for_External_Applications = "Starting_Manual_Test_Session_for_External_Applications";
        public const string Templates__Applying_Templates = "Templates__Applying_Templates";
        public const string Templates__Applying_Templates__Creating_Files_from_Templates = "Templates__Applying_Templates__Creating_Files_from_Templates";
        public const string Templates__Applying_Templates__Creating_Source_Code_Using_Live_Templates = "Templates__Applying_Templates__Creating_Source_Code_Using_Live_Templates";
        public const string Templates__Applying_Templates__Inserting_Imported_Code_Snippets = "Templates__Applying_Templates__Inserting_Imported_Code_Snippets";
        public const string Templates__Applying_Templates__Surrounding_Code_Fragments_with_Templates = "Templates__Applying_Templates__Surrounding_Code_Fragments_with_Templates";
        public const string Templates__Creating_and_Editing_Templates = "Templates__Creating_and_Editing_Templates";
        public const string Templates__Creating_and_Editing_Templates__Creating_a_Live_Template_from_Source_Code = "Templates__Creating_and_Editing_Templates__Creating_a_Live_Template_from_Source_C" +
            "ode";
        public const string Templates__Creating_and_Editing_Templates__Creating_a_Template = "Templates__Creating_and_Editing_Templates__Creating_a_Template";
        public const string Templates__Creating_and_Editing_Templates__Declaring_Variables = "Templates__Creating_and_Editing_Templates__Declaring_Variables";
        public const string Templates__Creating_and_Editing_Templates__Editing_a_Template = "Templates__Creating_and_Editing_Templates__Editing_a_Template";
        public const string Templates__Creating_and_Editing_Templates__Multifile = "Templates__Creating_and_Editing_Templates__Multifile";
        public const string Templates__Index = "Templates__Index";
        public const string Templates__Managing_Templates = "Templates__Managing_Templates";
        public const string Templates__Managing_Templates__Editing_Quick_Access_List = "Templates__Managing_Templates__Editing_Quick_Access_List";
        public const string Templates__Managing_Templates__Importing_and_Exporting_Templates = "Templates__Managing_Templates__Importing_and_Exporting_Templates";
        public const string Templates__Managing_Templates__Organizing_Templates = "Templates__Managing_Templates__Organizing_Templates";
        public const string Templates__Managing_Templates__Sharing_Templates = "Templates__Managing_Templates__Sharing_Templates";
        public const string Templates__Template_Basics = "Templates__Template_Basics";
        public const string Templates__Template_Basics__Applicability_and_Storage_of_Templates = "Templates__Template_Basics__Applicability_and_Storage_of_Templates";
        public const string Templates__Template_Basics__Template_Macros = "Templates__Template_Basics__Template_Macros";
        public const string Templates__Template_Basics__Template_Types = "Templates__Template_Basics__Template_Types";
        public const string Templates__Template_Basics__Template_Variables = "Templates__Template_Basics__Template_Variables";
        public const string Templates__Template_Scopes = "Templates__Template_Scopes";
        public const string Troubleshooting__ReSharper_Exception_Browser = "Troubleshooting__ReSharper_Exception_Browser";
        public const string Unit_Testing__Analyzing_Code_Coverage_with_dotCover = "Unit_Testing__Analyzing_Code_Coverage_with_dotCover";
        public const string Unit_Testing__Index = "Unit_Testing__Index";
        public const string Unit_Testing__Navigating_to_Source_Code = "Unit_Testing__Navigating_to_Source_Code";
        public const string Unit_Testing__Profiling_Unit_Tests = "Unit_Testing__Profiling_Unit_Tests";
        public const string Unit_Testing__Recognizing_Unit_Tests = "Unit_Testing__Recognizing_Unit_Tests";
        public const string Unit_Testing__Running_and_Debugging_Unit_Tests = "Unit_Testing__Running_and_Debugging_Unit_Tests";
        public const string Using_IntelliSense = "Using_IntelliSense";
        public const string Viewing_Compiler_Generated_Code = "Viewing_Compiler_Generated_Code";
        public const string Viewing_Coverage_of_Particular_Unit_Test_Item = "Viewing_Coverage_of_Particular_Unit_Test_Item";
        public const string Viewing_References_Hierarchy = "Viewing_References_Hierarchy";
        public const string Visualizing_Code_Coverage = "Visualizing_Code_Coverage";
        public const string Web_Development__ASP_NET_MVC = "Web_Development__ASP_NET_MVC";
        public const string Web_Development__Code_Analysis_and_Coding_Assistance = "Web_Development__Code_Analysis_and_Coding_Assistance";
        public const string Web_Development__Code_Generation_and_Templates = "Web_Development__Code_Generation_and_Templates";
        public const string Web_Development__Index = "Web_Development__Index";
        public const string Web_Development__Navigation = "Web_Development__Navigation";
        public const string Web_Development__Refactorings = "Web_Development__Refactorings";
        public const string What_is_Coverage_Snapshot = "What_is_Coverage_Snapshot";
        public const string Whats_New = "Whats_New";
        public const string Working_with_Code = "Working_with_Code";
    }
    public class static ReSharperInfo
    {
        public const string AllAssembliesResourceName = "JetBrains.resources.config.AllAssemblies.xml";
    }
    public class static ReSharperLegacyHelpIds
    {
        public static readonly string Generic;
        public static readonly string OptionsNew;
        public static readonly string OptionsOld;
    }
    public class ReSharperLicenseSupport : JetBrains.Application.License.LicenseSupportBase
    {
        public ReSharperLicenseSupport(JetBrains.Application.IApplicationDescriptor descriptor) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.Application.ProductEdition> Editions { get; }
        public override bool SendBuildDateAsVersionToOldServers { get; }
        protected static JetBrains.Application.License.LicenseCheckResult Check30License(JetBrains.Application.License.LicenseData licenseData) { }
        public override JetBrains.Application.License.LicenseData CreateLicenseData(string licenseKey, string userName, string companyName) { }
        public override JetBrains.Application.ProductEdition DecodeProductEdition(int editionCode, JetBrains.Application.IApplicationDescriptor descriptor) { }
        public override string GetLicenseAgreement(JetBrains.Application.License.LicenseType licenseType) { }
        public override string GetLicenseServerEdition(JetBrains.Application.ProductEdition edition) { }
        public override JetBrains.Application.License.LicenseData LoadLicense(JetBrains.Util.DataStructures.ISettingsTable settings, JetBrains.Util.FileSystemPath installDir) { }
        public override void SaveLicense(JetBrains.Application.License.LicenseData license, JetBrains.Util.DataStructures.ISettingsTable settings) { }
        [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Neutral)]
        public class ReSharperLicenseRegistryInstaller : JetBrains.Application.Install.IStaticInstaller { }
    }
}
namespace JetBrains.ReSharper.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Settings for ReSharper features which modify the source code")]
    public class CodeEditingSettings { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "ReSharper code inspections: enabled state, severities, parameters, and possible a" +
        "ctions. Usually would be shared along with the solution file across the team")]
    public class CodeInspectionSettings { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Sets up the coding style for ReSharper features")]
    public class CodeStyleSettings { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Libraries of templates and patterns")]
    public class PatternsAndTemplatesSettingsKey { }
}
namespace JetBrains.Resources.Icons.PsiFeaturesUnsortedIcons
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.AnyThread)]
    public class IconsForIconThemeSelectionSamplePsiUnsorted : JetBrains.UI.Icons.Settings.IIconsForIconThemeSelectionSample { }
}
namespace JetBrains.Resources.Icons
{
    
    public sealed class PsiFeaturesUnsortedOptionsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedOption" +
            "sIcons/ThemedIcons.PsiFeaturesUnsortedOptions.Generated.Xaml", 2, "BlankLines")]
        public sealed class BlankLines : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedOption" +
            "sIcons/ThemedIcons.PsiFeaturesUnsortedOptions.Generated.Xaml", 4, "LineBreaks")]
        public sealed class LineBreaks : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedOption" +
            "sIcons/ThemedIcons.PsiFeaturesUnsortedOptions.Generated.Xaml", 0, "MvcOptionsPage")]
        public sealed class MvcOptionsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedOption" +
            "sIcons/ThemedIcons.PsiFeaturesUnsortedOptions.Generated.Xaml", 3, "Others")]
        public sealed class Others : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedOption" +
            "sIcons/ThemedIcons.PsiFeaturesUnsortedOptions.Generated.Xaml", 1, "Spaces")]
        public sealed class Spaces : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
    public sealed class PsiFeaturesUnsortedThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 3, "AddFolder")]
        public sealed class AddFolder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 10, "Analyze")]
        public sealed class Analyze : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 6, "AnalyzeReferences")]
        public sealed class AnalyzeReferences : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 16, "AutoScrollToSource")]
        public sealed class AutoScrollToSource : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 9, "ExpandHaircomb")]
        public sealed class ExpandHaircomb : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 21, "FindDependentCode")]
        public sealed class FindDependentCode : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 7, "FindSymbolsExternalToScope")]
        public sealed class FindSymbolsExternalToScope : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 4, "FuncZoneAnalyze")]
        public sealed class FuncZoneAnalyze : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 19, "FuncZoneGenerate")]
        public sealed class FuncZoneGenerate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 14, "FuncZoneGenerateQuickFix")]
        public sealed class FuncZoneGenerateQuickFix : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 20, "FuncZoneNavigate")]
        public sealed class FuncZoneNavigate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 13, "FuncZoneRefactoring")]
        public sealed class FuncZoneRefactoring : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 1, "FuncZoneRefactoringQuickFix")]
        public sealed class FuncZoneRefactoringQuickFix : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 0, "Generate")]
        public sealed class Generate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 8, "GenerateQuickFix")]
        public sealed class GenerateQuickFix : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 2, "Navigate")]
        public sealed class Navigate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 12, "NavigateToSource")]
        public sealed class NavigateToSource : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 11, "OverrideOptions")]
        public sealed class OverrideOptions : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 18, "OverrideOptionsBack")]
        public sealed class OverrideOptionsBack : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 5, "Refactor")]
        public sealed class Refactor : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 17, "RefactorQuickFix")]
        public sealed class RefactorQuickFix : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Resources;component/resources/icons/PsiFeaturesUnsortedIcons/" +
            "ThemedIcons.PsiFeaturesUnsorted.Generated.Xaml", 15, "RemoveUnusedRefactoring")]
        public sealed class RemoveUnusedRefactoring : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}