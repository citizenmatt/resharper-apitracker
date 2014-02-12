[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "AspCodeExpression",
        "AspCode",
        "AspCodeHtmlEncoding",
        "AspCodeDataBinding",
        "AspCodeRegular",
        "AspCodeHtmlEncodedDataBinding",
        "ScopeAsp"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
    "ns/ThemedIcons.ServicesAsp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-asp", "JetBrains.ReSharper.Feature.Services.Asp.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Asp
{
    
    public class static AspContextUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetAttributeValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, string attributeName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetContentPlaceHolders([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspCache) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.Icons.IconId GetIcon([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetInnerTagsByType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer tagContainer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Tree.IAspFile GetMasterPageFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        public static bool TypeMatches([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType type) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public sealed class AspFileTypeSpecificOwnerUtil : JetBrains.ReSharper.Feature.Services.Util.DefaultFileTypeSpecificOwnerUtil
    {
        public AspFileTypeSpecificOwnerUtil(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public override bool CanContainSeveralClasses(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool CanHaveConstructors(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public override bool CanImplementInterfaces(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetContainingTypeForReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.Util.FileSystemPath GetFolderForElementsMovedToExternalScope(JetBrains.ProjectModel.IProjectFile projectFile, string @namespace, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClrTypeName> GetMvcViewWithModelBaseTypes() { }
        public override string GetNamespaceForElementsMovedToExternalScope(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode) { }
        public override string GetPrettyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration element, bool mustBeIdentifier) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetRelatedAndFilterHidden(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetRelatedDeclarations(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public override bool HasUglyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override bool IsCodeBehindClass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override bool IsHidden(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public bool IsPageClass([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public override bool IsUserTextDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool SuperClassCanBeChanged(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public override bool SuperClassNameMustBeFull(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspTextControlPsi : JetBrains.ReSharper.Psi.Services.ITextControlPsi
    {
        public AspTextControlPsi(JetBrains.ReSharper.Feature.Services.Asp.AspFileTypeSpecificOwnerUtil aspFileTypeSpecificOwnerUtil) { }
        public bool IgnoreDeclarationInBinding(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Caches
{
    
    public interface IMvcCacheProcessor : JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool>>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
    }
    public interface IMvcElementsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType CustomModelBinderAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType HttpPostedFileBase { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType MvcActionResultClassType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcApiControllerClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcAsyncControllerClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcControllerClass { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType MvcControllerClassType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcControllerInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcHttpControllerInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcTypedViewDataDictionaryClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement MvcViewDataDictionaryClass { get; }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class MvcCache : JetBrains.ReSharper.Psi.Caches.ICache
    {
        public MvcCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewResolver> viewResolvers, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.Asp.Caches.IMvcCacheProcessor> cacheProcessors) { }
        public System.Collections.Generic.IEnumerable<string> GetDisplayModes([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public System.Collections.Generic.IEnumerable<string> GetLocations([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType key, bool expandRoot = True) { }
        public sealed class MvcData
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly System.Collections.Generic.IList<string> DisplayModes;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>> Layout;
            public MvcData([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>> layout, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IList<string> displayModes) { }
        }
    }
    public class MvcCacheProcessorHelper
    {
        public MvcCacheProcessorHelper(System.StringComparer stringComparer) { }
        public TObjectCreationExpression CheckDisplayMode<TObjectCreationExpression>(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner destExpression, JetBrains.ReSharper.Psi.Resolve.IReference destReference, JetBrains.ReSharper.Psi.Resolve.IReference sourceReference, bool full)
            where TObjectCreationExpression :  class, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner { }
        public JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType CheckViewLocationType(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression destExpression, JetBrains.ReSharper.Psi.Resolve.IReference destReference, JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression sourceExpression, bool full) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class MvcElementsCache
    {
        public MvcElementsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules) { }
        public JetBrains.ReSharper.Feature.Services.Asp.Caches.IMvcElementsCache this[JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context] { get; }
        public static JetBrains.ReSharper.Feature.Services.Asp.Caches.IMvcElementsCache GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CallHierarchy
{
    
    [JetBrains.ReSharper.Feature.Services.CallHierarchy.View.CallHierarchyIncomingTypeMemberNodePresenterAttribute()]
    public class AspCallHierarchyIncomingTypeMemberNodePresenter : JetBrains.ReSharper.Feature.Services.CallHierarchy.View.CallHierarchyIncomingTypeMemberNodePresenter
    {
        public AspCallHierarchyIncomingTypeMemberNodePresenter(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        public override JetBrains.DocumentModel.DocumentRange GetPreviewableDocumentRange(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node) { }
        public override void Present(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.PresentableItem presentableItem, JetBrains.UI.TreeView.PresentationState state, JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyNodePresenter presenter) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class RemoveRedundandTagNamePrefixesModule : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CodeCleanup.RemoveRedundandTagNamePrefixesModule.Descriptor DESCRIPTOR;
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
        [System.ComponentModel.CategoryAttribute("ASP.NET")]
        [System.ComponentModel.DisplayNameAttribute("Optimize @Register directives")]
        public class Descriptor : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor
        {
            public Descriptor() { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspAutomaticStrategyOnCharacter : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>
    {
        public AspAutomaticStrategyOnCharacter(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>.StartChar> GetStartChars(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenNodeTypes) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class AspCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext
    {
        public AspCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes AspDeclaredElementTypes { get; }
        public override string ContextId { get; }
        public override JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override string GetDisplayNameByDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class AspCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContextProvider
    {
        public AspCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes htmlCache, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetSpecificContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class AspCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "ASP.NET")]
    public class AspCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non-completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
    }
    public class AspDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlDeclaredElementLookupItem
    {
        public AspDeclaredElementLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string name, string displayName, JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.Casing Casing { get; }
        protected override void FixInsertedText(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspNewMethodItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspReferencedItemsProvider : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReferencedItemsProvider
    {
        public AspReferencedItemsProvider(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        protected override System.Collections.Generic.IEnumerable<string> GetAttributesByImportance(JetBrains.ReSharper.Psi.Resolve.IReference qualifier) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspSimpleTypeItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context) { }
    }
    public class AspTagNameLookupItem : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlTagNameLookupItem
    {
        public AspTagNameLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string name, string displayName, JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.Casing Casing { get; }
        protected override void DecorateDisplayName(JetBrains.UI.RichText.RichText displayName, JetBrains.ReSharper.Psi.DeclaredElementInstance preferredDeclaredElement) { }
        protected override void FixInsertedText(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspVisibilityRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.AspCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.Rules
{
    
    public class MvcActionTransformationRule<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem> Decorate(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(TContext specificContext) { }
        protected bool IsApplicable(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected void Transfom(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public class MvcControllerTransformationRule<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected void Apply(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(TContext specificContext) { }
        protected bool IsApplicable(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "ASP.NET")]
    public class AspAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After \'-\' and \':\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnMinusAndColon;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CodeStructure
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspCodeStructureProvider : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureProvider
    {
        public AspCodeStructureProvider(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        protected override JetBrains.ReSharper.Psi.IRecursiveElementProcessor CreateElementProcessor(JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureRootElement root, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
    }
    public class AspDirectiveCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective>, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureDeclarationElement
    {
        public AspDirectiveCodeStructureElement(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public override JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class AspRenderBlockCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock>
    {
        public AspRenderBlockCodeStructureElement(JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock aspRenderBlock, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        public static JetBrains.Util.Pair<int, int> GetNestedLevel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock block) { }
        public JetBrains.Util.Pair<int, int> GetNestedLevel() { }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class AspSubstitutionCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution>
    {
        public AspSubstitutionCodeStructureElement(JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class AspTagCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlTagCodeStructureElement<JetBrains.ReSharper.Psi.Asp.Tree.IAspTag>
    {
        public AspTagCodeStructureElement(JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        protected override JetBrains.UI.RichText.RichText DecorElement(JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, JetBrains.UI.RichText.RichText text) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Comment
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspBlockCommentActionProvider : JetBrains.ReSharper.Feature.Services.Html.Comment.HtmlBlockCommentActionProvider
    {
        public AspBlockCommentActionProvider(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenNodeTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentBody { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentEnd { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentStart { get; }
        public override string EndBlockCommentMarker { get; }
        public override string StartBlockCommentMarker { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspLineCommentActionProvider : JetBrains.ReSharper.Feature.Services.Html.Comment.HtmlLineCommentActionProvider
    {
        public AspLineCommentActionProvider(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenNodeTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentEnd { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentStart { get; }
        public override string EndLineCommentMarker { get; }
        public override string StartLineCommentMarker { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class AspMatchingBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ContextHighlighterBase
    {
        protected override void CollectHighlightings(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Asp.ContextActions.AspContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CustomReferences
{
    
    public interface IMvcActionControllerReference : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Psi.IClass>> Controllers { get; }
    }
    public interface IMvcActionReference : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IMvcAreaReference : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IMvcControllerReference : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IMvcLanguageHelper
    {
        JetBrains.ReSharper.Psi.IType GetAssigmentType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetAttributeDeclarations(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node);
        bool IsAttribute(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node);
    }
    public interface IMvcReference : JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool IsInternalValid { get; }
        JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
    }
    public interface IMvcViewReference : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath GetControllerFolder();
    }
    public interface IMvcViewResolver
    {
        System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>> Values { get; }
        bool IsApplicable(JetBrains.ProjectModel.IProject project);
    }
    public abstract class MvcActionControllerReference<TLiteral> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcReference<TLiteral>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteral : JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        protected readonly JetBrains.ReSharper.Psi.Tree.IArgumentsOwner myArgumentsExpression;
        protected MvcActionControllerReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsExpression) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Psi.IClass>> Controllers { get; }
    }
    public class MvcActionReference<TLiteral> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcActionControllerReference<TLiteral>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteral : JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        public MvcActionReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsExpression) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Psi.IClass>> Controllers { get; }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected override string PrepareName(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbol) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    [System.ComponentModel.DescriptionAttribute("Area")]
    public class MvcAreaReference<TLiteral> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcReference<TLiteral>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcAreaReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteral : JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        public MvcAreaReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner) { }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public abstract class MvcBaseReference<TElement> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MyReferenceBase<TElement>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TElement : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected MvcBaseReference([JetBrains.Annotations.NotNullAttribute()] TElement owner) { }
        public abstract bool IsInternalValid { get; }
        public abstract JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public JetBrains.ReSharper.Psi.Resolve.Refers RefersToDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class MvcControllerReference<TLiteral> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcActionControllerReference<TLiteral>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteral : JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        public MvcControllerReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsExpression) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Psi.IClass>> Controllers { get; }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected override string PrepareName(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbol) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Asp.Settings.AspHierarchySettings), "ASP.NET MVC settings", KeyNameOverride="Mvc")]
    public class MvcCustomReferencesSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable ASP.NET MVC processing")]
        public bool Enabled;
        public MvcCustomReferencesSettings() { }
    }
    public class static MvcCustomReferencesSettingsEx
    {
        public static bool IsApplied([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> enabled, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
        public static bool IsApplied([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> enabled, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.CanBeNullAttribute()] out System.Version version) { }
        public static bool IsApplied([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcCustomReferencesSettings settings, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class MvcCustomReferencesSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader { }
    public abstract class MvcImplicitActionControllerReference<TElement, TDeclaration> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcImplicitReference<TElement, TDeclaration>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TElement : JetBrains.ReSharper.Psi.Tree.IArgumentsOwner
        where TDeclaration : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        protected MvcImplicitActionControllerReference([JetBrains.Annotations.NotNullAttribute()] TElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Func<TElement, System.Collections.Generic.IEnumerable<TDeclaration>> declarationsRetriever, [JetBrains.Annotations.NotNullAttribute()] System.Func<TDeclaration, string> namer) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Psi.IClass>> Controllers { get; }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcUtil.DeterminationKind DeterminationKind { get; }
    }
    public sealed class MvcImplicitActionReference<TElement> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcImplicitActionControllerReference<TElement, JetBrains.ReSharper.Psi.IMethod>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TElement : JetBrains.ReSharper.Psi.Tree.IArgumentsOwner
    {
        public MvcImplicitActionReference(TElement owner) { }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public override string GetName() { }
    }
    public sealed class MvcImplicitControllerReference<TElement> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcImplicitActionControllerReference<TElement, JetBrains.ReSharper.Psi.IClass>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcControllerReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TElement : JetBrains.ReSharper.Psi.Tree.IArgumentsOwner
    {
        public MvcImplicitControllerReference(TElement owner) { }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public override string GetName() { }
    }
    public abstract class MvcImplicitReference<TElement, TDeclaration> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcBaseReference<TElement>, JetBrains.ReSharper.Feature.Services.Util.IImplicitReference, JetBrains.ReSharper.Feature.Services.Util.IPrefferedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TElement : JetBrains.ReSharper.Psi.Tree.IArgumentsOwner
        where TDeclaration : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        protected MvcImplicitReference([JetBrains.Annotations.NotNullAttribute()] TElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Func<TElement, System.Collections.Generic.IEnumerable<TDeclaration>> declarationsRetriever, [JetBrains.Annotations.NotNullAttribute()] System.Func<TDeclaration, string> namer) { }
        public abstract JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcUtil.DeterminationKind DeterminationKind { get; }
        public override bool HasMultipleNames { get; }
        public override bool IsInternalValid { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public sealed class MvcImplicitViewReference<TElement, TLiteral, TMethod> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcImplicitReference<TElement, JetBrains.ReSharper.Psi.IPathDeclaredElement>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TElement : JetBrains.ReSharper.Psi.Tree.IArgumentsOwner
        where TLiteral :  class, JetBrains.ReSharper.Psi.Tree.ILiteralExpression
        where TMethod :  class, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration
    {
        public MvcImplicitViewReference(TElement owner, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind, System.Version version) { }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcUtil.DeterminationKind DeterminationKind { get; }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public JetBrains.Util.FileSystemPath GetControllerFolder() { }
        public override string GetName() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public enum MvcKind
    {
        None = 0,
        Area = 1,
        Controller = 2,
        Action = 3,
        View = 4,
        PartialView = 5,
        Master = 6,
        DisplayTemplate = 7,
        EditorTemplate = 8,
        Template = 9,
        PathReference = 10,
        ModelType = 11,
    }
    public abstract class MvcReference<TLiteral> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcBaseReference<JetBrains.ReSharper.Psi.Tree.IExpression>, JetBrains.ReSharper.Feature.Services.Util.IPrefferedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteral : JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        protected MvcReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner) { }
        public override bool IsInternalValid { get; }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        protected JetBrains.ReSharper.Psi.Tree.IExpression InternalBindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsValid() { }
        protected virtual string PrepareName(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbol) { }
    }
    public abstract class MvcReferenceProvider<TLiteral, TExpression, TMethod> : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
        where TLiteral :  class, JetBrains.ReSharper.Psi.Tree.ILiteralExpression
        where TExpression :  class, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner, JetBrains.ReSharper.Psi.IInvocationInfo, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TMethod :  class, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration
    {
        protected MvcReferenceProvider([JetBrains.Annotations.NotNullAttribute()] System.Version version) { }
        protected abstract JetBrains.Util.DataStructures.HybridCollection<string> GetExpressionNames([JetBrains.Annotations.NotNullAttribute()] TExpression expression);
        protected virtual JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcActionReference<TLiteral> GetMvcActionReference(JetBrains.ReSharper.Psi.Tree.IExpression literal, TExpression argumentsExpression) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcAreaReference<TLiteral> GetMvcAreaReference(JetBrains.ReSharper.Psi.Tree.IExpression literal) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcControllerReference<TLiteral> GetMvcControllerReference(JetBrains.ReSharper.Psi.Tree.IExpression literal, TExpression argumentsExpression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.IExpression GetMvcLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] out TExpression expression, [JetBrains.Annotations.CanBeNullAttribute()] out string anonymousPropertyName);
        protected virtual JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewReference<TLiteral, TMethod> GetMvcViewReference(JetBrains.ReSharper.Psi.Tree.IExpression literal, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcUtil.DeterminationKind, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClass>>> names, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind, System.Version version) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MvcReferenceProviderValidator
    {
        public MvcReferenceProviderValidator(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public event System.Action OnChanged;
    }
    public class MvcResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorTypeWithTooltip
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_ACTION_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_AREA_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_CONTROLLER_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_MASTERPAGE_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_PARTIAL_VIEW_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_TEMPLATE_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcResolveErrorType MVC_VIEW_NOT_RESOLVED;
        public override string CreateTooltip(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static MvcUtil
    {
        public const string AreasFolder = "Areas";
        public const string AsyncActionSuffixCompleted = "Completed";
        public static readonly string[] AsyncActionSuffixes;
        public const string AsyncActionSuffixInit = "Async";
        public const string ControllerClassSuffix = "Controller";
        public const string ControllersFolder = "Controllers";
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo CheckMvcResolveResult([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo result, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> DetermineActionParameters(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static string DetermineViewModelType(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.IType defaultType = null) { }
        public static string GetActionName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetAreaFolder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetAreaFolder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.CanBeNullAttribute()] string area) { }
        public static System.Collections.Generic.IList<string> GetAreas([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetAreasFolder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.Util.OneToListMap<string, JetBrains.ReSharper.Psi.IClass> GetAvailableControllers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<string> areas = null, bool includingIntermediateControllers = False, JetBrains.ReSharper.Psi.ITypeElement baseClass = null) { }
        public static JetBrains.Util.OneToListMap<string, JetBrains.ReSharper.Psi.IClass> GetAvailableControllers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context, bool includingIntermediateControllers = False, JetBrains.ReSharper.Psi.ITypeElement baseClass = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IMethod> GetControllerActions([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IClass @class, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetControllerArea([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement controller) { }
        public static JetBrains.Util.FileSystemPath GetControllerFolder(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.IClass @class) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetControllerFolder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.CanBeNullAttribute()] string area, [JetBrains.Annotations.CanBeNullAttribute()] string controllerName, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind = 4) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetControllerName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement controller) { }
        public static string GetControllerName([JetBrains.Annotations.NotNullAttribute()] string controllerName) { }
        public static System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcUtil.DeterminationKind, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClass>>> GetControllers([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
        public static JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind GetMvcKind([JetBrains.Annotations.NotNullAttribute()] System.Type attributeType) { }
        public static System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind, string, JetBrains.ReSharper.Psi.IAttributeInstance>> GetMvcKinds([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IAttributesOwner element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression GetMvcLiteral<TExpression>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression literal, [JetBrains.Annotations.CanBeNullAttribute()] out TExpression expression, [JetBrains.Annotations.CanBeNullAttribute()] out string anonymousPropertyName)
            where TExpression :  class, JetBrains.ReSharper.Psi.IInvocationInfo { }
        public static JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind GetReferenceKind(this JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcActionControllerReference reference) { }
        public static JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType GetViewLocationType(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind, string area) { }
        public static bool IsAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Asp.Caches.MvcElementsCache mvcElementsCache, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static bool IsController([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Asp.Caches.MvcElementsCache mvcElementsCache, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static bool IsModelTypeExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, out JetBrains.ReSharper.Psi.Tree.IArgument argument, out JetBrains.Util.OneToListMap<, > modelTypes) { }
        public enum DeterminationKind
        {
            Explicit = 0,
            ImplicitByLocation = 1,
            ImplicitByContainingMember = 2,
        }
    }
    public enum MvcViewLocationType
    {
        Unknown = 0,
        AreaMaster = 1,
        AreaPartialView = 2,
        AreaView = 3,
        Master = 4,
        PartialView = 5,
        View = 6,
    }
    [JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewResolverAttribute()]
    public class MvcViewRazorResolver : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewResolver
    {
        public MvcViewRazorResolver() { }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>> Values { get; }
        public bool IsApplicable(JetBrains.ProjectModel.IProject project) { }
    }
    [System.ComponentModel.DescriptionAttribute("View")]
    public class MvcViewReference<TLiteral, TMethod> : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcReference<TLiteral>, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteral : JetBrains.ReSharper.Psi.Tree.ILiteralExpression
        where TMethod :  class, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration
    {
        public MvcViewReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<string, string, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcUtil.DeterminationKind, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClass>>> names, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind, System.Version version) { }
        public override JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind MvcKind { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo CheckViewResolveResult([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo result, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IMethod GetAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        public JetBrains.Util.FileSystemPath GetControllerFolder() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClass @class, [JetBrains.Annotations.CanBeNullAttribute()] string name, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcKind mvcKind, System.Version version, string area = null) { }
        protected override string PrepareName(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbol) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewResolver))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class MvcViewResolverAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    [JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewResolverAttribute()]
    public class MvcViewSparkResolver : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewResolver
    {
        public MvcViewSparkResolver() { }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>> Values { get; }
        public bool IsApplicable(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewResolverAttribute()]
    public class MvcViewWebFormResolver : JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewResolver
    {
        public MvcViewWebFormResolver() { }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>> Values { get; }
        public bool IsApplicable(JetBrains.ProjectModel.IProject project) { }
    }
    public abstract class MyReferenceBase<T> : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<T>
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> ResolveFilter;
        protected MyReferenceBase([JetBrains.Annotations.NotNullAttribute()] T owner) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class PathReferenceProvider<TLiteral, TExpression> : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
        where TLiteral :  class, JetBrains.ReSharper.Psi.Tree.ILiteralExpression
        where TExpression :  class, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner, JetBrains.ReSharper.Psi.IInvocationInfo, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public PathReferenceProvider(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache, JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.ExpectedTypes
{
    
    public class static MvcExpectedTypesUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> ProcessExpectedTypes(JetBrains.ReSharper.Psi.Tree.IExpression expression, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> baseExpectedTypes, System.Func<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ExpectedTypes.IExpectedTypeConstraint> createTypeConstraint) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Generate
{
    
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorElementProviderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspEventsProvider : JetBrains.ReSharper.Feature.Services.Generate.GeneratorEventsProviderBase<JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext>
    {
        public AspEventsProvider(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public override double Priority { get; }
        public override void Populate(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class AspEventSubscriptionKnownLanguageService : JetBrains.ReSharper.Feature.Services.Asp.Generate.IAspEventSubscriptionLanguageService
    {
        public virtual void FilterEventsLanguageCanHandle(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, bool autoEventWireup, System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent>> events) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspEventSubscriptionsBuilder : JetBrains.ReSharper.Feature.Services.Generate.GenerateEventSubscriptionsBuilderBase<JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext>
    {
        public override double Priority { get; }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override void Process(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override string SuggestEventHandlerPrefix(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
    }
    public abstract class AspEventSubscriptionsCodeBehindBuilderBase<TCodeBehindContext> : JetBrains.ReSharper.Feature.Services.Generate.CodeBehindGeneratorBuilderBase<JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext, TCodeBehindContext>
        where TCodeBehindContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected abstract TCodeBehindContext CodeBehindContextFromDeclaration(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        protected override TCodeBehindContext CreateCodeBehindContext(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected virtual void EmitExplicitSubscriptions(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, TCodeBehindContext codeBehindContext) { }
        public abstract void Process(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, TCodeBehindContext codeBehindContext, JetBrains.ReSharper.Psi.AccessRights accessRights);
        public override void Process(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, TCodeBehindContext codeBehindContext) { }
    }
    public class AspGeneratorContext : JetBrains.ReSharper.Feature.Services.Generate.GeneratorContextBase
    {
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspFile AspFile { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ProjectModel.IProject Project { get; }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Root { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; set; }
        public static JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext CreateContext(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspTag FindAspServerTag(out JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public JetBrains.ReSharper.Psi.ITypeElement FindPageByAspDirective(out bool autoEventsWireUp) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetSelectionTreeRange() { }
        public bool IsGlobalAsax() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspGeneratorContextFactory : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderAttribute("Asp.Masterpage.Content", typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspMasterpageContentBuilder : JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderBase<JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext>
    {
        public override double Priority { get; }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetOutputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement outputElement, JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override bool IsAvaliable(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
        protected override void Process(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorElementProviderAttribute("Asp.Masterpage.Content", typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspMasterpageContentProvider : JetBrains.ReSharper.Feature.Services.Generate.GeneratorProviderBase<JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext>
    {
        public override double Priority { get; }
        public override void Populate(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context) { }
    }
    public class static GeneratorAspKinds
    {
        public const string MasterpageContent = "Asp.Masterpage.Content";
    }
    public interface IAspEventSubscriptionLanguageService
    {
        void FilterEventsLanguageCanHandle(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, bool autoEventWireup, System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent>> events);
    }
    public class MasterpageGeneratorElement : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElementPresenter
    {
        public MasterpageGeneratorElement(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public bool Emphasize { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag Tag { get; }
        public string TestDescriptor { get; }
        public object GetGroupingObject() { }
        public object GetPresentationObject() { }
        public void InitGeneratorPresenter(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter) { }
        public bool Matches(string searchText, JetBrains.Text.IdentifierMatcher matcher) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.HtmlEntities
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspHtmlEntitiesNodeTypeSet : JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntitiesNodeTypeSet
    {
        public AspHtmlEntitiesNodeTypeSet(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class AspFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.AspFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
    }
    public abstract class AspFileTemplatesSupportBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport
    {
        protected abstract JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public abstract string Name { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public virtual bool Accepts(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class AspProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public AspProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.Scope
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=0D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class AspProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public AspProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    public class InAnyWebProject : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyProject
    {
        public override string DefaultFileName { get; }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InLanguageSpecificWebProject : JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.Scope.InAnyWebProject
    {
        public InLanguageSpecificWebProject(JetBrains.ProjectModel.Properties.ProjectLanguage projectLanguage) { }
        public override System.Guid GetDefaultUID() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Navigation.GoToRelated
{
    
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.DefaultRelatedFilesProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class MvcRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.IRelatedFilesProvider
    {
        public MvcRelatedFilesProvider(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Options
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings), "ASP.NET typing assistance settings", KeyNameOverride="Asp")]
    public class AspTypingAssistSettings : JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PredefinedAspTypingAssistSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.ParameterInfo
{
    
    public class AspTagCandidate : JetBrains.ReSharper.Feature.Services.Html.ParameterInfo.HtmlTagCandidateBase
    {
        public AspTagCandidate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> table, JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, JetBrains.UI.RichText.RichTextBlock description, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader htmlTagHeader, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute currentAttribute, JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter presenter) { }
        public override bool IsObsolete { get; }
        public override JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public override bool IsParameterRecognized(string attribute) { }
    }
    [JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionProviderAttribute()]
    public class DescriptionAttributeProvider : JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionProvider
    {
        public DescriptionAttributeProvider() { }
        public int Priority { get; }
        public string GetDescriptionFromAttributes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IAttributesOwner member, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public string GetDescriptionFromAttributes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IAttributesOwner member) { }
        public JetBrains.UI.RichText.RichTextBlock GetElementDescription(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public System.Nullable<bool> IsElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style) { }
        public static bool IsHiddenFromDesigner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IAttributesOwner property, JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType editorBrowsableProcessing) { }
        public static bool IsHiddenViaBrowsable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IAttributesOwner property) { }
        public static bool IsHiddenViaDesignerSerializationVisibility([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IAttributesOwner property) { }
        public static bool IsHiddenViaEditorBrowsable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IAttributesOwner property, JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType editorBrowsableProcessing) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.RearrangeCode
{
    
    [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
    public class AspDirectiveAttributeRearrangeableElementType : JetBrains.ReSharper.Feature.Services.Html.RearrangeCode.HtmlAttributeRearrangeableElementTypeBase<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> { }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Resources
{
    
    public sealed class ServicesAspThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 1, "AspCode")]
        public sealed class AspCode : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 3, "AspCodeDataBinding")]
        public sealed class AspCodeDataBinding : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 0, "AspCodeExpression")]
        public sealed class AspCodeExpression : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 5, "AspCodeHtmlEncodedDataBinding")]
        public sealed class AspCodeHtmlEncodedDataBinding : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 2, "AspCodeHtmlEncoding")]
        public sealed class AspCodeHtmlEncoding : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 4, "AspCodeRegular")]
        public sealed class AspCodeRegular : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp;component/resources/ServicesAspThemedIco" +
            "ns/ThemedIcons.ServicesAsp.Generated.Xaml", 6, "ScopeAsp")]
        public sealed class ScopeAsp : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Search
{
    
    public interface IMasterPageSpecialElementFinder : JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder { }
    public interface IMvcSearchSupported { }
    [JetBrains.ReSharper.Feature.Services.Search.SpecialElementFinderAttribute()]
    public class MasterPageBaseSpecialFinder : JetBrains.ReSharper.Feature.Services.Asp.Search.IMasterPageSpecialElementFinder, JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder
    {
        public MasterPageBaseSpecialFinder(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind Kind { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle LocationStyle { get; }
        public void FindOccurences(object target, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> consumer, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.ReSharper.Psi.Search.ISearchDomain scopeDomain) { }
        public JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext GetSearchDomainContext(object target) { }
        public object GetSearchTarget(JetBrains.ReSharper.Psi.Tree.IFile file, System.Nullable<JetBrains.DocumentModel.DocumentRange> range, System.Nullable<int> caretOffset) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetTargetRanges(object target, JetBrains.ProjectModel.IProjectFile file) { }
        public string GetTitle() { }
        public string Present(object target) { }
    }
    [JetBrains.ReSharper.Feature.Services.Search.SpecialElementFinderAttribute()]
    public class MasterPageInheritorsSpecialFinder : JetBrains.ReSharper.Feature.Services.Asp.Search.IMasterPageSpecialElementFinder, JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder
    {
        public MasterPageInheritorsSpecialFinder(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind Kind { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle LocationStyle { get; }
        public void FindOccurences(object target, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> consumer, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.ReSharper.Psi.Search.ISearchDomain scopeDomain) { }
        public JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext GetSearchDomainContext(object target) { }
        public object GetSearchTarget(JetBrains.ReSharper.Psi.Tree.IFile file, System.Nullable<JetBrains.DocumentModel.DocumentRange> range, System.Nullable<int> caretOffset) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetTargetRanges(object target, JetBrains.ProjectModel.IProjectFile file) { }
        public string GetTitle() { }
        public string Present(object target) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class MvcAttributeNames : JetBrains.ReSharper.Psi.Impl.Reflection2.ExternalAnnotations.IExternalAnnotationsAttributeWatcher
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> AttributeClrNamesToWatch { get; }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class MvcSearchFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public MvcSearchFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Asp.Caches.MvcElementsCache mvcElementsCache) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.SelectEmbracingConstruct
{
    
    public class AspElementRange : JetBrains.ReSharper.Feature.Services.Html.SelectEmbracingConstruct.HtmlElementRange<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>
    {
        public AspElementRange(JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> provider, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.Html.SelectEmbracingConstruct.HtmlSelectEmbracingConstructProvider, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider, JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>
    {
        public AspSelectEmbracingConstructProvider(JetBrains.ProjectModel.AspProjectFileType aspProjectFileType, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateDotSelectedRange(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile primaryFile, JetBrains.ReSharper.Psi.TreeOffset treeOffset, bool selectBetterToken) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateElementSelectedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWrapperRange CreateWrapperRange(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primaryRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange codeBehindRange, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ProjectModel.Settings.Schema.HierarchySettings), "ASP.NET solution/project level settings", KeyNameOverride="Asp")]
    public class AspHierarchySettings { }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspTodoContentsProvider : JetBrains.ReSharper.Feature.Services.Html.TodoItems.HtmlTodoContentsProvider
    {
        public AspTodoContentsProvider(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes aspTokenNodeTypes) { }
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspChangedTagNameTracker : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.SpecificChangedTagNameTracker<JetBrains.ReSharper.Feature.Services.Asp.Options.AspTypingAssistSettings, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspChangedTagNameTracker(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspTypingAssist : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.WebTypingAssist<JetBrains.ProjectModel.AspProjectFileType, JetBrains.ReSharper.Psi.Asp.AspLanguage, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes, JetBrains.ReSharper.Feature.Services.Asp.Options.AspTypingAssistSettings>
    {
        public AspTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist skippingTypingAssist, JetBrains.ReSharper.Psi.ILanguageManager languageManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ISpecialTagSmartEnterHandler> smartEnterHandlers, JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController parameterInfoPopupController, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist> secondaryTypingAssists) { }
        protected override bool HandleQuoteAtTokenStart(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override bool IsTokenEnd(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes> tokenType) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.Util
{
    
    public class AspMethodReferenceHelper<T> : JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<T>
        where T :  class, JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference
    {
        public AspMethodReferenceHelper([JetBrains.Annotations.NotNullAttribute()] T reference) { }
        public override JetBrains.ReSharper.Psi.AccessRights GetAccessRights() { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature GetMemberSignature() { }
        public override string SuggestName(T reference) { }
    }
    public class EventHandlerReferenceHelper : JetBrains.ReSharper.Feature.Services.Asp.Util.MethodReferenceHelper<JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference>
    {
        public EventHandlerReferenceHelper(JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference reference) { }
        public JetBrains.ReSharper.Psi.IDelegate Delegate { get; }
        public override JetBrains.ReSharper.Psi.AccessRights GetAccessRights() { }
        public override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature GetMemberSignature() { }
        public override string SuggestName(JetBrains.ReSharper.Psi.Asp.References.IEventHandlerReference reference) { }
    }
    public abstract class MethodReferenceHelper<T>
        where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected MethodReferenceHelper([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TargetTypeDeclaration { get; }
        public abstract JetBrains.ReSharper.Psi.AccessRights GetAccessRights();
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature GetMemberSignature();
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration(T reference, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool IsSuitableTargetDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration typeDeclaration) { }
        public abstract string SuggestName(T reference);
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.ContextActions
{
    
    public class static AspContextActionDataProvider
    {
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>>
        {
            public static readonly JetBrains.ReSharper.Intentions.Asp.ContextActions.AspContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>, JetBrains.ReSharper.Psi.Asp.AspLanguage, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>> GetContextKey() { }
        }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.Util
{
    
    public class static TargetTypeDeclarationUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.Tree.IDeclaration, bool> isSuitable) { }
    }
}