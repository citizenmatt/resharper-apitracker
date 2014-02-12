[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Application.Components
{
    
    public class ComponentContainer : JetBrains.Application.Components.IComponentContainer
    {
        public ComponentContainer(JetBrains.DataFlow.Lifetime lifetime, string id) { }
        public JetBrains.Application.Components.ComponentContainer Compose() { }
        public JetBrains.Application.Components.IValueResolveContext CreateResolveContext(JetBrains.Application.Components.IValueDescriptor requestingDescriptor) { }
        public JetBrains.Application.Components.ComponentContainer RegisterDescriptors(System.Collections.Generic.IList<JetBrains.Application.Components.IComponentDescriptor> descriptors) { }
        public JetBrains.Application.Components.ComponentContainer RegisterDescriptors(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IList<JetBrains.Application.Components.IComponentDescriptor> descriptors) { }
        public JetBrains.Application.Components.ComponentContainer RegisterResolver(JetBrains.Application.Components.IValueResolver resolver) { }
        public JetBrains.Application.Components.ComponentContainer RegisterSource(JetBrains.DataFlow.IViewable<System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IComponentDescriptor>> componentSource) { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
        public override string ToString() { }
    }
    public class static ComponentContainerEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TInterface GetComponent<TInterface>(this JetBrains.Application.Components.IComponentContainer container) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<TInterface> GetComponents<TInterface>(this JetBrains.Application.Components.IComponentContainer container) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IViewable<TInterface> GetViewable<TInterface>(this JetBrains.Application.Components.IComponentContainer container) { }
        public static bool HasComponent<TInterface>(this JetBrains.Application.Components.IComponentContainer container) { }
        public static JetBrains.Application.Components.ComponentContainer Register(this JetBrains.Application.Components.ComponentContainer container, [JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        public static JetBrains.Application.Components.ComponentContainer Register(this JetBrains.Application.Components.ComponentContainer container, [JetBrains.Annotations.NotNullAttribute()] object instance) { }
        public static JetBrains.Application.Components.ComponentContainer Register<T>(this JetBrains.Application.Components.ComponentContainer container, System.Func<JetBrains.Application.Components.IValueResolveContext, T> factory) { }
        public static JetBrains.Application.Components.ComponentContainer Register<T>(this JetBrains.Application.Components.ComponentContainer container) { }
        public static JetBrains.Application.Components.ComponentContainer Register<T>(this JetBrains.Application.Components.ComponentContainer container, JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TInterface TryGetComponent<TInterface>(this JetBrains.Application.Components.IComponentContainer container) { }
    }
    public enum ComponentInstantiation
    {
        Default = 0,
        WithEnvironment = 0,
        OnDemand = 1,
    }
    public class ComponentStorage : JetBrains.Application.Components.IValueResolver, System.IDisposable
    {
        public ComponentStorage([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public JetBrains.Application.Components.ComponentStorage AttachPolicy(JetBrains.Application.Components.IComponentAccessPolicy accessPolicy) { }
        public void Compose() { }
        public void Dispose() { }
        public JetBrains.Application.Components.ComponentStorage RegisterDescriptors(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IList<JetBrains.Application.Components.IComponentDescriptor> descriptors) { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>([JetBrains.Annotations.NotNullAttribute()] TRequest request, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IValueResolveContext context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueDescriptor> ResolveMultiple<TRequest>(TRequest request, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IValueResolveContext context) { }
        public override string ToString() { }
    }
    public enum ComponentStorageState
    {
        Initial = 0,
        Initialized = 1,
        Disposing = 2,
        Disposed = 3,
    }
    public class CompositeAccessPolicy : JetBrains.Application.Components.IComponentAccessPolicy
    {
        public CompositeAccessPolicy() { }
        public void Add(JetBrains.Application.Components.IComponentAccessPolicy accessPolicy) { }
        public void AssertModification() { }
    }
    public class DelegatingComponentContainer : JetBrains.Application.Components.IComponentContainer, JetBrains.Application.Components.IValueDescriptor, JetBrains.Application.Components.IValueResolver
    {
        public DelegatingComponentContainer(JetBrains.Application.Components.IValueResolveContext context, JetBrains.Application.Components.IValueResolveContext dynamicContext) { }
        public JetBrains.Application.Components.IValueResolveContext Context { get; }
        public JetBrains.Application.Components.IValueResolveContext CreateResolveContext(JetBrains.Application.Components.IValueDescriptor requestingDescriptor) { }
        public object GetValue() { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
        public override string ToString() { }
    }
    public class static DelegatingContainer
    {
        public static JetBrains.Application.Components.ComponentContainer ChainTo(this JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Components.IComponentContainer dynamicContainer) { }
    }
    public class DelegatingContainerValueResolver : JetBrains.Application.Components.IValueResolver
    {
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
    }
    public class DispatcherAccessPolicy : JetBrains.Application.Components.IComponentAccessPolicy
    {
        public DispatcherAccessPolicy(JetBrains.Threading.JetDispatcher dispatcher) { }
        public static JetBrains.Application.Components.DispatcherAccessPolicy Default { get; }
        public void AssertModification() { }
    }
    public class DynamicComponentDescriptor : JetBrains.Application.Components.IComponentDescriptor, JetBrains.Application.Components.IValueDescriptor
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Components.DynamicComponentDescriptor Instance;
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations() { }
        public object GetValue() { }
        public override string ToString() { }
    }
    public class EnumerableValueResolver : JetBrains.Application.Components.IValueResolver
    {
        public EnumerableValueResolver(JetBrains.Application.Components.ComponentStorage componentStorage, System.Collections.Generic.List<JetBrains.Application.Components.IValueResolver> linkedResolvers) { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
    }
    public class static FactoryComponentContainer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TInstance CreateInstance<TInstance>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer parent, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object CreateInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Type objecttype, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer parent, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static object CreateInstanceWithoutContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Type objecttype, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
    }
    public interface IComponentAccessPolicy
    {
        void AssertModification();
    }
    public interface IComponentContainer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Components.IValueResolveContext CreateResolveContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IValueDescriptor requestingDescriptor);
    }
    public interface IComponentDescriptor : JetBrains.Application.Components.IValueDescriptor
    {
        System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations();
    }
    public interface IValueDescriptor
    {
        [JetBrains.Annotations.NotNullAttribute()]
        object GetValue();
    }
    public interface IValueRegistration
    {
        bool Accepts(object request);
    }
    public interface IValueResolveContext
    {
        JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest registration);
    }
    public interface IValueResolver
    {
        JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IValueResolveContext context);
    }
    public class LazyValueResolver : JetBrains.Application.Components.IValueResolver
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Components.IValueDescriptor Create([JetBrains.Annotations.NotNullAttribute()] System.Type typeUnderLazy, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IValueDescriptor descriptorUnderLazy) { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Type TryExtractTypeUnderLazy([JetBrains.Annotations.CanBeNullAttribute()] System.Type typePossiblyLazy) { }
    }
    public class LifetimeValueResolver : JetBrains.Application.Components.IValueResolver
    {
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
    }
    public class LoggerValueResolver : JetBrains.Application.Components.IValueResolver
    {
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
    }
    public class ObjectComponentDescriptor : JetBrains.Application.Components.IComponentDescriptor, JetBrains.Application.Components.IValueDescriptor
    {
        public ObjectComponentDescriptor([JetBrains.Annotations.NotNullAttribute()] object instance) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations() { }
        public object GetValue() { }
        public override string ToString() { }
    }
    public class static SignatureResolution
    {
        public static object[] BindArguments(System.Collections.Generic.List<JetBrains.Application.Components.IValueDescriptor> argumentDescriptors) { }
        public static JetBrains.Application.Components.SignatureResolution.Binding BindToConstructor(this System.Type type, JetBrains.Application.Components.IValueResolveContext context) { }
        public static JetBrains.Application.Components.SignatureResolution.Binding BindToMethod(this System.Type type, string name, JetBrains.Application.Components.IValueResolveContext context) { }
        public static JetBrains.Application.Components.SignatureResolution.Binding BindToMethod(System.Reflection.MethodBase[] candidates, JetBrains.Application.Components.IValueResolveContext context, string name) { }
        public static object CreateInstance<T>(this JetBrains.Application.Components.IComponentContainer container) { }
        public static object CreateInstance(this JetBrains.Application.Components.IComponentContainer container, System.Type type) { }
        public static object CreateInstance(this JetBrains.Application.Components.SignatureResolution.Binding binding) { }
        public static object DynamicInvoke(this JetBrains.Application.Components.IComponentContainer container, System.Delegate function) { }
        public static void DynamicInvoke(this JetBrains.Application.Components.IComponentContainer container, System.Action action) { }
        public static void DynamicInvoke<T1>(this JetBrains.Application.Components.IComponentContainer container, System.Action<T1> action) { }
        public static void DynamicInvoke<T1, T2>(this JetBrains.Application.Components.IComponentContainer container, System.Action<T1, T2> action) { }
        public static TResult DynamicInvoke<TResult>(this JetBrains.Application.Components.IComponentContainer container, System.Func<TResult> action) { }
        public static TResult DynamicInvoke<TResult, T1>(this JetBrains.Application.Components.IComponentContainer container, System.Func<T1, TResult> action) { }
        public static TResult DynamicInvoke<TResult, T1, T2>(this JetBrains.Application.Components.IComponentContainer container, System.Func<T1, T2, TResult> action) { }
        public static TResult DynamicInvoke<TResult, T1, T2, T3>(this JetBrains.Application.Components.IComponentContainer container, System.Func<T1, T2, T3, TResult> action) { }
        public static TResult DynamicInvoke<TResult, T1, T2, T3, T4>(this JetBrains.Application.Components.IComponentContainer container, System.Func<T1, T2, T3, T4, TResult> action) { }
        public struct Binding
        {
            public readonly System.Collections.Generic.List<JetBrains.Application.Components.IValueDescriptor> ArgumentDescriptors;
            public readonly System.Reflection.MethodBase Method;
            public Binding(System.Reflection.MethodBase method, System.Collections.Generic.List<JetBrains.Application.Components.IValueDescriptor> argumentDescriptors) { }
        }
    }
    public abstract class SingletonComponentDescriptor : JetBrains.Application.Components.SingletonDescriptor
    {
        protected SingletonComponentDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer container, [JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Type Type { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations() { }
        public override string ToString() { }
    }
    public abstract class SingletonDescriptor : JetBrains.Application.Components.IComponentDescriptor, JetBrains.Application.Components.IValueDescriptor, System.IDisposable
    {
        protected SingletonDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer container) { }
        public void AddExceptionData(System.Exception ex) { }
        protected abstract object CreateInstance(JetBrains.Application.Components.IValueResolveContext context);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations();
        public object GetValue() { }
        protected void RegisterOwnedObject(System.IDisposable ownedObject) { }
        protected void SetState(JetBrains.Application.Components.SingletonDescriptor.ComponentState state) { }
        public override string ToString() { }
        protected enum ComponentState
        {
            Null = 0,
            Initializing = 1,
            Initialized = 2,
            Corrupted = 3,
            Disposing = 4,
            Disposed = 5,
        }
    }
    public class SingletonFactoryComponentDescriptor<T> : JetBrains.Application.Components.SingletonComponentDescriptor
    
    {
        public SingletonFactoryComponentDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer container, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.Components.IValueResolveContext, T> factory) { }
        protected override object CreateInstance(JetBrains.Application.Components.IValueResolveContext context) { }
    }
    public class SingletonTypeComponentDescriptor : JetBrains.Application.Components.SingletonComponentDescriptor
    {
        public SingletonTypeComponentDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer container, [JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        protected override object CreateInstance(JetBrains.Application.Components.IValueResolveContext context) { }
    }
    public class TaggedRegistration : JetBrains.Application.Components.IValueRegistration
    {
        public TaggedRegistration([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IValueRegistration registration, [JetBrains.Annotations.NotNullAttribute()] object tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Components.IValueRegistration Registration { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public object Tag { get; }
        public bool Accepts(object request) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class TaggedRequest
    {
        public TaggedRequest([JetBrains.Annotations.NotNullAttribute()] object request, [JetBrains.Annotations.NotNullAttribute()] object tag) { }
        public object Request { get; }
        public object Tag { get; }
    }
    public class TypeRegistration : JetBrains.Application.Components.IValueRegistration
    {
        public TypeRegistration([JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        public System.Type Type { get; }
        public bool Accepts(object request) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class UnidentifiedComponentDescriptor : JetBrains.Application.Components.IComponentDescriptor, JetBrains.Application.Components.IValueDescriptor
    {
        public static JetBrains.Application.Components.UnidentifiedComponentDescriptor Instance;
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations() { }
        public object GetValue() { }
        public override string ToString() { }
    }
    public class ViewableValueResolver : JetBrains.Application.Components.IValueResolver
    {
        public ViewableValueResolver(JetBrains.Application.Components.ComponentStorage componentStorage, System.Collections.Generic.List<JetBrains.Application.Components.IValueResolver> linkedResolvers) { }
        public JetBrains.Application.Components.IValueDescriptor Resolve<TRequest>(TRequest request, JetBrains.Application.Components.IValueResolveContext context) { }
    }
}
namespace JetBrains.Application.Extensibility
{
    
    public class static CatalogueComponents
    {
        public static JetBrains.Application.Components.ComponentContainer RegisterCatalogue(this JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Parts.IPartsSelector selector, params JetBrains.Application.Parts.IPartsCatalogueFilter[] filters) { }
        public static JetBrains.Application.Components.ComponentContainer RegisterCatalogue(this JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet) { }
        public static JetBrains.Application.Components.ComponentContainer RegisterCatalogue<TPartAttribute>(this JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, params JetBrains.Application.Parts.IPartsCatalogueFilter[] filters)
            where TPartAttribute : JetBrains.Application.Parts.PartAttribute { }
        public static JetBrains.Application.Components.ComponentContainer RegisterCatalogue<TPartAttribute>(this JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Parts.IPartsSelector selector, params JetBrains.Application.Parts.IPartsCatalogueFilter[] filters)
            where TPartAttribute : JetBrains.Application.Parts.PartAttribute { }
    }
    public class CatalogueComponentSource : JetBrains.DataFlow.IViewable<System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IComponentDescriptor>>
    {
        public CatalogueComponentSource(JetBrains.Application.Components.ComponentContainer container, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartsSelector selector, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogueFilter> filters) { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IComponentDescriptor>> viewer) { }
    }
    public class static FeaturePartsExtensions
    {
        public static System.Collections.Generic.IEnumerable<TResultPart> FilterFactoryPattern<TFeatureFactory, TResultPart>(this System.Collections.Generic.IEnumerable<TFeatureFactory> componentsEnumerable, System.Func<TFeatureFactory, TResultPart> creator)
            where TFeatureFactory :  class
            where TResultPart :  class { }
        public static System.Collections.Generic.IEnumerable<TFeaturePart> FilterOverriddenComponents<TFeaturePart>(this System.Collections.Generic.IList<TFeaturePart> components)
            where TFeaturePart :  class { }
        public static System.Collections.Generic.IEnumerable<TObj> FilterOverriddenComponents<TObj, TFactory>(this System.Collections.Generic.IList<TObj> components, System.Func<TObj, TFactory> getFactory)
            where TObj :  class
            where TFactory :  class { }
    }
    public class PartComponentDescriptor : JetBrains.Application.Components.SingletonDescriptor
    {
        public PartComponentDescriptor(JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Parts.PartCatalogueType part) { }
        public JetBrains.Application.Parts.PartCatalogueType Part { get; }
        protected override object CreateInstance(JetBrains.Application.Components.IValueResolveContext context) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations() { }
        public override string ToString() { }
    }
    public class PartMemberComponentDescriptor : JetBrains.Application.Components.SingletonDescriptor
    {
        public PartMemberComponentDescriptor(JetBrains.Application.Components.ComponentContainer container, JetBrains.Application.Parts.PartCatalogueType part, JetBrains.Application.Parts.PartCatalogueTypeMember member) { }
        protected override object CreateInstance(JetBrains.Application.Components.IValueResolveContext context) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.Application.Components.IValueRegistration> GetRegistrations() { }
        public override string ToString() { }
    }
    public class SplittedComponentContainer<TDefinition, TDefinitionAttribute>
        where TDefinition :  class
        where TDefinitionAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public SplittedComponentContainer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.DataFlow.IViewable<TDefinition> definitions, System.Linq.Expressions.Expression<System.Func<TDefinitionAttribute, System.Type>> property) { }
        public JetBrains.DataFlow.ViewableCollection<TDefinition> Definitions { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TDefinition, System.Collections.Generic.IEnumerable<T>>> GetMultipleServices<T>()
            where T :  class { }
        public System.Collections.Generic.IEnumerable<T> GetMultipleServicesFromAll<T>()
            where T :  class { }
        public T GetService<T, TDef>()
            where T :  class
            where TDef : TDefinition { }
        public T GetService<T>(TDefinition definition)
            where T :  class { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TDefinition, T>> GetServices<T>()
            where T :  class { }
        public System.Collections.Generic.IEnumerable<T> GetServices<T>(TDefinition definition)
            where T :  class { }
        public System.Collections.Generic.IEnumerable<T> GetServicesFromAll<T>()
            where T :  class { }
        public bool HasService<T>(TDefinition definition)
            where T :  class { }
        protected virtual void InitializeDefinition(JetBrains.DataFlow.Lifetime lifetime, TDefinition definition, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer) { }
        public T TryGetService<T, TDef>()
            where T :  class
            where TDef : TDefinition { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T TryGetService<T>(TDefinition definition)
            where T :  class { }
    }
    public class TypesInstantiator<T, TAttribute> : JetBrains.DataFlow.IViewable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T :  class
        where TAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public TypesInstantiator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.ISorter<T> sorter = null) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, T> viewer) { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, T, TAttribute> viewer) { }
    }
    public class TypeView<TAttribute> : JetBrains.DataFlow.IViewable<System.Type>
        where TAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public TypeView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, System.Type> viewer) { }
    }
}
namespace JetBrains.Application.Parts
{
    
    public class AllPartsSelector : JetBrains.Application.Parts.IPartsSelector
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> SelectParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
    }
    public class AssemblyPartsCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        public AssemblyPartsCatalogue(System.Reflection.Assembly assembly, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
    }
    public class AttributeIndexedPartsCatalogue : JetBrains.Util.UserDataHolder, JetBrains.Application.Parts.IAttributedPartsCatalogue, JetBrains.Application.Parts.IPartsCatalogue
    {
        public AttributeIndexedPartsCatalogue(JetBrains.Application.Parts.IPartsCatalogue catalogue) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Type attributeType) { }
    }
    public class static CachedPartCatalogueUtil
    {
        public static JetBrains.Application.Parts.IPartsCatalogue CreateMetadataPartsCatalogueCached(System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> locations) { }
    }
    public class CatalogueAttributeFilter : JetBrains.Application.Parts.IPartsCatalogueFilter
    {
        public CatalogueAttributeFilter(System.Type attributeType) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(JetBrains.Application.Parts.IPartsCatalogue catalogue) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
    }
    public class CatalogueAttributeFilter<TAttribute> : JetBrains.Application.Parts.CatalogueAttributeFilter
        where TAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public CatalogueAttributeFilter() { }
    }
    public class static CatalogueAttributePartsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetPartsWithAttribute<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Parts.IPartsCatalogue thіs)
            where TAttribute : JetBrains.Application.Parts.PartAttribute { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.PartCatalogueAttribute GetSingleAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Parts.PartCatalogueType thіs, [JetBrains.Annotations.NotNullAttribute()] System.Type typeAttribute) { }
    }
    public class CatalogueIntersectFilter : JetBrains.Application.Parts.IPartsCatalogueFilter
    {
        public CatalogueIntersectFilter(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogueFilter> filters) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(JetBrains.Application.Parts.IPartsCatalogue catalogue) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
    }
    public class CataloguePredicateFilter : JetBrains.Application.Parts.IPartsCatalogueFilter
    {
        public CataloguePredicateFilter(System.Func<JetBrains.Application.Parts.PartCatalogueType, bool> predicate) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(JetBrains.Application.Parts.IPartsCatalogue catalogue) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
    }
    public class CataloguesChanged
    {
        public CataloguesChanged(JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> addedCatalogues, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> removingCatalogues) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> AddedCatalogues { get; }
        public JetBrains.Application.Parts.IPartsCatalogueSet CatalogueSet { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> RemovingCatalogues { get; }
    }
    public class CompositePartsCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        public CompositePartsCatalogue(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> catalogues) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
    }
    public class FilteredCatalogue : JetBrains.Util.UserDataHolder, JetBrains.Application.Parts.IAttributedPartsCatalogue, JetBrains.Application.Parts.IPartsCatalogue
    {
        public FilteredCatalogue(JetBrains.Application.Parts.IPartsCatalogue catalogue, JetBrains.Application.Parts.IPartsCatalogueFilter filter) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Type attributeType) { }
    }
    public class FlyweightPartFactory : JetBrains.Application.Parts.IPartCatalogueFactory
    {
        public FlyweightPartFactory() { }
        public JetBrains.Application.Parts.PartCatalogueAssembly CreateAssembly(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, string location, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute>> attributes) { }
        public JetBrains.Application.Parts.PartCatalogueAssembly CreateAssembly(string assemblyName, string location, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute>> attributes) { }
        public JetBrains.Application.Parts.PartCatalogueAttribute CreateAttribute(JetBrains.Application.Parts.PartCatalogueType type, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, object>> properties) { }
        public JetBrains.Application.Parts.PartCatalogueType CreateType(string fullName, JetBrains.Application.Parts.PartCatalogueAssembly assembly, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueType>> baseTypes, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute>> attributes, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueTypeMember>> members) { }
    }
    public interface IAttributedPartsCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Type attributeType);
    }
    public interface IPartCatalogueFactory
    {
        JetBrains.Application.Parts.PartCatalogueAssembly CreateAssembly(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, string location, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute>> attributes);
        JetBrains.Application.Parts.PartCatalogueAssembly CreateAssembly(string assemblyName, string location, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute>> attributes);
        JetBrains.Application.Parts.PartCatalogueAttribute CreateAttribute(JetBrains.Application.Parts.PartCatalogueType type, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, object>> properties);
        JetBrains.Application.Parts.PartCatalogueType CreateType(string fullName, JetBrains.Application.Parts.PartCatalogueAssembly assembly, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueType>> baseTypes, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute>> attributes, System.Func<System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueTypeMember>> members);
    }
    public interface IPartsCatalogue
    {
        System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies();
        System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts();
    }
    public interface IPartsCatalogueFilter
    {
        System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(JetBrains.Application.Parts.IPartsCatalogue catalogue);
        System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts);
    }
    public interface IPartsCatalogueSet
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IViewable<JetBrains.Application.Parts.IPartsCatalogue> Catalogues { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IViewable<JetBrains.Application.Parts.IPartsCatalogue> CataloguesPreview { get; }
    }
    public interface IPartsSelector
    {
        System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> SelectParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts);
    }
    public class LeafPartsSelector : JetBrains.Application.Parts.IPartsSelector
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> SelectParts(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
    }
    public class MetadataPartsCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.CompoundException ReferencedAssemblyResolutionFailures;
        public MetadataPartsCatalogue([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> assemblyLocations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartCatalogueFactory typeFactory, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Metadata.Reader.API.IAssemblyResolver> FCreateAdditionalResolvers = null) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public abstract class PartAttribute : System.Attribute { }
    public class PartAttributeProperty
    {
        public PartAttributeProperty(string name, object value) { }
        public string Name { get; }
        public object Value { get; }
        public bool Equals(JetBrains.Application.Parts.PartAttributeProperty other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class PartCatalogueAssembly : System.IEquatable<JetBrains.Application.Parts.PartCatalogueAssembly>
    {
        public PartCatalogueAssembly([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, JetBrains.Util.FileSystemPath location) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath Location { get; }
        public void AddAttributes(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> attributes) { }
        public System.Type Bind(JetBrains.Application.Parts.PartCatalogueType type) { }
        public bool Equals(JetBrains.Application.Parts.PartCatalogueAssembly other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes(System.Type attributeType) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes<TAttributeType>()
            where TAttributeType : System.Attribute { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes() { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class PartCatalogueAttribute
    {
        public PartCatalogueAttribute(JetBrains.Application.Parts.PartCatalogueType type, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartAttributeProperty> properties) { }
        public JetBrains.Application.Parts.PartCatalogueType Type { get; }
        public bool Equals(JetBrains.Application.Parts.PartCatalogueAttribute other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartAttributeProperty> GetProperties() { }
        public T GetProperty<T>(string name) { }
        public TConvertedValue GetProperty<TSource, TValue, TConvertedValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression) { }
        public TValue GetProperty<TSource, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression) { }
        public object GetProperty(string name) { }
        public T GetPropertyOrDefault<T>(string name, T defaultValue) { }
        public TConvertedValue GetPropertyOrDefault<TSource, TValue, TConvertedValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression, TConvertedValue defaultValue = null) { }
        public TValue GetPropertyOrDefault<TSource, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression, TValue defaultValue = null) { }
        public override string ToString() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TValue TryGetProperty<TValue>([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public bool TryGetProperty<T>(string name, out T value) { }
        public bool TryGetProperty<TSource, TValue, TConvertedValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression, out TConvertedValue value) { }
        public bool TryGetProperty<TSource, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression, out TValue value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TValue TryGetProperty<TSource, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> expression) { }
    }
    public class PartCatalogueType : System.IEquatable<JetBrains.Application.Parts.PartCatalogueType>
    {
        public PartCatalogueType(string name, string nameQualifier, JetBrains.Application.Parts.PartCatalogueAssembly assembly, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> baseTypes) { }
        public JetBrains.Application.Parts.PartCatalogueAssembly Assembly { get; }
        public string AssemblyQualifiedName { get; }
        public JetBrains.Application.Parts.PartCatalogueType.BaseTypesCollection BaseTypes { get; }
        public string FullName { get; }
        public string LocalName { get; }
        public string NameQualifier { get; }
        public string ShortName { get; }
        public void AddAttributes(System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute> attributes) { }
        public void AddExceptionData(System.Exception obj) { }
        public void AddMembers(System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueTypeMember> members) { }
        public System.Type Bind() { }
        public bool Equals(JetBrains.Application.Parts.PartCatalogueType other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes(System.Type attributeType) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes<TAttribute>()
            where TAttribute : System.Attribute { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes() { }
        public override int GetHashCode() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueTypeMember> GetMembers() { }
        public override string ToString() { }
        public System.Type TryGetBoundType() { }
        public struct BaseTypesCollection : System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType>, System.Collections.IEnumerable
        {
            public BaseTypesCollection(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> baseTypes) { }
            public JetBrains.Application.Parts.PartCatalogueType.BaseTypesCollection.Enumerator GetEnumerator() { }
            public struct Enumerator : System.Collections.Generic.IEnumerator<JetBrains.Application.Parts.PartCatalogueType>, System.Collections.IEnumerator, System.IDisposable
            {
                public Enumerator(object baseTypes) { }
                public JetBrains.Application.Parts.PartCatalogueType Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
                public void Reset() { }
            }
        }
    }
    public class PartCatalogueTypeMember
    {
        public PartCatalogueTypeMember(string name, System.Collections.Generic.IList<JetBrains.Application.Parts.PartCatalogueType> parameterTypes, JetBrains.Application.Parts.PartCatalogueType valueType) { }
        public string Name { get; }
        public System.Collections.Generic.IList<JetBrains.Application.Parts.PartCatalogueType> ParameterTypes { get; }
        public JetBrains.Application.Parts.PartCatalogueType ValueType { get; }
        public void AddAttributes(System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueAttribute> attributes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes(System.Type attributeType) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes<TAttribute>()
            where TAttribute : System.Attribute { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAttribute> GetAttributes() { }
    }
    public class static PartHelpers
    {
        public static JetBrains.Application.Parts.PartCatalogueAssembly CreateAssembly(JetBrains.Application.Parts.IPartCatalogueFactory typeFactory, JetBrains.Metadata.Reader.API.IMetadataTypeInfo type) { }
        public static JetBrains.Application.Parts.PartCatalogueAssembly CreateAssembly(JetBrains.Application.Parts.IPartCatalogueFactory typeFactory, System.Reflection.Assembly assembly) { }
        public static JetBrains.Application.Parts.PartCatalogueAttribute CreatePartAttribute(object attributeInstance, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public static JetBrains.Application.Parts.PartCatalogueAttribute CreatePartAttribute(JetBrains.Metadata.Reader.API.IMetadataCustomAttribute attribute, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public static JetBrains.Metadata.Reader.Impl.CombiningAssemblyResolver CreateResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> assembliesCurrent, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Metadata.Reader.API.IAssemblyResolver> FCreateAdditionalResolvers, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.CompoundException resolveerrors) { }
        public static JetBrains.Application.Parts.PartCatalogueType CreateType(JetBrains.Metadata.Reader.API.IMetadataClassType type, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public static JetBrains.Application.Parts.PartCatalogueType CreateType(JetBrains.Metadata.Reader.API.IMetadataTypeInfo type, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public static JetBrains.Application.Parts.PartCatalogueType CreateType(JetBrains.Application.Parts.PartCatalogueAssembly assembly, System.Type type, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public static JetBrains.Application.Parts.PartCatalogueType CreateType(System.Type type, JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public static System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueType> GetBaseTypes(JetBrains.Application.Parts.IPartCatalogueFactory typeFactory, System.Type type) { }
        public static System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueType> GetBaseTypes(JetBrains.Application.Parts.IPartCatalogueFactory typeFactory, JetBrains.Metadata.Reader.API.IMetadataTypeInfo type) { }
        public static System.Collections.Generic.ICollection<JetBrains.Application.Parts.PartCatalogueType> GetBaseTypes(JetBrains.Application.Parts.IPartCatalogueFactory typeFactory, JetBrains.Metadata.Reader.API.IMetadataClassType type) { }
        public static bool HasPartAttribute(JetBrains.Metadata.Reader.API.IMetadataEntity metadata) { }
        public static bool HasPartAttribute(System.Reflection.ICustomAttributeProvider type) { }
        public static bool IsAttributeOfType(JetBrains.Application.Parts.PartCatalogueAttribute attribute, string assemblyQualifiedName) { }
        public static bool IsPartAttribute(object attributeInstance) { }
        public static bool IsPartAttribute(JetBrains.Metadata.Reader.API.IMetadataCustomAttribute attributeMetadata) { }
    }
    public class static PartsCatalogueMetadataKeys
    {
        public static readonly JetBrains.Util.Key<object> SingleAndNotLiveComposition;
    }
    public class static PartsCatalogueSerializer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Parts.IPartsCatalogue ReadCatalogue(System.IO.Stream stream) { }
        public static void SerializeCatalogue(JetBrains.Application.Parts.IPartsCatalogue partsCatalogue, System.IO.Stream stream) { }
    }
    public class PartsCatalogueSet : JetBrains.Application.Parts.IPartsCatalogueSet, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue>, System.Collections.IEnumerable
    {
        public PartsCatalogueSet(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IViewable<JetBrains.Application.Parts.IPartsCatalogue> Catalogues { get; }
        public JetBrains.DataFlow.IViewable<JetBrains.Application.Parts.IPartsCatalogue> CataloguesPreview { get; }
        public void Add(params JetBrains.Application.Parts.IPartsCatalogue[] catalogues) { }
        public void Add([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, params JetBrains.Application.Parts.IPartsCatalogue[] catalogues) { }
        public void AddCatalogues(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> catalogues) { }
        public System.Collections.Generic.IEnumerator<JetBrains.Application.Parts.IPartsCatalogue> GetEnumerator() { }
        public void Remove(params JetBrains.Application.Parts.IPartsCatalogue[] catalogues) { }
        public void RemoveCatalogues(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.IPartsCatalogue> catalogues) { }
    }
    public class static PartsSelector
    {
        public static readonly JetBrains.Application.Parts.IPartsSelector All;
        public static readonly JetBrains.Application.Parts.IPartsSelector Default;
        public static readonly JetBrains.Application.Parts.IPartsSelector Leafs;
    }
    public class ReflectionPartsCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        public ReflectionPartsCatalogue([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> assemblyLocations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Parts.IPartCatalogueFactory typeFactory) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
    }
    public class SerializedCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        public SerializedCatalogue(System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> assemblies, System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> parts) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueAssembly> GetAssemblies() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Parts.PartCatalogueType> GetParts() { }
    }
    public class static SerializedCatalogueConstants
    {
        public const uint VERSION = 1u;
    }
    public enum SerializedCatalogueEntryKind
    {
        EOF = 0,
        ASSEMBLY = 1,
        TYPE = 2,
        ATTRIBUTE = 3,
        MEMBER = 4,
        CATALOGUE = 5,
        ASSEMBLY_ATTRIBUTES = 6,
    }
    public class SerializedCatalogueReader
    {
        public SerializedCatalogueReader(System.IO.BinaryReader reader) { }
        public System.Collections.Generic.IList<JetBrains.Application.Parts.PartCatalogueAssembly> ReadAssemblyList() { }
        public System.Collections.Generic.IList<JetBrains.Application.Parts.PartCatalogueAttribute> ReadAttributeList() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Parts.IPartsCatalogue ReadCatalogueFile() { }
        public System.Collections.Generic.IList<JetBrains.Application.Parts.PartCatalogueTypeMember> ReadMembersList() { }
        public System.Collections.Generic.IList<JetBrains.Application.Parts.PartAttributeProperty> ReadPropertyList() { }
        public System.Collections.Generic.IList<JetBrains.Application.Parts.PartCatalogueType> ReadTypeList() { }
    }
    public class SerializedCatalogueWriter
    {
        public SerializedCatalogueWriter(System.IO.BinaryWriter writer) { }
        public void SerializePartsCatalogue(JetBrains.Application.Parts.IPartsCatalogue partsCatalogue) { }
        public void SerializeType(JetBrains.Application.Parts.PartCatalogueType type) { }
        public void WriteAssembly(JetBrains.Application.Parts.PartCatalogueAssembly assembly) { }
        public void WriteAssemblyAttributes(JetBrains.Application.Parts.PartCatalogueAssembly assembly) { }
        public void WriteAssemblyRef(JetBrains.Application.Parts.PartCatalogueAssembly assembly) { }
        public void WriteAttributeRef(JetBrains.Application.Parts.PartCatalogueAttribute attribute) { }
        public void WriteEntryKind(JetBrains.Application.Parts.SerializedCatalogueEntryKind entryKind) { }
        public void WriteEOF() { }
        public void WriteHeader() { }
        public void WriteList<T>(System.Collections.Generic.IEnumerable<T> items, System.Action<T> itemWriter) { }
        public void WriteMemberRef(JetBrains.Application.Parts.PartCatalogueTypeMember member) { }
        public void WritePartsCatalogue(JetBrains.Application.Parts.IPartsCatalogue catalogue) { }
        public void WriteTypeRef(JetBrains.Application.Parts.PartCatalogueType type) { }
    }
    public class TypesPartsCatalogue : JetBrains.Application.Parts.IPartsCatalogue
    {
        public TypesPartsCatalogue([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<System.Type> types) { }
        public TypesPartsCatalogue([JetBrains.Annotations.NotNullAttribute()] params System.Type[] types) { }
    }
}