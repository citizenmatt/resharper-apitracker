[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.Asp.VB
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBAspLanguageSpecificUtil : JetBrains.ReSharper.Psi.Services.Asp.IAspLanguageSpecificUtil
    {
        public bool IsPageClassDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public bool IsUserTextDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}