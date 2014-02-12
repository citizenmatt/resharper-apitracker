[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.JavaScript.WinRT.Impl.Finder
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JsWinRTSourceFileFilterForDeclaredElementSearch : JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.ISourceFileFilterForDeclaredElementSearch
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.FilterResult Filter(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IPsiSourceFile file, System.Type language) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.WinRT.LanguageImpl
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JavaScriptWinRTDeclaredElementPresenter : JetBrains.ReSharper.Psi.IDeclaredElementPresenter
    {
        public static JetBrains.ReSharper.Psi.JavaScript.WinRT.LanguageImpl.JavaScriptWinRTDeclaredElementPresenter Instance { get; }
        public string Format(JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle style, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        public string Format(JetBrains.ReSharper.Psi.ParameterKind parameterKind) { }
        public string Format(JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        public static JetBrains.ReSharper.Psi.IDeclaredType InterfaceQualification(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public static bool IsDestructor(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static bool IsParameterlessProperty(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static JetBrains.ReSharper.Psi.DefaultValue Normalize(JetBrains.ReSharper.Psi.DefaultValue value) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("JAVA_SCRIPT_WINRT")]
    public class JavaScriptWinRTLanguage : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.JavaScript.WinRT.LanguageImpl.JavaScriptWinRTLanguage Instance;
        public const string Name = "JAVA_SCRIPT_WINRT";
        protected JavaScriptWinRTLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected JavaScriptWinRTLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.WinRT.LanguageImpl.JavaScriptWinRTLanguage))]
    public class JavaScriptWinRTLanguageService : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguageService
    {
        public JavaScriptWinRTLanguageService(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage language, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache listCache) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DeclaredElementPresenter { get; }
        public override bool FullResolveForDynamicReferences { get; }
        public override bool SmartCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class JavaScriptWinRTProjectFileLanguageService : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.IJavaScriptDialectProvider
    {
        public JetBrains.ReSharper.Psi.PsiLanguageType GetDialectLanguage(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve
{
    
    public interface IClrJavaScriptType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExternalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IClrDeclaredElement ClrDeclaredElement { get; }
    }
    public interface IJavaScriptOverloadableFunctionSignature : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature { }
    public interface ISdkPathReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.References.IPathQualifier, JetBrains.Util.IUserDataHolder { }
    public class static JavaScriptSymbolTableHelper
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElements(this JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class JavaScriptWinRTGlobalSymbolProvider : JetBrains.ReSharper.Psi.JavaScript.Impl.Caches.IJavaScriptSymbolProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExternalPrimitiveType> GetSymbols(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JavaScriptWinRTSymbolInfoProvider : JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.IJavaScriptSymbolInfoProvider
    {
        public bool CanBeFunction(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetJsType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType GetPrimitiveType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public string GetShortName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static string GetShortNameForDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool HasDynamicName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsProperty(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class static JavaScriptWinRTTypeFactory
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] InstanceMembersFilters;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] NamespaceAndTypeElementFilters;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] StaticMembersFilters;
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType ConvertClrMethodReturnTypeToJavaScript(JetBrains.ReSharper.Psi.IParametersOwner method, JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType ConvertClrTypeToJavaScript(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> ConvertJavaScriptTypeToClrTypes(JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType type, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> GetClrTypes(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IConstructor> GetConstructors(JetBrains.ReSharper.Psi.ITypeElement winRTTypeElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ProjectName([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    public class JsTypeForWinRTArray : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTTypeBase
    {
        public JsTypeForWinRTArray(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType elementType) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public override string GetAnyName() { }
        public override string GetPresentableName() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public abstract class JsTypeForWinRTBase : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExternalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.IClrJavaScriptType
    {
        protected JsTypeForWinRTBase(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public abstract JetBrains.ReSharper.Psi.IClrDeclaredElement ClrDeclaredElement { get; }
        protected JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext Context { get; }
        protected void DoExpand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context) { }
        public void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public abstract string GetAnyName();
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public string GetName() { }
        public abstract string GetPresentableName();
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable();
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public virtual System.Xml.XmlNode GetXmlDoc(bool inherit) { }
        public virtual bool IsFunction() { }
        public virtual void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public abstract class JsTypeForWinRTElementBase : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTBase
    {
        protected JsTypeForWinRTElementBase(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override string GetAnyName() { }
        public override System.Xml.XmlNode GetXmlDoc(bool inherit) { }
    }
    public class JsTypeForWinRTNamespace : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTElementBase
    {
        public JsTypeForWinRTNamespace(JetBrains.ReSharper.Psi.INamespace ns, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override JetBrains.ReSharper.Psi.IClrDeclaredElement ClrDeclaredElement { get; }
        public override string GetPresentableName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
    }
    public class JsTypeForWinRTType : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTTypeBase
    {
        public JsTypeForWinRTType(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
    }
    public abstract class JsTypeForWinRTTypeBase : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTBase, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        protected JsTypeForWinRTTypeBase(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IType type) { }
        public override JetBrains.ReSharper.Psi.IClrDeclaredElement ClrDeclaredElement { get; }
        public virtual JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public override string GetAnyName() { }
        public override string GetPresentableName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable() { }
    }
    public class JsTypeForWinRTTypeElement : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTElementBase, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        public JsTypeForWinRTTypeElement(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override JetBrains.ReSharper.Psi.IClrDeclaredElement ClrDeclaredElement { get; }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public override string GetPresentableName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public override bool IsFunction() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public class JsTypeWithPropertyList : JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.JsTypeForWinRTBase
    {
        public JsTypeWithPropertyList(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> properties, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name) { }
        public override JetBrains.ReSharper.Psi.IClrDeclaredElement ClrDeclaredElement { get; }
        public override string GetAnyName() { }
        public override string GetPresentableName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetPropertiesSymbolTable() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.WinRT
{
    
    public class static Util
    {
        public static bool IsClrJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType javaScriptType) { }
        public static bool IsClrJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType javaScriptType, out JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.IClrJavaScriptType clrJavaScriptType) { }
    }
}