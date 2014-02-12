[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Asp.Css
{
    
    public class static AspCssClassAttributeEx
    {
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName CssClassPropertyAttributeName;
        public static bool IsCssClassAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute) { }
    }
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class CssFromAspGeneratedDocumentService : JetBrains.ReSharper.Psi.Html.Css.CssFromHtmlGeneratedDocumentService
    {
        public CssFromAspGeneratedDocumentService(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ProjectModel.AspProjectFileType aspProjectFileType) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
    }
}