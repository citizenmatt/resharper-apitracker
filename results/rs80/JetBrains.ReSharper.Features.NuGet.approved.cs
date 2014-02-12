[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]

namespace JetBrains.ReSharper.Features.NuGet
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class NuGetPsiSourceFilePropertiesProvider : JetBrains.ReSharper.Psi.IPsiSourceFilePropertiesProvider
    {
        public NuGetPsiSourceFilePropertiesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Features.NuGet.RepositorySettings repositorySettings, JetBrains.Util.ILogger logger) { }
        public double Order { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ReSharper.Psi.IPsiSourceFileProperties prevProperties, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class ProjectSystem : NuGet.PhysicalFileSystem
    {
        public static NuGet.IFileSystem Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class RepositorySettings
    {
        public RepositorySettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.ILogger logger, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.ProjectModel.SolutionFileLocationLive solutionFileLocationLive) { }
        public JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> ConfigFolderPath { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> RepositoryPath { get; }
    }
}