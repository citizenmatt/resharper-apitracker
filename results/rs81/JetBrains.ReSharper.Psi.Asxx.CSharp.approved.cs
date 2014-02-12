[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Asxx.CSharp.Impl.PsiModules.Website.Properties
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AsxxProjectFileType))]
    public class AsxxCSharpProjectFileCustomPsiPropertiesProvider : JetBrains.ReSharper.Psi.IProjectFileCustomPsiPropertiesProvider
    {
        public T GetCustomProperties<T>(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpWebsiteAsxxPsiSourceFilePropertiesFactory : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Properties.IWebsiteAsxxPsiSourceFilePropertiesFactory
    {
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
    }
}