[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]

namespace JetBrains.ProjectModel.MsBuild.Diagnostics
{
    
    public interface IMsBuildErrorConsumer
    {
        void LogError(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError error);
    }
    public interface IMsBuildLoaderError
    {
        string PresentableText { get; }
        void Accept(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor visitor);
    }
    public interface IMsBuildLoaderErrorVisitor
    {
        void VisitMsBuildProjectLoadError(JetBrains.ProjectModel.MsBuild.Diagnostics.MsBuildProjectLoadError error);
        void VisitProjectDependencyLoadFailed(JetBrains.ProjectModel.MsBuild.Diagnostics.ProjectDependencyLoadFailed error);
        void VisitSolutionFileNotFound(JetBrains.ProjectModel.MsBuild.Diagnostics.SolutionFileNotFound error);
        void VisitSolutionFileParseError(JetBrains.ProjectModel.MsBuild.Diagnostics.SolutionFileParseError error);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MsBuildErrorConsumers
    {
        public MsBuildErrorConsumers() { }
        public void RegisterConsumer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildErrorConsumer consumer) { }
    }
    public abstract class MsBuildLoaderErrorVisitorBase : JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor
    {
        protected abstract void VisitError(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError error);
        public virtual void VisitMsBuildProjectLoadError(JetBrains.ProjectModel.MsBuild.Diagnostics.MsBuildProjectLoadError error) { }
        public virtual void VisitProjectDependencyLoadFailed(JetBrains.ProjectModel.MsBuild.Diagnostics.ProjectDependencyLoadFailed error) { }
        public virtual void VisitSolutionFileNotFound(JetBrains.ProjectModel.MsBuild.Diagnostics.SolutionFileNotFound error) { }
        public virtual void VisitSolutionFileParseError(JetBrains.ProjectModel.MsBuild.Diagnostics.SolutionFileParseError error) { }
    }
    public class MsBuildProjectLoadError : JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError
    {
        public MsBuildProjectLoadError(string message, int lineNumber, int columnNumber) { }
        public MsBuildProjectLoadError(string message) { }
        public MsBuildProjectLoadError(Microsoft.Build.Exceptions.InvalidProjectFileException exception) { }
        public int ColumnNumber { get; }
        public int LineNumber { get; }
        public string Message { get; }
        public string PresentableText { get; }
        public void Accept(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor visitor) { }
    }
    public class ProjectDependencyLoadFailed : JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError
    {
        public ProjectDependencyLoadFailed([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.MsBuild.MsBuildProject project, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.MsBuild.MsBuildProject targetProject, System.Guid targetProjectGuid, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath targetProjectOutputAssembly) { }
        public string PresentableText { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.MsBuild.MsBuildProject Project { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.MsBuild.MsBuildProject TargetProject { get; }
        public System.Guid TargetProjectGuid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath TargetProjectOutputAssembly { get; }
        public void Accept(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor visitor) { }
    }
    public class SolutionFileNotFound : JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError
    {
        public SolutionFileNotFound(JetBrains.Util.FileSystemPath path) { }
        public JetBrains.Util.FileSystemPath Path { get; }
        public string PresentableText { get; }
        public void Accept(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor visitor) { }
    }
    public class SolutionFileParseError : JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError
    {
        public SolutionFileParseError(JetBrains.ProjectModel.SolutionFileParser.ISlnFile slnFile) { }
        public string PresentableText { get; }
        public JetBrains.ProjectModel.SolutionFileParser.ISlnFile SlnFile { get; }
        public void Accept(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor visitor) { }
    }
    public class VisitingConsumer : JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildErrorConsumer
    {
        public VisitingConsumer(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderErrorVisitor visitor) { }
        public void LogError(JetBrains.ProjectModel.MsBuild.Diagnostics.IMsBuildLoaderError error) { }
    }
}
namespace JetBrains.ProjectModel.MsBuild.Extensions
{
    
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class CSharpProjectPropertiesBuilder : JetBrains.ProjectModel.MsBuild.Extensions.ManagedProjectPropertiesBuilder
    {
        protected override void BuildProjectProperties(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ManagedProjectPropertiesBuilder : JetBrains.ProjectModel.MsBuild.IMsBuildProjectPropertiesBuilder
    {
        public void BuildProjectProperties(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected virtual void BuildProjectProperties(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings buildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase configurationSettings) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class MsBuildProjectFilePropertiesBuilderBase : JetBrains.ProjectModel.MsBuild.IMsBuildProjectFilePropertiesBuilder
    {
        public virtual bool BuildProjectFileProperties(JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties, Microsoft.Build.Execution.ProjectItemInstance itemInstance) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class MsBuildProjectLoader
    {
        public MsBuildProjectLoader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer) { }
        public JetBrains.ProjectModel.IProject UpdateOrCreateProject(JetBrains.ProjectModel.MsBuild.MsBuildProject slnFileProject, JetBrains.ProjectModel.IProject parentProject, JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class MsBuildProjectLoaderAttribute : JetBrains.Application.Parts.PartAttribute { }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectReferencesBuilder : JetBrains.ProjectModel.MsBuild.IMsBuildProjectReferencesBuilder
    {
        protected readonly JetBrains.ProjectModel.PlatformManager myPlatformManager;
        public ProjectReferencesBuilder(JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.MsBuild.Diagnostics.MsBuildErrorConsumers consumers) { }
        protected void AddReferenceIfNotExists(JetBrains.Util.FileSystemPath referencePath, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> referencesByAssemblyNameIgnoreCase) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> BuildProjectReferences(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.ProjectModel.MsBuild.MsBuildProject msBuildProject, JetBrains.ProjectModel.ISolution solution) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected virtual void ProcessNoStdLibProperty(bool noStdLibProperty, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> referencesByAssemblyNameIgnoreCase, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected void RemoveReference(JetBrains.Util.FileSystemPath referencePath, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> referencesByAssemblyNameIgnoreCase) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VBProjectPropertiesBuilder : JetBrains.ProjectModel.MsBuild.Extensions.ManagedProjectPropertiesBuilder
    {
        protected override void BuildProjectProperties(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VBProjectReferencesBuilder : JetBrains.ProjectModel.MsBuild.Extensions.ProjectReferencesBuilder
    {
        public VBProjectReferencesBuilder(JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.MsBuild.Diagnostics.MsBuildErrorConsumers consumers) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        protected override void ProcessNoStdLibProperty(bool noStdLibProperty, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> referencesByAssemblyNameIgnoreCase, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VCXProjectPropertiesBuilder : JetBrains.ProjectModel.MsBuild.Extensions.ManagedProjectPropertiesBuilder
    {
        protected override void BuildProjectProperties(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings managedProjectBuildSettings, JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase managedProjectConfiguration) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
}
namespace JetBrains.ProjectModel.MsBuild
{
    
    public interface IMsBuildProjectFilePropertiesBuilder
    {
        bool BuildProjectFileProperties(JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties, Microsoft.Build.Execution.ProjectItemInstance itemInstance);
        bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties);
    }
    public interface IMsBuildProjectLoadFilter
    {
        bool ShouldLoadProject(JetBrains.ProjectModel.SolutionFileParser.SlnFileProject slnProject);
    }
    public interface IMsBuildProjectReferencesBuilder
    {
        System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> BuildProjectReferences(Microsoft.Build.Execution.ProjectInstance projectInstance, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.ProjectModel.MsBuild.MsBuildProject msBuildProject, JetBrains.ProjectModel.ISolution solution);
        bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties);
    }
    public interface IMSBuildProjectTypeGuidProvider
    {
        System.Guid TryGetProjectTypeGuid(Microsoft.Build.Execution.ProjectInstance projectInstance);
    }
    public interface IMsBuildSolutionUserProfile
    {
        JetBrains.ProjectModel.MsBuild.IMsBuildProjectLoadFilter Filter { get; }
    }
    public class MsBuildDefaultUserProfile : JetBrains.ProjectModel.MsBuild.IMsBuildSolutionUserProfile
    {
        public static readonly JetBrains.ProjectModel.MsBuild.MsBuildDefaultUserProfile Instance;
        public JetBrains.ProjectModel.MsBuild.IMsBuildProjectLoadFilter Filter { get; }
    }
    public class MsBuildProject
    {
        public MsBuildProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.SolutionFileParser.SlnFileProject slnProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.MsBuild.MsBuildSolution msBuildSolution, [JetBrains.Annotations.CanBeNullAttribute()] Microsoft.Build.Evaluation.Project msBuildProject, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.SolutionFileParser.ISlnFile solutionFile, JetBrains.ProjectModel.MsBuild.MsBuildProjectKind projectKind) { }
        public System.Collections.Generic.List<JetBrains.ProjectModel.MsBuild.MsBuildProject> ChildProjects { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.MsBuild.MsBuildSolution MSBuildSolution { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.MsBuild.MsBuildProject ParentProject { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public Microsoft.Build.Evaluation.Project Project { get; }
        public JetBrains.ProjectModel.MsBuild.MsBuildProjectKind ProjectKind { get; }
        public JetBrains.Util.FileSystemPath ProjectLocation { get; }
        public System.Guid ProjectTypeGuid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.SolutionFileParser.ISlnFile SlnFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.SolutionFileParser.SlnFileProject SlnProject { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public Microsoft.Build.Execution.ProjectInstance GetProjectInstnace() { }
    }
    public enum MsBuildProjectKind
    {
        ProjectLoadFailed = 0,
        ProjectUnloaded = 1,
        Project = 2,
        SolutionFolder = 3,
    }
    public class MsBuildSolution
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.MsBuild.MsBuildProject> AllProjects { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public Microsoft.Build.Evaluation.ProjectCollection ProjectCollection { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ProjectModel.MsBuild.MsBuildProject> RootProjects { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.SolutionFileParser.ISlnFile SolutionFile { get; }
        public JetBrains.ProjectModel.MsBuild.MsBuildProject GetProjectByGuid(System.Guid targetProjectGuid) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MsBuildSolutionHost
    {
        public MsBuildSolutionHost(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.MsBuild.MsBuildSolutionOrProjectFileLoader msBuildSolutionLoader) { }
        public JetBrains.DataFlow.IProperty<JetBrains.ProjectModel.MsBuild.MsBuildSolution> MsBuildSolution { get; }
        public bool OpenSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.MsBuild.IMsBuildSolutionUserProfile userProfile) { }
        public void UnloadSolution() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MsBuildSolutionOrProjectFileLoader
    {
        public MsBuildSolutionOrProjectFileLoader(JetBrains.ProjectModel.MsBuild.Diagnostics.MsBuildErrorConsumers consumers) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.MsBuild.MsBuildSolution LoadSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.MsBuild.IMsBuildSolutionUserProfile profile) { }
    }
    public class static SlnFileExtensions
    {
        public static System.Version GetMaxPlatformVersion([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.SolutionFileParser.ISlnFile msBuildSolution) { }
    }
}