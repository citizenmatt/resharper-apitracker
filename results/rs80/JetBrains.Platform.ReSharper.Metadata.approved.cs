[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Metadata.Access
{
    
    public struct AssemblyReference
    {
        public AssemblyReference(JetBrains.Metadata.Access.MetadataToken assemblyReferenceToken, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        public JetBrains.Metadata.Access.MetadataToken AssemblyReferenceToken { get; }
    }
    public class ClassLayout
    {
        public static readonly JetBrains.Metadata.Access.ClassLayout Empty;
        public ClassLayout(int packingSize, int classSize, System.Collections.Generic.IDictionary<JetBrains.Metadata.Access.MetadataToken, int> fieldOffsets) { }
        public int ClassSize { get; }
        public JetBrains.Util.ReadOnlyDictionary<JetBrains.Metadata.Access.MetadataToken, int> FieldOffsets { get; }
        public int PackingSize { get; }
    }
    [System.FlagsAttribute()]
    public enum CorEventAttr
    {
        evSpecialName = 512,
        evReservedMask = 1024,
        evRTSpecialName = 1024,
    }
    [System.FlagsAttribute()]
    public enum CorFieldAttr
    {
        fdFieldAccessMask = 7,
        fdPrivateScope = 0,
        fdPrivate = 1,
        fdFamANDAssem = 2,
        fdAssembly = 3,
        fdFamily = 4,
        fdFamORAssem = 5,
        fdPublic = 6,
        fdStatic = 16,
        fdInitOnly = 32,
        fdLiteral = 64,
        fdNotSerialized = 128,
        fdSpecialName = 512,
        fdPinvokeImpl = 8192,
        fdReservedMask = 38144,
        fdRTSpecialName = 1024,
        fdHasFieldMarshal = 4096,
        fdHasDefault = 32768,
        fdHasFieldRVA = 256,
    }
    [System.FlagsAttribute()]
    public enum CorFileFlags
    {
        ffContainsMetaData = 0,
        ffContainsNoMetaData = 1,
    }
    [System.FlagsAttribute()]
    public enum CorGenericParamAttr
    {
        gpVarianceMask = 3,
        gpNonVariant = 0,
        gpCovariant = 1,
        gpContravariant = 2,
        gpSpecialConstraintMask = 28,
        gpNoSpecialConstraint = 0,
        gpReferenceTypeConstraint = 4,
        gpValueTypeConstraint = 8,
        gpDefaultConstructorConstraint = 16,
    }
    [System.FlagsAttribute()]
    public enum CorMethodAttr
    {
        mdMemberAccessMask = 7,
        mdPrivateScope = 0,
        mdPrivate = 1,
        mdFamANDAssem = 2,
        mdAssem = 3,
        mdFamily = 4,
        mdFamORAssem = 5,
        mdPublic = 6,
        mdStatic = 16,
        mdFinal = 32,
        mdVirtual = 64,
        mdHideBySig = 128,
        mdVtableLayoutMask = 256,
        mdReuseSlot = 0,
        mdNewSlot = 256,
        mdCheckAccessOnOverride = 512,
        mdAbstract = 1024,
        mdSpecialName = 2048,
        mdPinvokeImpl = 8192,
        mdUnmanagedExport = 8,
        mdReservedMask = 53248,
        mdRTSpecialName = 4096,
        mdHasSecurity = 16384,
        mdRequireSecObject = 32768,
    }
    [System.FlagsAttribute()]
    public enum CorMethodImpl
    {
        miCodeTypeMask = 3,
        miIL = 0,
        miNative = 1,
        miOPTIL = 2,
        miRuntime = 3,
        miManagedMask = 4,
        miUnmanaged = 4,
        miManaged = 0,
        miForwardRef = 16,
        miPreserveSig = 128,
        miInternalCall = 4096,
        miSynchronized = 32,
        miNoOptimization = 64,
        miNoInlining = 8,
        miMaxMethodImplVal = 65535,
    }
    [System.FlagsAttribute()]
    public enum CorMethodSemanticsAttr
    {
        msSetter = 1,
        msGetter = 2,
        msOther = 4,
        msAddOn = 8,
        msRemoveOn = 16,
        msFire = 32,
    }
    [System.FlagsAttribute()]
    public enum CorOpenFlags : uint
    {
        ofRead = 0u,
        ofWrite = 1u,
        ofReadWriteMask = 1u,
        ofCopyMemory = 2u,
        ofManifestMetadata = 8u,
        ofReadOnly = 16u,
        ofTakeOwnership = 32u,
        ofCacheImage = 4u,
        ofNoTypeLib = 128u,
        ofReserved1 = 256u,
        ofReserved2 = 512u,
        ofReserved = 4294967104u,
    }
    [System.FlagsAttribute()]
    public enum CorParamAttr
    {
        pdIn = 1,
        pdOut = 2,
        pdOptional = 16,
        pdReservedMask = 61440,
        pdHasDefault = 4096,
        pdHasFieldMarshal = 8192,
        pdUnused = 53216,
    }
    [System.FlagsAttribute()]
    public enum CorPInvokeMap
    {
        pmNoMangle = 1,
        pmCharSetMask = 6,
        pmCharSetNotSpec = 0,
        pmCharSetAnsi = 2,
        pmCharSetUnicode = 4,
        pmCharSetAuto = 6,
        pmBestFitUseAssem = 0,
        pmBestFitEnabled = 16,
        pmBestFitDisabled = 32,
        pmBestFitMask = 48,
        pmThrowOnUnmappableCharUseAssem = 0,
        pmThrowOnUnmappableCharEnabled = 4096,
        pmThrowOnUnmappableCharDisabled = 8192,
        pmThrowOnUnmappableCharMask = 12288,
        pmSupportsLastError = 64,
        pmCallConvMask = 1792,
        pmCallConvWinapi = 256,
        pmCallConvCdecl = 512,
        pmCallConvStdcall = 768,
        pmCallConvThiscall = 1024,
        pmCallConvFastcall = 1280,
        pmMaxValue = 65535,
    }
    [System.FlagsAttribute()]
    public enum CorPropertyAttr
    {
        prSpecialName = 512,
        prReservedMask = 62464,
        prRTSpecialName = 1024,
        prHasDefault = 4096,
        prUnused = 59903,
    }
    [System.FlagsAttribute()]
    public enum CorThreadSafetyOptions
    {
        MDThreadSafetyDefault = 0,
        MDThreadSafetyOff = 0,
        MDThreadSafetyOn = 1,
    }
    [System.FlagsAttribute()]
    public enum CorTypeAttr
    {
        tdVisibilityMask = 7,
        tdNestedMask = 6,
        tdNotPublic = 0,
        tdPublic = 1,
        tdNestedPublic = 2,
        tdNestedPrivate = 3,
        tdNestedFamily = 4,
        tdNestedAssembly = 5,
        tdNestedFamANDAssem = 6,
        tdNestedFamORAssem = 7,
        tdLayoutMask = 24,
        tdAutoLayout = 0,
        tdSequentialLayout = 8,
        tdExplicitLayout = 16,
        tdClassSemanticsMask = 32,
        tdClass = 0,
        tdInterface = 32,
        tdAbstract = 128,
        tdSealed = 256,
        tdSpecialName = 1024,
        tdImport = 4096,
        tdSerializable = 8192,
        tdWindowsRuntime = 16384,
        tdStringFormatMask = 196608,
        tdAnsiClass = 0,
        tdUnicodeClass = 65536,
        tdAutoClass = 131072,
        tdBeforeFieldInit = 1048576,
        tdForwarder = 2097152,
        tdReservedMask = 264192,
        tdRTSpecialName = 2048,
        tdHasSecurity = 262144,
    }
    public struct CustomAttributeProperties
    {
        public CustomAttributeProperties(JetBrains.Metadata.Access.MetadataToken parentToken, JetBrains.Metadata.Access.MetadataToken typeToken, JetBrains.Metadata.Utils.IBlob value) { }
        public JetBrains.Metadata.Access.MetadataToken ParentToken { get; }
        public JetBrains.Metadata.Access.MetadataToken TypeToken { get; }
        public JetBrains.Metadata.Utils.IBlob Value { get; }
    }
    public struct DeclSecurityProperties
    {
        public DeclSecurityProperties(ushort action, JetBrains.Metadata.Utils.IBlob permissionSetBlob) { }
        public ushort Action { get; }
        public JetBrains.Metadata.Utils.IBlob PermissionSetBlob { get; }
    }
    public struct EventProperties
    {
        public EventProperties(string name, JetBrains.Metadata.Access.MetadataToken declaringTypeToken, JetBrains.Metadata.Access.CorEventAttr eventFlags, JetBrains.Metadata.Access.MetadataToken eventType, JetBrains.Metadata.Access.MetadataToken adder, JetBrains.Metadata.Access.MetadataToken remover, JetBrains.Metadata.Access.MetadataToken raiser, JetBrains.Metadata.Access.MetadataToken[] otherMethods) { }
        public JetBrains.Metadata.Access.MetadataToken Adder { get; }
        public JetBrains.Metadata.Access.MetadataToken DeclaringTypeToken { get; }
        public JetBrains.Metadata.Access.CorEventAttr EventFlags { get; }
        public JetBrains.Metadata.Access.MetadataToken EventType { get; }
        public string Name { get; }
        public JetBrains.Metadata.Access.MetadataToken[] OtherMethods { get; }
        public JetBrains.Metadata.Access.MetadataToken Raiser { get; }
        public JetBrains.Metadata.Access.MetadataToken Remover { get; }
    }
    public struct ExportedTypeProperty
    {
        public ExportedTypeProperty(JetBrains.Metadata.Access.MetadataToken token, string clrName, JetBrains.Metadata.Access.MetadataToken implementation, JetBrains.Metadata.Access.MetadataToken typeDef, JetBrains.Metadata.Access.CorTypeAttr exportedTypeFlags) { }
        public string ClrName { get; }
        public JetBrains.Metadata.Access.CorTypeAttr ExportedTypeFlags { get; }
        public JetBrains.Metadata.Access.MetadataToken Implementation { get; }
        public JetBrains.Metadata.Access.MetadataToken Token { get; }
        public JetBrains.Metadata.Access.MetadataToken TypeDef { get; }
    }
    public struct FieldProperties
    {
        public FieldProperties(string name, JetBrains.Metadata.Access.MetadataToken declaringTypeToken, JetBrains.Metadata.Access.CorFieldAttr fieldFlags, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.IBlob signatureBlob, JetBrains.Metadata.Reader.API.ElementType constantValueElementType, JetBrains.Metadata.Utils.IBlob value, int valueChars, uint rva) { }
        public JetBrains.Metadata.Reader.API.ElementType ConstantValueElementType { get; }
        public JetBrains.Metadata.Access.MetadataToken DeclaringTypeToken { get; }
        public JetBrains.Metadata.Access.CorFieldAttr FieldFlags { get; }
        public string Name { get; }
        public uint Rva { get; }
        public JetBrains.Metadata.Utils.IBlob SignatureBlob { get; }
        public JetBrains.Metadata.Utils.IBlob Value { get; }
        public int ValueLength { get; }
    }
    public struct FileReference
    {
        public FileReference(string name, JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Access.CorFileFlags fileFlags) { }
        public JetBrains.Metadata.Access.CorFileFlags FileFlags { get; }
        public string Name { get; }
        public JetBrains.Metadata.Access.MetadataToken Token { get; }
    }
    public struct GenericParamProperties
    {
        public GenericParamProperties(string name, uint paramIndex, JetBrains.Metadata.Access.MetadataToken ownerToken, JetBrains.Metadata.Access.CorGenericParamAttr attributes, JetBrains.Metadata.Access.MetadataToken[] constraints) { }
        public JetBrains.Metadata.Access.MetadataToken[] Constraints { get; }
        public JetBrains.Metadata.Access.CorGenericParamAttr GenericParamAttributes { get; }
        public string Name { get; }
        public JetBrains.Metadata.Access.MetadataToken OwnerToken { get; }
        public uint ParamIndex { get; }
    }
    public interface IMetadataAccess
    {
        JetBrains.Metadata.Access.IMetadataProvider MetadataProvider { get; }
        System.Guid Mvid { get; }
        JetBrains.Util.OneToSetMap<JetBrains.Metadata.Access.MetadataToken, JetBrains.Metadata.Access.MetadataToken> NestedTypeMap { get; }
        JetBrains.Metadata.Access.TargetPlatform TargetPlatform { get; }
        JetBrains.Util.ReadOnlyDictionary<string, JetBrains.Metadata.Access.MetadataToken> TypeName2TokenMapping { get; }
        JetBrains.Metadata.Access.MetadataToken[] FindMemberRefs(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.MetadataToken[] FindMethodSpecs(JetBrains.Metadata.Access.MetadataToken methodDefOrRef);
        JetBrains.Metadata.Access.MetadataToken FindTypeRef(JetBrains.Metadata.Access.MetadataToken resolutionScope, string qualifiedName);
        JetBrains.Metadata.Access.IMetadataAssemblyInfo GetAssemblyInfo();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Access.ClassLayout GetClassLayout(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.CustomAttributeProperties GetCustomAttributeProperties(JetBrains.Metadata.Access.MetadataToken customAttributeToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetCustomAttributes(JetBrains.Metadata.Access.MetadataToken ownerToken);
        JetBrains.Metadata.Reader.API.MetadataTypeReference GetCustomAttributeTypeName(JetBrains.Metadata.Access.MetadataToken customAttributeToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetDeclSecurity(JetBrains.Metadata.Access.MetadataToken owner);
        JetBrains.Metadata.Access.DeclSecurityProperties GetDeclSecurityProperties(JetBrains.Metadata.Access.MetadataToken token);
        string[] GetDeclSecurityTypeNames(JetBrains.Metadata.Access.MetadataToken token);
        long GetEmbeddedResourceOffset(long resourceOffset);
        JetBrains.Metadata.Access.MetadataToken GetEnclosingType(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.EventProperties GetEventProperties(JetBrains.Metadata.Access.MetadataToken eventToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetEvents(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.FieldProperties GetFieldProperties(JetBrains.Metadata.Access.MetadataToken fieldToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetFields(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetFields();
        JetBrains.Metadata.Access.MetadataTokenRange GetGenericParameters(JetBrains.Metadata.Access.MetadataToken ownerToken);
        JetBrains.Metadata.Access.GenericParamProperties GetGenericParamProperties(JetBrains.Metadata.Access.MetadataToken gpToken);
        JetBrains.Metadata.Access.MetadataToken[] GetInterfaceImplementations(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.ManifestResourceProperties GetManifestResourceProperties(JetBrains.Metadata.Access.MetadataToken manifestResourceToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetManifestResources();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.IBlob GetMarshalSpec(JetBrains.Metadata.Access.MetadataToken token);
        string GetMemberName(JetBrains.Metadata.Access.MetadataToken memberToken);
        JetBrains.Metadata.Access.MemberReferenceProperties GetMemberReferenceProperties(JetBrains.Metadata.Access.MetadataToken memberReferenceToken);
        JetBrains.Metadata.Access.MethodImplementationProperties[] GetMethodImplementationProperties(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.MethodProperties GetMethodProperties(JetBrains.Metadata.Access.MetadataToken methodToken);
        JetBrains.Util.ReadOnlyList<uint> GetMethodRvaMap();
        JetBrains.Metadata.Access.MetadataTokenRange GetMethods(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetMethods();
        JetBrains.Metadata.Access.MethodSpecProperties GetMethodSpecProperties(JetBrains.Metadata.Access.MetadataToken methodSpec);
        JetBrains.Metadata.Access.MetadataTokenRange GetMethodSpecs();
        string GetModuleRefProperties(JetBrains.Metadata.Access.MetadataToken token);
        JetBrains.Metadata.Access.MetadataTokenRange GetModuleRefs();
        JetBrains.Metadata.Access.MetadataToken GetParameterByIndex(JetBrains.Metadata.Access.MetadataToken methodToken, uint paramIndex);
        JetBrains.Metadata.Access.ParamProperties GetParameterProperties(JetBrains.Metadata.Access.MetadataToken paramToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetParameters(JetBrains.Metadata.Access.MetadataToken methodToken);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Access.PInvokeProperties GetPInvokeProperties(JetBrains.Metadata.Access.MetadataToken methodToken);
        JetBrains.Metadata.Access.MetadataTokenRange GetProperties(JetBrains.Metadata.Access.MetadataToken typeToken);
        JetBrains.Metadata.Access.PropertyProperties GetPropertyProperties(JetBrains.Metadata.Access.MetadataToken propertyToken);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Utils.IBlob GetStandaloneSignatureBlob(JetBrains.Metadata.Access.MetadataToken standaloneSig);
        JetBrains.Metadata.Access.MetadataTokenRange GetStandaloneSigs();
        JetBrains.Metadata.Access.TypeDefProperties GetTypeDefProperties(JetBrains.Metadata.Access.MetadataToken typeDef);
        JetBrains.Metadata.Access.MetadataTokenRange GetTypeDefs();
        JetBrains.Metadata.Access.TypeRefProperties GetTypeRefProperties(JetBrains.Metadata.Access.MetadataToken typeRef);
        JetBrains.Metadata.Access.MetadataTokenRange GetTypeRefs();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Utils.IBlob GetTypeSpecBlob(JetBrains.Metadata.Access.MetadataToken typeSpec);
        JetBrains.Metadata.Access.MetadataTokenRange GetTypeSpecs();
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetUserstring(JetBrains.Metadata.Access.MetadataToken pointer);
    }
    public interface IMetadataAssemblyInfo
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyName();
        JetBrains.Metadata.Access.ExportedTypeProperty[] GetExportedTypes();
        System.Collections.Generic.Dictionary<JetBrains.Metadata.Access.MetadataToken, JetBrains.Metadata.Access.AssemblyReference> GetReferencedAssembliesNames();
        JetBrains.Metadata.Access.FileReference[] GetReferencedFiles();
        JetBrains.Metadata.Access.MetadataToken GetToken();
    }
    public interface IMetadataProvider
    {
        void DisposeMetadataAccess([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Access.IMetadataAccess access);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Access.IMetadataAccess GetFromFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Access.IMetadataAccess TryGetFromFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Access.IMetadataAccess TryGetFromMemory([JetBrains.Annotations.NotNullAttribute()] byte[] data);
    }
    [System.FlagsAttribute()]
    public enum ManifestResourceAttributes : uint
    {
        Public = 1u,
        Private = 2u,
        VisibilityMask = 7u,
    }
    public struct ManifestResourceProperties
    {
        public ManifestResourceProperties(uint offset, string name, JetBrains.Metadata.Access.ManifestResourceAttributes flags, JetBrains.Metadata.Access.MetadataToken implementation) { }
        public JetBrains.Metadata.Access.ManifestResourceAttributes Flags { get; }
        public JetBrains.Metadata.Access.MetadataToken Implementation { get; }
        public string Name { get; }
        public uint Offset { get; }
    }
    public struct MemberProperties
    {
        public MemberProperties([JetBrains.Annotations.NotNullAttribute()] string name, int attributes) { }
        public int Attributes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
    }
    public struct MemberReferenceProperties
    {
        public MemberReferenceProperties(JetBrains.Metadata.Access.MetadataToken ownerToken, string name, JetBrains.Metadata.Utils.IBlob signatureBlob) { }
        public string Name { get; }
        public JetBrains.Metadata.Access.MetadataToken OwnerToken { get; }
        public JetBrains.Metadata.Utils.IBlob SignatureBlob { get; }
    }
    public class MetadataAccessCookie : System.IDisposable
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Access.IMetadataAccess MetadataAccess { get; }
        public void Dispose() { }
    }
    public class static MetadataProviderEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Access.MetadataAccessCookie GetFromFileDisposable([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Access.IMetadataProvider provider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
    }
    public class static MetadataProviderFactory
    {
        public static JetBrains.Metadata.Access.IMetadataProvider modreq(System.Runtime.CompilerServices.IsVolatile) DefaultProvider;
    }
    public enum MetadataTableId
    {
        Module = 0,
        TypeRef = 1,
        TypeDef = 2,
        FieldPointer = 3,
        FieldDef = 4,
        MethodPointer = 5,
        MethodDef = 6,
        ParamPointer = 7,
        Param = 8,
        InterfaceImpl = 9,
        MemberRef = 10,
        Constant = 11,
        CustomAttribute = 12,
        FieldMarshal = 13,
        DeclSecurity = 14,
        ClassLayout = 15,
        FieldLayout = 16,
        Signature = 17,
        EventMap = 18,
        EventPointer = 19,
        Event = 20,
        PropertyMap = 21,
        PropertyPointer = 22,
        Property = 23,
        MethodSemantics = 24,
        MethodImpl = 25,
        ModuleRef = 26,
        TypeSpec = 27,
        ImplMap = 28,
        FieldRva = 29,
        EncodingLog = 30,
        EncodingMap = 31,
        Assembly = 32,
        AssemblyProcessor = 33,
        AssemblyOS = 34,
        AssemblyRef = 35,
        AssemblyRefProcessor = 36,
        AssemblyRefOS = 37,
        File = 38,
        ExportedType = 39,
        ManifestResource = 40,
        NestedClass = 41,
        GenericParam = 42,
        MethodSpec = 43,
        GenericParamConstraint = 44,
        MaxTable = 44,
    }
    public struct MetadataToken
    {
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.Metadata.Access.MetadataToken> EqualityComparer;
        public static readonly JetBrains.Metadata.Access.MetadataToken Nil;
        public const uint RID_MASK = 16777215u;
        public const uint TT_ASSEMBLY = 536870912u;
        public const uint TT_ASSEMBLYREF = 587202560u;
        public const uint TT_CUSTOMATTRIBUTE = 201326592u;
        public const uint TT_EVENT = 335544320u;
        public const uint TT_EXPORTEDTYPE = 654311424u;
        public const uint TT_FIELDDEF = 67108864u;
        public const uint TT_FILE = 637534208u;
        public const uint TT_GENERICPARAM = 704643072u;
        public const uint TT_GENERICPARAMCONSTRAINT = 738197504u;
        public const uint TT_INTERFACEIMPL = 150994944u;
        public const uint TT_MANIFESTRESOURCE = 671088640u;
        public const uint TT_MEMBERREF = 167772160u;
        public const uint TT_METHODDEF = 100663296u;
        public const uint TT_METHODSPEC = 721420288u;
        public const uint TT_MODULE = 0u;
        public const uint TT_MODULEREF = 436207616u;
        public const uint TT_PARAMDEF = 134217728u;
        public const uint TT_PERMISSION = 234881024u;
        public const uint TT_PROPERTY = 385875968u;
        public const uint TT_STANDALONE_SIG = 285212672u;
        public const uint TT_TYPEDEF = 33554432u;
        public const uint TT_TYPEREF = 16777216u;
        public const uint TT_TYPESPEC = 452984832u;
        public const uint TYPE_MASK = 4278190080u;
        public MetadataToken(uint token) { }
        public MetadataToken(JetBrains.Metadata.Access.MetadataTableId tableId, int rid) { }
        public bool IsAssembly { get; }
        public bool IsAssemblyRef { get; }
        public bool IsCustomAttribute { get; }
        public bool IsEvent { get; }
        public bool IsExportedType { get; }
        public bool IsFieldDef { get; }
        public bool IsFile { get; }
        public bool IsGenericParam { get; }
        public bool IsGenericParamConstraint { get; }
        public bool IsInterfaceImpl { get; }
        public bool IsManifestResource { get; }
        public bool IsMemberRef { get; }
        public bool IsMethodDef { get; }
        public bool IsMethodSpec { get; }
        public bool IsModule { get; }
        public bool IsModuleRef { get; }
        public bool IsNil { get; }
        public bool IsParamDef { get; }
        public bool IsPermission { get; }
        public bool IsProperty { get; }
        public bool IsStandaloneSig { get; }
        public bool IsTypeDef { get; }
        public bool IsTypeRef { get; }
        public bool IsTypeSpec { get; }
        public uint RID { get; }
        public JetBrains.Metadata.Access.MetadataTableId TableId { get; }
        public uint Value { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsInRange(JetBrains.Metadata.Access.MetadataTokenRange range) { }
        public static JetBrains.Metadata.Access.MetadataToken MakeTypedNil(JetBrains.Metadata.Access.MetadataTableId table) { }
        public override string ToString() { }
        public class EqualityComparerImpl : System.Collections.Generic.IEqualityComparer<JetBrains.Metadata.Access.MetadataToken>
        {
            public bool Equals(JetBrains.Metadata.Access.MetadataToken x, JetBrains.Metadata.Access.MetadataToken y) { }
            public int GetHashCode(JetBrains.Metadata.Access.MetadataToken obj) { }
        }
    }
    public struct MetadataTokenRange
    {
        public static readonly JetBrains.Metadata.Access.MetadataTokenRange Empty;
        public MetadataTokenRange(JetBrains.Metadata.Access.MetadataTableId tableId, int startRid, int endRid) { }
        public int EndRid { get; }
        public int Length { get; }
        public int StartRid { get; }
        public JetBrains.Metadata.Access.MetadataTableId TableId { get; }
        public static JetBrains.Metadata.Access.MetadataTokenRange CreateEmptyRange(JetBrains.Metadata.Access.MetadataTableId tableId) { }
        public JetBrains.Metadata.Access.MetadataTokenRange.Enumerator GetEnumerator() { }
        public struct Enumerator
        {
            public JetBrains.Metadata.Access.MetadataToken Current { get; }
            public bool MoveNext() { }
        }
    }
    public enum MetadataTokenType
    {
        Module = 0,
        TypeRef = 1,
        TypeDef = 2,
        FieldPointer = 3,
        Field = 4,
        MethodPointer = 5,
        MethodDef = 6,
        ParamPointer = 7,
        Param = 8,
        InterfaceImpl = 9,
        MemberRef = 10,
        Constant = 11,
        CustomAttribute = 12,
        FieldMarshal = 13,
        Permission = 14,
        ClassLayout = 15,
        FieldLayout = 16,
        Signature = 17,
        EventMap = 18,
        EventPointer = 19,
        Event = 20,
        PropertyMap = 21,
        PropertyPointer = 22,
        Property = 23,
        MethodSemantics = 24,
        MethodImpl = 25,
        ModuleRef = 26,
        TypeSpec = 27,
        ImplMap = 28,
        FieldRva = 29,
        EncodingLog = 30,
        EncodingMap = 31,
        Assembly = 32,
        AssemblyProcessor = 33,
        AssemblyOS = 34,
        AssemblyRef = 35,
        AssemblyRefProcessor = 36,
        AssemblyRefOS = 37,
        File = 38,
        ExportedType = 39,
        ManifestResource = 40,
        NestedClass = 41,
        GenericParam = 42,
        MethodSpec = 43,
        GenericParamConstraint = 44,
        MaxTableTokenType = 44,
        TypeDefOrRef = 64,
        HasConstant = 65,
        CustomAttributeType = 66,
        HasSemantics = 67,
        ResolutionScope = 68,
        HasFieldMarshal = 69,
        HasDeclSecurity = 70,
        MemberRefParent = 71,
        MethodDefOrRef = 72,
        MemberForwarded = 73,
        Implementation = 80,
        HasCustomAttribute = 81,
        TypeOrMethodDef = 82,
    }
    public struct MethodImplementationProperties
    {
        public MethodImplementationProperties(JetBrains.Metadata.Access.MetadataToken typeToken, JetBrains.Metadata.Access.MetadataToken methodToken, JetBrains.Metadata.Access.MetadataToken bodyToken) { }
        public JetBrains.Metadata.Access.MetadataToken BodyToken { get; }
        public JetBrains.Metadata.Access.MetadataToken MethodToken { get; }
        public JetBrains.Metadata.Access.MetadataToken TypeToken { get; }
    }
    public struct MethodProperties
    {
        public MethodProperties(string name, JetBrains.Metadata.Access.MetadataToken declaringTypeToken, JetBrains.Metadata.Utils.IBlob signature, uint codeRVA, JetBrains.Metadata.Access.CorMethodAttr methodFlags, JetBrains.Metadata.Access.CorMethodImpl implFlags) { }
        public uint CodeRVA { get; }
        public JetBrains.Metadata.Access.MetadataToken DeclaringTypeToken { get; }
        public JetBrains.Metadata.Access.CorMethodImpl ImplFlags { get; }
        public JetBrains.Metadata.Access.CorMethodAttr MethodFlags { get; }
        public string Name { get; }
        public JetBrains.Metadata.Utils.IBlob Signature { get; }
    }
    public struct MethodSpecProperties
    {
        public MethodSpecProperties(JetBrains.Metadata.Access.MetadataToken methodDefOrRef, JetBrains.Metadata.Utils.IBlob instantiation) { }
        public JetBrains.Metadata.Utils.IBlob Instantiation { get; }
        public JetBrains.Metadata.Access.MetadataToken MethodDefOrRef { get; }
    }
    public struct ParamProperties
    {
        public ParamProperties(string name, uint index, JetBrains.Metadata.Access.MetadataToken methodToken, JetBrains.Metadata.Access.CorParamAttr paramFlags, byte valueElementType, JetBrains.Metadata.Utils.IBlob value) { }
        public uint Index { get; }
        public JetBrains.Metadata.Access.MetadataToken MethodToken { get; }
        public string Name { get; }
        public JetBrains.Metadata.Access.CorParamAttr ParamFlags { get; }
        public JetBrains.Metadata.Utils.IBlob Value { get; }
        public byte ValueElementType { get; }
    }
    public class PInvokeProperties
    {
        public PInvokeProperties(JetBrains.Metadata.Access.CorPInvokeMap flags, string importName, JetBrains.Metadata.Access.MetadataToken importScope) { }
        public JetBrains.Metadata.Access.CorPInvokeMap Flags { get; }
        public string ImportName { get; }
        public JetBrains.Metadata.Access.MetadataToken ImportScope { get; }
    }
    [System.FlagsAttribute()]
    public enum Prologs : byte
    {
        VarArg = 5,
        FieldSig = 6,
        LocalSig = 7,
        PropertySig = 8,
        Generic = 16,
        GenricInst = 10,
        HasThis = 32,
        ExplicitThis = 64,
        PermissionSetBlob20 = 46,
    }
    public struct PropertyProperties
    {
        public PropertyProperties(string name, JetBrains.Metadata.Access.MetadataToken declaringTypeToken, JetBrains.Metadata.Access.CorPropertyAttr propertyFlags, JetBrains.Metadata.Utils.IBlob signature, JetBrains.Metadata.Access.MetadataToken getter, JetBrains.Metadata.Access.MetadataToken setter, JetBrains.Metadata.Access.MetadataToken[] otherMethods) { }
        public JetBrains.Metadata.Access.MetadataToken DeclaringTypeToken { get; }
        public JetBrains.Metadata.Access.MetadataToken Getter { get; }
        public string Name { get; }
        public JetBrains.Metadata.Access.MetadataToken[] OtherMethods { get; }
        public JetBrains.Metadata.Access.CorPropertyAttr PropertyFlags { get; }
        public JetBrains.Metadata.Access.MetadataToken Setter { get; }
        public JetBrains.Metadata.Utils.IBlob Signature { get; }
    }
    public enum TargetPlatform
    {
        MSIL = 0,
        X86 = 1,
        X64 = 2,
    }
    public class static TargetPlatformUtil
    {
        public static JetBrains.Metadata.Access.TargetPlatform GetTargetPlatform(JetBrains.Metadata.Utils.PE.CLIFlags cliFlags, JetBrains.Metadata.Utils.PE.MachineId machineId) { }
    }
    public struct TypeDefProperties
    {
        public TypeDefProperties(JetBrains.Metadata.Access.MetadataToken baseToken, JetBrains.Metadata.Access.CorTypeAttr typeDefFlags, [JetBrains.Annotations.NotNullAttribute()] string namespaceName, [JetBrains.Annotations.NotNullAttribute()] string typeName) { }
        public JetBrains.Metadata.Access.MetadataToken BaseToken { get; }
        public string FullName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string NamespaceName { get; }
        public JetBrains.Metadata.Access.CorTypeAttr TypeDefFlags { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string TypeName { get; }
    }
    public struct TypeRefProperties
    {
        public TypeRefProperties(JetBrains.Metadata.Access.MetadataToken resolutionScope, string namespaceName, string typeName) { }
        public string FullName { get; }
        public string NamespaceName { get; }
        public JetBrains.Metadata.Access.MetadataToken ResolutionScope { get; }
        public string TypeName { get; }
    }
}
namespace JetBrains.Metadata.Access.ILReader
{
    
    public class static CodedTokenTables
    {
        public static JetBrains.Metadata.Access.MetadataTableId[] CodedTokenList(JetBrains.Metadata.Access.ILReader.EncodedTokenType type) { }
        public static int GetCodedTableId(JetBrains.Metadata.Access.ILReader.EncodedTokenType type, JetBrains.Metadata.Access.MetadataTableId tableId) { }
    }
    public enum EncodedTokenType
    {
        TypeDefOrRef = 64,
        HasConstant = 65,
        CustomAttributeType = 66,
        HasSemantics = 67,
        ResolutionScope = 68,
        HasFieldMarshal = 69,
        HasDeclSecurity = 70,
        MemberRefParent = 71,
        MethodDefOrRef = 72,
        MemberForwarded = 73,
        Implementation = 80,
        HasCustomAttribute = 81,
        TypeOrMethodDef = 82,
        Max = 82,
    }
    public class static ExtensionMethods { }
    public sealed class ILReaderMetadataAccess : JetBrains.Metadata.Access.IMetadataAccess
    {
        public ILReaderMetadataAccess([JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath imageFile, System.DateTime imageFileTimestamp) { }
        public JetBrains.Metadata.Access.IMetadataProvider MetadataProvider { get; }
        public System.Guid Mvid { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.Metadata.Access.MetadataToken, JetBrains.Metadata.Access.MetadataToken> NestedTypeMap { get; }
        public JetBrains.Metadata.Access.ILReader.StreamsManager Streams { get; }
        public JetBrains.Metadata.Access.TargetPlatform TargetPlatform { get; }
        public JetBrains.Util.ReadOnlyDictionary<string, JetBrains.Metadata.Access.MetadataToken> TypeName2TokenMapping { get; }
        public JetBrains.Metadata.Access.MetadataToken[] FindMemberRefs(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.MetadataToken[] FindMethodSpecs(JetBrains.Metadata.Access.MetadataToken methodDefOrRef) { }
        public JetBrains.Metadata.Access.MetadataToken FindTypeRef(JetBrains.Metadata.Access.MetadataToken resolutionScope, string qualifiedName) { }
        public JetBrains.Metadata.Access.IMetadataAssemblyInfo GetAssemblyInfo() { }
        public JetBrains.Metadata.Access.ClassLayout GetClassLayout(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.CustomAttributeProperties GetCustomAttributeProperties(JetBrains.Metadata.Access.MetadataToken customAttributeToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetCustomAttributes(JetBrains.Metadata.Access.MetadataToken parentToken) { }
        public JetBrains.Metadata.Reader.API.MetadataTypeReference GetCustomAttributeTypeName(JetBrains.Metadata.Access.MetadataToken customAttributeToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetDeclSecurity(JetBrains.Metadata.Access.MetadataToken owner) { }
        public JetBrains.Metadata.Access.DeclSecurityProperties GetDeclSecurityProperties(JetBrains.Metadata.Access.MetadataToken token) { }
        public string[] GetDeclSecurityTypeNames(JetBrains.Metadata.Access.MetadataToken token) { }
        public long GetEmbeddedResourceOffset(long resourceOffset) { }
        public JetBrains.Metadata.Access.MetadataToken GetEnclosingType(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.EventProperties GetEventProperties(JetBrains.Metadata.Access.MetadataToken eventToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetEvents(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.FieldProperties GetFieldProperties(JetBrains.Metadata.Access.MetadataToken fieldToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetFields(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetFields() { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetGenericParameters(JetBrains.Metadata.Access.MetadataToken ownerToken) { }
        public JetBrains.Metadata.Access.GenericParamProperties GetGenericParamProperties(JetBrains.Metadata.Access.MetadataToken gpToken) { }
        public JetBrains.Metadata.Access.MetadataToken[] GetInterfaceImplementations(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.ManifestResourceProperties GetManifestResourceProperties(JetBrains.Metadata.Access.MetadataToken manifestResourceToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetManifestResources() { }
        public JetBrains.Metadata.Utils.IBlob GetMarshalSpec(JetBrains.Metadata.Access.MetadataToken token) { }
        public string GetMemberName(JetBrains.Metadata.Access.MetadataToken memberToken) { }
        public JetBrains.Metadata.Access.MemberReferenceProperties GetMemberReferenceProperties(JetBrains.Metadata.Access.MetadataToken memberReferenceToken) { }
        public JetBrains.Metadata.Access.MethodImplementationProperties[] GetMethodImplementationProperties(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.MethodProperties GetMethodProperties(JetBrains.Metadata.Access.MetadataToken methodToken) { }
        public JetBrains.Util.ReadOnlyList<uint> GetMethodRvaMap() { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetMethods(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetMethods() { }
        public JetBrains.Metadata.Access.MethodSpecProperties GetMethodSpecProperties(JetBrains.Metadata.Access.MetadataToken methodSpec) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetMethodSpecs() { }
        public string GetModuleRefProperties(JetBrains.Metadata.Access.MetadataToken token) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetModuleRefs() { }
        public JetBrains.Metadata.Access.MetadataToken GetParameterByIndex(JetBrains.Metadata.Access.MetadataToken methodToken, uint paramIndex) { }
        public JetBrains.Metadata.Access.ParamProperties GetParameterProperties(JetBrains.Metadata.Access.MetadataToken paramToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetParameters(JetBrains.Metadata.Access.MetadataToken methodToken) { }
        public JetBrains.Metadata.Access.PInvokeProperties GetPInvokeProperties(JetBrains.Metadata.Access.MetadataToken methodToken) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetProperties(JetBrains.Metadata.Access.MetadataToken typeToken) { }
        public JetBrains.Metadata.Access.PropertyProperties GetPropertyProperties(JetBrains.Metadata.Access.MetadataToken propertyToken) { }
        public JetBrains.Metadata.Utils.IBlob GetStandaloneSignatureBlob(JetBrains.Metadata.Access.MetadataToken standaloneSig) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetStandaloneSigs() { }
        public JetBrains.Metadata.Access.TypeDefProperties GetTypeDefProperties(JetBrains.Metadata.Access.MetadataToken typeDef) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetTypeDefs() { }
        public JetBrains.Metadata.Access.TypeRefProperties GetTypeRefProperties(JetBrains.Metadata.Access.MetadataToken typeRef) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetTypeRefs() { }
        public JetBrains.Metadata.Utils.IBlob GetTypeSpecBlob(JetBrains.Metadata.Access.MetadataToken typeSpec) { }
        public JetBrains.Metadata.Access.MetadataTokenRange GetTypeSpecs() { }
        public string GetUserstring(JetBrains.Metadata.Access.MetadataToken pointer) { }
        public static uint MakeToken(JetBrains.Metadata.Access.MetadataTableId type, int rid) { }
    }
    public class ILReaderMetadataProvider : JetBrains.Metadata.Access.IMetadataProvider
    {
        public static readonly JetBrains.Metadata.Access.IMetadataProvider Instance;
        public void ClearCache() { }
        public void DisposeMetadataAccess(JetBrains.Metadata.Access.IMetadataAccess access) { }
        public void DumpDebugInfo(System.IO.TextWriter sw) { }
        public JetBrains.Metadata.Access.IMetadataAccess GetFromFile(JetBrains.Util.FileSystemPath fsp) { }
        public JetBrains.Metadata.Access.IMetadataAccess TryGetFromFile(JetBrains.Util.FileSystemPath fsp) { }
        public JetBrains.Metadata.Access.IMetadataAccess TryGetFromMemory(byte[] data) { }
    }
    public interface ITableReader
    {
        int ReadBlob();
        int ReadGuid();
        int ReadString();
        uint ReadToken(JetBrains.Metadata.Access.MetadataTokenType type);
        ushort ReadUInt16();
        uint ReadUInt32();
    }
    public enum MethodSemanticsAttributes : short
    {
        Setter = 1,
        Getter = 2,
        Other = 4,
        AddOn = 8,
        RemoveOn = 16,
        Fire = 32,
    }
    public class StreamsManager
    {
        public StreamsManager(JetBrains.Metadata.Utils.IBlob metadataBlob, string imageMoniker) { }
        public JetBrains.Metadata.Access.ILReader.TableManager Tables { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Utils.IBlob GetBlob(int offset) { }
        public System.Guid GetGuid(int index) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetString(int offset) { }
        public string GetUserstring(JetBrains.Metadata.Access.MetadataToken pointer) { }
    }
    public sealed class TableManager
    {
        public readonly int BlobIdxSize;
        public static readonly int[] CODED_TOKEN_BITS;
        public readonly int GuidIdxSize;
        public readonly int StringIdxSize;
        public readonly int[] TableOffsets;
        public readonly int[] TableRows;
        public readonly int[] TableRowSize;
        public readonly int[] TokenSize;
        public TableManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.IBinaryReader reader, [JetBrains.Annotations.NotNullAttribute()] string imageMoniker) { }
        public int GetRowOffset(JetBrains.Metadata.Access.MetadataToken token) { }
        public int GetRowOffset(JetBrains.Metadata.Access.MetadataTableId table, int rid) { }
        public JetBrains.Metadata.Access.ILReader.ITableReader GetTableRow(JetBrains.Metadata.Access.MetadataTableId table, int rid) { }
        public JetBrains.Metadata.Access.ILReader.ITableReader GetTableRow(JetBrains.Metadata.Access.MetadataToken token) { }
    }
    public enum TableOrderingState
    {
        UNKNOWN = 0,
        SORTED = 1,
        UNSORTED = 2,
    }
    public class TablesOrderingState
    {
        public JetBrains.Metadata.Access.ILReader.TableOrderingState this[JetBrains.Metadata.Access.MetadataTableId tableId] { get; }
        public static JetBrains.Metadata.Access.ILReader.TablesOrderingState CreateFromSortedTablesList(JetBrains.Metadata.Access.MetadataTableId[] sortedTables) { }
        public JetBrains.Metadata.Access.ILReader.TablesOrderingState SetState(JetBrains.Metadata.Access.MetadataTableId tableId, JetBrains.Metadata.Access.ILReader.TableOrderingState newState) { }
    }
}
namespace JetBrains.Metadata.IL
{
    
    public class ExceptionHandler
    {
        public JetBrains.Metadata.Access.MetadataToken CatchTypeToken { get; }
        public int FilterOffset { get; }
        public int HandlerLength { get; }
        public int HandlerOffset { get; }
        public int TryLength { get; }
        public int TryOffset { get; }
        public JetBrains.Metadata.IL.ExceptionHandlerType Type { get; }
    }
    public class ExceptionHandlersComparer : System.Collections.Generic.IComparer<JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler>
    {
        public static readonly System.Collections.Generic.IComparer<JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler> Instance;
        public int Compare(JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler x, JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler y) { }
    }
    public enum ExceptionHandlerType
    {
        Fault = 0,
        Catch = 1,
        Finally = 2,
        CatchWithFilter = 3,
    }
    public enum FlowControl
    {
        ConditionalBranch = 0,
        Next = 1,
        Return = 2,
        Throw = 3,
        Break = 4,
        Branch = 5,
        Call = 6,
        Meta = 7,
        Switch = 8,
    }
    public class IlImageBodyAccess
    {
        public IlImageBodyAccess(System.IO.Stream image, JetBrains.Metadata.Access.IMetadataAccess metadata) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public byte[] GetFieldInitialValue(JetBrains.Metadata.Access.MetadataToken fieldToken, int valueSize) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.IL.ILMethodBody GetMethodBody(JetBrains.Metadata.Access.MetadataToken methodToken) { }
    }
    public class IlMetadataFormatter
    {
        public IlMetadataFormatter([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.IL.IMetadataTextWriter writer, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.IL.IMetadataLocalVariablesNameProvider localVariablesNameProvider) { }
        public void RenderExceptionHandlersIfAny(JetBrains.Metadata.Reader.API.IMethodBody methodBody, JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler[] sortedExceptionHandlers, int offset) { }
        public void RenderInstruction(JetBrains.Metadata.Reader.API.IMethodBody methodBody, JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler[] sortedExceptionHandlers, JetBrains.Metadata.IL.Instruction instruction) { }
        public void RenderLocalVariables(JetBrains.Metadata.Reader.API.IMethodBodyLocalVariable[] variables) { }
        public void RenderMaxStack(JetBrains.Metadata.Reader.API.IMethodBody methodBody) { }
        public void RenderMethodBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMethodBody methodBody) { }
    }
    public class IlMetadataTypeNameFormatter : JetBrains.Metadata.Reader.API.IMetadataTypeVisitor
    {
        public IlMetadataTypeNameFormatter(JetBrains.Metadata.Reader.API.IMetadataAssembly containingModule, JetBrains.Metadata.IL.IMetadataTextWriter writer) { }
        public void VisitArrayType(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType) { }
        public void VisitClassType(JetBrains.Metadata.Reader.API.IMetadataClassType classType) { }
        public void VisitFunctionPointer(JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType functionPointerType) { }
        public void VisitGenericArgumentReferenceType(JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType genericArgumentReferenceType) { }
        public void VisitPointerType(JetBrains.Metadata.Reader.API.IMetadataPointerType pointerType) { }
        public void VisitReferenceType(JetBrains.Metadata.Reader.API.IMetadataReferenceType referenceType) { }
        public void VisitUnknownType(JetBrains.Metadata.Reader.API.IMetadataType unknownType) { }
    }
    public sealed class ILMethodBody
    {
        public int CodeSize { get; }
        public JetBrains.Metadata.IL.ExceptionHandler[] Exceptions { get; }
        public JetBrains.Metadata.IL.ILMethodFlags Flags { get; }
        public JetBrains.Metadata.IL.Instruction[] Instructions { get; }
        public JetBrains.Metadata.Access.MetadataToken LocalVarsToken { get; }
        public int MaxStack { get; }
        public static JetBrains.Metadata.IL.ILMethodBody DecodeMethodBody([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Access.IMetadataAccess metadataAccess, JetBrains.Metadata.Utils.IBinaryReader reader) { }
    }
    [System.FlagsAttribute()]
    public enum ILMethodFlags
    {
        SmallCode = 0,
        TinyCode = 2,
        FatCode = 3,
        CodeMask = 3,
        InitLocals = 16,
        MoreSects = 8,
    }
    public interface IMetadataLocalVariablesNameProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetVariableName([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod methodBody, int index);
    }
    public interface IMetadataTextWriter
    {
        System.IDisposable Indent();
        void SetOffset(int offset);
        void WriteNewLine();
        void WriteText(string text);
    }
    public sealed class Instruction : JetBrains.Util.ICloneable<JetBrains.Metadata.IL.Instruction>, System.ICloneable
    {
        public Instruction(int offset, int size, JetBrains.Metadata.IL.Opcode code, object operand) { }
        public Instruction(JetBrains.Metadata.IL.Instruction instruction, object operand) { }
        public JetBrains.Metadata.IL.Opcode Code { get; }
        public int Offset { get; }
        public object Operand { get; }
        public int Size { get; }
        public JetBrains.Metadata.IL.Instruction Clone() { }
        public override string ToString() { }
    }
    public class static InstructionEx
    {
        public static int GetBranchTargetOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static double GetDoubleOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static JetBrains.Metadata.Reader.API.FieldSpecification GetFieldSpecificationOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static int GetInt32Operand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static long GetInt64Operand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static JetBrains.Metadata.Reader.API.IMetadataType GetMetadataTypeOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static JetBrains.Metadata.Reader.API.MethodInstantiation GetMethodInstantiationOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static JetBrains.Metadata.Reader.API.MethodSignature GetMethodSignatureOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static JetBrains.Metadata.Reader.API.MethodSpecification GetMethodSpecificationOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static sbyte GetSByteOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static float GetSingleOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static string GetStringOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static int[] GetSwitchTargetsOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static JetBrains.Metadata.Access.MetadataToken GetTokenOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
        public static int GetVariableIndexOperand(this JetBrains.Metadata.IL.Instruction instruction) { }
    }
    public sealed class Opcode
    {
        public const byte MultiByteOpCodePrefix = 254;
        public JetBrains.Metadata.IL.FlowControl FlowControl { get; }
        public bool IsEndsUnconditionalJumpBlock { get; }
        public string Name { get; }
        public JetBrains.Metadata.IL.OpcodeType OpcodeType { get; }
        public JetBrains.Metadata.IL.OperandType OperandType { get; }
        public int Size { get; }
        public JetBrains.Metadata.IL.StackBehavior StackBehaviorPop { get; }
        public JetBrains.Metadata.IL.StackBehavior StackBehaviorPush { get; }
        public int StackChange { get; }
        public JetBrains.Metadata.IL.OpcodeValue Value { get; }
        public bool Equals(JetBrains.Metadata.IL.Opcode other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static Opcodes
    {
        public static readonly JetBrains.Metadata.IL.Opcode Add;
        public static readonly JetBrains.Metadata.IL.Opcode Add_ovf;
        public static readonly JetBrains.Metadata.IL.Opcode Add_ovf_un;
        public static readonly JetBrains.Metadata.IL.Opcode And;
        public static readonly JetBrains.Metadata.IL.Opcode Arglist;
        public static readonly JetBrains.Metadata.IL.Opcode Beq;
        public static readonly JetBrains.Metadata.IL.Opcode Beq_s;
        public static readonly JetBrains.Metadata.IL.Opcode Bge;
        public static readonly JetBrains.Metadata.IL.Opcode Bge_s;
        public static readonly JetBrains.Metadata.IL.Opcode Bge_un;
        public static readonly JetBrains.Metadata.IL.Opcode Bge_un_s;
        public static readonly JetBrains.Metadata.IL.Opcode Bgt;
        public static readonly JetBrains.Metadata.IL.Opcode Bgt_s;
        public static readonly JetBrains.Metadata.IL.Opcode Bgt_un;
        public static readonly JetBrains.Metadata.IL.Opcode Bgt_un_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ble;
        public static readonly JetBrains.Metadata.IL.Opcode Ble_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ble_un;
        public static readonly JetBrains.Metadata.IL.Opcode Ble_un_s;
        public static readonly JetBrains.Metadata.IL.Opcode Blt;
        public static readonly JetBrains.Metadata.IL.Opcode Blt_s;
        public static readonly JetBrains.Metadata.IL.Opcode Blt_un;
        public static readonly JetBrains.Metadata.IL.Opcode Blt_un_s;
        public static readonly JetBrains.Metadata.IL.Opcode Bne_un;
        public static readonly JetBrains.Metadata.IL.Opcode Bne_un_s;
        public static readonly JetBrains.Metadata.IL.Opcode Box;
        public static readonly JetBrains.Metadata.IL.Opcode Br;
        public static readonly JetBrains.Metadata.IL.Opcode Br_s;
        public static readonly JetBrains.Metadata.IL.Opcode Break;
        public static readonly JetBrains.Metadata.IL.Opcode Brfalse;
        public static readonly JetBrains.Metadata.IL.Opcode Brfalse_s;
        public static readonly JetBrains.Metadata.IL.Opcode Brtrue;
        public static readonly JetBrains.Metadata.IL.Opcode Brtrue_s;
        public static readonly JetBrains.Metadata.IL.Opcode Call;
        public static readonly JetBrains.Metadata.IL.Opcode Calli;
        public static readonly JetBrains.Metadata.IL.Opcode Callvirt;
        public static readonly JetBrains.Metadata.IL.Opcode Castclass;
        public static readonly JetBrains.Metadata.IL.Opcode Ceq;
        public static readonly JetBrains.Metadata.IL.Opcode Cgt;
        public static readonly JetBrains.Metadata.IL.Opcode Cgt_un;
        public static readonly JetBrains.Metadata.IL.Opcode Ckfinite;
        public static readonly JetBrains.Metadata.IL.Opcode Clt;
        public static readonly JetBrains.Metadata.IL.Opcode Clt_un;
        public static readonly JetBrains.Metadata.IL.Opcode Constrained;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_i;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_i1;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_i2;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i1;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i1_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i2;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i2_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i4_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_i8_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u1;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u1_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u2;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u2_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u4;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u4_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u8;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_ovf_u8_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_r_un;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_r4;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_r8;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_u;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_u1;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_u2;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_u4;
        public static readonly JetBrains.Metadata.IL.Opcode Conv_u8;
        public static readonly JetBrains.Metadata.IL.Opcode Cpblk;
        public static readonly JetBrains.Metadata.IL.Opcode Cpobj;
        public static readonly JetBrains.Metadata.IL.Opcode Div;
        public static readonly JetBrains.Metadata.IL.Opcode Div_un;
        public static readonly JetBrains.Metadata.IL.Opcode Dup;
        public static readonly JetBrains.Metadata.IL.Opcode Endfilter;
        public static readonly JetBrains.Metadata.IL.Opcode Endfinally;
        public static readonly JetBrains.Metadata.IL.Opcode Initblk;
        public static readonly JetBrains.Metadata.IL.Opcode Initobj;
        public static readonly JetBrains.Metadata.IL.Opcode Isinst;
        public static readonly JetBrains.Metadata.IL.Opcode Jmp;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarg;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarg_0;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarg_1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarg_2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarg_3;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarg_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarga;
        public static readonly JetBrains.Metadata.IL.Opcode Ldarga_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_0;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_3;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_5;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_6;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_7;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_m1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i4_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_r4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldc_r8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_i;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_i1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_i2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_r4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_r8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_ref;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_u1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_u2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelem_u4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldelema;
        public static readonly JetBrains.Metadata.IL.Opcode Ldfld;
        public static readonly JetBrains.Metadata.IL.Opcode Ldflda;
        public static readonly JetBrains.Metadata.IL.Opcode Ldftn;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_i;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_i1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_i2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_r4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_r8;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_ref;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_u1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_u2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldind_u4;
        public static readonly JetBrains.Metadata.IL.Opcode Ldlen;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloc;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloc_0;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloc_1;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloc_2;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloc_3;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloc_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloca;
        public static readonly JetBrains.Metadata.IL.Opcode Ldloca_s;
        public static readonly JetBrains.Metadata.IL.Opcode Ldnull;
        public static readonly JetBrains.Metadata.IL.Opcode Ldobj;
        public static readonly JetBrains.Metadata.IL.Opcode Ldsfld;
        public static readonly JetBrains.Metadata.IL.Opcode Ldsflda;
        public static readonly JetBrains.Metadata.IL.Opcode Ldstr;
        public static readonly JetBrains.Metadata.IL.Opcode Ldtoken;
        public static readonly JetBrains.Metadata.IL.Opcode Ldvirtftn;
        public static readonly JetBrains.Metadata.IL.Opcode Leave;
        public static readonly JetBrains.Metadata.IL.Opcode Leave_s;
        public static readonly JetBrains.Metadata.IL.Opcode Localloc;
        public static readonly JetBrains.Metadata.IL.Opcode Mkrefany;
        public static readonly JetBrains.Metadata.IL.Opcode Mul;
        public static readonly JetBrains.Metadata.IL.Opcode Mul_ovf;
        public static readonly JetBrains.Metadata.IL.Opcode Mul_ovf_un;
        public static readonly JetBrains.Metadata.IL.Opcode Neg;
        public static readonly JetBrains.Metadata.IL.Opcode Newarr;
        public static readonly JetBrains.Metadata.IL.Opcode Newobj;
        public static readonly JetBrains.Metadata.IL.Opcode No;
        public static readonly JetBrains.Metadata.IL.Opcode Nop;
        public static readonly JetBrains.Metadata.IL.Opcode Not;
        public static readonly JetBrains.Metadata.IL.Opcode Or;
        public static readonly JetBrains.Metadata.IL.Opcode Pop;
        public static readonly JetBrains.Metadata.IL.Opcode Readonly;
        public static readonly JetBrains.Metadata.IL.Opcode Refanytype;
        public static readonly JetBrains.Metadata.IL.Opcode Refanyval;
        public static readonly JetBrains.Metadata.IL.Opcode Rem;
        public static readonly JetBrains.Metadata.IL.Opcode Rem_un;
        public static readonly JetBrains.Metadata.IL.Opcode Ret;
        public static readonly JetBrains.Metadata.IL.Opcode Rethrow;
        public static readonly JetBrains.Metadata.IL.Opcode Shl;
        public static readonly JetBrains.Metadata.IL.Opcode Shr;
        public static readonly JetBrains.Metadata.IL.Opcode Shr_un;
        public static readonly JetBrains.Metadata.IL.Opcode Sizeof;
        public static readonly JetBrains.Metadata.IL.Opcode Starg;
        public static readonly JetBrains.Metadata.IL.Opcode Starg_s;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_i;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_i1;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_i2;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_r4;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_r8;
        public static readonly JetBrains.Metadata.IL.Opcode Stelem_ref;
        public static readonly JetBrains.Metadata.IL.Opcode Stfld;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_i;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_i1;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_i2;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_i4;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_i8;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_r4;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_r8;
        public static readonly JetBrains.Metadata.IL.Opcode Stind_ref;
        public static readonly JetBrains.Metadata.IL.Opcode Stloc;
        public static readonly JetBrains.Metadata.IL.Opcode Stloc_0;
        public static readonly JetBrains.Metadata.IL.Opcode Stloc_1;
        public static readonly JetBrains.Metadata.IL.Opcode Stloc_2;
        public static readonly JetBrains.Metadata.IL.Opcode Stloc_3;
        public static readonly JetBrains.Metadata.IL.Opcode Stloc_s;
        public static readonly JetBrains.Metadata.IL.Opcode Stobj;
        public static readonly JetBrains.Metadata.IL.Opcode Stsfld;
        public static readonly JetBrains.Metadata.IL.Opcode Sub;
        public static readonly JetBrains.Metadata.IL.Opcode Sub_ovf;
        public static readonly JetBrains.Metadata.IL.Opcode Sub_ovf_un;
        public static readonly JetBrains.Metadata.IL.Opcode Switch;
        public static readonly JetBrains.Metadata.IL.Opcode Tail;
        public static readonly JetBrains.Metadata.IL.Opcode Throw;
        public static readonly JetBrains.Metadata.IL.Opcode Unaligned;
        public static readonly JetBrains.Metadata.IL.Opcode Unbox;
        public static readonly JetBrains.Metadata.IL.Opcode Unbox_any;
        public static readonly JetBrains.Metadata.IL.Opcode Unused;
        public static readonly JetBrains.Metadata.IL.Opcode Volatile;
        public static readonly JetBrains.Metadata.IL.Opcode Xor;
        public static JetBrains.Metadata.IL.Opcode[] MultiByteOpcodes { get; }
        public static JetBrains.Metadata.IL.Opcode[] SingleByteOpcodes { get; }
    }
    public enum OpcodeType
    {
        Prefix = 0,
        ObjectModel = 1,
        Primitive = 2,
        Macro = 3,
        Internal = 4,
    }
    public enum OpcodeValue : ushort
    {
        Nop = 0,
        Break = 1,
        Ldarg_0 = 2,
        Ldarg_1 = 3,
        Ldarg_2 = 4,
        Ldarg_3 = 5,
        Ldloc_0 = 6,
        Ldloc_1 = 7,
        Ldloc_2 = 8,
        Ldloc_3 = 9,
        Stloc_0 = 10,
        Stloc_1 = 11,
        Stloc_2 = 12,
        Stloc_3 = 13,
        Ldarg_s = 14,
        Ldarga_s = 15,
        Starg_s = 16,
        Ldloc_s = 17,
        Ldloca_s = 18,
        Stloc_s = 19,
        Ldnull = 20,
        Ldc_i4_m1 = 21,
        Ldc_i4_0 = 22,
        Ldc_i4_1 = 23,
        Ldc_i4_2 = 24,
        Ldc_i4_3 = 25,
        Ldc_i4_4 = 26,
        Ldc_i4_5 = 27,
        Ldc_i4_6 = 28,
        Ldc_i4_7 = 29,
        Ldc_i4_8 = 30,
        Ldc_i4_s = 31,
        Ldc_i4 = 32,
        Ldc_i8 = 33,
        Ldc_r4 = 34,
        Ldc_r8 = 35,
        Dup = 37,
        Pop = 38,
        Jmp = 39,
        Call = 40,
        Calli = 41,
        Ret = 42,
        Br_s = 43,
        Brfalse_s = 44,
        Brtrue_s = 45,
        Beq_s = 46,
        Bge_s = 47,
        Bgt_s = 48,
        Ble_s = 49,
        Blt_s = 50,
        Bne_un_s = 51,
        Bge_un_s = 52,
        Bgt_un_s = 53,
        Ble_un_s = 54,
        Blt_un_s = 55,
        Br = 56,
        Brfalse = 57,
        Brtrue = 58,
        Beq = 59,
        Bge = 60,
        Bgt = 61,
        Ble = 62,
        Blt = 63,
        Bne_un = 64,
        Bge_un = 65,
        Bgt_un = 66,
        Ble_un = 67,
        Blt_un = 68,
        Switch = 69,
        Ldind_i1 = 70,
        Ldind_u1 = 71,
        Ldind_i2 = 72,
        Ldind_u2 = 73,
        Ldind_i4 = 74,
        Ldind_u4 = 75,
        Ldind_i8 = 76,
        Ldind_i = 77,
        Ldind_r4 = 78,
        Ldind_r8 = 79,
        Ldind_ref = 80,
        Stind_ref = 81,
        Stind_i1 = 82,
        Stind_i2 = 83,
        Stind_i4 = 84,
        Stind_i8 = 85,
        Stind_r4 = 86,
        Stind_r8 = 87,
        Add = 88,
        Sub = 89,
        Mul = 90,
        Div = 91,
        Div_un = 92,
        Rem = 93,
        Rem_un = 94,
        And = 95,
        Or = 96,
        Xor = 97,
        Shl = 98,
        Shr = 99,
        Shr_un = 100,
        Neg = 101,
        Not = 102,
        Conv_i1 = 103,
        Conv_i2 = 104,
        Conv_i4 = 105,
        Conv_i8 = 106,
        Conv_r4 = 107,
        Conv_r8 = 108,
        Conv_u4 = 109,
        Conv_u8 = 110,
        Callvirt = 111,
        Cpobj = 112,
        Ldobj = 113,
        Ldstr = 114,
        Newobj = 115,
        Castclass = 116,
        Isinst = 117,
        Conv_r_un = 118,
        Unbox = 121,
        Throw = 122,
        Ldfld = 123,
        Ldflda = 124,
        Stfld = 125,
        Ldsfld = 126,
        Ldsflda = 127,
        Stsfld = 128,
        Stobj = 129,
        Conv_ovf_i1_un = 130,
        Conv_ovf_i2_un = 131,
        Conv_ovf_i4_un = 132,
        Conv_ovf_i8_un = 133,
        Conv_ovf_u1_un = 134,
        Conv_ovf_u2_un = 135,
        Conv_ovf_u4_un = 136,
        Conv_ovf_u8_un = 137,
        Conv_ovf_i_un = 138,
        Conv_ovf_u_un = 139,
        Box = 140,
        Newarr = 141,
        Ldlen = 142,
        Ldelema = 143,
        Ldelem_i1 = 144,
        Ldelem_u1 = 145,
        Ldelem_i2 = 146,
        Ldelem_u2 = 147,
        Ldelem_i4 = 148,
        Ldelem_u4 = 149,
        Ldelem_i8 = 150,
        Ldelem_i = 151,
        Ldelem_r4 = 152,
        Ldelem_r8 = 153,
        Ldelem_ref = 154,
        Stelem_i = 155,
        Stelem_i1 = 156,
        Stelem_i2 = 157,
        Stelem_i4 = 158,
        Stelem_i8 = 159,
        Stelem_r4 = 160,
        Stelem_r8 = 161,
        Stelem_ref = 162,
        Ldelem = 163,
        Stelem = 164,
        Unbox_any = 165,
        Conv_ovf_i1 = 179,
        Conv_ovf_u1 = 180,
        Conv_ovf_i2 = 181,
        Conv_ovf_u2 = 182,
        Conv_ovf_i4 = 183,
        Conv_ovf_u4 = 184,
        Conv_ovf_i8 = 185,
        Conv_ovf_u8 = 186,
        Refanyval = 194,
        Ckfinite = 195,
        Mkrefany = 198,
        Ldtoken = 208,
        Conv_u2 = 209,
        Conv_u1 = 210,
        Conv_i = 211,
        Conv_ovf_i = 212,
        Conv_ovf_u = 213,
        Add_ovf = 214,
        Add_ovf_un = 215,
        Mul_ovf = 216,
        Mul_ovf_un = 217,
        Sub_ovf = 218,
        Sub_ovf_un = 219,
        Endfinally = 220,
        Leave = 221,
        Leave_s = 222,
        Stind_i = 223,
        Conv_u = 224,
        Arglist = 65024,
        Ceq = 65025,
        Cgt = 65026,
        Cgt_un = 65027,
        Clt = 65028,
        Clt_un = 65029,
        Ldftn = 65030,
        Ldvirtftn = 65031,
        Ldarg = 65033,
        Ldarga = 65034,
        Starg = 65035,
        Ldloc = 65036,
        Ldloca = 65037,
        Stloc = 65038,
        Localloc = 65039,
        Endfilter = 65041,
        Unaligned = 65042,
        Volatile = 65043,
        Tailcall = 65044,
        Initobj = 65045,
        Constrained = 65046,
        Cpblk = 65047,
        Initblk = 65048,
        No = 65049,
        Rethrow = 65050,
        Sizeof = 65052,
        Refanytype = 65053,
        Readonly = 65054,
        Unused = 65535,
    }
    public enum OperandType
    {
        Int32 = 0,
        Int64 = 1,
        None = 2,
        TypeToken = 3,
        SwitchTargets = 4,
        ShortVariableIndex = 5,
        SByte = 6,
        Double = 7,
        SignatureToken = 8,
        Single = 9,
        ShortBranchTarget = 10,
        FieldToken = 11,
        String = 12,
        MethodToken = 13,
        BranchTarget = 14,
        Token = 15,
        VariableIndex = 16,
    }
    public enum StackBehavior
    {
        Popref_popi_popi = 0,
        Popref_popi_popr4 = 1,
        Popref_popi_pop1 = 2,
        Popref_popi_popref = 3,
        Popi = 4,
        Popi_popi_popi = 5,
        Varpop = 6,
        Push1_push1 = 7,
        Popi_popi8 = 8,
        Popi_popr8 = 9,
        Pushref = 10,
        Popi_popr4 = 11,
        Popi_popi = 12,
        Pushi8 = 13,
        Pushr4 = 14,
        Pop1_pop1 = 15,
        Popref_pop1 = 16,
        Popi_pop1 = 17,
        Popref_popi_popi8 = 18,
        Pop1 = 19,
        Pop0 = 20,
        Pushr8 = 21,
        Popref_popi = 22,
        Pushi = 23,
        Varpush = 24,
        Popref_popi_popr8 = 25,
        Push0 = 26,
        Push1 = 27,
        Popref = 28,
    }
}
namespace JetBrains.Metadata.Reader.API
{
    
    public class AssemblyReferenceWithSource
    {
        public AssemblyReferenceWithSource([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath sourcePath, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyNameInfo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyNameInfo { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath SourcePath { get; }
        protected bool Equals(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public enum ClassLayoutType
    {
        Auto = 0,
        Sequential = 8,
        Explicit = 16,
    }
    public enum CodeType
    {
        IL = 0,
        NATIVE = 1,
        OPTIL = 2,
        RUNTIME = 3,
    }
    public class static CompilerSpecificAttributesExtensions
    {
        public static JetBrains.Metadata.Reader.API.ICompilerSpecificAttribute[] GetCompilerSpecificAttributes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataEntity entity) { }
    }
    public class CopyingMetadataTypeTransformer : JetBrains.Metadata.Reader.API.IMetadataTypeTransformer
    {
        public virtual JetBrains.Metadata.Reader.API.IMetadataType TransformArrayType(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType) { }
        public virtual JetBrains.Metadata.Reader.API.IMetadataType TransformClassType(JetBrains.Metadata.Reader.API.IMetadataClassType classType) { }
        public JetBrains.Metadata.Reader.API.IMetadataType TransformFunctionPointerType(JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType functionPointerType) { }
        public virtual JetBrains.Metadata.Reader.API.IMetadataType TransformGenericArgumentReferenceType(JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType genericArgumentReferenceType) { }
        public virtual JetBrains.Metadata.Reader.API.IMetadataType TransformPointerType(JetBrains.Metadata.Reader.API.IMetadataPointerType pointerType) { }
        public virtual JetBrains.Metadata.Reader.API.IMetadataType TransformReferenceType(JetBrains.Metadata.Reader.API.IMetadataReferenceType referenceType) { }
    }
    public class DefaultAssemblyResolver : JetBrains.Metadata.Reader.API.IAssemblyResolver
    {
        public DefaultAssemblyResolver(params JetBrains.Util.FileSystemPath[] paths) { }
        public DefaultAssemblyResolver(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> paths) { }
        public DefaultAssemblyResolver(JetBrains.Metadata.Access.IMetadataProvider metadataProvider, params JetBrains.Util.FileSystemPath[] paths) { }
        public DefaultAssemblyResolver(JetBrains.Metadata.Access.IMetadataProvider metadataProvider, System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> paths) { }
        public void AddPath(JetBrains.Util.FileSystemPath path) { }
        public JetBrains.Metadata.Access.IMetadataAccess ResolveAssembly(JetBrains.Metadata.Utils.AssemblyNameInfo nameToResolve, out JetBrains.Util.FileSystemPath assemblyLocation, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
    }
    public class DiagnosticResolveContext : JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext
    {
        public static JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext Instance { get; }
        public string UniqueName { get; }
        public JetBrains.Util.FileSystemPath GetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource) { }
        public bool IsValid() { }
        public void SetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource, JetBrains.Util.FileSystemPath resolveResult) { }
    }
    public enum ElementType : byte
    {
        End = 0,
        Void = 1,
        Bool = 2,
        Char = 3,
        I1 = 4,
        U1 = 5,
        I2 = 6,
        U2 = 7,
        I4 = 8,
        U4 = 9,
        I8 = 10,
        U8 = 11,
        R4 = 12,
        R8 = 13,
        String = 14,
        Ptr = 15,
        ByRef = 16,
        ValueType = 17,
        Class = 18,
        Var = 19,
        Array = 20,
        GenericInst = 21,
        TypedByRef = 22,
        I = 24,
        U = 25,
        FnPtr = 27,
        Object = 28,
        SzArray = 29,
        MVar = 30,
        CmodReqd = 31,
        CmodOpt = 32,
        Internal = 33,
        Modifier = 64,
        Sentinel = 65,
        Pinned = 69,
        Type = 80,
        Boxed = 81,
        Field = 83,
        Property = 84,
        Enum = 85,
    }
    public class static ElementTypeExtensions
    {
        public static int GetSize(this JetBrains.Metadata.Reader.API.ElementType elementType) { }
    }
    public class EmptyResolveContext : JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext
    {
        public static readonly JetBrains.Metadata.Reader.API.EmptyResolveContext Instance;
        public string UniqueName { get; }
        public JetBrains.Util.FileSystemPath GetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource) { }
        public bool IsValid() { }
        public void SetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource, JetBrains.Util.FileSystemPath resolveResult) { }
    }
    public class FieldSignature
    {
        public FieldSignature(JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public bool IsEqualTo(JetBrains.Metadata.Reader.API.FieldSignature other) { }
    }
    public class FieldSpecification : System.IEquatable<JetBrains.Metadata.Reader.API.FieldSpecification>
    {
        public static readonly JetBrains.Metadata.Reader.API.FieldSpecification Null;
        public FieldSpecification([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataField field) { }
        public FieldSpecification([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataField field, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataClassType ownerType) { }
        public JetBrains.Metadata.Reader.API.IMetadataField Field { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType OwnerType { get; }
        public bool Equals(JetBrains.Metadata.Reader.API.FieldSpecification other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class GacAssemblyResolver : JetBrains.Metadata.Reader.API.IAssemblyResolver
    {
        public GacAssemblyResolver(JetBrains.Util.FileSystemPath gacPath, JetBrains.Util.FileSystemPath gacPath40) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.GacAssemblyResolver CreateOnCurrentRuntimeGac() { }
        protected virtual JetBrains.Util.FileSystemPath Resolve(JetBrains.Metadata.Utils.AssemblyNameInfo name) { }
        public JetBrains.Metadata.Access.IMetadataAccess ResolveAssembly(JetBrains.Metadata.Utils.AssemblyNameInfo name, out JetBrains.Util.FileSystemPath assemblyLocation, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
    }
    [System.FlagsAttribute()]
    public enum GenericArgumentAttributes
    {
        VarianceMask = 3,
        NonVariant = 0,
        Covariant = 1,
        Contravariant = 2,
        SpecialConstraintMask = 28,
        NoSpecialConstraint = 0,
        ReferenceTypeConstraint = 4,
        ValueTypeConstraint = 8,
        DefaultConstructorConstraint = 16,
    }
    public enum GenericArgumentKind
    {
        Type = 0,
        Method = 1,
    }
    public interface IAssemblyResolver
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Access.IMetadataAccess ResolveAssembly(JetBrains.Metadata.Utils.AssemblyNameInfo name, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.Util.FileSystemPath assemblyLocation, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext);
    }
    public interface ICompilerSpecificAttribute
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string AttributeType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.Pair<, >[] NamedArguments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.MetadataAttributeValue[] PositionalArguments { get; }
    }
    public interface IEntityPresentations
    {
        JetBrains.Metadata.Access.MetadataToken[] GetFieldPresentations([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataField field);
        JetBrains.Metadata.Access.MetadataToken[] GetMethodPresentations([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod method);
        JetBrains.Metadata.Access.MetadataToken GetTokenFromTypeInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo);
        JetBrains.Metadata.Access.MetadataToken[] GetTypePresentations([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo);
    }
    public interface IImageBodyReader : System.IDisposable
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        byte[] GetFieldInitialValue(JetBrains.Metadata.Reader.API.IMetadataField field);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMethodBody GetMethodBody(JetBrains.Metadata.Reader.API.IMetadataMethod method);
    }
    public interface IManifestResourceDisposition
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string ResourceName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.IO.Stream CreateResourceReader();
    }
    public interface IMetadataArrayType : JetBrains.Metadata.Reader.API.IMetadataType
    {
        JetBrains.Metadata.Reader.API.IMetadataType ElementType { get; }
        bool IsVector { get; }
        int[] LBounds { get; }
        uint Rank { get; }
        uint[] Sizes { get; }
        JetBrains.Metadata.Reader.API.IMetadataArrayTypeInfo TypeInfo { get; }
    }
    public interface IMetadataArrayTypeInfo : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeInfo, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.IMetadataArrayType ArrayType { get; }
    }
    public interface IMetadataAssembly : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.ITypeInfoByNameProvider, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        JetBrains.Metadata.Reader.API.IMetadataAssemblyInternals Internals { get; }
        JetBrains.Util.FileSystemPath Location { get; }
        JetBrains.Metadata.Access.IMetadataAccess MetadataAccess { get; }
        JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] ModuleAttributes { get; }
        System.Guid Mvid { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Metadata.Utils.AssemblyNameInfo> ReferencedAssembliesNames { get; }
        JetBrains.Metadata.Reader.API.IImageBodyReader CreateImageBodyReader();
        JetBrains.Metadata.Reader.API.IMethodBodyUsagesFinder CreateUsagesFinder();
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo[] GetExportedTypes();
        System.Collections.Generic.IDictionary<string, JetBrains.Metadata.Utils.AssemblyNameInfo> GetForwardedTypes();
        JetBrains.Metadata.Reader.API.IMetadataManifestResource[] GetManifestResources();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataType GetTypeFromQualifiedName(string qualifiedName, bool searchReferencedAssemblies);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo GetTypeInfoFromQualifiedName(string qualifiedName, bool searchReferencedAssemblies);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo GetTypeInfoFromToken(JetBrains.Metadata.Access.MetadataToken token);
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo[] GetTypes();
    }
    public interface IMetadataAssemblyInternals
    {
        JetBrains.Metadata.Reader.API.IEntityPresentations EntityPresentations { get; }
        JetBrains.Metadata.Reader.API.MetadataLoader Loader { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Metadata.Access.AssemblyReference> ReferencedAssemblies { get; }
        JetBrains.Metadata.Access.FileReference[] ReferencedFiles { get; }
        JetBrains.Metadata.Reader.API.IMetadataType DecodeType(JetBrains.Metadata.Utils.IBinaryReader reader, JetBrains.Metadata.Reader.API.TypeDecodeContext context);
        JetBrains.Metadata.Reader.API.IMetadataAssembly GetAssemblyFromReferencedFile(JetBrains.Metadata.Access.MetadataToken token);
        JetBrains.Metadata.Reader.API.FieldSpecification GetFieldFromToken(JetBrains.Metadata.Access.MetadataToken fieldToken, JetBrains.Metadata.Reader.API.TypeDecodeContext typeContext);
        JetBrains.Metadata.Reader.API.MethodSpecification GetMethodFromToken(JetBrains.Metadata.Access.MetadataToken methodToken);
        JetBrains.Metadata.Reader.API.MethodSpecification GetMethodFromToken(JetBrains.Metadata.Access.MetadataToken methodToken, JetBrains.Metadata.Reader.API.TypeDecodeContext context);
        JetBrains.Metadata.Reader.API.IMetadataAssembly GetReferencedAssembly(JetBrains.Metadata.Access.MetadataToken assemblyToken);
        JetBrains.Metadata.Reader.API.IMetadataAssembly GetReferencedAssembly(JetBrains.Metadata.Access.AssemblyReference assemblyReference);
        JetBrains.Util.FileSystemPath GetReferencedFile(JetBrains.Metadata.Access.MetadataToken token);
        JetBrains.Metadata.Reader.API.IMetadataType GetTypeFromToken(JetBrains.Metadata.Access.MetadataToken token);
        JetBrains.Metadata.Reader.API.IMetadataType GetTypeFromToken(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.TypeDecodeContext context);
        void ResetReferencedAssembliesCache();
    }
    public interface IMetadataClassType : JetBrains.Metadata.Reader.API.IMetadataType
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataType[] Arguments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo Type { get; }
    }
    public interface IMetadataCustomAttribute : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.MetadataAttributeValue[] ConstructorArguments { get; }
        JetBrains.Metadata.Reader.API.IMetadataCustomAttributeFieldInitialization[] InitializedFields { get; }
        JetBrains.Metadata.Reader.API.IMetadataCustomAttributePropertyInitialization[] InitializedProperties { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod UsedConstructor { get; }
    }
    public interface IMetadataCustomAttributeFieldInitialization
    {
        JetBrains.Metadata.Reader.API.IMetadataField Field { get; }
        JetBrains.Metadata.Reader.API.MetadataAttributeValue Value { get; }
    }
    public interface IMetadataCustomAttributePropertyInitialization
    {
        JetBrains.Metadata.Reader.API.IMetadataProperty Property { get; }
        JetBrains.Metadata.Reader.API.MetadataAttributeValue Value { get; }
    }
    public interface IMetadataEntity : System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataAssembly Assembly { get; }
        JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] CustomAttributes { get; }
        JetBrains.Metadata.Reader.API.MetadataTypeReference[] CustomAttributesTypeNames { get; }
        bool IsResolved { get; }
        JetBrains.Metadata.Access.MetadataToken Token { get; }
        System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.IMetadataCustomAttribute> GetCustomAttributes([JetBrains.Annotations.NotNullAttribute()] string attributeClassFullyQualifiedName);
        bool HasCustomAttribute([JetBrains.Annotations.NotNullAttribute()] string attributeClassFullyQualifiedName);
    }
    public interface IMetadataEvent : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.IMetadataMethod Adder { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod[] OtherMethods { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod Raiser { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod Remover { get; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMetadataField : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        bool HasMarshalSpec { get; }
        uint InitialValueRva { get; }
        bool IsAssembly { get; }
        bool IsFamily { get; }
        bool IsFamilyAndAssembly { get; }
        bool IsFamilyOrAssembly { get; }
        bool IsInitOnly { get; }
        bool IsLiteral { get; }
        bool IsPrivate { get; }
        bool IsPublic { get; }
        bool IsStatic { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        bool NotSerialized { get; }
        int Offset { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.FieldSignature Signature { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        object GetLiteralValue();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.IBlob GetLiteralValueBlob();
    }
    public interface IMetadataForwardedTypeInfo
    {
        JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        string FullName { get; }
    }
    public interface IMetadataFunctionPointerType : JetBrains.Metadata.Reader.API.IMetadataType
    {
        JetBrains.Metadata.Reader.API.MethodSignature MethodSignature { get; }
    }
    public interface IMetadataGenericArgument : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.GenericArgumentAttributes Attributes { get; }
        uint Index { get; }
        JetBrains.Metadata.Reader.API.GenericArgumentKind Kind { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod MethodOwner { get; }
        string Name { get; }
        JetBrains.Metadata.Reader.API.IMetadataType[] TypeConstraints { get; }
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo TypeOwner { get; }
    }
    public interface IMetadataGenericArgumentReferenceType : JetBrains.Metadata.Reader.API.IMetadataType
    {
        JetBrains.Metadata.Reader.API.IMetadataGenericArgument Argument { get; }
    }
    public interface IMetadataManifestResource : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Access.ManifestResourceAttributes Flags { get; }
        JetBrains.Metadata.Access.MetadataToken Implementation { get; }
        string Name { get; }
        uint Offset { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IManifestResourceDisposition GetDisposition();
    }
    public interface IMetadataMethod : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.CodeType CodeType { get; }
        JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] GenericArguments { get; }
        System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.MethodSpecification> ImplementedMethods { get; }
        bool IsAbstract { get; }
        bool IsAssembly { get; }
        bool IsFamily { get; }
        bool IsFamilyAndAssembly { get; }
        bool IsFamilyOrAssembly { get; }
        bool IsFinal { get; }
        bool IsForwardRef { get; }
        bool IsHideBySig { get; }
        bool IsInternalCall { get; }
        bool IsNewSlot { get; }
        bool IsPInvokeImpl { get; }
        bool IsPreserveSig { get; }
        bool IsPrivate { get; }
        bool IsPublic { get; }
        bool IsStatic { get; }
        bool IsSynchronized { get; }
        bool IsUnmanaged { get; }
        bool IsVarArg { get; }
        bool IsVirtual { get; }
        JetBrains.Metadata.Access.CorMethodImpl MethodImplFlags { get; }
        bool NoInlining { get; }
        bool NoOptimization { get; }
        JetBrains.Metadata.Reader.API.IMetadataParameter[] Parameters { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.PInvokeInfo PInvokeInfo { get; }
        JetBrains.Metadata.Reader.API.IMetadataReturnValue ReturnValue { get; }
        JetBrains.Metadata.Reader.API.MethodSignature Signature { get; }
    }
    public interface IMetadataParameter : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.IMetadataMethod DeclaringMethod { get; }
        bool HasDefaultValue { get; }
        bool HasMarshalSpec { get; }
        bool IsIn { get; }
        bool IsOptional { get; }
        bool IsOut { get; }
        bool IsParamArray { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        string Name { get; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        object GetDefaultValue();
        JetBrains.Metadata.Utils.IBlob GetDefaultValueBlob();
    }
    public interface IMetadataPointerType : JetBrains.Metadata.Reader.API.IMetadataType
    {
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMetadataProperty : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.IMetadataMethod Getter { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod[] OtherAccessors { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod Setter { get; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMetadataReferenceType : JetBrains.Metadata.Reader.API.IMetadataType
    {
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMetadataReturnValue : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.IMetadataMethod DeclaringMethod { get; }
        bool HasMarshalSpec { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMetadataSecurityAttribute
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataSecurityRow DeclaringSecurityRow { get; }
        JetBrains.Metadata.Reader.API.IMetadataCustomAttributeFieldInitialization[] InitializedFields { get; }
        JetBrains.Metadata.Reader.API.IMetadataCustomAttributePropertyInitialization[] InitializedProperties { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo Type { get; }
    }
    public interface IMetadataSecurityOwner
    {
        bool HasSecurity { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataSecurityRow[] Security { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string[] SecurityAttributesTypeName { get; }
    }
    public interface IMetadataSecurityRow : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.SecurityAction Action { get; }
        JetBrains.Metadata.Reader.API.IMetadataSecurityAttribute[] Attributes { get; }
    }
    [JetBrains.Annotations.CannotApplyEqualityOperatorAttribute()]
    public interface IMetadataType
    {
        string AssemblyQualification { get; }
        string AssemblyQualifiedName { get; }
        string FullName { get; }
        bool IsResolved { get; }
        bool Pinned { get; }
        JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] TypeModifiers { get; }
        void Accept(JetBrains.Metadata.Reader.API.IMetadataTypeVisitor visitor);
        JetBrains.Metadata.Reader.API.IMetadataType Transform(JetBrains.Metadata.Reader.API.IMetadataTypeTransformer transformer);
    }
    public interface IMetadataTypeInfo : JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        string AssemblyQualifiedName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataClassType Base { get; }
        int ClassSize { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.AssemblyNameInfo DeclaringAssemblyName { get; }
        string FullyQualifiedName { get; }
        JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] GenericParameters { get; }
        JetBrains.Metadata.Reader.API.IMetadataClassType[] Interfaces { get; }
        JetBrains.Metadata.Reader.API.PInvokeInfo.CharSetSpec InteropStringFormat { get; }
        bool IsAbstract { get; }
        bool IsClass { get; }
        bool IsImported { get; }
        bool IsInterface { get; }
        bool IsNested { get; }
        bool IsNestedAssembly { get; }
        bool IsNestedFamily { get; }
        bool IsNestedFamilyAndAssembly { get; }
        bool IsNestedFamilyOrAssembly { get; }
        bool IsNestedPrivate { get; }
        bool IsNestedPublic { get; }
        bool IsNotPublic { get; }
        bool IsPublic { get; }
        bool IsSealed { get; }
        bool IsSerializable { get; }
        bool IsWindowsRuntime { get; }
        JetBrains.Metadata.Reader.API.ClassLayoutType Layout { get; }
        string NamespaceName { get; }
        int PackingSize { get; }
        string TypeName { get; }
        JetBrains.Metadata.Reader.API.IMetadataEvent[] GetEvents();
        JetBrains.Metadata.Reader.API.IMetadataField[] GetFields();
        System.Collections.Generic.IEnumerable<JetBrains.Metadata.Reader.API.MemberInfo> GetMemberInfos();
        JetBrains.Metadata.Reader.API.IMetadataMethod[] GetMethods();
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo[] GetNestedTypes();
        JetBrains.Metadata.Reader.API.IMetadataProperty[] GetProperties();
        bool HasExtensionMethods();
    }
    public interface IMetadataTypeMember : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        bool IsSpecialName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
    }
    public interface IMetadataTypeModifier
    {
        JetBrains.Metadata.Reader.API.MetadataModifierKind Kind { get; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMetadataTypeTransformer
    {
        JetBrains.Metadata.Reader.API.IMetadataType TransformArrayType(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType);
        JetBrains.Metadata.Reader.API.IMetadataType TransformClassType(JetBrains.Metadata.Reader.API.IMetadataClassType classType);
        JetBrains.Metadata.Reader.API.IMetadataType TransformFunctionPointerType(JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType functionPointerType);
        JetBrains.Metadata.Reader.API.IMetadataType TransformGenericArgumentReferenceType(JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType genericArgumentReferenceType);
        JetBrains.Metadata.Reader.API.IMetadataType TransformPointerType(JetBrains.Metadata.Reader.API.IMetadataPointerType pointerType);
        JetBrains.Metadata.Reader.API.IMetadataType TransformReferenceType(JetBrains.Metadata.Reader.API.IMetadataReferenceType referenceType);
    }
    public interface IMetadataTypeVisitor
    {
        void VisitArrayType(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType);
        void VisitClassType(JetBrains.Metadata.Reader.API.IMetadataClassType classType);
        void VisitFunctionPointer(JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType functionPointerType);
        void VisitGenericArgumentReferenceType(JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType genericArgumentReferenceType);
        void VisitPointerType(JetBrains.Metadata.Reader.API.IMetadataPointerType pointerType);
        void VisitReferenceType(JetBrains.Metadata.Reader.API.IMetadataReferenceType referenceType);
        void VisitUnknownType(JetBrains.Metadata.Reader.API.IMetadataType unknownType);
    }
    public interface IMethodBody
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMethodBodyExceptionHandler[] ExceptionHandlers { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.IL.Instruction[] Instructions { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMethodBodyLocalVariable[] LocalVariables { get; }
        int MaxStack { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataMethod Method { get; }
    }
    public interface IMethodBodyExceptionHandler
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataType CatchType { get; }
        int FilterOffset { get; }
        int HandlerLength { get; }
        int HandlerOffset { get; }
        int TryLength { get; }
        int TryOffset { get; }
        JetBrains.Metadata.IL.ExceptionHandlerType Type { get; }
    }
    public interface IMethodBodyLocalVariable
    {
        int Index { get; }
        JetBrains.Metadata.Reader.API.IMetadataMethod Method { get; }
        bool Pinned { get; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMethodBodyUsagesFinder : System.IDisposable
    {
        JetBrains.DataStructures.ImmutableArray<JetBrains.Metadata.Reader.API.IMetadataMethod> FindUsagesOf(JetBrains.Metadata.Reader.API.IMetadataMethod method);
        JetBrains.DataStructures.ImmutableArray<JetBrains.Metadata.Reader.API.IMetadataMethod> FindUsagesOf(JetBrains.Metadata.Reader.API.IMetadataField field);
        JetBrains.DataStructures.ImmutableArray<JetBrains.Metadata.Reader.API.IMetadataMethod> FindUsagesOf(JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo);
    }
    public interface IModuleReferenceResolveContext
    {
        string UniqueName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource);
        bool IsValid();
        void SetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource, JetBrains.Util.FileSystemPath resolveResult);
    }
    public interface ITypeInfoByNameProvider
    {
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo GetTypeInfoFromQualifiedName(string name, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, bool searchReferencedAssemblies);
    }
    public struct MemberInfo
    {
        public readonly string Name;
        public readonly JetBrains.Metadata.Access.MetadataToken Token;
        public MemberInfo(string name, JetBrains.Metadata.Access.MetadataToken token) { }
    }
    public struct MetadataAttributeValue
    {
        public static JetBrains.Metadata.Reader.API.MetadataAttributeValue BadValue;
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public object Value { get; }
        public JetBrains.Metadata.Reader.API.MetadataAttributeValue[] ValuesArray { get; }
        public bool IsBadValue() { }
        public static JetBrains.Metadata.Reader.API.MetadataAttributeValue MakeArray([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType, JetBrains.Metadata.Reader.API.MetadataAttributeValue[] valuesArray) { }
        public static JetBrains.Metadata.Reader.API.MetadataAttributeValue MakeScalar([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType type, object value) { }
        public static JetBrains.Metadata.Reader.API.MetadataAttributeValue MakeScalar([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] string type, object value) { }
        public override string ToString() { }
    }
    public class static MetadataFieldEx
    {
        public static bool IsVolatile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataField field) { }
    }
    public class MetadataLoader : System.IDisposable
    {
        public MetadataLoader(params JetBrains.Util.FileSystemPath[] paths) { }
        public MetadataLoader(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> paths) { }
        public MetadataLoader(JetBrains.Metadata.Access.IMetadataProvider metadataProvider, params JetBrains.Util.FileSystemPath[] paths) { }
        public MetadataLoader(JetBrains.Metadata.Access.IMetadataProvider metadataProvider, System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> paths) { }
        public MetadataLoader(JetBrains.Metadata.Reader.API.IAssemblyResolver resolver) { }
        public MetadataLoader(JetBrains.Metadata.Access.IMetadataProvider metadataProvider, JetBrains.Metadata.Reader.API.IAssemblyResolver resolver) { }
        public void Dispose() { }
        public static JetBrains.Metadata.Reader.API.ElementType FindElementType(JetBrains.Metadata.Reader.API.IMetadataType metadataType) { }
        public static JetBrains.Metadata.Reader.API.MetadataLoader.ElementTypeName GetElementTypeMapping(JetBrains.Metadata.Reader.API.ElementType elementType) { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo GetWellKnownType(JetBrains.Metadata.Reader.API.ElementType elementType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataAssembly LoadAssemblyModule([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath file, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Access.IMetadataAccess access, JetBrains.Metadata.Access.MetadataToken moduleToken, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> predicate, bool loadElementTypes = True) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataAssembly LoadFrom([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> predicate) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataAssembly TryLoad(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> predicate, bool loadElementTypes = True) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataAssembly TryLoadFrom([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> predicate) { }
        public struct ElementTypeName
        {
            public string FullName;
            public string NamespaceName;
            public string TypeName;
        }
    }
    public enum MetadataModifierKind
    {
        Optional = 0,
        Required = 1,
    }
    public class static MetadataParameterEx
    {
        public static int Index(this JetBrains.Metadata.Reader.API.IMetadataParameter parameter) { }
    }
    public class MetadataTypeComparer : System.Collections.Generic.IEqualityComparer<JetBrains.Metadata.Reader.API.IMetadataType>
    {
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.Metadata.Reader.API.IMetadataType> Instance;
        public bool Equals(JetBrains.Metadata.Reader.API.IMetadataType type1, JetBrains.Metadata.Reader.API.IMetadataType type2) { }
        public int GetHashCode(JetBrains.Metadata.Reader.API.IMetadataType type) { }
    }
    public class static MetadataTypeFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataArrayType CreateArrayType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType elementType, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataArrayType CreateArrayType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType elementType, uint rank, uint[] sizes, int[] lBounds, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataClassType CreateClassType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo, JetBrains.Metadata.Reader.API.IMetadataType[] genericArguments = null, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType CreateFunctionPointerType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.MethodSignature methodSignature, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType CreateGenericArgumentReferenceType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataGenericArgument genericArgument, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
        public static JetBrains.Metadata.Reader.API.IMetadataTypeModifier CreateModifier(JetBrains.Metadata.Reader.API.MetadataModifierKind kind, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataPointerType CreatePointerType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType elementType, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataReferenceType CreateReferenceType([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType elementType, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers = null, bool pinned = False) { }
    }
    public struct MetadataTypeReference
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string NamespaceName;
        public static readonly JetBrains.Metadata.Reader.API.MetadataTypeReference Nil;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string TypeName;
        public MetadataTypeReference([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, [JetBrains.Annotations.NotNullAttribute()] string namespaceName, [JetBrains.Annotations.NotNullAttribute()] string typeName) { }
        public JetBrains.Util.dataStructures.StringConcat FullName { get; }
    }
    public class static MetadataTypeUtil
    {
        public static JetBrains.Metadata.Reader.API.IMetadataClassType GetBaseType(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Metadata.Reader.API.IMetadataClassType[] GetInterfaces(this JetBrains.Metadata.Reader.API.IMetadataClassType classType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Reader.API.MetadataLoader GetLoader(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static int GetTypeSize(JetBrains.Metadata.Reader.API.IMetadataTypeInfo type) { }
        public static bool IsMscorlibClassType(this JetBrains.Metadata.Reader.API.IMetadataType type, string fullyQualifiedName) { }
        public static T SubstituteGenericArguments<T>(T inputType, JetBrains.Metadata.Reader.API.IMetadataClassType substitutionsProvider)
            where T : JetBrains.Metadata.Reader.API.IMetadataType { }
        public static T SubstituteGenericArguments<T>(T inputType, JetBrains.Metadata.Reader.API.MethodInstantiation substitutionsProvider)
            where T : JetBrains.Metadata.Reader.API.IMetadataType { }
        public static T SubstituteGenericArguments<T>(JetBrains.Metadata.Reader.API.IMetadataType inputType, System.Collections.Generic.IDictionary<JetBrains.Metadata.Reader.API.IMetadataGenericArgument, JetBrains.Metadata.Reader.API.IMetadataType> substitutions)
            where T : JetBrains.Metadata.Reader.API.IMetadataType { }
    }
    public class MethodInstantiation : System.IEquatable<JetBrains.Metadata.Reader.API.MethodInstantiation>
    {
        public MethodInstantiation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.MethodSpecification methodSpecification, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType[] genericArguments) { }
        public MethodInstantiation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.MethodSpecification methodSpecification) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataType[] GenericArguments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.MethodSpecification MethodSpecification { get; }
        public bool Equals(JetBrains.Metadata.Reader.API.MethodInstantiation other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class MethodSignature : System.IEquatable<JetBrains.Metadata.Reader.API.MethodSignature>
    {
        public MethodSignature(bool isVararg, bool hasThis, uint methodGenericArgumentsCount, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType returnType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType[] parameterTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType[] varargParameterTypes) { }
        public bool HasThis { get; }
        public bool IsVararg { get; }
        public uint MethodGenericArgumentsCount { get; }
        public int ParamCount { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType[] ParameterTypes { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType ReturnType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType[] VarargParameterTypes { get; }
        public bool CanBeCalledBy(JetBrains.Metadata.Reader.API.MethodSignature by) { }
        public bool Equals(JetBrains.Metadata.Reader.API.MethodSignature other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
        public JetBrains.Metadata.Reader.API.MethodSignature TransformTypes(System.Func<JetBrains.Metadata.Reader.API.IMetadataType, JetBrains.Metadata.Reader.API.IMetadataType> transformer) { }
    }
    public class MethodSpecification : System.IEquatable<JetBrains.Metadata.Reader.API.MethodSpecification>
    {
        public static readonly JetBrains.Metadata.Reader.API.MethodSpecification Null;
        public MethodSpecification([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod method, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType[] varargParameters = null) { }
        public MethodSpecification([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod method, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataClassType ownerType, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType[] varargParameters) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Method { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType OwnerType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType[] VarargParameters { get; }
        public bool Equals(JetBrains.Metadata.Reader.API.MethodSpecification other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static ModuleReferenceResolveContextEx
    {
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertIsValid([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
    public class PInvokeInfo
    {
        public PInvokeInfo(JetBrains.Metadata.Access.CorPInvokeMap flags, string moduleName, string importName) { }
        public PInvokeInfo(System.IO.BinaryReader reader) { }
        public JetBrains.Metadata.Reader.API.PInvokeInfo.BestFitFlag BestFit { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo.CallConvSpec CallConv { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo.CharSetSpec CharSet { get; }
        public string ImportName { get; }
        public string ModuleName { get; }
        public bool SupportsLastError { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo.ThrowOnUnmappableFlag ThrowOnUnmappable { get; }
        public void Save(System.IO.BinaryWriter writer) { }
        public enum BestFitFlag
        {
            UseAssemblyDefault = 0,
            Enabled = 16,
            Disabled = 32,
        }
        public enum CallConvSpec
        {
            NotSpecified = 0,
            Winapi = 256,
            Cdecl = 512,
            Stdcall = 768,
            Thiscall = 1024,
            Fastcall = 1280,
        }
        public enum CharSetSpec
        {
            NotSpecified = 0,
            Ansi = 2,
            Unicode = 4,
            Auto = 6,
        }
        public enum ThrowOnUnmappableFlag
        {
            UseAssemblyDefault = 0,
            Enabled = 4096,
            Disabled = 8192,
        }
    }
    public class RecursiveMetadataTypeVisitor : JetBrains.Metadata.Reader.API.IMetadataTypeVisitor
    {
        public virtual void VisitArrayType(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType) { }
        public virtual void VisitClassType(JetBrains.Metadata.Reader.API.IMetadataClassType classType) { }
        public virtual void VisitFunctionPointer(JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType functionPointerType) { }
        public virtual void VisitGenericArgumentReferenceType(JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType genericArgumentReferenceType) { }
        public virtual void VisitPointerType(JetBrains.Metadata.Reader.API.IMetadataPointerType pointerType) { }
        public virtual void VisitReferenceType(JetBrains.Metadata.Reader.API.IMetadataReferenceType referenceType) { }
        public virtual void VisitUnknownType(JetBrains.Metadata.Reader.API.IMetadataType unknownType) { }
    }
    public class ReferencesAssemblyResolver : JetBrains.Metadata.Reader.API.GacAssemblyResolver
    {
        public ReferencesAssemblyResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath originalAssembly, JetBrains.Util.FileSystemPath gacPath, JetBrains.Util.FileSystemPath gacPath40) { }
        protected override JetBrains.Util.FileSystemPath Resolve(JetBrains.Metadata.Utils.AssemblyNameInfo name) { }
    }
    public enum SecurityAction
    {
        ActionNil = 0,
        Request = 1,
        Demand = 2,
        Assert = 3,
        Deny = 4,
        PermitOnly = 5,
        LinkDemand = 6,
        InheritanceDemand = 7,
        RequestMinimum = 8,
        RequestOptional = 9,
        RequestRefuse = 10,
        PrejitGrant = 11,
        PrejitDenied = 12,
        NonCasDemand = 13,
        NonCasLinkDemand = 14,
        NonCasInheritance = 15,
    }
    public class static StandardMemberNames
    {
        public const string ActivatorCreateInstance = "CreateInstance";
        public const string ArrayAddress = "Address";
        public const string ArrayGet = "Get";
        public const string ArrayLength = "Length";
        public const string ArraySet = "Set";
        public const string ByteMaxValue = "MaxValue";
        public const string ByteMinValue = "MinValue";
        public const string CharMaxValue = "MaxValue";
        public const string CharMinValue = "MinValue";
        public const string ClassConstructor = ".cctor";
        public const string Constructor = ".ctor";
        public const string DebuggerBreak = "Break";
        public const string DefaultIndexerName = "Item";
        public const string DelegateCombine = "Combine";
        public const string DelegateInvoke = "Invoke";
        public const string DelegateRemove = "Remove";
        public const string DictionaryAdd = "Add";
        public const string DictionaryTryGetValue = "TryGetValue";
        public const string DoubleMaxValue = "MaxValue";
        public const string DoubleMinValue = "MinValue";
        public const string EventAdderPrefix = "add_";
        public const string EventRemoverPrefix = "remove_";
        public const string HashtableAdd = "Add";
        public const string IDisposableDispose = "Dispose";
        public const string IEnumerable1GetEnumerator = "GetEnumerator";
        public const string IEnumerableGetEnumerator = "GetEnumerator";
        public const string IEnumerator1Current = "Current";
        public const string IEnumerator1MoveNext = "MoveNext";
        public const string IEnumeratorCurrent = "Current";
        public const string IEnumeratorMoveNext = "MoveNext";
        public const string Int16MaxValue = "MaxValue";
        public const string Int16MinValue = "MinValue";
        public const string Int32MaxValue = "MaxValue";
        public const string Int32MinValue = "MinValue";
        public const string Int64MaxValue = "MaxValue";
        public const string Int64MinValue = "MinValue";
        public const string IntPtrToInt64 = "ToInt64";
        public const string IntPtrZero = "Zero";
        public const string IsInterned = "IsInterned";
        public const string MathE = "E";
        public const string MathPi = "PI";
        public const string MethodCodeTypeOfMethodImplAttribute = "MethodCodeType";
        public const string MonitorEnter = "Enter";
        public const string MonitorExit = "Exit";
        public const string NullableGetValueOrDefault = "GetValueOrDefault";
        public const string NullableHasValue = "HasValue";
        public const string ObjectFinalize = "Finalize";
        public const string ObjectToString = "ToString";
        public const string PropertyGetterPrefix = "get_";
        public const string PropertySetterPrefix = "set_";
        public const string RuntimeHelpersInitializeArray = "InitializeArray";
        public const string RuntimeHelpersOffsetToStringData = "OffsetToStringData";
        public const string SByteMaxValue = "MaxValue";
        public const string SByteMinValue = "MinValue";
        public const string SingleMaxValue = "MaxValue";
        public const string SingleMinValue = "MinValue";
        public const string StringChars = "Chars";
        public const string StringConcat = "Concat";
        public const string StringLength = "Length";
        public const string TypeGetTypeFromHandle = "GetTypeFromHandle";
        public const string UInt16MaxValue = "MaxValue";
        public const string UInt16MinValue = "MinValue";
        public const string UInt32MaxValue = "MaxValue";
        public const string UInt32MinValue = "MinValue";
        public const string UInt64MaxValue = "MaxValue";
        public const string UInt64MinValue = "MinValue";
        public const string UIntPtrZero = "Zero";
    }
    public class static StandardOperatorNames
    {
        public const string Addition = "op_Addition";
        public const string AdditionAssignment = "op_AdditionAssignment";
        public const string AddressOf = "op_AddressOf";
        public const string Assign = "op_Assign";
        public const string BitwiseAnd = "op_BitwiseAnd";
        public const string BitwiseAndAssignment = "op_BitwiseAndAssignment";
        public const string BitwiseOr = "op_BitwiseOr";
        public const string BitwiseOrAssignment = "op_BitwiseOrAssignment";
        public const string Comma = "op_Comma";
        public const string Decrement = "op_Decrement";
        public const string Division = "op_Division";
        public const string DivisionAssignment = "op_DivisionAssignment";
        public const string Equality = "op_Equality";
        public const string ExclusiveOr = "op_ExclusiveOr";
        public const string ExclusiveOrAssignment = "op_ExclusiveOrAssignment";
        public const string Explicit = "op_Explicit";
        public const string False = "op_False";
        public const string GreaterThan = "op_GreaterThan";
        public const string GreaterThanOrEqual = "op_GreaterThanOrEqual";
        public const string Implicit = "op_Implicit";
        public const string Increment = "op_Increment";
        public const string Inequality = "op_Inequality";
        public const string LeftShift = "op_LeftShift";
        public const string LeftShiftAssignment = "op_LeftShiftAssignment";
        public const string LessThan = "op_LessThan";
        public const string LessThanOrEqual = "op_LessThanOrEqual";
        public const string LogicalAnd = "op_LogicalAnd";
        public const string LogicalNot = "op_LogicalNot";
        public const string LogicalOr = "op_LogicalOr";
        public const string MemberSelection = "op_MemberSelection";
        public const string Modulus = "op_Modulus";
        public const string ModulusAssignment = "op_ModulusAssignment";
        public const string MultiplicationAssignment = "op_MultiplicationAssignment";
        public const string Multiply = "op_Multiply";
        public const string OnesComplement = "op_OnesComplement";
        public const string PointerDereference = "op_PointerDereference";
        public const string PointerToMemberSelection = "op_PointerToMemberSelection";
        public const string RightShift = "op_RightShift";
        public const string RightShiftAssignment = "op_RightShiftAssignment";
        public const string SignedRightShift = "op_SignedRightShift";
        public const string Subtraction = "op_Subtraction";
        public const string SubtractionAssignment = "op_SubtractionAssignment";
        public const string True = "op_True";
        public const string UnaryNegation = "op_UnaryNegation";
        public const string UnaryPlus = "op_UnaryPlus";
        public const string UnsignedRightShift = "op_UnsignedRightShift";
        public const string UnsignedRightShiftAssignment = "op_UnsignedRightShiftAssignment";
    }
    public class static StandardTypeNames
    {
        public const string Activator = "System.Activator";
        public const string Array = "System.Array";
        public const string AssemlyVersionAttribute = "System.Reflection.AssemblyVersionAttribute";
        public const string AsyncStateMachineAttribute = "System.Runtime.CompilerServices.AsyncStateMachineAttribute";
        public const string Boolean = "System.Boolean";
        public const string Byte = "System.Byte";
        public const string CallingConvention = "System.Runtime.InteropServices.CallingConvention";
        public const string Char = "System.Char";
        public const string CharSet = "System.Runtime.InteropServices.CharSet";
        public const string ComImportAttribute = "System.Runtime.InteropServices.ComImportAttribute";
        public const string CompilerGeneratedAttribute = "System.Runtime.CompilerServices.CompilerGeneratedAttribute";
        public const string DateTime = "System.DateTime";
        public const string Debugger = "System.Diagnostics.Debugger";
        public const string DebuggerStepThroughAttribute = "System.Diagnostics.DebuggerStepThroughAttribute";
        public const string Decimal = "System.Decimal";
        public const string DecimalConstantAttribute = "System.Runtime.CompilerServices.DecimalConstantAttribute";
        public const string DefaultMemberAttribute = "System.Reflection.DefaultMemberAttribute";
        public const string Delegate = "System.Delegate";
        public const string Dictionary = "System.Collections.Generic.Dictionary`2";
        public const string DllImportAttribute = "System.Runtime.InteropServices.DllImportAttribute";
        public const string Double = "System.Double";
        public const string DynamicAttribute = "System.Runtime.CompilerServices.DynamicAttribute";
        public const string Enum = "System.Enum";
        public const string Exception = "System.Exception";
        public const string ExtensionAttribute = "System.Runtime.CompilerServices.ExtensionAttribute";
        public const string FieldOffsetAttribute = "System.Runtime.InteropServices.FieldOffsetAttribute";
        public const string FixedBufferAttribute = "System.Runtime.CompilerServices.FixedBufferAttribute";
        public const string FlagsAttribute = "System.FlagsAttribute";
        public const string Hashtable = "System.Collections.Hashtable";
        public const string ICollection = "System.Collections.ICollection";
        public const string ICollection1 = "System.Collections.Generic.ICollection`1";
        public const string IDisposable = "System.IDisposable";
        public const string IEnumerable = "System.Collections.IEnumerable";
        public const string IEnumerable1 = "System.Collections.Generic.IEnumerable`1";
        public const string IEnumerator = "System.Collections.IEnumerator";
        public const string IEnumerator1 = "System.Collections.Generic.IEnumerator`1";
        public const string IList = "System.Collections.IList";
        public const string IList1 = "System.Collections.Generic.IList`1";
        public const string InAttribute = "System.Runtime.InteropServices.InAttribute";
        public const string IndexerNameAttribute = "System.Runtime.CompilerServices.IndexerNameAttribute";
        public const string Int16 = "System.Int16";
        public const string Int32 = "System.Int32";
        public const string Int64 = "System.Int64";
        public const string IntPtr = "System.IntPtr";
        public const string IsVolatile = "System.Runtime.CompilerServices.IsVolatile";
        public const string LayoutKind = "System.Runtime.InteropServices.LayoutKind";
        public const string MarshalAsAttribute = "System.Runtime.InteropServices.MarshalAsAttribute";
        public const string Math = "System.Math";
        public const string MethodCodeType = "System.Runtime.CompilerServices.MethodCodeType";
        public const string MethodImplAttribute = "System.Runtime.CompilerServices.MethodImplAttribute";
        public const string MethodImplOptions = "System.Runtime.CompilerServices.MethodImplOptions";
        public const string ModuleType = "<Module>";
        public const string Monitor = "System.Threading.Monitor";
        public const string MulticastDelegate = "System.MulticastDelegate";
        public const string NonSerializedAttribute = "System.NonSerializedAttribute";
        public const string Nullable = "System.Nullable`1";
        public const string Object = "System.Object";
        public const string OptionalAttribute = "System.Runtime.InteropServices.OptionalAttribute";
        public const string OutAttribute = "System.Runtime.InteropServices.OutAttribute";
        public const string ParamArrayAttribute = "System.ParamArrayAttribute";
        public const string PermissionSetAttribute = "System.Security.Permissions.PermissionSetAttribute";
        public const string ReferenceAssemblyAttribute = "System.Runtime.CompilerServices.ReferenceAssemblyAttribute";
        public const string RuntimeArgumentHandle = "System.RuntimeArgumentHandle";
        public const string RuntimeFieldHandle = "System.RuntimeFieldHandle";
        public const string RuntimeHelpers = "System.Runtime.CompilerServices.RuntimeHelpers";
        public const string RuntimeMethodHandle = "System.RuntimeMethodHandle";
        public const string RuntimeTypeHandle = "System.RuntimeTypeHandle";
        public const string SByte = "System.SByte";
        public const string SecurityAction = "System.Security.Permissions.SecurityAction";
        public const string SerializableAttribute = "System.SerializableAttribute";
        public const string Single = "System.Single";
        public const string SpecialNameAttribute = "System.Runtime.CompilerServices.SpecialNameAttribute";
        public const string String = "System.String";
        public const string StructLayoutAttribute = "System.Runtime.InteropServices.StructLayoutAttribute";
        public const string TargetFrameworkAttribute = "System.Runtime.Versioning.TargetFrameworkAttribute";
        public const string Type = "System.Type";
        public const string TypedReference = "System.TypedReference";
        public const string UInt16 = "System.UInt16";
        public const string UInt32 = "System.UInt32";
        public const string UInt64 = "System.UInt64";
        public const string UIntPtr = "System.UIntPtr";
        public const string UnmanagedType = "System.Runtime.InteropServices.UnmanagedType";
        public const string ValueType = "System.ValueType";
        public const string VarEnum = "System.Runtime.InteropServices.VarEnum";
        public const string Void = "System.Void";
    }
    public class TypeDecodeContext
    {
        public TypeDecodeContext(JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] typeArguments) { }
        public TypeDecodeContext(JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] typeArguments, JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] methodArguments) { }
        public JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] MethodArguments { get; }
        public JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] TypeArguments { get; }
        public static JetBrains.Metadata.Reader.API.TypeDecodeContext CreateContextFromMethod(JetBrains.Metadata.Reader.API.IMetadataMethod method) { }
        public static JetBrains.Metadata.Reader.API.TypeDecodeContext CreateContextFromType(JetBrains.Metadata.Reader.API.IMetadataTypeInfo type) { }
    }
    public class UniversalModuleReferenceContext : JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Metadata.Reader.API.UniversalModuleReferenceContext Instance;
        public string UniqueName { get; }
        public JetBrains.Util.FileSystemPath GetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource) { }
        public bool IsValid() { }
        public void SetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource, JetBrains.Util.FileSystemPath resolveResult) { }
    }
}
namespace JetBrains.Metadata.Reader.API.MarshalSpec
{
    
    public class ArrayMarshalSpec : JetBrains.Metadata.Reader.API.MarshalSpec.MarshalSpecBase
    {
        public ArrayMarshalSpec(JetBrains.Metadata.Reader.API.MarshalSpec.NativeType elementType, int paramNum, int numElem) { }
        public JetBrains.Metadata.Reader.API.MarshalSpec.NativeType ElementType { get; }
        public int NumElem { get; }
        public int ParamNum { get; }
        public override string ToString() { }
    }
    public class CustomMarshalerMarshalSpec : JetBrains.Metadata.Reader.API.MarshalSpec.MarshalSpecBase
    {
        public CustomMarshalerMarshalSpec(System.Guid guid, string unmanagedType, string managedType, string cookie) { }
        public string Cookie { get; }
        public System.Guid Guid { get; }
        public string ManagedType { get; }
        public string UnmanagedType { get; }
        public override string ToString() { }
    }
    public class FixedArrayMarshalSpec : JetBrains.Metadata.Reader.API.MarshalSpec.MarshalSpecBase
    {
        public FixedArrayMarshalSpec(JetBrains.Metadata.Reader.API.MarshalSpec.NativeType elementType, int numElem) { }
        public JetBrains.Metadata.Reader.API.MarshalSpec.NativeType ElementType { get; }
        public int NumElem { get; }
        public override string ToString() { }
    }
    public class FixedSysStringMarshalSpec : JetBrains.Metadata.Reader.API.MarshalSpec.MarshalSpecBase
    {
        public FixedSysStringMarshalSpec(int size) { }
        public int Size { get; }
        public override string ToString() { }
    }
    public interface IMarshalSpec
    {
        JetBrains.Metadata.Reader.API.MarshalSpec.NativeType Type { get; }
    }
    public class IntrinsicMarshalSpec : JetBrains.Metadata.Reader.API.MarshalSpec.MarshalSpecBase
    {
        public IntrinsicMarshalSpec(JetBrains.Metadata.Reader.API.MarshalSpec.NativeType type) { }
        public override string ToString() { }
    }
    public abstract class MarshalSpecBase : JetBrains.Metadata.Reader.API.MarshalSpec.IMarshalSpec
    {
        protected MarshalSpecBase(JetBrains.Metadata.Reader.API.MarshalSpec.NativeType type) { }
        public JetBrains.Metadata.Reader.API.MarshalSpec.NativeType Type { get; }
    }
    public enum NativeType
    {
        NONE = 102,
        BOOLEAN = 2,
        I1 = 3,
        U1 = 4,
        I2 = 5,
        U2 = 6,
        I4 = 7,
        U4 = 8,
        I8 = 9,
        U8 = 10,
        R4 = 11,
        R8 = 12,
        LPSTR = 20,
        INT = 31,
        UINT = 32,
        FUNC = 38,
        ARRAY = 42,
        CURRENCY = 15,
        BSTR = 19,
        LPWSTR = 21,
        LPTSTR = 22,
        FIXEDSYSSTRING = 23,
        IUNKNOWN = 25,
        IDISPATCH = 26,
        STRUCT = 27,
        INTF = 28,
        SAFEARRAY = 29,
        FIXEDARRAY = 30,
        BYVALSTR = 34,
        ANSIBSTR = 35,
        TBSTR = 36,
        VARIANTBOOL = 37,
        ASANY = 40,
        LPSTRUCT = 43,
        CUSTOMMARSHALER = 44,
        ERROR = 45,
        MAX = 80,
    }
    public class SafeArrayMarshalSpec : JetBrains.Metadata.Reader.API.MarshalSpec.MarshalSpecBase
    {
        public SafeArrayMarshalSpec(JetBrains.Metadata.Reader.API.MarshalSpec.VariantType elementType) { }
        public JetBrains.Metadata.Reader.API.MarshalSpec.VariantType ElementType { get; }
        public override string ToString() { }
    }
    public enum VariantType
    {
        NONE = 0,
        I2 = 2,
        I4 = 3,
        R4 = 4,
        R8 = 5,
        CY = 6,
        DATE = 7,
        BSTR = 8,
        DISPATCH = 9,
        ERROR = 10,
        BOOL = 11,
        VARIANT = 12,
        UNKNOWN = 13,
        DECIMAL = 14,
        I1 = 16,
        UI1 = 17,
        UI2 = 18,
        UI4 = 19,
        INT = 22,
        UINT = 23,
    }
}
namespace JetBrains.Metadata.Reader.Impl
{
    
    public class CombiningAssemblyResolver : JetBrains.Metadata.Reader.API.IAssemblyResolver
    {
        public CombiningAssemblyResolver(params JetBrains.Metadata.Reader.API.IAssemblyResolver[] resolvers) { }
    }
    public class static DecimalConstantUtil
    {
        public static System.Nullable<decimal> ExtractDecimalConstant(JetBrains.Metadata.Utils.IBlob blob) { }
        public static JetBrains.Metadata.Utils.IBlob ExtractDecimalConstantBlob(JetBrains.Metadata.Reader.API.IMetadataEntity owner) { }
    }
    public sealed class EmbeddedManifestResourceDisposition : JetBrains.Metadata.Reader.API.IManifestResourceDisposition
    {
        public EmbeddedManifestResourceDisposition([JetBrains.Annotations.NotNullAttribute()] string resourceName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, long offset) { }
        public string ResourceName { get; }
        public System.IO.Stream CreateResourceReader() { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class EntityPresentations : JetBrains.Metadata.Reader.API.IEntityPresentations
    {
        public EntityPresentations(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Access.MetadataToken[] GetFieldPresentations(JetBrains.Metadata.Reader.API.IMetadataField field) { }
        public JetBrains.Metadata.Access.MetadataToken[] GetMethodPresentations(JetBrains.Metadata.Reader.API.IMetadataMethod method) { }
        public JetBrains.Metadata.Access.MetadataToken GetTokenFromTypeInfo(JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo) { }
        public JetBrains.Metadata.Access.MetadataToken[] GetTypePresentations(JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo) { }
    }
    public class FailAssemblyResolver : JetBrains.Metadata.Reader.API.IAssemblyResolver
    {
        public FailAssemblyResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror, string prefixExceptionMessage = null) { }
    }
    public class FieldSignatureBlobDecoder
    {
        public static TFieldType DecodeFieldSig<TFieldType, TMethodSig>(JetBrains.Metadata.Utils.IBlob signature, JetBrains.Metadata.Reader.Impl.ITypeBuilder<TFieldType, TMethodSig> builder) { }
    }
    public sealed class FileManifestResourceDisposition : JetBrains.Metadata.Reader.API.IManifestResourceDisposition
    {
        public FileManifestResourceDisposition([JetBrains.Annotations.NotNullAttribute()] string resourceName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public string ResourceName { get; }
        public System.IO.Stream CreateResourceReader() { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class HashingSignatureBuilder : JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<JetBrains.ReSharper.Psi.Dependencies.Hash, JetBrains.ReSharper.Psi.Dependencies.Hash>, JetBrains.Metadata.Reader.Impl.ITypeBuilder<JetBrains.ReSharper.Psi.Dependencies.Hash, JetBrains.ReSharper.Psi.Dependencies.Hash>
    {
        public HashingSignatureBuilder(System.Func<JetBrains.Metadata.Access.MetadataToken, JetBrains.ReSharper.Psi.Dependencies.Hash> typeTokenPresenter) { }
        public JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<JetBrains.ReSharper.Psi.Dependencies.Hash, JetBrains.ReSharper.Psi.Dependencies.Hash> MethodSignatureBuilder { get; }
        public JetBrains.ReSharper.Psi.Dependencies.Hash AddOptionalModifier(JetBrains.ReSharper.Psi.Dependencies.Hash type, JetBrains.ReSharper.Psi.Dependencies.Hash modifier) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash AddPinnedConstraint(JetBrains.ReSharper.Psi.Dependencies.Hash type) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash AddRequiredModifier(JetBrains.ReSharper.Psi.Dependencies.Hash type, JetBrains.ReSharper.Psi.Dependencies.Hash modifier) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildArrayType(JetBrains.ReSharper.Psi.Dependencies.Hash elementType, uint rank, uint[] sizes, int[] lBounds) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildArrayType(JetBrains.ReSharper.Psi.Dependencies.Hash elementType) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildClassType(JetBrains.Metadata.Access.MetadataToken typeDefOrRefOrSpecToken) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildFunctionPointer(JetBrains.ReSharper.Psi.Dependencies.Hash fnsig) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildGenericInst(JetBrains.ReSharper.Psi.Dependencies.Hash type, JetBrains.ReSharper.Psi.Dependencies.Hash[] args) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildMethodGenericArgument(uint index) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildMethodSignature(bool isVararg, bool hasThis, uint genericArgumentsCount, JetBrains.ReSharper.Psi.Dependencies.Hash returnType, JetBrains.ReSharper.Psi.Dependencies.Hash[] parameterTypes, JetBrains.ReSharper.Psi.Dependencies.Hash[] varargParameterTypes) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildPointerType(JetBrains.ReSharper.Psi.Dependencies.Hash type) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildReferenceType(JetBrains.ReSharper.Psi.Dependencies.Hash type) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildTypeGenericArgument(uint index) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildUndecodedType() { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash BuildWellKnownType(JetBrains.Metadata.Reader.API.ElementType type) { }
        public JetBrains.Metadata.Reader.Impl.ITypeBuilder<JetBrains.ReSharper.Psi.Dependencies.Hash, JetBrains.ReSharper.Psi.Dependencies.Hash> GetTypeBuilder(uint methodGenericArgumentsCount) { }
    }
    public interface IMethodSignatureBuilder<TType, TSig>
    
    
    {
        TSig BuildMethodSignature(bool isVararg, bool hasThis, uint genericArgumentsCount, TType returnType, TType[] parameterTypes, TType[] varargParameterTypes);
        JetBrains.Metadata.Reader.Impl.ITypeBuilder<TType, TSig> GetTypeBuilder(uint methodGenericArgumentsCount);
    }
    public interface ITypeBuilder<TType, TMethodSig>
    
    
    {
        JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<TType, TMethodSig> MethodSignatureBuilder { get; }
        TType AddOptionalModifier(TType type, TType modifier);
        TType AddPinnedConstraint(TType type);
        TType AddRequiredModifier(TType type, TType modifier);
        TType BuildArrayType(TType elementType, uint rank, uint[] sizes, int[] lBounds);
        TType BuildArrayType(TType elementType);
        TType BuildClassType(JetBrains.Metadata.Access.MetadataToken typeDefOrRefOrSpecToken);
        TType BuildFunctionPointer(TMethodSig fnsig);
        TType BuildGenericInst(TType type, TType[] args);
        TType BuildMethodGenericArgument(uint index);
        TType BuildPointerType(TType type);
        TType BuildReferenceType(TType type);
        TType BuildTypeGenericArgument(uint index);
        TType BuildUndecodedType();
        TType BuildWellKnownType(JetBrains.Metadata.Reader.API.ElementType type);
    }
    public class LoadedAssembliesResolver : JetBrains.Metadata.Reader.API.IAssemblyResolver
    {
        public LoadedAssembliesResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, bool isCheckingShortNameOnly) { }
    }
    public class static MarshalSpecConverter
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Reader.API.ICompilerSpecificAttribute CreateMarshalAsAttribute(JetBrains.Metadata.Reader.API.MarshalSpec.IMarshalSpec marshalSpec, JetBrains.Metadata.Reader.API.IMetadataAssembly context) { }
    }
    public class static MemberRefBlobDecoder
    {
        public static TFieldType DecodeFieldSig<TFieldType, TMethodSig>(JetBrains.Metadata.Utils.IBlob memberRefSignature, JetBrains.Metadata.Reader.Impl.ITypeBuilder<TFieldType, TMethodSig> builder) { }
        public static TSig DecodeMethodSig<TType, TSig>(JetBrains.Metadata.Utils.IBlob memberRefSignature, JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<TType, TSig> builder) { }
        public static JetBrains.Metadata.Reader.Impl.MemberRefBlobDecoder.MemberRefType GetReferenceType(JetBrains.Metadata.Utils.IBlob memberRefSignature) { }
        public enum MemberRefType
        {
            FIELD = 0,
            METHOD = 1,
        }
    }
    public class MetadataArrayType : JetBrains.Metadata.Reader.Impl.MetadataTypeBase, JetBrains.Metadata.Reader.API.IMetadataArrayType, JetBrains.Metadata.Reader.API.IMetadataType
    {
        public MetadataArrayType(JetBrains.Metadata.Reader.API.IMetadataType elementType, uint rank, uint[] sizes, int[] lBounds, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers, bool pinned) { }
        public MetadataArrayType(JetBrains.Metadata.Reader.API.IMetadataType elementType, JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers, bool pinned) { }
        public override string AssemblyQualification { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType ElementType { get; }
        public override string FullName { get; }
        public override bool IsResolved { get; }
        public bool IsVector { get; }
        public int[] LBounds { get; }
        public uint Rank { get; }
        public uint[] Sizes { get; }
        public JetBrains.Metadata.Reader.API.IMetadataArrayTypeInfo TypeInfo { get; }
        public override void Accept(JetBrains.Metadata.Reader.API.IMetadataTypeVisitor visitor) { }
        public static string GetRankText(uint rank, uint[] sizes, int[] lBounds) { }
        public override JetBrains.Metadata.Reader.API.IMetadataType Transform(JetBrains.Metadata.Reader.API.IMetadataTypeTransformer transformer) { }
    }
    public abstract class MetadataEntity : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        protected JetBrains.Metadata.Reader.API.IMetadataAssembly myAssembly;
        protected readonly JetBrains.Metadata.Access.MetadataToken myToken;
        protected MetadataEntity(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataAssembly Assembly { get; }
        public JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] CustomAttributes { get; }
        public JetBrains.Metadata.Reader.API.MetadataTypeReference[] CustomAttributesTypeNames { get; }
        public bool IsResolved { get; }
        public JetBrains.Metadata.Access.MetadataToken Token { get; }
        public virtual bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.IMetadataCustomAttribute> GetCustomAttributes(string attributeClassFullyQualifiedName) { }
        public override int GetHashCode() { }
        public bool HasCustomAttribute(string attributeClassFullyQualifiedName) { }
        protected void SetAssembly(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public virtual string ToString() { }
    }
    public class MetadataEvent : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEvent, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataEvent(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Adder { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public bool IsSpecialName { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod[] OtherMethods { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Raiser { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Remover { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override string ToString() { }
    }
    public class MetadataField : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataField, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataField(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, int fieldOffset) { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public bool HasMarshalSpec { get; }
        public uint InitialValueRva { get; }
        public bool IsAssembly { get; }
        public bool IsFamily { get; }
        public bool IsFamilyAndAssembly { get; }
        public bool IsFamilyOrAssembly { get; }
        public bool IsInitOnly { get; }
        public bool IsLiteral { get; }
        public bool IsPrivate { get; }
        public bool IsPublic { get; }
        public bool IsSpecialName { get; }
        public bool IsStatic { get; }
        public JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        public string Name { get; }
        public bool NotSerialized { get; }
        public int Offset { get; }
        public JetBrains.Metadata.Reader.API.FieldSignature Signature { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public object GetLiteralValue() { }
        public JetBrains.Metadata.Utils.IBlob GetLiteralValueBlob() { }
        public override string ToString() { }
    }
    public class MetadataForwardedTypeInfo : JetBrains.Metadata.Reader.API.IMetadataForwardedTypeInfo
    {
        public MetadataForwardedTypeInfo(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, string typeFullName) { }
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        public string FullName { get; }
    }
    public class MetadataGenericArgument : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataGenericArgument, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataGenericArgument(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.GenericArgumentAttributes Attributes { get; }
        public uint Index { get; }
        public JetBrains.Metadata.Reader.API.GenericArgumentKind Kind { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod MethodOwner { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType[] TypeConstraints { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo TypeOwner { get; }
        public override string ToString() { }
    }
    public class MetadataManifestResource : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataManifestResource, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataManifestResource(JetBrains.Metadata.Access.MetadataToken manifestResourceToken, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Access.ManifestResourceAttributes Flags { get; }
        public JetBrains.Metadata.Access.MetadataToken Implementation { get; }
        public string Name { get; }
        public uint Offset { get; }
        public JetBrains.Metadata.Reader.API.IManifestResourceDisposition GetDisposition() { }
        public override string ToString() { }
    }
    public class MetadataMethod : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataMethod, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataMethod(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.CodeType CodeType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] GenericArguments { get; }
        public bool HasSecurity { get; }
        public System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.MethodSpecification> ImplementedMethods { get; }
        public bool IsAbstract { get; }
        public bool IsAssembly { get; }
        public bool IsFamily { get; }
        public bool IsFamilyAndAssembly { get; }
        public bool IsFamilyOrAssembly { get; }
        public bool IsFinal { get; }
        public bool IsForwardRef { get; }
        public bool IsHideBySig { get; }
        public bool IsInternalCall { get; }
        public bool IsNewSlot { get; }
        public bool IsPInvokeImpl { get; }
        public bool IsPreserveSig { get; }
        public bool IsPrivate { get; }
        public bool IsPublic { get; }
        public bool IsSpecialName { get; }
        public bool IsStatic { get; }
        public bool IsSynchronized { get; }
        public bool IsUnmanaged { get; }
        public bool IsVarArg { get; }
        public bool IsVirtual { get; }
        public JetBrains.Metadata.Access.CorMethodImpl MethodImplFlags { get; }
        public string Name { get; }
        public bool NoInlining { get; }
        public bool NoOptimization { get; }
        public JetBrains.Metadata.Reader.API.IMetadataParameter[] Parameters { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo PInvokeInfo { get; }
        public JetBrains.Metadata.Reader.API.IMetadataReturnValue ReturnValue { get; }
        public JetBrains.Metadata.Reader.API.IMetadataSecurityRow[] Security { get; }
        public string[] SecurityAttributesTypeName { get; }
        public JetBrains.Metadata.Reader.API.MethodSignature Signature { get; }
        public override string ToString() { }
    }
    public class MetadataParameter : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataParameter, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataParameter(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataType type, JetBrains.Metadata.Reader.API.IMetadataMethod method, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod DeclaringMethod { get; }
        public bool HasDefaultValue { get; }
        public bool HasMarshalSpec { get; }
        public bool IsIn { get; }
        public bool IsOptional { get; }
        public bool IsOut { get; }
        public bool IsParamArray { get; }
        public JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public object GetDefaultValue() { }
        public JetBrains.Metadata.Utils.IBlob GetDefaultValueBlob() { }
        public override string ToString() { }
    }
    public class MetadataProperty : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataProperty, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataProperty(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Getter { get; }
        public bool IsSpecialName { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod[] OtherAccessors { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Setter { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override string ToString() { }
    }
    public class MetadataReturnValue : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataReturnValue, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataReturnValue(JetBrains.Metadata.Access.MetadataToken token, JetBrains.Metadata.Reader.API.IMetadataType type, JetBrains.Metadata.Reader.API.IMetadataMethod method, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod DeclaringMethod { get; }
        public bool HasMarshalSpec { get; }
        public JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override string ToString() { }
    }
    public class MetadataSecurityRow : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityRow, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataSecurityRow(JetBrains.Metadata.Access.MetadataToken declSecurityToken, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.SecurityAction Action { get; }
        public JetBrains.Metadata.Reader.API.IMetadataSecurityAttribute[] Attributes { get; }
        public override string ToString() { }
    }
    public class MetadataSpecificTypeNameParser : JetBrains.Metadata.Utils.TypeName.AbstractTypeNameParser<JetBrains.Metadata.Reader.API.IMetadataType>
    {
        public MetadataSpecificTypeNameParser(string typeName, JetBrains.Metadata.Reader.API.ITypeInfoByNameProvider typeInfoByNameProvider, bool searchReferencedAssemblies) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataType CreateArrayType(JetBrains.Metadata.Reader.API.IMetadataType elementType, uint rank, uint[] sizes, int[] lBounds) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataType CreateArrayType(JetBrains.Metadata.Reader.API.IMetadataType elementType) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataType CreatePointerType(JetBrains.Metadata.Reader.API.IMetadataType elementType) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataType CreateReferenceType(JetBrains.Metadata.Reader.API.IMetadataType elementType) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataType CreateTypeByNameAndAssembly(string typeName, JetBrains.Util.TextRange typeNameRange, string assemblyName, JetBrains.Util.TextRange assemblyNameRange, JetBrains.Util.TextRange assemblyFullNameRange, JetBrains.Metadata.Reader.API.IMetadataType[] genericParameters) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataType CreateUnresolvedType(string typeName, JetBrains.Util.TextRange typeNameRange) { }
    }
    public abstract class MetadataTypeBase : JetBrains.Metadata.Reader.API.IMetadataType
    {
        protected MetadataTypeBase(JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] typeModifiers, bool pinned) { }
        public abstract string AssemblyQualification { get; }
        public virtual string AssemblyQualifiedName { get; }
        public abstract string FullName { get; }
        public virtual bool IsResolved { get; }
        public bool Pinned { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeModifier[] TypeModifiers { get; }
        public abstract void Accept(JetBrains.Metadata.Reader.API.IMetadataTypeVisitor visitor);
        public override string ToString() { }
        public abstract JetBrains.Metadata.Reader.API.IMetadataType Transform(JetBrains.Metadata.Reader.API.IMetadataTypeTransformer transformer);
    }
    public class MetadataTypeInfo : JetBrains.Metadata.Reader.Impl.MetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeInfo, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public MetadataTypeInfo(JetBrains.Metadata.Access.MetadataToken token, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public string AssemblyQualifiedName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType Base { get; }
        public int ClassSize { get; }
        public JetBrains.Metadata.Utils.AssemblyNameInfo DeclaringAssemblyName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public string FullyQualifiedName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] GenericParameters { get; }
        public bool HasSecurity { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType[] Interfaces { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo.CharSetSpec InteropStringFormat { get; }
        public bool IsAbstract { get; }
        public bool IsClass { get; }
        public bool IsImported { get; }
        public bool IsInterface { get; }
        public bool IsNestedAssembly { get; }
        public bool IsNestedFamily { get; }
        public bool IsNestedFamilyAndAssembly { get; }
        public bool IsNestedFamilyOrAssembly { get; }
        public bool IsNestedPrivate { get; }
        public bool IsNestedPublic { get; }
        public bool IsNotPublic { get; }
        public bool IsPublic { get; }
        public bool IsSealed { get; }
        public bool IsSerializable { get; }
        public bool IsSpecialName { get; }
        public bool IsWindowsRuntime { get; }
        public JetBrains.Metadata.Reader.API.ClassLayoutType Layout { get; }
        public string Name { get; }
        public string NamespaceName { get; }
        public int PackingSize { get; }
        public JetBrains.Metadata.Reader.API.IMetadataSecurityRow[] Security { get; }
        public string[] SecurityAttributesTypeName { get; }
        public string TypeName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataEvent[] GetEvents() { }
        public JetBrains.Metadata.Reader.API.IMetadataField[] GetFields() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Metadata.Reader.API.MemberInfo> GetMemberInfos() { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod[] GetMethods() { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo[] GetNestedTypes() { }
        public JetBrains.Metadata.Reader.API.IMetadataProperty[] GetProperties() { }
        public bool HasExtensionMethods() { }
        public override string ToString() { }
    }
    public class MetadataTypeModifier : JetBrains.Metadata.Reader.API.IMetadataTypeModifier
    {
        public MetadataTypeModifier(JetBrains.Metadata.Reader.API.MetadataModifierKind kind, JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public JetBrains.Metadata.Reader.API.MetadataModifierKind Kind { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public class static MethodSignatureBlobDecoder
    {
        public static TSig DecodeBlob<TType, TSig>(JetBrains.Metadata.Utils.IBinaryReader reader, JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<TType, TSig> builder) { }
    }
    public class PresentingMethodSignatureBuilder : JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<string, string>
    {
        public PresentingMethodSignatureBuilder(System.Func<JetBrains.Metadata.Access.MetadataToken, string> typeTokenPresenter) { }
        public string BuildMethodSignature(bool isVararg, bool hasThis, uint genericArgumentsCount, string returnType, string[] parameterTypes, string[] varargParameterTypes) { }
        public JetBrains.Metadata.Reader.Impl.ITypeBuilder<string, string> GetTypeBuilder(uint methodGenericArgumentsCount) { }
    }
    public class PresentingTypeBuilder : JetBrains.Metadata.Reader.Impl.ITypeBuilder<string, string>
    {
        public PresentingTypeBuilder(System.Func<JetBrains.Metadata.Access.MetadataToken, string> typeTokenPresenter) { }
        public JetBrains.Metadata.Reader.Impl.IMethodSignatureBuilder<string, string> MethodSignatureBuilder { get; }
        public string AddOptionalModifier(string type, string modifier) { }
        public string AddPinnedConstraint(string type) { }
        public string AddRequiredModifier(string type, string modifier) { }
        public string BuildArrayType(string elementType, uint rank, uint[] sizes, int[] lBounds) { }
        public string BuildArrayType(string elementType) { }
        public string BuildClassType(JetBrains.Metadata.Access.MetadataToken typeDefOrRefOrSpecToken) { }
        public string BuildFunctionPointer(string fnsig) { }
        public string BuildGenericInst(string type, string[] args) { }
        public string BuildMethodGenericArgument(uint index) { }
        public string BuildPointerType(string type) { }
        public string BuildReferenceType(string type) { }
        public string BuildTypeGenericArgument(uint index) { }
        public string BuildUndecodedType() { }
        public string BuildWellKnownType(JetBrains.Metadata.Reader.API.ElementType type) { }
    }
    public class static TypeBlobDecoder
    {
        public static TType DecodeType<TType, TMethodSig>(JetBrains.Metadata.Utils.IBinaryReader reader, JetBrains.Metadata.Reader.Impl.ITypeBuilder<TType, TMethodSig> typeBuilder) { }
    }
    public class UnresolvedField : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataField, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedField([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo declaringType, string name) { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public bool HasMarshalSpec { get; }
        public uint InitialValueRva { get; }
        public bool IsAssembly { get; }
        public bool IsFamily { get; }
        public bool IsFamilyAndAssembly { get; }
        public bool IsFamilyOrAssembly { get; }
        public bool IsInitOnly { get; }
        public bool IsLiteral { get; }
        public bool IsPrivate { get; }
        public bool IsPublic { get; }
        public bool IsSpecialName { get; }
        public bool IsStatic { get; }
        public JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        public string Name { get; }
        public bool NotSerialized { get; }
        public int Offset { get; }
        public JetBrains.Metadata.Reader.API.FieldSignature Signature { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public override int GetHashCode() { }
        public object GetLiteralValue() { }
        public JetBrains.Metadata.Utils.IBlob GetLiteralValueBlob() { }
        public override string ToString() { }
    }
    public class UnresolvedGenericArgument : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataGenericArgument, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedGenericArgument(uint index, JetBrains.Metadata.Reader.API.GenericArgumentKind kind) { }
        public UnresolvedGenericArgument(uint index, JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeOwner) { }
        public UnresolvedGenericArgument(uint index, JetBrains.Metadata.Reader.API.IMetadataMethod method) { }
        public JetBrains.Metadata.Reader.API.GenericArgumentAttributes Attributes { get; }
        public uint Index { get; }
        public JetBrains.Metadata.Reader.API.GenericArgumentKind Kind { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod MethodOwner { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType[] TypeConstraints { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo TypeOwner { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public abstract class UnresolvedMetadataEntity : JetBrains.Metadata.Reader.API.IMetadataEntity, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        protected UnresolvedMetadataEntity(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public JetBrains.Metadata.Reader.API.IMetadataAssembly Assembly { get; }
        public JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] CustomAttributes { get; }
        public JetBrains.Metadata.Reader.API.MetadataTypeReference[] CustomAttributesTypeNames { get; }
        public bool IsResolved { get; }
        public JetBrains.Metadata.Access.MetadataToken Token { get; }
        public abstract bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other);
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.IMetadataCustomAttribute> GetCustomAttributes(string attributeClassFullyQualifiedName) { }
        public virtual int GetHashCode() { }
        public bool HasCustomAttribute(string attributeClassFullyQualifiedName) { }
        public virtual string ToString() { }
    }
    public class UnresolvedMethod : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataMethod, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedMethod(JetBrains.Metadata.Reader.API.IMetadataTypeInfo declaringType, string name, JetBrains.Metadata.Reader.API.MethodSignature signature) { }
        public JetBrains.Metadata.Reader.API.CodeType CodeType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] GenericArguments { get; }
        public bool HasSecurity { get; }
        public System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.MethodSpecification> ImplementedMethods { get; }
        public bool IsAbstract { get; }
        public bool IsAssembly { get; }
        public bool IsFamily { get; }
        public bool IsFamilyAndAssembly { get; }
        public bool IsFamilyOrAssembly { get; }
        public bool IsFinal { get; }
        public bool IsForwardRef { get; }
        public bool IsHideBySig { get; }
        public bool IsInternalCall { get; }
        public bool IsNewSlot { get; }
        public bool IsPInvokeImpl { get; }
        public bool IsPreserveSig { get; }
        public bool IsPrivate { get; }
        public bool IsPublic { get; }
        public bool IsSpecialName { get; }
        public bool IsStatic { get; }
        public bool IsSynchronized { get; }
        public bool IsUnmanaged { get; }
        public bool IsVarArg { get; }
        public bool IsVirtual { get; }
        public JetBrains.Metadata.Access.CorMethodImpl MethodImplFlags { get; }
        public string Name { get; }
        public bool NoInlining { get; }
        public bool NoOptimization { get; }
        public JetBrains.Metadata.Reader.API.IMetadataParameter[] Parameters { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo PInvokeInfo { get; }
        public JetBrains.Metadata.Reader.API.IMetadataReturnValue ReturnValue { get; }
        public JetBrains.Metadata.Reader.API.IMetadataSecurityRow[] Security { get; }
        public string[] SecurityAttributesTypeName { get; }
        public JetBrains.Metadata.Reader.API.MethodSignature Signature { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class UnresolvedParameter : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataParameter, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod declaringMethod, int index) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod DeclaringMethod { get; }
        public bool HasDefaultValue { get; }
        public bool HasMarshalSpec { get; }
        public bool IsIn { get; }
        public bool IsOptional { get; }
        public bool IsOut { get; }
        public bool IsParamArray { get; }
        public JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public object GetDefaultValue() { }
        public JetBrains.Metadata.Utils.IBlob GetDefaultValueBlob() { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class UnresolvedProperty : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataProperty, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo declaringType, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Getter { get; }
        public bool IsSpecialName { get; }
        public string Name { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod[] OtherAccessors { get; }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Setter { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class UnresolvedReturnValue : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataReturnValue, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedReturnValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod declaringMethod, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod DeclaringMethod { get; }
        public bool HasMarshalSpec { get; }
        public JetBrains.Metadata.Utils.IBlob MarshalSpec { get; }
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class UnresolvedTypeInfo : JetBrains.Metadata.Reader.Impl.UnresolvedMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataEntity, JetBrains.Metadata.Reader.API.IMetadataSecurityOwner, JetBrains.Metadata.Reader.API.IMetadataTypeInfo, JetBrains.Metadata.Reader.API.IMetadataTypeMember, System.IEquatable<JetBrains.Metadata.Reader.API.IMetadataEntity>
    {
        public UnresolvedTypeInfo([JetBrains.Annotations.NotNullAttribute()] string fullyQualifiedName) { }
        public UnresolvedTypeInfo([JetBrains.Annotations.NotNullAttribute()] string fullyQualifiedName, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public string AssemblyQualifiedName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType Base { get; }
        public int ClassSize { get; }
        public JetBrains.Metadata.Utils.AssemblyNameInfo DeclaringAssemblyName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo DeclaringType { get; }
        public string FullyQualifiedName { get; }
        public JetBrains.Metadata.Reader.API.IMetadataGenericArgument[] GenericParameters { get; }
        public bool HasSecurity { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType[] Interfaces { get; }
        public JetBrains.Metadata.Reader.API.PInvokeInfo.CharSetSpec InteropStringFormat { get; }
        public bool IsAbstract { get; }
        public bool IsClass { get; }
        public bool IsImported { get; }
        public bool IsInterface { get; }
        public bool IsNested { get; }
        public bool IsNestedAssembly { get; }
        public bool IsNestedFamily { get; }
        public bool IsNestedFamilyAndAssembly { get; }
        public bool IsNestedFamilyOrAssembly { get; }
        public bool IsNestedPrivate { get; }
        public bool IsNestedPublic { get; }
        public bool IsNotPublic { get; }
        public bool IsPublic { get; }
        public bool IsSealed { get; }
        public bool IsSerializable { get; }
        public bool IsSpecialName { get; }
        public bool IsWindowsRuntime { get; }
        public JetBrains.Metadata.Reader.API.ClassLayoutType Layout { get; }
        public string Name { get; }
        public string NamespaceName { get; }
        public int PackingSize { get; }
        public JetBrains.Metadata.Reader.API.IMetadataSecurityRow[] Security { get; }
        public string[] SecurityAttributesTypeName { get; }
        public string TypeName { get; }
        public override bool Equals(JetBrains.Metadata.Reader.API.IMetadataEntity other) { }
        public JetBrains.Metadata.Reader.API.IMetadataEvent[] GetEvents() { }
        public JetBrains.Metadata.Reader.API.IMetadataField[] GetFields() { }
        public override int GetHashCode() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Metadata.Reader.API.MemberInfo> GetMemberInfos() { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod[] GetMethods() { }
        public JetBrains.Metadata.Reader.API.IMetadataTypeInfo[] GetNestedTypes() { }
        public JetBrains.Metadata.Reader.API.IMetadataProperty[] GetProperties() { }
        public bool HasExtensionMethods() { }
        public override string ToString() { }
    }
}
namespace JetBrains.Metadata.Utils
{
    
    public class static AssemblyNameExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly string[] AllPossibleExtensionsForModules;
        public const long MAX_DISTANCE = 9223372036854775807;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo ChooseAssemblyName(JetBrains.Metadata.Utils.AssemblyNameInfo name, System.Collections.Generic.IList<JetBrains.Metadata.Utils.AssemblyNameInfo> candidates, out int index) { }
        public static bool CompareIgnoreCultureAndVersion(JetBrains.Metadata.Utils.AssemblyNameInfo name1, JetBrains.Metadata.Utils.AssemblyNameInfo name2) { }
        public static bool CompareName(JetBrains.Metadata.Utils.AssemblyNameInfo name1, JetBrains.Metadata.Utils.AssemblyNameInfo name2) { }
        public static bool CompareNameAndVersion(JetBrains.Metadata.Utils.AssemblyNameInfo name1, JetBrains.Metadata.Utils.AssemblyNameInfo name2) { }
        public static bool ComparePublicKeyToken(System.Reflection.AssemblyName name, [JetBrains.Annotations.NotNullAttribute()] byte[] token) { }
        public static System.Version CreateVersion(ushort majorVersion, ushort minorVersion, ushort buildNumber, ushort revisionNumber) { }
        public static long Distance([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo required, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo candidate) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath EvaluateFileSystemPath(this JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath FindAssemblyFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath pathFolder, [JetBrains.Annotations.NotNullAttribute()] string sShortAssemblyName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath assemblyPath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo GetNameInfo([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.Assembly ass) { }
        public static byte[] GetPublicKey(string value) { }
        public static byte[] GetPublicKeyToken(string value) { }
        public static void GetPublicKeyTokenString(byte[] value, System.Text.StringBuilder sb) { }
        public static string GetPublicKeyTokenString(byte[] value) { }
        public static bool IsMscorlib(this JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public static bool IsWindowsWinmd(this JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public static bool Matches(JetBrains.Metadata.Utils.AssemblyNameInfo name1, JetBrains.Metadata.Utils.AssemblyNameInfo name2) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo ParseAssemblyName(string assemblyFullName) { }
        public static bool ReferenceMatchesDefinition([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Utils.AssemblyNameInfo @ref, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo def) { }
        public static void SetCodeBase(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, string fullPath) { }
    }
    public sealed class AssemblyNameInfo
    {
        public static readonly JetBrains.Metadata.Utils.AssemblyNameInfo Empty;
        public const int NEUTRAL_KEY_LENGTH = 16;
        public const int PUBLIC_TOKEN_LENGTH = 8;
        public const int SHA1_ALG_ID = 32772;
        public AssemblyNameInfo() { }
        public AssemblyNameInfo(System.Reflection.AssemblyName assemblyName) { }
        public AssemblyNameInfo([JetBrains.Annotations.NotNullAttribute()] string fullName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string CodeBase { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string CultureInfo { get; set; }
        public JetBrains.Metadata.Utils.AssemblyNameInfoFlags Flags { get; set; }
        public string FullName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; set; }
        public System.Reflection.ProcessorArchitecture ProcessorArchitecture { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Version Version { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public byte[] GetPublicKey() { }
        public byte[] GetPublicKeyToken() { }
        public static JetBrains.Metadata.Utils.AssemblyNameInfo Read(System.IO.BinaryReader reader) { }
        public void SetPublicKey(byte[] value, uint hashAlgId) { }
        public void SetPublicKeyToken(byte[] value) { }
        public override string ToString() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo TryParse(string s) { }
        public void Write(System.IO.BinaryWriter writer) { }
    }
    [System.FlagsAttribute()]
    public enum AssemblyNameInfoFlags
    {
        None = 0,
        PublicKey = 1,
        Retargetable = 256,
        WindowsRuntime = 512,
    }
    public class AssemblyNameReader
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameReader CreateReader(JetBrains.Metadata.Utils.IBinaryReader reader, string imageMoniker, bool metadataOnly = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameReader.AssemblyInfo GetAssemblyInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, bool checkForExistence = True) { }
        public JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyName() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public System.Guid GetMvid() { }
        public class AssemblyInfo
        {
            public AssemblyInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, System.Guid mvid) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
            public System.Guid Mvid { get; }
        }
    }
    public class AssemblyResolver : System.IDisposable
    {
        protected readonly System.Collections.Generic.List<JetBrains.Util.FileSystemPath> myBaseDirs;
        protected readonly System.Collections.Generic.JetHashSet<System.AppDomain> myInstalledOn;
        protected readonly System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> myPredicate;
        public AssemblyResolver(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> basedirs) { }
        public AssemblyResolver(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> basedirs, System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> predicate) { }
        public void Dispose() { }
        protected override void Finalize() { }
        public static JetBrains.Metadata.Utils.AssemblyResolver FromAssembly(System.Reflection.Assembly assembly) { }
        public static JetBrains.Metadata.Utils.AssemblyResolver FromAssembly(System.Reflection.Assembly assembly, System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, bool> predicate) { }
        public void Install(System.AppDomain appDomain) { }
        public void Uninstall(System.AppDomain appDomain) { }
    }
    public class static BinaryBlobExtensions
    {
        public static bool CanReadBytes(this JetBrains.Metadata.Utils.IBlob blob, int offset, int count) { }
        public static bool IsEmpty(this JetBrains.Metadata.Utils.IBlob blob) { }
        public static byte[] ReadBytes(this JetBrains.Metadata.Utils.IBlob blob, int offset, int count) { }
        public static uint ReadCompressedInteger(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static short ReadInt16(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static int ReadInt32(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static long ReadInt64(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static sbyte ReadSByte(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static string ReadStringUtf8(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static JetBrains.Metadata.Access.MetadataToken ReadTypeDefOrTypeRefEncoded(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static byte ReadUInt8(this JetBrains.Metadata.Utils.IBlob blob, int offset) { }
        public static byte[] ToArray(this JetBrains.Metadata.Utils.IBlob blob) { }
    }
    public sealed class BinaryBlobReader : JetBrains.Metadata.Utils.IBinaryReader
    {
        public BinaryBlobReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.IBlob blob) { }
        public BinaryBlobReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.IBlob blob, int initialPosition) { }
        public int Length { get; }
        public int Position { get; set; }
        public void Read(byte[] buffer, int offset, int count) { }
        public byte ReadByte() { }
        public char ReadChar() { }
        public uint ReadCompressedInteger() { }
        public double ReadDouble() { }
        public short ReadInt16() { }
        public int ReadInt32() { }
        public long ReadInt64() { }
        public sbyte ReadSByte() { }
        public float ReadSingle() { }
        public string ReadStringUnicode(int length) { }
        public string ReadStringUtf8() { }
        public ushort ReadUInt16() { }
        public uint ReadUInt32() { }
        public ulong ReadUInt64() { }
        public byte ReadUInt8() { }
        public string ReadUtf8Constant() { }
        public void Skip(int bytes) { }
    }
    public class BinaryBlobStream : System.IO.Stream
    {
        public BinaryBlobStream(JetBrains.Metadata.Utils.IBlob blob) { }
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public class static BinaryReaderExtensions
    {
        public static void Align(this JetBrains.Metadata.Utils.IBinaryReader reader, int alignment) { }
        public static bool CanReadBytes(this JetBrains.Metadata.Utils.IBinaryReader reader, int count) { }
        public static bool Eof(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static System.IDisposable Mark(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static string ReadBString(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static byte[] ReadBytes(this JetBrains.Metadata.Utils.IBinaryReader reader, int count) { }
        public static int ReadCompressedSignedInteger(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static string ReadCString(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static decimal ReadDecimal(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static System.Guid ReadGuid(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public static JetBrains.Metadata.Access.MetadataToken ReadTypeDefOrTypeRefEncoded(this JetBrains.Metadata.Utils.IBinaryReader reader) { }
    }
    public class BlobOnReader : JetBrains.Metadata.Utils.IBlob
    {
        public BlobOnReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public int Length { get; }
        public JetBrains.Metadata.Utils.IBlob Clone() { }
        public JetBrains.Metadata.Utils.IBinaryReader CreateReader(int position) { }
        public void Read(int sourceOffset, byte[] buffer, int bufferOffset, int count) { }
        public byte ReadByte(int offset) { }
        public uint ReadCompressedInteger(int offset, out int size) { }
        public short ReadInt16(int offset) { }
        public sbyte ReadSByte(int offset) { }
        public string ReadStringUtf8(int offset, out int bytesLen) { }
        public ushort ReadUInt16(int offset) { }
        public uint ReadUInt32(int offset) { }
        public ulong ReadUInt64(int offset) { }
        public byte ReadUInt8(int offset) { }
        public string ReadUtf8Constant(int offset, out int len) { }
        public JetBrains.Metadata.Utils.IBlob Slice(int position, int length) { }
    }
    public sealed class ComStreamWrapper : System.Runtime.InteropServices.ComTypes.IStream
    {
        public ComStreamWrapper(System.IO.Stream stream) { }
        public void Clone(out System.Runtime.InteropServices.ComTypes.IStream ppstm) { }
        public void Commit(int grfCommitFlags) { }
        public void CopyTo(System.Runtime.InteropServices.ComTypes.IStream pstm, long cb, System.IntPtr pcbRead, System.IntPtr pcbWritten) { }
        public void LockRegion(long libOffset, long cb, int dwLockType) { }
        public void Read(byte[] pv, int cb, System.IntPtr pcbRead) { }
        public void Revert() { }
        public void Seek(long dlibMove, int dwOrigin, System.IntPtr plibNewPosition) { }
        public void SetSize(long libNewSize) { }
        public void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag) { }
        public void UnlockRegion(long libOffset, long cb, int dwLockType) { }
        public void Write(byte[] pv, int cb, System.IntPtr pcbWritten) { }
    }
    public class EmptyBlob : JetBrains.Metadata.Utils.IBlob
    {
        public static readonly JetBrains.Metadata.Utils.IBlob Instance;
        public int Length { get; }
        public JetBrains.Metadata.Utils.IBlob Clone() { }
        public JetBrains.Metadata.Utils.IBinaryReader CreateReader(int position) { }
        public void Read(int sourceOffset, byte[] buffer, int bufferOffset, int count) { }
        public byte ReadByte(int offset) { }
        public uint ReadCompressedInteger(int offset, out int size) { }
        public string ReadStringUtf8(int offset, out int bytesLen) { }
        public ushort ReadUInt16(int offset) { }
        public uint ReadUInt32(int offset) { }
        public ulong ReadUInt64(int offset) { }
        public string ReadUtf8Constant(int offset, out int len) { }
        public JetBrains.Metadata.Utils.IBlob Slice(int position, int length) { }
    }
    public class static GacUtil
    {
        public static readonly JetBrains.Util.Lazy.Lazy<JetBrains.Util.FileSystemPath> SystemGacPath;
        public static readonly JetBrains.Util.Lazy.Lazy<JetBrains.Util.FileSystemPath> SystemGacPath40;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetCandidatesFromGac([JetBrains.Annotations.NotNullAttribute()] string name, JetBrains.Util.FileSystemPath gacPath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetCandidatesFromGac40([JetBrains.Annotations.NotNullAttribute()] string name, JetBrains.Util.FileSystemPath gacPath) { }
        public static JetBrains.Util.FileSystemPath GetGacPath40() { }
        public static JetBrains.Util.FileSystemPath ResolveInGac([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, JetBrains.Util.FileSystemPath gacRootPath) { }
        public static JetBrains.Util.FileSystemPath ResolveInGac40([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, string platform, JetBrains.Util.FileSystemPath gacPath) { }
    }
    public interface IBinaryReader
    {
        int Length { get; }
        int Position { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Utils.IBinaryReader Clone();
        void Read(byte[] buffer, int offset, int count);
        byte ReadByte();
        char ReadChar();
        uint ReadCompressedInteger();
        double ReadDouble();
        short ReadInt16();
        int ReadInt32();
        long ReadInt64();
        sbyte ReadSByte();
        float ReadSingle();
        string ReadStringUnicode(int length);
        string ReadStringUtf8();
        ushort ReadUInt16();
        uint ReadUInt32();
        ulong ReadUInt64();
        byte ReadUInt8();
        string ReadUtf8Constant();
        void Skip(int bytes);
    }
    public interface IBlob
    {
        int Length { get; }
        JetBrains.Metadata.Utils.IBlob Clone();
        JetBrains.Metadata.Utils.IBinaryReader CreateReader(int position);
        void Read(int sourceOffset, byte[] buffer, int bufferOffset, int count);
        byte ReadByte(int offset);
        uint ReadCompressedInteger(int offset, out int size);
        string ReadStringUtf8(int offset, out int bytesLen);
        ushort ReadUInt16(int offset);
        uint ReadUInt32(int offset);
        ulong ReadUInt64(int offset);
        string ReadUtf8Constant(int offset, out int len);
        JetBrains.Metadata.Utils.IBlob Slice(int position, int length);
    }
    public class static ManifestResourceUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataManifestResource GetManifestResource([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly, string resourceName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IManifestResourceDisposition GetManifestResourceDisposition([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly, [JetBrains.Annotations.NotNullAttribute()] string resourceName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IO.Stream GetManifestResourceStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly, [JetBrains.Annotations.NotNullAttribute()] string resourceName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IO.Stream GetManifestResourceStream([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath assemblyLocation, [JetBrains.Annotations.NotNullAttribute()] string resourceName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.IO.Stream TryGetManifestResourceStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly, [JetBrains.Annotations.NotNullAttribute()] string resourceName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.IO.Stream TryGetManifestResourceStream([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath assemblyLocation, [JetBrains.Annotations.NotNullAttribute()] string resourceName) { }
    }
    public class static MarshalSpecParser
    {
        public static JetBrains.Metadata.Reader.API.MarshalSpec.IMarshalSpec Parse([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.IBlob blob) { }
    }
    public class static MetadataHelpers
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataAssembly GetCorlib([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public static JetBrains.Metadata.Reader.API.MetadataTypeReference GetTypeInfoFullName(this JetBrains.Metadata.Access.IMetadataAccess metadataAccess, JetBrains.Metadata.Access.MetadataToken type) { }
        public static JetBrains.Metadata.Reader.API.IMetadataClassType GetUnderlyingEnumType(this JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo) { }
        public static JetBrains.Metadata.Reader.API.IMetadataClassType GetUnderlyingEnumType(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Metadata.Reader.API.IMetadataType GetUnderlyingNullableType(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static bool HasModifier(this JetBrains.Metadata.Reader.API.IMetadataType type, string modifierFqn) { }
        public static bool IsDelegate(this JetBrains.Metadata.Reader.API.IMetadataTypeInfo info) { }
        public static bool IsDelegate(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static bool IsEnum(this JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo) { }
        public static bool IsEnum(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static bool IsModuleType(this JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo) { }
        public static bool IsNullable(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static bool IsSealed(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static bool IsValueType(this JetBrains.Metadata.Reader.API.IMetadataTypeInfo info) { }
        public static bool IsValueType(this JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static System.Runtime.InteropServices.CallingConvention ToCallingConvention(this JetBrains.Metadata.Reader.API.PInvokeInfo.CallConvSpec spec) { }
        public static System.Runtime.InteropServices.CharSet ToCharSet(this JetBrains.Metadata.Reader.API.PInvokeInfo.CharSetSpec spec) { }
        public static System.Runtime.InteropServices.LayoutKind ToLayoutKind(this JetBrains.Metadata.Reader.API.ClassLayoutType layoutType) { }
        public static System.Runtime.CompilerServices.MethodCodeType ToMethodCodeType(this JetBrains.Metadata.Reader.API.CodeType codeType) { }
        public static System.Runtime.InteropServices.UnmanagedType ToUnmanagedType(this JetBrains.Metadata.Reader.API.MarshalSpec.NativeType type) { }
        public static System.Runtime.InteropServices.VarEnum ToVarEnum(this JetBrains.Metadata.Reader.API.MarshalSpec.VariantType type) { }
        public static bool TypeSpecIsInstantiationOf(this JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.Metadata.Access.MetadataToken typeSpec, JetBrains.Metadata.Access.MetadataToken type) { }
    }
    public class static ModuleQualificationUtil
    {
        public static readonly string ASSEMBLY_GROUP;
        public static readonly string ASSEMBLY_PATTERN;
        public static readonly string ASSEMBLY_PATTERN_NO_COMMA;
        public static readonly string CULTURE_GROUP;
        public static readonly string CULTURE_PATTERN;
        public static readonly string FULL_TYPE_NAME_PATTERN;
        public static readonly System.Text.RegularExpressions.Regex FULL_TYPE_NAME_REGEX;
        public static readonly string MODULE_QUALIFICATION_PATTERN;
        public static readonly string MODULE_QUALIFICATION_PATTERN_NO_COMMA;
        public static readonly System.Text.RegularExpressions.Regex MODULE_QUALIFICATION_REGEX;
        public static readonly System.Text.RegularExpressions.Regex MODULE_QUALIFICATION_REGEX_NO_COMMA;
        public static readonly string PUBLIC_KEY_TOKEN_GROUP;
        public static readonly string PUBLIC_KEY_TOKEN_PATTERN;
        public static readonly string TYPE_GROUP;
        public static readonly string TYPE_PATTERN;
        public static readonly string VERSION_GROUP;
        public static readonly string VERSION_PATTERN;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyName(string moduleQualification, out string error, bool hasLeadingComma) { }
        public static string GetTypeName(string qualifiedTypeString, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public static string Optional(string pattern) { }
    }
    [System.FlagsAttribute()]
    public enum SdkAppliesTo
    {
        WindowsAppContainer = 1,
        VisualC = 2,
        VB = 4,
        CSharp = 8,
        WindowsXAML = 16,
        JavaScript = 32,
        Managed = 64,
        Native = 128,
        Undefined = 256,
    }
    public class SdkModuleInfo
    {
        public SdkModuleInfo(string sdkName, JetBrains.Util.FileSystemPath sdkManifestPath, JetBrains.Util.FileSystemPath contentRootPath, string identity, string version, bool isPlatformSdk, JetBrains.Metadata.Utils.SdkAppliesTo appliesTo) { }
        public JetBrains.Metadata.Utils.SdkAppliesTo AppliesTo { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.Util.FileSystemPath> ContentFiles { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.Util.FileSystemPath> HierarchyItems { get; }
        public string Identity { get; }
        public bool IsPlatformSdk { get; }
        public JetBrains.Util.FileSystemPath ManifestPath { get; }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> NestedAssemblies { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath RootFolderForContentFiles { get; }
        public System.Collections.Generic.List<string> SdkDependencies { get; }
        public string SdkName { get; }
        public string Version { get; }
        public void AddContentItem(JetBrains.Util.FileSystemPath absoluteFilePath) { }
        public void DumpFull(System.IO.TextWriter to) { }
        public void DumpShort(System.IO.TextWriter to) { }
        public void RetriveAdditionalInfo(System.Xml.XmlElement fileListElement) { }
    }
    public class StreamBinaryReader : JetBrains.Metadata.Utils.IBinaryReader
    {
        public StreamBinaryReader(System.IO.Stream stream) { }
        public StreamBinaryReader(System.IO.Stream stream, int position) { }
        public int Length { get; }
        public int Position { get; set; }
        public JetBrains.Metadata.Utils.IBinaryReader Clone() { }
        public void Read(byte[] buffer, int offset, int count) { }
        public byte ReadByte() { }
        public char ReadChar() { }
        public uint ReadCompressedInteger() { }
        public double ReadDouble() { }
        public short ReadInt16() { }
        public int ReadInt32() { }
        public long ReadInt64() { }
        public sbyte ReadSByte() { }
        public float ReadSingle() { }
        public string ReadStringUnicode(int length) { }
        public string ReadStringUtf8() { }
        public ushort ReadUInt16() { }
        public uint ReadUInt32() { }
        public ulong ReadUInt64() { }
        public byte ReadUInt8() { }
        public string ReadUtf8Constant() { }
        public void Skip(int bytes) { }
    }
    public class SubStream : System.IO.Stream
    {
        public SubStream(System.IO.Stream parent, long length) { }
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { }
        public override int ReadByte() { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public class TargetPlatformData
    {
        public TargetPlatformData([JetBrains.Annotations.NotNullAttribute()] string targetPlatformIdentifier, [JetBrains.Annotations.NotNullAttribute()] string targetPlatformVersion) { }
        public TargetPlatformData() { }
        public bool IsEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string TargetPlatformIdentifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string TargetPlatformVersion { get; }
        public void Read(System.IO.BinaryReader reader) { }
        public void Write(System.IO.BinaryWriter writer) { }
        public static void WriteEmpty(System.IO.BinaryWriter writer) { }
    }
    public class static ToolLocationHelper
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> EnumerateContentRoots(string sdkRoot, [JetBrains.Annotations.CanBeNullAttribute()] string targetConfiguration = null, [JetBrains.Annotations.CanBeNullAttribute()] string targetArchitecture = null) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetContentRoots(string sdkRoot, [JetBrains.Annotations.CanBeNullAttribute()] string targetConfiguration = null, [JetBrains.Annotations.CanBeNullAttribute()] string targetArchitecture = null) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetContentRootsForSpecifiedTargetPlatform(string sdkRoot, [JetBrains.Annotations.NotNullAttribute()] string targetArchitecture) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetPlatformSDKPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.SdkModuleInfo GetSdkModuleInfo(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> contentRoots, string manifestPath) { }
    }
    public sealed class UnmanagedBlob : JetBrains.Metadata.Utils.IBlob
    {
        public static readonly JetBrains.Metadata.Utils.UnmanagedBlob Empty;
        public UnmanagedBlob(JetBrains.Util.UnmanagedBlock block) { }
        public UnmanagedBlob(JetBrains.Metadata.Utils.UnmanagedBlob source) { }
        public UnmanagedBlob(JetBrains.Metadata.Utils.UnmanagedBlob source, int start) { }
        public UnmanagedBlob(JetBrains.Metadata.Utils.UnmanagedBlob source, int start, int length) { }
        public int Length { get; }
        public JetBrains.Metadata.Utils.IBlob Clone() { }
        public JetBrains.Metadata.Utils.IBinaryReader CreateReader(int position) { }
        public void Read(int sourceOffset, byte[] buffer, int bufferOffset, int count) { }
        public byte ReadByte(int offset) { }
        public uint ReadCompressedInteger(int offset, out int size) { }
        public string ReadStringUtf8(int offset, out int bytesLen) { }
        public ushort ReadUInt16(int offset) { }
        public uint ReadUInt32(int offset) { }
        public ulong ReadUInt64(int offset) { }
        public string ReadUtf8Constant(int offset, out int len) { }
        public JetBrains.Metadata.Utils.IBlob Slice(int position, int length) { }
    }
}
namespace JetBrains.Metadata.Utils.Pdb.Common
{
    
    public class PackedBitSet
    {
        public PackedBitSet(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public bool IsEmpty() { }
        public bool IsSet(int position) { }
    }
    public class PdbException : System.Exception
    {
        public PdbException(string message) { }
    }
    public struct PdbStream
    {
        public PdbStream(uint size, uint[] blocks) { }
        public uint[] Blocks { get; }
        public uint Size { get; }
    }
    public struct PdbStreamInfo
    {
        public PdbStreamInfo(System.IO.BinaryReader reader) { }
        public uint Size { get; }
    }
}
namespace JetBrains.Metadata.Utils.Pdb.Dbi
{
    
    public class DbiDbgHdr
    {
        public DbiDbgHdr(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public DbiDbgHdr(ushort snFPO, ushort snException, ushort snFixup, ushort snOmapToSrc, ushort snOmapFromSrc, ushort snSectionHdr, ushort snTokenRidMap, ushort snXdata, ushort snPdata, ushort snNewFPO, ushort snSectionHdrOrig) { }
        public ushort SnException { get; }
        public ushort SnFixup { get; }
        public ushort SnFPO { get; }
        public ushort SnNewFPO { get; }
        public ushort SnOmapFromSrc { get; }
        public ushort SnOmapToSrc { get; }
        public ushort SnPdata { get; }
        public ushort SnSectionHdr { get; }
        public ushort SnSectionHdrOrig { get; }
        public ushort SnTokenRidMap { get; }
        public ushort SnXdata { get; }
    }
    public class DbiFileInfo
    {
        public DbiFileInfo(JetBrains.Metadata.Utils.IBinaryReader reader, JetBrains.Util.ReadOnlyList<JetBrains.Metadata.Utils.Pdb.Dbi.DbiModuleInfo> modules) { }
        public JetBrains.Util.OneToListMap<JetBrains.Metadata.Utils.Pdb.Dbi.DbiModuleInfo, string> Files { get; }
    }
    public class DbiHeader
    {
        public DbiHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public int Age { get; }
        public int DbgHdrSize { get; }
        public int EcInfoSize { get; }
        public int FileInfoSize { get; }
        public ushort Flags { get; }
        public int GpModSectionSize { get; }
        public short GsSymStream { get; }
        public ushort Machine { get; }
        public int MfcIndex { get; }
        public ushort PdbVer { get; }
        public ushort PdbVer2 { get; }
        public short PsSymStream { get; }
        public int Reserved { get; }
        public int SectionContributionSize { get; }
        public int SectionMapSize { get; }
        public int Sig { get; }
        public short SymRecStream { get; }
        public int TsMapSize { get; }
        public int Ver { get; }
        public ushort Vers { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{ModuleName} {ObjectName}")]
    public class DbiModuleInfo
    {
        public DbiModuleInfo(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public int CbLines { get; }
        public int CbOldLines { get; }
        public int CbSyms { get; }
        public short Files { get; }
        public ushort Flags { get; }
        public string ModuleName { get; }
        public int NiCompiler { get; }
        public int NiSource { get; }
        public string ObjectName { get; }
        public uint Offsets { get; }
        public int Opened { get; }
        public JetBrains.Metadata.Utils.Pdb.Dbi.DbiSecCon SecCon { get; }
        public short Stream { get; }
    }
    public class DbiSecCon
    {
        public DbiSecCon(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public uint DataCrc { get; }
        public uint Flags { get; }
        public short Module { get; }
        public int Offset { get; }
        public uint RelocCrc { get; }
        public short Section { get; }
        public int Size { get; }
    }
    public class DbiStreamInfo
    {
        public DbiStreamInfo(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public JetBrains.Metadata.Utils.Pdb.Dbi.DbiDbgHdr DbgHeader { get; }
        public JetBrains.Metadata.Utils.Pdb.Dbi.DbiFileInfo FileInfo { get; }
        public JetBrains.Metadata.Utils.Pdb.Dbi.DbiHeader Header { get; }
        public JetBrains.Util.ReadOnlyList<JetBrains.Metadata.Utils.Pdb.Dbi.DbiModuleInfo> Modules { get; }
    }
}
namespace JetBrains.Metadata.Utils.Pdb.DebugSubsection
{
    
    public class LocalVariablesNameProvider : JetBrains.Metadata.IL.IMetadataLocalVariablesNameProvider
    {
        public LocalVariablesNameProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.Pdb.DebugSubsection.SourceFileInfo sourceFileInfo) { }
        public string GetVariableName(JetBrains.Metadata.Reader.API.IMetadataMethod methodBody, int index) { }
    }
    public class SourceFileInfo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.ReadOnlyDictionary<JetBrains.Metadata.Access.MetadataToken, JetBrains.Metadata.Utils.Pdb.PdbFunction> Functions;
    }
}
namespace JetBrains.Metadata.Utils.Pdb
{
    
    public interface IPdbStreamBuilder
    {
        System.IO.Stream GetDbiStream();
        System.IO.Stream GetNamesStream();
        System.IO.Stream GetSrcFileStream(string name);
        System.IO.Stream GetSrcSrvStream();
        string GetStreamName(int name);
    }
    public class ParsedPdb
    {
        public ParsedPdb(JetBrains.Util.DataStructures.CompactOneToListMap<string, string> type2Files, JetBrains.Metadata.Utils.Pdb.SrcSrv.SrcSrvInfo srcSrvInfo, JetBrains.Metadata.Utils.Pdb.DebugSubsection.SourceFileInfo sourceFileInfo, System.DateTime pdbTimestamp) { }
        public System.DateTime PdbTimestamp { get; }
        public JetBrains.Metadata.Utils.Pdb.DebugSubsection.SourceFileInfo SourceFileInfo { get; }
        public JetBrains.Metadata.Utils.Pdb.SrcSrv.SrcSrvInfo SrcSrvInfo { get; }
        public JetBrains.Util.DataStructures.CompactOneToListMap<string, string> Type2Files { get; }
        public void DumpSelf(System.IO.TextWriter writer) { }
        public int GetByteCount(System.Text.Encoding encoding) { }
        public static JetBrains.Metadata.Utils.Pdb.ParsedPdb ReadFrom(System.IO.BinaryReader reader) { }
        public bool ReferencesFile(JetBrains.Util.FileSystemPath fileName) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class PdbFile : JetBrains.Metadata.Utils.Pdb.IPdbStreamBuilder
    {
        public PdbFile(System.IO.Stream pdbStream) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Utils.Pdb.Dbi.DbiStreamInfo Dbi { get; }
        public JetBrains.Metadata.Utils.Pdb.PdbHeader Header { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use IPdbStreamBuilder member for get pdb stream")]
        public JetBrains.Util.ReadOnlyDictionary<string, int> NameIndex { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use IPdbStreamBuilder member for get pdb stream")]
        public JetBrains.Util.ReadOnlyDictionary<int, string> NameStream { get; }
        public System.IO.Stream GetDbiStream() { }
        public System.IO.Stream GetNamesStream() { }
        public JetBrains.Metadata.Utils.Pdb.PdbRootRecord GetRoot() { }
        public JetBrains.Metadata.Utils.Pdb.DebugSubsection.SourceFileInfo GetSourceFileInfo(bool loadStatements) { }
        public System.IO.Stream GetSrcFileStream(string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.Pdb.SrcSrv.SrcSrvInfo GetSrcSrvInfo() { }
        public System.IO.Stream GetSrcSrvStream() { }
        public string GetStreamName(int name) { }
    }
    public class PdbFunction
    {
        public readonly uint Address;
        public static readonly System.Collections.Generic.IComparer<JetBrains.Metadata.Utils.Pdb.PdbFunction> ByAddressAndToken;
        public readonly string Name;
        public readonly ushort Segment;
        public PdbFunction(ushort sec, uint off) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.Pdb.PdbLine[] Lines { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.ReadOnlyDictionary<uint, JetBrains.Metadata.Utils.Pdb.PdbVariable> Slots { get; }
        public JetBrains.Metadata.Access.MetadataToken Token { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Utils.Pdb.PdbFunction[] LoadManagedFunctions(JetBrains.Metadata.Utils.StreamBinaryReader moduleStream, int initialPosition, int endPosition) { }
        public static void LoadManagedLines(JetBrains.Metadata.Utils.StreamBinaryReader moduleStream, int startManagedLines, int endManagedLines, JetBrains.Metadata.Utils.Pdb.PdbFunction[] func, System.Collections.Generic.IDictionary<int, JetBrains.Metadata.Utils.Pdb.PdbSource> checks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.ReadOnlyDictionary<int, JetBrains.Metadata.Utils.Pdb.PdbSource> LoadReadSourceFileInfo(JetBrains.Metadata.Utils.StreamBinaryReader moduleStream, int startManagedLines, int endManagedLines, JetBrains.Metadata.Utils.Pdb.IPdbStreamBuilder pdbStreamBuilder) { }
        public void MergeFunction(JetBrains.Metadata.Utils.Pdb.PdbFunction pdbFunction) { }
        public static void SkipDebugSubsection(JetBrains.Metadata.Utils.StreamBinaryReader moduleStream, int initialPosition, int endPosition) { }
    }
    public struct PdbHeader
    {
        public const int HeaderSize = 56;
        public uint BlockSize { get; }
        public uint FirstPage { get; }
        public uint NumPages { get; }
        public string Signature { get; }
        public uint TocBlocksPage { get; }
        public uint TocSize { get; }
    }
    public class PdbLine
    {
        public readonly JetBrains.Metadata.Utils.Pdb.PdbSource File;
        public readonly JetBrains.Metadata.Utils.Pdb.PdbSequencePoint SequencePoint;
    }
    [System.FlagsAttribute()]
    public enum PdbParseLevel
    {
        None = 0,
        LoadFunc = 1,
        LoadFuncAndStatement = 3,
    }
    public class PdbReader
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.Pdb.ParsedPdb ReadPdb(JetBrains.Util.FileSystemPath pdbPath, JetBrains.Metadata.Utils.Pdb.PdbParseLevel level) { }
    }
    public class PdbRootRecord
    {
        public PdbRootRecord(System.IO.BinaryReader rdr) { }
        public uint Age { get; }
        public System.Guid SymId { get; }
        public uint TimeDateStamp { get; }
        public uint Version { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("PdbSequencePoint: {Offset} {LineBegin} {Statement}")]
    public class PdbSequencePoint
    {
        public const int InvalidLine = 16707566;
        public ushort ColBegin { get; }
        public ushort ColEnd { get; }
        public bool IsValidLine { get; }
        public uint LineBegin { get; }
        public uint LineEnd { get; }
        public uint Offset { get; }
        public bool Statement { get; }
    }
    public class PdbSource
    {
        public readonly System.Guid DoctypeGuid;
        public readonly int Index;
        public readonly System.Guid LanguageGuid;
        public readonly string Name;
        public readonly System.Guid VendorGuid;
        public PdbSource(int index, string name, System.Guid doctypeGuid, System.Guid languageGuid, System.Guid vendorGuid) { }
    }
    public class PdbToc
    {
        public JetBrains.Metadata.Utils.Pdb.Common.PdbStream[] Streams { get; }
    }
    public class PdbVariable
    {
        public string Name { get; }
        public uint SlotIndex { get; }
    }
}
namespace JetBrains.Metadata.Utils.Pdb.SrcSrv
{
    
    public class SourceLocation
    {
        public SourceLocation(string localPath, JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocationKind locationKind, string location) { }
        public SourceLocation(System.Func<string, string> localPathGenerator, JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocationKind locationKind, System.Func<string, string> locationGenerator) { }
        public JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocationKind LocationKind { get; }
        public string GetLocalPath(string cacheDirectory = "") { }
        public string GetLocation(string cacheDirectory) { }
    }
    public class static SourceLocationHelper
    {
        public static JetBrains.Util.FileSystemPath GetLocalPath(this JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocation sourceLocation, JetBrains.Util.FileSystemPath cacheDirectory) { }
    }
    public enum SourceLocationKind
    {
        PATH = 0,
        CMD = 1,
        HTTP = 2,
    }
    public class SrcSrvInfo
    {
        public SrcSrvInfo(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> ini, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> variables, string[] fileComponents) { }
        public string[] FileComponents { get; }
        public System.Collections.Generic.IDictionary<string, string> Ini { get; }
        public System.Collections.Generic.IDictionary<string, string> Variables { get; }
        public void DumpSelf(System.IO.TextWriter writer, int indent, int maxComponentsToDump) { }
        public int GetByteCount(System.Text.Encoding encoding) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocation GetFileLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath srcPath) { }
        public bool IsOurLocalPath(JetBrains.Util.FileSystemPath localPath) { }
        public bool MayHaveMappingFor(string shortFileName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Utils.Pdb.SrcSrv.SrcSrvInfo ReadFrom(System.IO.BinaryReader reader) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class SrcSrvInfoParser
    {
        public static JetBrains.Metadata.Utils.Pdb.SrcSrv.SrcSrvInfo ParsePdbStream(System.IO.TextReader stream) { }
    }
}
namespace JetBrains.Metadata.Utils.PE
{
    
    [System.FlagsAttribute()]
    public enum Characteristics : ushort
    {
        RELOCS_STRIPPED = 1,
        EXECUTABLE_IMAGE = 2,
        LINE_NUMS_STRIPPED = 4,
        LOCAL_SYMS_STRIPPED = 8,
        AGGRESIVE_WS_TRIM = 16,
        LARGE_ADDRESS_AWARE = 32,
        BYTES_REVERSED_LO = 128,
        MACHINE_32BIT = 256,
        DEBUG_STRIPPED = 512,
        REMOVABLE_RUN_FROM_SWAP = 1024,
        NET_RUN_FROM_SWAP = 2048,
        SYSTEM = 4096,
        DLL = 8192,
        UP_SYSTEM_ONLY = 16384,
        BYTES_REVERSED_HI = 32768,
    }
    [System.FlagsAttribute()]
    public enum CLIFlags
    {
        IL_ONLY = 1,
        REQUIRED_32BIT = 2,
        STRONGNAME_SIGNED = 8,
        TRACK_DEBUG_DATA = 65536,
    }
    public sealed class CLIHeader
    {
        public CLIHeader(JetBrains.Metadata.Utils.IBinaryReader reader, JetBrains.Metadata.Utils.PE.PEFile file) { }
        public JetBrains.Metadata.Utils.PE.DataDirectory CodeManagerTable { get; }
        public int EntryPointToken { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory ExportAddressTableJumps { get; }
        public JetBrains.Metadata.Utils.PE.CLIFlags Flags { get; }
        public ushort MajorRuntimeVersion { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory ManagedNativeHeader { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory MetaData { get; }
        public int MetadataStartOffset { get; }
        public ushort MinorRuntimeVersion { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory Resources { get; }
        public uint Size { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory StrongNameSignature { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory VTableFixups { get; }
    }
    public sealed class CoffHeader
    {
        public CoffHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public JetBrains.Metadata.Utils.PE.Characteristics Characteristics { get; }
        public JetBrains.Metadata.Utils.PE.MachineId Machine { get; }
        public ushort NumberOfSections { get; }
        public uint NumberOfSymbols { get; }
        public JetBrains.Metadata.Utils.PE.OptHeaderSize OptionalHeaderSize { get; }
        public uint PointerToSymbolTable { get; }
        public uint Signature { get; }
        public uint TimeStamp { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("RVA={myRva} Size={mySize}")]
    public sealed class DataDirectory
    {
        public DataDirectory(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public uint RVA { get; }
        public int Size { get; }
    }
    public sealed class DosHeader
    {
        public const ushort SIGNATURE = 23117;
        public DosHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public ushort Cblp { get; }
        public ushort Cp { get; }
        public ushort CparHdr { get; }
        public ushort Crlc { get; }
        public ushort Cs { get; }
        public ushort CSum { get; }
        public ushort Ip { get; }
        public uint LfaNew { get; }
        public ushort LfaRlc { get; }
        public ushort Magic { get; }
        public ushort MaxAlloc { get; }
        public ushort MinAlloc { get; }
        public ushort OemId { get; }
        public ushort OemInfo { get; }
        public ushort OvNo { get; }
        public ushort[] Res { get; }
        public ushort[] Res2 { get; }
        public ushort Sp { get; }
        public ushort Ss { get; }
    }
    public enum ExeSignature : ushort
    {
        UNKNOWN = 0,
        DOS = 23117,
        OS2 = 17742,
        OS2_LE = 17740,
        VXD = 17740,
        NT = 17744,
        NT2 = 0,
    }
    public enum MachineId : ushort
    {
        UNKNOWN = 0,
        I386 = 332,
        I486 = 333,
        PENTIUM = 334,
        R3000_BE = 352,
        R3000 = 354,
        R4000 = 358,
        R10000 = 360,
        WCEMIPSV2 = 361,
        ALPHA = 388,
        SH3 = 418,
        SH3DSP = 419,
        SH3E = 420,
        SH4 = 422,
        SH5 = 424,
        ARM = 448,
        THUMB = 450,
        AM33 = 467,
        POWERPC = 496,
        POWERPCFP = 497,
        IA64 = 512,
        MIPS16 = 614,
        ALPHA64 = 644,
        MIPSFPU = 870,
        MIPSFPU16 = 1126,
        AXP64 = 644,
        TRICORE = 1312,
        CEF = 3311,
        EBC = 3772,
        AMD64 = 34404,
        M32R = 37124,
        CEE = 49390,
    }
    public sealed class MetadataHeader
    {
        public const int SIGNATURE = 1112167234;
        public MetadataHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public int Flags { get; }
        public ushort MajorVersion { get; }
        public ushort MinorVersion { get; }
        public uint Reserved { get; }
        public uint Signature { get; }
        public JetBrains.Metadata.Utils.PE.StreamHeader[] StreamHeaders { get; }
        public string VersionString { get; }
    }
    public class MetadataReaderException : System.Exception
    {
        public MetadataReaderException(string message) { }
        public MetadataReaderException(string message, System.Exception innerException) { }
        protected MetadataReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum OptHeaderSize : ushort
    {
        IMAGE_SIZEOF_ROM_OPTIONAL_HEADER = 56,
        IMAGE_SIZEOF_STD_OPTIONAL_HEADER = 28,
        IMAGE_SIZEOF_NT_OPTIONAL32_HEADER = 224,
        IMAGE_SIZEOF_NT_OPTIONAL64_HEADER = 240,
    }
    public class OptionalNtHeader32 : JetBrains.Metadata.Utils.PE.OptionalNTHeaderBase
    {
        public OptionalNtHeader32(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public uint HeapCommitSize { get; }
        public uint HeapReserveSize { get; }
        public uint StackCommitSize { get; }
        public uint StackReserveSize { get; }
        protected override void ReadStackHeapSizes(JetBrains.Metadata.Utils.IBinaryReader reader) { }
    }
    public class OptionalNtHeader64 : JetBrains.Metadata.Utils.PE.OptionalNTHeaderBase
    {
        public OptionalNtHeader64(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public long HeapCommitSize { get; }
        public long HeapReserveSize { get; }
        public long StackCommitSize { get; }
        public long StackReserveSize { get; }
        protected override void ReadStackHeapSizes(JetBrains.Metadata.Utils.IBinaryReader reader) { }
    }
    public abstract class OptionalNTHeaderBase
    {
        protected OptionalNTHeaderBase(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public ushort DllCharacteristics { get; }
        public uint FileAlignment { get; }
        public uint FileChecksum { get; }
        public uint HeaderSize { get; }
        public uint ImageBase { get; }
        public uint ImageSize { get; }
        public uint LoaderFlags { get; }
        public ushort MajorImageVersion { get; }
        public ushort MajorOperatingSystemVersion { get; }
        public ushort MajorSubsystemVersion { get; }
        public ushort MinorImageVersion { get; }
        public ushort MinorOperatingSystemVersion { get; }
        public ushort MinorSubsystemVersion { get; }
        public uint NumberOfDataDirectories { get; }
        public uint Reserved { get; }
        public uint SectionAlignment { get; }
        public ushort SubSystem { get; }
        protected abstract void ReadStackHeapSizes(JetBrains.Metadata.Utils.IBinaryReader reader);
    }
    public class static PEDictionaryEntry
    {
        public const int DELAY_IMPORT = 13;
        public const int ENTRY_ARCHITECTURE = 7;
        public const int ENTRY_BASERELOC = 5;
        public const int ENTRY_BOUND_IMPORT = 11;
        public const int ENTRY_COM_DESCRIPTOR = 14;
        public const int ENTRY_DEBUG = 6;
        public const int ENTRY_EXCEPTION = 3;
        public const int ENTRY_EXPORT = 0;
        public const int ENTRY_GLOBALPTR = 8;
        public const int ENTRY_IAT = 12;
        public const int ENTRY_IMPORT = 1;
        public const int ENTRY_LOAD_CONFIG = 10;
        public const int ENTRY_RESOURCE = 2;
        public const int ENTRY_SECURITY = 4;
        public const int ENTRY_TLS = 9;
        public const int ENTRY_UNKNOWN = 15;
    }
    public class PEFile
    {
        public readonly int EndOffset;
        public PEFile(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.PE.CLIHeader CLIHeader { get; }
        public JetBrains.Metadata.Utils.PE.CoffHeader COFFheader { get; }
        public JetBrains.Metadata.Utils.PE.DosHeader DOSheader { get; }
        public JetBrains.Metadata.Utils.PE.DataDirectory[] Entries { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.PE.MetadataHeader MetadataHeader { get; }
        public JetBrains.Metadata.Utils.PE.OptionalNTHeaderBase NTHeader { get; }
        public JetBrains.Metadata.Utils.PE.PEHeader PEHeader { get; }
        public JetBrains.Metadata.Utils.IBinaryReader Reader { get; }
        public JetBrains.Metadata.Utils.PE.SectionHeader[] Sections { get; }
        public object GetDirectory(int directoryId) { }
        public int RvaToVa(uint rva) { }
    }
    public class static PEFileEx
    {
        public static JetBrains.Metadata.Utils.PE.Directories.DebugInfo7 GetDebugInfo7(this JetBrains.Metadata.Utils.PE.PEFile peFile) { }
        public static string GetPdbName(this JetBrains.Metadata.Utils.PE.PEFile peFile) { }
        public static string GetPdbSignature(this JetBrains.Metadata.Utils.PE.PEFile peFile) { }
        public static JetBrains.Metadata.Utils.PE.Directories.EntireResourceDirectory GetResources(this JetBrains.Metadata.Utils.PE.PEFile peFile) { }
    }
    public sealed class PEHeader
    {
        public PEHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public int BaseOfCode { get; }
        public int BaseOfData { get; }
        public int CodeSize { get; }
        public int EntryPointRva { get; }
        public int InitializedDataSize { get; }
        public JetBrains.Metadata.Utils.PE.PESignature Magic { get; }
        public byte MajorLinkerVersion { get; }
        public byte MinorLinkerVersion { get; }
        public int UninitializedDataSize { get; }
    }
    public enum PESignature : ushort
    {
        PE_32BIT = 267,
        PE_64BIT = 523,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Start={myVirtualAddress} Size={myVirtualSize}")]
    public sealed class SectionHeader
    {
        public SectionHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public int Characteristics { get; }
        public string Name { get; }
        public ushort NumberOfLineNumbers { get; }
        public ushort NumberOfRelocations { get; }
        public int PointerToLineNumbers { get; }
        public int PointerToRawData { get; }
        public int PointerToRelocations { get; }
        public int SizeOfRawData { get; }
        public int VirtualAddress { get; }
        public int VirtualSize { get; }
    }
    public sealed class SectionHeaderTable : System.Collections.DictionaryBase
    {
        public JetBrains.Metadata.Utils.PE.SectionHeader this[string name] { get; }
    }
    public sealed class StreamHeader
    {
        public StreamHeader(JetBrains.Metadata.Utils.IBinaryReader reader) { }
        public string Name { get; }
        public int Offset { get; }
        public int Size { get; }
    }
    public enum Subsystem : short
    {
        UNKNOWN = 0,
        NATIVE = 1,
        WINDOWS_GUI = 2,
        WINDOWS_CUI = 3,
        OS2_CUI = 5,
        POSIX_CUI = 7,
        NATIVE_WINDOWS = 8,
        WINDOWS_CE_GUI = 9,
        EFI_APPLICATION = 10,
        EFI_BOOT_SERVICE_DRIVER = 11,
        EFI_RUNTIME_DRIVER = 12,
        EFI_ROM = 13,
        XBOX = 14,
    }
}
namespace JetBrains.Metadata.Utils.PE.Directories
{
    
    public class DebugDirectory : JetBrains.Metadata.Utils.PE.Directories.PEDirectoryBase
    {
        public Entry[] Entries { get; }
        public override void Read(JetBrains.Metadata.Utils.IBinaryReader rdr, int size) { }
        public struct Entry
        {
            public const int ENTRY_SIZE = 28;
            public Entry(JetBrains.Metadata.Utils.IBinaryReader rdr) { }
            public uint AddressOfRawData { get; }
            public uint Characteristics { get; }
            public ushort MajorVersion { get; }
            public ushort MinorVersion { get; }
            public uint PointerToRawData { get; }
            public uint SizeOfData { get; }
            public uint TimeDateStamp { get; }
            public JetBrains.Metadata.Utils.PE.Directories.DebugType Type { get; }
            public JetBrains.Metadata.Utils.PE.Directories.DebugInfo GetEntry() { }
        }
    }
    public class DebugInfo
    {
        protected uint myAge;
        protected int myOffset;
        protected string myPdbFile;
        protected uint mySignature;
        public uint Age { get; }
        public int Offset { get; }
        public string PdbFile { get; }
        public uint Signature { get; }
        protected string ReadNullTerminatedString(JetBrains.Metadata.Utils.IBinaryReader reader) { }
    }
    public sealed class DebugInfo2 : JetBrains.Metadata.Utils.PE.Directories.DebugInfo
    {
        public DebugInfo2(JetBrains.Metadata.Utils.IBinaryReader stm) { }
        public System.DateTime Timestamp { get; }
    }
    public sealed class DebugInfo7 : JetBrains.Metadata.Utils.PE.Directories.DebugInfo
    {
        public DebugInfo7(JetBrains.Metadata.Utils.IBinaryReader stm) { }
        public System.Guid Stamp { get; }
    }
    public enum DebugType : uint
    {
        Unknown = 0u,
        COFF = 1u,
        Codeview = 2u,
        FPO = 3u,
        Misc = 4u,
        Exception = 5u,
        Fixup = 6u,
        OMAPtoSRC = 7u,
        OMAPfromSRC = 8u,
        Borland = 9u,
        Reserved10 = 10u,
        CLSID = 11u,
    }
    public class EntireResourceDirectory : JetBrains.Metadata.Utils.PE.Directories.PEDirectoryBase
    {
        public JetBrains.Metadata.Utils.PE.Directories.ResourceDirectory Root { get; }
        public void Dump(System.IO.TextWriter result) { }
        public override void Read(JetBrains.Metadata.Utils.IBinaryReader rdr, int size) { }
    }
    public sealed class MiscDebugInfo : JetBrains.Metadata.Utils.PE.Directories.DebugInfo
    {
        public MiscDebugInfo(JetBrains.Metadata.Utils.IBinaryReader stm) { }
    }
    public abstract class PEDirectoryBase
    {
        public abstract void Read(JetBrains.Metadata.Utils.IBinaryReader rdr, int size);
    }
    public class ResourceDataEntry
    {
        public ResourceDataEntry(JetBrains.Metadata.Utils.IBinaryReader reader, int baseOffset) { }
        public int Codepage { get; }
        public int OffsetToData { get; }
        public int Size { get; }
        public void Dump(System.IO.TextWriter result) { }
        public JetBrains.Metadata.Utils.IBinaryReader GetData(JetBrains.Metadata.Utils.PE.PEFile peFile) { }
    }
    public class ResourceDirectory
    {
        public ResourceDirectory(JetBrains.Metadata.Utils.IBinaryReader reader, int baseOffset) { }
        public int Characteristics { get; }
        public JetBrains.Metadata.Utils.PE.Directories.ResourceDirectoryEntry[] Entries { get; }
        public int MajorVersion { get; }
        public int MinorVersion { get; }
        public int NumberOfIdEntries { get; }
        public int NumberOfNamedEntries { get; }
        public int Timestamp { get; }
        public void Dump(System.IO.TextWriter result) { }
    }
    public class ResourceDirectoryEntry
    {
        public ResourceDirectoryEntry(JetBrains.Metadata.Utils.IBinaryReader reader, int baseOffset) { }
        public JetBrains.Metadata.Utils.PE.Directories.ResourceDataEntry DataEntry { get; }
        public JetBrains.Metadata.Utils.PE.Directories.ResourceDirectory Directory { get; }
        public int Id { get; }
        public string Name { get; }
        public JetBrains.Metadata.Utils.PE.Directories.ResourceDirectoryEntryNameType NameType { get; }
        public int Offset { get; }
        public void Dump(System.IO.TextWriter result, bool isTopLevel, int indent) { }
    }
    public enum ResourceDirectoryEntryNameType
    {
        Id = 0,
        String = 1,
    }
    public enum ResourceType
    {
        None = 0,
        Cursor = 1,
        Bitmap = 2,
        Icon = 3,
        Menu = 4,
        Dialog = 5,
        String = 6,
        FontDir = 7,
        Font = 8,
        Accelerator = 9,
        RcData = 10,
        MessageTable = 11,
        GroupCursor = 12,
        GroupIcon = 14,
        Version = 16,
        DlgInclude = 17,
        PlugPlay = 19,
        VxD = 20,
        AniCursor = 21,
        AniIcon = 22,
        Html = 23,
        Manifest = 24,
    }
}
namespace JetBrains.Metadata.Utils.TypeName
{
    
    public abstract class AbstractTypeNameParser<TType>
        where TType :  class
    {
        protected AbstractTypeNameParser([JetBrains.Annotations.NotNullAttribute()] string typeName) { }
        protected AbstractTypeNameParser([JetBrains.Annotations.NotNullAttribute()] string typeName, JetBrains.Metadata.Utils.TypeName.TypeNameParserArrayRanksOrder arrayRanksOrder) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected string TypeName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TType CreateArrayType(TType elementType, uint rank, uint[] sizes, int[] lBounds);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TType CreateArrayType(TType elementType);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TType CreatePointerType(TType elementType);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TType CreateReferenceType(TType elementType);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TType CreateTypeByNameAndAssembly(string typeName, JetBrains.Util.TextRange typeNameRange, string assemblyName, JetBrains.Util.TextRange assemblyNameRange, JetBrains.Util.TextRange assemblyFullNameRange, [JetBrains.Annotations.NotNullAttribute()] TType[] genericArguments);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TType CreateUnresolvedType([JetBrains.Annotations.NotNullAttribute()] string typeName, JetBrains.Util.TextRange typeNameRange);
        [JetBrains.Annotations.NotNullAttribute()]
        public TType Parse() { }
    }
    public class InvalidTypeNameException : System.Exception
    {
        public InvalidTypeNameException(string message) { }
        public InvalidTypeNameException(string message, System.Exception exInner) { }
    }
    public enum TypeNameParserArrayRanksOrder
    {
        MSIL = 0,
        CSHARP = 1,
    }
}
namespace System.GAC
{
    
    [System.FlagsAttribute()]
    public enum ASM_CACHE_FLAGS
    {
        ASM_CACHE_ZAP = 1,
        ASM_CACHE_GAC = 2,
        ASM_CACHE_DOWNLOAD = 4,
    }
    [System.FlagsAttribute()]
    public enum ASM_CMP_FLAGS
    {
        NAME = 1,
        MAJOR_VERSION = 2,
        MINOR_VERSION = 4,
        BUILD_NUMBER = 8,
        REVISION_NUMBER = 16,
        PUBLIC_KEY_TOKEN = 32,
        CULTURE = 64,
        CUSTOM = 128,
        ALL = 255,
        DEFAULT = 256,
    }
    [System.FlagsAttribute()]
    public enum ASM_DISPLAY_FLAGS
    {
        VERSION = 1,
        CULTURE = 2,
        PUBLIC_KEY_TOKEN = 4,
        PUBLIC_KEY = 8,
        CUSTOM = 16,
        PROCESSORARCHITECTURE = 32,
        LANGUAGEID = 64,
    }
    public enum ASM_NAME
    {
        ASM_NAME_PUBLIC_KEY = 0,
        ASM_NAME_PUBLIC_KEY_TOKEN = 1,
        ASM_NAME_HASH_VALUE = 2,
        ASM_NAME_NAME = 3,
        ASM_NAME_MAJOR_VERSION = 4,
        ASM_NAME_MINOR_VERSION = 5,
        ASM_NAME_BUILD_NUMBER = 6,
        ASM_NAME_REVISION_NUMBER = 7,
        ASM_NAME_CULTURE = 8,
        ASM_NAME_PROCESSOR_ID_ARRAY = 9,
        ASM_NAME_OSINFO_ARRAY = 10,
        ASM_NAME_HASH_ALGID = 11,
        ASM_NAME_ALIAS = 12,
        ASM_NAME_CODEBASE_URL = 13,
        ASM_NAME_CODEBASE_LASTMOD = 14,
        ASM_NAME_NULL_PUBLIC_KEY = 15,
        ASM_NAME_NULL_PUBLIC_KEY_TOKEN = 16,
        ASM_NAME_CUSTOM = 17,
        ASM_NAME_NULL_CUSTOM = 18,
        ASM_NAME_MVID = 19,
        ASM_NAME_MAX_PARAMS = 20,
    }
    public struct ASSEMBLY_INFO
    {
        public uint cbAssemblyInfo;
        public uint cchBuf;
        public uint dwAssemblyFlags;
        public string pszCurrentAssemblyPathBuf;
        public ulong uliAssemblySizeInKB;
    }
    public class AssemblyCache { }
    public enum CREATE_ASM_NAME_OBJ_FLAGS
    {
        CANOF_PARSE_DISPLAY_NAME = 1,
        CANOF_SET_DEFAULT_VALUES = 2,
    }
    public struct FUSION_INSTALL_REFERENCE
    {
        public uint cbSize;
        public uint dwFlags;
        public System.Guid guidScheme;
        public string szIdentifier;
        public string szNonCannonicalData;
    }
    [System.Runtime.InteropServices.GuidAttribute("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyCache { }
    public enum IASSEMBLYCACHE_INSTALL_FLAG
    {
        IASSEMBLYCACHE_INSTALL_FLAG_REFRESH = 1,
        IASSEMBLYCACHE_INSTALL_FLAG_FORCE_REFRESH = 2,
    }
    public enum IASSEMBLYCACHE_UNINSTALL_DISPOSITION
    {
        IASSEMBLYCACHE_UNINSTALL_DISPOSITION_UNINSTALLED = 1,
        IASSEMBLYCACHE_UNINSTALL_DISPOSITION_STILL_IN_USE = 2,
        IASSEMBLYCACHE_UNINSTALL_DISPOSITION_ALREADY_UNINSTALLED = 3,
        IASSEMBLYCACHE_UNINSTALL_DISPOSITION_DELETE_PENDING = 4,
        IASSEMBLYCACHE_UNINSTALL_DISPOSITION_HAS_INSTALL_REFERENCES = 5,
        IASSEMBLYCACHE_UNINSTALL_DISPOSITION_REFERENCE_NOT_FOUND = 6,
    }
    [System.Runtime.InteropServices.GuidAttribute("9E3AAEB4-D1CD-11D2-BAB9-00C04F8ECEAE")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyCacheItem { }
    [System.Runtime.InteropServices.GuidAttribute("21b8916c-f28e-11d2-a473-00c04f8ef448")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyEnum { }
    [System.Runtime.InteropServices.GuidAttribute("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyName { }
    [System.Runtime.InteropServices.GuidAttribute("56b1a988-7c0c-4aa2-8639-c3eb5a90226f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInstallReferenceEnum { }
    [System.Runtime.InteropServices.GuidAttribute("582dac66-e678-449f-aba6-6faaec8a9394")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInstallReferenceItem { }
    public enum QUERYASMINFO_FLAG
    {
        QUERYASMINFO_FLAG_VALIDATE = 1,
        QUERYASMINFO_FLAG_GETSIZE = 2,
    }
}