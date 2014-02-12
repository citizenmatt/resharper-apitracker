[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Resx.CodeStructure
{
    
    public abstract class CodeStructureElementBase<T> : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement
        where T :  class, JetBrains.ReSharper.Psi.Resx.Tree.IResxTag
    {
        protected CodeStructureElementBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, [JetBrains.Annotations.NotNullAttribute()] T tag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IconId image) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.Icons.IconId Image { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T Tag { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        protected override void DumpSelf(System.IO.TextWriter builder) { }
        public override JetBrains.Util.TextRange GetTextRange() { }
    }
    public class ResxDataTagElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureDeclarationElement
    {
        public ResxDataTagElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Resx.CodeStructure.ResxFileElement fileElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagDeclaration resxTag) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
    }
    public class ResxFileElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement
    {
        public ResxFileElement(JetBrains.ReSharper.Psi.Resx.Tree.IResxFile file) { }
        public JetBrains.ReSharper.Psi.Resx.Tree.IResxFile File { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Resx.Occurences
{
    
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class ResxOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.RangeOccurencePresenter
    {
        protected override JetBrains.UI.RichText.RichText GetDisplayText(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Resx.QuickDoc
{
    
    public class QuickDocResxPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocResxPresenter(JetBrains.IDE.EditorManager editorManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement resourceItemDeclaredElement) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(-10)]
    public class QuickDocResxProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocResxProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.IDE.EditorManager editorManager) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Services
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ReswProjectFileType))]
    public class ReswResourceService : JetBrains.ReSharper.Psi.Resx.Services.WinRTResourceServiceBase { }
    public abstract class ResxResourceServiceBase : JetBrains.ReSharper.Psi.Resx.Services.ResourceService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetBaseCultureFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, [JetBrains.Annotations.NotNullAttribute()] string baseCultureName) { }
        public override string GetCultureName(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override string GetResourceName(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithAllCultures(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithCulture(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string cultureName) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithSpecificCultures(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetResourceWithCulture([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, [JetBrains.Annotations.CanBeNullAttribute()] string cultureName) { }
        public override bool IsDefaultCulture(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
    }
}