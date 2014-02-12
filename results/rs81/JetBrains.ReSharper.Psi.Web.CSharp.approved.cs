[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Web.CSharp.Impl
{
    
    public class static CodeBehindModificationUtil
    {
        public static void DetachServiceCommentMarker(JetBrains.ReSharper.Psi.Tree.IStatement statement, System.Collections.Generic.HashSet<string> commentSet, System.Collections.Generic.HashSet<string> endCommentSet) { }
        public static void DetachServiceCommentMarkerAfterDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode statement, System.Collections.Generic.HashSet<string> commentSet, System.Collections.Generic.HashSet<string> endCommentSet) { }
        public static JetBrains.ReSharper.Psi.Tree.IComment GetServiceCommentAfter(JetBrains.ReSharper.Psi.Tree.ITreeNode statement, System.Collections.Generic.HashSet<string> commentSet) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.CSharp.Impl.Languages
{
    
    [JetBrains.ReSharper.Psi.Web.Languages.WebCodeBehindLanguageSupportAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCodeBehindLanguageSupport : JetBrains.ReSharper.Psi.Web.Languages.IWebCodeBehindLanguageSupport
    {
        public CSharpCodeBehindLanguageSupport(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage language) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType CodeBehindLanguage { get; }
        public bool IsCaseSensitive { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Web.CSharp.Impl.PsiModules
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.CSharpProjectFileType))]
    public class WebCSharpProjectFileClassifier : JetBrains.ReSharper.Psi.Web.PsiModules.IWebProjectFileClassifier
    {
        public bool CanBeAppCodeFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeAspFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeCodeBehindFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.CSharp.Impl.References
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpStringLiteralPathBinder : JetBrains.ReSharper.Psi.Web.References.StringLiteralPathBinder
    {
        public CSharpStringLiteralPathBinder(JetBrains.ReSharper.Psi.Util.IStringLiteralAltererProvider stringLiteralAltererProvider) { }
    }
}