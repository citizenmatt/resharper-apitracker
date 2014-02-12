[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.Asp.CSharp
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspCSharpCustomFormattingInfoProvider : JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.DummyCSharpCustomFormattingInfoProvider
    {
        public override JetBrains.ReSharper.Psi.CSharp.CodeStyle.CSharpCodeFormattingSettings AdjustFormattingSettings(JetBrains.ReSharper.Psi.CSharp.CodeStyle.CSharpCodeFormattingSettings settings, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public override JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.SpaceType GetBlockSpaceType(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpFmtStageContext context) { }
        public override JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.SpaceType VisitInvocationExpression(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpFmtStageContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpAspLanguageSpecificUtil : JetBrains.ReSharper.Psi.Services.Asp.IAspLanguageSpecificUtil
    {
        public bool IsPageClassDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public bool IsUserTextDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}