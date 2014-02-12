[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ResxHeader",
        "ResxMetadata",
        "ResxStringValue",
        "ResxStringFormatValue",
        "ResxDataComment",
        "ResxFileRefValue",
        "ResxBlobValue",
        "ResxRoot",
        "ResxFile",
        "ResxAssembly",
        "ResxData"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
    "siResx.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-resx", "JetBrains.ReSharper.Psi.Resx.Resources")]

namespace JetBrains.ReSharper.Psi.Resx.CodeStyle
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResxFormatterPredefinedSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CodeStyle.CodeFormattingSettingsKey), "Code formatting in Resx")]
    public class ResxFormatterSettingsKey : JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey { }
}
namespace JetBrains.ReSharper.Psi.Resx.Impl.DeclaredElement
{
    
    public class ResxDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementTypeBase
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_ASSEMBLY_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_DATA_BLOB_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_DATA_FILE_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_DATA_STRING_FROMAT_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_DATA_STRING_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_DATA_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_HEADER_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_MEATADATA_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType RESX_ROOT_TAG;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Impl.Parsing
{
    
    public abstract class ReferenceFactory<TR>
        where TR : JetBrains.ReSharper.Psi.Resx.Tree.ITypeReference
    {
        protected int myShift;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.Util.RangeTranslator myTranslator;
        protected ReferenceFactory(JetBrains.Util.RangeTranslator translator) { }
        protected ReferenceFactory(JetBrains.Util.RangeTranslator translator, int shift) { }
        public abstract TR CreateArrayTypeRefernce(TR elementType, uint rank, uint[] sizes, int[] lBounds);
        public abstract JetBrains.ReSharper.Psi.Resx.Tree.IAssemblyReference CreateAssemblyReference(string assemblyName, JetBrains.Util.TextRange assemblyNameRange, JetBrains.Util.TextRange assemblyFullNameRange);
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference CreateNamespaceReference(JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier);
        public abstract TR CreatePointerTypeReference(TR elementType);
        public abstract TR CreateReferenceTypeReference(TR reference);
        public abstract TR CreateTypeReference(JetBrains.Util.TextRange nameRange, TR[] genericArguments, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier);
        public abstract TR CreateUnresolvedTypeReference(string typeName, JetBrains.Util.TextRange typeNameRange);
        protected virtual JetBrains.ReSharper.Psi.TreeTextRange GetSourceRange(JetBrains.Util.TextRange resultRange) { }
    }
    public class ResxTreeBuilder : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder
    {
        public ResxTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Impl
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ReswProjectFileType))]
    public class ReswProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public ReswProjectFileLanguageService(JetBrains.ProjectModel.ReswProjectFileType reswProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public class ResxCodeFormatter : JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter
    {
        public ResxCodeFormatter(JetBrains.ReSharper.Psi.Resx.ResxLanguage language, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.Indenting.XmlIndentingInfoProvider indentingInfoProvider) { }
        protected override JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlCodeFormattingSettings GetFormattingSettings(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalFormatSettings) { }
    }
    public sealed class ResxElementFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlElementFactory<JetBrains.ReSharper.Psi.Resx.ResxLanguage>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagDeclaration CreateDataTag([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] string comment = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType type = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Impl.ResxElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool applyFormatter = True) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Impl.ResxElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool applyFormatter = True) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public class ResxElementTypes : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes
    {
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ASSEMBLY_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ASSEMBLY_TAG_ALIAS_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ASSEMBLY_TAG_NAME_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_COMMENT_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_TAG_MIMETYPE_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_TAG_NAME_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_TAG_TYPE_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_VALUE_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType METADATA_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType METADATA_TAG_MIMETYPE_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType METADATA_TAG_NAME_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType METADATA_TAG_TYPE_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType METADATA_VALUE_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESHEADER_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESHEADER_TAG_NAME_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESHEADER_VALUE_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ROOT_TAG;
        public ResxElementTypes(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public class ResxLanguageSupport : JetBrains.ReSharper.Psi.Xml.XmlLanguageSupport
    {
        public override JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        public override bool IsFormattingAllowed(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResxProjectFileType))]
    public class ResxProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public ResxProjectFileLanguageService(JetBrains.ProjectModel.ResxProjectFileType resxProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public sealed class ResxTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeNodeFactory
    {
        public ResxTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.ResxLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.Impl.ResxElementTypes elementTypes) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile() { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Impl.Tree.References
{
    
    public class AssemblyOrAliasReferenceInsideTag<TOwner> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.AssemblyReferenceInsideTag<TOwner>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IAssemblyAliasReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public AssemblyOrAliasReferenceInsideTag(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange) { }
        public AssemblyOrAliasReferenceInsideTag(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange, JetBrains.ReSharper.Psi.TreeTextRange fullNameWithinRange) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule ResolvePsiModule() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class AssemblyOrAliasWithTokenReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.AssemblyReferenceWithToken<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IAssemblyAliasReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken
    {
        public AssemblyOrAliasWithTokenReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange) { }
        public AssemblyOrAliasWithTokenReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange, JetBrains.ReSharper.Psi.TreeTextRange fullNameWithinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule ResolvePsiModule() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class AssemblyReferenceInsideTag<TOwner> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceInsideTagBase<TOwner>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IAssemblyReference, JetBrains.ReSharper.Psi.Resx.Tree.ISkippedReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public AssemblyReferenceInsideTag(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange) { }
        public AssemblyReferenceInsideTag(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange, JetBrains.ReSharper.Psi.TreeTextRange fullNameWithinRange) { }
        protected override bool CaseSensitive { get; }
        public bool Resolved { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public void MarkAsSkipped(bool ignorable) { }
        public virtual JetBrains.ReSharper.Psi.Modules.IPsiModule ResolvePsiModule() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class AssemblyReferenceWithToken<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IAssemblyReference, JetBrains.ReSharper.Psi.Resx.Tree.ISkippedReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken
    {
        public AssemblyReferenceWithToken(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange) { }
        public AssemblyReferenceWithToken(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange nameWithinRange, JetBrains.ReSharper.Psi.TreeTextRange fullNameWithinRange) { }
        public override bool CaseSensitive { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public void MarkAsSkipped(bool ignorable) { }
        public virtual JetBrains.ReSharper.Psi.Modules.IPsiModule ResolvePsiModule() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public interface IReferenceInsideTag<T> : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where T : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<T> TagRange { get; set; }
    }
    public class static ModuleConverter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.IModule ConvertToModule([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
    }
    public class NamespaceReferenceInsideTag<TOwner> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceInsideTagBase<TOwner>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.INamespaceReference, JetBrains.ReSharper.Psi.Resx.Tree.ISkippedReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public NamespaceReferenceInsideTag(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public NamespaceReferenceInsideTag(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public bool Resolved { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public void MarkAsSkipped(bool ignorable) { }
    }
    public class NamespaceReferenceWithToken<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.INamespaceReference, JetBrains.ReSharper.Psi.Resx.Tree.ISkippedReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public NamespaceReferenceWithToken(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public NamespaceReferenceWithToken(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override bool AllowedNotResolved { get; }
        public override bool IsQualified { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public void MarkAsSkipped(bool ignorable) { }
    }
    public abstract class QualifiableReferenceInsideTagBase<TOwner> : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.QualifiableCheckedReferenceBase<TOwner>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<TOwner>, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        protected QualifiableReferenceInsideTagBase(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected virtual bool AllowedNotResolved { get; set; }
        protected virtual bool CaseSensitive { get; }
        public override bool IsQualified { get; }
        protected System.StringComparison StringComparison { get; }
        public JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<TOwner> TagRange { get; set; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        protected JetBrains.ReSharper.Psi.Resolve.IReference SetNewText(string newText) { }
    }
    public abstract class QualifiableReferenceWithTokenBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Impl.Shared.References.QualifiableReferenceWithinElement<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected QualifiableReferenceWithTokenBase(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected QualifiableReferenceWithTokenBase(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<TToken> ElementRange { get; set; }
        protected static TToken CreateNewToken(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken oldToken, JetBrains.Text.IBuffer buffer) { }
        protected virtual string GetElementText() { }
        public string GetXmlText(string text) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class ReferenceInsideTagBase<TOwner> : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.CheckedReferenceBase<TOwner>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<TOwner>, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        protected ReferenceInsideTagBase(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected virtual bool AllowedNotResolved { get; set; }
        protected virtual bool CaseSensitive { get; }
        protected System.StringComparison StringComparison { get; }
        public JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<TOwner> TagRange { get; set; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
        protected JetBrains.ReSharper.Psi.Resolve.IReference SetNewText(string newText) { }
    }
    public class static ReferenceInsideTagUtil<T>
        where T : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public static void AddRestoreTransactionAction(JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<T> referenceWithToken, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<T> oldRange) { }
        public static JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<T> ResetReferences(T element, JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<T> newTagRange, System.Predicate<JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<T>> predicate) { }
        public static JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<T> SetText(JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.IReferenceInsideTag<T> reference, string newText) { }
        public static JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<T> SetText(JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.XmlTagRange<T> tagRange, string newText) { }
    }
    public abstract class ReferenceWithTokenBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Impl.Shared.References.ReferenceWithinElementBase<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected ReferenceWithTokenBase(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<TToken> ElementRange { get; set; }
        protected static TToken CreateNewToken(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken oldToken, JetBrains.Text.IBuffer buffer) { }
        protected virtual string GetElementText() { }
        public string GetXmlText(string text) { }
    }
    public class XmlTagRange<TOwner>
        where TOwner : JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag
    {
        public XmlTagRange(TOwner owner, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public TOwner Tag { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange WithinRange { get; }
        public string GetText() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.ResourceDefaultLanguage
{
    
    public class static ResourceDefaultLanguageProperty
    {
        public const string DefaultValue = "en-US";
        public const string PropertName = "ResourceDefaultLanguageProperty";
        public static string ExtractLanguage(System.Xml.XmlDocument document) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetDefaultResourceLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Resources
{
    
    public sealed class PsiResxThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 9, "ResxAssembly")]
        public sealed class ResxAssembly : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 6, "ResxBlobValue")]
        public sealed class ResxBlobValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 10, "ResxData")]
        public sealed class ResxData : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 4, "ResxDataComment")]
        public sealed class ResxDataComment : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 8, "ResxFile")]
        public sealed class ResxFile : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 5, "ResxFileRefValue")]
        public sealed class ResxFileRefValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 0, "ResxHeader")]
        public sealed class ResxHeader : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 1, "ResxMetadata")]
        public sealed class ResxMetadata : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 7, "ResxRoot")]
        public sealed class ResxRoot : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 3, "ResxStringFormatValue")]
        public sealed class ResxStringFormatValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Resx;component/resources/PsiResxThemedIcons/ThemedIcons.P" +
            "siResx.Generated.Xaml", 2, "ResxStringValue")]
        public sealed class ResxStringValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Resx
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("RESX")]
    public class ResxLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resx.ResxLanguage Instance;
        public const string Name = "RESX";
        protected ResxLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected ResxLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    public abstract class ResxLanguageService : JetBrains.ReSharper.Psi.Xml.XmlLanguageService
    {
        protected ResxLanguageService(JetBrains.ReSharper.Psi.Resx.ResxLanguage languageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Resx.Impl.ResxCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DeclaredElementPresenter { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IReferenceContextCodec CreateReferenceContextCodec() { }
        public override bool IsTypeMemberVisible(JetBrains.ReSharper.Psi.ITypeMember member) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Tree
{
    
    public interface IAssemblyAliasReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IAssemblyReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IPsiModule ResolvePsiModule();
    }
    public interface INamespaceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.ISkippedReference, JetBrains.Util.IUserDataHolder { }
    public interface IResourceFileReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles();
    }
    public interface IResourceItemReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string GetDefaultName();
    }
    public interface IResourceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles();
    }
    public interface IResxAssemblyTag : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaredElement { }
    public interface IResxAssemblyTagAliasAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxAssemblyTagDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Alias { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxAssemblyTagAliasAttribute AliasAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxAssemblyTagNameAttribute NameAttribute { get; }
    }
    public interface IResxAssemblyTagNameAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxDataCommentTag : JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxDataTag : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaredElement
    {
        bool IsLinkedFileValue { get; }
        bool IsStringValue { get; }
        JetBrains.ReSharper.Psi.IType Type { get; }
        JetBrains.ReSharper.Psi.IType ValueType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IPathDeclaredElement GetLinkedFile();
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetStringValue();
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetValueText();
    }
    public interface IResxDataTagDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDataCommentTag Comment { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTag DeclaredElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagMimetypeAttribute MimetypeAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagNameAttribute NameAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagTypeAttribute TypeAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag Value { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType ValueType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IPathDeclaredElement GetLinkedFile();
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetStringValue();
        bool IsLinkedFileValue();
        bool IsStringValue();
    }
    public interface IResxDataTagMimetypeAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxDataTagNameAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxDataTagTypeAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Resx.Tree.IResxTypeReference, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxDataValueTag : JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType Type { get; }
    }
    public interface IResxDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaredElement DeclaredElement { get; }
    }
    public interface IResxDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IResxFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resx.Tree.IResxAssemblyTagDeclaration> GetAssemblyAlias([JetBrains.Annotations.NotNullAttribute()] string alias);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.OneToListMap<string, JetBrains.ReSharper.Psi.Resx.Tree.IResxAssemblyTagDeclaration> GetAssemblyAliasesByName();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.Tree.IResxAssemblyTagDeclaration> GetAssemblyTags();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagDeclaration> GetDataTags();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.Tree.IResxDataTagDeclaration> GetDataTags([JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.Tree.IResxMetadataTagDeclaration> GetMetadataTags();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.Tree.IResxResheaderTagDeclaration> GetResheaderTags();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxRootTagDeclaration GetRootTag();
    }
    public interface IResxIdentifierAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.TreeTextRange GetNameRange();
        void SetName(string name);
    }
    public interface IResxMetadaTagMimetypeAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxMetadaTagNameAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxMetadaTagTypeAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxMetadataTagDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Resx.Tree.IResxMetadaTagMimetypeAttribute MimetypeAttribute { get; }
        JetBrains.ReSharper.Psi.Resx.Tree.IResxMetadaTagNameAttribute NameAttribute { get; }
        JetBrains.ReSharper.Psi.Resx.Tree.IResxMetadaTagTypeAttribute TypeAttribute { get; }
        JetBrains.ReSharper.Psi.Resx.Tree.IResxMetadaValueTag Value { get; }
    }
    public interface IResxMetadaValueTag : JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxResheaderTagDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.Tree.IResxResheaderTagNameAttribute NameAttribute { get; }
        JetBrains.ReSharper.Psi.Resx.Tree.IResxResheaderValueTag Value { get; }
    }
    public interface IResxResheaderTagNameAttribute : JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute, JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxResheaderValueTag : JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxRootTagDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxDeclaration, JetBrains.ReSharper.Psi.Resx.Tree.IResxTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IResxTypeReference
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType Type { get; }
    }
    public interface ISkippedReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        void MarkAsSkipped(bool ignorable);
    }
    public interface ITypeReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.ISkippedReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Resx.Tree.ITypeReference[] GenericArguments { get; }
        bool IsResultType { get; set; }
        int GetGenericArgumentsCount();
        JetBrains.ReSharper.Psi.IType GetReferencedType();
        string GetTypeName(bool onlyName);
    }
    public class ResxResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType RESOURCE_ITEM_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType RESOURCE_NOT_RESOLVED;
        protected ResxResolveErrorType(string name) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Utils
{
    
    public class static CodeDomUtils
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.CodeDom.Compiler.CodeDomProvider GetCodeDomProvider([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.CodeDom.Compiler.CodeDomProvider GetCodeDomProvider([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
    }
    public class static StringFormatUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string ConvertToString([JetBrains.Annotations.CanBeNullAttribute()] this object value) { }
        public static int GetMaxFormatArgsIndex([JetBrains.Annotations.CanBeNullAttribute()] this string value) { }
    }
    public class static TextRangesUtil
    {
        [System.ObsoleteAttribute("Dangerous! Use range translator")]
        public static JetBrains.Util.TextRange ToTextRange(this JetBrains.ReSharper.Psi.TreeTextRange range) { }
        [System.ObsoleteAttribute("Dangerous! Use range translator")]
        public static JetBrains.ReSharper.Psi.TreeTextRange ToTreeTextRange(this JetBrains.Util.TextRange range) { }
    }
    public class static XmlAttributeUtil
    {
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute, out JetBrains.Util.RangeTranslator translator) { }
        public static void GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute, System.Text.StringBuilder builder, JetBrains.Util.RangeTranslator translator = null) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetValueRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetValueRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute xmlAttribute, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
    }
    public class static XmlElementUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode xmlElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode xmlElement, out JetBrains.Util.RangeTranslator translator) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetValueRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode xmlElement) { }
    }
    public class static XmlTagUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, out JetBrains.Util.RangeTranslator translator) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetValueRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetValueRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetValueWithinRange([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
    }
}